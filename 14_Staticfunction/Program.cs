// See https://aka.ms/new-console-template for more information
/*
필드라는 개념은 { } 내의 영역을 의미함
클래스 혹은 메소드가 필드를 가질 수 있음
그런데 namespace 또한 필드를 가지고 있음
namespace 간에는 이름이 달라야 하지만 내용물의 이름은 다르지 않아도 됨
보통 코드에서 맨 처음에 적는 using 키워드는 namespace를 하나하나 적지 않게 해줌
C로 따지면 include와 같은 작업이라고 보면 됨
아무런 using도 하지 않았다면, System.Console.WriteLine();과 같이 적어야 함
만약 using System;을 했다면, Console.WriteLine();으로 생략하여 적을 수 있음
단순히 namespace만을 생략할 것이라면 using을 쓰면 되지만, namespace 내의 class까지 생략할 거면 using static을 사용해야 함
using static System.Console;을 하면 WriteLine();으로 사용 가능함
만약 namespace 내에 namespace가 또 있다면 using만 사용하면 됨 (using InterFace1.InterFace2;)
만약 동일한 클래스명을 가지고 있는 namespace를 둘 다 using으로 생략하려고 하면 문법 오류가 남
https://m.blog.naver.com/bug_ping/221425846342
*/

class Player
{
    // 정적 멤버함수는 정적 멤버변수와 마찬가지로 그 클래스에 속함
    // 그러나 객체를 이용하지 (+만들지) 않고 사용할 수 있는 함수
    // 이러한 함수를 정적 멤버함수라고 함
    // 객체화를 하지 않아도 플레이어의 내부는 내부이므로 접근제한 지정자의 영향을 받지 않음
    // 객체의 멤버 변수가 아닌 클래스 변수로 선언이 됨
    public static void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }
    private int AT = 100;
    private int HP = 100;
    public void Damage(int _Damage)
    {
        HP -= 100;
    }

    // 자기자신의 레퍼런스는 자신의 내부에서 public인 상태임
    public void Damage(Player _Other)
    {
        HP -= _Other.AT;
    }

    // 정적 클래스는 정적 멤버변수와 정적 멤버함수만을 가질 수 있음
}

namespace StaticFuntion
{
    class Program
    {
        // 아래의 함수도 클래스에 속한 정적 함수임
        // 어떤 클래스에 존재하는 Main이라는 이름을 가진 정적 멤버함수에서부터 C# 프로그램은 시작함
        // public : 접근 제한자 중 하나
        // static : 메모리에서 제일 먼저 실행됨
        // void : 리턴값을 의미하는데, Main 메소드는 리턴값이 없음
        // Main : 메소드 이름
        // string[] : string형 배열
        // args : 배열의 이름

        // main에 static을 사용하는 이유
        // 프로그램이 실행하기 전에 static 함수나 static 변수가 메모리에 올라가고 프로그램이 종료될 때까지 사라지지 않음
        // main 함수가 실행되기 위해서는 메모리에 미리 올라가야 함
        // 메모리에 올라가 있지 않으면 시작점인 main 함수를 호출하려고 하는데 메모리에는 main 함수가 올라가 있지 않기 때문에 실행이 안 됨
        // 따라서 main에 static을 붙이는 것임
        // main 메소드는 프로그램의 entry point이기 때문에 클래스 선언 없이 접근할 수 있어야 함
        // C#에서는 메소드만 따로 작성할 수 없고 최소 단위가 class이기 때문에 그 안에 static으로 선엄함으로써 직접적으로 접근할 수 있는 구조임
        // https://attibook.tistory.com/154
        // https://charlesslee.tistory.com/entry/C%EC%97%90%EC%84%9C-%ED%95%A8%EC%88%98%EC%97%90-Static%EC%9D%84-%EB%B6%99%EC%9D%B4%EB%8A%94-%EC%9D%B4%EC%9C%A0-1

        // C#에서는 여러 개 클래스에 대해 각각 여러 main 메소드를 사용할 수 있음
        // 그러나 시작점이 어디인지 몰라서 실행은 안 됨 (Java는 된다고 함)
        // MainEntryPoint나 StartupObject를 이용하면 이 문제를 해결할 수 있다고 함
        // https://stackoverflow.com/questions/11551412/multiple-main-functions
        static void Main(string[] args)
        {

            /* Player NewPlayer = new Player();
            NewPlayer.Damage(100);
            NewPlayer.Damage(100);
            Console.WriteLine(NewPlayer.HP);
            // WriteLine이라는 함수 또한 Console이라는 클래스 내의 정적 멤버함수임
            */

            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            Player.PVP(NewPlayer1, NewPlayer2);

            NewPlayer1.Damage(100);

        }
    }
}

public class Monster
{
    private int AT = 100;
    /*     static public void PVP(Player _Left, Player _Right)
            {
                _Left.HP -= _Right.AT;
                _Right.HP -= _Left.AT;
            }
     */
}

