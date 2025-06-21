using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class InMemoryDrivingLicenseRepository : IDrivingLicenseRepository
    {
        private readonly List<DrivingLicense> _licenses = new();
        private int _nextId = 1;

        public IEnumerable<DrivingLicense> GetAll() => _licenses;

        public DrivingLicense? GetById(int id) => _licenses.FirstOrDefault(l => l.Id == id);

        public DrivingLicense? GetByLicenseNumber(string licenseNumber) => _licenses.FirstOrDefault(l => l.LicenseNumber == licenseNumber);

        public void Add(DrivingLicense license)
        {
            license.Id = _nextId++;
            _licenses.Add(license);
        }

        public void Update(DrivingLicense license)
        {
            var index = _licenses.FindIndex(l => l.Id == license.Id);
            if (index >= 0)
                _licenses[index] = license;
        }

        public void Delete(int id)
        {
            var license = GetById(id);
            if (license != null)
                _licenses.Remove(license);
        }
    }
}
