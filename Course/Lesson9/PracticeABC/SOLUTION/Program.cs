﻿namespace SOLUTION;

class Program
{
    static void Main()
    {
        Person[] people = new Person[3];

        people[0] = new Person("Акшин", 23);
        people[1] = new Person("Дима", 5);
        people[2] = new Person("Саша", 92);

        foreach (Person person in people)
        {
            person.Introduce();
        }
    }
}

public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hi! My name is {Name}");
    }
}