using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CignalizationArea : MonoBehaviour
{
    [SerializeField] private AudioSource _cignalizationAudio;
    [SerializeField] private Animator _cignalizationAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Thieve>(out Thieve thieve))
        {
            _cignalizationAudio.Play();
            _cignalizationAnimator.SetBool("isInHome", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent<Thieve>(out Thieve thieve))
        {
            _cignalizationAudio.Stop();
            _cignalizationAnimator.SetBool("isInHome", false);
        }
    }
}
