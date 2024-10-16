using DiyoShop.Core.Enums.Genders;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyoShop.Identity.Models.Users
{
    public class User : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public GenderEnum? Gender { get; set; }= GenderEnum.Unknown;
		public DateTime BirthDate {  get; set; }
		public DateTime CreateDate { get; set; }= DateTime.Now;
		public string Status {  get; set; } = "Active";
		public Guid? DistrictId { get; set; }
		public string? DirectorName { get; set; }
		public string? RegionName { get; set; }
		public string? LocationString {  get; set; }

        public User(string firstName, string lastName, string phoneNumber)
        {
            this.FirstName = firstName;
			this.LastName = lastName;
			this.PhoneNumber = phoneNumber;
        }
        public User(string firstName, string lastName, string phoneNumber,string email,GenderEnum gender,DateTime birthDate)
        {
            this.FirstName=firstName;
            this.LastName=lastName;
			this.PhoneNumber=phoneNumber;
			this.Email=email;
			this.Gender=gender;
			this.BirthDate=birthDate;
        }

    }
}
