namespace WindowsFormsApp1
{
    partial class frmHorista
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
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.txtFalta = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnInstMens = new System.Windows.Forms.Button();
            this.lblDiasFalta = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lblNumHoras = new System.Windows.Forms.Label();
            this.txtNumHoras = new System.Windows.Forms.TextBox();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHome
            // 
            this.gbxHome.Controls.Add(this.rbtNao);
            this.gbxHome.Controls.Add(this.rbtSim);
            this.gbxHome.Location = new System.Drawing.Point(541, 82);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(134, 117);
            this.gbxHome.TabIndex = 21;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Home Office?";
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
            // txtFalta
            // 
            this.txtFalta.Location = new System.Drawing.Point(346, 196);
            this.txtFalta.Name = "txtFalta";
            this.txtFalta.Size = new System.Drawing.Size(88, 20);
            this.txtFalta.TabIndex = 20;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(346, 114);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(88, 20);
            this.txtSalario.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(346, 81);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(88, 20);
            this.txtNome.TabIndex = 18;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(346, 49);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(88, 20);
            this.txtMatricula.TabIndex = 17;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(190, 170);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(129, 13);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data Entrada na Empresa";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(190, 114);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(83, 13);
            this.lblSalario.TabIndex = 15;
            this.lblSalario.Text = "Salario por Hora";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(190, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(190, 49);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 13;
            this.lblMatricula.Text = "Matricula";
            // 
            // btnInstMens
            // 
            this.btnInstMens.Location = new System.Drawing.Point(335, 261);
            this.btnInstMens.Name = "btnInstMens";
            this.btnInstMens.Size = new System.Drawing.Size(170, 118);
            this.btnInstMens.TabIndex = 11;
            this.btnInstMens.Text = "Instanciar Horista";
            this.btnInstMens.UseVisualStyleBackColor = true;
            this.btnInstMens.Click += new System.EventHandler(this.BtnInstMens_Click);
            // 
            // lblDiasFalta
            // 
            this.lblDiasFalta.AutoSize = true;
            this.lblDiasFalta.Location = new System.Drawing.Point(190, 196);
            this.lblDiasFalta.Name = "lblDiasFalta";
            this.lblDiasFalta.Size = new System.Drawing.Size(74, 13);
            this.lblDiasFalta.TabIndex = 23;
            this.lblDiasFalta.Text = "Dias de Faltas";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(346, 170);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(88, 20);
            this.txtEntrada.TabIndex = 24;
            // 
            // lblNumHoras
            // 
            this.lblNumHoras.AutoSize = true;
            this.lblNumHoras.Location = new System.Drawing.Point(190, 145);
            this.lblNumHoras.Name = "lblNumHoras";
            this.lblNumHoras.Size = new System.Drawing.Size(90, 13);
            this.lblNumHoras.TabIndex = 25;
            this.lblNumHoras.Text = "Numero de Horas";
            // 
            // txtNumHoras
            // 
            this.txtNumHoras.Location = new System.Drawing.Point(346, 145);
            this.txtNumHoras.Name = "txtNumHoras";
            this.txtNumHoras.Size = new System.Drawing.Size(88, 20);
            this.txtNumHoras.TabIndex = 26;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumHoras);
            this.Controls.Add(this.lblNumHoras);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblDiasFalta);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtFalta);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnInstMens);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.RadioButton rbtSim;
        private System.Windows.Forms.TextBox txtFalta;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnInstMens;
        private System.Windows.Forms.Label lblDiasFalta;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblNumHoras;
        private System.Windows.Forms.TextBox txtNumHoras;
    }
}