using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkRoomTrigger : MonoBehaviour
{

    [SerializeField] private Material defaultSkybox;
    [SerializeField] private Material darkSkybox;
    void Start()
    {
        RenderSettings.skybox = defaultSkybox;
        RenderSettings.fogMode = FogMode.ExponentialSquared;
        RenderSettings.fogColor = Color.black;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RenderSettings.skybox = darkSkybox;
            RenderSettings.sun.enabled = false;
            RenderSettings.ambientIntensity = 0f;
            RenderSettings.fog = true;
            RenderSettings.fogDensity = 0.15f;
            DynamicGI.UpdateEnvironment();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RenderSettings.skybox = defaultSkybox;
            RenderSettings.sun.enabled = true;
            RenderSettings.ambientIntensity = 1.5f;
            RenderSettings.fog = false;
            RenderSettings.fogDensity = 0;
            DynamicGI.UpdateEnvironment();
        }
    }
}
