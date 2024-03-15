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
            TestList.AddFirst("Dawn John"); //add new entry
            string TestValue = TestList.GetValue(1);//return entry in the first position
            Assert.AreEqual("Dawn John", TestValue);
        }
        [Test]
        public void AddLastTest()
        {
            TestList.AddLast("John Doe"); //add new entry
            string TestValue = TestList.GetValue(TestList.Count); //return entry in the last position
            Assert.AreEqual("John Doe", TestValue);
        }
        [Test]
        public void RemoveFirstTest()
        {
            TestList.RemoveFirst(); //remove entry
            string TestValue = TestList.GetValue(1); //return entry in the first position
            Assert.AreEqual("Joe Schmoe", TestValue);
        }
        [Test]
        public void RemoveLastTest()
        {
            TestList.RemoveLast(); //remove entry
            string TestValue = TestList.GetValue(TestList.Count); //return entry in the last position
            Assert.AreEqual("Sam Sammerson", TestValue);
        }
        [Test]
        public void RetrieveValueTest()
        {
            string TestValue = TestList.GetValue(3); //get entry at position 3
            Assert.AreEqual("John Smith", TestValue);
        }
        [Test]
        public void LengthTest()
        {
            int Length = TestList.Count; //check counter vs number of entries
            Assert.AreEqual(Length, 7);
        }

    }
}