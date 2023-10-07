using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class PowerPlant
    {
        private StationInform stationInform;
        private int stationCount;
        private int employeesCount;
        public static readonly int MAX_STAION_COUNT = 100;    
        public int EmployeesCount { get => employeesCount; set => employeesCount = value >= 0 ? value : throw new ArgumentOutOfRangeException(); }
        public int StationCount { get => stationCount; set => stationCount = value >= 0 && value <= MAX_STAION_COUNT ? value :throw new ArgumentOutOfRangeException(); }
        public PowerPlant(string stationName, string stationType, string location, string fuelType, int yearBuilt , int stationCount, int employeesCount)
        {
            stationInform = new StationInform(stationName, stationType, location, fuelType, yearBuilt);
            StationCount = stationCount;
            EmployeesCount = employeesCount;
        }
        public override string ToString()
        {
            return $"{stationInform.ToString()}, StationCount: {StationCount}, EmployeesCount: {EmployeesCount}"; 
        }
    }
}
