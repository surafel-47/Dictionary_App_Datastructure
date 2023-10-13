using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.GUI.Admin
{
    public partial class Admin : Form
    {
        private AVLTree avlTree; //AVLTree of The Admin Form, used for ViewingAdding, Editing and Deleting Records 
        public Admin()
        {
            InitializeComponent();
            this.CenterToScreen();
            loadAvlTree(); //loading AVLTree when Admin Form is Opened
            loadEditTable(); //loading Edits Panel with Word Records when Admin Form is Opened
            loadDeleteTable(); //loading Edits Panel with Word Records when Admin Form is Opened
            BTreePrinter.Print(avlTree.getRoot());//for Printing on Console AVLTree Nodes for Debugging
        }
    
        //loads AVLTree from File
        public void loadAvlTree()
        {
            avlTree = new AVLTree();
            avlTree.loadAVLTreeFromFile();
        }



        //loads Edits Panel from Search Input
        public void loadEditTable()
        {
            editWordsPanel.Controls.Clear();

            string target = editSearchT.Text;
            Queue<DicIndex> searchResultQueue = avlTree.find(target);

            if (File.Exists("Dictionary.bin"))
            {
                using (FileStream fileStream = new FileStream("Dictionary.bin", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    while (searchResultQueue.Count != 0)
                    {
                        DicIndex dicIndex = searchResultQueue.Dequeue();
                        long position = dicIndex.posIndex;
                        fileStream.Seek(position, SeekOrigin.Begin);

                        if (fileStream.Position > fileStream.Length)
                            continue;

                        Dictionary tempDictionary = (Dictionary)binaryFormatter.Deserialize(fileStream);
                        string word = new string(tempDictionary.word);
                        string pron = new string(tempDictionary.pron);
                        string type = new string(tempDictionary.type);
                        string meaning = new string(tempDictionary.meaning);  
                        EditUserControl editUserControl=new EditUserControl(word,pron, type,meaning,dicIndex,avlTree);
                        editWordsPanel.Controls.Add(editUserControl);
                    }
                    fileStream.Close();
                }
            }
          
        }

        //loads Delete Panel from Search Input
        public void loadDeleteTable()
        {
            deleteWordsPanel.Controls.Clear();

            string target = deleteSearchT.Text;
            Queue<DicIndex> searchResultQueue = avlTree.find(target);

            if (File.Exists("Dictionary.bin"))
            {
                using (FileStream fileStream = new FileStream("Dictionary.bin", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    while (searchResultQueue.Count != 0)
                    {
                        DicIndex dicIndex = searchResultQueue.Dequeue();
                        long position = dicIndex.posIndex;
                        fileStream.Seek(position, SeekOrigin.Begin);
                        Dictionary tempDictionary = (Dictionary)binaryFormatter.Deserialize(fileStream);
                        string word = new string(tempDictionary.word);
                        string pron = new string(tempDictionary.pron);
                        string type = new string(tempDictionary.type);
                        string meaning = new string(tempDictionary.meaning);
                        DeleteUserControl deleteUserControl = new DeleteUserControl(word, pron, type, meaning,dicIndex,avlTree);
                        deleteWordsPanel.Controls.Add(deleteUserControl);
                    }
                    fileStream.Close();
                }
            }
        }

        //re loads AVLTree first, then Edits Panel, then Deletes Panel
        public void refresh()
        {
            loadAvlTree();
            loadEditTable();
            loadDeleteTable();
        }

        private void AddB_Click(object sender, EventArgs e) //when Add Recorc Clicked
        {
            if(wordAddT.Text.Equals("") || proAddT.Text.Equals("") || typeAddT.Text.Equals("") || meaningAddT.Text.Equals(""))
            {
                MessageBox.Show("Input Important Fields");
            }
            else
            {
                //Preparing a Dicionary Record to be inserted
                Dictionary newDictionaryRecord = new Dictionary(); 
                newDictionaryRecord.word = wordAddT.Text.ToCharArray();
                newDictionaryRecord.type = typeAddT.Text.ToCharArray();
                newDictionaryRecord.pron = proAddT.Text.ToCharArray();
                newDictionaryRecord.meaning = meaningAddT.Text.ToCharArray();
                

                avlTree.insert(newDictionaryRecord); //inserting the Prepared DictionaryRecord in both File and AVLTree

                MessageBox.Show("Word Record Added!");
                wordAddT.Text = ""; proAddT.Text = "";typeAddT.Text = ""; meaningAddT.Text = ""; //clearing textFields
            }
        }

        private void EditSearchB_Click(object sender, EventArgs e)//loads Edit Table Based on Search Input
        {
            loadEditTable();
        }

        private void DeleteSearchB_Click(object sender, EventArgs e)//loads Delete Table Based on Search Input
        {
            loadDeleteTable();
        }




        //*************************************************Extra*************************************************************

        private void BackB_Click(object sender, EventArgs e)//return to Main Panel
        {
            this.Hide();
            new MainPanel().ShowDialog();
            this.Close();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAvlTree();
            loadEditTable();
            loadDeleteTable();
        }

        private void CloseB_Click(object sender, EventArgs e) //Exit Program
        {
            this.Close();
        }


        private Point mouseLocation;

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }
    }



}
