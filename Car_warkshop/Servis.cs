//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_warkshop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servis()
        {
            this.Choice_services = new HashSet<Choice_services>();
        }
    
        public int Id_servis { get; set; }
        public string Servis1 { get; set; }
        public string Cost_servis { get; set; }
        public Nullable<int> Id_mechanic { get; set; }
    
        public virtual Car_mechanic Car_mechanic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Choice_services> Choice_services { get; set; }
    }
}
