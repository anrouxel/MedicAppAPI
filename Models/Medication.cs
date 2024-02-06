using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MedicAppAPI.Models
{
    /// <summary>
    /// Classe représentant un médicament.
    /// </summary>
    public class Medication
    {
        /// <summary>
        /// Obtient ou définit le code CIS du médicament.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.Int64)]
        public long CISCode { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du médicament.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit la forme pharmaceutique du médicament.
        /// </summary>
        public string PharmaceuticalForm { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit les voies d'administration du médicament.
        /// </summary>
        public List<string> AdministrationRoutes { get; set; } = new();

        /// <summary>
        /// Obtient ou définit le statut de l'autorisation de mise sur le marché du médicament.
        /// </summary>
        public string MarketingAuthorizationStatus { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le type de procédure d'autorisation de mise sur le marché du médicament.
        /// </summary>
        public string MarketingAuthorizationProcedureType { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le statut de commercialisation du médicament.
        /// </summary>
        public string CommercializationStatus { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit la date de l'autorisation de mise sur le marché du médicament.
        /// </summary>
        public DateOnly? MarketingAuthorizationDate { get; set; }

        /// <summary>
        /// Obtient ou définit le statut BDM du médicament.
        /// </summary>
        public string BdmStatus { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit le numéro d'autorisation européen du médicament.
        /// </summary>
        public string EuropeanAuthorizationNumber { get; set; } = string.Empty;

        /// <summary>
        /// Obtient ou définit les détenteurs du médicament.
        /// </summary>
        public List<string> Holders { get; set; } = new();

        /// <summary>
        /// Obtient ou définit si le médicament est sous surveillance renforcée.
        /// </summary>
        public bool? EnhancedMonitoring { get; set; }

        /// <summary>
        /// Obtient ou définit les compositions du médicament.
        /// </summary>
        public List<MedicationComposition> MedicationCompositions { get; set; } = new();

        /// <summary>
        /// Obtient ou définit les présentations du médicament.
        /// </summary>
        public List<MedicationPresentation> MedicationPresentations { get; set; } = new();

        /// <summary>
        /// Obtient ou définit les groupes génériques du médicament.
        /// </summary>
        public List<GenericGroup> GenericGroups { get; set; } = new();

        /// <summary>
        /// Obtient ou définit les opinions SMR du médicament.
        /// </summary>
        public List<HasSmrOpinion> HasSmrOpinions { get; set; } = new();

        /// <summary>
        /// Obtient ou définit les opinions ASMR du médicament.
        /// </summary>
        public List<HasAsmrOpinion> HasAsmrOpinions { get; set; } = new();

        /// <summary>
        /// Obtient ou définit les informations importantes du médicament.
        /// </summary>
        public List<ImportantInformation> ImportantInformations { get; set; } = new();

        /// <summary>
        /// Obtient ou définit les conditions de délivrance du médicament.
        /// </summary>
        public List<PrescriptionDispensingConditions> PrescriptionDispensingConditions { get; set; } = new();

        /// <summary>
        /// Obtient ou définit les spécialités pharmaceutiques du médicament.
        /// </summary>
        public List<PharmaceuticalSpecialty> PharmaceuticalSpecialties { get; set; } = new();
    }
}
