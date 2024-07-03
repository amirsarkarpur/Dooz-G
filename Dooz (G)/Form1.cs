using System.ComponentModel.DataAnnotations;
using System.Media;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Dooz__G_
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form2().ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            new Form3().ShowDialog();

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

            new Form5().ShowDialog();

            this.Close();

        }
    }
}
