using System;

namespace Entidade
{
    public class Bicicleta
    {
        #region propriedades
        public int id { get; set; }
        public string modelo { get; set; }

        public Fabricante fabricante { get; set; }
        public DateTime dataFabricacao { get; set; }

        #endregion propriedades

        #region método
        public override string ToString()
        {
            return "\nModelo: " + this.modelo + "\nFabricante: " + this.fabricante.nome + "\nCargo: " + this.fabricante.cargo.descricao;

        }

        #endregion método
    }
}
