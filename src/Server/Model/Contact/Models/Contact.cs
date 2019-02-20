using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Server.Model.Contact.Generic.UnifiedKey;

namespace odec.Server.Model.Contact
{
    /// <summary>
    /// серверный объект - контакт
    /// </summary>
    public class Contact : ContactGeneric<Int32,Sex>
    {

        /// <summary>
        /// строка адреса - денормализованная
        /// </summary>
     [StringLength(200)]
        public string AddressDenormolized { get; set; }

        /// <summary>
        /// строка телефон - денормализованная
        /// </summary>
        [StringLength(10)]
        public string PhoneNumberDenormolized { get; set; }




    }
}
