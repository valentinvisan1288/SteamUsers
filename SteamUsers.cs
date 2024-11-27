namespace SteamUsers;

public class SteamUser
{
private string? userName;
private int profileLevel;
private GamerLevel gamerLevel;
private List<SteamGame> steamGameList;

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

public List<SteamGame>SteamGameList
{
    get
    {
        return steamGameList;
    }
    set
    {
        steamGameList = value;
    }
}

public SteamUser(string steamUserName, int profileLevel, GamerLevel gamerLevel, List<SteamGame> steamGameList)
{
   this.userName = steamUserName;
   this.profileLevel = profileLevel;
   this.gamerLevel = gamerLevel;
   this.steamGameList = steamGameList;
}




}
