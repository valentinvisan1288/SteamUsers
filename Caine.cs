namespace Homework;

public class Caine
{

private int picioare;

private string? nume;
private int varsta;

public int Picioare
{
    get
    {
        return picioare;
    }
    set
    {
        picioare = value;
    }
}

public string? Nume
{
    get
    {
        return nume;
    }
    set
    {
        nume = value;
    }
}

public int Varsta
{
    get
    {
        return varsta;
    }
    set
    {
        varsta = value;
    }
}

public Caine(int picioare, string nume, int varsta)
{
    this.Picioare = picioare;
    this.Nume = nume;
    this.Varsta = varsta;
}

    public static void CaineInstant()
    {  
     Caine caineUnu = new Caine(3, "Tripod", 7);
     System.Console.WriteLine(caineUnu.Varsta);
    }
};

