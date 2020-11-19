﻿using Ninject;
using SGM.WindowsForms.IoC;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmPrincipal : Form
    {
        [Inject()]
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void VeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVeiculo f = new frmCadastroVeiculo();
            f.ShowDialog();
            f.Dispose();
        }

        private void VeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVeiculo v = new frmConsultaVeiculo();
            v.ShowDialog();
            v.Dispose();
        }

        private void ClienteVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroClienteVeiculo k = new FrmCadastroClienteVeiculo();
            k.ShowDialog();
            k.Dispose();
        }

        private void BtnPrincipalCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente form = FormResolve.Resolve<FrmCadastroCliente>();
            form.ShowDialog();
            form.Dispose();

        }

        private void BtnPrincipalOrcamento_Click(object sender, EventArgs e)
        {
            FrmGerarOrcamento g = new FrmGerarOrcamento();
            g.ShowDialog();
            g.Dispose();
        }

        private void BtnPrincipalRealizaMaoDeObra_Click(object sender, EventArgs e)
        {
            FrmGerarServico h = new FrmGerarServico();
            h.ShowDialog();
            h.Dispose();
        }

        private void BtnPrincipalEmitirNotas_Click(object sender, EventArgs e)
        {
            /* EM IMPLANTAÇÃO */

            MessageBox.Show("Aguenta aí, que o bixo ta vindo... HAHAHA! \n Estou trabalhando para colocar essa tela no ar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre p = new frmSobre();
            p.ShowDialog();
            p.Dispose();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente form = FormResolve.Resolve<FrmCadastroCliente>();
            form.ShowDialog();
            form.Dispose();
        }

        private void MovimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* EM IMPLANTAÇÃO */

            MessageBox.Show("Aguenta aí, que o bixo ta vindo... HAHAHA! \n Estou trabalhando para colocar essa tela no ar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ImprimeNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* EM IMPLANTAÇÃO */

            MessageBox.Show("Aguenta aí, que o bixo ta vindo... HAHAHA! \n Estou trabalhando para colocar essa tela no ar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaClienteVeiculo p = new FrmConsultaClienteVeiculo();
            p.ShowDialog();
            p.Dispose();
        }

        private void BtnVeiculoCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaClienteVeiculo x = new FrmConsultaClienteVeiculo();
            x.ShowDialog();
            if (x.codigo != 0)
            {
                FrmCadastroClienteVeiculo clivei = new FrmCadastroClienteVeiculo
                {
                    clienteId = x.clienteId,
                    placaVeiculo = x.placaVeiculo
                };

                clivei.ShowDialog();
                clivei.Dispose();
            }
        }

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente t = new frmConsultaCliente();
            t.ShowDialog();
            t.Dispose();
        }

        private void PeçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPeca o = new FrmCadastroPeca();
            o.ShowDialog();
            o.Dispose();
        }

        private void PecasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaPeca i = new frmConsultaPeca();
            i.ShowDialog();
            i.Dispose();
        }

        private void MaoDeObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroMaoDeObra u = new FrmCadastroMaoDeObra();
            u.ShowDialog();
            u.Dispose();
        }

        private void MaoDeObraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaMaoDeObra b = new FrmConsultaMaoDeObra();
            b.ShowDialog();
            b.Dispose();
        }

        private void RealizarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerarOrcamento g = new FrmGerarOrcamento();
            g.ShowDialog();
            g.Dispose();
        }

        private void RealizaMãodeObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerarServico j = new FrmGerarServico();
            j.ShowDialog();
            j.Dispose();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string texto = "Versão: ";

            lblVersionSystem.Text = texto + ProductVersion.ToString();
        }

        private void BtnBuscarHistoricoServicoCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaHistoricoServicoClienteVeiculo consultaHistorico = new FrmConsultaHistoricoServicoClienteVeiculo();
            consultaHistorico.ShowDialog();
            consultaHistorico.Dispose();
        }
    }
}