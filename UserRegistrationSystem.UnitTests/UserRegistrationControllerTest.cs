using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationSystem.UnitTests
{
    [TestFixture]
    public class UserRegistrationControllerTest
    {
        private UserRegistrationController _classUnderTest;
        private Mock<IReadCommand<IUser, String>> mockFileReadRegisteredUser;
        private Mock<IWriteCommand<IUser>> mockFileWriteRegisteredUser;
        private Mock<IInstance<User, IUser>> mockUserFactory;

        [SetUp]
        public void SetUp()
        {
            mockFileReadRegisteredUser = new Mock<IReadCommand<IUser, String>>();
            mockFileWriteRegisteredUser = new Mock<IWriteCommand<IUser>>();
            mockUserFactory = new Mock<IInstance<User, IUser>>();
            _classUnderTest = new UserRegistrationController(mockFileReadRegisteredUser.Object, mockFileWriteRegisteredUser.Object, mockUserFactory.Object);
        }

        [Test]
        public void TestMethodRegisterNewUserThatItThrowsAnUserRegistrationExceptionWhenUsernameIsAlreadyTaken()
        {
            //arrange
            IUser _userFound = new User();
            mockFileReadRegisteredUser.Setup(reader => reader.ReadItem("defaultUsername")).Returns(_userFound);

            //act & assert
            Assert.Throws<UserRegistrationException>(() => _classUnderTest.RegisterNewUser("defaultUsername", "defaultPassword", Role.USER));
        }

        [Test]
        public void TestMethodRegisterNewUserThatItRegisterNewUserWhenTheInputHasNotBeenAlreadyTaken()
        {
            //arrange
            mockFileReadRegisteredUser.Setup(reader => reader.ReadItem("Username1")).Returns((IUser)null);
            IUser createdUser = new User();
            mockUserFactory.Setup(userFactory => userFactory.Create()).Returns(createdUser);

            //act
            _classUnderTest.RegisterNewUser("Username1", "Password1", Role.USER);

            //assert
            mockUserFactory.Verify(userFactory => userFactory.Create(), Times.Once);
        }
    }
}
