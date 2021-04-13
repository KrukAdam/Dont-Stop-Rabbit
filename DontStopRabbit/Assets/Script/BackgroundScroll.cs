using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] GameObject backgroundPrefab = null;
    [SerializeField] float speedSroll = 1;
    [SerializeField] Rigidbody2D rb2d = null;

    Vector2 movement;
    bool addNewGrass = false;

    private void Start()
    {
        movement.x = -1;
    }
    private void Update()
    {
        if (transform.position.x < 0 && !addNewGrass)
        {
            Instantiate(backgroundPrefab, new Vector3(18.5f, 0f, 0f), Quaternion.identity);
            addNewGrass = true;
        }
        if(transform.position.x < -18.51)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * speedSroll * Time.fixedDeltaTime);
    }
}
