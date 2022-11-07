
namespace Parts4U
{
    partial class ProductGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGrid));
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvMotorbike = new System.Windows.Forms.DataGridView();
            this.dgvBike = new System.Windows.Forms.DataGridView();
            this.lblMotorbike = new System.Windows.Forms.Label();
            this.lblBike = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorbike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBike)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCar
            // 
            this.dgvCar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Location = new System.Drawing.Point(263, 189);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.RowHeadersWidth = 51;
            this.dgvCar.RowTemplate.Height = 24;
            this.dgvCar.Size = new System.Drawing.Size(694, 323);
            this.dgvCar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.Location = new System.Drawing.Point(267, 92);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(391, 29);
            this.lblSubHeader.TabIndex = 5;
            this.lblSubHeader.Text = "- de rigtige dele til den rigtige pris";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.lblHeader.Location = new System.Drawing.Point(360, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(171, 44);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Parts4U";
            // 
            // dgvMotorbike
            // 
            this.dgvMotorbike.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMotorbike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotorbike.Location = new System.Drawing.Point(263, 189);
            this.dgvMotorbike.Name = "dgvMotorbike";
            this.dgvMotorbike.RowHeadersWidth = 51;
            this.dgvMotorbike.RowTemplate.Height = 24;
            this.dgvMotorbike.Size = new System.Drawing.Size(694, 323);
            this.dgvMotorbike.TabIndex = 7;
            this.dgvMotorbike.Visible = false;
            // 
            // dgvBike
            // 
            this.dgvBike.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBike.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBike.Location = new System.Drawing.Point(263, 189);
            this.dgvBike.Name = "dgvBike";
            this.dgvBike.RowHeadersWidth = 51;
            this.dgvBike.RowTemplate.Height = 24;
            this.dgvBike.Size = new System.Drawing.Size(694, 323);
            this.dgvBike.TabIndex = 8;
            this.dgvBike.Visible = false;
            // 
            // lblMotorbike
            // 
            this.lblMotorbike.AutoSize = true;
            this.lblMotorbike.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorbike.Location = new System.Drawing.Point(41, 303);
            this.lblMotorbike.Name = "lblMotorbike";
            this.lblMotorbike.Size = new System.Drawing.Size(186, 20);
            this.lblMotorbike.TabIndex = 10;
            this.lblMotorbike.Text = "Motorcykel produkter";
            this.lblMotorbike.Click += new System.EventHandler(this.lblMotorbike_Click);
            // 
            // lblBike
            // 
            this.lblBike.AutoSize = true;
            this.lblBike.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBike.Location = new System.Drawing.Point(41, 367);
            this.lblBike.Name = "lblBike";
            this.lblBike.Size = new System.Drawing.Size(142, 20);
            this.lblBike.TabIndex = 11;
            this.lblBike.Text = "Cykel produkter";
            this.lblBike.Click += new System.EventHandler(this.lblBike_Click);
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(37, 247);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(117, 20);
            this.lblCar.TabIndex = 12;
            this.lblCar.Text = "Bil produkter";
            this.lblCar.Click += new System.EventHandler(this.lblCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(32, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Vælg Produkttype";
            // 
            // ProductGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblBike);
            this.Controls.Add(this.lblMotorbike);
            this.Controls.Add(this.dgvBike);
            this.Controls.Add(this.dgvMotorbike);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvCar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductGrid";
            this.Text = "ProductGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorbike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvMotorbike;
        private System.Windows.Forms.DataGridView dgvBike;
        private System.Windows.Forms.Label lblMotorbike;
        private System.Windows.Forms.Label lblBike;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label label1;
    }
}