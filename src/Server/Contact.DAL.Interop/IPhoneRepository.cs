using odec.Entity.DAL.Interop;
using System.Collections.Generic;
namespace odec.Contact.DAL.Interop
{
    /// <summary>
    /// Interface to represent repository to operate with Phone
    /// </summary>
    /// <typeparam name="TPhoneId">Phone Key type</typeparam>
    /// <typeparam name="TPhone">Phone type</typeparam>
    /// <typeparam name="TUser">User type</typeparam>
    /// <typeparam name="TUserId">User key type</typeparam>
    /// <typeparam name="TPhoneType">Phone type type</typeparam>
    /// <typeparam name="TContact">Contact type</typeparam>
    public interface IPhoneRepository<TPhoneId, TUser, TUserId, TPhone, TPhoneType, TContact> :
        IActivatableEntity<TPhoneId, TPhone>,
        IEntityOperations<TPhoneId, TPhone>
        where TPhoneId : struct
        where TPhone : class
    {
        /// <summary>
        /// Gets User Phones 
        /// </summary>
        /// <param name="user">user object</param>
        /// <returns><see cref="IList{T}"></see> of phones</returns>
        IList<TPhone> GetUserPhones(TUser user);

        /// <summary>
        /// Gets User Phones  by Id
        /// </summary>
        /// <param name="userId">user identity</param>
        /// <returns><see cref="IList{T}"></see> of phones</returns>
        IList<TPhone> GetUserPhones(TUserId userId);

        /// <summary>
        /// Gets Phone Type
        /// </summary>
        /// <param name="phone">phone object</param>
        /// <returns> return Phone type of the the Phone Types</returns>
        TPhoneType GetPhoneType(TPhone phone);

        /// <summary>
        /// Gets Phone Type by phone Id
        /// </summary>
        /// <param name="phoneId">phone identity</param>
        /// <returns> return Phone type of the Phone Types</returns>
        TPhoneType GetPhoneType(TPhoneId phoneId);

        /// <summary>
        /// Get Contacts which has the phone specified.
        /// </summary>
        /// <param name="phone">phone object</param>
        /// <returns> returns list of the contacts</returns>
        IList<TContact> GetContactsWithThatPhone(TPhone phone);


        /// <summary>
        /// Get Contacts which has the phone specified by phone Id
        /// </summary>
        /// <param name="phoneId">phone identity</param>
        /// <returns> returns list of the contacts</returns>
        IList<TContact> GetContactsWithThatPhone(TPhoneId phoneId);


    }
}
