using OmniJournal;
using OmniJournal.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add TrackerFactory to the DI container
//builder.Services.AddSingleton<ITrackerFactory, TrackerFactory>();
builder.Services.AddAbstractFactory<ITracker, Tracker<int>>();

//// Use the trackerFactory to create instances of ITracker
//var trackerFactory = app.Services.GetRequiredService<IAbstractFactory<Tracker<object>>>();
//var tracker = trackerFactory.Create();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.SetUpApiSample();

app.Run();
