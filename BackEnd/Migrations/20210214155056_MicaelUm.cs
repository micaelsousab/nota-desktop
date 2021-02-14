using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class MicaelUm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensServicos",
                table: "ItensServicos");

            migrationBuilder.RenameColumn(
                name: "ServicoId",
                table: "Servicos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ItemServicoId",
                table: "ItensServicos",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "EnderecoId",
                table: "Enderecos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Quantidade",
                table: "ItensServicos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ItensServicos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Enderecos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensServicos",
                table: "ItensServicos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensServicos",
                table: "ItensServicos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ItensServicos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Servicos",
                newName: "ServicoId");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "ItensServicos",
                newName: "ItemServicoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Enderecos",
                newName: "EnderecoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.AlterColumn<int>(
                name: "ItemServicoId",
                table: "ItensServicos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Enderecos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensServicos",
                table: "ItensServicos",
                column: "ItemServicoId");
        }
    }
}
