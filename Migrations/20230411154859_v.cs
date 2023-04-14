using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace liaqati_master.Migrations
{
    public partial class v : Migration
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
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Target = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyFocus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Difficulty = table.Column<int>(type: "int", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraningType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    BurnEstimate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblExercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblFavorite",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFavorite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblHealthyRecipe",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    DieteryType = table.Column<int>(type: "int", nullable: false),
                    PrepTime = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Total_Carbohydrate = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<int>(type: "int", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreparationMethod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHealthyRecipe", x => x.Id);
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
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    UserIdDelivery = table.Column<int>(type: "int", nullable: false),
                    UserIdResiver = table.Column<int>(type: "int", nullable: false),
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
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblArticles_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblServices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblServices_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    BodyFocus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    review = table.Column<int>(type: "int", nullable: false),
                    review_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Order_DetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblRate", x => x.Id);
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
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Cover_photo", "Email", "EmailConfirmed", "Exp_Years", "Fname", "Gender", "Height", "Lname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wieght" },
                values: new object[] { "1", 0, false, "7027ccbd-f64c-4723-b142-77eb21b26b00", "sssssssssssssssa", null, false, 10, "sssssssssssssss", 1, 120, "sssssssssssssss", false, null, null, null, null, null, false, "ssssssssssssssss", "5d62f807-17dd-4bc0-9d2e-863ca89feab4", false, null, 120 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Image", "Name", "Target" },
                values: new object[,]
                {
                    { "1", null, "طبق رئيسي", 1 },
                    { "2", null, "أكل صحي", 1 },
                    { "3", null, "المكملات الغذائية", 4 },
                    { "4", null, "الاجهزة الرياضية", 4 },
                    { "5", null, "حلوى", 1 },
                    { "6", null, "الوجبات", 0 }
                });

            migrationBuilder.InsertData(
                table: "TblExercises",
                columns: new[] { "Id", "BodyFocus", "BurnEstimate", "Detail", "Difficulty", "Duration", "Equipments", "Image", "Price", "ShortDescription", "Title", "TraningType", "Video" },
                values: new object[,]
                {
                    { "1", "الجسم بالكامل", "50-250", "هذا التدفق هو واحد من المفضلة. عندما أستيقظ في الصباح ، أحب أن أبدأ يومي بتمديدات روتينية من شأنها أن تجعل دمي يتدفق ، وطاقي ، وتضبط نغمة اليوم. هذه الممارسة ستجعلك تتعرق وتساعد جسمك على تخفيف الضغط في نفس الوقت. تخلق أنماط الحركة ذاكرة حسية يمكننا البناء عليها. بدءًا من نمط التنفس ، تهدف كل حركة إلى مطابقة كل شهيق أو زفير لتشجيع التنفس العميق الذي يعزز الشعور بالتوتر ، ويزيد من مستوى الطاقة والاسترخاء ، ويثبت ضغط الدم. إذا ركزت على أنفاسك ، فسوف يهدأ عقلك. فيما يلي بعض إشارات المحاذاة التي يجب وضعها في الاعتبار للسلامة في Low Lunge:\r\n\r\nابدأ في اندفاع العداء ، والساق اليمنى للأمام مع الركبة فوق الكاحل والركبة اليسرى على الأرض مع وضع الجزء العلوي من قدمك على السجادة. ارفع الجذع ببطء وضع يديك برفق على الفخذ الأيمن. تميل الوركين إلى الأمام قليلاً ، مع إبقاء الركبة اليمنى خلف أصابع القدم ، والشعور بالتمدد في ثني الورك الأيسر. امسك هنا ، أو لتمتد أعمق ، ارفع الذراعين فوق الرأس ، والعضلة ذات الرأسين من الأذنين. استمر لمدة 30 ثانية على الأقل ، ثم كرر على الجانب الآخر. تتضمن عضلات الجسم المنخفضة المستهدفة في هذا التسلسل أوتار الركبة ، وثني الورك ، والرباعية ، والألوية. في كل مرة نتنقل فيها عبر نمط الحركة ، سيكون هناك موقف أو وضعان مضافان إلى التسلسل. التكرار مع كل الجسم للانفتاح على كل شكل تدريجيًا.", 3, 27, "حصيرة ، معدات اليوجا", "Images/Exercise/31.jpg", 0.0, null, "اليوجا الصباحية للجسم بالكامل", "تدريب القوة", "https://www.youtube.com/watch?v=w5y3Zl1F5Vs" },
                    { "10", "جوهر", "50-250", "\r\nإذا كنت تمارس هذا التمرين بهدف بناء القوة و / أو الكتلة ، فإليك بعض الأشياء التي يجب وضعها في الاعتبار.\r\n\r\nأولاً ، كما هو الحال مع أي تمرين قوي أو جماعي ، لا ترفع كثيرًا حتى يبدأ شكلك أو نطاق حركتك في المعاناة. إذا كنت قد قمت في أي وقت مضى بواحد من إجراءات قوتنا من أي نوع من قبل ، فمن المحتمل أنك سمعتنا بالفعل نقول هذا مرارًا وتكرارًا ؛ شكل ونطاق الحركة أكثر أهمية بكثير من مقدار الوزن الذي ترفعه عندما يتعلق الأمر بالقوة الوظيفية الخالية من الإصابات.\r\n\r\nثانيًا ، حدد الوزن الذي تستخدمه بناءً على معدل التعب لديك. يجب أن يكون هدفك هو استخدام وزن ثقيل بدرجة كافية بحيث يمكنك إجراء جميع عمليات التكرار تقريبًا بشكل مثالي ونطاق كامل من الحركة. يجب السماح للمعاناة في آخر 2 أو 3 مرات فقط لأن هذه العضلات تصبح مرهقة للغاية بحيث لا يمكن الحفاظ عليها نظيفة.\r\n\r\nثالثًا ، عندما تتخلى عضلاتك عن تلك التكرارات القليلة الأخيرة ، ابدأ في التركيز حقًا على الحركة \"السلبية\". يُعرف بشكل أكثر رسميًا باسم الانقباض غريب الأطوار ، والسالب هو النقطة التي يتغلب فيها الحمل على القوة التي يمكن للعضلة أو تقدمها والمبتدئين في إطالة العضلات. على سبيل المثال ، عند أداء تمرين الدمبل ، فإن المرحلة اللامتراكزة هي عندما يتراجع الدمبل إلى أسفل من الكتف ، مما يؤدي إلى إطالة عضلات البايسبس. من خلال التركيز على هذه الحركة ومحاولة التحكم في المرحلة اللامركزية ، يمكنك الحصول على مزيد من التمزقات الدقيقة في ألياف عضلاتك ، مما يؤدي إلى درجة أعلى من التقدم لزيادة القوة والحجم في العضلات التي تعمل. لذلك ، عندما تبدأ في الشعور بالتعب ، لا تدع هذا الوزن ينخفض فقط. إن بذل قصارى جهدك لمحاربة فقدان الوزن هو أهم جزء في روتين قوتك بالكامل.\r\n\r\nأخيرًا ، تأكد من ضبط الوزن الذي تستخدمه لكل مجموعة ، حسب الحاجة. لا تتعثر في عقلية أن ما تبدأ به يجب أن ينتهي به. بالنسبة لبعض التمارين ، قد تشعر أنه يمكنك زيادة وزنك والبعض الآخر قد تحتاج إلى إنقاصه ، وقد يكون ذلك لمجموعة واحدة فقط قبل التغيير مرة أخرى. جسمك هو آلة ديناميكية دائمة التغير ، لذلك عليك أن تكون قادرًا على التغيير والتكيف مع احتياجاته يوميًا ، إن لم يكن دقيقة بدقيقة.", 3, 37, " دمبل  ، بدون معدات ", "Images/Exercise/41.jpg", 0.0, null, "روتين القوة الأساسية الموزونة - روتين أوزان الدمبل في المنزل", "تدريب متقطع عالي الكثافة ، تأثير منخفض ، بيلاتيس ، تدريب القوة ، التمدد / المرونة ، القدرة على الحركة", "https://www.youtube.com/watch?v=pnNCuecyZnQ" },
                    { "2", "الجسم بالكامل", "50-250", "إذا كنت تريد ممارسة تمرينات رياضية فعالة في أقل من 25 دقيقة ، فلا داعي لمزيد من البحث. هذا مزيج قصير ولطيف بين نمطي تدريب مهمين: تدريب القوة وتمارين القلب والأوعية الدموية. يتم تقديم تعديلات عالية ومنخفضة التأثير حتى تتمكن من مقابلة جسمك تمامًا في مكانه.                        عندما يتعلق الأمر بالحصول على أقصى درجات \"الضجة\" لوقتك ، يمكن أن تكون قوة الاقتران وتمارين القلب فعالة للغاية. يسمح لنا تدريب القوة ببناء العضلات الخالية من الدهون بينما تحافظ تمارين القلب والأوعية الدموية على ارتفاع معدل ضربات القلب. يعملان معًا على تعزيز عملية التمثيل الغذائي وإطلاق الطاقة لتغذية يومك!\r\n\r\nكنت مؤخرًا أحضر فصلًا لركوب الدراجات حيث قال المدرب ، \"ما هي أفضل طريقة للاحتفال بجسدك من الشعور بإطلاق الطاقة والقوة التي يحملها جسمك؟\" لا يمكن اقبل المزيد. هذا التمرين هو النوع الذي يبدو وكأنه احتفال بما يمكن أن يفعله جسمك. دون أن تكون شديدة أو معتدلة للغاية ، فإنها تهبط في المنتصف تمامًا \"للاحتفال\" التمكيني والحيوي ، إذا رغبت في ذلك.", 3, 23, "حصيرة ، دمبل", "Images/Exercise/32.jpg", 0.0, null, "تمارين تقوية الجسم بالكامل وتمارين القلب", "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة", "https://www.youtube.com/watch?v=R58oVgVgRlc" },
                    { "3", "الجزء العلوي من الجسم", "50-250", "أولاً ، سنركز على الصدر ، بدءًا من مكابس الأرضية ثم الانتقال بسرعة إلى ذبابة الصدر والانتهاء بضغطة سحق. بعد مجموعتين من تمارين الصدر ، سننتقل إلى الخلف ، بدءًا من الصفوف المنحنية ، والانتقال إلى الذباب العكسي ، والانتهاء من صف yates. مجموعتنا التالية سوف تستهدف الذراعين ، في المقام الأول العضلة ثلاثية الرؤوس والعضلة ذات الرأسين. بالنسبة لمجموعات الترايسبس لدينا ، نحتاج فقط إلى دمبل واحد. سنبدأ المجموعات بضغطة دمبل مفردة بقبضة قريبة ، وننتقل إلى كسارة جمجمة دمبل واحدة ، ثم ننتقل إلى تمديدات ثلاثية الرؤوس العلوية. (سوف تحترق عضلاتك ثلاثية الرؤوس ، لول). مجموعتنا التالية هي إحدى الطرق المفضلة لتدريب العضلة ذات الرأسين. سنستخدم المقاييس المتساوية لدفع العضلة ذات الرأسين هنا. تمريننا الأول هو ما أحب أن أسميه تجعيد الشعر أحادي الذراع ؛ سنقوم بعمل كل ذراع على حدة مع تلك قبل الانتهاء من تمارين العضلة ذات الرأسين القياسية. هذا المزيج يعمل دائمًا مع العضلة ذات الرأسين! في مجموعتنا النهائية ، سنركز على أكتافنا. سنبدأ العمل بضغط الكتف القياسي ، والانتقال إلى صفوفنا المستقيمة ، وإنهاء المجموعة مع صف دلتا الخلفي الذي يستهدف عضلات الدالية الصغيرة - مما يجعل هذه الطريقة المثالية لإنهاء تمرين الجزء العلوي من الجسم.", 4, 37, "دمبل", "Images/Exercise/34.jpg", 0.0, null, "مجموعات القوة المركبة للجزء العلوي من الجسم", "تدريب القوة", "https://www.youtube.com/watch?v=fPlN4amOMY8" },
                    { "4", "الجسم بالكامل", "50-250", "أولاً ، سنركز على الصدر ، بدءًا من مكابس الأرضية ثم الانتقال بسرعة إلى ذبابة الصدر والانتهاء بضغطة سحق. بعد مجموعتين من تمارين الصدر ، سننتقل إلى الخلف ، بدءًا من الصفوف المنحنية ، والانتقال إلى الذباب العكسي ، والانتهاء من صف yates. مجموعتنا التالية سوف تستهدف الذراعين ، في المقام الأول العضلة ثلاثية الرؤوس والعضلة ذات الرأسين. بالنسبة لمجموعات الترايسبس لدينا ، نحتاج فقط إلى دمبل واحد. سنبدأ المجموعات بضغطة دمبل مفردة بقبضة قريبة ، وننتقل إلى كسارة جمجمة دمبل واحدة ، ثم ننتقل إلى تمديدات ثلاثية الرؤوس العلوية. (سوف تحترق عضلاتك ثلاثية الرؤوس ، لول). مجموعتنا التالية هي إحدى الطرق المفضلة لتدريب العضلة ذات الرأسين. سنستخدم المقاييس المتساوية لدفع العضلة ذات الرأسين هنا. تمريننا الأول هو ما أحب أن أسميه تجعيد الشعر أحادي الذراع ؛ سنقوم بعمل كل ذراع على حدة مع تلك قبل الانتهاء من تمارين العضلة ذات الرأسين القياسية. هذا المزيج يعمل دائمًا مع العضلة ذات الرأسين! في مجموعتنا النهائية ، سنركز على أكتافنا. سنبدأ العمل بضغط الكتف القياسي ، والانتقال إلى صفوفنا المستقيمة ، وإنهاء المجموعة مع صف دلتا الخلفي الذي يستهدف عضلات الدالية الصغيرة - مما يجعل هذه الطريقة المثالية لإنهاء تمرين الجزء العلوي من الجسم. ", 4, 23, "حصيرة ، دمبل", "Images/Exercise/35.jpg", 0.0, null, "مجموعة القلب والقوة", "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة", "https://www.youtube.com/watch?v=d8QcqQA0zIQ" },
                    { "5", "جوهر", "50-250", "يعد هذا التمرين القصير الذي يركز على النواة إضافة رائعة لروتين الجسم السفلي أو العلوي أو الكلي - ولكنه أيضًا خيار رائع كتمرين مستقل لحركتك الأساسية في اليوم. استخدم الإحماء أحادي الدورة لتهيئة عضلاتك الأساسية جسديًا للدوائر الصعبة ولكن القابلة للتكيف التي تليها ، ولكن ركز أيضًا على التدفق ببطء خلال كل تمرين لتنشيط اتصال العقل والعضلات لتوظيف العضلات بكفاءة.\r\n\r\n\r\n\r\n\r\nتحتوي كل دائرة على تمارين تجمع بين الإمساك المتساوي القياس وأنماط الحركة الديناميكية ولكن المتحكم فيها والتركيز على الاستقرار الأساسي. هذه التمارين لن تقوي فقط عضلات البطن (التي تشمل عضلات البطن ، الألوية ، عضلات الفخذ ، وعضلات الظهر السفلية) مع حركات الانثناء / الطحن التقليدية ، بل ستعمل أيضًا على تحسين مشاركة عضلات الجسم الكلية وتكامل الحركة (التدفق).\r\n\r\nلاحظ أنه لا يوجد سوى عدد قليل من التمارين المتعلقة بلوح في هذا التمرين ؛ لذلك ، إذا كانت لديك مخاوف من ألم الرسغ أثناء تمارين اللوح / وضعية الانبطاح ، فقد يكون هذا الروتين خيارًا رائعًا للاحتفاظ به في مجموعتك من أجل إجراءات الانتقال الأساسية المستقبلية. من الاعتبارات المهمة للجميع الحفاظ على ثنية طفيفة في الحوض أثناء تمارين وضعية الاستلقاء (الوجه لأعلى) والمنبطحة (الوجه لأسفل / اللوح الخشبي). على سبيل المثال ، أثناء الجزء الميت من تسلسل التنشيط بالإضافة إلى تمرين لوح الساعد في الدائرة رقم 1 ، تخيل أنك تقوم بإدخال عظام الفخذ إلى ضلوعك - قم بإمالة الجزء العلوي من عظام الحوض قليلاً إلى الأعلى والعودة باتجاه الجزء السفلي من القفص الصدري الخاص بك.\r\n\r\nفيما يلي بعض النصائح الإضافية لجعل هذا الروتين تجربة مُرضية لك:\r\n\r\nتشمل التعديلات لجميع التمارين تقليل نطاق الحركة و / أو ثني ركبتيك (تقصير الرافعة) لأي حركات تتضمن اختلافات في تمديد الساق.\r\nلاحظ التمارين الأكثر صعوبة بالنسبة لك وحدد الاختلافات في نطاقات الحركة والقوة وعدد التكرارات للتمارين ذات التركيز الأحادي (مثل v-ups المائلة). سيساعدك الانتباه إلى أكثر الاختلافات دقة في توجيه تركيزك أثناء المحاولات المستقبلية في هذا التمرين.\r\nلا تتردد في تكرار دائرة التبريد القصيرة لتمديد ممتد أو إضافة الامتدادات الخاصة بك لمساعدتك على العودة إلى حالة الاسترخاء والحيوية. يجب أن تشعر كما لو أن عضلاتك \"تعمل\" خلال هذا الروتين ولكن لا تزال تنتهي بعقلية \"جاهزة للتعامل مع أي شيء قادم\".\r\nيتمتع!", 3, 19, "حصيرة", "Images/Exercise/36.jpg", 0.0, null, "دوائر القوة الأساسية السريعة و الجوهر", "تدريب القوة", "https://www.youtube.com/watch?v=B5ZZqBslKU0" },
                    { "6", "الجسم بالكامل", "50-250", "\r\nتساعد التدريبات أحادية الجانب على تعزيز المشاركة الأساسية ، وبالتالي تحسين الأساس الذي تبدأ منه كل الحركات.\r\nتعمل عضلاتك معًا بشكل تآزري لتقوية السلسلة الحركية بأكملها ، مما يقلل من فرص السقوط أو العثرات الضارة المحتملة أثناء الأنشطة المعتادة للحياة اليومية.\r\nيمكن أن يساعدك العمل المتوازن في تحديد مناطق الضعف والكتل المحتملة نحو تحسين الأداء الرياضي وكذلك تحسين التنسيق لأنماط الحركة المتقدمة والتمارين التي تحركها القوة.\r\nالتدريبات مع تحديات التوازن تعمل على تحسين الاتصال بين العقل والجسم. يؤدي هذا الاتصال المعزز إلى زيادة القدرة على التحمل الذهني والفعالية الذاتية اللازمة لإكمال التدريبات الصعبة.\r\nتوفر مثل هذه التدريبات استراحة من البلى من التدريب على التأثير وتتحدى الدماغ لطرق بديلة لمعالجة وعي العقل والجسم من أجل نهج شامل للياقة البدنية.\r\nكل حركة في هذا التمرين لها درجات متفاوتة من التوازن في العمل. أثناء دورات القوة ، ستكمل كل تمرين لمدة 45 ثانية ، وهي فترة زمنية كافية لتتعرف تمامًا على كل حركة. تؤدي إضافة درجة صغيرة من التوازن أثناء هذه الحركات التي تركز على القوة إلى زيادة وقت العضلات تحت التوتر للمساعدة في بناء القوة. بمجرد الانتقال إلى موازنة قطاعات العمل ، استفد من تنشيط العضلات الذي حدث أثناء دوائر القوة لتحقيق أقصى استفادة من الفواصل الزمنية التي تبلغ دقيقة واحدة والتركيز على الاستقرار.\r\n\r\nسأعترف ، لقد استمتعت تمامًا بالحركة بسرعة أبطأ من التدريبات المعتادة مع هذه الجلسة التي تركز على التوازن. لبضعة أيام بعد ذلك ، لاحظت أن العديد من العضلات شعرت بـ \"الاستيقاظ\" مع نوع صحي جيد من القرحة التي سمحت لي بمعرفة أنني كنت أهمل مجموعات عضلية معينة وطرق التدريب. خذ وقتك مع كل حركة واستمع إلى الملاحظات التي يقدمها لك جسمك. استمتع!", 3, 45, "حصيرة", "Images/Exercise/37.jpg", 0.0, null, "دارات تقوية الجسم الكلي مع عمل التوازن", "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة", "https://www.youtube.com/watch?v=UzAFN61CiVQ" },
                    { "7", "الجسم بالكامل", "50-250", "في منتصف عام 2022 ، قمت بتصوير تمرين بدا أن عددًا كبيرًا منكم يحبه حقًا. كان قسم التعليقات مليئًا بطلبات لتصوير المزيد مثله ، وعلى الرغم من أنني كنت أمتلك مجموعة من التدريبات الأخرى المطلوبة للحصول عليها أولاً ، إلا أنني لم أنس هذا التمرين (بفضل Kelli لتذكيري) وقمت ببناء علامة تجارية جديدة نسخة منه مع جميع التدريبات الجديدة. بالنسبة لأولئك منكم الذين لم يجربوا النسخة الأصلية ، يمكنك إلقاء نظرة هنا أو - بل أفضل - جرب كلاهما وأخبرني ما إذا كان هذا الإصدار الجديد يتوافق مع نفس المعيار.\r\n\r\n\r\n\r\n\r\nسواء كنت قد جربت الإصدار الأصلي أم لا ، لا يهم ، حيث إن كلاهما تمرين مستقل مصمم لروتين كامل للجسم متوازن. يحتوي هذا التمرين الذي يستغرق 26 دقيقة على كل شيء: الإحماء ، والتهدئة ، وفترات HIIT للقلب ، ومجموعات القوة ، والتمارين الأساسية ، كل ذلك في فاصل زمني سريع بأسلوب Tabata للحفاظ على هذا التمرين سريعًا.\r\n\r\nتم بناء كل مجموعة من المجموعات الأربع في هذا الروتين بنفس الطريقة تمامًا ولكن مع تمارين فريدة في كل مرة. تتكون المجموعات من تمرين HIIT من أجل انفجار القلب ، يليه تمرين قوة متعدد السلاسل لزيادة إجهاد العضلات ومكاسب القوة ، ثم ننهيها بتمرين أساسي للمتعة فقط. على الرغم من أن هذا التمرين قصير ، إلا أنه يحزم لك بالتأكيد ، خاصة إذا كنت تتحدى نفسك في مجموعات القوة.\r\n\r\nأيضًا ، إذا كنت تريد تحديًا إضافيًا لكامل الجسم ، فحاول القيام بكل من هذين التمرينين معًا أو كل منهما مرتين خلال تمرين كامل للجسم لمدة ساعة تقريبًا.", 4, 26, "حصيرة ، دمبل  ، بدون معدات ", "Images/Exercise/38.jpg", 0.0, null, "مجموعة سريعة من تمارين القلب والقوة و الجوهر  لكامل الجسم", "تدريب القوة", "https://www.youtube.com/watch?v=3xR8ZKVALwo" },
                    { "8", "الجسم بالكامل ", "50-250", "في تمرين اليوم نركز على السرعة. تم تصميم هذا التمرين القصير ولكن الفعال ليوفر لك تمرينًا جيدًا في أقصر وقت ممكن لتلك الأيام التي ربما لم تكن قد مارستها فيها على الإطلاق. لقد صممت هذا التمرين بعد نوبة أخيرة من العمل المكثف ومتطلبات الحياة التي ضربت في نفس الوقت ، مما يجعل التمرين لمدة 20 دقيقة يبدو كثيرًا.\r\n\r\nلقد صممت هذا الروتين عن قصد لاستخدامه بسهولة في تخصيصين مختلفين للوقت: إصدار سريع يأخذك خلال مقطع فيديو التمرين الكامل هذا ويبلغ أقصى حد له 15 دقيقة ، وإصدار فائق السرعة يأخذك خلال جزء \"التمرين\" لـ نصف الوقت مع قطع الطول الإجمالي إلى حوالي 10 دقائق.\r\n\r\nيتم إجراء كل هذا الروتين بنفس بنية الفاصل الزمني 20 تشغيل و 10 إيقاف لإبقائه سريعًا وبسيطًا. لقد قمت بتضمين إحماء سريع مدته 3 دقائق يتم تشغيله مباشرة في التمرين لتقليل أي توقف مؤقت غير ضروري ؛ تذكر أن هذا كله يتعلق بالكفاءة حتى نتمكن من الحصول على أفضل تدريب ممكن في أقصر وقت ممكن. لذلك ، بعد تمارين الإحماء الستة ، ننتقل مباشرة إلى التمارين الثمانية لقسم التمرين. هذا هو المكان الذي يمكنك فيه الاختيار من خلال هذه التدريبات الثمانية مرة واحدة أو مرتين. أعطي دعوة واضحة عندما ننتهي من أول تشغيل لهذه التمارين حتى تتمكن من اتخاذ قرار التخطي إلى فترة التهدئة السريعة التي تبلغ 3 دقائق والقيام بها في حوالي 10 دقائق أو إجراء التمارين مرة ثانية (كما أفعل في الفيديو) ويتم الانتهاء منه في حوالي 15 دقيقة. بهذه الطريقة يمكنك تحديد مقدار الوقت الذي يمكنك تخصيصه لهذا التمرين.\r\n\r\nهذا تمرين شامل للجسم ، لذا إذا كنت تستخدمه بعد يوم مكثف من الجزء العلوي أو السفلي من الجسم ، ففي كلتا الحالتين من المرجح أنك تستخدم بعض مجموعات العضلات نفسها. لا تقلق ، على الرغم من ذلك - ستفعل ذلك بوزن الجسم فقط حتى تتمكن من التكيف لجعل التمارين أسهل أو أصعب ، وستقوم فقط ببضع عمليات التكرار لكل منها ، لذلك لا داعي للقلق بشأن إرهاق العضلات المؤلمة.\r\n\r\nمع ذلك ، يمكن أيضًا استخدام هذا كتمرين إضافي إذا كنت تريد القيام بتمرين ثانٍ في يوم واحد. يمكن القيام بذلك إما مباشرة بعد التمرين الأول أو في وقت لاحق من اليوم للحصول على نوبة إضافية من حرق السعرات الحرارية.", 3, 15, " بدون معدات ", "Images/Exercise/39.jpg", 0.0, null, "تمرين الجسم الكلي السريع - 10 أو 15 دقيقة تختارها", "تدريب متقطع عالي الكثافة ، تأثير منخفض ، بيلاتيس ، تدريب القوة ، التمدد / المرونة ، القدرة على الحركة", "https://www.youtube.com/watch?v=xafq0q5lIq4" },
                    { "9", "الجسم السفلي", "50-250", "يمكن استخدام تمرين الجزء السفلي من الجسم هذا للتناغم أو القوة أو بناء الكتلة ، بحيث يمكنك استخدامه لما تحتاجه بالضبط. في هذا الروتين ، قمنا بتقسيم التمرين إلى ثلاث مجموعات (لا تشمل الإحماء والتهدئة). سيتم إجراء أول مجموعتين بأسلوب فاصل من 45 ثانية من النشاط مع 15 ثانية من الراحة للاستعداد للتمرين التالي. تحتوي كل مجموعة من هاتين المجموعتين الأوليين على 4 تمارين لكل منهما ، وسيتم إجراؤها بنمط A ، B A ، B بالتناوب ، بالتناوب ذهابًا وإيابًا بين اثنين من التمارين الأربعة في وقت واحد. سيتم إجراء كل تمرين لما مجموعه ثلاث مجموعات قبل الانتقال إلى التدريبات التالية ، مما يمنحنا إجمالي 12 فترة لكل مجموعة لأول مجموعتين. ستتم المجموعة الأخيرة قبل فترة التهدئة والتمدد بشكل مختلف. على الرغم من وجود أربعة تمارين مرة أخرى في هذه المجموعة ، فإننا سنقوم بدلاً من ذلك بإجراء كل تمرين لمجموعة واحدة فقط باستخدام فترات 60 ثانية على و 15 ثانية راحة. هذا المزيج من مجموعتين باستخدام ثلاث مجموعات تقليدية أكثر لكل تمرين متبوعًا بمجموعة تستخدم مجموعة نضوب واحدة سيسمح لنا بإرهاق العضلات بشكل فعال إلى الحد الذي يمكننا فيه الحصول على التمزقات الدقيقة في عضلاتنا التي تؤدي إلى زيادة القوة والكتلة.\r\nمع ما يقال ، تذكر أنه يمكنك التحكم بالضبط في النتائج التي تحصل عليها من هذا الروتين عن طريق ضبط الوزن الذي تختار رفعه ومدى سرعة القيام بكل تكرار. للحصول على تمرين أكثر تركيزًا على التنغيم ، استخدم وزن الجسم فقط أو الوزن الخفيف جدًا وتحرك بسرعة أكبر (طالما أنك لا تزال تتحرك مع التحكم ولا تستخدم الزخم للمساعدة في إكمال الحركة التي يتم إجراؤها). إذا كنت تريد التركيز أكثر على بناء الحجم الكلي للعضلات ، فحافظ على بطء حركاتك واختر أثقل وزن يمكنك التحكم فيه من خلال نطاق كامل من الحركة. مع بناء الكتلة ، يجب أن يكون هدفك هو الحصول على 90-100 ٪ من كل مجموعة من أول مجموعتين (من أي تمرين معين) قبل أن تبدأ عضلاتك في الاستسلام ويبدأ شكلك في المعاناة. يجب أن يكون الهدف من المجموعة الثالثة (الأخيرة) من كل تمرين هو إكمال 80-90٪ من الفاصل الزمني قبل أن تستسلم عضلاتك.", 4, 43, "دمبل", "Images/Exercise/40.jpg", 0.0, null, "تقوية اعضاء الجسم السفلية - تمرين الفخذ لمدة 43 دقيقة", "تدريب القوة", "https://www.youtube.com/watch?v=ABDmiZD1TDU" }
                });

            migrationBuilder.InsertData(
                table: "TblHealthyRecipe",
                columns: new[] { "Id", "Calories", "Description", "DieteryType", "Image", "Ingredients", "MealType", "PrepTime", "PreparationMethod", "Price", "Protein", "Title", "Total_Carbohydrate" },
                values: new object[,]
                {
                    { "41", 491, null, 0, "1.jpg", null, 3, 50, null, null, 35, "وجبة 1", 43 },
                    { "42", 156, null, 1, "2.jpg", null, 4, 5, null, null, 4, null, 17 },
                    { "43", 379, null, 0, "3.jpg", null, 2, 50, null, null, 32, null, 47 },
                    { "44", 19, null, 1, "4.jpg", null, 4, 60, null, null, 5, null, 37 },
                    { "45", 170, null, 0, "5.png", null, 4, 60, null, null, 5, null, 43 },
                    { "46", 180, null, 1, "6.jpg", null, 2, 30, null, null, 4, null, 44 },
                    { "47", 538, null, 0, "7.jpg", null, 3, 35, null, null, 37, null, 79 },
                    { "48", 30, null, 1, "8.jpg", null, 1, 10, null, null, 5, null, 10 },
                    { "49", 110, null, 1, "9.png", null, 1, 15, null, null, 5, null, 10 },
                    { "50", 40, null, 1, "10.png", null, 0, 60, null, null, 8, null, 20 },
                    { "51", 125, null, 1, "11.png", null, 2, 50, null, null, 5, null, 30 },
                    { "52", 66, null, 0, "12.png", null, 4, 30, null, null, 5, null, 36 },
                    { "53", 110, null, 1, "13.jpg", null, 2, 30, null, null, 7, null, 45 },
                    { "54", 145, null, 0, "14.jpg", null, 2, 60, null, null, 17, null, 30 },
                    { "55", 25, null, 1, "15.png", null, 0, 15, null, null, 8, null, 10 },
                    { "56", 150, null, 0, "16.jpg", null, 4, 30, null, null, 5, null, 25 },
                    { "57", 50, null, 1, "17.jpg", null, 3, 20, null, null, 4, null, 15 },
                    { "58", 65, null, 0, "18.jpg", null, 1, 30, null, null, 15, null, 40 },
                    { "59", 34, null, 0, "19.jpg", null, 1, 15, null, null, 0, null, 15 },
                    { "60", 45, null, 0, "20.jpg", null, 1, 240, null, null, 7, null, 15 }
                });

            migrationBuilder.InsertData(
                table: "TblOrder",
                columns: new[] { "Id", "OrderDate", "TotalPrice", "UserId", "UserIdDelivery", "UserIdResiver" },
                values: new object[,]
                {
                    { "1", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0, "1", 1, 1 },
                    { "2", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", 1, 1 },
                    { "3", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "TblServices",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { "1", "1", "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ", 19.989999999999998, "حمية البحر المتوسط" },
                    { "100", "1", "تم تصميم هذا التحدي لمدة 5 أيام للقوة والقلب والشد لتحسين قوة الجسم بالكامل والقدرة على التحمل وإعادة إشعال الحافز لروتين لياقة بدنية ثابت.", 350.0, "سلسلة مُدربي التحدي لمدة 5 أيام: تناغم مع إيريكا" },
                    { "101", "5", "لبدء هذا العام بشكل صحيح ، ننشر فيديو تمرين مجاني جديد كل صباح للأسبوع الأول من شهر كانون الثاني (يناير) ؛ خمسة أيام من التدريبات المكثفة ، ويوم تعافي واحد ، وتأمل يوم راحة. نحن متحمسون جدًا لأن نكون قادرين على تقديم هذا التحدي الجديد ، ونحن متحمسون حقًا لأننا تمكنا من بنائه مع فريقنا. سيكون أسبوعًا ممتعًا!", 100.0, "تحدي للياقة البدنية لمدة 5 أيام مجانًا" },
                    { "102", "5", "تحدي تجريب أسبوع مصمم للأشخاص الذين يريدون فقط ثلاثة (مطلوب) أيام تمرين في الأسبوع. سواء كنت مشغولاً للغاية لأكثر من ثلاثة تمارين في الأسبوع ، أو كنت ترغب في استكمال أنواع أخرى من اللياقة البدنية (المشي ، والسباحة ، وما إلى ذلك) بمقاطع فيديو للتمرين في المنزل ، فإن هذا التحدي يهدف إلى المساعدة في دعم اللياقة البدنية الشاملة. الروتين الذي يناسب الجدول الزمني والسرعة التي تريدها. توقع مزيجًا من رفع الأثقال والتدريب المتقطع عالي الكثافة (التدريب المتقطع عالي الكثافة) الذي سيختبر قدرتك على التحمل وصحة القلب والأوعية الدموية والقوة.", 200.0, "3 تمارين في الأسبوع لمدة أسبوعين" },
                    { "103", "5", "هذا برنامج صديق للمبتدئين مدته 8 أسابيع مصمم لبناء قاعدة القوة الكلية للجسم وتحمل القلب والأوعية الدموية واللياقة البدنية الشاملة.", 450.0, "برنامج لمدة 8 أسابيع لبدء روتين لياقتك البدنية" },
                    { "11", "1", "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ", 19.989999999999998, " اختبار " },
                    { "2", "1", " يعتمد على تقليل الكربوهيدرات  و منع السكر المصنع و البطاطا , يتم تناول الفواكه و الخضروات و الحبوب", 20.989999999999998, "  النظام الغذائي باليو" },
                    { "21", "4", "", 20.0, "طقم اوزان دمبل 30 كغم" },
                    { "22", "4", "", 30.0, "حلقات لايف اب الاولمبية للجمباز" },
                    { "23", "4", "", 1490.0, "مشاية كهربائية منحنية بدون محرك" },
                    { "24", "4", "", 320.0, "دراجة سبينر" },
                    { "25", "4", "", 150.0, "Livepro أيروبيك ستيبر ومقعد" },
                    { "26", "4", "", 15.0, "سجادة Liveup للتمارين الرياضية" },
                    { "27", "4", "", 175.0, "مقعد بووفليكس متعدد الوظائف" },
                    { "28", "4", "", 69.0, "حبل معركة بروبانتل" },
                    { "29", "4", "", 125.0, "مقعد قابل للطي قابل للتعديل للتمارين الرياضية" },
                    { "3", "1", "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن", 19.989999999999998, "   كيتو دايت " },
                    { "30", "4", "", 25.0, "مجدّف" },
                    { "31", "3", "", 111.0, "زيت السمك أوميغا 3" },
                    { "32", "3", "", 78.0, "Muscletech, بلاتينيوم ملتي فيتامين" },
                    { "33", "3", "", 169.0, "Ultima Replenisher" },
                    { "34", "3", "", 169.0, "زيت الكريل" },
                    { "35", "3", "", 170.0, "أنافيت" },
                    { "36", "3", "", 79.0, "Trace Minerals Research" },
                    { "37", "3", "", 109.0, "BodyBio, E-Lyte" },
                    { "38", "3", "", 163.0, "فيجا ، سبورت" },
                    { "39", "3", "", 111.0, "مضاعف الترطيب" },
                    { "4", "1", "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن", 19.989999999999998, "   كيتو دايت " },
                    { "40", "3", "", 54.0, "NutriBiotic" },
                    { "41", "3", "", 169.0, "زيت الكريل" },
                    { "5", "1", "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ", 19.989999999999998, " اختبار " }
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
                    { "21", 20.0, "/Image/Product/Dumbbell3.jfif" },
                    { "22", 0.0, "/Image/Product/LiveupOlympic.jpg" },
                    { "23", 0.0, "/Image/Product/Curved.jpg" },
                    { "24", 0.0, "/Image/Product/Spinner.jpg" },
                    { "25", 0.0, "/Image/Product/Liveup.jpg" },
                    { "26", 0.0, "/Image/Product/LiveupOlympic.jpg" },
                    { "27", 0.0, "/Image/Product/Bowflex.jpg" },
                    { "28", 0.0, "/Image/Product/Brobantle.jfif" },
                    { "29", 0.0, "/Image/Product/Adjustable.jpg" },
                    { "30", 0.0, "/Image/Product/rower.jpg" },
                    { "31", 0.0, "/Image/Product/omega.jpg" }
                });

            migrationBuilder.InsertData(
                table: "TblProducts",
                columns: new[] { "Id", "Discount", "ImgUrl" },
                values: new object[,]
                {
                    { "32", 0.0, "/Image/Product/Muscletech.jpg" },
                    { "33", 0.0, "/Image/Product/Ultima.jpg" },
                    { "34", 0.0, "/Image/Product/krilloil.jpg" },
                    { "35", 0.0, "/Image/Product/anavite.jpg" },
                    { "36", 0.0, "/Image/Product/Trace.jpg" },
                    { "37", 0.0, "/Image/Product/BodyBio.jpg" },
                    { "38", 0.0, "/Image/Product/Vega.jpg" },
                    { "39", 0.0, "/Image/Product/HydrationMultiplier.jpg" },
                    { "40", 0.0, "/Image/Product/NutriBiotic.jpg" },
                    { "41", 0.0, "/Image/Product/krilloil.jpg" }
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
                name: "IX_TblFavorite_Servies_FavoriteId",
                table: "TblFavorite_Servies",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFavorite_Servies_ServicesId",
                table: "TblFavorite_Servies",
                column: "ServicesId");

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
                name: "IX_Tracking_Exercies_programId",
                table: "Tracking",
                column: "Exercies_programId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracking_Order_DetailsId",
                table: "Tracking",
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
                name: "TblChatUser");

            migrationBuilder.DropTable(
                name: "TblComment");

            migrationBuilder.DropTable(
                name: "TblCommentServies");

            migrationBuilder.DropTable(
                name: "TblCoupon_redemption");

            migrationBuilder.DropTable(
                name: "TblFavorite_Servies");

            migrationBuilder.DropTable(
                name: "TblMeal_Healthy");

            migrationBuilder.DropTable(
                name: "TblNotification");

            migrationBuilder.DropTable(
                name: "TblProducts");

            migrationBuilder.DropTable(
                name: "TblRate");

            migrationBuilder.DropTable(
                name: "Tracking");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TblChat");

            migrationBuilder.DropTable(
                name: "TblArticles");

            migrationBuilder.DropTable(
                name: "TblCoupon");

            migrationBuilder.DropTable(
                name: "TblFavorite");

            migrationBuilder.DropTable(
                name: "TblHealthyRecipe");

            migrationBuilder.DropTable(
                name: "TblMealPlans");

            migrationBuilder.DropTable(
                name: "TblExercies_program");

            migrationBuilder.DropTable(
                name: "TblOrder_Details");

            migrationBuilder.DropTable(
                name: "TblExercises");

            migrationBuilder.DropTable(
                name: "TblSportsProgram");

            migrationBuilder.DropTable(
                name: "TblOrder");

            migrationBuilder.DropTable(
                name: "TblServices");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
