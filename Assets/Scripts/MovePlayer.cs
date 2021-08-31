using System.Collections;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    [SerializeField] float jumpForce = 3f;
    bool isGrounded = false;
    float speed = 0.02f;

    public Rigidbody2D rb;
    public Vector3 vectorMovement;
    public GameObject PrefHero;
    public static MovePlayer PortalMovePlayer;

    private void Awake()
    {
        PortalMovePlayer = this;
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    private void Run()
    {
        transform.position = transform.position + vectorMovement;
    }
    private void Update()
    {
        
        
        if (transform.position.y < -9)
        {
            HeroAnimation.HeroAnimationPortal.Death();
            // Сделать анимацию затемнения экрана
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            vectorMovement = new Vector3(0, 0, 0);
            SceneManager.Portal.CloseInterfacesAll();
            SceneManager.Portal.ActiveateScene("Lose");
        }
    }
    private void FixedUpdate()
    {
        Run();
        CheckGround();
    }

    public void StartRun()
    {
        UnderManager.UnderChange.under = true;
        UnderManager.UnderChange.Change();


        vectorMovement = new Vector3(speed, 0, 0);
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public void Jump()
    {
        if ((isGrounded) && (Input.touchCount == 1))
        {
            HeroAnimation.HeroAnimationPortal.Jump();
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }


    public void ReTurn()
    {
        speed = -speed;
        PrefHero.transform.Rotate(0, 180, 0);
        vectorMovement = new Vector3(speed, 0, 0);
    }

    public void Atk()
    {
        HeroAnimation.HeroAnimationPortal.Hit(); // Удар по нажатиям
    }
    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.05f);
        isGrounded = collider.Length > 1;
    }

    public void BtnPause()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        vectorMovement = new Vector3(0, 0, 0);
        SceneManager.Portal.CloseInterfacesAll();
        SceneManager.Portal.ActiveateScene("Pause");
    }
}