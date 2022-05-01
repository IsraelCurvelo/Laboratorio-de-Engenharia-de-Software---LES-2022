﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RaellShoes.Data;

namespace RaellShoes.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RaellShoes.Models.Administrador.Carrinho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("CupomId");

                    b.Property<int>("EnderecoEntregaId");

                    b.Property<double>("ValorFrete");

                    b.Property<double>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("CupomId");

                    b.HasIndex("EnderecoEntregaId");

                    b.ToTable("Carrinho");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Cupom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<string>("Codigo")
                        .IsRequired();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<double>("Desconto");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<bool>("Promocional");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Cupom");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.FichaTecnica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Altura");

                    b.Property<string>("Cuidados")
                        .IsRequired();

                    b.Property<int>("GarantiaMeses");

                    b.Property<string>("Limpeza")
                        .IsRequired();

                    b.Property<string>("Material")
                        .IsRequired();

                    b.Property<string>("Palmilha")
                        .IsRequired();

                    b.Property<string>("Solado")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("FichaTecnica");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CNPJ")
                        .IsRequired();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.GrupoPrecificacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<int>("MargemMax");

                    b.Property<int>("MargemMin");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<int>("TipoGrupoPrecificacao");

                    b.HasKey("Id");

                    b.ToTable("GrupoPrecificacao");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApelidoEnderecoEntrega");

                    b.Property<string>("Cartao1Apelido");

                    b.Property<double>("Cartao1Valor");

                    b.Property<string>("Cartao2Apelido");

                    b.Property<double>("Cartao2Valor");

                    b.Property<int>("ClienteId");

                    b.Property<int?>("CupomId1");

                    b.Property<DateTime>("DataCompra");

                    b.Property<string>("EnderecoEntrega")
                        .IsRequired();

                    b.Property<int>("FormaPagamento");

                    b.Property<int>("NumeroCartoesUsados");

                    b.Property<string>("NumeroPedido")
                        .IsRequired();

                    b.Property<string>("Parcelamento1Valor");

                    b.Property<string>("Parcelamento2Valor");

                    b.Property<int>("Status");

                    b.Property<double>("SubTotalCupom");

                    b.Property<double>("SubTotalFrete");

                    b.Property<double>("SubTotalProdutos");

                    b.Property<double>("ValorFrete");

                    b.Property<double>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("CupomId1");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoBarra")
                        .IsRequired();

                    b.Property<int>("CorPrimariaProduto");

                    b.Property<int>("CorSecundariaProduto");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int>("FichaTecnicaId");

                    b.Property<int>("FornecedorId");

                    b.Property<int>("Genero");

                    b.Property<int>("GrupoPrecificacaoId");

                    b.Property<int>("Marca");

                    b.Property<string>("Modelo")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Quantidade");

                    b.Property<int>("Status");

                    b.Property<int>("Tamanho");

                    b.Property<string>("URLFoto")
                        .IsRequired();

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("FichaTecnicaId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("GrupoPrecificacaoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.ProdutoPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoBarra");

                    b.Property<int>("CorPrimariaProduto");

                    b.Property<int>("CorSecundariaProduto");

                    b.Property<string>("Descricao");

                    b.Property<int?>("FichaTecnicaId");

                    b.Property<int?>("FornecedorId");

                    b.Property<int>("Genero");

                    b.Property<int?>("GrupoPrecificacaoId");

                    b.Property<int>("Marca");

                    b.Property<string>("Modelo");

                    b.Property<string>("Nome");

                    b.Property<int>("PedidoId");

                    b.Property<int>("ProdutoEstoqueId");

                    b.Property<int>("Quantidade");

                    b.Property<int>("QuantidadeCarrinho");

                    b.Property<int>("Status");

                    b.Property<int>("Tamanho");

                    b.Property<string>("URLFoto");

                    b.Property<double>("Valor");

                    b.Property<double>("ValorSubtotal");

                    b.HasKey("Id");

                    b.HasIndex("FichaTecnicaId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("GrupoPrecificacaoId");

                    b.ToTable("ProdutoPedido");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Troca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comentarios");

                    b.Property<DateTime>("DataSolicitacao");

                    b.Property<int>("IddoCliente");

                    b.Property<int>("MetodoColeta");

                    b.Property<int>("MotivoTroca");

                    b.Property<string>("OutroMotivo");

                    b.Property<int?>("PedidoId");

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Status");

                    b.Property<int>("Tamanho");

                    b.Property<int>("TipoReembolso");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Troca");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Cartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apelido");

                    b.Property<int>("Bandeira");

                    b.Property<int>("ClienteId");

                    b.Property<string>("CodigoSeguranca");

                    b.Property<string>("NomeImpresso");

                    b.Property<string>("Numero");

                    b.Property<bool>("Preferencial");

                    b.Property<int>("TipoCartao");

                    b.Property<string>("Validade");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Cartao");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int?>("EstadoId");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<bool>("FlagCobranca");

                    b.Property<bool>("FlagEntrega");

                    b.Property<int>("Genero");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Sobrenome")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.Property<int?>("TelefoneId");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("TelefoneId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apelido")
                        .IsRequired();

                    b.Property<string>("Bairro")
                        .IsRequired();

                    b.Property<bool>("CadastroInicial");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<int?>("CidadeId");

                    b.Property<int>("ClienteId");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro")
                        .IsRequired();

                    b.Property<string>("Numero")
                        .IsRequired();

                    b.Property<string>("Observacoes");

                    b.Property<int>("TipoEndereco");

                    b.Property<int>("TipoLogradouro");

                    b.Property<int>("TipoResidencia");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int?>("PaisId");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DDD")
                        .IsRequired();

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("TipoTelefone");

                    b.HasKey("Id");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("RaellShoes.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("RaellShoes.Models.NN.CupomCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("CupomId");

                    b.HasKey("Id");

                    b.ToTable("CupomCliente");
                });

            modelBuilder.Entity("RaellShoes.Models.NN.ProdutoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.ToTable("ProdutoCliente");
                });

            modelBuilder.Entity("RaellShoes.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Carrinho", b =>
                {
                    b.HasOne("RaellShoes.Models.Clientes.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RaellShoes.Models.Administrador.Cupom", "Cupom")
                        .WithMany()
                        .HasForeignKey("CupomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RaellShoes.Models.Clientes.Endereco", "EnderecoEntrega")
                        .WithMany()
                        .HasForeignKey("EnderecoEntregaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Categoria", b =>
                {
                    b.HasOne("RaellShoes.Models.Administrador.Produto")
                        .WithMany("Categorias")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Pedido", b =>
                {
                    b.HasOne("RaellShoes.Models.Clientes.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RaellShoes.Models.Administrador.Cupom", "Cupom")
                        .WithMany()
                        .HasForeignKey("CupomId1");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Produto", b =>
                {
                    b.HasOne("RaellShoes.Models.Administrador.FichaTecnica", "FichaTecnica")
                        .WithMany()
                        .HasForeignKey("FichaTecnicaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RaellShoes.Models.Administrador.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RaellShoes.Models.Administrador.GrupoPrecificacao", "GrupoPrecificacao")
                        .WithMany()
                        .HasForeignKey("GrupoPrecificacaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.ProdutoPedido", b =>
                {
                    b.HasOne("RaellShoes.Models.Administrador.FichaTecnica", "FichaTecnica")
                        .WithMany()
                        .HasForeignKey("FichaTecnicaId");

                    b.HasOne("RaellShoes.Models.Administrador.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");

                    b.HasOne("RaellShoes.Models.Administrador.GrupoPrecificacao", "GrupoPrecificacao")
                        .WithMany()
                        .HasForeignKey("GrupoPrecificacaoId");
                });

            modelBuilder.Entity("RaellShoes.Models.Administrador.Troca", b =>
                {
                    b.HasOne("RaellShoes.Models.Administrador.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId");

                    b.HasOne("RaellShoes.Models.Administrador.ProdutoPedido", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Cartao", b =>
                {
                    b.HasOne("RaellShoes.Models.Clientes.Cliente")
                        .WithOne("Cartao")
                        .HasForeignKey("RaellShoes.Models.Clientes.Cartao", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Cidade", b =>
                {
                    b.HasOne("RaellShoes.Models.Clientes.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Cliente", b =>
                {
                    b.HasOne("RaellShoes.Models.Clientes.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId");

                    b.HasOne("RaellShoes.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Endereco", b =>
                {
                    b.HasOne("RaellShoes.Models.Clientes.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");

                    b.HasOne("RaellShoes.Models.Clientes.Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RaellShoes.Models.Clientes.Estado", b =>
                {
                    b.HasOne("RaellShoes.Models.Clientes.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId");
                });
#pragma warning restore 612, 618
        }
    }
}
