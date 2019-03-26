using System;
using System.IO;
using DfindTest.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DfindTest.UnitTests
{
    [TestClass]
    public class ProblemC_Test
    {
        [TestMethod]
        public void SelectHeir_Test()
        {
              string inputFilesFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\\ProblemC_InputFiles";

              Assert.AreEqual("elena", ProblemC.SelectHeir(inputFilesFolder + "\\InputFile1.txt"));
              Assert.AreEqual("matthew", ProblemC.SelectHeir(inputFilesFolder + "\\InputFile2.txt"));
        }
    }
}
