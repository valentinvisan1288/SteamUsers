namespace SteamUsers;

public class SteamMethods
{
    public static void ListIterated(List<SteamGame> steamGameNameList)
    {
        foreach(SteamGame steamGame in steamGameNameList)
        {
            steamGame.Price += 10;
            Console.WriteLine($"The name of the game is " + steamGame.Name + " and new price is "+ steamGame.Price);
        }
    }

        //for (int i = 0; i< 10; i++)

    public static void ForMethod(List<SteamGame> steamGameForList)
    {
        var maxLengthSteamGameForList = steamGameForList.Count();
        List<SteamGame> steamGame = new List<SteamGame>(); 
        for (int i = 0; i < maxLengthSteamGameForList ; i++)
        {
            
            Console.WriteLine($"I have iterated " + steamGame);

        }

    }








}
    
