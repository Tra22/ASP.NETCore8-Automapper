using AutoMapper;
using AutomapperWebAPIProject.dto;
using AutomapperWebAPIProject.entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/users", static (IMapper mapper) =>
{
    var users =  Enumerable.Range(1, 5).Select(static index =>
        new UserEntity
        (
            Guid.NewGuid().ToString(),
            $"FirstName {index}",
            $"LastName {index}",
            Random.Shared.Next(18, 60),
            $"firstname.lastname.{index}@gmail.com"
        ))
        .ToArray();
    // var users =  Enumerable.Range(1, 5).Select(static index =>
    //     new DerivedSource
    //     (
    //         Guid.NewGuid().ToString(),
    //         $"FirstName {index}",
    //         $"LastName {index}",
    //         Random.Shared.Next(18, 60),
    //         $"firstname.lastname.{index}@gmail.com",
    //         $"DerivedProperty {index}"
    //     ))
    //     .ToArray();
    return mapper.Map<UserDto[]>(users);
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();