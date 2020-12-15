using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Compare
    {
        #region comp1
        public Boolean isSame1(Stack<String> tower1,
                            Stack<String> comp1)
        {
           
            Boolean flag = true;

            
            if (tower1.Count != comp1.Count)
            {
                flag = false;
                return flag;
            }

            
            while (tower1.Count != 0)
            {
                
                if (tower1.Peek() == comp1.Peek())
                {
                      
                    tower1.Pop();
                    comp1.Pop();
                }
                else
                {
                    
                    flag = false;
                    break;
                }
            }

             
            return flag;
        }
        #endregion
        #region comp2
        public Boolean isSame2(Stack<String> tower2,
                           Stack<String> comp2)
        {

            Boolean flag = true;


            if (tower2.Count != comp2.Count)
            {
                flag = false;
                return flag;
            }


            while (tower2.Count != 0)
            {

                if (tower2.Peek() == comp2.Peek())
                {

                    tower2.Pop();
                    comp2.Pop();
                }
                else
                {

                    flag = false;
                    break;
                }
            }


            return flag;
        }
        #endregion
        #region comp3
        public Boolean isSame3(Stack<String> tower3,
                           Stack<String> comp3)
        {

            Boolean flag = true;


            if (tower3.Count != comp3.Count)
            {
                flag = false;
                return flag;
            }


            while (tower3.Count != 0)
            {

                if (tower3.Peek() == comp3.Peek())
                {

                    tower3.Pop();
                    comp3.Pop();
                }
                else
                {

                    flag = false;
                    break;
                }
            }


            return flag;
        }
        #endregion
    }
}
