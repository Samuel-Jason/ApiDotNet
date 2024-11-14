var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os ao cont�iner
builder.Services.AddControllers(); // Necess�rio para habilitar controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura o pipeline de requisi��es HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapeia os controllers para que o Swagger possa reconhec�-los
app.MapControllers();

app.Run();
