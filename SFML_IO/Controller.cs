using SFML.Window;
using SFML.Graphics;
using SFML.System;
using System;



internal class Controller
{
    Soplya soplya;
    
    public bool player;
    Keyboard.Key MoveUp;
    Keyboard.Key MoveDown;
    Keyboard.Key MoveLeft;
    Keyboard.Key MoveRight;

   public Controller(Keyboard.Key UP, Keyboard.Key DOWN , Keyboard.Key LEFT ,Keyboard.Key RIGHT)
    {
        MoveUp = UP;
        MoveDown = DOWN;
        MoveLeft = LEFT;
        MoveRight = RIGHT;

    }
    void controlls() {
        float move = soplya.MoveStep;
        if (player == true) 
        {
            if (Keyboard.IsKeyPressed(MoveRight)  )
              soplya.CurPos.X += move;

            if (Keyboard.IsKeyPressed(MoveLeft) )
                soplya.CurPos.X -= move;

            if (Keyboard.IsKeyPressed(MoveUp))
                soplya.CurPos.Y += move;

            if (Keyboard.IsKeyPressed(MoveDown))
                soplya.CurPos.Y -= move;

            if (soplya.CurLevel > 2 && Mouse.IsButtonPressed(0))
            {
                soplya.Attack();
            }
        }
    }
}