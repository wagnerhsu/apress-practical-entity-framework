﻿using System.ComponentModel.DataAnnotations;

namespace Activity1402_MultipleDatabaseContexts.Models
{
    public class Item
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }

}
