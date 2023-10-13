using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Dictionary.GUI.Users
{
    public partial class ViewUserControl : UserControl
    {
        public ViewUserControl(String word, String pron, String type, String meaning,String searchInput)
        {

            InitializeComponent();
            wordT.Text = word;
            pronT.Text = pron;
            typeT.Text = type;
            meaningT.Text = meaning;
            highlightWordPartThatMatchesSearchInput(searchInput);
        }

        private void SpeakB_Click(object sender, EventArgs e)// Read the Word and It's Meaning
        {
                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.Rate = 2;
                speech.SpeakAsync(wordT.Text);
                speech.SpeakAsync(meaningT.Text);
        }
        private void highlightWordPartThatMatchesSearchInput(String searchInput)//to Highlight matching substrings of words with SearchInput
        {
            searchInput = searchInput.Trim('*', ' ');
            int highlightStart = wordT.Find(searchInput);
            if (highlightStart > -1)
            {
                int highlightEnd = searchInput.Length;
                wordT.Select(highlightStart, highlightEnd);
                wordT.SelectionBackColor = Color.Yellow;
            }
        }
    }
}
