using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Scriptable Objects/Item Info", fileName = "New Item Info")] 
public class itemInfo : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
}
