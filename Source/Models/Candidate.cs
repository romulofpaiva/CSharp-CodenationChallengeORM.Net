using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
  [Table("candidate")]
  public class Candidate
  {
    [Column("user_id")]
    [Required]
    public int UserId { get; set; }

    public User User { get; set; }
 
    [Column("acceleration_id")]
    [Required]
    public int AccelerationId { get; set; }

    [Required]
    public Acceleration Acceleration { get; set; }

    [Column("company_id")]
    [Required]
    public int CompanyId { get; set; }

    [Required]
    public Company Company { get; set; }
    
    [Column("status")]
    [Required]
    public int Status { get; set; }

    [Column("created_at")]
    [Required]
    public DateTime CreatedAt { get; set; }
  }
}