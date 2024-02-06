namespace MedicAppAPI.Models
{
    /// <summary>
    /// Classe représentant les liens vers les avis de la Commission de la Transparence.
    /// </summary>
    public class TransparencyCommissionOpinionLinks
    {

        /// <summary>
        /// Obtient ou définit le code indiquant si le dossier a été examiné par la Commission de la Transparence.
        /// </summary>
        public string HasDossierCode { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le lien vers l'avis de la Commission de la Transparence.
        /// </summary>
        public Uri? CommissionOpinionLink { get; set; }
    }
}
