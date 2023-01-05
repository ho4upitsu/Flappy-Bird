using TMPro;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] public Rigidbody2D Rigidbody2D;
    [SerializeField] public float speed;
    [SerializeField] public float force;

    public RestartGame rg;
    private float velocity = 1;
    private bool _pause;
    void Start()
    {
        Rigidbody2D.velocity = Vector2.up * velocity;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D.AddForce(Vector2.up * force);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("ScoreCollider"))
        {
            rg.GameOver();
        }
    }
}
