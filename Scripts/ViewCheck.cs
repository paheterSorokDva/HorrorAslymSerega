using EvolveGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewCheck : MonoBehaviour
{
    [SerializeField] private bool Check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool CheckedBool()
    {
        return Check;
    }
}
