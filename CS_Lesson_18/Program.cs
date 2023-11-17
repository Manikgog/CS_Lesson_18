using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagementSystem managementSystem = new ManagementSystem();
            managementSystem.Add(new Quadrocopter("Квадрокоптер 1", 5, 0, new Coordinate(20, 20, 1)));
            managementSystem.Add(new Quadrocopter("Квадрокоптер 2", 5, 0, new Coordinate(21, 20, 1)));
            managementSystem.Add(new UnmannedPlane("Самолёт 1", 12, 0, new Coordinate(23, 20, 1)));
            managementSystem.Add(new UnmannedPlane("Самолёт 2", 10, 0, new Coordinate(26, 20, 1)));


            managementSystem.Movement += (int i) => { Console.WriteLine(managementSystem[i]); };
            

            for(int i = 0; i < managementSystem.Count(); i++)
            {
                managementSystem.Move(i, new Coordinate(50, 50, 50));
            }

            managementSystem.WriteToXMLFile("C:\\Users\\С - 4\\Documents\\ГЕА\\CS_Lesson_18\\CS_Lesson_18\\output.xml");
            managementSystem.WriteToJsonFile("C:\\Users\\С - 4\\Documents\\ГЕА\\CS_Lesson_18\\CS_Lesson_18\\output.json");
            managementSystem.WriteToTxt("C:\\Users\\С - 4\\Documents\\ГЕА\\CS_Lesson_18\\CS_Lesson_18\\output.txt");
        }
    }
}
