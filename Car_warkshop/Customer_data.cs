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
    
    public partial class Customer_data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer_data()
        {
            this.Choice_services = new HashSet<Choice_services>();
        }
    
        public int Id_client { get; set; }
        public string Surname_client { get; set; }
        public string Name_client { get; set; }
        public string Partronymic_client { get; set; }
        public string Mail_client { get; set; }
        public string Phone_number_client { get; set; }
        public string Login_client { get; set; }
        public string Password_client { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Choice_services> Choice_services { get; set; }
    }
}
