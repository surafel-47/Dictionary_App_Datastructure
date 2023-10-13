namespace Dictionary.GUI.Users
{
    partial class User
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
            this.searchT = new System.Windows.Forms.TextBox();
            this.searchB = new System.Windows.Forms.Button();
            this.viewWordsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchT
            // 
            this.searchT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchT.BackColor = System.Drawing.SystemColors.Menu;
            this.searchT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.searchT.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.searchT.Location = new System.Drawing.Point(15, 88);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(264, 30);
            this.searchT.TabIndex = 0;
            this.searchT.Text = "Search Here! use (*) for Wildcard Search";
            this.searchT.Enter += new System.EventHandler(this.SearchT_Enter);
            this.searchT.Leave += new System.EventHandler(this.SearchT_Leave);
            // 
            // searchB
            // 
            this.searchB.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.searchB.Location = new System.Drawing.Point(285, 88);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(99, 30);
            this.searchB.TabIndex = 1;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // viewWordsPanel
            // 
            this.viewWordsPanel.AutoScroll = true;
            this.viewWordsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.viewWordsPanel.Location = new System.Drawing.Point(12, 141);
            this.viewWordsPanel.Name = "viewWordsPanel";
            this.viewWordsPanel.Size = new System.Drawing.Size(517, 437);
            this.viewWordsPanel.TabIndex = 2;
            // 
            // backB
            // 
            this.backB.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.backB.Location = new System.Drawing.Point(12, 595);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(112, 31);
            this.backB.TabIndex = 3;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.closeB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 35);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // closeB
            // 
            this.closeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeB.Location = new System.Drawing.Point(510, 5);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(28, 27);
            this.closeB.TabIndex = 1;
            this.closeB.Text = "X";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User(Dictionary)";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.viewWordsPanel);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.searchT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "User (Dictionary)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.FlowLayoutPanel viewWordsPanel;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.Label label1;
    }
}