using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerManager.App.Model
{
    public class Water : Beverage
    {
        public Water(bool hasBubbles) : base(hasBubbles)
        {
        }

        public override bool ModifyQuantity(int quantity)
        {
            return true;
        }
    }
}
