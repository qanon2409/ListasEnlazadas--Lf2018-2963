using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseAlg275
{
    public partial class Form1 : Form
    {
        LinkedList<string> nomEstud = new LinkedList<string>();
        string a,b;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = txt1.Text;
            nomEstud.Remove(a);
            txt1.Clear();
            listBox1.Items.Remove(a);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a=txt1.Text;
            nomEstud.AddLast(a);
            txt1.Clear();
            listBox1.Items.Add(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var b1 = txt2.Text;
            var b2 = nomEstud.Find(b1);
            var b3 = nomEstud.Find(nomEstud.First.Value);
            nomEstud.AddBefore(b3, b1);
            nomEstud.Remove(b2);
            listBox1.Items.Clear();

            foreach (var z in nomEstud)
            {
                listBox1.Items.Add(z);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var b1 = txt2.Text;
            var b2 = nomEstud.Find(b1);
            var b3 = nomEstud.Find(nomEstud.Last.Value);
            nomEstud.AddAfter(b3, b1);
            nomEstud.Remove(b2);
            listBox1.Items.Clear();

            foreach (var z in nomEstud)
            {
                listBox1.Items.Add(z);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = txt2.Text;
            nomEstud.Contains(a);
            if(nomEstud.Contains(a))
            {
                DialogResult dialogResult = MessageBox.Show("Usted está en la lista", "Listado", MessageBoxButtons.OK);
                txt2.Clear();
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Usted debe registarse", "Listado", MessageBoxButtons.OK);
                txt2.Clear();
            }
        }
    }
}
