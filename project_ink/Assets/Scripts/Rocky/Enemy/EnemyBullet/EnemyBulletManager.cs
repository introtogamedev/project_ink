using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletManager : Singleton<EnemyBulletManager>{
    public EnemyBulletBase boss1_a4,boss1_a5;
    public EnemyBulletBase monkey, monkey_split;
    public EnemyBulletBase diamond, frog;
    /// <summary>
    /// set the bullet direction. velocity=dir*bullet.spd
    /// </summary>
    public static EnemyBulletBase InstantiateBullet_dir(EnemyBulletBase prefab, Vector2 pos, Vector2 dir){
        EnemyBulletBase bullet=InstantiateBullet(prefab);
        bullet.transform.position=pos;
        bullet.rgb.velocity=dir*prefab.spd;
        return bullet;
    }
    /// <summary>
    /// set the bullet's velocity directly
    /// </summary>
    public static EnemyBulletBase InstantiateBullet_v(EnemyBulletBase prefab, Vector2 pos, Vector2 v){
        EnemyBulletBase bullet=InstantiateBullet(prefab);
        bullet.transform.position=pos;
        bullet.rgb.velocity=v;
        return bullet;
    }
    public static EnemyBulletBase InstantiateBullet(EnemyBulletBase prefab){
        EnemyBulletBase bullet = Instantiate(prefab.gameObject).GetComponent<EnemyBulletBase>();
        if(bullet.rgb==null) bullet.rgb=bullet.GetComponent<Rigidbody2D>();
        return bullet;
    }
}