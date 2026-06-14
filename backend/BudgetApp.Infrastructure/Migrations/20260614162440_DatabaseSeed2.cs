using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BudgetApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "transaction_categories",
                columns: new[] { "id", "name", "parent_id", "type" },
                values: new object[,]
                {
                    { 1, "Dom i wyposażenie", null, 0 },
                    { 2, "Kultura i rozrywka", null, 0 },
                    { 3, "Opłaty", null, 0 },
                    { 4, "Samochód", null, 0 },
                    { 5, "Specjalne okazje", null, 0 },
                    { 6, "Sport", null, 0 },
                    { 7, "Transport i noclegi", null, 0 },
                    { 8, "Usługi cyfrowe", null, 0 },
                    { 9, "Zdrowie i uroda", null, 0 },
                    { 10, "Jedzenie i napoje", null, 0 },
                    { 11, "Praca", null, 1 },
                    { 12, "Inwestycje", null, 1 },
                    { 13, "Inne", null, 1 },
                    { 80, "Premia", null, 1 },
                    { 14, "AGD", 1, 0 },
                    { 15, "Akcesoria i dekoracje", 1, 0 },
                    { 16, "Artykuły papiernicze", 1, 0 },
                    { 17, "Elektronika i RTV", 1, 0 },
                    { 18, "Kuchnia", 1, 0 },
                    { 19, "Meble", 1, 0 },
                    { 20, "Narzędzia i sprzęt", 1, 0 },
                    { 21, "Odzież", 1, 0 },
                    { 22, "Tekstylia", 1, 0 },
                    { 23, "Inne aktywności", 2, 0 },
                    { 24, "Filmy i seriale", 2, 0 },
                    { 25, "Gry", 2, 0 },
                    { 26, "Hobby i kolekcjonerstwo", 2, 0 },
                    { 27, "Muzyka", 2, 0 },
                    { 28, "Komiksy, książki, prasa", 2, 0 },
                    { 29, "Eventy", 2, 0 },
                    { 30, "Muzea", 2, 0 },
                    { 31, "Mandaty", 3, 0 },
                    { 32, "Opłaty bankowe", 3, 0 },
                    { 33, "Opłaty drobne", 3, 0 },
                    { 34, "Opłaty urzędowe", 3, 0 },
                    { 35, "Podatki", 3, 0 },
                    { 36, "Telefon", 3, 0 },
                    { 37, "Usługi pocztowe", 3, 0 },
                    { 38, "Akcesoria", 4, 0 },
                    { 39, "Mechanik", 4, 0 },
                    { 40, "Myjnie i czyszczenie", 4, 0 },
                    { 41, "Paliwo", 4, 0 },
                    { 42, "Parkingi", 4, 0 },
                    { 43, "Ubezpieczenie", 4, 0 },
                    { 44, "Przegląd", 4, 0 },
                    { 45, "Akcje charytatywne", 5, 0 },
                    { 46, "Prezenty", 5, 0 },
                    { 47, "Odzież i akcesoria", 6, 0 },
                    { 48, "Sulementy i żywienie", 6, 0 },
                    { 49, "Zawody", 6, 0 },
                    { 50, "Rekreacja", 6, 0 },
                    { 51, "Koleje", 7, 0 },
                    { 52, "Komunikacja miejska", 7, 0 },
                    { 53, "Noclegi", 7, 0 },
                    { 54, "Samolot", 7, 0 },
                    { 55, "Taxi", 7, 0 },
                    { 56, "Ubezpieczenia podróżne", 7, 0 },
                    { 57, "Kursy i szkolenia", 8, 0 },
                    { 58, "Narzędzia", 8, 0 },
                    { 59, "Inne platformy", 8, 0 },
                    { 60, "Badania", 9, 0 },
                    { 61, "Dentysta", 9, 0 },
                    { 62, "Fizjoterapia", 9, 0 },
                    { 63, "Fryzjer", 9, 0 },
                    { 64, "Lekarstwa i wyroby medyczne", 9, 0 },
                    { 65, "Zdrowie intymne", 9, 0 },
                    { 66, "Kosmetyki", 9, 0 },
                    { 67, "Wizyty u lekarzy", 9, 0 },
                    { 68, "Jedzenie poza domem", 10, 0 },
                    { 69, "Zakupy spożywcze", 10, 0 },
                    { 70, "Inne", 10, 0 },
                    { 71, "Akcje", 11, 1 },
                    { 72, "Dywidendy", 11, 1 },
                    { 73, "Inne odsetki", 11, 1 },
                    { 74, "Lokaty", 11, 1 },
                    { 75, "Bonusy bankowe", 12, 1 },
                    { 76, "Cashbacki", 12, 1 },
                    { 77, "Prezenty", 12, 1 },
                    { 78, "Usługi", 12, 1 },
                    { 79, "Wypłata", 13, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "transaction_categories",
                keyColumn: "id",
                keyValue: 13);
        }
    }
}
