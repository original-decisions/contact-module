using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Contact.Generic.UnifiedKey
{
    /// <summary>
    /// Обобщенная связь контакта и телефона
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    /// <typeparam name="TContact">Тип контакта</typeparam>
    /// <typeparam name="TPhone">Тип телефона</typeparam>
    public class ContactPhoneGeneric<TKey, TContact, TPhone>
    {
        /// <summary>
        /// Идентификатор телефона
        /// </summary>
     //   [Key, Column(Order = 0)]
        public TKey PhoneId { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public TPhone Phone { get; set; }
        /// <summary>
        /// Идентификатор контакта
        /// </summary>
   //     [Key, Column(Order = 1)]
        public TKey ContactId { get; set; }
        /// <summary>
        /// Контакт
        /// </summary>
        public TContact Contact { get; set; }
    }
}
