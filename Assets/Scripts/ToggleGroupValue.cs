using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupValue : MonoBehaviour
{
    public List<Toggle> m_lstToggle;
    public int m_nFeatureIndex;
    public void SetToggleIndex(int _index)
    {
        if (m_lstToggle[_index].isOn)
        {
            MenuManager.instance.SetCharacter(m_nFeatureIndex, _index);
        }
    }
}
