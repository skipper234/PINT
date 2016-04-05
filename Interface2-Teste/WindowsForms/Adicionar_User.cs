using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface2_Teste
{

    public partial class Adicionar_User : Form
    {
        public event Activar_Mapa event_Activar_Mapa;

        Gestor Ges;

        public Adicionar_User(Gestor Ges)
        {
            InitializeComponent();

            this.Ges = Ges;
            this.FormClosing += Window_Closing;
        }

        private void Window_Closing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "Cancelar Inserção?", "Tem a certeza que quer cancelar a inserção ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    event_Activar_Mapa();
                    break;
                default:
                    break;
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            errorProviderValidarDados.Clear();

            if (txt_p_nome.Text == "")
                errorProviderValidarDados.SetError(txt_p_nome, "error");
            else if (txt_u_nome.Text == "")
                errorProviderValidarDados.SetError(txt_u_nome, "error");
            else if (txt_password.Text == "")
                errorProviderValidarDados.SetError(txt_password, "error");
            else if (txt_r_password.Text != txt_password.Text)
                errorProviderValidarDados.SetError(txt_r_password, "error");
            else if (!txt_cor_longitude.MaskCompleted)
                errorProviderValidarDados.SetError(txt_cor_longitude, "error");
            else if (!txt_cor_latitude.MaskCompleted)
                errorProviderValidarDados.SetError(txt_cor_latitude, "error");
            else if (cb_tipo_user.Text == "")
                errorProviderValidarDados.SetError(cb_tipo_user, "error");
            else
            {
                string nome = txt_p_nome.Text + " " + txt_u_nome.Text;
                Ges.adicionarUtilizador(nome, txt_password.Text, txt_cor_longitude.Text, txt_cor_latitude.Text, cb_tipo_user.Text);
            }
        }

        private void Adicionar_User_Load(object sender, EventArgs e)
        {

        }


    }
}
