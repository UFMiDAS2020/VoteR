using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
    public Animator MC, MC_Global, NPC, NPC_Global, deskDude;

    public int state;

    // Start is called before the first frame update
    void Start()
    {
        MC_Global.enabled = false;
        MC_Global.enabled = true;

        NPC_Global.enabled = false;
        NPC_Global.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        MC.SetInteger("State", state);
        MC_Global.SetInteger("State", state);
        NPC.SetInteger("State", state);
        NPC_Global.SetInteger("State", state);

        if(state == 5)
        {
            deskDude.SetBool("HandDocument", true);
        }
        if(state == 6)
        {
            deskDude.SetBool("HandDocument", false);
        }
    }

    public void increment()
    {
        state++;
    }
}
