using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class nodeList
    {
        public int data;
        public nodeList next;
    }
    class List
    {
        public List() {
            head = tail = null;   
        }
        public bool isEmpty() {
            return head == null;    
        }
        public bool insert(int data) {
            nodeList p=new nodeList();
            p.data = data;
            p.next = null;
            insertNode(p, tail);
            return true;
        }


        private nodeList head;
        private nodeList tail;
        private void insertNode(nodeList p,nodeList prev) {
            if (head == null)
            {
                p.next = head;
                head = tail = p;
            }else if (prev == null)
            {
                p.next = head;
                head = p;
            }
            else
            {
                p.next = prev.next;
                prev.next = p;
                if (prev == tail)
                    tail = p;
            }
        }
    }
}
