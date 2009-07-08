namespace Midas.VeiculoZ.Forms
{
    partial class ListagemTiposCombustivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemTiposCombustivel));
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pToolbar1 = new System.Windows.Forms.PictureBox();
            this.pExcluir = new System.Windows.Forms.PictureBox();
            this.pEditar = new System.Windows.Forms.PictureBox();
            this.pNovo = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pVoltar = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackColor = System.Drawing.Color.White;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersVisible = false;
            this.dataGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGrid.GridLineColor = System.Drawing.Color.DarkGray;
            this.dataGrid.HeaderBackColor = System.Drawing.Color.White;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(0, 102);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.PreferredRowHeight = 20;
            this.dataGrid.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.dataGrid.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.Size = new System.Drawing.Size(240, 153);
            this.dataGrid.TabIndex = 4;
            this.dataGrid.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn);
            // 
            // dataGridTextBoxColumn
            // 
            this.dataGridTextBoxColumn.Format = "";
            this.dataGridTextBoxColumn.FormatInfo = null;
            this.dataGridTextBoxColumn.MappingName = "Nome";
            this.dataGridTextBoxColumn.Width = 210;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 37);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 23);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 15);
            this.label1.Text = "Tipos de Combustível";
            // 
            // pToolbar1
            // 
            this.pToolbar1.Image = ((System.Drawing.Image)(resources.GetObject("pToolbar1.Image")));
            this.pToolbar1.Location = new System.Drawing.Point(0, 36);
            this.pToolbar1.Name = "pToolbar1";
            this.pToolbar1.Size = new System.Drawing.Size(23, 42);
            this.pToolbar1.Click += new System.EventHandler(this.pNovo_Click);
            // 
            // pExcluir
            // 
            this.pExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pExcluir.Image")));
            this.pExcluir.Location = new System.Drawing.Point(90, 36);
            this.pExcluir.Name = "pExcluir";
            this.pExcluir.Size = new System.Drawing.Size(31, 42);
            this.pExcluir.Click += new System.EventHandler(this.pExcluir_Click);
            // 
            // pEditar
            // 
            this.pEditar.Image = ((System.Drawing.Image)(resources.GetObject("pEditar.Image")));
            this.pEditar.Location = new System.Drawing.Point(54, 36);
            this.pEditar.Name = "pEditar";
            this.pEditar.Size = new System.Drawing.Size(36, 42);
            this.pEditar.Click += new System.EventHandler(this.pEditar_Click);
            // 
            // pNovo
            // 
            this.pNovo.Image = ((System.Drawing.Image)(resources.GetObject("pNovo.Image")));
            this.pNovo.Location = new System.Drawing.Point(22, 36);
            this.pNovo.Name = "pNovo";
            this.pNovo.Size = new System.Drawing.Size(32, 42);
            this.pNovo.Click += new System.EventHandler(this.pNovo_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(121, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 42);
            // 
            // pVoltar
            // 
            this.pVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pVoltar.Image")));
            this.pVoltar.Location = new System.Drawing.Point(207, 36);
            this.pVoltar.Name = "pVoltar";
            this.pVoltar.Size = new System.Drawing.Size(33, 42);
            this.pVoltar.Click += new System.EventHandler(this.pVoltar_Click);
            // 
            // ListagemTiposCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pVoltar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pNovo);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pEditar);
            this.Controls.Add(this.pExcluir);
            this.Controls.Add(this.pToolbar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListagemTiposCombustivel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pToolbar1;
        private System.Windows.Forms.PictureBox pExcluir;
        private System.Windows.Forms.PictureBox pEditar;
        private System.Windows.Forms.PictureBox pNovo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pVoltar;
    }
}