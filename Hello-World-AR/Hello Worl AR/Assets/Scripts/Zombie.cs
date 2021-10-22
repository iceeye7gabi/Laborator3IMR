using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform enemy;
    public float timeBetweenAttack;

    private float _time;
    private Animator _anim;
    
    void Start()
    {
        _time = Time.time;
        _anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, enemy.position) < 3)
        {
            if (_time + timeBetweenAttack < Time.time)
            {
                _anim.SetTrigger("Attack");
            }
        }
    }
     
}
