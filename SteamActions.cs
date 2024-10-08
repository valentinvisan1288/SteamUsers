namespace SteamUsers;

public class SteamActions
{
    /// <summary>
    /// Daca pretul average > 50 && unul din ele este shooter, atunci printam "eu nu am bani de shooter"
    /// </summary>
    public static void GenreChecker(string genreOne, string genreTwo, string genreThree, double averateRating)
    {
        if ((genreOne == "Shooter" || genreTwo == "Shooter" || genreThree == "Shooter") && averateRating < 50)
        {
            Console.WriteLine("Eu nu am bani de shooter");
        }
        else
        {
            Console.WriteLine("Avem bani de shooter");
        }
    }
    // o metoda care printeze average rating pt toate jocurile;
    public double AverageCalculator(double ratingOne, double ratingTwo, double ratingThree)
    {
        double averageRating = (ratingOne + ratingTwo + ratingThree)/3;
        System.Console.WriteLine($"Average game rating is " + averageRating);
        return averageRating;
    }

    /// <summary>
    /// A method that calculates increased price by 10.
    /// Receives three price parameters.
    /// Very demure
    /// </summary>
    public void PriceIncrease(int x, double priceOne, double priceTwo, double priceThree)
    {
        priceOne += x;
        priceTwo += x;
        priceThree += x;
        Console.WriteLine($"Total price is " + (priceOne + priceTwo + priceThree));
    }

    public static void PriciestGame(List<double> steamGamesList)
    {
        double priciestGame = steamGamesList.Max();
        System.Console.WriteLine($"Priciest game is " + priciestGame);        
    }

    public static void TotalPrice(List<SteamGame> steamGamePriceList)
    {
        double sum = 0;
        foreach (var steamGame in steamGamePriceList)
        {
            sum += steamGame.Price;
        }
        Console.WriteLine($"Total game price is: " + sum);
    }

    public static void DiscountedPrice(double gamePrice, int percentageDiscount)
    {
        var newPrice = gamePrice - percentageDiscount * gamePrice / 100;

        Console.WriteLine($"Price has been discounted by " + percentageDiscount + 
        " . Discounted price is " + newPrice);
    }

    public static void RatingIncrease(SteamGame steamGame)
    {
        if (steamGame.IsFinished == true ) 
        {
            steamGame.Rating++;
            Console.WriteLine($"Game is finished, so new rating is " + steamGame.Rating);
        }
    }

    public static void DoublePrice (double gamePrice)
    {
        gamePrice *=2;
        Console.WriteLine($"Doubled price is " + gamePrice);
    }

    public static List<double> PriceExtractor(List<SteamGame> steamGameExtractedList)
    {      
        List<double> steamGamePrices = new List<double>();

            foreach (SteamGame steamGame in steamGameExtractedList)
            {
            steamGamePrices.Add(steamGame.Price);
            }
            Console.WriteLine(steamGamePrices);
            return steamGamePrices;          
    }



    public static void ListIterated(List<SteamGame> steamGameNameList)
    {
        foreach(SteamGame steamGame in steamGameNameList)
        {
            steamGame.Price += 10;
            Console.WriteLine($"The name of the game is " + steamGame.Name + " and new price is "+ steamGame.Price);
        }
    }

    public static List<SteamGame> RatingChecker(List<SteamGame> steamGameRatingList)
    {
        List<SteamGame> steamGameFilteredList = new List<SteamGame>();
        foreach (SteamGame steamGame in steamGameRatingList)
        {
            if (steamGame.Rating >= 6)
            {
            steamGameFilteredList.Add(steamGame);
            }
            Console.WriteLine($"On the SteamGame list the following remains:" + steamGame.Name);  
        }
        return steamGameFilteredList;
    }
    public static List<SteamGame> RatingCheckerAlt
    (List<SteamGame> steamGameRatingList)
    {
        foreach (SteamGame steamGame in steamGameRatingList)
        {
            if (steamGame.Rating < 6)
            {
            steamGameRatingList.Remove(steamGame);
            } 
            Console.WriteLine($"On the SteamGame list the following remains:" + steamGame.Name);      
        }
        return steamGameRatingList;
    }





    public static void MaxManualCheck()
    {
        // x = 0
        // foreach steamGameList[x]
        // x > y => x=y (?)
    }

    public static void LetterChecker(SteamGame steamGame, int x)
    {
        if (x>= 0 && x < steamGame.Genre.Length)
        {
            char steamGameGenre = steamGame.Genre[x];
            Console.WriteLine($"The letter in position " + x + " for the game genre is '" + steamGameGenre + "'");
        }
        else
        {
            Console.WriteLine("Number is too high");
        }
    }

    public static int PriceEstimator(SteamGame steamGame)
    {
        int steamGamePriceInt = (int)steamGame.Price;

        Console.WriteLine($"The estimated price for " +steamGame.Name + " is " + steamGamePriceInt);
        Console.WriteLine($"The estimated price for " +steamGame.Name + " is " 
                            + Math.Round(steamGame.Price, MidpointRounding.AwayFromZero));
        return steamGamePriceInt;
    }

    public static void PalindromeChecker(SteamGame steamGame)
    {
        char[] originalCharArray =  steamGame.Name.ToCharArray();
        string originalCharString = new string(originalCharArray);   
        char[] reversedCharArray = originalCharArray.Reverse().ToArray();
        string reversedCharString = new string(reversedCharArray);
        //Console.WriteLine(palindrome[2]);

       string result = (originalCharString == reversedCharString) ? 
                        ("The Steam Game name for " + steamGame.Name + " is a palindrome") :
                        ("The Steam Game name for " + steamGame.Name + " is a not palindrome");
        System.Console.WriteLine(result);
        // if (originalCharString == reversedCharString)
        // {
        //     Console.WriteLine("The Steam Game name for " + steamGame.Name + " is a palindrome");
        // } 
        // else
        // {
        //     Console.WriteLine("The Steam Game name for " + steamGame.Name + " is a not palindrome");
        // }

    }
    


    public static void IfPractice(SteamGame steamGame)
    {
        if (steamGame.Name == "DOTA" )
        {
            System.Console.WriteLine("This is DOTA");
        } 
        else if (steamGame.Genre == "MOBA")
        {
            System.Console.WriteLine("This is a MOBA");
        }
        else
        {
            System.Console.WriteLine("This is neither DOTA nor a MOBA");
        }
    }

    public static void SwitchPractice(int numarJocuri)
    {
        switch(numarJocuri)
        {
            case 1:
            System.Console.WriteLine("numarJocuri = 1");
            break;
            case 2:
            System.Console.WriteLine("numarJocuri = 2");
            break;
            case 3:
            System.Console.WriteLine("numarJocuri = 3");
            break;
            case 4:
            System.Console.WriteLine("numarJocuri = 4");
            break;
            case 5:
            System.Console.WriteLine("numarJocuri = 5");
            break;
            case 6:
            System.Console.WriteLine("numarJocuri = 6");
            break;
            case 7:
            System.Console.WriteLine("numarJocuri = 7");
            break;
            default:
            System.Console.WriteLine("Default");
            break;
        }
    }
    public static void SwitchPractice2(string numeJocuri)
    {
        switch(numeJocuri)
        {
            case "Hell Divers":
            System.Console.WriteLine("mor cu asta");
            break;
            case "Elden Ring":
            System.Console.WriteLine("Eren Ding");
            break;
            case "Elder Scrolls: Skyrim":
            System.Console.WriteLine("SKYRIM");
            break;
            default:
            System.Console.WriteLine("Default");
            break;
        }
    }

    public static (List<SteamGame> mustPlay, List<SteamGame> mayPlay) MustPlayChecker(List<SteamGame> steamGameList)
    {
        List<SteamGame> mustPlayList = new List<SteamGame>();
        List<SteamGame> mayPlayList = new List<SteamGame>();
       foreach (SteamGame game in steamGameList)
       {
        if (game.Rating > 8)
        {
            mustPlayList.Add(game);

        } else if (game.IsFinished == true)
        {
            mustPlayList.Add(game);
        } else
        {
            mayPlayList.Add(game);
        }
       }
       return (mustPlayList, mayPlayList);
    }

    public static void MustPlayListIterator(List<SteamGame> steamGameMustPlayList, List<SteamGame> steamGameMaybePlayList)
    {
        foreach (SteamGame game in steamGameMustPlayList)
        {
            Console.WriteLine(game.Name + $" is a MustPlay");
        }
        foreach (SteamGame game in steamGameMaybePlayList)
        {
            Console.WriteLine(game.Name + $" is a MaybePlay");
        }
    }

    public static void IntervalPriceChecker(List<SteamGame> steamGameIntervalList)
    {
        foreach (SteamGame steamGame in steamGameIntervalList)
        {
            switch(steamGame.Price)
            {
            case double when steamGame.Price >= 0 && steamGame.Price <= 10:
            Console.WriteLine($"Game price is very cheap: " + steamGame.Name);
            break;
            case double when steamGame.Price > 10 && steamGame.Price <= 20:
            Console.WriteLine($"Game price is average: " + steamGame.Name);
            break;
            case double when steamGame.Price > 20 && steamGame.Price <= 30:
            Console.WriteLine($"Game price is good: " + steamGame.Name);
            break;
            case double when steamGame.Price > 40 && steamGame.Price <= 50:
            Console.WriteLine($"Game price is high: " + steamGame.Name);
            break;
            case double when steamGame.Price > 50 && steamGame.Price <= 60:
            Console.WriteLine($"Game price is AAA: " + steamGame.Name);
            break;
            case double when steamGame.Price > 60 :
            Console.WriteLine($"Wait for discount: " + steamGame.Name);
            break;
            }
        }
    }


    public static void IntervalPriceLister(List<SteamGame> steamGameList)
    {
        List<SteamGame> steamGameUpto20List = new List<SteamGame>();
        List<SteamGame> steamGameUpto40List = new List<SteamGame>();
        List<SteamGame> steamGameUpto60List = new List<SteamGame>();
        List<SteamGame> steamGameUpto80List = new List<SteamGame>();

        foreach(SteamGame steamGame in steamGameList)
        {
            switch(steamGame.Price)
            {
                case double when steamGame.Price >= 0 && steamGame.Price < 20:
                steamGameUpto20List.Add(steamGame);
                break;
                case double when steamGame.Price > 20 && steamGame.Price <=40:
                steamGameUpto40List.Add(steamGame);
                break;
                case double when steamGame.Price > 40 && steamGame.Price <=60:
                steamGameUpto60List.Add(steamGame);
                break;
                case double when steamGame.Price > 60 && steamGame.Price <=80:
                steamGameUpto80List.Add(steamGame);
                break;
            }
        }

        foreach(SteamGame steamGame in steamGameUpto20List)
        {
            Console.WriteLine($"steamGameUpto20List consists of: " + steamGame.Name );
        }
        foreach(SteamGame steamGame in steamGameUpto40List)
        {
            Console.WriteLine($"steamGameUpto40List consists of: " + steamGame.Name );
        }
        foreach(SteamGame steamGame in steamGameUpto60List)
        {
            Console.WriteLine($"steamGameUpto60List consists of: " + steamGame.Name );
        }
        foreach(SteamGame steamGame in steamGameUpto80List)
        {
            Console.WriteLine($"steamGameUpto80List consists of: " + steamGame.Name );
        }

    }






}