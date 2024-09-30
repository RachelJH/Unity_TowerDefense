using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private Image imageScreen;
    [SerializeField]
    private float maxHP = 20;
    private float currentHP;

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    private void Awake()
    {
        currentHP = maxHP;
    }
    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        StopCoroutine("HitAlphaAnimation");
        StartCoroutine("HitAlphaAnimation");

        //플레이어 체력이 0이하로 내려가면 게임 오버
        if(currentHP <= 0)
        {

        }
    }
    IEnumerator HitAlphaAnimation()
    {
        Color color = imageScreen.color;
        color.a = 0.4f;
        imageScreen.color = color;  

        while(color.a >=0.0f)
        {
            color.a -=Time.deltaTime;
            imageScreen.color = color;

            yield return null;
        }
    }

}
