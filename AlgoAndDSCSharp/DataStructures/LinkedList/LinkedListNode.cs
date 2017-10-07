using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.DataStructures.LinkedList
{
    /// <summary>
    /// Node Is the most basic building block for many common data structures.
    /// .NET have it's own LinkedListNode<T>  We can use it instead of that LinkedListNode class
    /// </summary>
    /// <typeparam name="T">T allow safely type Node {Value} to create a homogeneous LinkedList</typeparam>
    public class LinkedListNode<T>
    {

        /// <summary>
        /// Constructor to construct a new node with a specific value.
        /// </summary>
        /// <param name="value"></param>
        public LinkedListNode(T value)
        {
            Value = value;
        }


        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }
}
