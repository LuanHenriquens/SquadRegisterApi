using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SquadRegisterApi.Models
{
    [Table("squad",Schema = "squad_register")]
    public class Squad
    {
        [Key]
        public int? id {get; set;}
        public String name {get; set;}
        public DateTime? create_date {get; set;}
        public String description {get; set;}
    }
}