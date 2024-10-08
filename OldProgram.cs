using SteamUsers;

public class OldProgram
{
    public static void MainOld(string[] args)
    {

        //Pisica p1 = new Pisica();
        SteamActions steamActions = new SteamActions();
        SteamGame hellDivers = new SteamGame("Hell Divers",39.99, "Shooter", 10, false);
        SteamGame hellDiversDoi = new SteamGame("Hell Divers 2", 69.00, "MOBA", 11, true);
        SteamGame dota = new SteamGame("DOTA", 0, "Moba", 5, false);
        SteamGame slayTheSpire = new SteamGame("Slay the Spire",20,"Card Game", 8, true);

        SteamGame eldenRing = new SteamGame("Elden Ring",59.99, "RPG", 5, true);
        SteamGame superAutoPets = new SteamGame("Super-Auto-Pets",9.50, "Auto Battler", 7, false);
        SteamGame elderScrollsSkyrim = new SteamGame("Elder Scrolls: Skyrim", 35, "Open World", 10, false);
        SteamGame falloutFour = new SteamGame ("Fallout 4", 26.78, "Post Apocalyptic", 9, true);


        slayTheSpire.Price = 16;
        System.Console.WriteLine(slayTheSpire.Price);

        List<SteamGame> steamGamesList = new List<SteamGame>()
        {
           hellDivers,
           hellDiversDoi,
           dota,
           slayTheSpire,
           eldenRing,
           superAutoPets,
           elderScrollsSkyrim,
           falloutFour
        };

        Console.WriteLine($"hellDivers price is " + hellDivers.Price);

        var averageRating = steamActions.AverageCalculator(hellDivers.Rating, hellDiversDoi.Rating, dota.Rating);
        steamActions.PriceIncrease(10, hellDivers.Price, hellDiversDoi.Price, dota.Price);

        
        Console.WriteLine("Homework results =============================");

        SteamActions.PriceExtractor(steamGamesList);
        var gameListPrices = SteamActions.PriceExtractor(steamGamesList);
        SteamActions.PriciestGame(gameListPrices);
        SteamActions.TotalPrice(steamGamesList);
        SteamActions.DiscountedPrice(hellDivers.Price, 15);
        SteamActions.DiscountedPrice(hellDivers.Price, 10);       
        SteamActions.RatingIncrease(hellDiversDoi);
        SteamActions.DoublePrice(elderScrollsSkyrim.Price);


        Console.WriteLine($"\n ======== Homework 21.09 ======== \n");
        SteamActions.ListIterated(steamGamesList);
        //SteamActions.RatingChecker(steamGamesList);
        //SteamActions.RatingCheckerAlt(steamGames);
        SteamActions.TotalPrice(steamGamesList);
        SteamActions.LetterChecker(slayTheSpire, 2);
        SteamActions.LetterChecker(eldenRing, 5);
        SteamActions.LetterChecker(slayTheSpire, 4);
        SteamActions.PriceEstimator(falloutFour);
        SteamActions.PalindromeChecker(elderScrollsSkyrim);

        SteamGame ABBA = new SteamGame("ABBA", 20, "This is a Band", 00, true);
        SteamActions.PalindromeChecker(ABBA);

        //SteamActions.RatingChecker(steamGamesList);
        //SteamActions.RatingCheckerAlt(steamGamesList);
        //RatingCheckerAltDoi(steamGamesList);


        Console.WriteLine("======== if practice ======");
        SteamActions.IfPractice(dota);
        SteamActions.IfPractice(superAutoPets);
        SteamActions.IfPractice(hellDiversDoi);
        Console.WriteLine("======== switch practice ======");
        SteamActions.SwitchPractice(dota.Rating);
        SteamActions.SwitchPractice(hellDiversDoi.Rating);
        SteamActions.SwitchPractice2(eldenRing.Name);
        SteamActions.SwitchPractice2(elderScrollsSkyrim.Name);

        Console.WriteLine($"\n ======== Homework 04.10 ======== \n");
        SteamActions.MustPlayChecker(steamGamesList);
        var (mustPlayList, mayPlayList) = SteamActions.MustPlayChecker(steamGamesList);
        SteamActions.MustPlayListIterator(mustPlayList, mayPlayList);
        SteamActions.IntervalPriceChecker(steamGamesList);
        SteamActions.IntervalPriceLister(steamGamesList);
    }
}

