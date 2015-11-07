using System;
using HelloWorld.ModelViews;
using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    public class FirstViewModelTest
    {
        public FirstViewModel firstViewModel;
        private string VALID_NAME = "Valid Name";

        [SetUp]
        public void SetUp()
        {
            firstViewModel = new FirstViewModel();
        }
        
        [Test]
        public void ShouldReturnTrueWhenNameIsNotEmptyOrNull()
        {
            firstViewModel.Name = VALID_NAME;
            Assert.IsTrue(firstViewModel.CanSayHello);
        }

        [Test]
        public void ShouldReturnFalseWhenNameIsEmptyString()
        {
            firstViewModel.Name = "";
            Assert.IsFalse(firstViewModel.CanSayHello);
        }

        [Test]
        public void ShouldReturnFalseWhenNameIsNull()
        {
            firstViewModel.Name = null;
            Assert.IsFalse(firstViewModel.CanSayHello);
        }
    }
}
