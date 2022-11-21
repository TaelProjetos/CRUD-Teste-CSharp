namespace CRUD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String user = txbUsuario.Text;
            String password = txbSenha.Text;

            if(user == "Thales" && password == "rola")
            {
                MessageBox.Show("Logado");
                Menu menu = new Menu();
                this.Hide();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Não logado");
                txbSenha.Focus();
                txbSenha.SelectAll();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}