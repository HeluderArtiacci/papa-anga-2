using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class LoadingForm : Form
    {
        private Label loadingLabel;

        public LoadingForm(string loadingText)
        {
            Text = "Cargando...";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            ShowInTaskbar = false;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Size = new Size(200, 100);

            loadingLabel = new Label();
            loadingLabel.Text = loadingText;
            loadingLabel.AutoSize = false;
            loadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            loadingLabel.Dock = DockStyle.Fill;
            Controls.Add(loadingLabel);
        }
    }
}
