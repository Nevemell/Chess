using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessman : MonoBehaviour
{
    public GameObject controller;
    public GameObject movePlate;

    private int xBoard=-1;
    private int yBoard=-1;

    private string player;

    public Sprite black_bishop, black_king, black_knight, black_pawn, black_queen, black_rook;
    public Sprite white_bishop, white_king, white_knight, white_pawn, white_queen, white_rook;


    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");
        SetCoords();

        switch (this.name)
        {
            case "black_queen": this.GetComponent<SpriteRenderer>().sprite =black_queen; break;
            case "black_bishop": this.GetComponent<SpriteRenderer>().sprite =black_bishop; break;
            case "black_king": this.GetComponent<SpriteRenderer>().sprite =black_king; break;
            case "black_knight": this.GetComponent<SpriteRenderer>().sprite =black_knight; break;
            case "black_pawn": this.GetComponent<SpriteRenderer>().sprite =black_pawn; break;
            case "black_rook": this.GetComponent<SpriteRenderer>().sprite =black_rook; break;
            
            case "white_queen": this.GetComponent<SpriteRenderer>().sprite =white_queen; break;
            case "white_bishop": this.GetComponent<SpriteRenderer>().sprite =white_bishop; break;
            case "white_king": this.GetComponent<SpriteRenderer>().sprite =white_king; break;
            case "white_knight": this.GetComponent<SpriteRenderer>().sprite =white_knight; break;
            case "white_pawn": this.GetComponent<SpriteRenderer>().sprite =white_pawn; break;
            case "white_rook": this.GetComponent<SpriteRenderer>().sprite =white_rook; break;
        }
    }
    public void SetCoords()
    {
        float x = xBoard;
        float y = yBoard;
        x*=1.1f;
        y*=1.1f;

        x+=-3.83f;
        y+=-3.83f;

        this.transform.position = new Vector3(x,y,-1.0f);
    }
    public int GetXBoard()
    {
        return xBoard;
    }
    public int GetYBoard()
    {
        return yBoard;
    }
    public void SetXBoard(int x)
    {
        xBoard= x;
    }
    public void SetYBoard(int y)
    {
        yBoard= y;
    }

}
