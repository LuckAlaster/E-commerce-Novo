namespace E_commerce.Models
{
    public class Categoria : Model
    {

        public int? CategoriaId { get; }
        public string NomeCategoria { get; }
        public string DescricaoCategoria { get; }
        public Categoria(int modelId, int? categoriaId, string nomeCategoria, string descricaoCategoria)
        {
            CategoriaId = categoriaId;
            NomeCategoria = nomeCategoria;
            DescricaoCategoria = descricaoCategoria;
            ModelId = modelId;
        }
    }
}