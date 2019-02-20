using System;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Contact.Generic.UnifiedKey
{
    //TODO:Refactor this class
    /// <summary>
    /// Обобщенный класс - контакт
    /// </summary>
    /// <typeparam name="TKey">Тип Идентификатора</typeparam>
    /// <typeparam name="TSex">Тип пола</typeparam>
    public class ContactGeneric<TKey, TSex> : Glossary<TKey>
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string Patronymic { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string LastName { get; set; }
        /// <summary>
        /// Почта
        /// </summary>
        [StringLength(20)]
        public string Email { get; set; }

        /// <summary>
        /// Идентификтаор пола
        /// </summary>
        public TKey SexId { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public TSex Sex { get; set; }
        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime? BirthdayDate { get; set; }
        /// <summary>
        /// Признак новосной рассылки
        /// </summary>
        public bool SendNews { get; set; }

    }


}