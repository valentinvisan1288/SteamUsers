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
       // StudentGrade.GradeConverter();
        SteamMethods.PalindromeForeach("asdfghjkl");
        SteamMethods.PalindromeForeach("abba");
        SteamMethods.PalindromeForeach("xxx");


        Console.WriteLine($"\n ======== 16.11 ======== \n");
        string randomLetters = "abc opq";
        SteamMethods.SpaceTrimmer(randomLetters);
        List<int> randomNumbers = [56137];
        SteamMethods.NumberSorter();

        //SteamMethods.GuessingGame();
        //SteamMethods.Calculator("Subtraction",[212, 468]);

        Console.WriteLine($"\n ======== 23.11 ======== \n");
        SteamMethods.ArrayOperatorHighestNumberFinder([7,3,2,8,1,9,06,1000]);
        SteamMethods.ArrayOperatorLowestNumberFinder([7,3,2,8,1,9,06,-100]);
        SteamMethods.ArrayOperatorAverageCalculator([7,3,2,8,1,9]);
        SteamMethods.ArrayOperatorAverageCalculator([100,1000,88888]);
        SteamMethods.ArrayOperatorReverser([7,3,2,8,1,9]);
        Console.WriteLine($"\n ======== With Delegate ======== \n");
        SteamMethods.ArrayOperator([5,16,2,80,0,4], SteamMethods.ArrayOperatorHighestNumberFinder);
        SteamMethods.ArrayOperator([5,16,2,80,0,4], SteamMethods.ArrayOperatorLowestNumberFinder);
        SteamMethods.ArrayOperator([1,5,8], SteamMethods.ArrayOperatorReverser);
        SteamMethods.ArrayOperator([5,16,2,80,0,4], SteamMethods.ArrayOperatorAverageCalculator);
        SteamMethods.Calculator("Sum",[2,2]);
        SteamMethods.Calculator("Subtraction",[20, 5, 3, 1]);
        SteamMethods.Calculator("Multiplication",[1, 5, 5]);
        SteamMethods.Calculator("Multiplication",[0,1000]);
        SteamMethods.Calculator("Division",[1000, 10 , 10 , 2]);
    }
}


