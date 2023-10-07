using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{   
    public class Electricity
    {
        private PowerPlant[] _energy;
        public PowerPlant[] Energy { get { return _energy; } }
        public Electricity() 
        {
            _energy = Array.Empty< PowerPlant>(); 
        }
        public Electricity(params PowerPlant[] energy)
        {
            _energy = energy;
        }
        public void AddStation(PowerPlant powerPlant)
        {
            Array.Resize(ref _energy, _energy.Length + 1);
            _energy[^1] = powerPlant;
        }
        public void RemoveStation(int index)
        {
            if (index >= 0 && index < _energy.Length)
            {
                for (int i = index; i < _energy.Length - 1; i++)
                {
                    _energy[i] = _energy[i + 1];
                }
                Array.Resize(ref _energy, _energy.Length - 1);
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }
        public void EditStation(int index, PowerPlant newPowerPlant)
        {
            if (index >= 0 && index < _energy.Length)
            {
                _energy[index] = newPowerPlant;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var powerPlant in _energy)
            {
                result.AppendLine(powerPlant.ToString());
            }

            return result.ToString();
        }
    }
}
