using System.ComponentModel.DataAnnotations;

namespace BO
{
    public class Article
    {
        /// <summary>
        /// Obtient ou définit l'identifiant de l'article
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de l'article
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtient ou définit la description d'un article
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Obtient ou définit le prix unitaire d'un article
        /// </summary>
        public decimal Price { get; set; }


        /// <summary>
        ///  Obtient ou définit la quantité en stock pour un article
        /// </summary>
        public int StockQuantity { get; set; }
    }
}
