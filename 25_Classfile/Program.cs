// See https://aka.ms/new-console-template for more information
// 객체를 선언해야 할 때
// 함수의 분기
// 함수를 합칠 때와 분리할 때
// C#에서 클래스 상속은 오직 하나만 가능함
// C++과 같이 클래스 상속을 여러 개 받는 언어들도 존재하긴 함
// public : 외부까지
// protected : 자식까지
// private (디폴트) : 나까지
// 따라서 상속을 할 때 변수를 사용하려면 protected를 사용해야 함
// FightUnit에는 NewPlayer, NewMonster 모두 넣을 수 있다
// 왜냐하면 NewPlayer, NewMonster 모두 FightUnit 부분은 포함하고 있기 때문임
// 그렇지만 넣게 되면 FightUnit 이외의 고유한 Player 부분과 Monster 부분은 버리는 셈임
// 이러한 자식의 능력을 버리는 것을 업캐스팅이라고 함 (자식형이 부모형이 되는 것)

// i/o 디버깅 오류 나면 launch.json "console": "externalTerminal",로 수정

// vscode 인텔리센스 한글로 뜰 때 : https://github.com/OmniSharp/omnisharp-vscode/issues/2513

// 다운캐스팅은 반대로 FightUnit이지만 Player나 Monster의 기능을 쓰는 것을 말함
// 다운캐스팅은 최대한 지양하는 것이 좋음
// 다운캐스팅을 하다 보면 실수로 플레이어를 몬스터로 변경할 수도 있게 됨

// 생성자는 class가 만들어질 때 한 번 실행해주는 함수임 (처음 인스턴스를 만들 때 메모리를 할당하는 함수)
// 특징으로는 리턴값이 없음 (만약 값을 리턴한다고 생각하면 Player NewPlayer = new Player();은 말이 안 됨)
// 무조건 자신의 클래스의 메모리를 리턴해주는 함수여야 함
// public Player() {}
// 만들지 않아도 눈에 보이지 않지만 이 함수는 만들어짐
// 멤버변수나 멤버함수와는 다르게 생성자는 기본적으로 Public임 (물론 이건 생략했을 때이고 만약 적는다면 private으로 적용됨)

// FightUnit이 먼저 만들어지고 Player가 만들어짐
// https://hevton.tistory.com/335

// https://stackoverflow.com/questions/48096247/is-inheritance-means-copy-from-parent-to-child-or-the-child-gain-access-to-the-p
// https://stackoverflow.com/questions/10722110/overriding-member-variables-in-java-variable-hiding
// https://stackoverflow.com/questions/8844649/how-do-i-override-not-hide-a-member-variable-field-in-a-c-sharp-subclass
// https://korbillgates.tistory.com/158
// https://freestrokes.tistory.com/72
// https://durubiz.tistory.com/entry/this%EC%9D%98-3%EA%B0%80%EC%A7%80-%EC%9A%A9%EB%B2%95-%EC%B2%B4%ED%81%AC
// 나중에 읽어볼 것들
// 왜 부모로부터 상속받은 자녀 클래스에서 바로 부모 클래스의 멤버함수나 멤버변수를 쓸 수 없는지 생각해볼 것 (자녀 클래스에서 따로 함수를 만들어서 그 안에서 쓰는 건 됨)
// 멤버함수에는 암묵적으로 this 매개변수가 생략되어있어서 그런가?
// 아니면 인스턴스 생성 전이라서 그런가?
// 일단 안 된다는 것만 알고 넘어가고 다음에 복습할 때 자세하게 알아볼 것
// 그리고 vscode 기본 설정에서 에러 메시지 한글로 뜨면 로케일만 한국어로 하고 나머지 지역이나 형식, 표시 언어 등은 다 영어로 설정할 것
// 뭐든 설치할 때 순서가 중요함

using System.Diagnostics;

namespace TextRPG
{
    class Program
    {
        // 시작
        // 마을로 갈지 싸움터로 갈지 정해주는 함수

        static void Main(string[] args)
        {
            // while (true)
            // {
            //     ConsoleKeyInfo KeyInfo = Console.ReadKey();
            //     Console.WriteLine(KeyInfo.Key);
            // }

            Player NewPlayer = new Player();

            while (true)
            {
                STARTSELECT SelectCheck = GOStartSelect.StartSelect();

                switch (SelectCheck) // NonSelect는 넣을 필요가 없음 (재입력 시켜야 하기 때문)
                {

                    case STARTSELECT.TownSelect:
                        GOTown.Town(NewPlayer);
                        break;
                    case STARTSELECT.BattleSelect:
                        GOBattle.Battle(NewPlayer);
                        GOTown.Town(NewPlayer);
                        break;
                    default:
                        break;
                }
            }

        }

    }
}