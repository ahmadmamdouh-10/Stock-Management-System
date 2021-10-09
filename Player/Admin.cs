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
            StockServices = Repository.StockServices;
            CategoryServices = Repository.CategoryServices;
            ItemServices = Repository.ItemServices;
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
            if (txtStockName.Text.Length != 0)
            {
                if (StockServices.AddStock(new Stock() { Name = txtStockName.Text }) != 0)
                    StockGridView.DataSource = StockServices.GetStocks();
                else
                    MessageBox.Show("this Stock already Exist");
            }

        }
        #endregion

        #region Category Tab
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtNameCategory.Text.Length != 0)
            {
                if(CategoryServices.AddCategory(new Category(){Name = txtNameCategory.Text }) != 0)
                {
                    CategoryGridView.DataSource = CategoryServices.GetAllCategories();
                    cmbCategory.DataSource = CategoryServices.GetAllCategories();
                }
                else
                MessageBox.Show("this Category already Exist");

            }

        }
        #endregion

        #region Item Tab
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string item_name = txtItemName.Text;

            if (item_name.Length != 0)
            {
                int cat_id = (int)cmbCategory.SelectedValue;

              if(  ItemServices.AddItem(new Item(){ Name = item_name, Cat_ID = cat_id}) !=0 )
                ItemGridView.DataSource = ItemServices.GetAllItemsByCatID((int?)cmbCategory.SelectedValue);
              else
                    MessageBox.Show("this  Item already Exist");

            }
        }
        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex != -1)
            {
                ItemGridView.DataSource = ItemServices.GetAllItemsByCatID((int)cmbCategory.SelectedValue);
            }
        }
        #endregion

        private void btnImportExportForm_Click(object sender, EventArgs e)
        {
            new ImportAndExport().ShowDialog();
        }






    }
}
