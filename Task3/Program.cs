// See https://aka.ms/new-console-template for more information
using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Task3
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        car.Move();       // Outputs: Car is moving
        bicycle.Move();   // Outputs: Bicycle is moving
    }
}
