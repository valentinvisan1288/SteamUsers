namespace Homework;

public class ObjectNine
{
    private string nume;
    private int varsta;
    private List<double> lista;

    public string Nume
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
    public List<double> Lista
    {
        get
        {
            return lista;
        }
        set
        {
            lista = value;
        }
    }

    public ObjectNine(string nume, int varsta, List<double> lista)
    {
        this.nume = nume;
        this.varsta = varsta;
        this.lista = lista;
    }



}