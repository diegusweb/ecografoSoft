namespace EcocgrafoSoft.View
{
    partial class EcoLayout
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
            this.paymentV2Layout = new System.Windows.Forms.TabControl();
            this.tbPagePurchases = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.paymentV2Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentV2Layout
            // 
            this.paymentV2Layout.Controls.Add(this.tbPagePurchases);
            this.paymentV2Layout.Controls.Add(this.tabPage2);
            this.paymentV2Layout.Controls.Add(this.tabPage3);
            this.paymentV2Layout.Location = new System.Drawing.Point(0, 0);
            this.paymentV2Layout.Name = "paymentV2Layout";
            this.paymentV2Layout.SelectedIndex = 0;
            this.paymentV2Layout.Size = new System.Drawing.Size(1528, 1044);
            this.paymentV2Layout.TabIndex = 0;
            // 
            // tbPagePurchases
            // 
            this.tbPagePurchases.Location = new System.Drawing.Point(4, 29);
            this.tbPagePurchases.Name = "tbPagePurchases";
            this.tbPagePurchases.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagePurchases.Size = new System.Drawing.Size(1520, 1011);
            this.tbPagePurchases.TabIndex = 0;
            this.tbPagePurchases.Text = "tabPage1";
            this.tbPagePurchases.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1520, 1011);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1520, 1011);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // EcoLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paymentV2Layout);
            this.Name = "EcoLayout";
            this.Size = new System.Drawing.Size(1528, 1044);
            this.paymentV2Layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl paymentV2Layout;
        private System.Windows.Forms.TabPage tbPagePurchases;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}