namespace Авторизация.EFAuto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пользователи
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Логин { get; set; }

        [Required]
        [StringLength(10)]
        public string Пароль { get; set; }

        [StringLength(10)]
        public string ФИО { get; set; }

        public int Роль { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ДатаСоздания { get; set; }

        public bool? Блокировка { get; set; }

        public virtual Роли Роли { get; set; }
    }
}
