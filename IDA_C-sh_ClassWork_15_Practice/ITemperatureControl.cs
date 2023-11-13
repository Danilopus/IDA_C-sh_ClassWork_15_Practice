using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_15_Practice
{
    internal interface ITemperatureControl
    {
        public void MonitorTemprature(Component component, double alarm_temperature);
        public void CoolDown(Component component);
            
    }
}
