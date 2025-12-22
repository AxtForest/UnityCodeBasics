using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth 
{

    //It is used to control access to private fields within a class.
    //Sınıfın içindeki private alanlara erişimi kontrol etmek için kullanılır.
    private int health;



    //Property
    public int Health 
    { 
        get //Value Return
        {
            return health;
        }
        set //Value Set
        {
            health = Mathf.Clamp(value, 0, 100);
        }
    }
}
