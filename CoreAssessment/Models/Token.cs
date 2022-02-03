using System.ComponentModel.DataAnnotations;
namespace CoreAssessment.Models
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Descriptions { get; set; }
        public string Movie_Type { get; set; }
        public string Languages { get; set; }
    }
}
