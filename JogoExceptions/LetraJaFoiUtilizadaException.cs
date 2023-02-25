using System;


public class LetraJaFoiUtilizadaException:Exception{ //Will be raised case the letter it's been already used; Vai ser chamada caso a letra já tenha sido utilizada

    public LetraJaFoiUtilizadaException():base("Error! A letra ja foi utilizada"){}
    
}