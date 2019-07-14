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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            cmbxSurfaceMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddQuote_Click(object sender, EventArgs e)
        {
           DisplayQuote viewDisplayQuotes = new DisplayQuote();
            viewDisplayQuotes.Tag = this;
            viewDisplayQuotes.Show(this);
            //this.Hide()
        }

        private void CmbxSurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
