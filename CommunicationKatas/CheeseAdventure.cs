﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommunicationKatas
{
    public class CheeseAdventure
    {
        public string CheesePartyDeterminer(string grid, int catSpeed, int mouseSpeed)
        {
            if (catSpeed < 0 || mouseSpeed < 0) { throw new ArgumentException("Speeds must be positive"); }
            if (!Regex.IsMatch(grid, "^-*[K]{1}-*[M]{1}-*[C]{1}-*$")) { throw new ArgumentException("Input grid is not valid."); }

            int catIndex = grid.IndexOf("K");
            int mouseIndex = grid.IndexOf("M");
            int cheeseIndex = grid.IndexOf("C");

            while (true)
            {
                catIndex += catSpeed;
                mouseIndex += mouseSpeed;

                if (catIndex >= cheeseIndex && mouseIndex >= cheeseIndex)
                {
                    return "Cheese party!";
                }
                else if (catIndex >= mouseIndex) { return "No cheese"; }
                else if (mouseIndex >= cheeseIndex) { return "Cheese"; }
            }
        }
    }
}
