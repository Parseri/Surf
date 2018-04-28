using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfPartSpecs {

}

public class SurfController : MonoBehaviour {
    public GameObject surfPartPrefab;
	private List<GameObject> surfPlanes;
    void Start() {
        GenerateSurfPart();
    }

    void Update() {

    }

    private void GenerateSurfPart(SurfPartSpecs specs = null) {
        if (specs == null) {

            surfPlanes.Add(Instantiate(surfPartPrefab, new Vector3(0, 0, 0), Quaternion.identity));
        }
    }
