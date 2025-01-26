using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int pointEarned;
    private int totalPointEarned;
    private bool isWin;

    public GameController()
    {
        this.pointEarned = 0;
        this.isWin = false;
    }

    public GameController(int winPoint)
    {
        this.pointEarned = winPoint;
    }

    public void Win()
    {
        this.isWin = true;
    }

    public void setWin(bool isWin)
    {
        this.isWin = isWin;
    }

    public bool getWin()
    {
        return this.isWin;
    }

    public void setPoint(int pointEarned)
    {
        this.pointEarned = pointEarned;
    }

    public int getPoint()
    {
        return this.pointEarned;
    }

    public void setTotalPoint(int totalPointEarned)
    {
        this.totalPointEarned = totalPointEarned;
    }

    public int getTotalPoint()
    {
        return this.totalPointEarned;
    }
}
