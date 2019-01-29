using System.Collections.Generic;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        public Node Top { get; set; }

        public BinarySearchTree()
        {
            Top = null;
        }
        public BinarySearchTree(int value)
        {
            Top = new Node(value);
        }


        public void Add(int value)
        {
            if(Top == null)// The tree is empty
            {
                Node NewNode = new Node(value);
                Top = NewNode;
                return;
            }
            Node CurrentNode = Top;
            bool added = false;
            do
            {
                // Tells us to go left
                if (value.CompareTo(CurrentNode.Value) < 0)
                {
                    //Value is less than the current node.value
                    // If there is nothing there go ahead and make a node
                    if (CurrentNode.Left == null)
                    {
                        Node NewNode = new Node(value);
                        CurrentNode.Left = NewNode;
                        added = true;
                    }
                    // Move the current node to the left
                    else
                    {
                        CurrentNode = CurrentNode.Left;
                    }
                }

            if(value.CompareTo(CurrentNode.Value) >= 0)
                {
                    // Value is greater than or equal to current node.value
                    if(CurrentNode.Right == null)
                    {
                        Node NewNode = new Node(value);
                        CurrentNode.Right = NewNode;
                        added = true;
                    }
                    else
                    {
                        CurrentNode = CurrentNode.Right;
                    }
                }

            } while (!added);

        }

        //private void AddR(Node n, object value)
        //{
        //    if (n == null)
        //    {
        //        Node newnode = new Node(value);
        //        n = newnode;
        //        return;
        //    }
        //    if (value.CompareTo(n.Value) < 0)
        //    {
        //        AddR(n.Left, value);
        //        return;
        //    }
        //    if(value.CompareTo(n.Value) >= 0)
        //    {
        //        AddR(n.Right, value);
        //        return;
        //    }
        //}
        /// <summary>
        /// Utilizing a queue to to traverse and form a list of nodes.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="valueList"></param>
        public void Traverse(Node node, List<object> valueList)
        {
            var NewQueue = new Queue<Node>();
            NewQueue.Enqueue(node);
            while (NewQueue.Count > 0)
            {
                var current = NewQueue.Dequeue();
                if(current == null)
                {
                    continue;
                }
                NewQueue.Enqueue(current.Left);
                NewQueue.Enqueue(current.Right);
                valueList.Add(current.Value);
            }
        }
        /// <summary>
        /// recursive way to find if the value is contained in the tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool Contains(Node root, int value)
        {
            if(root == null)return false;            
            if(root.Value == value) return true;
            if(root.Value > value) return Contains(root.Left, value);
            return Contains(root.Right, value);           
            
        }
      
    }
}
