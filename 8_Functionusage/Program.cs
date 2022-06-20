// See https://aka.ms/new-console-template for more information

// CLass에서 접근제한 지정자를 입력하지 않으면 디폴트로 private임
// 일반적으로 클래스의 속성들은 외부에서 접근하지 못하는 게 좋기 때문에 private이 디폴트임


class Player
{
    private int LV = 1;
    private int AT = 10;
    private int HP = 100;
    public int GetLV()
    {
        // return을 하는 순간 함수가 끝나고 return 아래의 코드는 의미가 없음
        return LV;

    }

    public void LVUP()
    {
        AT = 100;
        HP = 1000;
    }
    public void SetHP(int _HP)
    {
        // 조건문과 결합하면 내가 HP가 0이 되는 순간만 체크 가능
        // 내가 100이 되는 순간만도 체크 가능
        // 디버깅 가능
        HP = _HP;
    }

    // 함수는 보통 클래스 외부와의 소통을 위해서 만듦
    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }

}


namespace Functionusage
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.LVUP();
            NewPlayer.SetHP(2000);
            NewPlayer.Damage1(10);
            NewPlayer.Damage1(20);
            NewPlayer.Damage2(10, 20);
            // 위와 같이 외부의 값을 받아서 객체 내부의 상태를 변화시키기 위해 함수를 선언하는 경우가 많음

            Console.WriteLine(NewPlayer.GetLV());

        }

    }




}