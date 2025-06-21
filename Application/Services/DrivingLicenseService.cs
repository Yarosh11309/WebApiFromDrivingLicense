using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class DrivingLicenseService
    {
        private readonly IDrivingLicenseRepository _repository;

        public DrivingLicenseService(IDrivingLicenseRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<DrivingLicense> GetAll() => _repository.GetAll();

        public DrivingLicense? GetById(int id) => _repository.GetById(id);

        public DrivingLicense? GetByLicenseNumber(string number) => _repository.GetByLicenseNumber(number);

        public void Add(DrivingLicense license) => _repository.Add(license);

        public void Update(DrivingLicense license) => _repository.Update(license);

        public void Delete(int id) => _repository.Delete(id);
    }
}
