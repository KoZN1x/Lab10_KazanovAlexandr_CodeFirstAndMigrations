using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab10_KazanovAlexandr_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddedDependencies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Trainer_TrainerId",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainer",
                table: "Trainer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Trainer",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "Team",
                newName: "TrainerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Team",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Team_TrainerId",
                table: "Team",
                newName: "IX_Team_TrainerID");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Player",
                newName: "TeamID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Player",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                newName: "IX_Player_TeamID");

            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "Trainer_PK",
                table: "Trainer",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "Team_PK",
                table: "Team",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "Player_PK",
                table: "Player",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team",
                table: "Player",
                column: "TeamID",
                principalTable: "Team",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Trainer",
                table: "Team",
                column: "TrainerID",
                principalTable: "Trainer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Trainer",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "Trainer_PK",
                table: "Trainer");

            migrationBuilder.DropPrimaryKey(
                name: "Team_PK",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "Player_PK",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Trainer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TrainerID",
                table: "Team",
                newName: "TrainerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Team",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Team_TrainerID",
                table: "Team",
                newName: "IX_Team_TrainerId");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "Player",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Player",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Player_TeamID",
                table: "Player",
                newName: "IX_Player_TeamId");

            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Team",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Team",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Player",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Player",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainer",
                table: "Trainer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Trainer_TrainerId",
                table: "Team",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
