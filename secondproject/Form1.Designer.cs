namespace Secondproject
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
            lbl = new Label();
            lbl2 = new Label();
            textBox1 = new TextBox();
            lbl3 = new Label();
            textBox2 = new TextBox();
            lbl4 = new Label();
            lbl5 = new Label();
            textBox3 = new TextBox();
            rdomale = new RadioButton();
            rdofemale = new RadioButton();
            lbl6 = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft PhagsPa", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(211, 21);
            lbl.Name = "lbl";
            lbl.Size = new Size(237, 31);
            lbl.TabIndex = 0;
            lbl.Text = "Student Registration";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(43, 96);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(130, 22);
            lbl2.TabIndex = 1;
            lbl2.Text = "Admisstion.no";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 27);
            textBox1.TabIndex = 2;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.FlatStyle = FlatStyle.Flat;
            lbl3.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(43, 141);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(97, 22);
            lbl3.TabIndex = 3;
            lbl3.Text = "First name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 27);
            textBox2.TabIndex = 4;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.Location = new Point(43, 184);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(95, 22);
            lbl4.TabIndex = 5;
            lbl4.Text = "Last name";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.Location = new Point(43, 226);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(72, 22);
            lbl5.TabIndex = 6;
            lbl5.Text = "Gender";
            lbl5.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(343, 27);
            textBox3.TabIndex = 7;
            // 
            // rdomale
            // 
            rdomale.AutoSize = true;
            rdomale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdomale.Location = new Point(193, 224);
            rdomale.Name = "rdomale";
            rdomale.Size = new Size(64, 24);
            rdomale.TabIndex = 8;
            rdomale.TabStop = true;
            rdomale.Text = "Male";
            rdomale.UseVisualStyleBackColor = true;
            // 
            // rdofemale
            // 
            rdofemale.AutoSize = true;
            rdofemale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdofemale.Location = new Point(284, 224);
            rdofemale.Name = "rdofemale";
            rdofemale.Size = new Size(80, 24);
            rdofemale.TabIndex = 9;
            rdofemale.TabStop = true;
            rdofemale.Text = "Female";
            rdofemale.UseVisualStyleBackColor = true;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.Location = new Point(43, 271);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(61, 22);
            lbl6.TabIndex = 10;
            lbl6.Text = "Gread";
            lbl6.Click += lbl6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 450);
            Controls.Add(lbl6);
            Controls.Add(rdofemale);
            Controls.Add(rdomale);
            Controls.Add(textBox3);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(textBox2);
            Controls.Add(lbl3);
            Controls.Add(textBox1);
            Controls.Add(lbl2);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label lbl2;
        private TextBox textBox1;
        private Label lbl3;
        private TextBox textBox2;
        private Label lbl4;
        private Label lbl5;
        private TextBox textBox3;
        private RadioButton rdomale;
        private RadioButton rdofemale;
        private Label lbl6;
    }
}
