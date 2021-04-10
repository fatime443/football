//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            this.Reservation_TO_Rooms = new HashSet<Reservation_TO_Rooms>();
        }
    
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public int PlayersCount { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> WorkerId { get; set; }
        public Nullable<int> StadiumId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation_TO_Rooms> Reservation_TO_Rooms { get; set; }
        public virtual Stadium Stadium { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
