using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed = 2f;
    public GameObject Munition;
    public float CameraAxisX = 0;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        if (Input.GetKey(KeyCode.W))
        {
             MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
             MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
             MovePlayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
             MovePlayer(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
             Shoot();
        }
    }

    private void MovePlayer (Vector3 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
    
    private void Shoot() {
          Debug.Log("DISPARAR");
         Instantiate(Munition, transform.position, Munition.transform.rotation);
    }

    public void RotatePlayer()
    {
        CameraAxisX += Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(0, CameraAxisX, 0);
       // Quaternion newRotation = Quaternion.Euler(0, CameraAxisX, 0);
       // transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 10f * Time.deltaTime);
    }
   
}
