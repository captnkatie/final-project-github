using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFlowerUse : MonoBehaviour
{
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    public void Use()
    {
        player.gameObject.GetComponent<CharacterController2D>().canSpeedRun = true;
        player.gameObject.GetComponent<CharacterController2D>().runSpeed = player.gameObject.GetComponent<CharacterController2D>().runSpeed + 20;
        player.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.6f, 0.6f, 0.8f, 0.8f);
        Destroy(gameObject);
    }
}
