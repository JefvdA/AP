using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGameStore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Person");

            migrationBuilder.EnsureSchema(
                name: "Store");

            migrationBuilder.CreateTable(
                name: "tblStores",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Addition = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    IsFranchiseStore = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPeople",
                schema: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    EmailAdress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPeople", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPeople_tblStores_StoreId",
                        column: x => x.StoreId,
                        principalSchema: "Store",
                        principalTable: "tblStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Store",
                table: "tblStores",
                columns: new[] { "Id", "Addition", "Place", "IsFranchiseStore", "Name", "Number", "Street", "Zipcode" },
                values: new object[,]
                {
                    { -1, "", "Kortrijk", false, "MyGameStore Kortrijk", "260", "Korte Steenstraat", "8500" },
                    { -2, "", "Ninove", true, "MyGameStore Ninove", "95", "Centrumlaan", "9400" },
                    { -3, "", "Roeselare", false, "MyGameStore Roeselare", "97", "Ooststraat", "8800" },
                    { -4, "", "Zaventem", false, "MyGameStore Zaventem", "173", "Weiveldlaan", "1930" },
                    { -5, "", "Hasselt", false, "MyGameStore Hasselt", "254", "Demerstraat", "3500" },
                    { -6, "", "Gent", true, "MyGameStore Gent", "128", "Veldstraat", "9000" },
                    { -7, "", "Knokke-Heist", false, "MyGameStore Knokke-Heist", "215", "Lippenslaan", "8300" },
                    { -8, "", "Maaseik", false, "MyGameStore Maaseik", "239", "Bosstraat", "3680" },
                    { -9, "", "Beringen", false, "MyGameStore Beringen", "85", "Koolmijnlaan", "3580" },
                    { -10, "", "Geraardsbergen", false, "MyGameStore Geraardsbergen", "149", "Winkelstraat", "9500" },
                    { -11, "", "Asse", false, "MyGameStore Asse", "260", "Stationsstraat", "1730" },
                    { -12, "", "Geel", false, "MyGameStore Geel", "59", "Nieuwstraat", "2440" },
                    { -13, "", "Antwerpen", true, "MyGameStore Antwerpen", "76", "Meir", "2000" },
                    { -14, "", "Mol", false, "MyGameStore Mol", "179", "Statiestraat", "2400" },
                    { -15, "", "Sint-Gillis", false, "MyGameStore Sint-Gillis", "286", "Fonsnylaan", "1060" }
                });

            migrationBuilder.InsertData(
                schema: "Person",
                table: "tblPeople",
                columns: new[] { "Id", "EmailAdress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[] { -1, "jef.v.d.a@live.be", "Jef", 0, "van der Avoirt", -1 });

            migrationBuilder.InsertData(
                schema: "Person",
                table: "tblPeople",
                columns: new[] { "Id", "EmailAdress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[] { -2, "baetenjens@gmail.com", "Jens", 0, "Baeten", -2 });

            migrationBuilder.CreateIndex(
                name: "IX_tblPeople_EmailAdress",
                schema: "Person",
                table: "tblPeople",
                column: "EmailAdress",
                unique: true,
                filter: "[EmailAdress] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblPeople_StoreId",
                schema: "Person",
                table: "tblPeople",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStores_Name",
                schema: "Store",
                table: "tblStores",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPeople",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "tblStores",
                schema: "Store");
        }
    }
}
