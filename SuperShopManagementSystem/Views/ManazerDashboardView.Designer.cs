namespace SuperShopManagementSystem.Views
{
    partial class ManazerDashboardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManazerDashboardView));
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.buttonAddProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSellProducts = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPerson.Location = new System.Drawing.Point(21, 169);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(143, 55);
            this.buttonAddPerson.TabIndex = 0;
            this.buttonAddPerson.Text = "Add Person";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // buttonAddProducts
            // 
            this.buttonAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProducts.Location = new System.Drawing.Point(21, 247);
            this.buttonAddProducts.Name = "buttonAddProducts";
            this.buttonAddProducts.Size = new System.Drawing.Size(143, 55);
            this.buttonAddProducts.TabIndex = 2;
            this.buttonAddProducts.Text = "Add Products";
            this.buttonAddProducts.UseVisualStyleBackColor = true;
            this.buttonAddProducts.Click += new System.EventHandler(this.buttonAddProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Manager Dashboard ";
            // 
            // buttonSellProducts
            // 
            this.buttonSellProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSellProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellProducts.ForeColor = System.Drawing.Color.White;
            this.buttonSellProducts.Location = new System.Drawing.Point(193, 61);
            this.buttonSellProducts.Name = "buttonSellProducts";
            this.buttonSellProducts.Size = new System.Drawing.Size(141, 41);
            this.buttonSellProducts.TabIndex = 18;
            this.buttonSellProducts.Text = "Sell Products";
            this.buttonSellProducts.UseVisualStyleBackColor = false;
            this.buttonSellProducts.Click += new System.EventHandler(this.buttonSellProducts_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogOut.Location = new System.Drawing.Point(353, 61);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(141, 41);
            this.buttonLogOut.TabIndex = 17;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(37, 61);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(141, 41);
            this.buttonHome.TabIndex = 16;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.Location = new System.Drawing.Point(859, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // ManazerDashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1081, 565);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSellProducts);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonAddProducts);
            this.Controls.Add(this.buttonAddPerson);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ManazerDashboardView";
            this.Text = "ManagerDashboardView";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResizeBegin += new System.EventHandler(this.ManazerDashboardView_ResizeBegin);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Button buttonAddProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSellProducts;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}