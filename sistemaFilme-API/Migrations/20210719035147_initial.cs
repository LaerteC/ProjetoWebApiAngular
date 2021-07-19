using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaFilme_API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "atores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(nullable: true),
                    sobrenome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "filmes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(nullable: true),
                    dataLancamento = table.Column<string>(nullable: true),
                    diretor = table.Column<string>(nullable: true),
                    genero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    FilmeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genero_filmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "filmes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtorGenero",
                columns: table => new
                {
                    atorId = table.Column<int>(nullable: false),
                    generoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtorGenero", x => new { x.atorId, x.generoId });
                    table.ForeignKey(
                        name: "FK_AtorGenero_atores_atorId",
                        column: x => x.atorId,
                        principalTable: "atores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtorGenero_Genero_generoId",
                        column: x => x.generoId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "atores",
                columns: new[] { "id", "nome", "sobrenome" },
                values: new object[] { 1, "Lauro", "Fernão" });

            migrationBuilder.InsertData(
                table: "atores",
                columns: new[] { "id", "nome", "sobrenome" },
                values: new object[] { 2, "Roberto", "Gomes" });

            migrationBuilder.InsertData(
                table: "atores",
                columns: new[] { "id", "nome", "sobrenome" },
                values: new object[] { 3, "Ronaldo", "Nazario" });

            migrationBuilder.InsertData(
                table: "atores",
                columns: new[] { "id", "nome", "sobrenome" },
                values: new object[] { 4, "Rodrigo", "Hubert" });

            migrationBuilder.InsertData(
                table: "atores",
                columns: new[] { "id", "nome", "sobrenome" },
                values: new object[] { 5, "Alexandre", "Pires" });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "dataLancamento", "diretor", "genero", "titulo" },
                values: new object[] { 1, "22/02/2005", "Cristofer Nolan", "Ficção", "Vanilla Sky" });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "dataLancamento", "diretor", "genero", "titulo" },
                values: new object[] { 2, "22/02/2002", "Cristofer Nolan", "Drama", "Batman" });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "dataLancamento", "diretor", "genero", "titulo" },
                values: new object[] { 3, "22/02/1999", " Martin Scorcese", "Ação", "O Irlandes" });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "dataLancamento", "diretor", "genero", "titulo" },
                values: new object[] { 4, "22/02/2001", "David Linch", "Romance", "Clube de Luta" });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "dataLancamento", "diretor", "genero", "titulo" },
                values: new object[] { 5, "22/02/2019", "Rodrigo Padilha", "Comédia", "Magnólia" });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "dataLancamento", "diretor", "genero", "titulo" },
                values: new object[] { 6, "22/02/2021", "Fernando Meirelles", "Fantasia", "Tropa de Elite" });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "dataLancamento", "diretor", "genero", "titulo" },
                values: new object[] { 7, "22/02/2018", "Stanley Kubric", "Terror", "2001 Odisseia" });

            migrationBuilder.CreateIndex(
                name: "IX_AtorGenero_generoId",
                table: "AtorGenero",
                column: "generoId");

            migrationBuilder.CreateIndex(
                name: "IX_Genero_FilmeId",
                table: "Genero",
                column: "FilmeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtorGenero");

            migrationBuilder.DropTable(
                name: "atores");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "filmes");
        }
    }
}
