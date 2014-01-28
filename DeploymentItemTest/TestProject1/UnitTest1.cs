using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        //Copy sourceDir contest to destinationDir
        [DeploymentItem("sourceDir", "destinationDir")]
        public void TestMethod1()
        {
            string basePath = Path.Combine(TestContext.TestRunDirectory, "Out");
            string fullPath = basePath + @"\destinationDir\baseText.txt";
        }
    }
}
