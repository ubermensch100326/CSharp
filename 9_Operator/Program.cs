// See https://aka.ms/new-console-template for more information
// 연산자에서 &&, &은 서로 다르고 ||, | 또한 서로 다른 의미임
// &와 |은 첫 condition에서 바로 답이 나올지라도 나머지도 계산하고 나서 결과 도출함
// 따라서 &와 |가 요구하는 연산의 양이 더 많음

namespace Hojo
{
    class Player
    {
        public int HP = 100;

        void Damage(int _HP)
        {
            HP = HP - 10;

        }
    }
}

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int Left = 3;
            int Right = 7;

            Result = Left + Right;
            Hojo.Player NewPlayer = new Hojo.Player();
            Console.WriteLine(NewPlayer.HP);

            bool BResult = !(Left != Right);
            Console.WriteLine(BResult);

            Result += 10;
            Result *= 10;

        }
    }
}