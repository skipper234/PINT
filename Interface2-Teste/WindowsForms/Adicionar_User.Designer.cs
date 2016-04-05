namespace Interface2_Teste
{
    partial class Adicionar_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar_User));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_u_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_p_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cor_latitude = new System.Windows.Forms.MaskedTextBox();
            this.txt_cor_longitude = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_r_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_tipo_user = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.errorProviderValidarDados = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidarDados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_u_nome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_p_nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Pessoais";
            // 
            // txt_u_nome
            // 
            this.txt_u_nome.Location = new System.Drawing.Point(112, 50);
            this.txt_u_nome.Name = "txt_u_nome";
            this.txt_u_nome.Size = new System.Drawing.Size(213, 20);
            this.txt_u_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ultimo Nome";
            // 
            // txt_p_nome
            // 
            this.txt_p_nome.Location = new System.Drawing.Point(112, 23);
            this.txt_p_nome.Name = "txt_p_nome";
            this.txt_p_nome.Size = new System.Drawing.Size(213, 20);
            this.txt_p_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cor_latitude);
            this.groupBox2.Controls.Add(this.txt_cor_longitude);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações da Aplicação";
            // 
            // txt_cor_latitude
            // 
            this.txt_cor_latitude.Location = new System.Drawing.Point(112, 50);
            this.txt_cor_latitude.Mask = "0.999999999";
            this.txt_cor_latitude.Name = "txt_cor_latitude";
            this.txt_cor_latitude.Size = new System.Drawing.Size(213, 20);
            this.txt_cor_latitude.TabIndex = 5;
            // 
            // txt_cor_longitude
            // 
            this.txt_cor_longitude.Location = new System.Drawing.Point(112, 24);
            this.txt_cor_longitude.Mask = "0.999999999";
            this.txt_cor_longitude.Name = "txt_cor_longitude";
            this.txt_cor_longitude.Size = new System.Drawing.Size(213, 20);
            this.txt_cor_longitude.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cor. Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cor. Longitude";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_r_password);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_password);
            this.groupBox3.Location = new System.Drawing.Point(12, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 68);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txt_r_password
            // 
            this.txt_r_password.Location = new System.Drawing.Point(112, 40);
            this.txt_r_password.Name = "txt_r_password";
            this.txt_r_password.PasswordChar = '●';
            this.txt_r_password.Size = new System.Drawing.Size(213, 20);
            this.txt_r_password.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rep. Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(112, 13);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(213, 20);
            this.txt_password.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_tipo_user);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 41);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // cb_tipo_user
            // 
            this.cb_tipo_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo_user.FormattingEnabled = true;
            this.cb_tipo_user.Items.AddRange(new object[] {
            "Administrador",
            "Funcionario"});
            this.cb_tipo_user.Location = new System.Drawing.Point(112, 13);
            this.cb_tipo_user.Name = "cb_tipo_user";
            this.cb_tipo_user.Size = new System.Drawing.Size(213, 21);
            this.cb_tipo_user.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tipo de Utilizador";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(267, 302);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(89, 31);
            this.btn_entrar.TabIndex = 7;
            this.btn_entrar.Text = "Adicionar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // errorProviderValidarDados
            // 
            this.errorProviderValidarDados.ContainerControl = this;
            this.errorProviderValidarDados.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderValidarDados.Icon")));
            // 
            // Adicionar_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 340);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adicionar_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar User";
            this.Load += new System.EventHandler(this.Adicionar_User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidarDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_p_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_u_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_cor_latitude;
        private System.Windows.Forms.MaskedTextBox txt_cor_longitude;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_r_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_tipo_user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.ErrorProvider errorProviderValidarDados;
    }
}