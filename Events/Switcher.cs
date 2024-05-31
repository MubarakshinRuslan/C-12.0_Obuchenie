using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void Electricity();
    internal class Switcher
    {
        public Electricity ElectricityOn;
        public void SwitchOn() 
        {
            Console.WriteLine("Выключатель включен");
            ElectricityOn?.Invoke();
        }
    }
}
