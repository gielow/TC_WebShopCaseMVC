using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TC_WebShopCaseMVC.Entities;
using System.IO;

namespace TC_WebShopCaseMVC.Tests
{
    /// <summary>
    /// Summary description for SerializationTest
    /// </summary>
    [TestClass]
    public class SerializationTest
    {
        private const string articlePath = @"E:\VSWorkspace\TC_WebShopCaseMVC\TC_WebShopCaseMVC\App_Data\articles.xml";
        public SerializationTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Serialize()
        {
            var articles = new List<Article>();

            for (int i = 1; i <= 50; i++)
            {
                articles.Add(new Article()
                {
                    Address = "Primavera st",
                    City = "Blumenau",
                    Email = "andre.gielow@gmail.com",
                    FirstName = "André " + i.ToString("0#"),
                    LastName = "Gielow",
                    HouseNumber = 291,
                    ZipCode = "89057-036",
                    Title = "Mr."
                });
            }
            
            Serializer.SerializeObject<List<Article>>(articles, articlePath);
            Assert.IsTrue(File.Exists(articlePath));
        }

        [TestMethod]
        public void Deserialize()
        {
            var articles = Serializer.DeSerializeObject<List<Article>>(articlePath);

            Assert.AreEqual(1, articles.Count);
        }
    }
}
