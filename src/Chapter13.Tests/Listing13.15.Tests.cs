
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expectedInput = "Hello, World!";
        const string expectedOutput = "Hello, World!";

        StringReader reader = new (expectedInput);
        StringWriter writer = new ();
        try
        {
            Console.SetIn(reader);
            Console.SetOut(writer);
            Program.Main();

            string actualOutput = writer.ToString().Trim();
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        finally
        {
            reader.Dispose();
            writer.Dispose();
        }
    }
}