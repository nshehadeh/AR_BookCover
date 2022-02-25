using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VButton : MonoBehaviour
{
    public GameObject review;
    public GameObject back;
    public VirtualButtonBehaviour VB;
    bool active = true;
    // Start is called before the first frame update
    void Start()
    {
        VB.RegisterOnButtonPressed(OnButtonPressed);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb){
        review.SetActive(active);
        back.SetActive(!active);
        active = !active;
	Debug.Log("switch");
    }
}
