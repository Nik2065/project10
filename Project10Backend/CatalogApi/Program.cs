var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.MapGet("/", () => "Hello World!");

app.Run();

