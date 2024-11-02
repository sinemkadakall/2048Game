using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRow : MonoBehaviour
{
    //Bir s�radaki t�m h�creleri tutar
    public TileCell[] cells {  get; private set; }


    //Bu GameObject'in alt�ndaki (child) t�m TileCell bile�enlerini bulur ve diziye atar
   // Yani bir s�radaki t�m h�creleri otomatik olarak tespit eder

    private void Awake()
    {
        cells = GetComponentsInChildren<TileCell>();
    }

}
