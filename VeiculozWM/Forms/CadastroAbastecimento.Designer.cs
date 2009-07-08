namespace Midas.VeiculoZ.Forms
{
    partial class CadastroAbastecimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAbastecimento));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePercurso = new System.Windows.Forms.TabPage();
            this.tKmFinal = new System.Windows.Forms.NumericUpDown();
            this.tKmInicial = new System.Windows.Forms.NumericUpDown();
            this.pAddVeiculo = new System.Windows.Forms.PictureBox();
            this.tIdAbastecimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.chkViagem = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tabPageAbastecimento = new System.Windows.Forms.TabPage();
            this.tLitros = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tValorLitro = new System.Windows.Forms.TextBox();
            this.hora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.chkTanqueCheio = new System.Windows.Forms.CheckBox();
            this.pAddTipo = new System.Windows.Forms.PictureBox();
            this.cmbTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tValor = new System.Windows.Forms.TextBox();
            this.pAddPosto = new System.Windows.Forms.PictureBox();
            this.cmbPosto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabPagePercurso.SuspendLayout();
            this.tabPageAbastecimento.SuspendLayout();
            this.tabPageObs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePercurso);
            this.tabControl.Controls.Add(this.tabPageAbastecimento);
            this.tabControl.Controls.Add(this.tabPageObs);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tabControl.Location = new System.Drawing.Point(0, 100);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(240, 168);
            this.tabControl.TabIndex = 95;
            // 
            // tabPagePercurso
            // 
            this.tabPagePercurso.Controls.Add(this.tKmFinal);
            this.tabPagePercurso.Controls.Add(this.tKmInicial);
            this.tabPagePercurso.Controls.Add(this.pAddVeiculo);
            this.tabPagePercurso.Controls.Add(this.tIdAbastecimento);
            this.tabPagePercurso.Controls.Add(this.label10);
            this.tabPagePercurso.Controls.Add(this.cmbVeiculos);
            this.tabPagePercurso.Controls.Add(this.chkViagem);
            this.tabPagePercurso.Controls.Add(this.label7);
            this.tabPagePercurso.Controls.Add(this.label4);
            this.tabPagePercurso.Controls.Add(this.label3);
            this.tabPagePercurso.Controls.Add(this.tId);
            this.tabPagePercurso.Location = new System.Drawing.Point(0, 0);
            this.tabPagePercurso.Name = "tabPagePercurso";
            this.tabPagePercurso.Size = new System.Drawing.Size(240, 145);
            this.tabPagePercurso.Text = "Percurso";
            // 
            // tKmFinal
            // 
            this.tKmFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tKmFinal.Location = new System.Drawing.Point(83, 64);
            this.tKmFinal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tKmFinal.Name = "tKmFinal";
            this.tKmFinal.Size = new System.Drawing.Size(100, 22);
            this.tKmFinal.TabIndex = 121;
            // 
            // tKmInicial
            // 
            this.tKmInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tKmInicial.Location = new System.Drawing.Point(83, 38);
            this.tKmInicial.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tKmInicial.Name = "tKmInicial";
            this.tKmInicial.Size = new System.Drawing.Size(100, 22);
            this.tKmInicial.TabIndex = 115;
            // 
            // pAddVeiculo
            // 
            this.pAddVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("pAddVeiculo.Image")));
            this.pAddVeiculo.Location = new System.Drawing.Point(210, 94);
            this.pAddVeiculo.Name = "pAddVeiculo";
            this.pAddVeiculo.Size = new System.Drawing.Size(17, 18);
            this.pAddVeiculo.Click += new System.EventHandler(this.pAddVeiculo_Click);
            // 
            // tIdAbastecimento
            // 
            this.tIdAbastecimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tIdAbastecimento.Location = new System.Drawing.Point(151, 12);
            this.tIdAbastecimento.Name = "tIdAbastecimento";
            this.tIdAbastecimento.ReadOnly = true;
            this.tIdAbastecimento.Size = new System.Drawing.Size(62, 21);
            this.tIdAbastecimento.TabIndex = 110;
            this.tIdAbastecimento.Visible = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(25, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 21);
            this.label10.Text = "Veículo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbVeiculos.DisplayMember = "Modelo";
            this.cmbVeiculos.Location = new System.Drawing.Point(83, 91);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(124, 22);
            this.cmbVeiculos.TabIndex = 4;
            this.cmbVeiculos.ValueMember = "Id";
            // 
            // chkViagem
            // 
            this.chkViagem.Location = new System.Drawing.Point(79, 112);
            this.chkViagem.Name = "chkViagem";
            this.chkViagem.Size = new System.Drawing.Size(89, 22);
            this.chkViagem.TabIndex = 5;
            this.chkViagem.Text = "Viagem?";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(61, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.Text = "Id:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.Text = "KM Final:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.Text = "KM Inicial:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tId.Location = new System.Drawing.Point(83, 12);
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(62, 21);
            this.tId.TabIndex = 1;
            // 
            // tabPageAbastecimento
            // 
            this.tabPageAbastecimento.Controls.Add(this.tLitros);
            this.tabPageAbastecimento.Controls.Add(this.label8);
            this.tabPageAbastecimento.Controls.Add(this.tValorLitro);
            this.tabPageAbastecimento.Controls.Add(this.hora);
            this.tabPageAbastecimento.Controls.Add(this.label5);
            this.tabPageAbastecimento.Controls.Add(this.data);
            this.tabPageAbastecimento.Controls.Add(this.chkTanqueCheio);
            this.tabPageAbastecimento.Controls.Add(this.pAddTipo);
            this.tabPageAbastecimento.Controls.Add(this.cmbTipoCombustivel);
            this.tabPageAbastecimento.Controls.Add(this.label1);
            this.tabPageAbastecimento.Controls.Add(this.label9);
            this.tabPageAbastecimento.Controls.Add(this.tValor);
            this.tabPageAbastecimento.Controls.Add(this.pAddPosto);
            this.tabPageAbastecimento.Controls.Add(this.cmbPosto);
            this.tabPageAbastecimento.Controls.Add(this.label6);
            this.tabPageAbastecimento.Controls.Add(this.label2);
            this.tabPageAbastecimento.Location = new System.Drawing.Point(0, 0);
            this.tabPageAbastecimento.Name = "tabPageAbastecimento";
            this.tabPageAbastecimento.Size = new System.Drawing.Size(240, 145);
            this.tabPageAbastecimento.Text = "Abastecimento";
            // 
            // tLitros
            // 
            this.tLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tLitros.Location = new System.Drawing.Point(58, 110);
            this.tLitros.Name = "tLitros";
            this.tLitros.ReadOnly = true;
            this.tLitros.Size = new System.Drawing.Size(57, 21);
            this.tLitros.TabIndex = 1002;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.Text = "Litros:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tValorLitro
            // 
            this.tValorLitro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tValorLitro.Location = new System.Drawing.Point(58, 86);
            this.tValorLitro.Name = "tValorLitro";
            this.tValorLitro.Size = new System.Drawing.Size(57, 21);
            this.tValorLitro.TabIndex = 10;
            this.tValorLitro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tValorLitro_KeyUp);
            // 
            // hora
            // 
            this.hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hora.Location = new System.Drawing.Point(141, 10);
            this.hora.Name = "hora";
            this.hora.ShowUpDown = true;
            this.hora.Size = new System.Drawing.Size(81, 22);
            this.hora.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.Text = "Data:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // data
            // 
            this.data.CustomFormat = "dd/MM/yyyy";
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data.Location = new System.Drawing.Point(58, 10);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(81, 22);
            this.data.TabIndex = 6;
            // 
            // chkTanqueCheio
            // 
            this.chkTanqueCheio.Location = new System.Drawing.Point(122, 112);
            this.chkTanqueCheio.Name = "chkTanqueCheio";
            this.chkTanqueCheio.Size = new System.Drawing.Size(109, 19);
            this.chkTanqueCheio.TabIndex = 127;
            this.chkTanqueCheio.Text = "Tanque Cheio?";
            // 
            // pAddTipo
            // 
            this.pAddTipo.Image = ((System.Drawing.Image)(resources.GetObject("pAddTipo.Image")));
            this.pAddTipo.Location = new System.Drawing.Point(205, 63);
            this.pAddTipo.Name = "pAddTipo";
            this.pAddTipo.Size = new System.Drawing.Size(17, 18);
            this.pAddTipo.Click += new System.EventHandler(this.pAddTipo_Click);
            // 
            // cmbTipoCombustivel
            // 
            this.cmbTipoCombustivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbTipoCombustivel.DisplayMember = "Nome";
            this.cmbTipoCombustivel.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoCombustivel.Location = new System.Drawing.Point(58, 61);
            this.cmbTipoCombustivel.Name = "cmbTipoCombustivel";
            this.cmbTipoCombustivel.Size = new System.Drawing.Size(145, 22);
            this.cmbTipoCombustivel.TabIndex = 9;
            this.cmbTipoCombustivel.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.Text = "Tipo C.:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(119, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.Text = "Total:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tValor
            // 
            this.tValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tValor.Location = new System.Drawing.Point(157, 86);
            this.tValor.Name = "tValor";
            this.tValor.Size = new System.Drawing.Size(65, 21);
            this.tValor.TabIndex = 11;
            this.tValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tValor_KeyUp);
            // 
            // pAddPosto
            // 
            this.pAddPosto.Image = ((System.Drawing.Image)(resources.GetObject("pAddPosto.Image")));
            this.pAddPosto.Location = new System.Drawing.Point(205, 38);
            this.pAddPosto.Name = "pAddPosto";
            this.pAddPosto.Size = new System.Drawing.Size(17, 18);
            this.pAddPosto.Click += new System.EventHandler(this.pAddPosto_Click);
            // 
            // cmbPosto
            // 
            this.cmbPosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbPosto.DisplayMember = "Nome";
            this.cmbPosto.ForeColor = System.Drawing.Color.Black;
            this.cmbPosto.Location = new System.Drawing.Point(58, 36);
            this.cmbPosto.Name = "cmbPosto";
            this.cmbPosto.Size = new System.Drawing.Size(145, 22);
            this.cmbPosto.TabIndex = 8;
            this.cmbPosto.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.Text = "Posto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.Text = "Preço/L:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPageObs
            // 
            this.tabPageObs.Controls.Add(this.tObs);
            this.tabPageObs.Location = new System.Drawing.Point(0, 0);
            this.tabPageObs.Name = "tabPageObs";
            this.tabPageObs.Size = new System.Drawing.Size(240, 145);
            this.tabPageObs.Text = "Observações";
            // 
            // tObs
            // 
            this.tObs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tObs.Location = new System.Drawing.Point(0, 0);
            this.tObs.Multiline = true;
            this.tObs.Name = "tObs";
            this.tObs.Size = new System.Drawing.Size(240, 145);
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
            this.lTitulo.Location = new System.Drawing.Point(4, 40);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(198, 17);
            this.lTitulo.Text = "Abastecimento";
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
            // CadastroAbastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
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
            this.Name = "CadastroAbastecimento";
            this.tabControl.ResumeLayout(false);
            this.tabPagePercurso.ResumeLayout(false);
            this.tabPageAbastecimento.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPagePercurso;
        private System.Windows.Forms.TabPage tabPageAbastecimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.PictureBox pAddPosto;
        private System.Windows.Forms.ComboBox cmbPosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tValor;
        private System.Windows.Forms.TabPage tabPageObs;
        private System.Windows.Forms.TextBox tObs;
        private System.Windows.Forms.CheckBox chkViagem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.CheckBox chkTanqueCheio;
        private System.Windows.Forms.PictureBox pAddTipo;
        private System.Windows.Forms.ComboBox cmbTipoCombustivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.DateTimePicker hora;
        private System.Windows.Forms.TextBox tIdAbastecimento;
        private System.Windows.Forms.TextBox tValorLitro;
        private System.Windows.Forms.PictureBox pAddVeiculo;
        private System.Windows.Forms.TextBox tLitros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tKmInicial;
        private System.Windows.Forms.NumericUpDown tKmFinal;

    }
}