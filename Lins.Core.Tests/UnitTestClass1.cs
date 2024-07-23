namespace Lins.Core.Tests;

[TestClass]
public class MoneyTest
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();
        Assert.AreEqual(27998, cents);
        
    }
}