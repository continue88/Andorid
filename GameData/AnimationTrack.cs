using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace GameData
{
    [Serializable]
    public class AnimationTrack
    {
        string mName = "";
        [XmlAttribute("Name"), DefaultValue("")]
        public string Name { get { return mName; } set { mName = value; } }

        bool mEnabled = true;
        [XmlAttribute("Enabled"), DefaultValue(true)]
        public bool Enabled { get { return mEnabled; } set { mEnabled = value; } }

        float mBegin = 0.0f;
        [XmlAttribute("Begin"), DefaultValue(0.0f)]
        public float Begin { get { return mBegin; } set { mBegin = value; } }

        float mEnd = 1.0f;
        [XmlAttribute("End"), DefaultValue(1.0f)]
        public float End { get { return mEnd; } set { mEnd = value; } }

        String mImageName = "";
        [XmlAttribute("ImageName"), DefaultValue("")]
        public string ImageName { get { return mImageName; } set { mImageName = value; } }

        List<AnimationKey> mAnimKeys = new List<AnimationKey>();
        public List<AnimationKey> AnimKeys { get { return mAnimKeys; } }
    }
}
