using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class TestDatabase_Add1kvalue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a458fbe5-c96a-433a-8f48-34cc17a77979"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dca0c0d7-f4d6-4f3d-bbf0-363067a60cb4"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("6e8254d8-47e2-4054-be0b-d26d13865b90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1679c788-8717-43d7-8f23-f6a8e8ff34f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a14f794f-3ecf-49cc-b9c4-33bfd272c34f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7336d7c-2709-44a6-a33c-ffed1119e7dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4afeb0d4-2e75-42a2-83bf-2449c9f095e3"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null },
                    { new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Adress", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("00486ef7-1c62-43bc-ba4d-3a42bceb6654"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76587587@gmail.com", "NamDepTRai587", "Hashed_password_02", null, false, false, "Ho Hoang587", null, "User", null, 0 },
                    { new Guid("005744c4-fde9-4883-be40-cefaf497ae76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76558558@gmail.com", "NamDepTRai558", "Hashed_password_02", null, false, false, "Ho Hoang558", null, "User", null, 0 },
                    { new Guid("0068e416-3406-4c15-87cd-4233a22d157e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76554554@gmail.com", "NamDepTRai554", "Hashed_password_02", null, false, false, "Ho Hoang554", null, "User", null, 0 },
                    { new Guid("00daea56-fe30-4811-943b-0237801213d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76142142@gmail.com", "NamDepTRai142", "Hashed_password_02", null, false, false, "Ho Hoang142", null, "User", null, 0 },
                    { new Guid("01464551-0c13-4899-aedf-1e9401168752"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76653653@gmail.com", "NamDepTRai653", "Hashed_password_02", null, false, false, "Ho Hoang653", null, "User", null, 0 },
                    { new Guid("01d96684-9806-4241-9018-8ba97cc8c90d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76238238@gmail.com", "NamDepTRai238", "Hashed_password_02", null, false, false, "Ho Hoang238", null, "User", null, 0 },
                    { new Guid("01f0fc59-4d3d-4bae-819f-ea4f604b91c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76471471@gmail.com", "NamDepTRai471", "Hashed_password_02", null, false, false, "Ho Hoang471", null, "User", null, 0 },
                    { new Guid("0220faa4-4f34-466c-b6fd-08ed637c4758"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76966966@gmail.com", "NamDepTRai966", "Hashed_password_02", null, false, false, "Ho Hoang966", null, "User", null, 0 },
                    { new Guid("02293a03-6d3b-48ac-a3be-0eee787a12d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76873873@gmail.com", "NamDepTRai873", "Hashed_password_02", null, false, false, "Ho Hoang873", null, "User", null, 0 },
                    { new Guid("023f4760-5077-46d9-898d-e6f7330c6b6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76672672@gmail.com", "NamDepTRai672", "Hashed_password_02", null, false, false, "Ho Hoang672", null, "User", null, 0 },
                    { new Guid("024425bf-348d-4caa-a364-0645742c3c5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76248248@gmail.com", "NamDepTRai248", "Hashed_password_02", null, false, false, "Ho Hoang248", null, "User", null, 0 },
                    { new Guid("026ea7e6-3636-4099-8641-8b25a0436ac1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76754754@gmail.com", "NamDepTRai754", "Hashed_password_02", null, false, false, "Ho Hoang754", null, "User", null, 0 },
                    { new Guid("02b2ecdf-bdb0-4cea-982b-d15ef0db40ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76790790@gmail.com", "NamDepTRai790", "Hashed_password_02", null, false, false, "Ho Hoang790", null, "User", null, 0 },
                    { new Guid("02e9c885-0165-463c-b22d-33ce17e317be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76159159@gmail.com", "NamDepTRai159", "Hashed_password_02", null, false, false, "Ho Hoang159", null, "User", null, 0 },
                    { new Guid("03518558-31ab-45c2-b0b7-b1858a87268e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76685685@gmail.com", "NamDepTRai685", "Hashed_password_02", null, false, false, "Ho Hoang685", null, "User", null, 0 },
                    { new Guid("036b073c-f791-4a13-ac30-f222b3f7be14"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76562562@gmail.com", "NamDepTRai562", "Hashed_password_02", null, false, false, "Ho Hoang562", null, "User", null, 0 },
                    { new Guid("03d57710-d9f9-49be-bb20-923147d31c64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76370370@gmail.com", "NamDepTRai370", "Hashed_password_02", null, false, false, "Ho Hoang370", null, "User", null, 0 },
                    { new Guid("03ff4295-956a-488c-b7e4-0befc77a4a1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76499499@gmail.com", "NamDepTRai499", "Hashed_password_02", null, false, false, "Ho Hoang499", null, "User", null, 0 },
                    { new Guid("044c8215-2726-41f8-a35e-c423216fe5e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76243243@gmail.com", "NamDepTRai243", "Hashed_password_02", null, false, false, "Ho Hoang243", null, "User", null, 0 },
                    { new Guid("051ad26f-fe08-4427-a355-2b55cb3c381b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76844844@gmail.com", "NamDepTRai844", "Hashed_password_02", null, false, false, "Ho Hoang844", null, "User", null, 0 },
                    { new Guid("05749b0c-9220-4928-b3a6-5256ccc02ded"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76246246@gmail.com", "NamDepTRai246", "Hashed_password_02", null, false, false, "Ho Hoang246", null, "User", null, 0 },
                    { new Guid("057d70ac-805d-4212-ba2a-961cc5dd6912"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769696@gmail.com", "NamDepTRai96", "Hashed_password_02", null, false, false, "Ho Hoang96", null, "User", null, 0 },
                    { new Guid("058081a9-f704-4f09-977f-e500bd1c2cfc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76627627@gmail.com", "NamDepTRai627", "Hashed_password_02", null, false, false, "Ho Hoang627", null, "User", null, 0 },
                    { new Guid("05839782-cc01-4a11-bb3b-c4e386547821"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76226226@gmail.com", "NamDepTRai226", "Hashed_password_02", null, false, false, "Ho Hoang226", null, "User", null, 0 },
                    { new Guid("058ccbf8-8d06-43ab-8e07-859f96e14a4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76773773@gmail.com", "NamDepTRai773", "Hashed_password_02", null, false, false, "Ho Hoang773", null, "User", null, 0 },
                    { new Guid("058e33c9-28f9-420a-8167-2013000b2d4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76959959@gmail.com", "NamDepTRai959", "Hashed_password_02", null, false, false, "Ho Hoang959", null, "User", null, 0 },
                    { new Guid("05e39ecd-60dc-47c7-b32b-303e62ebeeef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76982982@gmail.com", "NamDepTRai982", "Hashed_password_02", null, false, false, "Ho Hoang982", null, "User", null, 0 },
                    { new Guid("062ecc8f-dc72-46c7-9656-7ba5ebd3a2a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76454454@gmail.com", "NamDepTRai454", "Hashed_password_02", null, false, false, "Ho Hoang454", null, "User", null, 0 },
                    { new Guid("06ae639a-ea4c-4b87-bdf9-ea1134ed9fcc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763333@gmail.com", "NamDepTRai33", "Hashed_password_02", null, false, false, "Ho Hoang33", null, "User", null, 0 },
                    { new Guid("070b1b26-2844-4782-a390-abd9d1f5a9d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76910910@gmail.com", "NamDepTRai910", "Hashed_password_02", null, false, false, "Ho Hoang910", null, "User", null, 0 },
                    { new Guid("07342f7e-32c6-4812-bb5a-f4c9aa850856"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76230230@gmail.com", "NamDepTRai230", "Hashed_password_02", null, false, false, "Ho Hoang230", null, "User", null, 0 },
                    { new Guid("076d9183-584d-49e9-b29d-0219fc5492f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76848848@gmail.com", "NamDepTRai848", "Hashed_password_02", null, false, false, "Ho Hoang848", null, "User", null, 0 },
                    { new Guid("07761fc6-31b4-4baf-b1f3-3d4f5b82926a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76175175@gmail.com", "NamDepTRai175", "Hashed_password_02", null, false, false, "Ho Hoang175", null, "User", null, 0 },
                    { new Guid("08043ea0-3875-42ec-b44c-05276c78dea7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76803803@gmail.com", "NamDepTRai803", "Hashed_password_02", null, false, false, "Ho Hoang803", null, "User", null, 0 },
                    { new Guid("08083381-0b47-4ad6-89b8-3bbbe1c73b48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76890890@gmail.com", "NamDepTRai890", "Hashed_password_02", null, false, false, "Ho Hoang890", null, "User", null, 0 },
                    { new Guid("08129710-eef7-4a4f-90fc-61402b672407"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76183183@gmail.com", "NamDepTRai183", "Hashed_password_02", null, false, false, "Ho Hoang183", null, "User", null, 0 },
                    { new Guid("0852ec09-8a9e-4093-a38a-3ad4c29dbdc8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76494494@gmail.com", "NamDepTRai494", "Hashed_password_02", null, false, false, "Ho Hoang494", null, "User", null, 0 },
                    { new Guid("08e57850-2302-4e52-8ad9-f66ffd71f8ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76144144@gmail.com", "NamDepTRai144", "Hashed_password_02", null, false, false, "Ho Hoang144", null, "User", null, 0 },
                    { new Guid("08f12892-7790-42a5-bada-1735bd8d89e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76711711@gmail.com", "NamDepTRai711", "Hashed_password_02", null, false, false, "Ho Hoang711", null, "User", null, 0 },
                    { new Guid("090f7307-0724-4141-b2b7-311a15d387a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76716716@gmail.com", "NamDepTRai716", "Hashed_password_02", null, false, false, "Ho Hoang716", null, "User", null, 0 },
                    { new Guid("09114738-0cd5-4417-8cba-c948605a4f39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763535@gmail.com", "NamDepTRai35", "Hashed_password_02", null, false, false, "Ho Hoang35", null, "User", null, 0 },
                    { new Guid("09aac9ec-d4eb-45e9-b3ff-884852272aeb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76828828@gmail.com", "NamDepTRai828", "Hashed_password_02", null, false, false, "Ho Hoang828", null, "User", null, 0 },
                    { new Guid("09ee9c7e-22ca-4661-b015-6dcd7ddbceff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76257257@gmail.com", "NamDepTRai257", "Hashed_password_02", null, false, false, "Ho Hoang257", null, "User", null, 0 },
                    { new Guid("0a103841-d64a-4d6d-a5f1-fb94f597437c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76353353@gmail.com", "NamDepTRai353", "Hashed_password_02", null, false, false, "Ho Hoang353", null, "User", null, 0 },
                    { new Guid("0a7fbcc4-8210-4ae6-9def-402dec2bc09e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764040@gmail.com", "NamDepTRai40", "Hashed_password_02", null, false, false, "Ho Hoang40", null, "User", null, 0 },
                    { new Guid("0af2d546-83c3-4f49-8816-3ca4ab4664f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76511511@gmail.com", "NamDepTRai511", "Hashed_password_02", null, false, false, "Ho Hoang511", null, "User", null, 0 },
                    { new Guid("0b7595a1-1d32-42e0-bada-7289c08de942"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76455455@gmail.com", "NamDepTRai455", "Hashed_password_02", null, false, false, "Ho Hoang455", null, "User", null, 0 },
                    { new Guid("0b864d48-53bc-4668-9927-587db255af27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76128128@gmail.com", "NamDepTRai128", "Hashed_password_02", null, false, false, "Ho Hoang128", null, "User", null, 0 },
                    { new Guid("0b9dee37-803a-433f-bb9b-d39fcbf8d3d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76161161@gmail.com", "NamDepTRai161", "Hashed_password_02", null, false, false, "Ho Hoang161", null, "User", null, 0 },
                    { new Guid("0bcc34e6-89dc-44c2-b87b-f7261e3632db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76486486@gmail.com", "NamDepTRai486", "Hashed_password_02", null, false, false, "Ho Hoang486", null, "User", null, 0 },
                    { new Guid("0c412f7a-cd29-4437-ba9d-a2be766534f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76191191@gmail.com", "NamDepTRai191", "Hashed_password_02", null, false, false, "Ho Hoang191", null, "User", null, 0 },
                    { new Guid("0ca81e54-b456-4481-a16a-f32ea46ca162"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76339339@gmail.com", "NamDepTRai339", "Hashed_password_02", null, false, false, "Ho Hoang339", null, "User", null, 0 },
                    { new Guid("0cd5acaa-e111-41bc-b578-44ee533ba456"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76194194@gmail.com", "NamDepTRai194", "Hashed_password_02", null, false, false, "Ho Hoang194", null, "User", null, 0 },
                    { new Guid("0cff1139-cdfd-4b17-ab6a-0f5a593911ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76549549@gmail.com", "NamDepTRai549", "Hashed_password_02", null, false, false, "Ho Hoang549", null, "User", null, 0 },
                    { new Guid("0d7182f1-c5ed-4a15-b4c8-ce86ffbf116d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764848@gmail.com", "NamDepTRai48", "Hashed_password_02", null, false, false, "Ho Hoang48", null, "User", null, 0 },
                    { new Guid("0d84a4a3-fc6b-4bf6-a080-8d8164f42698"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76368368@gmail.com", "NamDepTRai368", "Hashed_password_02", null, false, false, "Ho Hoang368", null, "User", null, 0 },
                    { new Guid("0d92f4b7-f269-482a-8b3f-ff9554b16379"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76502502@gmail.com", "NamDepTRai502", "Hashed_password_02", null, false, false, "Ho Hoang502", null, "User", null, 0 },
                    { new Guid("0dbde706-1dee-4067-9abb-31a2ae172987"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76796796@gmail.com", "NamDepTRai796", "Hashed_password_02", null, false, false, "Ho Hoang796", null, "User", null, 0 },
                    { new Guid("0e224479-f8d9-4ded-97e1-1192a1397505"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76756756@gmail.com", "NamDepTRai756", "Hashed_password_02", null, false, false, "Ho Hoang756", null, "User", null, 0 },
                    { new Guid("0e23782e-6964-41d8-988b-e932a41bb1bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76876876@gmail.com", "NamDepTRai876", "Hashed_password_02", null, false, false, "Ho Hoang876", null, "User", null, 0 },
                    { new Guid("0eb36172-8712-4712-86fb-b653f4be8876"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76697697@gmail.com", "NamDepTRai697", "Hashed_password_02", null, false, false, "Ho Hoang697", null, "User", null, 0 },
                    { new Guid("0ed6ce42-405c-4902-a3e8-91437ac4dd0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765050@gmail.com", "NamDepTRai50", "Hashed_password_02", null, false, false, "Ho Hoang50", null, "User", null, 0 },
                    { new Guid("0f823b09-7eba-4697-865b-4629fd550cf9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76836836@gmail.com", "NamDepTRai836", "Hashed_password_02", null, false, false, "Ho Hoang836", null, "User", null, 0 },
                    { new Guid("0fae2b55-1ea6-4578-adaf-70e3862928c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76438438@gmail.com", "NamDepTRai438", "Hashed_password_02", null, false, false, "Ho Hoang438", null, "User", null, 0 },
                    { new Guid("10a46572-c2e2-42b8-8a17-102f64b79df6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76600600@gmail.com", "NamDepTRai600", "Hashed_password_02", null, false, false, "Ho Hoang600", null, "User", null, 0 },
                    { new Guid("10b625d5-a246-4237-a1e5-4f59f1375851"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76573573@gmail.com", "NamDepTRai573", "Hashed_password_02", null, false, false, "Ho Hoang573", null, "User", null, 0 },
                    { new Guid("10cf3d11-be03-402b-9477-35643db5575f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76538538@gmail.com", "NamDepTRai538", "Hashed_password_02", null, false, false, "Ho Hoang538", null, "User", null, 0 },
                    { new Guid("1107c877-4c7e-47d0-b7e2-efff2285b330"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76605605@gmail.com", "NamDepTRai605", "Hashed_password_02", null, false, false, "Ho Hoang605", null, "User", null, 0 },
                    { new Guid("11621e91-69eb-4bff-b5a7-02ca99fb2122"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76846846@gmail.com", "NamDepTRai846", "Hashed_password_02", null, false, false, "Ho Hoang846", null, "User", null, 0 },
                    { new Guid("1177862a-af10-4b09-a6da-3d7dadc40f53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76981981@gmail.com", "NamDepTRai981", "Hashed_password_02", null, false, false, "Ho Hoang981", null, "User", null, 0 },
                    { new Guid("12471578-bdf0-4b96-bccd-61c3a1396d55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76156156@gmail.com", "NamDepTRai156", "Hashed_password_02", null, false, false, "Ho Hoang156", null, "User", null, 0 },
                    { new Guid("12da35d2-029c-432d-8912-e2d5e518d19c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76847847@gmail.com", "NamDepTRai847", "Hashed_password_02", null, false, false, "Ho Hoang847", null, "User", null, 0 },
                    { new Guid("12f779e7-0df0-478e-a96b-510a6066fb4d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76733733@gmail.com", "NamDepTRai733", "Hashed_password_02", null, false, false, "Ho Hoang733", null, "User", null, 0 },
                    { new Guid("140f968b-7d15-4d71-860e-740bf400ddfb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76879879@gmail.com", "NamDepTRai879", "Hashed_password_02", null, false, false, "Ho Hoang879", null, "User", null, 0 },
                    { new Guid("14610ee7-22d1-4e43-a104-1e62c629dbf6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76568568@gmail.com", "NamDepTRai568", "Hashed_password_02", null, false, false, "Ho Hoang568", null, "User", null, 0 },
                    { new Guid("14875e81-cc55-48b6-ba30-72ef968c1340"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76918918@gmail.com", "NamDepTRai918", "Hashed_password_02", null, false, false, "Ho Hoang918", null, "User", null, 0 },
                    { new Guid("1491b070-03ca-4076-8493-40a50a88417e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76329329@gmail.com", "NamDepTRai329", "Hashed_password_02", null, false, false, "Ho Hoang329", null, "User", null, 0 },
                    { new Guid("14c1a64f-eb56-469d-9584-3bb57fe07128"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76265265@gmail.com", "NamDepTRai265", "Hashed_password_02", null, false, false, "Ho Hoang265", null, "User", null, 0 },
                    { new Guid("154689f2-a66c-489e-aaac-f4076a3b440a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76917917@gmail.com", "NamDepTRai917", "Hashed_password_02", null, false, false, "Ho Hoang917", null, "User", null, 0 },
                    { new Guid("155f693e-e44a-4139-a277-9f9f37f7aa02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76199199@gmail.com", "NamDepTRai199", "Hashed_password_02", null, false, false, "Ho Hoang199", null, "User", null, 0 },
                    { new Guid("168d12d4-1a72-4d5a-8fd6-830521fc8097"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76237237@gmail.com", "NamDepTRai237", "Hashed_password_02", null, false, false, "Ho Hoang237", null, "User", null, 0 },
                    { new Guid("16e18d2a-478e-4b20-b16d-779b32837ad7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76582582@gmail.com", "NamDepTRai582", "Hashed_password_02", null, false, false, "Ho Hoang582", null, "User", null, 0 },
                    { new Guid("171c080f-c47e-4b39-859d-84b9b876f0a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76475475@gmail.com", "NamDepTRai475", "Hashed_password_02", null, false, false, "Ho Hoang475", null, "User", null, 0 },
                    { new Guid("17281cb3-b09b-4e0f-bd47-b017eecbd9f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76870870@gmail.com", "NamDepTRai870", "Hashed_password_02", null, false, false, "Ho Hoang870", null, "User", null, 0 },
                    { new Guid("1765bfc7-61f7-40f7-a9a6-7cd81fdbedd3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76489489@gmail.com", "NamDepTRai489", "Hashed_password_02", null, false, false, "Ho Hoang489", null, "User", null, 0 },
                    { new Guid("1777c268-1e1d-43dd-803c-4b3bc29da1b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76533533@gmail.com", "NamDepTRai533", "Hashed_password_02", null, false, false, "Ho Hoang533", null, "User", null, 0 },
                    { new Guid("17cc9051-639f-4aa5-8d05-be7e1e8296dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76278278@gmail.com", "NamDepTRai278", "Hashed_password_02", null, false, false, "Ho Hoang278", null, "User", null, 0 },
                    { new Guid("17d4d8a5-38f0-4a7a-a25e-ed8de4f245df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76818818@gmail.com", "NamDepTRai818", "Hashed_password_02", null, false, false, "Ho Hoang818", null, "User", null, 0 },
                    { new Guid("17e831a0-9dc2-474d-b944-c2561a784eaf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76240240@gmail.com", "NamDepTRai240", "Hashed_password_02", null, false, false, "Ho Hoang240", null, "User", null, 0 },
                    { new Guid("1801e74a-96a4-428a-a9ef-8c54d2d42f4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76631631@gmail.com", "NamDepTRai631", "Hashed_password_02", null, false, false, "Ho Hoang631", null, "User", null, 0 },
                    { new Guid("18d46ba3-8cc0-4642-93d5-0f70b5cb4654"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76561561@gmail.com", "NamDepTRai561", "Hashed_password_02", null, false, false, "Ho Hoang561", null, "User", null, 0 },
                    { new Guid("19124c1e-602b-49c2-9ce2-dfa489c30142"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76634634@gmail.com", "NamDepTRai634", "Hashed_password_02", null, false, false, "Ho Hoang634", null, "User", null, 0 },
                    { new Guid("199ff079-5989-400e-9c3a-47f851b6ebc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769191@gmail.com", "NamDepTRai91", "Hashed_password_02", null, false, false, "Ho Hoang91", null, "User", null, 0 },
                    { new Guid("19a04223-475e-4ee5-80a1-6c51c7f1a9a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76931931@gmail.com", "NamDepTRai931", "Hashed_password_02", null, false, false, "Ho Hoang931", null, "User", null, 0 },
                    { new Guid("19b3c3bf-a0fc-426c-b3d9-fd5b42c405fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76388388@gmail.com", "NamDepTRai388", "Hashed_password_02", null, false, false, "Ho Hoang388", null, "User", null, 0 },
                    { new Guid("19bf6224-fa9a-4390-9c0e-d359d07bfb53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76357357@gmail.com", "NamDepTRai357", "Hashed_password_02", null, false, false, "Ho Hoang357", null, "User", null, 0 },
                    { new Guid("19fd19f6-091b-4959-ba02-9f8137921138"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76231231@gmail.com", "NamDepTRai231", "Hashed_password_02", null, false, false, "Ho Hoang231", null, "User", null, 0 },
                    { new Guid("1a4201cc-52b4-4acb-8447-ca2a92166af9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76633633@gmail.com", "NamDepTRai633", "Hashed_password_02", null, false, false, "Ho Hoang633", null, "User", null, 0 },
                    { new Guid("1a57279d-7f0d-45c5-9314-5afeabc0c97a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76407407@gmail.com", "NamDepTRai407", "Hashed_password_02", null, false, false, "Ho Hoang407", null, "User", null, 0 },
                    { new Guid("1a60f4b8-f7df-45da-bc25-20436d972e90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76972972@gmail.com", "NamDepTRai972", "Hashed_password_02", null, false, false, "Ho Hoang972", null, "User", null, 0 },
                    { new Guid("1ad06c68-d4db-49c7-b7a1-a22c56803273"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76423423@gmail.com", "NamDepTRai423", "Hashed_password_02", null, false, false, "Ho Hoang423", null, "User", null, 0 },
                    { new Guid("1afe631b-f233-482a-ba6d-3924861f7257"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76281281@gmail.com", "NamDepTRai281", "Hashed_password_02", null, false, false, "Ho Hoang281", null, "User", null, 0 },
                    { new Guid("1b4f586f-801f-48bc-93bc-22db197d2f7e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76129129@gmail.com", "NamDepTRai129", "Hashed_password_02", null, false, false, "Ho Hoang129", null, "User", null, 0 },
                    { new Guid("1b5b1c14-2d01-4a7b-bb3d-e01b8c803ad7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76585585@gmail.com", "NamDepTRai585", "Hashed_password_02", null, false, false, "Ho Hoang585", null, "User", null, 0 },
                    { new Guid("1b928690-2e85-4107-9670-aefd4ddd0396"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76425425@gmail.com", "NamDepTRai425", "Hashed_password_02", null, false, false, "Ho Hoang425", null, "User", null, 0 },
                    { new Guid("1bbc7e2e-ab08-4110-af96-d15f200a59a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76657657@gmail.com", "NamDepTRai657", "Hashed_password_02", null, false, false, "Ho Hoang657", null, "User", null, 0 },
                    { new Guid("1bbf4805-f266-4975-beeb-b492110217b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76862862@gmail.com", "NamDepTRai862", "Hashed_password_02", null, false, false, "Ho Hoang862", null, "User", null, 0 },
                    { new Guid("1c091c01-d255-4ddb-8b3a-fe71d95adb4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76899899@gmail.com", "NamDepTRai899", "Hashed_password_02", null, false, false, "Ho Hoang899", null, "User", null, 0 },
                    { new Guid("1c905163-251f-4ea7-899a-9c54da62a2e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76477477@gmail.com", "NamDepTRai477", "Hashed_password_02", null, false, false, "Ho Hoang477", null, "User", null, 0 },
                    { new Guid("1cbd8abf-5887-4116-a81b-35570bf1de7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76829829@gmail.com", "NamDepTRai829", "Hashed_password_02", null, false, false, "Ho Hoang829", null, "User", null, 0 },
                    { new Guid("1d28b171-019b-461a-b832-ed2c2692fcb5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76460460@gmail.com", "NamDepTRai460", "Hashed_password_02", null, false, false, "Ho Hoang460", null, "User", null, 0 },
                    { new Guid("1d361828-18ee-40a4-a4ad-92ace500bb62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76795795@gmail.com", "NamDepTRai795", "Hashed_password_02", null, false, false, "Ho Hoang795", null, "User", null, 0 },
                    { new Guid("1d47a286-2bc3-4350-814c-9bb143c6ae8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76629629@gmail.com", "NamDepTRai629", "Hashed_password_02", null, false, false, "Ho Hoang629", null, "User", null, 0 },
                    { new Guid("1d7856fd-a8b3-4f2d-ab9b-26fea7558022"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76707707@gmail.com", "NamDepTRai707", "Hashed_password_02", null, false, false, "Ho Hoang707", null, "User", null, 0 },
                    { new Guid("1d8dd120-2c53-4605-8043-dcdeb5337387"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76720720@gmail.com", "NamDepTRai720", "Hashed_password_02", null, false, false, "Ho Hoang720", null, "User", null, 0 },
                    { new Guid("1dbbcd0d-8435-4af5-a8bd-704278f09c3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76686686@gmail.com", "NamDepTRai686", "Hashed_password_02", null, false, false, "Ho Hoang686", null, "User", null, 0 },
                    { new Guid("1dc44770-2eb6-4863-a6aa-675c4c47409d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76384384@gmail.com", "NamDepTRai384", "Hashed_password_02", null, false, false, "Ho Hoang384", null, "User", null, 0 },
                    { new Guid("1dec8ae4-f6ab-4935-ae93-c44f0f51098f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769393@gmail.com", "NamDepTRai93", "Hashed_password_02", null, false, false, "Ho Hoang93", null, "User", null, 0 },
                    { new Guid("1defad10-d0d7-4a89-9506-89cc860a229a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76317317@gmail.com", "NamDepTRai317", "Hashed_password_02", null, false, false, "Ho Hoang317", null, "User", null, 0 },
                    { new Guid("1e57f65a-2aab-4a78-b3d6-7aa601fb5489"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76239239@gmail.com", "NamDepTRai239", "Hashed_password_02", null, false, false, "Ho Hoang239", null, "User", null, 0 },
                    { new Guid("1e67574b-025b-4f34-b659-8254402c9610"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76308308@gmail.com", "NamDepTRai308", "Hashed_password_02", null, false, false, "Ho Hoang308", null, "User", null, 0 },
                    { new Guid("1eccf52b-ad12-4f90-b0dd-a1b65dade942"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76298298@gmail.com", "NamDepTRai298", "Hashed_password_02", null, false, false, "Ho Hoang298", null, "User", null, 0 },
                    { new Guid("1ecdb422-610a-4f0e-bbfa-963b8664e430"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76798798@gmail.com", "NamDepTRai798", "Hashed_password_02", null, false, false, "Ho Hoang798", null, "User", null, 0 },
                    { new Guid("1ee884e9-b6ff-4c35-b0b3-d1ddf4f22bd0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76464464@gmail.com", "NamDepTRai464", "Hashed_password_02", null, false, false, "Ho Hoang464", null, "User", null, 0 },
                    { new Guid("1fa39a25-54dc-45ae-a4c7-392caa68efef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767373@gmail.com", "NamDepTRai73", "Hashed_password_02", null, false, false, "Ho Hoang73", null, "User", null, 0 },
                    { new Guid("1fbdf169-749b-4465-a552-c88ac8a03456"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76323323@gmail.com", "NamDepTRai323", "Hashed_password_02", null, false, false, "Ho Hoang323", null, "User", null, 0 },
                    { new Guid("2012701f-b741-43ba-bd7c-d0c95ed16528"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76535535@gmail.com", "NamDepTRai535", "Hashed_password_02", null, false, false, "Ho Hoang535", null, "User", null, 0 },
                    { new Guid("2045c2f3-840c-467f-acbd-4ba5271cd518"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76621621@gmail.com", "NamDepTRai621", "Hashed_password_02", null, false, false, "Ho Hoang621", null, "User", null, 0 },
                    { new Guid("209e3ace-f628-4bdf-a6a7-d696efc0fc37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76808808@gmail.com", "NamDepTRai808", "Hashed_password_02", null, false, false, "Ho Hoang808", null, "User", null, 0 },
                    { new Guid("20a7e071-9e5e-4f66-9bb3-7bef38096be2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76352352@gmail.com", "NamDepTRai352", "Hashed_password_02", null, false, false, "Ho Hoang352", null, "User", null, 0 },
                    { new Guid("20cd2c4f-dc43-424d-8fea-f8b68206a49a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769090@gmail.com", "NamDepTRai90", "Hashed_password_02", null, false, false, "Ho Hoang90", null, "User", null, 0 },
                    { new Guid("21186c44-8c32-4790-87e8-f8aafacdf617"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76963963@gmail.com", "NamDepTRai963", "Hashed_password_02", null, false, false, "Ho Hoang963", null, "User", null, 0 },
                    { new Guid("211c7190-4d46-4b77-9ae4-c3fa805a7ce8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76556556@gmail.com", "NamDepTRai556", "Hashed_password_02", null, false, false, "Ho Hoang556", null, "User", null, 0 },
                    { new Guid("215416bd-0fe2-4f7f-975e-b5eff8f80b4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76258258@gmail.com", "NamDepTRai258", "Hashed_password_02", null, false, false, "Ho Hoang258", null, "User", null, 0 },
                    { new Guid("2167e5c1-e9e7-421b-a205-36c72dc752ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76801801@gmail.com", "NamDepTRai801", "Hashed_password_02", null, false, false, "Ho Hoang801", null, "User", null, 0 },
                    { new Guid("2181c6c1-9072-4d2c-87ce-62cd2329bf78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76315315@gmail.com", "NamDepTRai315", "Hashed_password_02", null, false, false, "Ho Hoang315", null, "User", null, 0 },
                    { new Guid("21c74d32-1c95-4059-a2ca-7e6f7c1687aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762525@gmail.com", "NamDepTRai25", "Hashed_password_02", null, false, false, "Ho Hoang25", null, "User", null, 0 },
                    { new Guid("21ca01c0-d576-4377-8f10-e5263b6d4b3c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76304304@gmail.com", "NamDepTRai304", "Hashed_password_02", null, false, false, "Ho Hoang304", null, "User", null, 0 },
                    { new Guid("21d4152e-ede2-4cdc-97c2-f968c53e71ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762121@gmail.com", "NamDepTRai21", "Hashed_password_02", null, false, false, "Ho Hoang21", null, "User", null, 0 },
                    { new Guid("2299d199-f6a9-4814-903b-065afa63c52d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76271271@gmail.com", "NamDepTRai271", "Hashed_password_02", null, false, false, "Ho Hoang271", null, "User", null, 0 },
                    { new Guid("22d4246b-0d60-464b-9a8b-562ac80bd333"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76781781@gmail.com", "NamDepTRai781", "Hashed_password_02", null, false, false, "Ho Hoang781", null, "User", null, 0 },
                    { new Guid("22de3890-45f3-4bca-84d3-7bd4eaa42195"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761111@gmail.com", "NamDepTRai11", "Hashed_password_02", null, false, false, "Ho Hoang11", null, "User", null, 0 },
                    { new Guid("23967030-a868-4621-8ffb-e0efe366ab42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76758758@gmail.com", "NamDepTRai758", "Hashed_password_02", null, false, false, "Ho Hoang758", null, "User", null, 0 },
                    { new Guid("23c0243f-11a5-432e-8387-d742db36ea5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76940940@gmail.com", "NamDepTRai940", "Hashed_password_02", null, false, false, "Ho Hoang940", null, "User", null, 0 },
                    { new Guid("23db39c2-0365-4079-b6c3-094c14a0fb43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76855855@gmail.com", "NamDepTRai855", "Hashed_password_02", null, false, false, "Ho Hoang855", null, "User", null, 0 },
                    { new Guid("23f78e1a-a59b-421f-919d-223fc892c8db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76591591@gmail.com", "NamDepTRai591", "Hashed_password_02", null, false, false, "Ho Hoang591", null, "User", null, 0 },
                    { new Guid("244063a8-e3a7-40e1-a210-e7f7e4684567"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76260260@gmail.com", "NamDepTRai260", "Hashed_password_02", null, false, false, "Ho Hoang260", null, "User", null, 0 },
                    { new Guid("244e9e46-50e4-41de-a100-d177cc381aaf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76969969@gmail.com", "NamDepTRai969", "Hashed_password_02", null, false, false, "Ho Hoang969", null, "User", null, 0 },
                    { new Guid("24cc652a-b535-4ff2-b7d4-7e57210f6d0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76860860@gmail.com", "NamDepTRai860", "Hashed_password_02", null, false, false, "Ho Hoang860", null, "User", null, 0 },
                    { new Guid("2508ef94-cd48-4ed6-85b0-3f195ec256f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76647647@gmail.com", "NamDepTRai647", "Hashed_password_02", null, false, false, "Ho Hoang647", null, "User", null, 0 },
                    { new Guid("250db92f-e6c8-4521-8974-8de2ff07f233"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76834834@gmail.com", "NamDepTRai834", "Hashed_password_02", null, false, false, "Ho Hoang834", null, "User", null, 0 },
                    { new Guid("25543b7f-8d40-40ee-baf6-fc63cecab1a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763232@gmail.com", "NamDepTRai32", "Hashed_password_02", null, false, false, "Ho Hoang32", null, "User", null, 0 },
                    { new Guid("2578519d-2514-49db-8c48-ae083d7fa8eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76945945@gmail.com", "NamDepTRai945", "Hashed_password_02", null, false, false, "Ho Hoang945", null, "User", null, 0 },
                    { new Guid("265011c1-4d67-483b-ab62-9e60ac84f320"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76817817@gmail.com", "NamDepTRai817", "Hashed_password_02", null, false, false, "Ho Hoang817", null, "User", null, 0 },
                    { new Guid("265ab674-a5de-40e2-afeb-60156a6f40af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76202202@gmail.com", "NamDepTRai202", "Hashed_password_02", null, false, false, "Ho Hoang202", null, "User", null, 0 },
                    { new Guid("266e381e-8593-4c2e-a86d-7ced98ad017b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76498498@gmail.com", "NamDepTRai498", "Hashed_password_02", null, false, false, "Ho Hoang498", null, "User", null, 0 },
                    { new Guid("26a10c4f-f72d-4829-9a5f-200cc6d816b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761313@gmail.com", "NamDepTRai13", "Hashed_password_02", null, false, false, "Ho Hoang13", null, "User", null, 0 },
                    { new Guid("26ac49be-27e4-4fae-bda4-9d61764cb0bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76389389@gmail.com", "NamDepTRai389", "Hashed_password_02", null, false, false, "Ho Hoang389", null, "User", null, 0 },
                    { new Guid("26ccb2c1-691e-449a-b253-d011bdc1ee61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765353@gmail.com", "NamDepTRai53", "Hashed_password_02", null, false, false, "Ho Hoang53", null, "User", null, 0 },
                    { new Guid("26e459d2-9d01-4e3c-ab5d-d88d423118cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76270270@gmail.com", "NamDepTRai270", "Hashed_password_02", null, false, false, "Ho Hoang270", null, "User", null, 0 },
                    { new Guid("271f4731-a2dc-49b0-8afb-421a062a5ee7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7622@gmail.com", "NamDepTRai2", "Hashed_password_02", null, false, false, "Ho Hoang2", null, "User", null, 0 },
                    { new Guid("272e704a-90f7-42ed-94a0-b9dda98bda48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76483483@gmail.com", "NamDepTRai483", "Hashed_password_02", null, false, false, "Ho Hoang483", null, "User", null, 0 },
                    { new Guid("277de574-bc80-40a7-b37f-4f8476cf07c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76742742@gmail.com", "NamDepTRai742", "Hashed_password_02", null, false, false, "Ho Hoang742", null, "User", null, 0 },
                    { new Guid("27d0ffc0-364a-4f50-8325-6e4e24b9a873"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76877877@gmail.com", "NamDepTRai877", "Hashed_password_02", null, false, false, "Ho Hoang877", null, "User", null, 0 },
                    { new Guid("2824a1a4-779b-4f08-8fd5-56ab3230b3a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76887887@gmail.com", "NamDepTRai887", "Hashed_password_02", null, false, false, "Ho Hoang887", null, "User", null, 0 },
                    { new Guid("282f46c4-8d26-414e-8ba1-ac31b45f47d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76138138@gmail.com", "NamDepTRai138", "Hashed_password_02", null, false, false, "Ho Hoang138", null, "User", null, 0 },
                    { new Guid("283ccb27-f3a6-4e7e-90bb-f85b184c4d9b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76500500@gmail.com", "NamDepTRai500", "Hashed_password_02", null, false, false, "Ho Hoang500", null, "User", null, 0 },
                    { new Guid("28baa8af-ae9b-417f-93e9-70aa08002766"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76378378@gmail.com", "NamDepTRai378", "Hashed_password_02", null, false, false, "Ho Hoang378", null, "User", null, 0 },
                    { new Guid("28c25f28-6084-468c-88bd-2e836cf86752"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76769769@gmail.com", "NamDepTRai769", "Hashed_password_02", null, false, false, "Ho Hoang769", null, "User", null, 0 },
                    { new Guid("28f9d874-33dc-4d57-8c17-e04fd5c819e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76410410@gmail.com", "NamDepTRai410", "Hashed_password_02", null, false, false, "Ho Hoang410", null, "User", null, 0 },
                    { new Guid("297d5a24-8637-4ffc-b0b1-4166f6bdf0d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767676@gmail.com", "NamDepTRai76", "Hashed_password_02", null, false, false, "Ho Hoang76", null, "User", null, 0 },
                    { new Guid("29b842e4-5ce9-4658-ba36-97e087144ad9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76153153@gmail.com", "NamDepTRai153", "Hashed_password_02", null, false, false, "Ho Hoang153", null, "User", null, 0 },
                    { new Guid("29ecc58d-b600-4450-af5c-e1fbac293e1f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76401401@gmail.com", "NamDepTRai401", "Hashed_password_02", null, false, false, "Ho Hoang401", null, "User", null, 0 },
                    { new Guid("2a0e007a-4e23-474b-b785-1f7943592bc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76158158@gmail.com", "NamDepTRai158", "Hashed_password_02", null, false, false, "Ho Hoang158", null, "User", null, 0 },
                    { new Guid("2a738d5f-a62b-4a8b-bb50-4c381e7004ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76222222@gmail.com", "NamDepTRai222", "Hashed_password_02", null, false, false, "Ho Hoang222", null, "User", null, 0 },
                    { new Guid("2afa83a3-ef50-4472-b7e4-c5ac4be1067f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76119119@gmail.com", "NamDepTRai119", "Hashed_password_02", null, false, false, "Ho Hoang119", null, "User", null, 0 },
                    { new Guid("2b28e803-6d94-481d-9a5c-924c1e561778"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76988988@gmail.com", "NamDepTRai988", "Hashed_password_02", null, false, false, "Ho Hoang988", null, "User", null, 0 },
                    { new Guid("2bb9740e-7648-4b03-b92c-3e2beb0ab3fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768080@gmail.com", "NamDepTRai80", "Hashed_password_02", null, false, false, "Ho Hoang80", null, "User", null, 0 },
                    { new Guid("2cc63d79-e0a9-491d-8c5b-172ccd97af6e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76536536@gmail.com", "NamDepTRai536", "Hashed_password_02", null, false, false, "Ho Hoang536", null, "User", null, 0 },
                    { new Guid("2d5515c0-9af1-476c-bdbf-59af37cab772"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76669669@gmail.com", "NamDepTRai669", "Hashed_password_02", null, false, false, "Ho Hoang669", null, "User", null, 0 },
                    { new Guid("2d9b3572-a76a-4e71-ae37-75f3810d8ea8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76473473@gmail.com", "NamDepTRai473", "Hashed_password_02", null, false, false, "Ho Hoang473", null, "User", null, 0 },
                    { new Guid("2db31f55-3156-4d08-827c-112e60e4aa20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76364364@gmail.com", "NamDepTRai364", "Hashed_password_02", null, false, false, "Ho Hoang364", null, "User", null, 0 },
                    { new Guid("2dd97bbf-8671-4df4-8a1d-339f4c713927"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76242242@gmail.com", "NamDepTRai242", "Hashed_password_02", null, false, false, "Ho Hoang242", null, "User", null, 0 },
                    { new Guid("2de3875a-7a13-4bf6-815a-0984ec1507ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76916916@gmail.com", "NamDepTRai916", "Hashed_password_02", null, false, false, "Ho Hoang916", null, "User", null, 0 },
                    { new Guid("2e2aef3b-8f87-4ae0-99c9-da2f294274a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76786786@gmail.com", "NamDepTRai786", "Hashed_password_02", null, false, false, "Ho Hoang786", null, "User", null, 0 },
                    { new Guid("2e2dc75e-a42e-4a50-8f7e-2a1809fb168f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76683683@gmail.com", "NamDepTRai683", "Hashed_password_02", null, false, false, "Ho Hoang683", null, "User", null, 0 },
                    { new Guid("2e6c1a6c-ccf1-409b-ac48-eab378950caa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76205205@gmail.com", "NamDepTRai205", "Hashed_password_02", null, false, false, "Ho Hoang205", null, "User", null, 0 },
                    { new Guid("2e716c79-752a-4684-8574-7d58ae9ef323"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76990990@gmail.com", "NamDepTRai990", "Hashed_password_02", null, false, false, "Ho Hoang990", null, "User", null, 0 },
                    { new Guid("2e9af078-27e3-483f-8574-8496b998a626"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76385385@gmail.com", "NamDepTRai385", "Hashed_password_02", null, false, false, "Ho Hoang385", null, "User", null, 0 },
                    { new Guid("2f799cd4-dc04-4689-8b2c-fa873154cddf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766767@gmail.com", "NamDepTRai67", "Hashed_password_02", null, false, false, "Ho Hoang67", null, "User", null, 0 },
                    { new Guid("2fb2e884-96dc-47e3-9534-0c33ea25b6af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76766766@gmail.com", "NamDepTRai766", "Hashed_password_02", null, false, false, "Ho Hoang766", null, "User", null, 0 },
                    { new Guid("2fed2f91-3593-4875-9b28-bacbe1ac927b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76496496@gmail.com", "NamDepTRai496", "Hashed_password_02", null, false, false, "Ho Hoang496", null, "User", null, 0 },
                    { new Guid("2ffb99d1-c8da-4a0f-aa54-62f6ef128706"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76991991@gmail.com", "NamDepTRai991", "Hashed_password_02", null, false, false, "Ho Hoang991", null, "User", null, 0 },
                    { new Guid("308b8076-0978-42c4-893b-e277f7ce4b22"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76893893@gmail.com", "NamDepTRai893", "Hashed_password_02", null, false, false, "Ho Hoang893", null, "User", null, 0 },
                    { new Guid("30c1dbf0-9af7-4020-94ca-51904b5c4626"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76141141@gmail.com", "NamDepTRai141", "Hashed_password_02", null, false, false, "Ho Hoang141", null, "User", null, 0 },
                    { new Guid("3104a5f2-2058-42d1-b139-0ea5bfccacab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76437437@gmail.com", "NamDepTRai437", "Hashed_password_02", null, false, false, "Ho Hoang437", null, "User", null, 0 },
                    { new Guid("31171219-9772-45bb-86f4-419737f948d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76277277@gmail.com", "NamDepTRai277", "Hashed_password_02", null, false, false, "Ho Hoang277", null, "User", null, 0 },
                    { new Guid("312c85a4-898a-4b69-ac21-de91e79ccb1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76429429@gmail.com", "NamDepTRai429", "Hashed_password_02", null, false, false, "Ho Hoang429", null, "User", null, 0 },
                    { new Guid("3149f220-4a6a-4a61-b957-b30f26d9ddfe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76336336@gmail.com", "NamDepTRai336", "Hashed_password_02", null, false, false, "Ho Hoang336", null, "User", null, 0 },
                    { new Guid("31a456ca-2ff8-4dc7-bd2b-2ab0e3981c12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76567567@gmail.com", "NamDepTRai567", "Hashed_password_02", null, false, false, "Ho Hoang567", null, "User", null, 0 },
                    { new Guid("31a5f75c-a66b-45b8-9945-a874c5f251a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76708708@gmail.com", "NamDepTRai708", "Hashed_password_02", null, false, false, "Ho Hoang708", null, "User", null, 0 },
                    { new Guid("31e93522-9e7d-437a-9810-62ab63bb9c9c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76874874@gmail.com", "NamDepTRai874", "Hashed_password_02", null, false, false, "Ho Hoang874", null, "User", null, 0 },
                    { new Guid("31fbd336-374d-40e5-aa06-52841fe6c30e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76295295@gmail.com", "NamDepTRai295", "Hashed_password_02", null, false, false, "Ho Hoang295", null, "User", null, 0 },
                    { new Guid("324b2b11-ddb5-4519-bbc2-50fa4413e27a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76807807@gmail.com", "NamDepTRai807", "Hashed_password_02", null, false, false, "Ho Hoang807", null, "User", null, 0 },
                    { new Guid("3250c4fe-69cd-4d9b-b014-7e932b27bc90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76303303@gmail.com", "NamDepTRai303", "Hashed_password_02", null, false, false, "Ho Hoang303", null, "User", null, 0 },
                    { new Guid("32708346-81b9-4ccb-9d50-4a88329d0e12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76312312@gmail.com", "NamDepTRai312", "Hashed_password_02", null, false, false, "Ho Hoang312", null, "User", null, 0 },
                    { new Guid("32d39ee3-fbb8-42d8-89e2-f62b1d9369da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76145145@gmail.com", "NamDepTRai145", "Hashed_password_02", null, false, false, "Ho Hoang145", null, "User", null, 0 },
                    { new Guid("32ef35dc-b3cd-45a6-8413-ee024c854d80"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76541541@gmail.com", "NamDepTRai541", "Hashed_password_02", null, false, false, "Ho Hoang541", null, "User", null, 0 },
                    { new Guid("33ab5390-fb75-4f37-9024-ea321a100968"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76736736@gmail.com", "NamDepTRai736", "Hashed_password_02", null, false, false, "Ho Hoang736", null, "User", null, 0 },
                    { new Guid("33f28969-21d3-4813-b7ca-5b5c445c3f4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76441441@gmail.com", "NamDepTRai441", "Hashed_password_02", null, false, false, "Ho Hoang441", null, "User", null, 0 },
                    { new Guid("340e4092-6030-4b1f-ba0d-205c5cb9594e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76859859@gmail.com", "NamDepTRai859", "Hashed_password_02", null, false, false, "Ho Hoang859", null, "User", null, 0 },
                    { new Guid("343057ab-48df-4448-8f67-63af0d0f6234"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76730730@gmail.com", "NamDepTRai730", "Hashed_password_02", null, false, false, "Ho Hoang730", null, "User", null, 0 },
                    { new Guid("3466d0a3-afca-4d77-b4ec-eafccb6d06fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76607607@gmail.com", "NamDepTRai607", "Hashed_password_02", null, false, false, "Ho Hoang607", null, "User", null, 0 },
                    { new Guid("34b01c3a-db51-417a-bcd2-db9ac40c884a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764444@gmail.com", "NamDepTRai44", "Hashed_password_02", null, false, false, "Ho Hoang44", null, "User", null, 0 },
                    { new Guid("35686140-b1cb-4abe-91ff-7412013950e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76757757@gmail.com", "NamDepTRai757", "Hashed_password_02", null, false, false, "Ho Hoang757", null, "User", null, 0 },
                    { new Guid("358eb4ff-9c43-4168-aa23-18a5f16794df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76247247@gmail.com", "NamDepTRai247", "Hashed_password_02", null, false, false, "Ho Hoang247", null, "User", null, 0 },
                    { new Guid("366ca04c-0a2b-4b48-bc17-51d2a7d88e9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76603603@gmail.com", "NamDepTRai603", "Hashed_password_02", null, false, false, "Ho Hoang603", null, "User", null, 0 },
                    { new Guid("3694af1e-20c6-4990-968e-21828974afa9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76331331@gmail.com", "NamDepTRai331", "Hashed_password_02", null, false, false, "Ho Hoang331", null, "User", null, 0 },
                    { new Guid("36c2c035-890d-40c3-8357-a7d1436b0650"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767878@gmail.com", "NamDepTRai78", "Hashed_password_02", null, false, false, "Ho Hoang78", null, "User", null, 0 },
                    { new Guid("36c89083-7e4d-4ec3-b051-8c49140503f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76182182@gmail.com", "NamDepTRai182", "Hashed_password_02", null, false, false, "Ho Hoang182", null, "User", null, 0 },
                    { new Guid("36da3c0c-e86f-46fa-93cd-2de839bd42b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76799799@gmail.com", "NamDepTRai799", "Hashed_password_02", null, false, false, "Ho Hoang799", null, "User", null, 0 },
                    { new Guid("37bd4355-121d-463c-ad77-1f6ea3605f86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76373373@gmail.com", "NamDepTRai373", "Hashed_password_02", null, false, false, "Ho Hoang373", null, "User", null, 0 },
                    { new Guid("3846a799-7353-433e-814a-60e94a467f25"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76497497@gmail.com", "NamDepTRai497", "Hashed_password_02", null, false, false, "Ho Hoang497", null, "User", null, 0 },
                    { new Guid("388f34a8-828d-4941-ae04-4923b74db330"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76749749@gmail.com", "NamDepTRai749", "Hashed_password_02", null, false, false, "Ho Hoang749", null, "User", null, 0 },
                    { new Guid("388f7009-fe5d-40d3-a45c-b0e08df0b605"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76354354@gmail.com", "NamDepTRai354", "Hashed_password_02", null, false, false, "Ho Hoang354", null, "User", null, 0 },
                    { new Guid("38c407ce-8278-4bbc-b0cc-44243c530b84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76289289@gmail.com", "NamDepTRai289", "Hashed_password_02", null, false, false, "Ho Hoang289", null, "User", null, 0 },
                    { new Guid("3933be7e-b605-4bb3-8620-7e0abc25fe19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766969@gmail.com", "NamDepTRai69", "Hashed_password_02", null, false, false, "Ho Hoang69", null, "User", null, 0 },
                    { new Guid("39c8d54f-778c-4f7e-96a2-171f5836f54a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76351351@gmail.com", "NamDepTRai351", "Hashed_password_02", null, false, false, "Ho Hoang351", null, "User", null, 0 },
                    { new Guid("3a2e504f-6037-462e-9232-c0e5f6d2d432"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7699@gmail.com", "NamDepTRai9", "Hashed_password_02", null, false, false, "Ho Hoang9", null, "User", null, 0 },
                    { new Guid("3a52422c-2f46-4b9a-b7de-bf769ccfd131"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76920920@gmail.com", "NamDepTRai920", "Hashed_password_02", null, false, false, "Ho Hoang920", null, "User", null, 0 },
                    { new Guid("3b51aa1e-b331-4008-b01e-d81ba6b50d35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76789789@gmail.com", "NamDepTRai789", "Hashed_password_02", null, false, false, "Ho Hoang789", null, "User", null, 0 },
                    { new Guid("3b6d7e92-90cd-42ff-8238-1f51d653cf6c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76235235@gmail.com", "NamDepTRai235", "Hashed_password_02", null, false, false, "Ho Hoang235", null, "User", null, 0 },
                    { new Guid("3c236ef8-69a6-4e4a-9e60-329fcb6d101c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76321321@gmail.com", "NamDepTRai321", "Hashed_password_02", null, false, false, "Ho Hoang321", null, "User", null, 0 },
                    { new Guid("3c527fd2-9294-42d8-884e-8a94097fd309"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76309309@gmail.com", "NamDepTRai309", "Hashed_password_02", null, false, false, "Ho Hoang309", null, "User", null, 0 },
                    { new Guid("3ca5e43d-fa47-4ba1-bcf0-f2cfd3f0ec30"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76398398@gmail.com", "NamDepTRai398", "Hashed_password_02", null, false, false, "Ho Hoang398", null, "User", null, 0 },
                    { new Guid("3ccf88e2-b4b6-442f-a291-ec7d44ec482e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76453453@gmail.com", "NamDepTRai453", "Hashed_password_02", null, false, false, "Ho Hoang453", null, "User", null, 0 },
                    { new Guid("3cf36a57-95fd-4af2-bf70-585adf97f990"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76914914@gmail.com", "NamDepTRai914", "Hashed_password_02", null, false, false, "Ho Hoang914", null, "User", null, 0 },
                    { new Guid("3d0bda25-6dc9-4520-8d34-29acb6667a03"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76973973@gmail.com", "NamDepTRai973", "Hashed_password_02", null, false, false, "Ho Hoang973", null, "User", null, 0 },
                    { new Guid("3d6ec171-7a41-496c-95ad-a48bf7eb12ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76771771@gmail.com", "NamDepTRai771", "Hashed_password_02", null, false, false, "Ho Hoang771", null, "User", null, 0 },
                    { new Guid("3db9bf35-b826-433b-80ca-83865d7bc67f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76889889@gmail.com", "NamDepTRai889", "Hashed_password_02", null, false, false, "Ho Hoang889", null, "User", null, 0 },
                    { new Guid("3de2c506-b94a-41ea-a14d-fdf8e50d67db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76751751@gmail.com", "NamDepTRai751", "Hashed_password_02", null, false, false, "Ho Hoang751", null, "User", null, 0 },
                    { new Guid("3dfef00d-cab0-41ea-8a9b-bbf21ade646f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76550550@gmail.com", "NamDepTRai550", "Hashed_password_02", null, false, false, "Ho Hoang550", null, "User", null, 0 },
                    { new Guid("3e4b94d2-4a75-487b-86a7-477aeb857d9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76345345@gmail.com", "NamDepTRai345", "Hashed_password_02", null, false, false, "Ho Hoang345", null, "User", null, 0 },
                    { new Guid("3ee5527d-761b-480a-9a59-4afa8ad42834"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76335335@gmail.com", "NamDepTRai335", "Hashed_password_02", null, false, false, "Ho Hoang335", null, "User", null, 0 },
                    { new Guid("3ef33f5b-88d0-4e97-9ff7-8d3f876514a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76280280@gmail.com", "NamDepTRai280", "Hashed_password_02", null, false, false, "Ho Hoang280", null, "User", null, 0 },
                    { new Guid("3f26a997-aed2-40be-b997-d42fb475e17b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76830830@gmail.com", "NamDepTRai830", "Hashed_password_02", null, false, false, "Ho Hoang830", null, "User", null, 0 },
                    { new Guid("3f7eec96-3462-420f-ad3b-5d538a1a2b0a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76849849@gmail.com", "NamDepTRai849", "Hashed_password_02", null, false, false, "Ho Hoang849", null, "User", null, 0 },
                    { new Guid("40a08a49-e9ae-466d-8ddc-929a4c2a2ed9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76172172@gmail.com", "NamDepTRai172", "Hashed_password_02", null, false, false, "Ho Hoang172", null, "User", null, 0 },
                    { new Guid("41434a8e-17c8-4a1d-a100-427e3e2ce28d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76189189@gmail.com", "NamDepTRai189", "Hashed_password_02", null, false, false, "Ho Hoang189", null, "User", null, 0 },
                    { new Guid("417af759-2d5c-4706-bbc5-3ffca5cd2487"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76419419@gmail.com", "NamDepTRai419", "Hashed_password_02", null, false, false, "Ho Hoang419", null, "User", null, 0 },
                    { new Guid("41a0668e-1a8b-4c62-a2ef-d5cce94e52b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76402402@gmail.com", "NamDepTRai402", "Hashed_password_02", null, false, false, "Ho Hoang402", null, "User", null, 0 },
                    { new Guid("41acaf93-7139-46fb-b8c9-602e4e339644"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76624624@gmail.com", "NamDepTRai624", "Hashed_password_02", null, false, false, "Ho Hoang624", null, "User", null, 0 },
                    { new Guid("41c3e5b7-9060-4a36-8508-2681c5d3ffda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76392392@gmail.com", "NamDepTRai392", "Hashed_password_02", null, false, false, "Ho Hoang392", null, "User", null, 0 },
                    { new Guid("41fa721f-34e3-4327-8824-2c619a5b1242"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76162162@gmail.com", "NamDepTRai162", "Hashed_password_02", null, false, false, "Ho Hoang162", null, "User", null, 0 },
                    { new Guid("423cef08-1c2d-4bc1-aee7-b91107ca9853"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76572572@gmail.com", "NamDepTRai572", "Hashed_password_02", null, false, false, "Ho Hoang572", null, "User", null, 0 },
                    { new Guid("424d70b4-3879-478f-943a-3acade3e6473"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76719719@gmail.com", "NamDepTRai719", "Hashed_password_02", null, false, false, "Ho Hoang719", null, "User", null, 0 },
                    { new Guid("426c4a28-986d-4adb-abd5-b892ff06c0eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763131@gmail.com", "NamDepTRai31", "Hashed_password_02", null, false, false, "Ho Hoang31", null, "User", null, 0 },
                    { new Guid("42974e45-f4ef-49a3-b867-cdcb58abb19e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76793793@gmail.com", "NamDepTRai793", "Hashed_password_02", null, false, false, "Ho Hoang793", null, "User", null, 0 },
                    { new Guid("42c059ed-76a3-487b-afab-78d1c796c6f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76510510@gmail.com", "NamDepTRai510", "Hashed_password_02", null, false, false, "Ho Hoang510", null, "User", null, 0 },
                    { new Guid("42f663ac-536a-490e-b02c-513a1ff6ecd1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76986986@gmail.com", "NamDepTRai986", "Hashed_password_02", null, false, false, "Ho Hoang986", null, "User", null, 0 },
                    { new Guid("4311f8e6-45ba-48e5-8fba-127bc7d23edc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76180180@gmail.com", "NamDepTRai180", "Hashed_password_02", null, false, false, "Ho Hoang180", null, "User", null, 0 },
                    { new Guid("4331c20d-0f5f-4c06-abdd-291bfcfb0477"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76362362@gmail.com", "NamDepTRai362", "Hashed_password_02", null, false, false, "Ho Hoang362", null, "User", null, 0 },
                    { new Guid("435d88a4-1417-48dc-9761-e99bf3a56154"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76408408@gmail.com", "NamDepTRai408", "Hashed_password_02", null, false, false, "Ho Hoang408", null, "User", null, 0 },
                    { new Guid("4420942e-43c4-4da3-8c2e-4b1cf8d9f50f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76100100@gmail.com", "NamDepTRai100", "Hashed_password_02", null, false, false, "Ho Hoang100", null, "User", null, 0 },
                    { new Guid("44759b2d-4763-4ad1-a6cf-8a121401bf96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76684684@gmail.com", "NamDepTRai684", "Hashed_password_02", null, false, false, "Ho Hoang684", null, "User", null, 0 },
                    { new Guid("4499b3bc-2ca7-40bc-a429-9fa02025c234"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76668668@gmail.com", "NamDepTRai668", "Hashed_password_02", null, false, false, "Ho Hoang668", null, "User", null, 0 },
                    { new Guid("44d879bd-cbce-4622-bbe1-2113d26d66f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76912912@gmail.com", "NamDepTRai912", "Hashed_password_02", null, false, false, "Ho Hoang912", null, "User", null, 0 },
                    { new Guid("44f6db9d-4f84-424e-955c-fd27ff52799d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76233233@gmail.com", "NamDepTRai233", "Hashed_password_02", null, false, false, "Ho Hoang233", null, "User", null, 0 },
                    { new Guid("455dc7a3-62d6-49de-8571-e574204edd83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76595595@gmail.com", "NamDepTRai595", "Hashed_password_02", null, false, false, "Ho Hoang595", null, "User", null, 0 },
                    { new Guid("457c231f-3223-4209-9164-86778eef2ff4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76946946@gmail.com", "NamDepTRai946", "Hashed_password_02", null, false, false, "Ho Hoang946", null, "User", null, 0 },
                    { new Guid("458a1bcf-a596-49ea-ac78-073811393568"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76944944@gmail.com", "NamDepTRai944", "Hashed_password_02", null, false, false, "Ho Hoang944", null, "User", null, 0 },
                    { new Guid("45b7c116-150a-4e67-89ac-aa1a7a0d50a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76508508@gmail.com", "NamDepTRai508", "Hashed_password_02", null, false, false, "Ho Hoang508", null, "User", null, 0 },
                    { new Guid("45e83ff8-236c-4f4e-8f6c-bb41e3549f6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76816816@gmail.com", "NamDepTRai816", "Hashed_password_02", null, false, false, "Ho Hoang816", null, "User", null, 0 },
                    { new Guid("46194de5-22c4-4667-b822-a98ed7fe477e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764949@gmail.com", "NamDepTRai49", "Hashed_password_02", null, false, false, "Ho Hoang49", null, "User", null, 0 },
                    { new Guid("463ac660-20d6-473d-ac91-dfb7dddf3655"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76279279@gmail.com", "NamDepTRai279", "Hashed_password_02", null, false, false, "Ho Hoang279", null, "User", null, 0 },
                    { new Guid("46453e0f-ca15-4de6-9a78-5bd45d4a783f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76639639@gmail.com", "NamDepTRai639", "Hashed_password_02", null, false, false, "Ho Hoang639", null, "User", null, 0 },
                    { new Guid("464b3851-dcad-40e9-a7a3-3fd7d58fee3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76478478@gmail.com", "NamDepTRai478", "Hashed_password_02", null, false, false, "Ho Hoang478", null, "User", null, 0 },
                    { new Guid("4650cd5f-46cd-4b01-bbe5-a0d5d2397939"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76702702@gmail.com", "NamDepTRai702", "Hashed_password_02", null, false, false, "Ho Hoang702", null, "User", null, 0 },
                    { new Guid("46711428-3765-4f6a-9970-9fc3e037ec16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76806806@gmail.com", "NamDepTRai806", "Hashed_password_02", null, false, false, "Ho Hoang806", null, "User", null, 0 },
                    { new Guid("46bb80d8-c6fb-4546-9f83-75ea74b22270"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76167167@gmail.com", "NamDepTRai167", "Hashed_password_02", null, false, false, "Ho Hoang167", null, "User", null, 0 },
                    { new Guid("46f60402-2f32-46af-9519-eb3e7956148b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76101101@gmail.com", "NamDepTRai101", "Hashed_password_02", null, false, false, "Ho Hoang101", null, "User", null, 0 },
                    { new Guid("46fe4c29-1428-49e2-8689-f7866669c79b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76146146@gmail.com", "NamDepTRai146", "Hashed_password_02", null, false, false, "Ho Hoang146", null, "User", null, 0 },
                    { new Guid("4741f9a9-5949-4b86-84fc-d64dc4f7e487"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76777777@gmail.com", "NamDepTRai777", "Hashed_password_02", null, false, false, "Ho Hoang777", null, "User", null, 0 },
                    { new Guid("4753fdba-189f-4355-ad35-cea53943dc01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76372372@gmail.com", "NamDepTRai372", "Hashed_password_02", null, false, false, "Ho Hoang372", null, "User", null, 0 },
                    { new Guid("4758a96b-e07b-44a9-8145-f857e65f272b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76782782@gmail.com", "NamDepTRai782", "Hashed_password_02", null, false, false, "Ho Hoang782", null, "User", null, 0 },
                    { new Guid("477fdf9c-6312-4d15-bd8b-84637c40e466"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76342342@gmail.com", "NamDepTRai342", "Hashed_password_02", null, false, false, "Ho Hoang342", null, "User", null, 0 },
                    { new Guid("47f8e9c8-1bfd-4eb1-8cc5-fab71eb14ebf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76192192@gmail.com", "NamDepTRai192", "Hashed_password_02", null, false, false, "Ho Hoang192", null, "User", null, 0 },
                    { new Guid("48257951-2324-4779-a1af-fa314f62d2e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76992992@gmail.com", "NamDepTRai992", "Hashed_password_02", null, false, false, "Ho Hoang992", null, "User", null, 0 },
                    { new Guid("4833efee-0817-486b-a0c1-3a92091959ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76949949@gmail.com", "NamDepTRai949", "Hashed_password_02", null, false, false, "Ho Hoang949", null, "User", null, 0 },
                    { new Guid("489f17e9-8795-4d80-8f1f-33f24fb542aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76650650@gmail.com", "NamDepTRai650", "Hashed_password_02", null, false, false, "Ho Hoang650", null, "User", null, 0 },
                    { new Guid("48df77e4-33a3-4edb-9e16-aba4fd5f6836"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76492492@gmail.com", "NamDepTRai492", "Hashed_password_02", null, false, false, "Ho Hoang492", null, "User", null, 0 },
                    { new Guid("48f15edf-d047-470e-9e99-d9dbb8590357"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76609609@gmail.com", "NamDepTRai609", "Hashed_password_02", null, false, false, "Ho Hoang609", null, "User", null, 0 },
                    { new Guid("4954ff38-d1cb-4baa-851f-8cc976e9baa9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76871871@gmail.com", "NamDepTRai871", "Hashed_password_02", null, false, false, "Ho Hoang871", null, "User", null, 0 },
                    { new Guid("49696969-7224-4ad2-be51-9cd25ced73d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76892892@gmail.com", "NamDepTRai892", "Hashed_password_02", null, false, false, "Ho Hoang892", null, "User", null, 0 },
                    { new Guid("499cfa92-a265-4a8d-abc8-a20858ec7534"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76810810@gmail.com", "NamDepTRai810", "Hashed_password_02", null, false, false, "Ho Hoang810", null, "User", null, 0 },
                    { new Guid("499e1a90-7479-4c17-90d5-360ebe69c52b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76581581@gmail.com", "NamDepTRai581", "Hashed_password_02", null, false, false, "Ho Hoang581", null, "User", null, 0 },
                    { new Guid("49a16286-96a9-499e-8b4c-dff771960bd9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76443443@gmail.com", "NamDepTRai443", "Hashed_password_02", null, false, false, "Ho Hoang443", null, "User", null, 0 },
                    { new Guid("49c93f6a-58b5-4ccb-bf2f-435bf40e4a2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76463463@gmail.com", "NamDepTRai463", "Hashed_password_02", null, false, false, "Ho Hoang463", null, "User", null, 0 },
                    { new Guid("4a0b6e48-a06d-414c-9eb3-aeec45a0d621"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769494@gmail.com", "NamDepTRai94", "Hashed_password_02", null, false, false, "Ho Hoang94", null, "User", null, 0 },
                    { new Guid("4a48b6b5-dc3c-4640-86f6-9ad1d34086ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76526526@gmail.com", "NamDepTRai526", "Hashed_password_02", null, false, false, "Ho Hoang526", null, "User", null, 0 },
                    { new Guid("4a5ec4dd-38d1-4b9d-a168-f3e934680f4d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76405405@gmail.com", "NamDepTRai405", "Hashed_password_02", null, false, false, "Ho Hoang405", null, "User", null, 0 },
                    { new Guid("4aa5a6d8-158f-4284-a716-b079c3c72f6b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76515515@gmail.com", "NamDepTRai515", "Hashed_password_02", null, false, false, "Ho Hoang515", null, "User", null, 0 },
                    { new Guid("4aae46d7-9bb7-4dff-aece-086b85d836a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76618618@gmail.com", "NamDepTRai618", "Hashed_password_02", null, false, false, "Ho Hoang618", null, "User", null, 0 },
                    { new Guid("4b47b33c-d965-4fab-b78c-fdda6691a5f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76178178@gmail.com", "NamDepTRai178", "Hashed_password_02", null, false, false, "Ho Hoang178", null, "User", null, 0 },
                    { new Guid("4c623126-d233-47af-bd65-e4f278f5e803"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76520520@gmail.com", "NamDepTRai520", "Hashed_password_02", null, false, false, "Ho Hoang520", null, "User", null, 0 },
                    { new Guid("4ccd5bfb-804d-4844-b1ac-181b6d816016"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76125125@gmail.com", "NamDepTRai125", "Hashed_password_02", null, false, false, "Ho Hoang125", null, "User", null, 0 },
                    { new Guid("4d667325-f8bb-4d94-9c98-04476a2dd305"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76495495@gmail.com", "NamDepTRai495", "Hashed_password_02", null, false, false, "Ho Hoang495", null, "User", null, 0 },
                    { new Guid("4dff349f-da83-4cc5-8fc2-51820e5612c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76518518@gmail.com", "NamDepTRai518", "Hashed_password_02", null, false, false, "Ho Hoang518", null, "User", null, 0 },
                    { new Guid("4ebfbae6-bf90-4305-a3db-78b26f1fece5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76236236@gmail.com", "NamDepTRai236", "Hashed_password_02", null, false, false, "Ho Hoang236", null, "User", null, 0 },
                    { new Guid("4ec0d083-59b4-4c49-b316-05cde055c7f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76853853@gmail.com", "NamDepTRai853", "Hashed_password_02", null, false, false, "Ho Hoang853", null, "User", null, 0 },
                    { new Guid("4ef69187-69e6-4b4a-bdd5-b7d5b99f6b3e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7611@gmail.com", "NamDepTRai1", "Hashed_password_02", null, false, false, "Ho Hoang1", null, "User", null, 0 },
                    { new Guid("4f879750-0124-4bff-ad61-85ad67fea160"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76979979@gmail.com", "NamDepTRai979", "Hashed_password_02", null, false, false, "Ho Hoang979", null, "User", null, 0 },
                    { new Guid("4fb188dd-b2da-4ae8-9140-6134b9b92850"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76220220@gmail.com", "NamDepTRai220", "Hashed_password_02", null, false, false, "Ho Hoang220", null, "User", null, 0 },
                    { new Guid("4fc34ed2-197d-443d-bb07-c9c6eef71010"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76316316@gmail.com", "NamDepTRai316", "Hashed_password_02", null, false, false, "Ho Hoang316", null, "User", null, 0 },
                    { new Guid("4ffc087c-126f-4d19-929f-bddebd90d339"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762828@gmail.com", "NamDepTRai28", "Hashed_password_02", null, false, false, "Ho Hoang28", null, "User", null, 0 },
                    { new Guid("501d57fe-2be2-4315-a62e-37e2e4ba7858"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769595@gmail.com", "NamDepTRai95", "Hashed_password_02", null, false, false, "Ho Hoang95", null, "User", null, 0 },
                    { new Guid("503d1d65-ecaf-41fa-9e27-aa2c1ead6896"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76532532@gmail.com", "NamDepTRai532", "Hashed_password_02", null, false, false, "Ho Hoang532", null, "User", null, 0 },
                    { new Guid("50d04e36-0a57-49f5-8b1b-01e3f1463e3b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76436436@gmail.com", "NamDepTRai436", "Hashed_password_02", null, false, false, "Ho Hoang436", null, "User", null, 0 },
                    { new Guid("517688ed-3be4-4822-bd68-6a7b1a8e4717"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76375375@gmail.com", "NamDepTRai375", "Hashed_password_02", null, false, false, "Ho Hoang375", null, "User", null, 0 },
                    { new Guid("51b27ae9-e39e-4f9c-ae7d-08fcaa8d9d6d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76649649@gmail.com", "NamDepTRai649", "Hashed_password_02", null, false, false, "Ho Hoang649", null, "User", null, 0 },
                    { new Guid("51ebfc0b-6c19-4840-af30-502c0a300bde"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76664664@gmail.com", "NamDepTRai664", "Hashed_password_02", null, false, false, "Ho Hoang664", null, "User", null, 0 },
                    { new Guid("5261a425-b414-4cdb-ae9a-b4f4f6101b18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76383383@gmail.com", "NamDepTRai383", "Hashed_password_02", null, false, false, "Ho Hoang383", null, "User", null, 0 },
                    { new Guid("5294fc53-cdd1-4dc5-bbad-27a9eb51a772"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769797@gmail.com", "NamDepTRai97", "Hashed_password_02", null, false, false, "Ho Hoang97", null, "User", null, 0 },
                    { new Guid("52bc1526-5146-4aca-80f6-74761240a8cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7610001000@gmail.com", "NamDepTRai1000", "Hashed_password_02", null, false, false, "Ho Hoang1000", null, "User", null, 0 },
                    { new Guid("52d19b40-9a1c-463f-a4a2-25304fffdf06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762323@gmail.com", "NamDepTRai23", "Hashed_password_02", null, false, false, "Ho Hoang23", null, "User", null, 0 },
                    { new Guid("52e1f9e9-5d31-45ba-8087-0f1efc4da806"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76815815@gmail.com", "NamDepTRai815", "Hashed_password_02", null, false, false, "Ho Hoang815", null, "User", null, 0 },
                    { new Guid("53408766-96aa-4e1f-9a38-6f8f8b7456b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76262262@gmail.com", "NamDepTRai262", "Hashed_password_02", null, false, false, "Ho Hoang262", null, "User", null, 0 },
                    { new Guid("541b249a-3591-4f25-b7a9-871f46e81f15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76528528@gmail.com", "NamDepTRai528", "Hashed_password_02", null, false, false, "Ho Hoang528", null, "User", null, 0 },
                    { new Guid("54564762-f2a3-4407-a2dc-13da34bff8a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76805805@gmail.com", "NamDepTRai805", "Hashed_password_02", null, false, false, "Ho Hoang805", null, "User", null, 0 },
                    { new Guid("545b9864-bc49-4a6b-89fb-4d7fb820cfc7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76284284@gmail.com", "NamDepTRai284", "Hashed_password_02", null, false, false, "Ho Hoang284", null, "User", null, 0 },
                    { new Guid("54871b3a-69c6-44af-b87a-a1c846fc4d25"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76955955@gmail.com", "NamDepTRai955", "Hashed_password_02", null, false, false, "Ho Hoang955", null, "User", null, 0 },
                    { new Guid("54c130cb-a564-4372-a980-b5d4a25bdf66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76739739@gmail.com", "NamDepTRai739", "Hashed_password_02", null, false, false, "Ho Hoang739", null, "User", null, 0 },
                    { new Guid("5515d1b5-0874-4d4d-b37d-c4e952ca8b21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76570570@gmail.com", "NamDepTRai570", "Hashed_password_02", null, false, false, "Ho Hoang570", null, "User", null, 0 },
                    { new Guid("5527aa6b-819d-4130-bd4b-6d78a094574d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76171171@gmail.com", "NamDepTRai171", "Hashed_password_02", null, false, false, "Ho Hoang171", null, "User", null, 0 },
                    { new Guid("557f2295-b3ad-4e46-8890-c99248752b8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76516516@gmail.com", "NamDepTRai516", "Hashed_password_02", null, false, false, "Ho Hoang516", null, "User", null, 0 },
                    { new Guid("56508dba-c3ca-48fe-9aeb-1eb115e7ee33"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76687687@gmail.com", "NamDepTRai687", "Hashed_password_02", null, false, false, "Ho Hoang687", null, "User", null, 0 },
                    { new Guid("565fd2b7-cf07-49c6-876d-dec4931d51db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76285285@gmail.com", "NamDepTRai285", "Hashed_password_02", null, false, false, "Ho Hoang285", null, "User", null, 0 },
                    { new Guid("5688be4a-5bc6-415a-b59e-b6d2889fd058"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76449449@gmail.com", "NamDepTRai449", "Hashed_password_02", null, false, false, "Ho Hoang449", null, "User", null, 0 },
                    { new Guid("56be6c10-44cd-40b3-a813-471606d836ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76302302@gmail.com", "NamDepTRai302", "Hashed_password_02", null, false, false, "Ho Hoang302", null, "User", null, 0 },
                    { new Guid("571fd8cc-23dc-4a6a-8793-05174dacf9ce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76867867@gmail.com", "NamDepTRai867", "Hashed_password_02", null, false, false, "Ho Hoang867", null, "User", null, 0 },
                    { new Guid("576823ee-5b38-4cb4-b69e-98dc55e38651"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76504504@gmail.com", "NamDepTRai504", "Hashed_password_02", null, false, false, "Ho Hoang504", null, "User", null, 0 },
                    { new Guid("577b998b-6248-4615-b0c3-669781c9cbc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76139139@gmail.com", "NamDepTRai139", "Hashed_password_02", null, false, false, "Ho Hoang139", null, "User", null, 0 },
                    { new Guid("578cf5b9-1a7e-47ef-b12c-68f70143bbc8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76132132@gmail.com", "NamDepTRai132", "Hashed_password_02", null, false, false, "Ho Hoang132", null, "User", null, 0 },
                    { new Guid("57c355ac-887a-4243-a6f6-2850400ea92f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76732732@gmail.com", "NamDepTRai732", "Hashed_password_02", null, false, false, "Ho Hoang732", null, "User", null, 0 },
                    { new Guid("57d09041-5ad7-4b5a-be90-e41e39ad615b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7688@gmail.com", "NamDepTRai8", "Hashed_password_02", null, false, false, "Ho Hoang8", null, "User", null, 0 },
                    { new Guid("57f13019-742f-4fca-93f7-c7255d7af10e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7644@gmail.com", "NamDepTRai4", "Hashed_password_02", null, false, false, "Ho Hoang4", null, "User", null, 0 },
                    { new Guid("585424bf-8793-40c1-9d66-909c2170fc2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76608608@gmail.com", "NamDepTRai608", "Hashed_password_02", null, false, false, "Ho Hoang608", null, "User", null, 0 },
                    { new Guid("587539d7-0a54-412c-b854-184efbe3d049"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76826826@gmail.com", "NamDepTRai826", "Hashed_password_02", null, false, false, "Ho Hoang826", null, "User", null, 0 },
                    { new Guid("5916336c-2afa-413d-bf96-c8db58d74fdf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76929929@gmail.com", "NamDepTRai929", "Hashed_password_02", null, false, false, "Ho Hoang929", null, "User", null, 0 },
                    { new Guid("59363b75-ab4e-4567-81e4-c9c58ba3b70b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76297297@gmail.com", "NamDepTRai297", "Hashed_password_02", null, false, false, "Ho Hoang297", null, "User", null, 0 },
                    { new Guid("5993420f-032e-4c6d-b666-23fe8d4c2d78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76576576@gmail.com", "NamDepTRai576", "Hashed_password_02", null, false, false, "Ho Hoang576", null, "User", null, 0 },
                    { new Guid("59a2f279-99d7-437a-b8ac-47ba5efc072f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76645645@gmail.com", "NamDepTRai645", "Hashed_password_02", null, false, false, "Ho Hoang645", null, "User", null, 0 },
                    { new Guid("59c79e12-5af9-46e5-948e-b6cababb9a44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76446446@gmail.com", "NamDepTRai446", "Hashed_password_02", null, false, false, "Ho Hoang446", null, "User", null, 0 },
                    { new Guid("59cecb26-3b18-4161-8861-ebca76004515"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76983983@gmail.com", "NamDepTRai983", "Hashed_password_02", null, false, false, "Ho Hoang983", null, "User", null, 0 },
                    { new Guid("5a454dde-fb76-41db-b115-441a769adf78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76823823@gmail.com", "NamDepTRai823", "Hashed_password_02", null, false, false, "Ho Hoang823", null, "User", null, 0 },
                    { new Guid("5b30139f-1f4f-4309-a25b-06503c37272b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76273273@gmail.com", "NamDepTRai273", "Hashed_password_02", null, false, false, "Ho Hoang273", null, "User", null, 0 },
                    { new Guid("5bbe3866-37e7-4222-9ea1-9476f6150386"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76447447@gmail.com", "NamDepTRai447", "Hashed_password_02", null, false, false, "Ho Hoang447", null, "User", null, 0 },
                    { new Guid("5bc7b674-5f3d-4bfe-9092-720718169930"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76875875@gmail.com", "NamDepTRai875", "Hashed_password_02", null, false, false, "Ho Hoang875", null, "User", null, 0 },
                    { new Guid("5c5a5cea-8afc-4352-9a85-7b4ba2aabada"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769292@gmail.com", "NamDepTRai92", "Hashed_password_02", null, false, false, "Ho Hoang92", null, "User", null, 0 },
                    { new Guid("5c5ea360-b4ee-4c01-8c91-4a101e9b0678"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76334334@gmail.com", "NamDepTRai334", "Hashed_password_02", null, false, false, "Ho Hoang334", null, "User", null, 0 },
                    { new Guid("5c63a70e-e17f-4efa-8e00-e0b4a81562d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76551551@gmail.com", "NamDepTRai551", "Hashed_password_02", null, false, false, "Ho Hoang551", null, "User", null, 0 },
                    { new Guid("5c910f15-50fa-40e2-8739-20fc194929e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76404404@gmail.com", "NamDepTRai404", "Hashed_password_02", null, false, false, "Ho Hoang404", null, "User", null, 0 },
                    { new Guid("5c9c040b-bb7d-46e5-aa83-8a69b827aa0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76474474@gmail.com", "NamDepTRai474", "Hashed_password_02", null, false, false, "Ho Hoang474", null, "User", null, 0 },
                    { new Guid("5d8c7602-47f9-425c-9420-17329e69f899"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76343343@gmail.com", "NamDepTRai343", "Hashed_password_02", null, false, false, "Ho Hoang343", null, "User", null, 0 },
                    { new Guid("5d9cc750-3fc6-43b5-98fc-44b66c945b8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76547547@gmail.com", "NamDepTRai547", "Hashed_password_02", null, false, false, "Ho Hoang547", null, "User", null, 0 },
                    { new Guid("5de5d872-4e4d-4504-b54f-0ac261096d12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76462462@gmail.com", "NamDepTRai462", "Hashed_password_02", null, false, false, "Ho Hoang462", null, "User", null, 0 },
                    { new Guid("5e059cdc-8bcb-4b8a-b423-a00e36fcf58c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76201201@gmail.com", "NamDepTRai201", "Hashed_password_02", null, false, false, "Ho Hoang201", null, "User", null, 0 },
                    { new Guid("5e0636c1-f3a1-48c1-92be-18b3e0d2d932"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76173173@gmail.com", "NamDepTRai173", "Hashed_password_02", null, false, false, "Ho Hoang173", null, "User", null, 0 },
                    { new Guid("5e099079-47e6-4b5a-823b-006285b00286"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76907907@gmail.com", "NamDepTRai907", "Hashed_password_02", null, false, false, "Ho Hoang907", null, "User", null, 0 },
                    { new Guid("5e89cd1b-9a98-4624-8721-b54c3880e066"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76974974@gmail.com", "NamDepTRai974", "Hashed_password_02", null, false, false, "Ho Hoang974", null, "User", null, 0 },
                    { new Guid("5e934cd9-f73f-4f34-ad1f-2b57c0117711"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763737@gmail.com", "NamDepTRai37", "Hashed_password_02", null, false, false, "Ho Hoang37", null, "User", null, 0 },
                    { new Guid("5eb37f1b-5462-4cca-8863-49eb478a2503"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765252@gmail.com", "NamDepTRai52", "Hashed_password_02", null, false, false, "Ho Hoang52", null, "User", null, 0 },
                    { new Guid("5eef06bc-3726-48b2-8816-8a32341f027b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76557557@gmail.com", "NamDepTRai557", "Hashed_password_02", null, false, false, "Ho Hoang557", null, "User", null, 0 },
                    { new Guid("5f1c0f34-6251-481e-af6b-75d0407507d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76642642@gmail.com", "NamDepTRai642", "Hashed_password_02", null, false, false, "Ho Hoang642", null, "User", null, 0 },
                    { new Guid("5f508112-d0da-4573-84cc-84b077cc842a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76737737@gmail.com", "NamDepTRai737", "Hashed_password_02", null, false, false, "Ho Hoang737", null, "User", null, 0 },
                    { new Guid("5fb8d474-4c09-4187-b43b-7bee7ffb2d31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76400400@gmail.com", "NamDepTRai400", "Hashed_password_02", null, false, false, "Ho Hoang400", null, "User", null, 0 },
                    { new Guid("5fdeb65d-8dba-476b-ad79-51f88820c2c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76933933@gmail.com", "NamDepTRai933", "Hashed_password_02", null, false, false, "Ho Hoang933", null, "User", null, 0 },
                    { new Guid("5ff6764b-1b58-4850-b832-344887258cba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76376376@gmail.com", "NamDepTRai376", "Hashed_password_02", null, false, false, "Ho Hoang376", null, "User", null, 0 },
                    { new Guid("604a36e6-0da7-40b5-90ae-d12fad32bb4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76203203@gmail.com", "NamDepTRai203", "Hashed_password_02", null, false, false, "Ho Hoang203", null, "User", null, 0 },
                    { new Guid("6067ff68-7342-4765-a99c-d1b907e504e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7677@gmail.com", "NamDepTRai7", "Hashed_password_02", null, false, false, "Ho Hoang7", null, "User", null, 0 },
                    { new Guid("60751269-9e44-4677-a9cb-d0b1d8c685ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76104104@gmail.com", "NamDepTRai104", "Hashed_password_02", null, false, false, "Ho Hoang104", null, "User", null, 0 },
                    { new Guid("608b5703-ac4b-4b9e-b91d-030233b0f87e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76485485@gmail.com", "NamDepTRai485", "Hashed_password_02", null, false, false, "Ho Hoang485", null, "User", null, 0 },
                    { new Guid("60cb9fd7-6265-4b2a-810e-e2d44c028aed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76109109@gmail.com", "NamDepTRai109", "Hashed_password_02", null, false, false, "Ho Hoang109", null, "User", null, 0 },
                    { new Guid("61548828-a24d-4514-83fa-d0b85a03266c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76209209@gmail.com", "NamDepTRai209", "Hashed_password_02", null, false, false, "Ho Hoang209", null, "User", null, 0 },
                    { new Guid("61fa0d29-edd0-4133-b8e9-eddb7e8b6b2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76509509@gmail.com", "NamDepTRai509", "Hashed_password_02", null, false, false, "Ho Hoang509", null, "User", null, 0 },
                    { new Guid("62061520-3a77-4005-ac3b-1a964448413a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76717717@gmail.com", "NamDepTRai717", "Hashed_password_02", null, false, false, "Ho Hoang717", null, "User", null, 0 },
                    { new Guid("626559bb-0bf0-4dfb-a1a3-9b7bb8960f84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76598598@gmail.com", "NamDepTRai598", "Hashed_password_02", null, false, false, "Ho Hoang598", null, "User", null, 0 },
                    { new Guid("62884485-b0bd-4db7-a1d0-c89627f80daa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76951951@gmail.com", "NamDepTRai951", "Hashed_password_02", null, false, false, "Ho Hoang951", null, "User", null, 0 },
                    { new Guid("62c9f1b8-4701-43b2-b76d-2b0b48812ce5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76204204@gmail.com", "NamDepTRai204", "Hashed_password_02", null, false, false, "Ho Hoang204", null, "User", null, 0 },
                    { new Guid("6319b17b-5535-463c-8803-c7a3f8017c5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76780780@gmail.com", "NamDepTRai780", "Hashed_password_02", null, false, false, "Ho Hoang780", null, "User", null, 0 },
                    { new Guid("633e2a78-c406-41cf-a0cd-38dcb7f317b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76665665@gmail.com", "NamDepTRai665", "Hashed_password_02", null, false, false, "Ho Hoang665", null, "User", null, 0 },
                    { new Guid("6361ebad-319d-416d-ad98-4ce15b3c317f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76869869@gmail.com", "NamDepTRai869", "Hashed_password_02", null, false, false, "Ho Hoang869", null, "User", null, 0 },
                    { new Guid("6381d503-16a2-44d9-bc6a-8067a2d22bd4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76895895@gmail.com", "NamDepTRai895", "Hashed_password_02", null, false, false, "Ho Hoang895", null, "User", null, 0 },
                    { new Guid("639b41b1-8ba7-472b-8773-0d869faf4a7e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76254254@gmail.com", "NamDepTRai254", "Hashed_password_02", null, false, false, "Ho Hoang254", null, "User", null, 0 },
                    { new Guid("63fe662c-ec73-4b25-973d-5c27bae5cead"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76155155@gmail.com", "NamDepTRai155", "Hashed_password_02", null, false, false, "Ho Hoang155", null, "User", null, 0 },
                    { new Guid("649a432c-ba11-4c44-b111-7a1dbe811151"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76261261@gmail.com", "NamDepTRai261", "Hashed_password_02", null, false, false, "Ho Hoang261", null, "User", null, 0 },
                    { new Guid("64f5aa9c-b5f0-4584-a87a-eb1ab74c45cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76590590@gmail.com", "NamDepTRai590", "Hashed_password_02", null, false, false, "Ho Hoang590", null, "User", null, 0 },
                    { new Guid("64fa6907-c2f0-4235-8348-a787771dcf69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76212212@gmail.com", "NamDepTRai212", "Hashed_password_02", null, false, false, "Ho Hoang212", null, "User", null, 0 },
                    { new Guid("651bece3-e3e1-447c-a651-c06926fba955"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76467467@gmail.com", "NamDepTRai467", "Hashed_password_02", null, false, false, "Ho Hoang467", null, "User", null, 0 },
                    { new Guid("6554edfc-1793-46d6-86a8-dd682e10325a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767171@gmail.com", "NamDepTRai71", "Hashed_password_02", null, false, false, "Ho Hoang71", null, "User", null, 0 },
                    { new Guid("656c763a-b593-4532-b135-aead4286f0b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76837837@gmail.com", "NamDepTRai837", "Hashed_password_02", null, false, false, "Ho Hoang837", null, "User", null, 0 },
                    { new Guid("65ba23d1-db0f-4ecd-a30c-f33655e43512"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76253253@gmail.com", "NamDepTRai253", "Hashed_password_02", null, false, false, "Ho Hoang253", null, "User", null, 0 },
                    { new Guid("65ec4fe6-c242-4ec1-bd3f-141e9ef5fca9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76282282@gmail.com", "NamDepTRai282", "Hashed_password_02", null, false, false, "Ho Hoang282", null, "User", null, 0 },
                    { new Guid("66216e89-ebbf-4240-af6f-f92685bde124"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76746746@gmail.com", "NamDepTRai746", "Hashed_password_02", null, false, false, "Ho Hoang746", null, "User", null, 0 },
                    { new Guid("6660b562-d1a3-422c-acb9-cb24351588c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76579579@gmail.com", "NamDepTRai579", "Hashed_password_02", null, false, false, "Ho Hoang579", null, "User", null, 0 },
                    { new Guid("6679064a-eb8a-4711-aff1-ebac1f01069a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76310310@gmail.com", "NamDepTRai310", "Hashed_password_02", null, false, false, "Ho Hoang310", null, "User", null, 0 },
                    { new Guid("66a8a6b3-933d-437b-8186-480ca73f6c3c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76548548@gmail.com", "NamDepTRai548", "Hashed_password_02", null, false, false, "Ho Hoang548", null, "User", null, 0 },
                    { new Guid("67156a93-0c4a-4854-8fb9-f09921bdf1d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76346346@gmail.com", "NamDepTRai346", "Hashed_password_02", null, false, false, "Ho Hoang346", null, "User", null, 0 },
                    { new Guid("671bef34-b7ad-4430-8159-842a220f2870"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76358358@gmail.com", "NamDepTRai358", "Hashed_password_02", null, false, false, "Ho Hoang358", null, "User", null, 0 },
                    { new Guid("678c2d48-e94d-44ad-a3a6-ddd537d4bc17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76110110@gmail.com", "NamDepTRai110", "Hashed_password_02", null, false, false, "Ho Hoang110", null, "User", null, 0 },
                    { new Guid("6792c11a-0947-4a02-b4e9-c23e052a562e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76466466@gmail.com", "NamDepTRai466", "Hashed_password_02", null, false, false, "Ho Hoang466", null, "User", null, 0 },
                    { new Guid("67aac8c2-de5a-4b71-a2db-39a222cb3166"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76565565@gmail.com", "NamDepTRai565", "Hashed_password_02", null, false, false, "Ho Hoang565", null, "User", null, 0 },
                    { new Guid("67c54a9c-5224-425b-9819-e6a1b26cc247"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76470470@gmail.com", "NamDepTRai470", "Hashed_password_02", null, false, false, "Ho Hoang470", null, "User", null, 0 },
                    { new Guid("67d35045-633e-4d87-a6f9-cf3099c713c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76427427@gmail.com", "NamDepTRai427", "Hashed_password_02", null, false, false, "Ho Hoang427", null, "User", null, 0 },
                    { new Guid("6820d501-5dcf-4c29-a24f-4c1cc3d6b220"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76692692@gmail.com", "NamDepTRai692", "Hashed_password_02", null, false, false, "Ho Hoang692", null, "User", null, 0 },
                    { new Guid("68465d01-46f0-4b75-851b-62426024bc5b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76706706@gmail.com", "NamDepTRai706", "Hashed_password_02", null, false, false, "Ho Hoang706", null, "User", null, 0 },
                    { new Guid("684d0f7d-0cdc-455b-ac46-ab237298f055"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76896896@gmail.com", "NamDepTRai896", "Hashed_password_02", null, false, false, "Ho Hoang896", null, "User", null, 0 },
                    { new Guid("68e49617-2d66-436a-acad-1d363ac43f9c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76244244@gmail.com", "NamDepTRai244", "Hashed_password_02", null, false, false, "Ho Hoang244", null, "User", null, 0 },
                    { new Guid("69261165-addc-4a8d-af0d-aa1c3b154ef7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76505505@gmail.com", "NamDepTRai505", "Hashed_password_02", null, false, false, "Ho Hoang505", null, "User", null, 0 },
                    { new Guid("69348945-af5e-4f42-b868-825d1396d123"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76718718@gmail.com", "NamDepTRai718", "Hashed_password_02", null, false, false, "Ho Hoang718", null, "User", null, 0 },
                    { new Guid("69844aab-3f65-4396-a9e4-f760024ba7e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76207207@gmail.com", "NamDepTRai207", "Hashed_password_02", null, false, false, "Ho Hoang207", null, "User", null, 0 },
                    { new Guid("69ab7627-a986-4110-82d9-cdf7a01b3f63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762222@gmail.com", "NamDepTRai22", "Hashed_password_02", null, false, false, "Ho Hoang22", null, "User", null, 0 },
                    { new Guid("69cd31e0-3f90-4472-81e0-05da0719bb94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76902902@gmail.com", "NamDepTRai902", "Hashed_password_02", null, false, false, "Ho Hoang902", null, "User", null, 0 },
                    { new Guid("6a0628a9-80d0-4b77-b021-80594ad7ec09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76676676@gmail.com", "NamDepTRai676", "Hashed_password_02", null, false, false, "Ho Hoang676", null, "User", null, 0 },
                    { new Guid("6a4c1784-0332-412b-af53-c214d4254eb7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76359359@gmail.com", "NamDepTRai359", "Hashed_password_02", null, false, false, "Ho Hoang359", null, "User", null, 0 },
                    { new Guid("6a8bff12-a39d-4379-af03-5194932fc968"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76928928@gmail.com", "NamDepTRai928", "Hashed_password_02", null, false, false, "Ho Hoang928", null, "User", null, 0 },
                    { new Guid("6aac6c7b-7b3f-4459-bef9-db8dd3a8a625"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76888888@gmail.com", "NamDepTRai888", "Hashed_password_02", null, false, false, "Ho Hoang888", null, "User", null, 0 },
                    { new Guid("6abdbb4d-ddc2-451f-85d5-66e0cc50f79b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765656@gmail.com", "NamDepTRai56", "Hashed_password_02", null, false, false, "Ho Hoang56", null, "User", null, 0 },
                    { new Guid("6b2d0871-6d58-49fe-83cc-b5c9840cf52b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76366366@gmail.com", "NamDepTRai366", "Hashed_password_02", null, false, false, "Ho Hoang366", null, "User", null, 0 },
                    { new Guid("6ba1abc5-a857-4b9d-83c6-43ac70c4b217"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76307307@gmail.com", "NamDepTRai307", "Hashed_password_02", null, false, false, "Ho Hoang307", null, "User", null, 0 },
                    { new Guid("6ba969a5-2e53-4f76-bd15-59721658fad5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76924924@gmail.com", "NamDepTRai924", "Hashed_password_02", null, false, false, "Ho Hoang924", null, "User", null, 0 },
                    { new Guid("6be7ef37-37be-4db5-883c-9db83a6e0e5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76747747@gmail.com", "NamDepTRai747", "Hashed_password_02", null, false, false, "Ho Hoang747", null, "User", null, 0 },
                    { new Guid("6bfbde61-39af-444e-b350-7e5790a9b3c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76184184@gmail.com", "NamDepTRai184", "Hashed_password_02", null, false, false, "Ho Hoang184", null, "User", null, 0 },
                    { new Guid("6c424bf0-5927-4000-9e57-d2768a6d8709"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763030@gmail.com", "NamDepTRai30", "Hashed_password_02", null, false, false, "Ho Hoang30", null, "User", null, 0 },
                    { new Guid("6c82ed39-1dde-4f19-93bc-fbe671007513"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76381381@gmail.com", "NamDepTRai381", "Hashed_password_02", null, false, false, "Ho Hoang381", null, "User", null, 0 },
                    { new Guid("6cd5e067-5184-4ffc-8ee9-a11a75856fe5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76660660@gmail.com", "NamDepTRai660", "Hashed_password_02", null, false, false, "Ho Hoang660", null, "User", null, 0 },
                    { new Guid("6ce0afd8-9868-4aa3-83b9-67b6987be2bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76195195@gmail.com", "NamDepTRai195", "Hashed_password_02", null, false, false, "Ho Hoang195", null, "User", null, 0 },
                    { new Guid("6d29c68f-ab0a-4de5-b7fb-60969ca39b74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76126126@gmail.com", "NamDepTRai126", "Hashed_password_02", null, false, false, "Ho Hoang126", null, "User", null, 0 },
                    { new Guid("6d730457-e10c-48fd-8a45-7bd9b5bd16df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76961961@gmail.com", "NamDepTRai961", "Hashed_password_02", null, false, false, "Ho Hoang961", null, "User", null, 0 },
                    { new Guid("6da6a377-d2e5-4373-b3a5-4bdcb3bbe35a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76188188@gmail.com", "NamDepTRai188", "Hashed_password_02", null, false, false, "Ho Hoang188", null, "User", null, 0 },
                    { new Guid("6e17029c-a9b1-4703-929d-0161e0b0075e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76625625@gmail.com", "NamDepTRai625", "Hashed_password_02", null, false, false, "Ho Hoang625", null, "User", null, 0 },
                    { new Guid("6e343ee2-f920-4209-a7dc-19739598b468"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76293293@gmail.com", "NamDepTRai293", "Hashed_password_02", null, false, false, "Ho Hoang293", null, "User", null, 0 },
                    { new Guid("6f815e47-b077-4a03-bbaf-de061a382898"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76845845@gmail.com", "NamDepTRai845", "Hashed_password_02", null, false, false, "Ho Hoang845", null, "User", null, 0 },
                    { new Guid("704ac43f-b548-42c6-9a12-baf4cf7812de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76993993@gmail.com", "NamDepTRai993", "Hashed_password_02", null, false, false, "Ho Hoang993", null, "User", null, 0 },
                    { new Guid("71734e2f-cb49-4856-8a61-d64cc8329302"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76776776@gmail.com", "NamDepTRai776", "Hashed_password_02", null, false, false, "Ho Hoang776", null, "User", null, 0 },
                    { new Guid("71853902-da5f-465b-9484-b7bc2d5704d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76880880@gmail.com", "NamDepTRai880", "Hashed_password_02", null, false, false, "Ho Hoang880", null, "User", null, 0 },
                    { new Guid("718be648-812b-46a6-89c2-1e928da138f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76314314@gmail.com", "NamDepTRai314", "Hashed_password_02", null, false, false, "Ho Hoang314", null, "User", null, 0 },
                    { new Guid("720762ea-c4c3-46ad-992f-bbd3a2c52332"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76190190@gmail.com", "NamDepTRai190", "Hashed_password_02", null, false, false, "Ho Hoang190", null, "User", null, 0 },
                    { new Guid("721a3ff1-2077-4959-8317-a82ae0d045fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76181181@gmail.com", "NamDepTRai181", "Hashed_password_02", null, false, false, "Ho Hoang181", null, "User", null, 0 },
                    { new Guid("727f9a94-f016-422e-a0bc-6049edb6f3a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76698698@gmail.com", "NamDepTRai698", "Hashed_password_02", null, false, false, "Ho Hoang698", null, "User", null, 0 },
                    { new Guid("72d196b4-087b-42ed-8334-ff127c2364bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76960960@gmail.com", "NamDepTRai960", "Hashed_password_02", null, false, false, "Ho Hoang960", null, "User", null, 0 },
                    { new Guid("72e5dfd0-4d4a-4a32-85dd-b39e7bcb45a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76589589@gmail.com", "NamDepTRai589", "Hashed_password_02", null, false, false, "Ho Hoang589", null, "User", null, 0 },
                    { new Guid("731d743d-04fb-4611-900e-d1eb3c074d8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76575575@gmail.com", "NamDepTRai575", "Hashed_password_02", null, false, false, "Ho Hoang575", null, "User", null, 0 },
                    { new Guid("734fa1fc-5554-4af7-bf02-2378eafccb06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76177177@gmail.com", "NamDepTRai177", "Hashed_password_02", null, false, false, "Ho Hoang177", null, "User", null, 0 },
                    { new Guid("73981b67-c5eb-4506-ae13-cc722458a7e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76560560@gmail.com", "NamDepTRai560", "Hashed_password_02", null, false, false, "Ho Hoang560", null, "User", null, 0 },
                    { new Guid("73aa397a-420e-4241-90e8-c9a183b4b7af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76741741@gmail.com", "NamDepTRai741", "Hashed_password_02", null, false, false, "Ho Hoang741", null, "User", null, 0 },
                    { new Guid("742ae67a-b9cd-40d4-a0c1-bbba3170fd21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76149149@gmail.com", "NamDepTRai149", "Hashed_password_02", null, false, false, "Ho Hoang149", null, "User", null, 0 },
                    { new Guid("74ad56df-7853-40cd-830a-2c8384aa110e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76604604@gmail.com", "NamDepTRai604", "Hashed_password_02", null, false, false, "Ho Hoang604", null, "User", null, 0 },
                    { new Guid("750c52b4-2682-45a4-892f-7ef29bd30be3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76276276@gmail.com", "NamDepTRai276", "Hashed_password_02", null, false, false, "Ho Hoang276", null, "User", null, 0 },
                    { new Guid("750dc68b-03db-4abb-bfcf-29cac7e2420b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76580580@gmail.com", "NamDepTRai580", "Hashed_password_02", null, false, false, "Ho Hoang580", null, "User", null, 0 },
                    { new Guid("75e6cbd6-c8cf-43f3-aeca-fb764a3467b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76118118@gmail.com", "NamDepTRai118", "Hashed_password_02", null, false, false, "Ho Hoang118", null, "User", null, 0 },
                    { new Guid("75eddb94-526f-4f7d-8243-16c00790142e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76451451@gmail.com", "NamDepTRai451", "Hashed_password_02", null, false, false, "Ho Hoang451", null, "User", null, 0 },
                    { new Guid("7601f991-eee9-4e69-9860-44886f858a75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764545@gmail.com", "NamDepTRai45", "Hashed_password_02", null, false, false, "Ho Hoang45", null, "User", null, 0 },
                    { new Guid("7605dba6-5be7-4071-9aad-1ca999cc210e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76930930@gmail.com", "NamDepTRai930", "Hashed_password_02", null, false, false, "Ho Hoang930", null, "User", null, 0 },
                    { new Guid("762147a6-d707-4344-8db6-edef9f360e33"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76825825@gmail.com", "NamDepTRai825", "Hashed_password_02", null, false, false, "Ho Hoang825", null, "User", null, 0 },
                    { new Guid("7668bcfc-7bd0-46a4-8485-c72f19b3d639"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76325325@gmail.com", "NamDepTRai325", "Hashed_password_02", null, false, false, "Ho Hoang325", null, "User", null, 0 },
                    { new Guid("766b3139-2468-407c-aa4f-379e5583adef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76413413@gmail.com", "NamDepTRai413", "Hashed_password_02", null, false, false, "Ho Hoang413", null, "User", null, 0 },
                    { new Guid("76aec754-537c-47a6-830a-28c30016c6a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76851851@gmail.com", "NamDepTRai851", "Hashed_password_02", null, false, false, "Ho Hoang851", null, "User", null, 0 },
                    { new Guid("76b781e6-2043-4dd4-a304-dd5597660181"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76469469@gmail.com", "NamDepTRai469", "Hashed_password_02", null, false, false, "Ho Hoang469", null, "User", null, 0 },
                    { new Guid("76fd0ab3-88be-4637-9049-6de1cc85ba84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76399399@gmail.com", "NamDepTRai399", "Hashed_password_02", null, false, false, "Ho Hoang399", null, "User", null, 0 },
                    { new Guid("7853af33-c7d8-4cc7-a500-812d05993e1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76658658@gmail.com", "NamDepTRai658", "Hashed_password_02", null, false, false, "Ho Hoang658", null, "User", null, 0 },
                    { new Guid("7857663f-fdb5-4f87-b3f6-723b2aae63b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76943943@gmail.com", "NamDepTRai943", "Hashed_password_02", null, false, false, "Ho Hoang943", null, "User", null, 0 },
                    { new Guid("78b76c32-a8f6-468a-a18b-2897fab5409e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76663663@gmail.com", "NamDepTRai663", "Hashed_password_02", null, false, false, "Ho Hoang663", null, "User", null, 0 },
                    { new Guid("798cead6-d5c6-43ac-be0e-21e6d9ad144d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76842842@gmail.com", "NamDepTRai842", "Hashed_password_02", null, false, false, "Ho Hoang842", null, "User", null, 0 },
                    { new Guid("79cb1e4c-bc1b-4c07-a7b9-3a1e1743c701"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76210210@gmail.com", "NamDepTRai210", "Hashed_password_02", null, false, false, "Ho Hoang210", null, "User", null, 0 },
                    { new Guid("7a44a253-70db-49e5-8e82-20391e68b0aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76654654@gmail.com", "NamDepTRai654", "Hashed_password_02", null, false, false, "Ho Hoang654", null, "User", null, 0 },
                    { new Guid("7a51684c-0fda-4a9c-9782-b8dda68bb242"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76241241@gmail.com", "NamDepTRai241", "Hashed_password_02", null, false, false, "Ho Hoang241", null, "User", null, 0 },
                    { new Guid("7a70fcec-d2bd-40a5-b49c-069514e9ba17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76620620@gmail.com", "NamDepTRai620", "Hashed_password_02", null, false, false, "Ho Hoang620", null, "User", null, 0 },
                    { new Guid("7a76696b-348c-4e4a-82f3-d411c68822e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762626@gmail.com", "NamDepTRai26", "Hashed_password_02", null, false, false, "Ho Hoang26", null, "User", null, 0 },
                    { new Guid("7a7baac4-4c00-49fd-810a-7c99a216c019"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76856856@gmail.com", "NamDepTRai856", "Hashed_password_02", null, false, false, "Ho Hoang856", null, "User", null, 0 },
                    { new Guid("7ab2fe79-1d1a-4a3c-8ac4-975001a2b3e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76715715@gmail.com", "NamDepTRai715", "Hashed_password_02", null, false, false, "Ho Hoang715", null, "User", null, 0 },
                    { new Guid("7ac75564-6b72-40b4-8eb8-6c05b1622eef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76939939@gmail.com", "NamDepTRai939", "Hashed_password_02", null, false, false, "Ho Hoang939", null, "User", null, 0 },
                    { new Guid("7b173d4e-40b2-4dbf-a294-42689c03be3c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76488488@gmail.com", "NamDepTRai488", "Hashed_password_02", null, false, false, "Ho Hoang488", null, "User", null, 0 },
                    { new Guid("7b5f0bef-4782-4927-b415-3700debb891b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76185185@gmail.com", "NamDepTRai185", "Hashed_password_02", null, false, false, "Ho Hoang185", null, "User", null, 0 },
                    { new Guid("7bb9ae06-9e9c-443b-8612-07f880af7977"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76121121@gmail.com", "NamDepTRai121", "Hashed_password_02", null, false, false, "Ho Hoang121", null, "User", null, 0 },
                    { new Guid("7bc06c6c-42f2-49ff-bce5-8eef9ce41a98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76812812@gmail.com", "NamDepTRai812", "Hashed_password_02", null, false, false, "Ho Hoang812", null, "User", null, 0 },
                    { new Guid("7be086df-955a-4b37-b343-4aac5a433d5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76784784@gmail.com", "NamDepTRai784", "Hashed_password_02", null, false, false, "Ho Hoang784", null, "User", null, 0 },
                    { new Guid("7bf2dcb0-a757-44a0-ad85-0ee88f9c2445"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76493493@gmail.com", "NamDepTRai493", "Hashed_password_02", null, false, false, "Ho Hoang493", null, "User", null, 0 },
                    { new Guid("7c8ce1f0-a897-4d1f-bc02-49b3fce96f72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76679679@gmail.com", "NamDepTRai679", "Hashed_password_02", null, false, false, "Ho Hoang679", null, "User", null, 0 },
                    { new Guid("7cccd954-af2f-492c-abc2-2c8e82ce26be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76906906@gmail.com", "NamDepTRai906", "Hashed_password_02", null, false, false, "Ho Hoang906", null, "User", null, 0 },
                    { new Guid("7cff01e1-35e4-4005-a013-b268535d1916"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76936936@gmail.com", "NamDepTRai936", "Hashed_password_02", null, false, false, "Ho Hoang936", null, "User", null, 0 },
                    { new Guid("7e0a527a-1a2a-468e-99f0-4384ee48cd9b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76559559@gmail.com", "NamDepTRai559", "Hashed_password_02", null, false, false, "Ho Hoang559", null, "User", null, 0 },
                    { new Guid("7e2b31d0-6d50-4096-b69c-f2f3fa492341"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768585@gmail.com", "NamDepTRai85", "Hashed_password_02", null, false, false, "Ho Hoang85", null, "User", null, 0 },
                    { new Guid("7e4ed12e-805a-47b2-87d2-49ee234c0788"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76690690@gmail.com", "NamDepTRai690", "Hashed_password_02", null, false, false, "Ho Hoang690", null, "User", null, 0 },
                    { new Guid("7f3187b1-4a4f-49d6-aa34-2652dc06296d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763434@gmail.com", "NamDepTRai34", "Hashed_password_02", null, false, false, "Ho Hoang34", null, "User", null, 0 },
                    { new Guid("7f5debcb-2ca2-4ec2-b0e3-91b49d97e25e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76614614@gmail.com", "NamDepTRai614", "Hashed_password_02", null, false, false, "Ho Hoang614", null, "User", null, 0 },
                    { new Guid("7f6b8499-e61d-4032-8364-3d842fe2c781"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76430430@gmail.com", "NamDepTRai430", "Hashed_password_02", null, false, false, "Ho Hoang430", null, "User", null, 0 },
                    { new Guid("7f85a32c-28c5-4a31-8031-9b02b00d2ce8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76333333@gmail.com", "NamDepTRai333", "Hashed_password_02", null, false, false, "Ho Hoang333", null, "User", null, 0 },
                    { new Guid("7f91a6cf-d0ad-4689-b228-c4a1a4de724f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76671671@gmail.com", "NamDepTRai671", "Hashed_password_02", null, false, false, "Ho Hoang671", null, "User", null, 0 },
                    { new Guid("80a9c605-bea9-4d39-a659-cb46cba6e981"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76299299@gmail.com", "NamDepTRai299", "Hashed_password_02", null, false, false, "Ho Hoang299", null, "User", null, 0 },
                    { new Guid("80cf310a-e9a4-431a-9727-e24012fa8948"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76630630@gmail.com", "NamDepTRai630", "Hashed_password_02", null, false, false, "Ho Hoang630", null, "User", null, 0 },
                    { new Guid("80fba56e-7566-4ad6-97a1-4f347aff244b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76330330@gmail.com", "NamDepTRai330", "Hashed_password_02", null, false, false, "Ho Hoang330", null, "User", null, 0 },
                    { new Guid("814a53e1-a9ad-4bbb-b834-537ac1842171"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76822822@gmail.com", "NamDepTRai822", "Hashed_password_02", null, false, false, "Ho Hoang822", null, "User", null, 0 },
                    { new Guid("815e8798-1da0-47ad-94f3-48d16a1dfd08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765151@gmail.com", "NamDepTRai51", "Hashed_password_02", null, false, false, "Ho Hoang51", null, "User", null, 0 },
                    { new Guid("8198a4f9-8cb3-42ea-a476-a114a10b2de6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76612612@gmail.com", "NamDepTRai612", "Hashed_password_02", null, false, false, "Ho Hoang612", null, "User", null, 0 },
                    { new Guid("81cd3705-5a95-476d-b3fd-89c7661f8619"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76213213@gmail.com", "NamDepTRai213", "Hashed_password_02", null, false, false, "Ho Hoang213", null, "User", null, 0 },
                    { new Guid("82231cdf-614c-41fa-b3b6-0b890839a0cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76984984@gmail.com", "NamDepTRai984", "Hashed_password_02", null, false, false, "Ho Hoang984", null, "User", null, 0 },
                    { new Guid("8253d237-6885-4754-82f0-89ff3c2a42c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765555@gmail.com", "NamDepTRai55", "Hashed_password_02", null, false, false, "Ho Hoang55", null, "User", null, 0 },
                    { new Guid("82577fc0-b87d-46bf-9209-1cc428146f63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76651651@gmail.com", "NamDepTRai651", "Hashed_password_02", null, false, false, "Ho Hoang651", null, "User", null, 0 },
                    { new Guid("82952642-b757-4753-8d20-b3ff41e2ad69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76566566@gmail.com", "NamDepTRai566", "Hashed_password_02", null, false, false, "Ho Hoang566", null, "User", null, 0 },
                    { new Guid("829ac2f4-d1f4-4586-b594-bfb4ed7036a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76923923@gmail.com", "NamDepTRai923", "Hashed_password_02", null, false, false, "Ho Hoang923", null, "User", null, 0 },
                    { new Guid("829f81a6-2667-4d94-a06a-4028d9eb6816"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76417417@gmail.com", "NamDepTRai417", "Hashed_password_02", null, false, false, "Ho Hoang417", null, "User", null, 0 },
                    { new Guid("82d0c1ad-9afe-4452-bea5-24aed960aa53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76249249@gmail.com", "NamDepTRai249", "Hashed_password_02", null, false, false, "Ho Hoang249", null, "User", null, 0 },
                    { new Guid("82d1d10c-76f4-4f18-894d-fb0de308a0e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76218218@gmail.com", "NamDepTRai218", "Hashed_password_02", null, false, false, "Ho Hoang218", null, "User", null, 0 },
                    { new Guid("82d6d1d9-06fc-4016-a07e-27b425a082bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76615615@gmail.com", "NamDepTRai615", "Hashed_password_02", null, false, false, "Ho Hoang615", null, "User", null, 0 },
                    { new Guid("831de9d2-5cff-4190-9cd3-6b122c963e8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76140140@gmail.com", "NamDepTRai140", "Hashed_password_02", null, false, false, "Ho Hoang140", null, "User", null, 0 },
                    { new Guid("833bd3f6-1fb1-4a46-aea2-f31eaf06e083"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76459459@gmail.com", "NamDepTRai459", "Hashed_password_02", null, false, false, "Ho Hoang459", null, "User", null, 0 },
                    { new Guid("83e7d5a9-ffa1-47df-9daf-9c379039c5c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76113113@gmail.com", "NamDepTRai113", "Hashed_password_02", null, false, false, "Ho Hoang113", null, "User", null, 0 },
                    { new Guid("84072197-2d45-4342-bdb0-ab0f96994207"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76433433@gmail.com", "NamDepTRai433", "Hashed_password_02", null, false, false, "Ho Hoang433", null, "User", null, 0 },
                    { new Guid("842eb446-2c3f-4109-87fa-6a9d565edf7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76623623@gmail.com", "NamDepTRai623", "Hashed_password_02", null, false, false, "Ho Hoang623", null, "User", null, 0 },
                    { new Guid("84399c20-4731-4ba5-871c-9ecba2268d2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76861861@gmail.com", "NamDepTRai861", "Hashed_password_02", null, false, false, "Ho Hoang861", null, "User", null, 0 },
                    { new Guid("8451efcc-5e00-4e5a-b76d-8fa9a977217f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76517517@gmail.com", "NamDepTRai517", "Hashed_password_02", null, false, false, "Ho Hoang517", null, "User", null, 0 },
                    { new Guid("846f7e60-125d-40df-8875-87b59a8095b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765757@gmail.com", "NamDepTRai57", "Hashed_password_02", null, false, false, "Ho Hoang57", null, "User", null, 0 },
                    { new Guid("84d3b27d-bf11-44d8-8e0c-a5fc04985620"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76881881@gmail.com", "NamDepTRai881", "Hashed_password_02", null, false, false, "Ho Hoang881", null, "User", null, 0 },
                    { new Guid("84e5b1c7-6d8f-4403-b46e-1ab264ae9bbb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76728728@gmail.com", "NamDepTRai728", "Hashed_password_02", null, false, false, "Ho Hoang728", null, "User", null, 0 },
                    { new Guid("8600ad7e-10d0-4ccd-a5a4-a90306a42f30"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769999@gmail.com", "NamDepTRai99", "Hashed_password_02", null, false, false, "Ho Hoang99", null, "User", null, 0 },
                    { new Guid("8650d961-9a3e-486c-8929-472fc6e41d58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76779779@gmail.com", "NamDepTRai779", "Hashed_password_02", null, false, false, "Ho Hoang779", null, "User", null, 0 },
                    { new Guid("865e330d-5391-420a-8521-7be429bcbd41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76980980@gmail.com", "NamDepTRai980", "Hashed_password_02", null, false, false, "Ho Hoang980", null, "User", null, 0 },
                    { new Guid("868555f3-6b15-419d-9844-b4a3c588adda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76745745@gmail.com", "NamDepTRai745", "Hashed_password_02", null, false, false, "Ho Hoang745", null, "User", null, 0 },
                    { new Guid("868b5c81-c842-4985-9981-7f45d8da463f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76543543@gmail.com", "NamDepTRai543", "Hashed_password_02", null, false, false, "Ho Hoang543", null, "User", null, 0 },
                    { new Guid("871df902-beac-48c3-9e2e-b6436006240b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76908908@gmail.com", "NamDepTRai908", "Hashed_password_02", null, false, false, "Ho Hoang908", null, "User", null, 0 },
                    { new Guid("87449e33-0198-4073-97c6-314a0a039f72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76761761@gmail.com", "NamDepTRai761", "Hashed_password_02", null, false, false, "Ho Hoang761", null, "User", null, 0 },
                    { new Guid("87549cdf-e295-4011-8992-6471e866ae89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76935935@gmail.com", "NamDepTRai935", "Hashed_password_02", null, false, false, "Ho Hoang935", null, "User", null, 0 },
                    { new Guid("877535de-23df-49cb-be66-deee29bd229a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76588588@gmail.com", "NamDepTRai588", "Hashed_password_02", null, false, false, "Ho Hoang588", null, "User", null, 0 },
                    { new Guid("87e09b4d-afbd-4710-9845-3abcd6a0c6bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76602602@gmail.com", "NamDepTRai602", "Hashed_password_02", null, false, false, "Ho Hoang602", null, "User", null, 0 },
                    { new Guid("87ecab59-daec-49ba-b50a-a8fa882f706e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76421421@gmail.com", "NamDepTRai421", "Hashed_password_02", null, false, false, "Ho Hoang421", null, "User", null, 0 },
                    { new Guid("880b9006-62cc-493a-9bf7-42696527cba2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76208208@gmail.com", "NamDepTRai208", "Hashed_password_02", null, false, false, "Ho Hoang208", null, "User", null, 0 },
                    { new Guid("883aa51f-aa68-4b9d-9858-3c1a97c4040b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76452452@gmail.com", "NamDepTRai452", "Hashed_password_02", null, false, false, "Ho Hoang452", null, "User", null, 0 },
                    { new Guid("883c8625-75a9-4f88-8931-05069ecbcf18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76250250@gmail.com", "NamDepTRai250", "Hashed_password_02", null, false, false, "Ho Hoang250", null, "User", null, 0 },
                    { new Guid("884d9a9d-e55f-45cf-a204-e2efe96e3e93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76531531@gmail.com", "NamDepTRai531", "Hashed_password_02", null, false, false, "Ho Hoang531", null, "User", null, 0 },
                    { new Guid("8867c5cb-4de1-4b29-a7a6-37cb020b3e5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76760760@gmail.com", "NamDepTRai760", "Hashed_password_02", null, false, false, "Ho Hoang760", null, "User", null, 0 },
                    { new Guid("886f6dc7-6052-4b1f-bb23-69b8555c207f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765959@gmail.com", "NamDepTRai59", "Hashed_password_02", null, false, false, "Ho Hoang59", null, "User", null, 0 },
                    { new Guid("8891eabb-9b3e-40fa-81d9-d65fa3ac35b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76619619@gmail.com", "NamDepTRai619", "Hashed_password_02", null, false, false, "Ho Hoang619", null, "User", null, 0 },
                    { new Guid("88a733ec-9a98-4229-9b61-8118b6075e74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76337337@gmail.com", "NamDepTRai337", "Hashed_password_02", null, false, false, "Ho Hoang337", null, "User", null, 0 },
                    { new Guid("89265ed1-d7f3-4dda-89c7-b8f33f2cba78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76954954@gmail.com", "NamDepTRai954", "Hashed_password_02", null, false, false, "Ho Hoang954", null, "User", null, 0 },
                    { new Guid("8abe9944-7726-473f-a839-269fd8f7021e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76921921@gmail.com", "NamDepTRai921", "Hashed_password_02", null, false, false, "Ho Hoang921", null, "User", null, 0 },
                    { new Guid("8b803106-c905-47a3-9ac0-f17884b38a71"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767474@gmail.com", "NamDepTRai74", "Hashed_password_02", null, false, false, "Ho Hoang74", null, "User", null, 0 },
                    { new Guid("8b8488dd-c79c-4c0b-9212-d7339b86351b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76347347@gmail.com", "NamDepTRai347", "Hashed_password_02", null, false, false, "Ho Hoang347", null, "User", null, 0 },
                    { new Guid("8bb7bda1-41f5-43c5-b66f-0b23e76522a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76355355@gmail.com", "NamDepTRai355", "Hashed_password_02", null, false, false, "Ho Hoang355", null, "User", null, 0 },
                    { new Guid("8bf5370d-4825-4a6a-bd6c-020eba992671"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76166166@gmail.com", "NamDepTRai166", "Hashed_password_02", null, false, false, "Ho Hoang166", null, "User", null, 0 },
                    { new Guid("8cfd2121-8c3c-473a-8fba-00100f7d1df6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76636636@gmail.com", "NamDepTRai636", "Hashed_password_02", null, false, false, "Ho Hoang636", null, "User", null, 0 },
                    { new Guid("8d00b52c-b6ae-4b01-8493-b0efb1e4bb8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76394394@gmail.com", "NamDepTRai394", "Hashed_password_02", null, false, false, "Ho Hoang394", null, "User", null, 0 },
                    { new Guid("8d4e0a43-5156-4a8a-be81-35ccd981f170"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76774774@gmail.com", "NamDepTRai774", "Hashed_password_02", null, false, false, "Ho Hoang774", null, "User", null, 0 },
                    { new Guid("8d4ebe1f-09dc-4425-a9d3-988fc8a43e8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76696696@gmail.com", "NamDepTRai696", "Hashed_password_02", null, false, false, "Ho Hoang696", null, "User", null, 0 },
                    { new Guid("8d8b503c-9c06-4f65-9a05-96239d4f28b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76514514@gmail.com", "NamDepTRai514", "Hashed_password_02", null, false, false, "Ho Hoang514", null, "User", null, 0 },
                    { new Guid("8e00547f-cba4-43f7-9c8a-a39ef1b49142"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76678678@gmail.com", "NamDepTRai678", "Hashed_password_02", null, false, false, "Ho Hoang678", null, "User", null, 0 },
                    { new Guid("8e5b2049-cf37-4a0d-80c4-049966b221da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76662662@gmail.com", "NamDepTRai662", "Hashed_password_02", null, false, false, "Ho Hoang662", null, "User", null, 0 },
                    { new Guid("8e5fb86b-8b4c-4f7d-9339-8662c6553c74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76904904@gmail.com", "NamDepTRai904", "Hashed_password_02", null, false, false, "Ho Hoang904", null, "User", null, 0 },
                    { new Guid("8faf8650-8253-497f-825c-9fd9b46eda89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76116116@gmail.com", "NamDepTRai116", "Hashed_password_02", null, false, false, "Ho Hoang116", null, "User", null, 0 },
                    { new Guid("905ae1c4-d0d8-4250-b10e-7d5d1690d56e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76941941@gmail.com", "NamDepTRai941", "Hashed_password_02", null, false, false, "Ho Hoang941", null, "User", null, 0 },
                    { new Guid("906bb9e6-df54-445e-92f4-3a7341c721d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766363@gmail.com", "NamDepTRai63", "Hashed_password_02", null, false, false, "Ho Hoang63", null, "User", null, 0 },
                    { new Guid("90890573-a0da-4d25-b57c-a9fb5b59f318"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76519519@gmail.com", "NamDepTRai519", "Hashed_password_02", null, false, false, "Ho Hoang519", null, "User", null, 0 },
                    { new Guid("908a4ab2-06dc-4fe7-bc31-50c64bf34c5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76583583@gmail.com", "NamDepTRai583", "Hashed_password_02", null, false, false, "Ho Hoang583", null, "User", null, 0 },
                    { new Guid("908b8a76-5917-41f8-8262-1f6c58fca7b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76900900@gmail.com", "NamDepTRai900", "Hashed_password_02", null, false, false, "Ho Hoang900", null, "User", null, 0 },
                    { new Guid("9153f2eb-b381-418c-b4a8-712711c3f78f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76193193@gmail.com", "NamDepTRai193", "Hashed_password_02", null, false, false, "Ho Hoang193", null, "User", null, 0 },
                    { new Guid("91728efb-fd9b-482c-b17f-f844212227e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76186186@gmail.com", "NamDepTRai186", "Hashed_password_02", null, false, false, "Ho Hoang186", null, "User", null, 0 },
                    { new Guid("91e57fc2-c98b-437a-991f-3a5047089dd3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76681681@gmail.com", "NamDepTRai681", "Hashed_password_02", null, false, false, "Ho Hoang681", null, "User", null, 0 },
                    { new Guid("92abfda0-a132-4cb4-82b3-836652548659"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76792792@gmail.com", "NamDepTRai792", "Hashed_password_02", null, false, false, "Ho Hoang792", null, "User", null, 0 },
                    { new Guid("92ef3d7e-a6f5-4550-a521-6444f40bb1ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76670670@gmail.com", "NamDepTRai670", "Hashed_password_02", null, false, false, "Ho Hoang670", null, "User", null, 0 },
                    { new Guid("92fc7756-7691-407f-9dae-10e27222ce5b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76491491@gmail.com", "NamDepTRai491", "Hashed_password_02", null, false, false, "Ho Hoang491", null, "User", null, 0 },
                    { new Guid("93ab62cf-2267-4b2c-ae21-fc8ab8ac6677"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76197197@gmail.com", "NamDepTRai197", "Hashed_password_02", null, false, false, "Ho Hoang197", null, "User", null, 0 },
                    { new Guid("944e25c0-bd16-4671-bb4d-80fc91b12006"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76985985@gmail.com", "NamDepTRai985", "Hashed_password_02", null, false, false, "Ho Hoang985", null, "User", null, 0 },
                    { new Guid("94a6b4c2-e31f-47bb-8bca-553c65abe0cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76341341@gmail.com", "NamDepTRai341", "Hashed_password_02", null, false, false, "Ho Hoang341", null, "User", null, 0 },
                    { new Guid("950cebf2-e206-4149-9de5-3d6610929632"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76725725@gmail.com", "NamDepTRai725", "Hashed_password_02", null, false, false, "Ho Hoang725", null, "User", null, 0 },
                    { new Guid("9539b6fc-d977-4847-b2f5-08e01d949597"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76117117@gmail.com", "NamDepTRai117", "Hashed_password_02", null, false, false, "Ho Hoang117", null, "User", null, 0 },
                    { new Guid("95673fbd-9190-490a-b89d-ad9400667abc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76266266@gmail.com", "NamDepTRai266", "Hashed_password_02", null, false, false, "Ho Hoang266", null, "User", null, 0 },
                    { new Guid("968bd322-6464-4a77-a677-dc62e5c44769"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76409409@gmail.com", "NamDepTRai409", "Hashed_password_02", null, false, false, "Ho Hoang409", null, "User", null, 0 },
                    { new Guid("968d963d-81f1-425e-8497-46ecee6e43a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767575@gmail.com", "NamDepTRai75", "Hashed_password_02", null, false, false, "Ho Hoang75", null, "User", null, 0 },
                    { new Guid("96915a9f-71ec-4af0-ae21-a74fb7a97462"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76232232@gmail.com", "NamDepTRai232", "Hashed_password_02", null, false, false, "Ho Hoang232", null, "User", null, 0 },
                    { new Guid("96c826f4-bbfb-4a9e-8237-93283a847969"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76948948@gmail.com", "NamDepTRai948", "Hashed_password_02", null, false, false, "Ho Hoang948", null, "User", null, 0 },
                    { new Guid("97508bba-39e3-4194-900d-f24b97223dde"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76326326@gmail.com", "NamDepTRai326", "Hashed_password_02", null, false, false, "Ho Hoang326", null, "User", null, 0 },
                    { new Guid("975e8ae5-b915-4f31-9896-6833a3ebc124"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762020@gmail.com", "NamDepTRai20", "Hashed_password_02", null, false, false, "Ho Hoang20", null, "User", null, 0 },
                    { new Guid("9783404b-0d43-428f-bc74-f97615309d06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76611611@gmail.com", "NamDepTRai611", "Hashed_password_02", null, false, false, "Ho Hoang611", null, "User", null, 0 },
                    { new Guid("978df77e-c2da-4edf-9d6f-1b141aa653e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76971971@gmail.com", "NamDepTRai971", "Hashed_password_02", null, false, false, "Ho Hoang971", null, "User", null, 0 },
                    { new Guid("983b43ea-a9e6-4d7c-a475-b7b2a53a4d2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767979@gmail.com", "NamDepTRai79", "Hashed_password_02", null, false, false, "Ho Hoang79", null, "User", null, 0 },
                    { new Guid("983b9470-0bff-43fc-82b3-c38e9c8b2c48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76300300@gmail.com", "NamDepTRai300", "Hashed_password_02", null, false, false, "Ho Hoang300", null, "User", null, 0 },
                    { new Guid("9905b919-6916-4122-a054-688745b1a053"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76656656@gmail.com", "NamDepTRai656", "Hashed_password_02", null, false, false, "Ho Hoang656", null, "User", null, 0 },
                    { new Guid("99dcbf77-6398-4779-9b83-da08b016d4e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76901901@gmail.com", "NamDepTRai901", "Hashed_password_02", null, false, false, "Ho Hoang901", null, "User", null, 0 },
                    { new Guid("9a33499f-3ec4-4e09-9c03-5cddd1f9e263"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76677677@gmail.com", "NamDepTRai677", "Hashed_password_02", null, false, false, "Ho Hoang677", null, "User", null, 0 },
                    { new Guid("9a3d831f-85f4-4722-8e0f-6e689da63d19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76841841@gmail.com", "NamDepTRai841", "Hashed_password_02", null, false, false, "Ho Hoang841", null, "User", null, 0 },
                    { new Guid("9a816152-5eb9-4370-8815-d2af5cfad5c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76638638@gmail.com", "NamDepTRai638", "Hashed_password_02", null, false, false, "Ho Hoang638", null, "User", null, 0 },
                    { new Guid("9af3929f-9175-490e-bdcb-4243031f20ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76555555@gmail.com", "NamDepTRai555", "Hashed_password_02", null, false, false, "Ho Hoang555", null, "User", null, 0 },
                    { new Guid("9b993787-77fe-4356-bd9e-34a794402118"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76539539@gmail.com", "NamDepTRai539", "Hashed_password_02", null, false, false, "Ho Hoang539", null, "User", null, 0 },
                    { new Guid("9bbbaeda-1876-4361-b626-94223e9a95eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76465465@gmail.com", "NamDepTRai465", "Hashed_password_02", null, false, false, "Ho Hoang465", null, "User", null, 0 },
                    { new Guid("9c06d20a-f733-439d-b8ca-6f313f64d9c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76723723@gmail.com", "NamDepTRai723", "Hashed_password_02", null, false, false, "Ho Hoang723", null, "User", null, 0 },
                    { new Guid("9c07b37c-5311-4f5e-af96-ba3e1e5056c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76913913@gmail.com", "NamDepTRai913", "Hashed_password_02", null, false, false, "Ho Hoang913", null, "User", null, 0 },
                    { new Guid("9c2088bf-93d9-439a-a4bc-b170afcd537d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76@gmail.com", "NamDepTRai", "Hashed_password_02", null, false, false, "Ho Hoang", null, "User", null, 0 },
                    { new Guid("9c66d9b6-1841-4b42-808e-de1953e9554d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76255255@gmail.com", "NamDepTRai255", "Hashed_password_02", null, false, false, "Ho Hoang255", null, "User", null, 0 },
                    { new Guid("9c6d8b7f-bc9a-4c87-b76c-e84186bb0b47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76387387@gmail.com", "NamDepTRai387", "Hashed_password_02", null, false, false, "Ho Hoang387", null, "User", null, 0 },
                    { new Guid("9cb76f42-96e8-4fb8-87ec-11bd0acf96ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766666@gmail.com", "NamDepTRai66", "Hashed_password_02", null, false, false, "Ho Hoang66", null, "User", null, 0 },
                    { new Guid("9cf9dba8-7450-4d52-9a7e-53be21e99d79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76835835@gmail.com", "NamDepTRai835", "Hashed_password_02", null, false, false, "Ho Hoang835", null, "User", null, 0 },
                    { new Guid("9d217f9b-e132-4de0-aa15-61a60655b95f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76626626@gmail.com", "NamDepTRai626", "Hashed_password_02", null, false, false, "Ho Hoang626", null, "User", null, 0 },
                    { new Guid("9d2c7ca4-6af1-4100-9467-86de265f5abd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76349349@gmail.com", "NamDepTRai349", "Hashed_password_02", null, false, false, "Ho Hoang349", null, "User", null, 0 },
                    { new Guid("9dc2cfba-ce9e-4287-944a-38293437fe34"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76160160@gmail.com", "NamDepTRai160", "Hashed_password_02", null, false, false, "Ho Hoang160", null, "User", null, 0 },
                    { new Guid("9e062add-a714-4153-87bd-6acf182b675d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76527527@gmail.com", "NamDepTRai527", "Hashed_password_02", null, false, false, "Ho Hoang527", null, "User", null, 0 },
                    { new Guid("9e133e4d-20d3-407b-9b79-59f0ec496c0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76227227@gmail.com", "NamDepTRai227", "Hashed_password_02", null, false, false, "Ho Hoang227", null, "User", null, 0 },
                    { new Guid("9e1de3b9-7804-4c2a-9b8c-e63e7be7ae7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76275275@gmail.com", "NamDepTRai275", "Hashed_password_02", null, false, false, "Ho Hoang275", null, "User", null, 0 },
                    { new Guid("9ec8c909-242f-41cc-b1cf-9e287c555593"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76637637@gmail.com", "NamDepTRai637", "Hashed_password_02", null, false, false, "Ho Hoang637", null, "User", null, 0 },
                    { new Guid("9ecd0cac-250d-4e19-9275-29d5a4ac3946"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76481481@gmail.com", "NamDepTRai481", "Hashed_password_02", null, false, false, "Ho Hoang481", null, "User", null, 0 },
                    { new Guid("9efaf709-ce3d-4aee-9da2-de9bf89051ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764242@gmail.com", "NamDepTRai42", "Hashed_password_02", null, false, false, "Ho Hoang42", null, "User", null, 0 },
                    { new Guid("9efd5a61-f1c4-49aa-b2bd-5f8cf9967963"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76724724@gmail.com", "NamDepTRai724", "Hashed_password_02", null, false, false, "Ho Hoang724", null, "User", null, 0 },
                    { new Guid("9f4ec26a-ec3e-4219-a6e2-d6692e1f52f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76996996@gmail.com", "NamDepTRai996", "Hashed_password_02", null, false, false, "Ho Hoang996", null, "User", null, 0 },
                    { new Guid("9f8b109b-22f2-4095-8f82-3e55641ece76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76586586@gmail.com", "NamDepTRai586", "Hashed_password_02", null, false, false, "Ho Hoang586", null, "User", null, 0 },
                    { new Guid("9fee981f-7ce8-4aae-8a89-0bb023bc1f1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76843843@gmail.com", "NamDepTRai843", "Hashed_password_02", null, false, false, "Ho Hoang843", null, "User", null, 0 },
                    { new Guid("a0ba7e32-d0cf-41ff-ba14-5bbedbe26e28"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76393393@gmail.com", "NamDepTRai393", "Hashed_password_02", null, false, false, "Ho Hoang393", null, "User", null, 0 },
                    { new Guid("a10c833e-2402-4ea4-a5b2-dfe59398d79c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76264264@gmail.com", "NamDepTRai264", "Hashed_password_02", null, false, false, "Ho Hoang264", null, "User", null, 0 },
                    { new Guid("a131db4e-2e3c-4ee1-bc55-b9569efc5c3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76593593@gmail.com", "NamDepTRai593", "Hashed_password_02", null, false, false, "Ho Hoang593", null, "User", null, 0 },
                    { new Guid("a16e177b-8f8a-4069-ad80-5e6b43b366d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76291291@gmail.com", "NamDepTRai291", "Hashed_password_02", null, false, false, "Ho Hoang291", null, "User", null, 0 },
                    { new Guid("a1b64f21-22f7-4cb4-84f7-bc3d2d51d91a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76791791@gmail.com", "NamDepTRai791", "Hashed_password_02", null, false, false, "Ho Hoang791", null, "User", null, 0 },
                    { new Guid("a1f2a55e-1332-4ba9-9fb8-c058dee475c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76703703@gmail.com", "NamDepTRai703", "Hashed_password_02", null, false, false, "Ho Hoang703", null, "User", null, 0 },
                    { new Guid("a2059b67-3002-4c4b-b687-59597b7538f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76484484@gmail.com", "NamDepTRai484", "Hashed_password_02", null, false, false, "Ho Hoang484", null, "User", null, 0 },
                    { new Guid("a2739acb-c440-4420-88f3-6876f1315a8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76450450@gmail.com", "NamDepTRai450", "Hashed_password_02", null, false, false, "Ho Hoang450", null, "User", null, 0 },
                    { new Guid("a27ef38f-54d9-4bf4-b74b-f24fcbbc3ba5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76632632@gmail.com", "NamDepTRai632", "Hashed_password_02", null, false, false, "Ho Hoang632", null, "User", null, 0 },
                    { new Guid("a2dfc715-f34e-4db4-84a6-fc121a5d87da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76115115@gmail.com", "NamDepTRai115", "Hashed_password_02", null, false, false, "Ho Hoang115", null, "User", null, 0 },
                    { new Guid("a2f63e2a-e8d4-467f-95f2-07cdf0782f8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76734734@gmail.com", "NamDepTRai734", "Hashed_password_02", null, false, false, "Ho Hoang734", null, "User", null, 0 },
                    { new Guid("a30fced2-a46f-4b67-9d4d-2d670bda2625"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76978978@gmail.com", "NamDepTRai978", "Hashed_password_02", null, false, false, "Ho Hoang978", null, "User", null, 0 },
                    { new Guid("a36b0352-7b3a-4114-899f-364d68aeb6d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76415415@gmail.com", "NamDepTRai415", "Hashed_password_02", null, false, false, "Ho Hoang415", null, "User", null, 0 },
                    { new Guid("a383f6c6-510e-4c79-878a-ea7784eccf19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76252252@gmail.com", "NamDepTRai252", "Hashed_password_02", null, false, false, "Ho Hoang252", null, "User", null, 0 },
                    { new Guid("a388ac69-1742-42e4-a776-f2999aafe419"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76426426@gmail.com", "NamDepTRai426", "Hashed_password_02", null, false, false, "Ho Hoang426", null, "User", null, 0 },
                    { new Guid("a3c64e2d-f3f4-4bdb-bdc2-7287e6af39c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76804804@gmail.com", "NamDepTRai804", "Hashed_password_02", null, false, false, "Ho Hoang804", null, "User", null, 0 },
                    { new Guid("a3dfc25a-aba4-4452-b8f6-88fc34d93ec2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768989@gmail.com", "NamDepTRai89", "Hashed_password_02", null, false, false, "Ho Hoang89", null, "User", null, 0 },
                    { new Guid("a451d5de-6860-428e-b501-c0541b5b1e62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767272@gmail.com", "NamDepTRai72", "Hashed_password_02", null, false, false, "Ho Hoang72", null, "User", null, 0 },
                    { new Guid("a460d056-5c1a-4285-a19e-d41f7ac9572b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76699699@gmail.com", "NamDepTRai699", "Hashed_password_02", null, false, false, "Ho Hoang699", null, "User", null, 0 },
                    { new Guid("a4649371-546a-441b-b263-74484fea2453"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76374374@gmail.com", "NamDepTRai374", "Hashed_password_02", null, false, false, "Ho Hoang374", null, "User", null, 0 },
                    { new Guid("a49e583a-593d-4934-bfed-a6117896037e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76970970@gmail.com", "NamDepTRai970", "Hashed_password_02", null, false, false, "Ho Hoang970", null, "User", null, 0 },
                    { new Guid("a55332e7-0d6a-4907-abc3-a5fd3f9eea39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7633@gmail.com", "NamDepTRai3", "Hashed_password_02", null, false, false, "Ho Hoang3", null, "User", null, 0 },
                    { new Guid("a5ad5574-767c-4e1b-b3e4-3c4f95ddebdc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76196196@gmail.com", "NamDepTRai196", "Hashed_password_02", null, false, false, "Ho Hoang196", null, "User", null, 0 },
                    { new Guid("a63eb619-6c25-46ea-958d-419eff843ce7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76479479@gmail.com", "NamDepTRai479", "Hashed_password_02", null, false, false, "Ho Hoang479", null, "User", null, 0 },
                    { new Guid("a653305c-b547-4d14-b07a-4b03ac29c27a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76456456@gmail.com", "NamDepTRai456", "Hashed_password_02", null, false, false, "Ho Hoang456", null, "User", null, 0 },
                    { new Guid("a670ab99-f999-4aad-b067-c23a11776812"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76762762@gmail.com", "NamDepTRai762", "Hashed_password_02", null, false, false, "Ho Hoang762", null, "User", null, 0 },
                    { new Guid("a74edde4-1e86-4e5c-8be7-19e3906be38f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76673673@gmail.com", "NamDepTRai673", "Hashed_password_02", null, false, false, "Ho Hoang673", null, "User", null, 0 },
                    { new Guid("a79f7efd-e5e1-4b3f-96f7-5bca990445b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76646646@gmail.com", "NamDepTRai646", "Hashed_password_02", null, false, false, "Ho Hoang646", null, "User", null, 0 },
                    { new Guid("a7f6599c-a5ea-461c-b9c1-52dcc05a162f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76854854@gmail.com", "NamDepTRai854", "Hashed_password_02", null, false, false, "Ho Hoang854", null, "User", null, 0 },
                    { new Guid("a7fceaa7-fa5d-483a-ae7d-7d3635b446bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76288288@gmail.com", "NamDepTRai288", "Hashed_password_02", null, false, false, "Ho Hoang288", null, "User", null, 0 },
                    { new Guid("a81cb48c-b70a-40a9-b924-3d0d9296c063"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76755755@gmail.com", "NamDepTRai755", "Hashed_password_02", null, false, false, "Ho Hoang755", null, "User", null, 0 },
                    { new Guid("a8801539-97be-439f-b333-dcd339a3c886"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76832832@gmail.com", "NamDepTRai832", "Hashed_password_02", null, false, false, "Ho Hoang832", null, "User", null, 0 },
                    { new Guid("a8bf5fa1-fe6a-4744-b19c-bf026fd9f28f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76850850@gmail.com", "NamDepTRai850", "Hashed_password_02", null, false, false, "Ho Hoang850", null, "User", null, 0 },
                    { new Guid("a8c10285-48b3-496d-8943-01e738a0d72f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76909909@gmail.com", "NamDepTRai909", "Hashed_password_02", null, false, false, "Ho Hoang909", null, "User", null, 0 },
                    { new Guid("a9a86a02-119c-48e5-b91a-8dfb06cd8910"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76434434@gmail.com", "NamDepTRai434", "Hashed_password_02", null, false, false, "Ho Hoang434", null, "User", null, 0 },
                    { new Guid("a9de60b9-ab89-48a1-ba27-125511aede77"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76444444@gmail.com", "NamDepTRai444", "Hashed_password_02", null, false, false, "Ho Hoang444", null, "User", null, 0 },
                    { new Guid("a9fcad60-52c7-430f-94c4-d61472b73f33"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76424424@gmail.com", "NamDepTRai424", "Hashed_password_02", null, false, false, "Ho Hoang424", null, "User", null, 0 },
                    { new Guid("aa054ec0-f784-4ad9-a7f9-6ec40e1466fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76361361@gmail.com", "NamDepTRai361", "Hashed_password_02", null, false, false, "Ho Hoang361", null, "User", null, 0 },
                    { new Guid("aa0e3755-3f59-40f8-b3ff-237d026c1504"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76390390@gmail.com", "NamDepTRai390", "Hashed_password_02", null, false, false, "Ho Hoang390", null, "User", null, 0 },
                    { new Guid("aa3a42d1-6d78-4fc3-8a55-940f717a9cdb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76753753@gmail.com", "NamDepTRai753", "Hashed_password_02", null, false, false, "Ho Hoang753", null, "User", null, 0 },
                    { new Guid("aa3c5d5b-c58e-4805-9532-9d31ac514a14"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76778778@gmail.com", "NamDepTRai778", "Hashed_password_02", null, false, false, "Ho Hoang778", null, "User", null, 0 },
                    { new Guid("aa66540f-fbee-43ae-a3ec-98e74b934717"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76120120@gmail.com", "NamDepTRai120", "Hashed_password_02", null, false, false, "Ho Hoang120", null, "User", null, 0 },
                    { new Guid("aac6e44b-04a5-474f-94f2-124cb0b0ca97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76319319@gmail.com", "NamDepTRai319", "Hashed_password_02", null, false, false, "Ho Hoang319", null, "User", null, 0 },
                    { new Guid("aada9bad-16d6-4166-b4a4-9bc24d533b79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76655655@gmail.com", "NamDepTRai655", "Hashed_password_02", null, false, false, "Ho Hoang655", null, "User", null, 0 },
                    { new Guid("aafa88c5-4281-4d58-8fea-e554e271959f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76131131@gmail.com", "NamDepTRai131", "Hashed_password_02", null, false, false, "Ho Hoang131", null, "User", null, 0 },
                    { new Guid("ab0de201-0395-49f0-b3ff-1c831fba8d49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76882882@gmail.com", "NamDepTRai882", "Hashed_password_02", null, false, false, "Ho Hoang882", null, "User", null, 0 },
                    { new Guid("ab547ef2-b905-4dcb-b189-0f1be19d3f2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76927927@gmail.com", "NamDepTRai927", "Hashed_password_02", null, false, false, "Ho Hoang927", null, "User", null, 0 },
                    { new Guid("ab6ddf17-a982-40e8-b8ad-4276494d940d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761414@gmail.com", "NamDepTRai14", "Hashed_password_02", null, false, false, "Ho Hoang14", null, "User", null, 0 },
                    { new Guid("ab942019-9280-42f5-ad81-6b953404306d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76124124@gmail.com", "NamDepTRai124", "Hashed_password_02", null, false, false, "Ho Hoang124", null, "User", null, 0 },
                    { new Guid("abc26dd2-fe0b-48b8-8581-bee4a1502b98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76659659@gmail.com", "NamDepTRai659", "Hashed_password_02", null, false, false, "Ho Hoang659", null, "User", null, 0 },
                    { new Guid("abd4993a-f61b-4917-8da1-b4dd74dcd142"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76958958@gmail.com", "NamDepTRai958", "Hashed_password_02", null, false, false, "Ho Hoang958", null, "User", null, 0 },
                    { new Guid("ac88e24d-0f00-451e-aea8-d8980f342f84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76765765@gmail.com", "NamDepTRai765", "Hashed_password_02", null, false, false, "Ho Hoang765", null, "User", null, 0 },
                    { new Guid("ad5c9949-3915-4b26-8920-b4aacc85ad70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76513513@gmail.com", "NamDepTRai513", "Hashed_password_02", null, false, false, "Ho Hoang513", null, "User", null, 0 },
                    { new Guid("ad7be630-2f03-47a0-8ab6-c4f9c62ffbe3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76301301@gmail.com", "NamDepTRai301", "Hashed_password_02", null, false, false, "Ho Hoang301", null, "User", null, 0 },
                    { new Guid("aeed8169-316a-4fde-8d96-3ad8b5d73a43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76833833@gmail.com", "NamDepTRai833", "Hashed_password_02", null, false, false, "Ho Hoang833", null, "User", null, 0 },
                    { new Guid("aef70c51-8696-45b1-bc37-9610a87d2f00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76610610@gmail.com", "NamDepTRai610", "Hashed_password_02", null, false, false, "Ho Hoang610", null, "User", null, 0 },
                    { new Guid("af1031cc-d6b8-4379-983e-a54b33200372"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76863863@gmail.com", "NamDepTRai863", "Hashed_password_02", null, false, false, "Ho Hoang863", null, "User", null, 0 },
                    { new Guid("af469eed-be40-4388-89fc-b35f6d6c1839"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76622622@gmail.com", "NamDepTRai622", "Hashed_password_02", null, false, false, "Ho Hoang622", null, "User", null, 0 },
                    { new Guid("afdf05fb-6935-4ab9-b2cb-1beebf80f923"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76886886@gmail.com", "NamDepTRai886", "Hashed_password_02", null, false, false, "Ho Hoang886", null, "User", null, 0 },
                    { new Guid("afedc4be-2e7f-432a-84c5-fb51eef92d6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76772772@gmail.com", "NamDepTRai772", "Hashed_password_02", null, false, false, "Ho Hoang772", null, "User", null, 0 },
                    { new Guid("afef1da9-132f-4bf3-b047-628b5936fdf0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76919919@gmail.com", "NamDepTRai919", "Hashed_password_02", null, false, false, "Ho Hoang919", null, "User", null, 0 },
                    { new Guid("b017aa71-098c-447a-956a-b5a50fb8df14"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76968968@gmail.com", "NamDepTRai968", "Hashed_password_02", null, false, false, "Ho Hoang968", null, "User", null, 0 },
                    { new Guid("b0501b81-3b9f-4fa7-a38f-8cb12c4c73f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76143143@gmail.com", "NamDepTRai143", "Hashed_password_02", null, false, false, "Ho Hoang143", null, "User", null, 0 },
                    { new Guid("b08457c4-5cc6-43a2-83d1-c036c64ede74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76468468@gmail.com", "NamDepTRai468", "Hashed_password_02", null, false, false, "Ho Hoang468", null, "User", null, 0 },
                    { new Guid("b09113ae-3adc-4287-b1fb-bd4a3f878908"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76151151@gmail.com", "NamDepTRai151", "Hashed_password_02", null, false, false, "Ho Hoang151", null, "User", null, 0 },
                    { new Guid("b0e6e4b0-b001-4b3f-8bee-f24462bc8a0f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76840840@gmail.com", "NamDepTRai840", "Hashed_password_02", null, false, false, "Ho Hoang840", null, "User", null, 0 },
                    { new Guid("b14e785c-ad3b-4b76-92af-f555d89323c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76320320@gmail.com", "NamDepTRai320", "Hashed_password_02", null, false, false, "Ho Hoang320", null, "User", null, 0 },
                    { new Guid("b19ad43b-d495-44db-8bc0-9c4434051a1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76891891@gmail.com", "NamDepTRai891", "Hashed_password_02", null, false, false, "Ho Hoang891", null, "User", null, 0 },
                    { new Guid("b1becc72-f459-4ca1-9143-5653066384cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76950950@gmail.com", "NamDepTRai950", "Hashed_password_02", null, false, false, "Ho Hoang950", null, "User", null, 0 },
                    { new Guid("b25167fb-cdad-454d-adf3-5395064ff528"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76512512@gmail.com", "NamDepTRai512", "Hashed_password_02", null, false, false, "Ho Hoang512", null, "User", null, 0 },
                    { new Guid("b25e64dd-7b80-4a69-9f3f-9b0a5ae4a003"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76457457@gmail.com", "NamDepTRai457", "Hashed_password_02", null, false, false, "Ho Hoang457", null, "User", null, 0 },
                    { new Guid("b295b20f-b0a9-48bb-b46b-bf43cd9348c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76268268@gmail.com", "NamDepTRai268", "Hashed_password_02", null, false, false, "Ho Hoang268", null, "User", null, 0 },
                    { new Guid("b2c0a339-81b4-44d5-a323-07d6308dfe3e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76553553@gmail.com", "NamDepTRai553", "Hashed_password_02", null, false, false, "Ho Hoang553", null, "User", null, 0 },
                    { new Guid("b2e72937-1ec4-4ba2-b65e-0c3fbb657e45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76937937@gmail.com", "NamDepTRai937", "Hashed_password_02", null, false, false, "Ho Hoang937", null, "User", null, 0 },
                    { new Guid("b31a13ae-2e37-4c54-b5c4-029ea7dff501"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76292292@gmail.com", "NamDepTRai292", "Hashed_password_02", null, false, false, "Ho Hoang292", null, "User", null, 0 },
                    { new Guid("b31aeb94-6206-4567-9a30-b7e15a143779"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76382382@gmail.com", "NamDepTRai382", "Hashed_password_02", null, false, false, "Ho Hoang382", null, "User", null, 0 },
                    { new Guid("b38938ec-7b03-4ca2-a99d-573eb62dee76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761212@gmail.com", "NamDepTRai12", "Hashed_password_02", null, false, false, "Ho Hoang12", null, "User", null, 0 },
                    { new Guid("b3d2f6a9-d6da-451f-9392-9bc8d9f91ad2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76344344@gmail.com", "NamDepTRai344", "Hashed_password_02", null, false, false, "Ho Hoang344", null, "User", null, 0 },
                    { new Guid("b3d5e4b1-bf38-44eb-8fa5-dae40e255363"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76287287@gmail.com", "NamDepTRai287", "Hashed_password_02", null, false, false, "Ho Hoang287", null, "User", null, 0 },
                    { new Guid("b451c46f-a5f8-4f36-8c91-6d57c0a23f69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76714714@gmail.com", "NamDepTRai714", "Hashed_password_02", null, false, false, "Ho Hoang714", null, "User", null, 0 },
                    { new Guid("b4526e5c-5dd1-4822-9155-2dab73b6dca0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76976976@gmail.com", "NamDepTRai976", "Hashed_password_02", null, false, false, "Ho Hoang976", null, "User", null, 0 },
                    { new Guid("b49f4e3b-e3a2-43b7-b29d-26d33a1e24c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76885885@gmail.com", "NamDepTRai885", "Hashed_password_02", null, false, false, "Ho Hoang885", null, "User", null, 0 },
                    { new Guid("b4c85b04-9d2b-4a87-8fa6-8c963397359e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768282@gmail.com", "NamDepTRai82", "Hashed_password_02", null, false, false, "Ho Hoang82", null, "User", null, 0 },
                    { new Guid("b5126cb1-389e-4e25-be38-7a62e7e92d62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76564564@gmail.com", "NamDepTRai564", "Hashed_password_02", null, false, false, "Ho Hoang564", null, "User", null, 0 },
                    { new Guid("b52fda4d-6ed5-40d4-833b-6f2a4f2e957d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76613613@gmail.com", "NamDepTRai613", "Hashed_password_02", null, false, false, "Ho Hoang613", null, "User", null, 0 },
                    { new Guid("b53398f3-d92a-4615-839e-78e2f9e823e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76214214@gmail.com", "NamDepTRai214", "Hashed_password_02", null, false, false, "Ho Hoang214", null, "User", null, 0 },
                    { new Guid("b659fdc1-9446-4427-bc55-73c59cfbdc91"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76380380@gmail.com", "NamDepTRai380", "Hashed_password_02", null, false, false, "Ho Hoang380", null, "User", null, 0 },
                    { new Guid("b66d4e56-245e-4d53-a553-4a977d4e4523"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76995995@gmail.com", "NamDepTRai995", "Hashed_password_02", null, false, false, "Ho Hoang995", null, "User", null, 0 },
                    { new Guid("b68b2dd6-80e3-4d8b-b805-3ab92b66c2a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76999999@gmail.com", "NamDepTRai999", "Hashed_password_02", null, false, false, "Ho Hoang999", null, "User", null, 0 },
                    { new Guid("b6acb24a-8bc4-47ca-8b1d-ae0a5e9207e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76102102@gmail.com", "NamDepTRai102", "Hashed_password_02", null, false, false, "Ho Hoang102", null, "User", null, 0 },
                    { new Guid("b6cb4c83-84aa-4fd2-9da7-a55822c0164d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76435435@gmail.com", "NamDepTRai435", "Hashed_password_02", null, false, false, "Ho Hoang435", null, "User", null, 0 },
                    { new Guid("b6dcceb4-0f80-478c-81ca-dc27c89af214"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764646@gmail.com", "NamDepTRai46", "Hashed_password_02", null, false, false, "Ho Hoang46", null, "User", null, 0 },
                    { new Guid("b6dd4c2d-6a06-48ab-a9d7-67d6bb03f8f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76987987@gmail.com", "NamDepTRai987", "Hashed_password_02", null, false, false, "Ho Hoang987", null, "User", null, 0 },
                    { new Guid("b733c060-3a04-4250-af6c-7211042f67f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76211211@gmail.com", "NamDepTRai211", "Hashed_password_02", null, false, false, "Ho Hoang211", null, "User", null, 0 },
                    { new Guid("b793990a-fc72-4b16-9b7a-32c5789b3352"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76221221@gmail.com", "NamDepTRai221", "Hashed_password_02", null, false, false, "Ho Hoang221", null, "User", null, 0 },
                    { new Guid("b7be8171-0bf4-4c93-b36a-43bc7f7ddaa0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76571571@gmail.com", "NamDepTRai571", "Hashed_password_02", null, false, false, "Ho Hoang571", null, "User", null, 0 },
                    { new Guid("b7c54827-ff0e-458e-a3c8-d8200f386e00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76223223@gmail.com", "NamDepTRai223", "Hashed_password_02", null, false, false, "Ho Hoang223", null, "User", null, 0 },
                    { new Guid("b7ddb198-211c-4a30-8308-321be70b3fa3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76228228@gmail.com", "NamDepTRai228", "Hashed_password_02", null, false, false, "Ho Hoang228", null, "User", null, 0 },
                    { new Guid("b8056320-95f9-4ec4-b08b-6d5118fb4aee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76709709@gmail.com", "NamDepTRai709", "Hashed_password_02", null, false, false, "Ho Hoang709", null, "User", null, 0 },
                    { new Guid("b8306d43-0097-4156-9002-77be3af06f84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76743743@gmail.com", "NamDepTRai743", "Hashed_password_02", null, false, false, "Ho Hoang743", null, "User", null, 0 },
                    { new Guid("b89cf326-15b9-4d4e-931c-27fe030bde45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76416416@gmail.com", "NamDepTRai416", "Hashed_password_02", null, false, false, "Ho Hoang416", null, "User", null, 0 },
                    { new Guid("b8aaab8c-2f4b-4d27-9b11-e1ea2da2b0a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76872872@gmail.com", "NamDepTRai872", "Hashed_password_02", null, false, false, "Ho Hoang872", null, "User", null, 0 },
                    { new Guid("b8ad3076-df44-4ab6-a094-d3f9a207b7c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76229229@gmail.com", "NamDepTRai229", "Hashed_password_02", null, false, false, "Ho Hoang229", null, "User", null, 0 },
                    { new Guid("b8b079c4-77a8-4a90-8407-ccae57e5301a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76767767@gmail.com", "NamDepTRai767", "Hashed_password_02", null, false, false, "Ho Hoang767", null, "User", null, 0 },
                    { new Guid("b8b258ea-a8cf-4197-9e16-680197c6fd73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76322322@gmail.com", "NamDepTRai322", "Hashed_password_02", null, false, false, "Ho Hoang322", null, "User", null, 0 },
                    { new Guid("b8e172d1-3109-4587-a633-77171a78446c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76975975@gmail.com", "NamDepTRai975", "Hashed_password_02", null, false, false, "Ho Hoang975", null, "User", null, 0 },
                    { new Guid("b8ffc8ae-3022-42d3-916f-69a4ed407d55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76163163@gmail.com", "NamDepTRai163", "Hashed_password_02", null, false, false, "Ho Hoang163", null, "User", null, 0 },
                    { new Guid("b9124336-eb89-4f26-a524-000b58baecdd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76170170@gmail.com", "NamDepTRai170", "Hashed_password_02", null, false, false, "Ho Hoang170", null, "User", null, 0 },
                    { new Guid("b9682bf4-2a03-4cad-892c-090465810316"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76294294@gmail.com", "NamDepTRai294", "Hashed_password_02", null, false, false, "Ho Hoang294", null, "User", null, 0 },
                    { new Guid("b9b416dc-f440-4152-8b79-c65b495989d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76731731@gmail.com", "NamDepTRai731", "Hashed_password_02", null, false, false, "Ho Hoang731", null, "User", null, 0 },
                    { new Guid("b9ef88bf-ec90-40d3-8878-2d76d2c7d4bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76406406@gmail.com", "NamDepTRai406", "Hashed_password_02", null, false, false, "Ho Hoang406", null, "User", null, 0 },
                    { new Guid("ba5b92c2-cac4-4d04-bcea-c035ce50f4f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76701701@gmail.com", "NamDepTRai701", "Hashed_password_02", null, false, false, "Ho Hoang701", null, "User", null, 0 },
                    { new Guid("bae9b775-0889-44e5-961d-70dce2f75d0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762424@gmail.com", "NamDepTRai24", "Hashed_password_02", null, false, false, "Ho Hoang24", null, "User", null, 0 },
                    { new Guid("bb6a3f03-5923-4a7f-93eb-80a3fe18a181"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76521521@gmail.com", "NamDepTRai521", "Hashed_password_02", null, false, false, "Ho Hoang521", null, "User", null, 0 },
                    { new Guid("bb7742ea-3531-4111-a49c-b20906a6f4cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76661661@gmail.com", "NamDepTRai661", "Hashed_password_02", null, false, false, "Ho Hoang661", null, "User", null, 0 },
                    { new Guid("bbb987d3-edd1-46c0-a67d-86239ef6b127"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76903903@gmail.com", "NamDepTRai903", "Hashed_password_02", null, false, false, "Ho Hoang903", null, "User", null, 0 },
                    { new Guid("bc404a06-427c-4312-be58-efc88a13364f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76712712@gmail.com", "NamDepTRai712", "Hashed_password_02", null, false, false, "Ho Hoang712", null, "User", null, 0 },
                    { new Guid("bc42e1e9-d204-4515-b817-d6b11cbd076c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76198198@gmail.com", "NamDepTRai198", "Hashed_password_02", null, false, false, "Ho Hoang198", null, "User", null, 0 },
                    { new Guid("bcadfe9f-ffae-482f-8c3a-5fcde50ead7b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766262@gmail.com", "NamDepTRai62", "Hashed_password_02", null, false, false, "Ho Hoang62", null, "User", null, 0 },
                    { new Guid("bd6f51d4-3eb7-4c3b-8976-f4a3f4074635"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76296296@gmail.com", "NamDepTRai296", "Hashed_password_02", null, false, false, "Ho Hoang296", null, "User", null, 0 },
                    { new Guid("bd954f59-176f-4982-9286-450e7345bcaf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76802802@gmail.com", "NamDepTRai802", "Hashed_password_02", null, false, false, "Ho Hoang802", null, "User", null, 0 },
                    { new Guid("bdc8a346-76a8-4b65-b474-3ac76f6f0de7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76878878@gmail.com", "NamDepTRai878", "Hashed_password_02", null, false, false, "Ho Hoang878", null, "User", null, 0 },
                    { new Guid("be0b58bc-78db-4d93-9786-3b3f8f7dd598"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76386386@gmail.com", "NamDepTRai386", "Hashed_password_02", null, false, false, "Ho Hoang386", null, "User", null, 0 },
                    { new Guid("be267274-179c-4504-8298-f1c7e0de8ba5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76800800@gmail.com", "NamDepTRai800", "Hashed_password_02", null, false, false, "Ho Hoang800", null, "User", null, 0 },
                    { new Guid("be5175c5-0e31-4878-a63d-61f1332efb87"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76764764@gmail.com", "NamDepTRai764", "Hashed_password_02", null, false, false, "Ho Hoang764", null, "User", null, 0 },
                    { new Guid("be70dbf2-6ac0-4843-934e-1dc0804a4698"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76311311@gmail.com", "NamDepTRai311", "Hashed_password_02", null, false, false, "Ho Hoang311", null, "User", null, 0 },
                    { new Guid("bebb0e58-b43c-41f6-9422-d03b0f82915b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76130130@gmail.com", "NamDepTRai130", "Hashed_password_02", null, false, false, "Ho Hoang130", null, "User", null, 0 },
                    { new Guid("beccbab0-5c1a-4aef-a887-98b4756d899d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76403403@gmail.com", "NamDepTRai403", "Hashed_password_02", null, false, false, "Ho Hoang403", null, "User", null, 0 },
                    { new Guid("beef5187-4abf-45fd-abaa-8f71c31f1969"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76783783@gmail.com", "NamDepTRai783", "Hashed_password_02", null, false, false, "Ho Hoang783", null, "User", null, 0 },
                    { new Guid("bef9cfdf-03ee-44a7-ae2a-23ffdbc46faa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76503503@gmail.com", "NamDepTRai503", "Hashed_password_02", null, false, false, "Ho Hoang503", null, "User", null, 0 },
                    { new Guid("bf2cb8df-70c2-4862-ad07-336f9419625b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76448448@gmail.com", "NamDepTRai448", "Hashed_password_02", null, false, false, "Ho Hoang448", null, "User", null, 0 },
                    { new Guid("bf94dced-c141-4334-b2aa-f13a7a6ad3dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76234234@gmail.com", "NamDepTRai234", "Hashed_password_02", null, false, false, "Ho Hoang234", null, "User", null, 0 },
                    { new Guid("bfaf5486-a048-4629-bc38-0d516e08f741"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76858858@gmail.com", "NamDepTRai858", "Hashed_password_02", null, false, false, "Ho Hoang858", null, "User", null, 0 },
                    { new Guid("bfbe5bea-9672-4254-911d-66d3d5ad158a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7655@gmail.com", "NamDepTRai5", "Hashed_password_02", null, false, false, "Ho Hoang5", null, "User", null, 0 },
                    { new Guid("bfccb6b7-58b1-4a65-9617-1c300481593c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76306306@gmail.com", "NamDepTRai306", "Hashed_password_02", null, false, false, "Ho Hoang306", null, "User", null, 0 },
                    { new Guid("bfcf09ac-2b80-4ccd-91ee-3d5a1c1128fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76418418@gmail.com", "NamDepTRai418", "Hashed_password_02", null, false, false, "Ho Hoang418", null, "User", null, 0 },
                    { new Guid("bffa991f-5a3b-4173-acdc-c1c9be79963f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76738738@gmail.com", "NamDepTRai738", "Hashed_password_02", null, false, false, "Ho Hoang738", null, "User", null, 0 },
                    { new Guid("c053fe28-b291-425e-a0f6-bc4433e252b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768181@gmail.com", "NamDepTRai81", "Hashed_password_02", null, false, false, "Ho Hoang81", null, "User", null, 0 },
                    { new Guid("c0628ee1-8b7a-45a5-a77d-259deb17a33e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76998998@gmail.com", "NamDepTRai998", "Hashed_password_02", null, false, false, "Ho Hoang998", null, "User", null, 0 },
                    { new Guid("c08307ac-61a6-4fb6-9516-d128573ebcbb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76897897@gmail.com", "NamDepTRai897", "Hashed_password_02", null, false, false, "Ho Hoang897", null, "User", null, 0 },
                    { new Guid("c0ad53c2-8326-4027-9d96-da0613e382fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76675675@gmail.com", "NamDepTRai675", "Hashed_password_02", null, false, false, "Ho Hoang675", null, "User", null, 0 },
                    { new Guid("c0e97177-83f3-40bd-beff-6427cb2cdc6b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76461461@gmail.com", "NamDepTRai461", "Hashed_password_02", null, false, false, "Ho Hoang461", null, "User", null, 0 },
                    { new Guid("c1231f5f-d3dc-459f-b799-e1dfc708b56c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76759759@gmail.com", "NamDepTRai759", "Hashed_password_02", null, false, false, "Ho Hoang759", null, "User", null, 0 },
                    { new Guid("c15ff4dd-7097-4b9e-a012-470208828717"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76942942@gmail.com", "NamDepTRai942", "Hashed_password_02", null, false, false, "Ho Hoang942", null, "User", null, 0 },
                    { new Guid("c1c09c1d-ca8f-45ce-9468-139add40c669"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768888@gmail.com", "NamDepTRai88", "Hashed_password_02", null, false, false, "Ho Hoang88", null, "User", null, 0 },
                    { new Guid("c1edd586-566e-4ca0-a2bf-1d207fdeab82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76997997@gmail.com", "NamDepTRai997", "Hashed_password_02", null, false, false, "Ho Hoang997", null, "User", null, 0 },
                    { new Guid("c20b7af6-ca21-47ae-91c3-2fdb485dbb67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76953953@gmail.com", "NamDepTRai953", "Hashed_password_02", null, false, false, "Ho Hoang953", null, "User", null, 0 },
                    { new Guid("c24fb198-9dad-4a07-9b8d-127f93e8dd72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767777@gmail.com", "NamDepTRai77", "Hashed_password_02", null, false, false, "Ho Hoang77", null, "User", null, 0 },
                    { new Guid("c297e2a9-5b3a-446c-9230-828aa0155090"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76428428@gmail.com", "NamDepTRai428", "Hashed_password_02", null, false, false, "Ho Hoang428", null, "User", null, 0 },
                    { new Guid("c2f335cc-02dd-4049-a1fd-9d49857add61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76103103@gmail.com", "NamDepTRai103", "Hashed_password_02", null, false, false, "Ho Hoang103", null, "User", null, 0 },
                    { new Guid("c344d8ff-3dc4-4985-a178-6dd68a779f6c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76797797@gmail.com", "NamDepTRai797", "Hashed_password_02", null, false, false, "Ho Hoang797", null, "User", null, 0 },
                    { new Guid("c3a0f736-5b0b-4314-84de-6babbe19f5da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76169169@gmail.com", "NamDepTRai169", "Hashed_password_02", null, false, false, "Ho Hoang169", null, "User", null, 0 },
                    { new Guid("c3c212d7-63d3-4bd4-bb8e-bffd10273b16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76108108@gmail.com", "NamDepTRai108", "Hashed_password_02", null, false, false, "Ho Hoang108", null, "User", null, 0 },
                    { new Guid("c3e338aa-7464-4e7d-ab3d-5a17c50a1253"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76540540@gmail.com", "NamDepTRai540", "Hashed_password_02", null, false, false, "Ho Hoang540", null, "User", null, 0 },
                    { new Guid("c411e050-c98d-41c5-bdeb-b2b21bcbd846"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76363363@gmail.com", "NamDepTRai363", "Hashed_password_02", null, false, false, "Ho Hoang363", null, "User", null, 0 },
                    { new Guid("c4908421-2580-4272-9bdc-71b7be07f6a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76574574@gmail.com", "NamDepTRai574", "Hashed_password_02", null, false, false, "Ho Hoang574", null, "User", null, 0 },
                    { new Guid("c4a42f1c-a17b-4710-96bd-71ee9e0e8d33"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76412412@gmail.com", "NamDepTRai412", "Hashed_password_02", null, false, false, "Ho Hoang412", null, "User", null, 0 },
                    { new Guid("c5715b73-8b0a-43d1-b696-b840601bf843"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76542542@gmail.com", "NamDepTRai542", "Hashed_password_02", null, false, false, "Ho Hoang542", null, "User", null, 0 },
                    { new Guid("c58a8c86-b2a7-496d-b88e-f20483111135"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76775775@gmail.com", "NamDepTRai775", "Hashed_password_02", null, false, false, "Ho Hoang775", null, "User", null, 0 },
                    { new Guid("c63608de-f643-4f2a-be28-4a57bb37f17d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76584584@gmail.com", "NamDepTRai584", "Hashed_password_02", null, false, false, "Ho Hoang584", null, "User", null, 0 },
                    { new Guid("c653cfb9-e4fb-4c0e-ad12-c266aacffcaa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76356356@gmail.com", "NamDepTRai356", "Hashed_password_02", null, false, false, "Ho Hoang356", null, "User", null, 0 },
                    { new Guid("c68dd176-03b2-4cda-82c6-e15c2ea145b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76391391@gmail.com", "NamDepTRai391", "Hashed_password_02", null, false, false, "Ho Hoang391", null, "User", null, 0 },
                    { new Guid("c7060e69-0cb3-484f-901e-53feb72b0f8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76578578@gmail.com", "NamDepTRai578", "Hashed_password_02", null, false, false, "Ho Hoang578", null, "User", null, 0 },
                    { new Guid("c875c902-e8b2-4742-a1e2-0733edb4421c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76648648@gmail.com", "NamDepTRai648", "Hashed_password_02", null, false, false, "Ho Hoang648", null, "User", null, 0 },
                    { new Guid("c8c35052-097b-4c4d-8947-752e2e8674c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76414414@gmail.com", "NamDepTRai414", "Hashed_password_02", null, false, false, "Ho Hoang414", null, "User", null, 0 },
                    { new Guid("c8d60efa-502a-4817-868b-893644f4c816"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76251251@gmail.com", "NamDepTRai251", "Hashed_password_02", null, false, false, "Ho Hoang251", null, "User", null, 0 },
                    { new Guid("c92bc90d-2969-4a9f-b39e-fb5f55f9ed21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76332332@gmail.com", "NamDepTRai332", "Hashed_password_02", null, false, false, "Ho Hoang332", null, "User", null, 0 },
                    { new Guid("c97d427a-8870-43e3-ac98-d79ab98b7456"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76269269@gmail.com", "NamDepTRai269", "Hashed_password_02", null, false, false, "Ho Hoang269", null, "User", null, 0 },
                    { new Guid("caa2f01e-c811-489b-ac54-2e37590a20c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76472472@gmail.com", "NamDepTRai472", "Hashed_password_02", null, false, false, "Ho Hoang472", null, "User", null, 0 },
                    { new Guid("cb08e3c3-0f96-45e6-b0c7-93b1b5ebef62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76898898@gmail.com", "NamDepTRai898", "Hashed_password_02", null, false, false, "Ho Hoang898", null, "User", null, 0 },
                    { new Guid("cb167bd8-faa3-4681-95c0-9582a709c5dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76440440@gmail.com", "NamDepTRai440", "Hashed_password_02", null, false, false, "Ho Hoang440", null, "User", null, 0 },
                    { new Guid("cb4b527e-48c0-4a46-8c07-eca2c2902934"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76324324@gmail.com", "NamDepTRai324", "Hashed_password_02", null, false, false, "Ho Hoang324", null, "User", null, 0 },
                    { new Guid("cb5109fb-3f4c-4505-af04-75c2a930f13a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76154154@gmail.com", "NamDepTRai154", "Hashed_password_02", null, false, false, "Ho Hoang154", null, "User", null, 0 },
                    { new Guid("cb7ce6e0-acea-4c51-a61f-1621e6b77599"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76599599@gmail.com", "NamDepTRai599", "Hashed_password_02", null, false, false, "Ho Hoang599", null, "User", null, 0 },
                    { new Guid("cb86d680-557a-4070-95dc-e3be3c478b9c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76680680@gmail.com", "NamDepTRai680", "Hashed_password_02", null, false, false, "Ho Hoang680", null, "User", null, 0 },
                    { new Guid("cbdedee2-6bc5-4fc7-b9a0-7cffd73bac9e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763636@gmail.com", "NamDepTRai36", "Hashed_password_02", null, false, false, "Ho Hoang36", null, "User", null, 0 },
                    { new Guid("cc9e1f00-59fa-4d2f-82d4-23c9ab331dbe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76136136@gmail.com", "NamDepTRai136", "Hashed_password_02", null, false, false, "Ho Hoang136", null, "User", null, 0 },
                    { new Guid("ccbe5f78-9d1b-4da0-960f-21e74de2ce11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76122122@gmail.com", "NamDepTRai122", "Hashed_password_02", null, false, false, "Ho Hoang122", null, "User", null, 0 },
                    { new Guid("cd1d9435-a5b6-4491-8dd0-d977c8d25856"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76883883@gmail.com", "NamDepTRai883", "Hashed_password_02", null, false, false, "Ho Hoang883", null, "User", null, 0 },
                    { new Guid("cd5d9998-151a-408c-a1eb-e01e21476a61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76952952@gmail.com", "NamDepTRai952", "Hashed_password_02", null, false, false, "Ho Hoang952", null, "User", null, 0 },
                    { new Guid("cdf11bec-8a2e-4923-b463-d7e42537c5cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764747@gmail.com", "NamDepTRai47", "Hashed_password_02", null, false, false, "Ho Hoang47", null, "User", null, 0 },
                    { new Guid("cea522c5-f3c5-4c61-b2aa-dfa7cb3a7af0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76722722@gmail.com", "NamDepTRai722", "Hashed_password_02", null, false, false, "Ho Hoang722", null, "User", null, 0 },
                    { new Guid("cef2b26e-df42-4978-a441-40b1748b7967"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76865865@gmail.com", "NamDepTRai865", "Hashed_password_02", null, false, false, "Ho Hoang865", null, "User", null, 0 },
                    { new Guid("cf40a95b-fccd-4a24-a4c5-310d7fe15d08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76938938@gmail.com", "NamDepTRai938", "Hashed_password_02", null, false, false, "Ho Hoang938", null, "User", null, 0 },
                    { new Guid("cfc7033e-db10-4543-83a4-c3f361fa867d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76432432@gmail.com", "NamDepTRai432", "Hashed_password_02", null, false, false, "Ho Hoang432", null, "User", null, 0 },
                    { new Guid("d01047c2-f61d-4558-835e-19c4fd7e2359"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76106106@gmail.com", "NamDepTRai106", "Hashed_password_02", null, false, false, "Ho Hoang106", null, "User", null, 0 },
                    { new Guid("d026b468-a285-480a-ba4f-ba6991e20dc8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76813813@gmail.com", "NamDepTRai813", "Hashed_password_02", null, false, false, "Ho Hoang813", null, "User", null, 0 },
                    { new Guid("d04c8335-9bb4-4b96-851d-e3725d3f9458"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76839839@gmail.com", "NamDepTRai839", "Hashed_password_02", null, false, false, "Ho Hoang839", null, "User", null, 0 },
                    { new Guid("d04c9266-83f6-474b-ae65-da193f70ed72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76689689@gmail.com", "NamDepTRai689", "Hashed_password_02", null, false, false, "Ho Hoang689", null, "User", null, 0 },
                    { new Guid("d08180c5-344e-4384-b80f-87a93e0525d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76965965@gmail.com", "NamDepTRai965", "Hashed_password_02", null, false, false, "Ho Hoang965", null, "User", null, 0 },
                    { new Guid("d0d60496-6b50-4eb5-a38e-4a6805b8ef5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766060@gmail.com", "NamDepTRai60", "Hashed_password_02", null, false, false, "Ho Hoang60", null, "User", null, 0 },
                    { new Guid("d0d95365-33dd-4ebc-9fc7-76972326f917"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76482482@gmail.com", "NamDepTRai482", "Hashed_password_02", null, false, false, "Ho Hoang482", null, "User", null, 0 },
                    { new Guid("d0ebd580-0146-412d-ba86-5e18996ea734"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76225225@gmail.com", "NamDepTRai225", "Hashed_password_02", null, false, false, "Ho Hoang225", null, "User", null, 0 },
                    { new Guid("d113ac20-a352-41f4-8f5a-311d62dbc959"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76964964@gmail.com", "NamDepTRai964", "Hashed_password_02", null, false, false, "Ho Hoang964", null, "User", null, 0 },
                    { new Guid("d1690e3e-ab6f-49ee-ad5c-9f8fdefea063"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox746@gmail.com", "Nam", "Hashed_password_01", null, false, false, "Ho Hoang", null, "User", null, 0 },
                    { new Guid("d18f111d-56a0-4812-ac14-5c38c27d5f05"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76379379@gmail.com", "NamDepTRai379", "Hashed_password_02", null, false, false, "Ho Hoang379", null, "User", null, 0 },
                    { new Guid("d1a9ae20-583b-4f22-95af-66641fa01f4f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76152152@gmail.com", "NamDepTRai152", "Hashed_password_02", null, false, false, "Ho Hoang152", null, "User", null, 0 },
                    { new Guid("d1aa49c5-5404-491d-a368-870d8da85749"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768383@gmail.com", "NamDepTRai83", "Hashed_password_02", null, false, false, "Ho Hoang83", null, "User", null, 0 },
                    { new Guid("d1d6b21d-2e42-4241-8968-27bb00525828"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76360360@gmail.com", "NamDepTRai360", "Hashed_password_02", null, false, false, "Ho Hoang360", null, "User", null, 0 },
                    { new Guid("d25b8947-bef6-4ce8-9aab-3f007cc2b0d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76617617@gmail.com", "NamDepTRai617", "Hashed_password_02", null, false, false, "Ho Hoang617", null, "User", null, 0 },
                    { new Guid("d2c17469-d964-4c03-8742-4516c6c14061"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76522522@gmail.com", "NamDepTRai522", "Hashed_password_02", null, false, false, "Ho Hoang522", null, "User", null, 0 },
                    { new Guid("d32d8f19-819d-4fff-a650-963dbef0b33a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762727@gmail.com", "NamDepTRai27", "Hashed_password_02", null, false, false, "Ho Hoang27", null, "User", null, 0 },
                    { new Guid("d36d6209-8faa-421b-99d7-ccfe3708e581"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76905905@gmail.com", "NamDepTRai905", "Hashed_password_02", null, false, false, "Ho Hoang905", null, "User", null, 0 },
                    { new Guid("d391efa5-a27c-435e-8edf-9a77b60135fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76137137@gmail.com", "NamDepTRai137", "Hashed_password_02", null, false, false, "Ho Hoang137", null, "User", null, 0 },
                    { new Guid("d39abddc-cc34-4526-a911-af15a8ee18e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76635635@gmail.com", "NamDepTRai635", "Hashed_password_02", null, false, false, "Ho Hoang635", null, "User", null, 0 },
                    { new Guid("d3a4ece0-7e61-4ee8-972f-a356c7f6ca98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76458458@gmail.com", "NamDepTRai458", "Hashed_password_02", null, false, false, "Ho Hoang458", null, "User", null, 0 },
                    { new Guid("d3fbe4d4-69f6-45d9-a43a-434c08815c52"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76597597@gmail.com", "NamDepTRai597", "Hashed_password_02", null, false, false, "Ho Hoang597", null, "User", null, 0 },
                    { new Guid("d4ef6318-99be-43a6-931f-03e8f019b5fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76215215@gmail.com", "NamDepTRai215", "Hashed_password_02", null, false, false, "Ho Hoang215", null, "User", null, 0 },
                    { new Guid("d50e00e0-73e9-43c7-9143-8b49bafaa21a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76107107@gmail.com", "NamDepTRai107", "Hashed_password_02", null, false, false, "Ho Hoang107", null, "User", null, 0 },
                    { new Guid("d541e834-3bd5-4b4e-81af-76c92706edda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76305305@gmail.com", "NamDepTRai305", "Hashed_password_02", null, false, false, "Ho Hoang305", null, "User", null, 0 },
                    { new Guid("d54cab3f-6363-4c56-9bbc-022d251d0128"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76864864@gmail.com", "NamDepTRai864", "Hashed_password_02", null, false, false, "Ho Hoang864", null, "User", null, 0 },
                    { new Guid("d59bbb93-6d6b-4f75-833b-d902e38dfac2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76256256@gmail.com", "NamDepTRai256", "Hashed_password_02", null, false, false, "Ho Hoang256", null, "User", null, 0 },
                    { new Guid("d5df477b-359e-4f61-b47f-3e7c424ed9e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76507507@gmail.com", "NamDepTRai507", "Hashed_password_02", null, false, false, "Ho Hoang507", null, "User", null, 0 },
                    { new Guid("d5fabf3e-e233-4320-adfa-96623393af5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76545545@gmail.com", "NamDepTRai545", "Hashed_password_02", null, false, false, "Ho Hoang545", null, "User", null, 0 },
                    { new Guid("d60b8f33-193e-4027-bf7b-75efec623832"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76439439@gmail.com", "NamDepTRai439", "Hashed_password_02", null, false, false, "Ho Hoang439", null, "User", null, 0 },
                    { new Guid("d6a7a97b-fbae-4668-ad41-3a83dc2cc7d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76735735@gmail.com", "NamDepTRai735", "Hashed_password_02", null, false, false, "Ho Hoang735", null, "User", null, 0 },
                    { new Guid("d732570e-f1f5-4b82-84ff-880cf42edd34"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76819819@gmail.com", "NamDepTRai819", "Hashed_password_02", null, false, false, "Ho Hoang819", null, "User", null, 0 },
                    { new Guid("d805700e-f62d-4984-b874-123c03a95ce6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76272272@gmail.com", "NamDepTRai272", "Hashed_password_02", null, false, false, "Ho Hoang272", null, "User", null, 0 },
                    { new Guid("d84f1606-483e-4699-9d0c-b8fa961fd450"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox762929@gmail.com", "NamDepTRai29", "Hashed_password_02", null, false, false, "Ho Hoang29", null, "User", null, 0 },
                    { new Guid("d8681403-c121-4fe6-a42b-4435a195244e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76989989@gmail.com", "NamDepTRai989", "Hashed_password_02", null, false, false, "Ho Hoang989", null, "User", null, 0 },
                    { new Guid("d89348d0-61ec-47a8-afd2-ceaefbd7b670"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76313313@gmail.com", "NamDepTRai313", "Hashed_password_02", null, false, false, "Ho Hoang313", null, "User", null, 0 },
                    { new Guid("d8a6722e-f077-4491-89de-cdb2f54628ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76176176@gmail.com", "NamDepTRai176", "Hashed_password_02", null, false, false, "Ho Hoang176", null, "User", null, 0 },
                    { new Guid("d949f1f3-e862-4f8d-a7b8-09981eebcb83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765858@gmail.com", "NamDepTRai58", "Hashed_password_02", null, false, false, "Ho Hoang58", null, "User", null, 0 },
                    { new Guid("d99f214a-8eec-4d76-9d55-9202723b5a8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7666@gmail.com", "NamDepTRai6", "Hashed_password_02", null, false, false, "Ho Hoang6", null, "User", null, 0 },
                    { new Guid("d9aa1a9b-b69a-4663-8418-714bedf39eda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76592592@gmail.com", "NamDepTRai592", "Hashed_password_02", null, false, false, "Ho Hoang592", null, "User", null, 0 },
                    { new Guid("d9f19631-d33a-47d8-ad6d-7c1fbc60f0c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761818@gmail.com", "NamDepTRai18", "Hashed_password_02", null, false, false, "Ho Hoang18", null, "User", null, 0 },
                    { new Guid("d9f8e65b-3d65-4635-a46f-4a43157a7c79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76546546@gmail.com", "NamDepTRai546", "Hashed_password_02", null, false, false, "Ho Hoang546", null, "User", null, 0 },
                    { new Guid("da391ba0-619c-4f60-8e3c-698b75067c97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76150150@gmail.com", "NamDepTRai150", "Hashed_password_02", null, false, false, "Ho Hoang150", null, "User", null, 0 },
                    { new Guid("da50d3d2-6343-4db0-88e3-c99cdb25ce96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76693693@gmail.com", "NamDepTRai693", "Hashed_password_02", null, false, false, "Ho Hoang693", null, "User", null, 0 },
                    { new Guid("da901e42-dde0-4d6a-8e82-88d0ec6255ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76105105@gmail.com", "NamDepTRai105", "Hashed_password_02", null, false, false, "Ho Hoang105", null, "User", null, 0 },
                    { new Guid("dac10e1c-8642-410a-881d-01de83852663"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76740740@gmail.com", "NamDepTRai740", "Hashed_password_02", null, false, false, "Ho Hoang740", null, "User", null, 0 },
                    { new Guid("dbc0f351-9a32-4c7c-9431-874ca4bdb137"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76644644@gmail.com", "NamDepTRai644", "Hashed_password_02", null, false, false, "Ho Hoang644", null, "User", null, 0 },
                    { new Guid("dbda5362-baf7-4575-b8a9-a3dafa113628"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76245245@gmail.com", "NamDepTRai245", "Hashed_password_02", null, false, false, "Ho Hoang245", null, "User", null, 0 },
                    { new Guid("dc2ee11c-c979-4da1-8fb9-2f70104a6f6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76700700@gmail.com", "NamDepTRai700", "Hashed_password_02", null, false, false, "Ho Hoang700", null, "User", null, 0 },
                    { new Guid("dc4b2cf2-b27f-4048-80dc-0190c8d0ca92"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766464@gmail.com", "NamDepTRai64", "Hashed_password_02", null, false, false, "Ho Hoang64", null, "User", null, 0 },
                    { new Guid("dc899e39-9a9c-400b-b102-13b3073ef8af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76748748@gmail.com", "NamDepTRai748", "Hashed_password_02", null, false, false, "Ho Hoang748", null, "User", null, 0 },
                    { new Guid("dcb5c9e4-09f6-428f-82cb-f4a55b99fbbe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76365365@gmail.com", "NamDepTRai365", "Hashed_password_02", null, false, false, "Ho Hoang365", null, "User", null, 0 },
                    { new Guid("ddc6b3ec-087c-47d0-8df2-3df28ccdd30d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76259259@gmail.com", "NamDepTRai259", "Hashed_password_02", null, false, false, "Ho Hoang259", null, "User", null, 0 },
                    { new Guid("ddd97fcf-ea1b-410f-94a5-b0ededd940cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76216216@gmail.com", "NamDepTRai216", "Hashed_password_02", null, false, false, "Ho Hoang216", null, "User", null, 0 },
                    { new Guid("ddf9bbdb-f4a9-4d7b-a996-169949b5e2fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76811811@gmail.com", "NamDepTRai811", "Hashed_password_02", null, false, false, "Ho Hoang811", null, "User", null, 0 },
                    { new Guid("de1e8ca2-af1e-4084-8e1e-631f5fe84643"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763939@gmail.com", "NamDepTRai39", "Hashed_password_02", null, false, false, "Ho Hoang39", null, "User", null, 0 },
                    { new Guid("debf9919-953b-4cd6-a81a-4c1f7a6a3b0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76431431@gmail.com", "NamDepTRai431", "Hashed_password_02", null, false, false, "Ho Hoang431", null, "User", null, 0 },
                    { new Guid("dec3f217-802b-4e86-932a-b07edf1dd5e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76704704@gmail.com", "NamDepTRai704", "Hashed_password_02", null, false, false, "Ho Hoang704", null, "User", null, 0 },
                    { new Guid("df3fe441-1b9d-4f75-bf46-7937e91ac497"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76785785@gmail.com", "NamDepTRai785", "Hashed_password_02", null, false, false, "Ho Hoang785", null, "User", null, 0 },
                    { new Guid("df447ee8-9edf-42a4-9369-e50f4fcee59f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76831831@gmail.com", "NamDepTRai831", "Hashed_password_02", null, false, false, "Ho Hoang831", null, "User", null, 0 },
                    { new Guid("df483881-bc64-41b0-ae7a-e89072e993e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768686@gmail.com", "NamDepTRai86", "Hashed_password_02", null, false, false, "Ho Hoang86", null, "User", null, 0 },
                    { new Guid("df581d71-f6f0-4b2a-bfbd-7b6f4ef7c17d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76667667@gmail.com", "NamDepTRai667", "Hashed_password_02", null, false, false, "Ho Hoang667", null, "User", null, 0 },
                    { new Guid("df67e51d-6013-4bfc-89d5-7c508db34ab6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox763838@gmail.com", "NamDepTRai38", "Hashed_password_02", null, false, false, "Ho Hoang38", null, "User", null, 0 },
                    { new Guid("e004d868-ee20-402c-83ff-eb68ed692583"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761919@gmail.com", "NamDepTRai19", "Hashed_password_02", null, false, false, "Ho Hoang19", null, "User", null, 0 },
                    { new Guid("e011adbb-dfba-4d75-bbea-11229805fece"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76524524@gmail.com", "NamDepTRai524", "Hashed_password_02", null, false, false, "Ho Hoang524", null, "User", null, 0 },
                    { new Guid("e01ff2e5-f285-467b-8e30-a1ccdfe00291"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76934934@gmail.com", "NamDepTRai934", "Hashed_password_02", null, false, false, "Ho Hoang934", null, "User", null, 0 },
                    { new Guid("e02d337c-d5cc-4b87-af0c-ff56e12c3259"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76594594@gmail.com", "NamDepTRai594", "Hashed_password_02", null, false, false, "Ho Hoang594", null, "User", null, 0 },
                    { new Guid("e02f04fb-3b7e-4886-a3b8-6958e7f1f565"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76111111@gmail.com", "NamDepTRai111", "Hashed_password_02", null, false, false, "Ho Hoang111", null, "User", null, 0 },
                    { new Guid("e033ea23-f057-4ab2-8658-1c4f4192bf93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76705705@gmail.com", "NamDepTRai705", "Hashed_password_02", null, false, false, "Ho Hoang705", null, "User", null, 0 },
                    { new Guid("e0723fea-6544-42d1-881a-fa77c7a0b26a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761717@gmail.com", "NamDepTRai17", "Hashed_password_02", null, false, false, "Ho Hoang17", null, "User", null, 0 },
                    { new Guid("e10d4e7e-12b7-42f4-a0a3-011bc444e07e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76750750@gmail.com", "NamDepTRai750", "Hashed_password_02", null, false, false, "Ho Hoang750", null, "User", null, 0 },
                    { new Guid("e14d39fe-d981-4118-9a5e-190e1d9517b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76348348@gmail.com", "NamDepTRai348", "Hashed_password_02", null, false, false, "Ho Hoang348", null, "User", null, 0 },
                    { new Guid("e151f64c-ebaa-43fe-8aec-32c7a51fa91f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76544544@gmail.com", "NamDepTRai544", "Hashed_password_02", null, false, false, "Ho Hoang544", null, "User", null, 0 },
                    { new Guid("e162c0cb-48c0-4487-aee1-6ca20dfed97b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76947947@gmail.com", "NamDepTRai947", "Hashed_password_02", null, false, false, "Ho Hoang947", null, "User", null, 0 },
                    { new Guid("e16e1464-17eb-4034-b889-503b4a459e56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76367367@gmail.com", "NamDepTRai367", "Hashed_password_02", null, false, false, "Ho Hoang367", null, "User", null, 0 },
                    { new Guid("e190d23d-3b1f-4d18-ac50-7286de36fc34"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761616@gmail.com", "NamDepTRai16", "Hashed_password_02", null, false, false, "Ho Hoang16", null, "User", null, 0 },
                    { new Guid("e1d6eadf-0877-4921-bda4-140088abda86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768484@gmail.com", "NamDepTRai84", "Hashed_password_02", null, false, false, "Ho Hoang84", null, "User", null, 0 },
                    { new Guid("e24714c0-7af4-4299-be99-78cadf1bbb7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76530530@gmail.com", "NamDepTRai530", "Hashed_password_02", null, false, false, "Ho Hoang530", null, "User", null, 0 },
                    { new Guid("e3021a01-c683-4113-ad3f-6b09c5455729"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76371371@gmail.com", "NamDepTRai371", "Hashed_password_02", null, false, false, "Ho Hoang371", null, "User", null, 0 },
                    { new Guid("e311f3fb-7c55-4dc7-9f0d-ecbf66886d3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76396396@gmail.com", "NamDepTRai396", "Hashed_password_02", null, false, false, "Ho Hoang396", null, "User", null, 0 },
                    { new Guid("e333f250-dd29-4c11-8eb8-1f6256bb16e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76338338@gmail.com", "NamDepTRai338", "Hashed_password_02", null, false, false, "Ho Hoang338", null, "User", null, 0 },
                    { new Guid("e35d09bb-cec7-4c07-adcb-077f641d6d32"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76868868@gmail.com", "NamDepTRai868", "Hashed_password_02", null, false, false, "Ho Hoang868", null, "User", null, 0 },
                    { new Guid("e36a8d59-346b-47eb-9165-3e6c61cec4c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76925925@gmail.com", "NamDepTRai925", "Hashed_password_02", null, false, false, "Ho Hoang925", null, "User", null, 0 },
                    { new Guid("e3bbbb9d-4e99-4126-8ce0-3b934fc5582a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76977977@gmail.com", "NamDepTRai977", "Hashed_password_02", null, false, false, "Ho Hoang977", null, "User", null, 0 },
                    { new Guid("e3c6048f-899f-490a-a904-5447ff24517f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76694694@gmail.com", "NamDepTRai694", "Hashed_password_02", null, false, false, "Ho Hoang694", null, "User", null, 0 },
                    { new Guid("e3dba9ac-4545-4b6e-bed1-652fcd792fc4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76770770@gmail.com", "NamDepTRai770", "Hashed_password_02", null, false, false, "Ho Hoang770", null, "User", null, 0 },
                    { new Guid("e3fdb35b-e749-47da-a88d-154682e04072"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76922922@gmail.com", "NamDepTRai922", "Hashed_password_02", null, false, false, "Ho Hoang922", null, "User", null, 0 },
                    { new Guid("e4405ef5-c33e-48d2-9910-4bf78ba17351"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76932932@gmail.com", "NamDepTRai932", "Hashed_password_02", null, false, false, "Ho Hoang932", null, "User", null, 0 },
                    { new Guid("e493fa68-8aab-428f-ac18-9afa543de719"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76616616@gmail.com", "NamDepTRai616", "Hashed_password_02", null, false, false, "Ho Hoang616", null, "User", null, 0 },
                    { new Guid("e4c12eb0-ae43-42b4-950c-e407fb10a921"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76563563@gmail.com", "NamDepTRai563", "Hashed_password_02", null, false, false, "Ho Hoang563", null, "User", null, 0 },
                    { new Guid("e4c53b2d-0b3f-430e-a9e9-d8b4373f33ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76112112@gmail.com", "NamDepTRai112", "Hashed_password_02", null, false, false, "Ho Hoang112", null, "User", null, 0 },
                    { new Guid("e508f3bb-9443-4382-91d8-5ba47f391f78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76377377@gmail.com", "NamDepTRai377", "Hashed_password_02", null, false, false, "Ho Hoang377", null, "User", null, 0 },
                    { new Guid("e5459910-4448-40c5-81df-66bc2bc64790"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76340340@gmail.com", "NamDepTRai340", "Hashed_password_02", null, false, false, "Ho Hoang340", null, "User", null, 0 },
                    { new Guid("e5b97806-4e9c-446f-a4ce-007925170dc9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76422422@gmail.com", "NamDepTRai422", "Hashed_password_02", null, false, false, "Ho Hoang422", null, "User", null, 0 },
                    { new Guid("e5fe5cfa-1112-45cb-8b56-7b9a0163966d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76537537@gmail.com", "NamDepTRai537", "Hashed_password_02", null, false, false, "Ho Hoang537", null, "User", null, 0 },
                    { new Guid("e61dee4c-dfe8-4a77-96e7-2d9fbfb3fc44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76726726@gmail.com", "NamDepTRai726", "Hashed_password_02", null, false, false, "Ho Hoang726", null, "User", null, 0 },
                    { new Guid("e7e8e87d-b9a4-4726-a3b3-f049f8919225"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76577577@gmail.com", "NamDepTRai577", "Hashed_password_02", null, false, false, "Ho Hoang577", null, "User", null, 0 },
                    { new Guid("e7f80c89-5515-4579-8346-8da068bd4bae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76695695@gmail.com", "NamDepTRai695", "Hashed_password_02", null, false, false, "Ho Hoang695", null, "User", null, 0 },
                    { new Guid("e89f1949-acef-44de-8825-5add1bc1668e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766868@gmail.com", "NamDepTRai68", "Hashed_password_02", null, false, false, "Ho Hoang68", null, "User", null, 0 },
                    { new Guid("e8c358e8-ca3c-4ac4-a9a6-e534b3c11df0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76476476@gmail.com", "NamDepTRai476", "Hashed_password_02", null, false, false, "Ho Hoang476", null, "User", null, 0 },
                    { new Guid("e8d64616-d3c3-45fd-b21e-67bbd5461117"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76290290@gmail.com", "NamDepTRai290", "Hashed_password_02", null, false, false, "Ho Hoang290", null, "User", null, 0 },
                    { new Guid("e8dde7a4-9b95-4904-a6c1-5f3066d42415"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76147147@gmail.com", "NamDepTRai147", "Hashed_password_02", null, false, false, "Ho Hoang147", null, "User", null, 0 },
                    { new Guid("e916c19f-6579-43c9-b000-b95817ed9cf8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76487487@gmail.com", "NamDepTRai487", "Hashed_password_02", null, false, false, "Ho Hoang487", null, "User", null, 0 },
                    { new Guid("e92fd5c8-545e-443f-b783-ab8cee0a6a1c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76179179@gmail.com", "NamDepTRai179", "Hashed_password_02", null, false, false, "Ho Hoang179", null, "User", null, 0 },
                    { new Guid("e97de1be-7384-41ac-9926-468ecdbaca4d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76838838@gmail.com", "NamDepTRai838", "Hashed_password_02", null, false, false, "Ho Hoang838", null, "User", null, 0 },
                    { new Guid("e9a2dc5c-4d96-40cd-b17a-ad6fd4e5dc1f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76820820@gmail.com", "NamDepTRai820", "Hashed_password_02", null, false, false, "Ho Hoang820", null, "User", null, 0 },
                    { new Guid("e9d2140a-b760-4209-9676-5189b01f85c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76915915@gmail.com", "NamDepTRai915", "Hashed_password_02", null, false, false, "Ho Hoang915", null, "User", null, 0 },
                    { new Guid("e9e32adf-e478-48f6-b97d-67e5709aeaab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761010@gmail.com", "NamDepTRai10", "Hashed_password_02", null, false, false, "Ho Hoang10", null, "User", null, 0 },
                    { new Guid("eadb1a1a-22d5-45a8-9268-2042adf4bf06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76956956@gmail.com", "NamDepTRai956", "Hashed_password_02", null, false, false, "Ho Hoang956", null, "User", null, 0 },
                    { new Guid("eae705ae-f011-4af7-850f-2d45d3c498db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76606606@gmail.com", "NamDepTRai606", "Hashed_password_02", null, false, false, "Ho Hoang606", null, "User", null, 0 },
                    { new Guid("eb10b30b-640c-4326-96d1-dfb1e12a7b60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76506506@gmail.com", "NamDepTRai506", "Hashed_password_02", null, false, false, "Ho Hoang506", null, "User", null, 0 },
                    { new Guid("eb404710-a810-4996-87d7-85662c9ca0d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76174174@gmail.com", "NamDepTRai174", "Hashed_password_02", null, false, false, "Ho Hoang174", null, "User", null, 0 },
                    { new Guid("eb83fc6e-8de9-4399-ba9f-d964729d14f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76682682@gmail.com", "NamDepTRai682", "Hashed_password_02", null, false, false, "Ho Hoang682", null, "User", null, 0 },
                    { new Guid("eb9a314e-f2ed-4f0e-874c-e08fb44edc1f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76217217@gmail.com", "NamDepTRai217", "Hashed_password_02", null, false, false, "Ho Hoang217", null, "User", null, 0 },
                    { new Guid("ebf8b58c-dfe1-4704-a912-8a015b3f1b54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76894894@gmail.com", "NamDepTRai894", "Hashed_password_02", null, false, false, "Ho Hoang894", null, "User", null, 0 },
                    { new Guid("ece76f55-9a3d-4639-961e-3a7901a8d364"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76994994@gmail.com", "NamDepTRai994", "Hashed_password_02", null, false, false, "Ho Hoang994", null, "User", null, 0 },
                    { new Guid("ed0a97cb-114d-4e05-bbc4-33ac91e97c21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox768787@gmail.com", "NamDepTRai87", "Hashed_password_02", null, false, false, "Ho Hoang87", null, "User", null, 0 },
                    { new Guid("ed961011-8eef-43ee-a86a-f44759416112"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76710710@gmail.com", "NamDepTRai710", "Hashed_password_02", null, false, false, "Ho Hoang710", null, "User", null, 0 },
                    { new Guid("edb41a3d-023e-46df-b367-9b53f24f55a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76529529@gmail.com", "NamDepTRai529", "Hashed_password_02", null, false, false, "Ho Hoang529", null, "User", null, 0 },
                    { new Guid("ee3bfd9c-fd65-41e8-8b82-c37f3a950aeb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76596596@gmail.com", "NamDepTRai596", "Hashed_password_02", null, false, false, "Ho Hoang596", null, "User", null, 0 },
                    { new Guid("ee596463-837d-4ecd-89ae-8552d5bbd5b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76569569@gmail.com", "NamDepTRai569", "Hashed_password_02", null, false, false, "Ho Hoang569", null, "User", null, 0 },
                    { new Guid("eec97e04-6d58-4079-bb91-796c0526a846"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76445445@gmail.com", "NamDepTRai445", "Hashed_password_02", null, false, false, "Ho Hoang445", null, "User", null, 0 },
                    { new Guid("eedc71c2-c858-4aeb-9821-0c85730c958a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76827827@gmail.com", "NamDepTRai827", "Hashed_password_02", null, false, false, "Ho Hoang827", null, "User", null, 0 },
                    { new Guid("eee365dd-7144-435b-9d12-75d3ea9517b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76164164@gmail.com", "NamDepTRai164", "Hashed_password_02", null, false, false, "Ho Hoang164", null, "User", null, 0 },
                    { new Guid("eeea30c5-fc4c-4cf9-b75e-da6f80d9fcb7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76601601@gmail.com", "NamDepTRai601", "Hashed_password_02", null, false, false, "Ho Hoang601", null, "User", null, 0 },
                    { new Guid("eeefd3a5-b3a1-4ab9-bdc2-b37b750696a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox767070@gmail.com", "NamDepTRai70", "Hashed_password_02", null, false, false, "Ho Hoang70", null, "User", null, 0 },
                    { new Guid("eefbbf8e-92fe-4c8f-a87b-fb281956190f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76135135@gmail.com", "NamDepTRai135", "Hashed_password_02", null, false, false, "Ho Hoang135", null, "User", null, 0 },
                    { new Guid("ef20ac3f-1959-44f3-ad80-04c5665ff92c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76727727@gmail.com", "NamDepTRai727", "Hashed_password_02", null, false, false, "Ho Hoang727", null, "User", null, 0 },
                    { new Guid("efbe432f-7083-4933-8ee2-308e7374977f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76318318@gmail.com", "NamDepTRai318", "Hashed_password_02", null, false, false, "Ho Hoang318", null, "User", null, 0 },
                    { new Guid("efef41d7-81d2-4f0e-825b-4485f010bd97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76283283@gmail.com", "NamDepTRai283", "Hashed_password_02", null, false, false, "Ho Hoang283", null, "User", null, 0 },
                    { new Guid("eff567e5-7bf4-4038-9963-209a55c52062"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox765454@gmail.com", "NamDepTRai54", "Hashed_password_02", null, false, false, "Ho Hoang54", null, "User", null, 0 },
                    { new Guid("f0735d08-bc63-4ecc-b4ed-63dd911285ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76534534@gmail.com", "NamDepTRai534", "Hashed_password_02", null, false, false, "Ho Hoang534", null, "User", null, 0 },
                    { new Guid("f1353baa-f913-401b-83e4-4d252170df81"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox769898@gmail.com", "NamDepTRai98", "Hashed_password_02", null, false, false, "Ho Hoang98", null, "User", null, 0 },
                    { new Guid("f1dac5cc-ab28-44b2-9b1b-e1c2da76af62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76263263@gmail.com", "NamDepTRai263", "Hashed_password_02", null, false, false, "Ho Hoang263", null, "User", null, 0 },
                    { new Guid("f1ef5781-6532-4fe3-9ecc-642f561c68f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76490490@gmail.com", "NamDepTRai490", "Hashed_password_02", null, false, false, "Ho Hoang490", null, "User", null, 0 },
                    { new Guid("f28f229f-9375-415f-985c-876f6463f5f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76787787@gmail.com", "NamDepTRai787", "Hashed_password_02", null, false, false, "Ho Hoang787", null, "User", null, 0 },
                    { new Guid("f2a11460-e7ed-41dd-89b3-146da46c044f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76691691@gmail.com", "NamDepTRai691", "Hashed_password_02", null, false, false, "Ho Hoang691", null, "User", null, 0 },
                    { new Guid("f2a8b769-25e6-4298-914c-25b7fad5cd41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76395395@gmail.com", "NamDepTRai395", "Hashed_password_02", null, false, false, "Ho Hoang395", null, "User", null, 0 },
                    { new Guid("f2c32bf5-4a16-4f26-b69c-a05cf9804ffc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76911911@gmail.com", "NamDepTRai911", "Hashed_password_02", null, false, false, "Ho Hoang911", null, "User", null, 0 },
                    { new Guid("f2c801e6-c06f-41a5-8892-1bc2ff27ecc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76763763@gmail.com", "NamDepTRai763", "Hashed_password_02", null, false, false, "Ho Hoang763", null, "User", null, 0 },
                    { new Guid("f2ea9d21-f870-4991-97ea-1a49286ff80a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76641641@gmail.com", "NamDepTRai641", "Hashed_password_02", null, false, false, "Ho Hoang641", null, "User", null, 0 },
                    { new Guid("f2f76948-17fd-4f62-91cd-b5cf07c66230"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76350350@gmail.com", "NamDepTRai350", "Hashed_password_02", null, false, false, "Ho Hoang350", null, "User", null, 0 },
                    { new Guid("f305b893-ecda-4485-b66b-ba051f8f6d34"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76884884@gmail.com", "NamDepTRai884", "Hashed_password_02", null, false, false, "Ho Hoang884", null, "User", null, 0 },
                    { new Guid("f30bde65-7bcd-4b89-a2bc-e620b9b231d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76821821@gmail.com", "NamDepTRai821", "Hashed_password_02", null, false, false, "Ho Hoang821", null, "User", null, 0 },
                    { new Guid("f3c8037c-916b-49b5-ad21-64c2327e61e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76721721@gmail.com", "NamDepTRai721", "Hashed_password_02", null, false, false, "Ho Hoang721", null, "User", null, 0 },
                    { new Guid("f4096988-206a-4e37-b6cd-e39beb2bfeae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76168168@gmail.com", "NamDepTRai168", "Hashed_password_02", null, false, false, "Ho Hoang168", null, "User", null, 0 },
                    { new Guid("f46cff69-44fe-4811-84fa-739509fa09a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76688688@gmail.com", "NamDepTRai688", "Hashed_password_02", null, false, false, "Ho Hoang688", null, "User", null, 0 },
                    { new Guid("f494d139-5a7d-4aae-af84-d42193b5e7ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766565@gmail.com", "NamDepTRai65", "Hashed_password_02", null, false, false, "Ho Hoang65", null, "User", null, 0 },
                    { new Guid("f49a54bf-5f4f-42a1-b71b-fdb0d4243f2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76824824@gmail.com", "NamDepTRai824", "Hashed_password_02", null, false, false, "Ho Hoang824", null, "User", null, 0 },
                    { new Guid("f4cb0f5f-c510-4dc8-997d-ea9fae746da6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76674674@gmail.com", "NamDepTRai674", "Hashed_password_02", null, false, false, "Ho Hoang674", null, "User", null, 0 },
                    { new Guid("f58c2c5a-7cda-4e7f-96be-3c86c22b6b56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76967967@gmail.com", "NamDepTRai967", "Hashed_password_02", null, false, false, "Ho Hoang967", null, "User", null, 0 },
                    { new Guid("f5dcf2aa-469e-404f-9b37-d89d8c14b2e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76420420@gmail.com", "NamDepTRai420", "Hashed_password_02", null, false, false, "Ho Hoang420", null, "User", null, 0 },
                    { new Guid("f61793cf-4ebd-4788-ae06-da1699a8f100"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76768768@gmail.com", "NamDepTRai768", "Hashed_password_02", null, false, false, "Ho Hoang768", null, "User", null, 0 },
                    { new Guid("f6407ad4-4b47-4c14-aa87-008a4e7221e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76962962@gmail.com", "NamDepTRai962", "Hashed_password_02", null, false, false, "Ho Hoang962", null, "User", null, 0 },
                    { new Guid("f66117ea-4f17-42c7-9dea-eee5dcfc897d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76809809@gmail.com", "NamDepTRai809", "Hashed_password_02", null, false, false, "Ho Hoang809", null, "User", null, 0 },
                    { new Guid("f68341d0-1f05-4559-9e5a-64a79e1cd378"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76286286@gmail.com", "NamDepTRai286", "Hashed_password_02", null, false, false, "Ho Hoang286", null, "User", null, 0 },
                    { new Guid("f69e2cbf-5bd5-4bfc-9d4e-cf55b19abf59"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76713713@gmail.com", "NamDepTRai713", "Hashed_password_02", null, false, false, "Ho Hoang713", null, "User", null, 0 },
                    { new Guid("f6ab30ff-1275-4424-b4d9-b262ddc156ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76852852@gmail.com", "NamDepTRai852", "Hashed_password_02", null, false, false, "Ho Hoang852", null, "User", null, 0 },
                    { new Guid("f70de723-b276-4206-a0f5-da0e0e84cefa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76206206@gmail.com", "NamDepTRai206", "Hashed_password_02", null, false, false, "Ho Hoang206", null, "User", null, 0 },
                    { new Guid("f71c31ca-ec8d-4a6b-9079-9672875d486d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76369369@gmail.com", "NamDepTRai369", "Hashed_password_02", null, false, false, "Ho Hoang369", null, "User", null, 0 },
                    { new Guid("f793012c-46dc-44fd-8364-2f35999287e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox761515@gmail.com", "NamDepTRai15", "Hashed_password_02", null, false, false, "Ho Hoang15", null, "User", null, 0 },
                    { new Guid("f7aac9f7-88b2-476c-b5d9-a58db58b5a41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76411411@gmail.com", "NamDepTRai411", "Hashed_password_02", null, false, false, "Ho Hoang411", null, "User", null, 0 },
                    { new Guid("f7d4485f-5ed7-46c3-a5be-23d0b59f6f9b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76148148@gmail.com", "NamDepTRai148", "Hashed_password_02", null, false, false, "Ho Hoang148", null, "User", null, 0 },
                    { new Guid("f7f9996e-c74e-432b-b6b9-c7ec756a62c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76219219@gmail.com", "NamDepTRai219", "Hashed_password_02", null, false, false, "Ho Hoang219", null, "User", null, 0 },
                    { new Guid("f816b64f-d517-42a4-a68f-057e3accd764"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76134134@gmail.com", "NamDepTRai134", "Hashed_password_02", null, false, false, "Ho Hoang134", null, "User", null, 0 },
                    { new Guid("f84a97d8-e153-48bc-abac-0d65a234e5d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76187187@gmail.com", "NamDepTRai187", "Hashed_password_02", null, false, false, "Ho Hoang187", null, "User", null, 0 },
                    { new Guid("f852943c-3b98-42bd-b33e-f7605c4b6ccd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76200200@gmail.com", "NamDepTRai200", "Hashed_password_02", null, false, false, "Ho Hoang200", null, "User", null, 0 },
                    { new Guid("f8562cd2-aeee-4ea7-aea9-af3bf327ec1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76327327@gmail.com", "NamDepTRai327", "Hashed_password_02", null, false, false, "Ho Hoang327", null, "User", null, 0 },
                    { new Guid("f86dd17c-a9da-4425-badc-8fa651dd4473"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76788788@gmail.com", "NamDepTRai788", "Hashed_password_02", null, false, false, "Ho Hoang788", null, "User", null, 0 },
                    { new Guid("f8742102-84f8-41b8-9d14-5466fd9f890f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764141@gmail.com", "NamDepTRai41", "Hashed_password_02", null, false, false, "Ho Hoang41", null, "User", null, 0 },
                    { new Guid("f880ac37-e077-4734-a037-8814ce2ae5a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76157157@gmail.com", "NamDepTRai157", "Hashed_password_02", null, false, false, "Ho Hoang157", null, "User", null, 0 },
                    { new Guid("f897083a-a9c4-4105-9230-874bae3ac819"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76224224@gmail.com", "NamDepTRai224", "Hashed_password_02", null, false, false, "Ho Hoang224", null, "User", null, 0 },
                    { new Guid("f8deff48-c8a7-487a-ad17-8982535ade43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox766161@gmail.com", "NamDepTRai61", "Hashed_password_02", null, false, false, "Ho Hoang61", null, "User", null, 0 },
                    { new Guid("f92d7b56-5208-4422-9b82-cc4b1dcd5592"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76652652@gmail.com", "NamDepTRai652", "Hashed_password_02", null, false, false, "Ho Hoang652", null, "User", null, 0 },
                    { new Guid("f92eee2a-ca3e-4c92-bba7-f0547a144369"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76666666@gmail.com", "NamDepTRai666", "Hashed_password_02", null, false, false, "Ho Hoang666", null, "User", null, 0 },
                    { new Guid("f97f4f73-dec1-4fd5-b788-d20ec564b872"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76729729@gmail.com", "NamDepTRai729", "Hashed_password_02", null, false, false, "Ho Hoang729", null, "User", null, 0 },
                    { new Guid("f9e83d74-f124-45e8-998d-b837a42059ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76165165@gmail.com", "NamDepTRai165", "Hashed_password_02", null, false, false, "Ho Hoang165", null, "User", null, 0 },
                    { new Guid("f9efc426-de17-46ef-a8bc-4c1ee5d82d1f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76525525@gmail.com", "NamDepTRai525", "Hashed_password_02", null, false, false, "Ho Hoang525", null, "User", null, 0 },
                    { new Guid("fa00ac6d-cf88-4eee-a871-d759fbdce4a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76744744@gmail.com", "NamDepTRai744", "Hashed_password_02", null, false, false, "Ho Hoang744", null, "User", null, 0 },
                    { new Guid("fa183943-ce6d-420d-9061-ffcb24210f6c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76628628@gmail.com", "NamDepTRai628", "Hashed_password_02", null, false, false, "Ho Hoang628", null, "User", null, 0 },
                    { new Guid("fa518445-e0f5-48f7-a519-7860b67dc42b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76794794@gmail.com", "NamDepTRai794", "Hashed_password_02", null, false, false, "Ho Hoang794", null, "User", null, 0 },
                    { new Guid("fa519832-ed06-47af-a31a-81609658a1b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76501501@gmail.com", "NamDepTRai501", "Hashed_password_02", null, false, false, "Ho Hoang501", null, "User", null, 0 },
                    { new Guid("fa5fad63-c0af-4ebf-97f1-bd841cc67036"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76127127@gmail.com", "NamDepTRai127", "Hashed_password_02", null, false, false, "Ho Hoang127", null, "User", null, 0 },
                    { new Guid("fa6b1c8f-68f7-4340-84a8-d5b9fada1462"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76643643@gmail.com", "NamDepTRai643", "Hashed_password_02", null, false, false, "Ho Hoang643", null, "User", null, 0 },
                    { new Guid("fa747dde-d4fe-4187-8136-cd0d52342f64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76752752@gmail.com", "NamDepTRai752", "Hashed_password_02", null, false, false, "Ho Hoang752", null, "User", null, 0 },
                    { new Guid("faa7cb17-a44f-4aae-90b0-2e27be8ab2b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76866866@gmail.com", "NamDepTRai866", "Hashed_password_02", null, false, false, "Ho Hoang866", null, "User", null, 0 },
                    { new Guid("faad37ab-35b5-419b-9883-d81b38c49909"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox764343@gmail.com", "NamDepTRai43", "Hashed_password_02", null, false, false, "Ho Hoang43", null, "User", null, 0 },
                    { new Guid("fb63da7c-34e6-4224-8f32-9c3e12f6bde1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76552552@gmail.com", "NamDepTRai552", "Hashed_password_02", null, false, false, "Ho Hoang552", null, "User", null, 0 },
                    { new Guid("fba362fc-4ab2-4262-996b-a96886dcda5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76442442@gmail.com", "NamDepTRai442", "Hashed_password_02", null, false, false, "Ho Hoang442", null, "User", null, 0 },
                    { new Guid("fbb7168f-e104-4ca2-a169-95d6524b950d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76523523@gmail.com", "NamDepTRai523", "Hashed_password_02", null, false, false, "Ho Hoang523", null, "User", null, 0 },
                    { new Guid("fbcacef5-93a8-40f1-a9a5-f34bfb62a15d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76133133@gmail.com", "NamDepTRai133", "Hashed_password_02", null, false, false, "Ho Hoang133", null, "User", null, 0 },
                    { new Guid("fbda06a7-a1dc-4787-84e3-0a3d3ac731b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76957957@gmail.com", "NamDepTRai957", "Hashed_password_02", null, false, false, "Ho Hoang957", null, "User", null, 0 },
                    { new Guid("fbf9991b-c192-40f9-8533-a9a251aefba9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76274274@gmail.com", "NamDepTRai274", "Hashed_password_02", null, false, false, "Ho Hoang274", null, "User", null, 0 },
                    { new Guid("fc7cd3b1-ca78-486e-a1ad-e8265f8d03e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76926926@gmail.com", "NamDepTRai926", "Hashed_password_02", null, false, false, "Ho Hoang926", null, "User", null, 0 },
                    { new Guid("fc99e3ff-fc7c-46ae-a142-6d806f3aa0d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76814814@gmail.com", "NamDepTRai814", "Hashed_password_02", null, false, false, "Ho Hoang814", null, "User", null, 0 },
                    { new Guid("fcbb5911-a3e6-4cb4-9d88-bfaeac4c7667"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76267267@gmail.com", "NamDepTRai267", "Hashed_password_02", null, false, false, "Ho Hoang267", null, "User", null, 0 },
                    { new Guid("fcc4b5a0-0a7b-49d3-b18f-15ceb5be48c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76123123@gmail.com", "NamDepTRai123", "Hashed_password_02", null, false, false, "Ho Hoang123", null, "User", null, 0 },
                    { new Guid("fccc1024-a7b6-403a-bc3b-44f691adeb96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76328328@gmail.com", "NamDepTRai328", "Hashed_password_02", null, false, false, "Ho Hoang328", null, "User", null, 0 },
                    { new Guid("fda5a8a7-cd37-4f45-a513-80b7749fb852"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76397397@gmail.com", "NamDepTRai397", "Hashed_password_02", null, false, false, "Ho Hoang397", null, "User", null, 0 },
                    { new Guid("fe3c0320-277d-4b21-a183-1c2ed3ef5b9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox7600@gmail.com", "NamDepTRai0", "Hashed_password_02", null, false, false, "Ho Hoang0", null, "User", null, 0 },
                    { new Guid("fe751e44-173f-4f91-9b06-ba9f16a4cc41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76480480@gmail.com", "NamDepTRai480", "Hashed_password_02", null, false, false, "Ho Hoang480", null, "User", null, 0 },
                    { new Guid("fe8cf992-ac8d-4136-b7cf-5cc37b9aca56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76857857@gmail.com", "NamDepTRai857", "Hashed_password_02", null, false, false, "Ho Hoang857", null, "User", null, 0 },
                    { new Guid("ff6a7181-d8ab-4804-bd4d-6e08f6d66464"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76114114@gmail.com", "NamDepTRai114", "Hashed_password_02", null, false, false, "Ho Hoang114", null, "User", null, 0 },
                    { new Guid("ff98e789-a49f-4dcf-a226-fcb2387bf459"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76640640@gmail.com", "NamDepTRai640", "Hashed_password_02", null, false, false, "Ho Hoang640", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00137a74-342b-44cc-bac0-3af1c4c18ab7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 412", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("008b4f18-6b32-4e2f-865a-3512739ba870"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 65", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("00c120ac-9b3c-42f0-ae4d-ea723cab4d92"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 139", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("00e9d9f6-0bf7-4db5-8b8c-725edc98f834"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 278", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("00fcce88-129a-4680-a24e-46354f7bec37"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 463", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("01110b3e-8651-4e56-9959-8308eb75d938"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 140", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("01317075-e3b0-4fba-896d-3481d4e56fb4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 432", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("01669cf3-fe3b-4652-850c-30de4e034f41"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 291", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("01b5a409-0baa-4fcd-817b-b562b7b8369e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 293", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("01cb41f0-ae9e-4add-8741-d17a2eb440b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 227", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("01d0369a-f378-45e6-98d3-c2959bd0ee4b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 63", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("01fb3d1c-a4d7-46fb-b7ad-6b14c51bc8a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 245", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("02a69876-2816-4dc0-a078-472cadd636bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 190", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("02af4ff1-c427-49fb-b447-d936fab3d1ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 71", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0383c9f8-f055-493e-8c2e-79084cee66b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 334", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("03984af3-03e4-4ed1-99ce-1efc2d6c6fd4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 91", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("03a3d050-1555-4948-af19-68dc12dc6125"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 395", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("03b16d62-a592-4aee-9b76-d7466afcf920"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 67", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("044942e5-faaf-4775-b1b2-c28e41d20fff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 304", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0462a054-7350-42b1-a595-12d631ef9458"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 12", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("046475cf-831b-44ad-b852-aa6c841f4cac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 222", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("04924bc5-bc4a-47c5-88b2-66688f73eb9e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 414", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("050c01d3-e019-4f11-a5b3-68abafdcd672"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 252", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("056d6f0a-3b9d-4dbc-8353-48bb3192f282"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 292", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("058a3a13-b1f8-496f-85ae-fb380e0021d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 168", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("06468e22-9a28-4324-aad8-e676c52f8252"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 469", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("067dd5c8-d154-474f-92d5-967db03845f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 160", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("06c89463-c533-4dd9-8bc1-49661cb282c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 373", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("07043b80-77ec-439e-a788-94f8afd0b1e5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 305", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("071a07ad-4c6e-410b-967c-dd777aa33c11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 282", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("07331899-528d-4e26-8d11-07f514740bca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 258", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("076c90e5-7a0e-4cd5-908b-f43222fbe40f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 232", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0790b282-d2c8-47af-bd43-51a070b376bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 395", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("07a1137f-cd4f-48b0-a6a0-ddc3056a03cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 107", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("07c45ef3-6714-43b5-88fa-0dd1c2d9f0c8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 388", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0804ad99-bf31-401a-896a-3624734b0b48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 267", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("083a0332-5fce-4334-9e46-e65ba564e266"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 482", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("085ae260-fc7e-4810-9827-400eced0e3f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 163", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("08758f10-963b-4094-8bda-ec402ec18883"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 144", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("09078b5a-b2ef-4980-bb2d-dd40d5e83dd3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 62", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("09137a96-09f0-4701-b53a-e448f17988a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 427", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0979abbc-0810-40a6-ac22-cca152a3a8ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 397", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("09bf469f-a59d-4d0c-a2e5-97c0525fdd1d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 453", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("09e0db66-917b-4968-8c91-b6c4d476a3c4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 116", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0a119c22-f976-48f0-a991-c5747abdc309"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 276", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0a2a527e-57dd-4666-80c3-6539faf32dac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 128", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0a4ea349-fe24-4727-ad6d-8d7aee6f32e5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 430", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0af2a314-a671-4efd-a886-cf5e073ff801"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 176", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0b1fda6d-2bd3-4fdd-a4a7-8aa2d6a34ff3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 203", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0b4a1066-75d0-4a19-b94e-20811fd0540f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 172", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0b81fb8c-1f03-437d-b4e4-79427917961c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 481", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0b8d95bc-fc4e-446c-9c63-662654ce81bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 374", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0ba4f72f-8697-4f4f-a86b-55feb750ea9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 475", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0ba5f382-ca08-4813-be93-70a0c3574835"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 48", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0bf5d8e1-fdd7-4ce6-bbf4-35fab3e93b0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 333", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0bfde11e-fcce-4563-95af-dcf121b202b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 159", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0ca14a6a-b4fc-466f-8f60-e156e7c63653"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 443", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0d536271-d1f3-4bf6-a10e-facd4e04defc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 155", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0ddf4d5c-2800-4de8-a71e-d7b6b88d2ca3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 379", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0e26be09-905f-40d7-bcf1-23c3f46e5752"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 7", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0f0d5a81-a83a-493e-96a4-e7be0c25d5ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 325", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0f804c90-30c1-4587-b8d0-28b0d9c94478"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 263", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("0f9dc749-9fb4-4ae5-9725-a6c753f51037"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 309", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("0fd386fa-c16e-4c93-ac15-6be77805954b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 79", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("10758dbd-90c4-40be-bec3-2856d09a26d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 51", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("10b16994-5a7f-4dbc-aa8d-d4e5cdf28f86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 471", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("10cc9331-cc3b-43be-bf60-c3d0d2511ea7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 442", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("11619b98-329c-4d6c-8cc1-279a945a790f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 392", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("11713333-24a2-4dbc-b868-f2b7d510815e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 432", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("11883c06-525a-4712-9bc4-068b5d608dfd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 426", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("11922663-6b5d-4944-848f-bb84e50a7015"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 479", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("119c520b-64d2-4e67-b559-71ce76c3a7ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 402", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("11c27d75-270a-47ee-ae9a-667e23becefd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 254", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("11d372b2-ac0a-427d-ac45-1aa1e8bc254b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 296", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("12313a29-83e4-4be2-90da-b38324ef0f04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 436", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("12416938-753b-438b-8728-15f245a81b9b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 495", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("124ee6ff-7a88-43e9-807e-b90bd209d6cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 206", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1258871e-5ef5-43e4-95ce-e98ca42f5032"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 98", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("12c05be1-bc4f-467e-920b-884ed964d361"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 307", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("12d19d4e-b5d6-4512-b59f-33cd74955f3d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 441", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("13c97dd4-9a46-456c-8f8d-9ec208f93322"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 294", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("13dd28c1-d859-4b78-a1b7-2d5e4d2d1af5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 295", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("142eee10-e701-48d6-b51c-d743babe29c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 407", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1443086f-bddb-4528-88fb-f797cbeb80a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 488", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("146f9d9c-8141-4517-a748-1e3352395db6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 271", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("15418c6b-3302-4ad3-98b8-f37ce763b151"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 411", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1554958e-f77e-48b1-b380-7c23cacea312"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 8", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("15dc6b94-9acb-4764-88d2-16a29cb9ea26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 259", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("162c0c81-a9ea-4d08-bb5f-266f5f94893c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 1", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("168b876b-e5f3-4d04-b924-ab9c96433462"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 221", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("16f852e6-04c9-4173-951e-b81f9d2022c7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 220", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("17af6213-c9bf-480a-9117-8125f656bb8e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 87", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("18293b0e-d15a-41b6-972b-563deb5ba878"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 204", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("183b8f58-66ea-475a-9cab-4d7cfe83727f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 40", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("18544b16-0379-471d-a848-bd0acc1d3c14"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 237", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("186a66d7-f0df-4886-bb52-9ec625db9095"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 55", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("18706c19-7ade-4fe8-964a-d75e4d0d1c22"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 115", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("18df1dde-7564-4a36-a4d7-2607a4dc5452"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 251", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1931ab5b-03df-46d2-aeeb-f3f0a866dc8a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 46", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("19b7c13a-0137-4ab3-b488-ae684ec670fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 339", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1a0db0a3-dd8e-4773-9972-56cb1e621ea9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 119", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1a3fcea3-aaa6-458c-8f31-b1586542b191"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 362", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1a89d482-a68d-47ff-95df-37af502dba0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 215", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1ad91845-0764-4c80-9292-ee5f0faedeb8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 284", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1ae18910-2b8b-4b42-82e9-e70029a585a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 15", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1b0e04af-953a-419f-897d-de7a7ece8eee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 323", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1b1a6169-6ff1-47d2-8b7c-9b82f52528ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 274", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1b3b78f8-464b-45ab-b009-e1b9f2309d56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 258", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1cd3da1c-c6fe-452d-a78e-6d2fbe62afeb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 82", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1d080dee-cad6-46cb-8e87-72af5e73de08"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 405", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1d458f38-a8cb-4604-8655-a46a2ee3db1e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 55", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1d45faf2-94d2-49f6-8330-6ab30cec3abe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 318", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1d5191bc-9e40-48b8-a640-08de9a317106"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 372", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1d7ce62c-2b15-463f-961f-1ddede131942"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 472", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1e02fc3e-f0af-4aec-b88f-c30a9ef43707"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 277", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1e0d82d1-be3f-4d7c-aec7-4f7f2273a112"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 481", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1e61c91c-aa6a-437a-901a-cc9d9bcafb63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 61", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1e6d27a8-c617-4508-8442-4f0f3c344026"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 429", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1e82b525-fbca-472e-9d34-59b80fcd09a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 214", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1eb598af-62b7-4bd1-aa74-d2de11f9eb10"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 27", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1f103fe9-533d-48bf-8b65-b516c02ee2be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 257", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1f20c13a-97fb-4f42-a307-301bf1ba4673"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 227", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1f2da576-c1df-41fe-a73d-5b6e018ad1ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 191", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1f968c9d-4c6f-441f-bdde-c1c0bc6c779a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 133", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1fb80fdd-8cab-4bbb-ae13-e656b6450436"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 403", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1fbf3f5f-64bc-43bf-a956-3ee10ffcf166"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 230", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("1fbfc548-a6b8-488d-85e6-7d4eabd4f506"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 170", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("1fdd8f1a-ca3d-4d07-83db-c6442a7a77cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("21048c6f-da93-485c-8d39-52d1e516bd2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 143", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2107a71c-3b57-436d-a80b-18c0baf3bbec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 494", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2108bef7-8acf-492a-b7e3-29bf89c193f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 336", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("211fbcad-ba2e-4c85-a950-a2493c2668e3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 315", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("21422a1e-a5e5-47ea-9d59-5671b6cab750"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 144", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("21a0870c-6f79-4f1a-8402-b99fbfddd874"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 2", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("227764c1-5905-4c5d-9ec1-262c85522af8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 229", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("22937ea7-776e-45c7-913e-1db86d2563f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 467", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("22988963-fc8e-41f6-ab5c-c7625923c31d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 129", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("22b81ed6-9590-45f1-9285-57fc9832dbd7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 234", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("22c2a466-20f7-43d1-a03d-8a895377722c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 434", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("22c44b07-0021-464b-ac6a-7b46867db40f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 385", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2349d1dc-03af-41db-aeb0-f5cf1ae62516"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 390", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("23616987-e10f-44e6-b619-43648dec1ba9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 35", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("23d95ac8-0117-40b9-92ef-c8cff6e03077"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 405", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("244107dd-fb01-4e15-9ac7-1d931a288857"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần xì", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("244d3ce0-8fff-4a63-8413-19cd1321be78"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 417", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2513cc16-5b0c-46e1-9906-b84555be85c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 150", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("252e0d7b-508c-4e1c-854c-7a5ceae4cf79"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 270", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("255a8f9c-9c82-48a4-87d5-5a8dca8f974e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 109", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("256da5d7-d9c7-4920-bf26-373604ce42d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 158", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("256fa8c8-26e5-444e-a3de-6ca8e32f1141"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 81", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2599f1b3-2dd2-456c-843c-681531a69b7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 24", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("25aff536-0348-4cc3-8660-0f4b6164a035"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 159", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("25f2dbc6-3ef8-4fb3-9832-52ef7f4f53ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 5", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("26dfd607-ad7d-43bf-b08b-663402127e5e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 16", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("26e44280-84ef-489e-9966-9eca3d7d2287"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 11", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("271ebecc-0ca5-4560-a978-59a15ec528b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 49", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("275c34c0-9792-4e3b-ace1-bf652a887780"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 197", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("27a64117-3470-4958-a5ac-16d5dc0c41ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 337", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2849f18f-a025-4d3a-861e-5dd843b2ac76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 393", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("286d2e29-f58d-42f4-a82d-50eb784598af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 27", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("28b19ef8-7e6b-4d85-b4e9-1f9b51c77ccd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 374", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("28e53a6c-e96d-4be2-91c8-8bbade5a86fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 281", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("28ec5789-f8c1-48d7-8448-2c20192f66e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 429", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2924c9da-3590-4d43-9717-3d5491b30737"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 448", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("293a1952-a328-4582-b7a8-a82f23f22507"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 394", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("298dc8fc-327f-4fe0-92e2-14580b6ddca8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 494", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("29e1d964-2cd8-43fa-b035-980724ac722b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 450", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2a169cc5-c33a-4a59-8d8c-588a093d99e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 208", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2b0485dc-e166-4d6e-9d6c-f43bfa789544"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 356", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2b765876-45e9-47f8-b843-bfc91fb857eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 86", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2bab9823-1d8a-4b28-a5b2-96cfc8ac831f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 33", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2c04c87e-010e-46f3-8b72-7d176edcc51e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 267", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2c596734-c3e9-4fa4-9327-49f8c2215d7f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 352", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2c6952d4-f2bf-45e8-975a-623c4da8a12e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 88", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2ca83e3b-e14d-4312-8d14-406090f3c218"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 70", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2cc62b44-c473-4f16-a4c1-eac38f309457"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 217", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2d5d83e0-4392-424d-8fd6-582732a30748"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 99", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2ee4e200-f79c-481c-be13-4f99faad143d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 411", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2f5ef86d-442a-455b-bf9c-f3bbe20e81cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 126", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2f7bcc72-f378-4aa2-8563-21a6c2997396"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 232", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("2f9a33ad-015f-4668-a2a0-bd90e0fd8382"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 350", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2fb33048-3073-48ae-991b-9bb4d2cda27f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 132", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("2fc9b1f1-f5f5-4e3b-a155-d3bfc020e33f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 275", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3043cbeb-3d94-4ecf-a6ff-4e1acc812265"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 418", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("30eab822-b48d-4a3c-a168-8359ebb2cdf2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 96", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("30f4d37f-d061-404d-9657-c7cdf71416f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 444", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("31065cc2-6007-47b8-b49f-5a38f48866a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 34", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("31226aee-1c0c-4882-a31c-873faef360b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 304", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3141a9ce-80a5-4b71-af4a-943978cbc5eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 193", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3219e94e-0c52-4c39-a3fb-84d9da1a8d93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 407", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("325ceacd-28a3-471f-84ca-bb85eb527ccb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 312", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("325d2aad-4086-458b-95d8-447681067e3c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 413", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("32662fcf-19b8-4dff-8096-2ac5a07084a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 56", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3354f04c-021d-4711-8505-17af97178992"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 250", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3368541e-3975-441d-a82a-ff0df3d9262c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 497", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3394af0f-9081-4eac-a137-3469c07f3ccf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 351", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("33b70dd2-781e-4e7c-98f4-a27baaea690e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 19", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("34d9e5dd-5844-4ab9-b018-aa9a15a84faa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 50", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("355bd165-8163-47dc-98df-c0f07e9d9533"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 145", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("356142f6-e756-4d57-a9a8-d882e9f18f08"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 210", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("357cbf7a-8280-4ce2-88ad-bd96a4bece1c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 7", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("35a00440-1088-4444-9240-30bdf7c2a49a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 376", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("35dab285-9b3e-4d9a-bf0e-a411f7f95950"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 243", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("35ffc7d5-0a44-4ad4-8777-6cbb0cd7ae31"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 228", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("367e452f-8f83-4528-bb17-7788b3ea12ae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 361", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("36a786d2-3519-484d-a440-a984076a82f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 302", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("36bc568a-05a1-4f5d-9e04-4a0c3b6269fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 473", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3739039a-f215-4277-82d2-6d81e87c6df1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 316", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("376f0604-2f22-4635-9068-66eea236b340"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 459", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("37a00bac-10ae-494f-bb76-96f63672d099"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 200", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("37aa6989-e932-4e15-9e9e-cb3324c99f76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 356", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("37c6522a-4eff-4c28-9509-9a3567af87d7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 461", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("37e0930f-fe16-415f-97dc-e2a77d8da82e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 424", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("381b05c7-b19f-4901-b6d0-bcb068e06bf7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 43", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3845aa1c-83c9-490f-b341-9f44cd52ee15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 104", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("39c480bd-dd73-4f1f-8ce7-34c2befe915b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 82", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("39fac1ae-95a1-4de6-bdc4-dc3b791f99f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 226", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3a7f0da7-61d6-4cfd-a246-2361e90dfd28"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 320", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3b4b6b1d-a84a-4efe-a3b1-aa36830177f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 155", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3b5c1c5d-7320-4bb8-871c-1689882a53dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 117", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3c2324dc-c04b-4140-b870-d26d716a70ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 86", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3c493dd7-d336-47ad-ae0f-acbc954edd05"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 303", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3c5af869-9b29-4d1c-8bae-6b99d6e2c40c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 278", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3c75e8e5-7a10-4973-8cd1-ddd7786a7465"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 391", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3c988a40-90b8-479a-8fe5-77e5d800e92c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 122", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3ca344de-f660-41b6-9b32-f05e6470993f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 137", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3ca58fde-9762-4211-9293-ddb177930830"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 259", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3cdf8142-8eff-44e3-a6e7-2d40aa9aeff1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 102", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3d1b4054-1688-46e3-98b7-af14dbb70bef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 242", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3d33c4d2-2e4f-4d6a-a7d2-3f71d18b1dcb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 262", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3dbdb104-099d-47a7-8ede-50f1b4649055"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 488", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3de01510-95e5-4ebc-a1f3-778789e9ca15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 167", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("3ec4e24c-6d42-44f2-8cd1-12586270d385"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 141", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3ede9ad3-617c-407e-a34b-0c78e0f795a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 71", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3f098cb7-43c9-4138-a208-0a48ca027b6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 464", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3f17f3b5-c75a-4e30-beeb-b0c3f184ade6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 279", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3f4eff5e-89d9-49ca-8523-48bda6c39fd1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 214", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3f8b0b43-5362-42e3-9b79-31ffba2476d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 497", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("3fc94ed5-a06a-4a1a-830a-e50227f5f59d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 317", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("400d16d5-4c5b-46ca-b462-b5363bf9bd25"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 166", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4022db86-c7af-4c4f-8948-8eca14df00b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 415", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("40b15e0f-6577-4242-adb7-035229d99643"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 442", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("40b63c8a-185e-4502-bd26-2f3905364cae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 265", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("40d149d6-9436-488d-be54-c5969c0beecf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 36", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("40f4666e-7072-457a-8386-05d62b193c70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 436", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("411c9ee1-4cab-4f53-81ef-cc6c677c0399"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 422", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("41353702-6510-4fe1-bebd-3a45d3a35821"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 69", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4180689b-b6ae-4a97-b9fb-87a8c5990728"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 23", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4183d7e1-cc00-4114-803f-a46ee196b5ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 500", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("418556fc-8407-48a8-81b1-2f48a265eead"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 54", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4259500e-b0d1-4508-9133-ccba4dbe230f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 476", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4261a47d-67b0-446c-b661-99521b23dcfe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 6", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("42a4e263-874c-43ef-9bfe-305e29b0cf54"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 114", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("430b7400-90e3-4678-a394-bb1ad3008b62"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 461", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("43e8da8e-f836-49b4-a82c-a6502ac58670"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 410", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("43ea1685-f3cb-4c10-9802-0a8824f68d0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 400", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("443f7879-a647-4381-9ce9-56a39facffa8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 456", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("446e4dac-df8c-4338-b785-8b5a3a324806"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 255", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("446f472a-f988-41e5-ae00-5957b1299cad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 13", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("44f899fb-3774-43f8-8558-480da44b01b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 428", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("45037b66-5e5f-46f6-b39d-eff2357486cb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 11", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4550591d-d3d8-49ae-bac6-45456ccc4f87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 37", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("45646b35-da27-446a-b1c1-13075a16aa6c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 364", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("45820695-723d-4d52-ada5-d0a1dc468e11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 318", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("45e0e9e5-be53-43cf-b3dd-94a0c02e918f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 100", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("45f1990f-d853-40dd-93bd-f451228cdb7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 280", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("46d129aa-8d99-41a7-9f63-8f3dd2df9eec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 0", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("470d250e-5373-405c-a405-553bc0d7e091"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 213", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("47442f5f-ce61-4386-ab76-62b52f490b90"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 168", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("476d2c9e-9291-460d-bbb6-be832240a2cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 209", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("47c8fe1c-9721-4323-830e-b4bacba32128"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 152", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("47d987c9-4eec-4f7f-9e02-519ed9183070"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 189", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("484ea95b-1f4a-4a42-bd31-59eba0406569"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 331", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("486f7279-75fb-4225-a756-b04925942442"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 485", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("48791aa5-168a-4146-8e16-20a77f2523de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 237", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("488de244-55cf-4ead-ab26-5fec60702180"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 152", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("48c50f58-dd87-43ab-84fe-f44da25c19ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 235", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("48e76290-2120-4771-8cc1-3ea928c3736d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 113", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("49215305-91ba-4df7-a17e-4dd30d2e3d62"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 333", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4960050c-31ce-440c-961b-572677dcbbfb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 413", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4990347f-ae43-4530-a929-e90626901550"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 459", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4996ea4a-930f-44c7-91ae-03c8cf2a177b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 18", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("49a6911b-8318-4990-951f-61c8901d5d9d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 472", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("49d05d62-b800-4ec1-988d-92b401e4637d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 383", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("49e427cf-3d0f-44e6-a4c3-4d5f8fcfc073"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 124", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4a025a88-36dc-4abd-be88-4aa3ee5c5c1b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 320", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4a49dcbb-b7e4-42b3-8951-3f44594a3804"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 454", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4a960ef8-093d-444e-95b2-0c0d07bf3205"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 335", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4a9c2f8c-c41b-45bf-9a12-696c88b8099a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 184", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4b2e849f-bfbd-4e88-a2da-84f22a5446f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 279", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4b6f0b48-72e5-44d8-9fa9-12fa612621ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 136", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4c19a1b8-128a-413d-a016-a8fd94547c6d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 491", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4c9b2ffd-0f9b-4d1f-bfb9-83015675925e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 211", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4ca1193d-1324-4872-b522-030b6aaeaf60"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 450", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4cadada3-ce07-4248-96d6-b7ea60f0b0b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 477", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4d41e72a-5796-451c-ab5c-9065b09c29e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 44", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4d4f02c0-cf5a-45cd-a7f2-a3116ed59180"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 416", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4d62a40b-7cd4-445f-a111-d1ca1ac09774"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 289", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4d7146d4-e1c5-4c64-b31f-0cb648ac0dc7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 153", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4d7bad3e-b073-46d2-84be-04b72fd4c51d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 319", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4d86ee75-4288-4026-8936-29202e6c9d4c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 206", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4dc8c678-3e3f-4175-b81a-f21775352edd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 364", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4dd69100-aba1-4681-b62d-cf94d50c7b1f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 60", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4ddc5918-a256-48aa-b436-1049ff60f375"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 42", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4df76772-933f-4c5f-9931-918b5d9e8a85"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 251", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4e59bbb6-3236-4605-ae6f-b5af31d8b907"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 26", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4e94d7dd-58f9-4431-9231-98f23f0bc4b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 178", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4e9556a7-46fc-4e1c-a871-c99c98af0840"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 136", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4ea65673-027d-4b2f-ac3f-e0fd0451518e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 473", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4ec8acc0-024c-40cc-8951-c39dbe3a250e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 437", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4ee2393a-854b-4258-83f5-b26b5a8c2ff9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 291", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4f5fd340-8a8a-4db8-a3c6-e681cb21985a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 203", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4fa4f292-d2aa-42bf-bb8b-27905f25fb07"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 166", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("4fbe475f-f704-4cc2-8bc7-04ab2aac5bfe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 265", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("4fd2b5db-87b0-4f47-b892-b38b0bde3d53"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 493", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("507751e4-3a1d-44d5-9e3c-4257273886bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 239", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("509ce78b-5be3-4a91-8e56-d3bb0ff252b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 483", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5127b887-fd83-4935-86fb-ec4748aad129"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 460", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5138c99e-a844-473f-add9-064245b65bdc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 468", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5146e563-7f49-4186-866c-fab5e6132953"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 317", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("514730d4-356e-452f-925a-c1043c67408c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 296", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("516d2303-49ed-445e-ac4f-d07ca245e737"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 477", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("518a4904-35cd-4c45-b47c-fd3b1d4553b9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 369", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("51986fc2-5eea-40e8-b867-9c4507051b26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 264", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("51dc5a91-5f26-42c4-b713-59fdf62fde24"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 308", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("520384b6-bc03-4044-91df-4740f9f65f74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 20", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("520c6ac4-6149-4c9a-a774-228c299387ae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 495", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("52262bc0-5ca5-4fa6-a850-f5da56e12c11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 125", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("52446171-fc38-4cf6-aa76-6da00a535968"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 131", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("525e5724-4bd9-4f09-98cf-edab445e550e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 146", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("5294ab53-d560-4144-91aa-9f591792f244"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 73", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("52c03489-b89f-4719-aba9-8406d5597189"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 177", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("52df8918-62de-46b5-9b50-81462421e289"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 41", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("52fdd0fc-2928-4728-b2d9-f92f4af41b17"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 408", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("53bca159-df17-40ce-a115-46e10169b824"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 342", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("54143c0b-5ea3-41e7-8490-db8871568931"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 110", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("54b90674-f160-4663-9ce1-d100372cdcdb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 222", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("55538f60-6a5a-4c50-aec3-de5479e61d14"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 132", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("55a77299-27a2-4590-a6a4-43ba5ec1911d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 146", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("55ae8c36-db2a-47bc-9428-0145d80d174a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 56", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("55de0fe6-81fa-4b91-8c73-4e2b55135050"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 148", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("5608f67e-bf31-4074-9c6e-59391d6c6e64"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 325", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("566b286c-4e83-42a5-b52d-85f43b0548aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 157", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("5693b024-0108-4a51-b754-7ee93776a326"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 363", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("56c70b27-9171-4eb2-835a-e01e082fc416"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 138", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("56db530c-8df7-44bf-8b83-6151e48c1574"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 223", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("570817c6-0f66-4996-9a41-c39e558745d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 220", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("577fc1d5-f1de-452c-8bc0-973eef03bf6a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 487", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("57ab631d-7bbb-406a-a9b0-b84be09db869"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 479", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("57bad710-4706-4474-b2ba-879aa2465abc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 188", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("57bb5136-484b-4575-971e-e9e7f4b776f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 47", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("57d2a77f-ca37-4314-96a1-56d5f4e8c04e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 20", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("582bb565-c09f-4b70-800a-dbe819421c84"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 409", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("5870bb10-7e12-4574-8284-c8b422ec90d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 192", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("587423c0-660f-4859-88a8-62ed55049d69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 174", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("58755865-7426-4b8c-b1e4-dca656b39320"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 191", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("58b7468d-8e9c-4d4b-b979-45c0fdf7cc49"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 334", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("58fbdfdf-4ef0-49ed-b68f-d93d76acbf4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 244", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("591e7d89-fc08-465a-b3cf-49a71d5c8a00"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 464", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5920a821-b12b-4a0f-8b40-c59e158957f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 354", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("5923289e-008e-47e7-89c2-75f263f416fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 66", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("59747626-45ab-4b42-90ad-9df2d436bf41"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 102", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5a4fff1c-0c11-4d14-ab3e-c35c3161e15d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 290", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5b08cfcc-e815-48fc-a7b3-6f739529c514"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 242", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5b383dd5-bae2-42ad-a858-91802ebe502e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 410", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5bda8296-4c3d-4176-8b2a-72f44645cfa4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 225", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("5bdeed8c-2138-4098-b4e4-3bbc18acd2c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 324", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("5c294bf6-4858-444e-a18a-2de64315700f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 348", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5c37aebc-d701-459a-8bff-654426e44729"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 30", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5c5cc8be-4e7a-4475-be84-0df7b9547388"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 269", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5cc26762-867f-49ec-935d-2bd262b0eefa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 313", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("5cd237e8-cf73-452d-9a51-033369624e79"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 326", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5d3925bc-431a-40ae-91de-c104c904ff58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 431", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5d88808b-4868-47f1-bcd0-d99aa68b38a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 44", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5e373b62-a547-4df2-84b4-53586519d9bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 95", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5e582c1c-21bf-4cc4-9b54-a558174b6460"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 126", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5e955be8-ebe4-44f7-ad47-58ede334f45a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 378", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5ea9d784-fae8-4dd6-94b0-2a213cd2ebcd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 106", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5ed03000-9469-4ab2-a3ab-523a43cc4c09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 451", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5f31836d-7188-4ee0-a1e0-73f0731d0384"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 255", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5f4ccb39-fe92-4487-9c76-e98ee847200e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 25", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("5f7c3725-f2a7-4a5a-8612-867bd4d33106"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 25", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("5f96c7e2-051a-419a-a5cc-c4b7a4df8863"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 224", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("600ef569-eee3-4fd3-8bf3-7a625798c195"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 226", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("603fac48-b76f-4338-9fe4-726799758b29"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 108", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6083a59b-8538-44e4-b865-3838e5434ce7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 293", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("60977491-b7ea-42c1-b21d-6b03289d01f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 147", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("60dfe47a-a6ac-4536-918e-560cee6a23b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 79", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("60eba8a7-fe3f-4bc0-9f4e-65c9c575ff97"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 391", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("612e0272-bf13-40c1-b1ca-ed5920f41093"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 382", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("616ec17b-fdaf-4ac8-9bd4-5472f830143b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 297", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("61a35d33-a7b5-4338-aa9f-6f2185dc9d55"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 359", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("61a40f39-92cc-48a6-a265-dcd22e196e82"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 381", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("61dff4cd-34b8-490f-97ce-3203a9f3ba69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 367", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6234ee99-ee8a-4126-865f-a4c5dada7601"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 160", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("628c483e-eaaa-4360-b9b1-9bf70b41ea84"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 308", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("62a7950a-a8f3-4671-b74e-5fcb87b8691b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 199", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("62bf8aa7-b8dd-4513-997d-7ad3eac4e0c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 139", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6341d143-74f9-4eba-9dfd-009c61279f0a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 275", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("63c178c0-daa9-4273-a3ce-aa9f97df4550"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 124", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("63f76c77-068b-4d9d-88ac-f8e41645151d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 425", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("64535bdb-f7b1-4798-a0b3-a2adb071d30b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 456", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("645da69e-5fed-421b-a43c-a353201756f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 323", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("64717b2b-5164-41c8-8ebc-c1f63ef38107"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 249", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6481fe21-bd77-4d36-b035-29e40ee6d181"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 270", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("64bb9f0e-f9eb-4ce9-9ae9-491be2d1d84e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 95", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("654addbb-4882-462c-b60d-611d1ad1b245"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 9", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("65788441-0e8e-4627-b683-f8b993ed3085"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 185", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("65ec186f-a572-4952-8575-2279baaef267"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 183", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("660a40ee-4001-4882-a0a5-25d44917a16d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 112", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6624c056-842d-4d5e-92d4-90b6af644085"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 39", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("662b42c6-23ec-4e56-a74c-ba26f532943f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 328", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("66508fa8-0a90-4521-a9ab-300fc58f78ae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 470", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6769c2b8-2690-4ce5-b4e4-5d1e3c7c9295"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 474", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6772188f-c215-4701-a864-7d277ed732dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 260", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("67d1a155-f3bf-44c3-a2a0-a014673101c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 64", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("67f183a6-fd4a-4835-a8f1-7579a511a355"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 256", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("67f48f6b-918c-43c6-a47d-3973ee8a3460"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 85", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("67fa816d-1559-4b95-afe8-7a334e8bcf3f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 29", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("67fc55d0-460e-4927-b982-85d8ef587e3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 272", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("681a87cc-5900-4a2a-937e-07676bf1867b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 154", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6860625f-09bb-40d8-9e52-b6b0513e0063"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 171", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("686305ae-c210-42b8-abc7-d65cb0ceb626"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 219", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6873390d-186a-4083-953c-cd316cfb5676"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 121", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("68a31e0f-2e73-4509-8720-86c4388a9455"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 113", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("68b933e0-4693-4770-844f-172154662aa8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 310", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("68dae8ac-6234-435b-82f0-b570464ff555"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 307", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("698dbe23-f06a-4af9-abeb-8c0f2f951861"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 151", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("698e39c9-6b29-41be-8b09-f27aa68e12cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 74", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6a2ac54c-9be0-469f-98d5-d84b7939b224"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 458", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6a5dd9d3-35a4-48d9-93e3-222f3a421b8c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 289", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6a696955-a4c9-44d3-abba-e640de0ca36d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 295", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6acba127-b021-4c1b-95ae-963913814fdc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 248", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6ad4624a-1e45-48d5-a10f-a96a7a02ed67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 162", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6b5b8fd3-b41a-407c-80a2-3adb255770a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 188", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6b751c1c-79bb-4750-8269-f8fc95d6faec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 463", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6b8afca6-3709-456d-a78a-736c8cbd9e20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 128", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6bf18102-3f75-4f72-81fd-88ed81207a9d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 66", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6cb27303-b777-4490-9ccd-90b3971f2f42"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 365", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6d32633c-5e3d-438b-8265-e6580480b109"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 157", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6d54c2c6-42ce-457a-b466-8e64052a80f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 371", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6d604969-7160-424b-917e-ad75058ed6a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 368", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6d66bbaa-006d-4f3f-af4f-59ab3e6be40d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 88", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6d670424-ad6f-4f5a-a439-f31c08bdbb1d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 418", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6d8471a3-7513-44e2-a578-318078146bff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 238", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6d8e0c0e-1451-4e86-8b0c-0ecc89e1b3d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 224", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6d93633b-d493-41b3-9017-5258263e7896"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 61", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6db52fe1-f314-4f01-bb3c-29b699201a2d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 233", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6e3c678d-0fcb-49b1-bdc8-b96f687c0b6f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 236", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6e668079-3114-4f15-af6f-956048e3aebb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 327", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6e9aba07-cd75-433b-b330-726ea28c46a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 312", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6eb63d56-becc-40e0-931a-f33f916465b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 209", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6ebf1069-1323-4e16-8768-f984966403f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 378", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("6f7e45e7-d110-41f7-b4a1-52bfee5ccab3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 76", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("6f8d250e-ddb9-40f7-9ab2-a28136066fb9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 322", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("701d79ce-5028-4eb5-8d13-846afedd284d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 435", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("706f5725-3159-43f0-a87e-b63d161e949c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 6", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("70916be8-9e22-490e-bc11-087b0842424d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 75", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("70b2b31c-b25c-4d0a-b02e-7501b591e4cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 354", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("70c4fabc-e8b4-4d8f-9f68-ef6fabdf461e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 210", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("70d507db-e022-4d4c-b38a-19296e6c8d3b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 294", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("70d6ec2a-f87b-4715-b4d5-9d840714ff64"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 22", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("71ff24b6-9592-49e1-ac42-7b46c303bcb3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 273", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("722f2d8b-dc54-4d60-8f11-8c87ac48219e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 216", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7243f90f-c355-4c3e-87f8-94ab6239a166"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 163", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("72579e93-c14f-484b-bad2-5345de92ed56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 328", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("729f1ff6-407b-4c5f-9513-4bad2f6d625c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 287", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7392cbdc-31ed-4b89-8f66-44fbe25af0ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 249", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("73d6de60-3a57-4358-af1a-229fe117b0a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 452", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("742ece5b-2fc8-4ceb-a0e9-fc2bee8e173c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 101", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("74391f4f-4f7a-4d08-bde6-58a7f7a10126"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 90", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("746289e3-9fce-4eed-b338-01ce0ef3c826"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 39", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7472e006-4e99-4fec-b543-986eee9715b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 219", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("747f22d2-af75-4160-8d1f-66077fecf1fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 3", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7488e7ac-eb7e-446c-bb3c-2e1ed74f59cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 111", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("74b2d791-b67c-4a05-9151-37a8fbbc3e3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 142", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("74b8e554-e863-4e8c-b17c-f3d04a2b4f25"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 83", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("74ef9879-b1fa-41ab-901b-0822f2422085"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 37", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("753436a3-80ee-4005-9603-301770d9e38f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 470", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("754c0906-b16f-488a-b90f-78c38fe1d5af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 133", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("75e8c7d2-b6e5-48c0-87a5-dbf536d8dc88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 231", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("760e8541-ce5d-449a-9b4b-237f1ec20b25"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 350", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("761e0563-fe40-4f63-9179-17cda6dd47ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 500", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("764f655b-0b46-44ea-8b2d-c1479f69ba5b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 233", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("76598eb1-b903-4215-abd7-eca6144b7b9e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 76", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("770a3007-4e75-4057-812a-90a565b542f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 262", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("77643d35-5e41-43d7-91c1-6a7cda1b4f52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 169", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7772bda7-2a1f-46f7-8101-1b16860d19f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 161", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("77d15531-374a-4547-87bb-368560f69ee4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 57", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("77ea80f8-9fe8-4151-85e4-ded7b2e6709f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 480", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("782b552f-7673-4e22-8181-189c7618595f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 77", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("78506f83-799d-4390-a821-a62af316d6cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 475", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("78af02fd-7532-453e-94ea-fe4664b0c2fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 443", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("78b03b50-90da-4945-aa96-7151dd6dddd1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 205", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("78e284f1-8ab4-40e7-9fad-764c4fd1ce8e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 240", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("78ecf3e6-b674-4779-b990-36be67c82c26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 491", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("790bc174-607c-4ec9-88a3-a73eb582c592"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 104", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("792b7a91-c391-4123-92ae-5d80267dbd3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 19", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("793221ce-dace-4822-9699-1ffdca7520ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 423", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("79757e76-3a29-4b46-98f4-4ea445954069"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 438", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("797c98e3-0a9f-4add-8b90-99c6bda91b64"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 180", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("79c390de-5681-4afe-8422-eb5a151f4ad8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 355", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7a1b5386-7f4b-4023-a493-4cf7f5fee539"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 377", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7a32deb0-4a09-4069-8e6b-e24435ba640d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 28", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("7a56ce5f-b4ba-4f8e-869f-f3dd9fd3d96c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 175", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7a74ac12-775b-4cb9-9e33-7dd4e46a9d85"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 373", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("7b3b09c6-6e9e-4020-8aef-9e9b3929db12"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 417", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("7bff0a3c-3763-45df-81c6-284172d507ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 398", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("7c40090b-72f3-40e5-a9a1-93ba1699c6cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 121", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("7c83d10c-d812-4404-9069-9d244d9e4aba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 319", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("7cb0baf4-5a8b-4058-9c54-80b99519b758"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 274", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7d0144c3-5ad5-41eb-af67-414565a0aa6c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 156", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7d21768b-7c44-402c-8da4-61c5051927f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 490", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("7d379c65-1489-463f-84b5-3e2e374a4637"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 286", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7d5c0ecb-e498-42c0-87e9-71dace9efbe4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 474", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7d81ad6f-44c6-4582-8c4e-2369a20fac77"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 445", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7d855d0f-04f9-4e12-af14-9f0d932a6d63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 366", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7dd5a9e2-b09a-4bd6-965b-a79e69a682cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 468", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("7ddb0754-c683-4698-b0c4-1f3d1535391b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 4", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("7f7878fd-6aa0-4553-99a6-b1c0c957bdaf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 4", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("7ff64a69-3043-4df5-b8c9-005628221331"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 346", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8009f735-d1d0-495c-87dd-e8f845479386"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 33", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("804e5d18-f251-4c81-af99-96a1898b461d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 234", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8060bd5b-d0f3-4d4e-8a0b-ec823b15e21d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 301", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("81134a13-3b8e-41bb-9f36-2d2508419cab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 45", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("813d8a69-de99-4c97-a4fa-c6729ef00499"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 213", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("82267998-204b-4b21-833f-b25355d0d098"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 257", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("823aa810-cb48-47c2-a5f7-b9da4d677480"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 178", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("824ad8f4-a857-467b-83fc-0dc20fb6f6e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 420", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("825b8908-68de-47fa-a362-aa9abfef94ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 380", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("827f7b73-e874-4f13-9648-ac6aa05f0db9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 211", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8288b2ec-843d-48d7-bb76-6283c3061868"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 32", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("832c9323-0246-4c34-b6bb-3d77483ed24b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 5", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("832e645e-40e4-487b-a18f-5fb89b4df0db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 38", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("83e0a773-5393-4ecd-9c27-0268e2cb5f9e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 330", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("83f01dbc-3e50-4cda-8367-fe0e707e1a0b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 153", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("83f7f8f5-0d9d-430d-9105-a21fdcc163b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 116", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8419e28a-d135-417b-9b90-f113bbaa01dc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 30", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8464c868-2059-4def-a611-eb6860d63175"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 43", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("847d0107-70ca-41b2-8d30-010228e9575a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 58", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("848f62b9-98e3-4a8c-ad26-d9d046e8b4e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 51", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("852825fb-265c-4801-a100-c865b1561dfb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 440", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("85756f67-20d5-4d88-8dda-773e7aea6c23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 301", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("85a9bc20-73fc-41d4-aca7-00306a510265"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 29", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("85f84ee5-278f-485e-b499-9ccb4a5e4b58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 85", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("86473d27-5a29-43eb-9b6e-488a1469a8a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 347", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("864d978c-9853-4814-ae22-cf2e5f84df50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 164", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8694b830-c5e2-4154-b57f-0dc9aeb6f239"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 327", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("86973314-9953-4a85-9f62-9fb4f58de0a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 52", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("86e7296b-350c-4f84-bb35-3921f8a25a2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 171", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("87369616-7aa4-4ff0-9a47-32e2270b6310"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 457", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("87757e04-e80d-4b04-a7fe-275cb3367387"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 476", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("87aa7167-acd8-4d29-9294-281176c29afd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 253", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("87e372cd-1656-403d-b218-70f9f812ce18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 201", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("880eca98-2e96-4e14-8f1f-c6c25cdf0475"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 89", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("88345b4e-40a8-4996-8728-fd4afda663ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 338", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("88587df9-7f86-4127-b10c-b51fc28355ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 70", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("88a442ed-66fb-4462-ba67-ea11007b160e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 386", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("88da7978-b795-441e-8ad7-d0b59f1b1a77"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 376", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("88e72e6a-394e-4ed5-86de-3bd0142ec9f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 78", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("890b7346-079d-4c19-a106-f81bba47acb6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 381", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("894c15e1-ebc3-41bb-8ed6-c9b33638ee71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 201", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("895c1014-832d-4bba-99b3-d9c3dd194768"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 129", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("89c35789-2cba-41e0-a9bb-fec1b366ad63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 269", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("89d8fa54-34b7-4905-a180-1c4e9bea184c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 187", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("89e15ba2-62b4-4fb0-b3f6-452903e001db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 454", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("89f4fb75-8c33-4c41-b278-09614747729b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 306", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8a2923ce-06db-4f27-8210-7761d66e5fe3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 53", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8a3bc9da-acb1-4d71-aa89-13dc3ef4bb05"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 96", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8a5c3d1d-47c5-4a25-8ed4-ef3694e7240e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 10", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8a69b35c-adc7-4fed-a8fc-48871ef23856"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 499", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8aaae46c-609e-4cfa-9644-93d204de06c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 382", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8b2d29e3-b93b-480c-9f52-b5e252a67e06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 408", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8b3a9543-ba1f-4234-aeda-ddabab2ec489"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 305", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8b5619c6-159d-45cc-bcc8-5ea8976cc9d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 179", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8b6326b7-ae15-4c3e-8923-7186eac5bcab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 449", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8c0149cc-3929-4002-be2a-c8cfa90e6433"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 372", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8c2ec0f1-85c9-4793-90aa-e3100ec19430"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 69", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8c62403b-44a8-472d-bff5-8de908eb3773"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 46", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8d294330-e1ba-458b-a301-c4932f30f281"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 440", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8d3ee51a-2a49-4cd8-849c-5ef83a6c0ee4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 498", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8d4c609d-5fa6-43d6-abc9-58af2019c366"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 241", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8d8d8f71-b532-43bd-9355-eacb2c528447"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 8", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8e41f631-bc38-418a-9cd5-6f3b79bdc076"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 349", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8e4831c0-a139-4480-b912-81b9a7f0bbc7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 355", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8e5a404b-e32e-44d8-ae1e-60d5204d368d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 134", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8ef6dd65-8bfe-4ff7-a161-46af04646228"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 498", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8ef9cbe6-689c-40a0-b59c-acdec90939ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 357", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("8f003a6a-e27d-4153-8962-97a490c1bbd2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 480", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("8f038bee-b8d7-4831-be9d-4019c4a332ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 65", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("90281c4f-d14a-4817-85f4-9a517b406604"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 239", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("90492569-d473-4a00-b6a7-d70600f50c08"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 94", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("90585357-47e7-4987-9a41-ed9559e4a03d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 192", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("91386eec-1a21-4a1e-886c-dd4bc72635da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 402", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("913922a2-b5de-4415-90a9-41de3162a2f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 298", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("91a83df7-eb75-4e42-8404-ece7b40e2f4f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 455", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9200459b-f821-41a6-9f07-abc2a540336c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 394", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("92a32ac0-42eb-4ea7-8721-11b46f116ff8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 338", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("92bc6556-1a28-45d9-a7f5-3921c7825fcf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 137", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("92db6596-c74c-4d2b-85a5-0f157c38f923"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 73", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("92f0451a-5cdc-4a65-be82-3737b7553050"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 283", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("92f878d8-16ba-4a89-b2df-6d310a59b083"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 143", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("930c40d6-5fae-49d3-b869-1896d83db0f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 111", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("937fdab9-0fda-4e0d-bf45-81d444a8efee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 392", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("938a765f-77a6-4bed-9b84-59b1d157800a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 486", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("94061dea-3593-4c5d-b2a7-a02082f4ff5b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 409", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("949ab859-d407-4f2a-9357-c38a406c3340"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 261", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("94c78bab-6d23-4c4d-b6b6-225c9dbfe3c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 433", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9546eb63-8957-4f82-8208-4df6b2b56052"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 349", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("956f898d-cdd3-4fee-b658-1e425bc63e66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 314", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("957c5dbe-8219-4962-bbcb-cdd72d20e670"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 466", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9595878e-926f-4fee-898c-307cad305478"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 422", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("95c3d42a-7cda-45bf-9744-fa05a1d6ccf4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 231", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("95dcf949-f6ab-4e1a-bb45-8ab60f28954d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 277", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("965092b8-80d6-4668-9f07-0fb9e01b3ef5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 228", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("96c4f1b1-3096-4422-80a4-a0005e9fe8e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 487", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("971bcf81-418b-4370-9d77-10138f9d96f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 268", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9725fa7a-dd45-40d3-968e-36b93be2fca7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 90", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("987d3c47-5a47-4854-b56a-4969a1a98435"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 404", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("98bc5689-d259-4f5d-8de1-1f92bc0e2fe1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 130", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("98c1f90a-c967-468f-ae8d-6da451eae400"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 63", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("99759cff-c97c-4751-b35c-1c607ac10487"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 77", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("99be9181-9eb8-40ee-a3c0-1f94452548eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 229", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("99bf284c-a6a9-4e0b-9b97-72497c379f81"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 147", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("99c77f32-8c62-4bb1-aaa2-a0d0bb9831a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 352", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9a0fbaf5-9f0d-431c-a332-d18ee27d239f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 324", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9a224193-6b6d-4b63-a895-2dfcef2bc70c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 196", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9a50641b-9a81-4607-adbb-82254df609b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 142", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9a5ee6cf-8ff6-4411-85e5-95b37b63ca2e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 17", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9a7033f3-a3c4-4bd0-ba07-578cce943669"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 238", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9ac79a1a-21f1-4a4e-9120-68326383bd73"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 164", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9aeb49a4-426b-4c85-ae1f-340adff70fd1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 448", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9b5f35e0-68d1-47e0-ae13-307d0a06fc67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 433", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9b8fcfec-4ce7-4668-8dc4-30a32a2f47bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 287", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9b9c1781-d639-417f-b9db-b07d06e06feb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 97", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9bb5b6cd-460d-4ad9-b648-1e6b3b11c84f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 303", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9c3722a5-cc34-4dd1-8e43-ff93479e7112"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 176", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9c8062b5-2454-4f63-ae87-6d2b5c8d18d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 212", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9c8e6cb7-e0e1-487e-afc6-7208894f2156"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 179", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9d3e7640-2f86-4de2-88f3-e16c5298dd50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 151", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9d6453d0-e0e0-4f04-9b2f-70efa6e386f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 290", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9d8873be-345b-4099-8ba7-ca0326582a3a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 187", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9dcc0c56-3c54-4aed-ba37-646525e38d89"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 107", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9e0ac68f-391c-44c6-ae8f-99ba9b8aa444"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 112", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9e3e3eb3-f33d-4fd4-aa5d-25bb5cd9b2c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 59", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9e520cf5-ff3a-4b22-8bd3-3a132f65edb5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 26", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9ec4cbc2-bc21-4304-aa2d-a3bc2886160a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 14", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9eddd749-854a-4e4f-9d43-ccc56e61c8b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 390", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9eea30d2-d7c3-4f3b-a160-8432d38190f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 384", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9eeed777-4372-4fa5-9e1b-be54af6ad80f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 292", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9ef36432-82e6-46da-9b4c-49da28035f5d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 478", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9f0a8345-d5d1-4200-881b-4dec8da9dda5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 24", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9f3dd60b-fbc8-4990-9b46-cdc8802b6fcb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 92", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("9f56f9c9-2aca-48d9-b5d5-01369ab943fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 283", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("9f97c47f-cc8e-42b1-9ff0-999806422d44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 208", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a05b8419-7bf6-4146-8ef6-3554d0c1ee81"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 217", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a067dcd1-ae0c-422d-a492-9b44fa94445b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 99", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a0990f1f-201a-4a13-aee1-9628619f929a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 60", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a10edc83-498d-43a0-aab0-bffc1f913ad9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 377", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a11c98af-cf6a-4178-a9f9-76edaac5116e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 339", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a16acc99-e82d-4e9d-8a89-2847e2b29292"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 431", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a187d31d-ff36-4455-baa5-39198f28c50a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 299", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a19876cd-058f-4c3d-ae37-35ae43437f4c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 243", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a1c6970d-aaa8-478e-8356-3540841907a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 127", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a1e49647-dc4d-41ae-ba6d-cedf9acb0127"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 9", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a2260787-9a26-4f5b-a854-ab4af164a33f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 387", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a228c8eb-f02e-4689-802c-927399b9ec01"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 12", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a26a2283-d7a6-4161-921a-ae44e11f5718"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 358", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a2eb4346-cd52-4ae1-80f8-0f761077d784"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 216", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a30783db-eed5-477f-b25b-6e15fadf71b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 346", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a348e98d-94f4-4265-9fc7-70c2ce926e41"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 425", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a34c8e13-8ab8-4abf-94fc-2a27600f7285"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 141", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a35903a3-c9ae-40f1-8de6-370dadea2d2a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 235", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a41d3bbf-754f-4529-8078-fb09d1145fab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 165", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a421c681-23eb-4971-b9f5-742363bfd100"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 446", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a4e10f7c-5108-4550-8c51-475ab6f0b267"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 314", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a5337512-d26c-45de-9944-5f3583a26872"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 135", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a55ab458-6a9d-4d22-8953-9fa797c0de9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 10", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a5bdcb9a-6ca5-487a-8fac-3b32be0ab39c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 401", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a5eb6221-5fa0-47ad-bb96-3a50fdbd87e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 341", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a627ca77-e943-4aee-9946-b155689d9fdf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 347", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a69877eb-4e12-4be4-814b-85ea3f46b273"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 447", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a6e3daa4-3377-490f-b93c-a1f6b603f685"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 68", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a7bb153e-c93f-4e22-83fc-63d7da038754"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 254", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a7eacc61-c511-43d6-87d5-c178a7a69594"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 368", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a822c3cb-7660-4f22-9273-475bc4d12cb6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 385", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("a841a459-1b8e-4e36-9b36-9883ffa92137"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 131", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a8921f95-2226-4675-a0c7-014e9f6a6ae1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 393", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("a936ba3f-6868-453c-9cd5-038a3e6a7359"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 266", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("aa0f2c72-daea-4bc8-87ed-37ff8eb742e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 36", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("aa21a8bd-bb7d-4224-85a0-3e073edf1dd6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 246", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("aa481c25-d326-4587-992f-a4f16de50ee4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 2", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("aa614c2c-e537-4dba-8f11-f4fd1054508f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 47", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("aa8c1a06-d206-4269-a2ff-61d815452ea4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 193", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("aaaae57f-c29a-4724-a541-da82be423b74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 300", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("aab608d4-076d-4ee9-937a-203c83d9c6c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 218", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("aaf5142c-04b1-4c86-a13a-1d6741d985a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 369", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("abb31163-ca7b-4ea4-9610-5ddecf27ed09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 360", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("abc60378-0c2e-4f61-bcca-6ee286fdf903"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 302", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("accb3742-0e18-4522-bfb0-8a7d6ff453f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 344", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ace315c0-4a4b-4909-bea8-445aa8affc19"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 427", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("acfb8d7d-af08-4cd5-8107-d2fd53de3a33"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 358", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ad2c0443-2158-45de-b1e5-ef0edbcd86ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 387", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ad532ad3-5b86-4348-b552-d22c654e67ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 380", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ad55c297-d982-49ed-b5d7-1edfd9500678"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 315", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ad59fee0-5818-4305-83be-218592677e9f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 297", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ad8e9b2e-1861-4671-a80d-58a11bcc889d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 396", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ae3d0359-6ec3-42de-9e98-d1cdf89a54bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 158", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ae43a682-093a-4fce-894e-b6883f81cc09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 97", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ae74f746-d4f1-4279-abf8-911089e4bd7b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 14", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ae9a1dff-ac3a-45c4-9752-3e705e4e8b9f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 169", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("aec89d79-b691-497f-9b71-4a248d51be44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 149", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("af434dfa-a72e-4c71-9448-4d0814f951b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 162", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("aff99396-ea8b-4061-947a-fe6fad58762f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 362", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b0e5f097-2df6-4762-b959-ee50d4e7a2a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 499", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b1364475-2dbd-4b0d-95af-99aa20ea5f4b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 45", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b13a830f-b7d7-4ee9-8432-21f780238e43"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 386", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b14a48bf-9995-4575-bc02-4b205d2c4b63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 430", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b1bde9a9-107f-42ef-9fa8-c6e3a13a3bfb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 54", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b1be3a53-b346-4588-ae83-22e4439c977f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 52", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b1d98621-6306-4b6c-807f-08305ba59b32"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 331", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b2360490-5c09-4535-b4ea-159c0c37b4cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 34", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b290dee1-59d1-4de6-bf09-80ce8722d738"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 189", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b2a10028-35ef-4b26-9dda-c26019f4c357"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 428", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b2b730ce-2fdb-4c17-b3a9-2a22c2f8390a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 484", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b2ddb9e4-6d4f-4374-8036-781f5c716dda"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 50", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b31bda4c-ea25-41f3-9a60-332f8d9112b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 72", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b33274d1-980a-444d-b0e5-8df95c08a4af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 170", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b34e16dd-4995-43d4-a4f0-294578dc94f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 375", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b3d509a7-c651-4b1d-934d-6ea6eb05167f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 40", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b3ee7e1c-af73-4f7e-8a36-a4ebf49a7912"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 420", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b48f331a-96b3-4272-aae5-eb73b229380e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 247", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b49ac14c-6be3-47b4-96c0-878c2eda5ccc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 250", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b4ad56d5-1634-4e1c-9021-bbb100e52fb6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 490", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b4adeec3-c8f2-4af0-9ecc-45ee18022e6f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 15", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b63ab56f-01a1-48a4-b683-19a2de71e42b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 282", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b688b1e0-10fc-44cf-9865-2e4fb6a3d3ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 455", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b6da6030-a462-4a9d-b36c-1f3a445056e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 446", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b790e982-e370-4891-af72-697f0703a805"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 230", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b7d3826a-9a1f-4e9a-aaa3-860d2ed5a530"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 252", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b8108a9f-3da8-452f-b2d8-7786151c93d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 32", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("b8298253-8a7b-47f5-9b48-0838bd717c70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 399", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b87108a4-af29-4557-86ee-841cafff3811"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 75", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b8839b29-74ff-41c2-ab58-fd56a938e30a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 423", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b8b6596a-5691-45d2-b8cf-f8672c66bf63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 340", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b8eea389-be7d-481f-9984-d689fb360304"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 416", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b8fc98ef-c6ba-481d-b0ba-6161d5adef5a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 59", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b94ad3cf-545a-4970-a4b8-cbc55c52285e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 439", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b972d571-3424-492b-af33-62590838e9e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 383", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b974b043-111f-468c-bdd0-b3fe41d95c04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 184", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("b9c9d1c7-eb36-4d0e-beb6-bd601d97a32e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 465", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ba0e32e9-630f-4723-94d6-2fbfa802e2bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 337", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ba3f9e95-579b-44ca-88da-198b5516de0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 351", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ba455e9b-e7da-4c03-b8dc-e4f1f245972e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 105", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bab9ad3d-ac62-4b7a-8860-79d9b1f199ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 379", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bbe31d87-7b13-4ba7-b735-e6813d977349"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 72", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bbe5209d-5782-4566-9f19-b8431c34bb63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 245", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("bc061894-a846-4d3f-b102-5fd384847532"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 207", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bc27fe1a-4121-468e-acc5-1474442f80d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 444", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bcc8575e-08e2-4276-a37a-4ac1a88878ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 42", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bd50d630-d9a8-4634-9901-0f0e7066cb23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 471", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("bd6ca768-837a-4d54-ba6f-9288656eb355"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 437", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("bd75d5b5-3716-4de1-841e-6b901b8cba86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 167", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bd7b0535-822e-40ed-9241-795d61ae770e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 460", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bd8311d2-1f84-481b-b9dc-565698f73d1b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 451", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bde0eb08-0015-4402-b070-653186595eed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 453", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("be672c9e-c31e-4445-8f0e-60efd2b839c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 122", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("be68dfb1-f193-4d2b-ab65-f3fdca5740fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 183", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bea3dea1-aa2b-4e24-838a-29187acf2fc7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 17", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bf7e1ba5-635d-4d12-abbc-1b66de21ec7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 135", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("bf86c748-1e90-40dd-9961-8f40bd720fcd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 404", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("bfa5d86f-10d0-44b2-b02c-2c64aee46d8a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 434", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("bfbb2715-d480-47fb-8222-3f810ea88716"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 439", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c032558c-93e5-41b2-8637-60ac717a2f0b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 134", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c098dd83-1a2a-45ed-a78d-bea4a549832c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 145", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c1030ee6-12d3-456b-b05c-bc1745a35a71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 389", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c110ac42-b8e2-4fc2-a2a7-83f580599245"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 316", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c1a76df1-6feb-4160-8485-e03b9b15978e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 181", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c21caf51-b162-4d51-bdae-d81a08cd009c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 78", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c229d4ec-5b5d-41b7-98db-8966924773ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 452", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c24e05f7-5f7f-4d6a-9016-4c319515ffb8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 236", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c2c394ab-1c97-44a1-9c08-1d6ab189155d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 48", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c30a2a9b-89c6-4bdb-8f60-632097683784"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 84", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c316d291-fb2b-4d66-819d-25ad33cf8def"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 335", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c375bb35-7539-44fd-a709-4a2587ee832d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 341", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c3ae87e7-a2cc-4e6a-930d-e2308563411f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 363", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c4ce88eb-16d3-4e68-865c-088ed7ce4c65"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 114", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c4f6d05a-f243-4eb8-8f5f-200c9a106e70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 173", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c4fb3eba-4cc9-468b-9363-d305aa81c0c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 256", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c5bc65f8-7604-4508-8690-a464dddbf022"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 127", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c66e0a74-7fd9-4b10-b240-39b6c9130eca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 16", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c68487d5-a497-40eb-a6a1-1c5b1250793c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 130", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c695f973-be31-424e-b8b4-466ae83b8855"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 370", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c6a61e12-2560-43db-98ca-c7519314c752"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 343", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c6b56ea3-833a-40e3-b5fb-648a634743d1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 53", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c6e974d3-b313-4520-9438-0f30e73de9ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 286", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c7338aa0-60cc-4af6-afa3-9694ab1ccc56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 253", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c7b903af-fe2f-4daf-841b-dc6080dcf644"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 401", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c7b941d6-89d9-42cf-8c35-cd7c16b1848c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 400", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c81948c5-c6db-4806-af92-0543dd5bce1e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 329", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c8386c4f-86c0-49d8-8886-a10ee19d3bb1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 348", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c8418b00-534f-4e3a-90c8-6ab30d0c90b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 74", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c88222ce-833b-4a4f-bc62-180f29e00090"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 212", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c8dc5a54-1693-4e36-bfb3-97bf7e09726b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 175", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c915ddff-224f-4428-ab89-8cd46786b0ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 123", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c934f271-74b8-4258-b35e-62b4db00997a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 371", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c9518e68-3770-4880-b062-a95452993c9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 489", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c95e1501-72ec-403d-85ed-393004414496"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 396", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c96dfc57-f57c-4100-8459-c241cf504770"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 93", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c99d15e2-3445-4c09-b833-c05db283b222"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 3", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c9a9bbef-fe83-4570-bad3-7ac3378cd835"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 103", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("c9b1425c-289e-422a-8490-09bbc1c8a271"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 342", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("c9ea4131-1786-41e3-b424-52a042766a2a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 218", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ca36cf07-ceaf-4cc1-b10a-789b88500a52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 207", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ca3c2b21-d664-4bad-a78f-3db5b2b3a17e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 345", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cb05bb32-b05d-481a-af15-74e471f9a2a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 204", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cb346c96-441f-4dc0-9af1-8cb56a58ee82"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 247", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("cb4fc063-77ec-421a-9237-c64c49075347"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 177", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("cb5aa4a3-ee58-4116-b1ce-93146850ec32"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 199", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cc16a812-0109-4489-ad65-178b77386d76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 264", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cc7d238f-ac85-4caa-8724-a0469e2fcba2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 353", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cd876f00-91e9-4cf5-a2e6-1d04d70b8a40"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 330", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cdc1ec42-82b4-4523-98b3-4af333e34799"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 154", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ce26bbd9-04e7-4b18-a0b3-4352ba3e6d8d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 419", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ce59a80a-763b-4031-9b9b-0f05e20677bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 389", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ceb1c8ba-930a-4dab-bc6e-58e814cb491d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 106", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cf5d0beb-eaaf-4be5-9326-8e94a11234b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 174", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cf823d84-5598-47a8-bc88-1b01669e6810"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 284", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cfb55013-6189-4e63-847c-567bfd2166cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 366", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("cfe6278c-1cfa-4c2c-8c04-b61fac3150c8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 272", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d0164845-a4b0-430c-9094-cc8cbe15a16f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 38", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d02af5a9-bf4f-4e43-b4af-92af58989477"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 310", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d0a0386a-7026-49a6-aa7d-310db572d284"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 370", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d0a7eb5a-2290-455f-b463-04e9d3f7e81f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 288", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d0e3238b-fb86-4096-87f0-1c7117cd71d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 120", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d0f8d6f8-1d42-4745-91fb-d8d0e9ec36a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 492", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d161daf9-ba85-49eb-9869-9af37bf11497"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 223", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d200d4a9-5b14-48ce-9451-d3f767b29f43"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 462", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d2115020-1b05-40df-a266-90b3162e4fc9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 285", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d2686cc4-abac-489f-95c3-1f7f440c60b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 441", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d303f9c3-0731-4f71-8f76-d6de111840c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 306", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d51b45d7-2c3e-4d27-9f95-37f91e563878"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 344", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d5293860-ebde-441e-a6f8-0145a62f4288"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 300", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d57e3163-2aac-4ae7-9b1d-ddb5498be105"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 311", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d5acbdb8-4c8b-4845-879a-06640973d041"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 150", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d5c88882-0110-476c-ab19-7aeec2efbdcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 0", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d61e785c-5b25-4a0b-9026-e62929a7cf03"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 84", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d6cb102e-1f2c-4ad9-ad9c-4773ef548104"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 57", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d738910b-f214-4934-bf6e-874f6ec59cd0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 492", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d787a2e8-8319-4f24-86fb-22b5f4c12c21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 357", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d7a43feb-cd35-4c0d-902e-77da85316de8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 426", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d7cd5b8c-4d27-46a2-addd-09a35e13d8e3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 123", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d7f2a34c-3ccb-4ea7-bb66-d30168162f14"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 173", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d851aba2-c9b3-49e1-813b-1e1eca4bb347"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 424", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d85c7f3a-e7f3-4a19-aea8-03cd6f924575"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 397", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("d8bce624-89ff-4541-9020-4490c9002755"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 447", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d950343b-5d77-4bf2-990d-94065864b0e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 138", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d9ae3f61-c668-4959-b24a-d70b661b8c00"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 489", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d9dea28d-d2b9-4f13-9449-d5367b394936"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 261", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("d9e183f4-e462-4a8a-811c-18b8cf224f60"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 248", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("da25cfa3-fbd7-496f-9480-24de789da872"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 91", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("da27eed9-b928-43a4-b376-14c91cf7a8a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 22", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("da6c6b71-4832-459f-bcb4-425bc327a055"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 28", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("da92a78e-c0e4-4417-9b93-34248b9ef70d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 109", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("dabfabbd-7b79-46d1-87c2-97c863e54d39"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 406", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("db395de1-f24d-416a-9de3-982795a04e8c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 260", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("dbc98fdc-1524-4eb6-8dd2-14a53094b045"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 119", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("dcacd089-31a7-40b4-ab74-bb5b0186b4fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 94", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("dd3cc0ac-e7ce-4bbf-813e-dc9c6252ae9e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 21", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("de9a3290-cce4-4920-a35e-c3f164c83287"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 449", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("def21afc-72f0-41aa-81c4-a10a26997d0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 359", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("df9bda85-68bf-4258-bbfc-2032f84a86f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 438", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e02e4715-4e5e-4b95-8831-ef7085b223b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 35", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e02f004f-8daa-4bca-bb68-9b6d850d7b00"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 190", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e034f68c-71d2-4a7a-bd41-00547eff5a09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 365", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e04e1e42-6bd8-4d04-beff-35f2c8e73c49"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 225", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e05855c6-a9f4-4cbd-8c8f-de707e0bf09b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 435", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e1425c1a-ee81-43f2-9ef3-2d6a00177ba7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 140", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e29c7b67-9386-4e86-97bd-060d8470f62c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 221", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e2addace-7b73-4e9c-8035-c1eecc87e91b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 263", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e3354e63-bca6-437b-b7c1-e5970de687ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 186", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e349ed9d-2351-469e-8034-ec1848364559"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 483", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e3b2f9f7-fd6e-4a58-afb6-d8ec4ab3ce79"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 194", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e3c9bf2f-9622-4d7e-920c-5cc83cc03508"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 340", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e3e4a4f7-f1c0-4846-852b-e2202e3601ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 117", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e468d808-bbfb-4e7d-a5e0-bf2383795b94"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 31", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e46cd9d3-f4c2-4820-bb6c-d4fbc880a67c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 64", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e4729cb5-fe7e-4c31-9bba-4a1c2178e70f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 156", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e49e3f26-ef5b-4801-a1bd-6d62dd40937a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 81", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e5603cfe-3dee-4374-ba4d-3deb2e7ce4ca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 62", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e5999a6c-e135-4562-8ffc-8e5709a5ce74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 271", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e5d99bff-a8f9-4dd7-870e-2fb2bc18d8d7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 309", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e5e1a79c-8abb-48f1-b4df-3d7227009dc5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 89", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e5f78449-4211-48c7-8020-d766ba534324"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 100", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e6521083-e699-4f84-80cc-04ca4a881b5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 149", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e6eb8e55-a052-464d-b26d-cde3d734d384"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 345", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e6f79e48-cb8c-4eb0-9ddf-ff74b1923737"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 182", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e72b9d7c-05fe-47c7-8808-0289356a9931"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 276", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e732d90f-11d2-4346-97dd-022537679393"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 202", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e741cc16-90df-410d-aec0-7965b6a5c5c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 118", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e763ad53-953f-4383-84d5-c00b41f7216b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 478", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e78d78ec-bd79-45c7-9ae3-7faf8bd1ae4b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 172", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e7b2baba-f3e9-4232-b05a-4451f11e324c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 18", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e7f4f226-ae88-431b-9f39-5a21d390349c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 185", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e85c3bd4-7491-4414-9d04-9b40f73e568b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 329", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e86cfbf0-7900-4b9f-b0fd-afc6c0d26c29"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 298", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e8adb4e2-a1fe-4077-9e86-d372b59bd1b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 87", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("e9061f1f-909c-4aff-959b-e2ffcc857410"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 118", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("e95f2824-d64c-4424-8c0e-922047ec9304"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 240", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ea243459-76e4-4db3-9474-c194eac197f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 406", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ea4c6a4d-711e-487b-947d-e7110a49b720"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 288", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("eaaaa234-72c2-4626-8c18-84274f413c66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 467", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("eacf71cb-aab7-40ad-b30f-402af5e464ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 421", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("eaed5975-d98a-47a2-a68f-1fef7a07b01c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 457", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("eb134e32-fb2b-4ef3-b554-90fcd4e034d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 268", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("eb624b43-ab49-4d63-9280-b1dc9aefd6f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 241", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("eb7e0d34-13b3-4f55-ab28-1c248777a9c4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 360", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ecbaf104-8e17-46f4-9969-e666dbc1e48a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 202", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ecf7c3b3-e1d4-4124-be82-19ef27542995"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 21", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ed21c60f-75df-4807-ad3b-3c9209329f9e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 80", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ed25127c-aaac-44d9-92c4-5938ec3bdc11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 273", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("edca706b-ae46-44e5-8f71-aa053bb3a98e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 196", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ede42a37-5550-438a-bfa3-fb561d553631"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 244", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ee54af97-3d10-4ede-85b8-2594ada682e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 120", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("eeae2644-60c6-410a-b9cb-4bb9c3b6aa2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 462", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("eeb513ff-27d8-495a-866d-4468e32f8a0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 353", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("eeb936e7-b053-40e5-b0d4-2a1a9e079818"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 384", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("eebafbd6-37bb-4efa-b882-c96029ce0d30"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 195", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("eeeddad1-2752-428f-a5ba-071a33815a19"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 388", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ef6edf58-2795-4e6c-b0d9-0819fc35a07e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 108", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ef9ada48-ea54-4cc2-818c-48c8f8a52799"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 205", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("efabd8ea-2fed-47eb-84f3-2b82c759e2fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 23", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("efc9b70c-8474-4be0-8cf1-bce7b0b079ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 31", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f01964ae-2ff9-4393-a567-c31a1a370fcd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 186", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f09099bc-4127-418b-8432-f380ac3fec1c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 125", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f0e86abb-7381-4eff-809e-8f6d47eb4d1a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 180", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f0ef0156-faef-460c-a116-95b777c219c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 110", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f17c6b51-a8e0-4870-9e4a-7f8c3b15811f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 321", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f1ed803d-97ff-4282-8591-d5fb0e3915e7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 41", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f2121177-2ca0-45a1-a087-6c12bb1738b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 103", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f2982f61-981c-4e56-82e6-f4f639284390"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 398", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f2e7a1b0-a9d8-4673-8b4c-30333c81bdce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 484", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f30c9944-a251-4c87-aed8-1ebc2d9d9d62"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 49", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f3227357-0a43-41e6-b107-1b87c061e065"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 13", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f34e6bad-0e0d-49c0-b0e9-1c4958f1f937"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 182", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f38ec80b-49a7-4d2e-86cd-4f6ef1181638"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 1", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f3bb7293-c4cb-4823-90c0-8099742dd146"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 414", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f3d3fef3-0a6b-4eb4-b0eb-8c30d20269fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 493", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f45a4136-8c32-4f9e-bcf6-75bac171ee79"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 68", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f4663579-087d-4eca-b7fa-d8cf1d3b9aba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 195", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f4acd2e6-9eb2-4767-9654-121461469d41"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 281", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f4c23885-971c-493e-8ec9-c4d0600e0e54"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 194", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f4cd1145-7934-4afd-8a12-2b5c10e97f78"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 496", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f575b846-976a-4e6d-b689-3db74879c560"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 280", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f59cf7be-85cc-4ba6-8e80-783562aaa791"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 496", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f5e962d5-0124-441d-a1e5-3202b62a4da2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 101", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f629a0b1-3715-4240-b0d6-1062732927c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 367", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f6341a25-4b36-4a79-ab6e-a3c68f96d6a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 266", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f6b77156-c019-4226-a3cf-0c5d384edf04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 343", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f6db9687-ed42-4e96-b3fa-a4290ce17958"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 148", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f72e7499-fc05-479f-b023-3e657e97a2cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 115", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f731d1b6-b3af-480c-9555-a7dbbfcbbb23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 403", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f78d8815-6ac9-44d0-bc77-8992b7a2b255"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 299", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f79a0d40-1165-47e3-992d-c51df6fcd51a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 326", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f8006c41-7487-492a-a836-87fae4247568"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 421", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f8ef57ba-d275-4ebc-bb3c-40e986e5e20d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 285", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f90906fc-77d2-46d6-902a-3f020a365e71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 399", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("f9528f8b-eef8-40db-bc1a-d02239bc6620"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 80", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f95b3019-c378-4a53-85ed-5a8c6844799c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 313", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f971ba19-cc0f-462a-8cc0-77ebf8d2411e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 412", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f99ac6cc-c145-4de3-94f7-02b0bddb7433"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 165", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("f9e21857-c005-46bf-9511-6c54ad6c9a7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 98", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fa06cdf3-cfdf-42a5-abee-151a6892e206"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 92", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fa111e62-1c2b-4f8c-8988-1c8e9e7549b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 321", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fa6b2191-019e-4e1c-9da3-2fc9b2366f6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 482", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fa81c749-de0e-402f-bfe7-0651166cd449"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 67", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fa8df25e-2ec4-45c3-aa9e-0bb6a1ff8604"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 181", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("faeffc8a-d92f-4689-8769-fe2d043da16a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 322", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fb119b4d-7b71-4996-97fd-378545dfffe4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 246", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fb128bc7-a317-43e2-87b8-a75e5c0453f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 58", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fb158926-073c-413c-8cea-dddddf1f60fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 445", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fb3f5aa6-3be9-4da6-9dcb-c304d0d39b24"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 336", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fb9b3267-ea04-4082-b2cd-078fc537b727"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 419", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fbdbff05-b205-4fef-89da-c0ee71ed8ef7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 198", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fc086080-0ca3-478c-a1c7-abef74b0e52f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 83", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fc0ef066-e42c-44f6-a78a-f71c677bf4f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 332", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fc349002-5626-4cac-a300-fce1765971ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 332", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fca97d3b-ff43-4dbc-a406-f6ae3d2aa78d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 361", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fd0a14ad-c715-409c-a17b-9d13659efb69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 466", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fda26d4f-5003-49e6-84dc-608936d330d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 161", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fde77568-31d5-4083-a4fe-034b81e49d74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 215", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fded1f0b-c39a-49e8-b5c2-d9255e3cabbf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 458", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fe0d2eee-a696-4970-9dff-a81f5ae3ef04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 198", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fe708fa6-dc69-4a81-9c15-7ac69af03205"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 486", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fe787d4c-6024-4fb8-bcce-d4606125df16"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 197", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fe96c2a8-5754-4b93-9bff-18949e868473"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 93", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("feba0cf1-dcb0-4176-a269-56d8a36845db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 469", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("fec35606-9071-4633-9ccf-2d7a3b5e7700"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 200", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("fedc8fe2-554d-434f-8cc0-e8ae92fb9ccf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 415", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ff010175-0bca-417c-a804-ba4eacecee23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 465", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ff4415dc-aec5-4e0d-aea9-9cda1125e178"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 105", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ff7f7273-a185-429a-b7d7-310034686b9e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 485", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null },
                    { new Guid("ffb2762c-a9d4-4b1b-a971-1af980ddcec9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo size 375", new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"), null },
                    { new Guid("ffcb1da3-097c-46e0-98fb-96710c76ce5b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần size 311", new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"), null }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("65065e9f-51e7-4ac7-bf42-5b78a17b2e58"), "123 , Ny, USA", "Apple", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123134", null, new Guid("d1690e3e-ab6f-49ee-ad5c-9f8fdefea063") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00137a74-342b-44cc-bac0-3af1c4c18ab7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("008b4f18-6b32-4e2f-865a-3512739ba870"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00c120ac-9b3c-42f0-ae4d-ea723cab4d92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00e9d9f6-0bf7-4db5-8b8c-725edc98f834"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00fcce88-129a-4680-a24e-46354f7bec37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01110b3e-8651-4e56-9959-8308eb75d938"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01317075-e3b0-4fba-896d-3481d4e56fb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01669cf3-fe3b-4652-850c-30de4e034f41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01b5a409-0baa-4fcd-817b-b562b7b8369e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01cb41f0-ae9e-4add-8741-d17a2eb440b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01d0369a-f378-45e6-98d3-c2959bd0ee4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01fb3d1c-a4d7-46fb-b7ad-6b14c51bc8a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02a69876-2816-4dc0-a078-472cadd636bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02af4ff1-c427-49fb-b447-d936fab3d1ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0383c9f8-f055-493e-8c2e-79084cee66b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03984af3-03e4-4ed1-99ce-1efc2d6c6fd4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03a3d050-1555-4948-af19-68dc12dc6125"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03b16d62-a592-4aee-9b76-d7466afcf920"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("044942e5-faaf-4775-b1b2-c28e41d20fff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0462a054-7350-42b1-a595-12d631ef9458"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("046475cf-831b-44ad-b852-aa6c841f4cac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04924bc5-bc4a-47c5-88b2-66688f73eb9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("050c01d3-e019-4f11-a5b3-68abafdcd672"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("056d6f0a-3b9d-4dbc-8353-48bb3192f282"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("058a3a13-b1f8-496f-85ae-fb380e0021d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06468e22-9a28-4324-aad8-e676c52f8252"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("067dd5c8-d154-474f-92d5-967db03845f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06c89463-c533-4dd9-8bc1-49661cb282c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07043b80-77ec-439e-a788-94f8afd0b1e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("071a07ad-4c6e-410b-967c-dd777aa33c11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07331899-528d-4e26-8d11-07f514740bca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("076c90e5-7a0e-4cd5-908b-f43222fbe40f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0790b282-d2c8-47af-bd43-51a070b376bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07a1137f-cd4f-48b0-a6a0-ddc3056a03cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07c45ef3-6714-43b5-88fa-0dd1c2d9f0c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0804ad99-bf31-401a-896a-3624734b0b48"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("083a0332-5fce-4334-9e46-e65ba564e266"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("085ae260-fc7e-4810-9827-400eced0e3f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08758f10-963b-4094-8bda-ec402ec18883"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09078b5a-b2ef-4980-bb2d-dd40d5e83dd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09137a96-09f0-4701-b53a-e448f17988a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0979abbc-0810-40a6-ac22-cca152a3a8ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09bf469f-a59d-4d0c-a2e5-97c0525fdd1d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09e0db66-917b-4968-8c91-b6c4d476a3c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a119c22-f976-48f0-a991-c5747abdc309"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a2a527e-57dd-4666-80c3-6539faf32dac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a4ea349-fe24-4727-ad6d-8d7aee6f32e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0af2a314-a671-4efd-a886-cf5e073ff801"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b1fda6d-2bd3-4fdd-a4a7-8aa2d6a34ff3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b4a1066-75d0-4a19-b94e-20811fd0540f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b81fb8c-1f03-437d-b4e4-79427917961c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b8d95bc-fc4e-446c-9c63-662654ce81bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ba4f72f-8697-4f4f-a86b-55feb750ea9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ba5f382-ca08-4813-be93-70a0c3574835"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bf5d8e1-fdd7-4ce6-bbf4-35fab3e93b0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bfde11e-fcce-4563-95af-dcf121b202b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ca14a6a-b4fc-466f-8f60-e156e7c63653"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d536271-d1f3-4bf6-a10e-facd4e04defc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ddf4d5c-2800-4de8-a71e-d7b6b88d2ca3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e26be09-905f-40d7-bcf1-23c3f46e5752"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f0d5a81-a83a-493e-96a4-e7be0c25d5ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f804c90-30c1-4587-b8d0-28b0d9c94478"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f9dc749-9fb4-4ae5-9725-a6c753f51037"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0fd386fa-c16e-4c93-ac15-6be77805954b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10758dbd-90c4-40be-bec3-2856d09a26d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10b16994-5a7f-4dbc-aa8d-d4e5cdf28f86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10cc9331-cc3b-43be-bf60-c3d0d2511ea7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11619b98-329c-4d6c-8cc1-279a945a790f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11713333-24a2-4dbc-b868-f2b7d510815e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11883c06-525a-4712-9bc4-068b5d608dfd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11922663-6b5d-4944-848f-bb84e50a7015"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("119c520b-64d2-4e67-b559-71ce76c3a7ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11c27d75-270a-47ee-ae9a-667e23becefd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11d372b2-ac0a-427d-ac45-1aa1e8bc254b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12313a29-83e4-4be2-90da-b38324ef0f04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12416938-753b-438b-8728-15f245a81b9b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("124ee6ff-7a88-43e9-807e-b90bd209d6cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1258871e-5ef5-43e4-95ce-e98ca42f5032"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12c05be1-bc4f-467e-920b-884ed964d361"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12d19d4e-b5d6-4512-b59f-33cd74955f3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("13c97dd4-9a46-456c-8f8d-9ec208f93322"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("13dd28c1-d859-4b78-a1b7-2d5e4d2d1af5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("142eee10-e701-48d6-b51c-d743babe29c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1443086f-bddb-4528-88fb-f797cbeb80a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("146f9d9c-8141-4517-a748-1e3352395db6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15418c6b-3302-4ad3-98b8-f37ce763b151"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1554958e-f77e-48b1-b380-7c23cacea312"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15dc6b94-9acb-4764-88d2-16a29cb9ea26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("162c0c81-a9ea-4d08-bb5f-266f5f94893c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("168b876b-e5f3-4d04-b924-ab9c96433462"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16f852e6-04c9-4173-951e-b81f9d2022c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17af6213-c9bf-480a-9117-8125f656bb8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18293b0e-d15a-41b6-972b-563deb5ba878"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("183b8f58-66ea-475a-9cab-4d7cfe83727f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18544b16-0379-471d-a848-bd0acc1d3c14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("186a66d7-f0df-4886-bb52-9ec625db9095"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18706c19-7ade-4fe8-964a-d75e4d0d1c22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18df1dde-7564-4a36-a4d7-2607a4dc5452"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1931ab5b-03df-46d2-aeeb-f3f0a866dc8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19b7c13a-0137-4ab3-b488-ae684ec670fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a0db0a3-dd8e-4773-9972-56cb1e621ea9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a3fcea3-aaa6-458c-8f31-b1586542b191"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a89d482-a68d-47ff-95df-37af502dba0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ad91845-0764-4c80-9292-ee5f0faedeb8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ae18910-2b8b-4b42-82e9-e70029a585a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b0e04af-953a-419f-897d-de7a7ece8eee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b1a6169-6ff1-47d2-8b7c-9b82f52528ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b3b78f8-464b-45ab-b009-e1b9f2309d56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1cd3da1c-c6fe-452d-a78e-6d2fbe62afeb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d080dee-cad6-46cb-8e87-72af5e73de08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d458f38-a8cb-4604-8655-a46a2ee3db1e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d45faf2-94d2-49f6-8330-6ab30cec3abe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d5191bc-9e40-48b8-a640-08de9a317106"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d7ce62c-2b15-463f-961f-1ddede131942"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e02fc3e-f0af-4aec-b88f-c30a9ef43707"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e0d82d1-be3f-4d7c-aec7-4f7f2273a112"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e61c91c-aa6a-437a-901a-cc9d9bcafb63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e6d27a8-c617-4508-8442-4f0f3c344026"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e82b525-fbca-472e-9d34-59b80fcd09a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1eb598af-62b7-4bd1-aa74-d2de11f9eb10"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f103fe9-533d-48bf-8b65-b516c02ee2be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f20c13a-97fb-4f42-a307-301bf1ba4673"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f2da576-c1df-41fe-a73d-5b6e018ad1ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f968c9d-4c6f-441f-bdde-c1c0bc6c779a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fb80fdd-8cab-4bbb-ae13-e656b6450436"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fbf3f5f-64bc-43bf-a956-3ee10ffcf166"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fbfc548-a6b8-488d-85e6-7d4eabd4f506"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fdd8f1a-ca3d-4d07-83db-c6442a7a77cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21048c6f-da93-485c-8d39-52d1e516bd2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2107a71c-3b57-436d-a80b-18c0baf3bbec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2108bef7-8acf-492a-b7e3-29bf89c193f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("211fbcad-ba2e-4c85-a950-a2493c2668e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21422a1e-a5e5-47ea-9d59-5671b6cab750"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21a0870c-6f79-4f1a-8402-b99fbfddd874"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("227764c1-5905-4c5d-9ec1-262c85522af8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22937ea7-776e-45c7-913e-1db86d2563f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22988963-fc8e-41f6-ab5c-c7625923c31d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22b81ed6-9590-45f1-9285-57fc9832dbd7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22c2a466-20f7-43d1-a03d-8a895377722c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22c44b07-0021-464b-ac6a-7b46867db40f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2349d1dc-03af-41db-aeb0-f5cf1ae62516"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("23616987-e10f-44e6-b619-43648dec1ba9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("23d95ac8-0117-40b9-92ef-c8cff6e03077"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("244107dd-fb01-4e15-9ac7-1d931a288857"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("244d3ce0-8fff-4a63-8413-19cd1321be78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2513cc16-5b0c-46e1-9906-b84555be85c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("252e0d7b-508c-4e1c-854c-7a5ceae4cf79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("255a8f9c-9c82-48a4-87d5-5a8dca8f974e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("256da5d7-d9c7-4920-bf26-373604ce42d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("256fa8c8-26e5-444e-a3de-6ca8e32f1141"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2599f1b3-2dd2-456c-843c-681531a69b7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25aff536-0348-4cc3-8660-0f4b6164a035"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25f2dbc6-3ef8-4fb3-9832-52ef7f4f53ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26dfd607-ad7d-43bf-b08b-663402127e5e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26e44280-84ef-489e-9966-9eca3d7d2287"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("271ebecc-0ca5-4560-a978-59a15ec528b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("275c34c0-9792-4e3b-ace1-bf652a887780"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27a64117-3470-4958-a5ac-16d5dc0c41ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2849f18f-a025-4d3a-861e-5dd843b2ac76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("286d2e29-f58d-42f4-a82d-50eb784598af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28b19ef8-7e6b-4d85-b4e9-1f9b51c77ccd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28e53a6c-e96d-4be2-91c8-8bbade5a86fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28ec5789-f8c1-48d7-8448-2c20192f66e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2924c9da-3590-4d43-9717-3d5491b30737"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("293a1952-a328-4582-b7a8-a82f23f22507"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("298dc8fc-327f-4fe0-92e2-14580b6ddca8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29e1d964-2cd8-43fa-b035-980724ac722b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a169cc5-c33a-4a59-8d8c-588a093d99e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b0485dc-e166-4d6e-9d6c-f43bfa789544"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b765876-45e9-47f8-b843-bfc91fb857eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2bab9823-1d8a-4b28-a5b2-96cfc8ac831f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c04c87e-010e-46f3-8b72-7d176edcc51e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c596734-c3e9-4fa4-9327-49f8c2215d7f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c6952d4-f2bf-45e8-975a-623c4da8a12e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ca83e3b-e14d-4312-8d14-406090f3c218"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2cc62b44-c473-4f16-a4c1-eac38f309457"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d5d83e0-4392-424d-8fd6-582732a30748"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ee4e200-f79c-481c-be13-4f99faad143d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f5ef86d-442a-455b-bf9c-f3bbe20e81cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f7bcc72-f378-4aa2-8563-21a6c2997396"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f9a33ad-015f-4668-a2a0-bd90e0fd8382"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2fb33048-3073-48ae-991b-9bb4d2cda27f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2fc9b1f1-f5f5-4e3b-a155-d3bfc020e33f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3043cbeb-3d94-4ecf-a6ff-4e1acc812265"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30eab822-b48d-4a3c-a168-8359ebb2cdf2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30f4d37f-d061-404d-9657-c7cdf71416f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31065cc2-6007-47b8-b49f-5a38f48866a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31226aee-1c0c-4882-a31c-873faef360b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3141a9ce-80a5-4b71-af4a-943978cbc5eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3219e94e-0c52-4c39-a3fb-84d9da1a8d93"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("325ceacd-28a3-471f-84ca-bb85eb527ccb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("325d2aad-4086-458b-95d8-447681067e3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32662fcf-19b8-4dff-8096-2ac5a07084a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3354f04c-021d-4711-8505-17af97178992"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3368541e-3975-441d-a82a-ff0df3d9262c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3394af0f-9081-4eac-a137-3469c07f3ccf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33b70dd2-781e-4e7c-98f4-a27baaea690e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34d9e5dd-5844-4ab9-b018-aa9a15a84faa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("355bd165-8163-47dc-98df-c0f07e9d9533"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("356142f6-e756-4d57-a9a8-d882e9f18f08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("357cbf7a-8280-4ce2-88ad-bd96a4bece1c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35a00440-1088-4444-9240-30bdf7c2a49a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35dab285-9b3e-4d9a-bf0e-a411f7f95950"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35ffc7d5-0a44-4ad4-8777-6cbb0cd7ae31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("367e452f-8f83-4528-bb17-7788b3ea12ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36a786d2-3519-484d-a440-a984076a82f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36bc568a-05a1-4f5d-9e04-4a0c3b6269fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3739039a-f215-4277-82d2-6d81e87c6df1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("376f0604-2f22-4635-9068-66eea236b340"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37a00bac-10ae-494f-bb76-96f63672d099"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37aa6989-e932-4e15-9e9e-cb3324c99f76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37c6522a-4eff-4c28-9509-9a3567af87d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37e0930f-fe16-415f-97dc-e2a77d8da82e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("381b05c7-b19f-4901-b6d0-bcb068e06bf7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3845aa1c-83c9-490f-b341-9f44cd52ee15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39c480bd-dd73-4f1f-8ce7-34c2befe915b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39fac1ae-95a1-4de6-bdc4-dc3b791f99f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a7f0da7-61d6-4cfd-a246-2361e90dfd28"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3b4b6b1d-a84a-4efe-a3b1-aa36830177f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3b5c1c5d-7320-4bb8-871c-1689882a53dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c2324dc-c04b-4140-b870-d26d716a70ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c493dd7-d336-47ad-ae0f-acbc954edd05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c5af869-9b29-4d1c-8bae-6b99d6e2c40c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c75e8e5-7a10-4973-8cd1-ddd7786a7465"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c988a40-90b8-479a-8fe5-77e5d800e92c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ca344de-f660-41b6-9b32-f05e6470993f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ca58fde-9762-4211-9293-ddb177930830"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3cdf8142-8eff-44e3-a6e7-2d40aa9aeff1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d1b4054-1688-46e3-98b7-af14dbb70bef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d33c4d2-2e4f-4d6a-a7d2-3f71d18b1dcb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3dbdb104-099d-47a7-8ede-50f1b4649055"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3de01510-95e5-4ebc-a1f3-778789e9ca15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ec4e24c-6d42-44f2-8cd1-12586270d385"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ede9ad3-617c-407e-a34b-0c78e0f795a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f098cb7-43c9-4138-a208-0a48ca027b6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f17f3b5-c75a-4e30-beeb-b0c3f184ade6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f4eff5e-89d9-49ca-8523-48bda6c39fd1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f8b0b43-5362-42e3-9b79-31ffba2476d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fc94ed5-a06a-4a1a-830a-e50227f5f59d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("400d16d5-4c5b-46ca-b462-b5363bf9bd25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4022db86-c7af-4c4f-8948-8eca14df00b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40b15e0f-6577-4242-adb7-035229d99643"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40b63c8a-185e-4502-bd26-2f3905364cae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40d149d6-9436-488d-be54-c5969c0beecf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40f4666e-7072-457a-8386-05d62b193c70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("411c9ee1-4cab-4f53-81ef-cc6c677c0399"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41353702-6510-4fe1-bebd-3a45d3a35821"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4180689b-b6ae-4a97-b9fb-87a8c5990728"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4183d7e1-cc00-4114-803f-a46ee196b5ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("418556fc-8407-48a8-81b1-2f48a265eead"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4259500e-b0d1-4508-9133-ccba4dbe230f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4261a47d-67b0-446c-b661-99521b23dcfe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42a4e263-874c-43ef-9bfe-305e29b0cf54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("430b7400-90e3-4678-a394-bb1ad3008b62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43e8da8e-f836-49b4-a82c-a6502ac58670"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43ea1685-f3cb-4c10-9802-0a8824f68d0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("443f7879-a647-4381-9ce9-56a39facffa8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("446e4dac-df8c-4338-b785-8b5a3a324806"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("446f472a-f988-41e5-ae00-5957b1299cad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44f899fb-3774-43f8-8558-480da44b01b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45037b66-5e5f-46f6-b39d-eff2357486cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4550591d-d3d8-49ae-bac6-45456ccc4f87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45646b35-da27-446a-b1c1-13075a16aa6c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45820695-723d-4d52-ada5-d0a1dc468e11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45e0e9e5-be53-43cf-b3dd-94a0c02e918f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45f1990f-d853-40dd-93bd-f451228cdb7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46d129aa-8d99-41a7-9f63-8f3dd2df9eec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("470d250e-5373-405c-a405-553bc0d7e091"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47442f5f-ce61-4386-ab76-62b52f490b90"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("476d2c9e-9291-460d-bbb6-be832240a2cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47c8fe1c-9721-4323-830e-b4bacba32128"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47d987c9-4eec-4f7f-9e02-519ed9183070"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("484ea95b-1f4a-4a42-bd31-59eba0406569"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("486f7279-75fb-4225-a756-b04925942442"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48791aa5-168a-4146-8e16-20a77f2523de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("488de244-55cf-4ead-ab26-5fec60702180"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48c50f58-dd87-43ab-84fe-f44da25c19ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48e76290-2120-4771-8cc1-3ea928c3736d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49215305-91ba-4df7-a17e-4dd30d2e3d62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4960050c-31ce-440c-961b-572677dcbbfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4990347f-ae43-4530-a929-e90626901550"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4996ea4a-930f-44c7-91ae-03c8cf2a177b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49a6911b-8318-4990-951f-61c8901d5d9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49d05d62-b800-4ec1-988d-92b401e4637d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49e427cf-3d0f-44e6-a4c3-4d5f8fcfc073"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a025a88-36dc-4abd-be88-4aa3ee5c5c1b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a49dcbb-b7e4-42b3-8951-3f44594a3804"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a960ef8-093d-444e-95b2-0c0d07bf3205"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a9c2f8c-c41b-45bf-9a12-696c88b8099a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b2e849f-bfbd-4e88-a2da-84f22a5446f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b6f0b48-72e5-44d8-9fa9-12fa612621ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c19a1b8-128a-413d-a016-a8fd94547c6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c9b2ffd-0f9b-4d1f-bfb9-83015675925e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ca1193d-1324-4872-b522-030b6aaeaf60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4cadada3-ce07-4248-96d6-b7ea60f0b0b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d41e72a-5796-451c-ab5c-9065b09c29e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d4f02c0-cf5a-45cd-a7f2-a3116ed59180"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d62a40b-7cd4-445f-a111-d1ca1ac09774"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d7146d4-e1c5-4c64-b31f-0cb648ac0dc7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d7bad3e-b073-46d2-84be-04b72fd4c51d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d86ee75-4288-4026-8936-29202e6c9d4c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4dc8c678-3e3f-4175-b81a-f21775352edd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4dd69100-aba1-4681-b62d-cf94d50c7b1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ddc5918-a256-48aa-b436-1049ff60f375"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4df76772-933f-4c5f-9931-918b5d9e8a85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e59bbb6-3236-4605-ae6f-b5af31d8b907"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e94d7dd-58f9-4431-9231-98f23f0bc4b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e9556a7-46fc-4e1c-a871-c99c98af0840"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ea65673-027d-4b2f-ac3f-e0fd0451518e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ec8acc0-024c-40cc-8951-c39dbe3a250e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ee2393a-854b-4258-83f5-b26b5a8c2ff9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f5fd340-8a8a-4db8-a3c6-e681cb21985a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4fa4f292-d2aa-42bf-bb8b-27905f25fb07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4fbe475f-f704-4cc2-8bc7-04ab2aac5bfe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4fd2b5db-87b0-4f47-b892-b38b0bde3d53"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("507751e4-3a1d-44d5-9e3c-4257273886bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("509ce78b-5be3-4a91-8e56-d3bb0ff252b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5127b887-fd83-4935-86fb-ec4748aad129"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5138c99e-a844-473f-add9-064245b65bdc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5146e563-7f49-4186-866c-fab5e6132953"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("514730d4-356e-452f-925a-c1043c67408c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("516d2303-49ed-445e-ac4f-d07ca245e737"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("518a4904-35cd-4c45-b47c-fd3b1d4553b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51986fc2-5eea-40e8-b867-9c4507051b26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51dc5a91-5f26-42c4-b713-59fdf62fde24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("520384b6-bc03-4044-91df-4740f9f65f74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("520c6ac4-6149-4c9a-a774-228c299387ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52262bc0-5ca5-4fa6-a850-f5da56e12c11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52446171-fc38-4cf6-aa76-6da00a535968"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("525e5724-4bd9-4f09-98cf-edab445e550e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5294ab53-d560-4144-91aa-9f591792f244"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52c03489-b89f-4719-aba9-8406d5597189"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52df8918-62de-46b5-9b50-81462421e289"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52fdd0fc-2928-4728-b2d9-f92f4af41b17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53bca159-df17-40ce-a115-46e10169b824"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54143c0b-5ea3-41e7-8490-db8871568931"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54b90674-f160-4663-9ce1-d100372cdcdb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55538f60-6a5a-4c50-aec3-de5479e61d14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55a77299-27a2-4590-a6a4-43ba5ec1911d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55ae8c36-db2a-47bc-9428-0145d80d174a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55de0fe6-81fa-4b91-8c73-4e2b55135050"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5608f67e-bf31-4074-9c6e-59391d6c6e64"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("566b286c-4e83-42a5-b52d-85f43b0548aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5693b024-0108-4a51-b754-7ee93776a326"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56c70b27-9171-4eb2-835a-e01e082fc416"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56db530c-8df7-44bf-8b83-6151e48c1574"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("570817c6-0f66-4996-9a41-c39e558745d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("577fc1d5-f1de-452c-8bc0-973eef03bf6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57ab631d-7bbb-406a-a9b0-b84be09db869"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57bad710-4706-4474-b2ba-879aa2465abc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57bb5136-484b-4575-971e-e9e7f4b776f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57d2a77f-ca37-4314-96a1-56d5f4e8c04e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("582bb565-c09f-4b70-800a-dbe819421c84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5870bb10-7e12-4574-8284-c8b422ec90d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("587423c0-660f-4859-88a8-62ed55049d69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58755865-7426-4b8c-b1e4-dca656b39320"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58b7468d-8e9c-4d4b-b979-45c0fdf7cc49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58fbdfdf-4ef0-49ed-b68f-d93d76acbf4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("591e7d89-fc08-465a-b3cf-49a71d5c8a00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5920a821-b12b-4a0f-8b40-c59e158957f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5923289e-008e-47e7-89c2-75f263f416fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59747626-45ab-4b42-90ad-9df2d436bf41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a4fff1c-0c11-4d14-ab3e-c35c3161e15d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b08cfcc-e815-48fc-a7b3-6f739529c514"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b383dd5-bae2-42ad-a858-91802ebe502e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bda8296-4c3d-4176-8b2a-72f44645cfa4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bdeed8c-2138-4098-b4e4-3bbc18acd2c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c294bf6-4858-444e-a18a-2de64315700f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c37aebc-d701-459a-8bff-654426e44729"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c5cc8be-4e7a-4475-be84-0df7b9547388"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cc26762-867f-49ec-935d-2bd262b0eefa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cd237e8-cf73-452d-9a51-033369624e79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d3925bc-431a-40ae-91de-c104c904ff58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d88808b-4868-47f1-bcd0-d99aa68b38a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e373b62-a547-4df2-84b4-53586519d9bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e582c1c-21bf-4cc4-9b54-a558174b6460"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e955be8-ebe4-44f7-ad47-58ede334f45a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ea9d784-fae8-4dd6-94b0-2a213cd2ebcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ed03000-9469-4ab2-a3ab-523a43cc4c09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f31836d-7188-4ee0-a1e0-73f0731d0384"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f4ccb39-fe92-4487-9c76-e98ee847200e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f7c3725-f2a7-4a5a-8612-867bd4d33106"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f96c7e2-051a-419a-a5cc-c4b7a4df8863"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("600ef569-eee3-4fd3-8bf3-7a625798c195"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("603fac48-b76f-4338-9fe4-726799758b29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6083a59b-8538-44e4-b865-3838e5434ce7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60977491-b7ea-42c1-b21d-6b03289d01f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60dfe47a-a6ac-4536-918e-560cee6a23b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60eba8a7-fe3f-4bc0-9f4e-65c9c575ff97"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("612e0272-bf13-40c1-b1ca-ed5920f41093"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("616ec17b-fdaf-4ac8-9bd4-5472f830143b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61a35d33-a7b5-4338-aa9f-6f2185dc9d55"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61a40f39-92cc-48a6-a265-dcd22e196e82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61dff4cd-34b8-490f-97ce-3203a9f3ba69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6234ee99-ee8a-4126-865f-a4c5dada7601"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("628c483e-eaaa-4360-b9b1-9bf70b41ea84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62a7950a-a8f3-4671-b74e-5fcb87b8691b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62bf8aa7-b8dd-4513-997d-7ad3eac4e0c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6341d143-74f9-4eba-9dfd-009c61279f0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63c178c0-daa9-4273-a3ce-aa9f97df4550"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63f76c77-068b-4d9d-88ac-f8e41645151d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64535bdb-f7b1-4798-a0b3-a2adb071d30b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("645da69e-5fed-421b-a43c-a353201756f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64717b2b-5164-41c8-8ebc-c1f63ef38107"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6481fe21-bd77-4d36-b035-29e40ee6d181"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64bb9f0e-f9eb-4ce9-9ae9-491be2d1d84e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("654addbb-4882-462c-b60d-611d1ad1b245"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65788441-0e8e-4627-b683-f8b993ed3085"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65ec186f-a572-4952-8575-2279baaef267"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("660a40ee-4001-4882-a0a5-25d44917a16d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6624c056-842d-4d5e-92d4-90b6af644085"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("662b42c6-23ec-4e56-a74c-ba26f532943f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66508fa8-0a90-4521-a9ab-300fc58f78ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6769c2b8-2690-4ce5-b4e4-5d1e3c7c9295"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6772188f-c215-4701-a864-7d277ed732dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67d1a155-f3bf-44c3-a2a0-a014673101c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67f183a6-fd4a-4835-a8f1-7579a511a355"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67f48f6b-918c-43c6-a47d-3973ee8a3460"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67fa816d-1559-4b95-afe8-7a334e8bcf3f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67fc55d0-460e-4927-b982-85d8ef587e3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("681a87cc-5900-4a2a-937e-07676bf1867b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6860625f-09bb-40d8-9e52-b6b0513e0063"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("686305ae-c210-42b8-abc7-d65cb0ceb626"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6873390d-186a-4083-953c-cd316cfb5676"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68a31e0f-2e73-4509-8720-86c4388a9455"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68b933e0-4693-4770-844f-172154662aa8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68dae8ac-6234-435b-82f0-b570464ff555"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("698dbe23-f06a-4af9-abeb-8c0f2f951861"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("698e39c9-6b29-41be-8b09-f27aa68e12cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a2ac54c-9be0-469f-98d5-d84b7939b224"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a5dd9d3-35a4-48d9-93e3-222f3a421b8c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a696955-a4c9-44d3-abba-e640de0ca36d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6acba127-b021-4c1b-95ae-963913814fdc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ad4624a-1e45-48d5-a10f-a96a7a02ed67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b5b8fd3-b41a-407c-80a2-3adb255770a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b751c1c-79bb-4750-8269-f8fc95d6faec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b8afca6-3709-456d-a78a-736c8cbd9e20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6bf18102-3f75-4f72-81fd-88ed81207a9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cb27303-b777-4490-9ccd-90b3971f2f42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d32633c-5e3d-438b-8265-e6580480b109"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d54c2c6-42ce-457a-b466-8e64052a80f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d604969-7160-424b-917e-ad75058ed6a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d66bbaa-006d-4f3f-af4f-59ab3e6be40d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d670424-ad6f-4f5a-a439-f31c08bdbb1d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d8471a3-7513-44e2-a578-318078146bff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d8e0c0e-1451-4e86-8b0c-0ecc89e1b3d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d93633b-d493-41b3-9017-5258263e7896"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6db52fe1-f314-4f01-bb3c-29b699201a2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e3c678d-0fcb-49b1-bdc8-b96f687c0b6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e668079-3114-4f15-af6f-956048e3aebb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e9aba07-cd75-433b-b330-726ea28c46a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6eb63d56-becc-40e0-931a-f33f916465b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ebf1069-1323-4e16-8768-f984966403f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f7e45e7-d110-41f7-b4a1-52bfee5ccab3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f8d250e-ddb9-40f7-9ab2-a28136066fb9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("701d79ce-5028-4eb5-8d13-846afedd284d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("706f5725-3159-43f0-a87e-b63d161e949c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70916be8-9e22-490e-bc11-087b0842424d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70b2b31c-b25c-4d0a-b02e-7501b591e4cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70c4fabc-e8b4-4d8f-9f68-ef6fabdf461e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70d507db-e022-4d4c-b38a-19296e6c8d3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70d6ec2a-f87b-4715-b4d5-9d840714ff64"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71ff24b6-9592-49e1-ac42-7b46c303bcb3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("722f2d8b-dc54-4d60-8f11-8c87ac48219e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7243f90f-c355-4c3e-87f8-94ab6239a166"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72579e93-c14f-484b-bad2-5345de92ed56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("729f1ff6-407b-4c5f-9513-4bad2f6d625c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7392cbdc-31ed-4b89-8f66-44fbe25af0ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73d6de60-3a57-4358-af1a-229fe117b0a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("742ece5b-2fc8-4ceb-a0e9-fc2bee8e173c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74391f4f-4f7a-4d08-bde6-58a7f7a10126"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("746289e3-9fce-4eed-b338-01ce0ef3c826"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7472e006-4e99-4fec-b543-986eee9715b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("747f22d2-af75-4160-8d1f-66077fecf1fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7488e7ac-eb7e-446c-bb3c-2e1ed74f59cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74b2d791-b67c-4a05-9151-37a8fbbc3e3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74b8e554-e863-4e8c-b17c-f3d04a2b4f25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74ef9879-b1fa-41ab-901b-0822f2422085"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("753436a3-80ee-4005-9603-301770d9e38f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("754c0906-b16f-488a-b90f-78c38fe1d5af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75e8c7d2-b6e5-48c0-87a5-dbf536d8dc88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("760e8541-ce5d-449a-9b4b-237f1ec20b25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("761e0563-fe40-4f63-9179-17cda6dd47ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("764f655b-0b46-44ea-8b2d-c1479f69ba5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76598eb1-b903-4215-abd7-eca6144b7b9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("770a3007-4e75-4057-812a-90a565b542f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77643d35-5e41-43d7-91c1-6a7cda1b4f52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7772bda7-2a1f-46f7-8101-1b16860d19f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77d15531-374a-4547-87bb-368560f69ee4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77ea80f8-9fe8-4151-85e4-ded7b2e6709f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("782b552f-7673-4e22-8181-189c7618595f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78506f83-799d-4390-a821-a62af316d6cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78af02fd-7532-453e-94ea-fe4664b0c2fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78b03b50-90da-4945-aa96-7151dd6dddd1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78e284f1-8ab4-40e7-9fad-764c4fd1ce8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78ecf3e6-b674-4779-b990-36be67c82c26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("790bc174-607c-4ec9-88a3-a73eb582c592"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("792b7a91-c391-4123-92ae-5d80267dbd3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("793221ce-dace-4822-9699-1ffdca7520ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79757e76-3a29-4b46-98f4-4ea445954069"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("797c98e3-0a9f-4add-8b90-99c6bda91b64"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79c390de-5681-4afe-8422-eb5a151f4ad8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a1b5386-7f4b-4023-a493-4cf7f5fee539"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a32deb0-4a09-4069-8e6b-e24435ba640d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a56ce5f-b4ba-4f8e-869f-f3dd9fd3d96c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a74ac12-775b-4cb9-9e33-7dd4e46a9d85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b3b09c6-6e9e-4020-8aef-9e9b3929db12"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bff0a3c-3763-45df-81c6-284172d507ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c40090b-72f3-40e5-a9a1-93ba1699c6cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c83d10c-d812-4404-9069-9d244d9e4aba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cb0baf4-5a8b-4058-9c54-80b99519b758"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d0144c3-5ad5-41eb-af67-414565a0aa6c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d21768b-7c44-402c-8da4-61c5051927f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d379c65-1489-463f-84b5-3e2e374a4637"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d5c0ecb-e498-42c0-87e9-71dace9efbe4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d81ad6f-44c6-4582-8c4e-2369a20fac77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d855d0f-04f9-4e12-af14-9f0d932a6d63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dd5a9e2-b09a-4bd6-965b-a79e69a682cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ddb0754-c683-4698-b0c4-1f3d1535391b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f7878fd-6aa0-4553-99a6-b1c0c957bdaf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ff64a69-3043-4df5-b8c9-005628221331"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8009f735-d1d0-495c-87dd-e8f845479386"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("804e5d18-f251-4c81-af99-96a1898b461d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8060bd5b-d0f3-4d4e-8a0b-ec823b15e21d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81134a13-3b8e-41bb-9f36-2d2508419cab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("813d8a69-de99-4c97-a4fa-c6729ef00499"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82267998-204b-4b21-833f-b25355d0d098"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("823aa810-cb48-47c2-a5f7-b9da4d677480"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("824ad8f4-a857-467b-83fc-0dc20fb6f6e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("825b8908-68de-47fa-a362-aa9abfef94ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("827f7b73-e874-4f13-9648-ac6aa05f0db9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8288b2ec-843d-48d7-bb76-6283c3061868"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("832c9323-0246-4c34-b6bb-3d77483ed24b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("832e645e-40e4-487b-a18f-5fb89b4df0db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83e0a773-5393-4ecd-9c27-0268e2cb5f9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83f01dbc-3e50-4cda-8367-fe0e707e1a0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83f7f8f5-0d9d-430d-9105-a21fdcc163b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8419e28a-d135-417b-9b90-f113bbaa01dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8464c868-2059-4def-a611-eb6860d63175"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("847d0107-70ca-41b2-8d30-010228e9575a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("848f62b9-98e3-4a8c-ad26-d9d046e8b4e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("852825fb-265c-4801-a100-c865b1561dfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85756f67-20d5-4d88-8dda-773e7aea6c23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85a9bc20-73fc-41d4-aca7-00306a510265"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85f84ee5-278f-485e-b499-9ccb4a5e4b58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86473d27-5a29-43eb-9b6e-488a1469a8a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("864d978c-9853-4814-ae22-cf2e5f84df50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8694b830-c5e2-4154-b57f-0dc9aeb6f239"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86973314-9953-4a85-9f62-9fb4f58de0a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86e7296b-350c-4f84-bb35-3921f8a25a2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87369616-7aa4-4ff0-9a47-32e2270b6310"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87757e04-e80d-4b04-a7fe-275cb3367387"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87aa7167-acd8-4d29-9294-281176c29afd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87e372cd-1656-403d-b218-70f9f812ce18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("880eca98-2e96-4e14-8f1f-c6c25cdf0475"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88345b4e-40a8-4996-8728-fd4afda663ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88587df9-7f86-4127-b10c-b51fc28355ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88a442ed-66fb-4462-ba67-ea11007b160e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88da7978-b795-441e-8ad7-d0b59f1b1a77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88e72e6a-394e-4ed5-86de-3bd0142ec9f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("890b7346-079d-4c19-a106-f81bba47acb6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("894c15e1-ebc3-41bb-8ed6-c9b33638ee71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("895c1014-832d-4bba-99b3-d9c3dd194768"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89c35789-2cba-41e0-a9bb-fec1b366ad63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89d8fa54-34b7-4905-a180-1c4e9bea184c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89e15ba2-62b4-4fb0-b3f6-452903e001db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89f4fb75-8c33-4c41-b278-09614747729b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a2923ce-06db-4f27-8210-7761d66e5fe3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a3bc9da-acb1-4d71-aa89-13dc3ef4bb05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a5c3d1d-47c5-4a25-8ed4-ef3694e7240e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a69b35c-adc7-4fed-a8fc-48871ef23856"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8aaae46c-609e-4cfa-9644-93d204de06c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b2d29e3-b93b-480c-9f52-b5e252a67e06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b3a9543-ba1f-4234-aeda-ddabab2ec489"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b5619c6-159d-45cc-bcc8-5ea8976cc9d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b6326b7-ae15-4c3e-8923-7186eac5bcab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c0149cc-3929-4002-be2a-c8cfa90e6433"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c2ec0f1-85c9-4793-90aa-e3100ec19430"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c62403b-44a8-472d-bff5-8de908eb3773"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d294330-e1ba-458b-a301-c4932f30f281"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d3ee51a-2a49-4cd8-849c-5ef83a6c0ee4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d4c609d-5fa6-43d6-abc9-58af2019c366"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d8d8f71-b532-43bd-9355-eacb2c528447"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e41f631-bc38-418a-9cd5-6f3b79bdc076"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e4831c0-a139-4480-b912-81b9a7f0bbc7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e5a404b-e32e-44d8-ae1e-60d5204d368d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ef6dd65-8bfe-4ff7-a161-46af04646228"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ef9cbe6-689c-40a0-b59c-acdec90939ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f003a6a-e27d-4153-8962-97a490c1bbd2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f038bee-b8d7-4831-be9d-4019c4a332ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90281c4f-d14a-4817-85f4-9a517b406604"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90492569-d473-4a00-b6a7-d70600f50c08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90585357-47e7-4987-9a41-ed9559e4a03d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91386eec-1a21-4a1e-886c-dd4bc72635da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("913922a2-b5de-4415-90a9-41de3162a2f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91a83df7-eb75-4e42-8404-ece7b40e2f4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9200459b-f821-41a6-9f07-abc2a540336c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92a32ac0-42eb-4ea7-8721-11b46f116ff8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92bc6556-1a28-45d9-a7f5-3921c7825fcf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92db6596-c74c-4d2b-85a5-0f157c38f923"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92f0451a-5cdc-4a65-be82-3737b7553050"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92f878d8-16ba-4a89-b2df-6d310a59b083"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("930c40d6-5fae-49d3-b869-1896d83db0f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("937fdab9-0fda-4e0d-bf45-81d444a8efee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("938a765f-77a6-4bed-9b84-59b1d157800a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94061dea-3593-4c5d-b2a7-a02082f4ff5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("949ab859-d407-4f2a-9357-c38a406c3340"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94c78bab-6d23-4c4d-b6b6-225c9dbfe3c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9546eb63-8957-4f82-8208-4df6b2b56052"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("956f898d-cdd3-4fee-b658-1e425bc63e66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("957c5dbe-8219-4962-bbcb-cdd72d20e670"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9595878e-926f-4fee-898c-307cad305478"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95c3d42a-7cda-45bf-9744-fa05a1d6ccf4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95dcf949-f6ab-4e1a-bb45-8ab60f28954d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("965092b8-80d6-4668-9f07-0fb9e01b3ef5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96c4f1b1-3096-4422-80a4-a0005e9fe8e8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("971bcf81-418b-4370-9d77-10138f9d96f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9725fa7a-dd45-40d3-968e-36b93be2fca7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("987d3c47-5a47-4854-b56a-4969a1a98435"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98bc5689-d259-4f5d-8de1-1f92bc0e2fe1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98c1f90a-c967-468f-ae8d-6da451eae400"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99759cff-c97c-4751-b35c-1c607ac10487"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99be9181-9eb8-40ee-a3c0-1f94452548eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99bf284c-a6a9-4e0b-9b97-72497c379f81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99c77f32-8c62-4bb1-aaa2-a0d0bb9831a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a0fbaf5-9f0d-431c-a332-d18ee27d239f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a224193-6b6d-4b63-a895-2dfcef2bc70c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a50641b-9a81-4607-adbb-82254df609b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a5ee6cf-8ff6-4411-85e5-95b37b63ca2e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a7033f3-a3c4-4bd0-ba07-578cce943669"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ac79a1a-21f1-4a4e-9120-68326383bd73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9aeb49a4-426b-4c85-ae1f-340adff70fd1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b5f35e0-68d1-47e0-ae13-307d0a06fc67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b8fcfec-4ce7-4668-8dc4-30a32a2f47bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b9c1781-d639-417f-b9db-b07d06e06feb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9bb5b6cd-460d-4ad9-b648-1e6b3b11c84f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c3722a5-cc34-4dd1-8e43-ff93479e7112"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c8062b5-2454-4f63-ae87-6d2b5c8d18d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c8e6cb7-e0e1-487e-afc6-7208894f2156"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d3e7640-2f86-4de2-88f3-e16c5298dd50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d6453d0-e0e0-4f04-9b2f-70efa6e386f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d8873be-345b-4099-8ba7-ca0326582a3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9dcc0c56-3c54-4aed-ba37-646525e38d89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e0ac68f-391c-44c6-ae8f-99ba9b8aa444"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e3e3eb3-f33d-4fd4-aa5d-25bb5cd9b2c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e520cf5-ff3a-4b22-8bd3-3a132f65edb5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ec4cbc2-bc21-4304-aa2d-a3bc2886160a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9eddd749-854a-4e4f-9d43-ccc56e61c8b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9eea30d2-d7c3-4f3b-a160-8432d38190f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9eeed777-4372-4fa5-9e1b-be54af6ad80f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ef36432-82e6-46da-9b4c-49da28035f5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f0a8345-d5d1-4200-881b-4dec8da9dda5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f3dd60b-fbc8-4990-9b46-cdc8802b6fcb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f56f9c9-2aca-48d9-b5d5-01369ab943fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f97c47f-cc8e-42b1-9ff0-999806422d44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a05b8419-7bf6-4146-8ef6-3554d0c1ee81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a067dcd1-ae0c-422d-a492-9b44fa94445b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0990f1f-201a-4a13-aee1-9628619f929a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a10edc83-498d-43a0-aab0-bffc1f913ad9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a11c98af-cf6a-4178-a9f9-76edaac5116e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a16acc99-e82d-4e9d-8a89-2847e2b29292"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a187d31d-ff36-4455-baa5-39198f28c50a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a19876cd-058f-4c3d-ae37-35ae43437f4c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1c6970d-aaa8-478e-8356-3540841907a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1e49647-dc4d-41ae-ba6d-cedf9acb0127"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2260787-9a26-4f5b-a854-ab4af164a33f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a228c8eb-f02e-4689-802c-927399b9ec01"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a26a2283-d7a6-4161-921a-ae44e11f5718"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2eb4346-cd52-4ae1-80f8-0f761077d784"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a30783db-eed5-477f-b25b-6e15fadf71b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a348e98d-94f4-4265-9fc7-70c2ce926e41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a34c8e13-8ab8-4abf-94fc-2a27600f7285"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a35903a3-c9ae-40f1-8de6-370dadea2d2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a41d3bbf-754f-4529-8078-fb09d1145fab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a421c681-23eb-4971-b9f5-742363bfd100"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4e10f7c-5108-4550-8c51-475ab6f0b267"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5337512-d26c-45de-9944-5f3583a26872"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a55ab458-6a9d-4d22-8953-9fa797c0de9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5bdcb9a-6ca5-487a-8fac-3b32be0ab39c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5eb6221-5fa0-47ad-bb96-3a50fdbd87e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a627ca77-e943-4aee-9946-b155689d9fdf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a69877eb-4e12-4be4-814b-85ea3f46b273"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6e3daa4-3377-490f-b93c-a1f6b603f685"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7bb153e-c93f-4e22-83fc-63d7da038754"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7eacc61-c511-43d6-87d5-c178a7a69594"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a822c3cb-7660-4f22-9273-475bc4d12cb6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a841a459-1b8e-4e36-9b36-9883ffa92137"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a8921f95-2226-4675-a0c7-014e9f6a6ae1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a936ba3f-6868-453c-9cd5-038a3e6a7359"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa0f2c72-daea-4bc8-87ed-37ff8eb742e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa21a8bd-bb7d-4224-85a0-3e073edf1dd6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa481c25-d326-4587-992f-a4f16de50ee4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa614c2c-e537-4dba-8f11-f4fd1054508f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa8c1a06-d206-4269-a2ff-61d815452ea4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaae57f-c29a-4724-a541-da82be423b74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aab608d4-076d-4ee9-937a-203c83d9c6c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaf5142c-04b1-4c86-a13a-1d6741d985a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abb31163-ca7b-4ea4-9610-5ddecf27ed09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abc60378-0c2e-4f61-bcca-6ee286fdf903"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("accb3742-0e18-4522-bfb0-8a7d6ff453f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ace315c0-4a4b-4909-bea8-445aa8affc19"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("acfb8d7d-af08-4cd5-8107-d2fd53de3a33"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad2c0443-2158-45de-b1e5-ef0edbcd86ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad532ad3-5b86-4348-b552-d22c654e67ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad55c297-d982-49ed-b5d7-1edfd9500678"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad59fee0-5818-4305-83be-218592677e9f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad8e9b2e-1861-4671-a80d-58a11bcc889d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae3d0359-6ec3-42de-9e98-d1cdf89a54bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae43a682-093a-4fce-894e-b6883f81cc09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae74f746-d4f1-4279-abf8-911089e4bd7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae9a1dff-ac3a-45c4-9752-3e705e4e8b9f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aec89d79-b691-497f-9b71-4a248d51be44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af434dfa-a72e-4c71-9448-4d0814f951b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aff99396-ea8b-4061-947a-fe6fad58762f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0e5f097-2df6-4762-b959-ee50d4e7a2a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1364475-2dbd-4b0d-95af-99aa20ea5f4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b13a830f-b7d7-4ee9-8432-21f780238e43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b14a48bf-9995-4575-bc02-4b205d2c4b63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1bde9a9-107f-42ef-9fa8-c6e3a13a3bfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1be3a53-b346-4588-ae83-22e4439c977f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1d98621-6306-4b6c-807f-08305ba59b32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2360490-5c09-4535-b4ea-159c0c37b4cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b290dee1-59d1-4de6-bf09-80ce8722d738"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2a10028-35ef-4b26-9dda-c26019f4c357"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2b730ce-2fdb-4c17-b3a9-2a22c2f8390a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2ddb9e4-6d4f-4374-8036-781f5c716dda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b31bda4c-ea25-41f3-9a60-332f8d9112b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b33274d1-980a-444d-b0e5-8df95c08a4af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b34e16dd-4995-43d4-a4f0-294578dc94f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3d509a7-c651-4b1d-934d-6ea6eb05167f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3ee7e1c-af73-4f7e-8a36-a4ebf49a7912"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b48f331a-96b3-4272-aae5-eb73b229380e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b49ac14c-6be3-47b4-96c0-878c2eda5ccc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4ad56d5-1634-4e1c-9021-bbb100e52fb6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4adeec3-c8f2-4af0-9ecc-45ee18022e6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b63ab56f-01a1-48a4-b683-19a2de71e42b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b688b1e0-10fc-44cf-9865-2e4fb6a3d3ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6da6030-a462-4a9d-b36c-1f3a445056e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b790e982-e370-4891-af72-697f0703a805"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7d3826a-9a1f-4e9a-aaa3-860d2ed5a530"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8108a9f-3da8-452f-b2d8-7786151c93d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8298253-8a7b-47f5-9b48-0838bd717c70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b87108a4-af29-4557-86ee-841cafff3811"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8839b29-74ff-41c2-ab58-fd56a938e30a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8b6596a-5691-45d2-b8cf-f8672c66bf63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8eea389-be7d-481f-9984-d689fb360304"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8fc98ef-c6ba-481d-b0ba-6161d5adef5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b94ad3cf-545a-4970-a4b8-cbc55c52285e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b972d571-3424-492b-af33-62590838e9e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b974b043-111f-468c-bdd0-b3fe41d95c04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b9c9d1c7-eb36-4d0e-beb6-bd601d97a32e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba0e32e9-630f-4723-94d6-2fbfa802e2bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba3f9e95-579b-44ca-88da-198b5516de0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba455e9b-e7da-4c03-b8dc-e4f1f245972e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bab9ad3d-ac62-4b7a-8860-79d9b1f199ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbe31d87-7b13-4ba7-b735-e6813d977349"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbe5209d-5782-4566-9f19-b8431c34bb63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc061894-a846-4d3f-b102-5fd384847532"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc27fe1a-4121-468e-acc5-1474442f80d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bcc8575e-08e2-4276-a37a-4ac1a88878ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd50d630-d9a8-4634-9901-0f0e7066cb23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd6ca768-837a-4d54-ba6f-9288656eb355"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd75d5b5-3716-4de1-841e-6b901b8cba86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd7b0535-822e-40ed-9241-795d61ae770e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd8311d2-1f84-481b-b9dc-565698f73d1b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bde0eb08-0015-4402-b070-653186595eed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be672c9e-c31e-4445-8f0e-60efd2b839c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be68dfb1-f193-4d2b-ab65-f3fdca5740fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bea3dea1-aa2b-4e24-838a-29187acf2fc7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf7e1ba5-635d-4d12-abbc-1b66de21ec7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf86c748-1e90-40dd-9961-8f40bd720fcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfa5d86f-10d0-44b2-b02c-2c64aee46d8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfbb2715-d480-47fb-8222-3f810ea88716"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c032558c-93e5-41b2-8637-60ac717a2f0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c098dd83-1a2a-45ed-a78d-bea4a549832c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1030ee6-12d3-456b-b05c-bc1745a35a71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c110ac42-b8e2-4fc2-a2a7-83f580599245"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1a76df1-6feb-4160-8485-e03b9b15978e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c21caf51-b162-4d51-bdae-d81a08cd009c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c229d4ec-5b5d-41b7-98db-8966924773ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c24e05f7-5f7f-4d6a-9016-4c319515ffb8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2c394ab-1c97-44a1-9c08-1d6ab189155d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c30a2a9b-89c6-4bdb-8f60-632097683784"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c316d291-fb2b-4d66-819d-25ad33cf8def"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c375bb35-7539-44fd-a709-4a2587ee832d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3ae87e7-a2cc-4e6a-930d-e2308563411f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4ce88eb-16d3-4e68-865c-088ed7ce4c65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4f6d05a-f243-4eb8-8f5f-200c9a106e70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4fb3eba-4cc9-468b-9363-d305aa81c0c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5bc65f8-7604-4508-8690-a464dddbf022"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c66e0a74-7fd9-4b10-b240-39b6c9130eca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c68487d5-a497-40eb-a6a1-1c5b1250793c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c695f973-be31-424e-b8b4-466ae83b8855"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6a61e12-2560-43db-98ca-c7519314c752"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6b56ea3-833a-40e3-b5fb-648a634743d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6e974d3-b313-4520-9438-0f30e73de9ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7338aa0-60cc-4af6-afa3-9694ab1ccc56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7b903af-fe2f-4daf-841b-dc6080dcf644"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7b941d6-89d9-42cf-8c35-cd7c16b1848c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c81948c5-c6db-4806-af92-0543dd5bce1e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8386c4f-86c0-49d8-8886-a10ee19d3bb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8418b00-534f-4e3a-90c8-6ab30d0c90b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c88222ce-833b-4a4f-bc62-180f29e00090"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8dc5a54-1693-4e36-bfb3-97bf7e09726b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c915ddff-224f-4428-ab89-8cd46786b0ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c934f271-74b8-4258-b35e-62b4db00997a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9518e68-3770-4880-b062-a95452993c9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c95e1501-72ec-403d-85ed-393004414496"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c96dfc57-f57c-4100-8459-c241cf504770"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c99d15e2-3445-4c09-b833-c05db283b222"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9a9bbef-fe83-4570-bad3-7ac3378cd835"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9b1425c-289e-422a-8490-09bbc1c8a271"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9ea4131-1786-41e3-b424-52a042766a2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca36cf07-ceaf-4cc1-b10a-789b88500a52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca3c2b21-d664-4bad-a78f-3db5b2b3a17e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb05bb32-b05d-481a-af15-74e471f9a2a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb346c96-441f-4dc0-9af1-8cb56a58ee82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb4fc063-77ec-421a-9237-c64c49075347"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb5aa4a3-ee58-4116-b1ce-93146850ec32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc16a812-0109-4489-ad65-178b77386d76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc7d238f-ac85-4caa-8724-a0469e2fcba2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd876f00-91e9-4cf5-a2e6-1d04d70b8a40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdc1ec42-82b4-4523-98b3-4af333e34799"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce26bbd9-04e7-4b18-a0b3-4352ba3e6d8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce59a80a-763b-4031-9b9b-0f05e20677bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ceb1c8ba-930a-4dab-bc6e-58e814cb491d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf5d0beb-eaaf-4be5-9326-8e94a11234b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf823d84-5598-47a8-bc88-1b01669e6810"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfb55013-6189-4e63-847c-567bfd2166cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfe6278c-1cfa-4c2c-8c04-b61fac3150c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0164845-a4b0-430c-9094-cc8cbe15a16f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d02af5a9-bf4f-4e43-b4af-92af58989477"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0a0386a-7026-49a6-aa7d-310db572d284"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0a7eb5a-2290-455f-b463-04e9d3f7e81f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0e3238b-fb86-4096-87f0-1c7117cd71d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0f8d6f8-1d42-4745-91fb-d8d0e9ec36a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d161daf9-ba85-49eb-9869-9af37bf11497"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d200d4a9-5b14-48ce-9451-d3f767b29f43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2115020-1b05-40df-a266-90b3162e4fc9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2686cc4-abac-489f-95c3-1f7f440c60b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d303f9c3-0731-4f71-8f76-d6de111840c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d51b45d7-2c3e-4d27-9f95-37f91e563878"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5293860-ebde-441e-a6f8-0145a62f4288"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d57e3163-2aac-4ae7-9b1d-ddb5498be105"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5acbdb8-4c8b-4845-879a-06640973d041"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5c88882-0110-476c-ab19-7aeec2efbdcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d61e785c-5b25-4a0b-9026-e62929a7cf03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6cb102e-1f2c-4ad9-ad9c-4773ef548104"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d738910b-f214-4934-bf6e-874f6ec59cd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d787a2e8-8319-4f24-86fb-22b5f4c12c21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7a43feb-cd35-4c0d-902e-77da85316de8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7cd5b8c-4d27-46a2-addd-09a35e13d8e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7f2a34c-3ccb-4ea7-bb66-d30168162f14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d851aba2-c9b3-49e1-813b-1e1eca4bb347"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d85c7f3a-e7f3-4a19-aea8-03cd6f924575"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8bce624-89ff-4541-9020-4490c9002755"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d950343b-5d77-4bf2-990d-94065864b0e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9ae3f61-c668-4959-b24a-d70b661b8c00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9dea28d-d2b9-4f13-9449-d5367b394936"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9e183f4-e462-4a8a-811c-18b8cf224f60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da25cfa3-fbd7-496f-9480-24de789da872"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da27eed9-b928-43a4-b376-14c91cf7a8a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da6c6b71-4832-459f-bcb4-425bc327a055"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da92a78e-c0e4-4417-9b93-34248b9ef70d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dabfabbd-7b79-46d1-87c2-97c863e54d39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db395de1-f24d-416a-9de3-982795a04e8c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dbc98fdc-1524-4eb6-8dd2-14a53094b045"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcacd089-31a7-40b4-ab74-bb5b0186b4fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd3cc0ac-e7ce-4bbf-813e-dc9c6252ae9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de9a3290-cce4-4920-a35e-c3f164c83287"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("def21afc-72f0-41aa-81c4-a10a26997d0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df9bda85-68bf-4258-bbfc-2032f84a86f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e02e4715-4e5e-4b95-8831-ef7085b223b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e02f004f-8daa-4bca-bb68-9b6d850d7b00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e034f68c-71d2-4a7a-bd41-00547eff5a09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e04e1e42-6bd8-4d04-beff-35f2c8e73c49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e05855c6-a9f4-4cbd-8c8f-de707e0bf09b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1425c1a-ee81-43f2-9ef3-2d6a00177ba7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e29c7b67-9386-4e86-97bd-060d8470f62c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2addace-7b73-4e9c-8035-c1eecc87e91b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3354e63-bca6-437b-b7c1-e5970de687ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e349ed9d-2351-469e-8034-ec1848364559"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3b2f9f7-fd6e-4a58-afb6-d8ec4ab3ce79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3c9bf2f-9622-4d7e-920c-5cc83cc03508"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3e4a4f7-f1c0-4846-852b-e2202e3601ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e468d808-bbfb-4e7d-a5e0-bf2383795b94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e46cd9d3-f4c2-4820-bb6c-d4fbc880a67c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4729cb5-fe7e-4c31-9bba-4a1c2178e70f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e49e3f26-ef5b-4801-a1bd-6d62dd40937a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5603cfe-3dee-4374-ba4d-3deb2e7ce4ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5999a6c-e135-4562-8ffc-8e5709a5ce74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5d99bff-a8f9-4dd7-870e-2fb2bc18d8d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5e1a79c-8abb-48f1-b4df-3d7227009dc5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5f78449-4211-48c7-8020-d766ba534324"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6521083-e699-4f84-80cc-04ca4a881b5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6eb8e55-a052-464d-b26d-cde3d734d384"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6f79e48-cb8c-4eb0-9ddf-ff74b1923737"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e72b9d7c-05fe-47c7-8808-0289356a9931"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e732d90f-11d2-4346-97dd-022537679393"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e741cc16-90df-410d-aec0-7965b6a5c5c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e763ad53-953f-4383-84d5-c00b41f7216b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e78d78ec-bd79-45c7-9ae3-7faf8bd1ae4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7b2baba-f3e9-4232-b05a-4451f11e324c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7f4f226-ae88-431b-9f39-5a21d390349c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e85c3bd4-7491-4414-9d04-9b40f73e568b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e86cfbf0-7900-4b9f-b0fd-afc6c0d26c29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e8adb4e2-a1fe-4077-9e86-d372b59bd1b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e9061f1f-909c-4aff-959b-e2ffcc857410"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e95f2824-d64c-4424-8c0e-922047ec9304"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea243459-76e4-4db3-9474-c194eac197f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea4c6a4d-711e-487b-947d-e7110a49b720"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eaaaa234-72c2-4626-8c18-84274f413c66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eacf71cb-aab7-40ad-b30f-402af5e464ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eaed5975-d98a-47a2-a68f-1fef7a07b01c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb134e32-fb2b-4ef3-b554-90fcd4e034d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb624b43-ab49-4d63-9280-b1dc9aefd6f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb7e0d34-13b3-4f55-ab28-1c248777a9c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecbaf104-8e17-46f4-9969-e666dbc1e48a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecf7c3b3-e1d4-4124-be82-19ef27542995"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed21c60f-75df-4807-ad3b-3c9209329f9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed25127c-aaac-44d9-92c4-5938ec3bdc11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("edca706b-ae46-44e5-8f71-aa053bb3a98e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ede42a37-5550-438a-bfa3-fb561d553631"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee54af97-3d10-4ede-85b8-2594ada682e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eeae2644-60c6-410a-b9cb-4bb9c3b6aa2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eeb513ff-27d8-495a-866d-4468e32f8a0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eeb936e7-b053-40e5-b0d4-2a1a9e079818"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eebafbd6-37bb-4efa-b882-c96029ce0d30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eeeddad1-2752-428f-a5ba-071a33815a19"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef6edf58-2795-4e6c-b0d9-0819fc35a07e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef9ada48-ea54-4cc2-818c-48c8f8a52799"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efabd8ea-2fed-47eb-84f3-2b82c759e2fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efc9b70c-8474-4be0-8cf1-bce7b0b079ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f01964ae-2ff9-4393-a567-c31a1a370fcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f09099bc-4127-418b-8432-f380ac3fec1c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0e86abb-7381-4eff-809e-8f6d47eb4d1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0ef0156-faef-460c-a116-95b777c219c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f17c6b51-a8e0-4870-9e4a-7f8c3b15811f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1ed803d-97ff-4282-8591-d5fb0e3915e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2121177-2ca0-45a1-a087-6c12bb1738b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2982f61-981c-4e56-82e6-f4f639284390"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2e7a1b0-a9d8-4673-8b4c-30333c81bdce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f30c9944-a251-4c87-aed8-1ebc2d9d9d62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3227357-0a43-41e6-b107-1b87c061e065"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f34e6bad-0e0d-49c0-b0e9-1c4958f1f937"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f38ec80b-49a7-4d2e-86cd-4f6ef1181638"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3bb7293-c4cb-4823-90c0-8099742dd146"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3d3fef3-0a6b-4eb4-b0eb-8c30d20269fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f45a4136-8c32-4f9e-bcf6-75bac171ee79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4663579-087d-4eca-b7fa-d8cf1d3b9aba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4acd2e6-9eb2-4767-9654-121461469d41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4c23885-971c-493e-8ec9-c4d0600e0e54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4cd1145-7934-4afd-8a12-2b5c10e97f78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f575b846-976a-4e6d-b689-3db74879c560"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f59cf7be-85cc-4ba6-8e80-783562aaa791"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5e962d5-0124-441d-a1e5-3202b62a4da2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f629a0b1-3715-4240-b0d6-1062732927c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6341a25-4b36-4a79-ab6e-a3c68f96d6a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6b77156-c019-4226-a3cf-0c5d384edf04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6db9687-ed42-4e96-b3fa-a4290ce17958"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f72e7499-fc05-479f-b023-3e657e97a2cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f731d1b6-b3af-480c-9555-a7dbbfcbbb23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f78d8815-6ac9-44d0-bc77-8992b7a2b255"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f79a0d40-1165-47e3-992d-c51df6fcd51a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8006c41-7487-492a-a836-87fae4247568"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8ef57ba-d275-4ebc-bb3c-40e986e5e20d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f90906fc-77d2-46d6-902a-3f020a365e71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9528f8b-eef8-40db-bc1a-d02239bc6620"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f95b3019-c378-4a53-85ed-5a8c6844799c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f971ba19-cc0f-462a-8cc0-77ebf8d2411e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f99ac6cc-c145-4de3-94f7-02b0bddb7433"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9e21857-c005-46bf-9511-6c54ad6c9a7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa06cdf3-cfdf-42a5-abee-151a6892e206"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa111e62-1c2b-4f8c-8988-1c8e9e7549b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa6b2191-019e-4e1c-9da3-2fc9b2366f6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa81c749-de0e-402f-bfe7-0651166cd449"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa8df25e-2ec4-45c3-aa9e-0bb6a1ff8604"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("faeffc8a-d92f-4689-8769-fe2d043da16a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb119b4d-7b71-4996-97fd-378545dfffe4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb128bc7-a317-43e2-87b8-a75e5c0453f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb158926-073c-413c-8cea-dddddf1f60fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb3f5aa6-3be9-4da6-9dcb-c304d0d39b24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb9b3267-ea04-4082-b2cd-078fc537b727"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbdbff05-b205-4fef-89da-c0ee71ed8ef7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc086080-0ca3-478c-a1c7-abef74b0e52f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc0ef066-e42c-44f6-a78a-f71c677bf4f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc349002-5626-4cac-a300-fce1765971ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fca97d3b-ff43-4dbc-a406-f6ae3d2aa78d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd0a14ad-c715-409c-a17b-9d13659efb69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fda26d4f-5003-49e6-84dc-608936d330d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fde77568-31d5-4083-a4fe-034b81e49d74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fded1f0b-c39a-49e8-b5c2-d9255e3cabbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe0d2eee-a696-4970-9dff-a81f5ae3ef04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe708fa6-dc69-4a81-9c15-7ac69af03205"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe787d4c-6024-4fb8-bcce-d4606125df16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe96c2a8-5754-4b93-9bff-18949e868473"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("feba0cf1-dcb0-4176-a269-56d8a36845db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fec35606-9071-4633-9ccf-2d7a3b5e7700"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fedc8fe2-554d-434f-8cc0-e8ae92fb9ccf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff010175-0bca-417c-a804-ba4eacecee23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff4415dc-aec5-4e0d-aea9-9cda1125e178"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff7f7273-a185-429a-b7d7-310034686b9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffb2762c-a9d4-4b1b-a971-1af980ddcec9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffcb1da3-097c-46e0-98fb-96710c76ce5b"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("65065e9f-51e7-4ac7-bf42-5b78a17b2e58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00486ef7-1c62-43bc-ba4d-3a42bceb6654"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("005744c4-fde9-4883-be40-cefaf497ae76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0068e416-3406-4c15-87cd-4233a22d157e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00daea56-fe30-4811-943b-0237801213d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01464551-0c13-4899-aedf-1e9401168752"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01d96684-9806-4241-9018-8ba97cc8c90d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01f0fc59-4d3d-4bae-819f-ea4f604b91c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0220faa4-4f34-466c-b6fd-08ed637c4758"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02293a03-6d3b-48ac-a3be-0eee787a12d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("023f4760-5077-46d9-898d-e6f7330c6b6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("024425bf-348d-4caa-a364-0645742c3c5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("026ea7e6-3636-4099-8641-8b25a0436ac1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02b2ecdf-bdb0-4cea-982b-d15ef0db40ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02e9c885-0165-463c-b22d-33ce17e317be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03518558-31ab-45c2-b0b7-b1858a87268e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("036b073c-f791-4a13-ac30-f222b3f7be14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03d57710-d9f9-49be-bb20-923147d31c64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03ff4295-956a-488c-b7e4-0befc77a4a1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("044c8215-2726-41f8-a35e-c423216fe5e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("051ad26f-fe08-4427-a355-2b55cb3c381b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05749b0c-9220-4928-b3a6-5256ccc02ded"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("057d70ac-805d-4212-ba2a-961cc5dd6912"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("058081a9-f704-4f09-977f-e500bd1c2cfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05839782-cc01-4a11-bb3b-c4e386547821"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("058ccbf8-8d06-43ab-8e07-859f96e14a4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("058e33c9-28f9-420a-8167-2013000b2d4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05e39ecd-60dc-47c7-b32b-303e62ebeeef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("062ecc8f-dc72-46c7-9656-7ba5ebd3a2a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06ae639a-ea4c-4b87-bdf9-ea1134ed9fcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("070b1b26-2844-4782-a390-abd9d1f5a9d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07342f7e-32c6-4812-bb5a-f4c9aa850856"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("076d9183-584d-49e9-b29d-0219fc5492f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07761fc6-31b4-4baf-b1f3-3d4f5b82926a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08043ea0-3875-42ec-b44c-05276c78dea7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08083381-0b47-4ad6-89b8-3bbbe1c73b48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08129710-eef7-4a4f-90fc-61402b672407"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0852ec09-8a9e-4093-a38a-3ad4c29dbdc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08e57850-2302-4e52-8ad9-f66ffd71f8ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08f12892-7790-42a5-bada-1735bd8d89e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("090f7307-0724-4141-b2b7-311a15d387a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09114738-0cd5-4417-8cba-c948605a4f39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09aac9ec-d4eb-45e9-b3ff-884852272aeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09ee9c7e-22ca-4661-b015-6dcd7ddbceff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a103841-d64a-4d6d-a5f1-fb94f597437c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a7fbcc4-8210-4ae6-9def-402dec2bc09e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0af2d546-83c3-4f49-8816-3ca4ab4664f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b7595a1-1d32-42e0-bada-7289c08de942"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b864d48-53bc-4668-9927-587db255af27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b9dee37-803a-433f-bb9b-d39fcbf8d3d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0bcc34e6-89dc-44c2-b87b-f7261e3632db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c412f7a-cd29-4437-ba9d-a2be766534f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ca81e54-b456-4481-a16a-f32ea46ca162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cd5acaa-e111-41bc-b578-44ee533ba456"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cff1139-cdfd-4b17-ab6a-0f5a593911ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d7182f1-c5ed-4a15-b4c8-ce86ffbf116d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d84a4a3-fc6b-4bf6-a080-8d8164f42698"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d92f4b7-f269-482a-8b3f-ff9554b16379"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0dbde706-1dee-4067-9abb-31a2ae172987"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e224479-f8d9-4ded-97e1-1192a1397505"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e23782e-6964-41d8-988b-e932a41bb1bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0eb36172-8712-4712-86fb-b653f4be8876"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ed6ce42-405c-4902-a3e8-91437ac4dd0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f823b09-7eba-4697-865b-4629fd550cf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fae2b55-1ea6-4578-adaf-70e3862928c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10a46572-c2e2-42b8-8a17-102f64b79df6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10b625d5-a246-4237-a1e5-4f59f1375851"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10cf3d11-be03-402b-9477-35643db5575f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1107c877-4c7e-47d0-b7e2-efff2285b330"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11621e91-69eb-4bff-b5a7-02ca99fb2122"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1177862a-af10-4b09-a6da-3d7dadc40f53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12471578-bdf0-4b96-bccd-61c3a1396d55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12da35d2-029c-432d-8912-e2d5e518d19c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12f779e7-0df0-478e-a96b-510a6066fb4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("140f968b-7d15-4d71-860e-740bf400ddfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14610ee7-22d1-4e43-a104-1e62c629dbf6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14875e81-cc55-48b6-ba30-72ef968c1340"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1491b070-03ca-4076-8493-40a50a88417e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14c1a64f-eb56-469d-9584-3bb57fe07128"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("154689f2-a66c-489e-aaac-f4076a3b440a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("155f693e-e44a-4139-a277-9f9f37f7aa02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("168d12d4-1a72-4d5a-8fd6-830521fc8097"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16e18d2a-478e-4b20-b16d-779b32837ad7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("171c080f-c47e-4b39-859d-84b9b876f0a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17281cb3-b09b-4e0f-bd47-b017eecbd9f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1765bfc7-61f7-40f7-a9a6-7cd81fdbedd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1777c268-1e1d-43dd-803c-4b3bc29da1b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17cc9051-639f-4aa5-8d05-be7e1e8296dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17d4d8a5-38f0-4a7a-a25e-ed8de4f245df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17e831a0-9dc2-474d-b944-c2561a784eaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1801e74a-96a4-428a-a9ef-8c54d2d42f4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18d46ba3-8cc0-4642-93d5-0f70b5cb4654"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19124c1e-602b-49c2-9ce2-dfa489c30142"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("199ff079-5989-400e-9c3a-47f851b6ebc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19a04223-475e-4ee5-80a1-6c51c7f1a9a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19b3c3bf-a0fc-426c-b3d9-fd5b42c405fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19bf6224-fa9a-4390-9c0e-d359d07bfb53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19fd19f6-091b-4959-ba02-9f8137921138"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a4201cc-52b4-4acb-8447-ca2a92166af9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a57279d-7f0d-45c5-9314-5afeabc0c97a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a60f4b8-f7df-45da-bc25-20436d972e90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ad06c68-d4db-49c7-b7a1-a22c56803273"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1afe631b-f233-482a-ba6d-3924861f7257"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b4f586f-801f-48bc-93bc-22db197d2f7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b5b1c14-2d01-4a7b-bb3d-e01b8c803ad7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b928690-2e85-4107-9670-aefd4ddd0396"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bbc7e2e-ab08-4110-af96-d15f200a59a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bbf4805-f266-4975-beeb-b492110217b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c091c01-d255-4ddb-8b3a-fe71d95adb4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c905163-251f-4ea7-899a-9c54da62a2e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cbd8abf-5887-4116-a81b-35570bf1de7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d28b171-019b-461a-b832-ed2c2692fcb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d361828-18ee-40a4-a4ad-92ace500bb62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d47a286-2bc3-4350-814c-9bb143c6ae8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d7856fd-a8b3-4f2d-ab9b-26fea7558022"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d8dd120-2c53-4605-8043-dcdeb5337387"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dbbcd0d-8435-4af5-a8bd-704278f09c3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dc44770-2eb6-4863-a6aa-675c4c47409d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dec8ae4-f6ab-4935-ae93-c44f0f51098f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1defad10-d0d7-4a89-9506-89cc860a229a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e57f65a-2aab-4a78-b3d6-7aa601fb5489"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e67574b-025b-4f34-b659-8254402c9610"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eccf52b-ad12-4f90-b0dd-a1b65dade942"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ecdb422-610a-4f0e-bbfa-963b8664e430"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ee884e9-b6ff-4c35-b0b3-d1ddf4f22bd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fa39a25-54dc-45ae-a4c7-392caa68efef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fbdf169-749b-4465-a552-c88ac8a03456"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2012701f-b741-43ba-bd7c-d0c95ed16528"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2045c2f3-840c-467f-acbd-4ba5271cd518"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("209e3ace-f628-4bdf-a6a7-d696efc0fc37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20a7e071-9e5e-4f66-9bb3-7bef38096be2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20cd2c4f-dc43-424d-8fea-f8b68206a49a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21186c44-8c32-4790-87e8-f8aafacdf617"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("211c7190-4d46-4b77-9ae4-c3fa805a7ce8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("215416bd-0fe2-4f7f-975e-b5eff8f80b4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2167e5c1-e9e7-421b-a205-36c72dc752ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2181c6c1-9072-4d2c-87ce-62cd2329bf78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21c74d32-1c95-4059-a2ca-7e6f7c1687aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21ca01c0-d576-4377-8f10-e5263b6d4b3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21d4152e-ede2-4cdc-97c2-f968c53e71ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2299d199-f6a9-4814-903b-065afa63c52d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22d4246b-0d60-464b-9a8b-562ac80bd333"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22de3890-45f3-4bca-84d3-7bd4eaa42195"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23967030-a868-4621-8ffb-e0efe366ab42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23c0243f-11a5-432e-8387-d742db36ea5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23db39c2-0365-4079-b6c3-094c14a0fb43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23f78e1a-a59b-421f-919d-223fc892c8db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("244063a8-e3a7-40e1-a210-e7f7e4684567"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("244e9e46-50e4-41de-a100-d177cc381aaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24cc652a-b535-4ff2-b7d4-7e57210f6d0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2508ef94-cd48-4ed6-85b0-3f195ec256f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("250db92f-e6c8-4521-8974-8de2ff07f233"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25543b7f-8d40-40ee-baf6-fc63cecab1a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2578519d-2514-49db-8c48-ae083d7fa8eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("265011c1-4d67-483b-ab62-9e60ac84f320"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("265ab674-a5de-40e2-afeb-60156a6f40af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("266e381e-8593-4c2e-a86d-7ced98ad017b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26a10c4f-f72d-4829-9a5f-200cc6d816b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26ac49be-27e4-4fae-bda4-9d61764cb0bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26ccb2c1-691e-449a-b253-d011bdc1ee61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26e459d2-9d01-4e3c-ab5d-d88d423118cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("271f4731-a2dc-49b0-8afb-421a062a5ee7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("272e704a-90f7-42ed-94a0-b9dda98bda48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277de574-bc80-40a7-b37f-4f8476cf07c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27d0ffc0-364a-4f50-8325-6e4e24b9a873"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2824a1a4-779b-4f08-8fd5-56ab3230b3a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("282f46c4-8d26-414e-8ba1-ac31b45f47d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("283ccb27-f3a6-4e7e-90bb-f85b184c4d9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28baa8af-ae9b-417f-93e9-70aa08002766"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28c25f28-6084-468c-88bd-2e836cf86752"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28f9d874-33dc-4d57-8c17-e04fd5c819e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("297d5a24-8637-4ffc-b0b1-4166f6bdf0d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29b842e4-5ce9-4658-ba36-97e087144ad9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29ecc58d-b600-4450-af5c-e1fbac293e1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a0e007a-4e23-474b-b785-1f7943592bc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a738d5f-a62b-4a8b-bb50-4c381e7004ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2afa83a3-ef50-4472-b7e4-c5ac4be1067f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b28e803-6d94-481d-9a5c-924c1e561778"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bb9740e-7648-4b03-b92c-3e2beb0ab3fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cc63d79-e0a9-491d-8c5b-172ccd97af6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d5515c0-9af1-476c-bdbf-59af37cab772"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d9b3572-a76a-4e71-ae37-75f3810d8ea8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2db31f55-3156-4d08-827c-112e60e4aa20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dd97bbf-8671-4df4-8a1d-339f4c713927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2de3875a-7a13-4bf6-815a-0984ec1507ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e2aef3b-8f87-4ae0-99c9-da2f294274a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e2dc75e-a42e-4a50-8f7e-2a1809fb168f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e6c1a6c-ccf1-409b-ac48-eab378950caa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e716c79-752a-4684-8574-7d58ae9ef323"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e9af078-27e3-483f-8574-8496b998a626"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f799cd4-dc04-4689-8b2c-fa873154cddf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fb2e884-96dc-47e3-9534-0c33ea25b6af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fed2f91-3593-4875-9b28-bacbe1ac927b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ffb99d1-c8da-4a0f-aa54-62f6ef128706"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("308b8076-0978-42c4-893b-e277f7ce4b22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30c1dbf0-9af7-4020-94ca-51904b5c4626"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3104a5f2-2058-42d1-b139-0ea5bfccacab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31171219-9772-45bb-86f4-419737f948d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312c85a4-898a-4b69-ac21-de91e79ccb1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3149f220-4a6a-4a61-b957-b30f26d9ddfe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31a456ca-2ff8-4dc7-bd2b-2ab0e3981c12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31a5f75c-a66b-45b8-9945-a874c5f251a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31e93522-9e7d-437a-9810-62ab63bb9c9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31fbd336-374d-40e5-aa06-52841fe6c30e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324b2b11-ddb5-4519-bbc2-50fa4413e27a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3250c4fe-69cd-4d9b-b014-7e932b27bc90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32708346-81b9-4ccb-9d50-4a88329d0e12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32d39ee3-fbb8-42d8-89e2-f62b1d9369da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32ef35dc-b3cd-45a6-8413-ee024c854d80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33ab5390-fb75-4f37-9024-ea321a100968"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33f28969-21d3-4813-b7ca-5b5c445c3f4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("340e4092-6030-4b1f-ba0d-205c5cb9594e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("343057ab-48df-4448-8f67-63af0d0f6234"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3466d0a3-afca-4d77-b4ec-eafccb6d06fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34b01c3a-db51-417a-bcd2-db9ac40c884a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35686140-b1cb-4abe-91ff-7412013950e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("358eb4ff-9c43-4168-aa23-18a5f16794df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("366ca04c-0a2b-4b48-bc17-51d2a7d88e9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3694af1e-20c6-4990-968e-21828974afa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36c2c035-890d-40c3-8357-a7d1436b0650"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36c89083-7e4d-4ec3-b051-8c49140503f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36da3c0c-e86f-46fa-93cd-2de839bd42b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37bd4355-121d-463c-ad77-1f6ea3605f86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3846a799-7353-433e-814a-60e94a467f25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("388f34a8-828d-4941-ae04-4923b74db330"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("388f7009-fe5d-40d3-a45c-b0e08df0b605"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38c407ce-8278-4bbc-b0cc-44243c530b84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3933be7e-b605-4bb3-8620-7e0abc25fe19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39c8d54f-778c-4f7e-96a2-171f5836f54a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a2e504f-6037-462e-9232-c0e5f6d2d432"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a52422c-2f46-4b9a-b7de-bf769ccfd131"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b51aa1e-b331-4008-b01e-d81ba6b50d35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b6d7e92-90cd-42ff-8238-1f51d653cf6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c236ef8-69a6-4e4a-9e60-329fcb6d101c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c527fd2-9294-42d8-884e-8a94097fd309"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca5e43d-fa47-4ba1-bcf0-f2cfd3f0ec30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ccf88e2-b4b6-442f-a291-ec7d44ec482e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3cf36a57-95fd-4af2-bf70-585adf97f990"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d0bda25-6dc9-4520-8d34-29acb6667a03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d6ec171-7a41-496c-95ad-a48bf7eb12ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3db9bf35-b826-433b-80ca-83865d7bc67f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3de2c506-b94a-41ea-a14d-fdf8e50d67db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dfef00d-cab0-41ea-8a9b-bbf21ade646f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e4b94d2-4a75-487b-86a7-477aeb857d9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ee5527d-761b-480a-9a59-4afa8ad42834"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ef33f5b-88d0-4e97-9ff7-8d3f876514a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f26a997-aed2-40be-b997-d42fb475e17b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f7eec96-3462-420f-ad3b-5d538a1a2b0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40a08a49-e9ae-466d-8ddc-929a4c2a2ed9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41434a8e-17c8-4a1d-a100-427e3e2ce28d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("417af759-2d5c-4706-bbc5-3ffca5cd2487"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41a0668e-1a8b-4c62-a2ef-d5cce94e52b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41acaf93-7139-46fb-b8c9-602e4e339644"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41c3e5b7-9060-4a36-8508-2681c5d3ffda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41fa721f-34e3-4327-8824-2c619a5b1242"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("423cef08-1c2d-4bc1-aee7-b91107ca9853"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("424d70b4-3879-478f-943a-3acade3e6473"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("426c4a28-986d-4adb-abd5-b892ff06c0eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42974e45-f4ef-49a3-b867-cdcb58abb19e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42c059ed-76a3-487b-afab-78d1c796c6f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42f663ac-536a-490e-b02c-513a1ff6ecd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4311f8e6-45ba-48e5-8fba-127bc7d23edc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4331c20d-0f5f-4c06-abdd-291bfcfb0477"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("435d88a4-1417-48dc-9761-e99bf3a56154"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4420942e-43c4-4da3-8c2e-4b1cf8d9f50f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44759b2d-4763-4ad1-a6cf-8a121401bf96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4499b3bc-2ca7-40bc-a429-9fa02025c234"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44d879bd-cbce-4622-bbe1-2113d26d66f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44f6db9d-4f84-424e-955c-fd27ff52799d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("455dc7a3-62d6-49de-8571-e574204edd83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("457c231f-3223-4209-9164-86778eef2ff4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("458a1bcf-a596-49ea-ac78-073811393568"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45b7c116-150a-4e67-89ac-aa1a7a0d50a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45e83ff8-236c-4f4e-8f6c-bb41e3549f6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46194de5-22c4-4667-b822-a98ed7fe477e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("463ac660-20d6-473d-ac91-dfb7dddf3655"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46453e0f-ca15-4de6-9a78-5bd45d4a783f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("464b3851-dcad-40e9-a7a3-3fd7d58fee3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4650cd5f-46cd-4b01-bbe5-a0d5d2397939"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46711428-3765-4f6a-9970-9fc3e037ec16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46bb80d8-c6fb-4546-9f83-75ea74b22270"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46f60402-2f32-46af-9519-eb3e7956148b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46fe4c29-1428-49e2-8689-f7866669c79b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4741f9a9-5949-4b86-84fc-d64dc4f7e487"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4753fdba-189f-4355-ad35-cea53943dc01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4758a96b-e07b-44a9-8145-f857e65f272b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("477fdf9c-6312-4d15-bd8b-84637c40e466"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47f8e9c8-1bfd-4eb1-8cc5-fab71eb14ebf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48257951-2324-4779-a1af-fa314f62d2e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4833efee-0817-486b-a0c1-3a92091959ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("489f17e9-8795-4d80-8f1f-33f24fb542aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48df77e4-33a3-4edb-9e16-aba4fd5f6836"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48f15edf-d047-470e-9e99-d9dbb8590357"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4954ff38-d1cb-4baa-851f-8cc976e9baa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49696969-7224-4ad2-be51-9cd25ced73d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("499cfa92-a265-4a8d-abc8-a20858ec7534"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("499e1a90-7479-4c17-90d5-360ebe69c52b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49a16286-96a9-499e-8b4c-dff771960bd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49c93f6a-58b5-4ccb-bf2f-435bf40e4a2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a0b6e48-a06d-414c-9eb3-aeec45a0d621"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a48b6b5-dc3c-4640-86f6-9ad1d34086ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a5ec4dd-38d1-4b9d-a168-f3e934680f4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4aa5a6d8-158f-4284-a716-b079c3c72f6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4aae46d7-9bb7-4dff-aece-086b85d836a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b47b33c-d965-4fab-b78c-fdda6691a5f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c623126-d233-47af-bd65-e4f278f5e803"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ccd5bfb-804d-4844-b1ac-181b6d816016"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d667325-f8bb-4d94-9c98-04476a2dd305"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dff349f-da83-4cc5-8fc2-51820e5612c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ebfbae6-bf90-4305-a3db-78b26f1fece5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ec0d083-59b4-4c49-b316-05cde055c7f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ef69187-69e6-4b4a-bdd5-b7d5b99f6b3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f879750-0124-4bff-ad61-85ad67fea160"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fb188dd-b2da-4ae8-9140-6134b9b92850"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fc34ed2-197d-443d-bb07-c9c6eef71010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ffc087c-126f-4d19-929f-bddebd90d339"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("501d57fe-2be2-4315-a62e-37e2e4ba7858"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("503d1d65-ecaf-41fa-9e27-aa2c1ead6896"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50d04e36-0a57-49f5-8b1b-01e3f1463e3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("517688ed-3be4-4822-bd68-6a7b1a8e4717"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51b27ae9-e39e-4f9c-ae7d-08fcaa8d9d6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51ebfc0b-6c19-4840-af30-502c0a300bde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5261a425-b414-4cdb-ae9a-b4f4f6101b18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5294fc53-cdd1-4dc5-bbad-27a9eb51a772"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52bc1526-5146-4aca-80f6-74761240a8cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52d19b40-9a1c-463f-a4a2-25304fffdf06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52e1f9e9-5d31-45ba-8087-0f1efc4da806"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53408766-96aa-4e1f-9a38-6f8f8b7456b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("541b249a-3591-4f25-b7a9-871f46e81f15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54564762-f2a3-4407-a2dc-13da34bff8a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("545b9864-bc49-4a6b-89fb-4d7fb820cfc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54871b3a-69c6-44af-b87a-a1c846fc4d25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54c130cb-a564-4372-a980-b5d4a25bdf66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5515d1b5-0874-4d4d-b37d-c4e952ca8b21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5527aa6b-819d-4130-bd4b-6d78a094574d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("557f2295-b3ad-4e46-8890-c99248752b8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56508dba-c3ca-48fe-9aeb-1eb115e7ee33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("565fd2b7-cf07-49c6-876d-dec4931d51db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5688be4a-5bc6-415a-b59e-b6d2889fd058"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56be6c10-44cd-40b3-a813-471606d836ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("571fd8cc-23dc-4a6a-8793-05174dacf9ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("576823ee-5b38-4cb4-b69e-98dc55e38651"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("577b998b-6248-4615-b0c3-669781c9cbc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("578cf5b9-1a7e-47ef-b12c-68f70143bbc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57c355ac-887a-4243-a6f6-2850400ea92f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57d09041-5ad7-4b5a-be90-e41e39ad615b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57f13019-742f-4fca-93f7-c7255d7af10e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("585424bf-8793-40c1-9d66-909c2170fc2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("587539d7-0a54-412c-b854-184efbe3d049"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5916336c-2afa-413d-bf96-c8db58d74fdf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59363b75-ab4e-4567-81e4-c9c58ba3b70b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5993420f-032e-4c6d-b666-23fe8d4c2d78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59a2f279-99d7-437a-b8ac-47ba5efc072f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59c79e12-5af9-46e5-948e-b6cababb9a44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59cecb26-3b18-4161-8861-ebca76004515"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a454dde-fb76-41db-b115-441a769adf78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b30139f-1f4f-4309-a25b-06503c37272b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bbe3866-37e7-4222-9ea1-9476f6150386"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bc7b674-5f3d-4bfe-9092-720718169930"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c5a5cea-8afc-4352-9a85-7b4ba2aabada"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c5ea360-b4ee-4c01-8c91-4a101e9b0678"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c63a70e-e17f-4efa-8e00-e0b4a81562d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c910f15-50fa-40e2-8739-20fc194929e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c9c040b-bb7d-46e5-aa83-8a69b827aa0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d8c7602-47f9-425c-9420-17329e69f899"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d9cc750-3fc6-43b5-98fc-44b66c945b8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de5d872-4e4d-4504-b54f-0ac261096d12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e059cdc-8bcb-4b8a-b423-a00e36fcf58c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e0636c1-f3a1-48c1-92be-18b3e0d2d932"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e099079-47e6-4b5a-823b-006285b00286"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e89cd1b-9a98-4624-8721-b54c3880e066"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e934cd9-f73f-4f34-ad1f-2b57c0117711"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5eb37f1b-5462-4cca-8863-49eb478a2503"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5eef06bc-3726-48b2-8816-8a32341f027b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1c0f34-6251-481e-af6b-75d0407507d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f508112-d0da-4573-84cc-84b077cc842a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb8d474-4c09-4187-b43b-7bee7ffb2d31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fdeb65d-8dba-476b-ad79-51f88820c2c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ff6764b-1b58-4850-b832-344887258cba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("604a36e6-0da7-40b5-90ae-d12fad32bb4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6067ff68-7342-4765-a99c-d1b907e504e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60751269-9e44-4677-a9cb-d0b1d8c685ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("608b5703-ac4b-4b9e-b91d-030233b0f87e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60cb9fd7-6265-4b2a-810e-e2d44c028aed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61548828-a24d-4514-83fa-d0b85a03266c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61fa0d29-edd0-4133-b8e9-eddb7e8b6b2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62061520-3a77-4005-ac3b-1a964448413a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("626559bb-0bf0-4dfb-a1a3-9b7bb8960f84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62884485-b0bd-4db7-a1d0-c89627f80daa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62c9f1b8-4701-43b2-b76d-2b0b48812ce5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6319b17b-5535-463c-8803-c7a3f8017c5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("633e2a78-c406-41cf-a0cd-38dcb7f317b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6361ebad-319d-416d-ad98-4ce15b3c317f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6381d503-16a2-44d9-bc6a-8067a2d22bd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("639b41b1-8ba7-472b-8773-0d869faf4a7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63fe662c-ec73-4b25-973d-5c27bae5cead"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("649a432c-ba11-4c44-b111-7a1dbe811151"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64f5aa9c-b5f0-4584-a87a-eb1ab74c45cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64fa6907-c2f0-4235-8348-a787771dcf69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("651bece3-e3e1-447c-a651-c06926fba955"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6554edfc-1793-46d6-86a8-dd682e10325a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("656c763a-b593-4532-b135-aead4286f0b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65ba23d1-db0f-4ecd-a30c-f33655e43512"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65ec4fe6-c242-4ec1-bd3f-141e9ef5fca9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66216e89-ebbf-4240-af6f-f92685bde124"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6660b562-d1a3-422c-acb9-cb24351588c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6679064a-eb8a-4711-aff1-ebac1f01069a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66a8a6b3-933d-437b-8186-480ca73f6c3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67156a93-0c4a-4854-8fb9-f09921bdf1d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("671bef34-b7ad-4430-8159-842a220f2870"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("678c2d48-e94d-44ad-a3a6-ddd537d4bc17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6792c11a-0947-4a02-b4e9-c23e052a562e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67aac8c2-de5a-4b71-a2db-39a222cb3166"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67c54a9c-5224-425b-9819-e6a1b26cc247"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67d35045-633e-4d87-a6f9-cf3099c713c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6820d501-5dcf-4c29-a24f-4c1cc3d6b220"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68465d01-46f0-4b75-851b-62426024bc5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("684d0f7d-0cdc-455b-ac46-ab237298f055"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68e49617-2d66-436a-acad-1d363ac43f9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69261165-addc-4a8d-af0d-aa1c3b154ef7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69348945-af5e-4f42-b868-825d1396d123"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69844aab-3f65-4396-a9e4-f760024ba7e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69ab7627-a986-4110-82d9-cdf7a01b3f63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69cd31e0-3f90-4472-81e0-05da0719bb94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a0628a9-80d0-4b77-b021-80594ad7ec09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a4c1784-0332-412b-af53-c214d4254eb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a8bff12-a39d-4379-af03-5194932fc968"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6aac6c7b-7b3f-4459-bef9-db8dd3a8a625"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6abdbb4d-ddc2-451f-85d5-66e0cc50f79b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b2d0871-6d58-49fe-83cc-b5c9840cf52b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ba1abc5-a857-4b9d-83c6-43ac70c4b217"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ba969a5-2e53-4f76-bd15-59721658fad5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6be7ef37-37be-4db5-883c-9db83a6e0e5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bfbde61-39af-444e-b350-7e5790a9b3c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c424bf0-5927-4000-9e57-d2768a6d8709"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c82ed39-1dde-4f19-93bc-fbe671007513"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cd5e067-5184-4ffc-8ee9-a11a75856fe5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ce0afd8-9868-4aa3-83b9-67b6987be2bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d29c68f-ab0a-4de5-b7fb-60969ca39b74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d730457-e10c-48fd-8a45-7bd9b5bd16df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6da6a377-d2e5-4373-b3a5-4bdcb3bbe35a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e17029c-a9b1-4703-929d-0161e0b0075e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e343ee2-f920-4209-a7dc-19739598b468"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f815e47-b077-4a03-bbaf-de061a382898"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("704ac43f-b548-42c6-9a12-baf4cf7812de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71734e2f-cb49-4856-8a61-d64cc8329302"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71853902-da5f-465b-9484-b7bc2d5704d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("718be648-812b-46a6-89c2-1e928da138f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("720762ea-c4c3-46ad-992f-bbd3a2c52332"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("721a3ff1-2077-4959-8317-a82ae0d045fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("727f9a94-f016-422e-a0bc-6049edb6f3a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72d196b4-087b-42ed-8334-ff127c2364bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72e5dfd0-4d4a-4a32-85dd-b39e7bcb45a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("731d743d-04fb-4611-900e-d1eb3c074d8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("734fa1fc-5554-4af7-bf02-2378eafccb06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73981b67-c5eb-4506-ae13-cc722458a7e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73aa397a-420e-4241-90e8-c9a183b4b7af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("742ae67a-b9cd-40d4-a0c1-bbba3170fd21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74ad56df-7853-40cd-830a-2c8384aa110e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("750c52b4-2682-45a4-892f-7ef29bd30be3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("750dc68b-03db-4abb-bfcf-29cac7e2420b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75e6cbd6-c8cf-43f3-aeca-fb764a3467b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75eddb94-526f-4f7d-8243-16c00790142e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7601f991-eee9-4e69-9860-44886f858a75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7605dba6-5be7-4071-9aad-1ca999cc210e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("762147a6-d707-4344-8db6-edef9f360e33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7668bcfc-7bd0-46a4-8485-c72f19b3d639"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("766b3139-2468-407c-aa4f-379e5583adef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76aec754-537c-47a6-830a-28c30016c6a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76b781e6-2043-4dd4-a304-dd5597660181"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76fd0ab3-88be-4637-9049-6de1cc85ba84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7853af33-c7d8-4cc7-a500-812d05993e1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7857663f-fdb5-4f87-b3f6-723b2aae63b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78b76c32-a8f6-468a-a18b-2897fab5409e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("798cead6-d5c6-43ac-be0e-21e6d9ad144d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79cb1e4c-bc1b-4c07-a7b9-3a1e1743c701"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a44a253-70db-49e5-8e82-20391e68b0aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a51684c-0fda-4a9c-9782-b8dda68bb242"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a70fcec-d2bd-40a5-b49c-069514e9ba17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a76696b-348c-4e4a-82f3-d411c68822e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a7baac4-4c00-49fd-810a-7c99a216c019"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ab2fe79-1d1a-4a3c-8ac4-975001a2b3e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ac75564-6b72-40b4-8eb8-6c05b1622eef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b173d4e-40b2-4dbf-a294-42689c03be3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b5f0bef-4782-4927-b415-3700debb891b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bb9ae06-9e9c-443b-8612-07f880af7977"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bc06c6c-42f2-49ff-bce5-8eef9ce41a98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7be086df-955a-4b37-b343-4aac5a433d5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bf2dcb0-a757-44a0-ad85-0ee88f9c2445"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c8ce1f0-a897-4d1f-bc02-49b3fce96f72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cccd954-af2f-492c-abc2-2c8e82ce26be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cff01e1-35e4-4005-a013-b268535d1916"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e0a527a-1a2a-468e-99f0-4384ee48cd9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e2b31d0-6d50-4096-b69c-f2f3fa492341"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e4ed12e-805a-47b2-87d2-49ee234c0788"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f3187b1-4a4f-49d6-aa34-2652dc06296d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f5debcb-2ca2-4ec2-b0e3-91b49d97e25e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f6b8499-e61d-4032-8364-3d842fe2c781"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f85a32c-28c5-4a31-8031-9b02b00d2ce8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f91a6cf-d0ad-4689-b228-c4a1a4de724f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80a9c605-bea9-4d39-a659-cb46cba6e981"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80cf310a-e9a4-431a-9727-e24012fa8948"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80fba56e-7566-4ad6-97a1-4f347aff244b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("814a53e1-a9ad-4bbb-b834-537ac1842171"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("815e8798-1da0-47ad-94f3-48d16a1dfd08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8198a4f9-8cb3-42ea-a476-a114a10b2de6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81cd3705-5a95-476d-b3fd-89c7661f8619"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82231cdf-614c-41fa-b3b6-0b890839a0cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8253d237-6885-4754-82f0-89ff3c2a42c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82577fc0-b87d-46bf-9209-1cc428146f63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82952642-b757-4753-8d20-b3ff41e2ad69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("829ac2f4-d1f4-4586-b594-bfb4ed7036a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("829f81a6-2667-4d94-a06a-4028d9eb6816"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82d0c1ad-9afe-4452-bea5-24aed960aa53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82d1d10c-76f4-4f18-894d-fb0de308a0e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82d6d1d9-06fc-4016-a07e-27b425a082bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("831de9d2-5cff-4190-9cd3-6b122c963e8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("833bd3f6-1fb1-4a46-aea2-f31eaf06e083"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83e7d5a9-ffa1-47df-9daf-9c379039c5c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84072197-2d45-4342-bdb0-ab0f96994207"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("842eb446-2c3f-4109-87fa-6a9d565edf7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84399c20-4731-4ba5-871c-9ecba2268d2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8451efcc-5e00-4e5a-b76d-8fa9a977217f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("846f7e60-125d-40df-8875-87b59a8095b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84d3b27d-bf11-44d8-8e0c-a5fc04985620"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84e5b1c7-6d8f-4403-b46e-1ab264ae9bbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8600ad7e-10d0-4ccd-a5a4-a90306a42f30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8650d961-9a3e-486c-8929-472fc6e41d58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("865e330d-5391-420a-8521-7be429bcbd41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("868555f3-6b15-419d-9844-b4a3c588adda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("868b5c81-c842-4985-9981-7f45d8da463f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("871df902-beac-48c3-9e2e-b6436006240b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87449e33-0198-4073-97c6-314a0a039f72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87549cdf-e295-4011-8992-6471e866ae89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("877535de-23df-49cb-be66-deee29bd229a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87e09b4d-afbd-4710-9845-3abcd6a0c6bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87ecab59-daec-49ba-b50a-a8fa882f706e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("880b9006-62cc-493a-9bf7-42696527cba2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("883aa51f-aa68-4b9d-9858-3c1a97c4040b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("883c8625-75a9-4f88-8931-05069ecbcf18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("884d9a9d-e55f-45cf-a204-e2efe96e3e93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8867c5cb-4de1-4b29-a7a6-37cb020b3e5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("886f6dc7-6052-4b1f-bb23-69b8555c207f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8891eabb-9b3e-40fa-81d9-d65fa3ac35b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88a733ec-9a98-4229-9b61-8118b6075e74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89265ed1-d7f3-4dda-89c7-b8f33f2cba78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8abe9944-7726-473f-a839-269fd8f7021e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b803106-c905-47a3-9ac0-f17884b38a71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b8488dd-c79c-4c0b-9212-d7339b86351b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bb7bda1-41f5-43c5-b66f-0b23e76522a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bf5370d-4825-4a6a-bd6c-020eba992671"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cfd2121-8c3c-473a-8fba-00100f7d1df6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d00b52c-b6ae-4b01-8493-b0efb1e4bb8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d4e0a43-5156-4a8a-be81-35ccd981f170"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d4ebe1f-09dc-4425-a9d3-988fc8a43e8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d8b503c-9c06-4f65-9a05-96239d4f28b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e00547f-cba4-43f7-9c8a-a39ef1b49142"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e5b2049-cf37-4a0d-80c4-049966b221da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e5fb86b-8b4c-4f7d-9339-8662c6553c74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8faf8650-8253-497f-825c-9fd9b46eda89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("905ae1c4-d0d8-4250-b10e-7d5d1690d56e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("906bb9e6-df54-445e-92f4-3a7341c721d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90890573-a0da-4d25-b57c-a9fb5b59f318"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("908a4ab2-06dc-4fe7-bc31-50c64bf34c5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("908b8a76-5917-41f8-8262-1f6c58fca7b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9153f2eb-b381-418c-b4a8-712711c3f78f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91728efb-fd9b-482c-b17f-f844212227e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91e57fc2-c98b-437a-991f-3a5047089dd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92abfda0-a132-4cb4-82b3-836652548659"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92ef3d7e-a6f5-4550-a521-6444f40bb1ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92fc7756-7691-407f-9dae-10e27222ce5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93ab62cf-2267-4b2c-ae21-fc8ab8ac6677"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("944e25c0-bd16-4671-bb4d-80fc91b12006"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94a6b4c2-e31f-47bb-8bca-553c65abe0cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("950cebf2-e206-4149-9de5-3d6610929632"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9539b6fc-d977-4847-b2f5-08e01d949597"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95673fbd-9190-490a-b89d-ad9400667abc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("968bd322-6464-4a77-a677-dc62e5c44769"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("968d963d-81f1-425e-8497-46ecee6e43a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96915a9f-71ec-4af0-ae21-a74fb7a97462"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96c826f4-bbfb-4a9e-8237-93283a847969"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97508bba-39e3-4194-900d-f24b97223dde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("975e8ae5-b915-4f31-9896-6833a3ebc124"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9783404b-0d43-428f-bc74-f97615309d06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("978df77e-c2da-4edf-9d6f-1b141aa653e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("983b43ea-a9e6-4d7c-a475-b7b2a53a4d2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("983b9470-0bff-43fc-82b3-c38e9c8b2c48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9905b919-6916-4122-a054-688745b1a053"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99dcbf77-6398-4779-9b83-da08b016d4e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a33499f-3ec4-4e09-9c03-5cddd1f9e263"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a3d831f-85f4-4722-8e0f-6e689da63d19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a816152-5eb9-4370-8815-d2af5cfad5c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9af3929f-9175-490e-bdcb-4243031f20ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b993787-77fe-4356-bd9e-34a794402118"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9bbbaeda-1876-4361-b626-94223e9a95eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c06d20a-f733-439d-b8ca-6f313f64d9c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c07b37c-5311-4f5e-af96-ba3e1e5056c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c2088bf-93d9-439a-a4bc-b170afcd537d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c66d9b6-1841-4b42-808e-de1953e9554d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c6d8b7f-bc9a-4c87-b76c-e84186bb0b47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cb76f42-96e8-4fb8-87ec-11bd0acf96ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cf9dba8-7450-4d52-9a7e-53be21e99d79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d217f9b-e132-4de0-aa15-61a60655b95f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d2c7ca4-6af1-4100-9467-86de265f5abd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dc2cfba-ce9e-4287-944a-38293437fe34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e062add-a714-4153-87bd-6acf182b675d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e133e4d-20d3-407b-9b79-59f0ec496c0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e1de3b9-7804-4c2a-9b8c-e63e7be7ae7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ec8c909-242f-41cc-b1cf-9e287c555593"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ecd0cac-250d-4e19-9275-29d5a4ac3946"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9efaf709-ce3d-4aee-9da2-de9bf89051ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9efd5a61-f1c4-49aa-b2bd-5f8cf9967963"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f4ec26a-ec3e-4219-a6e2-d6692e1f52f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f8b109b-22f2-4095-8f82-3e55641ece76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fee981f-7ce8-4aae-8a89-0bb023bc1f1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0ba7e32-d0cf-41ff-ba14-5bbedbe26e28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a10c833e-2402-4ea4-a5b2-dfe59398d79c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a131db4e-2e3c-4ee1-bc55-b9569efc5c3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a16e177b-8f8a-4069-ad80-5e6b43b366d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1b64f21-22f7-4cb4-84f7-bc3d2d51d91a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1f2a55e-1332-4ba9-9fb8-c058dee475c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2059b67-3002-4c4b-b687-59597b7538f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2739acb-c440-4420-88f3-6876f1315a8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a27ef38f-54d9-4bf4-b74b-f24fcbbc3ba5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2dfc715-f34e-4db4-84a6-fc121a5d87da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2f63e2a-e8d4-467f-95f2-07cdf0782f8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a30fced2-a46f-4b67-9d4d-2d670bda2625"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a36b0352-7b3a-4114-899f-364d68aeb6d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a383f6c6-510e-4c79-878a-ea7784eccf19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a388ac69-1742-42e4-a776-f2999aafe419"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3c64e2d-f3f4-4bdb-bdc2-7287e6af39c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3dfc25a-aba4-4452-b8f6-88fc34d93ec2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a451d5de-6860-428e-b501-c0541b5b1e62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a460d056-5c1a-4285-a19e-d41f7ac9572b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4649371-546a-441b-b263-74484fea2453"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a49e583a-593d-4934-bfed-a6117896037e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a55332e7-0d6a-4907-abc3-a5fd3f9eea39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5ad5574-767c-4e1b-b3e4-3c4f95ddebdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a63eb619-6c25-46ea-958d-419eff843ce7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a653305c-b547-4d14-b07a-4b03ac29c27a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a670ab99-f999-4aad-b067-c23a11776812"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a74edde4-1e86-4e5c-8be7-19e3906be38f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a79f7efd-e5e1-4b3f-96f7-5bca990445b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7f6599c-a5ea-461c-b9c1-52dcc05a162f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7fceaa7-fa5d-483a-ae7d-7d3635b446bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a81cb48c-b70a-40a9-b924-3d0d9296c063"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8801539-97be-439f-b333-dcd339a3c886"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8bf5fa1-fe6a-4744-b19c-bf026fd9f28f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8c10285-48b3-496d-8943-01e738a0d72f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9a86a02-119c-48e5-b91a-8dfb06cd8910"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9de60b9-ab89-48a1-ba27-125511aede77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9fcad60-52c7-430f-94c4-d61472b73f33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa054ec0-f784-4ad9-a7f9-6ec40e1466fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa0e3755-3f59-40f8-b3ff-237d026c1504"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa3a42d1-6d78-4fc3-8a55-940f717a9cdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa3c5d5b-c58e-4805-9532-9d31ac514a14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa66540f-fbee-43ae-a3ec-98e74b934717"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aac6e44b-04a5-474f-94f2-124cb0b0ca97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aada9bad-16d6-4166-b4a4-9bc24d533b79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aafa88c5-4281-4d58-8fea-e554e271959f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab0de201-0395-49f0-b3ff-1c831fba8d49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab547ef2-b905-4dcb-b189-0f1be19d3f2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab6ddf17-a982-40e8-b8ad-4276494d940d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab942019-9280-42f5-ad81-6b953404306d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abc26dd2-fe0b-48b8-8581-bee4a1502b98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abd4993a-f61b-4917-8da1-b4dd74dcd142"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac88e24d-0f00-451e-aea8-d8980f342f84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad5c9949-3915-4b26-8920-b4aacc85ad70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad7be630-2f03-47a0-8ab6-c4f9c62ffbe3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aeed8169-316a-4fde-8d96-3ad8b5d73a43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aef70c51-8696-45b1-bc37-9610a87d2f00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af1031cc-d6b8-4379-983e-a54b33200372"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af469eed-be40-4388-89fc-b35f6d6c1839"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afdf05fb-6935-4ab9-b2cb-1beebf80f923"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afedc4be-2e7f-432a-84c5-fb51eef92d6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afef1da9-132f-4bf3-b047-628b5936fdf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b017aa71-098c-447a-956a-b5a50fb8df14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0501b81-3b9f-4fa7-a38f-8cb12c4c73f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b08457c4-5cc6-43a2-83d1-c036c64ede74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b09113ae-3adc-4287-b1fb-bd4a3f878908"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0e6e4b0-b001-4b3f-8bee-f24462bc8a0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b14e785c-ad3b-4b76-92af-f555d89323c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b19ad43b-d495-44db-8bc0-9c4434051a1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1becc72-f459-4ca1-9143-5653066384cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b25167fb-cdad-454d-adf3-5395064ff528"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b25e64dd-7b80-4a69-9f3f-9b0a5ae4a003"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b295b20f-b0a9-48bb-b46b-bf43cd9348c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2c0a339-81b4-44d5-a323-07d6308dfe3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2e72937-1ec4-4ba2-b65e-0c3fbb657e45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b31a13ae-2e37-4c54-b5c4-029ea7dff501"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b31aeb94-6206-4567-9a30-b7e15a143779"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b38938ec-7b03-4ca2-a99d-573eb62dee76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3d2f6a9-d6da-451f-9392-9bc8d9f91ad2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3d5e4b1-bf38-44eb-8fa5-dae40e255363"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b451c46f-a5f8-4f36-8c91-6d57c0a23f69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4526e5c-5dd1-4822-9155-2dab73b6dca0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b49f4e3b-e3a2-43b7-b29d-26d33a1e24c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4c85b04-9d2b-4a87-8fa6-8c963397359e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5126cb1-389e-4e25-be38-7a62e7e92d62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b52fda4d-6ed5-40d4-833b-6f2a4f2e957d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b53398f3-d92a-4615-839e-78e2f9e823e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b659fdc1-9446-4427-bc55-73c59cfbdc91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b66d4e56-245e-4d53-a553-4a977d4e4523"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b68b2dd6-80e3-4d8b-b805-3ab92b66c2a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6acb24a-8bc4-47ca-8b1d-ae0a5e9207e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6cb4c83-84aa-4fd2-9da7-a55822c0164d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6dcceb4-0f80-478c-81ca-dc27c89af214"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6dd4c2d-6a06-48ab-a9d7-67d6bb03f8f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b733c060-3a04-4250-af6c-7211042f67f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b793990a-fc72-4b16-9b7a-32c5789b3352"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7be8171-0bf4-4c93-b36a-43bc7f7ddaa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7c54827-ff0e-458e-a3c8-d8200f386e00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7ddb198-211c-4a30-8308-321be70b3fa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8056320-95f9-4ec4-b08b-6d5118fb4aee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8306d43-0097-4156-9002-77be3af06f84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b89cf326-15b9-4d4e-931c-27fe030bde45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8aaab8c-2f4b-4d27-9b11-e1ea2da2b0a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8ad3076-df44-4ab6-a094-d3f9a207b7c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8b079c4-77a8-4a90-8407-ccae57e5301a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8b258ea-a8cf-4197-9e16-680197c6fd73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8e172d1-3109-4587-a633-77171a78446c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8ffc8ae-3022-42d3-916f-69a4ed407d55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9124336-eb89-4f26-a524-000b58baecdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9682bf4-2a03-4cad-892c-090465810316"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9b416dc-f440-4152-8b79-c65b495989d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9ef88bf-ec90-40d3-8878-2d76d2c7d4bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba5b92c2-cac4-4d04-bcea-c035ce50f4f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bae9b775-0889-44e5-961d-70dce2f75d0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb6a3f03-5923-4a7f-93eb-80a3fe18a181"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb7742ea-3531-4111-a49c-b20906a6f4cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbb987d3-edd1-46c0-a67d-86239ef6b127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc404a06-427c-4312-be58-efc88a13364f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc42e1e9-d204-4515-b817-d6b11cbd076c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcadfe9f-ffae-482f-8c3a-5fcde50ead7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd6f51d4-3eb7-4c3b-8976-f4a3f4074635"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd954f59-176f-4982-9286-450e7345bcaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdc8a346-76a8-4b65-b474-3ac76f6f0de7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be0b58bc-78db-4d93-9786-3b3f8f7dd598"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be267274-179c-4504-8298-f1c7e0de8ba5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be5175c5-0e31-4878-a63d-61f1332efb87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be70dbf2-6ac0-4843-934e-1dc0804a4698"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bebb0e58-b43c-41f6-9422-d03b0f82915b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("beccbab0-5c1a-4aef-a887-98b4756d899d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("beef5187-4abf-45fd-abaa-8f71c31f1969"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bef9cfdf-03ee-44a7-ae2a-23ffdbc46faa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf2cb8df-70c2-4862-ad07-336f9419625b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf94dced-c141-4334-b2aa-f13a7a6ad3dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfaf5486-a048-4629-bc38-0d516e08f741"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfbe5bea-9672-4254-911d-66d3d5ad158a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfccb6b7-58b1-4a65-9617-1c300481593c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfcf09ac-2b80-4ccd-91ee-3d5a1c1128fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bffa991f-5a3b-4173-acdc-c1c9be79963f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c053fe28-b291-425e-a0f6-bc4433e252b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0628ee1-8b7a-45a5-a77d-259deb17a33e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c08307ac-61a6-4fb6-9516-d128573ebcbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0ad53c2-8326-4027-9d96-da0613e382fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0e97177-83f3-40bd-beff-6427cb2cdc6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1231f5f-d3dc-459f-b799-e1dfc708b56c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c15ff4dd-7097-4b9e-a012-470208828717"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1c09c1d-ca8f-45ce-9468-139add40c669"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1edd586-566e-4ca0-a2bf-1d207fdeab82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c20b7af6-ca21-47ae-91c3-2fdb485dbb67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c24fb198-9dad-4a07-9b8d-127f93e8dd72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c297e2a9-5b3a-446c-9230-828aa0155090"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2f335cc-02dd-4049-a1fd-9d49857add61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c344d8ff-3dc4-4985-a178-6dd68a779f6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3a0f736-5b0b-4314-84de-6babbe19f5da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3c212d7-63d3-4bd4-bb8e-bffd10273b16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3e338aa-7464-4e7d-ab3d-5a17c50a1253"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c411e050-c98d-41c5-bdeb-b2b21bcbd846"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4908421-2580-4272-9bdc-71b7be07f6a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4a42f1c-a17b-4710-96bd-71ee9e0e8d33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5715b73-8b0a-43d1-b696-b840601bf843"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c58a8c86-b2a7-496d-b88e-f20483111135"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c63608de-f643-4f2a-be28-4a57bb37f17d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c653cfb9-e4fb-4c0e-ad12-c266aacffcaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c68dd176-03b2-4cda-82c6-e15c2ea145b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7060e69-0cb3-484f-901e-53feb72b0f8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c875c902-e8b2-4742-a1e2-0733edb4421c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8c35052-097b-4c4d-8947-752e2e8674c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8d60efa-502a-4817-868b-893644f4c816"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c92bc90d-2969-4a9f-b39e-fb5f55f9ed21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c97d427a-8870-43e3-ac98-d79ab98b7456"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("caa2f01e-c811-489b-ac54-2e37590a20c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb08e3c3-0f96-45e6-b0c7-93b1b5ebef62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb167bd8-faa3-4681-95c0-9582a709c5dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb4b527e-48c0-4a46-8c07-eca2c2902934"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb5109fb-3f4c-4505-af04-75c2a930f13a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb7ce6e0-acea-4c51-a61f-1621e6b77599"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb86d680-557a-4070-95dc-e3be3c478b9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbdedee2-6bc5-4fc7-b9a0-7cffd73bac9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc9e1f00-59fa-4d2f-82d4-23c9ab331dbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccbe5f78-9d1b-4da0-960f-21e74de2ce11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd1d9435-a5b6-4491-8dd0-d977c8d25856"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd5d9998-151a-408c-a1eb-e01e21476a61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdf11bec-8a2e-4923-b463-d7e42537c5cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cea522c5-f3c5-4c61-b2aa-dfa7cb3a7af0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cef2b26e-df42-4978-a441-40b1748b7967"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf40a95b-fccd-4a24-a4c5-310d7fe15d08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfc7033e-db10-4543-83a4-c3f361fa867d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d01047c2-f61d-4558-835e-19c4fd7e2359"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d026b468-a285-480a-ba4f-ba6991e20dc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d04c8335-9bb4-4b96-851d-e3725d3f9458"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d04c9266-83f6-474b-ae65-da193f70ed72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d08180c5-344e-4384-b80f-87a93e0525d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0d60496-6b50-4eb5-a38e-4a6805b8ef5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0d95365-33dd-4ebc-9fc7-76972326f917"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0ebd580-0146-412d-ba86-5e18996ea734"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d113ac20-a352-41f4-8f5a-311d62dbc959"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d18f111d-56a0-4812-ac14-5c38c27d5f05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1a9ae20-583b-4f22-95af-66641fa01f4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1aa49c5-5404-491d-a368-870d8da85749"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1d6b21d-2e42-4241-8968-27bb00525828"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d25b8947-bef6-4ce8-9aab-3f007cc2b0d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2c17469-d964-4c03-8742-4516c6c14061"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d32d8f19-819d-4fff-a650-963dbef0b33a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d36d6209-8faa-421b-99d7-ccfe3708e581"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d391efa5-a27c-435e-8edf-9a77b60135fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d39abddc-cc34-4526-a911-af15a8ee18e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3a4ece0-7e61-4ee8-972f-a356c7f6ca98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3fbe4d4-69f6-45d9-a43a-434c08815c52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4ef6318-99be-43a6-931f-03e8f019b5fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d50e00e0-73e9-43c7-9143-8b49bafaa21a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d541e834-3bd5-4b4e-81af-76c92706edda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d54cab3f-6363-4c56-9bbc-022d251d0128"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d59bbb93-6d6b-4f75-833b-d902e38dfac2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5df477b-359e-4f61-b47f-3e7c424ed9e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5fabf3e-e233-4320-adfa-96623393af5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d60b8f33-193e-4027-bf7b-75efec623832"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6a7a97b-fbae-4668-ad41-3a83dc2cc7d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d732570e-f1f5-4b82-84ff-880cf42edd34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d805700e-f62d-4984-b874-123c03a95ce6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d84f1606-483e-4699-9d0c-b8fa961fd450"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8681403-c121-4fe6-a42b-4435a195244e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d89348d0-61ec-47a8-afd2-ceaefbd7b670"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8a6722e-f077-4491-89de-cdb2f54628ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d949f1f3-e862-4f8d-a7b8-09981eebcb83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d99f214a-8eec-4d76-9d55-9202723b5a8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9aa1a9b-b69a-4663-8418-714bedf39eda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9f19631-d33a-47d8-ad6d-7c1fbc60f0c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9f8e65b-3d65-4635-a46f-4a43157a7c79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da391ba0-619c-4f60-8e3c-698b75067c97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da50d3d2-6343-4db0-88e3-c99cdb25ce96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da901e42-dde0-4d6a-8e82-88d0ec6255ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dac10e1c-8642-410a-881d-01de83852663"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbc0f351-9a32-4c7c-9431-874ca4bdb137"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbda5362-baf7-4575-b8a9-a3dafa113628"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc2ee11c-c979-4da1-8fb9-2f70104a6f6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc4b2cf2-b27f-4048-80dc-0190c8d0ca92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc899e39-9a9c-400b-b102-13b3073ef8af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcb5c9e4-09f6-428f-82cb-f4a55b99fbbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddc6b3ec-087c-47d0-8df2-3df28ccdd30d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddd97fcf-ea1b-410f-94a5-b0ededd940cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddf9bbdb-f4a9-4d7b-a996-169949b5e2fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de1e8ca2-af1e-4084-8e1e-631f5fe84643"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("debf9919-953b-4cd6-a81a-4c1f7a6a3b0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dec3f217-802b-4e86-932a-b07edf1dd5e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df3fe441-1b9d-4f75-bf46-7937e91ac497"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df447ee8-9edf-42a4-9369-e50f4fcee59f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df483881-bc64-41b0-ae7a-e89072e993e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df581d71-f6f0-4b2a-bfbd-7b6f4ef7c17d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df67e51d-6013-4bfc-89d5-7c508db34ab6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e004d868-ee20-402c-83ff-eb68ed692583"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e011adbb-dfba-4d75-bbea-11229805fece"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e01ff2e5-f285-467b-8e30-a1ccdfe00291"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e02d337c-d5cc-4b87-af0c-ff56e12c3259"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e02f04fb-3b7e-4886-a3b8-6958e7f1f565"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e033ea23-f057-4ab2-8658-1c4f4192bf93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0723fea-6544-42d1-881a-fa77c7a0b26a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e10d4e7e-12b7-42f4-a0a3-011bc444e07e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e14d39fe-d981-4118-9a5e-190e1d9517b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e151f64c-ebaa-43fe-8aec-32c7a51fa91f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e162c0cb-48c0-4487-aee1-6ca20dfed97b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e16e1464-17eb-4034-b889-503b4a459e56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e190d23d-3b1f-4d18-ac50-7286de36fc34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1d6eadf-0877-4921-bda4-140088abda86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e24714c0-7af4-4299-be99-78cadf1bbb7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3021a01-c683-4113-ad3f-6b09c5455729"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e311f3fb-7c55-4dc7-9f0d-ecbf66886d3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e333f250-dd29-4c11-8eb8-1f6256bb16e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e35d09bb-cec7-4c07-adcb-077f641d6d32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e36a8d59-346b-47eb-9165-3e6c61cec4c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3bbbb9d-4e99-4126-8ce0-3b934fc5582a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3c6048f-899f-490a-a904-5447ff24517f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3dba9ac-4545-4b6e-bed1-652fcd792fc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3fdb35b-e749-47da-a88d-154682e04072"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4405ef5-c33e-48d2-9910-4bf78ba17351"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e493fa68-8aab-428f-ac18-9afa543de719"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4c12eb0-ae43-42b4-950c-e407fb10a921"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4c53b2d-0b3f-430e-a9e9-d8b4373f33ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e508f3bb-9443-4382-91d8-5ba47f391f78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5459910-4448-40c5-81df-66bc2bc64790"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5b97806-4e9c-446f-a4ce-007925170dc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5fe5cfa-1112-45cb-8b56-7b9a0163966d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e61dee4c-dfe8-4a77-96e7-2d9fbfb3fc44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7e8e87d-b9a4-4726-a3b3-f049f8919225"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7f80c89-5515-4579-8346-8da068bd4bae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e89f1949-acef-44de-8825-5add1bc1668e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8c358e8-ca3c-4ac4-a9a6-e534b3c11df0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8d64616-d3c3-45fd-b21e-67bbd5461117"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8dde7a4-9b95-4904-a6c1-5f3066d42415"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e916c19f-6579-43c9-b000-b95817ed9cf8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e92fd5c8-545e-443f-b783-ab8cee0a6a1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e97de1be-7384-41ac-9926-468ecdbaca4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9a2dc5c-4d96-40cd-b17a-ad6fd4e5dc1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9d2140a-b760-4209-9676-5189b01f85c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9e32adf-e478-48f6-b97d-67e5709aeaab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eadb1a1a-22d5-45a8-9268-2042adf4bf06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eae705ae-f011-4af7-850f-2d45d3c498db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb10b30b-640c-4326-96d1-dfb1e12a7b60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb404710-a810-4996-87d7-85662c9ca0d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb83fc6e-8de9-4399-ba9f-d964729d14f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb9a314e-f2ed-4f0e-874c-e08fb44edc1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebf8b58c-dfe1-4704-a912-8a015b3f1b54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ece76f55-9a3d-4639-961e-3a7901a8d364"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed0a97cb-114d-4e05-bbc4-33ac91e97c21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed961011-8eef-43ee-a86a-f44759416112"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edb41a3d-023e-46df-b367-9b53f24f55a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee3bfd9c-fd65-41e8-8b82-c37f3a950aeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee596463-837d-4ecd-89ae-8552d5bbd5b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eec97e04-6d58-4079-bb91-796c0526a846"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eedc71c2-c858-4aeb-9821-0c85730c958a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eee365dd-7144-435b-9d12-75d3ea9517b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eeea30c5-fc4c-4cf9-b75e-da6f80d9fcb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eeefd3a5-b3a1-4ab9-bdc2-b37b750696a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eefbbf8e-92fe-4c8f-a87b-fb281956190f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef20ac3f-1959-44f3-ad80-04c5665ff92c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efbe432f-7083-4933-8ee2-308e7374977f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efef41d7-81d2-4f0e-825b-4485f010bd97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eff567e5-7bf4-4038-9963-209a55c52062"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0735d08-bc63-4ecc-b4ed-63dd911285ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1353baa-f913-401b-83e4-4d252170df81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1dac5cc-ab28-44b2-9b1b-e1c2da76af62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1ef5781-6532-4fe3-9ecc-642f561c68f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f28f229f-9375-415f-985c-876f6463f5f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2a11460-e7ed-41dd-89b3-146da46c044f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2a8b769-25e6-4298-914c-25b7fad5cd41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2c32bf5-4a16-4f26-b69c-a05cf9804ffc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2c801e6-c06f-41a5-8892-1bc2ff27ecc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2ea9d21-f870-4991-97ea-1a49286ff80a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2f76948-17fd-4f62-91cd-b5cf07c66230"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f305b893-ecda-4485-b66b-ba051f8f6d34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f30bde65-7bcd-4b89-a2bc-e620b9b231d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3c8037c-916b-49b5-ad21-64c2327e61e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4096988-206a-4e37-b6cd-e39beb2bfeae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f46cff69-44fe-4811-84fa-739509fa09a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f494d139-5a7d-4aae-af84-d42193b5e7ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f49a54bf-5f4f-42a1-b71b-fdb0d4243f2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4cb0f5f-c510-4dc8-997d-ea9fae746da6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f58c2c5a-7cda-4e7f-96be-3c86c22b6b56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5dcf2aa-469e-404f-9b37-d89d8c14b2e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f61793cf-4ebd-4788-ae06-da1699a8f100"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6407ad4-4b47-4c14-aa87-008a4e7221e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f66117ea-4f17-42c7-9dea-eee5dcfc897d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f68341d0-1f05-4559-9e5a-64a79e1cd378"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f69e2cbf-5bd5-4bfc-9d4e-cf55b19abf59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6ab30ff-1275-4424-b4d9-b262ddc156ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f70de723-b276-4206-a0f5-da0e0e84cefa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f71c31ca-ec8d-4a6b-9079-9672875d486d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f793012c-46dc-44fd-8364-2f35999287e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7aac9f7-88b2-476c-b5d9-a58db58b5a41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7d4485f-5ed7-46c3-a5be-23d0b59f6f9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7f9996e-c74e-432b-b6b9-c7ec756a62c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f816b64f-d517-42a4-a68f-057e3accd764"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f84a97d8-e153-48bc-abac-0d65a234e5d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f852943c-3b98-42bd-b33e-f7605c4b6ccd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8562cd2-aeee-4ea7-aea9-af3bf327ec1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f86dd17c-a9da-4425-badc-8fa651dd4473"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8742102-84f8-41b8-9d14-5466fd9f890f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f880ac37-e077-4734-a037-8814ce2ae5a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f897083a-a9c4-4105-9230-874bae3ac819"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8deff48-c8a7-487a-ad17-8982535ade43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f92d7b56-5208-4422-9b82-cc4b1dcd5592"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f92eee2a-ca3e-4c92-bba7-f0547a144369"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f97f4f73-dec1-4fd5-b788-d20ec564b872"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9e83d74-f124-45e8-998d-b837a42059ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9efc426-de17-46ef-a8bc-4c1ee5d82d1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa00ac6d-cf88-4eee-a871-d759fbdce4a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa183943-ce6d-420d-9061-ffcb24210f6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa518445-e0f5-48f7-a519-7860b67dc42b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa519832-ed06-47af-a31a-81609658a1b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa5fad63-c0af-4ebf-97f1-bd841cc67036"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa6b1c8f-68f7-4340-84a8-d5b9fada1462"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa747dde-d4fe-4187-8136-cd0d52342f64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("faa7cb17-a44f-4aae-90b0-2e27be8ab2b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("faad37ab-35b5-419b-9883-d81b38c49909"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb63da7c-34e6-4224-8f32-9c3e12f6bde1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fba362fc-4ab2-4262-996b-a96886dcda5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbb7168f-e104-4ca2-a169-95d6524b950d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbcacef5-93a8-40f1-a9a5-f34bfb62a15d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbda06a7-a1dc-4787-84e3-0a3d3ac731b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbf9991b-c192-40f9-8533-a9a251aefba9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc7cd3b1-ca78-486e-a1ad-e8265f8d03e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc99e3ff-fc7c-46ae-a142-6d806f3aa0d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcbb5911-a3e6-4cb4-9d88-bfaeac4c7667"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcc4b5a0-0a7b-49d3-b18f-15ceb5be48c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fccc1024-a7b6-403a-bc3b-44f691adeb96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fda5a8a7-cd37-4f45-a513-80b7749fb852"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe3c0320-277d-4b21-a183-1c2ed3ef5b9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe751e44-173f-4f91-9b06-ba9f16a4cc41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe8cf992-ac8d-4136-b7cf-5cc37b9aca56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff6a7181-d8ab-4804-bd4d-6e08f6d66464"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff98e789-a49f-4dcf-a226-fcb2387bf459"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c240ba3b-c8e8-4a3e-8656-3ba0ba6f5a0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5a5fcd4-4f3e-4780-82e0-97d42818b2cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1690e3e-ab6f-49ee-ad5c-9f8fdefea063"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a14f794f-3ecf-49cc-b9c4-33bfd272c34f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null },
                    { new Guid("f7336d7c-2709-44a6-a33c-ffed1119e7dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Adress", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("1679c788-8717-43d7-8f23-f6a8e8ff34f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox76@gmail.com", "NamDepTRai", "Hashed_password_02", null, false, false, "Ho Hoang", null, "User", null, 0 },
                    { new Guid("4afeb0d4-2e75-42a2-83bf-2449c9f095e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dafox746@gmail.com", "Nam", "Hashed_password_01", null, false, false, "Ho Hoang", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a458fbe5-c96a-433a-8f48-34cc17a77979"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần xì", new Guid("a14f794f-3ecf-49cc-b9c4-33bfd272c34f"), null },
                    { new Guid("dca0c0d7-f4d6-4f3d-bbf0-363067a60cb4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("f7336d7c-2709-44a6-a33c-ffed1119e7dd"), null }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("6e8254d8-47e2-4054-be0b-d26d13865b90"), "123 , Ny, USA", "Apple", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123134", null, new Guid("4afeb0d4-2e75-42a2-83bf-2449c9f095e3") });
        }
    }
}
