﻿using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTerraria
{
    class Program
    {
        static RenderWindow win;
        static void Main(string[] args)
        {
            //create the window object
            win = new RenderWindow(new SFML.Window.VideoMode(800, 600), "Meu Terraria");
            //need for vertical synchronization
            win.SetVerticalSyncEnabled(true);

            //you need to bind a method to the window event handler that will be called when you click the close window button on the upper right of the window
            win.Closed += Win_Closed;

            //a loop that will work as long as the window is open
            while (win.IsOpen)
            {
                //inside the loop we ask one team that revises all its incoming message box about events such as moving higher, closing when keystrokes and so on
                win.DispatchEvents(); //call the event handlers for each pading events

                //next, we clear the drawing area of the window
                win.Clear(Color.Black);

                /*draw here!*/

                win.Display();

            }
        }

        private static void Win_Closed(object sender, EventArgs e)
        {
            win.Close();
        }
    }
}
