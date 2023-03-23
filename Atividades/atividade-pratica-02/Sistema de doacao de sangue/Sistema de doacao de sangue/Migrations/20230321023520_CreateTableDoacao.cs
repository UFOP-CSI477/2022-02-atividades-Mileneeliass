using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_de_doacao_de_sangue.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableDoacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Número = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_sanguíneo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_de_doacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_local_doacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rua_local_doacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_local_doacao = table.Column<int>(type: "int", nullable: false),
                    Complemento_local_doacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade_local_doacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado_local_doacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacao", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doacao");
        }
    }
}
