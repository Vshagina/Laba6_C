using System;
using System.Runtime.ConstrainedExecution;

// Абстрактный класс Транспорт
public abstract class Transport
{
    // Абстрактные свойства
    public abstract double Speed { get; }
    public abstract double LoadCapacity { get; }
    public abstract double Range { get; }

    // Абстрактные методы
    public abstract string GetDescription();
}

// Абстрактный класс Автомобиль
public abstract class Car : Transport
{
    // Реализация свойств для автомобиля
    public override double Speed => 100; 
    public override double LoadCapacity => 500; 
    public override double Range => 600; 
}

// Класс МаршруткаАвтомобиль
public class MinibusCar : Car
{
    // Реализация метода получения описания
    public override string GetDescription()
    {
        return $"Маршрутка с грузоподъемностью в {LoadCapacity} кг может проехать {Range} км";
    }
}

// Абстрактный класс Самолет
public abstract class Airplane : Transport
{
    // Реализация свойств для самолета
    public override double Speed => 800;
    public override double LoadCapacity => 10000; 
    public override double Range => 5000; 
}

// Класс ПассажирскийСамолет
public class PassengerAirplane : Airplane
{
    // Реализация метода получения описания
    public override string GetDescription()
    {
        return $"Пассажирский самолет с грузоподъемностью в {LoadCapacity} кг может пролететь {Range} км";
    }
}

// Абстрактный класс Корабль
public abstract class Ship : Transport
{
    // Реализация свойств для корабля
    public override double Speed => 30; 
    public override double LoadCapacity => 20000; 
    public override double Range => 3000; 
}

// Класс ГрузовойКорабль
public class CargoShip : Ship
{
    // Реализация метода получения описания
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

