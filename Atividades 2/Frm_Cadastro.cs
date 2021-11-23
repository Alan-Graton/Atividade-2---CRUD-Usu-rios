using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using DAL;

namespace Atividades_2
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void Frm_Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string UsuarioAtivo;
            if(Txt_Nome.Text.Equals("") || Txt_Email.Text.Equals("") || Mktxt_CPF.Text.Equals(""))
            {
                Lbl_Erro_Cadastro.Visible = true;
            }
            else
            {
                _ = (CkBx_Status.Checked) ? UsuarioAtivo = "Ativo" : UsuarioAtivo = "Inativo";
                Lbl_Erro_Cadastro.Visible = false;
                Usuario usuario = new Usuario(Txt_Nome.Text, Mktxt_CPF.Text, Txt_Email.Text, UsuarioAtivo);
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                MessageBox.Show(usuarioDAL.AddUsuarios(usuario));

                Txt_Nome.Clear();
                Mktxt_CPF.Clear();
                Txt_Email.Clear();

                DataTable table = new DataTable();
                List<Usuario> list = new List<Usuario>();
                list = usuarioDAL.ListarUsuarios(out string retorno);
                MessageBox.Show(retorno);
                DataGrid.DataSource = list;
            }
        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            MessageBox.Show(usuarioDAL.DeleteUsuarios(Txt_Nome.Text));
            Txt_Nome.Clear();
            Mktxt_CPF.Clear();
            Txt_Email.Clear();

            DataTable table = new DataTable();
            List<Usuario> list = new List<Usuario>();
            list = usuarioDAL.ListarUsuarios(out string retorno);
            DataGrid.DataSource = list;
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            string usuarioAtivo = "";
            _ = (CkBx_Status.Checked) ? usuarioAtivo = "Ativo" : usuarioAtivo = "Inativo";
            Usuario usuario = new Usuario(Txt_Nome.Text, Mktxt_CPF.Text, Txt_Email.Text, usuarioAtivo);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            MessageBox.Show(usuarioDAL.AlterarCadastroUsuarios(usuario));

            DataTable table = new DataTable();
            List<Usuario> list = new List<Usuario>();
            list = usuarioDAL.ListarUsuarios(out string retorno);
            DataGrid.DataSource = list;
        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            List<Usuario> list = new List<Usuario>();
            list = usuarioDAL.ListarUsuarios(out string retorno);
            DataGrid.DataSource = list;
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string usuarioStatus = "";
            _ = (CkBx_Status.Checked) ? usuarioStatus = "Ativo" : usuarioStatus = "Inativo";
            Usuario usuario = new Usuario();
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuario = usuarioDAL.ConsultarCadastroUsuarios(Txt_Nome.Text, out string mensagem);
            MessageBox.Show(mensagem);

            if (usuario != null)
            {
                Txt_Nome.Text = usuario.User_Nome;
                Mktxt_CPF.Text = usuario.User_CPF;
                Txt_Email.Text = usuario.User_Email;
                _ = (usuario.User_Status == "Ativo") ? CkBx_Status.Checked = true : CkBx_Status.Checked = false;

                Btn_Alterar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void Btn_LimparCampos_Click(object sender, EventArgs e)
        {
            Txt_Email.Clear();
            Txt_Nome.Clear();
            Mktxt_CPF.Clear();
            CkBx_Status.Checked = false;
            Btn_Alterar.Enabled = false;
        }

        // Janela Maximizada ou Normal
        private void Frm_Cadastro_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                Btn_LimparCampos.Dock = DockStyle.Right;
            }
            else if(WindowState == FormWindowState.Normal)
            {
                Btn_LimparCampos.Dock = DockStyle.Bottom;
            }
        }
    }
}
