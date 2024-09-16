using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Repository
{
    internal class EstoqueRepository : IRepository<Estoque>
    {
        private List<Estoque> ListaEstoque = new List<Estoque>();
        public List<Estoque> FindAll()
        {
            if (ListaEstoque == null)
            {
                return ListaEstoque;
            }
            return ListaEstoque;
        }
        public Estoque FindById(uint? id, string exceptionNotFound = "Essa id não existe nessa lista")
        {
            return ListaEstoque.First(x => x.Id == id) ?? throw new Exception(exceptionNotFound);
        }
        public Estoque FindByIdWithoutThrow(uint? id, string exceptionNotFound = "Essa id não existe nessa lista")
        {
            return ListaEstoque.FirstOrDefault(x => x.Id == id) ?? throw new Exception(exceptionNotFound);
        }
        public Estoque Create(Estoque novoEstoque)
        {
            if (novoEstoque != null)
            {
                throw new Exception("Esse estoque possui id");
            }
            var lastId = (uint)ListaEstoque.Count;
            bool naMinhaListaTemIsso;
            do
            {
                novoEstoque.Id = lastId + 1;
                naMinhaListaTemIsso = ListaEstoque.Any(l => l.Id == novoEstoque.Id);
            }
            while (naMinhaListaTemIsso);
            ListaEstoque.Add(novoEstoque);
            return novoEstoque;
        }
        public Estoque Update(Estoque updateEstoque)
        {
            uint? id = updateEstoque.Id;
            Estoque estoqueParaAtualizar = FindByIdWithoutThrow(id) ?? throw new Exception("Esse Estoque não existe na ListaEstoque");
            estoqueParaAtualizar.QuantidadeAtual = updateEstoque.QuantidadeAtual;
            estoqueParaAtualizar.Saída = updateEstoque.Saída;
            estoqueParaAtualizar.Entrada = updateEstoque.Entrada;
            return estoqueParaAtualizar;
        }
        public void Delete(uint? id)
        {
            Estoque estoqueParaDeletar = FindByIdWithoutThrow(id) ?? throw new Exception("Esse id não foi encontrado");
            if (estoqueParaDeletar.Id == id)
            {
                ListaEstoque.Remove(estoqueParaDeletar);
            }
        }
    }
}
