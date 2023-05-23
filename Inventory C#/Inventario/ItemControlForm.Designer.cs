namespace Inventario
{
    partial class ItemControlForm
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
            this.PrincipalPanel = new System.Windows.Forms.Panel();
            this.BT_DeleteItem = new System.Windows.Forms.Button();
            this.BT_print = new System.Windows.Forms.Button();
            this.BT_NewItem = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.BT_Edit = new System.Windows.Forms.Button();
            this.itemPicture = new System.Windows.Forms.PictureBox();
            this.PrincipalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PrincipalPanel
            // 
            this.PrincipalPanel.AutoSize = true;
            this.PrincipalPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrincipalPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrincipalPanel.Controls.Add(this.itemPicture);
            this.PrincipalPanel.Controls.Add(this.BT_Edit);
            this.PrincipalPanel.Controls.Add(this.BT_DeleteItem);
            this.PrincipalPanel.Controls.Add(this.BT_print);
            this.PrincipalPanel.Controls.Add(this.BT_NewItem);
            this.PrincipalPanel.Controls.Add(this.dataView);
            this.PrincipalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrincipalPanel.Location = new System.Drawing.Point(0, 0);
            this.PrincipalPanel.Name = "PrincipalPanel";
            this.PrincipalPanel.Size = new System.Drawing.Size(1051, 616);
            this.PrincipalPanel.TabIndex = 5;
            // 
            // BT_DeleteItem
            // 
            this.BT_DeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_DeleteItem.Location = new System.Drawing.Point(183, 4);
            this.BT_DeleteItem.Name = "BT_DeleteItem";
            this.BT_DeleteItem.Size = new System.Drawing.Size(75, 23);
            this.BT_DeleteItem.TabIndex = 3;
            this.BT_DeleteItem.Text = "Delete Item";
            this.BT_DeleteItem.UseVisualStyleBackColor = true;
            this.BT_DeleteItem.Click += new System.EventHandler(this.BT_DeleteItem_Click);
            // 
            // BT_print
            // 
            this.BT_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_print.Location = new System.Drawing.Point(634, 4);
            this.BT_print.Name = "BT_print";
            this.BT_print.Size = new System.Drawing.Size(75, 23);
            this.BT_print.TabIndex = 2;
            this.BT_print.Text = "Print";
            this.BT_print.UseVisualStyleBackColor = true;
            this.BT_print.Click += new System.EventHandler(this.BT_print_Click);
            // 
            // BT_NewItem
            // 
            this.BT_NewItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_NewItem.Location = new System.Drawing.Point(3, 4);
            this.BT_NewItem.Name = "BT_NewItem";
            this.BT_NewItem.Size = new System.Drawing.Size(84, 23);
            this.BT_NewItem.TabIndex = 1;
            this.BT_NewItem.Text = "Add Item";
            this.BT_NewItem.UseVisualStyleBackColor = true;
            this.BT_NewItem.Click += new System.EventHandler(this.BT_NewItem_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AllowUserToResizeColumns = false;
            this.dataView.AllowUserToResizeRows = false;
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
            this.dataView.Location = new System.Drawing.Point(3, 33);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(706, 576);
            this.dataView.TabIndex = 0;
            this.dataView.VirtualMode = true;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            this.dataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellDoubleClick);
            // 
            // BT_Edit
            // 
            this.BT_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Edit.Location = new System.Drawing.Point(93, 4);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(84, 23);
            this.BT_Edit.TabIndex = 4;
            this.BT_Edit.Text = "Edit Item";
            this.BT_Edit.UseVisualStyleBackColor = true;
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // itemPicture
            // 
            this.itemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPicture.Image = global::Inventario.Properties.Resources.missingImage;
            this.itemPicture.Location = new System.Drawing.Point(715, 33);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Padding = new System.Windows.Forms.Padding(5);
            this.itemPicture.Size = new System.Drawing.Size(225, 225);
            this.itemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemPicture.TabIndex = 5;
            this.itemPicture.TabStop = false;
            // 
            // ItemControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1051, 616);
            this.Controls.Add(this.PrincipalPanel);
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "ItemControlForm";
            this.Text = "ItemControlForm";
            this.Load += new System.EventHandler(this.ItemControlForm_Load);
            this.PrincipalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PrincipalPanel;
        private System.Windows.Forms.Button BT_DeleteItem;
        private System.Windows.Forms.Button BT_print;
        private System.Windows.Forms.Button BT_NewItem;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button BT_Edit;
        private System.Windows.Forms.PictureBox itemPicture;
    }
}