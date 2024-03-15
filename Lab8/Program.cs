namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new list
            LinkedList MyList = new LinkedList();
            //populate list
            string[] FillList = { "Joe Blow", "Joe Schmoe", "John Smith", "Jane Doe", "Bob Bobberson", "Sam Sammerson", "Dave Daverson" };
            foreach (string name in FillList)
            {
                MyList.AddLast(name);
            }
            //print list
            MyList.PrintList();
        }
    }
}
