using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SpriteLooper : MonoBehaviour
{

    public GameObject Object_to_loop;
    public float scrollMultiplier = 1;
    public float scrollSpeed;
    private float scroll_speed = 1;

    public enum PositionSnap
    {
        Top = 1,
        Down = 2,
        Y_Axis = 3,
    }
    public float Y_Axis = 0;

    public PositionSnap position;
    private List<GameObject> Sprite_List = new List<GameObject>();
    private float Camera_width;
    private float Camera_height;

    private float sprite_width;
    private float sprite_heigt;

    // Use this for initialization
    void Start()
    {
        scroll_speed = scrollMultiplier * scrollSpeed;

        sprite_width = Object_to_loop.transform.GetChild(0).renderer.bounds.size.x;//haalt de X breedte op van het grond object
        sprite_heigt = Object_to_loop.transform.GetChild(0).renderer.bounds.size.y;//haalt de Y breedte op van het grond object

        Camera_height = Camera.main.orthographicSize * 2;
        Camera_width = Camera_height * Screen.width / Screen.height;

        for (int i = 0; i < Mathf.Ceil(Camera_width / sprite_width) + 1; i++)
        {
            GameObject TempSprite = null;

            switch (position)
            {
                case PositionSnap.Top:
                    TempSprite = (GameObject)Instantiate(Object_to_loop, new Vector3((i * sprite_width) - (sprite_width / 2), (Camera_height / 2) - sprite_heigt / 2, Object_to_loop.transform.position.z), Quaternion.identity);
                    break;
                case PositionSnap.Down:
                    TempSprite = (GameObject)Instantiate(Object_to_loop, new Vector3((i * sprite_width) - (sprite_width / 2), (Camera_height / 2 * -1) + sprite_heigt / 2, Object_to_loop.transform.position.z), Quaternion.identity);
                    break;
                case PositionSnap.Y_Axis:
                    TempSprite = (GameObject)Instantiate(Object_to_loop, new Vector3((i * sprite_width) - (sprite_width / 2), (Camera_height / 2 * -1) + sprite_heigt / 2, Object_to_loop.transform.position.z), Quaternion.identity);
                    break;
                default:
                    break;
            }


            Sprite_List.Add(TempSprite);
        }
        Sprite_List = Sprite_List.OrderBy(t => t.transform.position.x).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        scroll_speed = scrollMultiplier * scrollSpeed;

        GameObject First = Sprite_List.First();
        //check of element uit de wereld is
        if (First.transform.position.x <= ((Camera_width / 2) + sprite_width / 2) * -1)
        {
            //zet het eerste element achter aan
            First.transform.position = new Vector3(Sprite_List.Last().transform.position.x + sprite_width, Sprite_List.Last().transform.position.y, transform.position.z);
            //sort de array op nieuw
            Sprite_List = Sprite_List.OrderBy(t => t.transform.position.x).ToList();
        }

        //loop door alle grond elementen en beweeg ze.
        for (int i = 0; i < Sprite_List.Count; i++)
        {
            Sprite_List.ElementAt(i).transform.Translate((Vector3.left * scroll_speed) * Time.deltaTime);
        }
    }
}
