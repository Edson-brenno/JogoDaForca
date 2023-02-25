using System;

public class LetraNaoPodeSerUmCharEspecialExeption:Exception{ //Will be reaised if the letter is an special character; Vai ser utilizada se caso a letra utilizada é um caracter especial 

    public LetraNaoPodeSerUmCharEspecialExeption():base("Error - A letra não pode ser um character especial "){}
}