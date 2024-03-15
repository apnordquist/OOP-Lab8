using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Node
    {
        //properties
        public string Value { get; set; }
        public Node? Next { get; set; }
        //constructor
        public Node(string value)
        {
            this.Value = value;
        }

    }
}
