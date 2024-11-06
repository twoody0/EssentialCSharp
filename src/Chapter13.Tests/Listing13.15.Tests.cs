
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expectedOutput = "ValidInput";
        string simulatedInput = "\n   \nValidInput\n";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expectedOutput,
            () =>
            {
                using (StringReader simulatedReader = new (simulatedInput))
                {
                    Console.SetIn(simulatedReader);
                    Program.Main();
                }
            });
    }
}