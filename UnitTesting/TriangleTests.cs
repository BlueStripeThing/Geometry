namespace UnitTesting;

public class TriangleTests
{
    //Проверка реальных значений
    [TestCase(4,20,17,24.32976572020372)]
    [TestCase(4,5,6,9.921567416492215)]
    [TestCase(3,4,5,6)]
    public void TrianglePassingTest(double inputA,double inputB,double inputC, double expect)
    {
        Assert.AreEqual(expect, new Triangle(inputA,inputB,inputC).FindArea());
    }
    
    //Проверка ошибочных значений
    [TestCase(4,6,1,0)]
    [TestCase(-4,-5,6,0)]
    [TestCase(-3,-2,-1,0)]
    public void TriangleFailingTest(double inputA,double inputB,double inputC, double expect)
    {
        Assert.AreEqual(expect, new Triangle(inputA,inputB,inputC).FindArea());
    }
}