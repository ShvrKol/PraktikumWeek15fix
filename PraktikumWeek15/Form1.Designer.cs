
namespace PraktikumWeek15
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
        /// 


        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxfnb = new System.Windows.Forms.ListBox();
            this.listBoxprice = new System.Windows.Forms.ListBox();
            this.radioButtonfood = new System.Windows.Forms.RadioButton();
            this.radioButtonBev = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxfnb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelprc = new System.Windows.Forms.Label();
            this.labelsize = new System.Windows.Forms.Label();
            this.radioButtonnormal = new System.Windows.Forms.RadioButton();
            this.radioButtonjumbo = new System.Windows.Forms.RadioButton();
            this.buttonbuy = new System.Windows.Forms.Button();
            this.buttoncheckout = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelbev = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelbev.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bu Dewi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITEMS";
            // 
            // listBoxfnb
            // 
            this.listBoxfnb.FormattingEnabled = true;
            this.listBoxfnb.Location = new System.Drawing.Point(22, 91);
            this.listBoxfnb.Name = "listBoxfnb";
            this.listBoxfnb.Size = new System.Drawing.Size(164, 225);
            this.listBoxfnb.TabIndex = 2;
            // 
            // listBoxprice
            // 
            this.listBoxprice.FormattingEnabled = true;
            this.listBoxprice.Location = new System.Drawing.Point(198, 91);
            this.listBoxprice.Name = "listBoxprice";
            this.listBoxprice.Size = new System.Drawing.Size(142, 225);
            this.listBoxprice.TabIndex = 3;
            // 
            // radioButtonfood
            // 
            this.radioButtonfood.AutoSize = true;
            this.radioButtonfood.Location = new System.Drawing.Point(5, 13);
            this.radioButtonfood.Name = "radioButtonfood";
            this.radioButtonfood.Size = new System.Drawing.Size(70, 17);
            this.radioButtonfood.TabIndex = 4;
            this.radioButtonfood.TabStop = true;
            this.radioButtonfood.Text = "Makanan";
            this.radioButtonfood.UseVisualStyleBackColor = true;
            this.radioButtonfood.CheckedChanged += new System.EventHandler(this.radioButtonfood_CheckedChanged);
            // 
            // radioButtonBev
            // 
            this.radioButtonBev.AutoSize = true;
            this.radioButtonBev.Location = new System.Drawing.Point(98, 13);
            this.radioButtonBev.Name = "radioButtonBev";
            this.radioButtonBev.Size = new System.Drawing.Size(68, 17);
            this.radioButtonBev.TabIndex = 5;
            this.radioButtonBev.TabStop = true;
            this.radioButtonBev.Text = "Minuman";
            this.radioButtonBev.UseVisualStyleBackColor = true;
            this.radioButtonBev.CheckedChanged += new System.EventHandler(this.radioButtonBev_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Menu";
            // 
            // comboBoxfnb
            // 
            this.comboBoxfnb.FormattingEnabled = true;
            this.comboBoxfnb.Location = new System.Drawing.Point(461, 124);
            this.comboBoxfnb.Name = "comboBoxfnb";
            this.comboBoxfnb.Size = new System.Drawing.Size(159, 21);
            this.comboBoxfnb.TabIndex = 7;
            this.comboBoxfnb.SelectedIndexChanged += new System.EventHandler(this.comboBoxfnb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Harga:";
            // 
            // labelprc
            // 
            this.labelprc.AutoSize = true;
            this.labelprc.Location = new System.Drawing.Point(687, 127);
            this.labelprc.Name = "labelprc";
            this.labelprc.Size = new System.Drawing.Size(13, 13);
            this.labelprc.TabIndex = 9;
            this.labelprc.Text = "0";
            this.labelprc.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelsize
            // 
            this.labelsize.AutoSize = true;
            this.labelsize.Location = new System.Drawing.Point(4, 12);
            this.labelsize.Name = "labelsize";
            this.labelsize.Size = new System.Drawing.Size(30, 13);
            this.labelsize.TabIndex = 10;
            this.labelsize.Text = "Size:";
            // 
            // radioButtonnormal
            // 
            this.radioButtonnormal.AutoSize = true;
            this.radioButtonnormal.Location = new System.Drawing.Point(7, 37);
            this.radioButtonnormal.Name = "radioButtonnormal";
            this.radioButtonnormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonnormal.TabIndex = 11;
            this.radioButtonnormal.TabStop = true;
            this.radioButtonnormal.Text = "Normal";
            this.radioButtonnormal.UseVisualStyleBackColor = true;
            this.radioButtonnormal.CheckedChanged += new System.EventHandler(this.radioButtonnormal_CheckedChanged);
            // 
            // radioButtonjumbo
            // 
            this.radioButtonjumbo.AutoSize = true;
            this.radioButtonjumbo.Location = new System.Drawing.Point(111, 37);
            this.radioButtonjumbo.Name = "radioButtonjumbo";
            this.radioButtonjumbo.Size = new System.Drawing.Size(56, 17);
            this.radioButtonjumbo.TabIndex = 12;
            this.radioButtonjumbo.TabStop = true;
            this.radioButtonjumbo.Text = "Jumbo";
            this.radioButtonjumbo.UseVisualStyleBackColor = true;
            this.radioButtonjumbo.CheckedChanged += new System.EventHandler(this.radioButtonjumbo_CheckedChanged);
            // 
            // buttonbuy
            // 
            this.buttonbuy.Location = new System.Drawing.Point(410, 247);
            this.buttonbuy.Name = "buttonbuy";
            this.buttonbuy.Size = new System.Drawing.Size(133, 47);
            this.buttonbuy.TabIndex = 13;
            this.buttonbuy.Text = "Buy";
            this.buttonbuy.UseVisualStyleBackColor = true;
            this.buttonbuy.Click += new System.EventHandler(this.buttonbuy_Click);
            // 
            // buttoncheckout
            // 
            this.buttoncheckout.Location = new System.Drawing.Point(626, 326);
            this.buttoncheckout.Name = "buttoncheckout";
            this.buttoncheckout.Size = new System.Drawing.Size(141, 58);
            this.buttoncheckout.TabIndex = 14;
            this.buttoncheckout.Text = "Check Out";
            this.buttoncheckout.UseVisualStyleBackColor = true;
            this.buttoncheckout.Click += new System.EventHandler(this.buttoncheckout_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Enabled = false;
            this.buttondelete.Location = new System.Drawing.Point(150, 326);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(86, 23);
            this.buttondelete.TabIndex = 15;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonfood);
            this.panel1.Controls.Add(this.radioButtonBev);
            this.panel1.Location = new System.Drawing.Point(410, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 40);
            this.panel1.TabIndex = 16;
            // 
            // panelbev
            // 
            this.panelbev.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelbev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelbev.Controls.Add(this.labelsize);
            this.panelbev.Controls.Add(this.radioButtonnormal);
            this.panelbev.Controls.Add(this.radioButtonjumbo);
            this.panelbev.Location = new System.Drawing.Point(413, 160);
            this.panelbev.Name = "panelbev";
            this.panelbev.Size = new System.Drawing.Size(200, 69);
            this.panelbev.TabIndex = 17;
            this.panelbev.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 396);
            this.Controls.Add(this.panelbev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttoncheckout);
            this.Controls.Add(this.buttonbuy);
            this.Controls.Add(this.labelprc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxfnb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxprice);
            this.Controls.Add(this.listBoxfnb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelbev.ResumeLayout(false);
            this.panelbev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxfnb;
        private System.Windows.Forms.ListBox listBoxprice;
        private System.Windows.Forms.RadioButton radioButtonfood;
        private System.Windows.Forms.RadioButton radioButtonBev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxfnb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelprc;
        private System.Windows.Forms.Label labelsize;
        private System.Windows.Forms.RadioButton radioButtonnormal;
        private System.Windows.Forms.RadioButton radioButtonjumbo;
        private System.Windows.Forms.Button buttonbuy;
        private System.Windows.Forms.Button buttoncheckout;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelbev;
    }
}

