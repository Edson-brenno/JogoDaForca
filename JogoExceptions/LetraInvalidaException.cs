using System;

public class LetraInvalidaException: Exception{ //This exception will be raised if the character is invalid; Essa exeção vai ser usada caso a letra seja inválida

    public LetraInvalidaException(){

        Console.WriteLine("Error - A letra Digitada é inválida");
    }

    
}