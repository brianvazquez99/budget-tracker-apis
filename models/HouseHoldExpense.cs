using System;

namespace budget_tracker.models;

public class HouseHoldExpense
{

    int ID {get;set;}

    int BUDGET_ID {get;set;}

    int EXPENSE {get;set;}

    DateOnly EXPENSE_DATE {get;set;}

}
