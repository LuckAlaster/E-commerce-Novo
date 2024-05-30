using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Produto : Model
    {
        public string Nome { get; }
        public string Descricao { get; }
        public float? Preco { get; }
        public float Avaliacao { get; }
        public Marca Marca { get; }
        public Promocao Promocao { get; }
        public List<Categoria> ListaCategorias { get; }
        public List<Comentario> ListaComentarios { get; }
        public List<Cor> ListaCores { get; }
        public List<HistoricoPreco> HistoricoPreco { get; }
        public List<Tamanho> ListaTamanhos { get; }
        public Produto(int id, string nomeDoProduto, string descricao, float? preco, float avaliacao, Marca marca, Promocao promocao, List<Categoria> listaCategorias, List<Comentario> listaComentarios, List<Cor> listaCores, List<HistoricoPreco> historicoPreco, List<Tamanho> listaTamanhos)
        {
            Id = id;
            Nome = nomeDoProduto;
            Descricao = descricao;
            Preco = preco;
            Avaliacao = avaliacao;
            Marca = marca;
            Promocao = promocao;
            ListaCategorias = listaCategorias;
            ListaComentarios = listaComentarios;
            ListaCores = listaCores;
            HistoricoPreco = historicoPreco;
            ListaTamanhos = listaTamanhos;
        }
    }
}