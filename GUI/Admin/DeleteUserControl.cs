using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.GUI.Admin
{
    public partial class DeleteUserControl : UserControl
    {
        DicIndex dicIndex;
        AVLTree avlTree;

        //setting the User Control Values of the Record
        public DeleteUserControl(String word, String pron, String type, String meaning,DicIndex dicIndex,AVLTree avlTree)
        {
            InitializeComponent();
            wordT.Text = word;
            pronT.Text = pron;
            typeT.Text = type;
            meaningT.Text = meaning;
            this.dicIndex = dicIndex;
            this.avlTree = avlTree;
        }


        private void DeleteB_Click(object sender, EventArgs e)//When Delete Clicked on a Record
        {

            avlTree.delete(dicIndex);//Deletes that DicIndex and Dicionary Record form File
        
            MessageBox.Show("Deleted");

          
            ((Admin)Parent.Parent.Parent.Parent).refresh();  //Reresh panel
        }
    }
}
