using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ekranhesaplayicisi
{
    static float sol;
    static float sag;
    static float ust;
    static float alt;

    public static float Sol
    {
        get
        {
            return sol;

        }
    }
    public static float Sag
{
        get
        {
            return sag;

        }
    }
    public static float Ust
    {
        get
        {
            return ust;

        }
    }
    public static float Alt
    {
        get
        {
            return alt;

        }
    }

    public static void Init()
    {
        float ekranZekseni=-Camera.main.transform.position.z;
        Vector3 solalt = new Vector3(0,0,ekranZekseni);
        Vector3 sagust = new Vector3(Screen.width,Screen.height,ekranZekseni);
        Vector3 solaltoyun=Camera.main.ScreenToWorldPoint(solalt);
        Vector3 sagustoyun=Camera.main.ScreenToWorldPoint(sagust);

        sol = solaltoyun.x;
        sag = sagustoyun.x;
        ust = sagustoyun.y;
        alt = solaltoyun.y;          
    }
}
