using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Business_Logic;

namespace DekanatPro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Gistogram();
        }
        public void Gistogram()
        {
            int kol = 0;
            List<string> specialityName = new List<string>() { Logic.students[0].Speciality };
            for (int i = 0; i < Logic.students.Count; i++)
            {
                int kolName = 0;
                for (int j = 0; j < specialityName.Count; j++)
                {
                    if (Logic.students[i].Speciality == specialityName[j]) kolName++;
                }
                if (kolName == 0) specialityName.Add(Logic.students[i].Speciality);
            }
            for (int i = 0; i < specialityName.Count; i++)
            {
                for (int j = 0; j < Logic.students.Count; j++)
                {
                    if (specialityName[i] == Logic.students[j].Speciality) kol++;
                }
                chart1.Series.Add(specialityName[i]);
                chart1.Series[i].Points.AddY(kol);
                kol = 0;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
