using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckThiefe : MonoBehaviour
{
    [SerializeField] private AudioSource _cignalizationAudio;
    [SerializeField] private Animator _cignalizationAnimator;

    private void OnTriggerEnter(Collider other)
    {
        _cignalizationAudio.Play();
        _cignalizationAnimator.SetBool("isInHome", true);
    }

    private void OnTriggerExit(Collider other)
    {
        _cignalizationAudio.Stop();
        _cignalizationAnimator.SetBool("isInHome", false);
    }
}
