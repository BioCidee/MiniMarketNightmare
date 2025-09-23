using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Flashlight : MonoBehaviour
{
    [Header("---- FlashLight Parameters ----")]
    [SerializeField] private bool isLightOn = false;
    [SerializeField] private float lightPower;
    [SerializeField] private Light light;

    void Awake()
    {
        isLightOn = false;
        WhenLightStateChange();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            isLightOn = !isLightOn;
            WhenLightStateChange();
        }
    }

    private void WhenLightStateChange()
    {
        if (isLightOn)
        {
            light.intensity = 1;
        }
        else
        {
            light.intensity = 0;
        }
        
   }
}
