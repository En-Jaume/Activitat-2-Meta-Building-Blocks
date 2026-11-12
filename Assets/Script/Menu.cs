using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject popUp;
    public void MostrarPopUp()
    {
        popUp.SetActive(true);
    }
    public void OcultarPopUp()
    {
        popUp.SetActive(false);
    }
}
