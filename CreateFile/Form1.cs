using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFile
{
    public partial class Form1 : Form
    {
        public bool a = true;
        public string headText,columnName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void addcolumn_Click(object sender, EventArgs e)
        {
            if (ParamFile.numberСolumns != 0)
            {
                headText = "Независимая переменная №" + ParamFile.numberСolumns.ToString();
                columnName = "NZav" + ParamFile.numberСolumns.ToString();
                dataGridView1.Columns.Add(columnName, headText);
            }
            else
            {
                dataGridView1.Columns.Add("NZav", "Зависимая переменная");
            }
            ParamFile.numberСolumns++;
        }

        private void deletecolumn_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n))
            {
                ParamFile.numberСolumns = int.Parse(textBox1.Text);
                if (ParamFile.numberСolumns < 2)
                {
                    MessageBox.Show("Введите число, больше 2");
                }
                else
                {
                    dataGridView1.Columns.Add("Zav", "Зависимая переменная");
                    for (int i = 1; i < ParamFile.numberСolumns; i++)
                    {
                        headText = "Независимая переменная №" + i.ToString();
                        columnName = "NZav" + i.ToString();
                        dataGridView1.Columns.Add(columnName,headText);
                    }
                    panel1.Enabled = true;
                    panel2.Enabled = false;
                }
            }           
            else
            {
                textBox1.Clear();
                MessageBox.Show("Введите число, больше 2");
            }          
           
        }
    }
}
