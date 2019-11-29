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
            this.button1 = new System.Windows.Forms.Button();
            this.labelManazerDashboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Person";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelManazerDashboard
            // 
            this.labelManazerDashboard.AutoSize = true;
            this.labelManazerDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManazerDashboard.Location = new System.Drawing.Point(267, 39);
            this.labelManazerDashboard.Name = "labelManazerDashboard";
            this.labelManazerDashboard.Size = new System.Drawing.Size(238, 25);
            this.labelManazerDashboard.TabIndex = 1;
            this.labelManazerDashboard.Text = "Manazer  Dashboard ";
            // 
            // ManazerDashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelManazerDashboard);
            this.Controls.Add(this.button1);
            this.Name = "ManazerDashboardView";
            this.Text = "DashbordView";
            this.ResizeBegin += new System.EventHandler(this.ManazerDashboardView_ResizeBegin);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelManazerDashboard;
    }
}