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
    public partial class CategoryUpdate : Form
    {
        int requestId = 0;
        public CategoryUpdate(int Id)
        {
            requestId = Id;
            InitializeComponent();
        }
        CategoryRepository repo = new CategoryRepository();
        private void CategoryUpdate_Load(object sender, EventArgs e)
        {
            Category c = repo.SelectById(requestId);
            txtCategoryName.Text = c.CategoryName;
            rchDescription.Text = c.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category updateCategory = new Category();
            updateCategory.CategoryID = requestId;
            updateCategory.CategoryName = txtCategoryName.Text;
            updateCategory.Description = rchDescription.Text;
            bool result = repo.UpdateCategory(updateCategory);

            if (result) MessageBox.Show("Kategori Güncellendi");
            else MessageBox.Show("Kategori Güncellenemedi");

        }
    }
}
