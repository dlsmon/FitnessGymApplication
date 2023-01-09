using Elfie.Serialization;
using FitnessGymApplication.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using NuGet.ContentModel;
using Location = FitnessGymApplication.Models.Location;

namespace FitnessGymApplication.Data.Seeding
{
    public class AppDBContextSeed
    {
        public static object Commitement { get; private set; }

        public static void Seed(ModelBuilder modelBuilder)
        {

            //Remarque : le Id n'est pas affiché dans la vue

            //Exercise 


                    //Perte de poids : cardio

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise()
                {
                    Id = 1,
                    Name = "Crunch",
                    Description = "Au sol sur le do, les genoux formant un angle un angle droit avec vos hanches. Ramenez votre buste vers le ciel tout en plaçant les mains au niveau de la nuque.",
                    Duration = 5,
                    Calories = 50
                });

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise()
                {
                    Id = 2,
                    Name = "Montain Climber",
                    Description = "En position de planche frontale : sur la pointe des pieds, les mains bien à plat sur le sol, le dos droit et la tête dans le prolongement de votre colonne vertébrale. Ramenez ensuite les genoux à votre poitrine de façon alternée.",
                    Duration = 5,
                    Calories = 100
                });

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise()
                {
                    Id = 3,
                    Name = "Jumping jack",
                    Description = "Debout, l'espace entre votre deux pieds correspond à la largeur de vos épaules. Sautez en poussant les genoux vers l'extérieur. Lever les bras en même temps que vous sautez. Puis revenir en position initiale : debout, les bras le long du corps.",
                    Duration = 5,
                    Calories = 100
                });
                   

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise()
                {
                    Id = 4,
                    Name = "Pompes Hiit",
                    Description = "En position de planche frontale, c'est-à-dire sur la pointe des pieds et mains à plat sur le sol, le dos droit et la tête dans le prolongement de votre colonne vertébrale. Ramenez la poitrine vers le sol en pliant les coudes puis tendez les bras. Restez bien gainé tout au long de l'exercice.",
                    Duration = 5,
                    Calories = 100
                });

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise()
                {
                    Id = 5,
                    Name = "Leg lift",
                    Description = "Commencez en position debout, puis lever rapidement les genoux un après l'autre.",
                    Duration = 5,
                    Calories = 100
                });




            //Training program  

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 1,
                    Name = "Aqua Bike",
                    Description = "Dans l'au, au rythme de la musique, les sportifs enchaînent une chorégraphie qui vise à travailler le cardio et la tonicité musculaire. ",
                    Intensity = TrainingProgram.eIntensity.Easy,
                    Duration = 45,
                    Calories = 400
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 2,
                    Name = "Aqua Gym",
                    Description = " l’Aquagym est un sport qui se pratique dans l’eau, guidé par un coach et motivé par des musiques entraînantes. En réalisant des chorégraphies ludiques, vous améliorez votre forme physique sans vous en rendre compte et dans la bonne humeur.",
                    Intensity = TrainingProgram.eIntensity.Medium,
                    Duration = 45,
                    Calories = 400
                });


            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 3,
                    Name = "Body Attack",
                    Description = "Fentes, squats, jumping jacks : plongez au cœur du Body Attack ! La dynamique de groupe vous donnera une énergie incroyable pour réaliser un entraînement de haute intensité. On y retrouve des mouvements athlétiques comme la course, les flexions ou les sauts, qui sont combinés à des exercices de renforcement comme les pompes. Chorégraphies et musiques donneront du rythme à vos fractionnés, pour une endurance décuplée..",
                    Intensity = TrainingProgram.eIntensity.Extreme,
                    Duration = 45,
                    Calories = 750
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 4,
                    Name = "Body Pump",
                    Description = "Bienvenue au  Body Pump ! Ce Group training LesMills tonifie et renforce le corps tout entier en permettant à vos muscles de se sculpter sans prendre de volume. Les mouvements sont simples et le nombre de répétitions est élevé : le secret des muscles fins et athlétiques.",
                    Intensity = TrainingProgram.eIntensity.Hard,
                    Duration = 45,
                    Calories = 500
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 5,
                    Name = "Body Sculpt",
                    Description = "Fruit de la rencontre entre le step et le Body Pump, le Body Sculpt vous aide à redessiner votre silhouette. Elastiques, haltères et bâtons sont les accessoires-clés pour parvenir à cet objectif, dans le cadre d’un Group training complet et accessible à tous. Après un court échauffement, vous alternez toutes les 5 minutes entre exercices cardio et renforcement musculaire, avant de travailler les abdos et de vous étirer.",
                    Intensity = TrainingProgram.eIntensity.Hard,
                    Duration = 45,
                    Calories = 500
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 6,
                    Name = "Cuisses Abdos Fessiers",
                    Description = "Cours traditionnel de cuisses abdos fessiers permettant de renforcer ses muscles afin de consolider les articulations et de limiter les douleurs dorsales.",
                    Intensity = TrainingProgram.eIntensity.Hard,
                    Duration = 30,
                    Calories = 300
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 7,
                    Name = "Hiit",
                    Description = "Le Hiit ou High Intensity Interval Training est un type d'entrainement bien connu pour son efficacité. C'est un cours où vous travaillerez principalement vos capacités cardio-vasculaires en association avec des mouvements de musculation. Le HIIT est un cours full body intense et complet qui permet aussi bien de travailler le renforcement musculaire que l'endurance, tout en se défoulant.",
                    Intensity = TrainingProgram.eIntensity.Extreme,
                    Duration = 30,
                    Calories = 700
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 8,
                    Name = "Pilates",
                    Description = "Prendre conscience de son corps en le musclant, c’est ce que propose le Pilates. Le pilate s’inspire de la danse, de la gymnastique et du yoga. Toute la séance est rythmée par des musiques zen et relaxantes. Tour à tour, vous alternez entre exercices d’équilibre afin de muscler la ceinture abdominale et exercices d’assouplissement, debout ou au sol, afin d’étirer les tendons et les muscles.",
                    Intensity = TrainingProgram.eIntensity.Medium,
                    Duration = 45,
                    Calories = 300
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 9,
                    Name = "Step",
                    Description = "Initiez-vous à l’art du Step en enchaînant des chorégraphies sur et autour d’une marche à hauteur réglable, sur fond de musique rythmée. Montez, descendez, tournez : de la coordination, vous en aurez besoin à coups sûr ! Vous brûlerez aussi beaucoup de calories, quasiment sans vous en rendre compte tellement vous serez concentré sur vos mouvements !",
                    Intensity = TrainingProgram.eIntensity.Easy,
                    Duration = 45,
                    Calories = 550
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 10,
                    Name = "Stretching",
                    Description = "Ce cours est un mix entre le Yoga et le Pilates. Il permet, grâce à des étirements, de travailler sa posture, en particulier celle du dos, en étirant la colonne vertébrale et en évitant le tassement des vertèbres. Les exercices effectués pendant la séance aident à augmenter la souplesse générale du corps en assouplissant et en renforçant l'élasticité des tendons et des muscles. Cela permet également de retrouver une silhouette affinée et plus harmonieuse.",
                    Intensity = TrainingProgram.eIntensity.Easy,
                    Duration = 60,
                    Calories = 500
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 11,
                    Name = "RPM",
                    Description = "Son nom signifie « Round Per minute », soit tour à la minute en français.  Entraîné par une musique électrisante, vous pédalez et donnez le meilleur de vous-même pour atteindre votre cible. Ici, l’objectif est de vous entraîner comme à l’extérieur mais de façon plus intensive.",
                    Intensity = TrainingProgram.eIntensity.Extreme,
                    Duration = 45,
                    Calories = 600
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 12,
                    Name = "Yoga",
                    Description = "Entre dynamisme et calme, ce cours permet de gagner en force et en souplesse tout en respirant. Allez un peu plus loin chaque jour tout en respectant votre corps, en laissant frustration et égo de côté. Ressentez les postures du flow plutôt que d'essayer de dépasser vos limites. En apprenant à écouter son corps, on se connecte plus à son mental, pour plus de maîtrise de soi.",
                    Intensity = TrainingProgram.eIntensity.Medium,
                    Duration = 60,
                    Calories = 400
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 13,
                    Name = "Zumba",
                    Description = "De la chorégraphie, toujours et encore pour vous faire bouger sur des rythmes endiablés. De la salsa au merengue, en passant par la cumbia, le reggaeton, le kuduro… De la variété plus qu’il n’en faut au sein d’un Group training aussi efficace qu’amusant.",
                    Intensity = TrainingProgram.eIntensity.Easy,
                    Duration = 45,
                    Calories = 550
                });

           

            //Formula

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 1,
                    Name = "Classique fit 1",
                    Description = "L'abonnement mensuel CLASSIQUE FIT à 29€/mois vous donne accès à tous les clubs FITNESS GYM pour profiter de tous les appareils de musculations et cardio ainsi que de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est AVEC engagement sur une période de 12 mois et est valable de date à date.",
                    Price = 29,                 
                    Commitement = Formula.eCommitement.Yes
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 2,
                    Name = "Classique fit 2",
                    Description = "L'abonnement mensuel CLASSIQUE FIT à 34€/mois vous donne accès à tous les clubs FITNESS GYM pour profiter de tous les appareils de musculations et cardio ainsi que de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est SANS engagement et valable de date à date. Seule la période en cours est due.",
                    Price = 34,
                    Commitement = Formula.eCommitement.None
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 3,
                    Name = "Premium fit 1",
                    Description = "L'abonnement mensuel PREMIUM FIT à 36€/mois vous donne accès à tous les clubs FITNESS GYM pour y pratiquer les activités de sports de fitness et musculation, participer à une multitude de cours ainsi profiter de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est AVEC engagement sur une période de 12 mois et est valable de date à date.",
                    Price = 36,
                    Commitement = Formula.eCommitement.Yes
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 4,
                    Name = "Premium fit 2",
                    Description = "L'abonnement mensuel PREMIUM FIT à 40€/mois vous donne accès à tous les clubs FITNESS GYM pour y pratiquer les activités de sports de fitness et musculation, participer à une multitude de cours ainsi profiter de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est SANS engagement et valable de date à date. Seule la période en cours est due.",
                    Price = 40,
                    Commitement = Formula.eCommitement.None
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 5,
                    Name = "No Gym No Problem Month",
                    Description = "Abonnement mensuel de 9€/mois sans engagement, sans période d'essai, seule la période en cours est due. Accès en illimités aux cours et programmes en ligne.",
                    Price = 9,
                    Commitement = Formula.eCommitement.None
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 6,
                    Name = "No Gym No Problem Year",
                    Description = "Abonnement annuel de 29€/mois sans engagement, sans période d'essai, seule la période en cours est due. Accès en illimités aux cours et programmes en ligne.",
                    Price = 29,
                    Commitement = Formula.eCommitement.None
                });

            

            //Location

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 1,
                    Name = "Fitness Gym Austerlitz",
                    Address = "22 bis boulevard Saint Marcel",
                    City = "Paris",
                    PostalCode = 75005,
                    MaxParticipants = 500                   
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 2,
                    Name = "Fitness Gym Bastille",
                    Address = "4/6 Passage Louis Philippe",
                    City = "Paris",
                    PostalCode = 75011,
                    MaxParticipants = 450
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 3,
                    Name = "Fitness Gym BNF",
                    Address = "123 Avenue de France ",
                    City = "Paris",
                    PostalCode = 75013,
                    MaxParticipants = 350
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 4,
                    Name = "Fitness Gym Opera",
                    Address = "21 rue de la banque",
                    City = "Paris",
                    PostalCode = 75002,
                    MaxParticipants = 350
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 5,
                    Name = "Fitness Gym Montparnasse",
                    Address = "6 allée de la 2ème Division Blindée",
                    City = "Paris",
                    PostalCode = 75014,
                    MaxParticipants = 500
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 6,
                    Name = "Fitness Gym Nation",
                    Address = "81 rue de Lagny ",
                    City = "Paris",
                    PostalCode = 75020,
                    MaxParticipants = 500
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 7,
                    Name = "Fitness Gym Saint-Lazarre",
                    Address = "44 rue de Clichy ",
                    City = "Paris",
                    PostalCode = 75009,
                    MaxParticipants = 450
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 8,
                    Name = "Fitness Gym La défense",
                    Address = "19, avenue de la Liberté",
                    City = "Nanterre",
                    PostalCode = 92000,
                    MaxParticipants = 600
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 9,
                    Name = "Fitness Gym Villejuif",
                    Address = "18-20, rue Auguste Perret",
                    City = "Villejuif",
                    PostalCode = 94800,
                    MaxParticipants = 550
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 10,
                    Name = "Fitness Gym Versailles",
                    Address = "11, Rue Exelmans",
                    City = "Versailles",
                    PostalCode = 78000,
                    MaxParticipants = 600
                });



            //Speciality (Specilization)

            modelBuilder.Entity<Speciality>().HasData(
                new Speciality()
                {
                    Id= 1,
                    Name = "Yoga Expert"
                });
            modelBuilder.Entity<Speciality>().HasData(
                new Speciality()
                {
                    Id = 2,
                    Name = "Bodybuilder"
                });
            modelBuilder.Entity<Speciality>().HasData(
                new Speciality()
                {
                    Id = 3,
                    Name = "Hiit Expert"
                });
            modelBuilder.Entity<Speciality>().HasData(
                new Speciality()
                {
                    Id = 4,
                    Name = "Cardio"
                });
            

            //Coach 

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 1,
                    FirstName = " Quentin",
                    LastName = "H.",
                    Photo = "/Assets/Images/Quentin H.jfif",                   
                    IdSpeciality = 1,
                    
                });
            modelBuilder.Entity<Coach>().HasData(
            new Coach()
                {
                    ID = 2,
                    FirstName = "Léonce",
                    LastName = " L.",
                    //Photo = "",
                    IdSpeciality = 2,
                    
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 3,
                    FirstName = " Guillaume",
                    LastName = " J.",
                    //Photo = "",
                    IdSpeciality = 3,
                    
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 4,
                    FirstName = " Anthony",
                    LastName = " J.",
                    //Photo = "",
                    IdSpeciality = 1,
                    
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 5,
                    FirstName = " Romain",
                    LastName = "G.",
                    //Photo = "",
                    IdSpeciality = 1,
                    
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 6,
                    FirstName = "Lia",
                    LastName = "T.",
                    //Photo = "",
                    IdSpeciality = 4,
                    
                });



            //Individual Program

            modelBuilder.Entity<IndividualProgram>().HasData(
                new IndividualProgram()
                {
                    Id = 1,
                    IdTrainingProgram = 1,
                    IdExercise = 2,               

                });

            modelBuilder.Entity<IndividualProgram>().HasData(
                new IndividualProgram()
                {
                    Id = 2,
                    IdTrainingProgram = 2,
                    IdExercise = 4,

                });

            modelBuilder.Entity<IndividualProgram>().HasData(
                new IndividualProgram()
                {
                    Id = 3,
                    IdTrainingProgram = 3,
                    IdExercise = 1,

                });

            modelBuilder.Entity<IndividualProgram>().HasData(
                new IndividualProgram()
                {
                    Id = 4,
                    IdTrainingProgram = 4,
                    IdExercise = 5,

                });

            modelBuilder.Entity<IndividualProgram>().HasData(
                new IndividualProgram()
                {
                    Id = 5,
                    IdTrainingProgram = 5,
                    IdExercise = 3,

                });


            //Session

            modelBuilder.Entity<Session>().HasData(
                new Session()
                {
                    Id = 1,
                    //Date = "15/01/2023",
                    //Time = 
                    MaxParticipants = 15,
                    IdTrainingProgram = 1,
                    IdCoach = 1,
                    IdLocation = 2,
                    IdFormula = 3 
                });

            modelBuilder.Entity<Session>().HasData(
                new Session()
                {
                    Id = 2,
                    //Date = 15/01/2023,
                    //Time,
                    MaxParticipants = 15,
                    IdTrainingProgram = 2,
                    IdCoach = 5,
                    IdLocation = 7,
                    IdFormula = 3
                });

            modelBuilder.Entity<Session>().HasData(
                new Session()
                {
                    Id = 3,
                    //Date = 16/01/2023,
                    //Time,
                    MaxParticipants = 15,
                    IdTrainingProgram = 3,
                    IdCoach = 5,
                    IdLocation = 9,
                    IdFormula = 4
                });

            modelBuilder.Entity<Session>().HasData(
                new Session()
                {
                    Id = 4,
                    //Date = 14/01/2023,
                    //Time,
                    MaxParticipants = 15,
                    IdTrainingProgram = 4,
                    IdCoach = 3,
                    IdLocation = 8,
                    IdFormula = 4
                });

            modelBuilder.Entity<Session>().HasData(
                new Session()
                {
                    Id = 5,
                    //Date = 15/01/2023,
                    //Time,
                    MaxParticipants = 15,
                    IdTrainingProgram = 2,
                    IdCoach = 1,
                    IdLocation = 3,
                    IdFormula = 3
                });


            //Client

            modelBuilder.Entity<Client>().HasData(
                new Client()
                {
                    ID = 1,
                    FirstName = "Rachel",
                    LastName = "Wiliam",
                    Sex = Client.eSex.Women,
                    Height = 170,
                    Weight = 75,
                    //Birthdate = 28.01.1990,
                    Phonenumber = 0620285591,
                    Adresse = "Rue du Chateau, 95110 Paris",
                    Email = "Rachel@gmail.com",
                    Password = "rachel",
                    Diseases = "None",
                    Hobbies = "Danse, volley-ball",
                    Newsletter = Client.eNewsletter.Yes,
                    Freetrial = Client.eFreetrial.Yes,                  
                });

            modelBuilder.Entity<Client>().HasData(
                new Client()
                {
                    ID = 2,
                    FirstName = "Richy",
                    LastName = "Wiliam",
                    Sex = Client.eSex.Men,
                    Height = 170,
                    Weight = 85,
                    //Birthdate = 28.01.1990,
                    Phonenumber = 0633504482,
                    Adresse = "Rue du Chateau, 95110 Paris",
                    Email = "Richy@gmail.com",
                    Password = "Richy",
                    Diseases = "diabetes",
                    Hobbies = "Sport",
                    Newsletter = Client.eNewsletter.No,
                    Freetrial = Client.eFreetrial.No,
                });           


            //Subscription

            modelBuilder.Entity<Subscription>().HasData(
                new Subscription()
                {
                    Id = 1,
                    //Entrydate = 01/01/2023,
                    //Sortdate = 01/01/2024,
                    IdClient = 1,                    
                    IdFormula = 3
                });

            modelBuilder.Entity<Subscription>().HasData(
                new Subscription()
                {
                    Id = 2,
                    //Entrydate = 01/01/2023,
                    //Sortdate = 01/01/2024,
                    IdClient = 2,
                    IdFormula = 4
                });



            //Reservation

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation()
                {
                    Id = 1,                   
                    Cancelled = 0,
                    IdSession = 1,
                    IdClient = 1                   
                });

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation()
                {
                    Id = 2,
                    Cancelled = 0,
                    IdSession = 1,
                    IdClient = 1
                });

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation()
                {
                    Id = 3,
                    Cancelled = 0,
                    IdSession = 1,
                    IdClient = 2
                });

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation()
                {
                    Id = 4,
                    Cancelled = 1,
                    IdSession = 1,
                    IdClient = 2
                });


            //Goal

            modelBuilder.Entity<Goal>().HasData(
                new Goal()
                {
                    Id = 1,
                    Weight = 75,
                    Frequency = Goal.eFrequency.Tree,
                    CaloriesBurnt = 1000,
                    IdClient = 1
                });


            //Machine

            modelBuilder.Entity<Machine>().HasData(
                new Machine()
                {
                    ID = 1,
                    Name = "Tapis de course",
                    //Photo = 
                    Description = "Améliorez votre endurance avec ce tapis de course qui absorbe le choc des impacts par rapport à la course en extérieur. Marcher, trottiner, courir, sprinter : vous pourrez choisir votre allure en fonction de votre forme ou de votre entraînement. Vous pouvez également augmenter la pente pour intensifier le travail."
                });

            modelBuilder.Entity<Machine>().HasData(
                new Machine()
                {
                    ID = 2,
                    Name = "Vélo elliptique",
                    //Photo = 
                    Description = "Le vélo elliptique, cet incontournable des salles de sport, associe travail cardiovasculaire doux et travail musculaire sans impacts ni douleurs pour les articulations. La particularité de ce vélo ? Ses bras sont mobiles, ce qui vous permettra de solliciter 90% des muscles du corps en reproduisant les mouvements du ski de fond."
                });

            modelBuilder.Entity<Machine>().HasData(
                new Machine()
                {
                    ID = 3,
                    Name = "Vélo semi-allongé",
                    //Photo = 
                    Description = "Ce vélo d’intérieur particulièrement ergonomique vous permet de réaliser des entraînements intenses, de développer vos capacités-cardio-vasculaires et de renforcer vos cuisses. Il possède toutes les fonctions d’un vélo de course : selle ajustable et fine permettant le pédalage en danseuse, guidon anatomique, pédales automatiques, système de freinage et cadre robuste."
                });

            modelBuilder.Entity<Machine>().HasData(
                new Machine()
                {
                    ID = 4,
                    Name = "Rameur",
                    //Photo = 
                    Description = "Contrairement à ce que l'on pense, le rameur ne permet pas uniquement de travailler le haut du corps. Les jambes sont aussi très sollicitées et plus vous maîtrisez la technique, plus vous le ressentez ! Bras, épaules, jambes, abdominaux, lombaires… : en réalité, tous les muscles du corps sont mobilisés et renforcés, faisant du rameur un appareil très complet."
                });

            modelBuilder.Entity<Machine>().HasData(
                new Machine()
                {
                    ID = 5,
                    Name = "Glute Drive",
                    //Photo = 
                    Description = "Idéale pour muscler les fessiers, cette machine vous laisse atteindre une extension maximale. Cela dit, aucun risque pour le bas de votre dos car la hanche n'effectue aucune rotation."
                });


            //Product

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Tapis de fitness",
                    //Photo = 
                    Description = "Un tapis spécialement conçu pour s’adapter à vos exercices au sol. Vous pourrez faire vos abdominaux ou réaliser vos étirements confortablement."
                });






            /*public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DBContext>();
             
                context.Database.EnsureCreated();                            

                //Exercice

                if (!context.Exercise.Any())
                {
                    context.Exercise.AddRange(new List<Exercise>()
                    {
                         new Exercise()
                        {
                            Name = "Body Attack",                           
                            Description = "Description"
                        }
                    }
                    );
                    context.SaveChanges();
                }                            

            }
        }*/





        }
    }
}
