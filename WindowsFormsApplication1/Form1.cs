using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com,587");
            client.Credentials = new System.Net.NetworkCredential("karay0825@gmail.com", "frty-*120");
            client.EnableSsl = true;
            MailMessage mesaj = new MailMessage("karay0825@gmail.com", textBox1.Text);
            mesaj.Body = textBox3.Text;
            mesaj.Subject = textBox2.Text;
            client.Send(mesaj);
        }
    }
}
