//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demopr30
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пользователи
    {
        public long id_пользователя { get; set; }
        public string ФИО { get; set; }
        public string Пол { get; set; }
        public string Почта { get; set; }
        public System.DateTime Дата_рождения { get; set; }
        public long id_страны { get; set; }
        public string Телефон { get; set; }
        public long id_направления { get; set; }
        public long id_состав_жюри { get; set; }
        public string Пароль { get; set; }
        public byte[] Фото { get; set; }
        public long id_роли { get; set; }
    
        public virtual Направления Направления { get; set; }
        public virtual Роли Роли { get; set; }
        public virtual Состав_жюри Состав_жюри { get; set; }
    }
}
