namespace CadastroCarros
{
    partial class TelaListagem
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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.buttonBusca = new System.Windows.Forms.Button();
            this.listViewCarros = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.Excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaCarros = new System.Windows.Forms.Label();
            this.Carregar = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(23, 66);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(646, 26);
            this.txtBusca.TabIndex = 0;
            // 
            // buttonBusca
            // 
            this.buttonBusca.Location = new System.Drawing.Point(692, 63);
            this.buttonBusca.Name = "buttonBusca";
            this.buttonBusca.Size = new System.Drawing.Size(103, 32);
            this.buttonBusca.TabIndex = 1;
            this.buttonBusca.Text = "Buscar";
            this.buttonBusca.UseVisualStyleBackColor = true;
            this.buttonBusca.Click += new System.EventHandler(this.ButtonBusca_Click);
            // 
            // listViewCarros
            // 
            this.listViewCarros.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewCarros.HideSelection = false;
            this.listViewCarros.Location = new System.Drawing.Point(23, 98);
            this.listViewCarros.MultiSelect = false;
            this.listViewCarros.Name = "listViewCarros";
            this.listViewCarros.Size = new System.Drawing.Size(881, 339);
            this.listViewCarros.TabIndex = 2;
            this.listViewCarros.UseCompatibleStateImageBehavior = false;
            this.listViewCarros.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewCarros_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Editar,
            this.Excluir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            // 
            // Editar
            // 
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(109, 22);
            this.Editar.Text = "Editar";
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(109, 22);
            this.Excluir.Text = "Excluir";
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // ListaCarros
            // 
            this.ListaCarros.AutoSize = true;
            this.ListaCarros.BackColor = System.Drawing.SystemColors.Control;
            this.ListaCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCarros.Location = new System.Drawing.Point(10, 9);
            this.ListaCarros.Name = "ListaCarros";
            this.ListaCarros.Size = new System.Drawing.Size(250, 37);
            this.ListaCarros.TabIndex = 3;
            this.ListaCarros.Text = "Lista de Carros";
            // 
            // Carregar
            // 
            this.Carregar.Location = new System.Drawing.Point(801, 63);
            this.Carregar.Name = "Carregar";
            this.Carregar.Size = new System.Drawing.Size(103, 32);
            this.Carregar.TabIndex = 4;
            this.Carregar.Text = "Atualizar";
            this.Carregar.UseVisualStyleBackColor = true;
            this.Carregar.Click += new System.EventHandler(this.Carregar_Click);
            // 
            // TelaListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 493);
            this.ControlBox = false;
            this.Controls.Add(this.Carregar);
            this.Controls.Add(this.ListaCarros);
            this.Controls.Add(this.listViewCarros);
            this.Controls.Add(this.buttonBusca);
            this.Controls.Add(this.txtBusca);
            this.Name = "TelaListagem";
            this.Text = "TelaListagem";
            this.Activated += new System.EventHandler(this.TelaListagem_Activated);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button buttonBusca;
        private System.Windows.Forms.ListView listViewCarros;
        private System.Windows.Forms.Label ListaCarros;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Editar;
        private System.Windows.Forms.ToolStripMenuItem Excluir;
        private System.Windows.Forms.Button Carregar;
    }
}