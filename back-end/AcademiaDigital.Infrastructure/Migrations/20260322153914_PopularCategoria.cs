using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaDigital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
        table: "Categorias",
        columns: new[] { "CategoriaId", "Name", "Description", "Date" },
        values: new object[,]
        {
            { 1, "Programação", "Cursos de desenvolvimento de software", new DateTime(2024, 1, 1) },
            { 2, "Design", "Cursos de design gráfico e UX/UI", new DateTime(2024, 1, 1) },
            { 3, "Marketing Digital", "Cursos de estratégias de marketing online", new DateTime(2024, 1, 1) },
            { 4, "Negócios", "Cursos de empreendedorismo e gestão", new DateTime(2024, 1, 1) }
        }
    );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
        table: "Categorias",
        keyColumn: "CategoriaId",
        keyValues: new object[] { 1, 2, 3, 4 }
    );
        }
    }
}
