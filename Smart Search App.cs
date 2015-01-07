using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        ArrayList addressList = new ArrayList();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fileContent = File.ReadAllLines("addressList.txt");

            for (int i = 0; i < fileContent.Length; i++)
            {
                addressList.Add(fileContent[i]);
                outBox.Items.Add(addressList[i].ToString());
            }
        }

        private void inBox_TextChanged(object sender, EventArgs e)
        {
            if (inBox.Text.Equals("")) { outBox.Visible=false;}
            else 
            {
                outBox.Items.Clear();
                for (int i = 0; i < addressList.Count; i++)
                {
                    if (addressList[i].ToString().Substring(0, inBox.Text.Length).Equals(inBox.Text)) 
                    {
                        outBox.Items.Add(addressList[i].ToString());
                    }
                }

                outBox.Visible = true; 
            }
        }

        private void outBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
