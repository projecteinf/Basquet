using System.ComponentModel.DataAnnotations;

namespace mba.basquet {
    public partial class Division {
        [Key]
        [MaxLength(20)]
        public string Name { get; set; }

        public ICollection<Competes>? Teams { get; set; }
    }
}