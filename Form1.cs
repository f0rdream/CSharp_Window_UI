using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Window_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetGrid();
            AmountStu();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownuber = gv.CurrentCell.RowIndex;
            textBox7.Text =gv.Rows[rownuber].Cells[0].Value.ToString();
            textBox8.Text = gv.Rows[rownuber].Cells[1].Value.ToString();
            textBox10.Text = gv.Rows[rownuber].Cells[2].Value.ToString();
            textBox6.Text = gv.Rows[rownuber].Cells[3].Value.ToString();
            textBox5.Text = gv.Rows[rownuber].Cells[4].Value.ToString();
            textBox12.Text = gv.Rows[rownuber].Cells[5].Value.ToString();
            textBox11.Text = gv.Rows[rownuber].Cells[6].Value.ToString();
            textBox9.Text = gv.Rows[rownuber].Cells[7].Value.ToString();
            textBox16.Text = gv.Rows[rownuber].Cells[8].Value.ToString();
            textBox15.Text = gv.Rows[rownuber].Cells[9].Value.ToString();
            textBox14.Text = gv.Rows[rownuber].Cells[10].Value.ToString();
            textBox13.Text = gv.Rows[rownuber].Cells[11].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
//            if (textBox5.Text == "" || textBox8.Text == "")
//            {
//                MessageBox.Show("学生姓名和学号为必填项");
//                return;
//            }
//            else
//            {
//                Student Mystu = new Student(textBox5.Text, (decimal)textBox8.Text, textBox6.Text);
//            }
            
        }
        private void SetGrid()
        {
            var query = GetXMLData();

            gv.DataSource = query;
            


//            DataSet dsRule = new DataSet();
//            XmlDocument xmlDoc = new XmlDocument();
//            xmlDoc.Load("./data.xml");
//            XmlNodeList xWitsTableList = xmlDoc.SelectNodes("/Students");
//            foreach(XmlNode node2 in xOrach)
        }
        private List<Student> GetXMLData()
        {
            var xDoc = XDocument.Load("./data.xml");
            var query = (from student in xDoc.Descendants("Student")
                         select new Student()
                         {
                             ID = Convert.ToInt64(student.Element("ID").Value),
                             Name = student.Element("Name").Value,
                             Gender = student.Element("Gender").Value,                     
                             StuClass = student.Element("Class").Value,                           
                             School = student.Element("School").Value,
                             Region = student.Element("Region").Value,
                             Type = student.Element("Type").Value,
                             Health = student.Element("Health").Value,
                             IDCard = Convert.ToInt64(student.Element("IDCard").Value),
                             StuDate = Convert.ToDateTime(student.Element("Date").Value),
                             PostNum = Convert.ToInt64(student.Element("PostNum").Value),
                             PhoneNum = Convert.ToInt64(student.Element("Phone").Value)
                         }).ToList();
            return query;
        }

        private void AmountStu()
        {
            int stuNum = gv.RowCount;
            int boyNum = 0;
            for (int i = 0; i < stuNum; i++)
            {
                if (Convert.ToString(gv.Rows[i].Cells[2].Value) == "Male")
                {
                    boyNum++;
                }
            }
            int girlNum = stuNum - boyNum;

            textBox17.Text = Convert.ToString(stuNum);
            textBox19.Text = Convert.ToString(boyNum);
            textBox18.Text = Convert.ToString(girlNum);
        }

        private void AddDoc()
        {
            
        }

        private void Search()
        {
            
        }
    }
}
