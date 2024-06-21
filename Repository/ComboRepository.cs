using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Repository
{
    internal class ComboRepository
    {
        private List<Combo> ListaDeCombos = new List<Combo>();
        public List<Combo> FindAll()
        {
            return ListaDeCombos;
        }
        public Combo FindById(uint? id)
        {
            return ListaDeCombos.First(l => l.Id == id) ?? throw new Exception("Esse id não existe nessa lista");
        }
        public Combo FindByIdWithoutThrow(uint? id, string exception = "Esse id não existe nessa lista")
        {
            return ListaDeCombos.FirstOrDefault(l => l.Id == id) ?? throw new Exception(exception);
        }
        public Combo Create (Combo novoCombo) 
        {
            if (novoCombo.Id != null)
            {
                throw new Exception("Esse combo já possui uma id");
            }
            var lastId = (uint)ListaDeCombos.Count;
            bool naMinhaListaTemIsso;
            do
            {
                novoCombo.Id = lastId + 1;
                naMinhaListaTemIsso = ListaDeCombos.Any(l => l.Id == novoCombo.Id);
            }
            while (naMinhaListaTemIsso);
            ListaDeCombos.Add(novoCombo);
            return novoCombo;
        }
        public Combo Update (Combo updateCombo)
        {
            uint? id = updateCombo.Id;
            Combo comboParaAtualizar = FindByIdWithoutThrow(id) ?? throw new Exception("Esse combo não existe");
            comboParaAtualizar.Descricao = updateCombo.Descricao;
            comboParaAtualizar.Valor = updateCombo.Valor;
            comboParaAtualizar.ListaProdutos = updateCombo.ListaProdutos;
            return comboParaAtualizar;
        }
        public void Delete (uint? id)
        {
            Combo comboParaDeletar = FindByIdWithoutThrow(id) ?? throw new Exception("Esse id não existe");
            ListaDeCombos.Remove(comboParaDeletar);
        }
    }
}
