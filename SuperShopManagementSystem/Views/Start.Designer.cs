namespace SuperShopManagementSystem.Views
{
    partial class Start
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
            this.buttonClark = new System.Windows.Forms.Button();
            this.buttonManazer = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClark
            // 
            this.buttonClark.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonClark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClark.Location = new System.Drawing.Point(477, 204);
            this.buttonClark.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClark.Name = "buttonClark";
            this.buttonClark.Size = new System.Drawing.Size(178, 74);
            this.buttonClark.TabIndex = 8;
            this.buttonClark.Text = "Clerk";
            this.buttonClark.UseVisualStyleBackColor = true;
            // 
            // buttonManazer
            // 
            this.buttonManazer.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonManazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManazer.Location = new System.Drawing.Point(287, 204);
            this.buttonManazer.Margin = new System.Windows.Forms.Padding(6);
            this.buttonManazer.Name = "buttonManazer";
            this.buttonManazer.Size = new System.Drawing.Size(178, 74);
            this.buttonManazer.TabIndex = 7;
            this.buttonManazer.Text = "Manazer";
            this.buttonManazer.UseVisualStyleBackColor = true;
            this.buttonManazer.Click += new System.EventHandler(this.buttonManazer_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer.Location = new System.Drawing.Point(97, 204);
            this.buttonCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(178, 74);
            this.buttonCustomer.TabIndex = 6;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.Welcome.AutoEllipsis = true;
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Red;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.White;
            this.Welcome.Location = new System.Drawing.Point(144, 40);
            this.Welcome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(469, 45);
            this.Welcome.TabIndex = 5;
            this.Welcome.Text = "Welcome To Our Supershop ";
            this.Welcome.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonManazer_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClark);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonManazer);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.Welcome);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClark;
        private System.Windows.Forms.Button buttonManazer;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button button1;
    }
}