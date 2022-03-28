using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners3 : MonoBehaviour
{
    public Transform spawner1, spawner2, spawner3, spawner4, spawner5, spawner6, spawner7, spawner8, spawner9, spawner10, spawner11, spawner12, spawner13, spawner14, spawner15, spawner16, spawner17, spawner18, spawner19, spawner20;
    public GameObject enemySprite;

    public GameObject batterySprite;
    public GameObject healthSprite;
    public GameObject ammoSprite;
    float delay = 4F;
    float timeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Time.fixedTime;
        for (int i = 0; i < 6; i++)
        {
            spawnConsumable(1);
            spawnConsumable(2);
            spawnConsumable(3);
        }
        InvokeRepeating("consumableSpawner", 5F, 5F);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (Time.fixedTime > timeToSpawn)
        {
            spawnEnemies();
            timeToSpawn += delay;
        }
    }
    public void spawnEnemies()
    {
        System.Random rand = new System.Random();
        int randomSpawner = rand.Next(1, 20);

        Transform spawner = convert(randomSpawner);
        enemy(spawner);
        if (delay <= 2)
        {
            delay = 2F;
        }
        else
        {
            delay -= 0.02F;
        }
    }

    public void spawnConsumable(int i)
    {
        System.Random rand = new System.Random();
        int randomSpawner = rand.Next(1, 20);

        Transform spawner = convert(randomSpawner);

        if (i == 1)
        {
            health(spawner);
        }
        if (i == 2 || i == 3)
        {
            ammo(spawner);
        }
        if (i == 4 || i == 5)
        {
            battery(spawner);
        }
    }

    public void consumableSpawner()
    {
        System.Random rand = new System.Random();
        int consumable = rand.Next(1, 5);

        spawnConsumable(consumable);
    }

    public void enemy(Transform s)
    {
        GameObject enemy = Instantiate(enemySprite, s.position, s.rotation);
    }

    public void health(Transform s)
    {
        GameObject health = Instantiate(healthSprite, s.position, s.rotation);
    }

    public void ammo(Transform s)
    {
        GameObject ammo = Instantiate(ammoSprite, s.position, s.rotation);
    }

    public void battery(Transform s)
    {
        GameObject battery = Instantiate(batterySprite, s.position, s.rotation);
    }

    public Transform convert(int i)
    {
        switch (i)
        {
            case 1:
                return spawner1;
            case 2:
                return spawner2;
            case 3:
                return spawner3;
            case 4:
                return spawner4;
            case 5:
                return spawner5;
            case 6:
                return spawner6;
            case 7:
                return spawner7;
            case 8:
                return spawner8;
            case 9:
                return spawner9;
            case 10:
                return spawner10;
            case 11:
                return spawner11;
            case 12:
                return spawner12;
            case 13:
                return spawner13;
            case 14:
                return spawner14;
            case 15:
                return spawner15;
            case 16:
                return spawner16;
            case 17:
                return spawner17;
            case 18:
                return spawner18;
            case 19:
                return spawner19;
            case 20:
                return spawner20;
            default:
                return null;
        }
    }
}
