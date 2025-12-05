namespace SorrisoDaFortuna
{
    partial class Form21
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAposta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(352, 339);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(413, 44);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 16);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "label1";
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(352, 283);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(75, 23);
            this.btnApostar.TabIndex = 2;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(584, 226);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(37, 16);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "label";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Location = new System.Drawing.Point(282, 163);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(44, 16);
            this.lblJogador.TabIndex = 4;
            this.lblJogador.Text = "label1";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(549, 163);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(44, 16);
            this.lblDealer.TabIndex = 5;
            this.lblDealer.Text = "label1";
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(464, 339);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 6;
            this.btnHit.Text = "Continuar";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(464, 283);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 7;
            this.btnStand.Text = "Parar";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor da Aposta R$";
            // 
            // txtAposta
            // 
            this.txtAposta.Location = new System.Drawing.Point(423, 220);
            this.txtAposta.Name = "txtAposta";
            this.txtAposta.Size = new System.Drawing.Size(100, 22);
            this.txtAposta.TabIndex = 9;
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Form21";
            this.Text = "Form21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAposta;
    }
}