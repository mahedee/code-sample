using OCP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for RectangleTest and is intended
    ///to contain all RectangleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RectangleTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Rectangle Constructor
        ///</summary>
        [TestMethod()]
        public void RectangleConstructorTest()
        {
            double height = 0F; // TODO: Initialize to an appropriate value
            double width = 0F; // TODO: Initialize to an appropriate value
            Rectangle target = new Rectangle(height, width);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CalculateArea
        ///</summary>
        [TestMethod()]
        public void CalculateAreaTest()
        {
            double height = 10F; // TODO: Initialize to an appropriate value
            double width = 10F; // TODO: Initialize to an appropriate value
            Rectangle target = new Rectangle(height, width); // TODO: Initialize to an appropriate value
            double expected = 100F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.CalculateArea();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Height
        ///</summary>
        [TestMethod()]
        public void HeightTest()
        {
            double height = 0F; // TODO: Initialize to an appropriate value
            double width = 0F; // TODO: Initialize to an appropriate value
            Rectangle target = new Rectangle(height, width); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.Height = expected;
            actual = target.Height;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Width
        ///</summary>
        [TestMethod()]
        public void WidthTest()
        {
            double height = 0F; // TODO: Initialize to an appropriate value
            double width = 0F; // TODO: Initialize to an appropriate value
            Rectangle target = new Rectangle(height, width); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            target.Width = expected;
            actual = target.Width;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Rectangle Constructor
        ///</summary>
        [TestMethod()]
        public void RectangleConstructorTest1()
        {
            double height = 0F; // TODO: Initialize to an appropriate value
            double width = 0F; // TODO: Initialize to an appropriate value
            Rectangle target = new Rectangle(height, width);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CalculateArea
        ///</summary>
        [TestMethod()]
        public void CalculateAreaTest1()
        {
            double height = 0F; // TODO: Initialize to an appropriate value
            double width = 0F; // TODO: Initialize to an appropriate value
            Rectangle target = new Rectangle(height, width); // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.CalculateArea();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
