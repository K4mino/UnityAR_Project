using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ModelSpawner : MonoBehaviour
{
    public GameObject model1Prefab;
    public GameObject model2Prefab;
    public ARPlacementInteractable placementInteractable;

    // Method to set Model 1 as the prefab to spawn
    public void SetModel1()
    {
        placementInteractable.placementPrefab = model1Prefab;
    }

    // Method to set Model 2 as the prefab to spawn
    public void SetModel2()
    {
        placementInteractable.placementPrefab = model2Prefab;
    }
}
