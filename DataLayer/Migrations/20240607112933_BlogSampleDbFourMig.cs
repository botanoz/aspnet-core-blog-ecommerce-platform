using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class BlogSampleDbFourMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03ed20eb-4666-4d60-9fc4-c4ac7055a53d", "AQAAAAIAAYagAAAAECDqIaXTcem8ig1YZzjjLipVlzp5pf+KKTwPyxAFJU1vQNHNEzCEQMh9rmJzE6JqvA==", "4ad4c0e9-fc7e-4dd5-bd95-5d5d04c39c9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b547cd55-023a-4ecf-9f31-012cb30663d6", "AQAAAAIAAYagAAAAEAPcV4ABN9pX8t10AAwfvyo6yKPG2B1vVWj2+6sKbDfsCGl51f+4Fo8nYtBanpeOBg==", "ad71d9a7-d7be-43ed-8f59-d564b0bc973a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9722a0dd-b7c0-4aa6-a3c6-da7f1a4af60a", "AQAAAAIAAYagAAAAEPyI6LhaUbiZG2bAPGoMHvcfbCw40mSXLKu0ioPiUfFbudV9L3vhkILYAE6SRBtpTw==", "4c82bf39-bf90-416e-9695-29e703fe6bdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7b471ca-08b7-4583-978c-48be2c986ca0", "AQAAAAIAAYagAAAAEGRnED98RT7KN1dNwKxkupRZb5jmFMvVxg10OJTaghpW6J4jAJ84tN6WPUSmS1u+1Q==", "8d6ed482-2036-408f-bdbc-cd11446d18db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4f9c84-5e46-4ce4-acd4-c6f6954b97b3", "AQAAAAIAAYagAAAAEE1gbOM0NgbJvrT1CHA9rLm5kkpXNfn8NMgpAG1aRGhEHBQeXGyHSj2fSvG2T4S7JQ==", "423d01af-57ff-4386-a231-8227a0569160" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 29, 32, 289, DateTimeKind.Utc).AddTicks(7828));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

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
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 6, 11, 54, 53, 271, DateTimeKind.Utc).AddTicks(4315));
        }
    }
}
