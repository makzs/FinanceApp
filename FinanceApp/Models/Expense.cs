using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models;

public class Expense
{
    public int Id { get; set; }
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public string Category { get; set; } = string.Empty;
    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Amount needs to be higher than 0")]
    public double Amount { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
}
