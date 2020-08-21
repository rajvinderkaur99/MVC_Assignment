using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;

namespace MovieCustomerMVCAppWithAuthen.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get;set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType{ get; set; }

        public int MembershipTypeId { get; set; }
    }
}