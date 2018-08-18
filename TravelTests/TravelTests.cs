using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTDD.Tests
{  //MALLORY BUSH TRAVEL TDD HOMEWORK
    [TestFixture]

    class TravelTests
    {
        [Test]
        public void Test_Default_CTR()
        {
            var travel = new Travel();

            var result = travel.Fname = "FName";

            Assert.That(result, Is.EqualTo("FName"));
        }

        [Test]
        public void Test_Last_Name()
        {
            var travel = new Travel();

            var result = travel.Lname = "LName";

            Assert.That(result, Is.EqualTo("LName"));
        }

        [Test]
        public void Test_Address()
        {
            var travel = new Travel();

            var result = travel.Lname = "";

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void Test_Email()
        {
            var travel = new Travel();

            var result = travel.Lname = "";

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void Test_GetDate_Method()
        {
            var travel = new Travel();

            var result = travel.GetDate(9, 8, 2018);

            Assert.That(result, Is.EqualTo("9/8/2018"));
        }

        [Test]
        public void Test_TtlTravel_Method()
        {
            var travel = new Travel();

            var result = travel.TtlTravel(5);

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test_GetSelection_Method()
        {
            var travel = new Travel();

            var result = travel.GetSelection(5);

            Assert.That(result, Is.EqualTo("Cali"));
        }

        [Test]
        public void Selection_Method_4_Georgia()
        {
            var travel = new Travel();

            var result = travel.GetSelection(4);

            Assert.That(result, Is.EqualTo("Georgia"));
        }

        [Test]
        public void Selection_Method_3_Florida()
        {
            var travel = new Travel();

            var result = travel.GetSelection(3);

            Assert.That(result, Is.EqualTo("Florida"));
        }

        [Test]
        public void Selection_Method_2_Nashville()
        {
            var travel = new Travel();

            var result = travel.GetSelection(2);

            Assert.That(result, Is.EqualTo("Nashville"));
        }

        [Test]
        public void Selection_Method_1_PutInBay()
        {
            var travel = new Travel();

            var result = travel.GetSelection(1);

            Assert.That(result, Is.EqualTo("Put In Bay"));
        }

        [Test]
        public void Selection_Method_0_GoHome()
        {
            var travel = new Travel();

            var result = travel.GetSelection(0);

            Assert.That(result, Is.EqualTo("Go Home"));
        }

        [Test]
        public void Selection_Method_Greater_Than_5()
        {
            var travel = new Travel();

            var result = travel.GetSelection(6);

            Assert.That(result, Is.EqualTo("The World Is Yours"));
        }

        [Test]
        public void Destination_Selection_Method_Greater_Than_5()
        {
            var travel = new Destination();

            var result = travel.GetSelection(6);

            Assert.That(result, Is.EqualTo("The World Is Yours"));
        }
    }
}