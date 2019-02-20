using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Contact.Generic.UnifiedKey
{
    /// <summary>
    /// Обобщенный класс связи адреса и контакта
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    /// <typeparam name="TContact">Тип контакта</typeparam>
    /// <typeparam name="TAddress">Тип адреса</typeparam>
    public class ContactAddressGeneric<TKey, TContact, TAddress>
    {
        /// <summary>
        /// Идентификатор адреса
        /// </summary>
       // [Key,Column(Order = 0)]
        public TKey AddressId { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public TAddress Address { get; set; }
        /// <summary>
        /// Идентификатор контакта
        /// </summary>
      //  [Key,Column(Order = 1)]
        public TKey ContactId { get; set; }
        /// <summary>
        /// Контакт
        /// </summary>
        public TContact Contact { get; set; }
    }
}
