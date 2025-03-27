using Telegram.Bot;

var bot = new TelegramBotClient("7455362319:AAEX546zffA3eIEpdz7t0tgJcGhqUNHsFuw");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/input_message", async (string message) =>
{
    await bot.SendTextMessageAsync(1121590497, message); // 1121590497 это мой тг-айди
    Console.WriteLine("Сообщение отправлено!");
})
.WithName("MessageToTeleBot")
.WithOpenApi();

app.Run();