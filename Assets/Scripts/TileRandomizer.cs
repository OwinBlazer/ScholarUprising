using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRandomizer : MonoBehaviour
{

    public Sprite[] tiles;

    private int idx;


    void Start()
    {
        idx = (int)Random.Range(0,4.999f);
        this.GetComponent<SpriteRenderer>().sprite = tiles[idx];
    }


}