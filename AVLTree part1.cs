using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class AVLNode
    {
        public DicIndex data;
        public int height;
        public AVLNode left;
        public AVLNode right;
        public AVLNode(DicIndex data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }

    public partial class AVLTree
    {
    
        private AVLNode root;  //top root of the tree

        public AVLTree()
        {
            root = null;
        }

        public AVLNode getRoot()
        {
            return root; //getter method to access root
        }

        //Inserts Dictionary Record in to both file and AVL Tree
        public void insert(Dictionary newWordDictionaryRecord)
        {
            //inserting into file and returning the index(positon)  
            long position = AddDictionaryRecordintoFileAndReturnPostionIndexOfTheWordAdded(newWordDictionaryRecord);

            //Preparing DicIndex 
            DicIndex newWordDicIndex = new DicIndex();
            newWordDicIndex.posIndex = position;
            newWordDicIndex.word = new string(newWordDictionaryRecord.word);


            //inserting into AVLTree 
            AVLNode newItem = new AVLNode(newWordDicIndex); 
            if (root == null)
                root = newItem;
            else
                root = insertNode(root, newItem);//recurively  inserting into AVLTree 

            BTreePrinter.Print(root);//printing on console
        }

        private void insertNodeOnlyToAVLTree(DicIndex dicIndex) //Insert into AVLTree only dicIndex
        {
            AVLNode newItem = new AVLNode(dicIndex);

            if (root == null)
                root = newItem;
            else
                root = insertNode(root, newItem);
        }


        private AVLNode insertNode(AVLNode currNode, AVLNode newNode) // Recursivly  insert into AVLTree    
        {
            if (currNode == null)
            {
                currNode = newNode;
                return currNode;
            }
            else if (string.Compare(newNode.data.word, currNode.data.word) == -1 || string.Compare(newNode.data.word, currNode.data.word) == 0)   // if newItem is smaller or equal?????
            {
                currNode.left = insertNode(currNode.left, newNode);
                currNode = balanceSubTree(currNode);
            }
            else if (string.Compare(newNode.data.word, currNode.data.word) == 1) // if newItem larger
            {
                currNode.right = insertNode(currNode.right, newNode);
                currNode = balanceSubTree(currNode);
            }
            return currNode;
        }
       
        public void delete(DicIndex target)
        {
            root = deleteNode(root, target); //recursivily delete target node

            saveDataFromAVLTreeToFile();  //saving Tree with the Deleted Node to File
            loadAVLTreeFromFile(); //Re loading Tree from the Saved File

            BTreePrinter.Print(root);//printing on console
        }


        //Recurivivly Deletes a Node
        private AVLNode deleteNode(AVLNode currNode, DicIndex target)
        {
            AVLNode parent;
            if (currNode == null)
                   return null; 
            else
            {
                //left subtree
                if ( string.Compare(target.word, currNode.data.word)==-1)  //to left subTree
                {
                    currNode.left = deleteNode(currNode.left, target);
                    if (getBalanceFactor(currNode) == -2)// if rightright/rightleft imbalance
                    {
                        if (getBalanceFactor(currNode.right) <= 0)//if rightright
                            currNode = singleRightRotate(currNode);
                        else                                      //if rightleft
                            currNode = DoubleRightRotate(currNode);
                    }
                }
                //right subtree
                else if (string.Compare(target.word, currNode.data.word) == 1)  //to the right subTree
                {
                    currNode.right = deleteNode(currNode.right, target);
                    if (getBalanceFactor(currNode) == 2) //if leftleft/leftright Imbalance 
                    {
                        if (getBalanceFactor(currNode.left) >= 0)//if leftleft Imbalance
                            currNode = singleLeftRotate(currNode);
                        else                                 //if leftright Imbalance      
                            currNode = DoubleLeftRotate(currNode);
                    }
                }
                //if same word with diff meaning is found
                else if (string.Compare(target.word, currNode.data.word) == 0 && target.posIndex != currNode.data.posIndex)
                {
                    currNode.left = deleteNode(currNode.left, target);
                    if (getBalanceFactor(currNode) == -2)// if rightright/rightleft imbalance
                    {
                        if (getBalanceFactor(currNode.right) <= 0)//if rightright
                            currNode = singleRightRotate(currNode);
                        else                                      //if rightleft
                            currNode = DoubleRightRotate(currNode);
                    }
                }
                else//if word is found and has exact same meaning
                {
                    if (currNode.right != null)
                    {
                        //deleteNode its inorder successor
                        parent = currNode.right;
                        while (parent.left != null) //get left most data of right subTree
                        {
                            parent = parent.left;
                        }
                        currNode.data = parent.data;
                        currNode.right = deleteNode(currNode.right, parent.data);
                        if (getBalanceFactor(currNode) == 2) //if leftleft/leftright Imbalance 
                        {
                            if (getBalanceFactor(currNode.left) >= 0)//if leftleft Imbalance
                                currNode = singleLeftRotate(currNode);
                            else                                 //if leftright Imbalance      
                                currNode = DoubleLeftRotate(currNode);
                        }
                    }
                    else //if there is no right childs
                    {       
                        //if current.left != null
                        return currNode.left;
                    }
                }
            }
            return currNode;
        }

        //Edits a Dictionary Record in File, and Updates a DicIndex in Node
        public void edit(DicIndex oldDicIndex, Dictionary newEditedDictionaryRecord)
        {
            delete(oldDicIndex);     //deleteing the old DicIndex(from Tree) & the Dictionary Record is also Removed from file here

            insert(newEditedDictionaryRecord); //inserting into both File and Tree 

        }


        //Balaces a Tree based if(Height of left sub Tree- Height of right SubTree > |2|) 
        private AVLNode balanceSubTree(AVLNode n)
        {
            int bf = getBalanceFactor(n);//getting balacce factor of the Given Node

            if (bf > 1) //if(bf>1) means Height of Left SubTree is Greater
            {
                if (getBalanceFactor(n.left) > 0)//checking if it is a Left Left Imbalance
                {
                    n = singleLeftRotate(n); //preforming singeLeft/LeftLeft Rotation
                }
                else//Else if is a Left Right Imbalance
                {
                    n = DoubleLeftRotate(n); //Preforming a DoubleLeft/leftRight Rotation
                }
            }

            else if (bf < -1)//if(bf>-1) means Height of Right SubTree is Greater
            {
                if (getBalanceFactor(n.right) > 0)//checking if it is a Right Right Imbalance
                {
                    n = DoubleRightRotate(n);//preforming singleRight/RightRight Rotation
                }
                else//Else if Right Left Imbalance
                {
                    n = singleRightRotate(n);//preforming doubleRight/RightLeft Rotation
                }
            }
            return n;
        }


        // ***************************Rotation/BalanceFactor and Height***********************************************
        private int getHeight(AVLNode n)//Recurisvly calculates height of the Given Tree
        {
            if (n == null)
                return 0;
            else
                return 1 + Math.Max(getHeight(n.left), getHeight(n.right));
        }

        private int getBalanceFactor(AVLNode n)//returns height of left subTree-height of Right SubTree
        {
            return getHeight(n.left)- getHeight(n.right);
        }

        private AVLNode singleRightRotate(AVLNode A)
        {
            //        (A)                              (B)
            //          \                             /    \
            //           (B)                        (A)     (C)
            //             \            ->            
            //             (C)   

            AVLNode B = A.right;
            A.right = B.left;
            B.left = A;
            return B;
        }

        private AVLNode singleLeftRotate(AVLNode A)
        {
            //        (A)                               (B)
            //       /                                 /   \
            //     (B)                               (C)   (A)
            //    /                    ->              
            //  (C)

            AVLNode B = A.left;
            A.left = B.right;
            B.right = A;
            return B;
        }

        private AVLNode DoubleLeftRotate(AVLNode A)
        {
            //        (A)                (A)                  (C)
            //       /                   /                   /    \
            //     (B)       ->        (C)         ->      (B)     (A)
            //       \                 /      
            //        (C)             (B) 

            AVLNode B = A.left;
            B = singleRightRotate(B);
            return singleLeftRotate(A);
        }

        private AVLNode DoubleRightRotate(AVLNode A)
        {
            //        (A)              (A)                 (C)
            //          \                \                /    \
            //          (B)      ->      (C)     ->     (A)     (B)
            //          /                  \          
            //        (C)                  (B)    

            AVLNode B = A.right;
            B = singleLeftRotate(B);
            return singleRightRotate(A);
        }



        //**************************************extraa***********************************************
        public AVLNode findMax(AVLNode r)//returns the Right Most Node of the Tree
        {
            while (r.right != null)
                r = r.right;
            return r;
        }

        public AVLNode findMin(AVLNode r)//returns the Left Most Node of the Tree
        {
            while (r.left != null)
                r = r.left;
            return r;
        }
    }

    //***********************************Print*********************************************************************
    public static class BTreePrinter // Printer class that has Print Method to Display Tree on Console for Debugging
    {
        public class NodeInfo
        {
            public AVLNode Node;
            public string Text;
            public int StartPos;
            public int Size { get { return Text.Length; } }
            public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
            public NodeInfo Parent, Left, Right;
        }

        public static void Print(this AVLNode root, string textFormat = "0", int spacing = 1, int topMargin = 2, int leftMargin = 2)
        {
            if (root == null) return;
            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInfo>();
            var next = root;
            for (int level = 0; next != null; level++)
            {
                var item = new NodeInfo { Node = next, Text = next.data.word };
                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + spacing;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = leftMargin;
                    last.Add(item);
                }
                if (level > 0)
                {
                    item.Parent = last[level - 1];
                    if (next == item.Parent.Node.left)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos - 1);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos + 1);
                    }
                }
                next = next.left ?? next.right;
                for (; next == null; item = item.Parent)
                {
                    int top = rootTop + 2 * level;
                    Print(item.Text, top, item.StartPos);
                    if (item.Left != null)
                    {
                        Print("/", top + 1, item.Left.EndPos);
                        Print("_", top, item.Left.EndPos + 1, item.StartPos);
                    }
                    if (item.Right != null)
                    {
                        Print("_", top, item.EndPos, item.Right.StartPos - 1);
                        Print("\\", top + 1, item.Right.StartPos - 1);
                    }
                    if (--level < 0) break;
                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos + 1;
                        next = item.Parent.Node.right;
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos - 1;
                        else
                            item.Parent.StartPos += (item.StartPos - 1 - item.Parent.EndPos) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
        }

        private static void Print(string s, int top, int left, int right = -1)
        {
            Console.SetCursorPosition(left, top);
            if (right < 0) right = left + s.Length;
            while (Console.CursorLeft < right) Console.Write(s);
        }
    }
}
