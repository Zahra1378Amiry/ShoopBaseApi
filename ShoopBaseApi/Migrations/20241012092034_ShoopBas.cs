using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoopBaseApi.Migrations
{
    public partial class ShoopBas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_AboutUs",
                columns: table => new
                {
                    ID_AboutUs = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_AboutUs", x => x.ID_AboutUs);
                });

            migrationBuilder.CreateTable(
                name: "T_Category",
                columns: table => new
                {
                    ID_Category = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Category", x => x.ID_Category);
                });

            migrationBuilder.CreateTable(
                name: "T_Ganoon",
                columns: table => new
                {
                    ID_Ganoon = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Ganoon", x => x.ID_Ganoon);
                });

            migrationBuilder.CreateTable(
                name: "T_Ostan",
                columns: table => new
                {
                    ID_Ostan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOstan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Ostan", x => x.ID_Ostan);
                });

            migrationBuilder.CreateTable(
                name: "T_User",
                columns: table => new
                {
                    ID_User = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FristName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Emile = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Images = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ISActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_User", x => x.ID_User);
                });

            migrationBuilder.CreateTable(
                name: "T_Product",
                columns: table => new
                {
                    ID_Product = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", precision: 18, scale: 0, nullable: true),
                    C_Product = table.Column<int>(type: "int", nullable: true),
                    T_Category_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ISActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Product", x => x.ID_Product);
                    table.ForeignKey(
                        name: "FK_T_Product_T_Category_T_Category_Id",
                        column: x => x.T_Category_Id,
                        principalTable: "T_Category",
                        principalColumn: "ID_Category");
                });

            migrationBuilder.CreateTable(
                name: "T_City",
                columns: table => new
                {
                    ID_City = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    T_Ostan_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_City", x => x.ID_City);
                    table.ForeignKey(
                        name: "FK_T_City_T_Ostan_T_Ostan_Id",
                        column: x => x.T_Ostan_Id,
                        principalTable: "T_Ostan",
                        principalColumn: "ID_Ostan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_LowOk",
                columns: table => new
                {
                    ID_LowOk = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_User_Id = table.Column<long>(type: "bigint", nullable: false),
                    T_Ganoon_Id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_LowOk", x => x.ID_LowOk);
                    table.ForeignKey(
                        name: "FK_T_LowOk_T_Ganoon_T_Ganoon_Id",
                        column: x => x.T_Ganoon_Id,
                        principalTable: "T_Ganoon",
                        principalColumn: "ID_Ganoon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_LowOk_T_User_T_User_Id",
                        column: x => x.T_User_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_SearchHistory",
                columns: table => new
                {
                    ID_Search = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchQuery = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    T_User_Id = table.Column<long>(type: "bigint", nullable: true),
                    SearchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SearchCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SearchHistory", x => x.ID_Search);
                    table.ForeignKey(
                        name: "FK_T_SearchHistory_T_User_T_User_Id",
                        column: x => x.T_User_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User");
                });

            migrationBuilder.CreateTable(
                name: "T_SendEmail",
                columns: table => new
                {
                    ID_SendEmail = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_User_Id = table.Column<long>(type: "bigint", nullable: false),
                    EmailAdrress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    SentStatus = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SendEmail", x => x.ID_SendEmail);
                    table.ForeignKey(
                        name: "FK_T_SendEmail_T_User_T_User_Id",
                        column: x => x.T_User_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_Feedback",
                columns: table => new
                {
                    ID_Feedback = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_UserSingup_Id = table.Column<long>(type: "bigint", nullable: false),
                    ID_Product_Id = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Feedback", x => x.ID_Feedback);
                    table.ForeignKey(
                        name: "FK_T_Feedback_T_Product_ID_Product_Id",
                        column: x => x.ID_Product_Id,
                        principalTable: "T_Product",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_Feedback_T_User_ID_UserSingup_Id",
                        column: x => x.ID_UserSingup_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ImagesProduct",
                columns: table => new
                {
                    ID_Images = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    T_Product_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ImagesProduct", x => x.ID_Images);
                    table.ForeignKey(
                        name: "FK_T_ImagesProduct_T_Product_T_Product_Id",
                        column: x => x.T_Product_Id,
                        principalTable: "T_Product",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_Offer",
                columns: table => new
                {
                    ID_Offer = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PriceOffer = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ID_Prodect_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Offer", x => x.ID_Offer);
                    table.ForeignKey(
                        name: "FK_T_Offer_T_Product_ID_Prodect_Id",
                        column: x => x.ID_Prodect_Id,
                        principalTable: "T_Product",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ShoppingBasket",
                columns: table => new
                {
                    ID_ItemShopping = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_User_Id = table.Column<long>(type: "bigint", nullable: false),
                    T_Product_Id = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(29,2)", precision: 29, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ShoppingBasket", x => x.ID_ItemShopping);
                    table.ForeignKey(
                        name: "FK_T_ShoppingBasket_T_Product_T_Product_Id",
                        column: x => x.T_Product_Id,
                        principalTable: "T_Product",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ShoppingBasket_T_User_T_User_Id",
                        column: x => x.T_User_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_Address",
                columns: table => new
                {
                    ID_Address = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_User_Id = table.Column<long>(type: "bigint", nullable: false),
                    T_Ostan_Id = table.Column<int>(type: "int", nullable: false),
                    T_City_Id = table.Column<int>(type: "int", nullable: false),
                    Adrress = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CodePost = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    AddressType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Address", x => x.ID_Address);
                    table.ForeignKey(
                        name: "FK_T_Address_T_City_T_City_Id",
                        column: x => x.T_City_Id,
                        principalTable: "T_City",
                        principalColumn: "ID_City",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_Address_T_Ostan_T_Ostan_Id",
                        column: x => x.T_Ostan_Id,
                        principalTable: "T_Ostan",
                        principalColumn: "ID_Ostan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_Address_T_User_T_User_Id",
                        column: x => x.T_User_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_Order",
                columns: table => new
                {
                    ID_Order = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_User_Id = table.Column<long>(type: "bigint", nullable: false),
                    T_Address_Id = table.Column<long>(type: "bigint", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SendStatus = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Order", x => x.ID_Order);
                    table.ForeignKey(
                        name: "FK_T_Order_T_Address_T_Address_Id",
                        column: x => x.T_Address_Id,
                        principalTable: "T_Address",
                        principalColumn: "ID_Address",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_Order_T_User_T_User_Id",
                        column: x => x.T_User_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_Payment",
                columns: table => new
                {
                    ID_Payment = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_User_Id = table.Column<long>(type: "bigint", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransactionCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    T_Order_Id = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Payment", x => x.ID_Payment);
                    table.ForeignKey(
                        name: "FK_T_Payment_T_Order_T_Order_Id",
                        column: x => x.T_Order_Id,
                        principalTable: "T_Order",
                        principalColumn: "ID_Order",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_Payment_T_User_ID_User_Id",
                        column: x => x.ID_User_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_TampOrder",
                columns: table => new
                {
                    ID_TampOrder = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_User_Id = table.Column<long>(type: "bigint", nullable: false),
                    T_Address_Id = table.Column<long>(type: "bigint", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SendStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    T_Order_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TampOrder", x => x.ID_TampOrder);
                    table.ForeignKey(
                        name: "FK_T_TampOrder_T_Address_T_Address_Id",
                        column: x => x.T_Address_Id,
                        principalTable: "T_Address",
                        principalColumn: "ID_Address",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TampOrder_T_Order_T_Order_Id",
                        column: x => x.T_Order_Id,
                        principalTable: "T_Order",
                        principalColumn: "ID_Order",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TampOrder_T_User_T_User_Id",
                        column: x => x.T_User_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_TampShoppingBasket",
                columns: table => new
                {
                    ID_TampShoppingBasket = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_User_Id = table.Column<long>(type: "bigint", nullable: false),
                    T_Product_Id = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(29,2)", precision: 29, scale: 2, nullable: true),
                    T_ShoppingBasket_Id = table.Column<long>(type: "bigint", nullable: false),
                    T_TampOrder_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TampShoppingBasket", x => x.ID_TampShoppingBasket);
                    table.ForeignKey(
                        name: "FK_T_TampShoppingBasket_T_Product_T_Product_Id",
                        column: x => x.T_Product_Id,
                        principalTable: "T_Product",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TampShoppingBasket_T_ShoppingBasket_T_ShoppingBasket_Id",
                        column: x => x.T_ShoppingBasket_Id,
                        principalTable: "T_ShoppingBasket",
                        principalColumn: "ID_ItemShopping",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TampShoppingBasket_T_TampOrder_T_TampOrder_Id",
                        column: x => x.T_TampOrder_Id,
                        principalTable: "T_TampOrder",
                        principalColumn: "ID_TampOrder");
                    table.ForeignKey(
                        name: "FK_T_TampShoppingBasket_T_User_T_User_Id",
                        column: x => x.T_User_Id,
                        principalTable: "T_User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Address_T_City_Id",
                table: "T_Address",
                column: "T_City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Address_T_Ostan_Id",
                table: "T_Address",
                column: "T_Ostan_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Address_T_User_Id",
                table: "T_Address",
                column: "T_User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_City_T_Ostan_Id",
                table: "T_City",
                column: "T_Ostan_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Feedback_ID_Product_Id",
                table: "T_Feedback",
                column: "ID_Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Feedback_ID_UserSingup_Id",
                table: "T_Feedback",
                column: "ID_UserSingup_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_ImagesProduct_T_Product_Id",
                table: "T_ImagesProduct",
                column: "T_Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_LowOk_T_Ganoon_Id",
                table: "T_LowOk",
                column: "T_Ganoon_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_LowOk_T_User_Id",
                table: "T_LowOk",
                column: "T_User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Offer_ID_Prodect_Id",
                table: "T_Offer",
                column: "ID_Prodect_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Order_T_Address_Id",
                table: "T_Order",
                column: "T_Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Order_T_User_Id",
                table: "T_Order",
                column: "T_User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Payment_ID_User_Id",
                table: "T_Payment",
                column: "ID_User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Payment_T_Order_Id",
                table: "T_Payment",
                column: "T_Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Product_T_Category_Id",
                table: "T_Product",
                column: "T_Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_SearchHistory_T_User_Id",
                table: "T_SearchHistory",
                column: "T_User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_SendEmail_T_User_Id",
                table: "T_SendEmail",
                column: "T_User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_ShoppingBasket_T_Product_Id",
                table: "T_ShoppingBasket",
                column: "T_Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_ShoppingBasket_T_User_Id",
                table: "T_ShoppingBasket",
                column: "T_User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_TampOrder_T_Address_Id",
                table: "T_TampOrder",
                column: "T_Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_TampOrder_T_Order_Id",
                table: "T_TampOrder",
                column: "T_Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_TampOrder_T_User_Id",
                table: "T_TampOrder",
                column: "T_User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_TampShoppingBasket_T_Product_Id",
                table: "T_TampShoppingBasket",
                column: "T_Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_TampShoppingBasket_T_ShoppingBasket_Id",
                table: "T_TampShoppingBasket",
                column: "T_ShoppingBasket_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_TampShoppingBasket_T_TampOrder_Id",
                table: "T_TampShoppingBasket",
                column: "T_TampOrder_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_TampShoppingBasket_T_User_Id",
                table: "T_TampShoppingBasket",
                column: "T_User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_AboutUs");

            migrationBuilder.DropTable(
                name: "T_Feedback");

            migrationBuilder.DropTable(
                name: "T_ImagesProduct");

            migrationBuilder.DropTable(
                name: "T_LowOk");

            migrationBuilder.DropTable(
                name: "T_Offer");

            migrationBuilder.DropTable(
                name: "T_Payment");

            migrationBuilder.DropTable(
                name: "T_SearchHistory");

            migrationBuilder.DropTable(
                name: "T_SendEmail");

            migrationBuilder.DropTable(
                name: "T_TampShoppingBasket");

            migrationBuilder.DropTable(
                name: "T_Ganoon");

            migrationBuilder.DropTable(
                name: "T_ShoppingBasket");

            migrationBuilder.DropTable(
                name: "T_TampOrder");

            migrationBuilder.DropTable(
                name: "T_Product");

            migrationBuilder.DropTable(
                name: "T_Order");

            migrationBuilder.DropTable(
                name: "T_Category");

            migrationBuilder.DropTable(
                name: "T_Address");

            migrationBuilder.DropTable(
                name: "T_City");

            migrationBuilder.DropTable(
                name: "T_User");

            migrationBuilder.DropTable(
                name: "T_Ostan");
        }
    }
}
