// See https://aka.ms/new-console-template for more information
// 깃 명령어가 git bash 말고 powershell에서도 되는 이유 : 환경변수 등록
// 나중에 환경변수가 구체적으로 어떤 의미인지 찾아볼 것

// 아직 안 배운 개념
// overloading
// overriding
// interface
// partial
// array
// generic (자료형에 대한 제네릭, 자료구조에 대한 네임스페이스 제네릭)

// partial은 한 클래스 내에 멤버변수나 멤버함수가 너무 많을 때 파일을 나눠서 저장할 수 있게 해줌
// 실제 빌드하면 partial 동일명 클래스들은 모두 합쳐짐

// overloading은 함수명이 중복되더라도 오는 매개변수 종류가 달라지면 다르다는 것임
// 멤버함수, 정적함수, 생성자 모두 overloading 가능함

// overriding
// 자식 단계에서 추가된 내용을 부모가 모른다는 단점을 해결하기 위해 등장함

// 클래스 안에서 선언된 변수를 필드라고 함
// 필드는 일반적으로 클래스의 부품 역할을 하며 대부분 private 한정자가 붙음
// C/C++ 등의 언어에서는 해당 범위에서의 전역변수와 같은 의미임
// 필드는 클래스가 가지는 속성이며 변수 또는 상수가 위치함
// this는 나 자신의 인스턴스를 의미함
// 필드, 멤버변수, 전역변수 다 같은 의미임
// this와 관련된 field initialization (class 내에서 바로 쓸 수 없는 이유) : https://stackoverflow.com/questions/1920615/field-initialization
// https://stackoverflow.com/questions/42054176/inheritance-cant-access-base-class-data-member-in-derived-class
// https://cosmosproject.tistory.com/544


class FightUnit
{
    protected string Name = "NONE";
    public static int AT = 10;
    protected int HP = 100;
    protected int Test = AT; // 잘 됨

    // HP = 200; // 쓰면 오류남 생성자 호출이 제일 먼저이므로 멤버함수 내에서부터 쓸 수 있음 (호출 전에 바로 사용하는 것이므로 말이 안 됨)
    // AT = 500; // 쓰면 오류남 : https://stackoverflow.com/questions/72700708/invalid-token-in-class-record-struct-or-interface-member-declaration
    // 타입 이전에 modifier가 오면 안 된다고 함 https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1519
    // 이 문법의 핵심은 자식에서 만약 나의 GetAT를 재정의했다면 자식의 GetAT를 호출하라는 것임
    // 이걸 오버라이딩이라고 함
    // 다형성의 핵심 문법 중 하나임
    // 동적 바인딩
    // 생성자는 오버라이딩 불가능
    // 생성자는 내가 나의 멤버변수를 가지고 메모리가 생겨나도록 하는데 이걸 자식한테 맡길 수는 없음
    // property는 오버라이딩 가능
    // public virtual int GetAT()
    // {
    //     Console.WriteLine("UNIT의 GetAT");
    //     return AT;
    // }
    // 변수도 오버라이딩 불가능 (단 하이딩은 되는 듯)
    // static 함수도 오버라이딩 불가능 (this가 없기 때문)

    public virtual int GetAT
    {
        get
        {
            return AT;
        }
    }
    // 플레이어가 공격할 때는 플레이어의 아이템을 고려하여 증가한 공격력을 이용하고 싶음
    // 그러나 부모 클래스인 FightUnit은 Player의 멤버변수를 알 수가 없는 상태임
    public void Damage(FightUnit _OtherFightUnit)
    {
        // AT = 100; 이거 오류남 static 때문인 듯
        // HP = 100; 이건 잘 됨
        int AT = _OtherFightUnit.GetAT;
        Console.WriteLine(this.Name + "가 " + _OtherFightUnit.Name + "에게 " + AT + "만큼의 데미지를 입었습니다.");
        HP -= AT;
    }


}

class Player : FightUnit
{
    // AT = 5; 오류 남, 생성자 호출 이전하고는 관련 없고 (static이므로 애초에 this가 없음) 그냥 클래스에서 바로 값을 할당해서 그럼
    // int AT = 5; 자동으로 하이딩 됨
    // testvar = AT; 이건 잘 됨
    // HP = 5; 오류 남, 생성자 호출 이전에 썼기 때문
    public override int GetAT // 부모도 GetAT를 가지고 있고 자식도 GetAT를 가지고 있다면 자식의 것이 우선시됨
    {
        get
        {
            Console.WriteLine("플레이어의 GetAT");
            return AT + ItemAT;
        }
    }
    public Player(string _Name)
    {
        Name = _Name;
    }

    public void test() // 이게 안 될 줄 알았는데 잘 돌아감, 생각해보니 Player.AT는 정상적으로 사용 가능하기 때문에 당연한 듯
    {
        AT = 50;
    }
    int ItemAT = 5;
}

class Monster : FightUnit
{
    int MonsterLV = 10;

    public override int GetAT
    {
        get
        {
            Console.WriteLine("몬스터의 GetAT");
            return AT + MonsterLV;
        }
    }
    public Monster(string _Name)
    {
        Name = _Name;
    }
}

namespace Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("플레이어");
            Monster NewMonster = new Monster("몬스터");

            // NewPlayer.GetAT(); // FightUnit의 GetAT는 숨겨서 업캐스팅이 일어나지 않음
            NewPlayer.Damage(NewMonster); // 업캐스팅 일어남
            NewMonster.Damage(NewPlayer); // 업캐스팅 일어남
        }
    }
}