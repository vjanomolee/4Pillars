using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VcamSwitcher : MonoBehaviour
{
   
    [SerializeField] private CinemachineVirtualCamera _startCam, _vCam1, _vCam2, _vCam3, _vCam4;
    // [SerializeField] private CinemachineVirtualCamera [];
    // <-----need to make this into a public array for adding as many cams as you want
    public GameObject startButton, button1, button2, button3, button4;

    public void StartTheDemo ()
    {
        _startCam.Priority = 0;
        _vCam1.Priority = 10;
        _vCam4.Priority = 0;
        _vCam3.Priority = 0;
        _vCam2.Priority = 0;
        startButton.SetActive(false);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
    }
    public void SetPriorityToVcam1 ()
    {
        _vCam4.Priority = 0;
        _vCam3.Priority = 0;
        _vCam2.Priority = 0;
        _vCam1.Priority = 10;
    }
    public void SetPriorityToVcam2()
    {
        _vCam4.Priority = 0;
        _vCam3.Priority = 0;
        _vCam2.Priority = 10;
        _vCam1.Priority = 0;
    }
    public void SetPriorityToVcam3()
    {
        _vCam4.Priority = 0;
        _vCam3.Priority = 10;
        _vCam2.Priority = 0;
        _vCam1.Priority = 0;
    }

    public void SetPriorityToVcam4()
    {
        _vCam4.Priority = 10;
        _vCam3.Priority = 0;
        _vCam2.Priority = 0;
        _vCam1.Priority = 0;
    }

}
