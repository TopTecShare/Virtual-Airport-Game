using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCamera : MonoBehaviour
{
    Transform m_cam;
    // Start is called before the first frame update
    void Start()
    {
        m_cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(m_cam);
    }
}
