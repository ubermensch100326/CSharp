// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 플레이어를 구성하는 명사 속성은 멤버 변수가 됨
// 플레이어가 하는 행동 속성은 멤버 함수가 됨
// 게임을 만든다 -> 프로젝트를 만든다

/* class Player
{
    int ATT;
    int HP;

    void Move()
    {

    }

} */

class Player
{
    // 멤버변수 : 클래스 안에 있다고 해서 멤버변수
    // 접근제한 지정자 : 객체지향의 캡슐화 은닉화를 대표하는 문법
    public int Att; // 외부에도 공개
    protected int Hp; // 자식에게만 공개
    private int Def; // 내부에만 공개
    public void Fight()
    {
        Console.WriteLine("플레이어가 싸움");
    }
}



namespace LocalVar
{
    // C#은 고지식한 객체지향 언어
    // 클래스로 시작해서 클래스로 끝남
    // 프로그램의 시작조차 클래스 안에 묶어둠
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("지역변수 공부");
            // 클래스 안에 있으면 멤버변수
            // 함수 안에 있으면 지역변수
            // 지역변수는 내부에서만 사용 가능
            int Att = 0;
            Att = 50;


            // 객체화
            // 클래스는 일종의 설계도와 같음
            // Player 설계도로 플레이어를 만들었음
            // 그 만든 플레이어의 이름이 NewPlayer임
            Player NewPlayer = new Player();
        }
    }
}