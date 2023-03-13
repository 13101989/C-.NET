using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Packt.Shared;

public partial class Person:object
{
    // fields
    public string Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    // constants
    public const string Species = "Homo Sapiens";
    // read-only fields
    public static readonly string HomeContinent = "Europe";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    // constructors
    public Person()
    {
        // set default values for fields
        // including read-only fields
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }
    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    // you can put how many items you want in the tuple
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Potatoes", Number: 15);
    }

    // deconstructors
    public void Deconstruct(out string? name, out DateTime dob)
    {
        name = Name;
        dob = DateOfBirth;
    }
    public void Deconstruct(out string? name, out DateTime dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = DateOfBirth;
        fav = FavoriteAncientWonder;
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }
    public string SayHello(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

    public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
    {
        return string.Format(format: "command is {0}, number is {1}, active is {2}",
                             arg0: command,
                             arg1: number,
                             arg2: active);
    }

    public void PassingParameters(int x, ref int y, out int z)
    {
        // out and ref parameters cannot have a default
        // BUT only out paramaters must be initialized inside the method
        z = 99;
        // increment each parameter
        x++;
        y++;
        z++;
    }
}


