namespace Dictionary.GUI.Admin
{
    partial class EditUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveB = new System.Windows.Forms.Button();
            this.wordT = new System.Windows.Forms.TextBox();
            this.pronT = new System.Windows.Forms.TextBox();
            this.typeT = new System.Windows.Forms.TextBox();
            this.meaningT = new System.Windows.Forms.TextBox();
            this.editB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveB
            // 
            this.saveB.Enabled = false;
            this.saveB.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.saveB.Location = new System.Drawing.Point(423, 65);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(84, 33);
            this.saveB.TabIndex = 4;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // wordT
            // 
            this.wordT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.wordT.Location = new System.Drawing.Point(17, 14);
            this.wordT.Name = "wordT";
            this.wordT.ReadOnly = true;
            this.wordT.Size = new System.Drawing.Size(119, 30);
            this.wordT.TabIndex = 5;
            this.wordT.Text = "Word";
            // 
            // pronT
            // 
            this.pronT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.pronT.Location = new System.Drawing.Point(17, 49);
            this.pronT.Name = "pronT";
            this.pronT.ReadOnly = true;
            this.pronT.Size = new System.Drawing.Size(119, 30);
            this.pronT.TabIndex = 6;
            this.pronT.Text = "Pron";
            // 
            // typeT
            // 
            this.typeT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.typeT.Location = new System.Drawing.Point(17, 85);
            this.typeT.Name = "typeT";
            this.typeT.ReadOnly = true;
            this.typeT.Size = new System.Drawing.Size(119, 30);
            this.typeT.TabIndex = 7;
            this.typeT.Text = "Type";
            // 
            // meaningT
            // 
            this.meaningT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.meaningT.Location = new System.Drawing.Point(156, 15);
            this.meaningT.Multiline = true;
            this.meaningT.Name = "meaningT";
            this.meaningT.ReadOnly = true;
            this.meaningT.Size = new System.Drawing.Size(241, 100);
            this.meaningT.TabIndex = 8;
            this.meaningT.Text = "Meaning";
            // 
            // editB
            // 
            this.editB.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.editB.Location = new System.Drawing.Point(423, 15);
            this.editB.Name = "editB";
            this.editB.Size = new System.Drawing.Size(84, 30);
            this.editB.TabIndex = 9;
            this.editB.Text = "Edit";
            this.editB.UseVisualStyleBackColor = true;
            this.editB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // EditUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.editB);
            this.Controls.Add(this.meaningT);
            this.Controls.Add(this.typeT);
            this.Controls.Add(this.pronT);
            this.Controls.Add(this.wordT);
            this.Controls.Add(this.saveB);
            this.Name = "EditUserControl";
            this.Size = new System.Drawing.Size(526, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.TextBox wordT;
        private System.Windows.Forms.TextBox pronT;
        private System.Windows.Forms.TextBox typeT;
        private System.Windows.Forms.TextBox meaningT;
        private System.Windows.Forms.Button editB;
    }
}
