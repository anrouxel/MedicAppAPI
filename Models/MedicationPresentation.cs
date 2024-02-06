namespace MedicAppAPI.Models
{
    /// <summary>
    /// Classe représentant une présentation de médicament.
    /// </summary>
    public class MedicationPresentation
    {

        /// <summary>
        /// Obtient ou définit le code CIS du médicament.
        /// </summary>
        public long CISCode { get; set; }

        /// <summary>
        /// Obtient ou définit le code CIP7 de la présentation.
        /// </summary>
        public long CIP7Code { get; set; }

        /// <summary>
        /// Obtient ou définit le libellé de la présentation.
        /// </summary>
        public string PresentationLabel { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le statut de la présentation.
        /// </summary>
        public string PresentationStatus { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le statut de commercialisation de la présentation.
        /// </summary>
        public string PresentationCommercializationStatus { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit la date de déclaration de commercialisation de la présentation.
        /// </summary>
        public DateOnly? CommercializationDeclarationDate { get; set; }

        /// <summary>
        /// Obtient ou définit le code CIP13 de la présentation.
        /// </summary>
        public long CIP13Code { get; set; }

        /// <summary>
        /// Obtient ou définit si la présentation est approuvée pour les communautés.
        /// </summary>
        public bool? ApprovalForCommunities { get; set; }

        /// <summary>
        /// Obtient ou définit les taux de remboursement de la présentation.
        /// </summary>
        public List<decimal> ReimbursementRates { get; set; } = new();

        /// <summary>
        /// Obtient ou définit le prix sans honoraire en euro de la présentation.
        /// </summary>
        public decimal? PriceWithoutHonoraryInEuro { get; set; }

        /// <summary>
        /// Obtient ou définit le prix avec honoraire en euro de la présentation.
        /// </summary>
        public decimal? PriceWithHonoraryInEuro { get; set; }

        /// <summary>
        /// Obtient ou définit le prix de l'honoraire en euro de la présentation.
        /// </summary>
        public decimal? PriceHonoraryInEuro { get; set; }

        /// <summary>
        /// Obtient ou définit les indications de remboursement de la présentation.
        /// </summary>
        public string ReimbursementIndications { get; set; } = string.Empty;
    }
}
