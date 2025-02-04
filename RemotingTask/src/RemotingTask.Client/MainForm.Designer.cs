using System;

namespace RemotingTask.Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.addProduct_tabPage = new System.Windows.Forms.TabPage();
            this.addProductResponse_label = new System.Windows.Forms.Label();
            this.productPrice_label = new System.Windows.Forms.Label();
            this.productName_label = new System.Windows.Forms.Label();
            this.productPrice_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productName_textBox = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.ProductList_tabPage = new System.Windows.Forms.TabPage();
            this.deleteResponse_label = new System.Windows.Forms.Label();
            this.deleteProduct_button = new System.Windows.Forms.Button();
            this.productList_dataGridView = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productUpdate_tabPage = new System.Windows.Forms.TabPage();
            this.updateResponse_label = new System.Windows.Forms.Label();
            this.updatePrice_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.updatePrice_label = new System.Windows.Forms.Label();
            this.updateName_label = new System.Windows.Forms.Label();
            this.selectProduct_Label = new System.Windows.Forms.Label();
            this.update_textbox = new System.Windows.Forms.TextBox();
            this.update_comboBox = new System.Windows.Forms.ComboBox();
            this.update_button = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.addProduct_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPrice_numericUpDown)).BeginInit();
            this.ProductList_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.productUpdate_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatePrice_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addProduct_tabPage);
            this.tabControl.Controls.Add(this.ProductList_tabPage);
            this.tabControl.Controls.Add(this.productUpdate_tabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 426);
            this.tabControl.TabIndex = 0;
            // 
            // addProduct_tabPage
            // 
            this.addProduct_tabPage.Controls.Add(this.addProductResponse_label);
            this.addProduct_tabPage.Controls.Add(this.productPrice_label);
            this.addProduct_tabPage.Controls.Add(this.productName_label);
            this.addProduct_tabPage.Controls.Add(this.productPrice_numericUpDown);
            this.addProduct_tabPage.Controls.Add(this.productName_textBox);
            this.addProduct_tabPage.Controls.Add(this.send_button);
            this.addProduct_tabPage.Location = new System.Drawing.Point(4, 25);
            this.addProduct_tabPage.Name = "addProduct_tabPage";
            this.addProduct_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addProduct_tabPage.Size = new System.Drawing.Size(780, 397);
            this.addProduct_tabPage.TabIndex = 0;
            this.addProduct_tabPage.Text = "Ürün Ekleme";
            this.addProduct_tabPage.UseVisualStyleBackColor = true;
            // 
            // addProductResponse_label
            // 
            this.addProductResponse_label.AutoSize = true;
            this.addProductResponse_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProductResponse_label.Location = new System.Drawing.Point(242, 275);
            this.addProductResponse_label.Name = "addProductResponse_label";
            this.addProductResponse_label.Size = new System.Drawing.Size(251, 22);
            this.addProductResponse_label.TabIndex = 5;
            this.addProductResponse_label.Text = "ÜRÜN KAYDETME CEVAP";
            this.addProductResponse_label.Visible = false;
            // 
            // productPrice_label
            // 
            this.productPrice_label.AutoSize = true;
            this.productPrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productPrice_label.Location = new System.Drawing.Point(256, 124);
            this.productPrice_label.Name = "productPrice_label";
            this.productPrice_label.Size = new System.Drawing.Size(116, 25);
            this.productPrice_label.TabIndex = 4;
            this.productPrice_label.Text = "Ürün Fiyatı";
            // 
            // productName_label
            // 
            this.productName_label.AutoSize = true;
            this.productName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productName_label.Location = new System.Drawing.Point(255, 41);
            this.productName_label.Name = "productName_label";
            this.productName_label.Size = new System.Drawing.Size(108, 25);
            this.productName_label.TabIndex = 3;
            this.productName_label.Text = "Ürün İsimi";
            // 
            // productPrice_numericUpDown
            // 
            this.productPrice_numericUpDown.DecimalPlaces = 1;
            this.productPrice_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productPrice_numericUpDown.Location = new System.Drawing.Point(261, 152);
            this.productPrice_numericUpDown.Name = "productPrice_numericUpDown";
            this.productPrice_numericUpDown.Size = new System.Drawing.Size(232, 28);
            this.productPrice_numericUpDown.TabIndex = 2;
            // 
            // productName_textBox
            // 
            this.productName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productName_textBox.HideSelection = false;
            this.productName_textBox.Location = new System.Drawing.Point(260, 69);
            this.productName_textBox.Name = "productName_textBox";
            this.productName_textBox.Size = new System.Drawing.Size(233, 28);
            this.productName_textBox.TabIndex = 1;
            // 
            // send_button
            // 
            this.send_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.send_button.Location = new System.Drawing.Point(320, 202);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(97, 38);
            this.send_button.TabIndex = 0;
            this.send_button.Text = "Kaydet";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // ProductList_tabPage
            // 
            this.ProductList_tabPage.Controls.Add(this.deleteResponse_label);
            this.ProductList_tabPage.Controls.Add(this.deleteProduct_button);
            this.ProductList_tabPage.Controls.Add(this.productList_dataGridView);
            this.ProductList_tabPage.Location = new System.Drawing.Point(4, 25);
            this.ProductList_tabPage.Name = "ProductList_tabPage";
            this.ProductList_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductList_tabPage.Size = new System.Drawing.Size(780, 397);
            this.ProductList_tabPage.TabIndex = 1;
            this.ProductList_tabPage.Text = "Ürün Listesi";
            this.ProductList_tabPage.UseVisualStyleBackColor = true;
            // 
            // deleteResponse_label
            // 
            this.deleteResponse_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteResponse_label.Location = new System.Drawing.Point(293, 276);
            this.deleteResponse_label.Name = "deleteResponse_label";
            this.deleteResponse_label.Size = new System.Drawing.Size(201, 22);
            this.deleteResponse_label.TabIndex = 6;
            this.deleteResponse_label.Text = "ÜRÜN SİLME CEVAP";
            this.deleteResponse_label.Visible = false;
            // 
            // deleteProduct_button
            // 
            this.deleteProduct_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteProduct_button.Location = new System.Drawing.Point(452, 33);
            this.deleteProduct_button.Name = "deleteProduct_button";
            this.deleteProduct_button.Size = new System.Drawing.Size(162, 37);
            this.deleteProduct_button.TabIndex = 1;
            this.deleteProduct_button.Text = "Ürünü Sil";
            this.deleteProduct_button.UseVisualStyleBackColor = true;
            this.deleteProduct_button.Click += new System.EventHandler(this.deleteProduct_button_Click);
            // 
            // productList_dataGridView
            // 
            this.productList_dataGridView.AllowUserToAddRows = false;
            this.productList_dataGridView.AllowUserToDeleteRows = false;
            this.productList_dataGridView.AutoGenerateColumns = false;
            this.productList_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productList_dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.productList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.productList_dataGridView.DataSource = this.productBindingSource;
            this.productList_dataGridView.Location = new System.Drawing.Point(114, 76);
            this.productList_dataGridView.MultiSelect = false;
            this.productList_dataGridView.Name = "productList_dataGridView";
            this.productList_dataGridView.RowHeadersWidth = 51;
            this.productList_dataGridView.RowTemplate.Height = 24;
            this.productList_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productList_dataGridView.Size = new System.Drawing.Size(500, 160);
            this.productList_dataGridView.TabIndex = 0;
            this.productList_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_dataGridView_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(RemotingTask.RemoteObjects.Product);
            // 
            // productUpdate_tabPage
            // 
            this.productUpdate_tabPage.Controls.Add(this.updateResponse_label);
            this.productUpdate_tabPage.Controls.Add(this.updatePrice_numericUpDown);
            this.productUpdate_tabPage.Controls.Add(this.updatePrice_label);
            this.productUpdate_tabPage.Controls.Add(this.updateName_label);
            this.productUpdate_tabPage.Controls.Add(this.selectProduct_Label);
            this.productUpdate_tabPage.Controls.Add(this.update_textbox);
            this.productUpdate_tabPage.Controls.Add(this.update_comboBox);
            this.productUpdate_tabPage.Controls.Add(this.update_button);
            this.productUpdate_tabPage.Location = new System.Drawing.Point(4, 25);
            this.productUpdate_tabPage.Name = "productUpdate_tabPage";
            this.productUpdate_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productUpdate_tabPage.Size = new System.Drawing.Size(780, 397);
            this.productUpdate_tabPage.TabIndex = 2;
            this.productUpdate_tabPage.Text = "Ürün Güncelleme";
            this.productUpdate_tabPage.UseVisualStyleBackColor = true;
            this.productUpdate_tabPage.Click += new System.EventHandler(this.productUpdate_tabPage_Click);
            // 
            // updateResponse_label
            // 
            this.updateResponse_label.AutoSize = true;
            this.updateResponse_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateResponse_label.Location = new System.Drawing.Point(242, 305);
            this.updateResponse_label.Name = "updateResponse_label";
            this.updateResponse_label.Size = new System.Drawing.Size(277, 22);
            this.updateResponse_label.TabIndex = 8;
            this.updateResponse_label.Text = "ÜRÜN GÜNCELLEME CEVAP";
            this.updateResponse_label.Visible = false;
            // 
            // updatePrice_numericUpDown
            // 
            this.updatePrice_numericUpDown.DecimalPlaces = 1;
            this.updatePrice_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updatePrice_numericUpDown.Location = new System.Drawing.Point(246, 215);
            this.updatePrice_numericUpDown.Name = "updatePrice_numericUpDown";
            this.updatePrice_numericUpDown.Size = new System.Drawing.Size(232, 28);
            this.updatePrice_numericUpDown.TabIndex = 7;
            // 
            // updatePrice_label
            // 
            this.updatePrice_label.AutoSize = true;
            this.updatePrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updatePrice_label.Location = new System.Drawing.Point(241, 187);
            this.updatePrice_label.Name = "updatePrice_label";
            this.updatePrice_label.Size = new System.Drawing.Size(140, 25);
            this.updatePrice_label.TabIndex = 6;
            this.updatePrice_label.Text = "Ürünün Fiyatı";
            // 
            // updateName_label
            // 
            this.updateName_label.AutoSize = true;
            this.updateName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateName_label.Location = new System.Drawing.Point(241, 113);
            this.updateName_label.Name = "updateName_label";
            this.updateName_label.Size = new System.Drawing.Size(127, 25);
            this.updateName_label.TabIndex = 5;
            this.updateName_label.Text = "Ürünün İsmi";
            // 
            // selectProduct_Label
            // 
            this.selectProduct_Label.AutoSize = true;
            this.selectProduct_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectProduct_Label.Location = new System.Drawing.Point(241, 26);
            this.selectProduct_Label.Name = "selectProduct_Label";
            this.selectProduct_Label.Size = new System.Drawing.Size(135, 25);
            this.selectProduct_Label.TabIndex = 4;
            this.selectProduct_Label.Text = "Ürün Seçiniz";
            // 
            // update_textbox
            // 
            this.update_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_textbox.Location = new System.Drawing.Point(246, 141);
            this.update_textbox.Name = "update_textbox";
            this.update_textbox.Size = new System.Drawing.Size(191, 28);
            this.update_textbox.TabIndex = 2;
            // 
            // update_comboBox
            // 
            this.update_comboBox.DataSource = this.productBindingSource;
            this.update_comboBox.DisplayMember = "Name";
            this.update_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.update_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_comboBox.FormattingEnabled = true;
            this.update_comboBox.Location = new System.Drawing.Point(246, 54);
            this.update_comboBox.Name = "update_comboBox";
            this.update_comboBox.Size = new System.Drawing.Size(191, 30);
            this.update_comboBox.TabIndex = 1;
            this.update_comboBox.SelectedIndexChanged += new System.EventHandler(this.update_comboBox_SelectedIndexChanged);
            // 
            // update_button
            // 
            this.update_button.Enabled = false;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_button.Location = new System.Drawing.Point(276, 258);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(122, 32);
            this.update_button.TabIndex = 0;
            this.update_button.Text = "Güncelle";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "FairTechTask";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.addProduct_tabPage.ResumeLayout(false);
            this.addProduct_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPrice_numericUpDown)).EndInit();
            this.ProductList_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productList_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.productUpdate_tabPage.ResumeLayout(false);
            this.productUpdate_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatePrice_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage addProduct_tabPage;
        private System.Windows.Forms.TabPage ProductList_tabPage;
        private System.Windows.Forms.Label addProductResponse_label;
        private System.Windows.Forms.Label productPrice_label;
        private System.Windows.Forms.Label productName_label;
        private System.Windows.Forms.NumericUpDown productPrice_numericUpDown;
        private System.Windows.Forms.TextBox productName_textBox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.DataGridView productList_dataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button deleteProduct_button;
        private System.Windows.Forms.TabPage productUpdate_tabPage;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ComboBox update_comboBox;
        private System.Windows.Forms.Label updateName_label;
        private System.Windows.Forms.Label selectProduct_Label;
        private System.Windows.Forms.TextBox update_textbox;
        private System.Windows.Forms.Label updatePrice_label;
        private System.Windows.Forms.NumericUpDown updatePrice_numericUpDown;
        private System.Windows.Forms.Label updateResponse_label;
        private System.Windows.Forms.Label deleteResponse_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

