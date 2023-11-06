using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ImplementLinkedList
{
    /// <summary>
    /// Node class contains two properties: value and the next node
    /// </summary>
    public class Node

    {
        private Node _nextNode;
        private int _value;

        /// <summary>
        /// Public Get and Set method for private nextNode property
        /// </summary>
        public Node NextNode
    {
        get => _nextNode;
        set => _nextNode = value;
    }
        /// <summary>
        /// Public Get and Set method for private value property
        /// </summary>
        public int Value
    {
        get => _value;
        set => _value = value;
    }
        /// <summary>
        /// Constructor for creating a new Node object
        /// </summary>
        /// <param name="value"> </param> 
        
        public Node(int value) 
        
        {
            _value = value;
            _nextNode = null;
        }
}
}
