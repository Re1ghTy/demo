namespace LandscapeDesign.Client
{
    partial class Main
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
            this.panelBut = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBut.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBut
            // 
            this.panelBut.Controls.Add(this.button4);
            this.panelBut.Controls.Add(this.button3);
            this.panelBut.Controls.Add(this.button2);
            this.panelBut.Controls.Add(this.button1);
            this.panelBut.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBut.Location = new System.Drawing.Point(0, 0);
            this.panelBut.Name = "panelBut";
            this.panelBut.Size = new System.Drawing.Size(153, 450);
            this.panelBut.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Свой дизайн";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Заказы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Каталог";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Профиль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(153, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(647, 53);
            this.panelTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(248, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Главная";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(153, 53);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(647, 397);
            this.panelMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelBut);
            this.Name = "Main";
            this.Text = "Главная";
            this.panelBut.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBut;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
    }
}