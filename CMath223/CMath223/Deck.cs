using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMath223
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() 
            { 
                "Red", "Yellow", "Green", "Blue", "Black",
                "Switch", "Pick Two" 
            };
            List<string> Faces = new List<string>()
            {
                "Zero", "One", "Two", "Three", "Four", "Five", "Six", 
                "Seven","Eight", "Nine", "Ten",
            };
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }
    }
}
