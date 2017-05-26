using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.IO;

//Decrypt MSIL injector malware: d220c54b2c844776a9e832ef2fd6421b0960b8ba

namespace MSIL_Injector_Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string[] BUyCleVKRdwNdc6BUyCleVKRdwNdc7()
        {
            return new string[]
            {
                "艾吉诶屁西屁哦克",
                "斯开勒德艾贼艾",
                "哦贝豆马维西吾提吾迪伊西哦艾马艾",
                "迪儿伊尺迪伊艾艾比诶吾屁豆比马儿儿",
                "弗艾艾勒尔伊尔丝迪艾",
                "贝尔比艾吉艾伊",
                "杰杰哦屁维弗尺伊",
                "贼吾德贝哦丝艾艾吉开维儿弗吾豆伊诶迪马吾开",
                "艾丝迪豆提艾斯艾艾屁儿吉",
                "艾开吾豆西吾艾豆伊勒迪迪艾",
                "杰艾杰伊贼马杰西开弗维比艾",
                "儿艾弗斯艾艾艾贝尺马哦维",
                "尺伊维诶迪艾伊",
                "娜吾艾艾艾艾西吾艾尔贼",
                "吉迪吾吾豆西豆比艾屁艾迪吉艾斯",
                "艾吾屁杰吉艾吾弗尺艾尔比马西迪贼",
                "屁艾吉尔吾伊马提艾艾儿尔吉娜马屁德贼伊吾吉克吾",
                "维克娜吾吉提吉勒吾伊克弗娜艾艾",
                "吾艾维斯开德艾迪伊艾",
                "贼迪娜迪吾吾马艾贝尺尔哦吾吾屁艾尔比",
                "吉尺西开吉德豆斯豆吉艾马弗艾娜尺西儿吾豆吉艾丝",
                "丝维尔吾迪儿伊艾诶勒尺艾马比艾比艾"
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num = Form1.BUyCleVKRdwNdc6BUyCleVKRdwNdc7().Length;
            string[] array = Form1.BUyCleVKRdwNdc6BUyCleVKRdwNdc7();
            //ResourceManager resourceManager = new ResourceManager("hPHoSOmYiRTldYf.resources", Assembly.GetExecutingAssembly());
            int num2 = 0;
            List<byte> list = new List<byte>();
            do
            {
                byte[] array2 = (byte[])MSIL_Injector_Decrypt.Properties.Resources.ResourceManager.GetObject(array[num2]);
                for (int i = 0; i < array2.Length - 1; i++)
                {
                    list.Add((byte)(array2[i] ^ 26));
                }
                num2++;
            }
            while (num2 < num);

            byte[] buffer = list.ToArray();
            FileStream fs = new FileStream("payload.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(buffer);
            bw.Close();
            fs.Close();
            MessageBox.Show("Decrypted file: payload.bin", "Decrypted!");
            this.Close();
            //Assembly assembly = Assembly.Load(list.ToArray());
            //assembly.EntryPoint.Invoke(null, new object[0]);

        }
    }
}
