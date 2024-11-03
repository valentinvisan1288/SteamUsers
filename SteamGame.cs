namespace SteamUsers;

public class SteamGame
{
private string name;
private double price;
private string? genre;
private int rating;
private bool isFinished;

public string Name
{
    get
    {
        return name; 
    }
    set
    { 
        name = value; 
    }
}
public double Price 
{ 
    get
    {
        return price;
    }
    set
    {
        price = value;
    }
}
public string? Genre
{
    get
    {
        return genre;
    }
    set
    {
        genre = value;
    }
}
public int Rating
{
    get
    {
        return rating;
    }
    set
    {
        rating = value;
    }
}

public bool IsFinished
{
    get
    {
        return isFinished;
    }
    set
    {
        isFinished = value;
        
    }
}

//TO DO @Ramon Remove comments
// public Cat(String name, int age, double kilos)
//     {
//         this.name = name;
//         this.age = age;
//         this.kilos = kilos;
//     }

public SteamGame (string name1, double price1, string genre1, int rating1, bool isFinished1)
{
    this.name = name1;
    this.price = price1;
    this.genre = genre1;
    this.rating = rating1;
    this.isFinished = isFinished1;
}

public SteamGame (string name1, double price1, string genre1, int rating1)
{
    this.name = name1;
    this.price = price1;
    this.genre = genre1;
    this.rating = rating1;

}




}
