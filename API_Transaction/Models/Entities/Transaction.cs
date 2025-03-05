using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace API_Transaction.Models.Entities
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public required string Type { get; set; }

        public string? Note { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int? PaymentMethodId { get; set; }

        public string? TransactionId { get; set; }

        [StringLength(10)]
        public string Status { get; set; } = "pending";

        public string? PaymentGateway { get; set; }

        public int? CurrencyId { get; set; }
    }
}
