using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWork2021.Migrations
{
    public partial class tolik2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "naim", "sku", "url" },
                values: new object[] { "Набор цветных карандашей MARCO Superb Writer 4100-12CB, 12 цветов", "150853", "https://images.ua.prom.st/1647524865_w272_h200_nabor-tsvetnyh-karandashej.jpg" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "naim", "sku", "url" },
                values: new object[,]
                {
                    { 20, "Фломастеры MARCO 1630-48CB 48 цветов", "196145", "https://images.ua.prom.st/2063124737_w272_h200_flomastery-marco-1630-48cb.jpg" },
                    { 19, "Пластилин 10 цветов &#34;Гамма&#34;, 200 грамм", "193766", "https://images.ua.prom.st/2223391181_w272_h200_plastilin-10-tsvetov.jpg" },
                    { 18, "Пластилин 12 цветов &#34;Гамма&#34;, 240 грамм", "193767", "https://images.ua.prom.st/1102067072_w272_h200_plastilin-12-tsvetov.jpg" },
                    { 17, "Альбом для рисования A4 на спирали, 30 листов, плотность 120г/м²", "151058", "https://images.ua.prom.st/1333050618_w272_h200_albom-dlya-risovaniya.jpg" },
                    { 16, "Гуашь &#34;Гамма&#34; 12 цветов по 10 мл.", "193761", "https://images.ua.prom.st/1243159090_w272_h200_guash-gamma-12.jpg" },
                    { 15, "Гуашь &#34;Луч Классика&#34; 12 цветов по 20 мл. блок-тара", "193576", "https://images.ua.prom.st/1634666786_w272_h200_guash-luch-klassika.jpg" },
                    { 14, "Раскраска &#34;Антистресс&#34; &#34;Вокруг света&#34; 24 рисунка, формат В4, GDM-008", "195895", "https://images.ua.prom.st/1494798100_w272_h200_raskraska-antistress-vokrug.jpg" },
                    { 13, "Краски акварельные &#34;Луч&#34; 32 цвета", "193577", "https://images.ua.prom.st/1088077436_w272_h200_kraski-akvarelnye-luch.jpg" },
                    { 21, "Раскраска по номерам &#34;Лев 3&#34; на полотне, большая 400*500мм №30654", "А108924", "https://images.ua.prom.st/2734243721_w272_h200_raskraska-po-nomeram.jpg" },
                    { 12, "Краски акварельные &#34;Луч - Классика&#34; 12 цветов", "150184", "https://images.ua.prom.st/1365922583_w272_h200_kraski-akvarelnye-luch.jpg" },
                    { 10, "Рюкзак школьный &#34;Ниндзяго Битва&#34;, ортопедический, коробка 33х26х13см. (Ninjago)", "988556", "https://images.ua.prom.st/2446121850_w272_h200_ryukzak-shkolnyj-nindzyago.jpg" },
                    { 9, "Ручка &#34;пиши-стирай&#34; &#34;С&#34; синяя (CR-707F)", "191500", "https://images.ua.prom.st/1350538336_w272_h200_ruchka-pishi-stiraj-s.jpg" },
                    { 8, "Сумка для обуви &#34;Мультики 808&#34;, 35х25см", "110574", "https://images.ua.prom.st/1720812071_w272_h200_sumka-dlya-obuvi.jpg" },
                    { 7, "Пластилин 8 цветов &#34;Луч&#34; &#34;Классика&#34;, 160 грамм", "150224", "https://images.ua.prom.st/1102242891_w272_h200_plastilin-8-tsvetov.jpg" },
                    { 6, "Тетрадь 18 листов линия, Фоновая &#34;Мрiя&#34;", "150016", "https://images.ua.prom.st/996382631_w272_h200_tetrad-18-listov.jpg" },
                    { 5, "Тетрадь 12 листов линия, Фоновая &#34;Мрiя&#34;", "150012", "https://images.ua.prom.st/996295732_w272_h200_tetrad-12-listov.jpg" },
                    { 4, "Ручка масляная Cello Writo-meter &#34;10км&#34; синяя", "150653", "https://images.ua.prom.st/1002943071_w272_h200_ruchka-maslyanaya-cello.jpg" },
                    { 3, "Картина по номерам &#34;Забавные питомцы&#34; на полотне, большая 400*500мм №30340", "А108831", "https://images.ua.prom.st/2731377405_w272_h200_kartina-po-nomeram.jpg" },
                    { 11, "Альбом для рисования A4 на скобе, 20 листов, плотность 120г/м²", "194221", "https://images.ua.prom.st/1075415876_w272_h200_albom-dlya-risovaniya.jpg" },
                    { 2, "Тетрадь 12 листов линия, Фоновая &#34;Квітка&#34;", "150005", "https://images.ua.prom.st/1017594182_w272_h200_tetrad-12-listov.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "naim", "sku", "url" },
                values: new object[] { "testc", "1111", "www.leningrad" });
        }
    }
}
