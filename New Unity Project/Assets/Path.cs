using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{

    public Color lineColor;

    private List<Transform> node = new List<Transform>();

    private void OnDrawGizmos()
    {
        Gizmos.color = lineColor;

        Transform[] pathTransforms = GetComponentInChildren<Transform[]>();
        node = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++)
        {
            if (pathTransforms[i] != transform)
            {
                node.Add(pathTransforms[i]);
            }
        }
    }

}
