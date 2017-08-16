namespace Vulnerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ATC_IATC_PendingItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ATC_IATC_PendingItems()
        {
            ATC_IATC = new HashSet<ATC_IATC>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ATC_IATC_PendingItem_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string PendingItem { get; set; }

        public DateTime PendingItemDueDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATC_IATC> ATC_IATC { get; set; }
    }
}
