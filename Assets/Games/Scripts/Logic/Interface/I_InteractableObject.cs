using UnityEngine;

public interface I_InteractableObject 
{
    public void OnInteract() { }
    public void GiveTypeOfObjectOnType() { }
    public void SetObjectOnTop(SO_Object newObject) { }
    public void ChangeObjectOnTop() { }
    public void DeleteObjectOnTop() {  }
}
