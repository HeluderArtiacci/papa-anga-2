namespace Inventario
{
    partial class BillingForm
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
            this.PanelOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.BT_selectEntries = new System.Windows.Forms.Button();
            this.BT_selectExits = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.dataNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerDate = new System.Windows.Forms.Label();
            this.PanelClientData = new System.Windows.Forms.Panel();
            this.ClientDNILabel = new System.Windows.Forms.Label();
            this.asdf = new System.Windows.Forms.Label();
            this.clientAddressLabel = new System.Windows.Forms.Label();
            this.labke = new System.Windows.Forms.Label();
            this.clienNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_Print = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.LabelList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PanelOptions.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PanelOptions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PanelContent);
            this.splitContainer1.Size = new System.Drawing.Size(1049, 616);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 0;
            // 
            // PanelOptions
            // 
            this.PanelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOptions.Controls.Add(this.BT_selectEntries);
            this.PanelOptions.Controls.Add(this.BT_selectExits);
            this.PanelOptions.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelOptions.Location = new System.Drawing.Point(0, 0);
            this.PanelOptions.Name = "PanelOptions";
            this.PanelOptions.Size = new System.Drawing.Size(107, 616);
            this.PanelOptions.TabIndex = 0;
            // 
            // BT_selectEntries
            // 
            this.BT_selectEntries.BackgroundImage = global::Inventario.Properties.Resources.Entrada1;
            this.BT_selectEntries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_selectEntries.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BT_selectEntries.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_selectEntries.Location = new System.Drawing.Point(3, 3);
            this.BT_selectEntries.Name = "BT_selectEntries";
            this.BT_selectEntries.Size = new System.Drawing.Size(100, 100);
            this.BT_selectEntries.TabIndex = 0;
            this.BT_selectEntries.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BT_selectEntries.UseVisualStyleBackColor = true;
            this.BT_selectEntries.Click += new System.EventHandler(this.BT_selectEntries_Click);
            // 
            // BT_selectExits
            // 
            this.BT_selectExits.BackgroundImage = global::Inventario.Properties.Resources.Salida1;
            this.BT_selectExits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_selectExits.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BT_selectExits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_selectExits.Location = new System.Drawing.Point(3, 109);
            this.BT_selectExits.Name = "BT_selectExits";
            this.BT_selectExits.Size = new System.Drawing.Size(100, 100);
            this.BT_selectExits.TabIndex = 1;
            this.BT_selectExits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BT_selectExits.UseVisualStyleBackColor = true;
            this.BT_selectExits.Click += new System.EventHandler(this.BT_selectExits_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelContent.Controls.Add(this.dataNameLabel);
            this.PanelContent.Controls.Add(this.panel1);
            this.PanelContent.Controls.Add(this.TotalLabel);
            this.PanelContent.Controls.Add(this.dataView);
            this.PanelContent.Controls.Add(this.panel2);
            this.PanelContent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(938, 616);
            this.PanelContent.TabIndex = 0;
            // 
            // dataNameLabel
            // 
            this.dataNameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataNameLabel.Location = new System.Drawing.Point(14, 85);
            this.dataNameLabel.Name = "dataNameLabel";
            this.dataNameLabel.Size = new System.Drawing.Size(677, 23);
            this.dataNameLabel.TabIndex = 13;
            this.dataNameLabel.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.registerDate);
            this.panel1.Controls.Add(this.PanelClientData);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BT_Print);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(706, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 616);
            this.panel1.TabIndex = 11;
            // 
            // registerDate
            // 
            this.registerDate.AutoSize = true;
            this.registerDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.registerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registerDate.Location = new System.Drawing.Point(9, 89);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(0, 17);
            this.registerDate.TabIndex = 7;
            // 
            // PanelClientData
            // 
            this.PanelClientData.Controls.Add(this.ClientDNILabel);
            this.PanelClientData.Controls.Add(this.asdf);
            this.PanelClientData.Controls.Add(this.clientAddressLabel);
            this.PanelClientData.Controls.Add(this.labke);
            this.PanelClientData.Controls.Add(this.clienNameLabel);
            this.PanelClientData.Controls.Add(this.label1);
            this.PanelClientData.Location = new System.Drawing.Point(-1, 111);
            this.PanelClientData.Name = "PanelClientData";
            this.PanelClientData.Size = new System.Drawing.Size(226, 504);
            this.PanelClientData.TabIndex = 2;
            this.PanelClientData.Click += new System.EventHandler(this.BT_selectEntries_Click);
            // 
            // ClientDNILabel
            // 
            this.ClientDNILabel.AutoSize = true;
            this.ClientDNILabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientDNILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClientDNILabel.Location = new System.Drawing.Point(10, 120);
            this.ClientDNILabel.Name = "ClientDNILabel";
            this.ClientDNILabel.Size = new System.Drawing.Size(0, 17);
            this.ClientDNILabel.TabIndex = 5;
            // 
            // asdf
            // 
            this.asdf.AutoSize = true;
            this.asdf.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.asdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asdf.Location = new System.Drawing.Point(10, 107);
            this.asdf.Name = "asdf";
            this.asdf.Size = new System.Drawing.Size(143, 13);
            this.asdf.TabIndex = 4;
            this.asdf.Text = "RIF o C.I. N° del cliente";
            // 
            // clientAddressLabel
            // 
            this.clientAddressLabel.AutoSize = true;
            this.clientAddressLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clientAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clientAddressLabel.Location = new System.Drawing.Point(10, 73);
            this.clientAddressLabel.Name = "clientAddressLabel";
            this.clientAddressLabel.Size = new System.Drawing.Size(0, 17);
            this.clientAddressLabel.TabIndex = 3;
            // 
            // labke
            // 
            this.labke.AutoSize = true;
            this.labke.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labke.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labke.Location = new System.Drawing.Point(10, 60);
            this.labke.Name = "labke";
            this.labke.Size = new System.Drawing.Size(124, 13);
            this.labke.TabIndex = 2;
            this.labke.Text = "Dirección del cliente";
            // 
            // clienNameLabel
            // 
            this.clienNameLabel.AutoSize = true;
            this.clienNameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clienNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clienNameLabel.Location = new System.Drawing.Point(10, 29);
            this.clienNameLabel.Name = "clienNameLabel";
            this.clienNameLabel.Size = new System.Drawing.Size(0, 17);
            this.clienNameLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha del registro";
            // 
            // BT_Print
            // 
            this.BT_Print.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BT_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Print.Location = new System.Drawing.Point(12, 14);
            this.BT_Print.Name = "BT_Print";
            this.BT_Print.Size = new System.Drawing.Size(201, 45);
            this.BT_Print.TabIndex = 1;
            this.BT_Print.Text = "Imprimir";
            this.BT_Print.UseVisualStyleBackColor = true;
            this.BT_Print.Click += new System.EventHandler(this.BT_Print_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(586, 565);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(105, 26);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "$ 0";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AllowUserToResizeRows = false;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataView.Location = new System.Drawing.Point(14, 110);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(677, 456);
            this.dataView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FilterBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dropDown);
            this.panel2.Controls.Add(this.LabelList);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 76);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FilterBox
            // 
            this.FilterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FilterBox.Location = new System.Drawing.Point(400, 19);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(292, 20);
            this.FilterBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(660, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtrar";
            // 
            // dropDown
            // 
            this.dropDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown.FormattingEnabled = true;
            this.dropDown.Location = new System.Drawing.Point(15, 45);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(677, 21);
            this.dropDown.TabIndex = 1;
            this.dropDown.SelectedIndexChanged += new System.EventHandler(this.dropDown_SelectedIndexChanged);
            // 
            // LabelList
            // 
            this.LabelList.AutoSize = true;
            this.LabelList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LabelList.Location = new System.Drawing.Point(12, 29);
            this.LabelList.Name = "LabelList";
            this.LabelList.Size = new System.Drawing.Size(91, 13);
            this.LabelList.TabIndex = 8;
            this.LabelList.Text = "Lista de Registros";
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 616);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BillingForm";
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PanelOptions.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelClientData.ResumeLayout(false);
            this.PanelClientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel PanelOptions;
        private System.Windows.Forms.Button BT_selectEntries;
        private System.Windows.Forms.Button BT_selectExits;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Label LabelList;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label dataNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelClientData;
        private System.Windows.Forms.Button BT_Print;
        private System.Windows.Forms.Label clienNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClientDNILabel;
        private System.Windows.Forms.Label asdf;
        private System.Windows.Forms.Label clientAddressLabel;
        private System.Windows.Forms.Label labke;
        private System.Windows.Forms.Label registerDate;
        private System.Windows.Forms.Label label4;
    }
}