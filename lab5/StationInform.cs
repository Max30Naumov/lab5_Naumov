using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab5
{
    public class StationInform
    {
        private int yearBuilt;
        private string fuelType;
        private string location;
        private string stationType;
        private string stationName;

        public string StationName
        {
            get => stationName;
            set => stationName = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значения не могут бить null или пустым.");
        }
        public string StationType
        {
            get => stationType;
            set => stationType = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значения не могут бить null или пустым.");
        }
        public string Location
        {
            get => location;
            set => location = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значения не могут бить null или пустым.");
        }
        public string FuelType
        {
            get => fuelType;
            set => fuelType = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Значения не могут бить null или пустым.");
        }
        public int YearBuilt { 
            get => yearBuilt; 
            set => yearBuilt = value >= 1886 && value <=2023 ? value : throw new ArgumentOutOfRangeException();   // 1886 - первая електростанция в Украине
        }

        public StationInform(string stationName, string stationType, string location, string fuelType, int yearBuilt)
        {
            StationName = stationName;
            StationType = stationType;
            Location = location;
            FuelType = fuelType;
            YearBuilt = yearBuilt;
        }


        public override string ToString()
        {
            return $"Name: {StationName}, Location: {Location}, StationType: {StationType}, Fuel Type: {FuelType}, Year Built: {YearBuilt}";
        }
    }
}
