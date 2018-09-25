using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MORO
{
 

    class TitleConsole : Console
    {
        public TitleConsole(string title)
            : base(25, 7)
        {
            Fill(Color.White, Color.Black, 176);
            Print(0, 0, title.Align(HorizontalAlignment.Center, Width), Color.Black, Color.Yellow);
        }

    }

    class MapConsole : Console
    {
        public MapConsole(string title)
            : base(132, 35)
        {
            Fill(Color.Green, Color.Black, 176);
            Print(0, 0, title.Align(HorizontalAlignment.Center, Width), Color.Black, Color.Yellow);
        }
    }
    class StatusConsole : Console
    {
        public StatusConsole(string title)
            : base(158, 10)
        {
            Fill(Color.Gray, Color.Black, 176);
            Print(0, 0, title.Align(HorizontalAlignment.Center, Width), Color.Black, Color.Yellow);
        }
    }
    class ChatConsole : Console
    {
        public ChatConsole(string title, string carot)
            : base(160, 1)
        {
            //Fill(Color.Transparent, Color.Transparent , 176);
            //Print(1, 158, title.Align(HorizontalAlignment.Center, Width), Color.Transparent, Color.Transparent);
            //Print(2, 159, carot.Align(HorizontalAlignment.Left, Width), Color.Transparent, Color.Transparent);
            //Cursor.IsVisible = true;

            //var input = new SadConsole.Controls.TextBox(14);
            //input.Position = new Point(10, 8);
            //Cursor.Position = new Point(2, 47);

            

        }
    }
    class InputCon : Console
    {
        public InputCon()
            :base(160,3)
        {
            var console = new SadConsole.ControlsConsole(160, 3);
            var input = new SadConsole.Controls.TextBox(160);


            input.Position = new Point(3, 3);

            Fill(Color.Red, Color.Red, 176);
            console.Add(input);
            

        }

    }


    class Program
    {

        public const int Width = 160;
        public const int Height = 51;
        static void Main(string[] args)
        {
            // Setup the engine and creat the main window.
            SadConsole.Game.Create("IBM.font", Width, Height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            // Hook the update event that happens each frame so we can trap keys and respond.
            SadConsole.Game.OnUpdate = Update;

            // Start the game.
            SadConsole.Game.Instance.Run();

            //
            // Code here will not run until the game window closes.
            //

            SadConsole.Game.Instance.Dispose();
        }

        private static void Update(GameTime time)
        {
 
           //do stuff
        }



        private static void Init()
        {
            
            //var chatCon = new ChatConsole("Chat", "->") { Position = new Point(1, 47) };
            SadConsole.Global.CurrentScreen = new SadConsole.ScreenObject();
            var test = (new InputCon() { Position = new Point(1, 47) });


            SadConsole.Global.CurrentScreen.Children.Add(new TitleConsole("1") { Position = new Point(1, 1) });
            SadConsole.Global.CurrentScreen.Children.Add(new TitleConsole("2") { Position = new Point(1, 9) });
            SadConsole.Global.CurrentScreen.Children.Add(new TitleConsole("3") { Position = new Point(1, 17) });
            SadConsole.Global.CurrentScreen.Children.Add(new MapConsole("World") { Position = new Point(27, 1) });
            SadConsole.Global.CurrentScreen.Children.Add(new StatusConsole("Status") { Position = new Point(1, 37) });
            //SadConsole.Global.CurrentScreen.Children.Add(new InputCon() { Position = new Point(1, 47) });



            //SadConsole.Global.CurrentScreen.Children.Add(new InputCon());
            //SadConsole.Global.CurrentScreen.Children.Add(chatCon);
            SadConsole.Global.CurrentScreen.Children.Add(test);
            SadConsole.Global.FocusedConsoles.Set(test);







        }

    }
}

