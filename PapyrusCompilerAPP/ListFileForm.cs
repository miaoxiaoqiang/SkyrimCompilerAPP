using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightPapyrusCompiler
{
    public partial class ListFileForm : Form
    {
        public ListFileForm()
        {
            InitializeComponent();
        }

        private void ListFileForm_Load(object sender, EventArgs e)
        {

        }

        private void ListFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
