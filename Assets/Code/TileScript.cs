using System;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    #region VARIABLES
    private Renderer _renderer;
    #endregion

    public void InitializeTile(Vector3 loc, String name, Transform parent)
    {
        this.transform.position = loc;
        this.name = name;
        this.transform.parent = parent;
    }

    private void Start()
    {
        _renderer = this.GetComponent<Renderer>();
    }
    private void OnMouseOver()
    {
        //Change the tiles color, temporarily
        _renderer.material.SetColor("_Color", Color.blue);
    }

    private void OnMouseDown()
    {
        //Move the currently selected player
        SquadMemberHandler.Instance.MoveSquadMember(this.transform.position);
    }

    private void OnMouseExit()
    {
        _renderer.material.SetColor("_Color", Color.white);
    }
}
