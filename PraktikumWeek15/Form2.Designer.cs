
namespace PraktikumWeek15
{
    partial class Form2
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
            this.checkBoxdisc = new System.Windows.Forms.CheckBox();
            this.buttoncalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelsubtot = new System.Windows.Forms.Label();
            this.labeltax = new System.Windows.Forms.Label();
            this.labeldisc = new System.Windows.Forms.Label();
            this.labeltot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxdisc
            // 
            this.checkBoxdisc.AutoSize = true;
            this.checkBoxdisc.Location = new System.Drawing.Point(28, 30);
            this.checkBoxdisc.Name = "checkBoxdisc";
            this.checkBoxdisc.Size = new System.Drawing.Size(68, 17);
            this.checkBoxdisc.TabIndex = 0;
            this.checkBoxdisc.Text = "Discount";
            this.checkBoxdisc.UseVisualStyleBackColor = true;
            this.checkBoxdisc.CheckedChanged += new System.EventHandler(this.checkBoxdisc_CheckedChanged);
            // 
            // buttoncalculate
            // 
            this.buttoncalculate.Location = new System.Drawing.Point(28, 83);
            this.buttoncalculate.Name = "buttoncalculate";
            this.buttoncalculate.Size = new System.Drawing.Size(92, 31);
            this.buttoncalculate.TabIndex = 1;
            this.buttoncalculate.Text = "Calculate";
            this.buttoncalculate.UseVisualStyleBackColor = true;
            this.buttoncalculate.Click += new System.EventHandler(this.buttoncalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total";
            // 
            // labelsubtot
            // 
            this.labelsubtot.AutoSize = true;
            this.labelsubtot.Location = new System.Drawing.Point(312, 30);
            this.labelsubtot.Name = "labelsubtot";
            this.labelsubtot.Size = new System.Drawing.Size(13, 13);
            this.labelsubtot.TabIndex = 6;
            this.labelsubtot.Text = "0";
            // 
            // labeltax
            // 
            this.labeltax.AutoSize = true;
            this.labeltax.Location = new System.Drawing.Point(312, 60);
            this.labeltax.Name = "labeltax";
            this.labeltax.Size = new System.Drawing.Size(13, 13);
            this.labeltax.TabIndex = 7;
            this.labeltax.Text = "0";
            // 
            // labeldisc
            // 
            this.labeldisc.AutoSize = true;
            this.labeldisc.Location = new System.Drawing.Point(312, 92);
            this.labeldisc.Name = "labeldisc";
            this.labeldisc.Size = new System.Drawing.Size(13, 13);
            this.labeldisc.TabIndex = 8;
            this.labeldisc.Text = "0";
            // 
            // labeltot
            // 
            this.labeltot.AutoSize = true;
            this.labeltot.Location = new System.Drawing.Point(312, 122);
            this.labeltot.Name = "labeltot";
            this.labeltot.Size = new System.Drawing.Size(13, 13);
            this.labeltot.TabIndex = 9;
            this.labeltot.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeltot);
            this.Controls.Add(this.labeldisc);
            this.Controls.Add(this.labeltax);
            this.Controls.Add(this.labelsubtot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoncalculate);
            this.Controls.Add(this.checkBoxdisc);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxdisc;
        private System.Windows.Forms.Button buttoncalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelsubtot;
        private System.Windows.Forms.Label labeltax;
        private System.Windows.Forms.Label labeldisc;
        private System.Windows.Forms.Label labeltot;
    }
}