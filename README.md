
ความเป็นมาของโปรแกรม
ปัญหาเลือกโน้ตบุ๊กมาใช้งานไม่ได้
วัตถุประสงค์ของโปรแกรม
แนะนำโน้ตบุ๊กมาให้เลือกดูแบบคร่าวๆ
โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown

```mermaid
classDiagram
   class Form1 {
        
        -CSV CsvWriter
        -List<string> LaptopList
        -int index
        +Form1()
        +void GetIndex()
        +void Search_Click(sender: object, e: EventArgs)
        +void CSVBTN_Click(sender: object, e: EventArgs)
    }

    class Computer_device {
        <<abstract>>
        -string Screen_Size
        -string Processor
        -string Display
        -string Memory
        -string Storage
        -string Graphics
        -string Weight
        -double price
        +Image picture
    }

    class Laptop_MSI_KATANA17 {
        -Image picture
    }

    class Asus_TUF_Gaming_F15 {
        -Image picture
    }

    class Gigabyte_G7 {
        -Image picture
    }

    class Asus_ROG_Strix_G16 {
        -Image picture
    }

    class Gigabyte_AERO_16_OLED5 {
        -Image picture
    }

    class Asus_ROG_Strix_G16_G614JVR {
        -Image picture
    }

    class MSI_Bravo_15B7ED_013TH {
        -Image picture
    }

    class Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey {
        -Image picture
    }

    class Acer_ConceptD_3_CN316_73G_551S {
        -Image picture
    }

    class CSV {
        +bool Savefile(string screensize , string processor , string display , string memory , string storage, string graphics , string weight , string price)
    }
    CSV --  Form1
    Form1 -- Computer_device
    Computer_device <|-- Laptop_MSI_KATANA17
    Computer_device <|-- Asus_TUF_Gaming_F15
    Computer_device <|-- Gigabyte_G7
    Computer_device <|-- Asus_ROG_Strix_G16
    Computer_device <|-- Gigabyte_AERO_16_OLED5
    Computer_device <|-- Asus_ROG_Strix_G16_G614JVR
    Computer_device <|-- MSI_Bravo_15B7ED_013TH
    Computer_device <|-- Lenovo_Legion_5i_15IAH7H_82RB00Q0TA_Grey
    Computer_device <|-- Acer_ConceptD_3_CN316_73G_551S
    
```
ชื่อของผู้พัฒนาโปรแกรม 
นายกีรติ สุวรรณภูสิทธิ์ 663450172-5
tomtimflow@gmail.com
