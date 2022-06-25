class Player : FightUnit
{
    // private으로 선언하면 그 클래스 내의 이너 클래스라 하더라도 접근 불가능
    // 이너 클래스는 사실상 자기 클래스 내부에 있는 다른 클래스임

    // enum은 클래스 안에 넣어줄 수도 있음
    // 그 클래스가 자기만 사용할 때 가장 많이 사용
    public enum PlayerJob
    {
        Novice,
        Knight,
        Fighter,
        Berserker,
        Firemage,
    }

    Inven PlayerInven = new Inven(2, 3);

    public Inven P_Inven
    {
        get
        {
            return PlayerInven;
        }
    }
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