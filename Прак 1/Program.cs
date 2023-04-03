using System;
Console.WriteLine("Введите дистанцию гонки в км");
double distance = Convert.ToDouble(Console.ReadLine());
Car[] cars = new Car[4];
for(int i = 0; i < cars.Length; i++) { 

Console.WriteLine($"Введите скорость  автомобиля под номером {i + 1}");
cars[i] = new Car(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine($"Введите название  автомобиля под номером {i+1}");
    cars[i].carName = Convert.ToString(Console.ReadLine());
    Console.WriteLine($"машина номер {i+1} имеет характеристики \n Название {cars[i].carName}\n Скорость = {cars[i].maxSpeed}");
}

if (cars[0].maxSpeed > cars[1].maxSpeed && cars[0].maxSpeed > cars[2].maxSpeed && cars[0].maxSpeed > cars[3].maxSpeed ) {
    Console.WriteLine($"Победил {cars[0].carName}");
}
if (cars[1].maxSpeed > cars[0].maxSpeed && cars[1].maxSpeed > cars[2].maxSpeed && cars[1].maxSpeed > cars[3].maxSpeed)
{
    Console.WriteLine($"Победил {cars[1].carName}");
}
if (cars[2].maxSpeed > cars[0].maxSpeed && cars[2].maxSpeed > cars[1].maxSpeed && cars[2].maxSpeed > cars[3].maxSpeed)
{
    Console.WriteLine($"Победил {cars[2].carName}");
}
if (cars[3].maxSpeed > cars[0].maxSpeed && cars[3].maxSpeed > cars[1].maxSpeed && cars[3].maxSpeed > cars[2].maxSpeed)
{
    Console.WriteLine($"Победил {cars[3].carName}");
}





Console.ReadKey(true);

class Car
{
    public double maxSpeed;
    public String carName;


    public Car()
    {
        this.maxSpeed = 180; 
    }
    public Car(double maxSpeed)
    {
        this.maxSpeed = maxSpeed;  
    }

    public double CalculateTime(double distance)
    {
        return distance / maxSpeed;
    }
}