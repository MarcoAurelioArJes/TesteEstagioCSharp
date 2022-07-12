namespace CadastroCarros
{
    partial class TelaDetalhes
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
            this.txtModeloDetalhes = new System.Windows.Forms.TextBox();
            this.txtPlacaDetalhes = new System.Windows.Forms.TextBox();
            this.txtChassiDetalhes = new System.Windows.Forms.TextBox();
            this.txtAnoDetalhes = new System.Windows.Forms.TextBox();
            this.txtMarcaDetalhes = new System.Windows.Forms.TextBox();
            this.Atualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtModeloDetalhes
            // 
            this.txtModeloDetalhes.Location = new System.Drawing.Point(45, 87);
            this.txtModeloDetalhes.Name = "txtModeloDetalhes";
            this.txtModeloDetalhes.Size = new System.Drawing.Size(374, 26);
            this.txtModeloDetalhes.TabIndex = 0;
            // 
            // txtPlacaDetalhes
            // 
            this.txtPlacaDetalhes.Location = new System.Drawing.Point(45, 169);
            this.txtPlacaDetalhes.Name = "txtPlacaDetalhes";
            this.txtPlacaDetalhes.Size = new System.Drawing.Size(374, 26);
            this.txtPlacaDetalhes.TabIndex = 1;
            // 
            // txtChassiDetalhes
            // 
            this.txtChassiDetalhes.Location = new System.Drawing.Point(471, 87);
            this.txtChassiDetalhes.Name = "txtChassiDetalhes";
            this.txtChassiDetalhes.ReadOnly = true;
            this.txtChassiDetalhes.Size = new System.Drawing.Size(374, 26);
            this.txtChassiDetalhes.TabIndex = 2;
            // 
            // txtAnoDetalhes
            // 
            this.txtAnoDetalhes.Location = new System.Drawing.Point(471, 169);
            this.txtAnoDetalhes.Name = "txtAnoDetalhes";
            this.txtAnoDetalhes.Size = new System.Drawing.Size(374, 26);
            this.txtAnoDetalhes.TabIndex = 3;
            // 
            // txtMarcaDetalhes
            // 
            this.txtMarcaDetalhes.Location = new System.Drawing.Point(45, 256);
            this.txtMarcaDetalhes.Name = "txtMarcaDetalhes";
            this.txtMarcaDetalhes.Size = new System.Drawing.Size(374, 26);
            this.txtMarcaDetalhes.TabIndex = 4;
            // 
            // Atualizar
            // 
            this.Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.Location = new System.Drawing.Point(469, 228);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(376, 62);
            this.Atualizar.TabIndex = 5;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chassi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Editor de informações";
            // 
            // TelaDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 325);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.txtMarcaDetalhes);
            this.Controls.Add(this.txtAnoDetalhes);
            this.Controls.Add(this.txtChassiDetalhes);
            this.Controls.Add(this.txtPlacaDetalhes);
            this.Controls.Add(this.txtModeloDetalhes);
            this.Name = "TelaDetalhes";
            this.Text = "TelaDetalhes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModeloDetalhes;
        private System.Windows.Forms.TextBox txtPlacaDetalhes;
        private System.Windows.Forms.TextBox txtChassiDetalhes;
        private System.Windows.Forms.TextBox txtAnoDetalhes;
        private System.Windows.Forms.TextBox txtMarcaDetalhes;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}