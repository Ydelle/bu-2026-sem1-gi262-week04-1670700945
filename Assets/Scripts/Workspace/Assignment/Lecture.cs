using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            //LCT02_SyntaxLinkedList();
            //LCT03_SyntaxHashTable();
            LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            

            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            //string[] playerName = new string[10];
            LinkedList<string> linkedlist = new LinkedList<string>();
            //[Node 1]
            linkedlist.AddLast("Node 1");
            //[Node 2]
            linkedlist.AddLast("Node 2");
            //[Node 0]
            linkedlist.AddFirst("Node 0");

            LinkedListNode<string> firstNode = linkedlist.First;
            Debug.Log("first: " + firstNode.Value);

            LinkedListNode<string> lastNode = linkedlist.Last;
            Debug.Log("last: " + lastNode.Value);

            Debug.Log("firstNade.Next: " + firstNode.Next.Value);
            Debug.Log("firstNade.Next.next: " + firstNode.Next.Next.Value);

            Debug.Log("lastNode.Previous: " + lastNode.Previous.Value);
            Debug.Log("lastNode.Previous.Previous: " + lastNode.Previous.Previous.Value);

            if (firstNode.Previous == null) Debug.Log("firstNode.Previous == null");
            if (lastNode.Next == null) Debug.Log("lastNode.Next  == null");

            linkedlist.AddAfter(firstNode, "Node0.5");
            linkedlist.AddAfter(lastNode, " Node 1.5");

            LinkedListNode<string> node1 = linkedlist.Find("Node 1");

            linkedlist.Remove("Node 1");
            linkedlist.Remove(node1);
            linkedlist.RemoveLast();
            linkedlist.RemoveFirst();

            linkedlist.Clear();


        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string,int> inv = new Dictionary<string,int>();
            var inv2 = new Dictionary<string,int>();

            //"Potion": 1 
            inv.Add("Potion", 1);

            //"Potion": 1 
            //"Apple": 10
            inv.Add("Apple", 10);

            //"Potion": 1 
            //"Apple": 10
            //"Banana": 5
            inv["Banana"] = 5;

            //"Potion": 10 
            //"Apple": 10
            //"Banana": 5
            inv["Potion"] = 10;

            var pickupItem = "Sword";
            inv[pickupItem] = 1;

            foreach (KeyValuePair<string,int> pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }

            var appleExists = inv.ContainsKey("Apple");
            Debug.Log(appleExists);

            var keyExists = inv.ContainsKey("key");
            Debug.Log(keyExists);

            inv.Remove("Apple");

            foreach(var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }
        }

        #endregion
    }
}
