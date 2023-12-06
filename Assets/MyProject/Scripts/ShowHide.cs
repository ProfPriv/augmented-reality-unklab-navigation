using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{

    public GameObject Teks;

    public void OpenTeks()
    {
        if (Teks != null)
        {
            bool isActive = Teks.activeSelf;

            Teks.SetActive(!isActive);
        }
    }

}
