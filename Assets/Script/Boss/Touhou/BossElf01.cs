using UnityEngine;
using System.Collections;

public class BossElf01 : BossBase {


	// Use this for initialization
    void Start()
    {
        base.Start();
        Init();
    }

    //初始化发射器列表
    void InitBossShooters() {
        for (int i = 0; i < BossShooterList.Count; i++)
        {

            BossShooterList[i].CanShootBulletCount = 5;
        }
        //mainShooter = BossShooterList[ShooterIndex];
        SetMainShooterBullet(5, 0, 0, 0);
    }

    void Init() {
        bossState = BossState.InNormal;
        ShooterIndex = 0;
        InitBossShooters();
    }

    //// Update is called once per frame
    void Update()
    {
        base.Update();
        //if (mainShooter.CanShootBulletCount <= 0) {  //这个波效果的子弹打完换下一波子弹
        //    if (ShooterIndex < BossShooterList.Count -1) {
        //        ShooterIndex++;
        //        InitBossShooters();
        //    }
            
        //}
    }
}
