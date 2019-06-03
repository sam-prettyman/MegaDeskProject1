using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskProject_1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
           //this.Hide();
            
        }

        private void BtnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewQuotes viewViewQuotes = new ViewQuotes();
            viewViewQuotes.Tag = this;
            viewViewQuotes.Show(this);
            //this.Hide();
        }

        private void BtnSeachQuotes_Click(object sender, EventArgs e)
        {
            SeachQuotes viewSeachQuotes = new SeachQuotes();
            viewSeachQuotes.Tag = this;
            viewSeachQuotes.Show(this);
            //this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
