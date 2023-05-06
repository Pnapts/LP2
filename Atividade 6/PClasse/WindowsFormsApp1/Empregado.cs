using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Empregado
    {
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }
        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }
        public string VerificaHome()
        {
            if (homeOffice == 'S')
                return "empregado trabalha em homeoffice";
            else
                return " Empregado nao trabalha em home office";
        }
        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days);
        }

        public abstract double SalarioBruto();
    }
}

