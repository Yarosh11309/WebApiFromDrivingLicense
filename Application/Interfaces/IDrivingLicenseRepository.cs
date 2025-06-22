using System.Collections.Generic;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IDrivingLicenseRepository
    {
        IEnumerable<DrivingLicense> GetAll();
        DrivingLicense? GetById(int id);
        DrivingLicense? GetByLicenseNumber(string licenseNumber);
        void Add(DrivingLicense license);
        void Update(DrivingLicense license);
        void Delete(int id);
    }
}
