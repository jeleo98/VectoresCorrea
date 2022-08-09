using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    [Range(1f,10f)] 
    private float Speed = 2f;

    
    enum ZombieTypes  {Observer, Follower};
    [SerializeField] ZombieTypes ZombieType;
    [SerializeField] Transform PlayerTransform;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void ChasePlayer()
    {
        LookPlayer();
        Vector3 direction = (PlayerTransform.position - transform.position);
        if (direction.magnitude > 2)
        {
            transform.position += (direction.normalized * Speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (ZombieType)
        {
            case ZombieTypes.Observer:
                Debug.Log(name + "->TIPO CRAWLER");
                SmoothLookPlayer();
                break;
            case ZombieTypes.Follower:
                Debug.Log(name + "->TIPO STALKER");
                ChasePlayer();
                break;
        }
    }
   

    void LookPlayer()
    {
        transform.LookAt(PlayerTransform); 
    }

    void SmoothLookPlayer()
        
    {
        Quaternion newRotation = Quaternion.LookRotation((PlayerTransform.position - transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2f * Time.deltaTime);
    }

}
