namespace EscalonadorApp
{
    partial class FrmDadosProcesso
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.nudQuantum = new System.Windows.Forms.NumericUpDown();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.nudTamanho = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(145, 108);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(88, 23);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // nudQuantum
            // 
            this.nudQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantum.Location = new System.Drawing.Point(12, 22);
            this.nudQuantum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQuantum.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudQuantum.Name = "nudQuantum";
            this.nudQuantum.Size = new System.Drawing.Size(222, 26);
            this.nudQuantum.TabIndex = 1;
            this.nudQuantum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudQuantum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudQuantum_KeyDown);
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantum.Location = new System.Drawing.Point(12, 6);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(50, 13);
            this.lblQuantum.TabIndex = 2;
            this.lblQuantum.Text = "Quantum";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(12, 54);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(52, 13);
            this.lblTamanho.TabIndex = 4;
            this.lblTamanho.Text = "Tamanho";
            // 
            // nudTamanho
            // 
            this.nudTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTamanho.Location = new System.Drawing.Point(12, 70);
            this.nudTamanho.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudTamanho.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTamanho.Name = "nudTamanho";
            this.nudTamanho.Size = new System.Drawing.Size(222, 26);
            this.nudTamanho.TabIndex = 3;
            this.nudTamanho.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTamanho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudTamanho_KeyDown);
            // 
            // FrmDadosProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 143);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.nudTamanho);
            this.Controls.Add(this.lblQuantum);
            this.Controls.Add(this.nudQuantum);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDadosProcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDadosProcesso";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FrmDadosProcesso_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.NumericUpDown nudQuantum;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.NumericUpDown nudTamanho;
    }
}