namespace LandscapeDesign.Client
{
    partial class Catalog
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(128, 52);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(266, 28);
            this.comboBoxType.TabIndex = 0;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Enabled = false;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(128, 125);
            this.comboBoxSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(266, 28);
            this.comboBoxSize.TabIndex = 1;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Заказать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(128, 203);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(12, 20);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "l";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Руб.";
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Catalog";
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label1;
    }
}