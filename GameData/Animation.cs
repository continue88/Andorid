using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.ComponentModel;

namespace GameData
{
    [Serializable]
    public class Animation
    {
        string mName = "";
        [XmlAttribute("Name"), DefaultValue("")]
        public string Name { get { return mName; } set { mName = value; } }

        bool mEnabled = true;
        [XmlAttribute("Enabled"), DefaultValue(true)]
        public bool Enabled { get { return mEnabled; } set { mEnabled = value; } }

        float mLifeTime = 1.0f;
        [XmlAttribute("LifeTime"), DefaultValue(1.0f)]
        public float LifeTime { get { return mLifeTime; } set { mLifeTime = value; } }

        Color mColor = Color.White;
        [DefaultValue(typeof(Color), "255, 255, 255")]
        public Color Color { get { return mColor; } set { mColor = value; } }

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

        float mDirectionX = 0.0f;
        [XmlAttribute("DirectionX"), DefaultValue(0.0f)]
        public float DirectionX { get { return mDirectionX; } set { mDirectionX = value; } }

        float mDirectionY = 0.0f;
        [XmlAttribute("DirectionY"), DefaultValue(0.0f)]
        public float DirectionY { get { return mDirectionY; } set { mDirectionY = value; } }

        float mVelocity = 0.0f;
        [XmlAttribute("mVelocity"), DefaultValue(0.0f)]
        public float Velocity { get { return mVelocity; } set { mVelocity = value; } }

        String mImageName = "";
        [XmlAttribute("ImageName"), DefaultValue("")]
        public string ImageName { get { return mImageName; } set { mImageName = value; } }

        List<AnimationTrack> mAnimTracks = new List<AnimationTrack>();
        public List<AnimationTrack> AnimTracks { get { return mAnimTracks; } }
    }
}
