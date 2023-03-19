namespace Project
{
    partial class Resouce
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
            tbName = new TextBox();
            tbCate = new TextBox();
            tbNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Addbutton = new Button();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(88, 47);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(110, 23);
            tbName.TabIndex = 0;
            // 
            // tbCate
            // 
            tbCate.Location = new Point(88, 82);
            tbCate.Margin = new Padding(3, 2, 3, 2);
            tbCate.Name = "tbCate";
            tbCate.Size = new Size(110, 23);
            tbCate.TabIndex = 1;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(88, 121);
            tbNumber.Margin = new Padding(3, 2, 3, 2);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(110, 23);
            tbNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 50);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 85);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "หมวดหมู่";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 123);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "จำนวนสินค้า";
            // 
            // Addbutton
            // 
            Addbutton.Location = new Point(61, 157);
            Addbutton.Margin = new Padding(3, 2, 3, 2);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(82, 22);
            Addbutton.TabIndex = 6;
            Addbutton.Text = "Add";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // Resouce
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 232);
            Controls.Add(Addbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNumber);
            Controls.Add(tbCate);
            Controls.Add(tbName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Resouce";
            Text = "Resouce";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private TextBox tbCate;
        private TextBox tbNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Addbutton;
    }
}