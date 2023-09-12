using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNumericValuesTypesInOperations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SecondValue",
                table: "Operations",
                type: "decimal(38,10)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Result",
                table: "Operations",
                type: "decimal(38,10)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "FirstValue",
                table: "Operations",
                type: "decimal(38,10)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "SecondValue",
                table: "Operations",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(38,10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Result",
                table: "Operations",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38,10)");

            migrationBuilder.AlterColumn<float>(
                name: "FirstValue",
                table: "Operations",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38,10)");
        }
    }
}
