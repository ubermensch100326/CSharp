// See https://aka.ms/new-console-template for more information
using System.IO;

class Player
{
    public int HP = 100;
    public int AT = 10;
}

namespace Reference
{
    class Program
    {
        static void ArrayTest(int[] _ArrTest)
        {
            _ArrTest[0] = 99999;
        }
        static void ClassTest(Player _Test)
        {
            _Test.AT = 10000;
        }
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.AT = 50;
            ClassTest(NewPlayer); // 힙에 있는 녀석이 이 함수에 들어갔다 나왔다는 의미
            Console.WriteLine(NewPlayer.AT);

            NewPlayer = new Player();
            int[] ArrNumber = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ArrayTest(ArrNumber);
            Console.WriteLine(ArrNumber[0]);
        }

    }
}