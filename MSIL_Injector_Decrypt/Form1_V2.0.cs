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


//Decrypt MSIL injector malware: 0190c4ad7e930bd060ac766c23f4bd890c85b916

namespace MSIL_Injector_Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] GTM2l903H()
        {
            return new string[]
			{
				"伊丝比艾艾诶吾艾马艾比伊艾比哦比克伊德吾豆开斯",
				"诶艾西提吾艾开豆儿维艾勒吾杰艾弗娜勒马贼",
				"艾吾马克艾豆艾尺比娜",
				"杰尺比尔西德娜吉艾杰勒伊提西艾尔屁弗诶",
				"吾伊德哦开丝勒提屁",
				"提伊德贝勒开屁艾艾吉斯",
				"吾娜斯艾艾伊克提弗",
				"尺开艾吾马艾提维豆艾吉",
				"娜艾吾勒比迪弗艾吾斯西艾艾艾德吉马豆艾",
				"吉斯诶丝伊艾迪吾艾豆德艾艾艾杰艾吉尺",
				"弗迪维艾弗豆娜维开勒",
				"儿儿艾德提丝儿尔德开勒吉艾吉艾屁艾艾艾维艾",
				"艾克艾儿艾艾克伊贼娜维提维比西艾艾艾维",
				"娜丝娜艾吾艾维艾豆艾杰吾维艾",
				"艾艾艾马提哦提吉斯艾比吉尔豆比马艾维德",
				"维伊马吉艾提尺艾吾",
				"尺尺维维杰艾豆伊豆艾贼斯艾马克斯贼艾吾艾比维迪",
				"马吉吾杰丝贝维马贼哦斯开马尔艾杰艾比马比艾艾",
				"德德艾迪开德迪德维吾",
				"艾艾维艾艾艾伊吉娜吾吾艾艾伊尔",
				"吾吾艾丝艾丝吉迪艾艾屁吉贝比娜艾伊艾豆丝克弗",
				"艾西贝艾艾勒艾屁儿弗伊艾艾艾儿艾迪"
			};
        }

        public static string wUuYyOJswkhFGuP1wUuYyOJswkhFGuP2 = "";
        public static byte[] tJHCUMgDZPB2tJHCUMgDZPB3 = new byte[122880];
        public static int tJHCUMgDZPB4tJHCUMgDZPB5 = 0;

        public int AIFPfQXpYYspV(int len)
        {
            return len - 1;
        }

        public byte IPPXqs1()
        {
            byte[] array = dGdM3xh8lPTWw((byte[])MSIL_Injector_Decrypt.Properties.Resources.ResourceManager.GetObject(Form1.wUuYyOJswkhFGuP1wUuYyOJswkhFGuP2));
            Buffer.BlockCopy(array, 0, tJHCUMgDZPB2tJHCUMgDZPB3, tJHCUMgDZPB4tJHCUMgDZPB5, AIFPfQXpYYspV(array.Length));
            Form1.tJHCUMgDZPB4tJHCUMgDZPB5 += AIFPfQXpYYspV(array.Length);
            return 32;
        }

        private byte[] dGdM3xh8lPTWw(byte[] eQXnHKMfMd4cRJEsBTLKEUCPYP4)
		{
			for (int i = 0; i < eQXnHKMfMd4cRJEsBTLKEUCPYP4.Length; i++)
			{
				eQXnHKMfMd4cRJEsBTLKEUCPYP4[i] ^= 30;
			}
			return eQXnHKMfMd4cRJEsBTLKEUCPYP4;
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] array = GTM2l903H();
            for (int i = 0; i < array.Length; i++)
            {
                string text = array[i];
                Form1.wUuYyOJswkhFGuP1wUuYyOJswkhFGuP2 = text;
                IPPXqs1();
            }

            //tJHCUMgDZPB2tJHCUMgDZPB3
            FileStream fs = new FileStream("payload.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(tJHCUMgDZPB2tJHCUMgDZPB3);
            bw.Close();
            fs.Close();
            MessageBox.Show("Decrypted file: payload.bin", "Decrypted!");
            this.Close();
        }
    }
}
