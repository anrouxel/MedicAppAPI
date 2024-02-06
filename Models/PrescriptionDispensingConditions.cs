namespace MedicAppAPI.Models
{
    /// <summary>
    /// Classe représentant les conditions de prescription et de délivrance d'un médicament.
    /// </summary>
    public class PrescriptionDispensingConditions
    {

        /// <summary>
        /// Obtient ou définit le code CIS du médicament.
        /// </summary>
        public long CISCode { get; set; }

        /// <summary>
        /// Obtient ou définit la condition de prescription et de délivrance du médicament.
        /// </summary>
        public string PrescriptionDispensingCondition { get; set; } = string.Empty;
    }
}
