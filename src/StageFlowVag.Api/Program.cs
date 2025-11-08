using Microsoft.EntityFrameworkCore;
using StageFlowVag.Domain.Interfaces;
using StageFlowVag.Repository;
using StageFlowVag.Repository.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configurar DbContext com PostgreSQL
builder.Services.AddDbContext<StageFlowVagDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ISolicitacaoRepository, SolicitacaoRepository>();
builder.Services.AddScoped<IInsumoRepository, InsumoRepository>();
builder.Services.AddScoped<IBlocoRepository, BlocoRepository>();
builder.Services.AddScoped<IAtendimentoDepartamentoRepository, AtendimentoDepartamentoRepository>();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();