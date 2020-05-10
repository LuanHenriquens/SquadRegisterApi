using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SquadRegisterApi.Models
{
    [Table("member",Schema = "squad_register")]
    public class Member
    {
        [Key]
        public int id { get;set; }
        public string name { get;set; }
        public DateTime create_date { get;set; }
        public string function { get; set; }
        public int squad_id { get; set; }
    }
}