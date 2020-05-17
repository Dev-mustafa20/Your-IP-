using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.AccessControl;


namespace Your_IP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string hostname = string.Empty;
            hostname = Dns.GetHostName();
            tx_namepc.Text = hostname;

          
           
        
           
            /// Get ip 
            IPHostEntry ipEntry = Dns.GetHostEntry(hostname); 
            IPAddress[] addr = ipEntry.AddressList;   

            for (int i = 0; i < addr.Length; i++)
            {
                tx_ip .Text  = addr[i].ToString(); 
            }
            textBox1.Text = tx_ip.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = tx_ip.Text;
        }
    }
}
