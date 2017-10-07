using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDSCSharp.DataStructures.LinkedList
{

    /// <summary>
    /// A linked list collection capable of basic operations like Add, Remove, Enumurate, Find 
    /// but not have all the capabilities like exception handling and etc. that allow the class
    /// to be used in production.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : ICollection<T>
    {
        #region Properties to store refrances for Head and Tail

        /// <summary>
        /// The first node in the list or null if empty (Pointer to Head node).
        /// </summary>
        public LinkedListNode<T> Head { get; private set; }

        /// <summary>
        /// The last node in the list or null if empty (Pointer to Tail node).
        /// </summary>
        public LinkedListNode<T> Tail { get; private set; }
        #endregion


        #region Constructors
        /// <summary>
        /// Parameterless constructor of the LinkedList
        /// </summary>
        public LinkedList()
        {

        }
        #endregion


        #region AddFirst & AddLast operations

        #region Commented 
        //public void AddFirst_V1(LinkedListNode<T> node)
        //{
        //    if (Count == 0)
        //    {
        //        Head = node;
        //        Tail = node;
        //        Count++;
        //    }
        //    else
        //    {
        //        // Pass the Head to temp object
        //        var temp = Head;

        //        Head = node;

        //        Head.Next = temp;

        //        Count++;
        //    }

        //}
        #endregion


        /// <summary>
        /// Adding a node to the start of the list
        /// Complexity O(1) so LinkedList has an efficient insertion
        /// </summary>
        /// <param name="node"></param>
        public void AddFirst(LinkedListNode<T> node)
        {

            // Store the Head Node to temp var so we don't lose it.
            var temp = Head;

            // Point Head to the new node.
            Head = node;

            // Insert the rest of list behind the Head
            Head.Next = temp;

            // Increment the List Counter
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        /// <summary>
        /// Other overloading to make it easy Adding a node to the front of the list by adding a value only.
        /// (That's an Abstraction because: Encapsulation is wrapping, just hiding properties and methods. Encapsulation is used for hide the code and data in a single unit to protect the data from the outside the world. Class is the best example of encapsulation. Abstraction refers to showing only the necessary details to the intended user.).
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }


        /// <summary>
        /// Adding a node to the end of the list.
        /// Complexity O(1) so LinkedList has an efficient insertion
        /// </summary>
        /// <param name="node"></param>
        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;
            Count++;
        }


        /// <summary>
        /// Other overloading to make it easy Adding a node to the end of the list by adding a value only.
        /// (That's an Abstraction because: Encapsulation is wrapping, just hiding properties and methods. Encapsulation is used for hide the code and data in a single unit to protect the data from the outside the world. Class is the best example of encapsulation. Abstraction refers to showing only the necessary details to the intended user.).
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }


        #endregion


        #region RemoveFirst & RemoveLast operations

        /// <summary>
        ///  Removes the first node from the list.
        ///  Complexity O(1) so LinkedList has an efficient Remove from the front.
        /// </summary>
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }


        /// <summary>
        /// Removes the last node from the list.
        /// Complexity O(n) so single LinkedList has an bad performance while removing item from the last.
        /// And that's because it requires enumerating over Count -2 (till the Tail is your next node) of the list with O(n) complexity.
        /// So, The only weakness of removing node from the last when working with linked list is that the operation requires enumeration over the list to reach the second to last node to update it by setting it’s Next to null and made Tail reference it. this enumeration is because we only storing references to the tail and head nodes (Doubly linked list solved this issue)
        /// </summary>
        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;

                }
                else
                {
                    var current = Head;

                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;

                }

                Count--;
            }
        }

        #endregion





        #region ICollection<T> Members Implementation

        /// <summary>
        /// Add the specified item to the front of the list.
        /// </summary>
        /// <param name="item">The value to add</param>
        public void Add(T item)
        {
            AddFirst(item);
        }


        /// <summary>
        /// Removes all the nodes from the list.
        /// </summary>
        public void Clear()
        {
            // The below implementation is all we need in C# but of course for language like C or Cpp 
            // We need to manually delete each node from the memory as there is no garbage collector and manage memory
            // is the developer resposability.
            Tail = null;
            Head = null;
            Count = 0;
        }


        /// <summary>
        /// Returns true if the list contains a specific item.
        /// </summary>
        /// <param name="item">The item to search for.</param>
        /// <returns>True if item is found, false otherwise.</returns>
        public bool Contains(T item)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item)) return true;
                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Copies the linked list nodes values into a specific array.
        /// </summary>
        /// <param name="array">The array to copy the linked liste values to.</param>
        /// <param name="arrayIndex">The array index to start copying at.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            var current = Head;

            while (current.Next != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }


        /// <summary>
        /// Removes the first occurence of item from the list.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            #region Method Implementation Description
            // Cases Here:
            // 1- Empty List: Do Nothing.
            // 2- Single Node: Previous is null.
            // 3- Many Nodes:
            //  a: Node to remove is the first node.
            //  b: Node to remove is in the middle or the last node.
            #endregion

            // Define the needed pointers (Refrances in C#)
            var current = Head;
            LinkedListNode<T> previous = null;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    //Case 3-b
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            // It was the end so update Tail.
                            Tail = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        // Case 2 or 3-a
                        RemoveFirst();
                    }

                    return true;
                }

                // Update our pointers to refrance the correct nodes
                previous = current;
                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Enumurates over the linked list values from Head to Tail.
        /// </summary>
        /// <returns>A Head to Tail Enumurator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// Enumurates over the linked list values from Head to Tail.
        /// </summary>
        /// <returns>A Head to Tail Enumurator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        /// <summary>
        /// The number of items currently in the list.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// True if the collection read only, false otherwise.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        #endregion


    }
}
