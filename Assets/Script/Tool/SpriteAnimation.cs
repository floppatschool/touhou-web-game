using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpriteAnimation : MonoBehaviour {

    public bool isNeedMirror = false;//是否需要镜像
    private bool isLefting = false;//左移动中
    private bool isRighting = false;//右移动中
    private bool isChangeOver = true;//是否过度完成
    private List<Sprite> Cur_Sprites = new List<Sprite>();//动画序列
    int index = 0;//播放的当前索引

    //public List<Sprite> Stand_Sprites = new List<Sprite>();//不动的时候的动画
    //public List<Sprite> Left_Spites = new List<Sprite>();//左移动中动画
    //public List<Sprite> Right_Sprites = new List<Sprite>();//右移动中动画
    //public List<Sprite> Dead_Sprites = new List<Sprite>();//死亡动画
    //public List<Sprite> StartL_Sprite = new List<Sprite>();//开始向左的动画
    //public List<Sprite> StartR_Sprite = new List<Sprite>();//开始向右的动画

    //public float framesPerSecond = 10;//播放速度

    //private SpriteRenderer spriteRenderer;//当前动画
    //// Use this for initialization
    //void Start () {
    //    Cur_Sprites = Stand_Sprites;
    //    spriteRenderer = renderer as SpriteRenderer;
    //    if (isNeedMirror) {
    //        StartL_Sprite = StartR_Sprite;
    //        Left_Spites = Right_Sprites;
    //    }
    //}

    ////public void setSpriteState(PlaneBase.PlaneState state)
    ////{
    ////    gameObject.transform.localScale = Vector3.one;
    ////    switch (state)
    ////    {
    ////        case PlaneBase.PlaneState.NoMove:
    ////            Cur_Sprites = Stand_Sprites;
    ////            break;
    ////        case PlaneBase.PlaneState.Lefting:
    ////            Cur_Sprites = Left_Spites;
    ////            if (isNeedMirror)
    ////            {
    ////                gameObject.transform.localScale = new Vector3(-1, 1, 1);
    ////            }
    ////            break;
    ////        case PlaneBase.PlaneState.Righting:
    ////            Cur_Sprites = Right_Sprites;
    ////            break;
    ////        case PlaneBase.PlaneState.Dead:
    ////            Cur_Sprites = Dead_Sprites;
    ////            break;
    ////        case PlaneBase.PlaneState.StartLeft:
    ////            Cur_Sprites = StartL_Sprite;
    ////            if (isNeedMirror)
    ////            {
    ////                gameObject.transform.localScale = new Vector3(-1, 1, 1);
    ////            }
    ////            break;
    ////        case PlaneBase.PlaneState.StartRight:
    ////            Cur_Sprites = StartR_Sprite;
    ////            break;

    ////    }
    ////}

    //public void setSpriteState(PlaneBase.PlaneState state)
    //{
    //    gameObject.transform.localScale = Vector3.one;
    //    switch (state)
    //    {
    //        case PlaneBase.PlaneState.NoMove:
    //            isLefting = false;
    //            isRighting = false;
    //            isChangeOver = false;
    //            Cur_Sprites = Stand_Sprites;
    //            break;
    //        case PlaneBase.PlaneState.Left:
    //            isLefting = true;
    //            index = 0;
    //            //isRighting = false;
    //            //Cur_Sprites = StartL_Sprite;
    //            if (isNeedMirror)
    //            {
    //                gameObject.transform.localScale = new Vector3(-1, 1, 1);
    //                //StartL_Sprite = StartR_Sprite;
    //                //Left_Spites = Right_Sprites;
    //                //Cur_Sprites = Left_Spites;
    //            }
    //            break;
    //        case PlaneBase.PlaneState.Right:
    //            isRighting = true;
    //            index = 0;
    //            //isLefting = false;
    //            //Cur_Sprites = StartR_Sprite;
    //            break;
    //        case PlaneBase.PlaneState.Dead:
    //            Cur_Sprites = Dead_Sprites;
    //            break;
    //    }
    //}

    //// Update is called once per frame
    //void Update () {
    //    index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
    //    index = index % Cur_Sprites.Count;
    //    if (isLefting) { //左移动中先播放完渐变左图片序列
    //        if (!isChangeOver)
    //        {
    //            Cur_Sprites = StartL_Sprite;
    //            if (index == Cur_Sprites.Count-1)
    //            {
    //                isChangeOver = true;
    //                Cur_Sprites = Left_Spites;    
    //            }
    //        }           
    //    }
    //    if (isRighting) {
    //        if (!isChangeOver)
    //        {
    //            Cur_Sprites = StartR_Sprite;
    //            if (index == Cur_Sprites.Count-1)
    //            {
    //                isChangeOver = true;
    //                Cur_Sprites = Right_Sprites;
    //            }
    //        }
    //    }
    //    //Debug.Log("index = " + index);
    //    index = index % Cur_Sprites.Count;
    //    spriteRenderer.sprite = Cur_Sprites[index];
        
    //}
}
