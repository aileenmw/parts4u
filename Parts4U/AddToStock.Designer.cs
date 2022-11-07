
namespace Parts4U
{
    partial class AddToStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToStock));
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nudAddAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddAmount = new System.Windows.Forms.Button();
            this.lblAddAmountHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(34, 103);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 17);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "label2";
            // 
            // nudAddAmount
            // 
            this.nudAddAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAddAmount.Location = new System.Drawing.Point(397, 56);
            this.nudAddAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddAmount.Name = "nudAddAmount";
            this.nudAddAmount.Size = new System.Drawing.Size(76, 25);
            this.nudAddAmount.TabIndex = 2;
            // 
            // btnAddAmount
            // 
            this.btnAddAmount.BackColor = System.Drawing.Color.Green;
            this.btnAddAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAmount.ForeColor = System.Drawing.Color.White;
            this.btnAddAmount.Location = new System.Drawing.Point(397, 95);
            this.btnAddAmount.Name = "btnAddAmount";
            this.btnAddAmount.Size = new System.Drawing.Size(76, 32);
            this.btnAddAmount.TabIndex = 3;
            this.btnAddAmount.Text = "Tilføj";
            this.btnAddAmount.UseVisualStyleBackColor = false;
            this.btnAddAmount.Click += new System.EventHandler(this.btnAddAmount_Click);
            // 
            // lblAddAmountHeader
            // 
            this.lblAddAmountHeader.AutoSize = true;
            this.lblAddAmountHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAmountHeader.Location = new System.Drawing.Point(108, 22);
            this.lblAddAmountHeader.Name = "lblAddAmountHeader";
            this.lblAddAmountHeader.Size = new System.Drawing.Size(297, 20);
            this.lblAddAmountHeader.TabIndex = 5;
            this.lblAddAmountHeader.Text = "Tilføj produkter til lagerbeholdning";
            // 
            // AddToStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 158);
            this.Controls.Add(this.lblAddAmountHeader);
            this.Controls.Add(this.btnAddAmount);
            this.Controls.Add(this.nudAddAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddToStock";
            this.Text = "AddToStock";
            ((System.ComponentModel.ISupportInitialize)(this.nudAddAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nudAddAmount;
        private System.Windows.Forms.Button btnAddAmount;
        private System.Windows.Forms.Label lblAddAmountHeader;
    }
}