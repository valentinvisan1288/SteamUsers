

using System.Text;

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
        for (int i = 0; i < maxLengthSteamGameForList ; i++)
        {
            
            Console.WriteLine($"I have iterated " + steamGameForList[i].Name);
        }

    }

    public static void WhileMethod(List<SteamGame> steamGameListWhile)
    {
        int i = 0;
        while ( i < steamGameListWhile.Count())
        {
            Console.WriteLine($"Steam Game Name is {steamGameListWhile[i].Name}");
            i++;
        }

    }

    public static void PalindromeForeach(string palindromForeach)
    {
        char[] arrayOfCharacters = palindromForeach.ToCharArray();
        StringBuilder sb = new StringBuilder();

        for (int i = arrayOfCharacters.Count() - 1; i >= 0 ; i--)
        {
            
            sb.Append(arrayOfCharacters[i]);
        }

        if (palindromForeach == sb.ToString())
        {
            Console.WriteLine("this word is a palindome");
        } 
        else
        {
            Console.WriteLine("this word is NOT a palindome");
        }

    }







}
