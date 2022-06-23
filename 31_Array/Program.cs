// See https://aka.ms/new-console-template for more information

namespace Array
{
    class Program
    {
        class Item
        {
            public string Name = "none";
            int AT;

            public Item()
            {

            }

            public Item(string _name)
            {
                Name = _name;
            }
        }

        static void Main(string[] args)
        {
            int[] ArrInt = new int[10];
            // C#에서는 모든 자료형은 클래스 혹은 구조체라고 할 수 있음
            // 값형 배열을 정의하면 그 내부까지 다 생성됨 (여기에서는 각 원소가 0)

            for (int i = 0; i < ArrInt.Length; i++)
            {
                Console.WriteLine(ArrInt[i]);
            }

            Item[] ArrItem = new Item[10];
            // ArrItem은 10개의 칸을 가진 클래스 타입의 배열 객체임
            // 여기서 주의할 점은 배열 안의 각각의 클래스는 인스턴스화가 안 되어서 객체가 아님
            // 따라서 따로 할당시켜줘야 함
            // 물론 이건 레퍼런스형이라서 그런 것임
            // https://program-rest-area.tistory.com/110
            // 아이템이라는 참조형을 담을 수 있는 공간이 10개 생겼다는 뜻임
            // 한마디로 각각이 클래스 공간이 아니라 클래스를 가리키는 포인터 공간이 생겼다는 뜻인 듯
            // 이렇게 생각하면 포인터 공간만 따로 생긴 것이므로 당연히 개별적으로 인스턴스를 생성해줘야 함
            // Item NewItem; 이렇게 선언하면 아이템 자체가 선언된 것이 아니라 아이템을 가리키는 것이 선언됐다는 뜻임
            // 진짜 아이템은 뒤에 추가적으로 new Item()을 붙이는 것임
            ArrItem[0] = new Item("하나");
            ArrItem[1] = new Item("둘");
            ArrItem[2] = new Item("셋");
            ArrItem[3] = new Item();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(ArrItem[i].Name);
            }

        }

    }
}