// ClassWork template 1.2 // date: 29.09.2023

using IDA_C_sh_ClassWork_15_Practice;
using Service;
using System;
using System.Linq.Expressions;
using System.Text;



// ClassWork 15 : [C sharp] 13.11.2023 --------------------------------

namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task_1();
            // Task_2();
            // Task_3();


            // Console.ReadKey();

        }

        public static void Task_1() 
        {
            //////////////////////////////
            /// Блок стартовых параметров
            int processors_qua = 5;
            int graphicCards_qua = 7;
            int room_temperature = 22; // Цельсий
            
            /////////////////////////////
            /// Создание системы
            
            ComputerSystem computerSystem_1 = new ComputerSystem();
            computerSystem_1._alarm_temperature = 85;

            for (int i = 0; i < processors_qua; i++)             
                computerSystem_1.ComponentRegister(new Processor($"I{i+3}-12600", room_temperature));

            for (int i = 0; i < graphicCards_qua; i++)
                computerSystem_1.ComponentRegister(new GraphicCard($"Radeon Vega{i+7}", room_temperature));

            //computerSystem_1.ComponentRegister(new Cooler<Component>("ThermalTake", room_temperature));
            //computerSystem_1.Cooler = new ComputerSystem.Cooler<Component>();
            computerSystem_1.Cooler = new Cooler<Component>();

            //////////////////////////////
            /// Запускаем систему
            while (true)
            {
                computerSystem_1.HeavyLoadCalculation_and_TemperatureMonitoring();
            }



        }


    } // class Programm
}// namespace

