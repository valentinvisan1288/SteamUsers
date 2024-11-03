using SteamUsers;
using Animale;
using Homework;

public class ConsoleProgram
{
    public static void Main(string[] args)
    {
        SteamActions steamActions = new SteamActions();
        SteamGame hellDivers = new SteamGame("Hell Divers", 39.99, "Shooter", 10, false);
        SteamGame hellDiversDoi = new SteamGame("Hell Divers 2", 69.00, "MOBA", 11, true);
        SteamGame dota = new SteamGame("DOTA", 0, "Moba", 5, false);
        SteamGame slayTheSpire = new SteamGame("Slay the Spire", 20, "Card Game", 8, true);
        SteamGame eldenRing = new SteamGame("Elden Ring", 59.99, "RPG", 5, true);
        SteamGame superAutoPets = new SteamGame("Super-Auto-Pets", 9.50, "Auto Battler", 7, false);
        SteamGame elderScrollsSkyrim = new SteamGame("Elder Scrolls: Skyrim", 35, "Open World", 10, false);
        SteamGame falloutFour = new SteamGame("Fallout 4", 26.78, "Post Apocalyptic", 9, true);

        List<SteamGame> firstSteamGameList = [hellDivers, hellDiversDoi, dota, slayTheSpire, eldenRing];

        SteamMethods.ForMethod(firstSteamGameList);

        SteamUser steamUserInitial = new SteamUser("User One", 2, GamerLevel.Noob, firstSteamGameList);
        SteamUser Bob = new SteamUser("Displazya", 37, GamerLevel.Intermediate, [dota, slayTheSpire]);

        SteamMethods.WhileMethod(firstSteamGameList);





        Console.WriteLine($"\n ======== Homework 21.10 ======== \n");
        ObjectNine objectNine = new ObjectNine("vali", 36, [10,12,14,16]);
        Pisica Pisica = new(4,"Cocolino",4);
        Console.WriteLine( Pisica.Nume);
        Caine caineUnu = new(3, "Tripod", 7, false);
        Console.WriteLine(caineUnu.Varsta);
        StudentGrade.GradeConverter();
        SteamMethods.PalindromeForeach("asdfghjkl");
        SteamMethods.PalindromeForeach("abba");
        SteamMethods.PalindromeForeach("xxx");


    }
}

