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
            this.lblApostaTitle = new System.Windows.Forms.Label();
            this.txtAposta = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDealerTitle = new System.Windows.Forms.Label();
            this.lblJogadorTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltar.Location = new System.Drawing.Point(274, 333);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(60, 24);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSaldo.Location = new System.Drawing.Point(450, 24);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(104, 19);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo: R$ 0.00";
            // 
            // btnApostar
            // 
            this.btnApostar.BackColor = System.Drawing.Color.Gold;
            this.btnApostar.FlatAppearance.BorderSize = 0;
            this.btnApostar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApostar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostar.ForeColor = System.Drawing.Color.Black;
            this.btnApostar.Location = new System.Drawing.Point(255, 292);
            this.btnApostar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(90, 37);
            this.btnApostar.TabIndex = 2;
            this.btnApostar.Text = "APOSTAR";
            this.btnApostar.UseVisualStyleBackColor = false;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Aqua;
            this.lblMsg.Location = new System.Drawing.Point(262, 244);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(100, 19);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "Faça a aposta";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJogador
            // 
            this.lblJogador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblJogador.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.ForeColor = System.Drawing.Color.White;
            this.lblJogador.Location = new System.Drawing.Point(75, 195);
            this.lblJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(450, 41);
            this.lblJogador.TabIndex = 4;
            this.lblJogador.Text = "[Cartas do Jogador]";
            this.lblJogador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDealer
            // 
            this.lblDealer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDealer.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.ForeColor = System.Drawing.Color.White;
            this.lblDealer.Location = new System.Drawing.Point(75, 89);
            this.lblDealer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(450, 41);
            this.lblDealer.TabIndex = 5;
            this.lblDealer.Text = "[Cartas do Dealer]";
            this.lblDealer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnHit.FlatAppearance.BorderSize = 0;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.White;
            this.btnHit.Location = new System.Drawing.Point(352, 292);
            this.btnHit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(68, 37);
            this.btnHit.TabIndex = 6;
            this.btnHit.Text = "HIT (➕)";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStand.FlatAppearance.BorderSize = 0;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStand.Location = new System.Drawing.Point(428, 292);
            this.btnStand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(68, 37);
            this.btnStand.TabIndex = 7;
            this.btnStand.Text = "STAND";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Visible = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblApostaTitle
            // 
            this.lblApostaTitle.AutoSize = true;
            this.lblApostaTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApostaTitle.Location = new System.Drawing.Point(142, 284);
            this.lblApostaTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApostaTitle.Name = "lblApostaTitle";
            this.lblApostaTitle.Size = new System.Drawing.Size(110, 15);
            this.lblApostaTitle.TabIndex = 8;
            this.lblApostaTitle.Text = "Valor da Aposta R$";
            // 
            // txtAposta
            // 
            this.txtAposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAposta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAposta.ForeColor = System.Drawing.Color.White;
            this.txtAposta.Location = new System.Drawing.Point(142, 305);
            this.txtAposta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAposta.Name = "txtAposta";
            this.txtAposta.Size = new System.Drawing.Size(98, 25);
            this.txtAposta.TabIndex = 9;
            this.txtAposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gold;
            this.lblTitulo.Location = new System.Drawing.Point(225, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 32);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "BLACKJACK ♠️";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDealerTitle
            // 
            this.lblDealerTitle.AutoSize = true;
            this.lblDealerTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTitle.ForeColor = System.Drawing.Color.Red;
            this.lblDealerTitle.Location = new System.Drawing.Point(270, 57);
            this.lblDealerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerTitle.Name = "lblDealerTitle";
            this.lblDealerTitle.Size = new System.Drawing.Size(69, 21);
            this.lblDealerTitle.TabIndex = 11;
            this.lblDealerTitle.Text = "DEALER";
            // 
            // lblJogadorTitle
            // 
            this.lblJogadorTitle.AutoSize = true;
            this.lblJogadorTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblJogadorTitle.Location = new System.Drawing.Point(262, 162);
            this.lblJogadorTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogadorTitle.Name = "lblJogadorTitle";
            this.lblJogadorTitle.Size = new System.Drawing.Size(85, 21);
            this.lblJogadorTitle.TabIndex = 12;
            this.lblJogadorTitle.Text = "JOGADOR";
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblJogadorTitle);
            this.Controls.Add(this.lblDealerTitle);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtAposta);
            this.Controls.Add(this.lblApostaTitle);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnVoltar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form21";
            this.Text = "Blackjack - 21";
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
        private System.Windows.Forms.Label lblApostaTitle;
        private System.Windows.Forms.TextBox txtAposta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDealerTitle;
        private System.Windows.Forms.Label lblJogadorTitle;
    }
}