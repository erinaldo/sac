﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLProduto
    {
        private DAOConexao conexao;

        public BLLProduto(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto obj)
        {
            if (obj.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (obj.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória");
            }

            if (obj.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }

            if (obj.ProQtde < 0)
            {
                throw new Exception("A quantidade do produto deve ser maior ou igual a zero");
            }

            if (obj.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório");
            }

            if (obj.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            if (obj.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }
            DAOProduto DALobj = new DAOProduto(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DAOProduto DALobj = new DAOProduto(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloProduto obj)
        {
            if (obj.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (obj.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória");
            }

            if (obj.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }

            if (obj.ProQtde < 0)
            {
                throw new Exception("A quantidade do produto deve ser maior ou igual a zero");
            }

            if (obj.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório");
            }

            if (obj.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            if (obj.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }

            if (obj.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            DAOProduto DALobj = new DAOProduto(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DAOProduto DALobj = new DAOProduto(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DAOProduto DALobj = new DAOProduto(conexao);
            return DALobj.CarregaModeloProduto(codigo);
        }
    }
}
