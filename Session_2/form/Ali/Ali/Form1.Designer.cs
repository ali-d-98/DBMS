namespace Ali
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
            this.button1 = new System.Windows.Forms.Button();
            this.Firstname = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.Nationalid = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.NI = new System.Windows.Forms.TextBox();
            this.Ag = new System.Windows.Forms.TextBox();
            this.Ci = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(12, 9);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(152, 32);
            this.Firstname.TabIndex = 1;
            this.Firstname.Text = "First Name";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(12, 80);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(151, 32);
            this.Lastname.TabIndex = 2;
            this.Lastname.Text = "Last Name";
            // 
            // Nationalid
            // 
            this.Nationalid.AutoSize = true;
            this.Nationalid.Location = new System.Drawing.Point(12, 157);
            this.Nationalid.Name = "Nationalid";
            this.Nationalid.Size = new System.Drawing.Size(155, 32);
            this.Nationalid.TabIndex = 3;
            this.Nationalid.Text = "National ID";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(12, 230);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(66, 32);
            this.Age.TabIndex = 4;
            this.Age.Text = "Age";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(12, 308);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(64, 32);
            this.City.TabIndex = 5;
            this.City.Text = "City";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(200, 12);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(386, 38);
            this.Fname.TabIndex = 6;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(200, 80);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(386, 38);
            this.Lname.TabIndex = 7;
            // 
            // NI
            // 
            this.NI.Location = new System.Drawing.Point(200, 157);
            this.NI.Name = "NI";
            this.NI.Size = new System.Drawing.Size(386, 38);
            this.NI.TabIndex = 8;
            // 
            // Ag
            // 
            this.Ag.Location = new System.Drawing.Point(200, 230);
            this.Ag.Name = "Ag";
            this.Ag.Size = new System.Drawing.Size(386, 38);
            this.Ag.TabIndex = 9;
            // 
            // Ci
            // 
            this.Ci.Location = new System.Drawing.Point(200, 308);
            this.Ci.Name = "Ci";
            this.Ci.Size = new System.Drawing.Size(386, 38);
            this.Ci.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(915, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 57);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(613, 9);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(704, 337);
            this.result.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 478);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ci);
            this.Controls.Add(this.Ag);
            this.Controls.Add(this.NI);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Nationalid);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Nationalid;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox NI;
        private System.Windows.Forms.TextBox Ag;
        private System.Windows.Forms.TextBox Ci;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox result;
    }
}

