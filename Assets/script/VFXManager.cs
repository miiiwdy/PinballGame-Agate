using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject VFXbumper;
    public GameObject VFXswitch;

	// Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayBumperVFX(Vector3 spawnPosition)
	{
		GameObject.Instantiate(VFXbumper, spawnPosition, Quaternion.identity);
	}
    public void PlaySwitchVFX(Vector3 spawnPosition)
	{
		GameObject.Instantiate(VFXswitch, spawnPosition, Quaternion.identity);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
