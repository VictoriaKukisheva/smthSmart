//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfPractice.AppConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaterialsToBuy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaterialsToBuy()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int IDType { get; set; }
        public decimal Cost { get; set; }
    
        public virtual TypeMaterial TypeMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}