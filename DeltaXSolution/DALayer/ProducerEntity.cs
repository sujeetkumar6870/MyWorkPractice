//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProducerEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProducerEntity()
        {
            this.MovieEntities = new HashSet<MovieEntity>();
        }
    
        public int Producer_Id { get; set; }
        public string Producer_Name { get; set; }
        public string Producer_Sex { get; set; }
        public System.DateTime Producer_DOB { get; set; }
        public string Producer_Bio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieEntity> MovieEntities { get; set; }
    }
}
