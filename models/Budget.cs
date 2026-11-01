using System;
using System.ComponentModel.DataAnnotations;

namespace budget_tracker.models;

public class Budget
{
    [Key]
    public int ID {get;set;}
    public int HOUSEHOLD_ID {get;set;}
    public int CATEGORY_ID {get;set;}
    public int MONTH {get;set;}
    public int LIMIT {get;set;}
    public string? NAME {get;set;}

}
