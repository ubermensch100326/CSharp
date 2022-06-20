// See https://aka.ms/new-console-template for more information

public class Player
{
    public static void PVP
    {
        // 7분 17초
    }
    public int HP = 100;
    public void Damage(int _Damage)
    {
        HP -= 100;
    }
}

namespace StaticFuntion
{
    class Program
    {
        // 아래의 함수도 클래스에 속한 정적 함수임
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.Damage(100);
            NewPlayer.Damage(100);
            Console.WriteLine(NewPlayer.HP);
        }
    }
}