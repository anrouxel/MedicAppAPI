using MedicAppAPI.Configurations;
using MedicAppAPI.Controllers;
using MedicAppAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace MedicAppAPI.Services
{
    public class MedicationService
    {
        private readonly IMongoCollection<Medication> _medicationsCollection;

        public MedicationService(
            IOptions<ConfigureDatabaseSettings> databaseSettings)
        {
            MongoClientSettings mongoSettings = MongoClientSettings.FromConnectionString(databaseSettings.Value.ConnectionString);

            mongoSettings.LinqProvider = LinqProvider.V3;

            var mongoClient = new MongoClient(mongoSettings);

            var mongoDatabase = mongoClient.GetDatabase(
                databaseSettings.Value.DatabaseName);

            _medicationsCollection = mongoDatabase.GetCollection<Medication>(
                databaseSettings.Value.MedicationsCollectionName);
        }

        public async Task<List<Medication>> GetAsync()
        {
            return await _medicationsCollection.AsQueryable().ToListAsync();
        }

        public async Task<Medication?> GetAsync(long CISCode)
        {
            return await _medicationsCollection.AsQueryable().FirstOrDefaultAsync(m => m.CISCode == CISCode);
        }

        public async Task CreateAsync(List<Medication> newMedications)
        {
            foreach (var medication in newMedications)
            {
                await CreateAsync(medication);
            }
        }

        public async Task CreateAsync(Medication newBook)
        {
            var existingMedication = await _medicationsCollection.AsQueryable().FirstOrDefaultAsync(m => m.CISCode == newBook.CISCode);
            if (existingMedication != null)
            {
                await UpdateAsync(newBook.CISCode, newBook);
            }
            else
            {
                await _medicationsCollection.InsertOneAsync(newBook);
            }
        }

        public async Task UpdateAsync(long CISCode, Medication updatedMedication)
        {
            await _medicationsCollection.ReplaceOneAsync(m => m.CISCode == CISCode, updatedMedication);
        }

        public async Task RemoveAsync(long CISCode)
        {
            await _medicationsCollection.DeleteOneAsync(m => m.CISCode == CISCode);
        }
    }
}
