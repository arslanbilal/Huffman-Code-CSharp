using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCodeWithCSharp
{
    class HuffmanNode : IComparable<HuffmanNode>
    {
        public string symbol;   // For the character of char value. Public because Process class use it.
        public int frequency;          // Number of the count on file, string, text.
        public string code;            // Getting from a tree for making a huffman tree.
        public HuffmanNode parentNode; // Parent Node of current Node.
        public HuffmanNode leftTree;   // Left Node of current Node.
        public HuffmanNode rightTree;  // Right Node of current Node.
        public bool isLeaf;            // Shows it is a leaf.


        public HuffmanNode(string value)    // Creating a Node with given value(character).
        {
            symbol = value;     // Setting the symbol.
            frequency = 1;      // This is creation of Node, so now its count is 1.
            
            rightTree = leftTree = parentNode = null;       // Does not have a left or right tree and a parent.

            code = "";          // It will be Assigned on the making Tree. Now it is empty.
            isLeaf = true;      // Because all Node we create first does not have a parent Node.
        }


        public HuffmanNode(HuffmanNode node1, HuffmanNode node2) // Join the 2 Node to make Node.
        {
            // Firsly we are adding this 2 Nodes' variables. Except the new Node's left and right tree.
            code = "";
            isLeaf = false;
            parentNode = null;

            // Now the new Node need leaf. They are node1 and node2. if node1's frequency is bigger than or equal to node2's frequency. It is right tree. Otherwise left tree. The controllers are below:
            if (node1.frequency >= node2.frequency)
            {
                rightTree = node1;
                leftTree = node2;
                rightTree.parentNode = leftTree.parentNode = this;     // "this" means the new Node!
                symbol = node1.symbol + node2.symbol;
                frequency = node1.frequency + node2.frequency;
            }
            else if (node1.frequency < node2.frequency)
            {
                rightTree = node2;
                leftTree = node1;
                leftTree.parentNode = rightTree.parentNode = this;     // "this" means the new Node!
                symbol = node2.symbol + node1.symbol;
                frequency = node2.frequency + node1.frequency;
            }
        }


        public int CompareTo(HuffmanNode otherNode) // We just override the CompareTo method. Because when we compare two Node, it must be according to frequencies of the Nodes.
        {
            return this.frequency.CompareTo(otherNode.frequency);
        }


        public void frequencyIncrease()             // When facing a same value on the Node list, it is increasing the frequency of the Node.
        {
            frequency++;
        }
    }
}
