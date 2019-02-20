using Microsoft.EntityFrameworkCore;

namespace odec.CP.Server.Model.Contact.Abst.Interfaces
{
    public interface IContactContext<TContact, TPhone, TPhoneType, TSex, TContactPhone> 
        where TContact : class 
        where TPhone : class 
        where TPhoneType : class 
        where TSex : class 
        where TContactPhone : class
    {
        DbSet<TContact> Contacts { get; set; }
        DbSet<TPhone> Phones { get; set; }
        DbSet<TPhoneType> PhoneTypes { get; set; }
        DbSet<TSex> Sexes { get; set; }
        DbSet<TContactPhone> ContactPhones { get; set; }
    }
}