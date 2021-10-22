using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    public float speed;
    
    private Animator _animator;

    private float gripTarget;
    private float gripCurrent;
    private float triggerTargert;
    private float triggerCurrent;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         AnimateHand();
    }

    public void SetGrip(float readValue)
    {
        gripTarget = readValue;
    }

    public void SetTrigger(float readValue)
    {
        triggerTargert = readValue;
    }

    void AnimateHand()
    {
        if (gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            _animator.SetFloat("Grip",gripCurrent);
        }

        if (triggerCurrent != triggerTargert)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTargert, Time.deltaTime * speed);
            _animator.SetFloat("Trigger",triggerCurrent);
        }
        
    }
}
