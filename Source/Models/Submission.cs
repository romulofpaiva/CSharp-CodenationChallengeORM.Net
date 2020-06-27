using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("submission")]
    public class Submission
    {
      [Column("user_id")]
      [Required]
      public int UserId { get; set; }

      [Required]
      public User User { get; set; }

      [Column("challenge_id")]
      [Required]
      public int ChallengeId { get; set; }

      [Required]
      public Challenge Challenge { get; set; }
      
      [Column("score", TypeName="decimal(9,2)")]
      [Required]
      public decimal Score { get; set; }

      [Column("created_at")]
      [Required]
      public DateTime CreatedAt { get; set; }
    }
}