using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CS_Lesson_18
{
    [XmlInclude(typeof(UnmannedPlane))]
    public class UnmannedPlane : UnmannedAerialVehicle
    {  

        public UnmannedPlane() { }
        public UnmannedPlane(string model, double weight, int velocity, Coordinate coord)
            : base(model, weight, velocity, coord)
        {}

        public override void MoveToPoint(Coordinate coord)
        {
            Coord = coord;

        }

    }
}
