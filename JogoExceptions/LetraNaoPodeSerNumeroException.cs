using System;

public class LetraNaoPodeSerNumeroException: Exception{

    public LetraNaoPodeSerNumeroException(): base("Error! A letra não pode ser um número"){

    }

}