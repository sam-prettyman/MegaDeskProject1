using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDeskProject_1.Desk;

namespace MegaDeskProject_1
{
    public partial class SeachQuotes : Form
    {
        public SeachQuotes()
        {
            InitializeComponent();
            cmbxSurfaceMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
