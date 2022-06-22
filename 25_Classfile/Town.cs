class GOTown
{
    public static void Town(Player _Player)
    {
        while (true)
        {
            Console.Clear();
            _Player.StatusRender();
            Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
            Console.WriteLine("1. 체력을 회복한다.");
            Console.WriteLine("2. 무기를 강화한다.");
            Console.WriteLine("3. 마을을 벗어난다.");
            Console.WriteLine("");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    _Player.Heal();
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    return;
            }

            Console.WriteLine("");
        }

    }
}