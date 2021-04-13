using UnityEngine;

public class ObjectsController : MonoBehaviour
{
    [SerializeField] float minimumSpeed = 4;
    [SerializeField] float maximumSpeed = 4;
    [SerializeField] Rigidbody2D rb2d = null;
    float speed;
    Vector2 movement;
    [SerializeField] SpriteRenderer lookToChanged = null;
    [SerializeField] Sprite[] lookList = null;

    private void Start()
    {
        movement.x = -1;
        speed = Random.Range(minimumSpeed, maximumSpeed);
        lookToChanged.sprite = lookList[Random.Range(0, lookList.Length)];
    }
    private void Update()
    {
        if (transform.position.x < -18.51)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);
    }
}
