// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 10강에서 13강 내용은 모두 여기에 담았음
// 코딩보다는 이론적인 내용 중심임

// 어떤 프로그램을 실행하면 메모리를 차지하는 프로그램 영역은 4가지로 나눌 수 있음
// Code (수정이 불가능함) : 상수, 클래스 내부의 내용, 함수의 내용
// Data : static member variable
// Heap : new 키워드로 생성된 클래스 인스턴스가 저장되는 영역 (본체)
// Stack : 함수가 실행될 때 할당되는 메모리 영역 (매개변수, 지역변수 등을 저장하고 호출이 끝나면 스택에서 제거됨)
// C#에서 메인 함수는 해당 부분을 시작이라고 잡은 함수임
// 클래스가 객체화되어 인스턴스가 되면 레퍼런스 자료형이 됨
// int bool 같은 자료형은 값 자료형임
// 값 자료형과 레퍼런스 자료형은 메모리의 위치와 사용법이 다름
// Player NewPlayer = new Player(); 에서 Player NewPlayer까지는 stack에 저장 (주소값의 크기만큼)
// 뒤의 new Player은 heap에 저장됨 (실제 클래스의 크기)
// C에서 포인터 개념과 매우 유사한 듯 

// public static int PlayerCount = 0;
// 일반적인 멤버변수와는 다르게 static이 추가로 붙음
// 이런 경우 정적 멤버변수라고 하는데, 일반적인 멤버변수와는 다르게 객체화를 하지 않고도 사용 가능함
// 클래스의 이름만으로 사용 가능함
// Player NewPlayer1 = new Player();
// Player.PlayerCount = 1;
// Plyaer NewPlayer2 = new Player();
// Player.PlayerCount = 2;
// 이런 정적 멤버변수는 데이터 영역에 들어가게 됨
// NewPlayer1.PlayerCount 이런 식으로 객체들을 통해서 정적 멤버변수를 사용할 수는 없음
// 또한 클래스 내부 안에서는 사용 가능함
// 정말 요약해서 공통된 (공유하는) 멤버변수라고 생각하면 됨
// 정적 멤버변수는 객체의 개수만큼 만들어지는 것이 아님
