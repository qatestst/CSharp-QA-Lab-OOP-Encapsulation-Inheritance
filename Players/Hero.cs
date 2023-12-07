namespace Players;

public class Hero
{

    private string userName;
    private int level;

    public string UserName
    { 
        get { return userName; } 
        set {  userName = value; }
    }
    public int Level 
    { 
        get { return level; }
        set {  level = value; }
    }

    public Hero(string userName, int level)
    { 
        this.UserName = userName;
        this.Level = level;
    
    }
    
    public override string ToString()
    {
        return $"Type: {this.GetType().Name} Username: {this.userName} Level: {this.level}";
    }


}
