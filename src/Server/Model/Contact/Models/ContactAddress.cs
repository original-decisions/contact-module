using System;
using odec.CP.Server.Model.Location;
using odec.Server.Model.Contact.Generic.UnifiedKey;
using odec.Server.Model.Location;

namespace odec.Server.Model.Contact
{
    /// <summary>
    /// серверный объект - связь контакта и адреса 
    /// </summary>
    public class ContactAddress :ContactAddressGeneric<Int32,Contact,Address>
    {

    }
}
