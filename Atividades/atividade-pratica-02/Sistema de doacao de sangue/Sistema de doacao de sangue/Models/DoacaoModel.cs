using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_doacao_de_sangue.Models
{
    public class DoacaoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome da pessoa")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o documento da pessoa")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "Digite a rua da pessoa")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Digite o nº da pessoa")]
        public int Número { get; set; }

        [Required(ErrorMessage = "Digite o complemento da pessoa")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Digite a cidade da pessoa")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Digite o estado da pessoa")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Digite o tipo sanguineo da pessoa")]
        public string Tipo_sanguíneo { get; set; }

        [Required(ErrorMessage = "Digite o fator sanguineo da pessoa")]
        public string Fator { get; set; }

        [Required(ErrorMessage = "Digite a data de doacao")]
        public string Data_de_doacao { get; set; }

        [Required(ErrorMessage = "Digite o nome do local de doacao")]
        public string Nome_local_doacao { get; set; }

        [Required(ErrorMessage = "Digite a rua do local de doacao")]
        public string Rua_local_doacao { get; set; }

        [Required(ErrorMessage = "Digite o nº do local de doacao")]
        public int Num_local_doacao { get; set; }

        [Required(ErrorMessage = "Digite o complemento do local de doacao")]
        public string Complemento_local_doacao { get; set; }

        [Required(ErrorMessage = "Digite a cidade do local de doacao")]
        public string Cidade_local_doacao { get; set; }

        [Required(ErrorMessage = "Digite o estado do local de doacao")]
        public string Estado_local_doacao { get; set; }
    }
}
