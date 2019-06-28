using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace rsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static String codes2string(String str)
        {
            StringBuilder text = new StringBuilder();
            Byte[] bytes = new Byte[str.Length / 2];
            for(int i=0;i<str.Length/2;i++)
            {
                String code = str.Substring(2 * i, 2);
                bytes[i] = Byte.Parse(code);
            }
            return ASCIIEncoding.ASCII.GetString(bytes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger E = 12397;
            BigInteger n = 471110543304749;
            BigInteger p = 2432069;
            BigInteger q = 193707721;

            BigInteger phi = (p - 1) * (q - 1);
            BigInteger d = 401452747233253;

            //textBox1.Text = (d * E % phi).ToString();
            textBox2.Text = phi.ToString();
            String[] c_text = "2294003095398 266169040804144 339142294522972 84548923537277 210088832206760 80569577351917".Split(' ');
            StringBuilder text = new StringBuilder();
            StringBuilder c_text_ = new StringBuilder();

            foreach (String c_str in c_text)
            {
                BigInteger c_msg = UInt64.Parse(c_str);
                BigInteger msg = BigInteger.ModPow(c_msg, d, n);
                text.Append(msg.ToString());

                BigInteger c_msg_ = BigInteger.ModPow(msg, E, n);
                c_text_.Append(c_msg.ToString());
            }
            //textBox1.Text = c_text_.ToString();
            textBox1.Text += codes2string(text.ToString());
            ////471110347164960     2294003095398 266169040804144 339142294522972 84548923537277 210088832206760 80569577351917


            ///


            //BigInteger E = 12341;
            //BigInteger n = 565570077646207;
            //BigInteger p = 1546379;
            //BigInteger q = 365738333;

            //BigInteger phi = (p - 1) * (q - 1);
            //BigInteger d = 143672396238821;

            ////textBox1.Text = (d * E % phi).ToString();
            //textBox2.Text = phi.ToString();
            //String[] c_text = "277140870674302 260217431481485 329310844916399 448964498705119".Split(' ');
            //StringBuilder text = new StringBuilder();
            //StringBuilder c_text_ = new StringBuilder();

            //foreach (String c_str in c_text)
            //{
            //    BigInteger c_msg = UInt64.Parse(c_str);
            //    BigInteger msg = BigInteger.ModPow(c_msg, d, n);
            //    text.Append(msg.ToString());

            //    BigInteger c_msg_ = BigInteger.ModPow(msg, E, n);
            //    c_text_.Append(c_msg.ToString());
            //}
            ////textBox1.Text = c_text_.ToString();
            //textBox1.Text += codes2string(text.ToString());


            ///


            //macino
            //BigInteger E = 12977;
            //BigInteger n = 491384118735611;
            //BigInteger p = 2432237;
            //BigInteger q = 202029703;

            //BigInteger phi = (p - 1) * (q - 1);
            //BigInteger d = 4922548266593;

            ////textBox1.Text = (d * E % phi).ToString();
            //textBox2.Text = phi.ToString();
            //String[] c_text = "412511588964999 126415784861983 112099072175421 35696312149225 435919858918651 331990562463068".Split(' ');
            //StringBuilder text = new StringBuilder();
            //StringBuilder c_text_ = new StringBuilder();

            //foreach (String c_str in c_text)
            //{
            //    BigInteger c_msg = UInt64.Parse(c_str);
            //    BigInteger msg = BigInteger.ModPow(c_msg, d, n);
            //    text.Append(msg.ToString());

            //    BigInteger c_msg_ = BigInteger.ModPow(msg, E, n);
            //    c_text_.Append(c_msg.ToString());
            //}
            ////textBox1.Text = c_text_.ToString();
            //textBox1.Text += codes2string(text.ToString());

            //517815408095184  127881381553746 566264841115084 358393515453122 076856198569683 20863251613810
        }
    }
}
