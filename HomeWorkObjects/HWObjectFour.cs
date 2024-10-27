namespace Homework;

public class ObjectFour
{
    private int integerFour;
    private double doubleFour;

    public int IntegerFour
    {
        get
        {
            return integerFour;
        }
        set
        {
            integerFour = value;
        }
    }
    public double DoubleFour
    {
        get
        {
            return doubleFour;
        }
        set
        {
            doubleFour = value;
        }
    }

    public ObjectFour(int integerFourCT, double doubleFourCT)
    {
        this.integerFour = integerFourCT;
        this.doubleFour = doubleFourCT;

    }
}