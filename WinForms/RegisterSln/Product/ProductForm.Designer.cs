namespace Product
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.categoryDrop = new System.Windows.Forms.ComboBox();
            this.adBox = new System.Windows.Forms.TextBox();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.Label();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.barcode = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.categoryDrop);
            this.panel1.Controls.Add(this.adBox);
            this.panel1.Controls.Add(this.stockBox);
            this.panel1.Controls.Add(this.barcodeBox);
            this.panel1.Controls.Add(this.ad);
            this.panel1.Controls.Add(this.colorBox);
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.brandBox);
            this.panel1.Controls.Add(this.barcode);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.color);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.brand);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 446);
            this.panel1.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(110, 308);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(126, 32);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.AddProduct);
            // 
            // categoryDrop
            // 
            this.categoryDrop.FormattingEnabled = true;
            this.categoryDrop.Items.AddRange(new object[] {
            "Meiset",
            "Nomre",
            "Telefon ve Planset",
            "TV ve Audio"});
            this.categoryDrop.Location = new System.Drawing.Point(110, 73);
            this.categoryDrop.Name = "categoryDrop";
            this.categoryDrop.Size = new System.Drawing.Size(126, 21);
            this.categoryDrop.Sorted = true;
            this.categoryDrop.TabIndex = 3;
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(110, 262);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(126, 20);
            this.adBox.TabIndex = 8;
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(110, 222);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(126, 20);
            this.stockBox.TabIndex = 7;
            // 
            // barcodeBox
            // 
            this.barcodeBox.Location = new System.Drawing.Point(110, 183);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(126, 20);
            this.barcodeBox.TabIndex = 6;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ad.Location = new System.Drawing.Point(24, 266);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(25, 16);
            this.ad.TabIndex = 0;
            this.ad.Text = "Ad";
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(110, 146);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(126, 20);
            this.colorBox.TabIndex = 5;
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stock.Location = new System.Drawing.Point(24, 226);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(42, 16);
            this.stock.TabIndex = 0;
            this.stock.Text = "Stock";
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(110, 110);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(126, 20);
            this.brandBox.TabIndex = 4;
            // 
            // barcode
            // 
            this.barcode.AutoSize = true;
            this.barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcode.Location = new System.Drawing.Point(24, 187);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(60, 16);
            this.barcode.TabIndex = 0;
            this.barcode.Text = "Barcode";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(110, 41);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(126, 20);
            this.priceBox.TabIndex = 2;
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color.Location = new System.Drawing.Point(24, 150);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(40, 16);
            this.color.TabIndex = 0;
            this.color.Text = "Color";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(110, 11);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(126, 20);
            this.nameBox.TabIndex = 1;
            // 
            // brand
            // 
            this.brand.AutoSize = true;
            this.brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brand.Location = new System.Drawing.Point(24, 114);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(44, 16);
            this.brand.TabIndex = 0;
            this.brand.Text = "Brand";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category.Location = new System.Drawing.Point(24, 78);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(63, 16);
            this.category.TabIndex = 0;
            this.category.Text = "Category";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(24, 45);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(39, 16);
            this.price.TabIndex = 0;
            this.price.Text = "Price";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(24, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 16);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // productTable
            // 
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.priceCol,
            this.categoryCol,
            this.brandCol,
            this.colorCol,
            this.barcodeCol,
            this.stockCol});
            this.productTable.Location = new System.Drawing.Point(264, 2);
            this.productTable.Name = "productTable";
            this.productTable.Size = new System.Drawing.Size(707, 446);
            this.productTable.TabIndex = 1;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            // 
            // categoryCol
            // 
            this.categoryCol.HeaderText = "Category";
            this.categoryCol.Name = "categoryCol";
            this.categoryCol.ReadOnly = true;
            // 
            // brandCol
            // 
            this.brandCol.HeaderText = "Brand";
            this.brandCol.Name = "brandCol";
            this.brandCol.ReadOnly = true;
            // 
            // colorCol
            // 
            this.colorCol.HeaderText = "Color";
            this.colorCol.Name = "colorCol";
            this.colorCol.ReadOnly = true;
            // 
            // barcodeCol
            // 
            this.barcodeCol.HeaderText = "Barcode";
            this.barcodeCol.Name = "barcodeCol";
            this.barcodeCol.ReadOnly = true;
            // 
            // stockCol
            // 
            this.stockCol.HeaderText = "Stock";
            this.stockCol.Name = "stockCol";
            this.stockCol.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox categoryDrop;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.Label barcode;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCol;
        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.Label ad;
    }
}

