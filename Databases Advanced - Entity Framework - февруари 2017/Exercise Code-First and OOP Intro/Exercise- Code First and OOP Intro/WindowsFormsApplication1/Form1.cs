using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
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

        private void Form1_Load(object sender, EventArgs e)
        {

            using (var context = new Hospital_Database())
            {

                var pat = context.Patients.ToList().Select(x => $"{x.FirstName} {x.LastName}").ToList();
                string output = "";
                foreach (var p in pat)
                {
                    output += $"{p}  \r\n";
                }
                this.textBox1.Text = output;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new Hospital_Database())
            {

                Patient p = new Patient(

                 textBox2.Text,
                 textBox3.Text,
                "Sofia",
                "email@abv.bg",
                "10000000",
                new DateTime(1988, 12, 12),
                false
                );
               
                

                    context.Patients.Add(p);
                    context.SaveChanges();
                
                



                label6.Text = "1 patient Added to the Database";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new Hospital_Database())
            {

                var pat = context.Patients.ToList().OrderByDescending(x=>x.Id).Select(x => $"{x.FirstName} {x.LastName}").ToList();
                string output = "";
                foreach (var p in pat)
                {
                    output += $"{p}  \r\n";
                }
                this.textBox1.Text = output;
            }

        }
    }
}