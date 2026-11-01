using System;
using System.ComponentModel.DataAnnotations;

namespace budget_tracker.models;

public class Expense
{
    [Key]
    public int ID {get;set;}
    public int HOUSEHOLD_ID {get;set;}
    public int CATEGORY_ID {get;set;}
    public int AMOUNT {get;set;}
    public int DESCRIPTION {get;set;}
    public DateOnly DATE {get;set;}


}
