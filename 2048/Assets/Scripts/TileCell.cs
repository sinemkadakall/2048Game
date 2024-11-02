using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCell : MonoBehaviour
{

    //H�crenin grid �zerindeki konumunu tutar
    //Vector2Int kullan�lmas�n�n nedeni tam say� koordinatlar� tutmak i�indir(x, y)
    //�rne�in(2,3) gibi bir konumu temsil eder
    public Vector2Int coordinates {  get; set; }

    public Tile tile { get;  set; }

    //H�crenin bo� olup olmad���n� kontrol eder
    public bool empty => tile == null;

    //H�crenin dolu olup olmad���n� kontrol eder
    public bool occupied => tile != null;


}
