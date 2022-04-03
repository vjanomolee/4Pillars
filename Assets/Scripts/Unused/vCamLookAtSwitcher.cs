using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vCamLookAtSwitcher : MonoBehaviour
{
    Cinemachine.CinemachineVirtualCamera c_VirtualCamera;
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;
    [SerializeField] Transform target3;

    //public bool isLit1 = false;
    //public bool isLit2 = false;
    //public bool isLit3 = false;

    private void Awake()
    {
        c_VirtualCamera = GetComponent<Cinemachine.CinemachineVirtualCamera>();
        //LookAt1();
    }

    /*
    public void Update()
    {
        if (isLit1 == true)
        {
            LookAt1();
        }
        if(isLit2 == true)
        {
            LookAt2();
        }
        if (isLit3 == true)
        {
            LookAt3();
        }
    }
    */ 

    public void LookAt1()
    {
        c_VirtualCamera.m_LookAt = target1.transform;
        //c_VirtualCamera.m_Follow = target1.transform; ----> unComment this line if you want the camera to follow the target as well
    }
    public void LookAt2()
    {
        c_VirtualCamera.m_LookAt = target2.transform;
        //c_VirtualCamera.m_Follow = target2.transform; ----> unComment this line if you want the camera to follow the target as well
    }
    public void LookAt3()
    {
        c_VirtualCamera.m_LookAt = target3.transform;
        //c_VirtualCamera.m_Follow = target3.transform; ----> unComment this line if you want the camera to follow the target as well
    }


}
