using System.Drawing.Drawing2D;

namespace GS_FARMA___PEDIDO_DE_COMPRA_CONSULTA
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDadosPedido = new System.Windows.Forms.GroupBox();
            this.tbDias = new System.Windows.Forms.TextBox();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.tbMetodo = new System.Windows.Forms.TextBox();
            this.tbReposicao = new System.Windows.Forms.TextBox();
            this.tbSuprimento = new System.Windows.Forms.TextBox();
            this.tbPagina = new System.Windows.Forms.TextBox();
            this.tbEmissao = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.dgvDadosTxt = new MetroFramework.Controls.MetroGrid();
            this.btnApagar = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnImportar = new MetroFramework.Controls.MetroButton();
            this.gbDadosVetor = new System.Windows.Forms.GroupBox();
            this.dgvDadosVetor = new MetroFramework.Controls.MetroGrid();
            this.tbTotalEstoque = new System.Windows.Forms.TextBox();
            this.lbTotalEstoque = new System.Windows.Forms.Label();
            this.tbTotalMedia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDemandaLoja = new System.Windows.Forms.Label();
            this.tbDemandaLoja = new System.Windows.Forms.TextBox();
            this.gbDadosPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosTxt)).BeginInit();
            this.gbDadosVetor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosVetor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDadosPedido
            // 
            this.gbDadosPedido.Controls.Add(this.tbDias);
            this.gbDadosPedido.Controls.Add(this.tbEmpresa);
            this.gbDadosPedido.Controls.Add(this.tbStatus);
            this.gbDadosPedido.Controls.Add(this.tbFornecedor);
            this.gbDadosPedido.Controls.Add(this.tbMetodo);
            this.gbDadosPedido.Controls.Add(this.tbReposicao);
            this.gbDadosPedido.Controls.Add(this.tbSuprimento);
            this.gbDadosPedido.Controls.Add(this.tbPagina);
            this.gbDadosPedido.Controls.Add(this.tbEmissao);
            this.gbDadosPedido.Controls.Add(this.tbUsuario);
            this.gbDadosPedido.Controls.Add(this.dgvDadosTxt);
            this.gbDadosPedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDadosPedido.Location = new System.Drawing.Point(23, 25);
            this.gbDadosPedido.Name = "gbDadosPedido";
            this.gbDadosPedido.Size = new System.Drawing.Size(1204, 416);
            this.gbDadosPedido.TabIndex = 0;
            this.gbDadosPedido.TabStop = false;
            this.gbDadosPedido.Text = "DADOS DO PEDIDO";
            // 
            // tbDias
            // 
            this.tbDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbDias.ForeColor = System.Drawing.Color.Black;
            this.tbDias.Location = new System.Drawing.Point(1028, 139);
            this.tbDias.Margin = new System.Windows.Forms.Padding(2);
            this.tbDias.Name = "tbDias";
            this.tbDias.Size = new System.Drawing.Size(80, 25);
            this.tbDias.TabIndex = 18;
            this.tbDias.Text = "60";
            this.tbDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbEmpresa.Enabled = false;
            this.tbEmpresa.ForeColor = System.Drawing.Color.Black;
            this.tbEmpresa.Location = new System.Drawing.Point(5, 23);
            this.tbEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmpresa.Multiline = true;
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(295, 25);
            this.tbEmpresa.TabIndex = 9;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbStatus.Enabled = false;
            this.tbStatus.ForeColor = System.Drawing.Color.Black;
            this.tbStatus.Location = new System.Drawing.Point(5, 52);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(400, 25);
            this.tbStatus.TabIndex = 10;
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbFornecedor.Enabled = false;
            this.tbFornecedor.ForeColor = System.Drawing.Color.Black;
            this.tbFornecedor.Location = new System.Drawing.Point(5, 81);
            this.tbFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.tbFornecedor.Multiline = true;
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(225, 25);
            this.tbFornecedor.TabIndex = 11;
            // 
            // tbMetodo
            // 
            this.tbMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbMetodo.Enabled = false;
            this.tbMetodo.ForeColor = System.Drawing.Color.Black;
            this.tbMetodo.Location = new System.Drawing.Point(5, 110);
            this.tbMetodo.Margin = new System.Windows.Forms.Padding(2);
            this.tbMetodo.Multiline = true;
            this.tbMetodo.Name = "tbMetodo";
            this.tbMetodo.Size = new System.Drawing.Size(145, 25);
            this.tbMetodo.TabIndex = 12;
            // 
            // tbReposicao
            // 
            this.tbReposicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbReposicao.Enabled = false;
            this.tbReposicao.ForeColor = System.Drawing.Color.Black;
            this.tbReposicao.Location = new System.Drawing.Point(5, 139);
            this.tbReposicao.Margin = new System.Windows.Forms.Padding(2);
            this.tbReposicao.Multiline = true;
            this.tbReposicao.Name = "tbReposicao";
            this.tbReposicao.Size = new System.Drawing.Size(135, 25);
            this.tbReposicao.TabIndex = 13;
            // 
            // tbSuprimento
            // 
            this.tbSuprimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbSuprimento.Enabled = false;
            this.tbSuprimento.ForeColor = System.Drawing.Color.Black;
            this.tbSuprimento.Location = new System.Drawing.Point(144, 139);
            this.tbSuprimento.Margin = new System.Windows.Forms.Padding(2);
            this.tbSuprimento.Multiline = true;
            this.tbSuprimento.Name = "tbSuprimento";
            this.tbSuprimento.Size = new System.Drawing.Size(145, 25);
            this.tbSuprimento.TabIndex = 14;
            // 
            // tbPagina
            // 
            this.tbPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbPagina.Enabled = false;
            this.tbPagina.ForeColor = System.Drawing.Color.Black;
            this.tbPagina.Location = new System.Drawing.Point(1028, 23);
            this.tbPagina.Margin = new System.Windows.Forms.Padding(2);
            this.tbPagina.Multiline = true;
            this.tbPagina.Name = "tbPagina";
            this.tbPagina.Size = new System.Drawing.Size(105, 25);
            this.tbPagina.TabIndex = 15;
            // 
            // tbEmissao
            // 
            this.tbEmissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbEmissao.Enabled = false;
            this.tbEmissao.ForeColor = System.Drawing.Color.Black;
            this.tbEmissao.Location = new System.Drawing.Point(1028, 52);
            this.tbEmissao.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmissao.Multiline = true;
            this.tbEmissao.Name = "tbEmissao";
            this.tbEmissao.Size = new System.Drawing.Size(170, 25);
            this.tbEmissao.TabIndex = 16;
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbUsuario.Enabled = false;
            this.tbUsuario.ForeColor = System.Drawing.Color.Black;
            this.tbUsuario.Location = new System.Drawing.Point(1028, 81);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsuario.Multiline = true;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(95, 25);
            this.tbUsuario.TabIndex = 17;
            // 
            // dgvDadosTxt
            // 
            this.dgvDadosTxt.AllowUserToResizeRows = false;
            this.dgvDadosTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDadosTxt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDadosTxt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDadosTxt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.dgvDadosTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDadosTxt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDadosTxt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosTxt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDadosTxt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDadosTxt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDadosTxt.EnableHeadersVisualStyles = false;
            this.dgvDadosTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDadosTxt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDadosTxt.Location = new System.Drawing.Point(6, 174);
            this.dgvDadosTxt.Name = "dgvDadosTxt";
            this.dgvDadosTxt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosTxt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDadosTxt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDadosTxt.RowTemplate.Height = 25;
            this.dgvDadosTxt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosTxt.Size = new System.Drawing.Size(1192, 236);
            this.dgvDadosTxt.TabIndex = 0;
            this.dgvDadosTxt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosTxt_CellClick);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApagar.BackgroundImage")));
            this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Location = new System.Drawing.Point(115, 680);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(40, 40);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnApagar.UseSelectable = true;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(69, 680);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Transparent;
            this.btnImportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportar.BackgroundImage")));
            this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Location = new System.Drawing.Point(26, 680);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(40, 40);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnImportar.UseSelectable = true;
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // gbDadosVetor
            // 
            this.gbDadosVetor.Controls.Add(this.dgvDadosVetor);
            this.gbDadosVetor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDadosVetor.Location = new System.Drawing.Point(23, 447);
            this.gbDadosVetor.Name = "gbDadosVetor";
            this.gbDadosVetor.Size = new System.Drawing.Size(1204, 229);
            this.gbDadosVetor.TabIndex = 1;
            this.gbDadosVetor.TabStop = false;
            this.gbDadosVetor.Text = "DADOS DO VETOR";
            // 
            // dgvDadosVetor
            // 
            this.dgvDadosVetor.AllowUserToResizeRows = false;
            this.dgvDadosVetor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDadosVetor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosVetor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDadosVetor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.dgvDadosVetor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDadosVetor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDadosVetor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosVetor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDadosVetor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDadosVetor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDadosVetor.EnableHeadersVisualStyles = false;
            this.dgvDadosVetor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDadosVetor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDadosVetor.Location = new System.Drawing.Point(5, 24);
            this.dgvDadosVetor.Name = "dgvDadosVetor";
            this.dgvDadosVetor.ReadOnly = true;
            this.dgvDadosVetor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosVetor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDadosVetor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDadosVetor.RowTemplate.Height = 25;
            this.dgvDadosVetor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosVetor.Size = new System.Drawing.Size(1193, 199);
            this.dgvDadosVetor.TabIndex = 18;
            // 
            // tbTotalEstoque
            // 
            this.tbTotalEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbTotalEstoque.Enabled = false;
            this.tbTotalEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTotalEstoque.ForeColor = System.Drawing.Color.Black;
            this.tbTotalEstoque.Location = new System.Drawing.Point(587, 682);
            this.tbTotalEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalEstoque.Multiline = true;
            this.tbTotalEstoque.Name = "tbTotalEstoque";
            this.tbTotalEstoque.Size = new System.Drawing.Size(95, 25);
            this.tbTotalEstoque.TabIndex = 18;
            this.tbTotalEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTotalEstoque
            // 
            this.lbTotalEstoque.AutoSize = true;
            this.lbTotalEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalEstoque.Location = new System.Drawing.Point(487, 686);
            this.lbTotalEstoque.Name = "lbTotalEstoque";
            this.lbTotalEstoque.Size = new System.Drawing.Size(96, 17);
            this.lbTotalEstoque.TabIndex = 18;
            this.lbTotalEstoque.Text = "Total Estoque:";
            // 
            // tbTotalMedia
            // 
            this.tbTotalMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbTotalMedia.Enabled = false;
            this.tbTotalMedia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTotalMedia.ForeColor = System.Drawing.Color.Black;
            this.tbTotalMedia.Location = new System.Drawing.Point(815, 682);
            this.tbTotalMedia.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalMedia.Multiline = true;
            this.tbTotalMedia.Name = "tbTotalMedia";
            this.tbTotalMedia.Size = new System.Drawing.Size(95, 25);
            this.tbTotalMedia.TabIndex = 19;
            this.tbTotalMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(709, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Demanda:";
            // 
            // lbDemandaLoja
            // 
            this.lbDemandaLoja.AutoSize = true;
            this.lbDemandaLoja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDemandaLoja.Location = new System.Drawing.Point(920, 686);
            this.lbDemandaLoja.Name = "lbDemandaLoja";
            this.lbDemandaLoja.Size = new System.Drawing.Size(118, 17);
            this.lbDemandaLoja.TabIndex = 22;
            this.lbDemandaLoja.Text = "Tot. Deman. Loja:";
            // 
            // tbDemandaLoja
            // 
            this.tbDemandaLoja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            this.tbDemandaLoja.Enabled = false;
            this.tbDemandaLoja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDemandaLoja.ForeColor = System.Drawing.Color.Black;
            this.tbDemandaLoja.Location = new System.Drawing.Point(1042, 682);
            this.tbDemandaLoja.Margin = new System.Windows.Forms.Padding(2);
            this.tbDemandaLoja.Multiline = true;
            this.tbDemandaLoja.Name = "tbDemandaLoja";
            this.tbDemandaLoja.Size = new System.Drawing.Size(95, 25);
            this.tbDemandaLoja.TabIndex = 21;
            this.tbDemandaLoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1250, 725);
            this.Controls.Add(this.lbDemandaLoja);
            this.Controls.Add(this.tbDemandaLoja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTotalEstoque);
            this.Controls.Add(this.tbTotalMedia);
            this.Controls.Add(this.tbTotalEstoque);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.gbDadosVetor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbDadosPedido);
            this.Controls.Add(this.btnImportar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1250, 725);
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(20, 68, 20, 23);
            this.Text = "GS FARMA - CONSULTA | PEDIDO DE COMPRA";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbDadosPedido.ResumeLayout(false);
            this.gbDadosPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosTxt)).EndInit();
            this.gbDadosVetor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosVetor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbDadosPedido;
        private GroupBox gbDadosVetor;
        private TextBox tbEmpresa;
        private TextBox tbStatus;
        private TextBox tbFornecedor;
        private TextBox tbMetodo;
        private TextBox tbReposicao;
        private TextBox tbSuprimento;
        private TextBox tbPagina;
        private TextBox tbEmissao;
        private TextBox tbUsuario;
        private MetroFramework.Controls.MetroGrid dgvDadosTxt;
        private MetroFramework.Controls.MetroGrid dgvDadosVetor;
        private MetroFramework.Controls.MetroButton btnImportar;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnApagar;

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, btnImportar.Width, btnImportar.Height);
            forma.AddEllipse(0, 0, btnSalvar.Width, btnSalvar.Height);
            forma.AddEllipse(0, 0, btnApagar.Width, btnApagar.Height);
            btnImportar.Region = new Region(forma);
            btnApagar.Region = new Region(forma);
            btnSalvar.Region = new Region(forma);
        }

        private TextBox tbTotalEstoque;
        private TextBox tbDias;
        private Label lbTotalEstoque;
        private TextBox tbTotalMedia;
        private Label label1;
        private Label lbDemandaLoja;
        private TextBox tbDemandaLoja;
    }
}