﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [Range(2,256)]
    public int resolution = 10;
    public bool autoUpdate = true;
    public PlanetShapeSettings shapeSettings;
    public PlanetColorSettings colorSettings;

    [HideInInspector]
    public bool shapeSettingsFoldout;
    [HideInInspector]
    public bool colorSettingsFoldout;
    public PlanetShapeGenerator shapeGenerator;    

    [SerializeField,HideInInspector]
    MeshFilter[] meshFilters;
    TerrainFace[] terrainFaces;

    //  private void OnValidate() {
    //     GeneratePlanet();
    // }
    void Initialize()
    {
        if(!this.gameObject.GetComponent(typeof(Rigidbody)))
        {
            this.gameObject.AddComponent<Rigidbody>().mass = 1;
        }
        if(shapeSettings==null){
            Debug.Log("nullshapesettings...");
        }
        shapeGenerator = new PlanetShapeGenerator(shapeSettings);

        if(meshFilters == null || meshFilters.Length == 0)
        {
            meshFilters = new MeshFilter[6];
        }
        terrainFaces = new TerrainFace[6];

        Vector3[] directions = {Vector3.up, Vector3.down, Vector3.left, Vector3.right, Vector3.forward, Vector3.back};

        for (int i = 0; i < 6; i++)
        {
             if(meshFilters[i] == null)
            {
                GameObject meshObj= new GameObject("mesh");
                meshObj.transform.parent = transform;

                meshObj.AddComponent<MeshRenderer>().sharedMaterial = new Material(Shader.Find("Standard"));
                meshObj.AddComponent<MeshCollider>().convex = true;
                MeshCollider meshCollider = meshObj.GetComponent(typeof(MeshCollider)) as  MeshCollider;
                
                meshFilters[i] = meshObj.AddComponent<MeshFilter>();
                meshFilters[i].sharedMesh = new Mesh();

                meshCollider.sharedMesh  = meshFilters[i].mesh;
                meshCollider.material = shapeSettings.material;
            }

            terrainFaces[i] = new TerrainFace(shapeGenerator, meshFilters[i].sharedMesh, resolution, directions[i]);
        }
    }   

    public void GeneratePlanet()
    {
        Initialize();
        GenerateMesh();
        GenerateColors();
    }

    public void OnShapeSettingsUpdated()
    {
        if(autoUpdate)
        {        
            Initialize();
            GenerateMesh();
        }
    }

    public void OnColorSettingsUpdated()
    {
        if(autoUpdate)
        {
            Initialize();
            GenerateColors();
        }
    }

    void GenerateMesh()
    {
        foreach (TerrainFace face in terrainFaces)
        {
            face.ConstructMesh(shapeSettings.material);
        }
    }

    void GenerateColors()
    {
        foreach (MeshFilter m in meshFilters)
        {
            m.GetComponent<MeshRenderer>().sharedMaterial.color = colorSettings.planetColor;
        }
    }
}
