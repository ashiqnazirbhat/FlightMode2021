//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightMode.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class test_package
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public test_package()
        {
            this.package_item = new HashSet<package_item>();
        }
    
        public long test_package_id { get; set; }
        public string test_package_name { get; set; }
        public Nullable<int> test_package_pno { get; set; }
        public string test_package_profile { get; set; }
        public string test_package_habits { get; set; }
        public string test_package_conditions { get; set; }
        public Nullable<double> test_package_price { get; set; }
        public Nullable<double> test_package_dprice { get; set; }
        public string test_package_created { get; set; }
        public string test_package_created_by { get; set; }
        public string test_package_updated { get; set; }
        public string test_package_updated_by { get; set; }
        public string test_package_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<package_item> package_item { get; set; }
    }
}