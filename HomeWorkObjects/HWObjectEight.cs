namespace Homework;

public class ObjectEight
{
    private float floatEight;
    private bool boolEight;
    private double doubleEight;

    public float FloatEight
    {
        get
        {
            return floatEight;
        }
        set
        {
            floatEight = value;
        }
    }

    public double DoubleEight
    {
        get
        {
            return doubleEight;
        }
        set
        {
            doubleEight = value;
        }
    }

    public bool BoolEight
    {
        get
        {
            return boolEight;
        }
        set
        {
            boolEight = value;
        }
    }
    

    public ObjectEight(float floatEight8, double doubleEight8,  bool boolEight8)
    {
        this.floatEight = floatEight8;
        this.doubleEight = doubleEight8; 
        this.boolEight = boolEight8;
    }

}