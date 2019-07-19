using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sigcorp.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PedidoCompraID",
                table: "Produto",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "PedidoCompra",
                columns: table => new
                {
                    PedidoCompraID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroPedido = table.Column<int>(nullable: false),
                    ClienteID = table.Column<int>(nullable: true),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoCompra", x => x.PedidoCompraID);
                    table.ForeignKey(
                        name: "FK_PedidoCompra_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_PedidoCompraID",
                table: "Produto",
                column: "PedidoCompraID");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCompra_ClienteID",
                table: "PedidoCompra",
                column: "ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_PedidoCompra_PedidoCompraID",
                table: "Produto",
                column: "PedidoCompraID",
                principalTable: "PedidoCompra",
                principalColumn: "PedidoCompraID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_PedidoCompra_PedidoCompraID",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "PedidoCompra");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Produto_PedidoCompraID",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "PedidoCompraID",
                table: "Produto");
        }
    }
}
