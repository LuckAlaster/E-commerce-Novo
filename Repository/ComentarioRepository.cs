using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Repository
{
    internal class ComentarioRepository : IRepository<Comentario>
    {
        private List<Comentario> ListaDeComentarios = new List<Comentario>();
        public List<Comentario> FindAll()
        {
            return ListaDeComentarios;
        }
        public Comentario FindById(uint? id, string exceptionNotFound = "Essa id não existe nessa Lista de Comentario")
        {
            return ListaDeComentarios.First(l => l.Id == id) ?? throw new Exception(exceptionNotFound);
        }
        public Comentario FindByIdWithoutThrow(uint? id, string exceptionNotFound = "Esse id não existe nessa lista")
        {
            return ListaDeComentarios.FirstOrDefault(l => l.Id == id) ?? throw new Exception(exceptionNotFound);
        }
        public Comentario Create(Comentario novoComentario)
        {
            if (novoComentario.Id != null)
            {
                throw new Exception("Esse comentário possui id");
            }
            var lastId = (uint)ListaDeComentarios.Count;
            bool esseIdEstaNaLista;
            do
            {
                novoComentario.Id = lastId + 1;
                esseIdEstaNaLista = ListaDeComentarios.Any(l => l.Id == novoComentario.Id);
            }
            while (esseIdEstaNaLista);
            ListaDeComentarios.Add(novoComentario);
            return novoComentario;
        }
        public Comentario Update (Comentario comentarioUpdate)
        {
            Comentario comentarioParaAtualizar = FindByIdWithoutThrow(comentarioUpdate.Id) ?? throw new Exception("Esse comentário não existe na lsita");
            comentarioParaAtualizar.Texto = comentarioUpdate.Texto;
            comentarioParaAtualizar.Cliente = comentarioUpdate.Cliente;
            comentarioParaAtualizar.Pedido = comentarioUpdate.Pedido;
            comentarioParaAtualizar.Produto = comentarioUpdate.Produto;
            return comentarioParaAtualizar;
        }
        public void Delete (uint? id)
        {
            Comentario comentarioParaDeletar = FindByIdWithoutThrow(id) ?? throw new Exception("Esse comentário não existe na lista");
            ListaDeComentarios.Remove(comentarioParaDeletar);
        }
    }
}
