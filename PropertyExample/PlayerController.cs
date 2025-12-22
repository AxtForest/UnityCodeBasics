using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerHealth playerhealth;
    void Start()
    {
        playerhealth = new PlayerHealth();

        //Health property’sinin set bloğunu çağırarak değeri kontrollü şekilde 30 yapar.
        //Calls the set the Health property to assign 30 in a controlled way.
        playerhealth.Health = 30; 
    }

    
}
