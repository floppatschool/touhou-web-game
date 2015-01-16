using UnityEngine;
using System.Collections;

namespace Pixelnest.BulletML.Demo
{
    public class AyaTest : MonoBehaviour
    {
        protected Animator PlayerAnimationStatus; //机体动画
        public float speed = 30f;
        public float maxSpeed = 10f;

        public GameObject projectilePrefab;

        private Vector2 movement;
        private int damageTaken;
        private DemoFightScript demo;

        void Awake()
        {
            PlayerAnimationStatus = this.GetComponent<Animator>(); //获取机体移动动画
            damageTaken = 0;
            demo = FindObjectOfType<DemoFightScript>();
        }

        void Update()
        {
            float inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");
            movement = new Vector2(
              inputX * speed,
              inputY * speed
            );
            if (inputX > 0) {
                PlayerAnimationStatus.SetBool("Right",true);
            }
            else if (inputX < 0)
            {
                PlayerAnimationStatus.SetBool("Left", true);
            }
            else {
                PlayerAnimationStatus.SetBool("Left", false);
                PlayerAnimationStatus.SetBool("Right", false);
            }
            movement = new Vector2(
              Mathf.Clamp(movement.x, -maxSpeed, maxSpeed),
              Mathf.Clamp(movement.y, -maxSpeed, maxSpeed)
            );

            bool shoot = Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire3");
            if (Input.GetButton("Bomb"))
            {
                PlayerAnimationStatus.SetBool("Bomb", true);
            }
            else {
                PlayerAnimationStatus.SetBool("Bomb", false);
            }
            if (Input.GetButton("Shoot"))
            {
                // Create a new projectile
                Shoot();
            }
        }

        void FixedUpdate()
        {
            rigidbody2D.velocity = movement;
        }

        void OnTriggerEnter2D(Collider2D otherCollider)
        {
            // Collision with projectile
            BulletScript bullet = otherCollider.GetComponent<BulletScript>();

            if (bullet != null)
            {
                damageTaken++;

                // Flash red
                StartCoroutine(FlashRed());

                Destroy(bullet.gameObject);
            }
        }

        void OnGUI()
        {
            if (demo.showGUI)
            {
                GUI.Label(new Rect(5, 5, 150, 50), "Player damages: " + damageTaken);
            }
        }

        private void Shoot()
        {
            GameObject shot = Instantiate(projectilePrefab) as GameObject;
            shot.transform.position = this.transform.position;

            DemoPlayerShotScript shotScript = shot.GetComponent<DemoPlayerShotScript>();
            shotScript.speed = new Vector2(0, 20);
        }

        private IEnumerator FlashRed()
        {
            SpriteRenderer sprite = GetComponentInChildren<SpriteRenderer>();

            sprite.color = Color.red;

            yield return new WaitForSeconds(0.05f);

            sprite.color = Color.white;

            yield return null;
        }
    }
}
