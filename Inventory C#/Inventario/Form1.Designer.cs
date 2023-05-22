namespace Inventario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_NewItem = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.BT_print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1059, 85);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.TabStop = true;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BT_print);
            this.panel1.Controls.Add(this.BT_NewItem);
            this.panel1.Controls.Add(this.dataView);
            this.panel1.Location = new System.Drawing.Point(5, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 615);
            this.panel1.TabIndex = 4;
            // 
            // BT_NewItem
            // 
            this.BT_NewItem.Location = new System.Drawing.Point(716, 4);
            this.BT_NewItem.Name = "BT_NewItem";
            this.BT_NewItem.Size = new System.Drawing.Size(117, 62);
            this.BT_NewItem.TabIndex = 1;
            this.BT_NewItem.Text = "button1";
            this.BT_NewItem.UseVisualStyleBackColor = true;
            this.BT_NewItem.Click += new System.EventHandler(this.BT_NewItem_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AllowUserToResizeColumns = false;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataView.ColumnHeadersHeight = 25;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataView.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataView.Location = new System.Drawing.Point(3, 3);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(706, 605);
            this.dataView.TabIndex = 0;
            this.dataView.VirtualMode = true;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // BT_print
            // 
            this.BT_print.Location = new System.Drawing.Point(716, 72);
            this.BT_print.Name = "BT_print";
            this.BT_print.Size = new System.Drawing.Size(75, 23);
            this.BT_print.TabIndex = 2;
            this.BT_print.Text = "button1";
            this.BT_print.UseVisualStyleBackColor = true;
            this.BT_print.Click += new System.EventHandler(this.BT_print_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button BT_NewItem;
        private System.Windows.Forms.Button BT_print;
    }
}

