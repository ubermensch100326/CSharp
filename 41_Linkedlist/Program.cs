// See https://aka.ms/new-console-template for more information
/* 
class Node<T>
{
    public Node<T> Next;
    public Node<T> Prev;
}

class MyLinkList<T>
{
    public Node<T> First;
    public Node<T> Last;
}
// 이 두 클래스의 역할을 자동으로 해주는 게 LinkedList라고 볼 수 있음

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 시퀀스 배열형 List
            // 시퀀스 노드형 LinkedList
            LinkedList<int> LList = new LinkedList<int>();

            LList.AddFirst(10);
            LList.AddFirst(20);
            LList.AddFirst(30);

            for (LinkedListNode<int> StartNode = LList.First;
                StartNode != null;
                StartNode = StartNode.Next)
            {
                Console.WriteLine(StartNode.Value);
            }

            LinkedListNode<int> Cur = LList.First;
            Cur = Cur.Next;
            LList.AddAfter(Cur, 999);
        }
    }
} */

class Zone
{
    public string Name = "None";
    public List<Zone> LinkZone = new List<Zone>();

    public Zone Update()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("이곳은 " + Name + "입니다.");
            Console.WriteLine("이동할 수 있는 장소 목록 : ");
            for (int i = 0; i < LinkZone.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + LinkZone[i].Name);
            }

        }
    }
    public Zone(string _Name)
    {
        Name = _Name;
    }
}

namespace NodeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Zone NewZone0 = new Zone("태초마을");
            Zone NewZone1 = new Zone("초보사냥터");
            Zone NewZone2 = new Zone("중급사냥터");
            Zone NewZone3 = new Zone("중급마을");
            Zone NewZone4 = new Zone("고급사냥터");

            NewZone0.LinkZone.Add(NewZone1);
            NewZone0.LinkZone.Add(NewZone2);

            NewZone1.LinkZone.Add(NewZone3);

            NewZone2.LinkZone.Add(NewZone3);

            NewZone3.LinkZone.Add(NewZone4);

            Zone StartZone = NewZone0;
        }
    }
}