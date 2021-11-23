
namespace Atividades_2
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Erro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(130, 81);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_Usuario.TabIndex = 0;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.Location = new System.Drawing.Point(90, 302);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(205, 86);
            this.Btn_Entrar.TabIndex = 1;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = true;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(130, 149);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(100, 20);
            this.Txt_Senha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // Lbl_Erro
            // 
            this.Lbl_Erro.AutoSize = true;
            this.Lbl_Erro.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Erro.Location = new System.Drawing.Point(72, 21);
            this.Lbl_Erro.Name = "Lbl_Erro";
            this.Lbl_Erro.Size = new System.Drawing.Size(232, 13);
            this.Lbl_Erro.TabIndex = 5;
            this.Lbl_Erro.Text = "DADOS INCORRETOS! TENTE NOVAMENTE";
            this.Lbl_Erro.Visible = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 429);
            this.Controls.Add(this.Lbl_Erro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.Txt_Usuario);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Button Btn_Entrar;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Erro;
    }
}

