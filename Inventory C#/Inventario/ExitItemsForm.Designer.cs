namespace Inventario
{
    partial class ExitItemsForm
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
            this.label24158 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockLabelName = new System.Windows.Forms.Label();
            this.itemPicture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitNameFill = new System.Windows.Forms.TextBox();
            this.BT_AddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitDate = new System.Windows.Forms.MonthCalendar();
            this.productCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsDropDown = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.BT_cancelEntry = new System.Windows.Forms.Button();
            this.BT_saveExit = new System.Windows.Forms.Button();
            this.BT_NewExit = new System.Windows.Forms.Button();
            this.ExitNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientNameFill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DNIclientFill = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.addresClientFill = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
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
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 1;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.label7);
            this.EditPanel.Controls.Add(this.addresClientFill);
            this.EditPanel.Controls.Add(this.label6);
            this.EditPanel.Controls.Add(this.DNIclientFill);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.clientNameFill);
            this.EditPanel.Controls.Add(this.ExitDate);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.ExitNameFill);
            this.EditPanel.Controls.Add(this.panel2);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditPanel.Location = new System.Drawing.Point(0, 0);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(267, 612);
            this.EditPanel.TabIndex = 0;
            // 
            // filterItems
            // 
            this.filterItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterItems.Location = new System.Drawing.Point(10, 29);
            this.filterItems.Name = "filterItems";
            this.filterItems.Size = new System.Drawing.Size(100, 20);
            this.filterItems.TabIndex = 53;
            this.filterItems.TextChanged += new System.EventHandler(this.itemsDropDown_TextChanged);
            // 
            // itemCode
            // 
            this.itemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemCode.Location = new System.Drawing.Point(153, 78);
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
            this.SubTotalLabel.Location = new System.Drawing.Point(86, 211);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(34, 25);
            this.SubTotalLabel.TabIndex = 51;
            this.SubTotalLabel.Text = "$0";
            // 
            // label24158
            // 
            this.label24158.AutoSize = true;
            this.label24158.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label24158.Location = new System.Drawing.Point(5, 211);
            this.label24158.Name = "label24158";
            this.label24158.Size = new System.Drawing.Size(90, 25);
            this.label24158.TabIndex = 50;
            this.label24158.Text = "Subtotal:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(9, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 17);
            this.nameLabel.TabIndex = 49;
            this.nameLabel.Text = "Default";
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.AutoSize = true;
            this.sellPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sellPriceLabel.Location = new System.Drawing.Point(148, 186);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(34, 25);
            this.sellPriceLabel.TabIndex = 48;
            this.sellPriceLabel.Text = "$0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(4, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Precio de venta:";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.BackColor = System.Drawing.Color.Transparent;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stockLabel.Location = new System.Drawing.Point(172, 104);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(16, 17);
            this.stockLabel.TabIndex = 44;
            this.stockLabel.Text = "0";
            this.stockLabel.Click += new System.EventHandler(this.stockLabel_Click);
            // 
            // stockLabelName
            // 
            this.stockLabelName.AutoSize = true;
            this.stockLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stockLabelName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stockLabelName.Location = new System.Drawing.Point(93, 103);
            this.stockLabelName.Name = "stockLabelName";
            this.stockLabelName.Size = new System.Drawing.Size(89, 17);
            this.stockLabelName.TabIndex = 43;
            this.stockLabelName.Text = "Disponibles: ";
            // 
            // itemPicture
            // 
            this.itemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPicture.Image = global::Inventario.Properties.Resources.missingImage;
            this.itemPicture.Location = new System.Drawing.Point(9, 103);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Padding = new System.Windows.Forms.Padding(5);
            this.itemPicture.Size = new System.Drawing.Size(80, 80);
            this.itemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemPicture.TabIndex = 42;
            this.itemPicture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nombre de la venta";
            // 
            // ExitNameFill
            // 
            this.ExitNameFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitNameFill.Location = new System.Drawing.Point(8, 23);
            this.ExitNameFill.Name = "ExitNameFill";
            this.ExitNameFill.Size = new System.Drawing.Size(245, 20);
            this.ExitNameFill.TabIndex = 40;
            this.ExitNameFill.TextChanged += new System.EventHandler(this.ExitNameFill_TextChanged);
            // 
            // BT_AddProduct
            // 
            this.BT_AddProduct.Location = new System.Drawing.Point(8, 241);
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
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha de venta";
            // 
            // ExitDate
            // 
            this.ExitDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExitDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.ExitDate.Location = new System.Drawing.Point(8, 174);
            this.ExitDate.MaxSelectionCount = 1;
            this.ExitDate.Name = "ExitDate";
            this.ExitDate.ShowToday = false;
            this.ExitDate.ShowTodayCircle = false;
            this.ExitDate.TabIndex = 37;
            // 
            // productCount
            // 
            this.productCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productCount.Location = new System.Drawing.Point(214, 54);
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
            this.label1.Location = new System.Drawing.Point(9, 13);
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
            this.itemsDropDown.Location = new System.Drawing.Point(10, 54);
            this.itemsDropDown.MaxDropDownItems = 10;
            this.itemsDropDown.Name = "itemsDropDown";
            this.itemsDropDown.Size = new System.Drawing.Size(197, 21);
            this.itemsDropDown.TabIndex = 34;
            this.itemsDropDown.SelectedIndexChanged += new System.EventHandler(this.itemsDropDown_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataView);
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.BT_cancelEntry);
            this.panel1.Controls.Add(this.BT_saveExit);
            this.panel1.Controls.Add(this.BT_NewExit);
            this.panel1.Controls.Add(this.ExitNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 612);
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
            this.TotalLabel.TabIndex = 6;
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
            // 
            // BT_saveExit
            // 
            this.BT_saveExit.Location = new System.Drawing.Point(611, 553);
            this.BT_saveExit.Name = "BT_saveExit";
            this.BT_saveExit.Size = new System.Drawing.Size(121, 41);
            this.BT_saveExit.TabIndex = 4;
            this.BT_saveExit.Text = "Guardar Venta";
            this.BT_saveExit.UseVisualStyleBackColor = true;
            this.BT_saveExit.Click += new System.EventHandler(this.BT_saveExit_Click);
            // 
            // BT_NewExit
            // 
            this.BT_NewExit.Location = new System.Drawing.Point(32, 43);
            this.BT_NewExit.Name = "BT_NewExit";
            this.BT_NewExit.Size = new System.Drawing.Size(140, 42);
            this.BT_NewExit.TabIndex = 3;
            this.BT_NewExit.Text = "Nuevo registro de venta";
            this.BT_NewExit.UseVisualStyleBackColor = true;
            this.BT_NewExit.Click += new System.EventHandler(this.BT_NewExit_Click);
            // 
            // ExitNameLabel
            // 
            this.ExitNameLabel.AutoSize = true;
            this.ExitNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExitNameLabel.Location = new System.Drawing.Point(29, 23);
            this.ExitNameLabel.Name = "ExitNameLabel";
            this.ExitNameLabel.Size = new System.Drawing.Size(67, 17);
            this.ExitNameLabel.TabIndex = 2;
            this.ExitNameLabel.Text = "ExitName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Nombre del cliente";
            // 
            // clientNameFill
            // 
            this.clientNameFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientNameFill.Location = new System.Drawing.Point(8, 63);
            this.clientNameFill.Name = "clientNameFill";
            this.clientNameFill.Size = new System.Drawing.Size(245, 20);
            this.clientNameFill.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "RIF o C.I. N° del cliente";
            // 
            // DNIclientFill
            // 
            this.DNIclientFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DNIclientFill.Location = new System.Drawing.Point(9, 102);
            this.DNIclientFill.Name = "DNIclientFill";
            this.DNIclientFill.Size = new System.Drawing.Size(245, 20);
            this.DNIclientFill.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.stockLabel);
            this.panel2.Controls.Add(this.sellPriceLabel);
            this.panel2.Controls.Add(this.filterItems);
            this.panel2.Controls.Add(this.itemsDropDown);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.productCount);
            this.panel2.Controls.Add(this.BT_AddProduct);
            this.panel2.Controls.Add(this.itemCode);
            this.panel2.Controls.Add(this.itemPicture);
            this.panel2.Controls.Add(this.SubTotalLabel);
            this.panel2.Controls.Add(this.stockLabelName);
            this.panel2.Controls.Add(this.label24158);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 270);
            this.panel2.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Domicilio fiscal";
            // 
            // addresClientFill
            // 
            this.addresClientFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addresClientFill.Location = new System.Drawing.Point(9, 141);
            this.addresClientFill.Name = "addresClientFill";
            this.addresClientFill.Size = new System.Drawing.Size(245, 20);
            this.addresClientFill.TabIndex = 59;
            // 
            // ExitItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 616);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ExitItemsForm";
            this.Text = "ExitItems";
            this.Load += new System.EventHandler(this.ExitItems_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.TextBox filterItems;
        private System.Windows.Forms.Label itemCode;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label label24158;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label stockLabelName;
        private System.Windows.Forms.PictureBox itemPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExitNameFill;
        private System.Windows.Forms.Button BT_AddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar ExitDate;
        private System.Windows.Forms.NumericUpDown productCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemsDropDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_cancelEntry;
        private System.Windows.Forms.Button BT_saveExit;
        private System.Windows.Forms.Button BT_NewExit;
        private System.Windows.Forms.Label ExitNameLabel;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DNIclientFill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientNameFill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addresClientFill;
    }
}