using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Tile State")]


//ScriptableObject sýnýfýndan miras aldýk çünkü her tile için ayný ayarlarý tekrar tekrar yazmak yerine,
//bir kere oluþturup birçok yerde kullanabiliriz.

//ScriptableObject, Unity'de proje içinde birden fazla yerde kullanýlabilecek verileri
//saklamak için kullanýlan özel bir sýnýftýr.


public class TileState : ScriptableObject
{
    public Color backgroundColor;
    public Color textColor;



}
