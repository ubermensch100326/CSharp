// See https://aka.ms/new-console-template for more information


class Player
{
    private int HP = 100;
    /*     public void Damage(int _Dmg)
        {
            // C# 은 어떻게 이 HP가 NewPlayer2의 HP 라는 것을 알 수 있을까?
            // HP -= _Dmg;
            // this.HP -= _Dmg;

        } */

    // 

    public static void Damage(Player _this, int _Dmg)
    {
        _this.HP -= _Dmg;
    }

    // 멤버함수의 호출이란 어차피 넣어줄 거 내가 대신 넣어줄게 -> this.
    // 멤버함수에서 멤버변수를 쓴다면 눈에 보이지는 않지만 앞에 this.이 생략된 거임
    // 객체지향에서 매우 중요한 핵심 개념이 this임
    // 위 static 함수에서 그냥 HP를 쓸 수 없는 이유가 여기서 나옴
    // static 함수에는 this가 없음
    // static 함수는 객체화되지 않고도 쓸 수 있음
    // static 함수는 자기자신이라는 객체를 특정할 수가 없음
    // 따라서 this.HP라고 했을 때 this라고 할 만한 것이 없음!!

    public void Heal(int _Heal) // 보이진 않지만 public void Heal(Player _this, int _Heal)이라고 생각하면 됨
    {
        this.HP += _Heal;
    }

    private static int StTest = 100;
    public static void PVP(Player _Left, Player _Right)
    {
        StTest = 50;
        // HP = 1000; 사용 불가능
        // 객체에 영향을 받지 않는 것이 정적 멤버함수, 정적 멤버변수
        // 정적 멤버변수만을 정적 멤버함수에서 사용할 수 있음
    }
}

namespace ThisReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player.Damage(NewPlayer2, 100);

            Player.PVP(NewPlayer1, NewPlayer2);

        }
    }
}