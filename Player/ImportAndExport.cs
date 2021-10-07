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
            StockServices = new StockServices();
            CategoryServices = new CategoryServices();
            ItemServices = new ItemServices();
            ItemInStockServices = new ItemInStockServices();
            FillComponents();
        }
        // fill all components for the first time
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
            ImportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbImportStock.SelectedValue,tabPage1.Text);
            ImportGridView.Columns[0].Visible = false;
            ImportGridView.Columns[1].Visible = false;

            /// Export
            cmbExportStock.DisplayMember = "Name";
            cmbExportStock.ValueMember = "ID";
            cmbExportStock.DataSource = StockServices.GetStocks();
            cmbExportCategory.DisplayMember = "Name";
            cmbExportCategory.ValueMember = "ID";
            cmbExportCategory.DataSource = CategoryServices.GetAllCatByStockID((int?)cmbExportStock.SelectedValue,tabPage1.Text);
            cmbExportItem.DisplayMember = "Name";
            cmbExportItem.ValueMember = "ID";
            cmbExportItem.DataSource = ItemServices.GetAllItemsByCatIDandStockID((int?)cmbExportCategory.SelectedValue, (int?)cmbExportStock.SelectedValue);
            ExportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbExportStock.SelectedValue, tabPage2.Text);
            ExportGridView.Columns[0].Visible = false;
            ExportGridView.Columns[1].Visible = false;
            currentQuantity.Value = ItemServices.GetQuantity((int?)cmbExportItem.SelectedValue, (int?)cmbExportStock.SelectedValue);


            ///// Report
            cmbReportStock.DisplayMember = "Name";
            cmbReportStock.ValueMember = "ID";
            cmbReportStock.DataSource = StockServices.GetStocks();
            FillReport((int?)cmbReportStock.SelectedValue);
            dateOfImport.Value = DateTime.Now;
            dateOfExport.Value = DateTime.Now;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateOfImport.Value = DateTime.Now;
            dateOfExport.Value = DateTime.Now;
        }

        #region Import Tab
        private void cmbImportStock_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbImportStock.SelectedIndex != -1)
            {
                ImportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbImportStock.SelectedValue, tabPage1.Text);
            }
        }

        private void cmbImportCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbImportCategory.SelectedIndex != -1)
            {
                cmbImportItem.DisplayMember = "Name";
                cmbImportItem.ValueMember = "ID";
                cmbImportItem.DataSource = ItemServices.GetAllItemsByCatID((int?)cmbImportCategory.SelectedValue);
                FillReport((int?)cmbReportStock.SelectedValue);

            }
            else
            {
                cmbImportItem.Items.Clear();
            }
        }

        private void btnAddImport_Click(object sender, EventArgs e)
        {
            ItemInStockServices.AddItemInStock(
                new ItemInStock()
                {
                    Item_ID = (int)cmbImportItem.SelectedValue,
                    Stock_ID = (int)cmbImportStock.SelectedValue,
                    Quantity = (int)quantityOfImportItems.Value,
                    Date = dateOfImport.Value,
                    Status = tabPage1.Text
                }
                );
            ImportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbImportStock.SelectedValue, tabPage1.Text);
            FillReport((int?)cmbReportStock.SelectedValue);
        }

        private void btnSaveImport_Click(object sender, EventArgs e)
        {
            int itemInStockID = (int)ImportGridView.SelectedRows[0].Cells[0].Value;
            ItemInStockServices.EditItemInStock(itemInStockID, (int)quantityOfImportItems.Value, dateOfImport.Value);
            ImportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbImportStock.SelectedValue, tabPage1.Text);
            FillReport((int?)cmbReportStock.SelectedValue);
        }

        private void btnDeleteImport_Click(object sender, EventArgs e)
        {
            int iteminstockid = (int)ImportGridView.SelectedRows[0].Cells[0].Value;
            ItemInStockServices.DeleteItemInStock(iteminstockid);
            ImportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbImportStock.SelectedValue, tabPage1.Text);

        }

        private void ImportGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ImportGridView.SelectedRows.Count > 0)
            {
                int item_id = (int)ImportGridView.SelectedRows[0].Cells[1].Value;
                int cat_id = ItemServices.GetCatID(item_id);
                cmbImportItem.SelectedValue = item_id;
                cmbImportCategory.SelectedValue = cat_id;
                decimal res;
                decimal.TryParse(ImportGridView.SelectedRows[0].Cells[4].Value.ToString(), out res);
                quantityOfImportItems.Value = res;
                dateOfImport.Value = (DateTime)ImportGridView.SelectedRows[0].Cells[5].Value;
            }
        }

        #endregion

        #region Export Tab
        private void cmbExportStock_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbExportStock.SelectedIndex != -1)
            {
                ExportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbExportStock.SelectedValue, tabPage2.Text);
                cmbExportCategory.DisplayMember = "Name";
                cmbExportCategory.ValueMember = "ID";
                cmbExportCategory.DataSource = CategoryServices.GetAllCatByStockID((int?)cmbExportStock.SelectedValue, tabPage1.Text);
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
                currentQuantity.Value = ItemServices.GetQuantity((int?)cmbExportItem.SelectedValue, (int?)cmbExportStock.SelectedValue);
            }
        }

        private void btnExportAdd_Click(object sender, EventArgs e)
        {
            if ((int)quantity.Value > (int)currentQuantity.Value)
            {
                MessageBox.Show("This Quantity Is Not Available Right Now", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ItemInStockServices.AddItemInStock(
                    new ItemInStock()
                    {
                        Item_ID = (int)cmbExportItem.SelectedValue,
                        Stock_ID = (int)cmbExportStock.SelectedValue,
                        Quantity = (int)quantity.Value,
                        Date = dateOfExport.Value,
                        Status = tabPage2.Text
                    }
                    );
                ExportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbExportStock.SelectedValue, tabPage2.Text);
                FillReport((int?)cmbReportStock.SelectedValue);
            }
        }

        private void btnExportSave_Click(object sender, EventArgs e)
        {
            if ((int)quantity.Value > (int)currentQuantity.Value)
            {
                MessageBox.Show("This Quantity Is Not Available Right Now", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int iteminstockid = (int)ExportGridView.SelectedRows[0].Cells[0].Value;
                int qunatity = (int)quantity.Value;
                DateTime date = dateOfExport.Value;
                ItemInStockServices.EditItemInStock(iteminstockid, qunatity, date);
                ExportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbExportStock.SelectedValue, tabPage2.Text);
                FillReport((int?)cmbReportStock.SelectedValue);
            }
        }

        private void btnExportDelete_Click(object sender, EventArgs e)
        {
            int iteminstockid = (int)ExportGridView.SelectedRows[0].Cells[0].Value;
            ItemInStockServices.DeleteItemInStock(iteminstockid);
            ExportGridView.DataSource = ItemInStockServices.GetAllItemInStock((int?)cmbExportStock.SelectedValue, tabPage2.Text);
        }

        private void ExportGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ExportGridView.SelectedRows.Count > 0)
            {
                int item_id = (int)ExportGridView.SelectedRows[0].Cells[1].Value;
                int cat_id = ItemServices.GetCatID(item_id);
                cmbExportItem.SelectedValue = item_id;
                cmbExportCategory.SelectedValue = cat_id;
                decimal res;
                decimal.TryParse(ExportGridView.SelectedRows[0].Cells[4].Value.ToString(), out res);
                quantity.Value = res;
                dateOfExport.Value = (DateTime)ExportGridView.SelectedRows[0].Cells[5].Value;
            }
        }
        #endregion

        #region Report
        private void cmbReportStock_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbReportStock.SelectedIndex != -1)
            {
                FillReport((int)cmbReportStock.SelectedValue);
            }
        }

        //// fill the data gird view contains report
        public void FillReport(int? stock_id)
        {
            ReportGridView.Rows.Clear();
            foreach (Item item in ItemInStockServices.GetAllItemInStock(stock_id))
            {
                ReportGridView.Rows.Add(item.Name, item.Category.Name, ItemServices.GetQuantity(item.ID, stock_id));
            }

        }
        #endregion
    }
}
