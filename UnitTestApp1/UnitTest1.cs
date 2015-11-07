using System;
using HelloWorld.Views;
using HelloWorld.ModelViews;
using NUnit.Framework;

namespace UnitTestApp1
{
    [TestFixture]
    public class UnitTest1
    {
        private FirstViewModel _firstViewModel;
//        [SetUp]
//        public void SetUp()
//        {
//            _firstViewModel = new FirstViewModel();
//        }

        [Test]
        public void TestMethod1()
        {
//            _firstViewModel.Name = null;
            Assert.AreEqual(1, 2);
        }
    }
}
