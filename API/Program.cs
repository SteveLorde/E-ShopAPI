using System.Text;
using System.Text.Json.Serialization;
using API.Data;
using API.Services.Authentication;
using API.Services.Images;
using API.Services.JWT;
using API.Services.NewsRepository;
using API.Services.ProductsRepository;
using API.Services.StartupService;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IAuthentication,Authentication>();
builder.Services.AddScoped<IJWT,Jwt>();
builder.Services.AddScoped<IProductsRepository,ProductsRepository>();
builder.Services.AddScoped<I_ImageService,ImageService>();
builder.Services.AddScoped<INewsRepository,NewsRepository>();
builder.Services.AddScoped<Startup>();
builder.Services.AddAutoMapper(typeof(Program));
    /*
builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(options => {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "your-issuer",
            ValidAudience = "your-audience",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("V4XnjsgnRQuUecN27lwoCB82i4AbDMoX1GIFLbtolN4P8P18IRXFVLojx4vwLi7"))
        };
    });
    */
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var servicescope = app.Services.CreateScope();
var services = servicescope.ServiceProvider;
var startupservice = services.GetRequiredService<Startup>();
startupservice.ExecuteServices();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors( x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowAnyMethod());
app.UseHttpsRedirection();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "Storage")),
    RequestPath = "/storage"
});
/*
app.UseAuthentication();
app.UseAuthorization();
*/
app.MapControllers();
app.Run();