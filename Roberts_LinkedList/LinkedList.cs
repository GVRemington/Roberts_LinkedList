using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_LinkedList
{
     class LinkedList
    {
        Node? _head = null;
       
      
        public void Add (string name)
        {
           Node NewNode = new Node (name);
            if (_head == null)
            {
                _head = NewNode;
                return;
            }
            else
            {
                Node previous = null;
                Node current = _head;
                while ((current != null) && (string.Compare(name,current.Data) > 0))
                {
                    previous = current;
                    current = current.Next;
                }
                if(previous == null)
                {
                    NewNode.Next = current;
                    _head = NewNode;
                }
                else
                {
                    NewNode.Next = current;
                    previous.Next = NewNode;
                }
            }
           
         

        }
        public void Remove(string name)
        {
            if(_head == null)
            { return; }

            Node current = _head;

            if (current.Data == name)
            {
                current = current.Next;  
            }
            else
            {
                while (current.Next != null)
                {
                    if(current.Next.Data == name)
                    {
                        current.Next = current.Next.Next;
                        return;
                    }
                    current = current.Next;
                }
            }
        }
        public bool Contains(string name)
        {
            if(name == null) return false;

            Node current = _head;
            
            if(current.Data == name)
                return true;
            else
            {
                while(current.Next != null)
                {
                    if(current.Next.Data == name)
                    { return true;}
                    else
                        { return false; }
                }

            }
           return false;
        }

       
        public string Print()
        {
            Node _current = _head;
            string list = string.Empty;
            while (_current != null)
            {
                list = list + "\n" + _current.Data;
                _current = _current.Next;
            }

            return list;

        }
       
    }
}

