using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomoutController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.GoBackToDefault();
        }
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
