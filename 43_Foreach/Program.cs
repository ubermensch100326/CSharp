// See https://aka.ms/new-console-template for more information

class GTest<T>
{
    public T Data;
}


namespace DataStructEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> NewDic;
            List<Dictionary<string, int>> NewTest;

            Dictionary<string, int> DicTest = new Dictionary<string, int>();

            // 웬만하면 for문을 이용하여 순회 방식으로 할 것
            List<int> ListTest = new List<int>();
            LinkedList<int> LinkedListTest = new LinkedList<int>();

            ListTest.Add(1);
            ListTest.Add(2);
            ListTest.Add(3);
            ListTest.Add(4);
            ListTest.Add(5);

            LinkedListTest.AddLast(1);
            LinkedListTest.AddLast(2);
            LinkedListTest.AddLast(3);
            LinkedListTest.AddLast(4);
            LinkedListTest.AddLast(5);

            DicTest.Add("일", 1);
            DicTest.Add("이", 2);
            DicTest.Add("삼", 3);
            DicTest.Add("사", 4);
            DicTest.Add("오", 5);

            // foreach는 자동으로 반복하는 문장임
            // in을 통해 배열, 딕셔너리, 리스트 등의 내부의 자료를 그대로 순회할 수 있게 처리해줌
            // var은 이 때 가장 적합한 자료형이라고 볼 수 있음
            // in은 자료구조에서 빼온다는 의미로 이해하면 됨
            // 대신 루프에 대해 조건을 설정하기 어려움
            // 딕셔너리 빼고는 foreach를 잘 사용하지 않음
            // 물론 딕셔너리 또한 for문을 사용하지 않는 것이 좋음
            // 따라서 그냥 이런 것이 있다고 정도만 들고갈 것
            foreach (var item in ListTest)
            {
                Console.WriteLine(item);
            }

            foreach (var item in LinkedListTest)
            {
                Console.WriteLine(item);
            }

            foreach (var item in DicTest)
            {
                Console.WriteLine(item);
            }
        }
    }
}