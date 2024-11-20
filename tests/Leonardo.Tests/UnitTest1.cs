namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var results = await Fibonacci.RunAsync(new string[] { "4" });
        Assert.Equal(3, results[0].Result);
        
    }
}