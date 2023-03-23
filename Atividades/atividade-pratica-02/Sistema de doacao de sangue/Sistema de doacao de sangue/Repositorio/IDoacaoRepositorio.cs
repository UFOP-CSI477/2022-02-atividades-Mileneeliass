using Sistema_de_doacao_de_sangue.Models;

namespace Sistema_de_doacao_de_sangue.Repositorio
{
    public interface IDoacaoRepositorio
    {
        DoacaoModel ListarPorId(int id);
        List<DoacaoModel> BuscarTodos();
        DoacaoModel Adicionar(DoacaoModel doacao);

        DoacaoModel Atualizar(DoacaoModel doacao);

        bool Apagar(int id);
    }
}
