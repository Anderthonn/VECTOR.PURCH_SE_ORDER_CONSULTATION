//Calling the NuGet extension usings
//Below are the Metro Framework usings used to create a more modern user interface
using MetroFramework;
using MetroFramework.Design;
using MetroFramework.Fonts;
//Using to access Excel functionality
using Microsoft.Office.Interop.Excel;
//Using to connect to the SQL Server database
using System.Data;
using System.Data.SqlClient;

namespace GS_FARMA___PEDIDO_DE_COMPRA_CONSULTA
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Connection string to the SQL Server database
        public string strConexao = @"";
        public SqlConnection con;

        //DataTable extension for displaying TXT data
        System.Data.DataTable newTable = new System.Data.DataTable();

        //OpenFileDialog extension to select the TXT file
        OpenFileDialog ofd = new OpenFileDialog();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strConexao);
                con.Open();
            }
            catch
            {
                MessageBox.Show("Não foi possivel realizar a conexão com a base de dados, por favor tente novamnete!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Button that opens the OpenFileDialog to select the TXT, read it, and display the data in a DataGridView
        public void btnImportar_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] separators = new string[] { "\r\n" };

                using (TextReader tr = new StreamReader(ofd.FileName))
                {
                    if (Path.GetExtension(ofd.SafeFileName) == ".txt" | Path.GetExtension(ofd.SafeFileName) == ".TXT")
                    {
                        //Reads the file text
                        string text = tr.ReadToEnd();
                        //Splits the TXT contents by lines
                        string[] lines = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                        tbEmpresa.Text = lines[0].ToUpper();
                        tbStatus.Text = lines[1].ToString().Substring(0, 49).ToUpper();
                        tbPagina.Text = lines[1].ToString().Substring(114, 13).ToUpper();
                        tbFornecedor.Text = lines[2].ToString().Substring(0, 35).ToUpper();
                        tbEmissao.Text = lines[2].ToString().Substring(114, 23).ToUpper();
                        tbMetodo.Text = lines[3].ToString().Substring(0, 25).ToUpper();
                        tbReposicao.Text = lines[4].ToString().Substring(0, 16).ToUpper();
                        tbSuprimento.Text = lines[4].ToString().Substring(24, 17).ToUpper();
                        tbUsuario.Text = lines[3].ToString().Substring(114).ToUpper();

                        try
                        {
                            String[] colunas = lines[6].Split(" ");

                            newTable.Columns.Add(colunas[0]);
                            newTable.Columns.Add(colunas[1]);
                            newTable.Columns.Add(colunas[23]);
                            newTable.Columns.Add(colunas[24]);
                            newTable.Columns.Add(colunas[28]);
                            newTable.Columns.Add(colunas[32]);
                            newTable.Columns.Add(colunas[36]);
                            newTable.Columns.Add(colunas[40]);
                            newTable.Columns.Add(colunas[41]);
                            newTable.Columns.Add(colunas[42]);
                            newTable.Columns.Add(colunas[43]);
                            newTable.Columns.Add(colunas[44]);
                            newTable.Columns.Add(colunas[46]);
                            newTable.Columns.Add(colunas[47]);
                            newTable.Columns.Add(colunas[48]);
                            newTable.Columns.Add(colunas[50]);
                            newTable.Columns.Add(colunas[51]);

                            for (int l = 8; l < lines.Length; l++)
                            {
                                if (lines[l].StartsWith("=") && lines[l].EndsWith("="))
                                {
                                    break;
                                }                                
                                if (lines[l].StartsWith("G"))
                                {
                                    l += 12;
                                } 
                                
                                newTable.Rows.Add(lines[l].Substring(0, 6), lines[l].Substring(7, 29), lines[l].Substring(37, 6), lines[l].Substring(44, 6), lines[l].Substring(51, 6), lines[l].Substring(58, 6), lines[l].Substring(65, 6), lines[l].Substring(72, 5), lines[l].Substring(78, 6),
                                lines[l].Substring(85, 6), lines[l].Substring(92, 3), lines[l].Substring(96, 5), lines[l].Substring(102, 8), lines[l].Substring(111, 5), lines[l].Substring(117, 7), lines[l].Substring(125, 4), lines[l].Substring(130, 7));
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Por favor apague a ultima importação para poder realizar uma nova!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        dgvDadosTxt.DataSource = newTable;
                        dgvDadosTxt.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvDadosTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        MessageBox.Show("Esse arquivo não é um arquivo de extenção (.TXT), por favor verifique!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        //Button that checks for data in components and clears it
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (tbEmpresa.Text.StartsWith(" "))
            {
                MessageBox.Show("Por favor primeiro importe um arquivo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tbEmpresa.Text = " ";
                tbStatus.Text = " ";
                tbPagina.Text = " ";
                tbFornecedor.Text = " ";
                tbEmissao.Text = " ";
                tbMetodo.Text = " ";
                tbReposicao.Text = " ";
                tbSuprimento.Text = " ";
                tbUsuario.Text = " ";
                tbTotalEstoque.Text = " ";
                tbTotalMedia.Text = " ";

                newTable.Columns.Clear();
                newTable.Rows.Clear();

                for (int i = 0; i < dgvDadosVetor.RowCount; i++)
                {
                    dgvDadosVetor.Rows[i].DataGridView.Columns.Clear();
                }
            }
        }

        //Button that reads data from the DataGridView and imports it into an Excel worksheet
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbEmpresa.Text.StartsWith(" "))
            {
                MessageBox.Show("Por favor primeiro importe um arquivo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)app.Worksheets[1];


                if (dgvDadosTxt.Rows.Count > 0)
                {
                    try
                    {
                        for (int i = 1; i < dgvDadosTxt.Columns.Count + 1; i++)
                        {
                            app.Cells[1, i] = dgvDadosTxt.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < dgvDadosTxt.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvDadosTxt.Columns.Count; j++)
                            {
                                app.Cells[i + 2, j + 1] = dgvDadosTxt.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        app.Columns.AutoFit();
                        app.Columns.VerticalAlignment = XlVAlign.xlVAlignCenter;
                        app.Columns.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        app.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                        app.Quit();
                    }
                    MessageBox.Show("O Arquivo foi gerado, Verifique o Excel!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //Selects the product code in the DataGridView and retrieves the data from the database
        private void dgvDadosTxt_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var s = dgvDadosTxt.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            try
            {
                if (s.ToString().Substring(0, 5) == "00000")
                {
                    try
                    {
                        var c = s.ToString().Remove(0, 5);
                        con = new SqlConnection(strConexao);
                        SqlCommand cmd = new SqlCommand("SELECT BI_FILIAL.Filial, BI_FILIAL.FilialNome AS 'Nome da Filial', BI_ESTOQUE.QT_EST AS 'Quantidade Estoque', ROUND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')), 0) AS 'Demanda', ROUND((((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)), 0) AS 'Demanda Por Loja' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataAdapter Data = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        con.Open();
                        Data.Fill(ds, "BI_FILIAL");
                        dgvDadosVetor.DataSource = ds;
                        dgvDadosVetor.DataMember = "BI_FILIAL";

                        SqlCommand somaQtEst = new SqlCommand("SELECT SUM(BI_ESTOQUE.QT_EST) AS 'TOTAL_QUANT' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtEst = somaQtEst.ExecuteReader();
                        rdQtEst.Read();
                        tbTotalEstoque.Text = rdQtEst["TOTAL_QUANT"].ToString();

                        SqlCommand somaQtMedia = new SqlCommand("SELECT ROUND(SUM(((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "'))),0) AS 'DEMANDA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtMedia = somaQtMedia.ExecuteReader();
                        rdQtMedia.Read();
                        tbTotalMedia.Text = rdQtMedia["DEMANDA"].ToString();

                        SqlCommand somaQtDemandaPorLoja = new SqlCommand("SELECT ROUND(SUM((((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST))),0) AS 'DEMANDA_LOJA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtDemandaPorLoja = somaQtDemandaPorLoja.ExecuteReader();
                        rdQtDemandaPorLoja.Read();
                        tbDemandaLoja.Text = rdQtDemandaPorLoja["DEMANDA_LOJA"].ToString();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel realizar a conexão com a base de dados, por favor tente novamnete!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (s.ToString().Substring(0, 4) == "0000")
                {
                    try
                    {
                        var c = s.ToString().Remove(0, 4);
                        con = new SqlConnection(strConexao);
                        SqlCommand cmd = new SqlCommand("SELECT BI_FILIAL.Filial, BI_FILIAL.FilialNome AS 'Nome da Filial', BI_ESTOQUE.QT_EST AS 'Quantidade Estoque', ROUND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')), 0) AS 'Demanda', ROUND((((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)), 0) AS 'Demanda Por Loja' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataAdapter Data = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        con.Open();
                        Data.Fill(ds, "BI_FILIAL");
                        dgvDadosVetor.DataSource = ds;
                        dgvDadosVetor.DataMember = "BI_FILIAL";

                        SqlCommand somaQtEst = new SqlCommand("SELECT SUM(BI_ESTOQUE.QT_EST) AS 'TOTAL_QUANT' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtEst = somaQtEst.ExecuteReader();
                        rdQtEst.Read();
                        tbTotalEstoque.Text = rdQtEst["TOTAL_QUANT"].ToString();

                        SqlCommand somaQtMedia = new SqlCommand("SELECT ROUND(SUM(((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "'))),0) AS 'DEMANDA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtMedia = somaQtMedia.ExecuteReader();
                        rdQtMedia.Read();
                        tbTotalMedia.Text = rdQtMedia["DEMANDA"].ToString();

                        SqlCommand somaQtDemandaPorLoja = new SqlCommand("SELECT ROUND(SUM((((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST))),0) AS 'DEMANDA_LOJA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtDemandaPorLoja = somaQtDemandaPorLoja.ExecuteReader();
                        rdQtDemandaPorLoja.Read();
                        tbDemandaLoja.Text = rdQtDemandaPorLoja["DEMANDA_LOJA"].ToString();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel realizar a conexão com a base de dados, por favor tente novamnete!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (s.ToString().Substring(0, 3) == "000")
                {
                    try
                    {
                        var c = s.ToString().Remove(0, 3);
                        con = new SqlConnection(strConexao);
                        SqlCommand cmd = new SqlCommand("SELECT BI_FILIAL.Filial, BI_FILIAL.FilialNome AS 'Nome da Filial', BI_ESTOQUE.QT_EST AS 'Quantidade Estoque', ROUND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')), 0) AS 'Demanda', ROUND((((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)), 0) AS 'Demanda Por Loja' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataAdapter Data = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        con.Open();
                        Data.Fill(ds, "BI_FILIAL");
                        dgvDadosVetor.DataSource = ds;
                        dgvDadosVetor.DataMember = "BI_FILIAL";

                        SqlCommand somaQtEst = new SqlCommand("SELECT SUM(BI_ESTOQUE.QT_EST) AS 'TOTAL_QUANT' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtEst = somaQtEst.ExecuteReader();
                        rdQtEst.Read();
                        tbTotalEstoque.Text = rdQtEst["TOTAL_QUANT"].ToString();

                        SqlCommand somaQtMedia = new SqlCommand("SELECT ROUND(SUM(((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "'))),0) AS 'DEMANDA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtMedia = somaQtMedia.ExecuteReader();
                        rdQtMedia.Read();
                        tbTotalMedia.Text = rdQtMedia["DEMANDA"].ToString();

                        SqlCommand somaQtDemandaPorLoja = new SqlCommand("SELECT ROUND(SUM((((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST))),0) AS 'DEMANDA_LOJA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtDemandaPorLoja = somaQtDemandaPorLoja.ExecuteReader();
                        rdQtDemandaPorLoja.Read();
                        tbDemandaLoja.Text = rdQtDemandaPorLoja["DEMANDA_LOJA"].ToString();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel realizar a conexão com a base de dados, por favor tente novamnete!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (s.ToString().Substring(0, 2) == "00")
                {
                    try
                    {
                        var c = s.ToString().Remove(0, 2);
                        con = new SqlConnection(strConexao);
                        SqlCommand cmd = new SqlCommand("SELECT BI_FILIAL.Filial, BI_FILIAL.FilialNome AS 'Nome da Filial', BI_ESTOQUE.QT_EST AS 'Quantidade Estoque', ROUND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')), 0) AS 'Demanda', ROUND((((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)), 0) AS 'Demanda Por Loja' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataAdapter Data = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        con.Open();
                        Data.Fill(ds, "BI_FILIAL");
                        dgvDadosVetor.DataSource = ds;
                        dgvDadosVetor.DataMember = "BI_FILIAL";

                        SqlCommand somaQtEst = new SqlCommand("SELECT SUM(BI_ESTOQUE.QT_EST) AS 'TOTAL_QUANT' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtEst = somaQtEst.ExecuteReader();
                        rdQtEst.Read();
                        tbTotalEstoque.Text = rdQtEst["TOTAL_QUANT"].ToString();

                        SqlCommand somaQtMedia = new SqlCommand("SELECT ROUND(SUM(((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "'))),0) AS 'DEMANDA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtMedia = somaQtMedia.ExecuteReader();
                        rdQtMedia.Read();
                        tbTotalMedia.Text = rdQtMedia["DEMANDA"].ToString();

                        SqlCommand somaQtDemandaPorLoja = new SqlCommand("SELECT ROUND(SUM((((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST))),0) AS 'DEMANDA_LOJA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtDemandaPorLoja = somaQtDemandaPorLoja.ExecuteReader();
                        rdQtDemandaPorLoja.Read();
                        tbDemandaLoja.Text = rdQtDemandaPorLoja["DEMANDA_LOJA"].ToString();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel realizar a conexão com a base de dados, por favor tente novamnete!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (s.ToString().Substring(0, 1) == "0")
                {
                    try
                    {
                        var c = s.ToString().Remove(0, 1);
                        con = new SqlConnection(strConexao);
                        SqlCommand cmd = new SqlCommand("SELECT BI_FILIAL.Filial, BI_FILIAL.FilialNome AS 'Nome da Filial', BI_ESTOQUE.QT_EST AS 'Quantidade Estoque', ROUND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')), 0) AS 'Demanda', ROUND((((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)), 0) AS 'Demanda Por Loja' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND(((BI_ESTOQUE.QTDE_MEDIAF / 30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataAdapter Data = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        con.Open();
                        Data.Fill(ds, "BI_FILIAL");
                        dgvDadosVetor.DataSource = ds;
                        dgvDadosVetor.DataMember = "BI_FILIAL";

                        SqlCommand somaQtEst = new SqlCommand("SELECT SUM(BI_ESTOQUE.QT_EST) AS 'TOTAL_QUANT' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtEst = somaQtEst.ExecuteReader();
                        rdQtEst.Read();
                        tbTotalEstoque.Text = rdQtEst["TOTAL_QUANT"].ToString();

                        SqlCommand somaQtMedia = new SqlCommand("SELECT ROUND(SUM(((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "'))),0) AS 'DEMANDA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtMedia = somaQtMedia.ExecuteReader();
                        rdQtMedia.Read();
                        tbTotalMedia.Text = rdQtMedia["DEMANDA"].ToString();

                        SqlCommand somaQtDemandaPorLoja = new SqlCommand("SELECT ROUND(SUM((((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST))),0) AS 'DEMANDA_LOJA' FROM BI_ESTOQUE, BI_FILIAL, EST_PROD_FORN WHERE EST_PROD_FORN.CD_FORN = 2115 AND BI_ESTOQUE.Filial = BI_FILIAL.Filial AND EST_PROD_FORN.CD_PROD = BI_ESTOQUE.CD_PROD AND (((BI_ESTOQUE.QTDE_MEDIAF/30) * ('" + tbDias.Text + "')) - (BI_ESTOQUE.QT_EST)) > 0 AND BI_FILIAL.Filial != 999 AND BI_FILIAL.Filial != 3 AND BI_FILIAL.Filial != 11 AND BI_FILIAL.Filial != 15 AND BI_FILIAL.Filial != 20 AND BI_FILIAL.Filial != 29 AND BI_FILIAL.Filial != 30 AND BI_FILIAL.Filial != 39 AND BI_FILIAL.Filial != 41 AND BI_FILIAL.Filial != 93 AND BI_FILIAL.Filial != 77 AND BI_FILIAL.Filial != 24 AND BI_FILIAL.Filial != 37 AND BI_ESTOQUE.CD_PROD = (SELECT EST_PROD_FORN.CD_PROD FROM EST_PROD_FORN WHERE CD_FORN = 2115 AND CD_PROD_FORN = '" + c + "')", con);
                        SqlDataReader rdQtDemandaPorLoja = somaQtDemandaPorLoja.ExecuteReader();
                        rdQtDemandaPorLoja.Read();
                        tbDemandaLoja.Text = rdQtDemandaPorLoja["DEMANDA_LOJA"].ToString();
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel realizar a conexão com a base de dados, por favor tente novamnete!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não a um codigo valido!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
