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
    public partial class Massa : Form
    {
        public Massa()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primeira_tela form = new primeira_tela();
            form.ShowDialog();
        }
    }
}
