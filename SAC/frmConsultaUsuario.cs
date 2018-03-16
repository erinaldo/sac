﻿using BLL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAC
{
    public partial class frmConsultaUsuario : Form
    {

        public int codigo = 0;

        public frmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[1].Width = 100;
            dgvDados.Columns[2].HeaderText = "Usuario";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "Senha";
            dgvDados.Columns[3].Width = 80;
            dgvDados.Columns[4].HeaderText = "Foto";
            dgvDados.Columns[4].Width = 70;
            dgvDados.Columns[5].HeaderText = "Nível de Acesso";
            dgvDados.Columns[5].Width = 150;
            
            dgvDados.Columns[4].Visible = false;
            
            


        }
    }
}
