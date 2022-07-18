using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance = null;
    public List<GameObject> m_lstSettingDialog;
    public List<string> m_lstTitle;
    public Player m_nMainPlayer;
    public Player m_nCompletePlayer;
    public Player m_nSettingPlayer;
    public Player m_nPlayer;
    public Player m_nPlayerProfile;

    [SerializeField] private Text m_txtTitle;
    [SerializeField] private Slider m_sldStep;
    [SerializeField] private Text m_txtProgress;
    [SerializeField] private GameObject m_objDlgGroup;
    [SerializeField] private GameObject m_objLogo;
    [SerializeField] private GameObject m_objCharacter;
    [SerializeField] private GameObject m_objMaleHair;
    [SerializeField] private GameObject m_objFemaleHair;
    [SerializeField] private GameObject m_objHat;
    [SerializeField] private GameObject m_objBackGround;
    [SerializeField] private GameObject m_objSetPos;
    [SerializeField] private GameObject m_obj2dMode;
    [SerializeField] private GameObject m_obj3dMode;
    [SerializeField] private GameObject m_obj2DMap;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SetContentType(InputField _inputfield)
    {
        if (_inputfield.contentType == InputField.ContentType.Password)
            _inputfield.contentType = InputField.ContentType.Standard;
        else
            _inputfield.contentType = InputField.ContentType.Password;
        _inputfield.Select();
    }
    public void SignIn()
    {
        ResponseSignIn(true);
    }
    public void ResponseSignIn(bool _res)
    {
        if (_res)
        {
            //register
            NextSetting(1);
        }
        else
        {
            //if player is regestered on site, set player with info and go into the game
            Debug.Log("");
        }
    }
    void DisableDlg()
    {
        foreach (GameObject obj in m_lstSettingDialog)
            obj.SetActive(false);
    }
    public void NextSetting(int _index)
    {
        DisableDlg();
        m_txtTitle.text = m_lstTitle[_index];
        m_sldStep.value = _index / 7f;
        if (_index > 0 && _index < 9)
        {
            if (_index == 3)
            {
                if (m_nMainPlayer.m_nGender == 0)
                {
                    m_objMaleHair.SetActive(true);
                    m_objFemaleHair.SetActive(false);
                }
                else
                {
                    m_objMaleHair.SetActive(false);
                    m_objFemaleHair.SetActive(true);
                }
            }
            if (_index < 8)
            {
                m_objHat.SetActive(false);
                m_txtProgress.gameObject.SetActive(true);
                m_txtProgress.text = string.Format("{0} / 7", _index);
            }
            else
            {
                m_objHat.SetActive(true);
                m_txtProgress.gameObject.SetActive(false);
            }
            m_objBackGround.SetActive(true);
            m_objLogo.SetActive(false);
            m_objCharacter.SetActive(true);
        }
        else
        {
            if (_index > 8)
            {
                m_objBackGround.SetActive(false);
                m_objLogo.SetActive(false);
                m_objCharacter.SetActive(false);
                m_txtProgress.gameObject.SetActive(false);
            }
            else
            {
                m_objSetPos.SetActive(false);
                m_objBackGround.SetActive(true);
                m_objLogo.SetActive(true);
                m_objCharacter.SetActive(false);
                m_txtProgress.gameObject.SetActive(false);
            }
        }
        m_lstSettingDialog[_index].SetActive(true);
    }
    public void SetCharacter(int _featureIndex, int _index)
    {
        switch (_featureIndex)
        {
            case 0: m_nMainPlayer.SetGender(_index); break;
            case 1: m_nMainPlayer.SetSkinColor(_index); break;
            case 2: m_nMainPlayer.SetHairStyle(_index % 10); break;
            case 3: m_nMainPlayer.SetHairColor(_index); break;
            case 4: m_nMainPlayer.SetHeadStyle(_index); break;
            case 5: m_nMainPlayer.SetBodyStyle(_index); break;
            case 6: m_nMainPlayer.SetEquipment(_index); break;
            default: break;
        }
        switch (_featureIndex)
        {
            case 0: m_nCompletePlayer.SetGender(_index); break;
            case 1: m_nCompletePlayer.SetSkinColor(_index); break;
            case 2: m_nCompletePlayer.SetHairStyle(_index % 10); break;
            case 3: m_nCompletePlayer.SetHairColor(_index); break;
            case 4: m_nCompletePlayer.SetHeadStyle(_index); break;
            case 5: m_nCompletePlayer.SetBodyStyle(_index); break;
            case 6: m_nCompletePlayer.SetEquipment(_index); break;
            default: break;
        }
        switch (_featureIndex)
        {
            case 0: m_nSettingPlayer.SetGender(_index); break;
            case 1: m_nSettingPlayer.SetSkinColor(_index); break;
            case 2: m_nSettingPlayer.SetHairStyle(_index % 10); break;
            case 3: m_nSettingPlayer.SetHairColor(_index); break;
            case 4: m_nSettingPlayer.SetHeadStyle(_index); break;
            case 5: m_nSettingPlayer.SetBodyStyle(_index); break;
            case 6: m_nSettingPlayer.SetEquipment(_index); break;
            default: break;
        }
        switch (_featureIndex)
        {
            case 0: m_nPlayer.SetGender(_index); break;
            case 1: m_nPlayer.SetSkinColor(_index); break;
            case 2: m_nPlayer.SetHairStyle(_index % 10); break;
            case 3: m_nPlayer.SetHairColor(_index); break;
            case 4: m_nPlayer.SetHeadStyle(_index); break;
            case 5: m_nPlayer.SetBodyStyle(_index); break;
            case 6: m_nPlayer.SetEquipment(_index); break;
            default: break;
        }
        switch (_featureIndex)
        {
            case 0: m_nPlayerProfile.SetGender(_index); break;
            case 1: m_nPlayerProfile.SetSkinColor(_index); break;
            case 2: m_nPlayerProfile.SetHairStyle(_index % 10); break;
            case 3: m_nPlayerProfile.SetHairColor(_index); break;
            case 4: m_nPlayerProfile.SetHeadStyle(_index); break;
            case 5: m_nPlayerProfile.SetBodyStyle(_index); break;
            case 6: m_nPlayerProfile.SetEquipment(_index); break;
            default: break;
        }

    }
    public void SetManuallyPos()
    {
        m_objSetPos.SetActive(true);
        m_objDlgGroup.SetActive(false);
    }
    public void SetAutomaticallyPos()
    {
        m_objSetPos.SetActive(true);
        m_objDlgGroup.SetActive(false);
    }
    bool is2D = false;
    public void SetMode()
    {
        is2D = !is2D;
        m_obj2dMode.SetActive(is2D);
        m_obj3dMode.SetActive(!is2D);
        m_obj2DMap.SetActive(is2D);
    }
}