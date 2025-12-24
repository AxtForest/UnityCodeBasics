using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryEx : MonoBehaviour
{
    public int health = 50;
    private string status;

    // Update is called once per frame
    void Update()
    {

        // TR:
        // Koşul? dogruifade : yanlıs ifade:
        // Ternary operator (?:), bir koşula bağlı olarak iki değerden birini tek satırda seçmek için kullanılır.
        // Karmaşık mantıklar için önerilmez, okunabilirliği düşürür.
        // Koşul true ise ilk değer, false ise ikinci değer döndürülür.
        // Değer döndürdüğü için genellikle değişken atamalarında kullanılır.
        // Basit koşullarda if-else yerine daha kısa ve okunabilir bir kullanım sağlar.

        //-------------------------------------------------------------------------------------------------------

        // EN:
        // Condition ? trueExpression : falseExpression
        // The ternary operator (?:) is used to select one of two values based on a condition in a single line.
        // If the condition is true, the first value is returned; otherwise, the second value is returned.
        // Since it returns a value, it is commonly used in variable assignments.
        // It provides a shorter and more readable alternative to if-else for simple conditions.
        // It is not recommended for complex logic as it reduces readability.


        ///---------------- With if-Else ----------------
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= 10;

            if (health > 0)
                status = "Live";
            else
                status = "Dead";


            Debug.Log(status);
        }


        ///---------------- With Ternary ----------------
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= 10;

            status = health > 0 ? "Live" : "Dead";

            Debug.Log(status);
        }


    }
   

    



}
