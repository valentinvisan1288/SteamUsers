namespace Animale;

public class Caine : Animal
{
    private bool coada;
    public bool Coada
    {
        get
        {
            return coada;
        }
        set
        {
            coada = value;
        }
    }

    public Caine(int picioare, string nume, int varsta, bool coada) : base(picioare, nume, varsta)
    {
        this.coada = coada;
    }
};

