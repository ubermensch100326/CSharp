// See https://aka.ms/new-console-template for more information
// 인터페이스 설명 : https://qzqz.tistory.com/193
// 객체지향 5원칙
// SOLID
// 1. 단일 책임의 원칙
// 2. 개방 폐쇄의 원칙
// 3. 리스코브 치환의 원칙
// 4. 인터페이스 분리의 원칙 : 함수를 쪼개서 만든 다음 그 쪼갠 함수들을 조합해서 새 기능을 만들어내는 것
// 5. 의존성 역전의 원칙

class Program
{
    static void Main(string[] args)
    {
        // // null은 가리키는 것 없이 비워놓겠다는 의미임
        // Player NewPlayer1 = new Player();
        // Player NewPlayer2 = null;
        // Console.WriteLine(NewPlayer1.AT);
        // // System.NullReferenceException 뜨는데, 비어있는 건 사용하지 말라는 뜻임
        // Console.WriteLine(NewPlayer2.AT);

        Inven NewInven = new Inven(3, 8);
        NewInven.ItemAdd(new Item("영약", 10000), 2);
        NewInven.ItemAdd(new Item("철검", 100));
        NewInven.ItemAdd(new Item("빵", 10));
        NewInven.ItemAdd(new Item("드래곤의 뿔", 5000));
        NewInven.ItemAdd(new Item("드래곤의 혼", 100000), 7);
        NewInven.ItemAdd(new Item("야수의 심장", 50000), 24);


        NewInven.SelectItem2();
        // NewInven.Render();

    }
}