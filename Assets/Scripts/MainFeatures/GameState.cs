using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public enum Character { FlyBronze, BidDol, FlitterMouse, HumanStrike, None };
    public static Character P1_Character;
    public static Character P2_Character;
    public static Character P3_Character;
    public static Character P4_Character;

    public static GameObject P1;
    public static GameObject P2;
    public static GameObject P3;
    public static GameObject P4;

    public static int lives;
    public static int time;

    public static List<string> winners = new List<string>();

    private static bool init = false;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void Init(GameObject p1, GameObject p2, GameObject p3, GameObject p4)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;
        P4 = p4;

        if (!init)
        {
            winners.Add(P1_Character.ToString());
            winners.Add(P2_Character.ToString());
            winners.Add(P3_Character.ToString());
            winners.Add(P4_Character.ToString());

            init = true;
        }

        if (P1 != null)
        {
            P1.tag = "Player";
        }

        if (P2 != null)
        {
            P2.tag = "AI";
        }

        if (P3 != null)
        {
            P3.tag = "AI";
        }

        if (P4 != null)
        {
            P4.tag = "AI";
        }
    }

    public static void ResetGame()
    {
        init = false;
        Init(P1, P2, P3, P4);
    }
}
