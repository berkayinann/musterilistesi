namespace uygulama___06._10._2023___1
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
            label1 = new Label();
            txtadsoyad = new TextBox();
            txttelefon = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtadres = new TextBox();
            label4 = new Label();
            nudyas = new NumericUpDown();
            btnkaydet = new Button();
            btnlisteyedon = new Button();
            ((System.ComponentModel.ISupportInitialize)nudyas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // txtadsoyad
            // 
            txtadsoyad.Location = new Point(99, 26);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.Size = new Size(120, 23);
            txtadsoyad.TabIndex = 1;
            // 
            // txttelefon
            // 
            txttelefon.Location = new Point(99, 76);
            txttelefon.Name = "txttelefon";
            txttelefon.Size = new Size(120, 23);
            txttelefon.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 79);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 124);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 4;
            label3.Text = "Yaş";
            // 
            // txtadres
            // 
            txtadres.Location = new Point(313, 26);
            txtadres.Multiline = true;
            txtadres.Name = "txtadres";
            txtadres.Size = new Size(120, 98);
            txtadres.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 29);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "Adres";
            // 
            // nudyas
            // 
            nudyas.Location = new Point(99, 122);
            nudyas.Name = "nudyas";
            nudyas.Size = new Size(120, 23);
            nudyas.TabIndex = 8;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(240, 150);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(193, 40);
            btnkaydet.TabIndex = 9;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // btnlisteyedon
            // 
            btnlisteyedon.Location = new Point(240, 202);
            btnlisteyedon.Name = "btnlisteyedon";
            btnlisteyedon.Size = new Size(193, 40);
            btnlisteyedon.TabIndex = 10;
            btnlisteyedon.Text = "Listeye Dön";
            btnlisteyedon.UseVisualStyleBackColor = true;
            btnlisteyedon.Click += btnlisteyedon_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 258);
            Controls.Add(btnlisteyedon);
            Controls.Add(btnkaydet);
            Controls.Add(nudyas);
            Controls.Add(txtadres);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txttelefon);
            Controls.Add(label2);
            Controls.Add(txtadsoyad);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nudyas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtadsoyad;
        private TextBox txttelefon;
        private Label label2;
        private Label label3;
        private TextBox txtadres;
        private Label label4;
        private NumericUpDown nudyas;
        private Button btnkaydet;
        private Button btnlisteyedon;
    }
}