namespace SteamUsers;

public class SteamUsers
{
private string? userName;
private int profileLevel;
private GamerLevel gamerLevel;

public string? UserName
{
    get
    {
        return userName;
    }
    set
    {
        userName = value;
    }
}

public int ProfileLevel
{
    get
    {
        return profileLevel;
    }
    set
    {
        profileLevel = value;
    }
}

public required List<SteamGame> SteamGame;
public GamerLevel GamerLevel
{
    get
    {
        return gamerLevel;
    }
    set
    {
        gamerLevel = value;
    }
}

}
