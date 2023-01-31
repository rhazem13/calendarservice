using calendarservice.Services.CalendarEntryService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//adding cors
builder.Services.AddCors();
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
