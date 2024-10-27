namespace Homework;

public class ObjectOne
{
    private int numberOne;

    private string stringOne;

    public int NumberOne
    {
        get
        {
            return numberOne;
        }
        set
        {
            numberOne = value;
        }
    }

    public string StringOne
    {
        get
        {
            return stringOne;
        }
        set
        {
            stringOne = value;
        }
    }

    public ObjectOne(int numberOne1, string stringOne1)
    {
        this.numberOne = numberOne1;
        this.stringOne = stringOne1;
    }

}