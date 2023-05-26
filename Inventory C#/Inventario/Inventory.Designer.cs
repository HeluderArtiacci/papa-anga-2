namespace Inventario
{
    partial class Inventory
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
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.BT_Items = new System.Windows.Forms.Button();
            this.BT_EntryItems = new System.Windows.Forms.Button();
            this.BT_ExitItems = new System.Windows.Forms.Button();
            this.BT_CheckIn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.BT_Items);
            this.flowLayoutPanel1.Controls.Add(this.BT_EntryItems);
            this.flowLayoutPanel1.Controls.Add(this.BT_ExitItems);
            this.flowLayoutPanel1.Controls.Add(this.BT_CheckIn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1059, 85);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChildFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChildFormPanel.Location = new System.Drawing.Point(5, 91);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(1050, 615);
            this.ChildFormPanel.TabIndex = 4;
            // 
            // BT_Items
            // 
            this.BT_Items.BackgroundImage = global::Inventario.Properties.Resources.Articulos2;
            this.BT_Items.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Items.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Items.Location = new System.Drawing.Point(4, 4);
            this.BT_Items.Name = "BT_Items";
            this.BT_Items.Size = new System.Drawing.Size(220, 75);
            this.BT_Items.TabIndex = 0;
            this.BT_Items.UseVisualStyleBackColor = true;
            this.BT_Items.Click += new System.EventHandler(this.BT_Items_Click);
            // 
            // BT_EntryItems
            // 
            this.BT_EntryItems.BackgroundImage = global::Inventario.Properties.Resources.Entrada2;
            this.BT_EntryItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_EntryItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_EntryItems.Location = new System.Drawing.Point(230, 4);
            this.BT_EntryItems.Name = "BT_EntryItems";
            this.BT_EntryItems.Size = new System.Drawing.Size(220, 75);
            this.BT_EntryItems.TabIndex = 1;
            this.BT_EntryItems.UseVisualStyleBackColor = true;
            this.BT_EntryItems.Click += new System.EventHandler(this.BT_EntryItems_Click);
            // 
            // BT_ExitItems
            // 
            this.BT_ExitItems.BackgroundImage = global::Inventario.Properties.Resources.Salida2;
            this.BT_ExitItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_ExitItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ExitItems.Location = new System.Drawing.Point(456, 4);
            this.BT_ExitItems.Name = "BT_ExitItems";
            this.BT_ExitItems.Size = new System.Drawing.Size(220, 75);
            this.BT_ExitItems.TabIndex = 2;
            this.BT_ExitItems.UseVisualStyleBackColor = true;
            this.BT_ExitItems.Click += new System.EventHandler(this.BT_ExitItems_Click);
            // 
            // BT_CheckIn
            // 
            this.BT_CheckIn.BackgroundImage = global::Inventario.Properties.Resources.Facturacion2;
            this.BT_CheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_CheckIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CheckIn.Location = new System.Drawing.Point(682, 4);
            this.BT_CheckIn.Name = "BT_CheckIn";
            this.BT_CheckIn.Size = new System.Drawing.Size(220, 75);
            this.BT_CheckIn.TabIndex = 3;
            this.BT_CheckIn.UseVisualStyleBackColor = true;
            this.BT_CheckIn.Click += new System.EventHandler(this.BT_CheckIn_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 711);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventory_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Button BT_Items;
        private System.Windows.Forms.Button BT_EntryItems;
        private System.Windows.Forms.Button BT_ExitItems;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BT_CheckIn;
    }
}

