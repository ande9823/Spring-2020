using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork2020
{
    class World
    {
        List<Area> allAreas = new List<Area>();
        Area startingArea;
        public Area currentArea;

        public World()
        {
            Area a1 = new Area("starting area", "this is where you start");
            Area a2 = new Area("Silver moon", "it's pretty dman huge");
            Area a3 = new Area("Mushroom forest", "everything is square");
            Area a4 = new Area("Teapot area", "you are surrounded by tea");
            Area a5 = new Area("Teabag area", "you are doomed");

            a4.Connect(a5, Directions.South);
            a1.ConnectBidirectional(a3, Directions.West);
            a3.ConnectBidirectional(a4, Directions.South);
            a4.ConnectBidirectional(a2, Directions.East);
            a2.Connect(a1, Directions.North);
            a5.Connect(a3, Directions.South);

            startingArea = a1;
            currentArea = a1;
        }

        //input: the direction in which we want to move (we are in currentArea)
        //output: successful or unsuccessful move
        public bool Go(Directions direction)
        {
            //hint, maybe deal with the moving logic here
            if (currentArea.neighbors.ContainsKey(direction))
            {
                currentArea = currentArea.neighbors[direction];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
