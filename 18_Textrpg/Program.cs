// See https://aka.ms/new-console-template for more information
// 객체를 선언해야 할 때
// 함수의 분기
// 함수를 합칠 때와 분리할 때
// C#에서 클래스 상속은 오직 하나만 가능함
// C++과 같이 클래스 상속을 여러 개 받는 언어들도 존재하긴 함
// public : 외부까지
// protected : 자식까지
// private (디폴트) : 나까지
// 따라서 상속을 할 때 변수를 사용하려면 protected를 사용해야 함
// FightUnit에는 NewPlayer, NewMonster 모두 넣을 수 있다
// 왜냐하면 NewPlayer, NewMonster 모두 FightUnit 부분은 포함하고 있기 때문임
// 그렇지만 넣게 되면 FightUnit 이외의 고유한 Player 부분과 Monster 부분은 버리는 셈임
// 이러한 자식의 능력을 버리는 것을 업캐스팅이라고 함 (자식형이 부모형이 되는 것)

// 다운캐스팅은 반대로 FightUnit이지만 Player나 Monster의 기능을 쓰는 것을 말함
// 다운캐스팅은 최대한 지양하는 것이 좋음
// 다운캐스팅을 하다 보면 실수로 플레이어를 몬스터로 변경할 수도 있게 됨

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

}


class Player : FightUnit
{
    public void Heal()
    {
        if (HP < MAXHP)
        {
            HP += 10;
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

class Monster : FightUnit
{

}

enum STARTSELECT
{
    TownSelect,
    BattleSelect,
    NoneSelect
}

namespace TextRPG
{
    class Program
    {
        // 시작
        // 마을로 갈지 싸움터로 갈지 정해주는 함수
        static STARTSELECT StartSelect()
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

        static void Town(Player _Player)
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
                        _Player.StatusRender();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return;
                }

                Console.WriteLine("");
            }

        }

        static void Battle(Player _Player)
        {
            // Console.Clear();
            // Console.WriteLine("아직 개장하지 않았습니다.");
            // Console.ReadKey();

            // Console.WriteLine("");

            Monster NewMonster = new Monster();

            while (true) // 몬스터와 플레이어 둘 중 누가 죽을 때까지
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            // while (true)
            // {
            //     ConsoleKeyInfo KeyInfo = Console.ReadKey();
            //     Console.WriteLine(KeyInfo.Key);

            // }

            Player NewPlayer = new Player();

            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck) // NonSelect는 넣을 필요가 없음 (재입력 시켜야 하기 때문)
                {
                    case STARTSELECT.TownSelect:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.BattleSelect:
                        Battle(NewPlayer);
                        break;
                }
            }


        }

    }
}