using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABCMaterialReplacer : MonoBehaviour
{
    public Material toonMaterial;

    void Start()
    {
        // 替换当前物体及其所有子物体的材质
        var renderers = GetComponentsInChildren<Renderer>();
        foreach (var renderer in renderers)
        {
            // 替换所有slot里的材质为toonMaterial
            Material[] newMats = new Material[renderer.sharedMaterials.Length];
            for (int i = 0; i < newMats.Length; i++)
            {
                newMats[i] = toonMaterial;
            }
            renderer.materials = newMats;
        }
    }
}