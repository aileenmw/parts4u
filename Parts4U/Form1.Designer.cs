
namespace Parts4U
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnSalesStatistics = new System.Windows.Forms.Button();
            this.lblViewProducts = new System.Windows.Forms.Label();
            this.lblSalesOverview = new System.Windows.Forms.Label();
            this.btnStopOnlineSales = new System.Windows.Forms.Button();
            this.btnBasket = new System.Windows.Forms.Button();
            this.cbProducType = new System.Windows.Forms.ComboBox();
            this.btnChooseType = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbSales = new System.Windows.Forms.ListBox();
            this.dgvStockDisplay = new System.Windows.Forms.DataGridView();
            this.lblStockGrid = new System.Windows.Forms.Label();
            this.btnStockAdmin = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btntoProductGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.lblHeader.Location = new System.Drawing.Point(446, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(171, 44);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Parts4U";
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.Location = new System.Drawing.Point(353, 74);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(391, 29);
            this.lblSubHeader.TabIndex = 2;
            this.lblSubHeader.Text = "- de rigtige dele til den rigtige pris";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(891, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnSalesStatistics
            // 
            this.btnSalesStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.btnSalesStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesStatistics.ForeColor = System.Drawing.Color.White;
            this.btnSalesStatistics.Location = new System.Drawing.Point(681, 574);
            this.btnSalesStatistics.Name = "btnSalesStatistics";
            this.btnSalesStatistics.Size = new System.Drawing.Size(321, 35);
            this.btnSalesStatistics.TabIndex = 5;
            this.btnSalesStatistics.Text = "Salgs Statistik";
            this.btnSalesStatistics.UseVisualStyleBackColor = false;
            this.btnSalesStatistics.Click += new System.EventHandler(this.btnSalesStatistics_Click);
            // 
            // lblViewProducts
            // 
            this.lblViewProducts.AutoSize = true;
            this.lblViewProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewProducts.Location = new System.Drawing.Point(42, 151);
            this.lblViewProducts.Name = "lblViewProducts";
            this.lblViewProducts.Size = new System.Drawing.Size(112, 20);
            this.lblViewProducts.TabIndex = 7;
            this.lblViewProducts.Text = "Køb Produkt";
            // 
            // lblSalesOverview
            // 
            this.lblSalesOverview.AutoSize = true;
            this.lblSalesOverview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOverview.Location = new System.Drawing.Point(691, 151);
            this.lblSalesOverview.Name = "lblSalesOverview";
            this.lblSalesOverview.Size = new System.Drawing.Size(263, 20);
            this.lblSalesOverview.TabIndex = 8;
            this.lblSalesOverview.Text = "Løbende Salg (online og lokalt)";
            // 
            // btnStopOnlineSales
            // 
            this.btnStopOnlineSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStopOnlineSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopOnlineSales.ForeColor = System.Drawing.Color.DimGray;
            this.btnStopOnlineSales.Location = new System.Drawing.Point(681, 637);
            this.btnStopOnlineSales.Name = "btnStopOnlineSales";
            this.btnStopOnlineSales.Size = new System.Drawing.Size(321, 35);
            this.btnStopOnlineSales.TabIndex = 9;
            this.btnStopOnlineSales.Text = "Stop Onlinesalg";
            this.btnStopOnlineSales.UseVisualStyleBackColor = false;
            this.btnStopOnlineSales.Click += new System.EventHandler(this.btnStopOnlineSales_Click);
            // 
            // btnBasket
            // 
            this.btnBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.btnBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasket.ForeColor = System.Drawing.Color.White;
            this.btnBasket.Location = new System.Drawing.Point(35, 574);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(290, 35);
            this.btnBasket.TabIndex = 10;
            this.btnBasket.Text = "Gå til Kurv";
            this.btnBasket.UseVisualStyleBackColor = false;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // cbProducType
            // 
            this.cbProducType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducType.FormattingEnabled = true;
            this.cbProducType.Location = new System.Drawing.Point(32, 188);
            this.cbProducType.Name = "cbProducType";
            this.cbProducType.Size = new System.Drawing.Size(290, 26);
            this.cbProducType.TabIndex = 11;
            this.cbProducType.Text = "Vælg produkttype";
            // 
            // btnChooseType
            // 
            this.btnChooseType.BackColor = System.Drawing.Color.Green;
            this.btnChooseType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseType.ForeColor = System.Drawing.Color.White;
            this.btnChooseType.Location = new System.Drawing.Point(35, 235);
            this.btnChooseType.Margin = new System.Windows.Forms.Padding(0);
            this.btnChooseType.Name = "btnChooseType";
            this.btnChooseType.Size = new System.Drawing.Size(290, 30);
            this.btnChooseType.TabIndex = 12;
            this.btnChooseType.Text = "GO!";
            this.btnChooseType.UseVisualStyleBackColor = false;
            this.btnChooseType.Click += new System.EventHandler(this.btnChooseType_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 17;
            this.lbProducts.Location = new System.Drawing.Point(35, 293);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(290, 259);
            this.lbProducts.TabIndex = 13;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lbSales
            // 
            this.lbSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSales.FormattingEnabled = true;
            this.lbSales.ItemHeight = 15;
            this.lbSales.Location = new System.Drawing.Point(681, 188);
            this.lbSales.Name = "lbSales";
            this.lbSales.Size = new System.Drawing.Size(321, 364);
            this.lbSales.TabIndex = 14;
            // 
            // dgvStockDisplay
            // 
            this.dgvStockDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockDisplay.ColumnHeadersVisible = false;
            this.dgvStockDisplay.Location = new System.Drawing.Point(358, 188);
            this.dgvStockDisplay.Name = "dgvStockDisplay";
            this.dgvStockDisplay.RowHeadersVisible = false;
            this.dgvStockDisplay.RowHeadersWidth = 51;
            this.dgvStockDisplay.RowTemplate.Height = 24;
            this.dgvStockDisplay.Size = new System.Drawing.Size(275, 364);
            this.dgvStockDisplay.TabIndex = 16;
            // 
            // lblStockGrid
            // 
            this.lblStockGrid.AutoSize = true;
            this.lblStockGrid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockGrid.Location = new System.Drawing.Point(364, 151);
            this.lblStockGrid.Name = "lblStockGrid";
            this.lblStockGrid.Size = new System.Drawing.Size(122, 20);
            this.lblStockGrid.TabIndex = 18;
            this.lblStockGrid.Text = "Salgsoversigt";
            // 
            // btnStockAdmin
            // 
            this.btnStockAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.btnStockAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAdmin.ForeColor = System.Drawing.Color.White;
            this.btnStockAdmin.Location = new System.Drawing.Point(358, 574);
            this.btnStockAdmin.Name = "btnStockAdmin";
            this.btnStockAdmin.Size = new System.Drawing.Size(275, 35);
            this.btnStockAdmin.TabIndex = 19;
            this.btnStockAdmin.Text = "Administrér Lager";
            this.btnStockAdmin.UseVisualStyleBackColor = false;
            this.btnStockAdmin.Click += new System.EventHandler(this.btnStockAdmin_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(358, 637);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(275, 35);
            this.btnStatus.TabIndex = 20;
            this.btnStatus.Text = "Salgs status";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btntoProductGrid
            // 
            this.btntoProductGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.btntoProductGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoProductGrid.ForeColor = System.Drawing.Color.White;
            this.btntoProductGrid.Location = new System.Drawing.Point(35, 637);
            this.btntoProductGrid.Name = "btntoProductGrid";
            this.btntoProductGrid.Size = new System.Drawing.Size(290, 35);
            this.btntoProductGrid.TabIndex = 21;
            this.btntoProductGrid.Text = "Gå til Produktoversigt";
            this.btntoProductGrid.UseVisualStyleBackColor = false;
            this.btntoProductGrid.Click += new System.EventHandler(this.btntoProductGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 734);
            this.Controls.Add(this.btntoProductGrid);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnStockAdmin);
            this.Controls.Add(this.lblStockGrid);
            this.Controls.Add(this.dgvStockDisplay);
            this.Controls.Add(this.lbSales);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.btnChooseType);
            this.Controls.Add(this.cbProducType);
            this.Controls.Add(this.btnBasket);
            this.Controls.Add(this.btnStopOnlineSales);
            this.Controls.Add(this.lblSalesOverview);
            this.Controls.Add(this.lblViewProducts);
            this.Controls.Add(this.btnSalesStatistics);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.lblHeader);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Parts4U";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label lblSalesOverview;
        private System.Windows.Forms.Label lblViewProducts;
        private System.Windows.Forms.Button btnSalesStatistics;
        private System.Windows.Forms.Button btnStopOnlineSales;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.ComboBox cbProducType;
        private System.Windows.Forms.Button btnChooseType;
        private System.Windows.Forms.ListBox lbProducts;
        public System.Windows.Forms.ListBox lbSales;
        private System.Windows.Forms.DataGridView dgvStockDisplay;
        private System.Windows.Forms.Label lblStockGrid;
        private System.Windows.Forms.Button btnStockAdmin;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btntoProductGrid;
    }
}

