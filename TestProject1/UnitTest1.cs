
using Calculate;
using Moq;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Xml.Linq;

namespace TestProject1
{
    public class Tests
    {
        //MethodName_WhatYouPass_WhatShouldReturn

        [Test]
        public void Add_Validinputs_ShouldReturnCorrectAnswer()
        {
            //arrange
            Maths math = new Maths();
            int a = 3;
            int b = 4;
            int expected = 7;


            //act

            long actual = math.Add(a, b);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Add_Valid2inputs_ShouldReturnCorrectAnswer()
        {
            //arrange
            Maths maths = new Maths();
            int a = int.MaxValue;
            int b = int.MinValue;
            long expected = (long)a + (long)b;

            //act
            long actual = maths.Add2(a, b);
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(10, 20, 30)]
        [TestCase(200, 300, 500)]
        [TestCase(356, 4, 360)]
        public void Add_Valid3Inputs_ShouldReturnCorrectAnswer(int a, int b, int expected)
        {
            Maths maths = new Maths();

            long actual = maths.Add3(a, b); ;

            Assert.AreEqual(expected, actual);


        }

        [TestCase(5, 2, 2.5)]
        [TestCase(50, 5, 10)]
        public void Divide_ValidInputs_ShouldReturnCorrectAnswer(double a, double b, double expected)
        {
            Maths maths = new Maths();

            double actual = maths.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("Welcome","World","Welcome World")]
      
        public void ConcateString_ValidInputs_ShouldReturnCorrectAnswer(string a, string b, string expected)
        {
            Maths maths = new Maths();

            string actual = maths.Concate(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase('H', 'I', 145)]

        public void ConcateValue_ValidInputs_ShouldReturnCorrectAnswer(char a, char b, int expected)
        {
            Maths maths = new Maths();

            int actual = maths.ConcateValue(a, b);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test()
        {
                    
            UserManager manager = new UserManager(new DatabaseService());
            UserModel model = new UserModel()
            {

                Email = "jhbsshkjklj@gmail.com",
                Id = 123,
                Location = "Gujrat",
                Name = "UserNew",

            };

            bool actual = manager.AddNewUser(model);

            Assert.IsTrue(actual);
        }

        [Test]
        public void Test2()
        {

            UserManager manager = new UserManager(new DatabaseService());
            UserModel model = new UserModel()
            {

                Email = "zchaakakcakcla",
                Id = 1,
                Location = "Noida",
                Name = "Nagesh",

            };

            bool actual = manager.AddNewUser(model);

            Assert.IsTrue(actual);
        }

        [Test]
        public void CorrectTest()
        {
            Mock<IDatabaseService> db = new Mock<IDatabaseService>();

            db.Setup(x => x.AddUser(It.IsAny<UserModel>())).Returns(true);

            UserManager manager = new UserManager(new DatabaseService());
            UserModel model = new UserModel()
            {

                Email = "kdjshvzlj@gmail.com",
                Id = 654,
                Location = "Pune",
                Name = "TestUserNew",

            };

            bool actual = manager.AddNewUser(model);

            Assert.IsTrue(actual);
        }


        [Test]
        public void CorrectTest2()
        {
            Mock<IDatabaseService> db = new Mock<IDatabaseService>();

            db.Setup(x => x.AddUser(It.IsAny<UserModel>())).Returns(true);

            UserManager manager = new UserManager(new DatabaseService());
            UserModel model = new UserModel()
            {

                Email = "venky@gmail.com",
                Id = 6987,
                Location = "Mumbai",
                Name = "Venky",

            };

            bool actual = manager.AddNewUser(model);

            Assert.IsTrue(actual);
        }
    }

}
