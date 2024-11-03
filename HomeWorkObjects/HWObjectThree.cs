using SteamUsers;
namespace Homework;

public class ObjectThree
{
    private string stringThree;
    private string stringThreeOne;
    private List<SteamGame> steamGameThree;

    public string StringThree
    {
        get
        {
            return stringThree;
        }
        set
        {
            stringThree = value;
        }
    }

    public string StringThreeOne
    {
        get
        {
            return stringThreeOne;
        }
        set
        {
            stringThreeOne = value;
        }
    }

    public List<SteamGame> SteamGameThree
    {
        get
        {
            return steamGameThree;
        }
        set
        {
            steamGameThree = value;
        }
    }

    public ObjectThree(string stringThree1, string stringThreeOne, List<SteamGame> SteamGameThree1)
    {
        this.StringThreeOne = stringThree1;
        this.StringThree = stringThreeOne;
        this.SteamGameThree = SteamGameThree1;
    }
}