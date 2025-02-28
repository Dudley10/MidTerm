using UnityEngine;

public class Drop : MonoBehaviour

{
    public GameObject[] candyVariant;
    GameObject newObject;
    public float spawnRatio = 1.0f;
    public GameObject targetObject;
    public static float cooldown = 0.0f;
    public static float cooldownRate = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetObject = targetObject + 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (targetObject > 2) {
            spawnCandy();
        }
    }
    void spawnCandy(){
        int numVariants = candyVariant.Length;
        if (numVariants > 0) {
            int selection = Random.Range(0, numVariants);
            newObject = Instantiate(candyVariant[selection], new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            //needs spawn object
        }
    }
    void dropCandy(){
        cooldown = cooldown - Time.deltaTime;
    }
}
