using System;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Contact.Generic
{
    public class ContactGeneric<T, TUserId, TUser, TPhoneId, TPhone, TSexId, TSex> : Glossary<T>
    {

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = true)]

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string Email { get; set; }

        public TUserId UserId { get; set; }
        public TUser User { get; set; }

        public TPhoneId PhoneId { get; set; }



        public TPhone Phone { get; set; }

        public TSexId SexId { get; set; }

        public TSex Sex { get; set; }

        public DateTime? BirthdayDate { get; set; }

        public bool SendNews { get; set; }

        //public Boolean IsAccountContact { get; set; }



        //public virtual ICollection<> Orders { get; set; }

      



    }


}