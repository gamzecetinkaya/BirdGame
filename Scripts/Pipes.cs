
using UnityEngine;

public class Pipes : MonoBehaviour
{

    public float Speed = 1f;
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -3;
    }
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
        if(transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
