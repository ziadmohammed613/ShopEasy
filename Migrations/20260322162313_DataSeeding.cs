using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopEasy.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "shop",
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "ParentCategoryId", "Slug" },
                values: new object[,]
                {
                    { 1, null, "Electronics", null, "electronics" },
                    { 11, null, "Clothing", null, "clothing" },
                    { 16, null, "Home & Living", null, "home-living" },
                    { 19, null, "Books", null, "books" },
                    { 20, null, "Sports & Outdoors", null, "sports-outdoors" }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Customers",
                columns: new[] { "CustomerId", "CreatedAt", "Email", "full_name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "walid.ramadan1@example.com", "Walid Ramadan", "01125437367" },
                    { 2, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ramadan.saleh2@example.com", "Ramadan Saleh", "01178324943" },
                    { 3, new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "shaimaa.naguib3@example.com", "Shaimaa Naguib", "01177072241" },
                    { 4, new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatima.morsi4@example.com", "Fatima Morsi", "01164201776" },
                    { 5, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "khaled.abdelrahman5@example.com", "Khaled Abdel-Rahman", "01125631632" },
                    { 6, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "amira.hamed6@example.com", "Amira Hamed", "01127852203" },
                    { 7, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatima.saad7@example.com", "Fatima Saad", "01149792477" },
                    { 8, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ziad.rashed8@example.com", "Ziad Rashed", "01293414144" },
                    { 9, new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "hassan.emara9@example.com", "Hassan Emara", "01038363649" },
                    { 10, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "eman.mansour10@example.com", "Eman Mansour", "01279051112" },
                    { 11, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fady.elsayed11@example.com", "Fady El-Sayed", "01257317289" },
                    { 12, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "tarek.maher12@example.com", "Tarek Maher", "01298699277" },
                    { 13, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hana.mostafa13@example.com", "Hana Mostafa", "01037217581" },
                    { 14, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "fady.salem14@example.com", "Fady Salem", "01172695883" },
                    { 15, new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.othman15@example.com", "Youssef Othman", "01269259358" },
                    { 16, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "adel.naguib16@example.com", "Adel Naguib", "01016524385" },
                    { 17, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "samer.rashed17@example.com", "Samer Rashed", "01086243658" },
                    { 18, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "salma.lotfy18@example.com", "Salma Lotfy", "01226952295" },
                    { 19, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "samir.salem19@example.com", "Samir Salem", "01174409492" },
                    { 20, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "walid.khalil20@example.com", "Walid Khalil", "01166952088" },
                    { 21, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "dina.rashed21@example.com", "Dina Rashed", "01010313053" },
                    { 22, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "mariam.morsi22@example.com", "Mariam Morsi", "01134974063" },
                    { 23, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "samer.sherif23@example.com", "Samer Sherif", "01016824235" },
                    { 24, new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ramadan.saleh24@example.com", "Ramadan Saleh", "01149027730" },
                    { 25, new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "samer.badr25@example.com", "Samer Badr", "01014701810" },
                    { 26, new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "hassan.qassem26@example.com", "Hassan Qassem", "01056052781" },
                    { 27, new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "samer.rashed27@example.com", "Samer Rashed", "01015744762" },
                    { 28, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "shaimaa.othman28@example.com", "Shaimaa Othman", "01056163523" },
                    { 29, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "radwa.naguib29@example.com", "Radwa Naguib", "01285861260" },
                    { 30, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "hamdy.gohar30@example.com", "Hamdy Gohar", "01253758804" },
                    { 31, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.abdelrahman31@example.com", "Youssef Abdel-Rahman", "01130438759" },
                    { 32, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "walid.lotfy32@example.com", "Walid Lotfy", "01283698090" },
                    { 33, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "samer.maher33@example.com", "Samer Maher", "01091978589" },
                    { 34, new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "tamer.ali34@example.com", "Tamer Ali", "01212201455" },
                    { 35, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "mariam.eldin35@example.com", "Mariam El-Din", "01027662455" },
                    { 36, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "sherif.ibrahim36@example.com", "Sherif Ibrahim", "01272432953" },
                    { 37, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "essam.hassan37@example.com", "Essam Hassan", "01115167432" },
                    { 38, new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "nadia.hamdan38@example.com", "Nadia Hamdan", "01199052572" },
                    { 39, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ziad.khaled39@example.com", "Ziad Khaled", "01125903238" },
                    { 40, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.selim40@example.com", "Youssef Selim", "01191669436" },
                    { 41, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "rania.badr41@example.com", "Rania Badr", "01279513149" },
                    { 42, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ghada.hamdan42@example.com", "Ghada Hamdan", "01037009466" },
                    { 43, new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "emad.rizk43@example.com", "Emad Rizk", "01231483691" },
                    { 44, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "noha.saleh44@example.com", "Noha Saleh", "01090686704" },
                    { 45, new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "amr.badawi45@example.com", "Amr Badawi", "01278209868" },
                    { 46, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.ali46@example.com", "Youssef Ali", "01160768004" },
                    { 47, new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "essam.khalil47@example.com", "Essam Khalil", "01250614170" },
                    { 48, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mariam.mahmoud48@example.com", "Mariam Mahmoud", "01230840514" },
                    { 49, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "essam.ramadan49@example.com", "Essam Ramadan", "01132931830" },
                    { 50, new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "shaimaa.qassem50@example.com", "Shaimaa Qassem", "01123421315" },
                    { 51, new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "nadia.gohar51@example.com", "Nadia Gohar", "01144070992" },
                    { 52, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "hassan.khalil52@example.com", "Hassan Khalil", "01212287602" },
                    { 53, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "hossam.rizk53@example.com", "Hossam Rizk", "01129861498" },
                    { 54, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "rana.eldin54@example.com", "Rana El-Din", "01014895611" },
                    { 55, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "adel.naguib55@example.com", "Adel Naguib", "01085423043" },
                    { 56, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mariam.emara56@example.com", "Mariam Emara", "01270853439" },
                    { 57, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "abeer.ezzat57@example.com", "Abeer Ezzat", "01083361428" },
                    { 58, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "amr.elsayed58@example.com", "Amr El-Sayed", "01073466115" },
                    { 59, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "khaled.gohar59@example.com", "Khaled Gohar", "01050163298" },
                    { 60, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emad.hassan60@example.com", "Emad Hassan", "01191507292" },
                    { 61, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "nadia.gohar61@example.com", "Nadia Gohar", "01023406277" },
                    { 62, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "adel.omar62@example.com", "Adel Omar", "01129170495" },
                    { 63, new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "eman.fawzy63@example.com", "Eman Fawzy", "01159093603" },
                    { 64, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "fady.mansour64@example.com", "Fady Mansour", "01216423049" },
                    { 65, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "tarek.saleh65@example.com", "Tarek Saleh", "01142941537" },
                    { 66, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "salma.naguib66@example.com", "Salma Naguib", "01240417163" },
                    { 67, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "magdy.abdelrahman67@example.com", "Magdy Abdel-Rahman", "01176312648" },
                    { 68, new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "doaa.khaled68@example.com", "Doaa Khaled", "01117859123" },
                    { 69, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara.yousef69@example.com", "Sara Yousef", "01265456124" },
                    { 70, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tamer.monir70@example.com", "Tamer Monir", "01049700272" },
                    { 71, new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatima.qassem71@example.com", "Fatima Qassem", "01111084421" },
                    { 72, new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "amira.mostafa72@example.com", "Amira Mostafa", "01193978737" },
                    { 73, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hana.khaled73@example.com", "Hana Khaled", "01251249783" },
                    { 74, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "hana.farouk74@example.com", "Hana Farouk", "01061066065" },
                    { 75, new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "hamdy.sobhi75@example.com", "Hamdy Sobhi", "01032438574" },
                    { 76, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "heba.fawzy76@example.com", "Heba Fawzy", "01285669737" },
                    { 77, new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "amr.qassem77@example.com", "Amr Qassem", "01173046311" },
                    { 78, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "layla.saad78@example.com", "Layla Saad", "01043555562" },
                    { 79, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.atef79@example.com", "Youssef Atef", "01079886246" },
                    { 80, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sherif.helal80@example.com", "Sherif Helal", "01255518760" },
                    { 81, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "hamdy.gohar81@example.com", "Hamdy Gohar", "01180528064" },
                    { 82, new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "mohamed.hassan82@example.com", "Mohamed Hassan", "01275044828" },
                    { 83, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "sherif.mohamed83@example.com", "Sherif Mohamed", "01137429944" },
                    { 84, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "abeer.fawzy84@example.com", "Abeer Fawzy", "01223564503" },
                    { 85, new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "emad.zaki85@example.com", "Emad Zaki", "01180274660" },
                    { 86, new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "karim.mahmoud86@example.com", "Karim Mahmoud", "01085076755" },
                    { 87, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.maher87@example.com", "Youssef Maher", "01122751623" },
                    { 88, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "magdy.ali88@example.com", "Magdy Ali", "01216349302" },
                    { 89, new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "yasmin.hamdan89@example.com", "Yasmin Hamdan", "01270742334" },
                    { 90, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tarek.rashed90@example.com", "Tarek Rashed", "01212289505" },
                    { 91, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayman.fawzy91@example.com", "Ayman Fawzy", "01191120364" },
                    { 92, new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "khaled.othman92@example.com", "Khaled Othman", "01283655261" },
                    { 93, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "tamer.ezzat93@example.com", "Tamer Ezzat", "01253635763" },
                    { 94, new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "layla.hamdan94@example.com", "Layla Hamdan", "01189565889" },
                    { 95, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "tarek.farouk95@example.com", "Tarek Farouk", "01045851466" },
                    { 96, new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "amira.ali96@example.com", "Amira Ali", "01070766496" },
                    { 97, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "khaled.eldin97@example.com", "Khaled El-Din", "01017422564" },
                    { 98, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "adel.nasser98@example.com", "Adel Nasser", "01267929312" },
                    { 99, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "nour.fawzy99@example.com", "Nour Fawzy", "01231483501" },
                    { 100, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mona.maher100@example.com", "Mona Maher", "01091281405" },
                    { 101, new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "hossam.saleh101@example.com", "Hossam Saleh", "01299389754" },
                    { 102, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "dina.morsi102@example.com", "Dina Morsi", "01030724717" },
                    { 103, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ramadan.monir103@example.com", "Ramadan Monir", "01219071690" },
                    { 104, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatima.atef104@example.com", "Fatima Atef", "01134033610" },
                    { 105, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "ghada.helal105@example.com", "Ghada Helal", "01045364572" },
                    { 106, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "dina.fawzy106@example.com", "Dina Fawzy", "01087475579" },
                    { 107, new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "doaa.elsayed107@example.com", "Doaa El-Sayed", "01264998192" },
                    { 108, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "emad.fawzy108@example.com", "Emad Fawzy", "01127968603" },
                    { 109, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "hamdy.monir109@example.com", "Hamdy Monir", "01258127032" },
                    { 110, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "noha.badawi110@example.com", "Noha Badawi", "01264137566" },
                    { 111, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "abeer.gohar111@example.com", "Abeer Gohar", "01082805422" },
                    { 112, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "rania.saleh112@example.com", "Rania Saleh", "01071778286" },
                    { 113, new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "salma.ezzat113@example.com", "Salma Ezzat", "01211682963" },
                    { 114, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "emad.saad114@example.com", "Emad Saad", "01039534137" },
                    { 115, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "eman.helal115@example.com", "Eman Helal", "01018265765" },
                    { 116, new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ghada.mahmoud116@example.com", "Ghada Mahmoud", "01059154630" },
                    { 117, new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "yasmin.shehata117@example.com", "Yasmin Shehata", "01043342455" },
                    { 118, new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "hassan.taha118@example.com", "Hassan Taha", "01212502390" },
                    { 119, new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "samer.nasser119@example.com", "Samer Nasser", "01261916571" },
                    { 120, new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "essam.badawi120@example.com", "Essam Badawi", "01159251627" }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "IsActive", "MaxUses", "Percentage" },
                values: new object[] { 1000, "SAVE10", 29, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 401, 12.61m });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "MaxUses", "Percentage" },
                values: new object[] { 1001, "SAVE20", 25, new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 363, 33.66m });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "IsActive", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1002, "WELCOME15", 33, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 485, 34.24m },
                    { 1003, "FLASH25", 20, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 97, 6.45m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "MaxUses", "Percentage" },
                values: new object[] { 1004, "VIP30", 4, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 128, 14.91m });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "IsActive", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1005, "STUDENT10", 29, new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 140, 19.05m },
                    { 1006, "RAMADAN20", 32, new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 245, 28.44m },
                    { 1007, "EID15", 49, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 228, 22.75m },
                    { 1008, "SUMMER25", 11, new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 312, 14.42m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1009, "BACK2SCHOOL", 40, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 461, 11.83m },
                    { 1010, "NEWUSER10", 38, new DateTime(2025, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, 28.12m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "IsActive", "MaxUses", "Percentage" },
                values: new object[] { 1011, "LOYALTY20", 30, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 96, 27.85m });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "MaxUses", "Percentage" },
                values: new object[] { 1012, "WEEKEND15", 35, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 426, 39.14m });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "IsActive", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1013, "CLEARANCE30", 31, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 269, 5.49m },
                    { 1014, "TECH10", 45, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 199, 25.47m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "MaxUses", "Percentage" },
                values: new object[] { 1015, "FASHION15", 44, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 300, 35.72m });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "IsActive", "MaxUses", "Percentage" },
                values: new object[] { 1016, "BOOKS20", 30, new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 457, 39.2m });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1017, "SPORTS25", 20, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 202, 34.53m },
                    { 1018, "HOME10", 36, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 184, 7.77m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "IsActive", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1019, "BUNDLE20", 40, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 283, 13.68m },
                    { 1020, "REFER15", 16, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 313, 29.37m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1021, "FIRSTORDER", 25, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 378, 33.79m },
                    { 1022, "MEGA30", 20, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 252, 28.61m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "IsActive", "MaxUses", "Percentage" },
                values: new object[] { 1023, "DAILY10", 27, new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 93, 23.07m });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1024, "WEEKLY20", 36, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 20.85m },
                    { 1025, "MONTHLY25", 4, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 24.65m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "IsActive", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1026, "SEASONAL15", 24, new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 483, 27.94m },
                    { 1027, "CLOSING40", 43, new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 349, 36.85m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Discounts",
                columns: new[] { "DiscountId", "Code", "CurrentUses", "ExpiresAt", "MaxUses", "Percentage" },
                values: new object[,]
                {
                    { 1028, "PREMIUM20", 15, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 186, 7.21m },
                    { 1029, "ELITE25", 8, new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 496, 12.26m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 1, "New Arrival" },
                    { 2, "Best Seller" },
                    { 3, "On Sale" },
                    { 4, "Limited Stock" },
                    { 5, "Trending" },
                    { 6, "Premium" },
                    { 7, "Budget Pick" },
                    { 8, "Eco-Friendly" },
                    { 9, "Imported" },
                    { 10, "Local Brand" },
                    { 11, "Wireless" },
                    { 12, "Fast Charging" },
                    { 13, "Waterproof" },
                    { 14, "Gaming" },
                    { 15, "Professional" },
                    { 16, "Student Pick" },
                    { 17, "Office Use" },
                    { 18, "Gift Idea" },
                    { 19, "Refurbished" },
                    { 20, "Bundle Deal" }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "ParentCategoryId", "Slug" },
                values: new object[,]
                {
                    { 2, null, "Mobile Phones", 1, "mobile-phones" },
                    { 3, null, "Laptops", 1, "laptops" },
                    { 4, null, "Tablets", 1, "tablets" },
                    { 5, null, "Audio & Headphones", 1, "audio-headphones" },
                    { 6, null, "Cameras", 1, "cameras" },
                    { 7, null, "Smart Watches", 1, "smart-watches" },
                    { 8, null, "TV & Displays", 1, "tv-displays" },
                    { 9, null, "Gaming", 1, "gaming" },
                    { 10, null, "Networking", 1, "networking" },
                    { 12, null, "Mens Wear", 11, "mens-wear" },
                    { 13, null, "Womens Wear", 11, "womens-wear" },
                    { 14, null, "Kids Clothing", 11, "kids-clothing" },
                    { 15, null, "Sportswear", 11, "sportswear" },
                    { 17, null, "Furniture", 16, "furniture" },
                    { 18, null, "Kitchen", 16, "kitchen" }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "CustomerProfiles",
                columns: new[] { "CustomerProfileId", "Address", "City", "CustomerId", "NationalId", "PostalCode" },
                values: new object[,]
                {
                    { 1, "55 Maadi Corniche", "Suez", 1, "31971034637599", "10280" },
                    { 2, "188 Mohandiseen", "Kafr El-Sheikh", 2, "22249035810575", "83841" },
                    { 3, "110 Ramsis St", "Beni Suef", 3, "39524474832258", "17356" },
                    { 4, "70 Ramsis St", "Sohag", 4, "21125086181938", "91518" },
                    { 5, "166 Maadi Corniche", "Mansoura", 5, "24218433684769", "88880" },
                    { 6, "73 El Haram St", "Port Said", 6, "32253153340238", "47733" },
                    { 7, "200 Port Said St", "Minya", 7, "39603209621647", "29382" },
                    { 8, "181 Salah Salem", "Fayoum", 8, "37082663655603", "25381" },
                    { 9, "39 El Galaa St", "Giza", 9, "38520910226014", "54501" },
                    { 10, "88 El Bahr St", "Minya", 10, "36883624519283", "56839" },
                    { 11, "197 Port Said St", "Qena", 11, "35752506203185", "81348" },
                    { 12, "197 El Corniche", "Tanta", 12, "39278722021054", "21390" },
                    { 13, "74 Ramsis St", "Cairo", 13, "38980167733610", "39815" },
                    { 14, "148 El Bahr St", "Alexandria", 14, "39825556582185", "55501" },
                    { 15, "192 Maadi Corniche", "Suez", 15, "37887632423326", "79436" },
                    { 16, "89 El Nil St", "Asyut", 16, "39667455554747", "11521" },
                    { 17, "104 El Galaa St", "Minya", 17, "29513750830367", "13144" },
                    { 18, "147 Ramsis St", "Zagazig", 18, "32154559408026", "59702" },
                    { 19, "22 Mohandiseen", "Asyut", 19, "31949582201783", "30827" },
                    { 20, "81 Port Said St", "Minya", 20, "22363048682914", "12819" },
                    { 21, "101 Maadi Corniche", "Kafr El-Sheikh", 21, "39824046426536", "44517" },
                    { 22, "58 El Nasr St", "Tanta", 22, "29353583382104", "94559" },
                    { 23, "31 El Bahr St", "Mansoura", 23, "25314077861030", "53993" },
                    { 24, "107 El Galaa St", "Tanta", 24, "38991544576385", "18250" },
                    { 25, "45 El Nil St", "Sohag", 25, "38463228130896", "62604" },
                    { 26, "159 El Azhar St", "Asyut", 26, "31397832644826", "17190" },
                    { 27, "102 El Moez St", "Minya", 27, "22735786081760", "73731" },
                    { 28, "60 Mohandiseen", "Beni Suef", 28, "27917248627705", "57516" },
                    { 29, "82 El Bahr St", "Asyut", 29, "29304930612185", "91080" },
                    { 30, "89 Salah Salem", "Zagazig", 30, "38731931567552", "66325" },
                    { 31, "32 El Bahr St", "Giza", 31, "33412105071366", "36965" },
                    { 32, "196 El Azhar St", "Alexandria", 32, "22136226778365", "10994" },
                    { 33, "15 El Corniche", "Luxor", 33, "23161775570285", "95359" },
                    { 34, "165 El Haram St", "Shibin El-Kom", 34, "29681179748093", "43406" },
                    { 35, "69 El Corniche", "Minya", 35, "34539484548892", "13345" },
                    { 36, "68 Ramsis St", "Kafr El-Sheikh", 36, "25705484333783", "71766" },
                    { 37, "31 Mohandiseen", "Aswan", 37, "36086221191616", "92451" },
                    { 38, "24 El Galaa St", "Shibin El-Kom", 38, "26383131335009", "84912" },
                    { 39, "154 El Nil St", "Port Said", 39, "27137165351891", "16345" },
                    { 40, "147 El Galaa St", "Port Said", 40, "39450358572723", "28678" },
                    { 41, "49 Mohandiseen", "Mansoura", 41, "27123006779859", "26067" },
                    { 42, "111 Port Said St", "Zagazig", 42, "39960004534547", "75336" },
                    { 43, "77 Salah Salem", "Aswan", 43, "26263011479086", "98219" },
                    { 44, "9 El Nil St", "Minya", 44, "29952074182208", "22147" },
                    { 45, "27 El Azhar St", "Tanta", 45, "23490864956029", "43844" },
                    { 46, "52 Mohandiseen", "Damanhour", 46, "22235390414463", "47168" },
                    { 47, "94 Salah Salem", "Beni Suef", 47, "22190885578646", "79997" },
                    { 48, "106 Maadi Corniche", "Port Said", 48, "36074952121565", "22252" },
                    { 49, "16 El Corniche", "Minya", 49, "32748006824795", "93411" },
                    { 50, "107 El Corniche", "Ismailia", 50, "27389245482479", "71595" },
                    { 51, "195 Salah Salem", "Fayoum", 51, "21071880515933", "41497" },
                    { 52, "112 El Haram St", "Luxor", 52, "26404274376017", "47568" },
                    { 53, "121 Maadi Corniche", "Kafr El-Sheikh", 53, "25819431802847", "94272" },
                    { 54, "167 El Moez St", "Beni Suef", 54, "39992106062339", "51400" },
                    { 55, "141 El Haram St", "Damanhour", 55, "27494993127770", "60278" },
                    { 56, "176 El Nasr St", "Mansoura", 56, "24902707769446", "29307" },
                    { 57, "171 El Obour Bldg", "Minya", 57, "23513141670636", "98475" },
                    { 58, "104 El Obour Bldg", "Kafr El-Sheikh", 58, "38813196681199", "39309" },
                    { 59, "71 El Bahr St", "Zagazig", 59, "33095999401425", "70580" },
                    { 60, "109 El Haram St", "Kafr El-Sheikh", 60, "31041462905156", "97034" },
                    { 61, "52 El Nil St", "Mansoura", 61, "39643729624785", "93470" },
                    { 62, "169 El Azhar St", "Kafr El-Sheikh", 62, "33043201658985", "14423" },
                    { 63, "189 El Obour Bldg", "Zagazig", 63, "38561090204750", "75568" },
                    { 64, "148 El Azhar St", "Qena", 64, "29823215299951", "50121" },
                    { 65, "143 El Nil St", "Kafr El-Sheikh", 65, "22844093650002", "59250" },
                    { 66, "138 El Azhar St", "Fayoum", 66, "32164607038344", "68734" },
                    { 67, "132 Port Said St", "Shibin El-Kom", 67, "38305069599704", "48761" },
                    { 68, "90 Port Said St", "Beni Suef", 68, "22433852838503", "62330" },
                    { 69, "94 El Bahr St", "Tanta", 69, "31572819721240", "24635" },
                    { 70, "6 El Corniche", "Cairo", 70, "32519365598042", "70497" },
                    { 71, "10 El Nil St", "Damanhour", 71, "37714506286094", "19987" },
                    { 72, "104 El Nasr St", "Ismailia", 72, "31550496499701", "39611" },
                    { 73, "70 Maadi Corniche", "Kafr El-Sheikh", 73, "29058542831081", "67712" },
                    { 74, "96 Salah Salem", "Mansoura", 74, "21906130523252", "57661" },
                    { 75, "169 El Nil St", "Fayoum", 75, "24206705013289", "63834" },
                    { 76, "177 El Bahr St", "Port Said", 76, "23710268388348", "41070" },
                    { 77, "197 El Nil St", "Cairo", 77, "27646229260367", "54235" },
                    { 78, "28 El Nasr St", "Giza", 78, "37885136313505", "53159" },
                    { 79, "93 El Bahr St", "Suez", 79, "32347286212794", "34359" },
                    { 80, "199 El Galaa St", "Ismailia", 80, "32171392412557", "11640" },
                    { 81, "191 El Galaa St", "Aswan", 81, "26873334334547", "80985" },
                    { 82, "86 El Galaa St", "Zagazig", 82, "23818995685139", "10179" },
                    { 83, "91 El Nasr St", "Fayoum", 83, "31643758231568", "66712" },
                    { 84, "115 Mohandiseen", "Zagazig", 84, "37037624956688", "52467" },
                    { 85, "58 Ramsis St", "Qena", 85, "39580204019853", "57584" },
                    { 86, "26 Maadi Corniche", "Cairo", 86, "39018881425336", "32060" },
                    { 87, "25 El Bahr St", "Kafr El-Sheikh", 87, "23008700436667", "93001" },
                    { 88, "191 El Galaa St", "Sohag", 88, "25407070454254", "45788" },
                    { 89, "87 El Nil St", "Minya", 89, "23679150482505", "13217" },
                    { 90, "144 El Moez St", "Beni Suef", 90, "35115186858397", "94714" },
                    { 91, "162 Port Said St", "Giza", 91, "21114296041814", "72127" },
                    { 92, "182 El Nasr St", "Mansoura", 92, "32385936849500", "22823" },
                    { 93, "172 El Nasr St", "Luxor", 93, "21585163978246", "22953" },
                    { 94, "161 El Nasr St", "Zagazig", 94, "39488917220738", "12186" },
                    { 95, "147 El Obour Bldg", "Port Said", 95, "24505663243711", "71505" },
                    { 96, "69 El Bahr St", "Qena", 96, "28505104932462", "16038" },
                    { 97, "195 Salah Salem", "Fayoum", 97, "24827664008540", "13491" },
                    { 98, "116 El Obour Bldg", "Tanta", 98, "38975149529807", "30922" },
                    { 99, "56 El Galaa St", "Cairo", 99, "36269596775837", "22420" },
                    { 100, "61 El Azhar St", "Mansoura", 100, "39187418226476", "91035" },
                    { 101, "99 El Nasr St", "Giza", 101, "23482857392957", "62143" },
                    { 102, "56 El Moez St", "Cairo", 102, "38366009377171", "49722" },
                    { 103, "126 Mohandiseen", "Zagazig", 103, "38653362634955", "98484" },
                    { 104, "156 El Moez St", "Ismailia", 104, "35526810733851", "34923" },
                    { 105, "128 El Haram St", "Ismailia", 105, "29713211327276", "37222" },
                    { 106, "105 El Nil St", "Beni Suef", 106, "38484782707411", "34084" },
                    { 107, "134 Ramsis St", "Luxor", 107, "28437660130451", "53181" },
                    { 108, "127 El Tahrir Sq", "Luxor", 108, "23636287415224", "64230" },
                    { 109, "104 El Bahr St", "Shibin El-Kom", 109, "25511585532953", "90626" },
                    { 110, "152 El Corniche", "Cairo", 110, "38274410451992", "93083" },
                    { 111, "116 El Haram St", "Minya", 111, "33193506859371", "39204" },
                    { 112, "10 El Nil St", "Cairo", 112, "29847832943254", "80185" },
                    { 113, "148 El Tahrir Sq", "Fayoum", 113, "36011477635391", "68157" },
                    { 114, "30 Port Said St", "Suez", 114, "39277242968576", "57869" },
                    { 115, "71 Ramsis St", "Beni Suef", 115, "37583166474525", "88068" },
                    { 116, "121 El Nil St", "Fayoum", 116, "32446397063864", "16434" },
                    { 117, "114 Ramsis St", "Aswan", 117, "37844977421024", "13641" },
                    { 118, "65 El Azhar St", "Sohag", 118, "26516255343765", "12897" },
                    { 119, "198 El Azhar St", "Minya", 119, "33340972805781", "51661" },
                    { 120, "11 El Nil St", "Sohag", 120, "33201419171452", "80654" }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "PlacedAt", "ShippedAt", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 24, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 41539.16m },
                    { 2, 84, new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 19765.21m },
                    { 3, 110, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 11849.99m },
                    { 4, 101, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 31824.65m },
                    { 5, 93, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 16869.77m },
                    { 6, 28, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 4955.39m },
                    { 7, 102, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 19380.65m },
                    { 8, 69, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 34025.07m },
                    { 9, 115, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 11141.17m },
                    { 10, 36, new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 23161.14m },
                    { 11, 56, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 2072.73m },
                    { 12, 52, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 32762.45m },
                    { 13, 74, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 45081.31m },
                    { 14, 71, new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 44783.9m },
                    { 15, 99, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 53037.9m },
                    { 16, 53, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 41682.32m },
                    { 17, 61, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 41144.71m },
                    { 18, 87, new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 43205.11m },
                    { 19, 100, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 18808.64m },
                    { 20, 91, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 10900.94m },
                    { 21, 32, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 2229.72m },
                    { 22, 115, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 30835.89m },
                    { 23, 7, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 47615.7m },
                    { 24, 80, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 53236.89m },
                    { 25, 84, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 27549.03m },
                    { 26, 13, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 46309.98m },
                    { 27, 89, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 7061.32m },
                    { 28, 112, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 28607.77m },
                    { 29, 96, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 37347.38m },
                    { 30, 57, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 23838.18m },
                    { 31, 7, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 5731.85m },
                    { 32, 63, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 9474.67m },
                    { 33, 21, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 19919.26m },
                    { 34, 25, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 45944.26m },
                    { 35, 28, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 8426.28m },
                    { 36, 45, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 50349.75m },
                    { 37, 120, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 48262.39m },
                    { 38, 20, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 33223.96m },
                    { 39, 42, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 40658.07m },
                    { 40, 5, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 41867.36m },
                    { 41, 38, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 35853.86m },
                    { 42, 59, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 50647.32m },
                    { 43, 7, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 45194.12m },
                    { 44, 21, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 51684.59m },
                    { 45, 69, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 43285.76m },
                    { 46, 54, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 21957.4m },
                    { 47, 82, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 47532.8m },
                    { 48, 29, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 50395.19m },
                    { 49, 6, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 26800.07m },
                    { 50, 80, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 5527.7m },
                    { 51, 104, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 8472.02m },
                    { 52, 86, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 14500.44m },
                    { 53, 20, new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 9235.17m },
                    { 54, 55, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 46652.48m },
                    { 55, 26, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 10348.12m },
                    { 56, 90, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 29702.75m },
                    { 57, 113, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 16146.5m },
                    { 58, 100, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 51694.4m },
                    { 59, 49, new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 14915.52m },
                    { 60, 2, new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 17187.07m },
                    { 61, 5, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 53989.13m },
                    { 62, 20, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 12949.68m },
                    { 63, 107, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 10714.46m },
                    { 64, 71, new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 45731.36m },
                    { 65, 111, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 50098.07m },
                    { 66, 107, new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 19228.76m },
                    { 67, 27, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 36687.49m },
                    { 68, 59, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 19410.03m },
                    { 69, 35, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 21989.66m },
                    { 70, 33, new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 10546.71m },
                    { 71, 23, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 8719m },
                    { 72, 61, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 21999.94m },
                    { 73, 43, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 24668.03m },
                    { 74, 112, new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 6106.41m },
                    { 75, 15, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 14230.92m },
                    { 76, 8, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 39420.47m },
                    { 77, 28, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 22573.54m },
                    { 78, 106, new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 21999.35m },
                    { 79, 104, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 33744.03m },
                    { 80, 32, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 6612.54m },
                    { 81, 75, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 14196.94m },
                    { 82, 75, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 504.61m },
                    { 83, 87, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 35840.6m },
                    { 84, 40, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 790.23m },
                    { 85, 116, new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 31002.95m },
                    { 86, 57, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 31270.13m },
                    { 87, 68, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 322.05m },
                    { 88, 1, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 48907.88m },
                    { 89, 111, new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 42661.22m },
                    { 90, 13, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 40252.13m },
                    { 91, 114, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 5715.56m },
                    { 92, 1, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 2701.05m },
                    { 93, 67, new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 51203.62m },
                    { 94, 115, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 54604.31m },
                    { 95, 72, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 23023.58m },
                    { 96, 75, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 40385.72m },
                    { 97, 27, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 32584.92m },
                    { 98, 86, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 20340.6m },
                    { 99, 112, new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 36380.66m },
                    { 100, 51, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 5519.69m },
                    { 101, 18, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 15158.69m },
                    { 102, 38, new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 10372.64m },
                    { 103, 82, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 17759.87m },
                    { 104, 13, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 8668.82m },
                    { 105, 85, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 35824.68m },
                    { 106, 99, new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 6579.92m },
                    { 107, 35, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 37119.94m },
                    { 108, 4, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 13386.78m },
                    { 109, 115, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 24365.75m },
                    { 110, 88, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 54156.09m },
                    { 111, 102, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 17792.08m },
                    { 112, 117, new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 48054.18m },
                    { 113, 99, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 25326.98m },
                    { 114, 78, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 18090.5m },
                    { 115, 79, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 49302.44m },
                    { 116, 103, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 21820.02m },
                    { 117, 7, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 20272.24m },
                    { 118, 30, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 36001.43m },
                    { 119, 25, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 39829.37m },
                    { 120, 47, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 36673.57m },
                    { 121, 26, new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 14238.9m },
                    { 122, 25, new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 28922.48m },
                    { 123, 91, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 9898.16m },
                    { 124, 50, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 39651.08m },
                    { 125, 45, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 43814.39m },
                    { 126, 96, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 46640.88m },
                    { 127, 69, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 296.3m },
                    { 128, 2, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 53595.5m },
                    { 129, 80, new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 27792.23m },
                    { 130, 62, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 3309.89m },
                    { 131, 39, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 25186.54m },
                    { 132, 38, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 33104.18m },
                    { 133, 109, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 11285.43m },
                    { 134, 26, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 13850.6m },
                    { 135, 60, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 42595.21m },
                    { 136, 37, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 40858.62m },
                    { 137, 74, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 35395.22m },
                    { 138, 31, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 52362.32m },
                    { 139, 62, new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 17744.5m },
                    { 140, 12, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", 15362.69m },
                    { 141, 41, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 9200.72m },
                    { 142, 92, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 44389m },
                    { 143, 5, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 4437.93m },
                    { 144, 58, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 7388.03m },
                    { 145, 76, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 47160.17m },
                    { 146, 43, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 30213.31m },
                    { 147, 8, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cancelled", 45429.6m },
                    { 148, 98, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pending", 41913.06m },
                    { 149, 10, new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Refunded", 50430.59m },
                    { 150, 45, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", 38640.3m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "IsActive", "Name", "Price", "SKU", "StockQuantity" },
                values: new object[,]
                {
                    { 84, 19, true, "Clean Code", 280m, "BOK-001", 100 },
                    { 85, 19, true, "The Pragmatic Programmer", 320m, "BOK-002", 80 },
                    { 86, 19, true, "Design Patterns GoF", 350m, "BOK-003", 75 },
                    { 87, 19, true, "You Dont Know JS", 220m, "BOK-004", 90 },
                    { 88, 19, true, "Domain-Driven Design", 380m, "BOK-005", 60 },
                    { 89, 19, true, "C# in Depth Jon Skeet", 420m, "BOK-006", 55 },
                    { 90, 20, true, "Football Size 5", 299m, "OUT-001", 80 },
                    { 91, 20, true, "Yoga Mat Premium", 349m, "OUT-002", 60 },
                    { 92, 20, true, "Dumbbell Set 20kg", 1200m, "OUT-003", 25 },
                    { 93, 20, true, "Resistance Bands Set", 199m, "OUT-004", 100 },
                    { 94, 20, true, "Cycling Helmet", 599m, "OUT-005", 40 },
                    { 95, 20, true, "Camping Tent 4-Person", 2500m, "OUT-006", 15 },
                    { 96, 20, true, "Trekking Poles", 450m, "OUT-007", 30 }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "OrderItems",
                columns: new[] { "OrderItemId", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 12, 72, 89, 1, 420m },
                    { 27, 13, 89, 5, 420m },
                    { 29, 110, 96, 3, 450m },
                    { 45, 113, 93, 5, 199m },
                    { 47, 24, 90, 5, 299m },
                    { 48, 137, 86, 5, 350m },
                    { 63, 39, 94, 3, 599m },
                    { 75, 30, 85, 4, 320m },
                    { 76, 58, 92, 4, 1200m },
                    { 93, 148, 95, 1, 2500m },
                    { 106, 52, 90, 3, 299m },
                    { 122, 19, 88, 5, 380m },
                    { 161, 61, 96, 1, 450m },
                    { 171, 48, 91, 2, 349m },
                    { 179, 141, 85, 3, 320m },
                    { 188, 15, 88, 3, 380m },
                    { 189, 43, 96, 4, 450m },
                    { 193, 100, 87, 3, 220m },
                    { 203, 83, 95, 2, 2500m },
                    { 204, 66, 88, 3, 380m },
                    { 211, 69, 89, 2, 420m },
                    { 218, 18, 96, 5, 450m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "Method", "OrderId", "PaidAt", "Status" },
                values: new object[,]
                {
                    { 1, 41539.16m, "Cash on Delivery", 1, null, "Paid" },
                    { 2, 19765.21m, "Debit Card", 2, null, "Pending" },
                    { 3, 11849.99m, "Debit Card", 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 4, 31824.65m, "Credit Card", 4, null, "Pending" },
                    { 5, 16869.77m, "Vodafone Cash", 5, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 6, 4955.39m, "Vodafone Cash", 6, null, "Pending" },
                    { 7, 19380.65m, "Vodafone Cash", 7, null, "Paid" },
                    { 8, 34025.07m, "Credit Card", 8, null, "Pending" },
                    { 9, 11141.17m, "Instapay", 9, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 10, 23161.14m, "Bank Transfer", 10, null, "Refunded" },
                    { 11, 2072.73m, "Debit Card", 11, null, "Pending" },
                    { 12, 32762.45m, "Bank Transfer", 12, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 13, 45081.31m, "Instapay", 13, new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 14, 44783.9m, "Cash on Delivery", 14, null, "Pending" },
                    { 15, 53037.9m, "Vodafone Cash", 15, null, "Paid" },
                    { 16, 41682.32m, "Instapay", 16, null, "Refunded" },
                    { 17, 41144.71m, "Cash on Delivery", 17, null, "Pending" },
                    { 18, 43205.11m, "Vodafone Cash", 18, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 19, 18808.64m, "Credit Card", 19, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 20, 10900.94m, "Vodafone Cash", 20, null, "Refunded" },
                    { 21, 2229.72m, "Bank Transfer", 21, new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 22, 30835.89m, "Credit Card", 22, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 23, 47615.7m, "Bank Transfer", 23, null, "Paid" },
                    { 24, 53236.89m, "Cash on Delivery", 24, null, "Pending" },
                    { 25, 27549.03m, "Bank Transfer", 25, null, "Pending" },
                    { 26, 46309.98m, "Debit Card", 26, null, "Paid" },
                    { 27, 7061.32m, "Credit Card", 27, null, "Pending" },
                    { 28, 28607.77m, "Bank Transfer", 28, null, "Pending" },
                    { 29, 37347.38m, "Cash on Delivery", 29, null, "Pending" },
                    { 30, 23838.18m, "Cash on Delivery", 30, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 31, 5731.85m, "Cash on Delivery", 31, null, "Pending" },
                    { 32, 9474.67m, "Vodafone Cash", 32, null, "Paid" },
                    { 33, 19919.26m, "Vodafone Cash", 33, null, "Pending" },
                    { 34, 45944.26m, "Bank Transfer", 34, null, "Pending" },
                    { 35, 8426.28m, "Instapay", 35, null, "Pending" },
                    { 36, 50349.75m, "Credit Card", 36, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 37, 48262.39m, "Instapay", 37, null, "Paid" },
                    { 38, 33223.96m, "Cash on Delivery", 38, null, "Refunded" },
                    { 39, 40658.07m, "Cash on Delivery", 39, null, "Pending" },
                    { 40, 41867.36m, "Vodafone Cash", 40, null, "Refunded" },
                    { 41, 35853.86m, "Vodafone Cash", 41, null, "Pending" },
                    { 42, 50647.32m, "Instapay", 42, null, "Pending" },
                    { 43, 45194.12m, "Credit Card", 43, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 44, 51684.59m, "Vodafone Cash", 44, null, "Pending" },
                    { 45, 43285.76m, "Instapay", 45, null, "Paid" },
                    { 46, 21957.4m, "Cash on Delivery", 46, null, "Pending" },
                    { 47, 47532.8m, "Cash on Delivery", 47, null, "Pending" },
                    { 48, 50395.19m, "Debit Card", 48, null, "Paid" },
                    { 49, 26800.07m, "Bank Transfer", 49, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 50, 5527.7m, "Debit Card", 50, null, "Pending" },
                    { 51, 8472.02m, "Vodafone Cash", 51, null, "Refunded" },
                    { 52, 14500.44m, "Bank Transfer", 52, null, "Paid" },
                    { 53, 9235.17m, "Cash on Delivery", 53, null, "Pending" },
                    { 54, 46652.48m, "Credit Card", 54, null, "Paid" },
                    { 55, 10348.12m, "Vodafone Cash", 55, null, "Pending" },
                    { 56, 29702.75m, "Bank Transfer", 56, null, "Pending" },
                    { 57, 16146.5m, "Vodafone Cash", 57, null, "Paid" },
                    { 58, 51694.4m, "Debit Card", 58, null, "Paid" },
                    { 59, 14915.52m, "Instapay", 59, null, "Refunded" },
                    { 60, 17187.07m, "Cash on Delivery", 60, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 61, 53989.13m, "Bank Transfer", 61, null, "Paid" },
                    { 62, 12949.68m, "Cash on Delivery", 62, null, "Refunded" },
                    { 63, 10714.46m, "Credit Card", 63, null, "Pending" },
                    { 64, 45731.36m, "Debit Card", 64, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 65, 50098.07m, "Cash on Delivery", 65, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 66, 19228.76m, "Debit Card", 66, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 67, 36687.49m, "Vodafone Cash", 67, null, "Paid" },
                    { 68, 19410.03m, "Instapay", 68, null, "Pending" },
                    { 69, 21989.66m, "Instapay", 69, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 70, 10546.71m, "Debit Card", 70, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 71, 8719m, "Cash on Delivery", 71, null, "Paid" },
                    { 72, 21999.94m, "Credit Card", 72, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 73, 24668.03m, "Vodafone Cash", 73, null, "Pending" },
                    { 74, 6106.41m, "Vodafone Cash", 74, null, "Pending" },
                    { 75, 14230.92m, "Debit Card", 75, null, "Refunded" },
                    { 76, 39420.47m, "Bank Transfer", 76, null, "Paid" },
                    { 77, 22573.54m, "Vodafone Cash", 77, new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 78, 21999.35m, "Cash on Delivery", 78, null, "Paid" },
                    { 79, 33744.03m, "Vodafone Cash", 79, null, "Paid" },
                    { 80, 6612.54m, "Vodafone Cash", 80, null, "Refunded" },
                    { 81, 14196.94m, "Credit Card", 81, null, "Pending" },
                    { 82, 504.61m, "Credit Card", 82, null, "Paid" },
                    { 83, 35840.6m, "Credit Card", 83, null, "Pending" },
                    { 84, 790.23m, "Vodafone Cash", 84, null, "Paid" },
                    { 85, 31002.95m, "Cash on Delivery", 85, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 86, 31270.13m, "Credit Card", 86, null, "Paid" },
                    { 87, 322.05m, "Instapay", 87, null, "Refunded" },
                    { 88, 48907.88m, "Cash on Delivery", 88, null, "Pending" },
                    { 89, 42661.22m, "Instapay", 89, null, "Pending" },
                    { 90, 40252.13m, "Debit Card", 90, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 91, 5715.56m, "Instapay", 91, null, "Pending" },
                    { 92, 2701.05m, "Instapay", 92, null, "Refunded" },
                    { 93, 51203.62m, "Bank Transfer", 93, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 94, 54604.31m, "Bank Transfer", 94, null, "Pending" },
                    { 95, 23023.58m, "Credit Card", 95, null, "Pending" },
                    { 96, 40385.72m, "Vodafone Cash", 96, null, "Pending" },
                    { 97, 32584.92m, "Debit Card", 97, null, "Pending" },
                    { 98, 20340.6m, "Bank Transfer", 98, null, "Pending" },
                    { 99, 36380.66m, "Cash on Delivery", 99, null, "Paid" },
                    { 100, 5519.69m, "Cash on Delivery", 100, null, "Pending" },
                    { 101, 15158.69m, "Credit Card", 101, new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 102, 10372.64m, "Credit Card", 102, null, "Pending" },
                    { 103, 17759.87m, "Vodafone Cash", 103, null, "Pending" },
                    { 104, 8668.82m, "Debit Card", 104, null, "Pending" },
                    { 105, 35824.68m, "Vodafone Cash", 105, null, "Paid" },
                    { 106, 6579.92m, "Credit Card", 106, null, "Pending" },
                    { 107, 37119.94m, "Vodafone Cash", 107, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 108, 13386.78m, "Credit Card", 108, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 109, 24365.75m, "Bank Transfer", 109, null, "Paid" },
                    { 110, 54156.09m, "Cash on Delivery", 110, null, "Paid" },
                    { 111, 17792.08m, "Instapay", 111, null, "Refunded" },
                    { 112, 48054.18m, "Bank Transfer", 112, null, "Paid" },
                    { 113, 25326.98m, "Instapay", 113, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 114, 18090.5m, "Debit Card", 114, null, "Paid" },
                    { 115, 49302.44m, "Vodafone Cash", 115, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 116, 21820.02m, "Bank Transfer", 116, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 117, 20272.24m, "Vodafone Cash", 117, null, "Refunded" },
                    { 118, 36001.43m, "Vodafone Cash", 118, null, "Paid" },
                    { 119, 39829.37m, "Cash on Delivery", 119, null, "Paid" },
                    { 120, 36673.57m, "Bank Transfer", 120, null, "Paid" },
                    { 121, 14238.9m, "Debit Card", 121, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 122, 28922.48m, "Cash on Delivery", 122, null, "Paid" },
                    { 123, 9898.16m, "Bank Transfer", 123, null, "Pending" },
                    { 124, 39651.08m, "Credit Card", 124, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 125, 43814.39m, "Instapay", 125, null, "Pending" },
                    { 126, 46640.88m, "Credit Card", 126, null, "Pending" },
                    { 127, 296.3m, "Instapay", 127, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 128, 53595.5m, "Bank Transfer", 128, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid" },
                    { 129, 27792.23m, "Bank Transfer", 129, null, "Paid" },
                    { 130, 3309.89m, "Instapay", 130, null, "Paid" }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { 84, 11 },
                    { 84, 20 },
                    { 85, 4 },
                    { 85, 7 },
                    { 85, 16 },
                    { 85, 18 },
                    { 87, 11 },
                    { 87, 16 },
                    { 87, 18 },
                    { 88, 7 },
                    { 89, 5 },
                    { 89, 12 },
                    { 90, 1 },
                    { 90, 20 },
                    { 91, 3 },
                    { 91, 4 },
                    { 93, 2 },
                    { 94, 3 },
                    { 96, 1 }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "IsActive", "Name", "Price", "SKU", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 2, true, "Samsung Galaxy A54", 8999.99m, "MOB-001", 50 },
                    { 2, 2, true, "iPhone 15 Pro", 32999m, "MOB-002", 15 },
                    { 3, 2, true, "Xiaomi Redmi Note 13", 5499m, "MOB-003", 80 },
                    { 4, 2, true, "OPPO Reno 10", 6799m, "MOB-004", 40 },
                    { 5, 2, true, "Huawei Nova 11", 7299m, "MOB-005", 30 },
                    { 6, 2, true, "Samsung Galaxy S24", 38999m, "MOB-006", 12 },
                    { 7, 2, true, "iPhone 14", 25999m, "MOB-007", 20 },
                    { 8, 2, true, "Google Pixel 8", 22999m, "MOB-008", 18 },
                    { 9, 2, true, "OnePlus 12", 19999m, "MOB-009", 25 },
                    { 10, 2, true, "Vivo V27", 7499m, "MOB-010", 35 },
                    { 11, 2, true, "Realme 11 Pro", 5999m, "MOB-011", 45 },
                    { 12, 2, true, "Infinix Note 30", 3999m, "MOB-012", 60 },
                    { 13, 3, true, "Dell Inspiron 15", 18500m, "LAP-001", 15 }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "SKU", "StockQuantity" },
                values: new object[] { 14, 3, "HP Pavilion 14", 15200m, "LAP-002", 0 });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "IsActive", "Name", "Price", "SKU", "StockQuantity" },
                values: new object[,]
                {
                    { 15, 3, true, "Lenovo IdeaPad 5", 16800m, "LAP-003", 22 },
                    { 16, 3, true, "Asus VivoBook 15", 14500m, "LAP-004", 18 },
                    { 17, 3, true, "Acer Aspire 5", 13200m, "LAP-005", 30 },
                    { 18, 3, true, "MacBook Air M2", 52000m, "LAP-006", 8 },
                    { 19, 3, true, "Dell XPS 13", 45000m, "LAP-007", 5 },
                    { 20, 3, true, "HP EliteBook 840", 38000m, "LAP-008", 10 },
                    { 21, 3, true, "Lenovo ThinkPad E14", 24000m, "LAP-009", 14 },
                    { 22, 3, true, "MSI Modern 14", 19500m, "LAP-010", 20 },
                    { 23, 3, true, "Huawei MateBook D15", 17800m, "LAP-011", 16 },
                    { 24, 4, true, "Samsung Galaxy Tab S9", 22000m, "TAB-001", 20 },
                    { 25, 4, true, "iPad 10th Gen", 19999m, "TAB-002", 15 },
                    { 26, 4, true, "Lenovo Tab P12", 12500m, "TAB-003", 25 },
                    { 27, 4, true, "Huawei MatePad 11", 10800m, "TAB-004", 30 },
                    { 28, 4, true, "Amazon Fire HD 10", 4200m, "TAB-005", 50 },
                    { 29, 5, true, "Sony WH-1000XM5", 12500m, "AUD-001", 30 },
                    { 30, 5, true, "AirPods Pro 2", 9999m, "AUD-002", 25 },
                    { 31, 5, true, "JBL Tune 760NC", 2999m, "AUD-003", 60 },
                    { 32, 5, true, "Bose QC45", 11500m, "AUD-004", 20 },
                    { 33, 5, true, "Samsung Galaxy Buds2", 2499m, "AUD-005", 70 },
                    { 34, 5, true, "Jabra Evolve2", 8500m, "AUD-006", 15 },
                    { 35, 6, true, "Sony ZV-E10", 18000m, "CAM-001", 12 },
                    { 36, 6, true, "Canon EOS M50", 22000m, "CAM-002", 8 },
                    { 37, 6, true, "Fujifilm X-T30", 28000m, "CAM-003", 5 },
                    { 38, 6, true, "GoPro HERO12", 15000m, "CAM-004", 18 },
                    { 39, 6, true, "DJI Osmo Pocket 3", 12500m, "CAM-005", 10 },
                    { 40, 7, true, "Apple Watch Series 9", 18000m, "SWT-001", 20 },
                    { 41, 7, true, "Samsung Galaxy Watch 6", 9500m, "SWT-002", 25 },
                    { 42, 7, true, "Huawei Watch GT 4", 7200m, "SWT-003", 30 },
                    { 43, 7, true, "Garmin Venu 3", 14000m, "SWT-004", 12 },
                    { 44, 8, true, "Samsung 55 4K QLED", 28000m, "TVD-001", 8 },
                    { 45, 8, true, "LG C3 OLED 55", 45000m, "TVD-002", 5 },
                    { 46, 8, true, "Sony Bravia XR 50", 32000m, "TVD-003", 7 },
                    { 47, 8, true, "Hisense 50 UHD", 12500m, "TVD-004", 20 },
                    { 48, 9, true, "PS5 Console", 25000m, "GAM-001", 6 },
                    { 49, 9, true, "Xbox Series X", 22000m, "GAM-002", 4 },
                    { 50, 9, true, "Nintendo Switch OLED", 13500m, "GAM-003", 15 },
                    { 51, 9, true, "Razer DeathAdder V3", 3200m, "GAM-004", 40 },
                    { 52, 9, true, "Logitech G502 X", 2800m, "GAM-005", 35 },
                    { 53, 9, true, "Corsair K95 Keyboard", 5500m, "GAM-006", 20 },
                    { 54, 10, true, "TP-Link Archer AX73", 3200m, "NET-001", 40 },
                    { 55, 10, true, "Netgear Nighthawk AX8", 5800m, "NET-002", 20 },
                    { 56, 10, true, "Huawei Router AX3", 1800m, "NET-003", 60 },
                    { 57, 10, true, "D-Link EXO AX3200", 2900m, "NET-004", 30 },
                    { 58, 12, true, "Classic White T-Shirt", 199m, "CLO-001", 300 },
                    { 59, 12, true, "Black Polo Shirt", 299m, "CLO-002", 200 },
                    { 60, 12, true, "Slim Fit Jeans", 599m, "CLO-003", 150 },
                    { 61, 12, true, "Formal Dress Shirt", 499m, "CLO-004", 120 },
                    { 62, 12, true, "Chino Trousers", 449m, "CLO-005", 180 },
                    { 63, 12, true, "Casual Hoodie", 399m, "CLO-006", 220 },
                    { 64, 13, true, "Floral Maxi Dress", 549m, "CLO-007", 130 },
                    { 65, 13, true, "Silk Blouse", 449m, "CLO-008", 140 },
                    { 66, 13, true, "Women Skinny Jeans", 499m, "CLO-009", 160 },
                    { 67, 13, true, "Evening Gown", 1299m, "CLO-010", 50 },
                    { 68, 14, true, "Kids Denim Jacket", 349m, "CLO-011", 100 },
                    { 69, 14, true, "Boys Cargo Pants", 249m, "CLO-012", 120 },
                    { 70, 14, true, "Girls Floral Dress", 299m, "CLO-013", 110 },
                    { 71, 15, true, "Nike Running Shoes", 1499m, "SPT-001", 80 },
                    { 72, 15, true, "Adidas Track Pants", 699m, "SPT-002", 90 },
                    { 73, 15, true, "Puma Sports T-Shirt", 349m, "SPT-003", 150 },
                    { 74, 15, true, "Under Armour Hoodie", 899m, "SPT-004", 70 },
                    { 75, 17, true, "IKEA KALLAX Shelf", 2800m, "FUR-001", 20 },
                    { 76, 17, true, "Office Chair Ergonomic", 3500m, "FUR-002", 15 },
                    { 77, 17, true, "Standing Desk", 5200m, "FUR-003", 10 },
                    { 78, 17, true, "Bedside Table Wooden", 1200m, "FUR-004", 30 },
                    { 79, 18, true, "Tefal Air Fryer", 2200m, "KIT-001", 40 },
                    { 80, 18, true, "Instant Pot Duo", 3100m, "KIT-002", 25 },
                    { 81, 18, true, "Philips Blender", 850m, "KIT-003", 55 },
                    { 82, 18, true, "Bosch Coffee Machine", 4500m, "KIT-004", 12 },
                    { 83, 18, true, "Nespresso Vertuo", 3800m, "KIT-005", 18 },
                    { 97, 2, true, "iPhone 15", 28999m, "MOB-013", 10 },
                    { 98, 2, true, "Samsung Galaxy A35", 7299m, "MOB-014", 55 },
                    { 99, 2, true, "Asus ROG Phone 7", 31999m, "MOB-015", 8 },
                    { 100, 2, true, "Lenovo Legion Phone", 27500m, "MOB-016", 6 },
                    { 101, 3, true, "MacBook Pro M3", 68000m, "LAP-012", 4 },
                    { 102, 3, true, "Dell G15 Gaming", 23500m, "LAP-013", 12 },
                    { 103, 3, true, "Asus TUF Gaming A15", 21000m, "LAP-014", 14 },
                    { 104, 3, true, "Acer Nitro 5", 19200m, "LAP-015", 18 },
                    { 105, 3, true, "HP Omen 16", 35000m, "LAP-016", 7 },
                    { 106, 3, true, "Lenovo Yoga 7i", 28000m, "LAP-017", 9 },
                    { 107, 4, true, "Samsung Galaxy Tab A9", 8500m, "TAB-006", 35 },
                    { 108, 4, true, "Xiaomi Pad 6", 9800m, "TAB-007", 28 },
                    { 109, 5, true, "Beats Studio Pro", 8900m, "AUD-007", 22 },
                    { 110, 5, true, "Sennheiser HD 450", 3200m, "AUD-008", 40 },
                    { 111, 5, true, "Anker Soundcore Q45", 1299m, "AUD-009", 80 },
                    { 112, 5, true, "Marshall Major IV", 2800m, "AUD-010", 35 },
                    { 113, 6, true, "Nikon Z30", 21000m, "CAM-006", 9 },
                    { 114, 6, true, "Sony A6400", 25000m, "CAM-007", 7 },
                    { 115, 7, true, "Xiaomi Mi Band 8", 1299m, "SWT-005", 90 },
                    { 116, 7, true, "Fitbit Versa 4", 5500m, "SWT-006", 25 }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "CreatedAt", "CustomerId", "ProductId", "Rating" },
                values: new object[,]
                {
                    { 15, "Solid build quality, no complaints.", new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 90, 4 },
                    { 19, "Works perfectly out of the box.", new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, 91, 1 },
                    { 33, "Average quality, expected better.", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 96, 5 },
                    { 38, "Could be improved, but usable.", new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 86, 4 },
                    { 47, "Budget option that performs well.", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 89, 3 },
                    { 48, "Perfect for daily use.", new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 92, 1 },
                    { 70, "Fantastic for students on a budget.", new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 90, 4 },
                    { 74, "Arrived on time, well packaged.", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 96, 5 },
                    { 99, "Great gift idea, recipient loved it.", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 96, 1 },
                    { 103, "Good value for money.", new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 93, 3 }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "OrderItems",
                columns: new[] { "OrderItemId", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 56, 58, 4, 199m },
                    { 2, 15, 56, 5, 1800m },
                    { 3, 93, 105, 3, 35000m },
                    { 4, 94, 107, 4, 8500m },
                    { 5, 146, 1, 1, 8999.99m },
                    { 6, 45, 1, 5, 8999.99m },
                    { 7, 122, 51, 5, 3200m },
                    { 8, 88, 43, 1, 14000m },
                    { 9, 18, 107, 2, 8500m },
                    { 10, 28, 101, 4, 68000m },
                    { 11, 64, 19, 1, 45000m },
                    { 13, 41, 113, 1, 21000m },
                    { 14, 27, 46, 1, 32000m },
                    { 15, 10, 20, 3, 38000m },
                    { 16, 57, 45, 5, 45000m },
                    { 17, 35, 9, 2, 19999m },
                    { 18, 62, 70, 5, 299m },
                    { 19, 60, 11, 4, 5999m },
                    { 20, 131, 59, 5, 299m },
                    { 21, 96, 63, 5, 399m },
                    { 22, 57, 43, 5, 14000m },
                    { 23, 31, 41, 3, 9500m },
                    { 24, 133, 110, 5, 3200m },
                    { 25, 132, 29, 3, 12500m },
                    { 26, 30, 69, 1, 249m },
                    { 28, 79, 18, 3, 52000m },
                    { 30, 39, 32, 1, 11500m },
                    { 31, 96, 33, 5, 2499m },
                    { 32, 28, 9, 3, 19999m },
                    { 33, 134, 37, 3, 28000m },
                    { 34, 66, 36, 1, 22000m },
                    { 35, 113, 9, 3, 19999m },
                    { 36, 148, 3, 1, 5499m },
                    { 37, 88, 49, 1, 22000m },
                    { 38, 26, 39, 3, 12500m },
                    { 39, 144, 56, 1, 1800m },
                    { 40, 52, 8, 3, 22999m },
                    { 41, 49, 81, 2, 850m },
                    { 42, 49, 105, 5, 35000m },
                    { 43, 57, 18, 2, 52000m },
                    { 44, 33, 44, 3, 28000m },
                    { 46, 95, 12, 4, 3999m },
                    { 49, 17, 60, 4, 599m },
                    { 50, 39, 25, 2, 19999m },
                    { 51, 124, 98, 1, 7299m },
                    { 52, 61, 36, 5, 22000m },
                    { 53, 7, 40, 5, 18000m },
                    { 54, 7, 82, 4, 4500m },
                    { 55, 28, 56, 3, 1800m },
                    { 56, 30, 110, 2, 3200m },
                    { 57, 146, 36, 3, 22000m },
                    { 58, 59, 15, 4, 16800m },
                    { 59, 86, 43, 1, 14000m },
                    { 60, 7, 6, 5, 38999m },
                    { 61, 128, 100, 3, 27500m },
                    { 62, 103, 105, 1, 35000m },
                    { 64, 59, 72, 1, 699m },
                    { 65, 135, 54, 3, 3200m },
                    { 66, 89, 78, 2, 1200m },
                    { 67, 6, 68, 1, 349m },
                    { 68, 34, 29, 2, 12500m },
                    { 69, 134, 81, 4, 850m },
                    { 70, 48, 39, 5, 12500m },
                    { 71, 122, 15, 1, 16800m },
                    { 72, 69, 36, 4, 22000m },
                    { 73, 78, 65, 5, 449m },
                    { 74, 92, 81, 2, 850m },
                    { 77, 5, 107, 1, 8500m },
                    { 78, 57, 19, 4, 45000m },
                    { 79, 115, 9, 2, 19999m },
                    { 80, 49, 44, 1, 28000m },
                    { 81, 85, 40, 2, 18000m },
                    { 82, 133, 79, 2, 2200m },
                    { 83, 89, 75, 5, 2800m },
                    { 84, 81, 83, 2, 3800m },
                    { 85, 40, 106, 4, 28000m },
                    { 86, 120, 5, 4, 7299m },
                    { 87, 46, 47, 2, 12500m },
                    { 88, 84, 61, 4, 499m },
                    { 89, 44, 69, 2, 249m },
                    { 90, 71, 113, 1, 21000m },
                    { 91, 145, 16, 3, 14500m },
                    { 92, 129, 57, 5, 2900m },
                    { 94, 130, 20, 2, 38000m },
                    { 95, 7, 31, 1, 2999m },
                    { 96, 39, 47, 5, 12500m },
                    { 97, 109, 36, 2, 22000m },
                    { 98, 69, 81, 5, 850m },
                    { 99, 78, 67, 2, 1299m },
                    { 100, 102, 17, 1, 13200m },
                    { 101, 109, 5, 2, 7299m },
                    { 102, 49, 72, 5, 699m },
                    { 103, 63, 52, 1, 2800m },
                    { 104, 52, 97, 1, 28999m },
                    { 105, 27, 20, 1, 38000m },
                    { 107, 124, 43, 5, 14000m },
                    { 108, 99, 15, 1, 16800m },
                    { 109, 98, 111, 2, 1299m },
                    { 110, 147, 43, 5, 14000m },
                    { 111, 96, 16, 3, 14500m },
                    { 112, 95, 31, 4, 2999m },
                    { 113, 130, 61, 5, 499m },
                    { 114, 119, 61, 3, 499m },
                    { 115, 38, 69, 5, 249m },
                    { 116, 128, 12, 2, 3999m },
                    { 117, 59, 4, 1, 6799m },
                    { 118, 107, 34, 2, 8500m },
                    { 119, 96, 43, 4, 14000m },
                    { 120, 52, 75, 2, 2800m },
                    { 121, 30, 71, 5, 1499m },
                    { 123, 68, 99, 2, 31999m },
                    { 124, 18, 5, 1, 7299m },
                    { 125, 18, 60, 2, 599m },
                    { 126, 83, 32, 1, 11500m },
                    { 127, 28, 48, 5, 25000m },
                    { 128, 48, 24, 5, 22000m },
                    { 129, 111, 22, 3, 19500m },
                    { 130, 58, 41, 2, 9500m },
                    { 131, 113, 1, 5, 8999.99m },
                    { 132, 110, 21, 4, 24000m },
                    { 133, 136, 50, 2, 13500m },
                    { 134, 108, 105, 3, 35000m },
                    { 135, 72, 107, 2, 8500m },
                    { 136, 139, 41, 4, 9500m },
                    { 137, 26, 32, 5, 11500m },
                    { 138, 120, 56, 3, 1800m },
                    { 139, 81, 44, 3, 28000m },
                    { 140, 144, 27, 1, 10800m },
                    { 141, 56, 26, 1, 12500m },
                    { 142, 127, 66, 2, 499m },
                    { 143, 81, 39, 3, 12500m },
                    { 144, 27, 72, 1, 699m },
                    { 145, 28, 78, 2, 1200m },
                    { 146, 34, 23, 3, 17800m },
                    { 147, 33, 101, 4, 68000m },
                    { 148, 146, 74, 2, 899m },
                    { 149, 110, 22, 3, 19500m },
                    { 150, 102, 109, 2, 8900m },
                    { 151, 29, 60, 2, 599m },
                    { 152, 81, 18, 1, 52000m },
                    { 153, 15, 4, 5, 6799m },
                    { 154, 12, 104, 2, 19200m },
                    { 155, 97, 11, 1, 5999m },
                    { 156, 40, 57, 4, 2900m },
                    { 157, 46, 111, 1, 1299m },
                    { 158, 150, 51, 1, 3200m },
                    { 159, 16, 43, 1, 14000m },
                    { 160, 95, 52, 4, 2800m },
                    { 162, 103, 33, 2, 2499m },
                    { 163, 149, 70, 1, 299m },
                    { 164, 96, 106, 3, 28000m },
                    { 165, 102, 112, 5, 2800m },
                    { 166, 38, 109, 3, 8900m },
                    { 167, 25, 20, 2, 38000m },
                    { 168, 99, 41, 1, 9500m },
                    { 169, 125, 99, 1, 31999m },
                    { 170, 58, 102, 5, 23500m },
                    { 172, 42, 71, 2, 1499m },
                    { 173, 135, 70, 1, 299m },
                    { 174, 45, 83, 2, 3800m },
                    { 175, 102, 49, 2, 22000m },
                    { 176, 135, 29, 4, 12500m },
                    { 177, 13, 11, 3, 5999m },
                    { 178, 94, 78, 3, 1200m },
                    { 180, 148, 66, 1, 499m },
                    { 181, 109, 70, 5, 299m },
                    { 182, 11, 64, 1, 549m },
                    { 183, 78, 68, 1, 349m },
                    { 184, 70, 16, 3, 14500m },
                    { 185, 9, 15, 4, 16800m },
                    { 186, 134, 31, 2, 2999m },
                    { 187, 25, 116, 4, 5500m },
                    { 190, 90, 7, 1, 25999m },
                    { 191, 59, 20, 4, 38000m },
                    { 192, 114, 114, 5, 25000m },
                    { 194, 118, 104, 4, 19200m },
                    { 195, 142, 9, 1, 19999m },
                    { 196, 3, 77, 2, 5200m },
                    { 197, 101, 24, 3, 22000m },
                    { 198, 112, 46, 2, 32000m },
                    { 199, 61, 80, 5, 3100m },
                    { 200, 18, 13, 4, 18500m },
                    { 201, 113, 19, 2, 45000m },
                    { 202, 15, 37, 1, 28000m },
                    { 205, 77, 74, 1, 899m },
                    { 206, 134, 74, 2, 899m },
                    { 207, 133, 16, 2, 14500m },
                    { 208, 30, 39, 5, 12500m },
                    { 209, 62, 69, 2, 249m },
                    { 210, 7, 12, 4, 3999m },
                    { 212, 23, 70, 3, 299m },
                    { 213, 121, 105, 5, 35000m },
                    { 214, 99, 45, 2, 45000m },
                    { 215, 112, 18, 1, 52000m },
                    { 216, 113, 42, 3, 7200m },
                    { 217, 104, 62, 4, 449m },
                    { 219, 129, 110, 5, 3200m },
                    { 220, 136, 52, 5, 2800m }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { 2, 10 },
                    { 2, 15 },
                    { 2, 18 },
                    { 4, 1 },
                    { 5, 18 },
                    { 6, 4 },
                    { 8, 4 },
                    { 8, 15 },
                    { 9, 12 },
                    { 10, 4 },
                    { 12, 9 },
                    { 12, 14 },
                    { 14, 3 },
                    { 14, 14 },
                    { 15, 16 },
                    { 16, 9 },
                    { 17, 1 },
                    { 17, 15 },
                    { 18, 11 },
                    { 18, 17 },
                    { 19, 15 },
                    { 21, 2 },
                    { 23, 2 },
                    { 24, 9 },
                    { 25, 11 },
                    { 25, 18 },
                    { 25, 19 },
                    { 27, 15 },
                    { 29, 4 },
                    { 29, 10 },
                    { 30, 11 },
                    { 32, 3 },
                    { 32, 8 },
                    { 34, 16 },
                    { 34, 18 },
                    { 36, 1 },
                    { 36, 3 },
                    { 36, 20 },
                    { 37, 8 },
                    { 37, 9 },
                    { 37, 20 },
                    { 38, 3 },
                    { 38, 13 },
                    { 38, 20 },
                    { 39, 17 },
                    { 40, 6 },
                    { 41, 5 },
                    { 41, 6 },
                    { 41, 7 },
                    { 42, 7 },
                    { 42, 12 },
                    { 42, 14 },
                    { 42, 16 },
                    { 45, 18 },
                    { 46, 10 },
                    { 46, 11 },
                    { 47, 5 },
                    { 47, 17 },
                    { 47, 18 },
                    { 48, 1 },
                    { 49, 20 },
                    { 50, 2 },
                    { 50, 11 },
                    { 50, 14 },
                    { 51, 10 },
                    { 51, 16 },
                    { 52, 6 },
                    { 53, 14 },
                    { 55, 3 },
                    { 55, 4 },
                    { 55, 16 },
                    { 55, 19 },
                    { 56, 20 },
                    { 58, 7 },
                    { 58, 13 },
                    { 58, 19 },
                    { 59, 3 },
                    { 59, 12 },
                    { 60, 2 },
                    { 61, 14 },
                    { 61, 15 },
                    { 62, 6 },
                    { 63, 5 },
                    { 63, 8 },
                    { 66, 7 },
                    { 66, 9 },
                    { 67, 3 },
                    { 67, 12 },
                    { 68, 6 },
                    { 70, 3 },
                    { 70, 18 },
                    { 71, 6 },
                    { 72, 7 },
                    { 72, 9 },
                    { 72, 18 },
                    { 73, 12 },
                    { 73, 13 },
                    { 73, 17 },
                    { 74, 8 },
                    { 74, 19 },
                    { 74, 20 },
                    { 75, 2 },
                    { 75, 3 },
                    { 75, 10 },
                    { 81, 10 },
                    { 81, 16 },
                    { 82, 10 },
                    { 83, 8 },
                    { 83, 9 },
                    { 83, 11 },
                    { 83, 15 },
                    { 97, 2 },
                    { 99, 1 },
                    { 99, 3 },
                    { 99, 9 },
                    { 99, 20 },
                    { 100, 9 },
                    { 101, 6 },
                    { 101, 18 },
                    { 102, 13 },
                    { 103, 13 },
                    { 103, 14 },
                    { 104, 12 },
                    { 104, 14 },
                    { 106, 3 },
                    { 107, 11 },
                    { 108, 7 },
                    { 108, 15 },
                    { 108, 17 },
                    { 110, 1 },
                    { 110, 2 },
                    { 110, 3 },
                    { 110, 14 },
                    { 112, 13 },
                    { 112, 20 },
                    { 113, 2 },
                    { 113, 11 },
                    { 113, 17 },
                    { 114, 15 },
                    { 115, 2 },
                    { 116, 7 }
                });

            migrationBuilder.InsertData(
                schema: "shop",
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "CreatedAt", "CustomerId", "ProductId", "Rating" },
                values: new object[,]
                {
                    { 1, "Very good quality for the price.", new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 117, 39, 4 },
                    { 2, "Exactly as described, very happy.", new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, 111, 4 },
                    { 3, "Good value for money.", new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 76, 4 },
                    { 4, "Budget option that performs well.", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 110, 5 },
                    { 5, "Could be improved, but usable.", new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 15, 4 },
                    { 6, "Arrived on time, well packaged.", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 53, 1 },
                    { 7, "A bit disappointing honestly.", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 111, 81, 1 },
                    { 8, "Works perfectly out of the box.", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 47, 5 },
                    { 9, "Amazing product, will buy again.", new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 101, 2 },
                    { 10, "Product is okay, nothing special.", new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 26, 2 },
                    { 11, "Works perfectly out of the box.", new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 107, 3 },
                    { 12, "Ideal for office work.", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 21, 4 },
                    { 13, "Exactly as described, very happy.", new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 27, 4 },
                    { 14, "Fantastic for students on a budget.", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 67, 5 },
                    { 16, "Perfect for daily use.", new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 10, 2 },
                    { 17, "Exactly as described, very happy.", new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 114, 1 },
                    { 18, "Decent quality but a bit pricey.", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 34, 4 },
                    { 20, "Good value for money.", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 5, 5 },
                    { 21, "Premium feel, very satisfied.", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, 1 },
                    { 22, "Great gift idea, recipient loved it.", new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 20, 4 },
                    { 23, "Ideal for office work.", new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 99, 4 },
                    { 24, "Premium feel, very satisfied.", new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 31, 4 },
                    { 25, "Would not recommend this product.", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 19, 4 },
                    { 26, "Average quality, expected better.", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 69, 1 },
                    { 27, "Ideal for office work.", new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 59, 3 },
                    { 28, "Premium feel, very satisfied.", new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 13, 4 },
                    { 29, "Very good quality for the price.", new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 26, 1 },
                    { 30, "Would not recommend this product.", new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 76, 3 },
                    { 31, "Excellent product, highly recommend!", new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 82, 3 },
                    { 32, "Exactly as described, very happy.", new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 3, 2 },
                    { 34, "Budget option that performs well.", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, 2 },
                    { 35, "Very good quality for the price.", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 13, 3 },
                    { 36, "Excellent product, highly recommend!", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, 97, 2 },
                    { 37, "Better than expected, love it.", new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 102, 5 },
                    { 39, "Fast shipping, great item.", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 13, 3 },
                    { 40, "Poor quality, not worth it.", new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 101, 3 },
                    { 41, "Could be improved, but usable.", new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, 113, 1 },
                    { 42, "Very good quality for the price.", new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 18, 3 },
                    { 43, "Works perfectly out of the box.", new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 8, 3 },
                    { 44, "Not as described, quite different.", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 38, 5 },
                    { 45, "Great gift idea, recipient loved it.", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 12, 4 },
                    { 46, "Not bad, does the job.", new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 115, 5 },
                    { 49, "Fantastic for students on a budget.", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 106, 1 },
                    { 50, "Arrived on time, well packaged.", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 46, 3 },
                    { 51, "Decent quality but a bit pricey.", new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, 48, 1 },
                    { 52, "Budget option that performs well.", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 116, 3, 5 },
                    { 53, "Solid build quality, no complaints.", new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 70, 3 },
                    { 54, "Average quality, expected better.", new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 62, 2 },
                    { 55, "Arrived on time, well packaged.", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 113, 49, 5 },
                    { 56, "A bit disappointing honestly.", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 6, 2 },
                    { 57, "Would not recommend this product.", new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 8, 5 },
                    { 58, "Fast shipping, great item.", new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 116, 37, 5 },
                    { 59, "Poor quality, not worth it.", new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 119, 20, 3 },
                    { 60, "Fantastic for students on a budget.", new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, 78, 3 },
                    { 61, "Excellent product, highly recommend!", new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 98, 1 },
                    { 62, "Arrived on time, well packaged.", new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 2, 4 },
                    { 63, "Ideal for office work.", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 53, 3 },
                    { 64, "Good but delivery was slow.", new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 60, 3 },
                    { 65, "Exactly as described, very happy.", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 73, 1 },
                    { 66, "Packaging was damaged but item fine.", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 82, 2 },
                    { 67, "A bit disappointing honestly.", new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 79, 2 },
                    { 68, "Fast shipping, great item.", new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 48, 2 },
                    { 69, "Not bad, does the job.", new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 23, 4 },
                    { 71, "Not bad, does the job.", new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 49, 4 },
                    { 72, "Average quality, expected better.", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 104, 4 },
                    { 73, "Budget option that performs well.", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 114, 2 },
                    { 75, "Premium feel, very satisfied.", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, 78, 5 },
                    { 76, "Budget option that performs well.", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 110, 2 },
                    { 77, "Fast shipping, great item.", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 102, 3 },
                    { 78, "Solid build quality, no complaints.", new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 23, 5 },
                    { 79, "A bit disappointing honestly.", new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 112, 3 },
                    { 80, "Packaging was damaged but item fine.", new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 43, 2 },
                    { 81, "Product is okay, nothing special.", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 114, 106, 4 },
                    { 82, "Ideal for office work.", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 76, 3 },
                    { 83, "Better than expected, love it.", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 17, 1 },
                    { 84, "Could be improved, but usable.", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 5, 5 },
                    { 85, "Solid build quality, no complaints.", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 3, 1 },
                    { 86, "Not as described, quite different.", new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, 105, 5 },
                    { 87, "Works perfectly out of the box.", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, 33, 1 },
                    { 88, "A bit disappointing honestly.", new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 2, 5 },
                    { 89, "Would not recommend this product.", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 37, 2 },
                    { 90, "Premium feel, very satisfied.", new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 53, 3 },
                    { 91, "Better than expected, love it.", new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 61, 5 },
                    { 92, "Arrived on time, well packaged.", new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 31, 5 },
                    { 93, "Good but delivery was slow.", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 72, 2 },
                    { 94, "Would not recommend this product.", new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 59, 3 },
                    { 95, "Great gift idea, recipient loved it.", new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 19, 2 },
                    { 96, "Amazing product, will buy again.", new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 43, 4 },
                    { 97, "Arrived on time, well packaged.", new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 81, 2 },
                    { 98, "Good value for money.", new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 65, 5 },
                    { 100, "Good value for money.", new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 111, 100, 5 },
                    { 101, "Better than expected, love it.", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 62, 2 },
                    { 102, "Not bad, does the job.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 65, 4 },
                    { 104, "Could be improved, but usable.", new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, 23, 2 },
                    { 105, "Arrived on time, well packaged.", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 78, 4 },
                    { 106, "Solid build quality, no complaints.", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 77, 4 },
                    { 107, "Product is okay, nothing special.", new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 45, 1 },
                    { 108, "Great gift idea, recipient loved it.", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 34, 5 },
                    { 109, "Not bad, does the job.", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 50, 2 },
                    { 110, "Could be improved, but usable.", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20, 4 },
                    { 111, "Fast shipping, great item.", new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 20, 3 },
                    { 112, "Average quality, expected better.", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 13, 5 },
                    { 113, "Amazing product, will buy again.", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 113, 3 },
                    { 114, "Would not recommend this product.", new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 25, 1 },
                    { 115, "Good but delivery was slow.", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 26, 2 },
                    { 116, "Product is okay, nothing special.", new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 103, 5 },
                    { 117, "Premium feel, very satisfied.", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 8, 1 },
                    { 118, "Not bad, does the job.", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 17, 4 },
                    { 119, "Fast shipping, great item.", new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 115, 2 },
                    { 120, "Packaging was damaged but item fine.", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, 14, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "CustomerProfiles",
                keyColumn: "CustomerProfileId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 17, 15 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 18, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 18, 17 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 19, 15 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 24, 9 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 25, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 25, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 25, 19 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 27, 15 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 30, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 32, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 32, 8 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 34, 16 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 34, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 36, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 36, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 37, 8 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 37, 9 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 37, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 38, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 38, 13 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 38, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 39, 17 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 40, 6 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 41, 5 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 41, 6 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 41, 7 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 42, 7 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 42, 12 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 42, 14 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 42, 16 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 45, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 46, 10 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 46, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 47, 5 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 47, 17 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 47, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 49, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 50, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 50, 14 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 51, 10 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 51, 16 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 52, 6 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 53, 14 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 55, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 55, 4 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 55, 16 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 55, 19 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 56, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 58, 7 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 58, 13 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 58, 19 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 59, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 59, 12 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 61, 14 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 61, 15 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 62, 6 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 63, 5 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 63, 8 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 66, 7 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 66, 9 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 67, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 67, 12 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 68, 6 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 70, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 70, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 71, 6 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 72, 7 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 72, 9 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 72, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 73, 12 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 73, 13 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 73, 17 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 74, 8 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 74, 19 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 74, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 75, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 75, 10 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 81, 10 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 81, 16 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 82, 10 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 83, 8 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 83, 9 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 83, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 83, 15 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 84, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 84, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 85, 4 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 85, 7 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 85, 16 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 85, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 87, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 87, 16 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 87, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 88, 7 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 89, 5 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 89, 12 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 90, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 91, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 91, 4 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 93, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 94, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 99, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 99, 9 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 99, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 100, 9 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 101, 6 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 101, 18 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 102, 13 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 103, 13 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 103, 14 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 104, 12 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 104, 14 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 106, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 107, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 108, 7 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 108, 15 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 108, 17 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 110, 1 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 110, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 110, 3 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 110, 14 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 112, 13 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 112, 20 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 113, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 113, 11 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 113, 17 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 114, 15 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 115, 2 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 116, 7 });

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "shop",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16);
        }
    }
}
