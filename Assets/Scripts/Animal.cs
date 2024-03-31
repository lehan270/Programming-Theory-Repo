using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private int m_Age;
    public int Age
    {
        get{ return m_Age; }
        set
        {
            if (value >= 0)
            {
                m_Age = value;
            }
        }
    }

    public virtual void makeSound ()
    {
        // Nothing
    }
}
