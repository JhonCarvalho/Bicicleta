namespace Entidade
{
    public class Fabricante
    {
        #region propriedades
        public int id { get; set; }
        public string nome { get; set; }

        public Cargo cargo { get; set; }

        #endregion propriedades
    }
}