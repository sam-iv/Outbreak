using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flashlight : MonoBehaviour
{
    public GameObject darkness;
    public int battery = 100;
    public TMP_Text batteryLabel;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("updateFlashlight", 1.5F, 1.5F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateFlashlight()
    {
        battery -= 10;
        if (battery <= 0)
        {
            battery = 0;
            darkness.SetActive(true);
        }
        batteryLabel.text = battery.ToString() + "%";
    }
}
