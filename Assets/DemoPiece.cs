
using UnityEngine;

[ExecuteInEditMode]
public class DemoPiece : MonoBehaviour
{
    // This should be associated to a specific house manager btw
    private HouseManager houseManager = null;
    
    private void Start()
    {
    }

    private void OnEnable()
    {
        GetOrFindHouseManager()?.AddPieceToHouse(gameObject);
    }

    private void OnDisable()
    {
        GetOrFindHouseManager()?.RemovePieceFromHouse(gameObject);
    }

    private HouseManager GetOrFindHouseManager()
    {
        if (!houseManager)
        {
            houseManager = FindObjectOfType<HouseManager>(); 
        }

        return houseManager;
    }
}
