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
    public partial class ImportAndExport : Form
    {
        StockServices StockServices;
        CategoryServices CategoryServices;
        ItemServices ItemServices;
        ItemInStockServices ItemInStockServices;
        public ImportAndExport()
        {
            InitializeComponent();
            StockServices = Repository.StockServices;
            CategoryServices = Repository.CategoryServices;
            ItemServices = Repository.ItemServices;
            ItemInStockServices = Repository.ItemInStockServices;
            FillComponents();
        }

        #region Fill comopnents 
        void FillComponents()
        {
            // Import
            cmbImportStock.DisplayMember = "Name";
            cmbImportStock.ValueMember = "ID";
            cmbImportStock.DataSource = StockServices.GetStocks();
            cmbImportCategory.DisplayMember = "Name";
            cmbImportCategory.ValueMember = "ID";
            cmbImportCategory.DataSource = CategoryServices.GetAllCategories();
            cmbImportItem.DisplayMember = "Name";
            cmbImportItem.ValueMember = "ID";
            cmbImportItem.DataSource = ItemServices.GetAllItemsByCatID((int?)cmbImportCategory.SelectedValue);
            ImportGridView.DataSource = ItemInStockServices.GetImportedItems((int)cmbImportStock.SelectedValue);

            /// Export
            cmbExportStock.DisplayMember = "Name";
            cmbExportStock.ValueMember = "ID";
            cmbExportStock.DataSource = StockServices.GetStocks();
            cmbExportCategory.DisplayMember = "Name";
            cmbExportCategory.ValueMember = "ID";
            cmbExportCategory.DataSource = CategoryServices.GetAllCatByStockID((int?)cmbExportStock.SelectedValue);
            cmbExportItem.DisplayMember = "Name";
            cmbExportItem.ValueMember = "ID";
            cmbExportItem.DataSource = ItemServices.GetAllItemsByCatIDandStockID((int?)cmbExportCategory.SelectedValue, (int?)cmbExportStock.SelectedValue);
            ExportGridView.DataSource = ItemInStockServices.GetExportedItems((int)cmbExportStock.SelectedValue);
            currentQuantity.Value = ItemInStockServices.GetQuantity((int?)cmbExportItem.SelectedValue, (int?)cmbExportStock.SelectedValue);


            ///// Report
            cmbReportStock.DisplayMember = "Name";
            cmbReportStock.ValueMember = "ID";
            cmbReportStock.DataSource = StockServices.GetStocks();
            ReportGridView.DataSource = ItemInStockServices.GetReportItems((int)cmbReportStock.SelectedValue);
            dateOfImport.Value = DateTime.Now;
            dateOfExport.Value = DateTime.Now;
        }

        #endregion

        #region Import Tab
        private void cmbImportStock_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbImportStock.SelectedIndex != -1)
            {
                ImportGridView.DataSource = ItemInStockServices.GetImportedItems((int)cmbImportStock.SelectedValue);
            }
        }
        private void cmbImportCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbImportCategory.SelectedIndex != -1)
            {
                cmbImportItem.DisplayMember = "Name";
                cmbImportItem.ValueMember = "ID";
                cmbImportItem.DataSource = ItemServices.GetAllItemsByCatID((int?)cmbImportCategory.SelectedValue);

            }
            else
            {
                cmbImportItem.Items.Clear();
            }
        }
        private void btnAddImport_Click(object sender, EventArgs e)
        {
            if ((int)quantityOfImportItems.Value > 0)
            {
                ItemInStockServices.ImportItem(
                    new ImportItem()
                    {
                        Item_ID = (int)cmbImportItem.SelectedValue,
                        Stock_ID = (int)cmbImportStock.SelectedValue,
                        quantity = (int)quantityOfImportItems.Value,
                        Date = DateTime.Now
                    }
                    );
                ReFeresh();
            }
        }
        #endregion

        #region Export Tab
        private void cmbExportStock_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbExportStock.SelectedIndex != -1)
            {
                ExportGridView.DataSource = ItemInStockServices.GetExportedItems((int)cmbExportStock.SelectedValue);
                cmbExportCategory.DisplayMember = "Name";
                cmbExportCategory.ValueMember = "ID";
                cmbExportCategory.DataSource = CategoryServices.GetAllCatByStockID((int?)cmbExportStock.SelectedValue);
                cmbExportItem.DisplayMember = "Name";
                cmbExportItem.ValueMember = "ID";
                cmbExportItem.DataSource = ItemServices.GetAllItemsByCatIDandStockID((int?)cmbExportCategory.SelectedValue, (int?)cmbExportStock.SelectedValue);
            }
        }
        private void cmbExportCategory_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbExportCategory.SelectedIndex != -1)
            {
                cmbExportItem.DisplayMember = "Name";
                cmbExportItem.ValueMember = "ID";
                cmbExportItem.DataSource = ItemServices.GetAllItemsByCatIDandStockID((int?)cmbExportCategory.SelectedValue, (int?)cmbExportStock.SelectedValue);
            }
        }
        private void cmbExportItem_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbExportItem.SelectedIndex != -1)
            {
                currentQuantity.Value = ItemInStockServices.GetQuantity((int?)cmbExportItem.SelectedValue, (int?)cmbExportStock.SelectedValue);
            }
        }
        private void btnExportAdd_Click(object sender, EventArgs e)
        {
            if ((int)quantity.Value > (int)currentQuantity.Value)
            {
                MessageBox.Show("This Quantity Is Not Available Right Now", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((int)quantity.Value > 0)
            {
                ItemInStockServices.ExportItem(
                    new ExportItem()
                    {
                        Item_ID = (int)cmbExportItem.SelectedValue,
                        Stock_ID = (int)cmbExportStock.SelectedValue,
                        quantity = (int)quantity.Value,
                        Date = DateTime.Now
                    }
                    );
                ReFeresh();
            }
        }
        #endregion
        #region Report
        private void cmbReportStock_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbReportStock.SelectedIndex != -1)
            {
                ReportGridView.DataSource = ItemInStockServices.GetReportItems((int)cmbReportStock.SelectedValue);
            }
        }
        #endregion
        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateOfImport.Value = DateTime.Now;
            dateOfExport.Value = DateTime.Now;
        }
        #endregion
        #region Refresh
        private void ReFeresh()
        {
            ReportGridView.DataSource = ItemInStockServices.GetReportItems((int)cmbReportStock.SelectedValue);
            ExportGridView.DataSource = ItemInStockServices.GetExportedItems((int)cmbExportStock.SelectedValue);
            cmbExportItem.DataSource = ItemServices.GetAllItemsByCatIDandStockID((int?)cmbExportCategory.SelectedValue, (int?)cmbExportStock.SelectedValue);
            ImportGridView.DataSource = ItemInStockServices.GetImportedItems((int)cmbImportStock.SelectedValue);

            currentQuantity.Value = ItemInStockServices.GetQuantity((int)cmbExportItem.SelectedValue, (int)cmbExportStock.SelectedValue);

            //currentQuantity.Value = ItemServices.GetQuantity((int)cmbExportItem.SelectedValue, (int)cmbExportStock.SelectedValue);


        }
        #endregion

    }
}
