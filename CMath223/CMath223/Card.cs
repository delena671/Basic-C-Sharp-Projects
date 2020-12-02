using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMath223
{
    public class Card
    {
        public Card()
        {
            Suit = "Red";
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
