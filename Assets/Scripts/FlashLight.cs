using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] private Light _light;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _light.enabled = !_light.enabled;
        }
    }
}
