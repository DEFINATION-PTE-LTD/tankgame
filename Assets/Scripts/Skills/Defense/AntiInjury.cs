﻿using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 防御技能-反伤
/// 对命中自身的敌方造成自身受到攻击伤害的百分比伤害（10%-80%）
/// </summary>
public class AntiInjury : MonoBehaviour
{
    public float Value = 0.1f;//
    public int Effected = 0;//已触发次数

    //技能预制体
    public GameObject SkillPrefab = null;

    //防御坦克
    public GameObject Tank = null;
    public GameObject SkillEffect = null;

    private void Awake()
    {
        //挂载后的默认状态
        SkillPrefab = CommonHelper.GetPrefabs("skill", "Defense/反伤");
        SkillEffect = GameObject.Instantiate(SkillPrefab, Tank.transform.parent, false);
        SkillEffect.SetActive(true);
    }



    /// <summary>
    /// 触发防御
    /// </summary>
    /// <returns></returns>
    public bool Trigger()
    {

        GameObject child = SkillEffect.transform.Find("LightSlash").gameObject;
        child.SetActive(true);
        child.GetComponent<ParticleSystem>().Play();
        Effected++;

        return true;

    }
}
