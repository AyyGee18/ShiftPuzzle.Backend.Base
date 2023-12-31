﻿using System;
using System.IO;

namespace Example;

public class Person
{
    // поля класса
    public string name;
    public int age;

    // Конструктор класса Person для инициализации имени и возраста. Вызывается при создании объекта
    public Person(string name, int age)
    {
        this.name = name;
        SetAge(age); // функция для проверки возраста
    }

    public void SetAge(int newAge)
    {
        if(newAge >= 0)
        {
            this.age = newAge;
        }
        else
        {
            Console.WriteLine("Возраст не может быть отрицательным");
        }
    }

    public void Introduce()
    {
        Console.WriteLine($"Привет! Меня зовут {this.name}");
    }
}

public class Employee : Person
{
    public string position;

    public Employee(string name, int age, string position) : base(name, age)
    {
        this.position = position;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание массива из объектов Person
        Person[] people = new Person[3];
        people[0] = new Person("Alice", 28);
        people[1] = new Person("Bob", 35);
        people[2] = new Employee("Charlie", 42, "Product Manager");

        foreach(Person person in people)
        {
            person.Introduce();
        }

        // Работа с файлами
        WriteToFile();
        ReadFromFileAndPrint();
    }

    public static void WriteToFile()
    {
        string[] lines = new string[5];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = "test";
        }
        File.WriteAllLines("test.txt", lines);
    }

    public static void ReadFromFileAndPrint()
    {
        string[] lines = File.ReadAllLines("test.txt");
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
