﻿namespace FarmSystem.Plantação
{
    partial class acoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acoes));
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtplantacao = new System.Windows.Forms.TextBox();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsemente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtfunc = new System.Windows.Forms.TextBox();
            this.btnListaPlant = new System.Windows.Forms.Button();
            this.btnListaProd = new System.Windows.Forms.Button();
            this.btnListaFunc = new System.Windows.Forms.Button();
            this.dgvacoes = new System.Windows.Forms.DataGridView();
            this.acoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postgresDataSet2 = new FarmSystem.postgresDataSet2();
            this.acoesTableAdapter = new FarmSystem.postgresDataSet2TableAdapters.acoesTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.combstatus = new System.Windows.Forms.ComboBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.txtipoac = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txthorario = new System.Windows.Forms.TextBox();
            this.mskdata = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(12, 28);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(170, 20);
            this.txtcodigo.TabIndex = 27;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // txtplantacao
            // 
            this.txtplantacao.Location = new System.Drawing.Point(11, 118);
            this.txtplantacao.Name = "txtplantacao";
            this.txtplantacao.Size = new System.Drawing.Size(82, 20);
            this.txtplantacao.TabIndex = 11;
            this.txtplantacao.TextChanged += new System.EventHandler(this.txtplantacao_TextChanged);
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(10, 159);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(82, 20);
            this.txtprod.TabIndex = 12;
            this.txtprod.TextChanged += new System.EventHandler(this.txtprod_TextChanged);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(145, 159);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(299, 20);
            this.txtdescricao.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Ação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plantação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data da Ação";
            // 
            // txtsemente
            // 
            this.txtsemente.AcceptsReturn = true;
            this.txtsemente.Location = new System.Drawing.Point(145, 118);
            this.txtsemente.Name = "txtsemente";
            this.txtsemente.Size = new System.Drawing.Size(408, 20);
            this.txtsemente.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Semente Utilizada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Funcionário:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(144, 202);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(409, 20);
            this.txtnome.TabIndex = 16;
            // 
            // txtfunc
            // 
            this.txtfunc.Location = new System.Drawing.Point(10, 202);
            this.txtfunc.Name = "txtfunc";
            this.txtfunc.Size = new System.Drawing.Size(82, 20);
            this.txtfunc.TabIndex = 13;
            this.txtfunc.TextChanged += new System.EventHandler(this.txtfunc_TextChanged);
            // 
            // btnListaPlant
            // 
            this.btnListaPlant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaPlant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaPlant.Location = new System.Drawing.Point(93, 116);
            this.btnListaPlant.Name = "btnListaPlant";
            this.btnListaPlant.Size = new System.Drawing.Size(46, 23);
            this.btnListaPlant.TabIndex = 1;
            this.btnListaPlant.Text = "Listar";
            this.btnListaPlant.UseVisualStyleBackColor = true;
            this.btnListaPlant.Click += new System.EventHandler(this.btnListaPlant_Click);
            // 
            // btnListaProd
            // 
            this.btnListaProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaProd.Location = new System.Drawing.Point(92, 157);
            this.btnListaProd.Name = "btnListaProd";
            this.btnListaProd.Size = new System.Drawing.Size(46, 23);
            this.btnListaProd.TabIndex = 2;
            this.btnListaProd.Text = "Listar";
            this.btnListaProd.UseVisualStyleBackColor = true;
            this.btnListaProd.Click += new System.EventHandler(this.btnListaProd_Click);
            // 
            // btnListaFunc
            // 
            this.btnListaFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaFunc.Location = new System.Drawing.Point(92, 200);
            this.btnListaFunc.Name = "btnListaFunc";
            this.btnListaFunc.Size = new System.Drawing.Size(46, 23);
            this.btnListaFunc.TabIndex = 4;
            this.btnListaFunc.Text = "Listar";
            this.btnListaFunc.UseVisualStyleBackColor = true;
            this.btnListaFunc.Click += new System.EventHandler(this.btnListaFunc_Click);
            // 
            // dgvacoes
            // 
            this.dgvacoes.AutoGenerateColumns = false;
            this.dgvacoes.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.tipoacaoDataGridViewTextBoxColumn,
            this.plantacaoDataGridViewTextBoxColumn,
            this.codigoprodDataGridViewTextBoxColumn,
            this.dataacDataGridViewTextBoxColumn,
            this.funcionarioDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.horario,
            this.quantidade});
            this.dgvacoes.DataSource = this.acoesBindingSource;
            this.dgvacoes.Location = new System.Drawing.Point(12, 272);
            this.dgvacoes.Name = "dgvacoes";
            this.dgvacoes.Size = new System.Drawing.Size(1129, 280);
            this.dgvacoes.TabIndex = 12;
            this.dgvacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvacoes_CellContentClick);
            this.dgvacoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvacoes_CellDoubleClick);
            // 
            // acoesBindingSource
            // 
            this.acoesBindingSource.DataMember = "acoes";
            this.acoesBindingSource.DataSource = this.postgresDataSet2;
            // 
            // postgresDataSet2
            // 
            this.postgresDataSet2.DataSetName = "postgresDataSet2";
            this.postgresDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acoesTableAdapter
            // 
            this.acoesTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Gravar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(781, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Editar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(894, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Excluir";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1002, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Limpar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(145, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Status";
            // 
            // combstatus
            // 
            this.combstatus.FormattingEnabled = true;
            this.combstatus.Items.AddRange(new object[] {
            "A executar",
            "Em execução",
            "Executada",
            "Ação Cancelada"});
            this.combstatus.Location = new System.Drawing.Point(148, 245);
            this.combstatus.Name = "combstatus";
            this.combstatus.Size = new System.Drawing.Size(263, 21);
            this.combstatus.TabIndex = 6;
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackgroundImage = global::FarmSystem.Properties.Resources.clean;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpar.Location = new System.Drawing.Point(969, 102);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(104, 82);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackgroundImage = global::FarmSystem.Properties.Resources.delete;
            this.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexcluir.Location = new System.Drawing.Point(859, 105);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(104, 82);
            this.btnexcluir.TabIndex = 10;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImage = global::FarmSystem.Properties.Resources.edit;
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Location = new System.Drawing.Point(749, 102);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(104, 82);
            this.btneditar.TabIndex = 9;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btngravar
            // 
            this.btngravar.BackgroundImage = global::FarmSystem.Properties.Resources.floppy_disk;
            this.btngravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngravar.Location = new System.Drawing.Point(639, 102);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(104, 82);
            this.btngravar.TabIndex = 8;
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // txtipoac
            // 
            this.txtipoac.FormattingEnabled = true;
            this.txtipoac.Items.AddRange(new object[] {
            "Plantar",
            "Colher",
            "Detetizar",
            "Adubar"});
            this.txtipoac.Location = new System.Drawing.Point(10, 76);
            this.txtipoac.Name = "txtipoac";
            this.txtipoac.Size = new System.Drawing.Size(543, 21);
            this.txtipoac.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(415, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Horário:";
            // 
            // txthorario
            // 
            this.txthorario.Location = new System.Drawing.Point(417, 246);
            this.txthorario.Name = "txthorario";
            this.txthorario.Size = new System.Drawing.Size(136, 20);
            this.txthorario.TabIndex = 7;
            this.txthorario.TextChanged += new System.EventHandler(this.txthorario_TextChanged);
            // 
            // mskdata
            // 
            this.mskdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskdata.Location = new System.Drawing.Point(10, 246);
            this.mskdata.Name = "mskdata";
            this.mskdata.Size = new System.Drawing.Size(128, 20);
            this.mskdata.TabIndex = 5;
            this.mskdata.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(447, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Quantidade Utilizada:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(450, 159);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(103, 20);
            this.txt_quantidade.TabIndex = 3;
            this.txt_quantidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipoacaoDataGridViewTextBoxColumn
            // 
            this.tipoacaoDataGridViewTextBoxColumn.DataPropertyName = "tipoacao";
            this.tipoacaoDataGridViewTextBoxColumn.HeaderText = "Tipo de Ação";
            this.tipoacaoDataGridViewTextBoxColumn.Name = "tipoacaoDataGridViewTextBoxColumn";
            this.tipoacaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // plantacaoDataGridViewTextBoxColumn
            // 
            this.plantacaoDataGridViewTextBoxColumn.DataPropertyName = "plantacao";
            this.plantacaoDataGridViewTextBoxColumn.HeaderText = "Plantação";
            this.plantacaoDataGridViewTextBoxColumn.Name = "plantacaoDataGridViewTextBoxColumn";
            this.plantacaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // codigoprodDataGridViewTextBoxColumn
            // 
            this.codigoprodDataGridViewTextBoxColumn.DataPropertyName = "codigoprod";
            this.codigoprodDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.codigoprodDataGridViewTextBoxColumn.Name = "codigoprodDataGridViewTextBoxColumn";
            this.codigoprodDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataacDataGridViewTextBoxColumn
            // 
            this.dataacDataGridViewTextBoxColumn.DataPropertyName = "dataac";
            this.dataacDataGridViewTextBoxColumn.HeaderText = "Data para Execução";
            this.dataacDataGridViewTextBoxColumn.Name = "dataacDataGridViewTextBoxColumn";
            // 
            // funcionarioDataGridViewTextBoxColumn
            // 
            this.funcionarioDataGridViewTextBoxColumn.DataPropertyName = "funcionario";
            this.funcionarioDataGridViewTextBoxColumn.HeaderText = "Funcionário";
            this.funcionarioDataGridViewTextBoxColumn.Name = "funcionarioDataGridViewTextBoxColumn";
            this.funcionarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status da Ação";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 200;
            // 
            // horario
            // 
            this.horario.DataPropertyName = "horario";
            this.horario.HeaderText = "Horário";
            this.horario.Name = "horario";
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.Width = 90;
            // 
            // acoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1149, 564);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.mskdata);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txthorario);
            this.Controls.Add(this.txtipoac);
            this.Controls.Add(this.combstatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.dgvacoes);
            this.Controls.Add(this.btnListaFunc);
            this.Controls.Add(this.btnListaProd);
            this.Controls.Add(this.btnListaPlant);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtfunc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsemente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.txtplantacao);
            this.Controls.Add(this.txtcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "acoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ações realizadas na plantação";
            this.Load += new System.EventHandler(this.acoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtplantacao;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsemente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtfunc;
        private System.Windows.Forms.Button btnListaPlant;
        private System.Windows.Forms.Button btnListaProd;
        private System.Windows.Forms.Button btnListaFunc;
        private System.Windows.Forms.DataGridView dgvacoes;
        private postgresDataSet2 postgresDataSet2;
        private System.Windows.Forms.BindingSource acoesBindingSource;
        private postgresDataSet2TableAdapters.acoesTableAdapter acoesTableAdapter;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox combstatus;
		private System.Windows.Forms.ComboBox txtipoac;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txthorario;
        private System.Windows.Forms.DateTimePicker mskdata;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
    }
}