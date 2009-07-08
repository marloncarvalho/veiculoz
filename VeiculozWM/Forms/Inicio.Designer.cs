namespace Midas.VeiculoZ.Forms
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pTopo = new System.Windows.Forms.PictureBox();
            this.pSemiTopo = new System.Windows.Forms.PictureBox();
            this.pAbastecimentos = new System.Windows.Forms.PictureBox();
            this.pRelatorios = new System.Windows.Forms.PictureBox();
            this.pDespesas = new System.Windows.Forms.PictureBox();
            this.pPostos = new System.Windows.Forms.PictureBox();
            this.lHora = new System.Windows.Forms.Label();
            this.cVeiculos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pTopo
            // 
            this.pTopo.Image = ((System.Drawing.Image)(resources.GetObject("pTopo.Image")));
            this.pTopo.Location = new System.Drawing.Point(0, 0);
            this.pTopo.Name = "pTopo";
            this.pTopo.Size = new System.Drawing.Size(240, 37);
            // 
            // pSemiTopo
            // 
            this.pSemiTopo.Image = ((System.Drawing.Image)(resources.GetObject("pSemiTopo.Image")));
            this.pSemiTopo.Location = new System.Drawing.Point(0, 36);
            this.pSemiTopo.Name = "pSemiTopo";
            this.pSemiTopo.Size = new System.Drawing.Size(240, 25);
            // 
            // pAbastecimentos
            // 
            this.pAbastecimentos.Image = ((System.Drawing.Image)(resources.GetObject("pAbastecimentos.Image")));
            this.pAbastecimentos.Location = new System.Drawing.Point(0, 59);
            this.pAbastecimentos.Name = "pAbastecimentos";
            this.pAbastecimentos.Size = new System.Drawing.Size(240, 42);
            this.pAbastecimentos.Click += new System.EventHandler(this.pAbastecimentos_Click);
            // 
            // pRelatorios
            // 
            this.pRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("pRelatorios.Image")));
            this.pRelatorios.Location = new System.Drawing.Point(0, 99);
            this.pRelatorios.Name = "pRelatorios";
            this.pRelatorios.Size = new System.Drawing.Size(240, 42);
            // 
            // pDespesas
            // 
            this.pDespesas.Image = ((System.Drawing.Image)(resources.GetObject("pDespesas.Image")));
            this.pDespesas.Location = new System.Drawing.Point(0, 139);
            this.pDespesas.Name = "pDespesas";
            this.pDespesas.Size = new System.Drawing.Size(240, 42);
            // 
            // pPostos
            // 
            this.pPostos.Image = ((System.Drawing.Image)(resources.GetObject("pPostos.Image")));
            this.pPostos.Location = new System.Drawing.Point(0, 179);
            this.pPostos.Name = "pPostos";
            this.pPostos.Size = new System.Drawing.Size(240, 42);
            this.pPostos.Click += new System.EventHandler(this.pPostos_Click);
            // 
            // lHora
            // 
            this.lHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lHora.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lHora.ForeColor = System.Drawing.Color.White;
            this.lHora.Location = new System.Drawing.Point(203, 39);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(42, 19);
            this.lHora.Text = "14:25";
            // 
            // cVeiculos
            // 
            this.cVeiculos.Location = new System.Drawing.Point(6, 241);
            this.cVeiculos.Name = "cVeiculos";
            this.cVeiculos.Size = new System.Drawing.Size(100, 22);
            this.cVeiculos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(135, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.Text = "Consumo Médio:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(135, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.Text = "12km / L";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.Text = "Veículo:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cVeiculos);
            this.Controls.Add(this.lHora);
            this.Controls.Add(this.pPostos);
            this.Controls.Add(this.pDespesas);
            this.Controls.Add(this.pRelatorios);
            this.Controls.Add(this.pAbastecimentos);
            this.Controls.Add(this.pSemiTopo);
            this.Controls.Add(this.pTopo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pTopo;
        private System.Windows.Forms.PictureBox pSemiTopo;
        private System.Windows.Forms.PictureBox pAbastecimentos;
        private System.Windows.Forms.PictureBox pRelatorios;
        private System.Windows.Forms.PictureBox pDespesas;
        private System.Windows.Forms.PictureBox pPostos;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.ComboBox cVeiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}