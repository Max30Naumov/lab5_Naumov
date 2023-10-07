using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class ThermalPowerPlant : PowerPlant
    {
        public static readonly int MAX_BOILER_COUNT = 100;
       

        private string heatSource;
        private string boilerType;
        private int numberOfBoilers;

        public string HeatSource { get => heatSource; set => heatSource = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значения не могут бить null или пустым."); }
        public string BoilerType { get => boilerType; set => boilerType = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значения не могут бить null или пустым."); }
        public int NumberOfBoilers { get => numberOfBoilers; set => numberOfBoilers = value >= 0 && value < MAX_BOILER_COUNT ? value : throw new ArgumentOutOfRangeException(); }
        public ThermalPowerPlant(string stationName, string stationType, string location, string fuelType, int yearBuilt, int stationCount, int employeesCount, string heatSource, string boilerType, int numberOfBoilers) : base(stationName, stationType, location, fuelType, yearBuilt, stationCount, employeesCount)
        {
            HeatSource = heatSource;
            BoilerType = boilerType;
            NumberOfBoilers = numberOfBoilers;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, HeatSource: {HeatSource}, BoilerType: {BoilerType}, NumberOfBoilers: {NumberOfBoilers}";
        }

    }
}
