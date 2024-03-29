﻿using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class frmConsultaCliente : Form
    {
        public int codigo = 0;
        public string nomeCliente = "";
        private readonly IClienteApplication _clienteApplication;

        public frmConsultaCliente(IClienteApplication clienteApplication)
        {
            _clienteApplication = clienteApplication;
            InitializeComponent();
        }

        private void BtnConsultaCliente_Click(object sender, EventArgs e)
        {
            if (txtConsultaCliente.Text != "" || txtConsultaCliente.Text != null)
            {
                IList<Cliente> cliente = new List<Cliente>
                {
                    _clienteApplication.GetClienteByLikePlacaOrNomeOrApelido(txtConsultaCliente.Text)
                };

                CarregaGridView(cliente);
            }
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            IList<Cliente> cliente = new List<Cliente>();

            if (codigo > 0)
            {
                cliente.Add(_clienteApplication.GetClienteById(codigo));
            }

            CarregaGridView(cliente);
        }

        private void DgvConsultCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsultCliente.Rows[e.RowIndex].Cells[0].Value);
                this.nomeCliente = Convert.ToString(dgvConsultCliente.Rows[e.RowIndex].Cells[3].Value);
                this.Close();
            }
        }

        private void CarregaGridView(IList<Cliente> cliente)
        {
            dgvConsultCliente.DataSource = cliente;
            dgvConsultCliente.Columns[0].HeaderText = "Código";
            dgvConsultCliente.Columns[0].Width = 50;
            dgvConsultCliente.Columns[1].HeaderText = "Cliente";
            dgvConsultCliente.Columns[1].Width = 220;
            dgvConsultCliente.Columns[2].HeaderText = "Apelido";
            dgvConsultCliente.Columns[2].Width = 90;
            dgvConsultCliente.Columns[3].HeaderText = "CPF";
            dgvConsultCliente.Columns[3].Width = 75;
            dgvConsultCliente.Columns[4].HeaderText = "Sexo";
            dgvConsultCliente.Columns[4].Width = 60;
            dgvConsultCliente.Columns[5].HeaderText = "Estado Civil";
            dgvConsultCliente.Columns[5].Width = 75;
            dgvConsultCliente.Columns[6].HeaderText = "Data Nascimento";
            dgvConsultCliente.Columns[6].Width = 75;
        }
    }
}