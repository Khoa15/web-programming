using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai3.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProducerModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducerModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    IdType = table.Column<int>(type: "int", nullable: false),
                    IdProducer = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookModel_ProducerModel_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "ProducerModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TypeBookModel",
                columns: table => new
                {
                    BookId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeModelId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeBookModel", x => new { x.BookId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_TypeBookModel_TypeModel_TypeModelId",
                        column: x => x.TypeModelId,
                        principalTable: "TypeModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookModel_ProducerId",
                table: "BookModel",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeBookModel_TypeModelId",
                table: "TypeBookModel",
                column: "TypeModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookModel");

            migrationBuilder.DropTable(
                name: "TypeBookModel");

            migrationBuilder.DropTable(
                name: "ProducerModel");

            migrationBuilder.DropTable(
                name: "TypeModel");
        }
    }
}
