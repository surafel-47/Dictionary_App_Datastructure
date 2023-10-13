using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public partial class  AVLTree
    {
        public void loadAVLTreeFromFile()//Reads Dictionary.bin file and Ineserts Into Tree all Records(as DicIndex)
        {
            if (File.Exists("Dictionary.bin"))
            {
                root = null; //clearing root
                using (FileStream fileStream = new FileStream("Dictionary.bin", FileMode.OpenOrCreate, FileAccess.Read))

                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    while (fileStream.Position < fileStream.Length)//reading until end of file
                    {
                        DicIndex tempDicIndex = new DicIndex(); //preparing DicIndex to Add to AVLTree
                        tempDicIndex.posIndex = fileStream.Position; //setting posIndex of propery of DicIndex the Index of the Current Record

                        Dictionary tempDictionary;//preparing Dicionary Variable to Read a Record from file
                        tempDictionary = (Dictionary)binaryFormatter.Deserialize(fileStream);//reading into tempDicionary

                        tempDicIndex.word = new String(tempDictionary.word);//Assinging DicIndex word propery it's value
                        insertNodeOnlyToAVLTree(tempDicIndex);//inserting the Node into AVL Tree
                    }
                    fileStream.Close();
                }
            }
        }

        private long AddDictionaryRecordintoFileAndReturnPostionIndexOfTheWordAdded(Dictionary dictionary)//Adds Dicionary Record to File
        {
            long position = 0;//to Hold the Pooition where new DicionaryRecord is Inserted Into File

            using (FileStream fileStream = new FileStream("Dictionary.bin", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                position = fileStream.Seek(0, SeekOrigin.End);//setting positon to end of file because that where new Record will be Inserted
                binaryFormatter.Serialize(fileStream, dictionary);//Writing at the end of file the new Dicionary Record
                fileStream.Close();
            }
            return position;
        }

        public void saveDataFromAVLTreeToFile()//loads Data From AVLTree into new File,then deletes old file
        {

                using (FileStream oldFileStream = new FileStream("Dictionary.bin", FileMode.OpenOrCreate, FileAccess.Read))
                using (FileStream newFileStream = new FileStream("temp.bin", FileMode.OpenOrCreate, FileAccess.Write))//new file
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    //InOrder Travering each nodes and Writing to File
                    InOrderTraverseToWriteToNewFileEachNodeVisited(root, oldFileStream, newFileStream, binaryFormatter);
                    newFileStream.Close();
                    oldFileStream.Close();
                }
                File.Delete("Dictionary.bin");//deleting old file
                File.Move("temp.bin", "Dictionary.bin");//renameing, setting the new file it's name "Dicionary.bin"
        }

        //Inorder Travese and Write to File Each Node Visisted
        private void InOrderTraverseToWriteToNewFileEachNodeVisited(AVLNode rootNode, FileStream oldFileStream, FileStream newFileStream, BinaryFormatter binaryFormatter)
        {
            if (rootNode != null)//do until current/rootNode in not null
            {
                //Visiting Left 1st
                InOrderTraverseToWriteToNewFileEachNodeVisited(rootNode.left, oldFileStream, newFileStream, binaryFormatter);
               
                //Visiting Current 2nd
                long positon = rootNode.data.posIndex;
                oldFileStream.Seek(positon, SeekOrigin.Begin);
                Dictionary tempDictionary = (Dictionary)binaryFormatter.Deserialize(oldFileStream);//reading from oldFile
                binaryFormatter.Serialize(newFileStream, tempDictionary);//Writing intoNew File

                //Visiting Right 3rd
                InOrderTraverseToWriteToNewFileEachNodeVisited(rootNode.right, oldFileStream, newFileStream, binaryFormatter);
            }
        }

        public Queue<DicIndex> find(String searchStr)//finds Nodes that match searchString and Returns there Address in Queue List
        {
            Queue<DicIndex> resultsQueue=new Queue<DicIndex>();
            searchStr = searchStr.Trim(); //trimming whitspaces left and right if any exisit

            if (searchStr.Equals(""))
            {
                findAllNodes(resultsQueue, root); //if No Search Input, then find All
            }
            else if( searchStr[0]=='*'   &&  searchStr[searchStr.Length-1]!='*')
            {
                searchStr = searchStr.TrimStart('*'); //Triming the Asterikes
                findNodesPostfix(root,searchStr,resultsQueue);//    *as
            }
            else if( searchStr[0]!='*'  && searchStr[searchStr.Length - 1]=='*')
            {
                searchStr = searchStr.TrimEnd('*'); //Triming the Asterikes
                findNodesPrefix(root, searchStr, resultsQueue);//    as*
            }
            else if( searchStr[0]=='*'   &&  searchStr[searchStr.Length - 1]=='*') 
            {
                searchStr = searchStr.TrimStart('*');  //Triming the Asterikes
                searchStr = searchStr.TrimEnd('*');
                findNodesInfix(root, searchStr, resultsQueue);  //  *as*
            }
            else
            {
                findNodeBST(root, searchStr, resultsQueue);//else just search normally (logN time)
            }
            return resultsQueue;
        }

        //searchs for Exact Matching Word to Search Input O(Logn) 
        private void findNodeBST(AVLNode rootNode,String searchStr, Queue<DicIndex> resultsQueue)
        {
            if (rootNode != null) {
                if (String.Compare(searchStr.ToLower(), rootNode.data.word.ToLower()) ==0)
                {
                    resultsQueue.Enqueue(rootNode.data);
                    findNodeBST(rootNode.left, searchStr, resultsQueue);
                    findNodeBST(rootNode.right, searchStr, resultsQueue);
                }
                else if(String.Compare(searchStr.ToLower(), rootNode.data.word.ToLower()) == -1)
                {
                    findNodeBST(rootNode.left, searchStr, resultsQueue);
                }
                else if(String.Compare(searchStr.ToLower(), rootNode.data.word.ToLower()) == 1)
                {
                    findNodeBST(rootNode.right, searchStr, resultsQueue);
                }
            } 
        }

        //Inorder Travese and Return All Nodes
        private void findAllNodes(Queue<DicIndex> resultsQueue, AVLNode rootNode)
        {
            if (rootNode != null)
            {
                findAllNodes(resultsQueue, rootNode.left);
                resultsQueue.Enqueue(rootNode.data);
                findAllNodes(resultsQueue, rootNode.right);
            }
        }


        //Return Prefix Matching Node (Inorder Travese)
        private void findNodesPrefix(AVLNode rootNode, String searchStr, Queue<DicIndex> resultsQueue)//    as*
        {
            if (rootNode != null)
            {

                //visit Left First
                findNodesPrefix(rootNode.left,searchStr,resultsQueue);

                //visit Node
                if (searchStr.Length < rootNode.data.word.Length)
                {
                    String prefixPartofData = rootNode.data.word.Substring(0, searchStr.Length);//getting Prefix part of Word
                    if (prefixPartofData.ToLower().Equals(searchStr.ToLower()))//comparing Prefix part with Search String
                        resultsQueue.Enqueue(rootNode.data);
                }

                //visit Right
                findNodesPrefix(rootNode.right, searchStr, resultsQueue);
            }
        }


        //Return PostFix Matching Nodes (Inorder Travese)
        private void findNodesPostfix(AVLNode rootNode, String searchStr, Queue<DicIndex> resultsQueue)// *as
        {
            if (rootNode != null)
            {
                //Visit Left
                findNodesPostfix(rootNode.left, searchStr, resultsQueue);

                //Visit Node
                if (searchStr.Length < rootNode.data.word.Length)
                {
                    String postfixPartofData = rootNode.data.word.Substring(rootNode.data.word.Length-searchStr.Length,searchStr.Length);//PostFix part of Word

                    if (postfixPartofData.ToLower().Equals(searchStr.ToLower()))//Comparing PostFix Part with Search Input
                        resultsQueue.Enqueue(rootNode.data);
                }
                
                //Visit Right
                findNodesPostfix(rootNode.right, searchStr, resultsQueue);
            }

        }

        //Return Infix Matching Nodes (Inorder Travese)
        private void findNodesInfix(AVLNode rootNode, String searchStr, Queue<DicIndex> resultsQueue)// *as*
        {
            if (rootNode != null)
            {
                //visit Left
                findNodesInfix(rootNode.left, searchStr, resultsQueue);

                //Vising Node
                if (rootNode.data.word.ToLower().Contains(searchStr.ToLower()))//checking if SearchInput is Contained in wrd
                    resultsQueue.Enqueue(rootNode.data);

                //Visit Right
                findNodesInfix(rootNode.right, searchStr, resultsQueue);
            }
        }

    }
}
