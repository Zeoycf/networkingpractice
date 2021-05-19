using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Inventory", menuName = "Inventory/List")]
public class ListScriptable : ScriptableObject
{
    public List<ScriptableItem> itemList = new List<ScriptableItem>();
}
