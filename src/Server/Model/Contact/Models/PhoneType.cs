using System;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Contact
{
    /// <summary>
    /// серверный объект - тип телефона
    /// </summary>
    public class PhoneType:Glossary<Int32>
    {
        /// <summary>
        /// наименование ( домашний, рабочий и проч.)
        /// </summary>
        [StringLength(50)]
        public override string Name { get; set; }

       }
}
