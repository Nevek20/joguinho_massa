using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinho_massa
{
    public partial class primeira_tela : Form
    {
        public primeira_tela()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void buttonCela_Click(object sender, EventArgs e)
        {
            cela form = new cela();
            form.ShowDialog();
        }
    }
}
