namespace Domain.Enums;

public enum Action
{
    pay = 0,
    Finish = 1, //comprou e pagou
    Cancel = 2, //criado para cancelado
    Refound = 3, // pago e cancelado
    Reopen = 4 // reabrir a compra
    
}