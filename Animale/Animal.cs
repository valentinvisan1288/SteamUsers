namespace Animale;

public class Animal
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

    public Animal(int legs, string name, int age)
    {
        this.Picioare = legs;
        this.Nume = name;
        this.Varsta = age;
    }
}