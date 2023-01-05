using Elfie.Serialization;
using FitnessGymApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using NuGet.ContentModel;

namespace FitnessGymApplication.Data.Seeding
{
    public class AppDBContextSeed
    {
        public static object Commitement { get; private set; }

        public static void Seed(ModelBuilder modelBuilder)
        {

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
                    Name = "Body Attack",
                    Description = "Fentes, squats, jumping jacks : plongez au cœur du Body Attack ! La dynamique de groupe vous donnera une énergie incroyable pour réaliser un entraînement de haute intensité. On y retrouve des mouvements athlétiques comme la course, les flexions ou les sauts, qui sont combinés à des exercices de renforcement comme les pompes. Chorégraphies et musiques donneront du rythme à vos fractionnés, pour une endurance décuplée..",                   
                    Duration = 45,
                    Calories = 750
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 2,
                    Name = "Body Pump",
                    Description = "Bienvenue au  Body Pump ! Ce Group training LesMills tonifie et renforce le corps tout entier en permettant à vos muscles de se sculpter sans prendre de volume. Les mouvements sont simples et le nombre de répétitions est élevé : le secret des muscles fins et athlétiques.",
                    Duration = 45,
                    Calories = 500
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 3,
                    Name = "Body Sculpt",
                    Description = "Fruit de la rencontre entre le step et le Body Pump, le Body Sculpt vous aide à redessiner votre silhouette. Elastiques, haltères et bâtons sont les accessoires-clés pour parvenir à cet objectif, dans le cadre d’un Group training complet et accessible à tous. Après un court échauffement, vous alternez toutes les 5 minutes entre exercices cardio et renforcement musculaire, avant de travailler les abdos et de vous étirer.",
                    Duration = 45,
                    Calories = 500
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 4,
                    Name = "Cuisses Abdos Fessiers",
                    Description = "Cours traditionnel de cuisses abdos fessiers permettant de renforcer ses muscles afin de consolider les articulations et de limiter les douleurs dorsales.",
                    Duration = 30,
                    Calories = 300
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 5,
                    Name = "Hiit",
                    Description = "Le Hiit ou High Intensity Interval Training est un type d'entrainement bien connu pour son efficacité. C'est un cours où vous travaillerez principalement vos capacités cardio-vasculaires en association avec des mouvements de musculation. Le HIIT est un cours full body intense et complet qui permet aussi bien de travailler le renforcement musculaire que l'endurance, tout en se défoulant.",
                    Duration = 30,
                    Calories = 700
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 6,
                    Name = "Step",
                    Description = "Initiez-vous à l’art du Step en enchaînant des chorégraphies sur et autour d’une marche à hauteur réglable, sur fond de musique rythmée. Montez, descendez, tournez : de la coordination, vous en aurez besoin à coups sûr ! Vous brûlerez aussi beaucoup de calories, quasiment sans vous en rendre compte tellement vous serez concentré sur vos mouvements !",
                    Duration = 45,
                    Calories = 550
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 7,
                    Name = "Stretching",
                    Description = "Ce cours est un mix entre le Yoga et le Pilates. Il permet, grâce à des étirements, de travailler sa posture, en particulier celle du dos, en étirant la colonne vertébrale et en évitant le tassement des vertèbres. Les exercices effectués pendant la séance aident à augmenter la souplesse générale du corps en assouplissant et en renforçant l'élasticité des tendons et des muscles. Cela permet également de retrouver une silhouette affinée et plus harmonieuse.",
                    Duration = 60,
                    Calories = 500
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 8,
                    Name = "RPM",
                    Description = "Son nom signifie « Round Per minute », soit tour à la minute en français.  Entraîné par une musique électrisante, vous pédalez et donnez le meilleur de vous-même pour atteindre votre cible. Ici, l’objectif est de vous entraîner comme à l’extérieur mais de façon plus intensive.",
                    Duration = 45,
                    Calories = 600
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 9,
                    Name = "Yoga",
                    Description = "Entre dynamisme et calme, ce cours permet de gagner en force et en souplesse tout en respirant. Allez un peu plus loin chaque jour tout en respectant votre corps, en laissant frustration et égo de côté. Ressentez les postures du flow plutôt que d'essayer de dépasser vos limites. En apprenant à écouter son corps, on se connecte plus à son mental, pour plus de maîtrise de soi.",
                    Duration = 60,
                    Calories = 400
                });

            modelBuilder.Entity<TrainingProgram>().HasData(
                new TrainingProgram()
                {
                    Id = 10,
                    Name = "Zumba",
                    Description = "De la chorégraphie, toujours et encore pour vous faire bouger sur des rythmes endiablés. De la salsa au merengue, en passant par la cumbia, le reggaeton, le kuduro… De la variété plus qu’il n’en faut au sein d’un Group training aussi efficace qu’amusant.",
                    Duration = 45,
                    Calories = 550
                });

        

            //Formula

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 1,
                    Name = "Classique fit",
                    Description = "L'abonnement mensuel CLASSIQUE FIT à 29€/mois vous donne accès à tous les clubs FITNESS GYM pour profiter de tous les appareils de musculations et cardio ainsi que de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est AVEC engagement sur une période de 12 mois et est valable de date à date.",
                    Price = 29,                 
                    Commitement = Formula.eCommitement.Yes
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 2,
                    Name = "Classique fit",
                    Description = "L'abonnement mensuel CLASSIQUE FIT à 34€/mois vous donne accès à tous les clubs FITNESS GYM pour profiter de tous les appareils de musculations et cardio ainsi que de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est SANS engagement et valable de date à date. Seule la période en cours est due.",
                    Price = 34,
                    Commitement = Formula.eCommitement.None
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 3,
                    Name = "Premium fit",
                    Description = "L'abonnement mensuel PREMIUM FIT à 36€/mois vous donne accès à tous les clubs FITNESS GYM pour y pratiquer les activités de sports de fitness et musculation, participer à une multitude de cours ainsi profiter de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est AVEC engagement sur une période de 12 mois et est valable de date à date.",
                    Price = 36,
                    Commitement = Formula.eCommitement.Yes
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 4,
                    Name = "Premium fit",
                    Description = "L'abonnement mensuel PREMIUM FIT à 40€/mois vous donne accès à tous les clubs FITNESS GYM pour y pratiquer les activités de sports de fitness et musculation, participer à une multitude de cours ainsi profiter de l'accès aux piscines dans les conditions du règlement intérieur. Cet abonnement est SANS engagement et valable de date à date. Seule la période en cours est due.",
                    Price = 40,
                    Commitement = Formula.eCommitement.None
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 5,
                    Name = "No Gym No Problem",
                    Description = "Abonnement mensuel de 9€/mois sans engagement, sans période d'essai, seule la période en cours est due. Accès en illimités aux cours et programmes en ligne.",
                    Price = 9,
                    Commitement = Formula.eCommitement.None
                });

            modelBuilder.Entity<Formula>().HasData(
                new Formula()
                {
                    ID = 6,
                    Name = "No Gym No Problem",
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
                    MaxParticipants = 200                   
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 2,
                    Name = "Fitness Gym Bastille",
                    Address = "4/6 Passage Louis Philippe",
                    City = "Paris",
                    PostalCode = 75011,
                    MaxParticipants = 200
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 3,
                    Name = "Fitness Gym BNF",
                    Address = "123 Avenue de France ",
                    City = "Paris",
                    PostalCode = 75013,
                    MaxParticipants = 150
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 4,
                    Name = "Fitness Gym Opera",
                    Address = "21 rue de la banque",
                    City = "Paris",
                    PostalCode = 75002,
                    MaxParticipants = 150
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 5,
                    Name = "Fitness Gym Montparnasse",
                    Address = "6 allée de la 2ème Division Blindée",
                    City = "Paris",
                    PostalCode = 75014,
                    MaxParticipants = 150
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 6,
                    Name = "Fitness Gym Nation",
                    Address = "81 rue de Lagny ",
                    City = "Paris",
                    PostalCode = 75020,
                    MaxParticipants = 250
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 7,
                    Name = "Fitness Gym Saint-Lazarre",
                    Address = "44 rue de Clichy ",
                    City = "Paris",
                    PostalCode = 75009,
                    MaxParticipants = 220
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 8,
                    Name = "Fitness Gym La défense",
                    Address = "19, avenue de la Liberté",
                    City = "Nanterre",
                    PostalCode = 92000,
                    MaxParticipants = 250
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 9,
                    Name = "Fitness Gym Villejuif",
                    Address = "18-20, rue Auguste Perret",
                    City = "Villejuif",
                    PostalCode = 94800,
                    MaxParticipants = 250
                });

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    ID = 10,
                    Name = "Fitness Gym Versailles",
                    Address = "11, Rue Exelmans",
                    City = "Versailles",
                    PostalCode = 78000,
                    MaxParticipants = 350
                });



            //Coach 

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 1,
                    FirstName = " Quentin",
                    LastName = "H.",
                    Photo = "/Assets/Images/Quentin H.jfif",// C:/Users/FORMATION/source/repos/FitnessGymApp/Fitne/wwwroot/Assets/Images/Quentin H.jfif,
                    //IdSpeciality = ,
                    //Speciality = 
                });
            modelBuilder.Entity<Coach>().HasData(
            new Coach()
                {
                    ID = 2,
                    FirstName = "Léonce",
                    LastName = " L.",
                    //Photo = "",
                    //IdSpeciality = " ",
                    //Speciality =
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 3,
                    FirstName = " Guillaume",
                    LastName = " J.",
                    //Photo = "",
                    //IdSpeciality = " ",
                    //Speciality =
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 4,
                    FirstName = " Anthony",
                    LastName = " J.",
                    //Photo = "",
                    //IdSpeciality = " ",
                    //Speciality =
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 5,
                    FirstName = " Romain",
                    LastName = "G.",
                    //Photo = "",
                    //IdSpeciality = " ",
                    //Speciality =
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 6,
                    FirstName = "Lia",
                    LastName = "T.",
                    //Photo = "",
                    //IdSpeciality = " ",
                    //Speciality =
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 7,
                    FirstName = "Florian",
                    LastName = "H.",
                    //Photo = "",
                    //IdSpeciality = " ",
                    //Speciality =
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 8,
                    FirstName = "Mélodie",
                    LastName = "C.",
                    //Photo = "",
                    //IdSpeciality = " ",
                    //Speciality =
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 9,
                    FirstName = "Nabil",
                    LastName = "C.",
                    //Photo = "",
                    //IdSpeciality = " ",
                    //Speciality =
                });

            modelBuilder.Entity<Coach>().HasData(
                new Coach()
                {
                    ID = 10,
                    FirstName = "Guillaume",
                    LastName = "P.",
                    //Photo = "",
                    //IdSpeciality = " ",
                    //Speciality =
                });


            //Machine


            //Product


            //Subscription


            //Individual Program


            //Speciality (Specilization)


            //Session

            //Reservation






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
