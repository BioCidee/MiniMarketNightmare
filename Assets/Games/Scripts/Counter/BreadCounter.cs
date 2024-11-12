using UnityEngine;

public class BreadCounter : MonoBehaviour, I_InteractableObject
{
    private SO_Object objectOnTop;

    public void OnInteract() {
        
    }
    public string GiveTypeOfObjectOnType() { 
        return objectOnTop.objectName;
    }
    public void SetObjectOnTop(SO_Object newObject) {
        if (objectOnTop != newObject) {
            objectOnTop = newObject;
        }
    }
    public void ChangeObjectOnTop() {
    
    }
    public void DeleteObjectOnTop() {
    
    }
}
