using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Wumpus
{
    static class Player
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            //constructor
            public Player()
            {
                //create player object

                public int Arrows()
                {
                    //arrows begin at three; increases upon collection, decreases upon useage
                    int arrows = 3;

                    //return arrows -> gui and hs
                    return arrows;
                }

                public int Coins()
                {
                    //sends information to GUI
                    //starts at zero; increases each time coins are collected; decreases per triva or action
                    int coins = 0;

                    //return coins
                    return coins;
                }

                public int Turns()
                {
                    //starts at zero; each time player changes turns++
                    int turns = 0;

                    //returns how many
                    return turns;
                }
         }

        
    }
}
