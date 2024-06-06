using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class BlogSampleDbThirdMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7f4463f-9be3-4ca8-9891-c420238d25e9", "AQAAAAIAAYagAAAAEHkWILUQg4eLVIlJt2v5HpwwTm2aIEOgcxGK4ZTuA7y3jJ149grSN6EoU5E6uPFZOw==", "1d62b8c1-4b70-4cf5-828b-c66be5d11e94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06958b51-4122-4975-a948-917ae6f96776", "AQAAAAIAAYagAAAAECIli1fC67cDgHMsATkJ230pEfrutBzas9ewLIFNI8rf29jNWKfm3Vkxkoow0KneOg==", "2c635e53-a289-4500-82a9-15fde356c7d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67c197e1-623f-4142-9fee-b15909e6f191", "AQAAAAIAAYagAAAAELd6ieCV4gEeb0drxEL1cSdQC4l7e/fjLEarew0i2eCX1RNaGBY/yltw7HrN+GEfOw==", "d815f00d-a809-47a8-85ee-ede285926a4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ad7dcc9-9ec2-4e5b-845a-ff834126dfdd", "AQAAAAIAAYagAAAAEB4VDkxHhO4uC6sv2fIkZSmnJsyT27ltxEC6Ys8z/+MRXKWcjVF80NFFyh5Rzh5EFw==", "61925cd2-b828-40f0-84f7-b28d3ddc97cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d7198dc-2149-4825-bece-830baf115f2f", "AQAAAAIAAYagAAAAEArAQP9U16sgEVxSzu2UsydXNMhaI1YQhkjahZy1eJ5ktSyzeniAauleQNhvDpbY8A==", "810e0b8e-9bf2-4a30-95b1-3908a5bc16de" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4294), "~/images/Shop/shop@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4297), "~/images/Shop/shop@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4299), "~/images/Shop/shop@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4301), "~/images/Shop/shop@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4308), "~/images/Shop/shop@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4310), "~/images/Shop/shop@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4313), "~/images/Shop/shop@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4315), "~/images/Shop/shop@2x.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3996));

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3869), "~/images/Shop/shop2@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3872), "~/images/Shop/shop3@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3891), "~/images/Shop/shop4@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3894), "~/images/Shop/shop5@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3903), "~/images/Shop/shop6@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3906), "~/images/Shop/shop7@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3909), "~/images/Shop/shop8@2x.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 44, 39, 995, DateTimeKind.Utc).AddTicks(3912), "~/images/Shop/shop9@2x.jpg" });
        }
    }
}
