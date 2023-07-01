using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CursoQ1 : MonoBehaviour
{
   public VirtualButtonBehaviour vb;
   public GameObject MediaPlane;
   public GameObject cImage;
   public GameObject TextPlane;
    void Start()
    {
        
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
        MediaPlane.SetActive(false);
        cImage.SetActive(false);
        TextPlane.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        MediaPlane.SetActive(true);
        cImage.SetActive(true);
        TextPlane.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        MediaPlane.SetActive(false);
        cImage.SetActive(false);
        TextPlane.SetActive(false);
    }
    
}
