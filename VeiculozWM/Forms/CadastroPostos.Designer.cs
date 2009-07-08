namespace Midas.VeiculoZ.Forms
{
    partial class CadastroPostos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPostos));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePosto = new System.Windows.Forms.TabPage();
            this.pAddDistrib = new System.Windows.Forms.PictureBox();
            this.cmbDistribuidora = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tNome = new System.Windows.Forms.TextBox();
            this.tId = new System.Windows.Forms.TextBox();
            this.tabPageEndereco = new System.Windows.Forms.TabPage();
            this.tEnderecoId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tCEP = new System.Windows.Forms.TextBox();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tComplemento = new System.Windows.Forms.TextBox();
            this.pAddCidade = new System.Windows.Forms.PictureBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tRua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBairro = new System.Windows.Forms.TextBox();
            this.tabPageEmpresa = new System.Windows.Forms.TabPage();
            this.tPJId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tCNPJ = new System.Windows.Forms.TextBox();
            this.tabPageObs = new System.Windows.Forms.TabPage();
            this.tObs = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pNovo = new System.Windows.Forms.PictureBox();
            this.pEditar = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pToolbar1 = new System.Windows.Forms.PictureBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPagePosto.SuspendLayout();
            this.tabPageEndereco.SuspendLayout();
            this.tabPageEmpresa.SuspendLayout();
            this.tabPageObs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePosto);
            this.tabControl.Controls.Add(this.tabPageEndereco);
            this.tabControl.Controls.Add(this.tabPageEmpresa);
            this.tabControl.Controls.Add(this.tabPageObs);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tabControl.Location = new System.Drawing.Point(0, 100);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(240, 168);
            this.tabControl.TabIndex = 95;
            // 
            // tabPagePosto
            // 
            this.tabPagePosto.Controls.Add(this.pAddDistrib);
            this.tabPagePosto.Controls.Add(this.cmbDistribuidora);
            this.tabPagePosto.Controls.Add(this.label7);
            this.tabPagePosto.Controls.Add(this.label4);
            this.tabPagePosto.Controls.Add(this.label3);
            this.tabPagePosto.Controls.Add(this.tNome);
            this.tabPagePosto.Controls.Add(this.tId);
            this.tabPagePosto.Location = new System.Drawing.Point(0, 0);
            this.tabPagePosto.Name = "tabPagePosto";
            this.tabPagePosto.Size = new System.Drawing.Size(240, 145);
            this.tabPagePosto.Text = "Posto";
            // 
            // pAddDistrib
            // 
            this.pAddDistrib.Image = ((System.Drawing.Image)(resources.GetObject("pAddDistrib.Image")));
            this.pAddDistrib.Location = new System.Drawing.Point(201, 61);
            this.pAddDistrib.Name = "pAddDistrib";
            this.pAddDistrib.Size = new System.Drawing.Size(27, 20);
            this.pAddDistrib.Click += new System.EventHandler(this.pAddDistrib_Click_1);
            // 
            // cmbDistribuidora
            // 
            this.cmbDistribuidora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbDistribuidora.DisplayMember = "Nome";
            this.cmbDistribuidora.ForeColor = System.Drawing.Color.Black;
            this.cmbDistribuidora.Location = new System.Drawing.Point(64, 59);
            this.cmbDistribuidora.Name = "cmbDistribuidora";
            this.cmbDistribuidora.Size = new System.Drawing.Size(129, 22);
            this.cmbDistribuidora.TabIndex = 93;
            this.cmbDistribuidora.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(42, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.Text = "Id:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.Text = "Distrib.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(2, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tNome
            // 
            this.tNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tNome.Location = new System.Drawing.Point(64, 35);
            this.tNome.Name = "tNome";
            this.tNome.Size = new System.Drawing.Size(164, 21);
            this.tNome.TabIndex = 90;
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tId.Location = new System.Drawing.Point(64, 11);
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(62, 21);
            this.tId.TabIndex = 89;
            // 
            // tabPageEndereco
            // 
            this.tabPageEndereco.Controls.Add(this.tEnderecoId);
            this.tabPageEndereco.Controls.Add(this.label9);
            this.tabPageEndereco.Controls.Add(this.tCEP);
            this.tabPageEndereco.Controls.Add(this.tNumero);
            this.tabPageEndereco.Controls.Add(this.label8);
            this.tabPageEndereco.Controls.Add(this.tComplemento);
            this.tabPageEndereco.Controls.Add(this.pAddCidade);
            this.tabPageEndereco.Controls.Add(this.cmbCidade);
            this.tabPageEndereco.Controls.Add(this.label6);
            this.tabPageEndereco.Controls.Add(this.label5);
            this.tabPageEndereco.Controls.Add(this.tRua);
            this.tabPageEndereco.Controls.Add(this.label2);
            this.tabPageEndereco.Controls.Add(this.tBairro);
            this.tabPageEndereco.Location = new System.Drawing.Point(0, 0);
            this.tabPageEndereco.Name = "tabPageEndereco";
            this.tabPageEndereco.Size = new System.Drawing.Size(232, 142);
            this.tabPageEndereco.Text = "Endereço";
            // 
            // tEnderecoId
            // 
            this.tEnderecoId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tEnderecoId.Location = new System.Drawing.Point(220, 118);
            this.tEnderecoId.Name = "tEnderecoId";
            this.tEnderecoId.Size = new System.Drawing.Size(17, 21);
            this.tEnderecoId.TabIndex = 114;
            this.tEnderecoId.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 22);
            this.label9.Text = "CEP:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tCEP
            // 
            this.tCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tCEP.Location = new System.Drawing.Point(58, 107);
            this.tCEP.Name = "tCEP";
            this.tCEP.Size = new System.Drawing.Size(164, 21);
            this.tCEP.TabIndex = 108;
            // 
            // tNumero
            // 
            this.tNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tNumero.Location = new System.Drawing.Point(188, 10);
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(36, 21);
            this.tNumero.TabIndex = 106;
            this.tNumero.Text = "S/N";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 22);
            this.label8.Text = "Comp.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tComplemento
            // 
            this.tComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tComplemento.Location = new System.Drawing.Point(58, 83);
            this.tComplemento.Name = "tComplemento";
            this.tComplemento.Size = new System.Drawing.Size(164, 21);
            this.tComplemento.TabIndex = 104;
            // 
            // pAddCidade
            // 
            this.pAddCidade.Image = ((System.Drawing.Image)(resources.GetObject("pAddCidade.Image")));
            this.pAddCidade.Location = new System.Drawing.Point(197, 36);
            this.pAddCidade.Name = "pAddCidade";
            this.pAddCidade.Size = new System.Drawing.Size(27, 20);
            // 
            // cmbCidade
            // 
            this.cmbCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCidade.ForeColor = System.Drawing.Color.Black;
            this.cmbCidade.Location = new System.Drawing.Point(58, 34);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(129, 22);
            this.cmbCidade.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(8, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.Text = "Cidade:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.Text = "Rua:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tRua
            // 
            this.tRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tRua.Location = new System.Drawing.Point(58, 10);
            this.tRua.Name = "tRua";
            this.tRua.Size = new System.Drawing.Size(129, 21);
            this.tRua.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.Text = "Bairro:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tBairro
            // 
            this.tBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBairro.HideSelection = false;
            this.tBairro.Location = new System.Drawing.Point(58, 59);
            this.tBairro.Name = "tBairro";
            this.tBairro.Size = new System.Drawing.Size(164, 21);
            this.tBairro.TabIndex = 97;
            // 
            // tabPageEmpresa
            // 
            this.tabPageEmpresa.Controls.Add(this.tPJId);
            this.tabPageEmpresa.Controls.Add(this.label1);
            this.tabPageEmpresa.Controls.Add(this.tCNPJ);
            this.tabPageEmpresa.Location = new System.Drawing.Point(0, 0);
            this.tabPageEmpresa.Name = "tabPageEmpresa";
            this.tabPageEmpresa.Size = new System.Drawing.Size(232, 142);
            this.tabPageEmpresa.Text = "Empresa";
            // 
            // tPJId
            // 
            this.tPJId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tPJId.Location = new System.Drawing.Point(112, 61);
            this.tPJId.Name = "tPJId";
            this.tPJId.Size = new System.Drawing.Size(17, 21);
            this.tPJId.TabIndex = 115;
            this.tPJId.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.Text = "CNPJ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tCNPJ
            // 
            this.tCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tCNPJ.Location = new System.Drawing.Point(58, 14);
            this.tCNPJ.Name = "tCNPJ";
            this.tCNPJ.Size = new System.Drawing.Size(164, 21);
            this.tCNPJ.TabIndex = 92;
            // 
            // tabPageObs
            // 
            this.tabPageObs.Controls.Add(this.tObs);
            this.tabPageObs.Location = new System.Drawing.Point(0, 0);
            this.tabPageObs.Name = "tabPageObs";
            this.tabPageObs.Size = new System.Drawing.Size(232, 142);
            this.tabPageObs.Text = "Observações";
            // 
            // tObs
            // 
            this.tObs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tObs.Location = new System.Drawing.Point(0, 0);
            this.tObs.Multiline = true;
            this.tObs.Name = "tObs";
            this.tObs.Size = new System.Drawing.Size(232, 142);
            this.tObs.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(207, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 42);
            this.pictureBox3.Click += new System.EventHandler(this.pVoltar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(121, 59);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 42);
            // 
            // pNovo
            // 
            this.pNovo.Image = ((System.Drawing.Image)(resources.GetObject("pNovo.Image")));
            this.pNovo.Location = new System.Drawing.Point(22, 59);
            this.pNovo.Name = "pNovo";
            this.pNovo.Size = new System.Drawing.Size(32, 42);
            this.pNovo.Click += new System.EventHandler(this.pSalvar_Click);
            // 
            // pEditar
            // 
            this.pEditar.Image = ((System.Drawing.Image)(resources.GetObject("pEditar.Image")));
            this.pEditar.Location = new System.Drawing.Point(54, 59);
            this.pEditar.Name = "pEditar";
            this.pEditar.Size = new System.Drawing.Size(30, 42);
            this.pEditar.Click += new System.EventHandler(this.pExcluir_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(84, 59);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 42);
            // 
            // pToolbar1
            // 
            this.pToolbar1.Image = ((System.Drawing.Image)(resources.GetObject("pToolbar1.Image")));
            this.pToolbar1.Location = new System.Drawing.Point(0, 59);
            this.pToolbar1.Name = "pToolbar1";
            this.pToolbar1.Size = new System.Drawing.Size(23, 42);
            // 
            // lTitulo
            // 
            this.lTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lTitulo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(7, 40);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(198, 17);
            this.lTitulo.Text = "Posto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 23);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 35);
            // 
            // CadastroPostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(257, 285);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pNovo);
            this.Controls.Add(this.pEditar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pToolbar1);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CadastroPostos";
            this.tabControl.ResumeLayout(false);
            this.tabPagePosto.ResumeLayout(false);
            this.tabPageEndereco.ResumeLayout(false);
            this.tabPageEmpresa.ResumeLayout(false);
            this.tabPageObs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.PictureBox pToolbar1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pEditar;
        private System.Windows.Forms.PictureBox pNovo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePosto;
        private System.Windows.Forms.TabPage tabPageEndereco;
        private System.Windows.Forms.TabPage tabPageEmpresa;
        private System.Windows.Forms.PictureBox pAddDistrib;
        private System.Windows.Forms.ComboBox cmbDistribuidora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNome;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.PictureBox pAddCidade;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tRua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBairro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tCNPJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tComplemento;
        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tCEP;
        private System.Windows.Forms.TabPage tabPageObs;
        private System.Windows.Forms.TextBox tObs;
        private System.Windows.Forms.TextBox tEnderecoId;
        private System.Windows.Forms.TextBox tPJId;

    }
}