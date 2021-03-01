using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogList
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetList_Click(object sender, EventArgs e)
        {
            
            StreamReader streamReader = File.OpenText(@"C:\log\log.txt");
            string logs;
            while((logs=streamReader.ReadLine())!=null)
            {
                ListLog.Items.Add(logs);
            }
            streamReader.Close();


        }
    }
}
