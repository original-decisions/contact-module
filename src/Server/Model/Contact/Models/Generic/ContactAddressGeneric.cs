using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Contact.Generic
{
    public class ContactAddressGeneric<TContactId,TContact,TAddressId,TAddress>
    {
        [Key,Column(Order = 0)]
        public TAddressId AddressId { get; set; }

        public TAddress Address { get; set; }

        [Key,Column(Order = 1)]
        public TContactId ContactId { get; set; }

        public TContact Contact { get; set; }
    }
}
