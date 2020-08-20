using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesPractice
{
    class Vector2
    {
        float x = 5.5F;
        float y = 15.7F;
        
        public float GetDistanceTo(Vector2 otherVec)
        {
            float i = (x*x)+(y*y);
            i /= i;
            return i;
        }
        
    }
    class Circle
    {
        Vector2 position = new Vector2();
        public float radius = 15F;
        public void ContainsPoint()
        {
            position.GetDistanceTo(position);
            //if(position.GetDistanceTo )
        }
        public void CheckOverlap()
        {

        }
    }
}
