namespace UnitTesting;

public class CircleTests
{
    //Проверка реальных значений
    [TestCase(1,3.141592653589793)]
    [TestCase(0.5,0.7853981633974483)]
    public void CirclePassingTest(double input, double expect)
    {
        Assert.AreEqual(expect, new Circle(input).FindArea());
    }
    
    //Проверка ошибочных значений
    [TestCase(-10,0)]
    [TestCase(0,0)]
    public void CircleFailingTest(double input, double expect)
    {
        Assert.AreEqual(expect, new Circle(input).FindArea());

    }
}