﻿namespace ConsoleApp15;

class Program
{
    static void Main(string[] args)
    {
        //Bilforhandleren
        // En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker, årsmodell, registreringsnummer og kilometerstand. Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa, eller han kan velge å finne en bil ut fra årsrange, eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand. Kunden skal også ha mulighet til å kjøpe en av bilene. Bilen må da tilhøre kunden og ikke forhandleren.

        Car bil1 = new Car("Tyota", 2023, "AZ10072", 55000);
        Car bil2 = new Car("BMW", 2022, "AQ55533", 80000);
        Car bil3 = new Car("Opel", 2010, "OP12345", 450000);
        Car bil4 = new Car("Nissan", 2018, "NI23471", 121100);

        List<Car> cars = new List<Car>();
        cars.Add(bil1);
        cars.Add(bil2);
        cars.Add(bil3);
        cars.Add(bil4);
        
        Menu();

        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                foreach (var car in cars)
                {
                    car.ShowInfo();
                }
                break;
            case "2":
                Console.Write("Enter Kilometers: ");
                int kms = Convert.ToInt32(Console.ReadLine());
                 List<Car> result =SearchForKM(kms , cars);
                Console.WriteLine($"Cars less than or equal to {kms} :");
                foreach (var car in result)
                {
                    car.ShowInfo();
                }
                break;
            case "3":
                break;
            case "4":
                break;
            default:
                Console.WriteLine("Wrong input!");
                break;
        }

    }

    public static List<Car> SearchForKM(int kilometer,List<Car> cars)
    {
        List<Car> newCars = new List<Car>();
        for (int i =0;i<cars.Count;i++) {
            if (kilometer>=(cars[i].Km))
            {
                newCars.Add(cars[i]);
            }
        }
        return newCars;
    }
    
    public static void Menu()
    {
        Console.WriteLine("*** Welcome to CarShop ***");
        Console.WriteLine("Press 1 to see all cars");
        Console.WriteLine("Press 2 search car based on KM");
        Console.WriteLine("Press 3 search car based on Year Model");
        Console.WriteLine("Press 4 to buy car");
    }
}