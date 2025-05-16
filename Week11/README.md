# 클래스 심화

```c#
public Dog(string name, COLOR color, int year)
    //: base() //기본 base()생성자
    : base(name, color)
{
    _year = year;
}
```
```:base``` 부모 클래스(Aniaml)의 생성자를 호출한다. 부모 클래스의 생성자 중 두 개의 인자를 받는 생성자를 호출한다.<br>
```Animal(string name, COLOR color)``` 생성자 필요. ```name, color```는 부모 클래스에 넘기고 ```year```는 자신이 직접 처리한다.<br>
```c#
public Cat(string name, COLOR color) : base(name, color)
{
}
```
```:base```를 통해 부모 클래스에 보내기만 하여도 C#의 생성자는 메서드처럼 동작하기 때문에 바디(```{}```)가 항상 필요하다.
```c#
//오버라이딩(재정의): 대상-메소드
public override void Eat() { AddLevel(30); }

//하이딩(숨기기): 대상-변수, 프로퍼티, 메소드
public new void Play() { AddLevel(20); }

// 부모 클래스 Animal
public virtual void Play()
{
    AddLevel(2);
}
// 추상 클래스일 경우
public abstract void Play(); // 구현은 자식 클래스에서만
```
```override```는 상속받은 부모 메서드를 재정의한다. ```new```는 부모 메서드를 숨기고 새롭게 정의한다. <br>
```override```는 다형성을 지원하고 ```new```는 다형성을 지원하지 않으며 부모 타입으로 부르면 부모 메서드를 실행한다. <br>
```override```는 타입이 부모일 때 자식의 ```override``` 메서드를 실행하고 ```new```는 부모의 원래 메서드를 실행한다. <br> <br>
```override```를 사용하기 위해서는 부모 클래스에서 ```virtual```을 붙여서 이 메서드를 자식이 재정의해도 된다, 허용해야 한다. <br>
```abstract```같은 추상 멤버라면 반드시 자식이 ```override```로 구현해야 한다.
일반적으로 ```override```를 선호하고 ```new```는 특별한 이유가 있을 때만 사용한다. <br> ( 부모 메서드는 그대로 두고, 자식에서 완전히 다른 방식을 구현하고 싶을 때 ) <br>
## 인터페이스
```c#
interface IRobot
{
  int BatteryLevel { get; set; }
  void Charge();
}
```
인터페이스의 구성요소는 모두 public이다. 접근제한자는 사용하지 않는다. <br>
```int BatteryLevel {get; set;}```은 자동구현 프로퍼티가 아니라, 인터페이스를 상속 받은 하위 클래스에서 구현해야할 프로퍼티를 의미한다.<br>
마찬가지로 ```void Charge();```또한, 하위 클래스에서 반드시 구현해야 한다.


