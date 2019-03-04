using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomText : MonoBehaviour
{
    [SerializeField]
    private string[] m_HardCodedStrings;

    void Awake()
    {
        m_HardCodedStrings = new string[]
            {
                 "String Zero",
                 "String One",
                 "String Two",
                 "String Three",
                 "String Four",
            };
    }

    void Update()
    {
        Debug.Log(GetRandomHardCodedString());
    }

    public string GetRandomHardCodedString()
    {
        return m_HardCodedStrings[Random.Range(0, m_HardCodedStrings.Length)];
    }
}