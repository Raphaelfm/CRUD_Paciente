namespace CRUD_Paciente
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_maximizar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_relatorios = new System.Windows.Forms.Button();
            this.btn_sair_menu = new System.Windows.Forms.Button();
            this.btn_paciente = new System.Windows.Forms.Button();
            this.pnl_conteudo = new System.Windows.Forms.Panel();
            this.pnl_top.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.pnl_top.Controls.Add(this.btn_restaurar);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.btn_maximizar);
            this.pnl_top.Controls.Add(this.btn_sair);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1800, 72);
            this.pnl_top.TabIndex = 0;
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseMove);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.FlatAppearance.BorderSize = 0;
            this.btn_restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.Location = new System.Drawing.Point(1615, 12);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(40, 40);
            this.btn_restaurar.TabIndex = 4;
            this.btn_restaurar.UseVisualStyleBackColor = true;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Sistema";
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.Location = new System.Drawing.Point(1673, 8);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(52, 48);
            this.btn_maximizar.TabIndex = 1;
            this.btn_maximizar.UseVisualStyleBackColor = true;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_sair.Image")));
            this.btn_sair.Location = new System.Drawing.Point(1748, 12);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(26, 40);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_menu.Controls.Add(this.btn_relatorios);
            this.pnl_menu.Controls.Add(this.btn_sair_menu);
            this.pnl_menu.Controls.Add(this.btn_paciente);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Location = new System.Drawing.Point(0, 72);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(227, 1034);
            this.pnl_menu.TabIndex = 1;
            // 
            // btn_relatorios
            // 
            this.btn_relatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_relatorios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_relatorios.FlatAppearance.BorderSize = 0;
            this.btn_relatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_relatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btn_relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relatorios.ForeColor = System.Drawing.Color.White;
            this.btn_relatorios.Image = ((System.Drawing.Image)(resources.GetObject("btn_relatorios.Image")));
            this.btn_relatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_relatorios.Location = new System.Drawing.Point(3, 125);
            this.btn_relatorios.Name = "btn_relatorios";
            this.btn_relatorios.Size = new System.Drawing.Size(224, 69);
            this.btn_relatorios.TabIndex = 2;
            this.btn_relatorios.Text = "Relatórios";
            this.btn_relatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_relatorios.UseVisualStyleBackColor = false;
            this.btn_relatorios.Click += new System.EventHandler(this.btn_relatorios_Click);
            // 
            // btn_sair_menu
            // 
            this.btn_sair_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_sair_menu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair_menu.FlatAppearance.BorderSize = 0;
            this.btn_sair_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sair_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btn_sair_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair_menu.ForeColor = System.Drawing.Color.White;
            this.btn_sair_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_sair_menu.Image")));
            this.btn_sair_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair_menu.Location = new System.Drawing.Point(2, 200);
            this.btn_sair_menu.Name = "btn_sair_menu";
            this.btn_sair_menu.Size = new System.Drawing.Size(225, 69);
            this.btn_sair_menu.TabIndex = 1;
            this.btn_sair_menu.Text = "Sair";
            this.btn_sair_menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair_menu.UseVisualStyleBackColor = false;
            this.btn_sair_menu.Click += new System.EventHandler(this.btn_sair_menu_Click);
            // 
            // btn_paciente
            // 
            this.btn_paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_paciente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_paciente.FlatAppearance.BorderSize = 0;
            this.btn_paciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_paciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btn_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paciente.ForeColor = System.Drawing.Color.White;
            this.btn_paciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_paciente.Image")));
            this.btn_paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paciente.Location = new System.Drawing.Point(2, 50);
            this.btn_paciente.Name = "btn_paciente";
            this.btn_paciente.Size = new System.Drawing.Size(225, 69);
            this.btn_paciente.TabIndex = 0;
            this.btn_paciente.Text = "Pacientes";
            this.btn_paciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_paciente.UseVisualStyleBackColor = false;
            this.btn_paciente.Click += new System.EventHandler(this.btn_paciente_Click);
            // 
            // pnl_conteudo
            // 
            this.pnl_conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_conteudo.Location = new System.Drawing.Point(227, 72);
            this.pnl_conteudo.Name = "pnl_conteudo";
            this.pnl_conteudo.Size = new System.Drawing.Size(1573, 1034);
            this.pnl_conteudo.TabIndex = 2;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1106);
            this.Controls.Add(this.pnl_conteudo);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_maximizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_relatorios;
        private System.Windows.Forms.Button btn_sair_menu;
        private System.Windows.Forms.Button btn_paciente;
        private System.Windows.Forms.Panel pnl_conteudo;
        private System.Windows.Forms.Button btn_restaurar;
    }
}