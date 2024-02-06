namespace MedicAppAPI.Models
{
    /// <summary>
    /// Classe représentant une opinion sur le SMR (Service Médical Rendu).
    /// </summary>
    public class HasSmrOpinion
    {
        /// <summary>
        /// Obtient ou définit le code CIS.
        /// </summary>
        public long CISCode { get; set; }

        /// <summary>
        /// Obtient ou définit le code du dossier.
        /// </summary>
        public string HasDossierCode { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit la raison de l'évaluation.
        /// </summary>
        public string EvaluationReason { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit la date de l'opinion de la Commission de la Transparence.
        /// </summary>
        public DateOnly? TransparencyCommissionOpinionDate { get; set; }

        /// <summary>
        /// Obtient ou définit la valeur du SMR.
        /// </summary>
        public string SmrValue { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le libellé du SMR.
        /// </summary>
        public string SmrLabel { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit les liens vers les opinions de la Commission de la Transparence.
        /// </summary>
        public List<TransparencyCommissionOpinionLinks> TransparencyCommissionOpinionLinks { get; set; } = new();
    }
}
