//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessClub.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainings()
        {
            this.Attendance = new HashSet<Attendance>();
            this.Bookings = new HashSet<Bookings>();
        }
    
        public int TrainingID { get; set; }
        public string TrainingType { get; set; }
        public Nullable<int> TrainerID { get; set; }
        public Nullable<int> GymID { get; set; }
        public System.DateTime Schedule { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> MaxParticipants { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bookings> Bookings { get; set; }
        public virtual Gyms Gyms { get; set; }
        public virtual Trainers Trainers { get; set; }
    }
}