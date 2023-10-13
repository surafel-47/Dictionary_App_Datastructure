namespace Dictionary.GUI.Users
{
    partial class ViewUserControl
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
            this.pronT = new System.Windows.Forms.Label();
            this.typeT = new System.Windows.Forms.Label();
            this.wordT = new System.Windows.Forms.RichTextBox();
            this.speakB = new System.Windows.Forms.Button();
            this.meaningT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pronT
            // 
            this.pronT.AutoSize = true;
            this.pronT.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronT.Location = new System.Drawing.Point(49, 48);
            this.pronT.Name = "pronT";
            this.pronT.Size = new System.Drawing.Size(42, 23);
            this.pronT.TabIndex = 1;
            this.pronT.Text = "Pron";
            // 
            // typeT
            // 
            this.typeT.AutoSize = true;
            this.typeT.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeT.Location = new System.Drawing.Point(49, 76);
            this.typeT.Name = "typeT";
            this.typeT.Size = new System.Drawing.Size(47, 23);
            this.typeT.TabIndex = 2;
            this.typeT.Text = "Type";
            // 
            // wordT
            // 
            this.wordT.BackColor = System.Drawing.SystemColors.Control;
            this.wordT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordT.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordT.Location = new System.Drawing.Point(48, 13);
            this.wordT.Name = "wordT";
            this.wordT.ReadOnly = true;
            this.wordT.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.wordT.Size = new System.Drawing.Size(120, 28);
            this.wordT.TabIndex = 5;
            this.wordT.Text = "Word";
            // 
            // speakB
            // 
            this.speakB.BackgroundImage = global::Dictionary.Properties.Resources.Speak;
            this.speakB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speakB.Location = new System.Drawing.Point(12, 12);
            this.speakB.Name = "speakB";
            this.speakB.Size = new System.Drawing.Size(30, 29);
            this.speakB.TabIndex = 4;
            this.speakB.UseVisualStyleBackColor = true;
            this.speakB.Click += new System.EventHandler(this.SpeakB_Click);
            // 
            // meaningT
            // 
            this.meaningT.BackColor = System.Drawing.SystemColors.Control;
            this.meaningT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meaningT.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.meaningT.Location = new System.Drawing.Point(195, 12);
            this.meaningT.Multiline = true;
            this.meaningT.Name = "meaningT";
            this.meaningT.Size = new System.Drawing.Size(296, 72);
            this.meaningT.TabIndex = 6;
            this.meaningT.Text = "Meaning";
            // 
            // ViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.meaningT);
            this.Controls.Add(this.wordT);
            this.Controls.Add(this.speakB);
            this.Controls.Add(this.typeT);
            this.Controls.Add(this.pronT);
            this.Name = "ViewUserControl";
            this.Size = new System.Drawing.Size(494, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pronT;
        private System.Windows.Forms.Label typeT;
        private System.Windows.Forms.Button speakB;
        private System.Windows.Forms.RichTextBox wordT;
        private System.Windows.Forms.TextBox meaningT;
    }
}
