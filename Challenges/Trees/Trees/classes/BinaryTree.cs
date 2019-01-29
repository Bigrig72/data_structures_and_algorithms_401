using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.classes
{
    public class BinaryTree
    {
        public Node Top { get; set; }

        public BinaryTree()
        {
            Top = null;
        }
        public BinaryTree(Object value)
        {
            Top = new Node(value);
        }
        /// <summary>
        /// checking to see if the tree is empty, if it is, return a new
        /// Single node. If there is a node, check its value, if its greater go right,
        /// if its less go left.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node Insert(Node node, int data)
        {
            if(node == null)
            {
                var newOne = new Node(data);
                if(Top == null)
                {
                    Top = newOne;
                }
                return newOne;
            }
            else
            {
                if(data <= node.Value)
                {
                    node.Left = Insert(node.Left, data);
                }
                else
                {
                    node.Right = Insert(node.Right, data);
                }
            }
            return node;
        }
        /// <summary>
        /// Pre order traversal(Root-Left-Right)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="valueList"></param>
        public void PreOrder(Node node, List<int> valueList)
        {
            if(node != null)
            {
                valueList.Add(node.Value);
                PreOrder(node.Left, valueList);
                PreOrder(node.Right, valueList);
            }
        }
        /// <summary>
        /// Inorder traversal (left-root-right)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="valueList"></param>
        public void InOrder(Node node, List<int> valueList)
        {
            if (node != null)
            {
                InOrder(node.Left, valueList);
                valueList.Add(node.Value);
                InOrder(node.Right, valueList);
            }
        }
        /// <summary>
        /// Post order(Left-Right-Root)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="valueList"></param>
        public void Postorder(Node node, List<int> valueList)
        {
            if(node != null)
            {
                Postorder(node.Left, valueList);
                Postorder(node.Right, valueList);
                valueList.Add(node.Value);
            }
        }




    }
}
