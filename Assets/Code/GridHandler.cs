using System.Collections.Generic;
using UnityEngine;

/*class Tile
{
    private readonly int _x;
    private readonly int _z;
    private readonly GameObject _tileObject;

    public Tile(int x, int z, GameObject obj)
    {
        _x = x;
        _z = z;
        _tileObject = obj;
    }

    public Vector2 GetLocation()
    {
        return new Vector3(_x, 0, _z);
    }

    public GameObject GetObject()
    {
        return _tileObject;
    }
}*/

public class GridHandler : MonoBehaviour
{
    private const int GridWidth = 20;
    private const int GridHeight = 20;
    public GameObject TileObject;
    private readonly List<GameObject> _tileObjectList = new List<GameObject>();
    public GameObject TileParentObject;

    // Start is called before the first frame update
    private void Start()
    {
        CreateGrid();
    }
    private void CreateGrid()
    {
        for (var h = 0; h < GridHeight; h++)
        {
            for (var w = 0; w < GridWidth; w++)
            {
                var tileObject = GameObject.Instantiate(TileObject) as GameObject;
                tileObject.GetComponent<TileScript>().InitializeTile(new Vector3(w, 0, h), w.ToString() + ",0," + h.ToString(), TileParentObject.transform);
                _tileObjectList.Add(tileObject);
            }
        }
    }
}
