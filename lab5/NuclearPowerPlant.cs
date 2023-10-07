using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class NuclearPowerPlant : PowerPlant
    {
        public static readonly int MAX_REACTOR_COUNT = 10;
        private string reactorType;
        private int reactorNumber;
        private bool isWasteStorage;

        public string ReactorType { get => reactorType; set => reactorType = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значения не могут бить null или пустым."); }
        public int ReactorNumber { get => reactorNumber; set => reactorNumber = value >= 0 && value <=MAX_REACTOR_COUNT ? value : throw new ArgumentOutOfRangeException(); }
        public bool IsWasteStorage { get => isWasteStorage; set => isWasteStorage = (value == true || value == false) ? value : throw new ArgumentException("Некоректное значение для IsWasteStorage. Принимаются только значения true или false.");}
        public NuclearPowerPlant(string stationName, string stationType, string location, string fuelType, int yearBuilt, int stationCount, int employeesCount, string reactorType, int reactorNumber, bool isWasteStorage) : base(stationName, stationType, location, fuelType, yearBuilt, stationCount, employeesCount)
        {
            ReactorType = reactorType;
            ReactorNumber = reactorNumber;
            IsWasteStorage = isWasteStorage;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, ReactorType: {ReactorType}, ReactorNumber: {ReactorNumber}, IsWasteStorage: {IsWasteStorage}";
        }
    }
}
