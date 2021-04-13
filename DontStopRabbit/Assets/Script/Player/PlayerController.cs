using System.Collections;
using UnityEngine;

public enum TypeOfControl {NONE, FIRST, SECOND, THIRD, FOURTH}

public class PlayerController : MonoBehaviour
{
    [SerializeField] TypeOfControl typeOfControl = TypeOfControl.NONE;
    [SerializeField] float moveSpeed = 0;
    [SerializeField] Rigidbody2D rb2d = null;
    [SerializeField] Collider2D playerCollider = null;
    [SerializeField] SpriteRenderer playerSrite = null;
    [SerializeField] Color colorAfterHit = Color.white;
    Vector2 movement;
    Color basicColorPlayer;
    string vertical;
    string horizontal;

    private void Start()
    {
        basicColorPlayer = playerSrite.color;
        switch (typeOfControl)
        {
            case TypeOfControl.FIRST:
                vertical = "VerticalP1";
                horizontal = "HorizontalP1";
                return;
            case TypeOfControl.SECOND:
                vertical = "VerticalP2";
                horizontal = "HorizontalP2";
                return;
            case TypeOfControl.THIRD:
                vertical = "VerticalP3";
                horizontal = "HorizontalP3";
                return;
            case TypeOfControl.FOURTH:
                vertical = "VerticalP4";
                horizontal = "HorizontalP4";
                return;
            default:
                return;
        }
    }
    void Update()
    {
        movement.y = Input.GetAxisRaw(vertical);
        movement.x = Input.GetAxisRaw(horizontal);
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    public void RespawnAfterHit(Vector3 positionTorespawn)
    {
        StartCoroutine(Respawn(positionTorespawn));
    }
    IEnumerator Respawn(Vector3 positionTorespawn)
    {
        playerCollider.enabled = false;
        rb2d.transform.localPosition = positionTorespawn;
        playerSrite.color = colorAfterHit;
        yield return new WaitForSeconds(3f);
        playerSrite.color = basicColorPlayer;
        playerCollider.enabled = true;
    }
}
