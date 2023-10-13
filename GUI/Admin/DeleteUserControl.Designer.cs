namespace Dictionary.GUI.Admin
{
    partial class DeleteUserControl
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
            this.deleteB = new System.Windows.Forms.Button();
            this.wordT = new System.Windows.Forms.TextBox();
            this.pronT = new System.Windows.Forms.TextBox();
            this.typeT = new System.Windows.Forms.TextBox();
            this.meaningT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteB
            // 
            this.deleteB.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.deleteB.Location = new System.Drawing.Point(415, 51);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(95, 37);
            this.deleteB.TabIndex = 4;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // wordT
            // 
            this.wordT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.wordT.Location = new System.Drawing.Point(17, 14);
            this.wordT.Name = "wordT";
            this.wordT.ReadOnly = true;
            this.wordT.Size = new System.Drawing.Size(119, 30);
            this.wordT.TabIndex = 6;
            this.wordT.Text = "Word";
            // 
            // pronT
            // 
            this.pronT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.pronT.Location = new System.Drawing.Point(17, 49);
            this.pronT.Name = "pronT";
            this.pronT.ReadOnly = true;
            this.pronT.Size = new System.Drawing.Size(119, 30);
            this.pronT.TabIndex = 7;
            this.pronT.Text = "Pron";
            // 
            // typeT
            // 
            this.typeT.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.typeT.Location = new System.Drawing.Point(17, 85);
            this.typeT.Name = "typeT";
            this.typeT.ReadOnly = true;
            this.typeT.Size = new System.Drawing.Size(119, 30);
            this.typeT.TabIndex = 8;
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
            this.meaningT.TabIndex = 9;
            this.meaningT.Text = "Meaning";
            // 
            // DeleteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.meaningT);
            this.Controls.Add(this.typeT);
            this.Controls.Add(this.pronT);
            this.Controls.Add(this.wordT);
            this.Controls.Add(this.deleteB);
            this.Name = "DeleteUserControl";
            this.Size = new System.Drawing.Size(523, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.TextBox wordT;
        private System.Windows.Forms.TextBox pronT;
        private System.Windows.Forms.TextBox typeT;
        private System.Windows.Forms.TextBox meaningT;
    }
}
