using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMaganer : MonoBehaviour
{

    public TextMesh texto;
    public GameObject Cuadro;

    // Start is called before the first frame update
    void Start()
    {
        Cuadro.SetActive(false);
        texto.text = "";
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {

                Debug.Log("El objeto tocado es: " + hitInfo.collider.gameObject.name);

                int v = hitInfo.collider.gameObject.GetInstanceID();

                texto.text = "El identificador del elemento es:" + v;
                Cuadro.SetActive(true);

                if (hitInfo.collider.gameObject.name == "Plane")
                {
                    Application.OpenURL("http://www.modelo.edu.mx");
                }

                if (v == -260)
                {

                }

            }
        }

    }
}
