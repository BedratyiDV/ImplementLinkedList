using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementLinkedList
{
    /// <summary>
    /// ListOfNodes class keeps the set of nodes in the private node list
    /// </summary>
    public class ListOfNodes

    {
        private List<Node> _nodes = new List<Node>();

        /// <summary>
        /// Method adds a new node to the end of list
        /// </summary>
        /// <param name="newNode"> </param> 
        public void AddNewNode(Node newNode) 
        
        {
            if (newNode is not null)

            {
                if (_nodes.Count == 0)
                {
                    _nodes.Add(newNode);
                    newNode.NextNode = null;
                    Console.WriteLine($"The node with value {newNode.Value} has been added to the list");
                }
                else

                {
                    newNode.NextNode = null;
                    _nodes.Last().NextNode = newNode;
                    _nodes.Add(newNode);
                    Console.WriteLine($"The node with value {newNode.Value} has been added to the list");

                }
            }
            else

            {
                Console.WriteLine("The Node you are trying to add is null");
            }
            }
        /// <summary>
        /// Method removes a node by value
        /// </summary>
        /// <param name="removedNode"> </param> 
        public void RemoveNode(Node removedNode)

        {
            if (removedNode is not null)
            {
                if (_nodes.Count == 0)

                {
                    Console.WriteLine("The list is empty: nothing to remove");
                    return;
                }
                if (_nodes.First().Value.Equals(removedNode.Value))

                {
                    Console.WriteLine($"The node with value {removedNode.Value} is the first in the list. It was Removed.");
                    _nodes.Remove(_nodes.First());
                    return;
                }
                else 
                {
                    Node currentNode = _nodes.First();

                    while (currentNode.NextNode != null)
                    {
                        if (currentNode.NextNode.Value.Equals(removedNode.Value))

                        {
                            currentNode.NextNode = currentNode.NextNode.NextNode;
                            _nodes.Remove(currentNode.NextNode);
                            Console.WriteLine($"The node with value {removedNode.Value} was removed");
                            return;
                        }
                        currentNode = currentNode.NextNode;
                    }
                }
                
            }
            else

            {
                Console.WriteLine("The node for remove is null!");
                return;
            }
        }
        /// <summary>
        /// Method prints into console the values of all nodes from the list
        /// </summary>
        public void PrintAllNodesValues() 
        
        {
            Node currentNode = _nodes.First();
            Console.WriteLine("All the values in the node list:");
            
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " -> ");
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine("null");
        }
    }
        }
    


