using calendarservice.Data;
using calendarservice.Services.CalendarEntryService;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//adding cors
builder.Services.AddCors();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("zoma")));
//customs
builder.Services.AddScoped<ICalendarEntryService,CalendarEntryService>();
//
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.UseCors(x=>x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
app.Run();
