using Sistema_de_doacao_de_sangue.Data;
using Sistema_de_doacao_de_sangue.Models;

namespace Sistema_de_doacao_de_sangue.Repositorio
{
    public class DoacaoRepositorio : IDoacaoRepositorio
    {
        private readonly BancoContext _context;
        public DoacaoRepositorio(BancoContext bancoContext)
        {
            this._context = bancoContext;
        }

        public DoacaoModel ListarPorId(int id)
        {
            return _context.Doacao.FirstOrDefault(x =>x.Id == id);
        }
        public List<DoacaoModel> BuscarTodos()
        {
            return _context.Doacao.ToList() ;
        }
        public DoacaoModel Adicionar(DoacaoModel doacao)
        {
            _context.Doacao.Add(doacao);
            _context.SaveChanges();

            return doacao;
        }

        public DoacaoModel Atualizar(DoacaoModel doacao)
        {
            DoacaoModel doacaoDB = ListarPorId(doacao.Id);

            if (doacaoDB == null) throw new Exception("Houve um erro na atualização!");

            doacaoDB.Nome = doacao.Nome;
            doacaoDB.Documento = doacao.Documento;
            doacaoDB.Rua = doacao.Rua;
            doacaoDB.Número = doacao.Número;
            doacaoDB.Complemento = doacao.Complemento;
            doacaoDB.Cidade = doacao.Cidade;
            doacaoDB.Estado = doacao.Estado;
            doacaoDB.Tipo_sanguíneo = doacao.Tipo_sanguíneo;
            doacaoDB.Fator = doacao.Fator;
            doacaoDB.Data_de_doacao = doacao.Data_de_doacao;
            doacaoDB.Nome_local_doacao = doacao.Nome_local_doacao;
            doacaoDB.Rua_local_doacao = doacao.Rua_local_doacao;
            doacaoDB.Num_local_doacao = doacao.Num_local_doacao;
            doacaoDB.Complemento_local_doacao = doacao.Complemento_local_doacao;
            doacaoDB.Cidade_local_doacao = doacao.Cidade_local_doacao;
            doacaoDB.Estado_local_doacao = doacao.Estado_local_doacao;

            _context.Doacao.Update(doacaoDB);
            _context.SaveChanges();

            return doacaoDB;
        }

        public bool Apagar(int id)
        {

            DoacaoModel doacaoDB = ListarPorId(id);

            if (doacaoDB == null) throw new Exception("Houve um erro ao deletar!");

            _context.Doacao.Remove(doacaoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
