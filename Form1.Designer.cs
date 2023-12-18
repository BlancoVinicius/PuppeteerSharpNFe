namespace view
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtPathName = new TextBox();
            label1 = new Label();
            btnSelectFolder = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(257, 214);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPathName
            // 
            txtPathName.BorderStyle = BorderStyle.FixedSingle;
            txtPathName.Location = new Point(44, 75);
            txtPathName.Name = "txtPathName";
            txtPathName.Size = new Size(436, 23);
            txtPathName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(219, 21);
            label1.TabIndex = 2;
            label1.Text = "Pasta para salvar o arquivo:";
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Cursor = Cursors.Hand;
            btnSelectFolder.FlatAppearance.BorderColor = Color.White;
            btnSelectFolder.FlatStyle = FlatStyle.Flat;
            btnSelectFolder.Image = Properties.Resources.folder;
            btnSelectFolder.Location = new Point(486, 70);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(53, 33);
            btnSelectFolder.TabIndex = 3;
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelectFolder);
            Controls.Add(label1);
            Controls.Add(txtPathName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtPathName;
        private Label label1;
        private Button btnSelectFolder;
    }
}