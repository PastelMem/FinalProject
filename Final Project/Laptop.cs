using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    internal class Laptop_MSI_KATANA17 : Computer_device
    {
        public Laptop_MSI_KATANA17()
        {
            Screen_Size = "17.3 inch";
            Processor = "Intel Core i7-13620H";
            Display = "FHD 1920x1080 @144Hz IPS-Level";
            Memory = "16GB";
            Storage = "512GB SSD M.2";
            Graphics = "NVIDIA  GeForce RTX 4050 Laptop";
            Weight = "2.6 Kg";
            price = 42990;
            picture = Properties.Resources.msi_katana;
            
        }
    }

    internal class Asus_TUF_Gaming_F15 : Computer_device
    {
        public Asus_TUF_Gaming_F15()
        {
            Screen_Size = "15.6 inch";
            Processor = "Intel Core i5";
            Display = "FHD (1920 x 1080) 16:9";
            Memory = "8GB";
            Storage = "512GB SSD M.2";
            Graphics = "NVIDIA GeForce RTX 2050 Laptop";
            Weight = "2.30 Kg.";
            price = 22990;
            picture = Properties.Resources.Tuf_gaming;
        }

    }
    internal class Gigabyte_G7 : Computer_device
    {
        public Gigabyte_G7()
        {
            Screen_Size = "17.3 inch";
            Processor = "Intel Core i5";
            Display = "FHD 1920x1080  144Hz";
            Memory = "8GB";
            Storage = "512GB SSD M.2";
            Graphics = "NVIDIA GeForce RTX 3050 Laptop";
            Weight = "2.4 kg.";
            price = 27990;
            picture = Properties.Resources.giga;
        }

    }
    internal class Asus_ROG_Strix_G16 : Computer_device
    {
        public Asus_ROG_Strix_G16()
        {
            Screen_Size = "16.0 inch";
            Processor = "Intel Core i7";
            Display = "FHD+ 1920x1200 WUXGA 16:10";
            Memory = "16GB";
            Storage = "1TB SSD M.2";
            Graphics = "NVIDIA GeForce RTX 4050 Laptop";
            Weight = "2.50 Kg";
            price = 49990;
            picture = Properties.Resources.rog_strix;

        }

    }
    internal class Gigabyte_AERO_16_OLED5 : Computer_device
    {
        public Gigabyte_AERO_16_OLED5()
        {
            Screen_Size = "16.0 inch";
            Processor = "Intel Core i7";
            Display = "UHD+ 3840x2400 @60Hz 4K 16:10  OLED HDR Display (DCI-P3 100%) Thin Bezel Display";
            Memory = "16GB";
            Storage = "1TB SSD M.2";
            Graphics = "NVIDIA GeForce RTX 4060 Laptop";
            Weight = "2.1 Kg";
            price = 59990;
            picture = Properties.Resources.aero;
        }


    }
    internal class Asus_ROG_Strix_G16_G614JVR : Computer_device
    {
        public Asus_ROG_Strix_G16_G614JVR()
        {
            Screen_Size = "16.0 inch";
            Processor = "Intel Core i9";
            Display = "WQXGA 2560x1600 @240Hz IPS 16:10 100% DCI-P3 G-Sync Anti-glare display";
            Memory = "16GB";
            Storage = "1TB SSD M.2";
            Graphics = "NVIDIA GeForce RTX 4060 Laptop";
            Weight = "2.50 Kg";
            price = 69990;
            picture = Properties.Resources.rog_2;
        }

        internal class MSI_Bravo_15B7ED_013TH : Computer_device
        {
            public MSI_Bravo_15B7ED_013TH()
            {
                Screen_Size = "15.6 นิ้ว Full HD 1920 x 1080 ";
                Processor = "AMD Ryzen 5 7535HS";
                Display = "FHD 1920x1080 @144Hz IPS 45%NTSC";
                Memory = "8GB";
                Storage = "512GB SSD M.2";
                Graphics = "AMD Radeon RX 6000 Series";
                Weight = "2.35 Kg";
                price = 20990;
                picture = Properties.Resources.msi_bravo;
            }
        }
        internal class Acer_ConceptD_3_CN316_73G_551S : Computer_device
        {
            public Acer_ConceptD_3_CN316_73G_551S()
            {
                Screen_Size = "16. 1920x1200 (WUXGA)";
                Processor = "Intel Core i5-11400H (2.7GHz Up to 4.5GHz 12MB Intel Smart Cache)";
                Display = "IPS 60Hz sRGB100%";
                Memory = "8GB DDR4 Onboard memory";
                Storage = "512GB PCIe NVMe M.2 SSD";
                Graphics = "NVIDIA GeForce RTX 3050 Ti (4GB GDDR6)";
                Weight = "t1.70 KG";
                price = 47990;
                picture = Properties.Resources.CONCEPTD;
            }
        }
        internal class Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey : Computer_device
        {
            public Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey()
            {
                Screen_Size = "15.6 inch";
                Processor = "Intel Core i5";
                Display = "WQHD (2560x1440) IPS 300nits Anti-glare 100% sRGB 165Hz Dolby Vision G-SYNC";
                Memory = "16GB";
                Storage = "512GB SSD M.2";
                Graphics = "NVIDIA GeForce RTX 3060 Laptop";
                Weight = "2.40 Kg.";
                price = 55990;
                picture = Properties.Resources.lenovo;
            }
        }
    }
}
