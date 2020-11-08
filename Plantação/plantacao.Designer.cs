namespace FarmSystem.Plantação
{
    partial class plantacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plantacao));
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtcodfunc = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomefunc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprevisaosacas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtvalorvenda = new System.Windows.Forms.TextBox();
            this.dtgplantacao = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distinciaentreplantasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadeplantioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordevendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdaplantacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previsaodecolheitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevdatacolheitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadecolhidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sementeusadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacolhida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postgresDataSet2 = new FarmSystem.postgresDataSet2();
            this.btnlistafunc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtqtdsacas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsemente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnacoes = new System.Windows.Forms.Button();
            this.brnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.plantacaoTableAdapter = new FarmSystem.postgresDataSet2TableAdapters.plantacaoTableAdapter();
            this.label17 = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.Pesquisa = new System.Windows.Forms.GroupBox();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.mskdataplantio = new System.Windows.Forms.DateTimePicker();
            this.txtdatadacolheita = new System.Windows.Forms.DateTimePicker();
            this.mskprevisaodata = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgplantacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet2)).BeginInit();
            this.Pesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(12, 36);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(179, 20);
            this.txtcodigo.TabIndex = 0;
            // 
            // txtcodfunc
            // 
            this.txtcodfunc.Location = new System.Drawing.Point(12, 75);
            this.txtcodfunc.Name = "txtcodfunc";
            this.txtcodfunc.Size = new System.Drawing.Size(119, 20);
            this.txtcodfunc.TabIndex = 1;
            this.txtcodfunc.TextChanged += new System.EventHandler(this.txtcodfunc_TextChanged);
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(12, 118);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(205, 20);
            this.txtarea.TabIndex = 2;
            // 
            // txtdistancia
            // 
            this.txtdistancia.Location = new System.Drawing.Point(223, 118);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(201, 20);
            this.txtdistancia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Área M²:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Distancia entre plantas CM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome:";
            // 
            // txtnomefunc
            // 
            this.txtnomefunc.Location = new System.Drawing.Point(189, 75);
            this.txtnomefunc.Name = "txtnomefunc";
            this.txtnomefunc.Size = new System.Drawing.Size(604, 20);
            this.txtnomefunc.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status da Plantação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Previsão de Colheita (SACAS):";
            // 
            // txtprevisaosacas
            // 
            this.txtprevisaosacas.Location = new System.Drawing.Point(366, 167);
            this.txtprevisaosacas.Name = "txtprevisaosacas";
            this.txtprevisaosacas.Size = new System.Drawing.Size(220, 20);
            this.txtprevisaosacas.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Previsão de Colheita (DATA):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Data de Plantio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(620, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Valor de venda (SACA):";
            // 
            // txtvalorvenda
            // 
            this.txtvalorvenda.Location = new System.Drawing.Point(620, 118);
            this.txtvalorvenda.Name = "txtvalorvenda";
            this.txtvalorvenda.Size = new System.Drawing.Size(173, 20);
            this.txtvalorvenda.TabIndex = 5;
            // 
            // dtgplantacao
            // 
            this.dtgplantacao.AutoGenerateColumns = false;
            this.dtgplantacao.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgplantacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgplantacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.funcionarioDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.distinciaentreplantasDataGridViewTextBoxColumn,
            this.datadeplantioDataGridViewTextBoxColumn,
            this.valordevendaDataGridViewTextBoxColumn,
            this.statusdaplantacaoDataGridViewTextBoxColumn,
            this.previsaodecolheitaDataGridViewTextBoxColumn,
            this.prevdatacolheitaDataGridViewTextBoxColumn,
            this.quantidadecolhidaDataGridViewTextBoxColumn,
            this.sementeusadaDataGridViewTextBoxColumn,
            this.datacolhida});
            this.dtgplantacao.DataSource = this.plantacaoBindingSource;
            this.dtgplantacao.Location = new System.Drawing.Point(12, 303);
            this.dtgplantacao.Name = "dtgplantacao";
            this.dtgplantacao.Size = new System.Drawing.Size(1346, 384);
            this.dtgplantacao.TabIndex = 21;
            this.dtgplantacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgplantacao_CellContentClick);
            this.dtgplantacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgplantacao_CellDoubleClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 80;
            // 
            // funcionarioDataGridViewTextBoxColumn
            // 
            this.funcionarioDataGridViewTextBoxColumn.DataPropertyName = "funcionario";
            this.funcionarioDataGridViewTextBoxColumn.HeaderText = "Funcionário";
            this.funcionarioDataGridViewTextBoxColumn.Name = "funcionarioDataGridViewTextBoxColumn";
            this.funcionarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Área M²";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 80;
            // 
            // distinciaentreplantasDataGridViewTextBoxColumn
            // 
            this.distinciaentreplantasDataGridViewTextBoxColumn.DataPropertyName = "distinciaentreplantas";
            this.distinciaentreplantasDataGridViewTextBoxColumn.HeaderText = "Distancia Plantas CM";
            this.distinciaentreplantasDataGridViewTextBoxColumn.Name = "distinciaentreplantasDataGridViewTextBoxColumn";
            // 
            // datadeplantioDataGridViewTextBoxColumn
            // 
            this.datadeplantioDataGridViewTextBoxColumn.DataPropertyName = "datadeplantio";
            this.datadeplantioDataGridViewTextBoxColumn.HeaderText = "Data Plantio";
            this.datadeplantioDataGridViewTextBoxColumn.Name = "datadeplantioDataGridViewTextBoxColumn";
            // 
            // valordevendaDataGridViewTextBoxColumn
            // 
            this.valordevendaDataGridViewTextBoxColumn.DataPropertyName = "valordevenda";
            this.valordevendaDataGridViewTextBoxColumn.HeaderText = "Valor de Venda";
            this.valordevendaDataGridViewTextBoxColumn.Name = "valordevendaDataGridViewTextBoxColumn";
            // 
            // statusdaplantacaoDataGridViewTextBoxColumn
            // 
            this.statusdaplantacaoDataGridViewTextBoxColumn.DataPropertyName = "statusdaplantacao";
            this.statusdaplantacaoDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusdaplantacaoDataGridViewTextBoxColumn.Name = "statusdaplantacaoDataGridViewTextBoxColumn";
            this.statusdaplantacaoDataGridViewTextBoxColumn.Width = 180;
            // 
            // previsaodecolheitaDataGridViewTextBoxColumn
            // 
            this.previsaodecolheitaDataGridViewTextBoxColumn.DataPropertyName = "previsaodecolheita";
            this.previsaodecolheitaDataGridViewTextBoxColumn.HeaderText = "Previsão Colheita (SACAS)";
            this.previsaodecolheitaDataGridViewTextBoxColumn.Name = "previsaodecolheitaDataGridViewTextBoxColumn";
            // 
            // prevdatacolheitaDataGridViewTextBoxColumn
            // 
            this.prevdatacolheitaDataGridViewTextBoxColumn.DataPropertyName = "prevdatacolheita";
            this.prevdatacolheitaDataGridViewTextBoxColumn.HeaderText = "Previsão Data Colheita";
            this.prevdatacolheitaDataGridViewTextBoxColumn.Name = "prevdatacolheitaDataGridViewTextBoxColumn";
            // 
            // quantidadecolhidaDataGridViewTextBoxColumn
            // 
            this.quantidadecolhidaDataGridViewTextBoxColumn.DataPropertyName = "quantidadecolhida";
            this.quantidadecolhidaDataGridViewTextBoxColumn.HeaderText = "Qtd Colhita (SACAS)";
            this.quantidadecolhidaDataGridViewTextBoxColumn.Name = "quantidadecolhidaDataGridViewTextBoxColumn";
            // 
            // sementeusadaDataGridViewTextBoxColumn
            // 
            this.sementeusadaDataGridViewTextBoxColumn.DataPropertyName = "sementeusada";
            this.sementeusadaDataGridViewTextBoxColumn.HeaderText = "Semente Usada";
            this.sementeusadaDataGridViewTextBoxColumn.Name = "sementeusadaDataGridViewTextBoxColumn";
            this.sementeusadaDataGridViewTextBoxColumn.Width = 150;
            // 
            // datacolhida
            // 
            this.datacolhida.DataPropertyName = "datadecolheita";
            this.datacolhida.HeaderText = "Data Colhida";
            this.datacolhida.Name = "datacolhida";
            // 
            // plantacaoBindingSource
            // 
            this.plantacaoBindingSource.DataMember = "plantacao";
            this.plantacaoBindingSource.DataSource = this.postgresDataSet2;
            // 
            // postgresDataSet2
            // 
            this.postgresDataSet2.DataSetName = "postgresDataSet2";
            this.postgresDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnlistafunc
            // 
            this.btnlistafunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlistafunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlistafunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistafunc.Location = new System.Drawing.Point(137, 71);
            this.btnlistafunc.Name = "btnlistafunc";
            this.btnlistafunc.Size = new System.Drawing.Size(46, 24);
            this.btnlistafunc.TabIndex = 1;
            this.btnlistafunc.Text = "Listar";
            this.btnlistafunc.UseVisualStyleBackColor = true;
            this.btnlistafunc.Click += new System.EventHandler(this.btnlistafunc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Quantidade Colhida (SACAS):";
            // 
            // txtqtdsacas
            // 
            this.txtqtdsacas.Location = new System.Drawing.Point(12, 211);
            this.txtqtdsacas.Name = "txtqtdsacas";
            this.txtqtdsacas.Size = new System.Drawing.Size(179, 20);
            this.txtqtdsacas.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Semete Usada:";
            // 
            // txtsemente
            // 
            this.txtsemente.Location = new System.Drawing.Point(249, 211);
            this.txtsemente.Name = "txtsemente";
            this.txtsemente.Size = new System.Drawing.Size(301, 20);
            this.txtsemente.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(903, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "GRAVAR";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1070, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "EDITAR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1240, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "EXCLUIR";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1077, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "AÇÕES";
            // 
            // btnacoes
            // 
            this.btnacoes.BackgroundImage = global::FarmSystem.Properties.Resources.clipboard;
            this.btnacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnacoes.Location = new System.Drawing.Point(844, 146);
            this.btnacoes.Name = "btnacoes";
            this.btnacoes.Size = new System.Drawing.Size(507, 82);
            this.btnacoes.TabIndex = 14;
            this.btnacoes.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnacoes.UseVisualStyleBackColor = true;
            this.btnacoes.Click += new System.EventHandler(this.btnacoes_Click);
            // 
            // brnexcluir
            // 
            this.brnexcluir.BackgroundImage = global::FarmSystem.Properties.Resources.delete;
            this.brnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.brnexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brnexcluir.Location = new System.Drawing.Point(1186, 36);
            this.brnexcluir.Name = "brnexcluir";
            this.brnexcluir.Size = new System.Drawing.Size(165, 82);
            this.brnexcluir.TabIndex = 13;
            this.brnexcluir.UseVisualStyleBackColor = true;
            this.brnexcluir.Click += new System.EventHandler(this.brnexcluir_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImage = global::FarmSystem.Properties.Resources.edit;
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Location = new System.Drawing.Point(1015, 36);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(165, 82);
            this.btneditar.TabIndex = 12;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btngravar
            // 
            this.btngravar.BackgroundImage = global::FarmSystem.Properties.Resources.floppy_disk;
            this.btngravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngravar.Location = new System.Drawing.Point(844, 36);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(165, 82);
            this.btngravar.TabIndex = 11;
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // plantacaoTableAdapter
            // 
            this.plantacaoTableAdapter.ClearBeforeFill = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(45, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Pesquisar por Semente:";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Ebrima", 8.25F);
            this.txtpesquisa.Location = new System.Drawing.Point(212, 11);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(1035, 22);
            this.txtpesquisa.TabIndex = 35;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // Pesquisa
            // 
            this.Pesquisa.Controls.Add(this.txtpesquisa);
            this.Pesquisa.Controls.Add(this.label17);
            this.Pesquisa.Location = new System.Drawing.Point(12, 258);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(1314, 39);
            this.Pesquisa.TabIndex = 37;
            this.Pesquisa.TabStop = false;
            this.Pesquisa.Text = "Pesquisa";
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Agendada",
            "Plantado",
            "Em Crescimento",
            "Colhida",
            "Plantação Perdida"});
            this.txtstatus.Location = new System.Drawing.Point(12, 166);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(348, 21);
            this.txtstatus.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(666, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Data da Colheita:";
            // 
            // mskdataplantio
            // 
            this.mskdataplantio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskdataplantio.Location = new System.Drawing.Point(430, 119);
            this.mskdataplantio.Name = "mskdataplantio";
            this.mskdataplantio.Size = new System.Drawing.Size(184, 20);
            this.mskdataplantio.TabIndex = 40;
            // 
            // txtdatadacolheita
            // 
            this.txtdatadacolheita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdatadacolheita.Location = new System.Drawing.Point(670, 211);
            this.txtdatadacolheita.Name = "txtdatadacolheita";
            this.txtdatadacolheita.Size = new System.Drawing.Size(123, 20);
            this.txtdatadacolheita.TabIndex = 41;
            // 
            // mskprevisaodata
            // 
            this.mskprevisaodata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskprevisaodata.Location = new System.Drawing.Point(592, 167);
            this.mskprevisaodata.Name = "mskprevisaodata";
            this.mskprevisaodata.Size = new System.Drawing.Size(201, 20);
            this.mskprevisaodata.TabIndex = 42;
            this.mskprevisaodata.ValueChanged += new System.EventHandler(this.mskprevisaodata_ValueChanged);
            this.mskprevisaodata.Leave += new System.EventHandler(this.mskprevisaodata_Leave);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(197, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 24);
            this.button2.TabIndex = 44;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(556, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Quantidade Produto:";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(556, 211);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(108, 20);
            this.txt_quantidade.TabIndex = 11;
            // 
            // plantacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1370, 699);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mskprevisaodata);
            this.Controls.Add(this.txtdatadacolheita);
            this.Controls.Add(this.mskdataplantio);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtsemente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtqtdsacas);
            this.Controls.Add(this.btnlistafunc);
            this.Controls.Add(this.btnacoes);
            this.Controls.Add(this.brnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.dtgplantacao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtvalorvenda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtprevisaosacas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnomefunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdistancia);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtcodfunc);
            this.Controls.Add(this.txtcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "plantacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.plantacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgplantacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet2)).EndInit();
            this.Pesquisa.ResumeLayout(false);
            this.Pesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtcodfunc;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomefunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprevisaosacas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtvalorvenda;
        private System.Windows.Forms.DataGridView dtgplantacao;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button brnexcluir;
        private System.Windows.Forms.Button btnacoes;
        private System.Windows.Forms.Button btnlistafunc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtqtdsacas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsemente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private postgresDataSet2 postgresDataSet2;
        private System.Windows.Forms.BindingSource plantacaoBindingSource;
        private postgresDataSet2TableAdapters.plantacaoTableAdapter plantacaoTableAdapter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.GroupBox Pesquisa;
		private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distinciaentreplantasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadeplantioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordevendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdaplantacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previsaodecolheitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevdatacolheitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadecolhidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sementeusadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacolhida;
        private System.Windows.Forms.DateTimePicker mskdataplantio;
        private System.Windows.Forms.DateTimePicker txtdatadacolheita;
        private System.Windows.Forms.DateTimePicker mskprevisaodata;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_quantidade;
    }
}