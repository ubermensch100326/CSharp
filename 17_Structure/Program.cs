// See https://aka.ms/new-console-template for more information



struct StructData
{
    // 클래스와 비슷한데 안 되는 것이 있음
    // 리터럴 초기화가 불가능 ( = 100 같은 것)
    // = 0이 기본임
    public int a;
    public int b;
    public void Func()
    {
        a = 100;
        b = 100;
    }
}

namespace Structure
{
    class Program
    {
        static void Test(StructData _Data)
        {
            _Data.a = 1000;
        }

        static void Main(string[] args)
        {
            StructData NewData = new StructData();
            NewData.a = 10;
            NewData.b = 10;

            // 구조체는 클래스와 다르게 값 형임
            // 즉, 함수에 구조체가 들어가게 되면 새로운 구조체가 하나 더 생기는 (복사) 것임
            Test(NewData);

            Item NewItem = new Item();
            NewItem.EquipSetting();

            int Type = NewItem.EnumType();
            switch (Type)
            {
                case (int)ItemType.Equip:
                    Console.WriteLine(ItemType.Equip);
                    break;
                case (int)ItemType.Potion:
                    Console.WriteLine(ItemType.Potion);
                    break;
                default:
                    Console.WriteLine("Others");
                    break;

            }


        }
    }
}

// 사용자 정의 자료형 : class (참조형), structure (값형), enum (값형)
// enum은 다른 언어에서는 정수형 상수라고 하는데 C#에서는 아님
// 보통 어떤 상태를 표현하는 것 중 나만의 것을 가지고 싶을 때 사용함
// 열거형이라고 불림
// 명찰에 가까운 값
// 내가 값의 범위를 지정한 새로운 자료형을 만들어낼 수 있다는 장점이 있고 스위치와 궁합이 좋음
enum ItemType
{
    Equip,
    Potion,
    Quest,
    Nonselect
}

// 클래스가 너무 많아지면 불편해지므로 보통은 멤버변수로 해결함
// 그런데 int ItemType = 0이 Equip 아이템 이런 식으로 하면 가독성이 엄청나게 떨어짐
// 왜냐하면 0을 보고 0이 뭐지?라는 생각을 할 가능성이 매우 높기 때문
// 그래서 enum을 사용하게 됨
class Item
{
    private ItemType Itype = ItemType.Nonselect;
    public void EquipSetting()
    {
        Itype = ItemType.Equip;
    }

    public int EnumType()
    {
        return (int)Itype;
    }

}
