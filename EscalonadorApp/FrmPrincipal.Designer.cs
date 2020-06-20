namespace EscalonadorApp
{
    partial class FrmPrincipal
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
            this.grpCPU = new System.Windows.Forms.GroupBox();
            this.grpEspera = new System.Windows.Forms.GroupBox();
            this.grpPronto = new System.Windows.Forms.GroupBox();
            this.grbControleProcessos = new System.Windows.Forms.GroupBox();
            this.btnReprocessar = new System.Windows.Forms.Button();
            this.btnAddProcesso = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grbControleCPU = new System.Windows.Forms.GroupBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.nudCPU = new System.Windows.Forms.NumericUpDown();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnCPU = new System.Windows.Forms.Button();
            this.pnlCrcCPU = new EscalonadorApp.PanelCircle(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.grbControleProcessos.SuspendLayout();
            this.grbControleCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPU)).BeginInit();
            this.pnlCrcCPU.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCPU
            // 
            this.grpCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCPU.Location = new System.Drawing.Point(12, 12);
            this.grpCPU.Name = "grpCPU";
            this.grpCPU.Size = new System.Drawing.Size(851, 100);
            this.grpCPU.TabIndex = 4;
            this.grpCPU.TabStop = false;
            this.grpCPU.Text = "CPU";
            // 
            // grpEspera
            // 
            this.grpEspera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEspera.Location = new System.Drawing.Point(12, 118);
            this.grpEspera.Name = "grpEspera";
            this.grpEspera.Size = new System.Drawing.Size(851, 100);
            this.grpEspera.TabIndex = 5;
            this.grpEspera.TabStop = false;
            this.grpEspera.Text = "Espera";
            // 
            // grpPronto
            // 
            this.grpPronto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPronto.Location = new System.Drawing.Point(12, 224);
            this.grpPronto.Name = "grpPronto";
            this.grpPronto.Size = new System.Drawing.Size(851, 100);
            this.grpPronto.TabIndex = 6;
            this.grpPronto.TabStop = false;
            this.grpPronto.Text = "Completo";
            // 
            // grbControleProcessos
            // 
            this.grbControleProcessos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbControleProcessos.Controls.Add(this.btnReprocessar);
            this.grbControleProcessos.Controls.Add(this.btnAddProcesso);
            this.grbControleProcessos.Controls.Add(this.btnLimpar);
            this.grbControleProcessos.Location = new System.Drawing.Point(12, 373);
            this.grbControleProcessos.Name = "grbControleProcessos";
            this.grbControleProcessos.Size = new System.Drawing.Size(265, 68);
            this.grbControleProcessos.TabIndex = 15;
            this.grbControleProcessos.TabStop = false;
            this.grbControleProcessos.Text = "Processos";
            // 
            // btnReprocessar
            // 
            this.btnReprocessar.Location = new System.Drawing.Point(178, 19);
            this.btnReprocessar.Name = "btnReprocessar";
            this.btnReprocessar.Size = new System.Drawing.Size(80, 42);
            this.btnReprocessar.TabIndex = 2;
            this.btnReprocessar.Text = "&Reprocessar";
            this.btnReprocessar.UseVisualStyleBackColor = true;
            this.btnReprocessar.Click += new System.EventHandler(this.btnReprocessar_Click);
            // 
            // btnAddProcesso
            // 
            this.btnAddProcesso.Location = new System.Drawing.Point(6, 19);
            this.btnAddProcesso.Name = "btnAddProcesso";
            this.btnAddProcesso.Size = new System.Drawing.Size(80, 42);
            this.btnAddProcesso.TabIndex = 0;
            this.btnAddProcesso.Text = "&Novo processo";
            this.btnAddProcesso.UseVisualStyleBackColor = true;
            this.btnAddProcesso.Click += new System.EventHandler(this.btnAddProcesso_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(92, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 42);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // grbControleCPU
            // 
            this.grbControleCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbControleCPU.Controls.Add(this.lblCPU);
            this.grbControleCPU.Controls.Add(this.nudCPU);
            this.grbControleCPU.Controls.Add(this.lblTipo);
            this.grbControleCPU.Controls.Add(this.cbTipo);
            this.grbControleCPU.Controls.Add(this.btnCPU);
            this.grbControleCPU.Location = new System.Drawing.Point(283, 373);
            this.grbControleCPU.Name = "grbControleCPU";
            this.grbControleCPU.Size = new System.Drawing.Size(301, 68);
            this.grbControleCPU.TabIndex = 17;
            this.grbControleCPU.TabStop = false;
            this.grbControleCPU.Text = "CPU";
            // 
            // lblCPU
            // 
            this.lblCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(191, 25);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(51, 13);
            this.lblCPU.TabIndex = 16;
            this.lblCPU.Text = "CPU (ms)";
            // 
            // nudCPU
            // 
            this.nudCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudCPU.Location = new System.Drawing.Point(194, 41);
            this.nudCPU.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCPU.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudCPU.Name = "nudCPU";
            this.nudCPU.Size = new System.Drawing.Size(101, 20);
            this.nudCPU.TabIndex = 5;
            this.nudCPU.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(90, 24);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "FIFO",
            "RoundRobin"});
            this.cbTipo.Location = new System.Drawing.Point(93, 40);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(95, 21);
            this.cbTipo.TabIndex = 4;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // btnCPU
            // 
            this.btnCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCPU.Location = new System.Drawing.Point(7, 19);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(80, 42);
            this.btnCPU.TabIndex = 3;
            this.btnCPU.Text = "&CPU (Parado)";
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // pnlCrcCPU
            // 
            this.pnlCrcCPU.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlCrcCPU.CircleColor = System.Drawing.Color.Red;
            this.pnlCrcCPU.Controls.Add(this.label1);
            this.pnlCrcCPU.Location = new System.Drawing.Point(76, 7);
            this.pnlCrcCPU.Name = "pnlCrcCPU";
            this.pnlCrcCPU.Size = new System.Drawing.Size(20, 20);
            this.pnlCrcCPU.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 453);
            this.Controls.Add(this.grbControleCPU);
            this.Controls.Add(this.grbControleProcessos);
            this.Controls.Add(this.grpPronto);
            this.Controls.Add(this.grpEspera);
            this.Controls.Add(this.pnlCrcCPU);
            this.Controls.Add(this.grpCPU);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escalonador - App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grbControleProcessos.ResumeLayout(false);
            this.grbControleCPU.ResumeLayout(false);
            this.grbControleCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPU)).EndInit();
            this.pnlCrcCPU.ResumeLayout(false);
            this.pnlCrcCPU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PanelCircle pnlCrcCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCPU;
        private System.Windows.Forms.GroupBox grpEspera;
        private System.Windows.Forms.GroupBox grpPronto;
        private System.Windows.Forms.GroupBox grbControleProcessos;
        private System.Windows.Forms.Button btnReprocessar;
        private System.Windows.Forms.Button btnAddProcesso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grbControleCPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.NumericUpDown nudCPU;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnCPU;
    }
}

