namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void FalseIsFalseAndStringIsEmpty()
    {
        // This was stupid
        Assert.False(false);
        Assert.True(!false);
        Assert.Empty("");
    }
}
