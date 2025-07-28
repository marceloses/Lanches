using Lanches.Models;
using Microsoft.EntityFrameworkCore;

/* Entity FrameworkCore / Ele tem 2  Classes DbContex / DbSet
 * Classe DbContext 
 * Conexão com banco de dados
 * Operações de dados 
 * Consulta e persistencias
 * Mapeamento de dados
 * Gestões de Tranações
 * 
 * DbSet 
 * Coleção para Entidade do modelo
 * */

namespace Lanches.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }

    }
}
