using System.Dynamic;
using NUnit.Framework.Constraints;

namespace TestProject2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddTest()           
    {
        var calculator = new Calculator();


        var expected = 3;
        Assert.That(calculator.Add(1, 2), Is.EqualTo(expected));
    }

    [Test]
    public void SubstractTest()
    {

        var calculator = new Calculator();
        var expected = 1;
        Assert.That(calculator.Sub(2, 1), Is.EqualTo(expected));

    }
    
    public void Foo(string input)
    {
        var columnIndex = 3;
        
        
    }
}