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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ReceiverID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblChat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblCoupon",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    RatePercentage = table.Column<double>(type: "float", nullable: true)
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
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                name: "TblContactUs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblContactUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblContactUs_AspNetUsers_UserId",
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RatePercentage = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    articlesId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                name: "TblCartItem",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Comment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    repliedFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServicesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    HealthyId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ServiceId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    Discount = table.Column<double>(type: "float", nullable: false)
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
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    FavoriteId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    CouponId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    HealthyRecipeId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    Week = table.Column<int>(type: "int", nullable: false)
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
                name: "Tracking",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Iscomplete = table.Column<bool>(type: "bit", nullable: false),
                    Order_DetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Exercies_programId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracking_TblExercies_program_Exercies_programId",
                        column: x => x.Exercies_programId,
                        principalTable: "TblExercies_program",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tracking_TblOrder_Details_Order_DetailsId",
                        column: x => x.Order_DetailsId,
                        principalTable: "TblOrder_Details",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Cover_photo", "DateOfBirth", "Email", "EmailConfirmed", "Exp_Years", "Fname", "Gender", "Height", "Instagram", "Lname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "Specialization", "Twitter", "TwoFactorEnabled", "UserName", "WhatsApp", "Wieght" },
                values: new object[] { "1", 0, false, "260d7852-6ab8-42bd-b341-972c53d7f0b5", "sssssssssssssssa", null, null, false, 10, "sssssssssssssss", 1, 120, null, "sssssssssssssss", false, null, null, null, null, null, false, "ssssssssssssssss", "04611dd2-9df0-4345-ab54-9b160f394acf", null, null, false, null, null, 120 });

            migrationBuilder.InsertData(
                table: "TblCategory",
                columns: new[] { "Id", "Description", "Name", "Target" },
                values: new object[,]
                {
                    { "1", null, "طبق رئيسي", "الوصفات الصحية" },
                    { "10", null, "رياضة", "المنتجات" },
                    { "11", null, "مرض السكري", "المنتجات" },
                    { "12", null, "شرب المياة", "المنتجات" },
                    { "2", null, "أكل صحي", "الوصفات الصحية" },
                    { "3", null, "المكملات الغذائية", "المنتجات" },
                    { "4", null, "الاجهزة الرياضية", "المنتجات" },
                    { "5", null, "حلوى", "الوصفات الصحية" },
                    { "6", null, "الأنظمة الحديثة", "الأنظمة الرياضية" },
                    { "8", null, "عامة", "المنتجات" },
                    { "9", null, "الصيام المتقطع", "المقالات" }
                });

            migrationBuilder.InsertData(
                table: "TblExercises",
                columns: new[] { "Id", "BodyFocus", "BurnEstimate", "Detail", "Difficulty", "Duration", "Equipments", "Image", "Price", "RatePercentage", "ShortDescription", "Title", "TraningType", "Video", "exerciseDate" },
                values: new object[,]
                {
                    { "1", "الجسم بالكامل", "50-250", "هذا التدفق هو واحد من المفضلة. عندما أستيقظ في الصباح ، أحب أن أبدأ يومي بتمديدات روتينية من شأنها أن تجعل دمي يتدفق ، وطاقي ، وتضبط نغمة اليوم. هذه الممارسة ستجعلك تتعرق وتساعد جسمك على تخفيف الضغط في نفس الوقت. تخلق أنماط الحركة ذاكرة حسية يمكننا البناء عليها. بدءًا من نمط التنفس ، تهدف كل حركة إلى مطابقة كل شهيق أو زفير لتشجيع التنفس العميق الذي يعزز الشعور بالتوتر ، ويزيد من مستوى الطاقة والاسترخاء ، ويثبت ضغط الدم. إذا ركزت على أنفاسك ، فسوف يهدأ عقلك. فيما يلي بعض إشارات المحاذاة التي يجب وضعها في الاعتبار للسلامة في Low Lunge:\r\n\r\nابدأ في اندفاع العداء ، والساق اليمنى للأمام مع الركبة فوق الكاحل والركبة اليسرى على الأرض مع وضع الجزء العلوي من قدمك على السجادة. ارفع الجذع ببطء وضع يديك برفق على الفخذ الأيمن. تميل الوركين إلى الأمام قليلاً ، مع إبقاء الركبة اليمنى خلف أصابع القدم ، والشعور بالتمدد في ثني الورك الأيسر. امسك هنا ، أو لتمتد أعمق ، ارفع الذراعين فوق الرأس ، والعضلة ذات الرأسين من الأذنين. استمر لمدة 30 ثانية على الأقل ، ثم كرر على الجانب الآخر. تتضمن عضلات الجسم المنخفضة المستهدفة في هذا التسلسل أوتار الركبة ، وثني الورك ، والرباعية ، والألوية. في كل مرة نتنقل فيها عبر نمط الحركة ، سيكون هناك موقف أو وضعان مضافان إلى التسلسل. التكرار مع كل الجسم للانفتاح على كل شكل تدريجيًا.", 3, 27, "حصيرة ، معدات اليوجا", "/images/Exercise/1.png", 0.0, 50.0, null, "اليوجا الصباحية للجسم بالكامل", "تدريب القوة", "https://www.youtube.com/watch?v=w5y3Zl1F5Vs", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "10", "جوهر", "50-250", "\r\nإذا كنت تمارس هذا التمرين بهدف بناء القوة و / أو الكتلة ، فإليك بعض الأشياء التي يجب وضعها في الاعتبار.\r\n\r\nأولاً ، كما هو الحال مع أي تمرين قوي أو جماعي ، لا ترفع كثيرًا حتى يبدأ شكلك أو نطاق حركتك في المعاناة. إذا كنت قد قمت في أي وقت مضى بواحد من إجراءات قوتنا من أي نوع من قبل ، فمن المحتمل أنك سمعتنا بالفعل نقول هذا مرارًا وتكرارًا ؛ شكل ونطاق الحركة أكثر أهمية بكثير من مقدار الوزن الذي ترفعه عندما يتعلق الأمر بالقوة الوظيفية الخالية من الإصابات.\r\n\r\nثانيًا ، حدد الوزن الذي تستخدمه بناءً على معدل التعب لديك. يجب أن يكون هدفك هو استخدام وزن ثقيل بدرجة كافية بحيث يمكنك إجراء جميع عمليات التكرار تقريبًا بشكل مثالي ونطاق كامل من الحركة. يجب السماح للمعاناة في آخر 2 أو 3 مرات فقط لأن هذه العضلات تصبح مرهقة للغاية بحيث لا يمكن الحفاظ عليها نظيفة.\r\n\r\nثالثًا ، عندما تتخلى عضلاتك عن تلك التكرارات القليلة الأخيرة ، ابدأ في التركيز حقًا على الحركة \"السلبية\". يُعرف بشكل أكثر رسميًا باسم الانقباض غريب الأطوار ، والسالب هو النقطة التي يتغلب فيها الحمل على القوة التي يمكن للعضلة أو تقدمها والمبتدئين في إطالة العضلات. على سبيل المثال ، عند أداء تمرين الدمبل ، فإن المرحلة اللامتراكزة هي عندما يتراجع الدمبل إلى أسفل من الكتف ، مما يؤدي إلى إطالة عضلات البايسبس. من خلال التركيز على هذه الحركة ومحاولة التحكم في المرحلة اللامركزية ، يمكنك الحصول على مزيد من التمزقات الدقيقة في ألياف عضلاتك ، مما يؤدي إلى درجة أعلى من التقدم لزيادة القوة والحجم في العضلات التي تعمل. لذلك ، عندما تبدأ في الشعور بالتعب ، لا تدع هذا الوزن ينخفض فقط. إن بذل قصارى جهدك لمحاربة فقدان الوزن هو أهم جزء في روتين قوتك بالكامل.\r\n\r\nأخيرًا ، تأكد من ضبط الوزن الذي تستخدمه لكل مجموعة ، حسب الحاجة. لا تتعثر في عقلية أن ما تبدأ به يجب أن ينتهي به. بالنسبة لبعض التمارين ، قد تشعر أنه يمكنك زيادة وزنك والبعض الآخر قد تحتاج إلى إنقاصه ، وقد يكون ذلك لمجموعة واحدة فقط قبل التغيير مرة أخرى. جسمك هو آلة ديناميكية دائمة التغير ، لذلك عليك أن تكون قادرًا على التغيير والتكيف مع احتياجاته يوميًا ، إن لم يكن دقيقة بدقيقة.", 3, 37, " دمبل  ، بدون معدات ", "/images/Exercise/9.png", 0.0, 50.0, null, "روتين القوة الأساسية الموزونة - روتين أوزان الدمبل في المنزل", "الحركة", "https://www.youtube.com/watch?v=pnNCuecyZnQ", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2", "الجسم بالكامل", "50-250", "إذا كنت تريد ممارسة تمرينات رياضية فعالة في أقل من 25 دقيقة ، فلا داعي لمزيد من البحث. هذا مزيج قصير ولطيف بين نمطي تدريب مهمين: تدريب القوة وتمارين القلب والأوعية الدموية. يتم تقديم تعديلات عالية ومنخفضة التأثير حتى تتمكن من مقابلة جسمك تمامًا في مكانه.                        عندما يتعلق الأمر بالحصول على أقصى درجات \"الضجة\" لوقتك ، يمكن أن تكون قوة الاقتران وتمارين القلب فعالة للغاية. يسمح لنا تدريب القوة ببناء العضلات الخالية من الدهون بينما تحافظ تمارين القلب والأوعية الدموية على ارتفاع معدل ضربات القلب. يعملان معًا على تعزيز عملية التمثيل الغذائي وإطلاق الطاقة لتغذية يومك!\r\n\r\nكنت مؤخرًا أحضر فصلًا لركوب الدراجات حيث قال المدرب ، \"ما هي أفضل طريقة للاحتفال بجسدك من الشعور بإطلاق الطاقة والقوة التي يحملها جسمك؟\" لا يمكن اقبل المزيد. هذا التمرين هو النوع الذي يبدو وكأنه احتفال بما يمكن أن يفعله جسمك. دون أن تكون شديدة أو معتدلة للغاية ، فإنها تهبط في المنتصف تمامًا \"للاحتفال\" التمكيني والحيوي ، إذا رغبت في ذلك.", 3, 23, "دمبل", "/images/Exercise/2.png", 0.0, 50.0, null, "تمارين تقوية الجسم بالكامل وتمارين القلب", "الحركة", "https://www.youtube.com/watch?v=R58oVgVgRlc", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3", "الجزء العلوي من الجسم", "50-250", "أولاً ، سنركز على الصدر ، بدءًا من مكابس الأرضية ثم الانتقال بسرعة إلى ذبابة الصدر والانتهاء بضغطة سحق. بعد مجموعتين من تمارين الصدر ، سننتقل إلى الخلف ، بدءًا من الصفوف المنحنية ، والانتقال إلى الذباب العكسي ، والانتهاء من صف yates. مجموعتنا التالية سوف تستهدف الذراعين ، في المقام الأول العضلة ثلاثية الرؤوس والعضلة ذات الرأسين. بالنسبة لمجموعات الترايسبس لدينا ، نحتاج فقط إلى دمبل واحد. سنبدأ المجموعات بضغطة دمبل مفردة بقبضة قريبة ، وننتقل إلى كسارة جمجمة دمبل واحدة ، ثم ننتقل إلى تمديدات ثلاثية الرؤوس العلوية. (سوف تحترق عضلاتك ثلاثية الرؤوس ، لول). مجموعتنا التالية هي إحدى الطرق المفضلة لتدريب العضلة ذات الرأسين. سنستخدم المقاييس المتساوية لدفع العضلة ذات الرأسين هنا. تمريننا الأول هو ما أحب أن أسميه تجعيد الشعر أحادي الذراع ؛ سنقوم بعمل كل ذراع على حدة مع تلك قبل الانتهاء من تمارين العضلة ذات الرأسين القياسية. هذا المزيج يعمل دائمًا مع العضلة ذات الرأسين! في مجموعتنا النهائية ، سنركز على أكتافنا. سنبدأ العمل بضغط الكتف القياسي ، والانتقال إلى صفوفنا المستقيمة ، وإنهاء المجموعة مع صف دلتا الخلفي الذي يستهدف عضلات الدالية الصغيرة - مما يجعل هذه الطريقة المثالية لإنهاء تمرين الجزء العلوي من الجسم.", 4, 37, "دمبل", "/images/Exercise/3.png", 0.0, 50.0, null, "مجموعات القوة المركبة للجزء العلوي من الجسم", "تدريب القوة", "https://www.youtube.com/watch?v=fPlN4amOMY8", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4", "الجسم بالكامل", "50-250", "أولاً ، سنركز على الصدر ، بدءًا من مكابس الأرضية ثم الانتقال بسرعة إلى ذبابة الصدر والانتهاء بضغطة سحق. بعد مجموعتين من تمارين الصدر ، سننتقل إلى الخلف ، بدءًا من الصفوف المنحنية ، والانتقال إلى الذباب العكسي ، والانتهاء من صف yates. مجموعتنا التالية سوف تستهدف الذراعين ، في المقام الأول العضلة ثلاثية الرؤوس والعضلة ذات الرأسين. بالنسبة لمجموعات الترايسبس لدينا ، نحتاج فقط إلى دمبل واحد. سنبدأ المجموعات بضغطة دمبل مفردة بقبضة قريبة ، وننتقل إلى كسارة جمجمة دمبل واحدة ، ثم ننتقل إلى تمديدات ثلاثية الرؤوس العلوية. (سوف تحترق عضلاتك ثلاثية الرؤوس ، لول). مجموعتنا التالية هي إحدى الطرق المفضلة لتدريب العضلة ذات الرأسين. سنستخدم المقاييس المتساوية لدفع العضلة ذات الرأسين هنا. تمريننا الأول هو ما أحب أن أسميه تجعيد الشعر أحادي الذراع ؛ سنقوم بعمل كل ذراع على حدة مع تلك قبل الانتهاء من تمارين العضلة ذات الرأسين القياسية. هذا المزيج يعمل دائمًا مع العضلة ذات الرأسين! في مجموعتنا النهائية ، سنركز على أكتافنا. سنبدأ العمل بضغط الكتف القياسي ، والانتقال إلى صفوفنا المستقيمة ، وإنهاء المجموعة مع صف دلتا الخلفي الذي يستهدف عضلات الدالية الصغيرة - مما يجعل هذه الطريقة المثالية لإنهاء تمرين الجزء العلوي من الجسم. ", 4, 23, "دمبل", "/images/Exercise/4.png", 0.0, 50.0, null, "مجموعة القلب والقوة", "اليوجا", "https://www.youtube.com/watch?v=d8QcqQA0zIQ", new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5", "جوهر", "50-250", "يعد هذا التمرين القصير الذي يركز على النواة إضافة رائعة لروتين الجسم السفلي أو العلوي أو الكلي - ولكنه أيضًا خيار رائع كتمرين مستقل لحركتك الأساسية في اليوم. استخدم الإحماء أحادي الدورة لتهيئة عضلاتك الأساسية جسديًا للدوائر الصعبة ولكن القابلة للتكيف التي تليها ، ولكن ركز أيضًا على التدفق ببطء خلال كل تمرين لتنشيط اتصال العقل والعضلات لتوظيف العضلات بكفاءة.\r\n\r\n\r\n\r\n\r\nتحتوي كل دائرة على تمارين تجمع بين الإمساك المتساوي القياس وأنماط الحركة الديناميكية ولكن المتحكم فيها والتركيز على الاستقرار الأساسي. هذه التمارين لن تقوي فقط عضلات البطن (التي تشمل عضلات البطن ، الألوية ، عضلات الفخذ ، وعضلات الظهر السفلية) مع حركات الانثناء / الطحن التقليدية ، بل ستعمل أيضًا على تحسين مشاركة عضلات الجسم الكلية وتكامل الحركة (التدفق).\r\n\r\nلاحظ أنه لا يوجد سوى عدد قليل من التمارين المتعلقة بلوح في هذا التمرين ؛ لذلك ، إذا كانت لديك مخاوف من ألم الرسغ أثناء تمارين اللوح / وضعية الانبطاح ، فقد يكون هذا الروتين خيارًا رائعًا للاحتفاظ به في مجموعتك من أجل إجراءات الانتقال الأساسية المستقبلية. من الاعتبارات المهمة للجميع الحفاظ على ثنية طفيفة في الحوض أثناء تمارين وضعية الاستلقاء (الوجه لأعلى) والمنبطحة (الوجه لأسفل / اللوح الخشبي). على سبيل المثال ، أثناء الجزء الميت من تسلسل التنشيط بالإضافة إلى تمرين لوح الساعد في الدائرة رقم 1 ، تخيل أنك تقوم بإدخال عظام الفخذ إلى ضلوعك - قم بإمالة الجزء العلوي من عظام الحوض قليلاً إلى الأعلى والعودة باتجاه الجزء السفلي من القفص الصدري الخاص بك.\r\n\r\nفيما يلي بعض النصائح الإضافية لجعل هذا الروتين تجربة مُرضية لك:\r\n\r\nتشمل التعديلات لجميع التمارين تقليل نطاق الحركة و / أو ثني ركبتيك (تقصير الرافعة) لأي حركات تتضمن اختلافات في تمديد الساق.\r\nلاحظ التمارين الأكثر صعوبة بالنسبة لك وحدد الاختلافات في نطاقات الحركة والقوة وعدد التكرارات للتمارين ذات التركيز الأحادي (مثل v-ups المائلة). سيساعدك الانتباه إلى أكثر الاختلافات دقة في توجيه تركيزك أثناء المحاولات المستقبلية في هذا التمرين.\r\nلا تتردد في تكرار دائرة التبريد القصيرة لتمديد ممتد أو إضافة الامتدادات الخاصة بك لمساعدتك على العودة إلى حالة الاسترخاء والحيوية. يجب أن تشعر كما لو أن عضلاتك \"تعمل\" خلال هذا الروتين ولكن لا تزال تنتهي بعقلية \"جاهزة للتعامل مع أي شيء قادم\".\r\nيتمتع!", 3, 19, "حصيرة", "/images/Exercise/5.png", 0.0, 50.0, null, "دوائر القوة الأساسية السريعة و الجوهر", "تدريب القوة", "https://www.youtube.com/watch?v=B5ZZqBslKU0", new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6", "الجسم بالكامل", "50-250", "\r\nتساعد التدريبات أحادية الجانب على تعزيز المشاركة الأساسية ، وبالتالي تحسين الأساس الذي تبدأ منه كل الحركات.\r\nتعمل عضلاتك معًا بشكل تآزري لتقوية السلسلة الحركية بأكملها ، مما يقلل من فرص السقوط أو العثرات الضارة المحتملة أثناء الأنشطة المعتادة للحياة اليومية.\r\nيمكن أن يساعدك العمل المتوازن في تحديد مناطق الضعف والكتل المحتملة نحو تحسين الأداء الرياضي وكذلك تحسين التنسيق لأنماط الحركة المتقدمة والتمارين التي تحركها القوة.\r\nالتدريبات مع تحديات التوازن تعمل على تحسين الاتصال بين العقل والجسم. يؤدي هذا الاتصال المعزز إلى زيادة القدرة على التحمل الذهني والفعالية الذاتية اللازمة لإكمال التدريبات الصعبة.\r\nتوفر مثل هذه التدريبات استراحة من البلى من التدريب على التأثير وتتحدى الدماغ لطرق بديلة لمعالجة وعي العقل والجسم من أجل نهج شامل للياقة البدنية.\r\nكل حركة في هذا التمرين لها درجات متفاوتة من التوازن في العمل. أثناء دورات القوة ، ستكمل كل تمرين لمدة 45 ثانية ، وهي فترة زمنية كافية لتتعرف تمامًا على كل حركة. تؤدي إضافة درجة صغيرة من التوازن أثناء هذه الحركات التي تركز على القوة إلى زيادة وقت العضلات تحت التوتر للمساعدة في بناء القوة. بمجرد الانتقال إلى موازنة قطاعات العمل ، استفد من تنشيط العضلات الذي حدث أثناء دوائر القوة لتحقيق أقصى استفادة من الفواصل الزمنية التي تبلغ دقيقة واحدة والتركيز على الاستقرار.\r\n\r\nسأعترف ، لقد استمتعت تمامًا بالحركة بسرعة أبطأ من التدريبات المعتادة مع هذه الجلسة التي تركز على التوازن. لبضعة أيام بعد ذلك ، لاحظت أن العديد من العضلات شعرت بـ \"الاستيقاظ\" مع نوع صحي جيد من القرحة التي سمحت لي بمعرفة أنني كنت أهمل مجموعات عضلية معينة وطرق التدريب. خذ وقتك مع كل حركة واستمع إلى الملاحظات التي يقدمها لك جسمك. استمتع!", 3, 45, "حصيرة", "/images/Exercise/6.png", 0.0, 50.0, null, "دارات تقوية الجسم الكلي مع عمل التوازن", "القلب والأوعية الدموية", "https://www.youtube.com/watch?v=UzAFN61CiVQ", new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7", "الجسم بالكامل", "50-250", "في منتصف عام 2022 ، قمت بتصوير تمرين بدا أن عددًا كبيرًا منكم يحبه حقًا. كان قسم التعليقات مليئًا بطلبات لتصوير المزيد مثله ، وعلى الرغم من أنني كنت أمتلك مجموعة من التدريبات الأخرى المطلوبة للحصول عليها أولاً ، إلا أنني لم أنس هذا التمرين (بفضل Kelli لتذكيري) وقمت ببناء علامة تجارية جديدة نسخة منه مع جميع التدريبات الجديدة. بالنسبة لأولئك منكم الذين لم يجربوا النسخة الأصلية ، يمكنك إلقاء نظرة هنا أو - بل أفضل - جرب كلاهما وأخبرني ما إذا كان هذا الإصدار الجديد يتوافق مع نفس المعيار.\r\n\r\n\r\n\r\n\r\nسواء كنت قد جربت الإصدار الأصلي أم لا ، لا يهم ، حيث إن كلاهما تمرين مستقل مصمم لروتين كامل للجسم متوازن. يحتوي هذا التمرين الذي يستغرق 26 دقيقة على كل شيء: الإحماء ، والتهدئة ، وفترات HIIT للقلب ، ومجموعات القوة ، والتمارين الأساسية ، كل ذلك في فاصل زمني سريع بأسلوب Tabata للحفاظ على هذا التمرين سريعًا.\r\n\r\nتم بناء كل مجموعة من المجموعات الأربع في هذا الروتين بنفس الطريقة تمامًا ولكن مع تمارين فريدة في كل مرة. تتكون المجموعات من تمرين HIIT من أجل انفجار القلب ، يليه تمرين قوة متعدد السلاسل لزيادة إجهاد العضلات ومكاسب القوة ، ثم ننهيها بتمرين أساسي للمتعة فقط. على الرغم من أن هذا التمرين قصير ، إلا أنه يحزم لك بالتأكيد ، خاصة إذا كنت تتحدى نفسك في مجموعات القوة.\r\n\r\nأيضًا ، إذا كنت تريد تحديًا إضافيًا لكامل الجسم ، فحاول القيام بكل من هذين التمرينين معًا أو كل منهما مرتين خلال تمرين كامل للجسم لمدة ساعة تقريبًا.", 4, 26, "حصيرة ، دمبل  ، بدون معدات ", "/images/Exercise/7.png", 0.0, 50.0, null, "مجموعة سريعة من تمارين القلب والقوة و الجوهر  لكامل الجسم", "تدريب القوة", "https://www.youtube.com/watch?v=3xR8ZKVALwo", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8", "الجسم بالكامل ", "50-250", "في تمرين اليوم نركز على السرعة. تم تصميم هذا التمرين القصير ولكن الفعال ليوفر لك تمرينًا جيدًا في أقصر وقت ممكن لتلك الأيام التي ربما لم تكن قد مارستها فيها على الإطلاق. لقد صممت هذا التمرين بعد نوبة أخيرة من العمل المكثف ومتطلبات الحياة التي ضربت في نفس الوقت ، مما يجعل التمرين لمدة 20 دقيقة يبدو كثيرًا.\r\n\r\nلقد صممت هذا الروتين عن قصد لاستخدامه بسهولة في تخصيصين مختلفين للوقت: إصدار سريع يأخذك خلال مقطع فيديو التمرين الكامل هذا ويبلغ أقصى حد له 15 دقيقة ، وإصدار فائق السرعة يأخذك خلال جزء \"التمرين\" لـ نصف الوقت مع قطع الطول الإجمالي إلى حوالي 10 دقائق.\r\n\r\nيتم إجراء كل هذا الروتين بنفس بنية الفاصل الزمني 20 تشغيل و 10 إيقاف لإبقائه سريعًا وبسيطًا. لقد قمت بتضمين إحماء سريع مدته 3 دقائق يتم تشغيله مباشرة في التمرين لتقليل أي توقف مؤقت غير ضروري ؛ تذكر أن هذا كله يتعلق بالكفاءة حتى نتمكن من الحصول على أفضل تدريب ممكن في أقصر وقت ممكن. لذلك ، بعد تمارين الإحماء الستة ، ننتقل مباشرة إلى التمارين الثمانية لقسم التمرين. هذا هو المكان الذي يمكنك فيه الاختيار من خلال هذه التدريبات الثمانية مرة واحدة أو مرتين. أعطي دعوة واضحة عندما ننتهي من أول تشغيل لهذه التمارين حتى تتمكن من اتخاذ قرار التخطي إلى فترة التهدئة السريعة التي تبلغ 3 دقائق والقيام بها في حوالي 10 دقائق أو إجراء التمارين مرة ثانية (كما أفعل في الفيديو) ويتم الانتهاء منه في حوالي 15 دقيقة. بهذه الطريقة يمكنك تحديد مقدار الوقت الذي يمكنك تخصيصه لهذا التمرين.\r\n\r\nهذا تمرين شامل للجسم ، لذا إذا كنت تستخدمه بعد يوم مكثف من الجزء العلوي أو السفلي من الجسم ، ففي كلتا الحالتين من المرجح أنك تستخدم بعض مجموعات العضلات نفسها. لا تقلق ، على الرغم من ذلك - ستفعل ذلك بوزن الجسم فقط حتى تتمكن من التكيف لجعل التمارين أسهل أو أصعب ، وستقوم فقط ببضع عمليات التكرار لكل منها ، لذلك لا داعي للقلق بشأن إرهاق العضلات المؤلمة.\r\n\r\nمع ذلك ، يمكن أيضًا استخدام هذا كتمرين إضافي إذا كنت تريد القيام بتمرين ثانٍ في يوم واحد. يمكن القيام بذلك إما مباشرة بعد التمرين الأول أو في وقت لاحق من اليوم للحصول على نوبة إضافية من حرق السعرات الحرارية.", 4, 23, "دمبل", "/images/Exercise/8.png", 0.0, 50.0, null, "تمرين الجسم الكلي السريع - 10 أو 15 دقيقة تختارها", "اليوجا", "https://www.youtube.com/watch?v=xafq0q5lIq4", new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9", "الجسم السفلي", "50-250", "يمكن استخدام تمرين الجزء السفلي من الجسم هذا للتناغم أو القوة أو بناء الكتلة ، بحيث يمكنك استخدامه لما تحتاجه بالضبط. في هذا الروتين ، قمنا بتقسيم التمرين إلى ثلاث مجموعات (لا تشمل الإحماء والتهدئة). سيتم إجراء أول مجموعتين بأسلوب فاصل من 45 ثانية من النشاط مع 15 ثانية من الراحة للاستعداد للتمرين التالي. تحتوي كل مجموعة من هاتين المجموعتين الأوليين على 4 تمارين لكل منهما ، وسيتم إجراؤها بنمط A ، B A ، B بالتناوب ، بالتناوب ذهابًا وإيابًا بين اثنين من التمارين الأربعة في وقت واحد. سيتم إجراء كل تمرين لما مجموعه ثلاث مجموعات قبل الانتقال إلى التدريبات التالية ، مما يمنحنا إجمالي 12 فترة لكل مجموعة لأول مجموعتين. ستتم المجموعة الأخيرة قبل فترة التهدئة والتمدد بشكل مختلف. على الرغم من وجود أربعة تمارين مرة أخرى في هذه المجموعة ، فإننا سنقوم بدلاً من ذلك بإجراء كل تمرين لمجموعة واحدة فقط باستخدام فترات 60 ثانية على و 15 ثانية راحة. هذا المزيج من مجموعتين باستخدام ثلاث مجموعات تقليدية أكثر لكل تمرين متبوعًا بمجموعة تستخدم مجموعة نضوب واحدة سيسمح لنا بإرهاق العضلات بشكل فعال إلى الحد الذي يمكننا فيه الحصول على التمزقات الدقيقة في عضلاتنا التي تؤدي إلى زيادة القوة والكتلة.\r\nمع ما يقال ، تذكر أنه يمكنك التحكم بالضبط في النتائج التي تحصل عليها من هذا الروتين عن طريق ضبط الوزن الذي تختار رفعه ومدى سرعة القيام بكل تكرار. للحصول على تمرين أكثر تركيزًا على التنغيم ، استخدم وزن الجسم فقط أو الوزن الخفيف جدًا وتحرك بسرعة أكبر (طالما أنك لا تزال تتحرك مع التحكم ولا تستخدم الزخم للمساعدة في إكمال الحركة التي يتم إجراؤها). إذا كنت تريد التركيز أكثر على بناء الحجم الكلي للعضلات ، فحافظ على بطء حركاتك واختر أثقل وزن يمكنك التحكم فيه من خلال نطاق كامل من الحركة. مع بناء الكتلة ، يجب أن يكون هدفك هو الحصول على 90-100 ٪ من كل مجموعة من أول مجموعتين (من أي تمرين معين) قبل أن تبدأ عضلاتك في الاستسلام ويبدأ شكلك في المعاناة. يجب أن يكون الهدف من المجموعة الثالثة (الأخيرة) من كل تمرين هو إكمال 80-90٪ من الفاصل الزمني قبل أن تستسلم عضلاتك.", 4, 43, "دمبل", "/images/Exercise/9.png", 0.0, 50.0, null, "تقوية اعضاء الجسم السفلية - تمرين الفخذ لمدة 43 دقيقة", "تدريب القوة", "https://www.youtube.com/watch?v=ABDmiZD1TDU", new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TblHealthyRecipe",
                columns: new[] { "Id", "Calories", "CategoryId", "CreatedDate", "Description", "DietaryType", "Image", "Ingredients", "IsFeatured", "MealType", "PrepTime", "PreparationMethod", "Price", "Protein", "RatePercentage", "ShortDescription", "Title", "Total_Carbohydrate", "ViewsNumber" },
                values: new object[,]
                {
                    { "41", 491, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1840), null, "Omnivore", "/images/HealthyRecipes/1.jpg", null, null, "Dinner", 50, null, null, 35, null, null, null, 43, 0 },
                    { "42", 156, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1974), null, "Vegetarian", "/images/HealthyRecipes/2.jpg", null, null, "Snack", 5, null, null, 4, null, null, null, 17, 0 },
                    { "43", 379, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1979), null, "Omnivore", "/images/HealthyRecipes/3.jpg", null, null, "Lunch", 50, null, null, 32, null, null, null, 47, 0 },
                    { "44", 19, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2121), null, "Vegetarian", "/images/HealthyRecipes/4.jpg", null, null, "Snack", 60, null, null, 5, null, null, null, 37, 0 },
                    { "45", 170, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2127), null, "Omnivore", "/images/HealthyRecipes/5.png", null, null, "Snack", 60, null, null, 5, null, null, null, 43, 0 },
                    { "46", 180, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2131), null, "Vegetarian", "/images/HealthyRecipes/6.jpg", null, null, "Lunch", 30, null, null, 4, null, null, null, 44, 0 },
                    { "47", 538, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2136), null, "Omnivore", "/images/HealthyRecipes/7.jpg", null, null, "Dinner", 35, null, null, 37, null, null, null, 79, 0 },
                    { "48", 30, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2140), null, "Vegetarian", "/images/HealthyRecipes/8.jpg", null, null, "Breakfast", 10, null, null, 5, null, null, null, 10, 0 },
                    { "49", 110, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2144), null, "Vegetarian", "/images/HealthyRecipes/9.png", null, null, "Breakfast", 15, null, null, 5, null, null, null, 10, 0 },
                    { "50", 40, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2150), null, "Vegetarian", "/images/HealthyRecipes/10.png", null, null, "SideDish", 60, null, null, 8, null, null, null, 20, 0 },
                    { "51", 125, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2155), null, "Vegetarian", "/images/HealthyRecipes/11.png", null, null, "Lunch", 50, null, null, 5, null, null, null, 30, 0 },
                    { "52", 66, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2159), null, "Omnivore", "/images/HealthyRecipes/12.png", null, null, "Snack", 30, null, null, 5, null, null, null, 36, 0 },
                    { "53", 110, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2162), null, "Vegetarian", "/images/HealthyRecipes/13.jpg", null, null, "Lunch", 30, null, null, 7, null, null, null, 45, 0 },
                    { "54", 145, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2166), null, "Omnivore", "/images/HealthyRecipes/14.jpg", null, null, "Lunch", 60, null, null, 17, null, null, null, 30, 0 },
                    { "55", 25, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2169), null, "Vegetarian", "/images/HealthyRecipes/15.png", null, null, "SideDish", 15, null, null, 8, null, null, null, 10, 0 },
                    { "56", 150, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2173), null, "Omnivore", "/images/HealthyRecipes/16.jpg", null, null, "Snack", 30, null, null, 5, null, null, null, 25, 0 },
                    { "57", 50, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2177), null, "Vegetarian", "/images/HealthyRecipes/17.jpg", null, null, "Dinner", 20, null, null, 4, null, null, null, 15, 0 },
                    { "58", 65, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2181), null, "Omnivore", "/images/HealthyRecipes/18.jpg", null, null, "Breakfast", 30, null, null, 15, null, null, null, 40, 0 },
                    { "59", 34, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2185), null, "Omnivore", "/images/HealthyRecipes/19.jpg", null, null, "Breakfast", 15, null, null, 0, null, null, null, 15, 0 },
                    { "60", 45, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2188), null, "Omnivore", "/images/HealthyRecipes/20.jpg", null, null, "Breakfast", 240, null, null, 7, null, null, null, 15, 0 }
                });

            migrationBuilder.InsertData(
                table: "TblHealthyRecipe",
                columns: new[] { "Id", "Calories", "CategoryId", "CreatedDate", "Description", "DietaryType", "Image", "Ingredients", "IsFeatured", "MealType", "PrepTime", "PreparationMethod", "Price", "Protein", "RatePercentage", "ShortDescription", "Title", "Total_Carbohydrate", "ViewsNumber" },
                values: new object[,]
                {
                    { "61", 250, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2204), "<p> <strong> الطبق </strong> </p>\r\n<p> فاهيتا على الفطور؟ تتحدى! مستوحاة من تلك الفاهيتا الأزيز على غرار المطاعم ، قمنا بإعادة إنشاء نسخة مبسطة مثالية لصباح أيام الأسبوع المزدحمة - كاملة مع خيارات الإعداد المسبق لتوفير المزيد من الوقت. بدلاً من التورتيلا ، ابتكرنا مفهوم الأومليت المفتوح الوجه. الأومليت مليء بالديك الرومي المحمر والمتبل بالإضافة إلى الفلفل والبصل المقلي. القليل من الصلصة والزبادي قليل الدسم والبصل الأخضر يكمل جمالية الفاهيتا. إذا كنت ترغب في جعل فاهيتا الإفطار نباتيًا ، فلا تتردد في استبدال الديك الرومي ببديل اللحم المفروم المفضل لديك (أو التوفو المفتت). </p>\r\n<p> <strong> نصائح للتحضير المسبق / لتوفير الوقت </strong> </p>\r\n<p> يمكن طهي الديك الرومي والخضار (الفلفل والبصل) وتبريدهما قبل يوم أو يومين. أثناء طهي البيض ، قم بإعادة تسخين مزيج الديك الرومي والخضروات في الميكروويف (أو في مقلاة أخرى) ، ثم قم بتجميعها حسب التعليمات. </p>", "حيواني", "/Images/HealthyRecipes/1.jpg", "بيضات كاملة,100,غرام\n الديك الرومي المطحون الخالي من الد,60,غرام\nتوابل التاكو ,2,غرام\n الفلفل الأخضر الجرس,20,غرام\n الفلفل الأحمر,20,غرام\n البصل الأحمر,20,غرام\nصلصة,15,غرام\n زبادي يوناني قليل الدسم,15,غرام\n البصل الأخضر,10,غرام\n", null, "وجبة الإفطار", 12, "دهن مقلاة غير لاصقة بقليل من بخاخ تحرير المقلاة وقم بالتسخين المسبق على حرارة متوسطة إلى عالية.\r\nبمجرد أن يسخن , افرم الديك الرومي المطحون في المقلاة ورشي توابل التاكو مع التقليب حتى تمتزج. يُطهى لمدة 3-4 دقائق مع التحريك من حين لآخر أو حتى ينضج تمامًا ويصبح لونه بنيًا جيدًا. بمجرد طهيه , باستخدام ملعقة مثقوبة , أخرج الديك الرومي من المقلاة وضعه جانبًا على طبق.\r\n, دهن المقلاة برفق مرة أخرى وعاد إلى درجة حرارة متوسطة إلى عالية. يُضاف الفلفل والبصل ويُطهى لمدة 3-4 دقائق أو حتى ينضج.\r\n, بمجرد أن تصبح الخضار طرية , أعد الديك الرومي المطحون إلى المقلاة وقلّب المزيج. باستخدام ملعقة مشقوقة , تُرفع الخضار والديك الرومي المفروم من المقلاة , ويُترك جانباً على الطبق , ويُتبل قليلاً بالملح والفلفل حسب الرغبة.\r\n, أعد المقلاة إلى درجة حرارة متوسطة إلى عالية. بمجرد أن يسخن , أضف البيض ولفه لتغطي قاع المقلاة.\r\n,يُغطّى ويُطهى لمدة 2-3 دقائق أو حتى يصبح البيض متماسكًا وينضج تمامًا. أخرج البيضة من المقلاة بحذر وانقلها إلى طبق التقديم.\r\nوزعي البيض بالديك الرومي والخضار والصلصة. دولوب مع الزبادي ورش البصل الأخضر قبل التقديم.", 0.0, 24, 0.0, "", " فاهيتا أوميليت مفتوح الوجه مع تركيا المطحونة والفلفل والبصل", 6, 0 },
                    { "62", 269, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2208), "<p> <strong> الطبق </strong> </p>\r\n<p> مستوحاة من شطائر الشاي الإنجليزي التقليدية ، تستخدم هذه النسخة اللطيفة الخيار الكلاسيكي والجبن بينما يتم تعزيزها بالبروتين من خلال صدور الدجاج الخالية من الدهون والمشوية والمتبل. يكمن السر في بناء وجبة ديناميكية ولذيذة في إضافة طبقة من النكهة والقوام. يتناقض الجبن الدسم قليل الدسم بشكل جيد مع شرائح الخيار الطازجة. الدجاج - المتبل بالخل البلسمي والتوابل الإيطالية - هو إضافة لذيذة لهذه الخبز المحمص ، يضفي نكهة حلوة ومالحة ومدخنة رائعة. قم بإقران هذه الوصفة مع أي نوع من أنواع الحساء أو السلطات التي تركز على الخضار للحصول على وجبة متوازنة - مثالية للغداء أو العشاء! </ p>\r\n<p> <strong> الاستعداد للأمام ونصيحة لتوفير الوقت </strong> </p>\r\n<p> لتوفير الوقت أو كخيار مسبق ، لا تتردد في نقع الدجاج طوال الليل. يمكنك أيضًا تتبيل صدور الدجاج وشويها وتبريدها وتقطيعها إلى شرائح لتوفير المزيد من الوقت. </p>", "حيواني", "/Images/HealthyRecipes/2.jpg", " الريحان الطازج,2,غرام\n خيارة,60,غرام\n جبن كوخ قليل الدسم ,2,غرام\n  كعكة القمح الكامل الإنجليزية ,20,غرام\n الخل البلسمي ,20,غرام\n  البارود الأسود,20,غرام\nالتوابل الإيطالية,15,غرام\n صدر دجاج,15,غرام\nزيت الزيتون,10,غرام\n", null, "طبق جانبي,وجبة غداء", 15, ", قم بالتسخين المسبق لشواية الغاز إلى درجة حرارة متوسطة إلى عالية أو الفحم المسبق لشواية الفحم., صدر الدجاج يجفف بالمناشف الورقية ويوضع على طبق ويتبل قليلا بالتوابل الإيطالية والفلفل الأسود والخل البلسمي ورشة ملح., ضع الدجاج جانبًا لينقع لمدة 10 دقائق بينما تسخن الشواية مسبقًا., بمجرد أن تصبح الشواية ساخنة ، أضيفي الدجاج واطهيها لمدة 2-3 دقائق لكل جانب أو حتى تفحم قليلاً وتنضج بالكامل. تُرفع عن الشواية وتترك جانباً لترتاح قبل التقطيع., ملعقة وافرد الجبن القريش على الكعك الإنجليزي المحمص. يُغطى التوست المُجهز بشرائح الدجاج وشرائح الخيار والريحان الطازج. الموسم الى الذوق مع الملح والفلفل.", 0.0, 26, 0.0, "", "خيار وجبن كوخ وخبز محمص دجاج مشوي مع الخل البلسمي والأعشاب الإيطالية", 30, 0 },
                    { "65", 250, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2192), "<p> <strong> الطبق </strong> </p>\r\n<p> فاهيتا على الفطور؟ تتحدى! مستوحاة من تلك الفاهيتا الأزيز على غرار المطاعم ، قمنا بإعادة إنشاء نسخة مبسطة مثالية لصباح أيام الأسبوع المزدحمة - كاملة مع خيارات الإعداد المسبق لتوفير المزيد من الوقت. بدلاً من التورتيلا ، ابتكرنا مفهوم الأومليت المفتوح الوجه. الأومليت مليء بالديك الرومي المحمر والمتبل بالإضافة إلى الفلفل والبصل المقلي. القليل من الصلصة والزبادي قليل الدسم والبصل الأخضر يكمل جمالية الفاهيتا. إذا كنت ترغب في جعل فاهيتا الإفطار نباتيًا ، فلا تتردد في استبدال الديك الرومي ببديل اللحم المفروم المفضل لديك (أو التوفو المفتت). </p>\r\n<p> <strong> نصائح للتحضير المسبق / لتوفير الوقت </strong> </p>\r\n<p> يمكن طهي الديك الرومي والخضار (الفلفل والبصل) وتبريدهما قبل يوم أو يومين. أثناء طهي البيض ، قم بإعادة تسخين مزيج الديك الرومي والخضروات في الميكروويف (أو في مقلاة أخرى) ، ثم قم بتجميعها حسب التعليمات. </p>", "حيواني", "/Images/HealthyRecipes/1.jpg", "بيضات كاملة,100,غرام\n الديك الرومي المطحون الخالي من الد,60,غرام\nتوابل التاكو ,2,غرام\n الفلفل الأخضر الجرس,20,غرام\n الفلفل الأحمر,20,غرام\n البصل الأحمر,20,غرام\nصلصة,15,غرام\n زبادي يوناني قليل الدسم,15,غرام\n البصل الأخضر,10,غرام\n", null, "وجبة الإفطار", 12, "دهن مقلاة غير لاصقة بقليل من بخاخ تحرير المقلاة وقم بالتسخين المسبق على حرارة متوسطة إلى عالية.\r\nبمجرد أن يسخن , افرم الديك الرومي المطحون في المقلاة ورشي توابل التاكو مع التقليب حتى تمتزج. يُطهى لمدة 3-4 دقائق مع التحريك من حين لآخر أو حتى ينضج تمامًا ويصبح لونه بنيًا جيدًا. بمجرد طهيه , باستخدام ملعقة مثقوبة , أخرج الديك الرومي من المقلاة وضعه جانبًا على طبق.\r\n, دهن المقلاة برفق مرة أخرى وعاد إلى درجة حرارة متوسطة إلى عالية. يُضاف الفلفل والبصل ويُطهى لمدة 3-4 دقائق أو حتى ينضج.\r\n, بمجرد أن تصبح الخضار طرية , أعد الديك الرومي المطحون إلى المقلاة وقلّب المزيج. باستخدام ملعقة مشقوقة , تُرفع الخضار والديك الرومي المفروم من المقلاة , ويُترك جانباً على الطبق , ويُتبل قليلاً بالملح والفلفل حسب الرغبة.\r\n, أعد المقلاة إلى درجة حرارة متوسطة إلى عالية. بمجرد أن يسخن , أضف البيض ولفه لتغطي قاع المقلاة.\r\n,يُغطّى ويُطهى لمدة 2-3 دقائق أو حتى يصبح البيض متماسكًا وينضج تمامًا. أخرج البيضة من المقلاة بحذر وانقلها إلى طبق التقديم.\r\nوزعي البيض بالديك الرومي والخضار والصلصة. دولوب مع الزبادي ورش البصل الأخضر قبل التقديم.", 0.0, 24, 0.0, "", " فاهيتا أوميليت مفتوح الوجه مع تركيا المطحونة والفلفل والبصل", 6, 0 },
                    { "66", 269, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2196), "<p> <strong> الطبق </strong> </p>\r\n<p> مستوحاة من شطائر الشاي الإنجليزي التقليدية ، تستخدم هذه النسخة اللطيفة الخيار الكلاسيكي والجبن بينما يتم تعزيزها بالبروتين من خلال صدور الدجاج الخالية من الدهون والمشوية والمتبل. يكمن السر في بناء وجبة ديناميكية ولذيذة في إضافة طبقة من النكهة والقوام. يتناقض الجبن الدسم قليل الدسم بشكل جيد مع شرائح الخيار الطازجة. الدجاج - المتبل بالخل البلسمي والتوابل الإيطالية - هو إضافة لذيذة لهذه الخبز المحمص ، يضفي نكهة حلوة ومالحة ومدخنة رائعة. قم بإقران هذه الوصفة مع أي نوع من أنواع الحساء أو السلطات التي تركز على الخضار للحصول على وجبة متوازنة - مثالية للغداء أو العشاء! </ p>\r\n<p> <strong> الاستعداد للأمام ونصيحة لتوفير الوقت </strong> </p>\r\n<p> لتوفير الوقت أو كخيار مسبق ، لا تتردد في نقع الدجاج طوال الليل. يمكنك أيضًا تتبيل صدور الدجاج وشويها وتبريدها وتقطيعها إلى شرائح لتوفير المزيد من الوقت. </p>", "حيواني", "/Images/HealthyRecipes/2.jpg", " الريحان الطازج,2,غرام\n خيارة,60,غرام\n جبن كوخ قليل الدسم ,2,غرام\n  كعكة القمح الكامل الإنجليزية ,20,غرام\n الخل البلسمي ,20,غرام\n  البارود الأسود,20,غرام\nالتوابل الإيطالية,15,غرام\n صدر دجاج,15,غرام\nزيت الزيتون,10,غرام\n", null, "طبق جانبي,وجبة غداء", 15, ", قم بالتسخين المسبق لشواية الغاز إلى درجة حرارة متوسطة إلى عالية أو الفحم المسبق لشواية الفحم., صدر الدجاج يجفف بالمناشف الورقية ويوضع على طبق ويتبل قليلا بالتوابل الإيطالية والفلفل الأسود والخل البلسمي ورشة ملح., ضع الدجاج جانبًا لينقع لمدة 10 دقائق بينما تسخن الشواية مسبقًا., بمجرد أن تصبح الشواية ساخنة ، أضيفي الدجاج واطهيها لمدة 2-3 دقائق لكل جانب أو حتى تفحم قليلاً وتنضج بالكامل. تُرفع عن الشواية وتترك جانباً لترتاح قبل التقطيع., ملعقة وافرد الجبن القريش على الكعك الإنجليزي المحمص. يُغطى التوست المُجهز بشرائح الدجاج وشرائح الخيار والريحان الطازج. الموسم الى الذوق مع الملح والفلفل.", 0.0, 26, 0.0, "", "خيار وجبن كوخ وخبز محمص دجاج مشوي مع الخل البلسمي والأعشاب الإيطالية", 30, 0 },
                    { "67", 273, null, new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(2200), " <p class=\"fs-6\">\r\n                            تساعد على تنظيف الجسم من السموم وتخليصه من الأمراض المختلفة، إذ يمكن عمله\r\n                            بطرق عدة باستخدام أنواع مختلفة من الخضار والفواكه، وهذه المشروبات تساعد في\r\n                            حميات إنقاص الوزن وتعزز الصحة العامة، هنا سنقدم طريقة عمل عصير ديتوكس\r\n                        </p>", "نباتي", "/user/images/pexels-toni-cuenca-616833.png", " الريحان الطازج,2,غرام\n خيارة,60,غرام\n جبن كوخ قليل الدسم ,2,غرام\n  كعكة القمح الكامل الإنجليزية ,20,غرام\n الخل البلسمي ,20,غرام\n  البارود الأسود,20,غرام\nالتوابل الإيطالية,15,غرام\n صدر دجاج,15,غرام\nزيت الزيتون,10,غرام\n", null, "مشروبات", 30, "  <ol>\r\n                    <li>اغسلي جميع الخضار والفواكه وقطعيها لقطع متوسطة يسهل وضعها في الخلاط.</li>\r\n                    <li>ضعي الخضار والفواكه في العصارة أو الخلاط الكهربائي واحداً تلو الآخر واخلطيها لمدة أربع دقائق حتى تتجانس المكونات.</li>\r\n                    <li>قدمي العصير مبرداً واحفظيه في الثلاجة إذ يمكن تناوله خلال سبع أيام.</li>\r\n                  \r\n                </ol>", 0.0, 20, 5.0, "", "مشروب الديتوكس الأخضر", 43, 0 }
                });

            migrationBuilder.InsertData(
                table: "TblArticles",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "LikesNumber", "PostDate", "Title", "ViewsNumber", "avgReading" },
                values: new object[,]
                {
                    { "140", "9", "<div class=\"artIntro\">\r\n<h2 class=\"artBrief\"><span style=\"color: rgb(190, 138, 220);\">يُعتبر الكركم من أشهر التوابل التي نستخدمها في حياتنا اليومية، وللكركم العديد من الفوائد المهمة التي تُحسن من صحة العقل، والجسم.</span></h2>\r\n</div>\r\n<div class=\"detailsText\">يُعتبر الكركم من أشهر التوابل التي نستخدمها في حياتنا اليومية، وللكركم العديد من الفوائد المهمة التي تُحسن من صحة العقل، والجسم.<br><br>فوائد الكركم للجسم:<br>إليك أهم<strong>&nbsp;<u><a href=\"https://altmedicine.mawdoo3.com/n/%D8%A7%D9%84%D9%83%D8%B1%D9%83%D9%85-%D9%84%D9%84%D8%AA%D8%AE%D8%B3%D9%8A%D8%B3-%D9%85%D8%B9%D9%84%D9%88%D9%85%D8%A7%D8%AA-%D8%AA%D9%87%D9%85%D9%83\">ا<span style=\"color: rgb(144, 112, 162);\">لفوائد</span></a><span style=\"color: rgb(144, 112, 162);\">&nbsp;<a style=\"color: rgb(144, 112, 162);\" href=\"https://altmedicine.mawdoo3.com/n/%D8%A7%D9%84%D9%83%D8%B1%D9%83%D9%85-%D9%84%D9%84%D8%AA%D8%AE%D8%B3%D9%8A%D8%B3-%D9%85%D8%B9%D9%84%D9%88%D9%85%D8%A7%D8%AA-%D8%AA%D9%87%D9%85%D9%83\">التي</a>&nbsp;<a style=\"color: rgb(144, 112, 162);\" href=\"https://altmedicine.mawdoo3.com/n/%D8%A7%D9%84%D9%83%D8%B1%D9%83%D9%85-%D9%84%D9%84%D8%AA%D8%AE%D8%B3%D9%8A%D8%B3-%D9%85%D8%B9%D9%84%D9%88%D9%85%D8%A7%D8%AA-%D8%AA%D9%87%D9%85%D9%83\">يحصل</a>&nbsp;<a style=\"color: rgb(144, 112, 162);\" href=\"https://altmedicine.mawdoo3.com/n/%D8%A7%D9%84%D9%83%D8%B1%D9%83%D9%85-%D9%84%D9%84%D8%AA%D8%AE%D8%B3%D9%8A%D8%B3-%D9%85%D8%B9%D9%84%D9%88%D9%85%D8%A7%D8%AA-%D8%AA%D9%87%D9%85%D9%83\">عليها</a>&nbsp;<a style=\"color: rgb(144, 112, 162);\" href=\"https://altmedicine.mawdoo3.com/n/%D8%A7%D9%84%D9%83%D8%B1%D9%83%D9%85-%D9%84%D9%84%D8%AA%D8%AE%D8%B3%D9%8A%D8%B3-%D9%85%D8%B9%D9%84%D9%88%D9%85%D8%A7%D8%AA-%D8%AA%D9%87%D9%85%D9%83\">جسم</a>&nbsp;<a style=\"color: rgb(144, 112, 162);\" href=\"https://altmedicine.mawdoo3.com/n/%D8%A7%D9%84%D9%83%D8%B1%D9%83%D9%85-%D9%84%D9%84%D8%AA%D8%AE%D8%B3%D9%8A%D8%B3-%D9%85%D8%B9%D9%84%D9%88%D9%85%D8%A7%D8%AA-%D8%AA%D9%87%D9%85%D9%83\">الإنسان</a>&nbsp;<a style=\"color: rgb(144, 112, 162);\" href=\"https://altmedicine.mawdoo3.com/n/%D8%A7%D9%84%D9%83%D8%B1%D9%83%D9%85-%D9%84%D9%84%D8%AA%D8%AE%D8%B3%D9%8A%D8%B3-%D9%85%D8%B9%D9%84%D9%88%D9%85%D8%A7%D8%AA-%D8%AA%D9%87%D9%85%D9%83\">عند</a>&nbsp;<a style=\"color: rgb(144, 112, 162);\" href=\"https://altmedicine.mawdoo3.com/n/%D8%A7%D9%84%D9%83%D8%B1%D9%83%D9%85-%D9%84%D9%84%D8%AA%D8%AE%D8%B3%D9%8A%D8%B3-%D9%85%D8%B9%D9%84%D9%88%D9%85%D8%A7%D8%AA-%D8%AA%D9%87%D9%85%D9%83\">تناول</a>&nbsp;<a style=\"color: rgb(144, 112, 162);\" href=\"https://altmedicine.mawdoo3.com/n/%D8%A7%D9%84%D9%83%D8%B1%D9%83%D9%85-%D9%84%D9%84%D8%AA%D8%AE%D8%B3%D9%8A%D8%B3-%D9%85%D8%B9%D9%84%D9%88%D9%85%D8%A7%D8%AA-%D8%AA%D9%87%D9%85%D9%83\">الكركم</a></span></u></strong><span dir=\"LTR\">:</span><br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; مضاد للالتهابات: يعمل الكركم كبديل فعال للأدوية المضادة للالتهاب، حيث يُساعد الكركم على تخفيف الالتهاب، وعلاجه بشكل سريع، كما يخفف الكركم من آثار هذا الالتهاب على الجسم.<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; تحسين الذاكرة: يُساعد الكركم على تحسين الذاكرة بشكل كبير، حيث يحتوي الكركم على مواد مضادة للأكسدة، وتُساعد هذه المواد على تنشيط خلايا الدماغ، ومنعها من التلف.<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; علاج التهاب المفاصل: يُستخدم الكركم كعلاج فعال لمشكلات المفاصل، والعضلات مثل هشاشة العظام، فهو يقلل من الآثار الجانبية لهشاشة العظام، ويُساعد على منع تقدم هذه المشكلة على مر الزمن.<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; الوقاية من مرض السكري: أثبتت الدراسات أن تناول الكركم بشكل مستمر يُساعد على الوقاية من الإصابة بمرض السكري، حيث يعمل الكركم على المُحافظة على مستوى السكر في الدم، كما أنه قادر على علاج مرض السكري في حال الالتزام بتناوله.<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; تخفيف أعراض الحيض: يُساعد الكركم على التخفيف من آلام الحيض بشكل فعّال جدًا، حيث يُمكن تناول الكركم مع كوب من الشاي الساخن للتخلص من آلام البطن، والظهر، والمفاصل الناتجة عن الحيض.<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; مُعالجة الاكتئاب: يُساعد الكركم على التخلص من الحالة المزاجية السيئة التي تنتج عن الاكتئاب، حيث يحتوي الكركم على العديد من العناصر التي تُساعد الجسم على التخلص من الطاقة السلبية.<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; مُعالجة أمراض السرطان: يُساعد الكركم على إيقاف نمو الخلايا السرطانية عند مرضى السرطان، كما أنه مادة فعّالة جدًا للوقاية من أمراض السرطان التي من الممكن أن تغزو الجسم بأي وقت.<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; مُعالجة القولون العصبي: أثبتت الدراسات أن الكركم مادة ممتازة للتخفيف من الأعراض المصاحبة للقولون العصبي، وأبرزها آلام البطن المزعجة.<br><br>استخدامات الكركم للبشرة:<br>يُعتبر الكركم فعالًا جدًا لعلاج مشكلات البشرة، وفي ما يلي أبرز فوائد الكركم المتعلقة بالبشرة:<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; يمنح البشرة لمعانًا طبيعيًا: يُساعد الكركم على تصفية البشرة؛ بسبب احتوائه على مواد مضادة للأكسدة، ويمكن صنع أقنعة للوجه عن طريق خلط الكركم مع الزبادي، والعسل، حيث ستظهر النتائج على البشرة بشكل فوري.<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; مُعالجة الجروح: يُساعد الكركم على تخفيف التهاب الجروح في البشرة، كما يُساعد أيضًا على التئام الجروح بشكل أسرع من استخدام الأدوية.<br>●&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; مُعالجة حب الشباب: يُمكن استخدام الكركم كبديل للأدوية المُتخصصة لعلاج حب الشباب، حيث يُساعد الكركم على التقليل من ظهورها على الوجه، وعلاجها، وعلاج آثارها أيضًا.<br><br>الأعراض الجانبية للكركم:<br>يُعتبر الكركم مفيدًا جدًا، ولكن يجب على الأشخاص الذين يعانون من حساسية اتجاه هذا النوع من التوابل تجنب تناوله، فقد يؤدي تناوله إلى التعرض لحساسية، وطفح جلدي، كما يجب تجنب تناول الكركم بكميات كبيرة جدًا، حيث سيؤدي ذلك إلى إصابة الفرد بالتحسس.</div>", "/images/articles/image_202.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "فوائد الكركم للجسم", 0, 20 },
                    { "141", "9", "<div class=\"artIntro\">\r\n<div class=\"artIntro\">\r\n<h2 class=\"artBrief\" style=\"text-align: center;\"><span style=\"color: rgb(190, 138, 220);\">يأكلون ما يريدون دون أن يزيد وزنهم</span></h2>\r\n</div>\r\n<div class=\"detailsText\">هناك الكثير من النكات عن الأشخاص الذين يأكلن ما يردن دون أن يصبن بالسمنة. لكن تنصح طبيبة الغدد الصماء والتغذية أن مثل هذه النحافة، يجب أن تؤخذ على محمل الجد.<br><br>وفقًا للخبيرة، عادةً ما يتم تفسير النحافة المفرطة بسببين. الأول هو علم وظائف الأعضاء، والثاني هو علم الأمراض.<br><br>في الحالة الأولى،&nbsp;ترجع النحافة&nbsp;مع الشهية الجيدة إلى الحالة الجيدة للميكروبات المعوية أو صغر السن أو نمط الحياة النشط. في الوقت نفسه، بعد 20 عامًا، يمكن للفتيات النحيفات الإصابة بالسمنة إذا لم يتبعن نظاما غذائيا جيدا.<br><br>في الحالة الثانية، تعتبر النحافة من أعراض العديد من الأمراض. يرتبط نقص الوزن بالتسمم الدرقي، والسرطان، ومرض السكري من النوع الأول، وأمراض الجهاز الهضمي، وداء الديدان الطفيلية. يمكن أن يكون سبب النحافة هو العادات السيئة أو فقدان الشهية أو الشره المرضي العصبي<br><br>تنصح الخبيرة&nbsp;بعدم تأجيل زيارة الطبيب&nbsp;في حالة حدوث فقدان سريع للوزن دون سبب واضح. يمكن لطبيب وحده فقط وصف العلاج اللازم.</div>\r\n<h2 class=\"artBrief\">&nbsp;</h2>\r\n</div>", "/images/articles/3005227.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "أنواع النحافة", 0, 20 },
                    { "142", "9", "<h2><span style=\"color:#be8adc\">تحمل كمية الزيت التي نستخدمها تأثير خفي على أهدافك المتعلقة بفقدان الوزن بسبب غناه بالسعرات الحرارية.</span></h2>\r\n\r\n<p>قد تكون محاولة إنقاص الوزن بطريقة صحية وطويلة الأمد عملية محبطة في بعض الأحيان لكثير من الأشخاص، وذلك لأن كل فرد لديه احتياجاته الخاصة.</p>\r\n\r\n<p>ولحل هذه المشكلة يجب علينا التعرف على أنفسنا وما تحتاجه أجسامنا، مع إجراء تغييرات صغيرة ولكنها مؤثرة في روتيننا اليومي، لفقدان الوزن بنجاح.</p>\r\n\r\n<p>في هذا الشأن، كشف أخصائيي التغذية عن 5 أنماط من الأكل الشائعة التي قد تمنعك من فقدان الوزن.</p>\r\n\r\n<h3><span style=\"color:#a566c8\">1- الإفراط في تناول الأكل الصحي</span></h3>\r\n\r\n<p>يوصي أخصائيو التغذية بقياس الحصص الغذائية من أجل عدم الإفراط في تناول السعرات الحرارية.</p>\r\n\r\n<p>فتناول الأطعمة الصحية مثل المكسرات والحمص والأفوكادو أمر جيد جدا لصحتك، لكنها تحتوي جميعها على دهون صحية وتحتوي على سعرات حرارية أكثر من الكربوهيدرات أو البروتينات الأخرى.</p>\r\n\r\n<p>كذلك، يعتقد الكثير من الأشخاص الذين يتطلعون إلى إنقاص الوزن، أن هذه الأطعمة مفيدة دون الاكتراث إلى الكمية، لكن هذا ليس صحيحاً فحجم الحصة هو المفتاح عند محاولة إنقاص الوزن.</p>\r\n\r\n<h3><span style=\"color:#a566c8\">2- عدم تناول كمية كافية من البروتين</span></h3>\r\n\r\n<p>لفقدان الوزن عليك بتناول مصادر البروتين مثل صدور الدجاج، أو برغر الديك الرومي، أو السمك، فذلك سيجعلك أقل عرضة لتناول الوجبات الخفيفة غير الصحية أو الأطباق الجانبية المليئة بالسعرات الحرارية العالية والسكر والحبوب المصنعة وما إلى ذلك.</p>\r\n\r\n<h3><span style=\"color:#a566c8\">3- أنت تطبخ بالكثير من الزيت</span></h3>\r\n\r\n<p>تحمل كمية الزيت التي نستخدمها تأثير خفي على أهدافك المتعلقة بفقدان الوزن بسبب غناه بالسعرات الحرارية.</p>\r\n\r\n<p>ويمكنك تقليل تناول الزيت عن طريق قياس المقدار الذي تريد استخدامه، من خلال شراء علبة رذاذ زيت لاستخدامها بدلا من سكب الزيت من زجاجة.</p>\r\n\r\n<p>كما يعد الطهي بدون أي زيت خيارا صحياً رائعاً.</p>\r\n\r\n<h3><span style=\"color:#a566c8\">4 - التباهي بتناول الطعام الغني السعرات الحرارية</span></h3>\r\n\r\n<p>بينما يحتاج الجميع إلى قطعة من الكيك أو بعض من الشيبس من وقت لآخر، فإن الكثير من الناس يبالغون في التباهي بذلك وينتهي بهم الأمر بتناول ما يكفي من السعرات الحرارية لتعويض النقص في السعرات الحرارية التي صنعوها في الأسبوع.</p>\r\n\r\n<p>لذلك يجب عليك الاعتدال وتناول الحبوب الكاملة والبروتينات الخالية من الدهون ومنتجات الألبان والدهون الصحية والفواكه والكثير من الخضروات وعدم الإسراف في تناول الأطعمة الغنية بالسعرات الحرارية.</p>\r\n\r\n<h3><span style=\"color:#a566c8\">5 - اضافة بهارات غير صحية</span></h3>\r\n\r\n<p>اضافة التوابل المفضلة لك إلى الطعام لتعزيز النكهة، يمكن أن يكون خطأ فادحًا يمنعك من فقدان الوزن.</p>\r\n\r\n<p>كما أن إضافة صلصة الشواء أو الكاتشب إلى وجبة غداء أو عشاء يعتبر أمرا غير صحياً، وبدلاً من ذلك استخدم بعض الصلصة &quot;قليلة الدسم&quot; في سلطتك، أو إلى الساندويتش المفضل لك.</p>\r\n", "/images/articles/image_20220907211306096.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 أخطاء تمنعك من خسارة الوزن", 0, 20 },
                    { "143", "9", "<h4>&nbsp;الأفوكادو أو ما يعرف بـكمثرى التمساح؛ فاكهة ذات غلاف املس متعرج وثمرة كريمية الملمس، موطنها أميركا الوسطى، متعددة الاستخدامات وغالبًا ما يتم إعداد عدد من الأطباق المتنوعة بواسطتها، كما وتستخدم شاي أوراق الأفوكادو في نيجيريا علاجًا عشبيًا لارتفاع ضغط الدم.<br />\r\n&nbsp;<br />\r\n<span style=\"color:#a566c8\"><strong>فوائد الأفوكادو:</strong></span><br />\r\n<br />\r\n&nbsp;توصي الإرشادات الغذائية بشكل عام إلى زيادة نسبة استهلاك الخضراوات والفواكه؛ وذلك لتعزيز الصحة والحد من خطر الإصابة بالأمراض، وبشكل خاص فإن الأفوكادو يعمل على تحسين جودة النظام الغذائي، حيث يحتوي على العديد من المصادر الغذائية؛ فهو مصدر غني بالدهون الأحادية غير المشبعة، وبالألياف، وحمض الفوليك، والبوتاسيوم والمغنيسيوم، وعدد متنوع من الفيتامينات:</h4>\r\n\r\n<ul>\r\n	<li>\r\n	<h2>تساعد الدهون الصحية على تعزيز قدرة الجسد على امتصاص العناصر الغذائية الرئيسية (العناصر القابلة للذوبان في داخل الدهون)، الأمر الذي يحافظ ويعزز من صحة القلب والبشرة، كما ويساعد على التقليل من خطر الإصابة بمرض السكري النوع الثاني.</h2>\r\n	</li>\r\n	<li>\r\n	<h2>&nbsp;تدعم العناصر الغذائية الأداء العقلي وجهاز المناعة، وتدعم أيضًا المزاج الجيد والشعور بالنشاط.</h2>\r\n	</li>\r\n	<li>\r\n	<h2>يعزز وجود فيتامين&nbsp;B5 وحمض الفوليك والبوتاسيوم والنياسين أداء الجهاز العصبي والأداء العقلي.</h2>\r\n	</li>\r\n	<li>\r\n	<h2>يعمل فيتوسترولس على خفض مستوى الكوليسترول الكلي ومستوى الكوليسترول الضار في الجسم، وذلك عن طريق خفض امتصاصه.</h2>\r\n	</li>\r\n	<li>\r\n	<h2>يعزز البوتاسيوم صحة القلب ويعمل على تنظيم ضغط الدم.</h2>\r\n	</li>\r\n	<li>\r\n	<h2>تعزز المادة الكيميائية المسمى الكاروتينات صحة العين؛ حيث تعمل كل من اللوتين والزياكسانثين كمضادات أكسدة تساهم في حماية العين من أضرار الأشعة فوق البنفسجية.</h2>\r\n	</li>\r\n	<li>\r\n	<h2>أخيرًا يعد الأفوكادو أحد الأغذية الملائمة والداعمة للحوامل لاحتوائه على حمض الفوليك، كما أنه مناسب للأطفال إذ يعمل على تعزيز النمو والتطور الجسدي والعقلي.</h2>\r\n	</li>\r\n</ul>\r\n\r\n<h2>&nbsp;<br />\r\n&nbsp;<br />\r\n<strong><span style=\"color:#a566c8\">&nbsp;الأفوكادو للرجيم</span></strong><br />\r\n&nbsp;تظهر الدراسات على وجود توافق إيجابي بين&nbsp;<u><a href=\"https://nutrition.mawdoo3.com/m/%D8%A7%D9%84%D8%A3%D9%81%D9%88%D9%83%D8%A7%D8%AF%D9%88-%D9%81%D9%8A-%D8%AD%D8%B1%D9%82-%D8%A7%D9%84%D8%AF%D9%87%D9%88%D9%86-%D9%87%D9%84-%D9%87%D9%88-%D9%85%D9%81%D9%8A%D8%AF-%D9%81%D9%8A-%D8%B0%D9%84%D9%83\">استهلاك</a>&nbsp;<a href=\"https://nutrition.mawdoo3.com/m/%D8%A7%D9%84%D8%A3%D9%81%D9%88%D9%83%D8%A7%D8%AF%D9%88-%D9%81%D9%8A-%D8%AD%D8%B1%D9%82-%D8%A7%D9%84%D8%AF%D9%87%D9%88%D9%86-%D9%87%D9%84-%D9%87%D9%88-%D9%85%D9%81%D9%8A%D8%AF-%D9%81%D9%8A-%D8%B0%D9%84%D9%83\">الأفوكادو</a>&nbsp;<a href=\"https://nutrition.mawdoo3.com/m/%D8%A7%D9%84%D8%A3%D9%81%D9%88%D9%83%D8%A7%D8%AF%D9%88-%D9%81%D9%8A-%D8%AD%D8%B1%D9%82-%D8%A7%D9%84%D8%AF%D9%87%D9%88%D9%86-%D9%87%D9%84-%D9%87%D9%88-%D9%85%D9%81%D9%8A%D8%AF-%D9%81%D9%8A-%D8%B0%D9%84%D9%83\">والرجيم</a></u>&nbsp;وجودة النظام الغذائي؛ حيث أظهرت النتائج انخفاض في مؤشر كتلة الجسد ووزن الجسد وقياسات محيط الخصر، كما ساعد دمج الأفوكادو في النظام الغذائي على الحد من خطر الإصابة بمتلازمة التمثيل الغذائي (ارتفاع ضغط الدم، وارتفاع نسبة السكر والدهون الثلاثية في الدم، والسمنة).<br />\r\n<br />\r\n&nbsp;يعد الأفوكادو أحد المكونات الأساسية في عدد من الأنظمة الغذائية الشائعة؛ مثل النظام الغذائي الخاصة بالنباتيين (لاحتوائها على نسب عالية من الدهون)؛ حيث يستخدم كبديل عن اللحوم، والأنظمة الغذائية منخفضة الكوليسترول، والأنظمة الغذائية منخفضة الكربوهيدرات الملائمة لمرضى السكري، كما ويستخدم في الأنظمة الغذائية الخالية من المشتقات الحليبية.<br />\r\n<br />\r\n&nbsp;&nbsp;تحتوي ثمرة الأفوكادو المتوسطة في الحجم على ما يقارب 240 سعرة حرارية؛ 22 جرام من الدهون، و13 جرام من الكربوهيدرات، و10 جرام ألياف، و3 جرامات من البروتين، بالإضافة إلى 11 مليجرام من الصوديوم، حيث من الممكن دمج الأفوكادو بالنظام الغذائي بعدد واسع من الأشكال؛ في الصلصات؛ مثل صلصة الأفوكادو مع السمك، في السلطات؛ مثل سلطة الكينوا والمانجو، ومع المخبوزات، أيضًا مع السندويتشات والعصائر.<br />\r\n&nbsp;&nbsp;<br />\r\n<span style=\"font-size:22px\"><span style=\"color:#a566c8\"><strong>المراجع</strong></span></span><br />\r\n1.<u><a href=\"https://www.ncbi.nlm.nih.gov/pmc/articles/PMC3545982/\">https://www.ncbi.nlm.nih.gov/pmc/articles/PMC3545982/</a></u><br />\r\n2.&nbsp;<u><a href=\"https://australianavocados.com.au/health-nutrition/\">https://australianavocados.com.au/health-nutrition/</a></u><br />\r\n3.<u><a href=\"https://www.hsph.harvard.edu/nutritionsource/avocados/\">https://www.hsph.harvard.edu/nutritionsource/avocados/</a></u><br />\r\n4.<u><a href=\"https://utswmed.org/medblog/avocado-a-day/\">https://utswmed.org/medblog/avocado-a-day/</a></u></h2>\r\n", "/images/articles/image_205015.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الأفوكادو للرجيم", 0, 20 },
                    { "144", "9", "<p>حذرت دراسة جديدة من الآثار السلبية على الصحة العقلية جراء الجلوس فترة طويلة ، حتى أنه يفوق فوائد ممارسة الرياضة بانتظام، وفقا للباحثين الذين درسوا تأثير &quot;كوفيد-19&quot; على الناس.</p>\r\n\r\n<p>وكان السماح بساعة من التمارين في الهواء الطلق يوميا جزءا أساسيا من استراتيجية حكومة المملكة المتحدة عندما بدأ الإغلاق الوطني الأول في مارس 2020.</p>\r\n\r\n<p>ومع ذلك، وجدت الدراسة أن العديد من الأشخاص يقضون أكثر من ثماني ساعات في اليوم جالسين، إما بسبب العمل من المنزل أو في نهاية المطاف أثناء الإجازة.</p>\r\n\r\n<p>وقال الباحثون إن هذا بدوره تسبب في آثار ضارة بصحتهم العقلية.</p>\r\n\r\n<p>وحتى الأشخاص الذين يمارسون نشاطا بدنيا معتدلا أو قويا لمدة 150 دقيقة أسبوعيا، تعرضوا لتأثير سلبي على صحتهم العقلية، ما يشير إلى أن المزيد من التمارين كانت مطلوبة لموازنة نمط حياتهم المستقرة المتزايدة.</p>\r\n\r\n<p>إحدى&nbsp;معدي الدراسة: &quot;على الرغم من أن عيّنتنا المكونة من حوالي 300 شخص كانت نشطة للغاية، إلا أنهم كانوا يجلسون لفترات أطول مع جلوس أكثر من 50% لأكثر من ثماني ساعات في اليوم. وأظهرت دراسات أخرى أنه إذا جلست لمدة تزيد عن ثماني ساعات، فمن أجل تعويض التأثير السلبي للسلوك المستقر على نتائج الصحة البدنية، فأنت بحاجة إلى ممارسة الرياضة لفترة أطول&quot;.</p>\r\n\r\n<p>وأضافت: &quot;إن تقليل وقت الجلوس له تأثير إيجابي على الصحة العقلية. نوصي أنه بالإضافة إلى زيادة النشاط البدني، يجب أن تشجع الصحة العامة على تقليل وقت الجلوس لفوائد الصحة العقلية&quot;.</p>\r\n\r\n<p>وأوضحت أن أوقات الفراغ والبستنة هي أنشطة تساعد جسديا وعقليا.</p>\r\n", "/images/articles/0f6d33c30a.png", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دراسة تحذّر من خطر صحي يرتبط بالجلوس لفترة طويلة!", 0, 20 },
                    { "145", "9", "<p>تتمثل الخطوة الأولى لفقدان الوزن أثناء النوم في الحصول على قسط كاف منه. ويقول الدكتور &quot;ريتشارد ك. بوجان&quot; الأستاذ في كلية الطب بجامعة ساوث كارولينا وباحث النوم، &quot;النوم في حد ذاته يمكن أن يساعد في إنقاص الوزن. النوم ضروري لهرمون الجسم الطبيعي ووظيفة الجهاز المناعي&quot;.</p>\r\n\r\n<p>يحتاج البشر إلى 6-8 ساعات من النوم المتواصل يومياً ، إذا لم تتمكن من النوم لمدة 8 ساعات ، يفشل الجسم على حرق الدهون وأنه بدون الحصول على قسط كاف من النوم ، يؤدي لزيادة مستوى هرمون الجريلين وهو هرمون الجوع.</p>\r\n\r\n<p>لذا &hellip;</p>\r\n\r\n<p>تم إضافة نصائح النوم إلى برامج الوقاية من السمنة وفقدان الوزن.</p>\r\n\r\n<p>أيضاً الحرمان من النوم يؤدي إلى إختلالات هرمونية كبيرة ، التي تؤدي لزيادة الوزن غير المرغوب فيه</p>\r\n\r\n<p>يمكن أن يؤدي الحرمان من النوم إلى زيادة شهيتك نتيجة لزيادة نسب الجريلين واللبتين ما يزيد من شهيتك وتناول السعرات الحرارية، عندما تكون محرومًا من النوم، فإنك تقوم بإختيارات غذائية غير صحية.</p>\r\n\r\n<p>إذا كنت تحاول إنقاص وزنك ، فعليك أولاً محاولة تعديل عادات نومك اتبع جدولًا مناسبًا للنوم كل ليلة أذهب إلى الفراش في الوقت المحدد، وإستيقظ في الوقت المحدد حتى في عطلات نهاية الأسبوع.</p>\r\n\r\n<p>الذين ينامون لمدة أطول بساعة واحدة، يوميا&nbsp; يستهلكون 300 سعراً حرارياً&nbsp;</p>\r\n\r\n<p>وإن الإبتعاد عن شاشات التلفزيونات والهواتف كان عاملاً مشتركاً بين أولئك الذين ينامون لمدة طويلة.</p>\r\n\r\n<p>إذا تم الحفاظ على عادات النوم الصحية لفترة أطول، فسيؤدي ذلك إلى فقدان الوزن مع مرور الوقت.</p>\r\n\r\n<p>وأن عدم الحصول على قسط كافٍ من النوم يؤثر على تنظيم الشهية ويزيد من خطر زيادة الوزن.</p>\r\n\r\n<p>تؤثر دورة نومنا على فقدان الوزن بأكثر من طريقة، يمكن أن يؤدي النوم المريح في الليل إلى تسريع عملية الأيض ويمكن أن يساعدك على إنقاص الوزن.</p>\r\n\r\n<p>يمكن أن تؤدي قلة النوم إلى تقليل معدل الأيض أثناء الراحة، والذي يشار إليه على أنه عدد السعرات الحرارية التي يحرقها جسمك عندما تكون في حالة راحة.</p>\r\n\r\n<p>فالأشخاص الذين لا يحصلون على قسط كافٍ من النوم في الليل يأكلون كثيرًا في اليوم التالي أكثر من المعتاد، ذلك لأن النوم السيئ ليلاً يمكن أن يزيد من الرغبة في تناول الأطعمة السريعة، أيضاً الأشخاص الذين لم يحصلوا على نوم جيد في الليل يتحركون أيضًا بشكل أقل ويحرقون سعرات حرارية أقل على مدار اليوم.</p>\r\n\r\n<p>أيضاً الحرمان من النوم يؤدي إلى الإكتئاب ، الذي بدوره يؤدي إلى الشراهة عند تناول الطعام ، حتى لو كنت لا تأكل كثيراً.</p>\r\n\r\n<p>أخيراً فإن أفضل وسيلة لإنقاص الوزن هو التمسك بالدخول إلى نظام غذائي صحي ، وبطبيعة الحال ليلة نوم جيدة</p>\r\n", "/images/articles/ima5801.png", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "هل النوم مهم لإنقاص الوزن", 0, 20 },
                    { "146", "9", "<h2><span style=\"color:#a566c8\">تساعد التمارين الرياضية في علاج الاكتئاب لأنها تحفز إفراز مادة الإندورفين</span></h2>\r\n\r\n<p>توصلت دراسة بريطانية جديدة شارك فيها 190 ألف شخص، إلى أن المشي بوتيرة سريعة لمدة 75 دقيقة فقط كل أسبوع يقلل من خطر الإصابة بالاكتئاب بنسبة 25%.<br />\r\n<br />\r\nو أن منظمة الصحة العالمية توصي الجميع بضرورة ممارسة الرياضة لمدة ساعتين ونصف الساعة على الأقل كل سبعة أيام.<br />\r\n<br />\r\nلكن باحثين&nbsp; وجدوا أن البالغين الذين مارسوا رياضة المشي بنصف الجرعة الموصى بها كانوا أقل عرضة للإصابة بالاكتئاب بمقدار 20%، في حين أن أولئك الذين مارسوا الرياضة لمدة ساعتين ونصف الساعة على الأقل أسبوعياً تقل لديهم مخاطر الإصابة بنسبة 25%.<br />\r\n<br />\r\nفائدة كبيرة<br />\r\n<br />\r\nوأكد العلماء أن نتائج البحث تشير إلى أنه حتى قدر ضئيل من التمارين يمكن أن تكون له &laquo;فائدة كبيرة&raquo; للصحة العقلية للشخص.<br />\r\n<br />\r\nوتساعد التمارين الرياضية في علاج الاكتئاب لأنها تحفز إفراز مادة الإندورفين -وهي مواد كيميائية تساعد على الشعور بالرضا- وتحسن إدراك صورة الجسم، على حد قول الباحثين.<br />\r\n<br />\r\nوتشير التقديرات إلى أن واحداً من كل خمسة أمريكيين بالغين -أو 40 مليون شخص- يعانون من الاكتئاب الذي يصيبهم بالتعاسة واليأس.<br />\r\n<br />\r\nواقترحت بعض الدراسات أن النشاط البدني يمكن أن يساعد في منع الاكتئاب، وقد يكون فعالًا مثل الأدوية المضادة للاكتئاب.<br />\r\n<br />\r\nوحلل الباحثون بيانات 190 ألف بالغ، بما في ذلك 28000 مصابين بالاكتئاب، في 15 دراسة سابقة في كل من الولايات المتحدة وأستراليا واليابان والهند والمكسيك وروسيا ودول أوروبية.<br />\r\n<br />\r\nوأظهرت النتائج انخفاضاً سريعاً في معدلات الاكتئاب حتى في مستويات النشاط المنخفض.<br />\r\n<br />\r\nوقال الباحثون إنه من المرجح أن &laquo;أكثر من آلية&raquo; أثارتها التمارين أدت إلى انخفاض معدلات الاكتئاب.<br />\r\n<br />\r\nواقترحوا أن التمارين الرياضية قد تخفف الأعراض لأنها تحفز إفراز الإندورفين في الدماغ، مما يعزز الشعور بالراحة.<br />\r\n<br />\r\nويمكن أن تحسن أيضاً إدراك الشخص لذاته وثقته بنفسه، وصورة جسده وتشجع على المزيد من التواصل الاجتماعي.<br />\r\n<br />\r\n<span style=\"font-size:16px\"><span style=\"color:#a566c8\"><strong>كيف تقلل التمارين من خطر الاكتئاب؟</strong></span></span><br />\r\n<br />\r\nالعمليات البيولوجية: التمارين الرياضية تحفز إفراز الإندورفين، أو المواد الكيميائية التي تساعد على تحسين الحالة المزاجية في الدماغ.<br />\r\n<br />\r\n&nbsp;البدينات أكثر عرضة لإصابات العظام<br />\r\n<br />\r\nالمظهر: يمكن أن يعزز التمرين كثيراً الشعور بإيجابية وثقة أكبر تجاه الجسد.<br />\r\n<br />\r\nالتفاعلات الاجتماعية: تساعد بعض التمارين في وجود وخلق مزيد من التفاعل والتواصل الإيجابي مع الآخرين.<br />\r\n<br />\r\nالدماغ: يمكن أن تؤدي أيضاً إلى نمو منطقة الدماغ التي تنظم الحالة المزاجية بشكل أكبر، مما يحسن الروابط العصبية، ويرفع الروح المعنوية ويساعد في تخفيف الاكتئاب.</p>\r\n", "/images/articles/image_202502838.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "75 دقيقة مشي تقلل خطر الإصابة بالاكتئاب بنسبة 25%", 0, 20 },
                    { "147", "9", "<h2><span style=\"color:#a566c8\"><strong>احتمال تسببها في جفاف الجسم من خلال قدرتها على امتصاص السوائل التي تدخل إليه بكميات محدودة طوال فترة الصيام.</strong></span></h2>\r\n\r\n<p><strong>ينصح الأطباء الصائم في رمضان بالاعتناء بنظامه الغذائي أكثر من الأيام العادية، إذ إن اختلال النظام الغذائي خلال شهر رمضان المبارك واقتصاره على وجبتي الإفطار والسحور قد يشعر الجسم بشيء من الانزعاج، تزيد حدته إذا ما تناول الصائم أنواعاً محددة من الأطباق والحلويات.</strong></p>\r\n\r\n<p><strong>لذا، ينصح بتجنب بعض الأطعمة والابتعاد عنها خلال الشهر الفضيل، ومنها على سبيل المثال لا الحصر:</strong></p>\r\n\r\n<ul>\r\n	<li><strong>- المقالي والأطعمة المدهنة على غرار البطاطس المقلية والسمبوسك، لاحتوائها على نسبة عالية جداً من السعرات الحرارية وخلوها من المواد الغذائية، فتناولها بكثرة قد يتسبب في اختلال توازن النظام الغذائي، ويزيد بالتالي من وطأة التعب والإرهاق الناتجين عن الصيام في رمضان.</strong></li>\r\n	<li><strong>- الأطعمة التي تحوي كميات عالية من الملح مثال المخللات، ومرد ذلك احتمال تسببها في جفاف الجسم من خلال قدرتها على امتصاص السوائل التي تدخل إليه بكميات محدودة طوال فترة الصيام.</strong></li>\r\n	<li><strong>- الأطعمة التي بها كميات كبيرة من السكر، بوصفها مصدراً غنياً بالسعرات الحرارية لكن فقيراً بالقيم الغذائية، فصحيح أن هذه الأطباق تمد الجسم بالطاقة الفورية، ولكن هذه الطاقة لا تدوم طويلاً وقد تذهب في أي لحظة.</strong></li>\r\n	<li><strong>- الأطعمة التي تحتوي على الشوكولاتة أو أي مصدر آخر للكافيين المدر للبول، فكثرة هذه المادة في الجسم قد تفقده السوائل والأملاح والمعادن القيمة التي يحتاج إليها خلال النهار.</strong></li>\r\n</ul>\r\n", "/images/articles/im03674.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 أطعمة يجب الابتعاد عنها في رمضان\r\n", 0, 20 },
                    { "148", "9", "<p style=\"text-align:right\"><span style=\"color:#a566c8\"><span style=\"font-size:18px\"><strong>كي تسيطر علي إحساسك بالجوع في فصل الشتاء، عليكِ أن تتعرف على أسباب زيادة الوزن في الشتاء، حتى تتجنبها وتتمكن من الحفاظ على أن يظل قوامكِ مثاليًّا في هذا الفصل من العام.</strong></span></span></p>\r\n\r\n<p style=\"text-align:right\">في دراسة حديثة أوضحت أن 53 بالمائة من الأمهات تعرضن لزيادة في الوزن خلال فصل الشتاء الماضي من أربع إلى عشر كيلوجرامات، نتيجة لعدد من الأسباب، أهمها:&nbsp;</p>\r\n\r\n<ul>\r\n	<li style=\"text-align: right;\"><span style=\"color:#006400\">إنخفاض درجة الحرارة</span></li>\r\n	<li style=\"text-align: right;\">عند إنخفاض درجة الحرارة في فصل الشتاء، والشعور بالبرودة الشديدة، يزيد من الشعور بالجوع، الأمر الذي يؤدي إلى تناول الطعام بكثرة، خصوصًا الوجبات التي تحتوي على الدهون والسكريات. كذلك فإن برودة الجو تزيد من الشعور بالكسل، وعدم ممارسة التمارين الرياضية، ما يؤدي إلى زيادة الوزن.</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">غياب الشمس</span>&nbsp;غياب ضوء الشمس لفترة طويلة خلال ساعات النهار في فصل الشتاء، يؤثر بشكل كبير على النظام الهرموني في الجسم، مما يؤدي إلى الرغبة في تناول الكثير من الأطعمة.</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">إكتئاب الشتاء</span>&nbsp; مع قدوم فصل الشتاء، يشعر كثير من الناس بالإكتئاب الموسمي، ويتسبب ذلك في الرغبة في تناول المزيد من الأطعمة</li>\r\n	<li style=\"text-align: right;\">&nbsp;</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">زيادة عدد ساعات النوم في فصل الشتاء</span>&nbsp; يميل الناس إلى النوم عدد ساعات أكثر، ما يؤثر على معدلات حرق السعرات الحرارية في الجسم، فيقل معدل الحرق ويزداد الوزن.</li>\r\n</ul>\r\n\r\n<p style=\"text-align:right\"><strong>ولأن جميعنا في الشتاء نشعر بالجوع في أيام الشتاء بشكل أكبر بسبب الجو البارد، فيدفعك جسمكِ لا شعوريًّا لطلب ما يمده بالدفء من طعام أو شراب، ولكن تكمن المشكلة في أن جميع الأطعمة الباعثة على الدفء تكون مليئة بالسعرات الحرارية، وهو ما قد يسبب لكِ القلق والخوف من إكتساب المزيد من الكيلوجرامات، في هذا المقال نخبركِ بطرق السيطرة على الجوع في فصل الشتاء، كل ما عليك هو إتباع هذه النصائح الآتية:</strong></p>\r\n\r\n<ul>\r\n	<li style=\"text-align: right;\">احرص على تناول الأطعمة والمشروبات قليلة السعرات الحرارية، مثل: البطاطا الحلوة وشوربة العدس والقرفة والذرة والترمس، فهي تمدكِ بالدف وتشعركِ بالشبع.&nbsp;</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من الخضروات والفواكه مثل البروكلي والملفوف والخضروات الورقية كالسبانخ والجرجير اأيضا الرمان والتفاح والكمثري، على شكل طبق سلطة أو في صورتها الكاملة.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من الأسماك الغنية بالأوميجا 3، مثل: السردين والماكريل والتونة، فهي قليلة السعرات الحرارية، ومليئة بالمواد المضادة للأكسدة.</li>\r\n	<li style=\"text-align: right;\">تناول منتجات الألبان سواء كانت حليبًا أو لبن رائب أو زبادي أو جبن قريش، وتجنب تناول المنتجات الدسمة، مثل: الجبن الشيدر والرومي... وغيرهما.</li>\r\n	<li style=\"text-align: right;\">أكثر من تناول الأطعمة المليئة بالألياف، مثل: الخس والبقوليات، والحبوب مثل: القمح والشعير والشوفان.&nbsp;</li>\r\n	<li style=\"text-align: right;\">تناول المخبوزات المصنوعة من الدقيق الأسمر.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من المشروبات الدافئة كالقهوة والكمون والكركم والشاي الأخضر وحاول أن تقلل من السكريات الأولية البسيطة كالعصائر والحلويات.</li>\r\n	<li style=\"text-align: right;\">تناول المكسرات غير المحمصة، فهي مفيدة جدًّا وقليلة السعرات، ولكن احرص على أن تكون غير مملحة أيضًا.</li>\r\n	<li style=\"text-align: right;\">مارس التمارين الرياضية بشكل يومي.</li>\r\n	<li style=\"text-align: right;\">تناول الأطعمة والمشروبات الساخنة، وخاصة أنواع الحساء المختلفة، واختار الأنواع قليلة السعرات، مثل: شوربة الشوفان والخضار والعدس والكرنب.</li>\r\n	<li style=\"text-align: right;\">احصل على وجبة متوسطة كل ثلاث إلى أربع ساعات، فالشعور بالجوع يجعلك نهمة جدًّا، ما يسبب لكِ زيادة كبيرة في الوزن</li>\r\n	<li style=\"text-align: right;\">احرص على تناول وجبتين رئيسيتين في اليوم، هما الإفطار والغداء، مع ثلاث وجبات بينية خفيفة.</li>\r\n	<li style=\"text-align: right;\">ارتد ملابس مناسبة لحرارة الجو، حتى لا تشعر بشدة البرد، فيدفعك هذا لتناول الكثير من الطعام.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من المياه، واحتمل التردد كثيرًا على دورة المياه، فهذا أفضل من زيادة الوزن، كما أنه يساعد كليتيكِ على إخراج السموم والأملاح الزائدة من جسمك في فصل الشتاء.&nbsp;</li>\r\n	<li style=\"text-align: right;\">أخيرا&nbsp; تجنب زيادة الوزن في الشتاء و، ابتعد عن كل مسببات زيادة الوزن، واتبع طرق السيطرة على الجوع في فصل الشتاء، حتى تحافظ على قوامكِ ولا يزداد وزنكِ.</li>\r\n	<li style=\"text-align: right;\">حافظ على صحتك ولا تجعل برد الشتاء يكون هو محرك الجوع لديك، في الشتاء يفقد جسمك العديد من السعرات في الحفاظ على التدفئة ولكن ذلك ليس السبب في شعورك بالجوع الدائم.</li>\r\n</ul>\r\n", "/images/articles/image_20230202235025276.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "كيف نحارب الجوع في الشتاء؟", 0, 20 },
                    { "149", "9", "Online HTML Editor\r\npowered by CKEditor\r\n\r\nOnline HTML editor user guideReal-time collaboration editor user guide\r\nOnline HTML Editor\r\nReal-time collaboration editor\r\n\r\nSwitch to WYSIWYG editor\r\n<p style=\"text-align:right\"><span style=\"color:#a566c8\"><span style=\"font-size:18px\"><strong>كي تسيطر علي إحساسك بالجوع في فصل الشتاء، عليكِ أن تتعرف على أسباب زيادة الوزن في الشتاء، حتى تتجنبها وتتمكن من الحفاظ على أن يظل قوامكِ مثاليًّا في هذا الفصل من العام.</strong></span></span></p>\r\n\r\n<p style=\"text-align:right\">في دراسة حديثة أوضحت أن 53 بالمائة من الأمهات تعرضن لزيادة في الوزن خلال فصل الشتاء الماضي من أربع إلى عشر كيلوجرامات، نتيجة لعدد من الأسباب، أهمها:&nbsp;</p>\r\n\r\n<ul>\r\n	<li style=\"text-align: right;\"><span style=\"color:#006400\">إنخفاض درجة الحرارة</span></li>\r\n	<li style=\"text-align: right;\">عند إنخفاض درجة الحرارة في فصل الشتاء، والشعور بالبرودة الشديدة، يزيد من الشعور بالجوع، الأمر الذي يؤدي إلى تناول الطعام بكثرة، خصوصًا الوجبات التي تحتوي على الدهون والسكريات. كذلك فإن برودة الجو تزيد من الشعور بالكسل، وعدم ممارسة التمارين الرياضية، ما يؤدي إلى زيادة الوزن.</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">غياب الشمس</span>&nbsp;غياب ضوء الشمس لفترة طويلة خلال ساعات النهار في فصل الشتاء، يؤثر بشكل كبير على النظام الهرموني في الجسم، مما يؤدي إلى الرغبة في تناول الكثير من الأطعمة.</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">إكتئاب الشتاء</span>&nbsp; مع قدوم فصل الشتاء، يشعر كثير من الناس بالإكتئاب الموسمي، ويتسبب ذلك في الرغبة في تناول المزيد من الأطعمة</li>\r\n	<li style=\"text-align: right;\">&nbsp;</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">زيادة عدد ساعات النوم في فصل الشتاء</span>&nbsp; يميل الناس إلى النوم عدد ساعات أكثر، ما يؤثر على معدلات حرق السعرات الحرارية في الجسم، فيقل معدل الحرق ويزداد الوزن.</li>\r\n</ul>\r\n\r\n<p style=\"text-align:right\"><strong>ولأن جميعنا في الشتاء نشعر بالجوع في أيام الشتاء بشكل أكبر بسبب الجو البارد، فيدفعك جسمكِ لا شعوريًّا لطلب ما يمده بالدفء من طعام أو شراب، ولكن تكمن المشكلة في أن جميع الأطعمة الباعثة على الدفء تكون مليئة بالسعرات الحرارية، وهو ما قد يسبب لكِ القلق والخوف من إكتساب المزيد من الكيلوجرامات، في هذا المقال نخبركِ بطرق السيطرة على الجوع في فصل الشتاء، كل ما عليك هو إتباع هذه النصائح الآتية:</strong></p>\r\n\r\n<ul>\r\n	<li style=\"text-align: right;\">احرص على تناول الأطعمة والمشروبات قليلة السعرات الحرارية، مثل: البطاطا الحلوة وشوربة العدس والقرفة والذرة والترمس، فهي تمدكِ بالدف وتشعركِ بالشبع.&nbsp;</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من الخضروات والفواكه مثل البروكلي والملفوف والخضروات الورقية كالسبانخ والجرجير اأيضا الرمان والتفاح والكمثري، على شكل طبق سلطة أو في صورتها الكاملة.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من الأسماك الغنية بالأوميجا 3، مثل: السردين والماكريل والتونة، فهي قليلة السعرات الحرارية، ومليئة بالمواد المضادة للأكسدة.</li>\r\n	<li style=\"text-align: right;\">تناول منتجات الألبان سواء كانت حليبًا أو لبن رائب أو زبادي أو جبن قريش، وتجنب تناول المنتجات الدسمة، مثل: الجبن الشيدر والرومي... وغيرهما.</li>\r\n	<li style=\"text-align: right;\">أكثر من تناول الأطعمة المليئة بالألياف، مثل: الخس والبقوليات، والحبوب مثل: القمح والشعير والشوفان.&nbsp;</li>\r\n	<li style=\"text-align: right;\">تناول المخبوزات المصنوعة من الدقيق الأسمر.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من المشروبات الدافئة كالقهوة والكمون والكركم والشاي الأخضر وحاول أن تقلل من السكريات الأولية البسيطة كالعصائر والحلويات.</li>\r\n	<li style=\"text-align: right;\">تناول المكسرات غير المحمصة، فهي مفيدة جدًّا وقليلة السعرات، ولكن احرص على أن تكون غير مملحة أيضًا.</li>\r\n	<li style=\"text-align: right;\">مارس التمارين الرياضية بشكل يومي.</li>\r\n	<li style=\"text-align: right;\">تناول الأطعمة والمشروبات الساخنة، وخاصة أنواع الحساء المختلفة، واختار الأنواع قليلة السعرات، مثل: شوربة الشوفان والخضار والعدس والكرنب.</li>\r\n	<li style=\"text-align: right;\">احصل على وجبة متوسطة كل ثلاث إلى أربع ساعات، فالشعور بالجوع يجعلك نهمة جدًّا، ما يسبب لكِ زيادة كبيرة في الوزن</li>\r\n	<li style=\"text-align: right;\">احرص على تناول وجبتين رئيسيتين في اليوم، هما الإفطار والغداء، مع ثلاث وجبات بينية خفيفة.</li>\r\n	<li style=\"text-align: right;\">ارتد ملابس مناسبة لحرارة الجو، حتى لا تشعر بشدة البرد، فيدفعك هذا لتناول الكثير من الطعام.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من المياه، واحتمل التردد كثيرًا على دورة المياه، فهذا أفضل من زيادة الوزن، كما أنه يساعد كليتيكِ على إخراج السموم والأملاح الزائدة من جسمك في فصل الشتاء.&nbsp;</li>\r\n	<li style=\"text-align: right;\">أخيرا&nbsp; تجنب زيادة الوزن في الشتاء و، ابتعد عن كل مسببات زيادة الوزن، واتبع طرق السيطرة على الجوع في فصل الشتاء، حتى تحافظ على قوامكِ ولا يزداد وزنكِ.</li>\r\n	<li style=\"text-align: right;\">حافظ على صحتك ولا تجعل برد الشتاء يكون هو محرك الجوع لديك، في الشتاء يفقد جسمك العديد من السعرات في الحفاظ على التدفئة ولكن ذلك ليس السبب في شعورك بالجوع الدائم.</li>\r\n</ul>\r\n\r\n1\r\n<p style=\"text-align:right\"><span style=\"font-size:19.2px\"><span style=\"color:#0f1944\"><span style=\"font-family:bodyFont\"><span style=\"background-color:#fbfbfb\">تنتشر الأطعمة ذات اللون الأسود على الإنترنت بسبب لونها المثير للاهتمام وأيضًا لأنها مليئة بالعناصر الغذائية التي يمكن أن تساعدنا في مكافحة أمراض مثل السكري والسرطان والنوبات القلبية.</span></span></span></span><br />\r\n2\r\n<br />\r\n3\r\n<span style=\"font-size:19.2px\"><span style=\"color:#0f1944\"><span style=\"font-family:bodyFont\"><span style=\"background-color:#fbfbfb\">إليك بعض الأطعمة السوداء التي يجب عليك تناولها ومحاولة دمجها في نظامك الغذائي :</span></span></span></span><br />\r\n4\r\n<br />\r\n5\r\n<span style=\"font-size:18px\"><span style=\"color:#a566c8\"><span style=\"font-family:bodyFont\"><span style=\"background-color:#fbfbfb\">التين الأسود</span></span></span></span><br />\r\n6\r\nالتين الأسود هو فاكهة حلوة ولذيذة وطازج، وهو مصدر غني للبوتاسيوم ويحتوي على نسبة عالية جدًا من الألياف التي تمكن من الهضم الجيد. ومن المعروف أيضًا أن هذا التين يساعدنا في إنقاص الوزن. كما يتكون التين الأسود من مكونات قد تساعد أجسامنا على محاربة الخلايا السرطانية. يمكن أن يقلل هذا التين أيضًا من ضغط الدم لدينا ويساعدنا في معالجة ارتفاع ضغط الدم.<br />\r\n7\r\n<br />\r\n8\r\n<span style=\"font-size:18px\"><span style=\"color:#a566c8\">التوت الأسود</span></span><br />\r\n9\r\nيمكن أن يكون هذا التوت منافساً كبيراً لأنواع التوت الأخرى مثل الفراولة والعنب البري عندما يتعلق الأمر بالفوائد الصحية. من المعروف أنه يعزز صحة القلب لأنه يقلل الالتهاب ويعزز مناعتنا. يجب تناول هذه الفاكهة من قبل النساء اللواتي لديهن مشاكل في تدفق الدورة الشهرية أو حدوثها بشكل غير منتظم. يعتبر التوت الأسود أيضًا أحد الأطعمة الغنية بمضادات الأكسدة ويمكنك استخدامه في العصائر أو الحلويات أو السلطات أو الفطائر.<br />\r\n10\r\n<br />\r\n11\r\n<span style=\"font-size:18px\"><span style=\"color:#a566c8\">بذور السمسم الأسود</span></span><br />\r\n12\r\nتزرع بذور السمسم الأسود في الغالب في آسيا وهي غنية جدًا بالمعادن الكبيرة مثل الكالسيوم والمغنيسيوم التي تساعد في تحسين صحة القلب والأوعية الدموية وارتفاع ضغط الدم. ينظم الحديد والنحاس والمنغنيز في هذه البذور دوران الأكسجين ويبقي معدلات التمثيل الغذائي لدينا تحت السيطرة.<br />\r\n13\r\n<br />\r\n14\r\n<span style=\"font-size:18px\"><span style=\"color:#a566c8\">الثوم الأسود</span></span><br />\r\n15\r\nيُصنع الثوم الأسود عن طريق تخمير الثوم العادي على درجة حرارة عالية لأسابيع. يساعد الثوم الأسود في منع الالتهاب وتقوية الذاكرة. يمكن أن يكون هذا الثوم مفيدًا لمرضى الزهايمر لأنه يحسن الذاكرة قصيرة المدى. أظهر الثوم الأسود من خلال الدراسات أنه أفضل من الثوم النيء بسبب مضادات الأكسدة وخصائصه المضادة للسرطان.<br />\r\n16\r\n<br />\r\n17\r\n<span style=\"font-size:18px\"><span style=\"color:#a566c8\">الأرز الأسود</span></span><br />\r\n18\r\nهذا الأرز الذي يحصل على لونه الفريد من الأنثوسيانين، يستهلكه الصينيون منذ وقت طويل جدًا. يتكون الأرز الأسود من بعض مضادات الأكسدة التي يمكن أن تساعد في تعزيز الرؤية. يتكون من مركبات اللوتين والزياكسانثين التي تحمي شبكية العين من الضوء القاسي. الأرز الأسود هو الخيار الأمثل للأشخاص الذين يعانون من حساسية الغلوتين أو الذين يتبعون نظامًا غذائيًا خالٍ من الغلوتين.</p>\r\n19\r\n​\r\nClean HTML output on the go\r\nHere are the 2 different WYSIWYG HTML editors available on this website:\r\n\r\n• CKEditor 4 with direct access to edit HTML markup\r\n\r\n• CKEditor 5 with real-time collaboration and Markdown support.\r\n\r\nWith both editors, you can create clean HTML output with the easiest WYSIWYG editing possible. If you've already started writing rich-text content, all you have to do is paste it in onlinehtmleditor.dev, make your adjustments, extract HTML output from view-source mode and reuse it anywhere on the web!\r\n\r\nMore on CKEditor 5\r\n\r\nMore on CKEditor 4\r\n\r\nEasy HTML editing\r\nCKEditor 4's HTML source code editing feature allows it to be used as an online HTML editor. It includes syntax highlighting to make it easier for you to follow code. It can be forced to accept any type of code includingtags by simply turning off the HTML filtering. You can also switch to WYSIWYG mode anytime to check how your code output looks!\r\n\r\nClean your HTML code\r\nFor situations where you would like to clean and fix up invalid HTML, you can use CKEditor 4's source code editing feature as well. After switching to source code mode, all you have to do is to paste in your HTML and CKEditor 4 will automatically fix it. You can again switch back and forth to WYSIWYG mode anytime to edit content more easily.\r\n\r\nConvert Word document and Google Docs to HTML\r\nCKEditor 4 and CKEditor 5 have excellent copy-paste with constant improvements. Whether you are copy-pasting from Google Docs, Word, Excel or LibreOffice, CKEditor will get you your exact content. This makes it better than any ordinary tool to turn your existing Word and Google Docs and LibreOffice documents to HTML. Simple as, paste your content, and click source code mode to see the HTML output.\r\n\r\n\r\n\r\nCollaborative writing\r\nIf you're looking for an alternative to Google Docs real-time collaboration, but you also need HTML output, CKEditor 5 is a go! You can use it to comment on selected parts of the content, text, images, tables or suggest edits with its track changes feature.\r\n\r\nTo collaborate with your colleagues or friends all you have to do is to share the link. Each time you load the page, a special document ID gets attached to the URL. Each document ID and its content stays active for an hour after the last user disconnects from it so you do not immediately lose your content. Also, there isn't a limit for the number of collaborators!\r\n\r\nCollaboration makes it easier to create your content quickly and efficiently. With CKEditor 5, where you write, comment, discuss and proofread the content are unified so you don't lose time switching between applications to edit and discuss. If some of your collaborators prefer Markdown, CKEditor 5 has you covered there too!\r\n\r\nLearn about CKEditor 5 collaboration features\r\n\r\nWhy CKEditor?\r\nWYSIWYG editors in your software often misbehave. This is usually because they are out-of-date or simply are not reliable. Unfortunately, many developers opt for simple, lightweight, do-it-yourself-editors based on assumptions without doing proper research or testing for their individual use case. This leaves the end users frustrated.\r\n\r\nHowever, both CKEditors are built with 16 years of experience in WYSIWYG rich-text editing by a team of 40+ developers. We consistently listen to user concerns, trends, new feature requests to help us build our editors. Architectures that can handle complex structures and the constant improvements makes the editors stronger than any other examples.\r\n\r\nThe best WYSIWYG Online HTML editor around\r\nWhat sets CKEditor apart from other online HTML tools is its originality! There are many websites and articles that include lists of best online HTML editors. What these listicles won't tell you is that although they have different names, many of the mentioned tools are simple implementations of CKEditor!\r\n\r\nNow you've found the original online HTML editor! Whether you are looking for a quick online solution or to implement the editor in your own software, CKEditor will always provide you the latest and greatest WYSIWYG features. But if you are looking for some guidance on deciding which editor is the best for you, we can also help with that!\r\n\r\nHow to choose the perfect editor\r\n\r\nOnline HTML editor features\r\nThis section presents a whole variety of features that CKEditor has to offer\r\nStyling and Formatting\r\nThe Basic Styles plugin provides the ability to add some basic text formatting to your document. It adds the Bold, Italic, Underline, Strikethrough, Subscript and Superscript toolbar buttons that apply these styles. If you want to quickly remove basic styles from your document, use the Remove Format button provided by the Remove Format plugin.\r\n\r\nCopy Formatting\r\nThe optional Copy Formatting plugin provides the ability to easily copy text formatting from one place in the document and apply it to another. To copy styles, place your cursor inside the text (or select a styled document fragment) and press the button or use the Ctrl+Shift+C keyboard shortcut.\r\n\r\nRemoving Text Formatting\r\nThe Remove Format plugin provides the ability to quickly remove any text formatting that is applied through inline HTML elements and CSS styles, like basic text styles (bold, italic, etc.), font family and size, text and background colors or styles applied through the Styles drop-down. Note that it does not change text formats applied at block level..\r\n\r\nAutoformatting\r\nThe Autoformat feature in CKEditor 5 allows you to quickly apply formatting to the content you are writing. While it can be customized, by default it can be used as an Markdown alternative. For example you bold by typing **text** or __text__ , create bulleted lists with * or -, create headings with #, ## or ###.\r\n\r\nBlock-Level Text Formats\r\nThe Format plugin provides the ability to add block-level text formatting to your document. It introduces the Paragraph Format toolbar button that applies these text formats. The formats work on block level which means that you do not need to select any text in order to apply them and entire blocks will be affected by your choice.\r\n\r\nTables\r\nThis plugin adds the Table Properties dialog window with support for creating tables and setting basic table properties, such as: number of rows and columns, table width and height, cell padding and spacing, table headers setting, table border size, table alignment on the page and table caption and summary.\r\n\r\nInserting Images\r\nThe default Image plugin supports inserting images into the editor content. This plugin supports left and right alignment. It also allows setting image border as well as pixel-perfect alignment (by setting the horizontal and vertical whitespace). Links can be added to an image easily from the Image Properties dialog. A file manager such as CKFinder can be integrated for image upload and storage support.\r\n\r\nPasting Content from LibreOffice\r\nThe Paste from LibreOffice plugin allows you to paste content from LibreOffice Writer and maintain original content structure and formatting.\r\n\r\nPasting Content from Google Docs\r\nThe Paste from Google Docs plugin allows you to paste content from Google Docs and maintain original content structure and formatting.\r\n\r\nPasting Content from Microsoft Excel\r\nThe Paste from Word plugin allows you to also paste content from Microsoft Excel and maintain original content structure and formatting.\r\n\r\nPasting Content from Microsoft Word\r\nThe Paste from Word plugin allows you to paste content from Microsoft Word and maintain original content structure and formatting. It automatically detects Word content and transforms its structure and formatting to clean HTML.\r\n\r\nSource Code Editing\r\nCKEditor 4 is a WYSIWYG editor, so it makes it easy for end users to work on HTML content without any knowledge of HTML whatsoever. More advanced users, however, sometimes want to access raw HTML source code for their content and CKEditor makes it possible by providing the Source Editing feature.\r\n\r\nCode Snippets\r\nThis plugin allows you to insert rich code fragments and see a live preview with highlighted syntax. Its original implementation uses the highlight.js library, but the plugin exposes a convenient interface for hooking any other library, even a server-side one.\r\n\r\nEmbedding Media Resources\r\nThe Media Embed plugin allow to embed resources (videos, images, tweets, etc.) hosted by other services (like e.g. YouTube, Vimeo, Twitter) in the editor.\r\n\r\nSpellcheck on the go\r\nThe SpellCheckAsYouType (SCAYT) plugin provides inline spelling and grammar checking, much like the native browser spell checker, well-integrated with the CKEditor 4 context menu. It uses the WebSpellChecker web services.\r\n\r\nOnline HTML WYSIWYG Editor © 2023 - all rights reserved.Terms of usePrivacy PolicyCookies policy\r\n\r\n\r\n", "/images/articles/2NM.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 أطعمة سوداء يجب أن تدمجها في نظامك الغذائي", 0, 20 },
                    { "150", "9", "Online HTML Editor\r\npowered by CKEditor\r\n\r\nOnline HTML editor user guideReal-time collaboration editor user guide\r\nOnline HTML Editor\r\nReal-time collaboration editor\r\n\r\nSwitch to WYSIWYG editor\r\n<p style=\"text-align:right\"><span style=\"color:#a566c8\"><span style=\"font-size:18px\"><strong>كي تسيطر علي إحساسك بالجوع في فصل الشتاء، عليكِ أن تتعرف على أسباب زيادة الوزن في الشتاء، حتى تتجنبها وتتمكن من الحفاظ على أن يظل قوامكِ مثاليًّا في هذا الفصل من العام.</strong></span></span></p>\r\n\r\n<p style=\"text-align:right\">في دراسة حديثة أوضحت أن 53 بالمائة من الأمهات تعرضن لزيادة في الوزن خلال فصل الشتاء الماضي من أربع إلى عشر كيلوجرامات، نتيجة لعدد من الأسباب، أهمها:&nbsp;</p>\r\n\r\n<ul>\r\n	<li style=\"text-align: right;\"><span style=\"color:#006400\">إنخفاض درجة الحرارة</span></li>\r\n	<li style=\"text-align: right;\">عند إنخفاض درجة الحرارة في فصل الشتاء، والشعور بالبرودة الشديدة، يزيد من الشعور بالجوع، الأمر الذي يؤدي إلى تناول الطعام بكثرة، خصوصًا الوجبات التي تحتوي على الدهون والسكريات. كذلك فإن برودة الجو تزيد من الشعور بالكسل، وعدم ممارسة التمارين الرياضية، ما يؤدي إلى زيادة الوزن.</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">غياب الشمس</span>&nbsp;غياب ضوء الشمس لفترة طويلة خلال ساعات النهار في فصل الشتاء، يؤثر بشكل كبير على النظام الهرموني في الجسم، مما يؤدي إلى الرغبة في تناول الكثير من الأطعمة.</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">إكتئاب الشتاء</span>&nbsp; مع قدوم فصل الشتاء، يشعر كثير من الناس بالإكتئاب الموسمي، ويتسبب ذلك في الرغبة في تناول المزيد من الأطعمة</li>\r\n	<li style=\"text-align: right;\">&nbsp;</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">زيادة عدد ساعات النوم في فصل الشتاء</span>&nbsp; يميل الناس إلى النوم عدد ساعات أكثر، ما يؤثر على معدلات حرق السعرات الحرارية في الجسم، فيقل معدل الحرق ويزداد الوزن.</li>\r\n</ul>\r\n\r\n<p style=\"text-align:right\"><strong>ولأن جميعنا في الشتاء نشعر بالجوع في أيام الشتاء بشكل أكبر بسبب الجو البارد، فيدفعك جسمكِ لا شعوريًّا لطلب ما يمده بالدفء من طعام أو شراب، ولكن تكمن المشكلة في أن جميع الأطعمة الباعثة على الدفء تكون مليئة بالسعرات الحرارية، وهو ما قد يسبب لكِ القلق والخوف من إكتساب المزيد من الكيلوجرامات، في هذا المقال نخبركِ بطرق السيطرة على الجوع في فصل الشتاء، كل ما عليك هو إتباع هذه النصائح الآتية:</strong></p>\r\n\r\n<ul>\r\n	<li style=\"text-align: right;\">احرص على تناول الأطعمة والمشروبات قليلة السعرات الحرارية، مثل: البطاطا الحلوة وشوربة العدس والقرفة والذرة والترمس، فهي تمدكِ بالدف وتشعركِ بالشبع.&nbsp;</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من الخضروات والفواكه مثل البروكلي والملفوف والخضروات الورقية كالسبانخ والجرجير اأيضا الرمان والتفاح والكمثري، على شكل طبق سلطة أو في صورتها الكاملة.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من الأسماك الغنية بالأوميجا 3، مثل: السردين والماكريل والتونة، فهي قليلة السعرات الحرارية، ومليئة بالمواد المضادة للأكسدة.</li>\r\n	<li style=\"text-align: right;\">تناول منتجات الألبان سواء كانت حليبًا أو لبن رائب أو زبادي أو جبن قريش، وتجنب تناول المنتجات الدسمة، مثل: الجبن الشيدر والرومي... وغيرهما.</li>\r\n	<li style=\"text-align: right;\">أكثر من تناول الأطعمة المليئة بالألياف، مثل: الخس والبقوليات، والحبوب مثل: القمح والشعير والشوفان.&nbsp;</li>\r\n	<li style=\"text-align: right;\">تناول المخبوزات المصنوعة من الدقيق الأسمر.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من المشروبات الدافئة كالقهوة والكمون والكركم والشاي الأخضر وحاول أن تقلل من السكريات الأولية البسيطة كالعصائر والحلويات.</li>\r\n	<li style=\"text-align: right;\">تناول المكسرات غير المحمصة، فهي مفيدة جدًّا وقليلة السعرات، ولكن احرص على أن تكون غير مملحة أيضًا.</li>\r\n	<li style=\"text-align: right;\">مارس التمارين الرياضية بشكل يومي.</li>\r\n	<li style=\"text-align: right;\">تناول الأطعمة والمشروبات الساخنة، وخاصة أنواع الحساء المختلفة، واختار الأنواع قليلة السعرات، مثل: شوربة الشوفان والخضار والعدس والكرنب.</li>\r\n	<li style=\"text-align: right;\">احصل على وجبة متوسطة كل ثلاث إلى أربع ساعات، فالشعور بالجوع يجعلك نهمة جدًّا، ما يسبب لكِ زيادة كبيرة في الوزن</li>\r\n	<li style=\"text-align: right;\">احرص على تناول وجبتين رئيسيتين في اليوم، هما الإفطار والغداء، مع ثلاث وجبات بينية خفيفة.</li>\r\n	<li style=\"text-align: right;\">ارتد ملابس مناسبة لحرارة الجو، حتى لا تشعر بشدة البرد، فيدفعك هذا لتناول الكثير من الطعام.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من المياه، واحتمل التردد كثيرًا على دورة المياه، فهذا أفضل من زيادة الوزن، كما أنه يساعد كليتيكِ على إخراج السموم والأملاح الزائدة من جسمك في فصل الشتاء.&nbsp;</li>\r\n	<li style=\"text-align: right;\">أخيرا&nbsp; تجنب زيادة الوزن في الشتاء و، ابتعد عن كل مسببات زيادة الوزن، واتبع طرق السيطرة على الجوع في فصل الشتاء، حتى تحافظ على قوامكِ ولا يزداد وزنكِ.</li>\r\n	<li style=\"text-align: right;\">حافظ على صحتك ولا تجعل برد الشتاء يكون هو محرك الجوع لديك، في الشتاء يفقد جسمك العديد من السعرات في الحفاظ على التدفئة ولكن ذلك ليس السبب في شعورك بالجوع الدائم.</li>\r\n</ul>\r\n\r\n1\r\n<p style=\"text-align:right\"><strong>يعرف الأكل العاطفي بأنه الإفراط في تناول الطعام لقمع أو تهدئة المشاعر السلبية، مثل التوتر والغضب والخوف، والملل والحزن والوحدة</strong><strong>.</strong><br />\r\n2\r\n<strong>ويمكن أن يكون الطعام أيضا مصدر إلهاء، وإذا كنت قلقا بشأن حدث قادم أو بسبب صراع ما، على سبيل المثال، يمكن التركيز على تناول طعام مريح بدلا من التعامل مع الموقف المؤلم</strong><strong>.</strong><br />\r\n3\r\n<strong>وغالبا ما يؤدي الأكل العاطفي إلى الإفراط في تناول الطعام، وخاصة الإفراط في تناول الأطعمة الحلوة والدهنية وعالية السعرات الحرارية. وهذا يمكن أن يبدد الجهود المبذولة في إنقاص الوزن</strong><strong>.</strong><br />\r\n4\r\n<strong>وعندما تهدد المشاعر السلبية بتحفيز الأكل العاطفي<span style=\"color:#a566c8\">،&nbsp;<span style=\"font-size:18px\">جرب هذه النصائح التسع للبقاء على المسار الصحيح:</span></span></strong></p>\r\n5\r\n​\r\n6\r\n<ul>\r\n7\r\n    <li><strong>احتفظ بمفكرة طعام</strong><strong>:</strong>&nbsp;<strong>اكتب ما تأكله، وكم تأكل، ومتى تأكل، وكيف تشعر عندما تأكل، ومدى جوعك. وبمرور الوقت، قد ترى أنماطا تكشف العلاقة بين الحالة المزاجية والطعام</strong><strong>.</strong></li>\r\n8\r\n    <li><strong>خفف من توترك</strong>:&nbsp;<strong>إذا كان التوتر يساهم في الأكل العاطفي، فجرب أسلوب إدارة الإجهاد، مثل اليوغا أو التأمل أو التنفس العميق</strong><strong>.</strong></li>\r\n9\r\n    <li><strong>قم بفحص حقيقة الجوع</strong><strong>:&nbsp;</strong><strong>هل جوعك جسدي أم عاطفي؟ إذا كنت أكلت قبل ساعات قليلة فقط ولم تكن تسمع أصواتا قادمة من المعدة، فمن المحتمل أنك لست جائعا</strong><strong>.</strong></li>\r\n10\r\n    <li><strong>احصل على الدعم</strong><strong>:</strong>&nbsp;<strong>من المرجح أن تستسلم للأكل العاطفي إذا كنت تفتقر إلى شبكة دعم جيدة. اعتمد على العائلة والأصدقاء، أو فكر في الانضمام إلى مجموعة دعم</strong><strong>.</strong></li>\r\n11\r\n    <li><strong>حارب الملل</strong>:&nbsp;<strong>بدلا من تناول الوجبات الخفيفة عندما لا تكون جائعا، شتت نفسك واستبدل ذلك بسلوك أكثر صحة. ويمكنك المشي أو مشاهدة فيلم أو اللعب مع حيوانك الأليف أو الاستماع إلى الموسيقى أو القراءة أو تصفح الإنترنت أو الاتصال بصديق</strong><strong>.</strong></li>\r\n12\r\n    <li><strong>تخلص من المغريات</strong><strong>:</strong>&nbsp;<strong>لا تحتفظ بأطعمة مغرية يصعب مقاومتها في منزلك. وإذا شعرت بالغضب أو الحزن، فقم بتأجيل رحلتك إلى متجر البقالة حتى تتخلص من عواطفك</strong><strong>.</strong></li>\r\n13\r\n    <li><strong>لا تحرم نفسك</strong><strong>:</strong>&nbsp;<strong>عند محاولة إنقاص الوزن، قد تحد من السعرات الحرارية أكثر من اللازم، وتتناول نفس الأطعمة بشكل متكرر وتتجنب المكافآت. وقد يؤدي هذا فقط إلى زيادة الرغبة الشديدة في تناول الطعام، خاصةً عند الاستجابة للعواطف. ويمكنك تناول كميات مُرضية من الأطعمة الصحية، واستمتع بتناول الطعام من حين لآخر، واحصل على الكثير من التنوع للحد من الرغبة الشديدة في تناول الطعام</strong><strong>.</strong></li>\r\n14\r\n    <li><strong>وجبة خفيفة صحية</strong><strong>:&nbsp;</strong><strong>إذا شعرت بالحاجة إلى تناول الطعام بين الوجبات، فاختر وجبة خفيفة صحية، مثل الفاكهة الطازجة، أو الخضار، أو المكسرات، أو الفشار. أو جرب نسخا منخفضة السعرات الحرارية من أطعمتك المفضلة لترى ما إذا كانت ترضي رغباتك</strong><strong>.</strong></li>\r\n15\r\n    <li><strong>تعلم من النكسات</strong><strong>:&nbsp;</strong><strong>إذا كانت لديك نوبة من الأكل العاطفي، فاغفر لنفسك وابدأ من جديد في اليوم التالي. وحاول أن تتعلم من التجربة وخطط لكيفية منعها في المستقبل. ركز على التغييرات الإيجابية التي تجريها في عاداتك الغذائية وامنح نفسك الإرادة لإجراء تغييرات تؤدي إلى صحة أفضل</strong><strong>.</strong></li>\r\n16\r\n</ul>\r\n17\r\n​\r\nClean HTML output on the go\r\nHere are the 2 different WYSIWYG HTML editors available on this website:\r\n\r\n• CKEditor 4 with direct access to edit HTML markup\r\n\r\n• CKEditor 5 with real-time collaboration and Markdown support.\r\n\r\nWith both editors, you can create clean HTML output with the easiest WYSIWYG editing possible. If you've already started writing rich-text content, all you have to do is paste it in onlinehtmleditor.dev, make your adjustments, extract HTML output from view-source mode and reuse it anywhere on the web!\r\n\r\nMore on CKEditor 5\r\n\r\nMore on CKEditor 4\r\n\r\nEasy HTML editing\r\nCKEditor 4's HTML source code editing feature allows it to be used as an online HTML editor. It includes syntax highlighting to make it easier for you to follow code. It can be forced to accept any type of code includingtags by simply turning off the HTML filtering. You can also switch to WYSIWYG mode anytime to check how your code output looks!\r\n\r\nClean your HTML code\r\nFor situations where you would like to clean and fix up invalid HTML, you can use CKEditor 4's source code editing feature as well. After switching to source code mode, all you have to do is to paste in your HTML and CKEditor 4 will automatically fix it. You can again switch back and forth to WYSIWYG mode anytime to edit content more easily.\r\n\r\nConvert Word document and Google Docs to HTML\r\nCKEditor 4 and CKEditor 5 have excellent copy-paste with constant improvements. Whether you are copy-pasting from Google Docs, Word, Excel or LibreOffice, CKEditor will get you your exact content. This makes it better than any ordinary tool to turn your existing Word and Google Docs and LibreOffice documents to HTML. Simple as, paste your content, and click source code mode to see the HTML output.\r\n\r\n\r\n\r\nCollaborative writing\r\nIf you're looking for an alternative to Google Docs real-time collaboration, but you also need HTML output, CKEditor 5 is a go! You can use it to comment on selected parts of the content, text, images, tables or suggest edits with its track changes feature.\r\n\r\nTo collaborate with your colleagues or friends all you have to do is to share the link. Each time you load the page, a special document ID gets attached to the URL. Each document ID and its content stays active for an hour after the last user disconnects from it so you do not immediately lose your content. Also, there isn't a limit for the number of collaborators!\r\n\r\nCollaboration makes it easier to create your content quickly and efficiently. With CKEditor 5, where you write, comment, discuss and proofread the content are unified so you don't lose time switching between applications to edit and discuss. If some of your collaborators prefer Markdown, CKEditor 5 has you covered there too!\r\n\r\nLearn about CKEditor 5 collaboration features\r\n\r\nWhy CKEditor?\r\nWYSIWYG editors in your software often misbehave. This is usually because they are out-of-date or simply are not reliable. Unfortunately, many developers opt for simple, lightweight, do-it-yourself-editors based on assumptions without doing proper research or testing for their individual use case. This leaves the end users frustrated.\r\n\r\nHowever, both CKEditors are built with 16 years of experience in WYSIWYG rich-text editing by a team of 40+ developers. We consistently listen to user concerns, trends, new feature requests to help us build our editors. Architectures that can handle complex structures and the constant improvements makes the editors stronger than any other examples.\r\n\r\nThe best WYSIWYG Online HTML editor around\r\nWhat sets CKEditor apart from other online HTML tools is its originality! There are many websites and articles that include lists of best online HTML editors. What these listicles won't tell you is that although they have different names, many of the mentioned tools are simple implementations of CKEditor!\r\n\r\nNow you've found the original online HTML editor! Whether you are looking for a quick online solution or to implement the editor in your own software, CKEditor will always provide you the latest and greatest WYSIWYG features. But if you are looking for some guidance on deciding which editor is the best for you, we can also help with that!\r\n\r\nHow to choose the perfect editor\r\n\r\nOnline HTML editor features\r\nThis section presents a whole variety of features that CKEditor has to offer\r\nStyling and Formatting\r\nThe Basic Styles plugin provides the ability to add some basic text formatting to your document. It adds the Bold, Italic, Underline, Strikethrough, Subscript and Superscript toolbar buttons that apply these styles. If you want to quickly remove basic styles from your document, use the Remove Format button provided by the Remove Format plugin.\r\n\r\nCopy Formatting\r\nThe optional Copy Formatting plugin provides the ability to easily copy text formatting from one place in the document and apply it to another. To copy styles, place your cursor inside the text (or select a styled document fragment) and press the button or use the Ctrl+Shift+C keyboard shortcut.\r\n\r\nRemoving Text Formatting\r\nThe Remove Format plugin provides the ability to quickly remove any text formatting that is applied through inline HTML elements and CSS styles, like basic text styles (bold, italic, etc.), font family and size, text and background colors or styles applied through the Styles drop-down. Note that it does not change text formats applied at block level..\r\n\r\nAutoformatting\r\nThe Autoformat feature in CKEditor 5 allows you to quickly apply formatting to the content you are writing. While it can be customized, by default it can be used as an Markdown alternative. For example you bold by typing **text** or __text__ , create bulleted lists with * or -, create headings with #, ## or ###.\r\n\r\nBlock-Level Text Formats\r\nThe Format plugin provides the ability to add block-level text formatting to your document. It introduces the Paragraph Format toolbar button that applies these text formats. The formats work on block level which means that you do not need to select any text in order to apply them and entire blocks will be affected by your choice.\r\n\r\nTables\r\nThis plugin adds the Table Properties dialog window with support for creating tables and setting basic table properties, such as: number of rows and columns, table width and height, cell padding and spacing, table headers setting, table border size, table alignment on the page and table caption and summary.\r\n\r\nInserting Images\r\nThe default Image plugin supports inserting images into the editor content. This plugin supports left and right alignment. It also allows setting image border as well as pixel-perfect alignment (by setting the horizontal and vertical whitespace). Links can be added to an image easily from the Image Properties dialog. A file manager such as CKFinder can be integrated for image upload and storage support.\r\n\r\nPasting Content from LibreOffice\r\nThe Paste from LibreOffice plugin allows you to paste content from LibreOffice Writer and maintain original content structure and formatting.\r\n\r\nPasting Content from Google Docs\r\nThe Paste from Google Docs plugin allows you to paste content from Google Docs and maintain original content structure and formatting.\r\n\r\nPasting Content from Microsoft Excel\r\nThe Paste from Word plugin allows you to also paste content from Microsoft Excel and maintain original content structure and formatting.\r\n\r\nPasting Content from Microsoft Word\r\nThe Paste from Word plugin allows you to paste content from Microsoft Word and maintain original content structure and formatting. It automatically detects Word content and transforms its structure and formatting to clean HTML.\r\n\r\nSource Code Editing\r\nCKEditor 4 is a WYSIWYG editor, so it makes it easy for end users to work on HTML content without any knowledge of HTML whatsoever. More advanced users, however, sometimes want to access raw HTML source code for their content and CKEditor makes it possible by providing the Source Editing feature.\r\n\r\nCode Snippets\r\nThis plugin allows you to insert rich code fragments and see a live preview with highlighted syntax. Its original implementation uses the highlight.js library, but the plugin exposes a convenient interface for hooking any other library, even a server-side one.\r\n\r\nEmbedding Media Resources\r\nThe Media Embed plugin allow to embed resources (videos, images, tweets, etc.) hosted by other services (like e.g. YouTube, Vimeo, Twitter) in the editor.\r\n\r\nSpellcheck on the go\r\nThe SpellCheckAsYouType (SCAYT) plugin provides inline spelling and grammar checking, much like the native browser spell checker, well-integrated with the CKEditor 4 context menu. It uses the WebSpellChecker web services.\r\n\r\nOnline HTML WYSIWYG Editor © 2023 - all rights reserved.Terms of usePrivacy PolicyCookies policy\r\n\r\n\r\n", "/images/articles/image_20230404210740716.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الأكل العاطفي .. ما هو وكيف يمكن التغلب عليه؟\r\n", 0, 20 },
                    { "151", "9", "Online HTML Editor\r\npowered by CKEditor\r\n\r\nOnline HTML editor user guideReal-time collaboration editor user guide\r\nOnline HTML Editor\r\nReal-time collaboration editor\r\n\r\nSwitch to WYSIWYG editor\r\n<p style=\"text-align:right\"><span style=\"color:#a566c8\"><span style=\"font-size:18px\"><strong>كي تسيطر علي إحساسك بالجوع في فصل الشتاء، عليكِ أن تتعرف على أسباب زيادة الوزن في الشتاء، حتى تتجنبها وتتمكن من الحفاظ على أن يظل قوامكِ مثاليًّا في هذا الفصل من العام.</strong></span></span></p>\r\n\r\n<p style=\"text-align:right\">في دراسة حديثة أوضحت أن 53 بالمائة من الأمهات تعرضن لزيادة في الوزن خلال فصل الشتاء الماضي من أربع إلى عشر كيلوجرامات، نتيجة لعدد من الأسباب، أهمها:&nbsp;</p>\r\n\r\n<ul>\r\n	<li style=\"text-align: right;\"><span style=\"color:#006400\">إنخفاض درجة الحرارة</span></li>\r\n	<li style=\"text-align: right;\">عند إنخفاض درجة الحرارة في فصل الشتاء، والشعور بالبرودة الشديدة، يزيد من الشعور بالجوع، الأمر الذي يؤدي إلى تناول الطعام بكثرة، خصوصًا الوجبات التي تحتوي على الدهون والسكريات. كذلك فإن برودة الجو تزيد من الشعور بالكسل، وعدم ممارسة التمارين الرياضية، ما يؤدي إلى زيادة الوزن.</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">غياب الشمس</span>&nbsp;غياب ضوء الشمس لفترة طويلة خلال ساعات النهار في فصل الشتاء، يؤثر بشكل كبير على النظام الهرموني في الجسم، مما يؤدي إلى الرغبة في تناول الكثير من الأطعمة.</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">إكتئاب الشتاء</span>&nbsp; مع قدوم فصل الشتاء، يشعر كثير من الناس بالإكتئاب الموسمي، ويتسبب ذلك في الرغبة في تناول المزيد من الأطعمة</li>\r\n	<li style=\"text-align: right;\">&nbsp;</li>\r\n	<li style=\"text-align: right;\"><span style=\"color:#008000\">زيادة عدد ساعات النوم في فصل الشتاء</span>&nbsp; يميل الناس إلى النوم عدد ساعات أكثر، ما يؤثر على معدلات حرق السعرات الحرارية في الجسم، فيقل معدل الحرق ويزداد الوزن.</li>\r\n</ul>\r\n\r\n<p style=\"text-align:right\"><strong>ولأن جميعنا في الشتاء نشعر بالجوع في أيام الشتاء بشكل أكبر بسبب الجو البارد، فيدفعك جسمكِ لا شعوريًّا لطلب ما يمده بالدفء من طعام أو شراب، ولكن تكمن المشكلة في أن جميع الأطعمة الباعثة على الدفء تكون مليئة بالسعرات الحرارية، وهو ما قد يسبب لكِ القلق والخوف من إكتساب المزيد من الكيلوجرامات، في هذا المقال نخبركِ بطرق السيطرة على الجوع في فصل الشتاء، كل ما عليك هو إتباع هذه النصائح الآتية:</strong></p>\r\n\r\n<ul>\r\n	<li style=\"text-align: right;\">احرص على تناول الأطعمة والمشروبات قليلة السعرات الحرارية، مثل: البطاطا الحلوة وشوربة العدس والقرفة والذرة والترمس، فهي تمدكِ بالدف وتشعركِ بالشبع.&nbsp;</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من الخضروات والفواكه مثل البروكلي والملفوف والخضروات الورقية كالسبانخ والجرجير اأيضا الرمان والتفاح والكمثري، على شكل طبق سلطة أو في صورتها الكاملة.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من الأسماك الغنية بالأوميجا 3، مثل: السردين والماكريل والتونة، فهي قليلة السعرات الحرارية، ومليئة بالمواد المضادة للأكسدة.</li>\r\n	<li style=\"text-align: right;\">تناول منتجات الألبان سواء كانت حليبًا أو لبن رائب أو زبادي أو جبن قريش، وتجنب تناول المنتجات الدسمة، مثل: الجبن الشيدر والرومي... وغيرهما.</li>\r\n	<li style=\"text-align: right;\">أكثر من تناول الأطعمة المليئة بالألياف، مثل: الخس والبقوليات، والحبوب مثل: القمح والشعير والشوفان.&nbsp;</li>\r\n	<li style=\"text-align: right;\">تناول المخبوزات المصنوعة من الدقيق الأسمر.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من المشروبات الدافئة كالقهوة والكمون والكركم والشاي الأخضر وحاول أن تقلل من السكريات الأولية البسيطة كالعصائر والحلويات.</li>\r\n	<li style=\"text-align: right;\">تناول المكسرات غير المحمصة، فهي مفيدة جدًّا وقليلة السعرات، ولكن احرص على أن تكون غير مملحة أيضًا.</li>\r\n	<li style=\"text-align: right;\">مارس التمارين الرياضية بشكل يومي.</li>\r\n	<li style=\"text-align: right;\">تناول الأطعمة والمشروبات الساخنة، وخاصة أنواع الحساء المختلفة، واختار الأنواع قليلة السعرات، مثل: شوربة الشوفان والخضار والعدس والكرنب.</li>\r\n	<li style=\"text-align: right;\">احصل على وجبة متوسطة كل ثلاث إلى أربع ساعات، فالشعور بالجوع يجعلك نهمة جدًّا، ما يسبب لكِ زيادة كبيرة في الوزن</li>\r\n	<li style=\"text-align: right;\">احرص على تناول وجبتين رئيسيتين في اليوم، هما الإفطار والغداء، مع ثلاث وجبات بينية خفيفة.</li>\r\n	<li style=\"text-align: right;\">ارتد ملابس مناسبة لحرارة الجو، حتى لا تشعر بشدة البرد، فيدفعك هذا لتناول الكثير من الطعام.</li>\r\n	<li style=\"text-align: right;\">تناول الكثير من المياه، واحتمل التردد كثيرًا على دورة المياه، فهذا أفضل من زيادة الوزن، كما أنه يساعد كليتيكِ على إخراج السموم والأملاح الزائدة من جسمك في فصل الشتاء.&nbsp;</li>\r\n	<li style=\"text-align: right;\">أخيرا&nbsp; تجنب زيادة الوزن في الشتاء و، ابتعد عن كل مسببات زيادة الوزن، واتبع طرق السيطرة على الجوع في فصل الشتاء، حتى تحافظ على قوامكِ ولا يزداد وزنكِ.</li>\r\n	<li style=\"text-align: right;\">حافظ على صحتك ولا تجعل برد الشتاء يكون هو محرك الجوع لديك، في الشتاء يفقد جسمك العديد من السعرات في الحفاظ على التدفئة ولكن ذلك ليس السبب في شعورك بالجوع الدائم.</li>\r\n</ul>\r\n\r\n1\r\n<p>لا شك أن كل ساع إلى الرشاقة جرب&nbsp;<strong>النظام الغذائي</strong>&nbsp;القديم الذي يركز على تناول وجبة كبيرة في الإفطار وأقل بعض الشيء على الغداء، ووجبة خفيفة جداً على العشاء.</p>\r\n2\r\n​\r\n3\r\n<p>فقد ربطت بعض الدراسات والخبراء سابقا أكل الجزء الأكبر من الطعام في وقت مبكر من اليوم، بانخفاض معدلات السمنة والتخلص من الوزن الزائد، إلا أن دراسة جديدة كشفت عدم صحة ذلك.</p>\r\n4\r\n​\r\n5\r\n<p>إذ اكتشف باحثون أسكتلنديون أن موعد تناول الوجبات ليس له أي تأثير على فقدان الوزن، مشيرين إلى أن عملية التمثيل الغذائي تحرق الكثير من السعرات الحرارية في المساء كما تفعل في الصباح.</p>\r\n6\r\n​\r\n7\r\n<p>كما اعتبروا أن الفائدة الوحيدة من تناول المزيد من الطعام في الصباح هي عدم الجوع في وقت لاحق من اليوم، وفق ما نقلت صحيفة &quot;ذا صن&quot; البريطانية.</p>\r\n8\r\n​\r\n9\r\n<p>وأجريت الدراسة التي نُشرت على 16 رجلاً و14 امرأة على مدار أربعة أسابيع لمعرفة كيف تأثر وزنهم اعتماداً على أي وقت من اليوم يأكلون فيه معظم السعرات الحرارية.</p>\r\n10\r\n​\r\n11\r\n<p>فيما أعطي كل شخص نفس النظام الغذائي الصحي، لكن نصفهم أجبروا على تناول غالبية السعرات الحرارية في وقت الإفطار، والنصف الآخر على العشاء.</p>\r\n12\r\n​\r\n13\r\n<p>وبعد أسبوعين أجري العكس، حيث تناول الأشخاص الذين تناولوا معظم سعراتهم الحرارية في الصباح في وقت لاحق من اليوم، والعكس صحيح.</p>\r\n14\r\n​\r\n15\r\n<p>إلى ذلك، فقد كل شخص في الدراسة نفس القدر من الوزن خلال كل أسبوع من الأسابيع الأربعة، مما يشير إلى أن عملية الأيض لديهم تحرق نفس القدر من الطاقة في الصباح مثل المساء.</p>\r\n16\r\n​\r\n17\r\n<p>بدورها، أوضحت الكاتبة الرئيسية للدراسة،&nbsp;أن المشاركين شعروا أنهم تحكموا بشهيتهم بشكل أفضل في الأيام التي تناولوا فيها وجبة فطور أكبر وأنهم &quot;شعروا بالشبع طوال اليوم&quot;.</p>\r\n18\r\n​\r\n19\r\n<p>ومع ذلك، أشارت إلى أنه عندما يتعلق الأمر بالتوقيت واتباع نظام غذائي، فإنه &quot;من غير المحتمل أن يكون هناك نظام غذائي واحد يناسب الجميع&quot;. وأضافت أن &quot;اكتشاف هذا سيكون مستقبل دراسات النظام الغذائي، ولكن من الصعب جداً قياسه&quot;.</p>\r\n20\r\n​\r\n21\r\n<p>يشار إلى أن فقدان الوزن يختلف من شخص لآخر، ولكن الطريقة الوحيدة التي تعمل في جميع المجالات هي نقص السعرات الحرارية.</p>\r\n22\r\n​\r\n23\r\n<p>ويحدث النقص في السعرات الحرارية عندما تستهلك سعرات حرارية أقل مما تستهلكه في اليوم.</p>\r\n24\r\n​\r\nClean HTML output on the go\r\nHere are the 2 different WYSIWYG HTML editors available on this website:\r\n\r\n• CKEditor 4 with direct access to edit HTML markup\r\n\r\n• CKEditor 5 with real-time collaboration and Markdown support.\r\n\r\nWith both editors, you can create clean HTML output with the easiest WYSIWYG editing possible. If you've already started writing rich-text content, all you have to do is paste it in onlinehtmleditor.dev, make your adjustments, extract HTML output from view-source mode and reuse it anywhere on the web!\r\n\r\nMore on CKEditor 5\r\n\r\nMore on CKEditor 4\r\n\r\nEasy HTML editing\r\nCKEditor 4's HTML source code editing feature allows it to be used as an online HTML editor. It includes syntax highlighting to make it easier for you to follow code. It can be forced to accept any type of code includingtags by simply turning off the HTML filtering. You can also switch to WYSIWYG mode anytime to check how your code output looks!\r\n\r\nClean your HTML code\r\nFor situations where you would like to clean and fix up invalid HTML, you can use CKEditor 4's source code editing feature as well. After switching to source code mode, all you have to do is to paste in your HTML and CKEditor 4 will automatically fix it. You can again switch back and forth to WYSIWYG mode anytime to edit content more easily.\r\n\r\nConvert Word document and Google Docs to HTML\r\nCKEditor 4 and CKEditor 5 have excellent copy-paste with constant improvements. Whether you are copy-pasting from Google Docs, Word, Excel or LibreOffice, CKEditor will get you your exact content. This makes it better than any ordinary tool to turn your existing Word and Google Docs and LibreOffice documents to HTML. Simple as, paste your content, and click source code mode to see the HTML output.\r\n\r\n\r\n\r\nCollaborative writing\r\nIf you're looking for an alternative to Google Docs real-time collaboration, but you also need HTML output, CKEditor 5 is a go! You can use it to comment on selected parts of the content, text, images, tables or suggest edits with its track changes feature.\r\n\r\nTo collaborate with your colleagues or friends all you have to do is to share the link. Each time you load the page, a special document ID gets attached to the URL. Each document ID and its content stays active for an hour after the last user disconnects from it so you do not immediately lose your content. Also, there isn't a limit for the number of collaborators!\r\n\r\nCollaboration makes it easier to create your content quickly and efficiently. With CKEditor 5, where you write, comment, discuss and proofread the content are unified so you don't lose time switching between applications to edit and discuss. If some of your collaborators prefer Markdown, CKEditor 5 has you covered there too!\r\n\r\nLearn about CKEditor 5 collaboration features\r\n\r\nWhy CKEditor?\r\nWYSIWYG editors in your software often misbehave. This is usually because they are out-of-date or simply are not reliable. Unfortunately, many developers opt for simple, lightweight, do-it-yourself-editors based on assumptions without doing proper research or testing for their individual use case. This leaves the end users frustrated.\r\n\r\nHowever, both CKEditors are built with 16 years of experience in WYSIWYG rich-text editing by a team of 40+ developers. We consistently listen to user concerns, trends, new feature requests to help us build our editors. Architectures that can handle complex structures and the constant improvements makes the editors stronger than any other examples.\r\n\r\nThe best WYSIWYG Online HTML editor around\r\nWhat sets CKEditor apart from other online HTML tools is its originality! There are many websites and articles that include lists of best online HTML editors. What these listicles won't tell you is that although they have different names, many of the mentioned tools are simple implementations of CKEditor!\r\n\r\nNow you've found the original online HTML editor! Whether you are looking for a quick online solution or to implement the editor in your own software, CKEditor will always provide you the latest and greatest WYSIWYG features. But if you are looking for some guidance on deciding which editor is the best for you, we can also help with that!\r\n\r\nHow to choose the perfect editor\r\n\r\nOnline HTML editor features\r\nThis section presents a whole variety of features that CKEditor has to offer\r\nStyling and Formatting\r\nThe Basic Styles plugin provides the ability to add some basic text formatting to your document. It adds the Bold, Italic, Underline, Strikethrough, Subscript and Superscript toolbar buttons that apply these styles. If you want to quickly remove basic styles from your document, use the Remove Format button provided by the Remove Format plugin.\r\n\r\nCopy Formatting\r\nThe optional Copy Formatting plugin provides the ability to easily copy text formatting from one place in the document and apply it to another. To copy styles, place your cursor inside the text (or select a styled document fragment) and press the button or use the Ctrl+Shift+C keyboard shortcut.\r\n\r\nRemoving Text Formatting\r\nThe Remove Format plugin provides the ability to quickly remove any text formatting that is applied through inline HTML elements and CSS styles, like basic text styles (bold, italic, etc.), font family and size, text and background colors or styles applied through the Styles drop-down. Note that it does not change text formats applied at block level..\r\n\r\nAutoformatting\r\nThe Autoformat feature in CKEditor 5 allows you to quickly apply formatting to the content you are writing. While it can be customized, by default it can be used as an Markdown alternative. For example you bold by typing **text** or __text__ , create bulleted lists with * or -, create headings with #, ## or ###.\r\n\r\nBlock-Level Text Formats\r\nThe Format plugin provides the ability to add block-level text formatting to your document. It introduces the Paragraph Format toolbar button that applies these text formats. The formats work on block level which means that you do not need to select any text in order to apply them and entire blocks will be affected by your choice.\r\n\r\nTables\r\nThis plugin adds the Table Properties dialog window with support for creating tables and setting basic table properties, such as: number of rows and columns, table width and height, cell padding and spacing, table headers setting, table border size, table alignment on the page and table caption and summary.\r\n\r\nInserting Images\r\nThe default Image plugin supports inserting images into the editor content. This plugin supports left and right alignment. It also allows setting image border as well as pixel-perfect alignment (by setting the horizontal and vertical whitespace). Links can be added to an image easily from the Image Properties dialog. A file manager such as CKFinder can be integrated for image upload and storage support.\r\n\r\nPasting Content from LibreOffice\r\nThe Paste from LibreOffice plugin allows you to paste content from LibreOffice Writer and maintain original content structure and formatting.\r\n\r\nPasting Content from Google Docs\r\nThe Paste from Google Docs plugin allows you to paste content from Google Docs and maintain original content structure and formatting.\r\n\r\nPasting Content from Microsoft Excel\r\nThe Paste from Word plugin allows you to also paste content from Microsoft Excel and maintain original content structure and formatting.\r\n\r\nPasting Content from Microsoft Word\r\nThe Paste from Word plugin allows you to paste content from Microsoft Word and maintain original content structure and formatting. It automatically detects Word content and transforms its structure and formatting to clean HTML.\r\n\r\nSource Code Editing\r\nCKEditor 4 is a WYSIWYG editor, so it makes it easy for end users to work on HTML content without any knowledge of HTML whatsoever. More advanced users, however, sometimes want to access raw HTML source code for their content and CKEditor makes it possible by providing the Source Editing feature.\r\n\r\nCode Snippets\r\nThis plugin allows you to insert rich code fragments and see a live preview with highlighted syntax. Its original implementation uses the highlight.js library, but the plugin exposes a convenient interface for hooking any other library, even a server-side one.\r\n\r\nEmbedding Media Resources\r\nThe Media Embed plugin allow to embed resources (videos, images, tweets, etc.) hosted by other services (like e.g. YouTube, Vimeo, Twitter) in the editor.\r\n\r\nSpellcheck on the go\r\nThe SpellCheckAsYouType (SCAYT) plugin provides inline spelling and grammar checking, much like the native browser spell checker, well-integrated with the CKEditor 4 context menu. It uses the WebSpellChecker web services.\r\n\r\nOnline HTML WYSIWYG Editor © 2023 - all rights reserved.Terms of usePrivacy PolicyCookies policy\r\n\r\n\r\n", "/images/articles/image_20220918180342371.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "موعد تناول وجباتك غير مهم لإنقاص الوزن.. مجرد خرافة!\r\n", 0, 20 },
                    { "152", "9", "<p>هل استيقظت صباحا وتفاجأت بزيادة في وزنك؟ إن كانت الإجابة بنعم، فربما تناولت واحدا من عدة أطعمة ومواد غذائية أثناء الليل.<br />\r\nويتصدر الملح والسكر قائمة الأطعمة الأكثر تسببا في زيادة الوزن خلال فترة وجيزة، ويطلق عليهما السموم البيضاء، ويتسببان كذلك في الإصابة بأمراض القلب والشرايين، والعديد من الأمراض الأمراض الأخرى.<br />\r\n<br />\r\n<span style=\"color:#a566c8\"><span style=\"font-size:20px\">الكثير من الملح</span></span><br />\r\nتبدو الحبوب البيضاء والمالحة بريئة ظاهريا، وصحيح أن الملح لا يحتوي على سعرات حرارية، لكن تأثيره على الوزن مهم بشكل خاص.<br />\r\n&nbsp;يمتص الملح السوائل ويجعلنا نأكل أكثر ويساهم في زيادة الوزن. هل أفرطت في تناول الملح؟ لا تتفاجأ أنك تزن أكثر في اليوم التالي وتشعر أيضًا بالانتفاخ بعد الفشار المالح أو الأحمر المالح أو الوجبات الخفيفة المصنعة والمقرمشات أو حتى المخللات.<br />\r\n<br />\r\n<span style=\"color:#a566c8\"><span style=\"font-size:20px\">تناول السكر</span></span><br />\r\nصديق الملح، لكنه على الجانب الآخر من الطعم، يحتوي في الواقع على عدد غير قليل من السعرات الحرارية. إذا لم تذهب إلى التدريب بعد تناول كعكة أو آيس كريم أو حلوى تحتوي على السكر، فمن المحتمل أن ينضم السكر إلى مخازن الدهون في الجسم، خاصة إذا تم تناوله في الليل، عندما يكون الجسم بالفعل أقل حركة وحرقا.<br />\r\nالسكر هو أكبر مرض في يومنا هذا، وقد لا يحتوي على دهون، ولكن بمجرد أن يمتصه الجسم إلى حد كبير، فإن الجسم يبقيه على الفور في مخازن الدهون لدينا.<br />\r\n<br />\r\n<span style=\"color:#a566c8\"><span style=\"font-size:20px\">الأقراص والمكملات الغذائية</span></span><br />\r\nهناك عدد غير قليل من الأدوية والمكملات التي تجعل الجسم يخزن السوائل والسموم مما قد يؤدي إلى زيادة الوزن. قبل تناول أي أقراص ومكملات من أي نوع، يُنصح باستشارة الخبراء المعنيين بعد إجراء اختبارات الدم.<br />\r\n&nbsp;</p>\r\n\r\n<p><span style=\"font-size:20px\"><span style=\"color:#a566c8\">&nbsp;الإمساك</span></span><br />\r\nالإمساك خطير على الصحة ويسبب الشعور بالثقل والسمنة. إذا كنت تعاني من الإمساك، فقد يكون لديك نقص في الألياف والسوائل الغذائية، أو أنك تتناول الكثير من الوجبات السريعة أو تمارس تمارين رياضية أقل.<br />\r\n&nbsp;أضف الخضار والفواكه إلى قائمتك واستبدل الإفطار بعصائر الخضار والفواكه أو وجبة فواكه على معدة فارغة.<br />\r\n<br />\r\n<span style=\"color:#a566c8\"><span style=\"font-size:20px\">منتجات الحمية</span></span><br />\r\nهل تشرب الكثير من عصائر الحمية أو تأكل الكثير من منتجات النظام الغذائي مثل الزبادي والحلويات القابلة للدهن التي تحتوي على سكريات صناعية؟ هذه المواد تترجم في الجسم إلى سكر، والإفراط في تناولها يمكن أن يؤدي أيضا إلى الانتفاخ والسمنة. وأكثر من ذلك وُجد أن بدائل السكر تشكل خطرا على الصحة ولا ينصح باستهلاكها.<br />\r\n<br />\r\n<span style=\"color:#a566c8\"><span style=\"font-size:20px\">الكربوهيدرات في المساء</span></span><br />\r\nتعتبر وظائف الكربوهيدرات ضرورية للغاية بالنسبة لنا، ومن بين الأدوار المهمة إنتاج الطاقة من تكسير الجلوكوز.<br />\r\nفي الواقع، يتم تقسيم الكربوهيدرات في أجسامنا إلى سكريات، والتي نستخدمها لتوليد الطاقة. لذلك، يُنصح بتناول الكربوهيدرات في الساعات الأولى من اليوم، عندما لا نزال نشيطين، واستخدام هذه الطاقة في التمارين واحتياجات الجسم الأساسية أثناء ساعات الاستيقاظ.<br />\r\nالشخص الذي يأكل الكربوهيدرات في المساء مثل بعض المعكرونة ثم يستلقي على الأريكة، لم يعد يحرق سعرات وبالتالي يذهب السكر الذي يتحلل لمخازن الدهون في الجسم.<br />\r\n<br />\r\n<span style=\"color:#a566c8\"><span style=\"font-size:20px\">مصدر موني</span></span></p>\r\n\r\n<p>هذه الجزئية تخص النساء وحدهن: هل حدث أن اكتسبت وزنا في منتصف الشهر ولم تفهمي كيف أضفت كيلو أو اثنين إلى وزنك؟ أثناء فترة التبويض قد تحدث زيادة في الوزن تقل بعد تلك الفترة وأحيانا بعد الحيض فقط. هذه عادة سوائل، لا داعي للذعر. بالإضافة إلى ذلك، حتى في بداية الحمل ستلاحظين مثل هذه الزيادة التي لا تتعلق بعد بحجم الجنين.</p>\r\n", "/images/articles/6_2_17_10_955.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7 أشياء تسبب زيادة في الوزن خلال النوم\r\n", 0, 20 }
                });

            migrationBuilder.InsertData(
                table: "TblFiles",
                columns: new[] { "Id", "HealthyId", "Path", "ServiceId" },
                values: new object[,]
                {
                    { "1", "61", "/Images/HealthyRecipes/1.jpg", null },
                    { "2", "61", "/Images/HealthyRecipes/img61.jpg", null },
                    { "3", "61", "/Images/HealthyRecipes/im61.jpg", null },
                    { "4", "62", "/Images/HealthyRecipes/2.jpg", null },
                    { "5", "62", "/Images/HealthyRecipes/img62.jpg", null },
                    { "6", "62", "/Images/HealthyRecipes/im62.jpg", null },
                    { "7", "66", "/user/images/pexels-toni-cuenca-616833.png", null },
                    { "8", "66", "~/user/images/224347.png", null },
                    { "9", "66", "/user/images/224664.png", null }
                });

            migrationBuilder.InsertData(
                table: "TblOrder",
                columns: new[] { "Id", "DiscountCode", "OrderDate", "OrderStatus", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { "1", "#15ar12", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3400.0, "1" },
                    { "2", "#13da32", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4500.0, "1" },
                    { "3", "#47as32", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5900.0, "1" }
                });

            migrationBuilder.InsertData(
                table: "TblServices",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsFeatured", "Price", "RatePercentage", "ShortDescription", "Title", "UserId" },
                values: new object[,]
                {
                    { "1", "1", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1426), "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ", null, 19.989999999999998, null, null, "حمية البحر المتوسط", null },
                    { "100", "1", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1413), "تم تصميم هذا التحدي لمدة 5 أيام للقوة والقلب والشد لتحسين قوة الجسم بالكامل والقدرة على التحمل وإعادة إشعال الحافز لروتين لياقة بدنية ثابت.", null, 350.0, null, null, "سلسلة مُدربي التحدي لمدة 5 أيام: تناغم مع إيريكا", null },
                    { "101", "5", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1419), "لبدء هذا العام بشكل صحيح ، ننشر فيديو تمرين مجاني جديد كل صباح للأسبوع الأول من شهر كانون الثاني (يناير) ؛ خمسة أيام من التدريبات المكثفة ، ويوم تعافي واحد ، وتأمل يوم راحة. نحن متحمسون جدًا لأن نكون قادرين على تقديم هذا التحدي الجديد ، ونحن متحمسون حقًا لأننا تمكنا من بنائه مع فريقنا. سيكون أسبوعًا ممتعًا!", null, 100.0, null, null, "تحدي للياقة البدنية لمدة 5 أيام مجانًا", null },
                    { "102", "5", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1422), "تحدي تجريب أسبوع مصمم للأشخاص الذين يريدون فقط ثلاثة (مطلوب) أيام تمرين في الأسبوع. سواء كنت مشغولاً للغاية لأكثر من ثلاثة تمارين في الأسبوع ، أو كنت ترغب في استكمال أنواع أخرى من اللياقة البدنية (المشي ، والسباحة ، وما إلى ذلك) بمقاطع فيديو للتمرين في المنزل ، فإن هذا التحدي يهدف إلى المساعدة في دعم اللياقة البدنية الشاملة. الروتين الذي يناسب الجدول الزمني والسرعة التي تريدها. توقع مزيجًا من رفع الأثقال والتدريب المتقطع عالي الكثافة (التدريب المتقطع عالي الكثافة) الذي سيختبر قدرتك على التحمل وصحة القلب والأوعية الدموية والقوة.", null, 200.0, null, null, "3 تمارين في الأسبوع لمدة أسبوعين", null },
                    { "103", "5", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1424), "هذا برنامج صديق للمبتدئين مدته 8 أسابيع مصمم لبناء قاعدة القوة الكلية للجسم وتحمل القلب والأوعية الدموية واللياقة البدنية الشاملة.", null, 450.0, null, null, "برنامج لمدة 8 أسابيع لبدء روتين لياقتك البدنية", null },
                    { "11", "1", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1440), "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ", null, 19.989999999999998, null, null, " اختبار ", null },
                    { "2", "1", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1429), " يعتمد على تقليل الكربوهيدرات  و منع السكر المصنع و البطاطا , يتم تناول الفواكه و الخضروات و الحبوب", null, 20.989999999999998, null, null, "  النظام الغذائي باليو", null },
                    { "21", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1443), "", null, 20.0, null, null, "طقم اوزان دمبل 30 كغم", null },
                    { "22", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1445), "", null, 30.0, null, null, "حلقات لايف اب الاولمبية للجمباز", null },
                    { "23", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1447), "", null, 1490.0, null, null, "مشاية كهربائية منحنية بدون محرك", null },
                    { "24", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1450), "", null, 320.0, null, null, "دراجة سبينر", null },
                    { "25", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1452), "", null, 150.0, null, null, "Livepro أيروبيك ستيبر ومقعد", null },
                    { "26", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1454), "", null, 15.0, null, null, "سجادة Liveup للتمارين الرياضية", null },
                    { "27", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1489), "", null, 175.0, null, null, "مقعد بووفليكس متعدد الوظائف", null },
                    { "28", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1493), "", null, 69.0, null, null, "حبل معركة بروبانتل", null },
                    { "29", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1495), "", null, 125.0, null, null, "مقعد قابل للطي قابل للتعديل للتمارين الرياضية", null },
                    { "3", "1", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1432), "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن", null, 19.989999999999998, null, null, "   كيتو دايت ", null }
                });

            migrationBuilder.InsertData(
                table: "TblServices",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsFeatured", "Price", "RatePercentage", "ShortDescription", "Title", "UserId" },
                values: new object[,]
                {
                    { "30", "4", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1497), "", null, 25.0, null, null, "مجدّف", null },
                    { "31", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1499), "", null, 111.0, null, null, "زيت السمك أوميغا 3", null },
                    { "32", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1502), "", null, 78.0, null, null, "Muscletech, بلاتينيوم ملتي فيتامين", null },
                    { "33", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1504), "", null, 169.0, null, null, "Ultima Replenisher", null },
                    { "34", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1506), "", null, 169.0, null, null, "زيت الكريل", null },
                    { "35", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1508), "", null, 170.0, null, null, "أنافيت", null },
                    { "36", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1510), "", null, 79.0, null, null, "Trace Minerals Research", null },
                    { "37", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1512), "", null, 109.0, null, null, "BodyBio, E-Lyte", null },
                    { "38", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1515), "", null, 163.0, null, null, "فيجا ، سبورت", null },
                    { "39", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1517), "", null, 111.0, null, null, "مضاعف الترطيب", null },
                    { "4", "1", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1434), "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن", null, 19.989999999999998, null, null, "   كيتو دايت ", null },
                    { "40", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1519), "", null, 54.0, null, null, "NutriBiotic", null },
                    { "41", "3", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1521), "", null, 169.0, null, null, "زيت الكريل", null },
                    { "5", "1", new DateTime(2023, 5, 13, 15, 44, 2, 569, DateTimeKind.Local).AddTicks(1438), "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ", null, 19.989999999999998, null, null, " اختبار ", null }
                });

            migrationBuilder.InsertData(
                table: "TblFiles",
                columns: new[] { "Id", "HealthyId", "Path", "ServiceId" },
                values: new object[,]
                {
                    { "10", null, "/user/images/224664.png", "23" },
                    { "11", null, "/user/images/224664.png", "23" },
                    { "12", null, "/Images/Product/Dumbbell3.jfif", "22" },
                    { "13", null, "/user/images/224664.png", "22" },
                    { "14", null, "/user/images/224664.png", "21" },
                    { "15", null, "/user/images/224664.png", "21" },
                    { "20", null, "/Images/Product/LiveupOlympic.jpg", "21" },
                    { "21", null, "/Images/Product/Curved.jpg", "23" },
                    { "24", null, "/Images/Product/Dumbbell.jfif", "21" },
                    { "25", null, "/Images/Product/Dumbbell1.jfif", "21" },
                    { "26", null, "/Images/Product/Dumbbell3.jfif", "21" }
                });

            migrationBuilder.InsertData(
                table: "TblMealPlans",
                columns: new[] { "Id", "AvgRecipeTime", "DietaryType", "Image", "Length", "MealType", "Numsubscribers" },
                values: new object[,]
                {
                    { "1", 13.0, "اكلة اللحوم", "./Images/MealPlan/1.jpg", 1, "الإفطار والغداء والعشاء والوجبات الخفيفة\r\n", 105 },
                    { "2", 13.0, "اكلة اللحوم", "./Images/MealPlan/2.jpg", 1, "الإفطار والغداء والعشاء والوجبات الخفيفة\r\n", 105 },
                    { "3", 20.0, "اكلة اللحوم", "./Images/MealPlan/3.jpg", 1, "الإفطار والغداء والعشاء والوجبات الخفيفة\r\n", 105 },
                    { "4", 20.0, "اكلة اللحوم", "./Images/MealPlan/4.jpg", 1, "الإفطار والغداء والعشاء والوجبات الخفيفة\r\n", 105 }
                });

            migrationBuilder.InsertData(
                table: "TblOrder_Details",
                columns: new[] { "Id", "OrderId", "Price", "Quantity", "RateId", "ServiceId" },
                values: new object[,]
                {
                    { "1", "1", 100.0, 2, 1, "21" },
                    { "10", "1", 100.0, 2, 1, "23" },
                    { "11", "1", 100.0, 2, 1, "23" },
                    { "12", "1", 100.0, 3, 1, "23" },
                    { "13", "2", 100.0, 7, 1, "24" },
                    { "14", "2", 100.0, 5, 1, "24" },
                    { "15", "2", 100.0, 3, 1, "24" },
                    { "16", "3", 100.0, 4, 1, "24" },
                    { "17", "3", 100.0, 4, 1, "24" },
                    { "18", "3", 100.0, 10, 1, "24" },
                    { "19", "1", 100.0, 5, 1, "31" },
                    { "2", "1", 100.0, 2, 1, "21" },
                    { "20", "1", 100.0, 6, 1, "31" },
                    { "21", "1", 100.0, 10, 1, "31" },
                    { "22", "2", 100.0, 7, 1, "31" },
                    { "23", "2", 100.0, 5, 1, "32" },
                    { "24", "2", 100.0, 3, 1, "32" },
                    { "25", "3", 100.0, 11, 1, "32" },
                    { "26", "3", 100.0, 4, 1, "32" },
                    { "27", "3", 100.0, 10, 1, "32" },
                    { "3", "1", 100.0, 2, 1, "21" },
                    { "4", "2", 100.0, 7, 1, "31" },
                    { "5", "2", 100.0, 5, 1, "31" },
                    { "6", "2", 100.0, 3, 1, "24" },
                    { "7", "3", 100.0, 2, 1, "23" },
                    { "8", "3", 100.0, 4, 1, "23" },
                    { "9", "3", 100.0, 10, 1, "23" }
                });

            migrationBuilder.InsertData(
                table: "TblProducts",
                columns: new[] { "Id", "Discount", "ImgUrl" },
                values: new object[,]
                {
                    { "21", 20.0, "/Images/Product/Dumbbell3.jfif" },
                    { "22", 0.0, "/Images/Product/LiveupOlympic.jpg" },
                    { "23", 0.0, "/Images/Product/Curved.jpg" },
                    { "24", 0.0, "/Images/Product/Spinner.jpg" },
                    { "25", 0.0, "/Images/Product/Liveup.jpg" },
                    { "26", 0.0, "/Images/Product/LiveupOlympic.jpg" },
                    { "27", 0.0, "/Images/Product/Bowflex.jpg" },
                    { "28", 0.0, "/Images/Product/Brobantle.jfif" },
                    { "29", 0.0, "/Images/Product/Adjustable.jpg" },
                    { "30", 0.0, "/Images/Product/rower.jpg" },
                    { "31", 0.0, "/Images/Product/omega.jpg" },
                    { "32", 0.0, "/Images/Product/Muscletech.jpg" },
                    { "33", 0.0, "/Images/Product/Ultima.jpg" },
                    { "34", 0.0, "/Images/Product/krilloil.jpg" },
                    { "35", 0.0, "/Images/Product/anavite.jpg" },
                    { "36", 0.0, "/Images/Product/Trace.jpg" },
                    { "37", 0.0, "/Images/Product/BodyBio.jpg" },
                    { "38", 0.0, "/Images/Product/Vega.jpg" },
                    { "39", 0.0, "/Images/Product/HydrationMultiplier.jpg" },
                    { "40", 0.0, "/Images/Product/NutriBiotic.jpg" },
                    { "41", 0.0, "/Images/Product/krilloil.jpg" }
                });

            migrationBuilder.InsertData(
                table: "TblSportsProgram",
                columns: new[] { "Id", "BodyFocus", "Difficulty", "Duration", "Equipment", "Image", "Length", "TrainingType" },
                values: new object[,]
                {
                    { "100", "الجسم السفلي ", 3, 34, "خطوة التمرين ، الدمبل ، حزام التمرين", "Images/Program/10.jpg", 4, "تدريب القوة" },
                    { "101", "كل الجسم ", 3, 37, "الدمبل ، حزام التمرين ، الكتيل بيل ، حصيرة ، بدون معدات", "Images/Program/11.jpg", 1, "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة" },
                    { "102", " كل الجسم ", 2, 44, "الدمبل، حصيرة", "Images/Program/12.jpg", 2, "تدريب القوة" },
                    { "103", "كل الجسم ", 1, 35, "الدمبل ", "Images/Program/13.jpg", 8, "تدريب متقطع عالي الكثافة ، تأثير منخفض ، بيلاتيس ، تدريب القوة ، التمدد / المرونة ، القدرة على الحركة" }
                });

            migrationBuilder.InsertData(
                table: "TblExercies_program",
                columns: new[] { "Id", "Day", "ExerciseId", "SportsProgramId", "Week" },
                values: new object[,]
                {
                    { "1", 1, "1", "102", 1 },
                    { "10", 7, "10", "102", 1 },
                    { "11", 1, "10", "102", 2 },
                    { "12", 2, "8", "102", 2 },
                    { "13", 2, "6", "102", 2 },
                    { "14", 3, "5", "102", 2 },
                    { "15", 4, "4", "102", 2 },
                    { "16", 5, "3", "102", 2 },
                    { "17", 6, "2", "102", 2 },
                    { "18", 7, "1", "102", 2 },
                    { "19", 8, "9", "102", 2 },
                    { "2", 2, "2", "102", 1 },
                    { "3", 3, "3", "102", 1 },
                    { "4", 4, "4", "102", 1 },
                    { "5", 4, "5", "102", 1 },
                    { "6", 5, "6", "102", 1 },
                    { "7", 6, "7", "102", 1 },
                    { "8", 7, "8", "102", 1 },
                    { "9", 7, "9", "102", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracking",
                columns: new[] { "Id", "Exercies_programId", "Iscomplete", "Order_DetailsId" },
                values: new object[] { "1", "1", true, "1" });

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
                name: "IX_TblContactUs_UserId",
                table: "TblContactUs",
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
                name: "IX_TblServices_CategoryId",
                table: "TblServices",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblServices_UserId",
                table: "TblServices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracking_Exercies_programId",
                table: "Tracking",
                column: "Exercies_programId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracking_Order_DetailsId",
                table: "Tracking",
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
                name: "Tracking");

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
