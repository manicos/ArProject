using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*using System.Collections;*/

public class ClickManager : MonoBehaviour
{
    private const string Url = "http://google.com/";
    public TextMesh textMesh;

    private void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
                Debug.Log("Object Hit is " + hitInfo.collider.gameObject.name);
                int v = hitInfo.collider.gameObject.GetInstanceID();
                textMesh.text = "ID:" + v;

                if (v == -290)
                {
                    
                }

                if (v == -260)
                {
                    
                }
                //



            }
        }

    }

}