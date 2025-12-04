namespace SorrisoDaFortuna
{
    partial class FormSlotMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSlotMachine));
            this.Number1label1 = new System.Windows.Forms.Label();
            this.Number2label2 = new System.Windows.Forms.Label();
            this.Number3label3 = new System.Windows.Forms.Label();
            this.cmbApostas = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number1label1
            // 
            this.Number1label1.AutoSize = true;
            this.Number1label1.BackColor = System.Drawing.Color.Transparent;
            this.Number1label1.Font = new System.Drawing.Font("Wide Latin", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1label1.Location = new System.Drawing.Point(89, 189);
            this.Number1label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number1label1.Name = "Number1label1";
            this.Number1label1.Size = new System.Drawing.Size(70, 50);
            this.Number1label1.TabIndex = 0;
            this.Number1label1.Text = "9";
            // 
            // Number2label2
            // 
            this.Number2label2.AutoSize = true;
            this.Number2label2.BackColor = System.Drawing.Color.Transparent;
            this.Number2label2.Font = new System.Drawing.Font("Wide Latin", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2label2.Location = new System.Drawing.Point(177, 189);
            this.Number2label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number2label2.Name = "Number2label2";
            this.Number2label2.Size = new System.Drawing.Size(70, 50);
            this.Number2label2.TabIndex = 1;
            this.Number2label2.Text = "9";
            // 
            // Number3label3
            // 
            this.Number3label3.AutoSize = true;
            this.Number3label3.BackColor = System.Drawing.Color.Transparent;
            this.Number3label3.Font = new System.Drawing.Font("Wide Latin", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number3label3.Location = new System.Drawing.Point(264, 189);
            this.Number3label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number3label3.Name = "Number3label3";
            this.Number3label3.Size = new System.Drawing.Size(70, 50);
            this.Number3label3.TabIndex = 2;
            this.Number3label3.Text = "9";
            // 
            // cmbApostas
            // 
            this.cmbApostas.FormattingEnabled = true;
            this.cmbApostas.Location = new System.Drawing.Point(288, 303);
            this.cmbApostas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbApostas.Name = "cmbApostas";
            this.cmbApostas.Size = new System.Drawing.Size(69, 23);
            this.cmbApostas.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(165, 340);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 25);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "SPIN";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(182, 373);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(61, 27);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(152, 311);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(40, 15);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "label1";
            // 
            // FormSlotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 425);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cmbApostas);
            this.Controls.Add(this.Number3label3);
            this.Controls.Add(this.Number2label2);
            this.Controls.Add(this.Number1label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormSlotMachine";
            this.Text = "FormSlotMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number1label1;
        private System.Windows.Forms.Label Number2label2;
        private System.Windows.Forms.Label Number3label3;
        private System.Windows.Forms.ComboBox cmbApostas;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblSaldo;
    }
}
