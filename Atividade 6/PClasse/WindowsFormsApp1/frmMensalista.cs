using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void BtnInstMens_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtEntrada.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            if (rbtSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';
            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "\n" + "Salario Bruto: " +
                objMensalista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa(dias): " +
                objMensalista.TempoTrabalho() +
                "\n" + objMensalista.VerificaHome()
                );
        }

        private void TxtEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblData_Click(object sender, EventArgs e)
        {

        }

        private void LblSalario_Click(object sender, EventArgs e)
        {

        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }

        private void LblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsMenPar_Click(object sender, EventArgs e)
        {

        }

        private void GbxHome_Enter(object sender, EventArgs e)
        {

        }
    }
}
