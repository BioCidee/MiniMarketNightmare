using System.Collections.Generic;
using UnityEngine;

public class Lockers : MonoBehaviour, I_Interactable
{
    [Header("---- Locker Parameters ----")]
    [SerializeField] private GameObject objectOnTop = null;
    [SerializeField] private Transform transformTopObject;

    [Header("---- Locker Hidden Parameters ----")]
    [SerializeField] private List<GameObject> objectCanSpawn = new List<GameObject>();


    public void OnInteract(GameObject _whoInteract)
    {
        //Vérifier si c'est le joueur.
        Player_Inventory playerInventory = _whoInteract.GetComponent<Player_Inventory>();
        if (playerInventory != null)
        {
            playerInventory.AddToInventory(objectOnTop, objectOnTop.name);

            Destroy(objectOnTop);
        }
        //Lui donner l'objet.
        //Effectué une action si besoins pour l'interaction ( animation, ect...)
        //Supprimer l'object du top.
    }

    private void SetObjectOnTop()
    {
        GameObject objectToSet;

        if (objectCanSpawn.Count == 0)
            Debug.LogError("There is no object that can spawn here !");

        objectOnTop = Instantiate(objectCanSpawn[Random.Range(0, objectCanSpawn.Count - 1)]);
        objectOnTop.transform.position = transformTopObject.position;
        objectOnTop.transform.rotation = transformTopObject.rotation;
    }
}
