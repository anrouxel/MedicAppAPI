namespace MedicAppAPI.Models
{
    /// <summary>
    /// Classe représentant des informations importantes.
    /// </summary>
    public class ImportantInformation
    {
        /// <summary>
        /// Obtient ou définit le code CIS.
        /// </summary>
        public long CISCode { get; set; }

        /// <summary>
        /// Obtient ou définit la date de début des informations de sécurité.
        /// </summary>
        public DateOnly? SafetyInformationStartDate { get; set; }

        /// <summary>
        /// Obtient ou définit la date de fin des informations de sécurité.
        /// </summary>
        public DateOnly? SafetyInformationEndDate { get; set; }

        /// <summary>
        /// Obtient ou définit le lien vers les informations de sécurité.
        /// </summary>
        public string SafetyInformationLink { get; set; } = string.Empty;
    }
}
