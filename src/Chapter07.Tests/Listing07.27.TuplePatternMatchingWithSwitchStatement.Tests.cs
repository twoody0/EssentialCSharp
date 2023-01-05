using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_27.Tests;

[TestClass]
public class ProgramTests
{
    string DataFile = "data.dat";
    const string EncryptedFileName = "temp.out";

    [TestMethod]
    public async Task Main_EncryptFileUsingSwitchStatement_Success()
    {
        await InvokeMainWithEncriptAction(
            Program.Main);
    }


    private async Task InvokeMainWithEncriptAction(Action<string[]> action)
    {
        const string data = "DATA";
        await File.WriteAllTextAsync(DataFile, data);
        string expected = $"ENCRYPTED <{data}> ENCRYPTED";

        
        action(new string[] { "Encrypt", EncryptedFileName });

        string actual = await File.ReadAllTextAsync(EncryptedFileName);
        Assert.AreEqual<string>(expected, actual);
    }

    [TestMethod]
    public async Task Main_ShowFileWithSwitchStatement_Success()
    {
        await InvokeMainWithShowFile(Program.Main);
    }

    private async Task InvokeMainWithShowFile(Action<string[]> action)
    {
        const string data = "DATA";
        await File.WriteAllTextAsync(DataFile, data);

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            data,
            () => action(new string[] { "show" }));
    }
}