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
    
    public partial class Форма_Оплаты
    {
        public int Код_Формы { get; set; }
        public Nullable<bool> Наличнй_расчет { get; set; }
        public Nullable<bool> Безналичный_расчет { get; set; }
        public Nullable<int> Код_продажи { get; set; }
    
        public virtual Продажа Продажа { get; set; }
    }
}
