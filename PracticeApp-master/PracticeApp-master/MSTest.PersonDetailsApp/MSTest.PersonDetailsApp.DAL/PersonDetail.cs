//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSTest.PersonDetailsApp.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonDetail()
        {
            this.PersonFiles = new HashSet<PersonFile>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime DOB { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonFile> PersonFiles { get; set; }
    }
}