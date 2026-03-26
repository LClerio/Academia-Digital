using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaDigital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PopularCurso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
        table: "Cursos",
        columns: new[]
        {
            "CursoId", "Name", "Description", "Price",
            "ImageUrl", "ImageThumbnailUrl",
            "Date", "CategoriaId"
        },
        values: new object[,]
       {
            { 1, "C# para Iniciantes", "Aprenda lógica e programação com C#", 99.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 1 },
            { 2, "ASP.NET Core Web API", "Crie APIs modernas com ASP.NET Core", 129.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 1 },
            { 3, "JavaScript Moderno", "Domine JS, ES6+ e desenvolvimento web", 89.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 1 },

            { 4, "Fundamentos do Design Gráfico", "Aprenda cores, tipografia e composição", 79.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 2 },
            { 5, "UI/UX Design Completo", "Crie interfaces modernas e intuitivas", 149.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 2 },
            { 6, "Figma do Zero ao Avançado", "Domine prototipação e design no Figma", 99.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 2 },

            { 7, "Marketing Digital para Iniciantes", "Aprenda estratégias básicas de marketing online", 59.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 3 },
            { 8, "Tráfego Pago e Facebook Ads", "Crie campanhas que convertem", 119.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 3 },
            { 9, "SEO na Prática", "Otimize sites para aparecer no Google", 109.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 3 },

            { 10, "Empreendedorismo do Zero", "Aprenda a criar e validar negócios", 139.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 4 },
            { 11, "Gestão de Projetos Ágeis", "Use Scrum e Kanban na prática", 129.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 4 },
            { 12, "Finanças para Empreendedores", "Controle financeiro e crescimento sustentável", 149.90m, "images/test.png", "images/test.png", new DateTime(2024, 1, 1), 4 }
        }
    );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
        table: "Cursos",
        keyColumn: "CursoId",
        keyValues: new object[]
        {
            1,2,3,4,5,6,7,8,9,10,11,12
        }
    );
        }
    }
}
