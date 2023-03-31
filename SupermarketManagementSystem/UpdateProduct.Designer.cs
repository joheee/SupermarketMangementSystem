﻿namespace SupermarketManagementSystem
{
    partial class UpdateProduct
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
            this.back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productDesc = new System.Windows.Forms.TextBox();
            this.RegisterHeader = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.productStock = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.ErrorMessageProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessageProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(10, 157);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 36;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "name:";
            // 
            // productDesc
            // 
            this.productDesc.Location = new System.Drawing.Point(89, 74);
            this.productDesc.Name = "productDesc";
            this.productDesc.Size = new System.Drawing.Size(190, 20);
            this.productDesc.TabIndex = 32;
            // 
            // RegisterHeader
            // 
            this.RegisterHeader.AutoSize = true;
            this.RegisterHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RegisterHeader.Location = new System.Drawing.Point(32, 9);
            this.RegisterHeader.Name = "RegisterHeader";
            this.RegisterHeader.Size = new System.Drawing.Size(203, 31);
            this.RegisterHeader.TabIndex = 31;
            this.RegisterHeader.Text = "Update Product";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(11, 128);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(268, 23);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "update product";
            this.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // productStock
            // 
            this.productStock.Location = new System.Drawing.Point(89, 97);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(190, 20);
            this.productStock.TabIndex = 29;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(89, 48);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(190, 20);
            this.productName.TabIndex = 28;
            // 
            // ErrorMessageProvider
            // 
            this.ErrorMessageProvider.ContainerControl = this;
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 192);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productDesc);
            this.Controls.Add(this.RegisterHeader);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.productStock);
            this.Controls.Add(this.productName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessageProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox productDesc;
        private System.Windows.Forms.Label RegisterHeader;
        private System.Windows.Forms.Button updateButton;
        protected System.Windows.Forms.TextBox productStock;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.ErrorProvider ErrorMessageProvider;
    }
}