
namespace WindowsFormsApp2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpAge = new System.Windows.Forms.TextBox();
            this.txtEmpPosition = new System.Windows.Forms.TextBox();
            this.btnSent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMassage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Emp ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Emp Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Emp Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Emp Position";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(169, 40);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 20);
            this.txtEmpID.TabIndex = 4;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(169, 74);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 5;
            // 
            // txtEmpAge
            // 
            this.txtEmpAge.Location = new System.Drawing.Point(169, 115);
            this.txtEmpAge.Name = "txtEmpAge";
            this.txtEmpAge.Size = new System.Drawing.Size(100, 20);
            this.txtEmpAge.TabIndex = 6;
            // 
            // txtEmpPosition
            // 
            this.txtEmpPosition.Location = new System.Drawing.Point(169, 158);
            this.txtEmpPosition.Name = "txtEmpPosition";
            this.txtEmpPosition.Size = new System.Drawing.Size(100, 20);
            this.txtEmpPosition.TabIndex = 7;
            // 
            // btnSent
            // 
            this.btnSent.Location = new System.Drawing.Point(194, 207);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(75, 23);
            this.btnSent.TabIndex = 8;
            this.btnSent.Text = "Sent";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Emp ID";
            // 
            // btnMassage
            // 
            this.btnMassage.Location = new System.Drawing.Point(318, 284);
            this.btnMassage.Name = "btnMassage";
            this.btnMassage.Size = new System.Drawing.Size(75, 23);
            this.btnMassage.TabIndex = 10;
            this.btnMassage.Text = "Massage";
            this.btnMassage.UseVisualStyleBackColor = true;
            this.btnMassage.Click += new System.EventHandler(this.btnMassage_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(617, 410);
            this.Controls.Add(this.btnMassage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtEmpPosition);
            this.Controls.Add(this.txtEmpAge);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpAge;
        private System.Windows.Forms.TextBox txtEmpPosition;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMassage;
    }
}

