﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("info_state_program")]
    public partial class InfoStateProgram
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("order_number")]
        public string OrderNumber { get; set; } = null!;
        [Column("short_name")]
        public string ShortName { get; set; } = null!;
        [Column("full_name")]
        public string FullName { get; set; } = null!;
        [Column("state_id")]
        public int StateId { get; set; }

        [ForeignKey("StateId")]
        [InverseProperty("InfoStatePrograms")]
        public virtual EnumState State { get; set; } = null!;
    }
}
