namespace Final_Project
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
            this.Search = new System.Windows.Forms.Button();
            this.CSVBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UserCombobox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Search.Location = new System.Drawing.Point(363, 58);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(122, 35);
            this.Search.TabIndex = 1;
            this.Search.Text = "ค้นหา";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CSVBTN
            // 
            this.CSVBTN.Location = new System.Drawing.Point(625, 475);
            this.CSVBTN.Name = "CSVBTN";
            this.CSVBTN.Size = new System.Drawing.Size(108, 34);
            this.CSVBTN.TabIndex = 4;
            this.CSVBTN.Text = "Save Data";
            this.CSVBTN.UseVisualStyleBackColor = true;
            this.CSVBTN.Click += new System.EventHandler(this.CSVBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.spec);
            this.groupBox1.Location = new System.Drawing.Point(470, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 325);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลสเปค";
            // 
            // spec
            // 
            this.spec.AutoSize = true;
            this.spec.Location = new System.Drawing.Point(18, 30);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(37, 16);
            this.spec.TabIndex = 0;
            this.spec.Text = "spec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "      ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "      ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "      ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "      ..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "      ...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "      ...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = " ....  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(606, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 32);
            this.label12.TabIndex = 7;
            this.label12.Text = "แอพแนะนำโน้ตบุก";
            // 
            // UserCombobox
            // 
            this.UserCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.UserCombobox.FormattingEnabled = true;
            this.UserCombobox.Items.AddRange(new object[] {
            "Laptop_MSI_KATANA17",
            "Asus_TUF_Gaming_F15",
            "Gigabyte_G7",
            "Asus_ROG_Strix_G16",
            "Gigabyte_AERO_16_OLED5",
            "Asus_ROG_Strix_G16_G614JVR",
            "MSI_Bravo_15B7ED_013TH",
            "Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey",
            "Acer_ConceptD_3_CN316_73G_551S",
            "Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey",
            "",
            "",
            "",
            ""});
            this.UserCombobox.Location = new System.Drawing.Point(64, 62);
            this.UserCombobox.Name = "UserCombobox";
            this.UserCombobox.Size = new System.Drawing.Size(278, 28);
            this.UserCombobox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "      ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 571);
            this.Controls.Add(this.UserCombobox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CSVBTN);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button CSVBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label spec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox UserCombobox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label8;
    }
}

