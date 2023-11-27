using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class updatedManufactures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacture",
                column: "manufacturerName",
                values: new object[]
                {
                    "Abart",
                    "Acura",
                    "Aiways",
                    "Alfa romeo",
                    "Alpine",
                    "Aston martin",
                    "Audi",
                    "Bentley",
                    "BYD",
                    "Cherry",
                    "Chevrolet",
                    "Chrysler",
                    "Citroen",
                    "Cupra",
                    "Dachia",
                    "Daihatsu",
                    "Dodge",
                    "DS",
                    "Eveasy",
                    "Ferari",
                    "Fiat",
                    "Ford",
                    "GAC",
                    "Geely",
                    "Genesis",
                    "Great wall",
                    "Honda",
                    "Hongqi",
                    "Hyundai",
                    "Infinity",
                    "Isuzu",
                    "Iveco",
                    "JAC",
                    "Jaguar",
                    "Jeep",
                    "Kadilac",
                    "Kia",
                    "Lanchia",
                    "Land rover",
                    "Leap motor",
                    "LEVC",
                    "Lexus",
                    "Lynk & Co",
                    "Maan",
                    "Maserati",
                    "Maxus",
                    "Mercedes",
                    "MG",
                    "Mini",
                    "Mitsubishi",
                    "Nio",
                    "Nissan",
                    "Opel",
                    "Ora",
                    "Peugeot",
                    "Polstar",
                    "Porche",
                    "Ram",
                    "Renault",
                    "Saang young",
                    "Seat",
                    "SERES",
                    "Skoda",
                    "SKYWALL",
                    "Smart",
                    "Subaru",
                    "Suzuki",
                    "Tesla",
                    "Volkswagen",
                    "Volvo",
                    "Voyah",
                    "Wey"
                });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Abart", "124" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Abart", "500" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Abart", "595" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Audi", "a1" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Audi", "a3" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Audi", "a4" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Audi", "a5" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Audi", "a6" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Audi", "a7" });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "manufacturerName", "model" },
                values: new object[,]
                {
                    { 10, "Audi", "s1" },
                    { 11, "Audi", "s3" },
                    { 12, "Audi", "s3 sedan" },
                    { 13, "Audi", "s4" },
                    { 14, "Audi", "s5" },
                    { 15, "Audi", "s6" },
                    { 16, "Audi", "s7" },
                    { 17, "Audi", "RS3" },
                    { 18, "Audi", "RS4" },
                    { 19, "Audi", "RS5" },
                    { 20, "Audi", "RS6" },
                    { 21, "Audi", "RS7" },
                    { 22, "Audi", "R8" },
                    { 23, "Audi", "Q2" },
                    { 24, "Audi", "Q3" },
                    { 25, "Audi", "Q3 Sportback" },
                    { 26, "Audi", "Q4 e-tron" },
                    { 27, "Audi", "Q4 e-tron sportback" },
                    { 28, "Audi", "Q5" },
                    { 29, "Audi", "Q5 Sportback" },
                    { 30, "Audi", "Q7" },
                    { 31, "Audi", "Q8" },
                    { 32, "Audi", "Q8 e-tron" },
                    { 33, "Audi", "Q8 e-tron sportback" },
                    { 34, "Audi", "TT" },
                    { 35, "Opel", "adam" },
                    { 36, "Opel", "insignia" },
                    { 37, "Opel", "astra" },
                    { 38, "Opel", "astra-berlina" },
                    { 39, "Opel", "grand land x" },
                    { 40, "Opel", "vivaro" },
                    { 41, "Opel", "zafira" },
                    { 42, "Opel", "moka" },
                    { 43, "Opel", "tigra" },
                    { 44, "Opel", "meriva" },
                    { 45, "Opel", "frontara" },
                    { 46, "Opel", "combo" },
                    { 47, "Opel", "corsa" },
                    { 48, "Opel", "cascada" },
                    { 49, "Opel", "crossland" },
                    { 50, "Opel", "crossland x" },
                    { 51, "Ora", "funky cat" },
                    { 52, "Iveco", "daily" },
                    { 53, "Infinity", "EX" },
                    { 54, "Infinity", "FX" },
                    { 55, "Infinity", "Q30" },
                    { 56, "Infinity", "Q50" },
                    { 57, "Infinity", "Q60" },
                    { 58, "Infinity", "Q70" },
                    { 59, "Infinity", "QX30" },
                    { 60, "Infinity", "QX50" },
                    { 61, "Infinity", "QX55" },
                    { 62, "Infinity", "QX60" },
                    { 63, "Infinity", "QX70" },
                    { 64, "Isuzu", "dmax" },
                    { 65, "Alfa romeo", "4C" },
                    { 66, "Alfa romeo", "Giulia" },
                    { 67, "Alfa romeo", "159" },
                    { 68, "Alfa romeo", "tonala" },
                    { 69, "Alfa romeo", "mito" },
                    { 70, "Alfa romeo", "stervio" },
                    { 71, "Alfa romeo", "gulieta" },
                    { 72, "Alpine", "A110" },
                    { 73, "Aston martin", "DB11" },
                    { 74, "Aston martin", "DB9" },
                    { 75, "Aston martin", "DBX" },
                    { 76, "Aston martin", "vanquish" },
                    { 77, "Aston martin", "ventage" },
                    { 78, "Aston martin", "rapid s" },
                    { 79, "Acura", "MDX" },
                    { 80, "B.M.W", "i3" },
                    { 81, "B.M.W", "i4" },
                    { 82, "B.M.W", "i8" },
                    { 83, "B.M.W", "i7" },
                    { 84, "B.M.W", "ix" },
                    { 85, "B.M.W", "ix1" },
                    { 86, "B.M.W", "ix3" },
                    { 87, "B.M.W", "m2" },
                    { 88, "B.M.W", "m3" },
                    { 89, "B.M.W", "m4" },
                    { 90, "B.M.W", "m5" },
                    { 91, "B.M.W", "m6" },
                    { 92, "B.M.W", "x1" },
                    { 93, "B.M.W", "x2" },
                    { 94, "B.M.W", "x3" },
                    { 95, "B.M.W", "x4" },
                    { 96, "B.M.W", "x5" },
                    { 97, "B.M.W", "x5 m" },
                    { 98, "B.M.W", "x6" },
                    { 99, "B.M.W", "x6 m" },
                    { 100, "B.M.W", "x7" },
                    { 101, "B.M.W", "x m" },
                    { 102, "B.M.W", "z4" },
                    { 103, "B.M.W", "z3" },
                    { 104, "B.M.W", "1" },
                    { 105, "B.M.W", "2" },
                    { 106, "B.M.W", "3" },
                    { 107, "B.M.W", "4" },
                    { 108, "B.M.W", "5" },
                    { 109, "B.M.W", "6" },
                    { 110, "B.M.W", "2 grand coupe" },
                    { 111, "B.M.W", "3 gt" },
                    { 112, "B.M.W", "4 grand coupe" },
                    { 113, "B.M.W", "6 grand coupe" },
                    { 114, "B.M.W", "7" },
                    { 115, "B.M.W", "8" },
                    { 116, "B.M.W", "8 grand coupe" },
                    { 117, "Bentley", "bentayga" },
                    { 118, "Bentley", "mulsanne" },
                    { 119, "Bentley", "flying spur" },
                    { 120, "Bentley", "continental" },
                    { 121, "Geely", "geometry c" },
                    { 122, "Jeep", "wrangler" },
                    { 123, "Jeep", "gladiator" },
                    { 124, "Jeep", "grand chrokee" },
                    { 125, "Jeep", "cherokee" },
                    { 126, "Jeep", "compast" },
                    { 127, "Jeep", "rangade" },
                    { 128, "Genesis", "G70" },
                    { 129, "Genesis", "G80" },
                    { 130, "Genesis", "G90" },
                    { 131, "Genesis", "GV60" },
                    { 132, "Genesis", "GV70" },
                    { 133, "Genesis", "GV80" },
                    { 134, "Great wall", "C10" },
                    { 135, "Great wall", "Stid" },
                    { 136, "Dachia", "Joger" },
                    { 137, "Dachia", "duster" },
                    { 138, "Dachia", "dokker" },
                    { 139, "Dachia", "logan" },
                    { 140, "Dachia", "lodgi" },
                    { 141, "Dachia", "sandero" },
                    { 142, "Dodge", "journey" },
                    { 143, "Dodge", "caliber" },
                    { 144, "Dodge", "ram" },
                    { 145, "Daihatsu", "applause" },
                    { 146, "Daihatsu", "materia" },
                    { 147, "Daihatsu", "gran mov" },
                    { 148, "Daihatsu", "YRV" },
                    { 149, "Daihatsu", "terius" },
                    { 150, "Daihatsu", "sirion" },
                    { 151, "Daihatsu", "sharade" },
                    { 152, "Daihatsu", "sharade classic" },
                    { 153, "Hongqi", "E-HS9" },
                    { 154, "Honda", "CRV" },
                    { 155, "Honda", "CRZ" },
                    { 156, "Honda", "HRV" },
                    { 157, "Honda", "civic hatchback" },
                    { 158, "Honda", "civic sedan" },
                    { 159, "Honda", "jazz" },
                    { 160, "Honda", "FRV" },
                    { 161, "Honda", "S2000" },
                    { 162, "Honda", "insight" },
                    { 163, "Honda", "accord" },
                    { 164, "Honda", "accord american" },
                    { 165, "Honda", "legend" },
                    { 166, "Honda", "stream" },
                    { 167, "Honda", "civic coupe" },
                    { 168, "Honda", "prelude" },
                    { 169, "Honda", "shuttel" },
                    { 170, "Voyah", "perry" },
                    { 171, "Volvo", "c30" },
                    { 172, "Volvo", "c40" },
                    { 173, "Volvo", "c70" },
                    { 174, "Volvo", "s40" },
                    { 175, "Volvo", "s60" },
                    { 176, "Volvo", "s70" },
                    { 177, "Volvo", "s80" },
                    { 178, "Volvo", "s90" },
                    { 179, "Volvo", "v40" },
                    { 180, "Volvo", "v50" },
                    { 181, "Volvo", "v60" },
                    { 182, "Volvo", "xc40" },
                    { 183, "Volvo", "xc60" },
                    { 184, "Volvo", "xc70" },
                    { 185, "Volvo", "xc90" },
                    { 186, "Toyota", "bz4x" },
                    { 187, "Toyota", "chr" },
                    { 188, "Toyota", "gt86" },
                    { 189, "Toyota", "mr2" },
                    { 190, "Toyota", "runx" },
                    { 191, "Toyota", "avalon" },
                    { 192, "Toyota", "avenys" },
                    { 193, "Toyota", "auris" },
                    { 194, "Toyota", "aygo" },
                    { 195, "Toyota", "aygo x" },
                    { 196, "Toyota", "highlander" },
                    { 197, "Toyota", "hilux" },
                    { 198, "Toyota", "verso" },
                    { 199, "Toyota", "land cruiser" },
                    { 200, "Toyota", "yaris" },
                    { 201, "Toyota", "yaris verso" },
                    { 202, "Toyota", "yaris cross" },
                    { 203, "Toyota", "starlet" },
                    { 204, "Toyota", "city" },
                    { 205, "Toyota", "sienna" },
                    { 206, "Toyota", "space verso" },
                    { 207, "Toyota", "privia" },
                    { 208, "Toyota", "camry" },
                    { 209, "Toyota", "corola" },
                    { 210, "Toyota", "prius" },
                    { 211, "Toyota", "corola crosss" },
                    { 212, "Toyota", "rav 4" },
                    { 213, "Tesla", "3" },
                    { 214, "Tesla", "S" },
                    { 215, "Tesla", "X" },
                    { 216, "Tesla", "Y" },
                    { 217, "Jaguar", "E-Pace" },
                    { 218, "Jaguar", "F-Pace" },
                    { 219, "Jaguar", "F-Type" },
                    { 220, "Jaguar", "I-Pace" },
                    { 221, "Jaguar", "S-Type" },
                    { 222, "Jaguar", "X-Type" },
                    { 223, "Jaguar", "XE" },
                    { 224, "Jaguar", "XF" },
                    { 225, "Jaguar", "XJ" },
                    { 226, "Jaguar", "XK" },
                    { 227, "Lynk & Co", "01" },
                    { 228, "Leap motor", "T03" },
                    { 229, "Hyundai", "H350" },
                    { 230, "Hyundai", "i10" },
                    { 231, "Hyundai", "i20" },
                    { 232, "Hyundai", "i20 cross" },
                    { 233, "Hyundai", "i25" },
                    { 234, "Hyundai", "i30" },
                    { 235, "Hyundai", "i30CW" },
                    { 236, "Hyundai", "i35" },
                    { 237, "Hyundai", "i40" },
                    { 238, "Hyundai", "i800" },
                    { 239, "Hyundai", "ix20" },
                    { 240, "Hyundai", "ix35" },
                    { 241, "Hyundai", "ioniq" },
                    { 242, "Hyundai", "ioniq 5" },
                    { 243, "Hyundai", "ioniq 6" },
                    { 244, "Hyundai", "ioniq e" },
                    { 245, "Hyundai", "elantra" },
                    { 246, "Hyundai", "elantra hybrid" },
                    { 247, "Hyundai", "accent" },
                    { 248, "Hyundai", "ethos" },
                    { 249, "Hyundai", "baion" },
                    { 250, "Hyundai", "galoper" },
                    { 251, "Hyundai", "getz" },
                    { 252, "Hyundai", "genesis" },
                    { 253, "Hyundai", "genesis coupe" },
                    { 254, "Hyundai", "veloster" },
                    { 255, "Hyundai", "venyo" },
                    { 256, "Hyundai", "tarkan" },
                    { 257, "Hyundai", "matrix" },
                    { 258, "Hyundai", "staria" },
                    { 259, "Hyundai", "santa fe" },
                    { 260, "Hyundai", "kona" },
                    { 261, "Hyundai", "coupe" },
                    { 262, "Land rover", "discovery" },
                    { 263, "Land rover", "discovery 4" },
                    { 264, "Land rover", "discovery 5" },
                    { 265, "Land rover", "defender" },
                    { 266, "Land rover", "freelander" },
                    { 267, "Land rover", "range rover" },
                    { 268, "Land rover", "range rover ewalk" },
                    { 269, "Land rover", "range rover velar" },
                    { 270, "Land rover", "range rover sport" },
                    { 271, "Lanchia", "thema" },
                    { 272, "Lanchia", "voyager" },
                    { 273, "Lanchia", "flavia" },
                    { 274, "Lexus", "gt200h" },
                    { 275, "Lexus", "ES" },
                    { 276, "Lexus", "GS" },
                    { 277, "Lexus", "IS" },
                    { 278, "Lexus", "IS C" },
                    { 279, "Lexus", "LC" },
                    { 280, "Lexus", "LS" },
                    { 281, "Lexus", "LX" },
                    { 282, "Lexus", "NX" },
                    { 283, "Lexus", "RC" },
                    { 284, "Lexus", "RX" },
                    { 285, "Lexus", "RX-L" },
                    { 286, "Lexus", "RZ" },
                    { 287, "Lexus", "SC" },
                    { 288, "Lexus", "UX" },
                    { 289, "Mazda", "2" },
                    { 290, "Mazda", "3" },
                    { 291, "Mazda", "6" },
                    { 292, "Mazda", "5" },
                    { 293, "Mazda", "mpv" },
                    { 294, "Mazda", "121" },
                    { 295, "Mazda", "323" },
                    { 296, "Mazda", "656" },
                    { 297, "Mazda", "demio" },
                    { 298, "Mazda", "bt50" },
                    { 299, "Mazda", "bt2500" },
                    { 300, "Mazda", "2 demio" },
                    { 301, "Mazda", "cx 5" },
                    { 302, "Mazda", "cx 3" },
                    { 303, "Mazda", "cx 30" },
                    { 304, "Mazda", "cx 50" },
                    { 305, "Mazda", "cx 90" },
                    { 306, "Mazda", "mx 30" },
                    { 307, "Mazda", "mx 50" },
                    { 308, "Mazda", "rx 7" },
                    { 309, "Mazda", "rx 8" },
                    { 310, "Maan", "TGE" },
                    { 311, "Maserati", "ghibli" },
                    { 312, "Maserati", "gran tourismo" },
                    { 313, "Maserati", "gran cabrio" },
                    { 314, "Maserati", "levante" },
                    { 315, "Maserati", "khamsin" },
                    { 316, "Maserati", "grecale" },
                    { 317, "Maserati", "quattroporte" },
                    { 318, "Mini", "cooper" },
                    { 319, "Mini", "cooper s" },
                    { 320, "Mini", "paceman" },
                    { 321, "Mini", "country man" },
                    { 322, "Mini", "cooper cabriolet" },
                    { 323, "Mini", "clubmen" },
                    { 324, "Mini", "roadster" },
                    { 325, "Mitsubishi", "lancer" },
                    { 326, "Mitsubishi", "lancer classic" },
                    { 327, "Mitsubishi", "ASX" },
                    { 328, "Mitsubishi", "imiev" },
                    { 329, "Mitsubishi", "outlander" },
                    { 330, "Mitsubishi", "attrage" },
                    { 331, "Mitsubishi", "eclipse cross" },
                    { 332, "Mitsubishi", "galant" },
                    { 333, "Mitsubishi", "eclipse" },
                    { 334, "Mitsubishi", "grandis" },
                    { 335, "Mitsubishi", "carisma" },
                    { 336, "Mitsubishi", "triton" },
                    { 337, "Mitsubishi", "lancer evo" },
                    { 338, "Mitsubishi", "magnum" },
                    { 339, "Mitsubishi", "spacestar" },
                    { 340, "Mitsubishi", "super lancer" },
                    { 341, "Mitsubishi", "space waggen" },
                    { 342, "Mitsubishi", "pajero" },
                    { 343, "Mitsubishi", "colt" },
                    { 344, "Maxus", "E-deliver 3" },
                    { 345, "Maxus", "E-deliver 9" },
                    { 346, "Maxus", "EUNIQ 5" },
                    { 347, "Maxus", "EUNIQ 6" },
                    { 348, "Maxus", "V80" },
                    { 349, "Mercedes", "A class" },
                    { 350, "Mercedes", "A class sedan" },
                    { 351, "Mercedes", "AMG GT" },
                    { 352, "Mercedes", "B class" },
                    { 353, "Mercedes", "C coupe cabriolet" },
                    { 354, "Mercedes", "C class" },
                    { 355, "Mercedes", "CL class" },
                    { 356, "Mercedes", "CLA class" },
                    { 357, "Mercedes", " CLK class" },
                    { 358, "Mercedes", "CLS class" },
                    { 359, "Mercedes", "CLC" },
                    { 360, "Mercedes", "E coupe cabriolet" },
                    { 361, "Mercedes", "E class" },
                    { 362, "Mercedes", "EQA " },
                    { 363, "Mercedes", "EQB " },
                    { 364, "Mercedes", "EQC" },
                    { 365, "Mercedes", "EQE" },
                    { 366, "Mercedes", "EQE SUV" },
                    { 367, "Mercedes", "EQS" },
                    { 368, "Mercedes", "EQS SUV" },
                    { 369, "Mercedes", "EQV" },
                    { 370, "Mercedes", "G class" },
                    { 371, "Mercedes", "GL class" },
                    { 372, "Mercedes", "GLA class" },
                    { 373, "Mercedes", "GLB" },
                    { 374, "Mercedes", "GLC" },
                    { 375, "Mercedes", "GLC coupe" },
                    { 376, "Mercedes", "GLE" },
                    { 377, "Mercedes", "GLE coupe" },
                    { 378, "Mercedes", "GLK class" },
                    { 379, "Mercedes", "GLS" },
                    { 380, "Mercedes", "M class" },
                    { 381, "Mercedes", "R class" },
                    { 382, "Mercedes", "S class" },
                    { 383, "Mercedes", "S class coupe" },
                    { 384, "Mercedes", "SL class" },
                    { 385, "Mercedes", "SLC" },
                    { 386, "Mercedes", "SLK class" },
                    { 387, "Mercedes", "SLS AMG" },
                    { 388, "Mercedes", "V class" },
                    { 389, "Mercedes", "Sprinter" },
                    { 390, "Nio", "ES8" },
                    { 391, "Nio", "ET5" },
                    { 392, "Nio", "ET7" },
                    { 393, "Nissan", "370Z" },
                    { 394, "Nissan", "350Z" },
                    { 395, "Nissan", "GTR" },
                    { 396, "Nissan", "NV200" },
                    { 397, "Nissan", "altima" },
                    { 398, "Nissan", "almera" },
                    { 399, "Nissan", "xtrail" },
                    { 400, "Nissan", "aria" },
                    { 401, "Nissan", "juke" },
                    { 402, "Nissan", "winner" },
                    { 403, "Nissan", "tiida" },
                    { 404, "Nissan", "terano" },
                    { 405, "Nissan", "leef" },
                    { 406, "Nissan", "morano" },
                    { 407, "Nissan", "micra" },
                    { 408, "Nissan", "maxima" },
                    { 409, "Nissan", "nevara" },
                    { 410, "Nissan", "note" },
                    { 411, "Nissan", "sdentra" },
                    { 412, "Nissan", "path finder" },
                    { 413, "Nissan", "polsar" },
                    { 414, "Nissan", "petrol" },
                    { 415, "Nissan", "primera" },
                    { 416, "Nissan", "QASHKAI" },
                    { 417, "Saang young", "Actyon" },
                    { 418, "Saang young", "Chairman" },
                    { 419, "Saang young", "Autoraya" },
                    { 420, "Saang young", "Istana" },
                    { 421, "Saang young", "Korando" },
                    { 422, "Saang young", "Kyron" },
                    { 423, "Saang young", "Musso" },
                    { 424, "Saang young", "Rexton" },
                    { 425, "Saang young", "Rhino" },
                    { 426, "Saang young", "Rodius" },
                    { 427, "Saang young", "Tivoli" },
                    { 428, "Saang young", "Torres" },
                    { 429, "Saang young", "Transstar" },
                    { 430, "Subaru", "impreza" },
                    { 431, "Subaru", "outback" },
                    { 432, "Subaru", "forester" },
                    { 433, "Subaru", "B3" },
                    { 434, "Subaru", "B4" },
                    { 435, "Subaru", "xv" },
                    { 436, "Subaru", "levorage" },
                    { 437, "Subaru", "legacy" },
                    { 438, "Subaru", "tribeca" },
                    { 439, "Subaru", "crosstrek" },
                    { 440, "Suzuki", "ONE" },
                    { 441, "Suzuki", "S-Cross" },
                    { 442, "Suzuki", "SX4" },
                    { 443, "Suzuki", "XL7" },
                    { 444, "Suzuki", "ignis" },
                    { 445, "Suzuki", "alto" },
                    { 446, "Suzuki", "baleno" },
                    { 447, "Suzuki", "jimni" },
                    { 448, "Suzuki", "grand vidara" },
                    { 449, "Suzuki", "wagon R+" },
                    { 450, "Suzuki", "vitara" },
                    { 451, "Suzuki", "euroswift" },
                    { 452, "Suzuki", "liana" },
                    { 453, "Suzuki", "swift" },
                    { 454, "Suzuki", "selerio" },
                    { 455, "Suzuki", "splash" },
                    { 456, "Suzuki", "kizashi" },
                    { 457, "Suzuki", "crossover" },
                    { 458, "Suzuki", "super swift" },
                    { 459, "Seat", "ateka" },
                    { 460, "Seat", "ibiza" },
                    { 461, "Seat", "ineka" },
                    { 462, "Seat", "alhambara" },
                    { 463, "Seat", "altea" },
                    { 464, "Seat", "axau" },
                    { 465, "Seat", "arona" },
                    { 466, "Seat", "tarracan" },
                    { 467, "Seat", "toledo" },
                    { 468, "Seat", "leon" },
                    { 469, "Seat", "mii" },
                    { 470, "Seat", "cordova" },
                    { 471, "Citroen", "C elisee" },
                    { 472, "Citroen", "C1" },
                    { 473, "Citroen", "C2 vts" },
                    { 474, "Citroen", "C3" },
                    { 475, "Citroen", "C3 aircross" },
                    { 476, "Citroen", "C3 picasso" },
                    { 477, "Citroen", "C4" },
                    { 478, "Citroen", "C4 X" },
                    { 479, "Citroen", "C4 spacetourrer" },
                    { 480, "Citroen", "C4 Grand picasso" },
                    { 481, "Citroen", "C4 cactus" },
                    { 482, "Citroen", "C5" },
                    { 483, "Smart", "port" },
                    { 484, "Smart", "1" },
                    { 485, "Smart", "porpor" },
                    { 486, "Smart", "roadster" },
                    { 487, "Skoda", "octavia" },
                    { 488, "Skoda", "aniak" },
                    { 489, "Skoda", "yeti" },
                    { 490, "Skoda", "superb" },
                    { 491, "Skoda", "citigo" },
                    { 492, "Skoda", "scala" },
                    { 493, "Skoda", "fabia" },
                    { 494, "Skoda", "kamiq" },
                    { 495, "Skoda", "qarok" },
                    { 496, "Skoda", "kodiak" },
                    { 497, "Skoda", "rapid" },
                    { 498, "Skoda", "roomster" },
                    { 499, "Polstar", "2" },
                    { 500, "Volkswagen", "CC" },
                    { 501, "Volkswagen", "ID Buzz" },
                    { 502, "Volkswagen", "ID.4" },
                    { 503, "Volkswagen", "Atlas" },
                    { 504, "Volkswagen", "ayos" },
                    { 505, "Volkswagen", "amaroq" },
                    { 506, "Volkswagen", "up" },
                    { 507, "Volkswagen", "bora" },
                    { 508, "Volkswagen", "golf" },
                    { 509, "Volkswagen", "golf +" },
                    { 510, "Volkswagen", "jetta" },
                    { 511, "Volkswagen", "bug" },
                    { 512, "Volkswagen", "toareg" },
                    { 513, "Volkswagen", "touran" },
                    { 514, "Volkswagen", "T cross" },
                    { 515, "Volkswagen", "tigouan" },
                    { 516, "Volkswagen", "transporter" },
                    { 517, "Volkswagen", "multivan" },
                    { 518, "Volkswagen", "sprtvan" },
                    { 519, "Volkswagen", "passat" },
                    { 520, "Volkswagen", "passat cc" },
                    { 521, "Volkswagen", "polo" },
                    { 522, "Volkswagen", "polo classic" },
                    { 523, "Volkswagen", "cadi" },
                    { 524, "Volkswagen", "california" },
                    { 525, "Volkswagen", "caraval" },
                    { 526, "Volkswagen", "crapter" },
                    { 527, "Volkswagen", "chiroko" },
                    { 528, "Ford", "B-max" },
                    { 529, "Ford", "C-max" },
                    { 530, "Ford", "F-150" },
                    { 531, "Ford", "F-250" },
                    { 532, "Ford", "F-350" },
                    { 533, "Ford", "S-max" },
                    { 534, "Ford", "edge" },
                    { 535, "Ford", "explorer" },
                    { 536, "Ford", "brunko" },
                    { 537, "Ford", "galaxy" },
                    { 538, "Ford", "taurus" },
                    { 539, "Ford", "tranzit" },
                    { 540, "Ford", "mondeo" },
                    { 541, "Ford", "mustang" },
                    { 542, "Ford", "puma" },
                    { 543, "Ford", "focus" },
                    { 544, "Ford", "fiesta" },
                    { 545, "Ford", "fusion" },
                    { 546, "Ford", "kuga" },
                    { 547, "Ford", "connect" },
                    { 548, "Ford", "ranger" },
                    { 549, "Porche", "718 boxer" },
                    { 550, "Porche", "718 cayman" },
                    { 551, "Porche", "911" },
                    { 552, "Porche", "boxter" },
                    { 553, "Porche", "tiken" },
                    { 554, "Porche", "mccan" },
                    { 555, "Porche", "panamera" },
                    { 556, "Porche", "caymen" },
                    { 557, "Porche", "cayen" },
                    { 558, "Porche", "cayen coupe" },
                    { 559, "Fiat", "500" },
                    { 560, "Fiat", "500c" },
                    { 561, "Fiat", "500L" },
                    { 562, "Fiat", "500X" },
                    { 563, "Fiat", "olize" },
                    { 564, "Fiat", "bravo" },
                    { 565, "Fiat", "grand punto" },
                    { 566, "Fiat", "dubelo" },
                    { 567, "Fiat", "ducatto" },
                    { 568, "Fiat", "tipo" },
                    { 569, "Fiat", "cruma" },
                    { 570, "Fiat", "multipepla" },
                    { 571, "Fiat", "sadiche" },
                    { 572, "Fiat", "skodu" },
                    { 573, "Fiat", "fullback" },
                    { 574, "Fiat", "punto" },
                    { 575, "Fiat", "furino" },
                    { 576, "Fiat", "panda" },
                    { 577, "Fiat", "qobu" },
                    { 578, "Peugeot", "107" },
                    { 579, "Peugeot", "108" },
                    { 580, "Peugeot", "2008" },
                    { 581, "Peugeot", "206" },
                    { 582, "Peugeot", "206CC" },
                    { 583, "Peugeot", "206SW" },
                    { 584, "Peugeot", "207" },
                    { 585, "Peugeot", "207CC" },
                    { 586, "Peugeot", "208" },
                    { 587, "Peugeot", "3008" },
                    { 588, "Peugeot", "301" },
                    { 589, "Peugeot", "306" },
                    { 590, "Peugeot", "307" },
                    { 591, "Peugeot", "307CC" },
                    { 592, "Peugeot", "307SW" },
                    { 593, "Peugeot", "308" },
                    { 594, "Peugeot", "308CC" },
                    { 595, "Peugeot", "406" },
                    { 596, "Peugeot", "407" },
                    { 597, "Peugeot", "408" },
                    { 598, "Peugeot", "5008" },
                    { 599, "Peugeot", "508" },
                    { 600, "Peugeot", "607" },
                    { 601, "Peugeot", "RCZ" },
                    { 602, "Peugeot", "boxer" },
                    { 603, "Peugeot", "beeper" },
                    { 604, "Peugeot", "partner" },
                    { 605, "Peugeot", "ripter" },
                    { 606, "Ferari", "scuderia" },
                    { 607, "Ferari", "italia" },
                    { 608, "Ferari", "488" },
                    { 609, "Ferari", "scaglietti" },
                    { 610, "Ferari", "f12berlinetta" },
                    { 611, "Ferari", "f430" },
                    { 612, "Ferari", "f430 spider" },
                    { 613, "Ferari", "FXX" },
                    { 614, "Ferari", "FXX Evolution" },
                    { 615, "Ferari", "GTB296" },
                    { 616, "Ferari", "GTC4 lusso" },
                    { 617, "Ferari", "Portofino" },
                    { 618, "Ferari", "superamerica" },
                    { 619, "Ferari", "porosangwea" },
                    { 620, "Cherry", "FX" },
                    { 621, "Cherry", "tygo 7 pro" },
                    { 622, "Cherry", "tygo 8 pro" },
                    { 623, "Kadilac", "ATS" },
                    { 624, "Kadilac", "ATS-V" },
                    { 625, "Kadilac", "CT5" },
                    { 626, "Kadilac", "CT6" },
                    { 627, "Kadilac", "CTS" },
                    { 628, "Kadilac", "CTS coupe" },
                    { 629, "Kadilac", "CTS-V" },
                    { 630, "Kadilac", "SRX" },
                    { 631, "Kadilac", "STS" },
                    { 632, "Kadilac", "SRX" },
                    { 633, "Kadilac", "STS" },
                    { 634, "Kadilac", "XT4" },
                    { 635, "Kadilac", "XT5" },
                    { 636, "Kadilac", "XT6" },
                    { 637, "Kadilac", "escalade" },
                    { 638, "Kadilac", "STS swill" },
                    { 639, "Cupra", "ateka" },
                    { 640, "Cupra", "leon" },
                    { 641, "Cupra", "formentor" },
                    { 642, "Kia", "EV6" },
                    { 643, "Kia", "K2500" },
                    { 644, "Kia", "optima" },
                    { 645, "Kia", "XCEED" },
                    { 646, "Kia", "joys" },
                    { 647, "Kia", "mentor" },
                    { 648, "Kia", "niro" },
                    { 649, "Kia", "niro EV" },
                    { 650, "Kia", "niro +" },
                    { 651, "Kia", "soll" },
                    { 652, "Kia", "sorento" },
                    { 653, "Kia", "stonic" },
                    { 654, "Kia", "stinger" },
                    { 655, "Kia", "ceed" },
                    { 656, "Kia", "seltos" },
                    { 657, "Kia", "sportage" },
                    { 658, "Kia", "spia" },
                    { 659, "Kia", "serato" },
                    { 660, "Kia", "forte" },
                    { 661, "Kia", "picanto" },
                    { 662, "Kia", "pro ceed" },
                    { 663, "Kia", "pride" },
                    { 664, "Kia", "carens" },
                    { 665, "Kia", "celeros" },
                    { 666, "Kia", "carnival" },
                    { 667, "Kia", "rio" },
                    { 668, "Kia", "shuma" },
                    { 669, "Chrysler", "300" },
                    { 670, "Chrysler", "300C" },
                    { 671, "Chrysler", "300M" },
                    { 672, "Chrysler", "PT Cruiser" },
                    { 673, "Chrysler", "Grand voyager" },
                    { 674, "Chrysler", "voyager" },
                    { 675, "Chrysler", "town and country" },
                    { 676, "Chrysler", "neon" },
                    { 677, "Chrysler", "sabring" },
                    { 678, "Chrysler", "stratos" },
                    { 679, "Chrysler", "pacifika" },
                    { 680, "Chrysler", "crossfire" },
                    { 681, "Ram", "2500" },
                    { 682, "Ram", "3500" },
                    { 683, "Renault", "ostrell" },
                    { 684, "Renault", "arcana" },
                    { 685, "Renault", "grand sneak" },
                    { 686, "Renault", "zoey" },
                    { 687, "Renault", "twingo" },
                    { 688, "Renault", "traffic" },
                    { 689, "Renault", "laguna" },
                    { 690, "Renault", "latitude" },
                    { 691, "Renault", "logan mcv" },
                    { 692, "Renault", "master" },
                    { 693, "Renault", "megan" },
                    { 694, "Renault", "megan grand coupe" },
                    { 695, "Renault", "megan coupe" },
                    { 696, "Renault", "symbol" },
                    { 697, "Renault", "sneak rx4" },
                    { 698, "Renault", "fluence" },
                    { 699, "Renault", "fluence Z.E" },
                    { 700, "Renault", "kadjar" },
                    { 701, "Renault", "coleus" },
                    { 702, "Renault", "clio" },
                    { 703, "Renault", "kangoo" },
                    { 704, "Renault", "cature" },
                    { 705, "Chevrolet", "aveo" },
                    { 706, "Chevrolet", "aveo sedan" },
                    { 707, "Chevrolet", "optra" },
                    { 708, "Chevrolet", "orlando" },
                    { 709, "Chevrolet", "impala" },
                    { 710, "Chevrolet", "alero" },
                    { 711, "Chevrolet", "astro" },
                    { 712, "Chevrolet", "epica" },
                    { 713, "Chevrolet", "uplander" },
                    { 714, "Chevrolet", "equinox" },
                    { 715, "Chevrolet", "blazer" },
                    { 716, "Chevrolet", "jimmi" },
                    { 717, "Chevrolet", "wolt" },
                    { 718, "Chevrolet", "vivant" },
                    { 719, "Chevrolet", "traverse" },
                    { 720, "Chevrolet", "trax" },
                    { 721, "Chevrolet", "trailblazer" },
                    { 722, "Chevrolet", "lumina" },
                    { 723, "Chevrolet", "malibu" },
                    { 724, "Chevrolet", "monta carlo" },
                    { 725, "Chevrolet", "savana" },
                    { 726, "Chevrolet", "sonic" },
                    { 727, "Chevrolet", "silverado" },
                    { 728, "Chevrolet", "spark" },
                    { 729, "Chevrolet", "colorado" },
                    { 730, "Chevrolet", "corvette" },
                    { 731, "Chevrolet", "camaro" },
                    { 732, "Chevrolet", "captiva" },
                    { 733, "Chevrolet", "cruze" },
                    { 734, "Aiways", "U5" },
                    { 735, "Aiways", "U6" },
                    { 736, "BYD", "ATO 3" },
                    { 737, "BYD", "dolphine" },
                    { 738, "BYD", "han" },
                    { 739, "BYD", "tang" },
                    { 740, "BYD", "seal" },
                    { 741, "DS", "DS 4" },
                    { 742, "DS", "DS 3" },
                    { 743, "DS", "DS 3 crossback" },
                    { 744, "DS", "DS 5" },
                    { 745, "DS", "DS 7 crossback" },
                    { 746, "Eveasy", "limo" },
                    { 747, "GAC", "GE 3" },
                    { 748, "JAC", "E-JS4" },
                    { 749, "JAC", "E-S2" },
                    { 750, "LEVC", "TX" },
                    { 751, "LEVC", "VN5" },
                    { 752, "MG", "4" },
                    { 753, "MG", "5" },
                    { 754, "MG", "EHS PHEV" },
                    { 755, "MG", "MG3" },
                    { 756, "MG", "MG350" },
                    { 757, "MG", "MG550" },
                    { 758, "MG", "ZS" },
                    { 759, "MG", "MARVEL R" },
                    { 760, "SERES", "EV 3" },
                    { 761, "SERES", "5" },
                    { 762, "SKYWALL", "ET 5" },
                    { 763, "Wey", "copy 01" },
                    { 764, "Wey", "copy 02" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "JobTitle", "Password", "UserName" },
                values: new object[] { 1, "admin@admin.com", 0, "admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Abart");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Acura");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Aiways");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Alfa romeo");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Alpine");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Aston martin");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Audi");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Bentley");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "BYD");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Cherry");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Chevrolet");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Chrysler");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Citroen");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Cupra");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Dachia");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Daihatsu");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Dodge");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "DS");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Eveasy");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Ferari");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Fiat");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Ford");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "GAC");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Geely");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Genesis");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Great wall");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Honda");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Hongqi");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Hyundai");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Infinity");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Isuzu");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Iveco");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "JAC");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Jaguar");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Jeep");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Kadilac");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Kia");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Lanchia");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Land rover");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Leap motor");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "LEVC");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Lexus");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Lynk & Co");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Maan");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Maserati");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Maxus");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Mercedes");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "MG");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Mini");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Mitsubishi");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Nio");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Nissan");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Opel");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Ora");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Peugeot");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Polstar");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Porche");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Ram");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Renault");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Saang young");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Seat");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "SERES");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Skoda");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "SKYWALL");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Smart");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Subaru");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Suzuki");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Tesla");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Volkswagen");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Volvo");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Voyah");

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "manufacturerName",
                keyValue: "Wey");

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Mazda", "3" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Mazda", "6" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Mazda", "CX-5" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "BMW", "3 Series" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "BMW", "4 Series" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "BMW", "5 Series" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Toyota", "Corolla" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Toyota", "Auris" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "manufacturerName", "model" },
                values: new object[] { "Toyota", "Verso" });
        }
    }
}
