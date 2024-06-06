using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class BlogSampleDbSecondMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3991), null, "A design and development agency based in London. We create digital products that make people’s lives easier.", true, "Header", null },
                    { 2, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3993), null, "~/images/About/about@2x.jpg", true, "Img", null },
                    { 3, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3994), null, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,", true, "Story", null },
                    { 4, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3995), null, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,", true, "Mission", null },
                    { 5, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3996), null, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,", true, "Value", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20453c50-8caf-48c2-a43e-9b870b9450ab", "AQAAAAIAAYagAAAAEG5rgZICqN+CPJtmNpnXito8pwj90sQ3gYtVqjSTKGT7qGmzvq6r9xzXqLrMfxeCRw==", "c571fee1-68f1-4fe9-b88c-67dad3b7591b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9d5daf2-8b89-4829-bec7-318061f1d35e", "AQAAAAIAAYagAAAAEEfHB2KFU9h4L7lntFxrwlz9aXi+xbKy4+1tQCxHszsJeiOutog1m/feRcVh8oM1mA==", "f046d883-25c1-4a22-afc6-440060441ee8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "336ad5cd-9ea2-40b7-bdf6-f13c8043dd6a", "AQAAAAIAAYagAAAAENsMoWHR2sCyPtZFLrRAomPZN2yG4GJhHVuiuRLuXerEE4+iQdkbB/L6Ie2XmgaGFg==", "fe78a735-0e90-4e9e-bb84-f7f402d1da62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d41d9ae-1b9b-4e03-8f17-b922f70ffdae", "AQAAAAIAAYagAAAAEG8utJrnh8hJ7vsVc6QVUca0VflgoqHcSKMdkTNVHdrmB1JqAITnzuTbZgecGqF4uQ==", "86970b15-9eea-409c-a5d4-860306f59450" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54f5310c-b7d4-4879-a12e-89220c616224", "AQAAAAIAAYagAAAAECcQnkFaSCdpgAZrRb2lLWrenmxK16sSmyM1KtOgpOS4WEbT8VT27qNMjOynm45aTw==", "9bc50420-f9fb-45fe-8a0e-f42e1c14c069" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "ImageUrl", "IsActive", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3866), null, "A high-quality flying ninja toy.", "~/images/Shop/shop@2x.jpg", true, "Flying Ninja", 15.00m, null },
                    { 2, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3869), null, "An invisible ninja toy with stealth mode.", "~/images/Shop/shop2@2x.jpg", true, "Invisible Ninja", 20.00m, null },
                    { 3, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3872), null, "A fast ninja toy with lightning speed.", "~/images/Shop/shop3@2x.jpg", true, "Speed Ninja", 18.00m, null },
                    { 4, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3891), null, "A stealthy ninja toy with night vision.", "~/images/Shop/shop4@2x.jpg", true, "Stealth Ninja", 22.00m, null },
                    { 5, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3894), null, "A shadow ninja toy that blends into the dark.", "~/images/Shop/shop5@2x.jpg", true, "Shadow Ninja", 19.00m, null },
                    { 6, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3903), null, "A samurai ninja toy with a katana.", "~/images/Shop/shop6@2x.jpg", true, "Samurai Ninja", 25.00m, null },
                    { 7, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3906), null, "A rogue ninja toy with dual blades.", "~/images/Shop/shop7@2x.jpg", true, "Rogue Ninja", 23.00m, null },
                    { 8, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3909), null, "A mystic ninja toy with magical powers.", "~/images/Shop/shop8@2x.jpg", true, "Mystic Ninja", 28.00m, null },
                    { 9, new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3912), null, "A warrior ninja toy with armor.", "~/images/Shop/shop9@2x.jpg", true, "Warrior Ninja", 30.00m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93854b3f-fae4-4ce9-9f0c-531b8a1455de", "AQAAAAIAAYagAAAAED0vyv/xG5Td6g3VkYVlnXwa/GzeRMEZH84xHDEbjNQN3x5m7ITKNWqCSjZjx24b9Q==", "c76827b2-61bb-41a6-bc6d-b518ab0e4526" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70cfcb55-9dfc-427d-9b27-b7cd4a16a33c", "AQAAAAIAAYagAAAAEFlMvJXZlZvJ25f3MTxZjDC+ziMzs0dcAySjZZXmFORvrEyxxgkf39uucSXAj0DMmg==", "884bf448-8b72-45e1-9a82-f9828eee6c42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d08676f4-7826-43fd-8ee8-15421efab6ab", "AQAAAAIAAYagAAAAEGgWQ/oxojnouQT6KJX1CDHv4R/xmBYiTtwJ8OtRt0x696nOojCE3ZM+ATaMxqiFcA==", "e15c60d4-deae-45ea-99be-e30fa183c169" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff98d5b1-aeec-4f59-9e48-74eea9bda9dd", "AQAAAAIAAYagAAAAEBlduhQKdUO4vmWpt15OP20HilNmrrlgzo7bTM0adChPF2/Hz2/aDUVTJFDotT5XWw==", "614e1426-ac20-4f9d-af1c-782e7533e106" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20d02dcc-4204-48fa-a9ac-a8fde4796352", "AQAAAAIAAYagAAAAENxRR5cg9CrljMfB+Ckh3S/uz/Xsddq10jyAqozyauMPih+XZT2UaCQ4zovotUb2EA==", "526eebc5-4ab7-45b4-9cc3-26056d6817b0" });
        }
    }
}
