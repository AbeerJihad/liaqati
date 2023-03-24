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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Target = table.Column<int>(type: "int", nullable: true),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DEx = table.Column<int>(type: "int", nullable: true),
                    Difficulty = table.Column<int>(type: "int", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraningType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblExercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblServices_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
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
                        name: "FK_Message_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                        name: "FK_TblAchievements_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    repliedFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    articlesId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    repliedFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    servicesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment_Servies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Servies_TblServices_servicesId",
                        column: x => x.servicesId,
                        principalTable: "TblServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorite_Servies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    servicesId = table.Column<int>(type: "int", nullable: false),
                    servicesId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    favoriteId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite_Servies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorite_Servies_Favorite_favoriteId",
                        column: x => x.favoriteId,
                        principalTable: "Favorite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorite_Servies_TblServices_servicesId1",
                        column: x => x.servicesId1,
                        principalTable: "TblServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HealthyRecipes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    DieteryType = table.Column<int>(type: "int", nullable: false),
                    prepTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Total_Carbohydrate = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<int>(type: "int", nullable: false),
                    Ingredients = table.Column<int>(type: "int", nullable: false),
                    PreparationMethod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthyRecipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthyRecipes_TblServices_Id",
                        column: x => x.Id,
                        principalTable: "TblServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblMealPlans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    numsubscribers = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: true),
                    dietaryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mealType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    avgRecipeTime = table.Column<double>(type: "float", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "TblProducts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyFocus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrainingType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                name: "Trak",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    servicesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trak_TblServices_servicesId",
                        column: x => x.servicesId,
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
                    ServicesId = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Exercies_program",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    isComplete = table.Column<bool>(type: "bit", nullable: false),
                    exerciseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sportsProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Image", "Name", "Target" },
                values: new object[,]
                {
                    { "1", null, "النظام الغذائي", null },
                    { "2", null, "الوجبات", null },
                    { "3", null, "المكملات الغذائية", null },
                    { "4", null, "الاجهزة الرياضية", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "Cover_photo", "Exp_Years", "Fname", "Gender", "Height", "Lname", "Photograph", "Wieght" },
                values: new object[] { "1", false, "sssssssssssssssa", 10, "sssssssssssssss", 1, 120, "sssssssssssssss", "ssssssssssssssss", 120 });

            migrationBuilder.InsertData(
                table: "TblOrder",
                columns: new[] { "Id", "OrderDate", "TotalPrice", "UserId", "UserIdDelivery", "UserIdResiver" },
                values: new object[] { "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "1", 1, 1 });

            migrationBuilder.InsertData(
                table: "TblServices",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { "1", "1", "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ", 19.989999999999998, "حمية البحر المتوسط" },
                    { "11", "1", "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ", 19.989999999999998, " اختبار " },
                    { "2", "1", " يعتمد على تقليل الكربوهيدرات  و منع السكر المصنع و البطاطا , يتم تناول الفواكه و الخضروات و الحبوب", 20.989999999999998, "  النظام الغذائي باليو" },
                    { "21", "4", null, 20.0, "طقم اوزان دمبل 30 كغم" },
                    { "22", "4", null, 30.0, "حلقات لايف اب الاولمبية للجمباز" },
                    { "23", "4", null, 1490.0, "مشاية كهربائية منحنية بدون محرك" },
                    { "24", "4", null, 320.0, "دراجة سبينر" },
                    { "25", "4", null, 150.0, "Livepro أيروبيك ستيبر ومقعد" },
                    { "26", "4", null, 15.0, "سجادة Liveup للتمارين الرياضية" },
                    { "27", "4", null, 175.0, "مقعد بووفليكس متعدد الوظائف" },
                    { "28", "4", null, 69.0, "حبل معركة بروبانتل" },
                    { "29", "4", null, 125.0, "مقعد قابل للطي قابل للتعديل للتمارين الرياضية" },
                    { "3", "1", "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن", 19.989999999999998, "   كيتو دايت " },
                    { "30", "4", null, 25.0, "مجدّف" },
                    { "31", "3", null, 111.0, "زيت السمك أوميغا 3" },
                    { "32", "3", null, 78.0, "Muscletech, بلاتينيوم ملتي فيتامين" },
                    { "33", "3", null, 169.0, "Ultima Replenisher" },
                    { "34", "3", null, 169.0, "زيت الكريل" },
                    { "35", "3", null, 170.0, "أنافيت" },
                    { "36", "3", null, 79.0, "Trace Minerals Research" },
                    { "37", "3", null, 109.0, "BodyBio, E-Lyte" },
                    { "38", "3", null, 163.0, "فيجا ، سبورت" },
                    { "39", "3", null, 111.0, "مضاعف الترطيب" },
                    { "4", "1", "  يعتمد على تقليل الكربوهيدرات و تناول الدهون الصحية , لا ينصح به النساءو الحوامل و كبار السن", 19.989999999999998, "   كيتو دايت " },
                    { "40", "3", null, 54.0, "NutriBiotic" },
                    { "41", "3", null, 169.0, "زيت الكريل" },
                    { "5", "1", "يعتمد على تناول البقوليات و المكسرات و الأوراق الخضراء ,مفيد لمرضى السكر و القلب ", 19.989999999999998, " اختبار " }
                });

            migrationBuilder.InsertData(
                table: "TblMealPlans",
                columns: new[] { "Id", "Length", "avgRecipeTime", "dietaryType", "image", "mealType", "numsubscribers" },
                values: new object[,]
                {
                    { "1", 0, 0.0, "", "", "", 0 },
                    { "2", 0, 0.0, "", "", "", 0 },
                    { "3", 0, 0.0, "", "", "", 0 },
                    { "4", 0, 0.0, "", "", "", 0 },
                    { "5", 0, 0.0, "", "", "", 0 }
                });

            migrationBuilder.InsertData(
                table: "TblProducts",
                columns: new[] { "Id", "Discount", "imgUrl" },
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
                name: "IX_Favorite_Servies_servicesId1",
                table: "Favorite_Servies",
                column: "servicesId1");

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
                name: "IX_Trak_servicesId",
                table: "Trak",
                column: "servicesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "TblAchievements");

            migrationBuilder.DropTable(
                name: "TblMealPlans");

            migrationBuilder.DropTable(
                name: "TblProducts");

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
                name: "TblOrder");

            migrationBuilder.DropTable(
                name: "TblServices");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
