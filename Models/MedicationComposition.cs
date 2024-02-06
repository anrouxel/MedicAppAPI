namespace MedicAppAPI.Models
{
    /// <summary>
    /// Classe représentant la composition d'un médicament.
    /// </summary>
    public class MedicationComposition
    {

        /// <summary>
        /// Obtient ou définit le code CIS du médicament.
        /// </summary>
        public long CISCode { get; set; }

        /// <summary>
        /// Obtient ou définit la désignation de l'élément pharmaceutique.
        /// </summary>
        public string PharmaceuticalElementDesignation { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le code de la substance.
        /// </summary>
        public long SubstanceCode { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de la substance.
        /// </summary>
        public string SubstanceName { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le dosage de la substance.
        /// </summary>
        public string SubstanceDosage { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit la référence du dosage.
        /// </summary>
        public string DosageReference { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit la nature du composant.
        /// </summary>
        public string ComponentNature { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le numéro de lien.
        /// </summary>
        public int? LinkNumber { get; set; }
    }
}
