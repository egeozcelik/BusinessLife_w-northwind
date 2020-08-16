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
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }

        CategoryRepository repo = new CategoryRepository();
        private void button1_Click(object sender, EventArgs e)
        {
             Category c = new Category();
            c.CategoryName = txtCategoryName.Text;
            c.Description = rchDescription.Text;
            bool result = repo.InsertCategory(c);

            if (result) MessageBox.Show("Kategori Başarılı Eklendi");
            else MessageBox.Show("Kategori Eklenemedi");
        }

        private void CategoryAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
