using Dictionary.GUI;
using Dictionary.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dictionary.GUI.Users;

namespace Dictionary
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void AdminB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().ShowDialog();
            this.Close();
        }

        private void UserB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User().ShowDialog();
            this.Close();
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
