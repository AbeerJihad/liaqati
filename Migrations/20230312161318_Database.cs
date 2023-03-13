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
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    target = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiverID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEx = table.Column<int>(type: "int", nullable: true),
                    Difficulty = table.Column<int>(type: "int", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraningType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblExercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Exp_Years = table.Column<int>(type: "int", nullable: true),
                    Wieght = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Photograph = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cover_photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsNumber = table.Column<int>(type: "int", nullable: false),
                    likesNumber = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MealPlansId = table.Column<int>(type: "int", nullable: true),
                    HealthyRecipesId = table.Column<int>(type: "int", nullable: true),
                    ProductsId = table.Column<int>(type: "int", nullable: true),
                    sportsProgramId = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ChatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievements_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ChatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatUser_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    UserIdDelivery = table.Column<int>(type: "int", nullable: false),
                    UserIdResiver = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblOrder_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    repliedFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    articlesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_TblArticles_articlesId",
                        column: x => x.articlesId,
                        principalTable: "TblArticles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comment_Servies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    repliedFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    servicesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment_Servies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Servies_TblServices_servicesId",
                        column: x => x.servicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favorite_Servies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicesId = table.Column<int>(type: "int", nullable: true),
                    favoriteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite_Servies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorite_Servies_Favorite_favoriteId",
                        column: x => x.favoriteId,
                        principalTable: "Favorite",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Favorite_Servies_TblServices_servicesId",
                        column: x => x.servicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HealthyRecipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    DieteryType = table.Column<int>(type: "int", nullable: false),
                    prepTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Total_Carbohydrate = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<int>(type: "int", nullable: false),
                    servicesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthyRecipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthyRecipes_TblServices_servicesId",
                        column: x => x.servicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    servicesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_TblServices_servicesId",
                        column: x => x.servicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblMealPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<int>(type: "int", nullable: false),
                    dietaryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mealType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    avgRecipeTime = table.Column<double>(type: "float", nullable: false),
                    servicesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMealPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblMealPlans_TblServices_servicesId",
                        column: x => x.servicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblSportsProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyFocus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    servicesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSportsProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblSportsProgram_TblServices_servicesId",
                        column: x => x.servicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Trak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trak_TblServices_servicesId",
                        column: x => x.servicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblOrder_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    RateId = table.Column<int>(type: "int", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Exercies_program",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isComplete = table.Column<bool>(type: "bit", nullable: false),
                    exerciseId = table.Column<int>(type: "int", nullable: false),
                    sportsProgramId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercies_program", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercies_program_TblExercises_exerciseId",
                        column: x => x.exerciseId,
                        principalTable: "TblExercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercies_program_TblSportsProgram_sportsProgramId",
                        column: x => x.sportsProgramId,
                        principalTable: "TblSportsProgram",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    review = table.Column<int>(type: "int", nullable: false),
                    review_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Order_DetailsId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.InsertData(
                table: "TblSportsProgram",
                columns: new[] { "Id", "BodyFocus", "Description", "Difficulty", "Equipment", "Length", "Price", "Title", "TrainingType", "servicesId" },
                values: new object[] { 1, "كل الجسم", "<p>\n أفضل طريقة لتحصيل أفضل النتائج من جهودك في التدريب هي تطبيق عدّة طرق وأنواع من التمارين والروتينات, وذلك لتمنح جسمك حوافز جديدة باستمرار لنمو العضلات وبناء أنسجة عضلية جديدة, ولتمنع تأقلم جسمك مع التدريبات التي تمارسهاء فإذا حصل هذا التاقلم سيبطئ عملية حرق الدهون وبناء العضلات. لذا عليك تغيير روتين تدريبك باستمرارإن كنت قد اتخذت قرارك بوضع حد لجسمك المترهّل وأسلوب حياتك الخامل وتريد أن تعرف كيف تنفذ خطة تدربيبة تعطيك نتائج مذهلة في فترة قصيرة, فقد وصلت للمكان المناسب. ستمكّنك هذه الخطة من رؤية تغيّرات جذرية في انسيابية جسمك ورشاقتك ومستوى لياقتك البدنية خلال 8 أسابيع من تنفيذها</p><h2>why kadljkd</h2>", "3-4", "حزام التمرين,سجاد", 8, 99.0, " برنامج لنحت وتفصيل الجسم في 8 أسابيع فقط", "القلب والأوعية الدموية ، تأثير منخفض ، تدريب القوة ، التنغيم ، اليوجا ، الحركة", null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "Cover_photo", "Exp_Years", "Fname", "Gender", "Height", "Lname", "Photograph", "Wieght" },
                values: new object[] { 1, false, "sssssssssssssssa", 10, "sssssssssssssss", 1, 120, "sssssssssssssss", "ssssssssssssssss", 120 });

            migrationBuilder.InsertData(
                table: "TblOrder",
                columns: new[] { "Id", "OrderDate", "TotalPrice", "UserId", "UserIdDelivery", "UserIdResiver" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserId",
                table: "Achievements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatUser_ChatId",
                table: "ChatUser",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatUser_UserId",
                table: "ChatUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_Servies_servicesId",
                table: "Comment_Servies",
                column: "servicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_articlesId",
                table: "Comments",
                column: "articlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercies_program_exerciseId",
                table: "Exercies_program",
                column: "exerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercies_program_sportsProgramId",
                table: "Exercies_program",
                column: "sportsProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_Servies_favoriteId",
                table: "Favorite_Servies",
                column: "favoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_Servies_servicesId",
                table: "Favorite_Servies",
                column: "servicesId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthyRecipes_servicesId",
                table: "HealthyRecipes",
                column: "servicesId",
                unique: true,
                filter: "[servicesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Message_ChatId",
                table: "Message",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_servicesId",
                table: "Products",
                column: "servicesId",
                unique: true,
                filter: "[servicesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TblArticles_CategoryId",
                table: "TblArticles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblMealPlans_servicesId",
                table: "TblMealPlans",
                column: "servicesId",
                unique: true,
                filter: "[servicesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrder_UserId",
                table: "TblOrder",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrder_Details_OrderId",
                table: "TblOrder_Details",
                column: "OrderId");

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
                name: "IX_TblSportsProgram_servicesId",
                table: "TblSportsProgram",
                column: "servicesId",
                unique: true,
                filter: "[servicesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Trak_servicesId",
                table: "Trak",
                column: "servicesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "ChatUser");

            migrationBuilder.DropTable(
                name: "Comment_Servies");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Exercies_program");

            migrationBuilder.DropTable(
                name: "Favorite_Servies");

            migrationBuilder.DropTable(
                name: "HealthyRecipes");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "TblMealPlans");

            migrationBuilder.DropTable(
                name: "TblRate");

            migrationBuilder.DropTable(
                name: "Trak");

            migrationBuilder.DropTable(
                name: "TblArticles");

            migrationBuilder.DropTable(
                name: "TblExercises");

            migrationBuilder.DropTable(
                name: "TblSportsProgram");

            migrationBuilder.DropTable(
                name: "Favorite");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "TblOrder_Details");

            migrationBuilder.DropTable(
                name: "TblServices");

            migrationBuilder.DropTable(
                name: "TblOrder");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
