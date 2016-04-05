namespace Interface2_Teste
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
            this.menu = new System.Windows.Forms.StatusStrip();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.menu_utilizadores = new System.Windows.Forms.ToolStripDropDownButton();
            this.menu_adicionar_ustilizador = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_editar_utilizador = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_remover_utlizador = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_p_interesse = new System.Windows.Forms.ToolStripDropDownButton();
            this.menu_adicionar_p_interesse = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_editar_p_interesse = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_remover_p_interesse = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_manutenção = new System.Windows.Forms.ToolStripDropDownButton();
            this.menu_adicionar_manutenção = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_editar_manutenção = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_remover_manutenção = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_precursos = new System.Windows.Forms.ToolStripDropDownButton();
            this.menu_utilizador_login = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_lbl_bem_vindo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_estatisticas = new System.Windows.Forms.ToolStripDropDownButton();
            this.calcularDistanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_utilizadores,
            this.menu_p_interesse,
            this.menu_manutenção,
            this.menu_precursos,
            this.menu_utilizador_login,
            this.menu_lbl_bem_vindo,
            this.menu_estatisticas});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(752, 22);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.menu);
            this.panel_menu.Location = new System.Drawing.Point(-1, -1);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(754, 25);
            this.panel_menu.TabIndex = 2;
            // 
            // menu_utilizadores
            // 
            this.menu_utilizadores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_adicionar_ustilizador,
            this.menu_editar_utilizador,
            this.menu_remover_utlizador});
            this.menu_utilizadores.Image = ((System.Drawing.Image)(resources.GetObject("menu_utilizadores.Image")));
            this.menu_utilizadores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_utilizadores.Name = "menu_utilizadores";
            this.menu_utilizadores.Size = new System.Drawing.Size(97, 20);
            this.menu_utilizadores.Text = "Utilizadores";
            // 
            // menu_adicionar_ustilizador
            // 
            this.menu_adicionar_ustilizador.Image = global::Interface2_Teste.Properties.Resources.add;
            this.menu_adicionar_ustilizador.Name = "menu_adicionar_ustilizador";
            this.menu_adicionar_ustilizador.Size = new System.Drawing.Size(178, 22);
            this.menu_adicionar_ustilizador.Text = "Adicionar Utilizador";
            this.menu_adicionar_ustilizador.Click += new System.EventHandler(this.menu_adicionar_ustilizador_Click);
            // 
            // menu_editar_utilizador
            // 
            this.menu_editar_utilizador.Image = ((System.Drawing.Image)(resources.GetObject("menu_editar_utilizador.Image")));
            this.menu_editar_utilizador.Name = "menu_editar_utilizador";
            this.menu_editar_utilizador.Size = new System.Drawing.Size(178, 22);
            this.menu_editar_utilizador.Text = "Editar Utilizador";
            this.menu_editar_utilizador.Click += new System.EventHandler(this.menu_editar_utilizador_Click);
            // 
            // menu_remover_utlizador
            // 
            this.menu_remover_utlizador.Image = global::Interface2_Teste.Properties.Resources.remove;
            this.menu_remover_utlizador.Name = "menu_remover_utlizador";
            this.menu_remover_utlizador.Size = new System.Drawing.Size(178, 22);
            this.menu_remover_utlizador.Text = "Remover Utilizador";
            // 
            // menu_p_interesse
            // 
            this.menu_p_interesse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_adicionar_p_interesse,
            this.menu_editar_p_interesse,
            this.menu_remover_p_interesse});
            this.menu_p_interesse.Image = global::Interface2_Teste.Properties.Resources.ponto;
            this.menu_p_interesse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_p_interesse.Name = "menu_p_interesse";
            this.menu_p_interesse.Size = new System.Drawing.Size(122, 20);
            this.menu_p_interesse.Text = "Pontos Interesse";
            // 
            // menu_adicionar_p_interesse
            // 
            this.menu_adicionar_p_interesse.Name = "menu_adicionar_p_interesse";
            this.menu_adicionar_p_interesse.Size = new System.Drawing.Size(187, 22);
            this.menu_adicionar_p_interesse.Text = "Adicionar P. Interesse";
            // 
            // menu_editar_p_interesse
            // 
            this.menu_editar_p_interesse.Name = "menu_editar_p_interesse";
            this.menu_editar_p_interesse.Size = new System.Drawing.Size(187, 22);
            this.menu_editar_p_interesse.Text = "Editar P. Interesse";
            // 
            // menu_remover_p_interesse
            // 
            this.menu_remover_p_interesse.Name = "menu_remover_p_interesse";
            this.menu_remover_p_interesse.Size = new System.Drawing.Size(187, 22);
            this.menu_remover_p_interesse.Text = "Remover P. Interesse";
            // 
            // menu_manutenção
            // 
            this.menu_manutenção.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_adicionar_manutenção,
            this.menu_editar_manutenção,
            this.menu_remover_manutenção});
            this.menu_manutenção.Image = global::Interface2_Teste.Properties.Resources.manuteção;
            this.menu_manutenção.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_manutenção.Name = "menu_manutenção";
            this.menu_manutenção.Size = new System.Drawing.Size(108, 20);
            this.menu_manutenção.Text = "Manutenções";
            // 
            // menu_adicionar_manutenção
            // 
            this.menu_adicionar_manutenção.Name = "menu_adicionar_manutenção";
            this.menu_adicionar_manutenção.Size = new System.Drawing.Size(195, 22);
            this.menu_adicionar_manutenção.Text = "Adicionar Manutenção";
            // 
            // menu_editar_manutenção
            // 
            this.menu_editar_manutenção.Name = "menu_editar_manutenção";
            this.menu_editar_manutenção.Size = new System.Drawing.Size(195, 22);
            this.menu_editar_manutenção.Text = "Editar Manutenção";
            // 
            // menu_remover_manutenção
            // 
            this.menu_remover_manutenção.Name = "menu_remover_manutenção";
            this.menu_remover_manutenção.Size = new System.Drawing.Size(195, 22);
            this.menu_remover_manutenção.Text = "Remover Manutenção";
            // 
            // menu_precursos
            // 
            this.menu_precursos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularDistanciaToolStripMenuItem});
            this.menu_precursos.Image = global::Interface2_Teste.Properties.Resources.rotas;
            this.menu_precursos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_precursos.Name = "menu_precursos";
            this.menu_precursos.Size = new System.Drawing.Size(87, 20);
            this.menu_precursos.Text = "Percursos";
            // 
            // menu_utilizador_login
            // 
            this.menu_utilizador_login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_utilizador_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_utilizador_login.Image = ((System.Drawing.Image)(resources.GetObject("menu_utilizador_login.Image")));
            this.menu_utilizador_login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_utilizador_login.Name = "menu_utilizador_login";
            this.menu_utilizador_login.Size = new System.Drawing.Size(77, 17);
            this.menu_utilizador_login.Text = "Utilizador";
            // 
            // menu_lbl_bem_vindo
            // 
            this.menu_lbl_bem_vindo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_lbl_bem_vindo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu_lbl_bem_vindo.Image = ((System.Drawing.Image)(resources.GetObject("menu_lbl_bem_vindo.Image")));
            this.menu_lbl_bem_vindo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_lbl_bem_vindo.Name = "menu_lbl_bem_vindo";
            this.menu_lbl_bem_vindo.Size = new System.Drawing.Size(68, 17);
            this.menu_lbl_bem_vindo.Text = "Bem Vindo,";
            // 
            // menu_estatisticas
            // 
            this.menu_estatisticas.Image = global::Interface2_Teste.Properties.Resources.estatisticas;
            this.menu_estatisticas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_estatisticas.Name = "menu_estatisticas";
            this.menu_estatisticas.Size = new System.Drawing.Size(88, 20);
            this.menu_estatisticas.Text = "Estatística";
            // 
            // calcularDistanciaToolStripMenuItem
            // 
            this.calcularDistanciaToolStripMenuItem.Name = "calcularDistanciaToolStripMenuItem";
            this.calcularDistanciaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.calcularDistanciaToolStripMenuItem.Text = "calcular distancia";
            this.calcularDistanciaToolStripMenuItem.Click += new System.EventHandler(this.calcularDistanciaToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(746, 346);
            this.Controls.Add(this.panel_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip menu;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.ToolStripDropDownButton menu_utilizadores;
        private System.Windows.Forms.ToolStripMenuItem menu_adicionar_ustilizador;
        private System.Windows.Forms.ToolStripMenuItem menu_editar_utilizador;
        private System.Windows.Forms.ToolStripDropDownButton menu_p_interesse;
        private System.Windows.Forms.ToolStripMenuItem menu_adicionar_p_interesse;
        private System.Windows.Forms.ToolStripMenuItem menu_editar_p_interesse;
        private System.Windows.Forms.ToolStripDropDownButton menu_precursos;
        private System.Windows.Forms.ToolStripMenuItem menu_remover_utlizador;
        private System.Windows.Forms.ToolStripDropDownButton menu_estatisticas;
        private System.Windows.Forms.ToolStripDropDownButton menu_manutenção;
        private System.Windows.Forms.ToolStripStatusLabel menu_utilizador_login;
        private System.Windows.Forms.ToolStripStatusLabel menu_lbl_bem_vindo;
        private System.Windows.Forms.ToolStripMenuItem menu_remover_p_interesse;
        private System.Windows.Forms.ToolStripMenuItem menu_adicionar_manutenção;
        private System.Windows.Forms.ToolStripMenuItem menu_editar_manutenção;
        private System.Windows.Forms.ToolStripMenuItem menu_remover_manutenção;
        private System.Windows.Forms.ToolStripMenuItem calcularDistanciaToolStripMenuItem;




    }
}

