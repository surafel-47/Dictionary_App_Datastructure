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
    public partial class EditUserControl : UserControl
    {
        private DicIndex oldDicIndex;
        private AVLTree avlTree;
        public EditUserControl(String word, String pron, String type, String meaning,DicIndex dicIndex,AVLTree avlTree)
        {
     
            InitializeComponent();
            wordT.Text = word;
            pronT.Text = pron;
            typeT.Text = type;
            meaningT.Text = meaning;
            this.oldDicIndex = dicIndex;
            this.avlTree = avlTree;
        }

        //saves the Edited Record
        private void SaveB_Click(object sender, EventArgs e)
        {
            if (wordT.Text.Equals("") || pronT.Text.Equals("") || typeT.Text.Equals("") || meaningT.Text.Equals(""))
            {
                MessageBox.Show("Input Important Fields");
            }
            else
            {
                //Preparing newly edited Dicionary Record 
                Dictionary newEditeddictionaryRecord = new Dictionary();
                newEditeddictionaryRecord.word = wordT.Text.ToCharArray();
                newEditeddictionaryRecord.pron = pronT.Text.ToCharArray();
                newEditeddictionaryRecord.type = typeT.Text.ToCharArray();
                newEditeddictionaryRecord.meaning = meaningT.Text.ToCharArray();

                //sending the Old Dic Index, and newEditedDicionartRecord to edit Method of AVLTree
                avlTree.edit(oldDicIndex, newEditeddictionaryRecord);


                MessageBox.Show("Edited Succfully");
                ((Admin)Parent.Parent.Parent.Parent).refresh(); //Reresh edits Panel
            }
        }

        private void EditB_Click(object sender, EventArgs e) //enableing Fields for Edit
        {
            wordT.ReadOnly = false;
            pronT.ReadOnly = false;
            typeT.ReadOnly = false;
            meaningT.ReadOnly = false;
            saveB.Enabled = true;
            editB.Enabled = false;
        }
    }
}
