using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Interface2_Teste
{
    public partial class Login : Form
    {
        Gestor Ges;

        public Login()
        {
            InitializeComponent();
            Ges = new Gestor();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // tenta conectar a base de dados
            if (!Ges.validarConnecaoBD())
            {
                lbl_info.Text = "Error: Inpossivel conectar a Base de Dados.";
                lbl_info.ForeColor = Color.Red;
                btn_entrar.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool loginValido = Ges.validarLogin(txt_username.Text, txt_password.Text);
            if (loginValido)
            {
                Inicio i = new Inicio(Ges);
                i.Show();
                this.Hide();
            }
            else
            {
                lbl_info.Text = "Error: Verifice os dados de Login.";
                lbl_info.ForeColor = Color.Red;
            }
          
        }
    }
}
