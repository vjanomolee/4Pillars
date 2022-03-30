using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class PresentationManager : MonoBehaviour
{
    public CinemachineVirtualCamera currentCamera;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToWaypoint1 ()
    {
        var dolly = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        dolly.m_PathPosition = 1;
    }

    public void GoToWaypoint2()
    {
        var dolly = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        dolly.m_PathPosition = 2;
    }

    public void GoToWaypoint3()
    {
        var dolly = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        dolly.m_PathPosition = 3;
    }

    public void GoToWaypoint4()
    {
        var dolly = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        dolly.m_PathPosition = 4;
    }

}
