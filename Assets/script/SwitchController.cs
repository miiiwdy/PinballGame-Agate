using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public ManagerAudio audioManager;
    public VFXManager VFXManager;

    private SwitchState state;
    private Renderer renderer;
    private static List<SwitchController> blinkingSwitches = new List<SwitchController>(); // Store active blinking switches

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        Set(false);
        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
            audioManager.PlaySwitchSFX(other.transform.position);
            VFXManager.PlaySwitchVFX(other.transform.position);
        }
    }

    private void Set(bool active)
    {
        if (active)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            if (!blinkingSwitches.Contains(this))
            {
                blinkingSwitches.Add(this);
            }
        }
    }

    private void Toggle()
    {
        if (state == SwitchState.On)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        if (blinkingSwitches.Contains(this))
        {
            blinkingSwitches.Remove(this);
        }

        if (blinkingSwitches.Count == 0)
        {
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
