using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Contact.Generic.UnifiedKey
{
    //TODO:Refactor this class
    /// <summary>
    /// Обощенный класс - пол
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    public class SexGeneric<TKey> : Glossary<TKey>
    {
        /// <summary>
        /// Имя
        /// </summary>
        [StringLength(50)]
        public override string Name { get; set; }        
    }
}
