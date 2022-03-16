using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;

namespace ConsoleAppTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestProcessUserInput()
    {
        Assert.IsNotNull(Program.ProcessProgramInput("blue whale", "left"));
    }

    [TestMethod]
    public void TestValidOutput()
    {
        Assert.AreEqual(Program.ProcessProgramInput("elephant", "left"), "Ahoy, Captain, an elephant of to left!");
    }

    [TestMethod]
    public void TestInvalidOutput()
    {
        Assert.AreNotEqual(Program.ProcessProgramInput("octopus", "left"), "Ahoy, Captain, an elephant of to the left!");
    }

    [TestMethod]
    public void TestThrowsException()
    {
        Assert.ThrowsException<Exception>(() => Program.ProcessProgramInput("", ""));
    }

    [TestMethod]
    public void TestArticle()
    {
        Assert.AreEqual<string>(Article.GetArticle("elephant"), "an");
    }
}