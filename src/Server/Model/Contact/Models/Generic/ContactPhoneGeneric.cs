using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Contact.Generic
{
    public class ContactPhoneGeneric<TContactId, TContact, TPhoneId, TPhone>
    {
        [Key, Column(Order = 0)]
        public TPhoneId PhoneId { get; set; }

        public TPhone Phone { get; set; }

        [Key, Column(Order = 1)]
        public TContactId ContactId { get; set; }

        public TContact Contact { get; set; }
    }
}
