using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] float minScale = .8f;
    [SerializeField] float maxScale = 1.2f;    
    [SerializeField] float rotaionOffset = 100f;
    Transform myT;
    Vector3 randomRotaion;
    
    void Awake() {
        myT = transform;
    }

    void Start() {

        // random size
        Vector3 scale = Vector3.one;
        scale.x = Random.Range(minScale, maxScale);
        scale.y = Random.Range(minScale, maxScale);
        scale.z = Random.Range(minScale, maxScale);
        myT.localScale = scale;

        // random rotation
        randomRotaion.x = Random.Range(-rotaionOffset, rotaionOffset);
        randomRotaion.y = Random.Range(-rotaionOffset, rotaionOffset);
        randomRotaion.z = Random.Range(-rotaionOffset, rotaionOffset);

    }
    void Update () {
        myT.Rotate(randomRotaion * Time.deltaTime);
    }

}
