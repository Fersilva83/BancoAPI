// <auto-generated />
using BancoAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BancoAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BancoAPI.Models.Conta", b =>
                {
                    b.Property<int>("ContaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodBanco")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("NomeTitular")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NumeroAgencia")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("NumeroConta")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<string>("dataAbertura")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ContaId");

                    b.ToTable("Contas");
                });
#pragma warning restore 612, 618
        }
    }
}
