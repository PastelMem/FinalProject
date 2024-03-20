using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final_Project.Asus_ROG_Strix_G16_G614JVR;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Allcom = new List<Computer_device>()
            {
                MSI_KATANA17 , asus_TUF_Gaming_F15 , gigabyte , asus_rog_strix_g16 ,gigabyte_aero_16_oled5 ,asus_rog_strix_g16_g614jvr ,msi_bravo_15b7ed_013th ,lenovo_legion_5i_15iah7h_82rb00q0ta_grey ,acer_conceptd_3_cn316_73g_551s
            };

        }
        private Laptop_MSI_KATANA17 MSI_KATANA17 = new Laptop_MSI_KATANA17();
        private Asus_TUF_Gaming_F15 asus_TUF_Gaming_F15 = new Asus_TUF_Gaming_F15();
        private Gigabyte_G7 gigabyte = new Gigabyte_G7();
        private Asus_ROG_Strix_G16 asus_rog_strix_g16 = new Asus_ROG_Strix_G16();
        private Gigabyte_AERO_16_OLED5 gigabyte_aero_16_oled5 = new Gigabyte_AERO_16_OLED5();
        private Asus_ROG_Strix_G16_G614JVR asus_rog_strix_g16_g614jvr = new Asus_ROG_Strix_G16_G614JVR();
        private MSI_Bravo_15B7ED_013TH msi_bravo_15b7ed_013th = new MSI_Bravo_15B7ED_013TH();
        private Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey lenovo_legion_5i_15iah7h_82rb00q0ta_grey = new Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey();
        private Acer_ConceptD_3_CN316_73G_551S acer_conceptd_3_cn316_73g_551s = new Acer_ConceptD_3_CN316_73G_551S();


        private int index;
        private List<Computer_device> Allcom = new List<Computer_device>();
        private CSV CsvWriter = new CSV();
        private List<string> LabtopList = new List<string>  
        {
            "Laptop_MSI_KATANA17",
            "Asus_TUF_Gaming_F15",
            "Gigabyte_G7",
            "Asus_ROG_Strix_G16",
            "Gigabyte_AERO_16_OLED5",
            "Asus_ROG_Strix_G16_G614JVR",
            "MSI_Bravo_15B7ED_013TH",
            "Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey",
            "Acer_ConceptD_3_CN316_73G_551S",
            "Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey"
        };
        private void GetIndex()
        {
            index = LabtopList.IndexOf(UserCombobox.Text);
        }

        

        private void Search_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = asus_rog_strix_g16.picture;
            GetIndex();

            pictureBox1.Image = Allcom[index].picture;

            label1.Text = Allcom[index].Screen_Size;
            label2.Text = Allcom[index].Processor;
            label3.Text = Allcom[index].Display;
            label4.Text = Allcom[index].Memory;
            label5.Text = Allcom[index].Storage;
            label6.Text = Allcom[index].Graphics;
            label8.Text = Allcom[index].Weight;
            label7.Text = Allcom[index].price.ToString();

        }

        private void CSVBTN_Click(object sender, EventArgs e)
        {
            bool csvWrite = CsvWriter.Savetofile(label1.Text , label2.Text , label3.Text , label4.Text , label5.Text , label6.Text , label8.Text , label7.Text);
            if (csvWrite)
            {
                MessageBox.Show("เขียนไฟล์สำเร็จ");
            }
            else
            {
                MessageBox.Show("เขียนไฟล์ไม่สำเร็จ");
            }
        }
    }
}
