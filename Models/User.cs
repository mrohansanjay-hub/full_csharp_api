
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApi.Models
{
    [Table("employee")]
    public class User
    {
        [Column("employee_id")]
        [Key]
        public int Id { get; set; }
        [Column("first_name")]
        public string Firstname { get; set; }
        [Column("last_name")]
        public string Lastname { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string Contact { get; set; }
        [Column("place")]
        public string Place { get; set; }
        [Column("department")]
        public string Department { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("created_by")]
        public string? CreateBy { get; set; } = "Admini";
    }
}
