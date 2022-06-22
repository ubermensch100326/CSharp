class Player : FightUnit
{
    public Player()
    {
        Name = "플레이어";
    }

    public void Heal()
    {
        if (HP < MAXHP)
        {
            HP += 10;
            StatusRender();
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("이미 체력이 최대입니다.");
            Console.ReadKey();
        }


        return;
    }
}