using System;
using odec.Server.Model.Contact.Generic.UnifiedKey;

namespace odec.Server.Model.Contact
{
    /// <summary>
    /// серверный объект - связь контакта и телефона
    /// </summary>
    public class ContactPhone:ContactPhoneGeneric<Int32,Contact,Phone>
    {
    }
}
