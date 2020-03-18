using SFML.Window;
using SFML.Graphics;
using SFML.System;


namespace SFML_IO
{


    internal class Game
    {
        private RenderWindow window;
        private uint SCREEN_WIDTH = 1300;
        private uint SCREEN_HEIGHT=900;
        private bool wantToCloseGame;
        private const uint MAX_FPS_LIMIT = 120;
        private readonly float timeStep = 1f / MAX_FPS_LIMIT;
        Soplya Player;
        Soplya Havka;
        Soplya Enemy;
        Color ColorI;
        Color ColorII;
        Color ColorIII;
        float CurHp;
        Controller controller;





        //   private uint[] PlatX;



        internal void Run()
        {
            Init();

            while (IsGameRun())
            {
                GetInput();

                Logic();

                Draw();
            }
        }

        private void Draw()
        {
            window.Clear(Color.White);

            window.Display();
        }

        private void Logic()
        {



       
        }

        private void GetInput()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                wantToCloseGame = true;
        }

        private bool IsGameRun()
        {
            return window.IsOpen && !wantToCloseGame;
        }

        private void Init()
        {

            ColorI = new Color(9,9,9);
            ColorII = new Color(33, 33,33 );
            ColorII = new Color(1, 0, 0);
            controller = new Controller(Keyboard.Key.W, Keyboard.Key.S, Keyboard.Key.A, Keyboard.Key.D);
            Player = new Soplya(10,CurHp,100,100,true,2,ColorI,ColorII,ColorIII,window,controller,10,10);
            Player.Spawn();
            window = new RenderWindow(new VideoMode(SCREEN_WIDTH, SCREEN_HEIGHT), "...");
            window.SetFramerateLimit(MAX_FPS_LIMIT);
        }

      
    }
}