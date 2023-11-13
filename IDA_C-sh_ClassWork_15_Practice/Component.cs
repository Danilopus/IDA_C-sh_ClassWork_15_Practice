using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_15_Practice
{
    abstract internal class Component
    {
        public string Name_ { get; set; }
        public double Temperature_ { get; set; }
        public Component (string name_, double temperature_)
        {
            Name_ = name_;
            Temperature_ = temperature_;
            OverHeat_event += OverHeat_Handler;
        }

        public event Action<Component> OverHeat_event; // = new event Action<double>;
        public void OverHeat_Handler(Component component)
        {
            Console.WriteLine("\n\n" + component.Name_ + "  overheat.\nTemperture = " + component.Temperature_);
            
        }
        public void GetEvent(Component component)
        {
            OverHeat_event(component);
        }
    }
}
