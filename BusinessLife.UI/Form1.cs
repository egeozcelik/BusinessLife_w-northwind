using BusinessLife.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLife.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CategoryRepository catRep = new CategoryRepository();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = catRep.GetCategoryList();
        }
    }
}
