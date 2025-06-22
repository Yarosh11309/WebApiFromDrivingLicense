using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class DrivingLicense
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public int BirthYear { get; set; }
        public string IssueRegion { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public string IssuingAuthority { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public List<CategoryIssue> CategoryHistory { get; set; } = new();
    }
}
