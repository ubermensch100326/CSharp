// See https://aka.ms/new-console-template for more information

// static class는 정적 변수와 정적 함수만을 내부에 넣을 수 있음
// 생성자를 만들 수 없음
public static class GTest
{
    // 제네릭 함수는 멤버 함수에도 통용됨
    // 자료형을 변수처럼 사용하고 싶을 때 사용 가능
    // 함수의 식별자에 <다양한 자료형을 대표할 수 있는 이름> 삽입
    public static T ConsolePrint<T>(T _Value)
    {
        Console.WriteLine(_Value);
        return _Value;
    }
    public static T ConsolePrint<T, U>(T _Test1, U _Test2)
    {
        Console.WriteLine(_Test1);
        return _Test1;
    }

}

class GameItem
{

}

class CashItem
{

}

class Program
{
    static void Main(string[] args)
    {
        GTest.ConsolePrint(1000);
        Inven<GameItem> GameItemInven = new Inven<GameItem>();
        GameItem NewGameItem = new GameItem();
        GameItemInven.ItemAdd(NewGameItem);

        Inven<CashItem> CashItemInven = new Inven<CashItem>();
        CashItem NewCashItem = new CashItem();
        CashItemInven.ItemAdd(NewCashItem);
    }
}

class Inven<T>
{
    // GameItem[] ArrInvenItem; // 게임아이템 인벤과 캐시아이템 인벤을 만들려고 하는 건 상속으로는 해결 불가능함
    // CashItem[] ArrInvenItem; // 왜냐하면 멤버변수 자체가 달라지는 것이기 때문 (다만 나머지는 동일함)
    // 이 경우 사용해야 하는 것이 제네릭임

    T[] ArrInvenItem;

    public void ItemAdd(T _Item)
    {

    }

    // public Inven(int _first, int _second)
    // {

    // }
}