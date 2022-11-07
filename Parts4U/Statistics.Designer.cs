
namespace Parts4U
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.lblStatistics = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSetItemNmb = new System.Windows.Forms.Label();
            this.lblSetType = new System.Windows.Forms.Label();
            this.cbProductNumber = new System.Windows.Forms.ComboBox();
            this.cbPickType = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSalesInterval = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbStartTime = new System.Windows.Forms.ComboBox();
            this.cbEndTime = new System.Windows.Forms.ComboBox();
            this.lbIntervalSales = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.Location = new System.Drawing.Point(353, 149);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(221, 32);
            this.lblStatistics.TabIndex = 0;
            this.lblStatistics.Text = "Salgs Statestik";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.Location = new System.Drawing.Point(268, 79);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(391, 29);
            this.lblSubHeader.TabIndex = 8;
            this.lblSubHeader.Text = "- de rigtige dele til den rigtige pris";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.lblHeader.Location = new System.Drawing.Point(361, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(214, 55);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Parts4U";
            // 
            // lblSetItemNmb
            // 
            this.lblSetItemNmb.AutoSize = true;
            this.lblSetItemNmb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetItemNmb.Location = new System.Drawing.Point(260, 223);
            this.lblSetItemNmb.Name = "lblSetItemNmb";
            this.lblSetItemNmb.Size = new System.Drawing.Size(185, 20);
            this.lblSetItemNmb.TabIndex = 17;
            this.lblSetItemNmb.Text = "VælgProduktnummer";
            // 
            // lblSetType
            // 
            this.lblSetType.AutoSize = true;
            this.lblSetType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetType.Location = new System.Drawing.Point(68, 223);
            this.lblSetType.Name = "lblSetType";
            this.lblSetType.Size = new System.Drawing.Size(158, 20);
            this.lblSetType.TabIndex = 16;
            this.lblSetType.Text = "Vælg Produkttype";
            // 
            // cbProductNumber
            // 
            this.cbProductNumber.FormattingEnabled = true;
            this.cbProductNumber.Location = new System.Drawing.Point(264, 267);
            this.cbProductNumber.Name = "cbProductNumber";
            this.cbProductNumber.Size = new System.Drawing.Size(147, 24);
            this.cbProductNumber.TabIndex = 13;
            // 
            // cbPickType
            // 
            this.cbPickType.FormattingEnabled = true;
            this.cbPickType.Location = new System.Drawing.Point(72, 267);
            this.cbPickType.Name = "cbPickType";
            this.cbPickType.Size = new System.Drawing.Size(154, 24);
            this.cbPickType.TabIndex = 12;
            this.cbPickType.SelectedIndexChanged += new System.EventHandler(this.cbPickType_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(264, 420);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(147, 38);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "Vis oversigt";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblSalesInterval
            // 
            this.lblSalesInterval.AutoSize = true;
            this.lblSalesInterval.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesInterval.Location = new System.Drawing.Point(61, 342);
            this.lblSalesInterval.Name = "lblSalesInterval";
            this.lblSalesInterval.Size = new System.Drawing.Size(165, 20);
            this.lblSalesInterval.TabIndex = 15;
            this.lblSalesInterval.Text = "Vælg Salgsinterval";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbStartTime
            // 
            this.cbStartTime.FormattingEnabled = true;
            this.cbStartTime.Location = new System.Drawing.Point(72, 379);
            this.cbStartTime.Name = "cbStartTime";
            this.cbStartTime.Size = new System.Drawing.Size(154, 24);
            this.cbStartTime.TabIndex = 19;
            // 
            // cbEndTime
            // 
            this.cbEndTime.FormattingEnabled = true;
            this.cbEndTime.Location = new System.Drawing.Point(72, 434);
            this.cbEndTime.Name = "cbEndTime";
            this.cbEndTime.Size = new System.Drawing.Size(154, 24);
            this.cbEndTime.TabIndex = 20;
            // 
            // lbIntervalSales
            // 
            this.lbIntervalSales.FormattingEnabled = true;
            this.lbIntervalSales.ItemHeight = 16;
            this.lbIntervalSales.Location = new System.Drawing.Point(459, 267);
            this.lbIntervalSales.Name = "lbIntervalSales";
            this.lbIntervalSales.Size = new System.Drawing.Size(423, 212);
            this.lbIntervalSales.TabIndex = 21;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 550);
            this.Controls.Add(this.lbIntervalSales);
            this.Controls.Add(this.cbEndTime);
            this.Controls.Add(this.cbStartTime);
            this.Controls.Add(this.lblSetItemNmb);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSetType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbProductNumber);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.cbPickType);
            this.Controls.Add(this.lblSalesInterval);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblStatistics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbPickType;
        private System.Windows.Forms.Label lblSetItemNmb;
        private System.Windows.Forms.Label lblSetType;
        private System.Windows.Forms.Label lblSalesInterval;
        private System.Windows.Forms.ComboBox cbProductNumber;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbStartTime;
        private System.Windows.Forms.ComboBox cbEndTime;
        private System.Windows.Forms.ListBox lbIntervalSales;
    }
}