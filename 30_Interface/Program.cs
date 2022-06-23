// See https://aka.ms/new-console-template for more information

// 인터페이스는 사용자 정의 자료형임
// 인터페이스는 필드를 포함할 수 없음
interface QuestUnit
{
    //함수의 형태만 물려줄 수 있는 문법임
    public void Talk(QuestUnit _OtherUnit);

    public void Event(QuestUnit _OtherUnit);
}

class FightUnit
{
    int AT;
    int DMG;
    public void Damage()
    {

    }
}

// 인터페이스는 함수구현을 강제할 수 있음
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
    void Talk()
    {

    }
}

class NPC : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
    void Talk()
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();

        // QuestUnit QuestUnit = new QuestUnit(); 이런 건 안 됨
        QuestUnit NewQuestUnit = NewNPC; // 이렇게 받는 것만 됨
        NewQuestUnit.Talk()

        // 업캐스팅이 됨
        NewPlayer.Talk(NewNPC);
    }
}