using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Фонарик : MonoBehaviour
{
    [SerializeField] Light _flashlight;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _flashlight.enabled = !_flashlight.enabled;
        }
    }
}
