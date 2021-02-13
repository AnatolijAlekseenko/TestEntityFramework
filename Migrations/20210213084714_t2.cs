using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWork2021.Migrations
{
    public partial class t2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    naim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "naim", "sku", "url" },
                values: new object[,]
                {
                    { 1, "Набор цветных карандашей MARCO Superb Writer 4100-12CB, 12 цветов", "150853", "https://images.ua.prom.st/1647524865_w272_h200_nabor-tsvetnyh-karandashej.jpg" },
                    { 19, "Пластилин 10 цветов &#34;Гамма&#34;, 200 грамм", "193766", "https://images.ua.prom.st/2223391181_w272_h200_plastilin-10-tsvetov.jpg" },
                    { 18, "Пластилин 12 цветов &#34;Гамма&#34;, 240 грамм", "193767", "https://images.ua.prom.st/1102067072_w272_h200_plastilin-12-tsvetov.jpg" },
                    { 17, "Альбом для рисования A4 на спирали, 30 листов, плотность 120г/м²", "151058", "https://images.ua.prom.st/1333050618_w272_h200_albom-dlya-risovaniya.jpg" },
                    { 16, "Гуашь &#34;Гамма&#34; 12 цветов по 10 мл.", "193761", "https://images.ua.prom.st/1243159090_w272_h200_guash-gamma-12.jpg" },
                    { 15, "Гуашь &#34;Луч Классика&#34; 12 цветов по 20 мл. блок-тара", "193576", "https://images.ua.prom.st/1634666786_w272_h200_guash-luch-klassika.jpg" },
                    { 14, "Раскраска &#34;Антистресс&#34; &#34;Вокруг света&#34; 24 рисунка, формат В4, GDM-008", "195895", "https://images.ua.prom.st/1494798100_w272_h200_raskraska-antistress-vokrug.jpg" },
                    { 13, "Краски акварельные &#34;Луч&#34; 32 цвета", "193577", "https://images.ua.prom.st/1088077436_w272_h200_kraski-akvarelnye-luch.jpg" },
                    { 12, "Краски акварельные &#34;Луч - Классика&#34; 12 цветов", "150184", "https://images.ua.prom.st/1365922583_w272_h200_kraski-akvarelnye-luch.jpg" },
                    { 20, "Фломастеры MARCO 1630-48CB 48 цветов", "196145", "https://images.ua.prom.st/2063124737_w272_h200_flomastery-marco-1630-48cb.jpg" },
                    { 11, "Альбом для рисования A4 на скобе, 20 листов, плотность 120г/м²", "194221", "https://images.ua.prom.st/1075415876_w272_h200_albom-dlya-risovaniya.jpg" },
                    { 9, "Ручка &#34;пиши-стирай&#34; &#34;С&#34; синяя (CR-707F)", "191500", "https://images.ua.prom.st/1350538336_w272_h200_ruchka-pishi-stiraj-s.jpg" },
                    { 8, "Сумка для обуви &#34;Мультики 808&#34;, 35х25см", "110574", "https://images.ua.prom.st/1720812071_w272_h200_sumka-dlya-obuvi.jpg" },
                    { 7, "Пластилин 8 цветов &#34;Луч&#34; &#34;Классика&#34;, 160 грамм", "150224", "https://images.ua.prom.st/1102242891_w272_h200_plastilin-8-tsvetov.jpg" },
                    { 6, "Тетрадь 18 листов линия, Фоновая &#34;Мрiя&#34;", "150016", "https://images.ua.prom.st/996382631_w272_h200_tetrad-18-listov.jpg" },
                    { 5, "Тетрадь 12 листов линия, Фоновая &#34;Мрiя&#34;", "150012", "https://images.ua.prom.st/996295732_w272_h200_tetrad-12-listov.jpg" },
                    { 4, "Ручка масляная Cello Writo-meter &#34;10км&#34; синяя", "150653", "https://images.ua.prom.st/1002943071_w272_h200_ruchka-maslyanaya-cello.jpg" },
                    { 3, "Картина по номерам &#34;Забавные питомцы&#34; на полотне, большая 400*500мм №30340", "А108831", "https://images.ua.prom.st/2731377405_w272_h200_kartina-po-nomeram.jpg" },
                    { 2, "Тетрадь 12 листов линия, Фоновая &#34;Квітка&#34;", "150005", "https://images.ua.prom.st/1017594182_w272_h200_tetrad-12-listov.jpg" },
                    { 10, "Рюкзак школьный &#34;Ниндзяго Битва&#34;, ортопедический, коробка 33х26х13см. (Ninjago)", "988556", "https://images.ua.prom.st/2446121850_w272_h200_ryukzak-shkolnyj-nindzyago.jpg" },
                    { 21, "Раскраска по номерам &#34;Лев 3&#34; на полотне, большая 400*500мм №30654", "А108924", "https://images.ua.prom.st/2734243721_w272_h200_raskraska-po-nomeram.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
