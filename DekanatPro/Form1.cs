using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using Business_Logic;
using Model;

namespace DekanatPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshLi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Logic.AddStudent(name: form2.textBox1.Text, speciality: form2.textBox2.Text, group: form2.textBox3.Text);
            RefreshLi();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void RefreshLi()
        {
            listView1.Clear();

            listView1.View = View.Details;

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("ФИО", 100);
            listView1.Columns.Add("Cпециальность", 150);
            listView1.Columns.Add("Группа", 150);

            for (int i = 0; i < Logic.GetAll().Count(); i++)

            {

                ListViewItem newitem = new ListViewItem(Convert.ToString(i));
                newitem.SubItems.Add(Convert.ToString(Logic.GetAll().ElementAt(i)[0]));
                newitem.SubItems.Add(Convert.ToString(Logic.GetAll().ElementAt(i)[1]));
                newitem.SubItems.Add(Convert.ToString(Logic.GetAll().ElementAt(i)[2]));


                listView1.Items.Add(newitem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textBox1.Text);
                Logic.DeleteStudent(Id);
                RefreshLi();
                textBox1.Clear();
            } catch(FormatException)
            {
                MessageBox.Show("Error");
            } catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Нет студента с таким ID");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
