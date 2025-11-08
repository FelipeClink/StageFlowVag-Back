using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Application.Services;
using StageFlowVag.Domain.Interfaces;
using StageFlowVag.Repository;
using StageFlowVag.Repository.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configurar DbContext com PostgreSQL
builder.Services.AddDbContext<StageFlowVagDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Registrar AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());  // Isso irá escanear todos os assemblies e mapear os profiles.

// Registrar os Controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrar os Repositories
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ISolicitacaoRepository, SolicitacaoRepository>();
builder.Services.AddScoped<IInsumoRepository, InsumoRepository>();
builder.Services.AddScoped<IBlocoRepository, BlocoRepository>();
builder.Services.AddScoped<IAtendimentoDepartamentoRepository, AtendimentoDepartamentoRepository>();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

// Registrar os Services
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ISolicitacaoService, SolicitacaoService>();
builder.Services.AddScoped<IInsumoService, InsumoService>();
builder.Services.AddScoped<IBlocoService, BlocoService>();
builder.Services.AddScoped<IAtendimentoDepartamentoService, AtendimentoDepartamentoService>();

var app = builder.Build();

// Configuração Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
