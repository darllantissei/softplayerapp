namespace softplayerclient
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblInfovalorInicial = new System.Windows.Forms.Label();
            this.lblInfoMeses = new System.Windows.Forms.Label();
            this.btnSolicitarCalculo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblinfoValorFinal = new System.Windows.Forms.Label();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.lblStatusProcesso = new System.Windows.Forms.Label();
            this.pgrStatusProcesso = new System.Windows.Forms.ProgressBar();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInfovalorInicial
            // 
            this.lblInfovalorInicial.AutoSize = true;
            this.lblInfovalorInicial.Location = new System.Drawing.Point(32, 23);
            this.lblInfovalorInicial.Name = "lblInfovalorInicial";
            this.lblInfovalorInicial.Size = new System.Drawing.Size(82, 18);
            this.lblInfovalorInicial.TabIndex = 2;
            this.lblInfovalorInicial.Text = "Valor inicial";
            // 
            // lblInfoMeses
            // 
            this.lblInfoMeses.AutoSize = true;
            this.lblInfoMeses.Location = new System.Drawing.Point(151, 23);
            this.lblInfoMeses.Name = "lblInfoMeses";
            this.lblInfoMeses.Size = new System.Drawing.Size(53, 18);
            this.lblInfoMeses.TabIndex = 3;
            this.lblInfoMeses.Text = "Meses";
            // 
            // btnSolicitarCalculo
            // 
            this.btnSolicitarCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSolicitarCalculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(125)))), ((int)(((byte)(194)))));
            this.btnSolicitarCalculo.Location = new System.Drawing.Point(151, 170);
            this.btnSolicitarCalculo.Name = "btnSolicitarCalculo";
            this.btnSolicitarCalculo.Size = new System.Drawing.Size(106, 55);
            this.btnSolicitarCalculo.TabIndex = 4;
            this.btnSolicitarCalculo.Text = "Solicitar cálculo";
            this.btnSolicitarCalculo.UseVisualStyleBackColor = true;
            this.btnSolicitarCalculo.Click += new System.EventHandler(this.btnSolicitarCalculo_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(125)))), ((int)(((byte)(194)))));
            this.btnSair.Location = new System.Drawing.Point(32, 170);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 55);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair da aplicação";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblinfoValorFinal
            // 
            this.lblinfoValorFinal.AutoSize = true;
            this.lblinfoValorFinal.Location = new System.Drawing.Point(32, 89);
            this.lblinfoValorFinal.Name = "lblinfoValorFinal";
            this.lblinfoValorFinal.Size = new System.Drawing.Size(76, 18);
            this.lblinfoValorFinal.TabIndex = 6;
            this.lblinfoValorFinal.Text = "Valor final:";
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Location = new System.Drawing.Point(151, 89);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(80, 18);
            this.lblValorFinal.TabIndex = 7;
            this.lblValorFinal.Text = "#########";
            // 
            // lblStatusProcesso
            // 
            this.lblStatusProcesso.AutoSize = true;
            this.lblStatusProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblStatusProcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(125)))), ((int)(((byte)(194)))));
            this.lblStatusProcesso.Location = new System.Drawing.Point(29, 228);
            this.lblStatusProcesso.Name = "lblStatusProcesso";
            this.lblStatusProcesso.Size = new System.Drawing.Size(169, 17);
            this.lblStatusProcesso.TabIndex = 8;
            this.lblStatusProcesso.Text = "Status de processamento";
            // 
            // pgrStatusProcesso
            // 
            this.pgrStatusProcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(125)))), ((int)(((byte)(194)))));
            this.pgrStatusProcesso.Location = new System.Drawing.Point(32, 248);
            this.pgrStatusProcesso.MarqueeAnimationSpeed = 45;
            this.pgrStatusProcesso.Name = "pgrStatusProcesso";
            this.pgrStatusProcesso.Size = new System.Drawing.Size(225, 17);
            this.pgrStatusProcesso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgrStatusProcesso.TabIndex = 9;
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Location = new System.Drawing.Point(32, 49);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(100, 24);
            this.txtValorInicial.TabIndex = 10;
            this.txtValorInicial.Enter += new System.EventHandler(this.txtValorInicial_Enter);
            this.txtValorInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorInicial_KeyPress);
            this.txtValorInicial.Leave += new System.EventHandler(this.txtValorInicial_Leave);
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(151, 49);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 24);
            this.txtMeses.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(302, 282);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.txtValorInicial);
            this.Controls.Add(this.pgrStatusProcesso);
            this.Controls.Add(this.lblStatusProcesso);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.lblinfoValorFinal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSolicitarCalculo);
            this.Controls.Add(this.lblInfoMeses);
            this.Controls.Add(this.lblInfovalorInicial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Juros Composto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfovalorInicial;
        private System.Windows.Forms.Label lblInfoMeses;
        private System.Windows.Forms.Button btnSolicitarCalculo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblinfoValorFinal;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lblStatusProcesso;
        private System.Windows.Forms.ProgressBar pgrStatusProcesso;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.TextBox txtMeses;
    }
}

