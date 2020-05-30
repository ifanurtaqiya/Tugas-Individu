namespace form_ekspedisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtberat = new System.Windows.Forms.TextBox();
            this.txttanggal = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.provinsibox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbiayaperkg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BERAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROVINSI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TANGGAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL";
            // 
            // txtberat
            // 
            this.txtberat.Location = new System.Drawing.Point(112, 29);
            this.txtberat.Name = "txtberat";
            this.txtberat.Size = new System.Drawing.Size(153, 20);
            this.txtberat.TabIndex = 4;
            // 
            // txttanggal
            // 
            this.txttanggal.Location = new System.Drawing.Point(112, 103);
            this.txttanggal.Name = "txttanggal";
            this.txttanggal.Size = new System.Drawing.Size(153, 20);
            this.txttanggal.TabIndex = 5;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(112, 143);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(220, 89);
            this.txttotal.TabIndex = 6;
            // 
            // provinsibox
            // 
            this.provinsibox.FormattingEnabled = true;
            this.provinsibox.Items.AddRange(new object[] {
            "JAWA",
            "BALI",
            "SUMATERA",
            "KALIMANTAN",
            "SULAWESI",
            "PAPUA"});
            this.provinsibox.Location = new System.Drawing.Point(112, 65);
            this.provinsibox.Name = "provinsibox";
            this.provinsibox.Size = new System.Drawing.Size(152, 21);
            this.provinsibox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "HITUNG";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "RISET";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtbiayaperkg
            // 
            this.txtbiayaperkg.Location = new System.Drawing.Point(282, 29);
            this.txtbiayaperkg.Name = "txtbiayaperkg";
            this.txtbiayaperkg.Size = new System.Drawing.Size(69, 20);
            this.txtbiayaperkg.TabIndex = 10;
            this.txtbiayaperkg.Text = "15000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "BIAYA PE KG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 368);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbiayaperkg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.provinsibox);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txttanggal);
            this.Controls.Add(this.txtberat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtberat;
        private System.Windows.Forms.TextBox txttanggal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox provinsibox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbiayaperkg;
        private System.Windows.Forms.Label label5;
    }
}

