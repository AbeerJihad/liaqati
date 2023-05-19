using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class Database : Migration
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
                    Fname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Exp_Years = table.Column<int>(type: "int", nullable: true),
                    Wieght = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatsApp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cover_photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "TblCategory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblChat",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiverID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblChat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblContactUs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneIntro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblContactUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblCoupon",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCoupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblExercises",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BodyFocus = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Difficulty = table.Column<int>(type: "int", nullable: true),
                    Detail = table.Column<string>(type: "NTEXT", nullable: true),
                    TraningType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    BurnEstimate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exerciseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RatePercentage = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblExercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblIngredent",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblIngredent", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "TblAchievements",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAchievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblAchievements_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblNotification",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblNotification_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblOrder",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    DiscountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStatus = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblOrder_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblArticles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsNumber = table.Column<int>(type: "int", nullable: false),
                    LikesNumber = table.Column<int>(type: "int", nullable: false),
                    avgReading = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblArticles_TblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblConsultation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ViewsNumber = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblConsultation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblConsultation_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblConsultation_TblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblHealthyRecipe",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "NTEXT", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DietaryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrepTime = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Total_Carbohydrate = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<int>(type: "int", nullable: false),
                    ViewsNumber = table.Column<int>(type: "int", nullable: false),
                    Ingredients = table.Column<string>(type: "NTEXT", nullable: true),
                    PreparationMethod = table.Column<string>(type: "NTEXT", nullable: true),
                    RatePercentage = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHealthyRecipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblHealthyRecipe_TblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TblCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblServices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "NTEXT", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RatePercentage = table.Column<double>(type: "float", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblServices_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblServices_TblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TblCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_TblChat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "TblChat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblChatUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblChatUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblChatUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblChatUser_TblChat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "TblChat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblComment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    repliedFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    articlesId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblComment_TblArticles_articlesId",
                        column: x => x.articlesId,
                        principalTable: "TblArticles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblReplyconsultation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Reply = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    consId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReplyconsultation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblReplyconsultation_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblReplyconsultation_TblConsultation_consId",
                        column: x => x.consId,
                        principalTable: "TblConsultation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblCartItem",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCartItem_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblCartItem_TblServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "TblServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblCommentServies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    repliedFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatePercentage = table.Column<double>(type: "float", nullable: false),
                    ServicesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCommentServies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCommentServies_TblServices_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblFavorite",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServicesId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthyRecipeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ExerciseId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ArticleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFavorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFavorite_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblFavorite_TblArticles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "TblArticles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblFavorite_TblExercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "TblExercises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblFavorite_TblHealthyRecipe_HealthyRecipeId",
                        column: x => x.HealthyRecipeId,
                        principalTable: "TblHealthyRecipe",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblFavorite_TblServices_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblFiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFiles_TblHealthyRecipe_HealthyId",
                        column: x => x.HealthyId,
                        principalTable: "TblHealthyRecipe",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblFiles_TblServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblMealPlans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numsubscribers = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: true),
                    DietaryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvgRecipeTime = table.Column<double>(type: "float", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BurnEstimate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMealPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblMealPlans_TblServices_Id",
                        column: x => x.Id,
                        principalTable: "TblServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblOrder_Details",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RateId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrder_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblOrder_Details_TblOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "TblOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblOrder_Details_TblServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblProducts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblProducts_TblServices_Id",
                        column: x => x.Id,
                        principalTable: "TblServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblSportsProgram",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    BodyFocus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BurnEstimate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSportsProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblSportsProgram_TblServices_Id",
                        column: x => x.Id,
                        principalTable: "TblServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblFavorite_Servies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServicesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FavoriteId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFavorite_Servies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFavorite_Servies_TblFavorite_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "TblFavorite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblFavorite_Servies_TblServices_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblMeal_Healthy",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MealPlansId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HealthyRecdpeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMeal_Healthy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblMeal_Healthy_TblHealthyRecipe_HealthyRecdpeId",
                        column: x => x.HealthyRecdpeId,
                        principalTable: "TblHealthyRecipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblMeal_Healthy_TblMealPlans_MealPlansId",
                        column: x => x.MealPlansId,
                        principalTable: "TblMealPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblCoupon_redemption",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Total_discount = table.Column<double>(type: "float", nullable: false),
                    RedemptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Order_DetailsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CouponId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCoupon_redemption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCoupon_redemption_TblCoupon_CouponId",
                        column: x => x.CouponId,
                        principalTable: "TblCoupon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblCoupon_redemption_TblOrder_Details_Order_DetailsId",
                        column: x => x.Order_DetailsId,
                        principalTable: "TblOrder_Details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblRate",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Review = table.Column<int>(type: "int", nullable: false),
                    review_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Order_DetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ExerciseId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthyRecipeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblRate_TblExercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "TblExercises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblRate_TblHealthyRecipe_HealthyRecipeId",
                        column: x => x.HealthyRecipeId,
                        principalTable: "TblHealthyRecipe",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblRate_TblOrder_Details_Order_DetailsId",
                        column: x => x.Order_DetailsId,
                        principalTable: "TblOrder_Details",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblExercies_program",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExerciseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SportsProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblExercies_program", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblExercies_program_TblExercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "TblExercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblExercies_program_TblSportsProgram_SportsProgramId",
                        column: x => x.SportsProgramId,
                        principalTable: "TblSportsProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracking_MealPlan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Iscomplete = table.Column<bool>(type: "bit", nullable: false),
                    Order_DetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Meal_HealthyId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracking_MealPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracking_MealPlan_TblMeal_Healthy_Meal_HealthyId",
                        column: x => x.Meal_HealthyId,
                        principalTable: "TblMeal_Healthy",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tracking_MealPlan_TblOrder_Details_Order_DetailsId",
                        column: x => x.Order_DetailsId,
                        principalTable: "TblOrder_Details",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblTracking",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Iscomplete = table.Column<bool>(type: "bit", nullable: false),
                    Order_DetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Exercies_programId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTracking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblTracking_TblExercies_program_Exercies_programId",
                        column: x => x.Exercies_programId,
                        principalTable: "TblExercies_program",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblTracking_TblOrder_Details_Order_DetailsId",
                        column: x => x.Order_DetailsId,
                        principalTable: "TblOrder_Details",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Cover_photo", "DateOfBirth", "Email", "EmailConfirmed", "Exp_Years", "Fname", "Gender", "Height", "Instagram", "Lname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "Specialization", "Twitter", "TwoFactorEnabled", "UserName", "WhatsApp", "Wieght" },
                values: new object[] { "1", 0, false, "d2df91c1-4ce1-43be-8cb1-1219c68269d7", "sssssssssssssssa", null, null, false, 10, "sssssssssssssss", 1, 120, null, "sssssssssssssss", false, null, null, null, null, null, false, "ssssssssssssssss", "f003f61b-3012-45d8-a3a5-cf427566f902", null, null, false, null, null, 120 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Message_ChatId",
                table: "Message",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_TblAchievements_UserId",
                table: "TblAchievements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblArticles_CategoryId",
                table: "TblArticles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCartItem_ServiceId",
                table: "TblCartItem",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCartItem_UserId",
                table: "TblCartItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblChatUser_ChatId",
                table: "TblChatUser",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_TblChatUser_UserId",
                table: "TblChatUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblComment_articlesId",
                table: "TblComment",
                column: "articlesId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCommentServies_ServicesId",
                table: "TblCommentServies",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_TblConsultation_CategoryId",
                table: "TblConsultation",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblConsultation_UserId",
                table: "TblConsultation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCoupon_redemption_CouponId",
                table: "TblCoupon_redemption",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCoupon_redemption_Order_DetailsId",
                table: "TblCoupon_redemption",
                column: "Order_DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_TblExercies_program_ExerciseId",
                table: "TblExercies_program",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblExercies_program_SportsProgramId",
                table: "TblExercies_program",
                column: "SportsProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavorite_ArticleId",
                table: "TblFavorite",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavorite_ExerciseId",
                table: "TblFavorite",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavorite_HealthyRecipeId",
                table: "TblFavorite",
                column: "HealthyRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavorite_ServicesId",
                table: "TblFavorite",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavorite_UserId",
                table: "TblFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavorite_Servies_FavoriteId",
                table: "TblFavorite_Servies",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavorite_Servies_ServicesId",
                table: "TblFavorite_Servies",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFiles_HealthyId",
                table: "TblFiles",
                column: "HealthyId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFiles_ServiceId",
                table: "TblFiles",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TblHealthyRecipe_CategoryId",
                table: "TblHealthyRecipe",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblMeal_Healthy_HealthyRecdpeId",
                table: "TblMeal_Healthy",
                column: "HealthyRecdpeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblMeal_Healthy_MealPlansId",
                table: "TblMeal_Healthy",
                column: "MealPlansId");

            migrationBuilder.CreateIndex(
                name: "IX_TblNotification_UserId",
                table: "TblNotification",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrder_UserId",
                table: "TblOrder",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrder_Details_OrderId",
                table: "TblOrder_Details",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrder_Details_ServiceId",
                table: "TblOrder_Details",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TblRate_ExerciseId",
                table: "TblRate",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblRate_HealthyRecipeId",
                table: "TblRate",
                column: "HealthyRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblRate_Order_DetailsId",
                table: "TblRate",
                column: "Order_DetailsId",
                unique: true,
                filter: "[Order_DetailsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TblReplyconsultation_consId",
                table: "TblReplyconsultation",
                column: "consId");

            migrationBuilder.CreateIndex(
                name: "IX_TblReplyconsultation_UserId",
                table: "TblReplyconsultation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblServices_CategoryId",
                table: "TblServices",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblServices_UserId",
                table: "TblServices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblTracking_Exercies_programId",
                table: "TblTracking",
                column: "Exercies_programId");

            migrationBuilder.CreateIndex(
                name: "IX_TblTracking_Order_DetailsId",
                table: "TblTracking",
                column: "Order_DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracking_MealPlan_Meal_HealthyId",
                table: "Tracking_MealPlan",
                column: "Meal_HealthyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracking_MealPlan_Order_DetailsId",
                table: "Tracking_MealPlan",
                column: "Order_DetailsId");
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
                name: "Message");

            migrationBuilder.DropTable(
                name: "TblAchievements");

            migrationBuilder.DropTable(
                name: "TblCartItem");

            migrationBuilder.DropTable(
                name: "TblChatUser");

            migrationBuilder.DropTable(
                name: "TblComment");

            migrationBuilder.DropTable(
                name: "TblCommentServies");

            migrationBuilder.DropTable(
                name: "TblContactUs");

            migrationBuilder.DropTable(
                name: "TblCoupon_redemption");

            migrationBuilder.DropTable(
                name: "TblFavorite_Servies");

            migrationBuilder.DropTable(
                name: "TblFiles");

            migrationBuilder.DropTable(
                name: "TblIngredent");

            migrationBuilder.DropTable(
                name: "TblNotification");

            migrationBuilder.DropTable(
                name: "TblProducts");

            migrationBuilder.DropTable(
                name: "TblRate");

            migrationBuilder.DropTable(
                name: "TblReplyconsultation");

            migrationBuilder.DropTable(
                name: "TblTracking");

            migrationBuilder.DropTable(
                name: "Tracking_MealPlan");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TblChat");

            migrationBuilder.DropTable(
                name: "TblCoupon");

            migrationBuilder.DropTable(
                name: "TblFavorite");

            migrationBuilder.DropTable(
                name: "TblConsultation");

            migrationBuilder.DropTable(
                name: "TblExercies_program");

            migrationBuilder.DropTable(
                name: "TblMeal_Healthy");

            migrationBuilder.DropTable(
                name: "TblOrder_Details");

            migrationBuilder.DropTable(
                name: "TblArticles");

            migrationBuilder.DropTable(
                name: "TblExercises");

            migrationBuilder.DropTable(
                name: "TblSportsProgram");

            migrationBuilder.DropTable(
                name: "TblHealthyRecipe");

            migrationBuilder.DropTable(
                name: "TblMealPlans");

            migrationBuilder.DropTable(
                name: "TblOrder");

            migrationBuilder.DropTable(
                name: "TblServices");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TblCategory");
        }
    }
}
