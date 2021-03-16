using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEventos.Persistence.Migrations
{
    public partial class quarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lotes",
                columns: new[] { "Id", "DataFim", "DataInicio", "EventoId", "Nome", "Preco", "Quantidade" },
                values: new object[] { 2, null, null, 2, "LOTE 2", 73.39m, 100 });

            migrationBuilder.InsertData(
                table: "Lotes",
                columns: new[] { "Id", "DataFim", "DataInicio", "EventoId", "Nome", "Preco", "Quantidade" },
                values: new object[] { 3, null, null, 3, "LOTE 3", 73.39m, 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lotes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lotes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
