using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    class Area
    {
        //Directions dir = Directions.West;
        Dictionary<Directions, Area> neighbors = new Dictionary<Directions, Area>();

        List<Item> items = new List<Item>();

        string description;
        string name;

        public Area(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Connect(Area other, Directions dir)
        {
            neighbors.Add(dir, other);
        }

        public void ConnectBidirectional(Area other, Directions dir)
        {
            Connect(other, dir);
            other.Connect(this, Opposite(dir));
        }

        Directions Opposite(Directions dir)
        {
            switch(dir)
            {
                case Directions.North:
                    return Directions.South;
                case Directions.South:
                    return Directions.North;
                case Directions.East:
                    return Directions.West;
                case Directions.West:
                    return Directions.East;
                default:
                    return Directions.North;
            }
        }

    }


    public enum Directions
    {
        North, West, East, South
    }
}
