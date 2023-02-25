using System;

public class LetraNaoPodeSerNulaException: Exception{

    public LetraNaoPodeSerNulaException():base("Error! A letra não pode ser nula ou conter espaços"){}

}