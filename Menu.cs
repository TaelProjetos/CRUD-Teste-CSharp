using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Tela()
        {
            Produtos prod = new Produtos();
            this.Hide();
            prod.Closed += (s, args) => this.Close();
            prod.Show();
        }

        private void htsProd_Click(object sender, EventArgs e)
        {
            Tela();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            Tela();
        }

        private void mnsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void mntMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            //Funcionario func = new Funcionario();
            //this.Hide();
            //func.Closed += (s, args) => this.Close();
            //func.Show();
        }
    }
}
