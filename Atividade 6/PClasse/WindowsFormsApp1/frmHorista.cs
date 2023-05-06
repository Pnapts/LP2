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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void BtnInstMens_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtEntrada.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHoras.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFalta.Text);
            if (rbtSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';
            MessageBox.Show ("Matricula: " + objHorista.Matricula + "\n" +
                "Nome: " + objHorista.NomeEmpregado + "\n" +
                "Data Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() +
                "\n" + "Salario Bruto: " +
                objHorista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa(dias): " +
                objHorista.TempoTrabalho() +
                "\n" + objHorista.VerificaHome());

        }
    }
}
