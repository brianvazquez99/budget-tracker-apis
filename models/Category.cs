using System;
using System.ComponentModel.DataAnnotations;

namespace budget_tracker.models;

public class Category
{
    [Key]
    public int ID {get;set;}
    public int HOUSEHOLD_ID {get;set;}

    public string NAME {get;set;}

}
