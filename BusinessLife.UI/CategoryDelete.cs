using BusinessLife.BLL;
using BusinessLife.DAL;
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
    public partial class CategoryDelete : Form
    {
        int deleteId = 0;
        public CategoryDelete(int Id)
        {
            deleteId = Id;
            InitializeComponent();
        }
        CategoryRepository repo = new CategoryRepository();
        private void CategoryDelete_Load(object sender, EventArgs e)
        {
            Category c = repo.SelectById(deleteId);
            txtCategoryName.Text = c.CategoryName;
            rchDescription.Text = c.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silmek ister misin", 
                    "Silinecek Bak",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.ServiceNotification);

            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Silmekten Vazgeçtin yine iyisin");
            }
            else
            {
              bool result =  repo.DeleteCategory(deleteId);
                if (result) MessageBox.Show("Silindi");
                else MessageBox.Show("Sorun var");
            }
        }
    }
}
