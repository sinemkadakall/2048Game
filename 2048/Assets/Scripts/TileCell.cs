using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCell : MonoBehaviour
{

    //Hücrenin grid üzerindeki konumunu tutar
    //Vector2Int kullanýlmasýnýn nedeni tam sayý koordinatlarý tutmak içindir(x, y)
    //Örneðin(2,3) gibi bir konumu temsil eder
    public Vector2Int coordinates {  get; set; }

    public Tile tile { get;  set; }

    //Hücrenin boþ olup olmadýðýný kontrol eder
    public bool empty => tile == null;

    //Hücrenin dolu olup olmadýðýný kontrol eder
    public bool occupied => tile != null;


}
