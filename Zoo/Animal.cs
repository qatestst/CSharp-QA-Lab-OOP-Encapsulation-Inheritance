﻿namespace Zoo;

public class Animal
{
    public string name;
    public string Name
    { 
        get { return name; }
        set { name = value; }
    }

    public Animal(string name)
    {
        this.Name = name;
    }



}
