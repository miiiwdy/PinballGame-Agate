using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
  public Collider bola;
  public Color colorA;
  public Color colorB;
  public KeyCode input;

  public float maxTimeHold;
  public float maxForce;

  private Renderer renderer;
  private bool isHold;

  private void Start()
  {
    isHold = false;
    renderer = GetComponent<Renderer>();
    renderer.material.color = colorB;
  }

  private void OnCollisionStay(Collision collision)
  {
    if (collision.collider == bola)
    {
      ReadInput(bola);
    }
  }

  private void ReadInput(Collider collider)
  {
    if (Input.GetKey(input) && !isHold)
    {
      StartCoroutine(StartHold(collider));
        renderer = GetComponent<Renderer>();
        renderer.material.color = colorA;
    }
  }

  private IEnumerator StartHold(Collider collider)
  {
    isHold = true;

    float force = 0.0f;
    float timeHold = 0.0f;

    while (Input.GetKey(input))
    {
      force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);
      yield return new WaitForEndOfFrame();
      timeHold += Time.deltaTime;
  
    }

    /*collider.GetComponent<Rigidbody>();
    AddForce(Vector3.forward * force);*/
    Rigidbody rb = collider.GetComponent<Rigidbody>();
    rb.AddForce(Vector3.forward * force);
    isHold = false;
    renderer = GetComponent<Renderer>();
    renderer.material.color = colorB;
  }
}