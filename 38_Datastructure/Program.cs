﻿// See https://aka.ms/new-console-template for more information

// namespace Datastructure
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             // 자료구조에서 컨테이너라는 용어를 사용하는데, 시퀀스 컨테이너, 연관 컨테이너, 어댑터 컨테이너로 분류함

//             List<int> NewList = new List<int>();

//             for (int i = 0; i < 10; i++)
//             {
//                 Console.WriteLine((NewList.Count + 1).ToString() + "Add");
//                 Console.WriteLine("Capacity : " + NewList.Capacity);
//                 Console.WriteLine("Count : " + NewList.Count);
//                 NewList.Add(100);
//             }

//         }
//     }
// }

class Item
{

}

class MyList<T>
{
    T[] Arr = new T[0];
    int Capacity = 0;
    int Count = 0;
    public void Add(T _Add)
    {
        if (Count + 1 >= Capacity)
        {
            
        }
    }
}
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> IntList = new List<int>(); // 배열형 시퀀스
            List<Item> ItemList = new List<Item>();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Capacity : " + IntList.Capacity); // 배열의 크기
                Console.WriteLine("Count : " + IntList.Count()); // 자료의 크기
                IntList.Add(i);
            }

            MyList<int> NewInt = new MyList<int>();
            NewInt.Add(100);


        }
    }
}