using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BudgetApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "currencies",
                columns: new[] { "id", "code", "decimal_places", "symbol" },
                values: new object[,]
                {
                    { 1, "PLN", (byte)2, "zł" },
                    { 2, "EUR", (byte)2, "€" },
                    { 3, "USD", (byte)2, "$" },
                    { 4, "GBP", (byte)2, "£" },
                    { 5, "CHF", (byte)2, "CHF" },
                    { 6, "JPY", (byte)0, "¥" },
                    { 7, "CNY", (byte)2, "¥" },
                    { 8, "HKD", (byte)2, "HK$" },
                    { 9, "SGD", (byte)2, "S$" },
                    { 10, "AUD", (byte)2, "A$" },
                    { 11, "CAD", (byte)2, "C$" },
                    { 12, "NZD", (byte)2, "NZ$" },
                    { 13, "SEK", (byte)2, "kr" },
                    { 14, "NOK", (byte)2, "kr" },
                    { 15, "DKK", (byte)2, "kr" },
                    { 16, "CZK", (byte)2, "Kč" },
                    { 17, "HUF", (byte)0, "Ft" },
                    { 18, "RON", (byte)2, "lei" },
                    { 19, "BGN", (byte)2, "лв" },
                    { 20, "TRY", (byte)2, "₺" },
                    { 21, "UAH", (byte)2, "₴" },
                    { 22, "RUB", (byte)2, "₽" },
                    { 23, "INR", (byte)2, "₹" },
                    { 24, "BRL", (byte)2, "R$" },
                    { 25, "MXN", (byte)2, "$" },
                    { 26, "ARS", (byte)2, "$" },
                    { 27, "CLP", (byte)0, "$" },
                    { 28, "COP", (byte)2, "$" },
                    { 29, "UYU", (byte)2, "$U" },
                    { 30, "ZAR", (byte)2, "R" },
                    { 31, "ILS", (byte)2, "₪" },
                    { 32, "AED", (byte)2, "د.إ" },
                    { 33, "SAR", (byte)2, "﷼" },
                    { 34, "QAR", (byte)2, "ر.ق" },
                    { 35, "KWD", (byte)3, "د.ك" },
                    { 36, "BHD", (byte)3, ".د.ب" },
                    { 37, "OMR", (byte)3, "ر.ع." },
                    { 38, "PKR", (byte)2, "₨" },
                    { 39, "BDT", (byte)2, "৳" },
                    { 40, "LKR", (byte)2, "₨" },
                    { 41, "NPR", (byte)2, "₨" },
                    { 42, "THB", (byte)2, "฿" },
                    { 43, "VND", (byte)0, "₫" },
                    { 44, "IDR", (byte)2, "Rp" },
                    { 45, "PHP", (byte)2, "₱" },
                    { 46, "MYR", (byte)2, "RM" },
                    { 47, "KRW", (byte)0, "₩" },
                    { 48, "EGP", (byte)2, "£" },
                    { 49, "NGN", (byte)2, "₦" },
                    { 50, "KES", (byte)2, "KSh" },
                    { 51, "ISK", (byte)0, "kr" },
                    { 52, "HRK", (byte)2, "kn" },
                    { 53, "RSD", (byte)2, "дин." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 53);
        }
    }
}
