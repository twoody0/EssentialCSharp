namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = "<<ValidInput>>ValidInput";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main
        );
    }
}