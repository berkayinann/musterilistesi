namespace uygulama___06._10._2023___1
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
            listcustomer = new ListBox();
            btnnewcustomer = new Button();
            SuspendLayout();
            // 
            // listcustomer
            // 
            listcustomer.FormattingEnabled = true;
            listcustomer.ItemHeight = 15;
            listcustomer.Location = new Point(12, 12);
            listcustomer.Name = "listcustomer";
            listcustomer.Size = new Size(219, 229);
            listcustomer.TabIndex = 0;
            listcustomer.SelectedIndexChanged += lstMusteriListesi_SelectedIndexChanged;
            // 
            // btnnewcustomer
            // 
            btnnewcustomer.Location = new Point(259, 200);
            btnnewcustomer.Name = "btnnewcustomer";
            btnnewcustomer.Size = new Size(219, 40);
            btnnewcustomer.TabIndex = 1;
            btnnewcustomer.Text = "Yeni Müşteri Ekle";
            btnnewcustomer.UseVisualStyleBackColor = true;
            btnnewcustomer.Click += btnnewcustomer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 252);
            Controls.Add(btnnewcustomer);
            Controls.Add(listcustomer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listcustomer;
        private Button btnnewcustomer;
    }
}