using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRow : MonoBehaviour
{
    //Bir sýradaki tüm hücreleri tutar
    public TileCell[] cells {  get; private set; }


    //Bu GameObject'in altýndaki (child) tüm TileCell bileþenlerini bulur ve diziye atar
   // Yani bir sýradaki tüm hücreleri otomatik olarak tespit eder

    private void Awake()
    {
        cells = GetComponentsInChildren<TileCell>();
    }

}
