using System.Collections.Generic;
using UnityEngine;

public class Player_Inventory : MonoBehaviour
{
    private static Dictionary<string, GameObject> playerInventory = new Dictionary<string, GameObject>();

    public bool IsPlayerHaveThis(GameObject _object)
    {
        if (playerInventory.ContainsValue(_object))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AddToInventory(GameObject _object, string _nameObject)
    {
        playerInventory.Add(_nameObject, _object);
    }

    public void RemoveFromInventory(string _nameObject)
    {
        playerInventory.Remove(_nameObject);
    }
}
