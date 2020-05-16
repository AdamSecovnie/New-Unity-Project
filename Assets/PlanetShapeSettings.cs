using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class PlanetShapeSettings : ScriptableObject {
        public float planetRadius = 1;
        public NoiseSettings noiseSettings;
        public NoiseLayer[] noiseLayers;
        public PhysicMaterial material;
        [System.Serializable]        public class NoiseLayer
        {
                public bool enabled = true;
                public NoiseSettings noiseSettings;
        }
}
