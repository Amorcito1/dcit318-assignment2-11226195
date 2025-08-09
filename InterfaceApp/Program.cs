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

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Car and Bicycle
        IMovable myCar = new Car();
        IMovable myBicycle = new Bicycle();

        // Call the Move() method on each instance
        myCar.Move();      // Output: Car is moving
        myBicycle.Move();  // Output: Bicycle is moving
    }
}