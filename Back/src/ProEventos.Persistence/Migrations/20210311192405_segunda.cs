using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEventos.Persistence.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { 1, null, "teste@123.com.br", "www.", "Evento WEG3", 1000, "99999", "Ações" });

            migrationBuilder.InsertData(
                table: "RedesSociais",
                columns: new[] { "Id", "EventoId", "Nome", "PalestranteId", "URL" },
                values: new object[] { 1, null, "Instagram", null, "instagram.com" });

            migrationBuilder.InsertData(
                table: "Lotes",
                columns: new[] { "Id", "DataFim", "DataInicio", "EventoId", "Nome", "Preco", "Quantidade" },
                values: new object[] { 1, null, null, 1, "LOTE WEG3", 73.39m, 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lotes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RedesSociais",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
