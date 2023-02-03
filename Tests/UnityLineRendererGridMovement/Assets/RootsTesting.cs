using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RootsTesting : MonoBehaviour
{
    public GameObject LineGo;

    private Vector3 position;

    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = LineGo.GetComponent<LineRenderer>();
        position = lineRenderer.GetPosition(lineRenderer.positionCount - 1);
    }

    // Update is called once per frame
    void Update()
    {
        //FourwayControl();
        EightwayControl();
    }


    private void FourwayControl()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            position.y--;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position.x--;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            position.x++;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            position.y++;

            UpdateLine();
        }
    }

    private void EightwayControl()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            position.x--;
            position.y++;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            position.y++;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            position.x++;
            position.y++;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            position.x--;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            position.x++;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            position.x--;
            position.y--;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            position.y--;

            UpdateLine();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            position.x++;
            position.y--;

            UpdateLine();
        }
    }


    private void UpdateLine()
    {
        Vector3[] lineVertices = new Vector3[lineRenderer.positionCount];

        lineRenderer.GetPositions(lineVertices);

        Vector3[] newlineVertices = new Vector3[lineRenderer.positionCount + 1];

        lineVertices.CopyTo(newlineVertices, 0);

        newlineVertices[newlineVertices.Length - 1] = position;

        lineRenderer.positionCount++;
        lineRenderer.SetPositions(newlineVertices);

        Debug.Log($"Down: {position}");
    }
}
