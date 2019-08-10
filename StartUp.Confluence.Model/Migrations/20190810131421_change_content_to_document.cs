using Microsoft.EntityFrameworkCore.Migrations;

namespace StartUp.Confluence.Model.Migrations
{
    public partial class change_content_to_document : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Space_Space_ParentId",
                table: "Space");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Space",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Space_ParentId",
                table: "Space",
                newName: "IX_Space_CategoryId");

            migrationBuilder.RenameColumn(
                name: "Documents",
                table: "Document",
                newName: "Content");

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "UserQuestionAnswer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Space",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "QuestionChoice",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Question",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Industry",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "Document",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Document",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "ContactAudit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Contact",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AddressBook",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AccountType",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AccountAudit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Account",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Space_Category_CategoryId",
                table: "Space",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Space_Category_CategoryId",
                table: "Space");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "UserQuestionAnswer");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Space");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "QuestionChoice");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Industry");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "ContactAudit");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AddressBook");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AccountType");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AccountAudit");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Account");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Space",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Space_CategoryId",
                table: "Space",
                newName: "IX_Space_ParentId");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Document",
                newName: "Documents");

            migrationBuilder.AlterColumn<int>(
                name: "Version",
                table: "Document",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Space_Space_ParentId",
                table: "Space",
                column: "ParentId",
                principalTable: "Space",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
