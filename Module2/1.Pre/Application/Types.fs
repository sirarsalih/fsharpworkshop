module Types

type Customer = 
    { Id: int
      IsVip: bool
      Credit: float }

let customer1 = {Id = 1; IsVip = true; Credit = 10.0};;

let customer2 = {Id = 2; IsVip = false; Credit = 0.0};;