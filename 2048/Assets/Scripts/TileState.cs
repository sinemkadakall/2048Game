using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Tile State")]


//ScriptableObject s�n�f�ndan miras ald�k ��nk� her tile i�in ayn� ayarlar� tekrar tekrar yazmak yerine,
//bir kere olu�turup bir�ok yerde kullanabiliriz.

//ScriptableObject, Unity'de proje i�inde birden fazla yerde kullan�labilecek verileri
//saklamak i�in kullan�lan �zel bir s�n�ft�r.


public class TileState : ScriptableObject
{
    public Color backgroundColor;
    public Color textColor;



}
