using BusinessLife.BLL;
using BusinessLife.UI.ProductUI;
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

        FactoryBuilder fc = new FactoryBuilder();
        CategoryRepository catRep;
        ProductRepository proRep = new ProductRepository();
        private void Form1_Load(object sender, EventArgs e)
        {
            catRep = (CategoryRepository)fc.createRepositoryInstance(Olusturucu.Category);
            CategoryDatafill();
        }

        private void employeeInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryAdd frm = new CategoryAdd();
            frm.FormClosing += Frm_FormClosing;
            frm.ShowDialog();
            
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CategoryDatafill();
        }

        private void CategoryDatafill()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = catRep.GetCategoryList();
        }

        object updateId;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                updateId = dataGridView1.SelectedRows[0].Cells[0].Value;
            }
        }

        private void kategoriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (updateId == null)
            {
                MessageBox.Show("Lütfen Kategori Seçiniz");
            }
            else
            {
                int id = (int)updateId;
                CategoryUpdate frmUpdate = new CategoryUpdate(id);
                frmUpdate.FormClosing += FrmUpdate_FormClosing;
                frmUpdate.ShowDialog();
            }
        }

        private void FrmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            CategoryDatafill();
        }

        private void kategoriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (updateId == null)
            {
                MessageBox.Show("Lütfen Silmek İçin Kategori Seçiniz");
            }
            else
            {
                int id = (int)updateId;
                CategoryDelete frmDelete = new CategoryDelete(id);
                frmDelete.FormClosing += FrmDelete_FormClosing;
                frmDelete.ShowDialog();
            }
        }

        private void FrmDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            CategoryDatafill();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductAdd frmProd = new ProductAdd();
            frmProd.ShowDialog();
        }

        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDataFill();
        }

        private void ProductDataFill()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = proRep.GetProductList();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void grpCategory_Enter(object sender, EventArgs e)
        {

        }
    }
}
