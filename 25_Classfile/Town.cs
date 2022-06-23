class GOTown
{
    // Inven ShopInven = new Inven(5, 10); // 이렇게 적으면 오류남 아마 인스턴스 생성 전에 호출해서 그런 듯 주의할 것
    public static void Town(Player _Player)
    {
        Inven ShopInven = new Inven(3, 4);
        ShopInven.ItemAdd(new Item("드래곤의 정수", 500000));
        ShopInven.ItemAdd(new Item("성검", 100000));
        ShopInven.ItemAdd(new Item("철검", 10000));
        ShopInven.ItemAdd(new Item("소보루빵", 500));
        ShopInven.ItemAdd(new Item("치즈케잌", 2000));
        ShopInven.ItemAdd(new Item("아메리카노", 500));
        ShopInven.ItemAdd(new Item("전설의 에고 웨폰", 1000000));
        ShopInven.ItemAdd(new Item("엘릭서", 5000));
        ShopInven.ItemAdd(new Item("철제 갑옷", 50000));


        while (true)
        {
            Console.Clear();
            _Player.StatusRender();
            Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
            Console.WriteLine("1. 체력을 회복한다.");
            Console.WriteLine("2. 상점을 방문한다.");
            Console.WriteLine("3. 마을을 벗어난다.");
            Console.WriteLine("");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    _Player.Heal();
                    break;
                case ConsoleKey.D2:
                    Shop(_Player, ShopInven);
                    break;
                case ConsoleKey.D3:
                    return;
            }

            Console.WriteLine("");
        }
    }

    static void Shop(Player _Player, Inven _ShopInven)
    {
        while (true)
        {
            _ShopInven.SelectItem();
            _Player.P_Inven.SelectItem();
        }
    }
}