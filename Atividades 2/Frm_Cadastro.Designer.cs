
namespace Atividades_2
{
    partial class Frm_Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.CkBx_Status = new System.Windows.Forms.CheckBox();
            this.Lbl_Erro_Cadastro = new System.Windows.Forms.Label();
            this.Mktxt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_LimparCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Nome.Location = new System.Drawing.Point(170, 131);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(215, 441);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(92, 56);
            this.Btn_Cadastrar.TabIndex = 6;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // CkBx_Status
            // 
            this.CkBx_Status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CkBx_Status.AutoSize = true;
            this.CkBx_Status.Location = new System.Drawing.Point(40, 255);
            this.CkBx_Status.Name = "CkBx_Status";
            this.CkBx_Status.Size = new System.Drawing.Size(50, 17);
            this.CkBx_Status.TabIndex = 7;
            this.CkBx_Status.Text = "Ativo";
            this.CkBx_Status.UseVisualStyleBackColor = true;
            // 
            // Lbl_Erro_Cadastro
            // 
            this.Lbl_Erro_Cadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Erro_Cadastro.AutoSize = true;
            this.Lbl_Erro_Cadastro.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Erro_Cadastro.Location = new System.Drawing.Point(355, 98);
            this.Lbl_Erro_Cadastro.Name = "Lbl_Erro_Cadastro";
            this.Lbl_Erro_Cadastro.Size = new System.Drawing.Size(133, 13);
            this.Lbl_Erro_Cadastro.TabIndex = 8;
            this.Lbl_Erro_Cadastro.Text = "CADASTRO INCORRETO";
            this.Lbl_Erro_Cadastro.Visible = false;
            // 
            // Mktxt_CPF
            // 
            this.Mktxt_CPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Mktxt_CPF.Location = new System.Drawing.Point(170, 171);
            this.Mktxt_CPF.Mask = "000-000-000-00";
            this.Mktxt_CPF.Name = "Mktxt_CPF";
            this.Mktxt_CPF.Size = new System.Drawing.Size(100, 20);
            this.Mktxt_CPF.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-mail";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Email.Location = new System.Drawing.Point(170, 214);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(100, 20);
            this.Txt_Email.TabIndex = 11;
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Deletar.Location = new System.Drawing.Point(614, 441);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(92, 56);
            this.Btn_Deletar.TabIndex = 13;
            this.Btn_Deletar.Text = "Deletar";
            this.Btn_Deletar.UseVisualStyleBackColor = true;
            this.Btn_Deletar.Click += new System.EventHandler(this.Btn_Deletar_Click);
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Alterar.Enabled = false;
            this.Btn_Alterar.Location = new System.Drawing.Point(481, 440);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(92, 56);
            this.Btn_Alterar.TabIndex = 14;
            this.Btn_Alterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.Btn_Alterar, "Para alterar uma ficha é preciso realizar uma Consulta com o \"Nome\" do usuário de" +
        "sejado");
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // DataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.DataGrid.BackgroundColor = System.Drawing.Color.Thistle;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.GridColor = System.Drawing.SystemColors.Info;
            this.DataGrid.Location = new System.Drawing.Point(40, 278);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(730, 157);
            this.DataGrid.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(55, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "CADASTRAR";
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Consultar.Location = new System.Drawing.Point(348, 440);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(92, 56);
            this.Btn_Consultar.TabIndex = 26;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Dica";
            // 
            // Btn_LimparCampos
            // 
            this.Btn_LimparCampos.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LimparCampos.Location = new System.Drawing.Point(576, 44);
            this.Btn_LimparCampos.Name = "Btn_LimparCampos";
            this.Btn_LimparCampos.Size = new System.Drawing.Size(261, 107);
            this.Btn_LimparCampos.TabIndex = 27;
            this.Btn_LimparCampos.Text = "Limpar Campos";
            this.Btn_LimparCampos.UseVisualStyleBackColor = true;
            this.Btn_LimparCampos.Click += new System.EventHandler(this.Btn_LimparCampos_Click);
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(849, 508);
            this.Controls.Add(this.Btn_LimparCampos);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Btn_Deletar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mktxt_CPF);
            this.Controls.Add(this.Lbl_Erro_Cadastro);
            this.Controls.Add(this.CkBx_Status);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Nome);
            this.Name = "Frm_Cadastro";
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Cadastro_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Cadastro_Load);
            this.Resize += new System.EventHandler(this.Frm_Cadastro_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.CheckBox CkBx_Status;
        private System.Windows.Forms.Label Lbl_Erro_Cadastro;
        private System.Windows.Forms.MaskedTextBox Mktxt_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Button Btn_Deletar;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btn_LimparCampos;
    }
}