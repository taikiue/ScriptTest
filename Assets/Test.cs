using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp=53;//変数宣言
    //magic関数
    public void magic(int MPpoint)
    {
        for (int mp = 53; mp >=0;mp=mp-5 )
        {
            if(mp>=5)
            {
               this.mp-=MPpoint;
                Debug.Log("魔法攻撃をした。残りMPは"+mp);

            }
            else
            {
                if(mp<5)
                Debug.Log("MPが足りないため、魔法が使えない");
            }
        }
    }
    

}

public class Test : MonoBehaviour
{
   
  
    // Start is called before the first frame update
    void Start()
    {
       Boss lastboss=new Boss();
       lastboss.magic(5);
      
    
    
       
        //通常課題
        int[] array={10,20,30,40,50};
        for (int i = 0; i <5; i++)
         {
             Debug.Log(array[i]);

         }

         for(int j=4;j>=0;j--)
         {
             Debug.Log(array[j]);

         }
    }
        
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
