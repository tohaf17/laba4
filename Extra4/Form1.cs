using Extra1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SortStudentMarks sortStudentMarks = new SortStudentMarks();
            var list=sortStudentMarks.Main();
            label1.Text = $"{list[0].firstName}";
        }
    }
}
