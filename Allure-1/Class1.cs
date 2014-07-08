using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllureCSharpCommons.AllureModel;
using NUnit.Framework;

namespace Allure_1
{
    
    public class Class1
    {
        //[all]
        //public File File()
        //{

        //}


        [Test]
        public void Do1()
        {
            Assert.AreEqual("10", "10");
        }
        [Test]
        public void Do2()
        {
            Assert.AreEqual("5", "6");
        }
        [Test]
        public void Do3()
        {
            Assert.AreEqual("7", "7");
        }
    }
}
