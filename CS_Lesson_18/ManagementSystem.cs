using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace CS_Lesson_18
{
    internal class ManagementSystem
    {
        public event Action<int> Movement;

        List<UnmannedAerialVehicle> unmannedAerialVehicles { get; set; }

        public ManagementSystem()
        {
            unmannedAerialVehicles = new List<UnmannedAerialVehicle>();
        }

        public void Add(UnmannedAerialVehicle unmanned)
        {
            unmannedAerialVehicles.Add(unmanned);
        }

        public void Remove(UnmannedAerialVehicle unmanned)
        {
            unmannedAerialVehicles.Remove(unmanned);
        }

        public int Count()
        {
            return unmannedAerialVehicles.Count;
        }

        public UnmannedAerialVehicle this[int index]
        {
            get
            {
                return unmannedAerialVehicles[index];
            }

            set
            {
                unmannedAerialVehicles[index] = value;
            }
        }

        public void Move(int index, Coordinate coord)
        {
            unmannedAerialVehicles[index].MoveToPoint(coord);
            Movement?.Invoke(EventHandler(index));
        }

        public int EventHandler(int index)
        {
            return index;
        }

        public void WriteToJsonFile(string path)
        {
            string outputJson = JsonConvert.SerializeObject(unmannedAerialVehicles);

            System.IO.File.WriteAllText(path, outputJson);
        }
        public void WriteToXMLFile(string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<UnmannedAerialVehicle>));
            using (FileStream fstream = new FileStream(path, FileMode.Truncate))
            {
                xml.Serialize(fstream, unmannedAerialVehicles);
            }
        }

        public void WriteToTxt(string path)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();                    // объект для задания кодировки для считывания и записи
            using (StreamWriter writer = new StreamWriter(path, false, unicode))    // запись буфера в файл
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < unmannedAerialVehicles.Count; i++)                      // цикл для построчной записи
                {
                    stringBuilder = stringBuilder.Append(unmannedAerialVehicles[i].ToString() + "\n");                            
                }
                writer.WriteLine(stringBuilder.ToString()); // запись строки в файл
            }
        }
    }
}
