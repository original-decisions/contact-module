using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Framework.Generic;

namespace odec.Server.Model.Contact.Generic
{
    public class PhoneGeneric<T,TPhoneTypeId,TPhoneType>:Glossary<T>
    {
        [StringLength(20)]
        [Column("PhoneNumber")]
        public override string Name { get; set; }

        [Required]
        [DefaultValue(1)]
        public TPhoneTypeId PhoneTypeId { get; set; }
        public TPhoneType PhoneType { get; set; }

    }
}
