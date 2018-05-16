using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hackathon004;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon004.Tests
{
    [TestClass()]
    public class FunctionTests
    {
        [TestMethod()]
        public void PalindromeTest()
        {
            string abcba = "abcba";
            Function a = new Function();
            Assert.AreEqual(true, a.Palindrome(abcba));
        }
    }
}

namespace 回文測試Tests
{
    class FunctionTests
    {
    }
}
