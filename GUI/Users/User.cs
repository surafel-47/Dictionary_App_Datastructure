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
using Dictionary.GUI.Admin;
namespace Dictionary.GUI.Users
{
    public partial class User : Form
    {
        AVLTree avlTree;

        public User()
        {
            InitializeComponent();
            this.CenterToScreen();
            loadAVLTree(); //load AVLTree when UserForm is Opened
            loadViewWordPanel(); // load View Words Panel when User Form Opened
            BTreePrinter.Print(avlTree.getRoot());//printing words on console
        }

        void loadAVLTree()//loading AVLTree
        {
            avlTree = new AVLTree();
            avlTree.loadAVLTreeFromFile();
        }

        public void loadViewWordPanel()
        {
            viewWordsPanel.Controls.Clear();
            string target;
            if (searchT.Text.Equals("Search Here! use (*) for Wildcard Search"))//if search Text box is this, means no search Input,meaning View All
                target = "";
            else
                target = searchT.Text;

            //using find Method to Search and Return Queue of DicIndex Addresses
            Queue<DicIndex> searchResultQueue = avlTree.find(target);


            //reading from file and Loading each viewUserControl in View Users Panel
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
                        ViewUserControl viewUserControl = new ViewUserControl(word, pron, type, meaning,target);
                        viewWordsPanel.Controls.Add(viewUserControl);
                    }
                    fileStream.Close();
                }
            }
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            loadViewWordPanel();// reload and Word Panel with Search Input
        }



        //****************************************************Extra**************************************************

        private void BackB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPanel().ShowDialog();
            this.Close();
        }

        private void SearchT_Enter(object sender, EventArgs e)
        {
            if(searchT.Text.Equals("Search Here! use (*) for Wildcard Search"))
            {
                searchT.Text = "";
                searchT.ForeColor = Color.Black;
            }
        }

        private void SearchT_Leave(object sender, EventArgs e)
        {
            if (searchT.Text.Equals(""))
            {
                searchT.Text = "Search Here! use (*) for Wildcard Search";
                searchT.ForeColor = Color.DarkGray;
            }
        }

        private void CloseB_Click(object sender, EventArgs e)
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
