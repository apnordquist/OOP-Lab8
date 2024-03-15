using Lab8;
using NUnit.Framework.Internal;
namespace Lab8Testing
{
    public class Tests
    {
        private LinkedList TestList;
        [SetUp]
        public void Setup()
        {
            //create new instance of the list
            TestList = new LinkedList();
            //populate the list
            string[] FillList = { "Joe Blow", "Joe Schmoe", "John Smith", "Jane Doe", "Bob Bobberson", "Sam Sammerson", "Dave Daverson" };
            foreach (string name in FillList)
            {
                TestList.AddLast(name);
            }
        }

        [Test]
        public void AddFirstTest()
        {
            TestList.AddFirst("Dawn John");
            string TestValue = TestList.GetValue(1);
            Assert.AreEqual("Dawn John", TestValue);
        }
        [Test]
        public void AddLastTest()
        {
            TestList.AddLast("John Doe");
            string TestValue = TestList.GetValue(TestList.Count);
            Assert.AreEqual("John Doe", TestValue);
        }
        [Test]
        public void RemoveFirstTest()
        {
            TestList.RemoveFirst();
            string TestValue = TestList.GetValue(1);
            Assert.AreEqual("Joe Schmoe", TestValue);
        }
        [Test]
        public void RemoveLastTest()
        {
            TestList.RemoveLast();
            string TestValue = TestList.GetValue(TestList.Count);
            Assert.AreEqual("Sam Sammerson", TestValue);
        }
        [Test]
        public void RetrieveValueTest()
        {
            string TestValue = TestList.GetValue(3);
            Assert.AreEqual("John Smith", TestValue);
        }
        [Test]
        public void LengthTest()
        {
            int Length = TestList.Count;
            Assert.AreEqual(Length, 7);
        }

    }
}