using SFML.Window;
using SFML.Graphics;
using SFML.System;
using System;

internal class Soplya
{
    private RenderWindow window;
    public float MoveStep;
    float SpeedMultiplier = 0.75f;
    float HpMultiplier = 2;
    public float CurHp;
    public float Hp;
    public float HpII;
    public float HpIII;
    public Vector2f CurPos;

    float CurExp;
    float MaxXp;
    float MaxXpMultiplier = 1.5f;

    
    CircleShape Havka;
    CircleShape Chelik;
    CircleShape BigChelik;
    CircleShape CurShape;
  public  Projectile projectile;
public     uint height;
  public   uint width;


 public uint CurLevel;



    Controller controller;

    bool UnderPLayerContrroll;


    Color CurColor;
    Color ZVetHavki;
    Color ColorII;
    Color ColorIII;

    public Soplya(float SPEED, float CURHP, float MAXXP, float MAXHP, bool Player, uint CURLEVEL, Color COLOR_I, Color COLOR_II, Color COLOR_III, RenderWindow WINDOW , Controller CONT,uint HEIGHT,uint WIDTH )
    {
        MoveStep = SPEED;
        MaxXp = MAXXP;
        Hp = MAXHP;
        UnderPLayerContrroll = Player;
        ZVetHavki = COLOR_I;
        ColorII = COLOR_II;
        ColorIII = COLOR_III;
        window = WINDOW;
        controller = CONT;
        height = HEIGHT;
        width = WIDTH;



    }

    void ExpGain(float Xp)
    {
        CurExp += Xp;
        if (CurExp == MaxXp)
            LevelUp();
    }

    void LevelUp()
    {
        Chelik = new CircleShape(width, height);
        Chelik = new CircleShape(width * 2, height * 2);
        BigChelik = new CircleShape(width * 4, height * 4);
        CurLevel += 1;
        Hp *= HpMultiplier;
        MoveStep *= SpeedMultiplier;
        MaxXp *= MaxXpMultiplier;

        if (CurLevel == 2)
        {
            CurShape = Chelik;
            CurColor = ColorII;
        }
        if (CurLevel == 3)
        {
            CurShape = BigChelik;
            CurColor = ColorIII;

        }
        else return;
        CurShape.FillColor = CurColor;
        CurShape.Position = CurPos;
        CurShape.Draw(window, RenderStates.Default);


    }

   public void Spawn()
    {
        CurShape = new CircleShape();
        CurHp = MaxXp;
        Chelik = new CircleShape(width, height);
        Chelik = new CircleShape(width * 2, height * 2);
        BigChelik = new CircleShape(width * 4, height * 4);
        

        if (UnderPLayerContrroll == true)
        {
            controller.player = true;
        }
        if (CurLevel == 1)
        {
            CurColor = ZVetHavki;
            CurShape = Havka;
        }

        if (CurLevel == 2)
        {
            CurColor = ColorII;
            CurShape = Chelik;
        }

        if (CurLevel == 3)
        {
            CurColor = ColorIII;
            CurShape = BigChelik;
        }

        CurShape.FillColor = CurColor;
        CurShape.Position = new Vector2f(500, 500);
        CurShape.Draw(window, RenderStates.Default);

    }
   public void Attack()
    {

    }

}

    

    


