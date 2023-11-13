using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_15_Practice
{
    internal class Cooler<T> : ITemperatureControl
    {
        public void MonitorTemprature(Component component, double alarm_temperature) 
        {
            if (component.Temperature_ > alarm_temperature)
            {
                component.GetEvent(component);
                CoolDown(component);
                //Console.ReadKey();
                Thread.Sleep(1000);
            }
        }
        public void CoolDown(Component component) 
        {
            component.Temperature_ = component.Temperature_ / 2;
        }
    }
}
