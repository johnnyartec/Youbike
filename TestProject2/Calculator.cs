using System.Security.Cryptography.X509Certificates;

namespace TestProject2;

public class Calculator
{
    public int Add(int i, int i1) => i + i1;

    public int Sub(int i, int i1) => i - i1;
    
    void showJson()
    {
        var foo = new {x1=123, x2="23"};
    }  
}