using Arnab.CustomPrompt.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapPromptApi();
app.Run();