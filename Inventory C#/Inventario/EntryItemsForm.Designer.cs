namespace Inventario
{
    partial class EntryItemsForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.filterItems = new System.Windows.Forms.TextBox();
            this.itemCode = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.entryNameFill = new System.Windows.Forms.TextBox();
            this.BT_AddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EntryDate = new System.Windows.Forms.MonthCalendar();
            this.productCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsDropDown = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.BT_cancelEntry = new System.Windows.Forms.Button();
            this.BT_saveEntry = new System.Windows.Forms.Button();
            this.BT_NewEntry = new System.Windows.Forms.Button();
            this.EntryNameLabel = new System.Windows.Forms.Label();
            this.itemPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EditPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1049, 616);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.filterItems);
            this.EditPanel.Controls.Add(this.itemCode);
            this.EditPanel.Controls.Add(this.SubTotalLabel);
            this.EditPanel.Controls.Add(this.label9);
            this.EditPanel.Controls.Add(this.nameLabel);
            this.EditPanel.Controls.Add(this.sellPriceLabel);
            this.EditPanel.Controls.Add(this.label8);
            this.EditPanel.Controls.Add(this.priceLabel);
            this.EditPanel.Controls.Add(this.label6);
            this.EditPanel.Controls.Add(this.stockLabel);
            this.EditPanel.Controls.Add(this.label5);
            this.EditPanel.Controls.Add(this.itemPicture);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.entryNameFill);
            this.EditPanel.Controls.Add(this.BT_AddProduct);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.EntryDate);
            this.EditPanel.Controls.Add(this.productCount);
            this.EditPanel.Controls.Add(this.label1);
            this.EditPanel.Controls.Add(this.itemsDropDown);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditPanel.Location = new System.Drawing.Point(0, 0);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(268, 612);
            this.EditPanel.TabIndex = 0;
            // 
            // filterItems
            // 
            this.filterItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterItems.Location = new System.Drawing.Point(7, 276);
            this.filterItems.Name = "filterItems";
            this.filterItems.Size = new System.Drawing.Size(100, 20);
            this.filterItems.TabIndex = 53;
            this.filterItems.TextChanged += new System.EventHandler(this.filterItems_TextChanged);
            // 
            // itemCode
            // 
            this.itemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemCode.Location = new System.Drawing.Point(151, 334);
            this.itemCode.Name = "itemCode";
            this.itemCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemCode.Size = new System.Drawing.Size(105, 17);
            this.itemCode.TabIndex = 52;
            this.itemCode.Text = "Default";
            this.itemCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SubTotalLabel.Location = new System.Drawing.Point(84, 494);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(34, 25);
            this.SubTotalLabel.TabIndex = 51;
            this.SubTotalLabel.Text = "$0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(3, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Subtotal:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(7, 334);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 17);
            this.nameLabel.TabIndex = 49;
            this.nameLabel.Text = "Default";
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.AutoSize = true;
            this.sellPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sellPriceLabel.Location = new System.Drawing.Point(146, 469);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(34, 25);
            this.sellPriceLabel.TabIndex = 48;
            this.sellPriceLabel.Text = "$0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(2, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Precio de venta:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.priceLabel.Location = new System.Drawing.Point(68, 444);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 25);
            this.priceLabel.TabIndex = 46;
            this.priceLabel.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(3, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Precio:";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.BackColor = System.Drawing.Color.Transparent;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stockLabel.Location = new System.Drawing.Point(170, 360);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(16, 17);
            this.stockLabel.TabIndex = 44;
            this.stockLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(91, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Disponibles: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nombre de la entrada";
            // 
            // entryNameFill
            // 
            this.entryNameFill.Location = new System.Drawing.Point(7, 23);
            this.entryNameFill.Name = "entryNameFill";
            this.entryNameFill.Size = new System.Drawing.Size(245, 20);
            this.entryNameFill.TabIndex = 40;
            this.entryNameFill.TextChanged += new System.EventHandler(this.entryNameFill_TextChanged);
            // 
            // BT_AddProduct
            // 
            this.BT_AddProduct.Location = new System.Drawing.Point(6, 539);
            this.BT_AddProduct.Name = "BT_AddProduct";
            this.BT_AddProduct.Size = new System.Drawing.Size(250, 23);
            this.BT_AddProduct.TabIndex = 39;
            this.BT_AddProduct.Text = "Añadir";
            this.BT_AddProduct.UseVisualStyleBackColor = true;
            this.BT_AddProduct.Click += new System.EventHandler(this.BT_AddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha de entrega";
            // 
            // EntryDate
            // 
            this.EntryDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.EntryDate.Location = new System.Drawing.Point(7, 79);
            this.EntryDate.MaxSelectionCount = 1;
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ShowToday = false;
            this.EntryDate.ShowTodayCircle = false;
            this.EntryDate.TabIndex = 37;
            this.EntryDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EntryDate_DateChanged);
            // 
            // productCount
            // 
            this.productCount.Location = new System.Drawing.Point(211, 301);
            this.productCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(45, 20);
            this.productCount.TabIndex = 36;
            this.productCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productCount.ValueChanged += new System.EventHandler(this.productCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Añadir Producto";
            // 
            // itemsDropDown
            // 
            this.itemsDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemsDropDown.FormattingEnabled = true;
            this.itemsDropDown.Location = new System.Drawing.Point(7, 301);
            this.itemsDropDown.MaxDropDownItems = 10;
            this.itemsDropDown.Name = "itemsDropDown";
            this.itemsDropDown.Size = new System.Drawing.Size(197, 21);
            this.itemsDropDown.TabIndex = 34;
            this.itemsDropDown.SelectedIndexChanged += new System.EventHandler(this.itemsDropDown_SelectedIndexChanged);
            this.itemsDropDown.TextChanged += new System.EventHandler(this.itemsDropDown_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataView);
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.BT_cancelEntry);
            this.panel1.Controls.Add(this.BT_saveEntry);
            this.panel1.Controls.Add(this.BT_NewEntry);
            this.panel1.Controls.Add(this.EntryNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 612);
            this.panel1.TabIndex = 1;
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(32, 97);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(700, 420);
            this.dataView.TabIndex = 0;
            // 
            // TotalLabel
            // 
            this.TotalLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(627, 516);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(105, 26);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "$ 0";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BT_cancelEntry
            // 
            this.BT_cancelEntry.Location = new System.Drawing.Point(484, 553);
            this.BT_cancelEntry.Name = "BT_cancelEntry";
            this.BT_cancelEntry.Size = new System.Drawing.Size(121, 41);
            this.BT_cancelEntry.TabIndex = 5;
            this.BT_cancelEntry.Text = "Cancelar";
            this.BT_cancelEntry.UseVisualStyleBackColor = true;
            this.BT_cancelEntry.Click += new System.EventHandler(this.BT_cancelEntry_Click);
            // 
            // BT_saveEntry
            // 
            this.BT_saveEntry.Location = new System.Drawing.Point(611, 553);
            this.BT_saveEntry.Name = "BT_saveEntry";
            this.BT_saveEntry.Size = new System.Drawing.Size(121, 41);
            this.BT_saveEntry.TabIndex = 4;
            this.BT_saveEntry.Text = "Guardar entrada";
            this.BT_saveEntry.UseVisualStyleBackColor = true;
            this.BT_saveEntry.Click += new System.EventHandler(this.BT_saveEntry_Click);
            // 
            // BT_NewEntry
            // 
            this.BT_NewEntry.Location = new System.Drawing.Point(32, 49);
            this.BT_NewEntry.Name = "BT_NewEntry";
            this.BT_NewEntry.Size = new System.Drawing.Size(139, 42);
            this.BT_NewEntry.TabIndex = 3;
            this.BT_NewEntry.Text = "Nuevo registro de entrada";
            this.BT_NewEntry.UseVisualStyleBackColor = true;
            this.BT_NewEntry.Click += new System.EventHandler(this.BT_NewEntry_Click);
            // 
            // EntryNameLabel
            // 
            this.EntryNameLabel.AutoSize = true;
            this.EntryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EntryNameLabel.Location = new System.Drawing.Point(29, 23);
            this.EntryNameLabel.Name = "EntryNameLabel";
            this.EntryNameLabel.Size = new System.Drawing.Size(78, 17);
            this.EntryNameLabel.TabIndex = 2;
            this.EntryNameLabel.Text = "EntryName";
            // 
            // itemPicture
            // 
            this.itemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPicture.Image = global::Inventario.Properties.Resources.missingImage;
            this.itemPicture.Location = new System.Drawing.Point(7, 359);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Padding = new System.Windows.Forms.Padding(5);
            this.itemPicture.Size = new System.Drawing.Size(80, 80);
            this.itemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemPicture.TabIndex = 42;
            this.itemPicture.TabStop = false;
            // 
            // EntryItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 616);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EntryItemsForm";
            this.Text = "EntryItemsForm";
            this.Load += new System.EventHandler(this.EntryItemsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_NewEntry;
        private System.Windows.Forms.Label EntryNameLabel;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label itemCode;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox itemPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entryNameFill;
        private System.Windows.Forms.Button BT_AddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar EntryDate;
        private System.Windows.Forms.NumericUpDown productCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemsDropDown;
        private System.Windows.Forms.TextBox filterItems;
        private System.Windows.Forms.Button BT_cancelEntry;
        private System.Windows.Forms.Button BT_saveEntry;
        private System.Windows.Forms.Label TotalLabel;
    }
}