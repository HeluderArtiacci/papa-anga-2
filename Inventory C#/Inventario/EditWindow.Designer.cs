namespace Inventario
{
    partial class EditWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.PriceValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SellPriceValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.itemManufacturer = new System.Windows.Forms.TextBox();
            this.itemProvider = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.Label();
            this.itemDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemPicture = new System.Windows.Forms.PictureBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellPriceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del producto:";
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.itemName.Location = new System.Drawing.Point(246, 56);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(226, 30);
            this.itemName.TabIndex = 2;
            // 
            // PriceValue
            // 
            this.PriceValue.DecimalPlaces = 2;
            this.PriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceValue.Location = new System.Drawing.Point(117, 243);
            this.PriceValue.Name = "PriceValue";
            this.PriceValue.Size = new System.Drawing.Size(120, 30);
            this.PriceValue.TabIndex = 4;
            this.PriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio de venta";
            // 
            // SellPriceValue
            // 
            this.SellPriceValue.DecimalPlaces = 2;
            this.SellPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SellPriceValue.Location = new System.Drawing.Point(117, 279);
            this.SellPriceValue.Name = "SellPriceValue";
            this.SellPriceValue.Size = new System.Drawing.Size(120, 30);
            this.SellPriceValue.TabIndex = 6;
            this.SellPriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fabricante:";
            // 
            // itemManufacturer
            // 
            this.itemManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.itemManufacturer.Location = new System.Drawing.Point(246, 109);
            this.itemManufacturer.Name = "itemManufacturer";
            this.itemManufacturer.Size = new System.Drawing.Size(225, 30);
            this.itemManufacturer.TabIndex = 9;
            // 
            // itemProvider
            // 
            this.itemProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.itemProvider.Location = new System.Drawing.Point(246, 168);
            this.itemProvider.Name = "itemProvider";
            this.itemProvider.Size = new System.Drawing.Size(225, 30);
            this.itemProvider.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Proveedor:";
            // 
            // ProductID
            // 
            this.ProductID.BackColor = System.Drawing.Color.Transparent;
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProductID.Location = new System.Drawing.Point(249, 9);
            this.ProductID.Name = "ProductID";
            this.ProductID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductID.Size = new System.Drawing.Size(223, 25);
            this.ProductID.TabIndex = 12;
            this.ProductID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // itemDesc
            // 
            this.itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemDesc.Location = new System.Drawing.Point(246, 225);
            this.itemDesc.Multiline = true;
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(225, 146);
            this.itemDesc.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Especificaciones:";
            // 
            // itemPicture
            // 
            this.itemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPicture.ErrorImage = global::Inventario.Properties.Resources.missingImage;
            this.itemPicture.Image = global::Inventario.Properties.Resources.UploadImage;
            this.itemPicture.Location = new System.Drawing.Point(12, 12);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Padding = new System.Windows.Forms.Padding(5);
            this.itemPicture.Size = new System.Drawing.Size(225, 225);
            this.itemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemPicture.TabIndex = 0;
            this.itemPicture.TabStop = false;
            this.itemPicture.DoubleClick += new System.EventHandler(this.itemPicture_DoubleClick);
            // 
            // BT_Save
            // 
            this.BT_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Save.Location = new System.Drawing.Point(12, 324);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(99, 47);
            this.BT_Save.TabIndex = 15;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Cancel.Location = new System.Drawing.Point(141, 324);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(99, 47);
            this.BT_Cancel.TabIndex = 16;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 383);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.itemDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.itemProvider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemManufacturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SellPriceValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceValue);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemPicture);
            this.Name = "EditWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EditWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellPriceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.NumericUpDown PriceValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SellPriceValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemManufacturer;
        private System.Windows.Forms.TextBox itemProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.TextBox itemDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Cancel;
    }
}