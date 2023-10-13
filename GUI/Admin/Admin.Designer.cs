namespace Dictionary.GUI.Admin
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.Addaneword = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.meaningAddT = new System.Windows.Forms.TextBox();
            this.typeAddT = new System.Windows.Forms.TextBox();
            this.proAddT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.wordAddT = new System.Windows.Forms.TextBox();
            this.addB = new System.Windows.Forms.Button();
            this.editTab = new System.Windows.Forms.TabPage();
            this.editWordsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.editSearchT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editSearchB = new System.Windows.Forms.Button();
            this.deleteTab = new System.Windows.Forms.TabPage();
            this.deleteWordsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteSearchT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteSearchB = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.addTab.SuspendLayout();
            this.editTab.SuspendLayout();
            this.deleteTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addTab);
            this.tabControl1.Controls.Add(this.editTab);
            this.tabControl1.Controls.Add(this.deleteTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 554);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.Addaneword);
            this.addTab.Controls.Add(this.label7);
            this.addTab.Controls.Add(this.label8);
            this.addTab.Controls.Add(this.label9);
            this.addTab.Controls.Add(this.meaningAddT);
            this.addTab.Controls.Add(this.typeAddT);
            this.addTab.Controls.Add(this.proAddT);
            this.addTab.Controls.Add(this.label10);
            this.addTab.Controls.Add(this.wordAddT);
            this.addTab.Controls.Add(this.addB);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(555, 528);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "Add";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // Addaneword
            // 
            this.Addaneword.AutoSize = true;
            this.Addaneword.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addaneword.Location = new System.Drawing.Point(120, 54);
            this.Addaneword.Name = "Addaneword";
            this.Addaneword.Size = new System.Drawing.Size(270, 40);
            this.Addaneword.TabIndex = 15;
            this.Addaneword.Text = "Add a New Word!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label7.Location = new System.Drawing.Point(46, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Meaning";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label8.Location = new System.Drawing.Point(71, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label9.Location = new System.Drawing.Point(11, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Pronouaction";
            // 
            // meaningAddT
            // 
            this.meaningAddT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.meaningAddT.Location = new System.Drawing.Point(129, 267);
            this.meaningAddT.Multiline = true;
            this.meaningAddT.Name = "meaningAddT";
            this.meaningAddT.Size = new System.Drawing.Size(319, 107);
            this.meaningAddT.TabIndex = 21;
            // 
            // typeAddT
            // 
            this.typeAddT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.typeAddT.Location = new System.Drawing.Point(129, 222);
            this.typeAddT.Name = "typeAddT";
            this.typeAddT.Size = new System.Drawing.Size(102, 30);
            this.typeAddT.TabIndex = 20;
            // 
            // proAddT
            // 
            this.proAddT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.proAddT.Location = new System.Drawing.Point(129, 176);
            this.proAddT.Name = "proAddT";
            this.proAddT.Size = new System.Drawing.Size(121, 30);
            this.proAddT.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label10.Location = new System.Drawing.Point(71, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Word";
            // 
            // wordAddT
            // 
            this.wordAddT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.wordAddT.Location = new System.Drawing.Point(129, 128);
            this.wordAddT.Name = "wordAddT";
            this.wordAddT.Size = new System.Drawing.Size(121, 30);
            this.wordAddT.TabIndex = 17;
            // 
            // addB
            // 
            this.addB.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.Location = new System.Drawing.Point(197, 399);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(133, 45);
            this.addB.TabIndex = 18;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // editTab
            // 
            this.editTab.Controls.Add(this.editWordsPanel);
            this.editTab.Controls.Add(this.editSearchT);
            this.editTab.Controls.Add(this.label1);
            this.editTab.Controls.Add(this.editSearchB);
            this.editTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.editTab.Location = new System.Drawing.Point(4, 22);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(555, 528);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "Edit";
            this.editTab.UseVisualStyleBackColor = true;
            // 
            // editWordsPanel
            // 
            this.editWordsPanel.AutoScroll = true;
            this.editWordsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.editWordsPanel.Location = new System.Drawing.Point(0, 65);
            this.editWordsPanel.Name = "editWordsPanel";
            this.editWordsPanel.Size = new System.Drawing.Size(555, 462);
            this.editWordsPanel.TabIndex = 51;
            // 
            // editSearchT
            // 
            this.editSearchT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.editSearchT.Location = new System.Drawing.Point(138, 16);
            this.editSearchT.Name = "editSearchT";
            this.editSearchT.Size = new System.Drawing.Size(222, 30);
            this.editSearchT.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Search Record";
            // 
            // editSearchB
            // 
            this.editSearchB.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.editSearchB.Location = new System.Drawing.Point(366, 14);
            this.editSearchB.Name = "editSearchB";
            this.editSearchB.Size = new System.Drawing.Size(89, 32);
            this.editSearchB.TabIndex = 35;
            this.editSearchB.Text = "Search";
            this.editSearchB.UseVisualStyleBackColor = true;
            this.editSearchB.Click += new System.EventHandler(this.EditSearchB_Click);
            // 
            // deleteTab
            // 
            this.deleteTab.Controls.Add(this.deleteWordsPanel);
            this.deleteTab.Controls.Add(this.deleteSearchT);
            this.deleteTab.Controls.Add(this.label12);
            this.deleteTab.Controls.Add(this.deleteSearchB);
            this.deleteTab.Location = new System.Drawing.Point(4, 22);
            this.deleteTab.Name = "deleteTab";
            this.deleteTab.Size = new System.Drawing.Size(555, 528);
            this.deleteTab.TabIndex = 2;
            this.deleteTab.Text = "Delete";
            this.deleteTab.UseVisualStyleBackColor = true;
            // 
            // deleteWordsPanel
            // 
            this.deleteWordsPanel.AutoScroll = true;
            this.deleteWordsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteWordsPanel.Location = new System.Drawing.Point(0, 65);
            this.deleteWordsPanel.Name = "deleteWordsPanel";
            this.deleteWordsPanel.Size = new System.Drawing.Size(555, 462);
            this.deleteWordsPanel.TabIndex = 52;
            // 
            // deleteSearchT
            // 
            this.deleteSearchT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.deleteSearchT.Location = new System.Drawing.Point(138, 16);
            this.deleteSearchT.Name = "deleteSearchT";
            this.deleteSearchT.Size = new System.Drawing.Size(222, 30);
            this.deleteSearchT.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label12.Location = new System.Drawing.Point(14, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 23);
            this.label12.TabIndex = 45;
            this.label12.Text = "Search Record";
            // 
            // deleteSearchB
            // 
            this.deleteSearchB.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.deleteSearchB.Location = new System.Drawing.Point(366, 14);
            this.deleteSearchB.Name = "deleteSearchB";
            this.deleteSearchB.Size = new System.Drawing.Size(89, 32);
            this.deleteSearchB.TabIndex = 44;
            this.deleteSearchB.Text = "Search";
            this.deleteSearchB.UseVisualStyleBackColor = true;
            this.deleteSearchB.Click += new System.EventHandler(this.DeleteSearchB_Click);
            // 
            // backB
            // 
            this.backB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backB.Location = new System.Drawing.Point(16, 611);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(89, 39);
            this.backB.TabIndex = 19;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.closeB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 27);
            this.panel1.TabIndex = 20;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // closeB
            // 
            this.closeB.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeB.Location = new System.Drawing.Point(547, 0);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(28, 27);
            this.closeB.TabIndex = 3;
            this.closeB.Text = "X";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin (Dictionary)";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 662);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin (Dictionary)";
            this.tabControl1.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            this.editTab.ResumeLayout(false);
            this.editTab.PerformLayout();
            this.deleteTab.ResumeLayout(false);
            this.deleteTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TabPage editTab;
        private System.Windows.Forms.TabPage deleteTab;
        private System.Windows.Forms.Label Addaneword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox meaningAddT;
        private System.Windows.Forms.TextBox typeAddT;
        private System.Windows.Forms.TextBox proAddT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox wordAddT;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.TextBox editSearchT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editSearchB;
        private System.Windows.Forms.TextBox deleteSearchT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button deleteSearchB;
        private System.Windows.Forms.FlowLayoutPanel editWordsPanel;
        private System.Windows.Forms.FlowLayoutPanel deleteWordsPanel;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeB;
    }
}