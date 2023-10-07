using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class HydroelectricPowerPlant : PowerPlant
    {
        public static readonly int MAX_DAM_HEIGHT = 305;
        public static readonly int MAX_TURBINE_COUNT = 32;
        public static readonly int MAX_RESERVOIR_VOLUME = 40; // кубометров
        private int turbineCount;
        private int reservoirVolume;
        private int damHeight;

        public int TurbineCount { get => turbineCount; set => turbineCount = value >= 0 && value <= MAX_TURBINE_COUNT ? value : throw new ArgumentOutOfRangeException(); }
        public int DamHeight { get => damHeight; set => damHeight = value >=0 && value <= MAX_DAM_HEIGHT ? value : throw new ArgumentOutOfRangeException(); }
        public int ReservoirVolume { get => reservoirVolume; set => reservoirVolume = value >= 0 && value <= MAX_RESERVOIR_VOLUME ? value : throw new ArgumentOutOfRangeException(); }
        public HydroelectricPowerPlant(string stationName, string stationType, string location, string fuelType, int yearBuilt, int stationCount, int employeesCount, int damHeight, int reservoirVolume,int turbineCount) : base(stationName, stationType, location, fuelType, yearBuilt, stationCount, employeesCount)
        {
            TurbineCount = turbineCount;
            DamHeight = damHeight;
            ReservoirVolume = reservoirVolume;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, TurbineCount: {TurbineCount}, DamHeight: {DamHeight}, ReservoirVolume: {ReservoirVolume}";
        }
    }
}
