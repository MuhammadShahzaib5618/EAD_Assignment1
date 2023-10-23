namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Fname = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreCheck = new System.Windows.Forms.CheckBox();
            this.Subjects = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sbutton = new System.Windows.Forms.Button();
            this.Rbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(203, 69);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(328, 26);
            this.Fname.TabIndex = 1;
            this.Fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(203, 138);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(328, 26);
            this.LName.TabIndex = 2;
            this.LName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // PreCheck
            // 
            this.PreCheck.AutoSize = true;
            this.PreCheck.Location = new System.Drawing.Point(516, 221);
            this.PreCheck.Name = "PreCheck";
            this.PreCheck.Size = new System.Drawing.Size(160, 24);
            this.PreCheck.TabIndex = 5;
            this.PreCheck.Text = "Prerequisite Clear";
            this.PreCheck.UseVisualStyleBackColor = true;
            this.PreCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Subjects
            // 
            this.Subjects.FormattingEnabled = true;
            this.Subjects.Items.AddRange(new object[] {
            "Programming Fundamentals",
            "OOP",
            "Data Structures",
            "Analysis of Algorithms",
            "Web Engineering",
            "Entreprise Application Development"});
            this.Subjects.Location = new System.Drawing.Point(34, 217);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(347, 28);
            this.Subjects.TabIndex = 6;
            this.Subjects.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subjects";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Sbutton
            // 
            this.Sbutton.Location = new System.Drawing.Point(334, 280);
            this.Sbutton.Name = "Sbutton";
            this.Sbutton.Size = new System.Drawing.Size(75, 31);
            this.Sbutton.TabIndex = 8;
            this.Sbutton.Text = "Submit";
            this.Sbutton.UseVisualStyleBackColor = true;
            this.Sbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Rbox
            // 
            this.Rbox.Location = new System.Drawing.Point(234, 332);
            this.Rbox.Name = "Rbox";
            this.Rbox.Size = new System.Drawing.Size(342, 106);
            this.Rbox.TabIndex = 9;
            this.Rbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rbox);
            this.Controls.Add(this.Sbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.PreCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.Fname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PreCheck;
        private System.Windows.Forms.ComboBox Subjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sbutton;
        private System.Windows.Forms.RichTextBox Rbox;
    }
}

