//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADO.NET_DataBaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class usersInfo
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string fio { get; set; }
        public string inn { get; set; }
        public System.DateTime birthDate { get; set; }
        public string gender { get; set; }
    
        public virtual users users { get; set; }
    }
}
