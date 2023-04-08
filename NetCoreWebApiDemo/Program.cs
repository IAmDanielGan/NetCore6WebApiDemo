using NetCoreWebApiDemo.Utility.Swagger;
using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Knowledge points: Solve coding problems, garbled characters
builder.Services.AddControllers()
    .AddJsonOptions(
    options=>{
        options.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    typeof(ApiVersions).GetEnumNames().ToList().ForEach(version => {                                    //Show differen version control
        options.SwaggerDoc(version, new Microsoft.OpenApi.Models.OpenApiInfo()
        {
            Title = $"{version}:API",
            Version = version,
            Description = $"Common Version in Core API version{version}"
        });
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        foreach(string version in typeof(ApiVersions).GetEnumNames())
        {
            options.SwaggerEndpoint($"/swagger/{version}/swagger.json",$"Version:{version}");                //Show differen version
        }
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
