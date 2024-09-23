using UnityEngine;

public class MyObject
{
    public static void ChangeActive(GameObject obj) => obj.SetActive(!obj.activeSelf);

    public static void ChangeActive(GameObject[] Mobj)
    {
        for (var i = 0; i < Mobj.Length; i++) ChangeActive(Mobj[i]);
    }
}