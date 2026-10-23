public class Expense
{
    public string Description { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; } 
    public Expense(string description, decimal amount, string category )
    {
        Description = description;
        Category = category;
        Amount = amount;
    }
    
public string GetDescription()
{
    return $"{Description} - {Category} - {Amount}";
}
}