using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Repository
{
    internal class ClienteRepository
    {
        private List<Cliente> ListaDeClientes = new List<Cliente>();
        public List<Cliente> FindAll()
        {
            return ListaDeClientes;
        }
        public Cliente FindById(uint? id)
        {
            return ListaDeClientes.First(i => i.Id == id) ?? throw new Exception("Essa id não existe nessa lista");
        }
        public Cliente FindByIdWithoutThrow(uint? id, string exception = "Essa id não existe nessa lista") 
        {
            return ListaDeClientes.FirstOrDefault(i => i.Id == id) ?? throw new Exception(exception);
        }
        public Cliente Create(Cliente novoCliente) 
        {
            if (novoCliente.Id != null)
            {
                throw new Exception("Esse cliente já possui um id");
            }
            var lastId = (uint)ListaDeClientes.Count;
            bool naMinhaListaTemIsso;
            do
            {
                novoCliente.Id = lastId + 1;
                naMinhaListaTemIsso = ListaDeClientes.Any(l => l.Id == novoCliente.Id);
            }
            while (naMinhaListaTemIsso);
            ListaDeClientes.Add(novoCliente);
            return novoCliente;
        }
        public Cliente Update(Cliente updateCliente)
        {
            uint? id = updateCliente.Id;
            Cliente clienteParaAtualizar = FindByIdWithoutThrow(id) ?? throw new Exception("Esse cliente não existe");
            clienteParaAtualizar.Nome = updateCliente.Nome;
            clienteParaAtualizar.Endereco = updateCliente.Endereco;
            clienteParaAtualizar.MetodoDePagamento = updateCliente.MetodoDePagamento;
            clienteParaAtualizar.Pedidos = updateCliente.Pedidos;
            return clienteParaAtualizar;
        }
        public void Delete (uint? id)
        {
            Cliente clienteDeletar = FindByIdWithoutThrow(id) ?? throw new Exception("Esse cliente não existe");
            ListaDeClientes.Remove(clienteDeletar);
        }
    }
}
