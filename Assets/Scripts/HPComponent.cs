using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPComponent : MonoBehaviour
{

    [SerializeField] Slider hpBar;

    public void TakeDamage(float damage)
    {
        hpBar.value -= damage;
    }

    public void RecoverLife(float amount)
    {
        hpBar.value += amount;
    }

}
