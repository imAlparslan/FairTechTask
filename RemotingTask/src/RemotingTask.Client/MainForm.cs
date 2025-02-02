using RemotingTask.RemoteObjects;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using System.Windows.Forms;

namespace RemotingTask.Client
{
    public partial class MainForm : Form
    {
        private IProductService _productService;
        private List<Product> _products;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // conf dosyasından okunacak
            TcpClientChannel tcpClient = new TcpClientChannel();
            ChannelServices.RegisterChannel(tcpClient, false);
            _productService = (IProductService)Activator.GetObject(typeof(IProductService), "tcp://localhost:1234/ProductService");
            SetProductList();

        }
        private void send_button_Click(object sender, EventArgs e)
        {
            var name = productName_textBox.Text;
            var price = productPrice_numericUpDown.Value;
            var result = _productService.AddProduct(name, price);
            addProductResponse_label.Visible = true;
            addProductResponse_label.Text = result;

            SetProductList();

        }

        private void productList_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var row = productList_dataGridView.Rows[e.RowIndex];
                var id = (int)row.Cells[0].Value;
                _productService.DeleteProduct(id);
                SetProductList();
            }
        }


        private void deleteProduct_button_Click(object sender, EventArgs e)
        {
            var rowSelected = productList_dataGridView
                .SelectedRows.Count > 0;

            if(rowSelected)
            {
                var cell = productList_dataGridView
               .SelectedRows[0].Cells[0];
                if (cell != null)
                {
                    var result = _productService.DeleteProduct((int)cell.Value);
                    deleteResponse_label.Text = result;
                    deleteResponse_label.Visible = true;
                    SetProductList();
                }
            }

           
        }
        private void SetProductList()
        {
            _products = _productService.GetAllProducts();

            update_comboBox.DataSource = _products;
            productList_dataGridView.DataSource = _products;

            if(_products.Count > 0)
            {
                update_comboBox.Enabled = true;
                deleteProduct_button.Enabled = true;
            }
            else
            {
                update_comboBox.Enabled = false;
                update_button.Enabled = false;
                update_textbox.Text = "";
                update_textbox.Enabled = false;
                updatePrice_numericUpDown.Value = 0;
                updatePrice_numericUpDown.Enabled = false;
                deleteProduct_button.Enabled = false;
            }
        }


        private void update_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Product)update_comboBox.SelectedItem;
            if (item != null)
            {
                update_textbox.Text = item.Name;
                updatePrice_numericUpDown.Value = item.Price;
                update_textbox.Enabled = true;
                updatePrice_numericUpDown.Enabled = true;
                update_button.Enabled = true;
            }

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            var item = ((Product)update_comboBox.SelectedItem);
            if (item != null)
            {
                var id = item.Id;
                var name = update_textbox.Text;
                var price = updatePrice_numericUpDown.Value;
                var result = _productService.UpdateProduct(id, name, price);
                updateResponse_label.Text = result;
                updateResponse_label.Visible = true;
                SetProductList();
            }

        }

        private void productUpdate_tabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
