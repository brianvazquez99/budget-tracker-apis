using System;
using System.ComponentModel.DataAnnotations;

namespace budget_tracker;

public class HouseHold
{
    [Key]
    public int ID {get; set;}
    public int INVITE_CODE {get; set;}
}
