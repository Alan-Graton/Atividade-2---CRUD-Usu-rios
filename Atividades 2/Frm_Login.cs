using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades_2
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            if(Txt_Usuario.Text.Equals("") || Txt_Senha.Text.Equals(""))
            {
                Lbl_Erro.Visible = true;
            }
            else
            {
                Frm_Cadastro cadastro = new Frm_Cadastro();
                this.Hide(); cadastro.Show();
                Lbl_Erro.Visible = false;
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja iniciar a forma automática?", "Atenção");
        }
    }
}
