using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChanger : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _vCam1, _vCam2, _vCam3, _vCam4;
    // [SerializeField] private CinemachineVirtualCamera []; <-----need to make this into a public array for adding as many cams as you want

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
