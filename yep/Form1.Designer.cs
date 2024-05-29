namespace yep
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewCategories = new DataGridView();
            dataGridViewProducts = new DataGridView();
            Button1 = new Button();
            categoryBindingSource = new BindingSource(components);
            productsBindingSource = new BindingSource(components);
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridViewCategories.DataSource = categoryBindingSource;
            dataGridViewCategories.Location = new Point(66, 121);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowTemplate.Height = 25;
            dataGridViewCategories.Size = new Size(240, 150);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, categoryIdDataGridViewTextBoxColumn1, categoryDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = productsBindingSource;
            dataGridViewProducts.Location = new Point(408, 121);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.Size = new Size(240, 150);
            dataGridViewProducts.TabIndex = 1;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            // 
            // Button1
            // 
            Button1.Location = new Point(573, 309);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 2;
            Button1.Text = "Save";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Save_Click;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(GetStartedWinForms.Category);
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = categoryBindingSource;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // categoryIdDataGridViewTextBoxColumn1
            // 
            categoryIdDataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn1.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn1.Name = "categoryIdDataGridViewTextBoxColumn1";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button1);
            Controls.Add(dataGridViewProducts);
            Controls.Add(dataGridViewCategories);
            Name = "MainForm";
            Text = "Products and Categories";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCategories;
        private DataGridView dataGridViewProducts;
        private Button Button1;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource productsBindingSource;
    }
}
