var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/users", 
           () => 
           Results.Ok(new Todo(Guid.NewGuid(), "Teste de Tarefas", false)));
app.Run();
