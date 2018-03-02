// using System.Collections;
//using System.Collections.Generic;
// using UnityEngine;



using UnityEngine;
using System.Collections;

using System.Collections.Generic;


public class ItemGenerator : MonoBehaviour
{


    public GameObject unitychan;

    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = -160;

    //private int startPos = -120;

    //ゴール地点
    private int goalPos = 120;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;


    //　壁　moving gate
    private int movingGate = -158;
    private float i;



    // Use this for initialization
    void Start()
    {

        this.unitychan = GameObject.Find("unitychan");


        //一定の距離ごとにアイテムを生成    元の　script
        for (int i = startPos; i < goalPos; i += 15)
        {

            // for (int i = startPos; i < startPos + 70; i += 15)
            //  {

            //      for (int i = -160 ; i < -100 ; i += 15)
            //  {

            //  if (unitychan.transform.position.z - gameObject.transform.position.z < 15.0f)

            // < 4.0f

            //  for (float i = unitychan.transform.position.z + 40.0f;
            //   i < unitychan.transform.position.z + 70.0f; i += 15)


            //  if (2.0f < unitychan.transform.position.z < 4.0f)
            //
            Debug.Log("Goodmorning");

            //    if (unitychan.transform.position.z - startPos > 10.0f)

            //       Debug.Log("Goodmorning2");
            //   {

            //      for ( startPos + 40.0f <　　                
            //                 i 　< startPos + 75.0f; 　i += 15)


            // i < unitychan.transform.position.z + 70.0f;
            // i += 15)


            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(0, 10);
            if (num <= 1)
            {
                //コーンをx軸方向に一直線に生成

                for (float j = -1; j <= 1; j += 0.4f)

                //  ********　　本数を減らす
                //for (float j = -1; j <= 1; j += 0.4f)


                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {

                //レーンごとにアイテムを生成
                for (int j = -1; j < 2; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //60%コイン配置:30%車配置:10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }
    }


}


// Update is called once per frame
void Update()
{


    // if (unitychan.transform.position.z - gameObject.transform.position.z < 1.0f) { 

    //if (gameObject.transform.position.z - unitychan.transform.position.z   < 1.0f)


    // if ( unitychan.transform.position.z - startPos  == 70.0f)


    //      if (unitychan.transform.position.z - movingGate < 40.0f)

    // movingGate = -240 ;

    if (unitychan.transform.position.z - startPos > 40.0f)

    //    if (unitychan.transform.position.z  > -240f)

    {

        // ******
        int num = Random.Range(0, 10);


        //     movingGate.position　=　transform.movingGate.position　+　72
        //   movingGate.positionを指定する場合には、Vector3型で指定しないといけませんので、
        // movingGate.position.z = new Vector3(transform.movingGate.position.x , 


        // movingGate.position.z = new Vector3(transform.movingGate.position.x , 
        //
        //   movingGate = new Vector3(transform.movingGate.x,
        //           transform.movingGate.position.y + transform.movingGate.position.z + 72) ;

        if (num <= 1)
        {
            //コーンをx軸方向に一直線に生成
            for (float j = -1; j <= 1; j += 0.4f)
            {
                GameObject cone = Instantiate(conePrefab) as GameObject;
                cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
            }
        }
        else
        {

            //レーンごとにアイテムを生成
            for (int j = -1; j < 2; j++)
            {
                //アイテムの種類を決める
                int item = Random.Range(1, 11);
                //アイテムを置くZ座標のオフセットをランダムに設定
                int offsetZ = Random.Range(-5, 6);
                //60%コイン配置:30%車配置:10%何もなし
                if (1 <= item && item <= 6)
                {
                    //コインを生成
                    GameObject coin = Instantiate(coinPrefab) as GameObject;
                    coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                }
                else if (7 <= item && item <= 9)
                {
                    //車を生成
                    GameObject car = Instantiate(carPrefab) as GameObject;
                    car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                }
            }
        }
    }
}












