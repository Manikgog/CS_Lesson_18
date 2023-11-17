using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CS_Lesson_18
{
    [XmlInclude(typeof(Quadrocopter))]
    [XmlInclude(typeof(UnmannedPlane))]
    public abstract class UnmannedAerialVehicle
    {
        
        public string Model { get; set; }
        public double Weight { get; set; }
        public int Velocity { get; set; }

        public Coordinate Coord { get; set; }

        public UnmannedAerialVehicle() { }

        public UnmannedAerialVehicle(string model, double weight, int velocity, Coordinate coord)
        {
            Model = model;
            Weight = weight;
            Velocity = velocity;
            Coord = coord;
            
        }

        public abstract void MoveToPoint(Coordinate coord);

        public override string ToString()
        {
            return "Модель: " + Model + "; Вес: " + Weight + "; Скорость: " + Velocity
                   + ". Координаты: " + Coord.ToString(); 
        }

    }
}
