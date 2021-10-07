using BLLayer;
using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Admin : Form
    {
        StockServices StockServices;
        CategoryServices CategoryServices;
        ItemServices ItemServices;
        public Admin()
        {
            InitializeComponent();
            StockServices = new StockServices();
            CategoryServices = new CategoryServices();
            ItemServices = new ItemServices();
            FillComponents();


        }
        void FillComponents()
        {
            StockGridView.DataSource = StockServices.GetStocks();
            CategoryGridView.DataSource = CategoryServices.GetAllCategories();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "ID";
            cmbCategory.DataSource = CategoryServices.GetAllCategories();
            ItemGridView.DataSource = ItemServices.GetAllItemsByCatID((int?)cmbCategory.SelectedValue);
            ItemGridView.Columns[0].Visible = false;
            ItemGridView.Columns[2].Visible = false;
            ItemGridView.Columns[3].Visible = false;
            StockGridView.Columns[0].Visible = false;
            CategoryGridView.Columns[0].Visible = false;
        }
        
      
        #region Stock Tab
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            this.StockServices.AddStock(new Stock() { Name = txtStockName.Text });
            StockGridView.DataSource = StockServices.GetStocks();
        }

        private void btnSaveStock_Click(object sender, EventArgs e)
        {
            StockServices.EditStock(
                (int)StockGridView.SelectedRows[0].Cells[0].Value, txtStockName.Text);
            StockGridView.DataSource = StockServices.GetStocks();
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            StockServices.DeleteStock((int)StockGridView.SelectedRows[0].Cells[0].Value);
            StockGridView.DataSource = StockServices.GetStocks();
        }

        private void StockGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (StockGridView.SelectedRows.Count > 0)
            {
                txtNameCategory.Text = StockGridView.SelectedRows[0].Cells[1].Value.ToString();
                int stock_id = (int)StockGridView.SelectedRows[0].Cells[0].Value;
            }
        }

        #endregion

        #region Category Tab
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int cat_id = (int)CategoryGridView.SelectedRows[0].Cells[0].Value;
            CategoryServices.DeleteCategory(cat_id);
            CategoryGridView.DataSource = CategoryServices.GetAllCategories();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            int cat_id = (int)CategoryGridView.SelectedRows[0].Cells[0].Value;
            string catName = txtNameCategory.Text;
            CategoryServices.EditCategory(cat_id, catName);
            CategoryGridView.DataSource = CategoryServices.GetAllCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryServices.AddCategory(new Category()
            {
                Name = txtNameCategory.Text
            });
            CategoryGridView.DataSource = CategoryServices.GetAllCategories();
        }

        private void CategoryGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoryGridView.SelectedRows.Count > 0)
            {
                txtNameCategory.Text = CategoryGridView.SelectedRows[0].Cells[1].Value.ToString();
                int cat_id = (int)CategoryGridView.SelectedRows[0].Cells[0].Value;
            }
        }
        #endregion

        #region Item Tab
        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex != -1)
            {
                ItemGridView.DataSource = ItemServices.GetAllItemsByCatID((int)cmbCategory.SelectedValue);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int item_id = (int)ItemGridView.SelectedRows[0].Cells[0].Value;
            ItemServices.DeleteItem(item_id);
            ItemGridView.DataSource = ItemServices.GetAllItemsByCatID((int?)cmbCategory.SelectedValue);
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            int cat_id = (int)cmbCategory.SelectedValue;
            int item_id = (int)ItemGridView.SelectedRows[0].Cells[0].Value;
            string itemName = txtItemName.Text;
            ItemServices.EditItem(item_id, cat_id);
            ItemServices.EditItem(item_id, itemName);
            ItemGridView.DataSource = ItemServices.GetAllItemsByCatID((int?)cmbCategory.SelectedValue);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string item_name = txtItemName.Text;
            int cat_id = (int)cmbCategory.SelectedValue;
            ItemServices.AddItem(new Item()
            {
                Name = item_name,
                Cat_ID = cat_id
            });
            ItemGridView.DataSource = ItemServices.GetAllItemsByCatID((int?)cmbCategory.SelectedValue);
        }

        private void ItemGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ItemGridView.SelectedRows.Count > 0)
            {
                txtItemName.Text = ItemGridView.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnImportExportForm_Click(object sender, EventArgs e)
        {
            new ImportAndExport().ShowDialog();
        }


        #endregion


    }
}
