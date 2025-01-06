using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
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

    public static void SpaceTrimmer(string stringToTrim)
    {
        StringBuilder sb = new StringBuilder();
        
        foreach (char c in stringToTrim)
        {
            if ( c != ' ')
            {
                sb.Append(c);
            }
        }
        Console.WriteLine(sb);
    }

    public static void NumberSorter()
    {
        List<int> listToSort = [637];
        //if x[i] > x[j] => mariani.append(x[i])
        //where i = 0 && j = 1
        //i++ j ++
        // i< max length - 1
        // j< max length - 2


        //comparatii recursive!!

        listToSort.Sort();
        foreach (int i in listToSort)
        {
            System.Console.WriteLine(i);
        }

    }

    public static void GuessingGame()
    {
        Random randomNumber = new Random();
        int numberOfGuesses = 5;
        int hiddenNumber = randomNumber.Next(100);
        Console.WriteLine("Enter a number");
        int? guessedNumber = int.Parse(Console.ReadLine());
        
        for(int x = numberOfGuesses-1; x > 0;)
        { 
            if(hiddenNumber > guessedNumber)
            {
                Console.WriteLine("Hidden number is higher, try again");
                x--;
                Console.WriteLine("Enter a higher number");
                guessedNumber = int.Parse(Console.ReadLine());
            }
            else if (hiddenNumber < guessedNumber)
            {
                Console.WriteLine("Hidden number is lower, try again");
                x--;
                Console.WriteLine("Enter a lower number");
                guessedNumber = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("correct");
                break;
            }

        }
        

    }

public static bool Compare<T>(T obj1, T obj2)
{
    if (obj1 == null && obj2 == null) return true;
    if (obj1 == null || obj2 == null) return false;
    if (obj1.GetType() != obj2.GetType()) return false;
    var properties = typeof(T).GetProperties(); //returneaza get-eri and set-eri
    foreach (var property in properties)
    {
        if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
        {
            if(!Compare(property.GetValue(obj1), property.GetValue(obj2))) return false;
        }
        else
        {
            if (!property.GetValue(obj1).Equals(property.GetValue(obj2))) return false;
        }
        //the Compare method will traverse through the properties of the objects, 
        //comparing their values deeply and handling nested properties using recursion.
    }
    return true;
}

public delegate void ArrayOperationsDelegator(int[] integers);
//asociaza instanta acestei metode cu oricare alta metoda care 
//este compatibila cu semnatura acestei metodei

public static void ArrayOperator(int[] integers, ArrayOperationsDelegator arrayOperationsDelegator)
{  
    arrayOperationsDelegator(integers);
    //or as switch case, passing the name of the method as a string
}


public static void ArrayOperatorHighestNumberFinder(int[] integers)
{
    int highestInteger = integers[0];
    for (int i = 0; i < integers.Length; i++ )
    {
        if(integers[i] > highestInteger)
        {
            highestInteger = integers[i];
        }
    }
    Console.WriteLine($"Highest integer is {highestInteger}"); 
}

public static void ArrayOperatorLowestNumberFinder(int[] integers)
{
    int lowestInteger = integers[0];
    for (int i = 0; i < integers.Length; i++)
    {
        if(integers[i] < lowestInteger)
        {
            lowestInteger = integers[i];
        }
    }
    Console.WriteLine($"Lowest integer is {lowestInteger}"); 
    
}

public static void ArrayOperatorAverageCalculator(int[] integers)
{
    int totalSum = 0;
    foreach (int i in integers)
    {
        totalSum += i;
    }
    int averageResult = totalSum / integers.Length;
    Console.WriteLine($"The average of all integers equals to {averageResult}"); 
}

public static void ArrayOperatorReverser(int[] integers)
{
    int[] reversedArray = new int[integers.Length];
    for (int i = 0, j = integers.Length - 1; i < integers.Length; i++, j--)
    {
        reversedArray[i] = integers[j];
    }
    Console.WriteLine(string.Join(", ", reversedArray));
}

public static void Calculator(string stringOne, params int[] integers)
{
    int result = 0;
    switch (stringOne)
    {
        case "Sum":
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine("Suma este " + result);
            break;
        case "Subtraction":
        int resultTemp = 0;
        int resultSum = 0;
            for (int i = 0; i < integers.Length - 1; i++)
            {
                for (i = 1; i < integers.Length; i++)
                {
                resultSum += integers[i];
                } 
            }
            resultTemp = integers[0] - (resultSum);
            Console.WriteLine("Diferenta este " + resultTemp);
            break;
        case "Multiplication":
        int resultTempMult = 1;
            for (int i = 0; i < integers.Length; i++)
            {
                
               resultTempMult *= integers[i];
            }
            Console.WriteLine("Produsul este " + resultTempMult);
            break;
        case "Division":
            int resultTempDiv = integers[0];
            for (int i = 0; i < integers.Length - 1; i++)
            {
                resultTempDiv = resultTempDiv / integers[i+1];
            }
            Console.WriteLine("Catul este " + resultTempDiv);
            break;
    }
}


// 20 - (5 + 3 + 1)
// 20 - 5 - 3 - 1
// 1000 / 10 / 5 / 8

// list.Sort() - foloseste interfata IComparer<T>. 
// Sorteaza toate elementele unei liste sau o parte din ele
// Poate folosi si Comparer<T>, care este un "delegate"

// public	   The code is accessible for all classes
// private	   The code is only accessible within the same class
// protected   The code is accessible within the same class, or in a class that is inherited from that class
// internal	   The code is only accessible within its own assembly, but not from another assembly
// Assembly    An assembly is a collection of types and resources that are built to work together and form a logical unit of functionality.
//             The fundamental units of deployment, version control, reuse, activation scoping, and security permissions 





}
