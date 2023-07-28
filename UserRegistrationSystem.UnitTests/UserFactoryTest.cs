using NUnit.Framework;

namespace UserRegistrationSystem.UnitTests
{
    [TestFixture]
    public class UserFactoryTest
    {
        private UserFactoryTest? _classUnderTest;

        [Test]
        public void TestMethodUserFactoryReturnsUserIntstancesWhenCalled()
        {
            //arrange
            var _classUnderTest = new UserFactory();

            //act
            var instanceCreatedByFactory = _classUnderTest.Create();

            //assert
            Assert.IsInstanceOf<User>(instanceCreatedByFactory);

        }
    }
}