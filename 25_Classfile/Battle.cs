class GOBattle
{
    public static STARTSELECT Battle(Player _Player)
    {
        // Console.Clear();
        // Console.WriteLine("아직 개장하지 않았습니다.");
        // Console.ReadKey();

        // Console.WriteLine("");

        Monster NewMonster = new Monster("오크");

        while (!(_Player.IsDeath()) && !(NewMonster.IsDeath())) // 몬스터와 플레이어 둘 중 누가 죽을 때까지 싸우게, 한 쪽이 죽으면 마을로 자동이송
        {
            Console.Clear();
            _Player.StatusRender();
            NewMonster.StatusRender();
            Console.ReadKey();

            Console.Clear();
            _Player.Fight(NewMonster); // 원래 각각에 대해 조건문으로 확인해야 하지만 이건 추후에 함
            NewMonster.Fight(_Player);
            _Player.StatusRender();
            NewMonster.StatusRender();
            Console.ReadKey();
        }

        Console.WriteLine("싸움이 끝났습니다.");
        Console.ReadKey();

        return STARTSELECT.TownSelect;
    }
}