using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float movementSpeed = 50f;  
    [SerializeField] float trunSpeed = 60f; 
    Transform myT;

    void Awake() {
        myT = transform;
    }

    void Update() {
        Turn();
        Thrust();
    }

    void Turn() {
        float yaw = trunSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = trunSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = trunSpeed * Time.deltaTime * Input.GetAxis("Roll");

        myT.Rotate(-pitch, yaw , -roll);
    }
    void Thrust(){
        if(Input.GetAxis("Vertical") > 0 )
            myT.position += myT.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");    
    }

}
