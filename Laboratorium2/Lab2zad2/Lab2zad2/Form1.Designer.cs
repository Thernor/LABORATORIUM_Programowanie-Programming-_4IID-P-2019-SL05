
namespace Lab2zad2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad6 = new System.Windows.Forms.RadioButton();
            this.rad5 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad9 = new System.Windows.Forms.RadioButton();
            this.rad8 = new System.Windows.Forms.RadioButton();
            this.rad7 = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(12, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(95, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Podaj tekst";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 23);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad3);
            this.groupBox1.Controls.Add(this.rad2);
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkość";
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(6, 73);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(90, 19);
            this.rad3.TabIndex = 2;
            this.rad3.TabStop = true;
            this.rad3.Text = "Bardzo dużo";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(6, 48);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(51, 19);
            this.rad2.TabIndex = 1;
            this.rad2.TabStop = true;
            this.rad2.Text = "Duża";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(7, 23);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(51, 19);
            this.rad1.TabIndex = 0;
            this.rad1.TabStop = true;
            this.rad1.Text = "Mała";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad6);
            this.groupBox2.Controls.Add(this.rad5);
            this.groupBox2.Controls.Add(this.rad4);
            this.groupBox2.Location = new System.Drawing.Point(134, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl czcionki";
            // 
            // rad6
            // 
            this.rad6.AutoSize = true;
            this.rad6.Location = new System.Drawing.Point(6, 72);
            this.rad6.Name = "rad6";
            this.rad6.Size = new System.Drawing.Size(92, 19);
            this.rad6.TabIndex = 7;
            this.rad6.TabStop = true;
            this.rad6.Text = "Podkreślenie";
            this.rad6.UseVisualStyleBackColor = true;
            // 
            // rad5
            // 
            this.rad5.AutoSize = true;
            this.rad5.Location = new System.Drawing.Point(6, 47);
            this.rad5.Name = "rad5";
            this.rad5.Size = new System.Drawing.Size(83, 19);
            this.rad5.TabIndex = 6;
            this.rad5.TabStop = true;
            this.rad5.Text = "Pochylenie";
            this.rad5.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(6, 22);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(89, 19);
            this.rad4.TabIndex = 5;
            this.rad4.TabStop = true;
            this.rad4.Text = "Pogrubienie";
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad9);
            this.groupBox3.Controls.Add(this.rad8);
            this.groupBox3.Controls.Add(this.rad7);
            this.groupBox3.Location = new System.Drawing.Point(262, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor czcionki";
            // 
            // rad9
            // 
            this.rad9.AutoSize = true;
            this.rad9.Location = new System.Drawing.Point(6, 72);
            this.rad9.Name = "rad9";
            this.rad9.Size = new System.Drawing.Size(106, 19);
            this.rad9.TabIndex = 3;
            this.rad9.TabStop = true;
            this.rad9.Text = "Pomarańczowy";
            this.rad9.UseVisualStyleBackColor = true;
            // 
            // rad8
            // 
            this.rad8.AutoSize = true;
            this.rad8.Location = new System.Drawing.Point(6, 47);
            this.rad8.Name = "rad8";
            this.rad8.Size = new System.Drawing.Size(73, 19);
            this.rad8.TabIndex = 2;
            this.rad8.TabStop = true;
            this.rad8.Text = "Niebieski";
            this.rad8.UseVisualStyleBackColor = true;
            // 
            // rad7
            // 
            this.rad7.AutoSize = true;
            this.rad7.Location = new System.Drawing.Point(6, 22);
            this.rad7.Name = "rad7";
            this.rad7.Size = new System.Drawing.Size(77, 19);
            this.rad7.TabIndex = 1;
            this.rad7.TabStop = true;
            this.rad7.Text = "Czerwony";
            this.rad7.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 163);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(365, 37);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "AKTUALIZUJ";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 214);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad6;
        private System.Windows.Forms.RadioButton rad5;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad9;
        private System.Windows.Forms.RadioButton rad8;
        private System.Windows.Forms.RadioButton rad7;
        private System.Windows.Forms.Button btn1;
    }
}

