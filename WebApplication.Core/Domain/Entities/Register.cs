using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Domain.Enums;

namespace WebApplication.Core.Domain.Entities
{
    public class Register:BaseEntity
    {
        public Register(string name, string email, string phoneNumber, string document, EDocumentType documentType, string fullAddress, string companyLogo, string companyBanner, bool isVerified)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Document = document;
            DocumentType = documentType;
            FullAddress = fullAddress;
            SupportNumbers = new List<PhoneNumber>();
            CompanyLogo = companyLogo;
            CompanyBanner = companyBanner;
            IsVerified = false;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string? Document { get;private set; }
        public EDocumentType DocumentType { get; private set; }
        public string FullAddress { get; private set; }
        public List<PhoneNumber> SupportNumbers { get; private set; }
        public string CompanyLogo { get; private set; }
        public string CompanyBanner { get; private set; }
        public bool IsVerified { get; private set; }
       

        public void UploadDocument(string ToUpload)
        {
            Document = ToUpload;
            IsVerified=true;
        }

    }
}
