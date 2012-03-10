using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Drawing;

namespace GameData
{
    [Serializable]
    public class AnimationKey
    {
        int mTime = 0;
        [XmlAttribute("Time"), DefaultValue(0)]
        public int Time { get { return mTime; } set { mTime = value; } }

        Color mColor = Color.White;
        [DefaultValue(typeof(Color), "255, 255, 255")]
        public Color Color { get { return mColor; } set { mColor = value; } }

        float mCenterX = 0.5f;
        [XmlAttribute("CenterX"), DefaultValue(0.5f)]
        public float CenterX { get { return mCenterX; } set { mCenterX = value; } }

        float mCenterY = 0.5f;
        [XmlAttribute("CenterY"), DefaultValue(0.5f)]
        public float CenterY { get { return mCenterY; } set { mCenterY = value; } }

        float mLocationX = 0.0f;
        [XmlAttribute("LocationX"), DefaultValue(0.0f)]
        public float LocationX { get { return mLocationX; } set { mLocationX = value; } }

        float mLocationY = 0.0f;
        [XmlAttribute("LocationY"), DefaultValue(0.0f)]
        public float LocationY { get { return mLocationY; } set { mLocationY = value; } }

        float mWidth = 1.0f;
        [XmlAttribute("Width"), DefaultValue(1.0f)]
        public float Width { get { return mWidth; } set { mWidth = value; } }

        float mHeight = 1.0f;
        [XmlAttribute("Height"), DefaultValue(1.0f)]
        public float Height { get { return mHeight; } set { mHeight = value; } }

        float mAlpha = 1.0f;
        [XmlAttribute("Alpha"), DefaultValue(1.0f)]
        public float Alpha { get { return mAlpha; } set { mAlpha = value; } }

        float mRotate = 0.0f;
        [XmlAttribute("Rotate"), DefaultValue(0.0f)]
        public float Rotate { get { return mRotate; } set { mRotate = value; } }
    }
}
