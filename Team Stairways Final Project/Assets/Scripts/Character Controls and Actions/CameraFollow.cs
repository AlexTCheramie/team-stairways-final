using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTarget;
    public float smoothing = 5;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - followTarget.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 targetCamPos = followTarget.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
