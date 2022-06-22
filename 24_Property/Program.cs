// See https://aka.ms/new-console-template for more information

class Player
{
    int AT = 10;

    public int HP;

    // Property라는 문법은 get, set을 사용하기 편하도록 만들어놓은 것임
    // Property라는 문법에서 get만 만들거나 set만 만들거나 할 수도 있음
    // 물론 그럴 경우 사용도 만들어놓은 get, set만 되는 거임
    public int PropertyAT
    {
        get
        {
            if (999 < AT)
            {
                Console.WriteLine("최대 수정치를 넘겼습니다.");
            }
            return AT;
        }

        set
        {
            AT = value;
        }
    }

    static int m_StaticValue = 100;

    public static int StaticValue
    {
        get
        {
            return m_StaticValue;
        }


        set
        {
            m_StaticValue = value;
        }
    }

    // get, set을 property가 아니라 직접 구현하는 경우
    // public int GetAT()
    // {
    //     return AT;
    // }

    // public void SetAT(int _Value)
    // {
    //     if (999 < _Value)
    //     {
    //         Console.WriteLine("최대 수정치를 넘겼습니다.");
    //         while (true)
    //         {
    //             Console.ReadKey();
    //         }
    //     }

    //     AT = _Value;
    //     return;
    // }
}

// class Test : Player
// {

//     // SetHP(50); 왜 오류가 뜰까?

//     Test()
//     {
//         SetAT(50);
//     }
// }



namespace Property
{

    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Player.StaticValue = 200;

            NewPlayer.PropertyAT = 100;
            int PlayerAT = NewPlayer.PropertyAT; // 마우스 갖다대면 get, set이라고 나옴

            NewPlayer.HP = 80; // 마우스 갖다대면 field라고 나옴

        }
    }
}