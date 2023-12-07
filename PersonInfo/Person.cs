using System;
using System.Net.NetworkInformation;

namespace PersonInfo;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public string FirstName
    { 
        get {
            if (firstName.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            else
            {
                return firstName;
            }
        }
        set {  firstName = value; }
    }

    public string LastName
    { 
        get
        { 
            if (lastName.Length < 3) 
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }


            return lastName;
        }
        set { lastName = value; }   
    }

    public int Age
    {
        get
        {
            if (age <= 0)
            { 
            throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            else 
            {
                return age;
            }
        }
        set { age = value; }
    }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} is {this.age} years old.";
    }




}
