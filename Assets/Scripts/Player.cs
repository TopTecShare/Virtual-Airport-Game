using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int m_nGender;
    public int m_nSkinColor;
    public int m_nHairStyle;
    public int m_nHairColor;
    public int m_nHeadStyle;
    public int m_nBodyStyle;
    public int m_nEquipment;
    public int m_nWorkPosition;
    [SerializeField] Image m_imgHead;
    [SerializeField] Image m_imgEar;
    [SerializeField] Image m_imgHand;
    [SerializeField] Image m_imgHair;
    [SerializeField] Image m_imgBody;
    [SerializeField] Image m_imgEquip;
    [SerializeField] Image m_imgHat;

    [SerializeField] SpriteRenderer m_srHead;
    [SerializeField] SpriteRenderer m_srEar;
    [SerializeField] SpriteRenderer m_srHand;
    [SerializeField] SpriteRenderer m_srHair;
    [SerializeField] SpriteRenderer m_srBody;
    [SerializeField] SpriteRenderer m_srEquip;
    [SerializeField] SpriteRenderer m_srHat;

    [SerializeField] Transform m_ui;
    void Start()
    {
        SetGender(m_nGender);
        SetSkinColor(m_nSkinColor);
        SetHairStyle(m_nHairStyle);
        SetHairColor(m_nHairColor);
        SetHeadStyle(m_nHeadStyle);
        SetBodyStyle(m_nBodyStyle);
        SetEquipment(m_nEquipment);
        SetWorkPosition(m_nWorkPosition);
    }
    private void Update()
    {
    }
    public void SetGender(int _index)
    {
        m_nGender = _index;
        if (m_nGender == 0)
        {
            if (m_imgEar) m_imgEar.gameObject.SetActive(true);
            if (m_srEar) m_srEar.gameObject.SetActive(true);
        }
        else
        {
            if (m_imgEar) m_imgEar.gameObject.SetActive(false);
            if (m_srEar) m_srEar.gameObject.SetActive(false);
        }
        SetHeadStyle(m_nHeadStyle);
        SetHairStyle(m_nHairStyle);
        SetBodyStyle(m_nBodyStyle);
        SetEquipment(m_nEquipment);
    }
    public void SetSkinColor(int _index)
    {
        m_nSkinColor = _index;
        SetHeadStyle(m_nHeadStyle);
        SetEarStyle();
        SetHandStyle();
    }
    public void SetHairStyle(int _index)
    {
        m_nHairStyle = _index;
        if (m_imgHair)
            m_imgHair.sprite = Resources.Load<Sprite>("Image/HairStyle/" + m_nGender + "0" + m_nHairStyle + "" + m_nHairColor);
        if (m_srHair)
            m_srHair.sprite = Resources.Load<Sprite>("Image/HairStyle/" + m_nGender + "0" + m_nHairStyle + "" + m_nHairColor);
    }
    public void SetHairColor(int _index)
    {
        m_nHairColor = _index;
        SetHairStyle(m_nHairStyle);
    }
    public void SetHeadStyle(int _index)
    {
        m_nHeadStyle = _index;
        if (m_imgHead)
            m_imgHead.sprite = Resources.Load<Sprite>("Image/SkinColor/" + m_nHeadStyle + "" + m_nSkinColor);
        if (m_srHead)
            m_srHead.sprite = Resources.Load<Sprite>("Image/SkinColor/" + m_nHeadStyle + "" + m_nSkinColor);
    }
    public void SetEarStyle()
    {
        if (m_imgEar)
            m_imgEar.sprite = Resources.Load<Sprite>("Image/Ear/" + m_nSkinColor);
        if (m_srEar)
            m_srEar.sprite = Resources.Load<Sprite>("Image/Ear/" + m_nSkinColor);
    }
    public void SetHandStyle()
    {
        if (m_imgHand)
            m_imgHand.sprite = Resources.Load<Sprite>("Image/Hand/" + m_nBodyStyle + "" + m_nSkinColor);
        if (m_srHand)
            m_srHand.sprite = Resources.Load<Sprite>("Image/Hand/" + m_nBodyStyle + "" + m_nSkinColor);
    }
    public void SetBodyStyle(int _index)
    {
        m_nBodyStyle = _index;
        if (m_imgBody)
            m_imgBody.sprite = Resources.Load<Sprite>("Image/BodyStyle/" + m_nBodyStyle);
        if (m_srBody)
            m_srBody.sprite = Resources.Load<Sprite>("Image/BodyStyle/" + m_nBodyStyle);
        SetHandStyle();
    }
    public void SetEquipment(int _index)
    {
        m_nEquipment = _index;
        if (m_imgEquip)
            m_imgEquip.sprite = Resources.Load<Sprite>("Image/Equipment/" + m_nEquipment);
        if (m_srEquip)
            m_srEquip.sprite = Resources.Load<Sprite>("Image/Equipment/" + m_nEquipment);
    }
    public void SetWorkPosition(int _index)
    {
        m_nWorkPosition = _index;
    }
}
