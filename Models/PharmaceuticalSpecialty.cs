namespace MedicAppAPI.Models
{
    /// <summary>
    /// Represents pharmaceutical specialties information from the ANSM's "Disponibilité des produits de santé" section.
    /// </summary>
    public class PharmaceuticalSpecialty
    {

        /// <summary>
        /// Code CIS (Code Identifiant de Spécialité)
        /// </summary>
        public long CISCode { get; set; }

        /// <summary>
        /// Code CIP13 (Code Identifiant de Présentation à 13 chiffres)
        /// This column will not be filled if all commercialized presentations of a pharmaceutical specialty are concerned.
        /// </summary>
        public string Cip13Code { get; set; } = string.Empty;

        public int StatusCode { get; set; }

        /// <summary>
        /// Label of the status based on the StatusCode values.
        /// </summary>
        public string StatusLabel { get; set; } = string.Empty;

        /// <summary>
        /// Date of the status start (format JJ/MM/AAAA).
        /// For records before 06/10/2023: the date will be the update date, not the start date.
        /// </summary>
        public DateOnly? StartDate { get; set; }

        /// <summary>
        /// Date of the update on the ANSM site (format JJ/MM/AAAA).
        /// </summary>
        public DateOnly? UpdateDate { get; set; }

        /// <summary>
        /// Date of the product's return to the market (format JJ/MM/AAAA).
        /// </summary>
        public DateOnly? ReturnToDate { get; set; }

        /// <summary>
        /// Link to the ANSM site page.
        /// </summary>
        public string AnsmSiteLink { get; set; } = string.Empty;
    }
}
