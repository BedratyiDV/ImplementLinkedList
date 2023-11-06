namespace ImplementLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            ListOfNodes listOfNodes1 = new ListOfNodes();

            listOfNodes1.AddNewNode(node1);
            listOfNodes1.AddNewNode(node2);
            listOfNodes1.AddNewNode(node3);
            listOfNodes1.AddNewNode(node4);
            listOfNodes1.AddNewNode(node5);

            listOfNodes1.PrintAllNodesValues();

            listOfNodes1.RemoveNode(node1);
            listOfNodes1.PrintAllNodesValues();

            listOfNodes1.RemoveNode(node3);
            listOfNodes1.PrintAllNodesValues();


        }
    }
}