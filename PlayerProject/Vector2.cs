using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Author: Tom Tsiliopoulos
 * Date: June 17, 2016
 * StudentID: 300818557
 * Description: This class is used to describe x and y coordinates for an object
 * Version: 0.01 - Initial Class creation with Getters and Setters for x and y
 */

namespace PlayerProject
{
    /**
     * <summary>
     * This class contains two properties x and y which are related to geospatial information for game objects
     * </summary>
     * 
     * @class Vector2
     * @property {float} x - defines the x coordinate
     * @property {float} y - defines the y coordinate
     */
    public class Vector2
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS) +++++++++++++++++++++++++++++++++++++++++
        private float _x;
        private float _y;
       
        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public float x
        {
            get
            {
                return this._x;
            }

            set
            {
                this._x = value;
            }
        }

        public float y
        {
            get
            {
                return this._y;
            }

            set
            {
                this._y = value;
            }
        }


        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: x and y which represent the x and y coordinates of an object
         * </summary>
         * 
         * @constructor Vector2
         * @param {float} x - the x coordinate
         * @param {float} y - the y coordinate
         */
        public Vector2(float x = 0f, float y = 0f)
        {
            this.x = x;
            this.y = y;
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Vector2 Zero()
        {
            this.x = 0f;
            this.y = 0f;

            return new Vector2(this.x, this.y);
        }

        public Vector2 East(float magnitude = 1)
        {
            this.x = magnitude;
            this.y = 0f;

            return new Vector2(this.x, this.y);
        }

        public Vector2 NorthEast(float magnitude = 1)
        {
            this.x = magnitude;
            this.y = -magnitude;

            return new Vector2(this.x, this.y);
        }

        public Vector2 North(float magnitude = 1)
        {
            this.x = 0f;
            this.y = -magnitude;

            return new Vector2(this.x, this.y);
        }

        public Vector2 NorthWest(float magnitude = 1)
        {
            this.x = -magnitude;
            this.y = -magnitude;

            return new Vector2(this.x, this.y);
        }

        public Vector2 West(float magnitude = 1)
        {
            this.x = -magnitude;
            this.y = 0f;

            return new Vector2(this.x, this.y);
        }

        public Vector2 SouthWest(float magnitude = 1)
        {
            this.x = -magnitude;
            this.y = magnitude;

            return new Vector2(this.x, this.y);
        }

        public Vector2 South(float magnitude = 1)
        {
            this.x = 0f;
            this.y = magnitude;

            return new Vector2(this.x, this.y);
        }

        public Vector2 SouthEast(float magnitude = 1)
        {
            this.x = magnitude;
            this.y = magnitude;

            return new Vector2(this.x, this.y);
        }

        public float Magnitude(Vector2 first, Vector2 second)
        {
            float magnitude = Convert.ToSingle(Math.Sqrt(Math.Pow(second.x - first.x,2) + Math.Pow(second.y - first.y,2)));
            return magnitude;
        }
    }
}