using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(BoxCollider2D))]
//[RequireComponent(typeof(Rigidbody2D))]
//东方系列弹幕基类
public class BulletBase_Touhou : MonoBehaviour 
{
    /// <summary>
    /// 擦弹记录
    /// </summary>
    public bool Grazed { get; set; }

    public float Power = 1;//子弹威力
    //public ShooterBase ownerShooter;//发出子弹的发射器
    public Vector2 speed = Vector2.zero;//子弹速度
    protected bool isOutDestroy = true;//打出屏幕是否销毁
    public GameObject vanishEffect;//消失特效

    protected void Update()
    {
        if (isOutDestroy) {
            // Destroy when outside the screen
            if (renderer != null && renderer.isVisible == false)
            {
                Destroy(this.gameObject);
            }
        }
    }

    /// <summary>
    /// 播放消失特效
    /// </summary>
    public void ShowVanishEffect() {
        if (vanishEffect != null) {
            GameObject effect = Instantiate(vanishEffect) as GameObject;
            effect.transform.parent = this.transform.parent;
            effect.transform.localScale = Vector3.one;
            effect.transform.position = transform.position;
        }
    }

    void OnTriggerEnter2D(Collider2D otherCollider) {
        //设置是否被擦弹过
        GrazeCenter gc = otherCollider.GetComponent<GrazeCenter>();
        if (gc != null && renderer.sortingLayerName == "EnemyBullet")
        {
            Grazed = true;
            MyPlane.GetInstance().InitGrazeItem();
        }
        PlaneBase plane = otherCollider.gameObject.GetComponent<PlaneBase>();
        if (plane != null) {
            plane.bHit(Power);
        }
        Destroy(this.gameObject);
    }
    
}
