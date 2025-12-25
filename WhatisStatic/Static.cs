using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{
    // TR:
    // Static nedir?
    // Bir değişkenin veya metodun sınıfa ait olduğunu nesneye ait olmadığını belirtir
    // yani nesne oluşturmadan kullanılabilir bellekte tek kopya bulunur herkes onu paylaşır


    // EN:
    // Static means that a variable or method belongs to the class, not to an instance.
    // It can be used without creating an object.
    // Only one copy exists in memory and it is shared by everyone.

    //---------------------------------------------------------------------------------------------------



    // NE ZAMAN KULLANILIR
    // Global değişkenlerde (score, game state gibi) kullanılır.
    // Utility (yardımcı) sınıflarında tercih edilir.
    // Matematik ve hesaplama işlemlerinde kullanılır.


    // WHEN TO USE STATIC
    // Used for global variables (such as score or game state).
    //  Preferred in utility/helper classes.
    //  Used for math and calculation operations.


    // NOTES
    // TR: Static üyeler Inspector’da görünmez.
    // EN: Static members are not visible in the Inspector.

    // TR: Static metotlar 'this' anahtar kelimesini kullanamaz.
    // EN: Static methods cannot use the 'this' keyword.

    // TR: Static değişkenler sahne geçişlerinde değerini korur (persist eder).
    // EN: Static variables keep their value across scene changes (persist).



    //Example 

    public static int score;
    //GameManager.score = 10;






}
