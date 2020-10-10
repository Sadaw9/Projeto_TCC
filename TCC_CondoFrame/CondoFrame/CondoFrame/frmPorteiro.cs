using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace CondoFrame
{
    public partial class frmPorteiro : Form
    {

        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_porteiro;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_porteiro = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;


        public frmPorteiro()
        {
            InitializeComponent();
        }

        private void frmPorteiro_Load(object sender, EventArgs e)
        {

        }

        private void carregar_grid()
        {
            //Determine a query desejada
            _query = "Select * from porteiro";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_porteiro = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_porteiro.HasRows == true)
            {
                bs_porteiro.DataSource = dr_porteiro;
                dgv_porteiro.DataSource = bs_porteiro;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos clientes cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void igualar_text()
        {
            txtNamePort.DataBindings.Add("Text", bs_porteiro, "nome");
            txtNamePort.DataBindings.Clear();

            mtxtRGPort.DataBindings.Add("Text", bs_porteiro, "rg");
            mtxtRGPort.DataBindings.Clear();

            mtxtCPFPort.DataBindings.Add("Text", bs_porteiro, "cpf");
            mtxtCPFPort.DataBindings.Clear();


            mtxtdtADDPort.DataBindings.Add("Text", bs_porteiro, "dataadmissao");
            mtxtdtADDPort.DataBindings.Clear();

            mtxtDTDemPort.DataBindings.Add("Text", bs_porteiro, "datademisao");
            mtxtDTDemPort.DataBindings.Clear();

        }

        private void frm_Porteiro_Load(object sender, EventArgs e)
        {
            // alimenta o datagridview com dados
            carregar_grid();
        }


        private void dgv_porteiro_Click(object sender, EventArgs e)
        {
            igualar_text();
        }


        private void dgv_porteiro_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

    }
}
