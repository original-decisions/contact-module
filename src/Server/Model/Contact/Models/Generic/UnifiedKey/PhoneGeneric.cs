using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Framework.Generic;

namespace odec.Server.Model.Contact.Generic.UnifiedKey
{
    //TODO: Refactor class
    /// <summary>
    /// Обобщенный класс - телефон
    /// </summary>
    /// <typeparam name="TKey">Тип идентификтора</typeparam>
    /// <typeparam name="TPhoneType">ТИп типа телефона</typeparam>
    public class PhoneGeneric<TKey, TPhoneType> : Glossary<TKey>
    {
        /// <summary>
        /// Номер телефона
        /// </summary>
        [StringLength(20)]
        [Column("PhoneNumber")]
        public override string Name { get; set; }
        /// <summary>
        /// Идентификтаор типа телефона
        /// </summary>
        [Required]
        [DefaultValue(1)]
        public TKey PhoneTypeId { get; set; }
        /// <summary>
        /// Тип телефона
        /// </summary>
        public TPhoneType PhoneType { get; set; }


    }
}
