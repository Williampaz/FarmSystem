﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem
{
    public partial class frmRelPlantacao : Form
    {
        public frmRelPlantacao()
        {
            InitializeComponent();
        }

        private void frmRelPlantacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet2.plantacao'. Você pode movê-la ou removê-la conforme necessário.
            this.plantacaoTableAdapter.Fill(this.postgresDataSet2.plantacao);

            this.reportViewer1.RefreshReport();
        }
    }
}
