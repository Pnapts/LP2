namespace WindowsFormsApp1
{
    partial class frmMensalista
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
            this.btnInstMens = new System.Windows.Forms.Button();
            this.btnInsMenPar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstMens
            // 
            this.btnInstMens.Location = new System.Drawing.Point(201, 223);
            this.btnInstMens.Name = "btnInstMens";
            this.btnInstMens.Size = new System.Drawing.Size(170, 118);
            this.btnInstMens.TabIndex = 0;
            this.btnInstMens.Text = "Instanciar Mensalista";
            this.btnInstMens.UseVisualStyleBackColor = true;
            this.btnInstMens.Click += new System.EventHandler(this.BtnInstMens_Click);
            // 
            // btnInsMenPar
            // 
            this.btnInsMenPar.Location = new System.Drawing.Point(568, 223);
            this.btnInsMenPar.Name = "btnInsMenPar";
            this.btnInsMenPar.Size = new System.Drawing.Size(170, 118);
            this.btnInsMenPar.TabIndex = 1;
            this.btnInsMenPar.Text = "Instanciar Mensalista Passando Paramentros";
            this.btnInsMenPar.UseVisualStyleBackColor = true;
            this.btnInsMenPar.Click += new System.EventHandler(this.BtnInsMenPar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(288, 48);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matricula";
            this.lblMatricula.Click += new System.EventHandler(this.LblMatricula_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(288, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.LblNome_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(288, 116);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(76, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario Mensal";
            this.lblSalario.Click += new System.EventHandler(this.LblSalario_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(288, 148);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(129, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data Entrada na Empresa";
            this.lblData.Click += new System.EventHandler(this.LblData_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(421, 46);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(88, 20);
            this.txtMatricula.TabIndex = 6;
            this.txtMatricula.TextChanged += new System.EventHandler(this.TxtMatricula_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(421, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(88, 20);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(421, 116);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(88, 20);
            this.txtSalario.TabIndex = 8;
            this.txtSalario.TextChanged += new System.EventHandler(this.TxtSalario_TextChanged);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(421, 148);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(88, 20);
            this.txtEntrada.TabIndex = 9;
            this.txtEntrada.TextChanged += new System.EventHandler(this.TxtEntrada_TextChanged);
            // 
            // gbxHome
            // 
            this.gbxHome.Controls.Add(this.rbtNao);
            this.gbxHome.Controls.Add(this.rbtSim);
            this.gbxHome.Location = new System.Drawing.Point(616, 50);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(134, 117);
            this.gbxHome.TabIndex = 10;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Home Office?";
            this.gbxHome.Enter += new System.EventHandler(this.GbxHome_Enter);
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.Location = new System.Drawing.Point(25, 50);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(44, 17);
            this.rbtSim.TabIndex = 0;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "SIM";
            this.rbtSim.UseVisualStyleBackColor = true;
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Location = new System.Drawing.Point(25, 73);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(48, 17);
            this.rbtNao.TabIndex = 1;
            this.rbtNao.TabStop = true;
            this.rbtNao.Text = "NAO";
            this.rbtNao.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnInsMenPar);
            this.Controls.Add(this.btnInstMens);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstMens;
        private System.Windows.Forms.Button btnInsMenPar;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.RadioButton rbtSim;
    }
}