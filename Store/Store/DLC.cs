using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class DLC
    {
        float price;
        string name;
        Game parentGame;
        string description;

        public DLC(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
