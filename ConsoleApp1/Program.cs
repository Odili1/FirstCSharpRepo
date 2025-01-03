// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

var p1 = new Person("Odili", "Eze", new DateOnly(1999, 5, 8));

var p2 = new Person("Chi", "Eni", new DateOnly(1999, 5, 8));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Damian"));

p2.Pets.Add(new Cat("Beyonce"));

List<Person> people = [p1, p2];

foreach (var person in people)
{
    System.Console.WriteLine(person);
    foreach (var pet in person.Pets)
    {
        System.Console.WriteLine($"     {pet}");
    }
}

System.Console.WriteLine(people.Count);

public class Person(string firstName, string lastName, DateOnly birthDay)
{
    public string First { get; } = firstName;
    public string Last { get; } = lastName;
    public DateOnly BirthDay { get; } = birthDay;
    public List<Pet> Pets { get; } = new();

    public override string ToString()
    {
        return $"Human {First} {Last}";
    }
}

public abstract class Pet(string firstName)
{
    public string First { get; } = firstName;
    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I {MakeNoise()}";
    }

}

public class Dog(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "Bark";
}

public class Cat(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "Meow";
}


Console.WriteLine("Hello, Odili!");