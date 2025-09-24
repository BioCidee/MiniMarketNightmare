using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    [Header("---- FlashLight Parameters ----")]
    [SerializeField] private bool isLightOn = false;
    [SerializeField] private float lightPower;
    [SerializeField] private Light light;

    [Header("---- Batterie Parameters ----")]
    [SerializeField] private float batteryLife;
    [SerializeField] private float batteryLoss;
    [SerializeField] private float maxBattery;

    [Header("---- UI ----")]
    [SerializeField] private Slider batterySlider;

    void Awake()
    {
        isLightOn = false;
        WhenLightStateChange();
        batterySlider.maxValue = maxBattery;
        batterySlider.value = batteryLife;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            WhenLightStateChange();
        }


        BatterySystem();
    }

    private void WhenLightStateChange()
    {
        isLightOn = !isLightOn;

        if (isLightOn)
        {
            light.intensity = 1;
        }
        else
        {
            light.intensity = 0;
            
        }

    }

    private void BatterySystem()
    {
        if (isLightOn)
        {
            if (batteryLife <= 0)
            {
                WhenLightStateChange();
            }
            else
            {
                batteryLife -= batteryLoss * Time.deltaTime;
            }
        }
        else
        {
            if (batteryLife >= maxBattery)
            {
                return;
            }
            else
            {
                batteryLife += Time.deltaTime;
            }
        }

        batterySlider.value = batteryLife;
   }
}
