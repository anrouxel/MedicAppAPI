namespace MedicAppAPI.Models
{
    /// <summary>
    /// Classe représentant un groupe générique.
    /// </summary>
    public class GenericGroup
    {
        /// <summary>
        /// Obtient ou définit l'identifiant du groupe générique.
        /// </summary>
        public long GenericGroupId { get; set; }

        /// <summary>
        /// Obtient ou définit le libellé du groupe générique.
        /// </summary>
        public string GenericGroupLabel { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le code CIS.
        /// </summary>
        public long CISCode { get; set; }

        /// <summary>
        /// Obtient ou définit le type générique.
        /// </summary>
        public int GenericType { get; set; }

        /// <summary>
        /// Obtient ou définit le libellé du type générique.
        /// </summary>
        public string GenericName { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le numéro de tri.
        /// </summary>
        public int? SortNumber { get; set; }
    }
}
