﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotController
{
    public struct MyQuat
    {

        public float w;
        public float x;
        public float y;
        public float z;

        public MyQuat(float x2, float y2, float z2, float w2)
        {
            this.w = w2;
            this.x = x2;
            this.y = y2;
            this.z = z2;
        }

        public MyQuat Normalize()
        {
            //MyVec v = new MyVec(this.x, this.y, this.z) / Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            float magnitude = (float)Math.Sqrt(Math.Pow(this.x, 2.0f) + Math.Pow(this.y, 2.0f) + Math.Pow(this.z, 2.0f));
            this.x /= magnitude;
            this.y /= magnitude;
            this.z /= magnitude;
            this.w /= magnitude;
            return this;
        }

        public MyQuat Invert()
        {
            this.x *= -1;
            this.y *= -1;
            this.z *= -1;
            return this;
        }

        public static MyQuat FromAngelAxis(MyVec axis, float a)
        {
            axis.Normalize();
            MyVec v = new MyVec(0, 0, 0);
            a = a * (float)Math.PI / 180;

            v.x = axis.x * (float)Math.Sin(a / 2);
            v.y = axis.y * (float)Math.Sin(a / 2);
            v.z = axis.z * (float)Math.Sin(a / 2);
            float w = (float)Math.Cos(a / 2);
            return new MyQuat(v.x, v.y, v.z, w).Normalize();
        }

        public static float GetAngle(MyQuat a)
        {
            return 2 * (float)Math.Acos(a.w);
        }
    }

    public struct MyVec
    {

        public float x;
        public float y;
        public float z;

        public MyVec(float x2, float y2, float z2)
        {
            this.x = x2;
            this.y = y2;
            this.z = z2;
        }

        public MyVec Normalize()
        {
            //MyVec v = new MyVec(this.x, this.y, this.z) / Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            float magnitude = (float)Math.Sqrt(Math.Pow(this.x, 2.0f) + Math.Pow(this.y, 2.0f) + Math.Pow(this.z, 2.0f));
            this.x /= magnitude;
            this.y /= magnitude;
            this.z /= magnitude;
            return this;
        }
    }






    public class MyRobotController
    {

        #region public methods



        public string Hi()
        {

            string s = "Pablo Periñan Cutillas, Josep Romera Andreu, Ivan Sales Mendez";
            return s;

        }


        //EX1: this function will place the robot in the initial position

        public void PutRobotStraight(out MyQuat rot0, out MyQuat rot1, out MyQuat rot2, out MyQuat rot3) {

            //todo: change this, use the function Rotate declared below
            rot0 = Rotate(NullQ, new MyVec(0f,1f,0f), 69f);
            rot1 = Rotate(rot0, new MyVec(0f, 1f, 0f), 4.37f);
            rot2 = Rotate(rot1, new MyVec(1f, 0f, 0f), 75.79f);
            rot3 = Rotate(rot2, new MyVec(1f, 0f, 0f), 33.42f);
        }

        public MyQuat M2(MyQuat q1, MyQuat q2)
        {

            return Multiply(q1, q2);
        }

        //EX2: this function will interpolate the rotations necessary to move the arm of the robot until its end effector collides with the target (called Stud_target)
        //it will return true until it has reached its destination. The main project is set up in such a way that when the function returns false, the object will be droped and fall following gravity.


        public bool PickStudAnim(out MyQuat rot0, out MyQuat rot1, out MyQuat rot2, out MyQuat rot3)
        {
            //Ponemos en pos inicial
            /*rot0 = Rotate(NullQ, new MyVec(0f, 1f, 0f), 69f);
            rot1 = Rotate(rot0, new MyVec(0f, 1f, 0f), 4.2f);
            rot2 = Rotate(rot1, new MyVec(1f, 0f, 0f), 60f);
            rot3 = Rotate(rot2, new MyVec(1f, 0f, 0f), 31.4f);

            //posiciones finales
            MyQuat rot0F = Rotate(NullQ, new MyVec(0f, 1f, 0f), 30.66f);
            MyQuat rot1F = Rotate(rot0, new MyVec(0f, 1f, 0f), 9.22f);
            MyQuat rot2F = Rotate(rot1, new MyVec(1f, 0f, 0f), 93.03f);
            MyQuat rot3F = Rotate(rot2, new MyVec(1f, 0f, 0f), 5.59f);

            float a0 = 30.66f;
            float a1 = 9.22f;
            float a2 = 93.03f;
            float a3 = 5.59f;*/

            bool myCondition = false;
            //todo: add a check for your condition



            if (myCondition)
            {
                //todo: add your code here
                rot0 = NullQ;
                rot1 = NullQ;
                rot2 = NullQ;
                rot3 = NullQ;

                //if()
                return true;
            }

            //todo: remove this once your code works.
            rot0 = NullQ;
            rot1 = NullQ;
            rot2 = NullQ;
            rot3 = NullQ;

            return false;
        }


        //EX3: this function will calculate the rotations necessary to move the arm of the robot until its end effector collides with the target (called Stud_target)
        //it will return true until it has reached its destination. The main project is set up in such a way that when the function returns false, the object will be droped and fall following gravity.
        //the only difference wtih exercise 2 is that rot3 has a swing and a twist, where the swing will apply to joint3 and the twist to joint4

        public bool PickStudAnimVertical(out MyQuat rot0, out MyQuat rot1, out MyQuat rot2, out MyQuat rot3)
        {

            bool myCondition = false;
            //todo: add a check for your condition



            while (myCondition)
            {
                //todo: add your code here


            }

            //todo: remove this once your code works.
            rot0 = NullQ;
            rot1 = NullQ;
            rot2 = NullQ;
            rot3 = NullQ;

            return false;
        }


        public static MyQuat GetSwing(MyQuat rot3)
        {
            //todo: change the return value for exercise 3
            return NullQ;

        }


        public static MyQuat GetTwist(MyQuat rot3)
        {
            //todo: change the return value for exercise 3
            return NullQ;

        }




        #endregion


        #region private and internal methods

        internal int TimeSinceMidnight { get { return (DateTime.Now.Hour * 3600000) + (DateTime.Now.Minute * 60000) + (DateTime.Now.Second * 1000) + DateTime.Now.Millisecond; } }


        private static MyQuat NullQ
        {
            get
            {
                MyQuat a;
                a.w = 1;
                a.x = 0;
                a.y = 0;
                a.z = 0;
                return a;

            }
        }

        internal MyQuat Multiply(MyQuat q1, MyQuat q2) {

            float x, y, z, w;
            x = q1.x * q2.w + q1.y * q2.z - q1.z * q2.y + q1.w * q2.x;
            y = -q1.x * q2.z + q1.y * q2.w + q1.z * q2.x + q1.w * q2.y;
            z = q1.x * q2.y - q1.y * q2.x + q1.z * q2.w + q1.w * q2.z;
            w = -q1.x * q2.x - q1.y * q2.y - q1.z * q2.z + q1.w * q2.w;

            /*a.w* b.w - a.x * b.x - a.y * b.y - a.z * b.z,  // 1
            a.w* b.x + a.x * b.w + a.y * b.z - a.z * b.y,  // i
            a.w* b.y - a.x * b.z + a.y * b.w + a.z * b.x,  // j
            a.w* b.z + a.x * b.y - a.y * b.x + a.z * b.w   // k*/
            //todo: change this so it returns a multiplication:

            return new MyQuat(x,y,z,w).Normalize();

        }

        internal MyQuat Rotate(MyQuat currentRotation, MyVec axis, float angle)
        {
            //todo: change this so it takes currentRotation, and calculate a new quaternion rotated by an angle "angle" radians along the normalized axis "axis"
            //MyQuat q = new MyQuat(Multiply(currentRotation, MyQuat.FromAngelAxis(axis, angle)));
            //MyQuat q = new MyQuat(Multiply(Multiply(currentRotation, MyQuat.FromAngelAxis(axis, angle)), currentRotation.Invert()));
            return Multiply(currentRotation, MyQuat.FromAngelAxis(axis, angle));

        }




        //todo: add here all the functions needed

        #endregion






    }
}
