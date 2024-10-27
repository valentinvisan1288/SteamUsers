namespace Homework;

public class ObjectTwo
{
    private double doubleTwo;
    private float floatTwo;
    private bool boolTwo;

    public double DoubleTwo
    {
        get
        {
            return doubleTwo;
        }
        set
        {
            doubleTwo = value;
        }
    }

    public float FloatTwo
    {
        get
        {
            return floatTwo;
        }
        set
        {
            floatTwo = value;
        }
    }

    public bool BoolTwo
    {
        get
        {
            return boolTwo;
        }
        set
        {
            boolTwo = value;
        }
    }
    

    public ObjectTwo(double doubleTwo2, float floatTwo2, bool boolTwo2)
    {
        this.doubleTwo = doubleTwo2;
        this.floatTwo = floatTwo2;
        this.boolTwo = boolTwo2;
    }

}