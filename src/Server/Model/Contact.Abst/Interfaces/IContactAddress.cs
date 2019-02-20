using Microsoft.EntityFrameworkCore;

namespace odec.CP.Server.Model.Contact.Abst.Interfaces
{
    /// <summary>
    /// Прокси объект контекста контактных адресов
    /// </summary>
    /// <typeparam name="TContactAddress">тип контактных адресов</typeparam>
    public interface IContactAddress<TContactAddress> where TContactAddress : class
    {
        /// <summary>
        /// таблица связи контактных адресов
        /// </summary>
        DbSet<TContactAddress> ContactAddresses { get; set; }
    }
}
