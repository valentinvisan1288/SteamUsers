using Homework;

public class Pisica
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

public Pisica(int picioare, string nume, int varsta)
{
    this.Picioare = picioare;
    this.Nume = nume;
    this.Varsta = varsta;
}

    public static void PisicaInstant()
    {  
     Pisica pisicaUnu = new Pisica(4, "PssPss", 4);
     System.Console.WriteLine(pisicaUnu.Picioare);
    }
    
}