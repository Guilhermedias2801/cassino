namespace SorrisoDaFortuna
{
    partial class MainForm
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
            this.btn21 = new System.Windows.Forms.Button();
            this.btnBicho = new System.Windows.Forms.Button();
            this.btnRoleta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(149, 133);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(181, 52);
            this.btn21.TabIndex = 0;
            this.btn21.Text = "Jogar Blackjack(21)";
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // btnBicho
            // 
            this.btnBicho.Location = new System.Drawing.Point(149, 230);
            this.btnBicho.Name = "btnBicho";
            this.btnBicho.Size = new System.Drawing.Size(181, 53);
            this.btnBicho.TabIndex = 1;
            this.btnBicho.Text = "Jogar Jogo do Bicho";
            this.btnBicho.UseVisualStyleBackColor = true;
            this.btnBicho.Click += new System.EventHandler(this.btnBicho_Click);
            // 
            // btnRoleta
            // 
            this.btnRoleta.Location = new System.Drawing.Point(438, 133);
            this.btnRoleta.Name = "btnRoleta";
            this.btnRoleta.Size = new System.Drawing.Size(171, 52);
            this.btnRoleta.TabIndex = 2;
            this.btnRoleta.Text = "Jogar Roleta";
            this.btnRoleta.UseVisualStyleBackColor = true;
            this.btnRoleta.Click += new System.EventHandler(this.btnRoleta_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(274, 363);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(238, 44);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(438, 230);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(171, 53);
            this.btnDepositar.TabIndex = 5;
            this.btnDepositar.Text = "Depositar ";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRoleta);
            this.Controls.Add(this.btnBicho);
            this.Controls.Add(this.btn21);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btnBicho;
        private System.Windows.Forms.Button btnRoleta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label2;
    }
}