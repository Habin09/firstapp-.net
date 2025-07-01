namespace Secondproject
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
            lbl = new Label();
            lblpersonal = new Label();
            lblname = new Label();
            txtname = new TextBox();
            lbladdress = new Label();
            txtaddress = new TextBox();
            lblphone = new Label();
            txtphone = new TextBox();
            lblemail = new Label();
            txtemail = new TextBox();
            lblid = new Label();
            txtid = new TextBox();
            btnapply = new Button();
            lblgender = new Label();
            rdomale = new RadioButton();
            rdofemale = new RadioButton();
            pnl = new Panel();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Microsoft New Tai Lue", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl.ForeColor = SystemColors.ButtonHighlight;
            lbl.Location = new Point(116, 25);
            lbl.Name = "lbl";
            lbl.Size = new Size(299, 37);
            lbl.TabIndex = 0;
            lbl.Text = "Job Application Form";
            // 
            // lblpersonal
            // 
            lblpersonal.AutoSize = true;
            lblpersonal.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpersonal.Location = new Point(24, 86);
            lblpersonal.Name = "lblpersonal";
            lblpersonal.Size = new Size(147, 20);
            lblpersonal.TabIndex = 1;
            lblpersonal.Text = "Personal information";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.Location = new Point(57, 106);
            lblname.Name = "lblname";
            lblname.Size = new Size(84, 18);
            lblname.TabIndex = 2;
            lblname.Text = "Full Name";
            // 
            // txtname
            // 
            txtname.Location = new Point(62, 127);
            txtname.Name = "txtname";
            txtname.Size = new Size(383, 27);
            txtname.TabIndex = 3;
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladdress.Location = new Point(57, 264);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(69, 18);
            lbladdress.TabIndex = 4;
            lbladdress.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(62, 285);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(380, 32);
            txtaddress.TabIndex = 5;
            // 
            // lblphone
            // 
            lblphone.AutoSize = true;
            lblphone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblphone.Location = new Point(57, 335);
            lblphone.Name = "lblphone";
            lblphone.Size = new Size(120, 18);
            lblphone.TabIndex = 6;
            lblphone.Text = "Phone Number";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(62, 356);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(246, 27);
            txtphone.TabIndex = 7;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblemail.Location = new Point(57, 402);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(116, 18);
            lblemail.TabIndex = 8;
            lblemail.Text = "Email Address";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(62, 423);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(389, 27);
            txtemail.TabIndex = 9;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.Location = new Point(57, 467);
            lblid.Name = "lblid";
            lblid.Size = new Size(88, 18);
            lblid.TabIndex = 10;
            lblid.Text = "ID Number";
            // 
            // txtid
            // 
            txtid.Location = new Point(62, 488);
            txtid.Name = "txtid";
            txtid.Size = new Size(327, 27);
            txtid.TabIndex = 11;
            // 
            // btnapply
            // 
            btnapply.BackColor = SystemColors.MenuHighlight;
            btnapply.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnapply.Location = new Point(177, 552);
            btnapply.Name = "btnapply";
            btnapply.Size = new Size(189, 40);
            btnapply.TabIndex = 14;
            btnapply.Text = "Apply Now";
            btnapply.UseVisualStyleBackColor = false;
            btnapply.Click += btnapply_Click;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgender.Location = new Point(57, 169);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(63, 18);
            lblgender.TabIndex = 15;
            lblgender.Text = "Gender";
            // 
            // rdomale
            // 
            rdomale.AutoSize = true;
            rdomale.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdomale.Location = new Point(77, 190);
            rdomale.Name = "rdomale";
            rdomale.Size = new Size(63, 24);
            rdomale.TabIndex = 16;
            rdomale.TabStop = true;
            rdomale.Text = "Male";
            rdomale.UseVisualStyleBackColor = true;
            // 
            // rdofemale
            // 
            rdofemale.AutoSize = true;
            rdofemale.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdofemale.Location = new Point(77, 220);
            rdofemale.Name = "rdofemale";
            rdofemale.Size = new Size(78, 24);
            rdofemale.TabIndex = 17;
            rdofemale.TabStop = true;
            rdofemale.Text = "Female";
            rdofemale.UseVisualStyleBackColor = true;
            // 
            // pnl
            // 
            pnl.BackColor = Color.LimeGreen;
            pnl.Controls.Add(lbl);
            pnl.Location = new Point(0, 1);
            pnl.Name = "pnl";
            pnl.Size = new Size(539, 81);
            pnl.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(541, 654);
            Controls.Add(pnl);
            Controls.Add(rdofemale);
            Controls.Add(rdomale);
            Controls.Add(lblgender);
            Controls.Add(btnapply);
            Controls.Add(txtid);
            Controls.Add(lblid);
            Controls.Add(txtemail);
            Controls.Add(lblemail);
            Controls.Add(txtphone);
            Controls.Add(lblphone);
            Controls.Add(txtaddress);
            Controls.Add(lbladdress);
            Controls.Add(txtname);
            Controls.Add(lblname);
            Controls.Add(lblpersonal);
            Name = "Form1";
            Text = "Form1";
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label lblpersonal;
        private Label lblname;
        private TextBox txtname;
        private Label lbladdress;
        private TextBox txtaddress;
        private Label lblphone;
        private TextBox txtphone;
        private Label lblemail;
        private TextBox txtemail;
        private Label lblid;
        private TextBox txtid;
        private Button btnapply;
        private Label lblgender;
        private RadioButton rdomale;
        private RadioButton rdofemale;
        private Panel pnl;
    }
}