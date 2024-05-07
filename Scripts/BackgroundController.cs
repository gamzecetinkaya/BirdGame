using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private float offset = 0f;

    private void Update()
    {
        offset += Time.deltaTime * scrollSpeed;
        GetComponent<Camera>().transform.position = new Vector3(offset, 0, -10);
    }
}
