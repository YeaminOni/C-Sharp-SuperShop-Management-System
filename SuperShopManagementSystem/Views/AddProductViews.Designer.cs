namespace SuperShopManagementSystem.Views
{
    partial class AddProductViews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductViews));
            this.dataGridViewAllProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductQuantaty = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelCatagory = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.labelPasseord = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllProducts
            // 
            this.dataGridViewAllProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllProducts.Location = new System.Drawing.Point(539, 132);
            this.dataGridViewAllProducts.Name = "dataGridViewAllProducts";
            this.dataGridViewAllProducts.Size = new System.Drawing.Size(478, 368);
            this.dataGridViewAllProducts.TabIndex = 40;
            this.dataGridViewAllProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pro);
            this.dataGridViewAllProducts.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.RowChanged);
            this.dataGridViewAllProducts.SelectionChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Manager Dashboard ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Green;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(20, 40);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(141, 41);
            this.buttonHome.TabIndex = 38;
            this.buttonHome.Text = "Back";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.Lime;
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddProduct.Location = new System.Drawing.Point(342, 383);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(143, 33);
            this.buttonAddProduct.TabIndex = 37;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(172, 311);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(313, 28);
            this.comboBoxCategory.TabIndex = 36;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductPrice.Location = new System.Drawing.Point(172, 234);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(319, 26);
            this.textBoxProductPrice.TabIndex = 33;
            // 
            // textBoxProductQuantaty
            // 
            this.textBoxProductQuantaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductQuantaty.Location = new System.Drawing.Point(171, 270);
            this.textBoxProductQuantaty.Name = "textBoxProductQuantaty";
            this.textBoxProductQuantaty.Size = new System.Drawing.Size(319, 26);
            this.textBoxProductQuantaty.TabIndex = 32;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(172, 195);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(319, 26);
            this.textBoxProductName.TabIndex = 31;
            // 
            // labelCatagory
            // 
            this.labelCatagory.AutoSize = true;
            this.labelCatagory.BackColor = System.Drawing.Color.White;
            this.labelCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatagory.ForeColor = System.Drawing.Color.Black;
            this.labelCatagory.Location = new System.Drawing.Point(65, 311);
            this.labelCatagory.Name = "labelCatagory";
            this.labelCatagory.Size = new System.Drawing.Size(96, 20);
            this.labelCatagory.TabIndex = 30;
            this.labelCatagory.Text = "Category  :";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.White;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Black;
            this.labelUserName.Location = new System.Drawing.Point(40, 237);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(126, 20);
            this.labelUserName.TabIndex = 29;
            this.labelUserName.Text = "Product Price :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(2, 276);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(159, 20);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "Product Quantaty :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.White;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.Black;
            this.labelId.Location = new System.Drawing.Point(23, 195);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(143, 24);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "Product Name";
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.BackColor = System.Drawing.Color.Yellow;
            this.labelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProduct.Location = new System.Drawing.Point(251, 98);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(113, 20);
            this.labelAddProduct.TabIndex = 42;
            this.labelAddProduct.Text = "Add Product ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(723, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "All products ";
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductId.Location = new System.Drawing.Point(172, 153);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(319, 26);
            this.textBoxProductId.TabIndex = 45;
            this.textBoxProductId.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPasseord
            // 
            this.labelPasseord.AutoSize = true;
            this.labelPasseord.BackColor = System.Drawing.Color.White;
            this.labelPasseord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasseord.ForeColor = System.Drawing.Color.Black;
            this.labelPasseord.Location = new System.Drawing.Point(65, 153);
            this.labelPasseord.Name = "labelPasseord";
            this.labelPasseord.Size = new System.Drawing.Size(102, 20);
            this.labelPasseord.TabIndex = 44;
            this.labelPasseord.Text = "Product Id :";
            this.labelPasseord.Click += new System.EventHandler(this.labelPasseord_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AddProductViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1081, 565);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.labelPasseord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAddProduct);
            this.Controls.Add(this.dataGridViewAllProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.textBoxProductQuantaty);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelCatagory);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductViews";
            this.Text = "AddProductViews";
            this.Load += new System.EventHandler(this.AddProductViews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAllProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.TextBox textBoxProductQuantaty;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelCatagory;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label labelPasseord;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}