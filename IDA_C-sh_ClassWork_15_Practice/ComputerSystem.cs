using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_15_Practice
{
    internal class ComputerSystem
    {
        public Cooler<Component> Cooler { get; set; }

        List<Component> _list_components = new List<Component>();
        public double _alarm_temperature { get; set; }

        public void ComponentRegister(Component component_to_register)
        {
            _list_components.Add(component_to_register);
        }

        public void SetAlarmTemperature(double new_alarm_temperature)
        {
            _alarm_temperature = new_alarm_temperature;
        }
        public void HeavyLoadCalculation_and_TemperatureMonitoring()
        {
            // Каждый такт вычислений будет 500 мс
            Thread.Sleep(500);
            //Случайный нагрев компонентов на каждом такте
            double max_random_upheat_value = 5;
            foreach (Component component in _list_components) { component.Temperature_ += Service.ServiceFunction.Get_Random(max_random_upheat_value); }

            // Мониторим температуру компонентов
            foreach (Component component in _list_components)
                Cooler.MonitorTemprature(component, _alarm_temperature);

            // Выводим статус системы
            Console.Clear();
            Console.WriteLine("System current status:");

            var temp_view = from i in _list_components
                            orderby i.Temperature_ descending
                            select i;

            foreach (var i in temp_view)
                Console.WriteLine(i.Name_ + "\t\t" + i.Temperature_);

        }
    }
}
