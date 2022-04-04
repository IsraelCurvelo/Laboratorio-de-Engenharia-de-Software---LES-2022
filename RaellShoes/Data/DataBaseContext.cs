using Microsoft.EntityFrameworkCore;
using RaellShoes.Models.Clientes;
using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using RaellShoes.Models.NN;

namespace RaellShoes.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }
       
        public DataBaseContext (DbContextOptions<DataBaseContext> options): base(options) {  }    
   
        public DbSet<Cliente> Cliente { get; set; }  
        
        public DbSet<Usuario> Usuario { get; set; }   
        
        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Cartao> Cartao { get; set; }

        public DbSet<Log> Log { get; set; }

        public DbSet<Produto> Produto { get; set; } 

        public DbSet<Carrinho> Carrinho { get; set; }

        public DbSet<ProdutoCliente> ProdutoCliente { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

    }
}
