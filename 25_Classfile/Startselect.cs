enum STARTSELECT
{
    TownSelect,
    BattleSelect,
    NoneSelect
}


class GOStartSelect
{
    public static STARTSELECT StartSelect()
    {
        Console.Clear(); // 콘솔 화면을 지워줌
        Console.WriteLine("1. 마을");
        Console.WriteLine("2. 배틀");
        Console.WriteLine("어디로 가시겠습니까?");

        ConsoleKeyInfo CKI = Console.ReadKey();

        Console.WriteLine("");

        switch (CKI.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                Console.WriteLine("마을로 이동합니다.");
                Console.ReadKey();
                Console.WriteLine("");
                return STARTSELECT.TownSelect;
            case ConsoleKey.D2:
                Console.Clear();
                Console.WriteLine("배틀을 시작합니다.");
                Console.ReadKey();
                Console.WriteLine("");
                return STARTSELECT.BattleSelect;
            default:
                Console.Clear();
                Console.WriteLine("잘못된 선택입니다.");
                Console.ReadKey();
                Console.WriteLine("");
                return STARTSELECT.NoneSelect;
        }

    }
}