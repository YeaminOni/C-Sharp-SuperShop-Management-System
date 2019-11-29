namespace SuperShopManagementSystem
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
            this.Welcome = new System.Windows.Forms.Label();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonManazer = new System.Windows.Forms.Button();
            this.buttonClark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoEllipsis = true;
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.Welcome.Location = new System.Drawing.Point(344, 40);
            this.Welcome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(160, 45);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome";
            this.Welcome.UseCompatibleTextRendering = true;
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer.Location = new System.Drawing.Point(107, 197);
            this.buttonCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(178, 74);
            this.buttonCustomer.TabIndex = 1;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonManazer
            // 
            this.buttonManazer.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonManazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManazer.Location = new System.Drawing.Point(297, 197);
            this.buttonManazer.Margin = new System.Windows.Forms.Padding(6);
            this.buttonManazer.Name = "buttonManazer";
            this.buttonManazer.Size = new System.Drawing.Size(178, 74);
            this.buttonManazer.TabIndex = 3;
            this.buttonManazer.Text = "Manazer";
            this.buttonManazer.UseVisualStyleBackColor = true;
            // 
            // buttonClark
            // 
            this.buttonClark.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonClark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClark.Location = new System.Drawing.Point(487, 197);
            this.buttonClark.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClark.Name = "buttonClark";
            this.buttonClark.Size = new System.Drawing.Size(178, 74);
            this.buttonClark.TabIndex = 4;
            this.buttonClark.Text = "Clark";
            this.buttonClark.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 487);
            this.Controls.Add(this.buttonClark);
            this.Controls.Add(this.buttonManazer);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.Welcome);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Super Shop Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonManazer;
        private System.Windows.Forms.Button buttonClark;
    }
}

