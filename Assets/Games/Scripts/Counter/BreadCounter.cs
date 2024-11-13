using UnityEngine;

public class BreadCounter : MonoBehaviour, I_InteractableObject
{
    private SO_Object objectOnTop;
    [SerializeField] private Transform posObject; 

    public void OnInteract() {
        
    }
    public string GiveTypeOfObjectOnType() { 
        return objectOnTop.objectName;
    }
    public void SetObjectOnTop(SO_Object newObject) {
        if (objectOnTop == null && objectOnTop != newObject) {
            objectOnTop = newObject;
        }
    }
    public void ChangeObjectOnTop(SO_Object newObject) {
        if(objectOnTop != newObject) {
            objectOnTop = newObject;
        }
    }
    public void DeleteObjectOnTop() {
        objectOnTop = null; 
    }

    private void SetObjectParameters() {

    }
}
