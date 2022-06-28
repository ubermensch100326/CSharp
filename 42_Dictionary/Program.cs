// See https://aka.ms/new-console-template for more information

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연관 복합
            // 딕셔너리는 제네릭이 2개 있는 경우로 볼 수 있음
            // 앞쪽의 string은 key, 뒤쪽의 int는 value (data)라고 함
            Dictionary<string, int> NewDic = new Dictionary<string, int>();

            NewDic.Add("일", 1);
            NewDic.Add("이", 2);
            NewDic.Add("삼", 3);

            // 인덱서
            // 연산자 겹지정이라고 함
            // 딕셔너리는 찾는다는 작업에 특화되어 있음
            Console.WriteLine(NewDic["일"]);
        }
    }
}