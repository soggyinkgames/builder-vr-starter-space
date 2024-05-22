using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SvgToMeshScriptableObject", menuName = "ScriptableObjects/SvgToMesh")]
public class SvgToMeshScriptableObject : ScriptableObject
{
    public float depth = 0.1f;
    public GameObject myObject;

    public Vector3 currentPosition;
}
