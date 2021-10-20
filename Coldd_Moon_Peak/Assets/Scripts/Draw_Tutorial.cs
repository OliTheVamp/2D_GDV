using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw_Tutorial : MonoBehaviour
{

    public Camera m_camera;
    public GameObject brush;

    LineRenderer currentLineRender;

    Vector2 lastPos;

    private void Update()
    {
        Draw();
    }
    void Draw()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
        }
        if(Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            if(mousePos != lastPos)
            {
                AddAPoint(mousePos);
                lastPos = mousePos;
            }
        }
        else
        {
            currentLineRender = null;
        }
    }
    void CreateBrush()
    {
        GameObject brushInstance = Instantiate(brush);
        currentLineRender = brushInstance.GetComponent<LineRenderer>();

        Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);

        currentLineRender.SetPosition(0, mousePos);
        currentLineRender.SetPosition(1, mousePos);

    }

    void AddAPoint(Vector2 pointPos)
    {
        currentLineRender.positionCount++;
        int positionIndex = currentLineRender.positionCount - 1;
        currentLineRender.SetPosition(positionIndex, pointPos);
    }
}
