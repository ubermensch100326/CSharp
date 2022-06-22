class FightUnit
{
    protected string Name = "None";

    protected int AT = 10;
    protected int HP = 50;
    protected int MAXHP = 100;

    public void StatusRender()
    {
        Console.Write(Name);
        Console.WriteLine("의 능력치------------------------");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);

        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("------------------------------");
    }

    public void Fight(FightUnit _FightUnit)
    {
        this.HP -= _FightUnit.AT;
    }

    public bool IsDeath()
    {
        return HP <= 0;
    }
}