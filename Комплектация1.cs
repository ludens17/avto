//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Комплектация1
    {
        public int Код_Комплектации { get; set; }
        public string КПП { get; set; }
        public string Цвет { get; set; }
        public string Привод { get; set; }
        public Nullable<int> Код_Автомобиль { get; set; }
    
        public virtual автомобиль автомобиль { get; set; }
    }
}
