using lab5;
using static System.Collections.Specialized.BitVector32;

internal class Program
{
    private static void Main(string[] args)
    {
        ThermalPowerPlant thermalPower = new ThermalPowerPlant("ThermalStation1", "Thermal", "LocationP", "Coal", 2010, 5, 566, "Fire", "BoilerType1", 50);

        ThermalPowerPlant thermalPower1 = new ThermalPowerPlant("ThermalStation2", "Thermal", "LocationQ", "Gas", 2018, 6, 766, "Gas", "BoilerType2", 60);

        HydroelectricPowerPlant hydroelectric = new HydroelectricPowerPlant("HydroStation1", "Hydroelectric", "LocationA", "Water", 1900, 1, 369, 166, 12, 6);

        HydroelectricPowerPlant hydroelectric1 = new HydroelectricPowerPlant("HydroStation2", "Hydroelectric", "LocationB", "Water", 1922, 4, 200, 65, 23, 1);

        NuclearPowerPlant nuclearPower = new NuclearPowerPlant("NuclearStation1", "Nuclear","Location1","Plutonium",2021, 2,544, "MoltenSaltReactor",5,false);

        NuclearPowerPlant nuclearPower2 = new NuclearPowerPlant("NuclearStation2", "Nuclear", "Location2", "Uranium", 2010, 1, 234, "FastBreederReactor", 3, true);

        PowerPlant powerPlant = new PowerPlant("MainStation", "GenericType1", "LocationX", "GenericFuel1", 1995, 3, 700);

        Electricity electricity = new Electricity(thermalPower, thermalPower1, hydroelectric, hydroelectric1, powerPlant);

        Console.WriteLine("Исходный масив:");
        Console.WriteLine(electricity.ToString());

        electricity.AddStation(nuclearPower);
        Console.WriteLine("После добавления:");
        Console.WriteLine(electricity.ToString());

        Console.WriteLine("После редактирования:");
        electricity.EditStation(5, nuclearPower2);
        Console.WriteLine(electricity.ToString());

        Console.WriteLine("После удаления:");
        electricity.RemoveStation(0);
        Console.WriteLine(electricity.ToString()) ;
    }
}