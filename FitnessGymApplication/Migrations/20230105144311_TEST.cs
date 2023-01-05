using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessGymApplication.Migrations
{
    /// <inheritdoc />
    public partial class TEST : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phonenumber = table.Column<int>(type: "int", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Diseases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Newsletter = table.Column<int>(type: "int", nullable: false),
                    Freetrial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formula",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Commitement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formula", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    MaxParticipants = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intensity = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Frequency = table.Column<int>(type: "int", nullable: false),
                    CaloriesBurnt = table.Column<int>(type: "int", nullable: true),
                    IdClient = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goal_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteExercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdExercise = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteExercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteExercise_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteExercise_Exercise_IdExercise",
                        column: x => x.IdExercise,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdLocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteLocation_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteLocation_Location_IdLocation",
                        column: x => x.IdLocation,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineLocation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMachine = table.Column<int>(type: "int", nullable: false),
                    IdLocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineLocation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MachineLocation_Location_IdLocation",
                        column: x => x.IdLocation,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineLocation_Machine_IdMachine",
                        column: x => x.IdMachine,
                        principalTable: "Machine",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSpeciality = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Coach_Speciality_IdSpeciality",
                        column: x => x.IdSpeciality,
                        principalTable: "Speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteTrainingProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdTrainingProgram = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteTrainingProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteTrainingProgram_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteTrainingProgram_TrainingProgram_IdTrainingProgram",
                        column: x => x.IdTrainingProgram,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndividualProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTrainingProgram = table.Column<int>(type: "int", nullable: false),
                    IdExercise = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualProgram_Exercise_IdExercise",
                        column: x => x.IdExercise,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndividualProgram_TrainingProgram_IdTrainingProgram",
                        column: x => x.IdTrainingProgram,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteCoach",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdCoach = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteCoach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteCoach_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteCoach_Coach_IdCoach",
                        column: x => x.IdCoach,
                        principalTable: "Coach",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxParticipants = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTrainingProgram = table.Column<int>(type: "int", nullable: false),
                    IdCoach = table.Column<int>(type: "int", nullable: false),
                    IdLocation = table.Column<int>(type: "int", nullable: false),
                    IdFormula = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Session_Coach_IdCoach",
                        column: x => x.IdCoach,
                        principalTable: "Coach",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Session_Formula_IdFormula",
                        column: x => x.IdFormula,
                        principalTable: "Formula",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Session_Location_IdLocation",
                        column: x => x.IdLocation,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Session_TrainingProgram_IdTrainingProgram",
                        column: x => x.IdTrainingProgram,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxParticipants = table.Column<int>(type: "int", nullable: false),
                    Cancelled = table.Column<int>(type: "int", nullable: false),
                    IdSession = table.Column<int>(type: "int", nullable: false),
                    IdClient = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_Session_IdSession",
                        column: x => x.IdSession,
                        principalTable: "Session",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "Calories", "Description", "Duration", "Name" },
                values: new object[,]
                {
                    { 1, 50, "Au sol sur le do, les genoux formant un angle un angle droit avec vos hanches. Ramenez votre buste vers le ciel tout en plaçant les mains au niveau de la nuque.", 5, "Crunch" },
                    { 2, 100, "En position de planche frontale : sur la pointe des pieds, les mains bien à plat sur le sol, le dos droit et la tête dans le prolongement de votre colonne vertébrale. Ramenez ensuite les genoux à votre poitrine de façon alternée.", 5, "Montain Climber" },
                    { 3, 100, "Debout, l'espace entre votre deux pieds correspond à la largeur de vos épaules. Sautez en poussant les genoux vers l'extérieur. Lever les bras en même temps que vous sautez. Puis revenir en position initiale : debout, les bras le long du corps.", 5, "Jumping jack" },
                    { 4, 100, "En position de planche frontale, c'est-à-dire sur la pointe des pieds et mains à plat sur le sol, le dos droit et la tête dans le prolongement de votre colonne vertébrale. Ramenez la poitrine vers le sol en pliant les coudes puis tendez les bras. Restez bien gainé tout au long de l'exercice.", 5, "Pompes Hiit" },
                    { 5, 100, "Commencez en position debout, puis lever rapidement les genoux un après l'autre.", 5, "Leg lift" }
                });

            migrationBuilder.InsertData(
                table: "Formula",
                columns: new[] { "ID", "Commitement", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "L'abonnement mensuel CLASSIQUE FIT à 29€/mois vous donne accès à tous les clubs FITNESS GYM pour profiter de tous les appareils de musculations et cardio ainsi que de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est AVEC engagement sur une période de 12 mois et est valable de date à date.", "Classique fit", 29 },
                    { 2, 0, "L'abonnement mensuel CLASSIQUE FIT à 34€/mois vous donne accès à tous les clubs FITNESS GYM pour profiter de tous les appareils de musculations et cardio ainsi que de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est SANS engagement et valable de date à date. Seule la période en cours est due.", "Classique fit", 34 },
                    { 3, 1, "L'abonnement mensuel PREMIUM FIT à 36€/mois vous donne accès à tous les clubs FITNESS GYM pour y pratiquer les activités de sports de fitness et musculation, participer à une multitude de cours ainsi profiter de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est AVEC engagement sur une période de 12 mois et est valable de date à date.", "Premium fit", 36 },
                    { 4, 0, "L'abonnement mensuel PREMIUM FIT à 40€/mois vous donne accès à tous les clubs FITNESS GYM pour y pratiquer les activités de sports de fitness et musculation, participer à une multitude de cours ainsi profiter de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est SANS engagement et valable de date à date. Seule la période en cours est due.", "Premium fit", 40 },
                    { 5, 0, "Abonnement mensuel de 9€/mois sans engagement, sans période d'essai, seule la période en cours est due. Accès en illimités aux cours et programmes en ligne.", "No Gym No Problem", 9 },
                    { 6, 0, "Abonnement annuel de 29€/mois sans engagement, sans période d'essai, seule la période en cours est due. Accès en illimités aux cours et programmes en ligne.", "No Gym No Problem", 29 }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "ID", "Address", "City", "MaxParticipants", "Name", "PostalCode" },
                values: new object[,]
                {
                    { 1, "22 bis boulevard Saint Marcel", "Paris", 200, "Fitness Gym Austerlitz", 75005 },
                    { 2, "4/6 Passage Louis Philippe", "Paris", 200, "Fitness Gym Bastille", 75011 },
                    { 3, "123 Avenue de France ", "Paris", 150, "Fitness Gym BNF", 75013 },
                    { 4, "21 rue de la banque", "Paris", 150, "Fitness Gym Opera", 75002 },
                    { 5, "6 allée de la 2ème Division Blindée", "Paris", 150, "Fitness Gym Montparnasse", 75014 },
                    { 6, "81 rue de Lagny ", "Paris", 250, "Fitness Gym Nation", 75020 },
                    { 7, "44 rue de Clichy ", "Paris", 220, "Fitness Gym Saint-Lazarre", 75009 },
                    { 8, "19, avenue de la Liberté", "Nanterre", 250, "Fitness Gym La défense", 92000 },
                    { 9, "18-20, rue Auguste Perret", "Villejuif", 250, "Fitness Gym Villejuif", 94800 },
                    { 10, "11, Rue Exelmans", "Versailles", 350, "Fitness Gym Versailles", 78000 }
                });

            migrationBuilder.InsertData(
                table: "TrainingProgram",
                columns: new[] { "Id", "Calories", "Description", "Duration", "Intensity", "Name" },
                values: new object[,]
                {
                    { 1, 750, "Fentes, squats, jumping jacks : plongez au cœur du Body Attack ! La dynamique de groupe vous donnera une énergie incroyable pour réaliser un entraînement de haute intensité. On y retrouve des mouvements athlétiques comme la course, les flexions ou les sauts, qui sont combinés à des exercices de renforcement comme les pompes. Chorégraphies et musiques donneront du rythme à vos fractionnés, pour une endurance décuplée..", 45, 0, "Body Attack" },
                    { 2, 500, "Bienvenue au  Body Pump ! Ce Group training LesMills tonifie et renforce le corps tout entier en permettant à vos muscles de se sculpter sans prendre de volume. Les mouvements sont simples et le nombre de répétitions est élevé : le secret des muscles fins et athlétiques.", 45, 0, "Body Pump" },
                    { 3, 500, "Fruit de la rencontre entre le step et le Body Pump, le Body Sculpt vous aide à redessiner votre silhouette. Elastiques, haltères et bâtons sont les accessoires-clés pour parvenir à cet objectif, dans le cadre d’un Group training complet et accessible à tous. Après un court échauffement, vous alternez toutes les 5 minutes entre exercices cardio et renforcement musculaire, avant de travailler les abdos et de vous étirer.", 45, 0, "Body Sculpt" },
                    { 4, 300, "Cours traditionnel de cuisses abdos fessiers permettant de renforcer ses muscles afin de consolider les articulations et de limiter les douleurs dorsales.", 30, 0, "Cuisses Abdos Fessiers" },
                    { 5, 700, "Le Hiit ou High Intensity Interval Training est un type d'entrainement bien connu pour son efficacité. C'est un cours où vous travaillerez principalement vos capacités cardio-vasculaires en association avec des mouvements de musculation. Le HIIT est un cours full body intense et complet qui permet aussi bien de travailler le renforcement musculaire que l'endurance, tout en se défoulant.", 30, 0, "Hiit" },
                    { 6, 550, "Initiez-vous à l’art du Step en enchaînant des chorégraphies sur et autour d’une marche à hauteur réglable, sur fond de musique rythmée. Montez, descendez, tournez : de la coordination, vous en aurez besoin à coups sûr ! Vous brûlerez aussi beaucoup de calories, quasiment sans vous en rendre compte tellement vous serez concentré sur vos mouvements !", 45, 0, "Step" },
                    { 7, 500, "Ce cours est un mix entre le Yoga et le Pilates. Il permet, grâce à des étirements, de travailler sa posture, en particulier celle du dos, en étirant la colonne vertébrale et en évitant le tassement des vertèbres. Les exercices effectués pendant la séance aident à augmenter la souplesse générale du corps en assouplissant et en renforçant l'élasticité des tendons et des muscles. Cela permet également de retrouver une silhouette affinée et plus harmonieuse.", 60, 0, "Stretching" },
                    { 8, 600, "Son nom signifie « Round Per minute », soit tour à la minute en français.  Entraîné par une musique électrisante, vous pédalez et donnez le meilleur de vous-même pour atteindre votre cible. Ici, l’objectif est de vous entraîner comme à l’extérieur mais de façon plus intensive.", 45, 0, "RPM" },
                    { 9, 400, "Entre dynamisme et calme, ce cours permet de gagner en force et en souplesse tout en respirant. Allez un peu plus loin chaque jour tout en respectant votre corps, en laissant frustration et égo de côté. Ressentez les postures du flow plutôt que d'essayer de dépasser vos limites. En apprenant à écouter son corps, on se connecte plus à son mental, pour plus de maîtrise de soi.", 60, 0, "Yoga" },
                    { 10, 550, "De la chorégraphie, toujours et encore pour vous faire bouger sur des rythmes endiablés. De la salsa au merengue, en passant par la cumbia, le reggaeton, le kuduro… De la variété plus qu’il n’en faut au sein d’un Group training aussi efficace qu’amusant.", 45, 0, "Zumba" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coach_IdSpeciality",
                table: "Coach",
                column: "IdSpeciality");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteCoach_IdClient",
                table: "FavoriteCoach",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteCoach_IdCoach",
                table: "FavoriteCoach",
                column: "IdCoach");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteExercise_IdClient",
                table: "FavoriteExercise",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteExercise_IdExercise",
                table: "FavoriteExercise",
                column: "IdExercise");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteLocation_IdClient",
                table: "FavoriteLocation",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteLocation_IdLocation",
                table: "FavoriteLocation",
                column: "IdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteTrainingProgram_IdClient",
                table: "FavoriteTrainingProgram",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteTrainingProgram_IdTrainingProgram",
                table: "FavoriteTrainingProgram",
                column: "IdTrainingProgram");

            migrationBuilder.CreateIndex(
                name: "IX_Goal_IdClient",
                table: "Goal",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualProgram_IdExercise",
                table: "IndividualProgram",
                column: "IdExercise");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualProgram_IdTrainingProgram",
                table: "IndividualProgram",
                column: "IdTrainingProgram");

            migrationBuilder.CreateIndex(
                name: "IX_MachineLocation_IdLocation",
                table: "MachineLocation",
                column: "IdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_MachineLocation_IdMachine",
                table: "MachineLocation",
                column: "IdMachine");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_IdClient",
                table: "Reservation",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_IdSession",
                table: "Reservation",
                column: "IdSession");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdCoach",
                table: "Session",
                column: "IdCoach");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdFormula",
                table: "Session",
                column: "IdFormula");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdLocation",
                table: "Session",
                column: "IdLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdTrainingProgram",
                table: "Session",
                column: "IdTrainingProgram");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteCoach");

            migrationBuilder.DropTable(
                name: "FavoriteExercise");

            migrationBuilder.DropTable(
                name: "FavoriteLocation");

            migrationBuilder.DropTable(
                name: "FavoriteTrainingProgram");

            migrationBuilder.DropTable(
                name: "Goal");

            migrationBuilder.DropTable(
                name: "IndividualProgram");

            migrationBuilder.DropTable(
                name: "MachineLocation");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "Formula");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "TrainingProgram");

            migrationBuilder.DropTable(
                name: "Speciality");
        }
    }
}
