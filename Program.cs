using System;
using System.Runtime.ConstrainedExecution;

public abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double LoadCapacity { get; }
    public abstract double Range { get; }

    public abstract string GetDescription();
}

public abstract class Car : Transport
{
    public override double Speed => 100; 
    public override double LoadCapacity => 500; 
    public override double Range => 600; 
}

public class MinibusCar : Car
{
    public override string GetDescription()
    {
        return $"Маршрутка с грузоподъемностью в {LoadCapacity} кг может проехать {Range} км";
    }
}

public abstract class Airplane : Transport
{
    public override double Speed => 800;
    public override double LoadCapacity => 10000; 
    public override double Range => 5000; 
}

public class PassengerAirplane : Airplane
{
    public override string GetDescription()
    {
        return $"Пассажирский самолет с грузоподъемностью в {LoadCapacity} кг может пролететь {Range} км";
    }
}

public abstract class Ship : Transport
{
    public override double Speed => 30; 
    public override double LoadCapacity => 20000; 
    public override double Range => 3000; 
}

public class CargoShip : Ship
{
    public override string GetDescription()
    {
        return $"Грузовой корабль с грузоподъемностью в {LoadCapacity} кг может пройти {Range} миль";
    }
}
class Program
{
    static void Main(string[] args)
    {
        MinibusCar minibus = new MinibusCar();
        PassengerAirplane airplane = new PassengerAirplane();
        CargoShip ship = new CargoShip();

        Console.WriteLine(minibus.GetDescription());
        Console.WriteLine(airplane.GetDescription());
        Console.WriteLine(ship.GetDescription());
    }
}

