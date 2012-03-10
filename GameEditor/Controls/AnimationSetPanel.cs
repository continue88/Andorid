using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameData;

namespace GameEditor.Controls
{
    public partial class AnimationSetPanel : UserControl
    {
        public AnimationSetPanel()
        {
            InitializeComponent();

            ShowAnimationSets();
        }

        private void OnNewAnimSetClicked(object sender, EventArgs e)
        {
            AnimationSet animationSet = new AnimationSet();
            animationSet.Name = "AnimationSet" + AnimationSetManager.Instance.AnimationSets.Count;

            SettingDlg dlg = new SettingDlg("New Animation Set", animationSet);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            if (AnimationSetManager.Instance.Contains(animationSet.Name))
            {
                MessageBox.Show(string.Format("Animation '{0}' already exist!!!", animationSet.Name));
                return;
            }

            AnimationSetManager.Instance.Add(animationSet);

            ShowAnimationSets();

            listView1.Items[listView1.Items.Count - 1].Selected = true;
        }

        private void OnDeleteAnimSetClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in listView1.SelectedItems)
            {
                AnimationSet animationSet = lvItem.Tag as AnimationSet;
                AnimationSetManager.Instance.Delete(animationSet.Name);
            }

            ShowAnimationSets();
        }

        private void OnSaveAnimSetClicked(object sender, EventArgs e)
        {
            AnimationSetManager.Instance.Save();
        }

        private void OnNewAnimClicked(object sender, EventArgs e)
        {
            AnimationSet animationSet = listView2.Tag as AnimationSet;
            if (animationSet == null)
                return;

            Animation animation = new Animation();
            animation.Name = "Animation" + animationSet.Animations.Count;

            SettingDlg dlg = new SettingDlg("New Animation", animation);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            animationSet.Animations.Add(animation);

            ShowAnimationSet(animationSet);

            listView2.Items[listView2.Items.Count - 1].Selected = true;
        }

        private void OnDeleteAnimClicked(object sender, EventArgs e)
        {
            AnimationSet animationSet = listView2.Tag as AnimationSet;
            if (animationSet == null)
                return;

            foreach (ListViewItem lvItem in listView2.SelectedItems)
            {
                Animation animation = lvItem.Tag as Animation;
                animationSet.Animations.Remove(animation);
            }

            ShowAnimationSet(animationSet);
        }

        private void OnAddAnimTrackClicked(object sender, EventArgs e)
        {
            Animation animation = listView3.Tag as Animation;
            if (animation == null)
                return;

            AnimationTrack animTrack = new AnimationTrack();
            SettingDlg dlg = new SettingDlg("New Animation Track", animTrack);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            animation.AnimTracks.Add(animTrack);

            ShowAnimation(animation);

            listView3.Items[listView3.Items.Count - 1].Selected = true;
        }

        private void OnDeleteAnimTrackClicked(object sender, EventArgs e)
        {
            Animation animation = listView3.Tag as Animation;
            if (animation == null)
                return;

            foreach (ListViewItem lvItem in listView3.SelectedItems)
            {
                AnimationTrack animationTrack = lvItem.Tag as AnimationTrack;
                animation.AnimTracks.Remove(animationTrack);
            }

            ShowAnimation(animation);
        }


        private void OnAddAnimKeyClicked(object sender, EventArgs e)
        {
            AnimationTrack animTrack = listView4.Tag as AnimationTrack;
            if (animTrack == null)
                return;

            AnimationKey animKey = new AnimationKey();
            SettingDlg dlg = new SettingDlg("New Animation Key", animKey);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            animTrack.AnimKeys.Add(animKey);

            ShowAnimationTrack(animTrack);

            listView3.Items[listView3.Items.Count - 1].Selected = true;
        }

        private void OnDeleteAnimKeyClicked(object sender, EventArgs e)
        {
            AnimationTrack animTrack = listView4.Tag as AnimationTrack;
            if (animTrack == null)
                return;

            foreach (ListViewItem lvItem in listView4.SelectedItems)
            {
                AnimationKey animKey = lvItem.Tag as AnimationKey;
                animTrack.AnimKeys.Remove(animKey);
            }

            ShowAnimationTrack(animTrack);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
                return;
            ShowAnimationSet(listView1.SelectedItems[0].Tag as AnimationSet);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count < 1)
                return;
            ShowAnimation(listView2.SelectedItems[0].Tag as Animation);
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count < 1)
                return;
            ShowAnimationTrack(listView3.SelectedItems[0].Tag as AnimationTrack);
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count < 1)
                return;
            ShowAnimationKey(listView3.SelectedItems[0].Tag as AnimationKey);
        }

        private void OnListViewDoubleClicked(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            if (listView == null || listView.SelectedItems.Count == 0)
                return;

            Object select = listView.SelectedItems[0].Tag;
            if (select == null)
                return;

            SettingDlg dlg = new SettingDlg("Edit", select);
            dlg.ShowDialog();
        }

        void ShowAnimationSets()
        {
            listView1.Items.Clear();
            foreach (AnimationSet animSet in AnimationSetManager.Instance.AnimationSets.Values)
            {
                ListViewItem lvItem = listView1.Items.Add(animSet.Name);
                lvItem.Tag = animSet;
            }
        }

        void ShowAnimationSet(AnimationSet animSet)
        {
            listView2.Items.Clear();
            listView2.Tag = animSet;

            foreach (Animation anim in animSet.Animations)
            {
                ListViewItem lvItem = listView2.Items.Add(anim.Name);
                lvItem.Tag = anim;
            }
        }

        void ShowAnimation(Animation anim)
        {
            listView3.Items.Clear();
            listView3.Tag = anim;

            foreach (AnimationTrack animTrack in anim.AnimTracks)
            {
                ListViewItem lvItem = listView3.Items.Add(animTrack.Name);
                lvItem.Tag = animTrack;
            }
        }

        void ShowAnimationTrack(AnimationTrack animTrack)
        {
            listView4.Items.Clear();
            listView4.Tag = animTrack;

            foreach (AnimationKey animKey in animTrack.AnimKeys)
            {
                ListViewItem lvItem = listView4.Items.Add(animKey.Time.ToString());
                lvItem.Tag = animKey;
            }
        }

        void ShowAnimationKey(AnimationKey animKey)
        {
        }
    }
}
