using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace WebPostgreSQL.Models
{

    [Table("Produto")] //Nome da Tabela no banco 
    public class Produto
    {
        [Column("Id")] //Nome da coluna
        [Display(Name = "Código")] //Nome que vai aparecer na tela do CRUD
        public int Id { get; set; }

        [Column("Nome")] //Nome da coluna
        [Display(Name = "Nome")] //Nome que vai aparecer na tela do CRUD
        public string Nome { get; set; }
    }
}
