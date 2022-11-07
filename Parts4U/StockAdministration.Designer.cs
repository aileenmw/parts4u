
namespace Parts4U
{
    partial class StockAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockAdministration));
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cbProductTypes = new System.Windows.Forms.ComboBox();
            this.lblCreateProductHeader = new System.Windows.Forms.Label();
            this.lblRefillStockItems = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nudNewProductAmount = new System.Windows.Forms.NumericUpDown();
            this.dgvEditProducts = new System.Windows.Forms.DataGridView();
            this.lblEditProducts = new System.Windows.Forms.Label();
            this.dgvStockRefill = new System.Windows.Forms.DataGridView();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblStockRefill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProductAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRefill)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(42, 234);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Produkt Navn";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 234);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(164, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(184, 275);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(164, 22);
            this.tbNumber.TabIndex = 3;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(43, 275);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(79, 20);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Nummer";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(184, 319);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(164, 22);
            this.tbType.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(43, 319);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(43, 448);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 20);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Beskrivelse";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(184, 360);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(164, 22);
            this.tbPrice.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(43, 360);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 20);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Pris";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(43, 193);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(119, 20);
            this.lblProductType.TabIndex = 14;
            this.lblProductType.Text = "Produkt Type";
            // 
            // cbProductTypes
            // 
            this.cbProductTypes.FormattingEnabled = true;
            this.cbProductTypes.Location = new System.Drawing.Point(183, 194);
            this.cbProductTypes.Name = "cbProductTypes";
            this.cbProductTypes.Size = new System.Drawing.Size(165, 24);
            this.cbProductTypes.TabIndex = 15;
            this.cbProductTypes.Text = "Vælg produkttype";
            // 
            // lblCreateProductHeader
            // 
            this.lblCreateProductHeader.AutoSize = true;
            this.lblCreateProductHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateProductHeader.Location = new System.Drawing.Point(41, 144);
            this.lblCreateProductHeader.Name = "lblCreateProductHeader";
            this.lblCreateProductHeader.Size = new System.Drawing.Size(259, 32);
            this.lblCreateProductHeader.TabIndex = 16;
            this.lblCreateProductHeader.Text = "Opret nyt Produkt";
            // 
            // lblRefillStockItems
            // 
            this.lblRefillStockItems.AutoSize = true;
            this.lblRefillStockItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefillStockItems.Location = new System.Drawing.Point(683, 145);
            this.lblRefillStockItems.Name = "lblRefillStockItems";
            this.lblRefillStockItems.Size = new System.Drawing.Size(286, 32);
            this.lblRefillStockItems.TabIndex = 17;
            this.lblRefillStockItems.Text = "Opfyldning af Lager";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(183, 448);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(165, 90);
            this.rtbDescription.TabIndex = 18;
            this.rtbDescription.Text = "";
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.Color.Green;
            this.btnCreateProduct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProduct.ForeColor = System.Drawing.Color.White;
            this.btnCreateProduct.Location = new System.Drawing.Point(183, 552);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(165, 36);
            this.btnCreateProduct.TabIndex = 19;
            this.btnCreateProduct.Text = "Opret produkt";
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(828, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.Location = new System.Drawing.Point(319, 80);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(391, 29);
            this.lblSubHeader.TabIndex = 21;
            this.lblSubHeader.Text = "- de rigtige dele til den rigtige pris";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.lblHeader.Location = new System.Drawing.Point(412, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(171, 44);
            this.lblHeader.TabIndex = 20;
            this.lblHeader.Text = "Parts4U";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(43, 405);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 20);
            this.lblAmount.TabIndex = 25;
            this.lblAmount.Text = "Antal";
            // 
            // nudNewProductAmount
            // 
            this.nudNewProductAmount.Location = new System.Drawing.Point(183, 406);
            this.nudNewProductAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNewProductAmount.Name = "nudNewProductAmount";
            this.nudNewProductAmount.Size = new System.Drawing.Size(164, 22);
            this.nudNewProductAmount.TabIndex = 26;
            // 
            // dgvEditProducts
            // 
            this.dgvEditProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvEditProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditProducts.ColumnHeadersVisible = false;
            this.dgvEditProducts.Location = new System.Drawing.Point(400, 194);
            this.dgvEditProducts.Name = "dgvEditProducts";
            this.dgvEditProducts.RowHeadersVisible = false;
            this.dgvEditProducts.RowHeadersWidth = 51;
            this.dgvEditProducts.RowTemplate.Height = 24;
            this.dgvEditProducts.Size = new System.Drawing.Size(237, 335);
            this.dgvEditProducts.TabIndex = 27;
            this.dgvEditProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditProducts_CellContentClick);
            // 
            // lblEditProducts
            // 
            this.lblEditProducts.AutoSize = true;
            this.lblEditProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProducts.Location = new System.Drawing.Point(394, 145);
            this.lblEditProducts.Name = "lblEditProducts";
            this.lblEditProducts.Size = new System.Drawing.Size(213, 32);
            this.lblEditProducts.TabIndex = 29;
            this.lblEditProducts.Text = "Slet produkter";
            // 
            // dgvStockRefill
            // 
            this.dgvStockRefill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockRefill.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockRefill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockRefill.ColumnHeadersVisible = false;
            this.dgvStockRefill.Location = new System.Drawing.Point(686, 194);
            this.dgvStockRefill.Name = "dgvStockRefill";
            this.dgvStockRefill.RowHeadersVisible = false;
            this.dgvStockRefill.RowHeadersWidth = 51;
            this.dgvStockRefill.RowTemplate.Height = 24;
            this.dgvStockRefill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockRefill.Size = new System.Drawing.Size(274, 335);
            this.dgvStockRefill.TabIndex = 23;
            this.dgvStockRefill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockRefill_CellContentClick);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(397, 564);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(194, 16);
            this.lblDelete.TabIndex = 30;
            this.lblDelete.Text = "Klik på produkt for at slette";
            // 
            // lblStockRefill
            // 
            this.lblStockRefill.AutoSize = true;
            this.lblStockRefill.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockRefill.Location = new System.Drawing.Point(686, 564);
            this.lblStockRefill.Name = "lblStockRefill";
            this.lblStockRefill.Size = new System.Drawing.Size(248, 16);
            this.lblStockRefill.TabIndex = 31;
            this.lblStockRefill.Text = "Klik på produkt for tilføje produkter";
            // 
            // StockAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 620);
            this.Controls.Add(this.lblStockRefill);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEditProducts);
            this.Controls.Add(this.dgvEditProducts);
            this.Controls.Add(this.nudNewProductAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dgvStockRefill);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblRefillStockItems);
            this.Controls.Add(this.lblCreateProductHeader);
            this.Controls.Add(this.cbProductTypes);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockAdministration";
            this.Text = "StockAdministration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProductAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRefill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cbProductTypes;
        private System.Windows.Forms.Label lblCreateProductHeader;
        private System.Windows.Forms.Label lblRefillStockItems;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nudNewProductAmount;
        private System.Windows.Forms.DataGridView dgvEditProducts;
        private System.Windows.Forms.Label lblEditProducts;
        private System.Windows.Forms.DataGridView dgvStockRefill;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblStockRefill;
    }
}