using System;

class Car
{
    private string brand;
    private string color;
    private double engineVolume;
    private int power;

    public Car(string brand, string color, double engineVolume, int power)
    {
        this.brand = brand;
        this.color = color;
        this.engineVolume = engineVolume;
        this.power = power;
    }

    public Car()
    {
        // Конструктор за умовчанням
    }

    public Car(Car other)
    {
        this.brand = other.brand;
        this.color = other.color;
        this.engineVolume = other.engineVolume;
        this.power = other.power;
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public double EngineVolume
    {
        get { return engineVolume; }
        set { engineVolume = value; }
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public void Display()
    {
        Console.WriteLine($"Марка: {brand}");
        Console.WriteLine($"Колiр: {color}");
        Console.WriteLine($"Об'єм двигуна: {engineVolume}L");
        Console.WriteLine($"Потужнiсть: {power}hp");
    }
}

class Truck : Car
{
    private double cargoCapacity;

    public Truck(double cargoCapacity)
    {
        this.cargoCapacity = cargoCapacity;
    }

    public Truck()
    {
        // Конструктор за умовчанням
    }

    public double CargoCapacity
    {
        get { return cargoCapacity; }
        set { cargoCapacity = value; }
    }

    public new void Display()
    {
        base.Display();
        Console.WriteLine($"Вантажопiдйомнiсть кузова: {cargoCapacity}кг");
    }
}

class Bus : Car
{
    private int seatingCapacity;

    public Bus(int seatingCapacity)
    {
        this.seatingCapacity = seatingCapacity;
    }

    public Bus()
    {
        // Конструктор за умовчанням
    }

    public int SeatingCapacity
    {
        get { return seatingCapacity; }
        set { seatingCapacity = value; }
    }

    public new void Display()
    {
        base.Display();
        Console.WriteLine($"Кiлькiсть посадкових мiсць: {seatingCapacity}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", "Red", 2.0, 150);
        Car car2 = new Car();
        Car car3 = new Car(car1);

        car1.Display();
        Console.WriteLine();

        car2.Brand = "Honda";
        car2.Color = "Blue";
        car2.EngineVolume = 1.5;
        car2.Power = 120;
        car2.Display();
        Console.WriteLine();

        car3.Brand = "Nissan";
        car3.Display();
        Console.WriteLine();

        Truck truck = new Truck(5000);
        truck.Brand = "Volvo";
        truck.Color = "White";
        truck.EngineVolume = 3.5;
        truck.Power = 300;
        truck.Display();
        Console.WriteLine();

        Bus bus = new Bus(30);
        bus.Brand = "Mercedes";
        bus.Color = "Yellow";
        bus.EngineVolume = 4.0;
        bus.Power = 250;
        bus.Display();
    }
}

