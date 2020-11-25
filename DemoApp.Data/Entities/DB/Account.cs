//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoApp.Data.Entities.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            this.AccountRole = new HashSet<AccountRole>();
        }
    
        public int AccountId { get; set; }
        public string Id { get; set; }
        public Nullable<int> EZFId { get; set; }
        public string FOBId { get; set; }
        public Nullable<int> BlobId { get; set; }
        public string Title { get; set; }
        public string Designations { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string WorkPhone { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Company { get; set; }
        public string Gender { get; set; }
        public string StatusKey { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> tmpLocation { get; set; }
        public Nullable<int> tmpRole { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public string ResidencyTimeZone { get; set; }
        public Nullable<int> TotalMasterCoachingHours { get; set; }
        public Nullable<decimal> CoachingCapacity { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public bool IsAutoBilling { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountRole> AccountRole { get; set; }
    }
}