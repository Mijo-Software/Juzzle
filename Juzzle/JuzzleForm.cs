using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using Juzzle.Properties;

namespace Juzzle
{
  public partial class JuzzleForm : Form
  {
    private const string colon = ":";
    private const string space = " ";
    private const string dot = ".";
    private const string backslash = "/";
    private const string underscore = "_";
    private const string size16 = "16";
    private const string size24 = "24";
    private const string size32 = "32";
    private const string size48 = "48";
    private const string size64 = "64";
    private const string s = "s";
    private const string litUp = "lit" + space + "up";
    private const string marble = "marble";
    private const string colorGrey = "grey";
    private const string colorBlue = "blue";
    private const string colorGreen = "green";
    private const string colorRed = "red";
    private const string colorYellow = "yellow";
    private const string marbleGrey32 = marble + underscore + colorGrey + underscore + size32;
    private const string marbleBlue32 = "marble_blue_32";
    private const string marbleBlue32s = "marble_blue_32_s";
    private const string marbleGreen32 = "marble_green_32";
    private const string marbleGreen32s = "marble_green_32_s";
    private const string marbleRed32 = "marble_red_32";
    private const string marbleRed32s = "marble_red_32_s";
    private const string marbleYellow32 = "marble_yellow_32";
    private const string marbleYellow32s = "marble_yellow_32_s";
    private const string noSoundfileFound = "NO SOUND FILE FOUND!!!";
    private const string soundOff = "sound OFF";
    private const string soundOn = "sound ON";
    private const string defaultNamespace = "Juzzle";
    private const string resources = "Resources";
    private const string dataDirectory = "data" + backslash;
    private const string soundDirectory = dataDirectory + "sound" + backslash;
    private const string buttonClickOggFilename = "button_click.ogg";
    private const string gameOverOggFilename = "game_over.ogg";
    private const string highScoreOggFilename = "high_score.ogg";
    private const string marbleClickOggFilename = "marble_click.ogg";
    private const string newLevelOggFilename = "new_level.ogg";
    private const string perfectRectangleOggFilename = "perfect_rectangle.ogg";
    private const string rectangleCompleteOggFilename = "rectangle_complete.ogg";
    private const string selectionCancelledOggFilename = "selection_cancelled.ogg";
    private const string selectionInvalidOggFilename = "selection_invalid.ogg";
    private const string timeAlertOggFilename = "time_alert.ogg";
    private bool isSoundEnabled = true;
    private bool isGamePaused;
    private readonly Random rnd = new Random();
    private string ButtonInformation;

    public JuzzleForm()=> InitializeComponent();

    #region Eigene Methoden

    private void ClearStatusbar_Leave(object sender, EventArgs e) => toolStripStatusLabelInformation.Text = string.Empty;

    private void ClearStatusbarInformationtext() => toolStripStatusLabelInformation.Text = string.Empty;

    private void SetStatusbarInformationtext(string information) => toolStripStatusLabelInformation.Text = information;

    private Bitmap InitFieldBackground(ref string tag)
    {
      switch (rnd.Next(minValue: 0, maxValue: 4))
      {
        case 0: tag = marbleBlue32; return Resources.marble_blue_32;
        case 1: tag = marbleGreen32; return Resources.marble_green_32;
        case 2: tag = marbleRed32; return Resources.marble_red_32;
        case 3: tag = marbleYellow32; return Resources.marble_yellow_32;
      }
      return null;
    }

    private void SetGamefield()
    {
      string tag = string.Empty;
      button1.BackgroundImage = InitFieldBackground(tag: ref tag);
      button1.Tag = tag;
      button2.BackgroundImage = InitFieldBackground(tag: ref tag);
      button2.Tag = tag;
      button3.BackgroundImage = InitFieldBackground(tag: ref tag);
      button3.Tag = tag;
      button4.BackgroundImage = InitFieldBackground(tag: ref tag);
      button4.Tag = tag;
      button5.BackgroundImage = InitFieldBackground(tag: ref tag);
      button5.Tag = tag;
      button6.BackgroundImage = InitFieldBackground(tag: ref tag);
      button6.Tag = tag;
      button7.BackgroundImage = InitFieldBackground(tag: ref tag);
      button7.Tag = tag;
      button8.BackgroundImage = InitFieldBackground(tag: ref tag);
      button8.Tag = tag;
      button9.BackgroundImage = InitFieldBackground(tag: ref tag);
      button9.Tag = tag;
      button10.BackgroundImage = InitFieldBackground(tag: ref tag);
      button10.Tag = tag;
      button11.BackgroundImage = InitFieldBackground(tag: ref tag);
      button11.Tag = tag;
      button12.BackgroundImage = InitFieldBackground(tag: ref tag);
      button12.Tag = tag;
      button13.BackgroundImage = InitFieldBackground(tag: ref tag);
      button13.Tag = tag;
      button14.BackgroundImage = InitFieldBackground(tag: ref tag);
      button14.Tag = tag;
      button15.BackgroundImage = InitFieldBackground(tag: ref tag);
      button15.Tag = tag;
      button16.BackgroundImage = InitFieldBackground(tag: ref tag);
      button16.Tag = tag;
      button17.BackgroundImage = InitFieldBackground(tag: ref tag);
      button17.Tag = tag;
      button18.BackgroundImage = InitFieldBackground(tag: ref tag);
      button18.Tag = tag;
      button19.BackgroundImage = InitFieldBackground(tag: ref tag);
      button19.Tag = tag;
      button20.BackgroundImage = InitFieldBackground(tag: ref tag);
      button20.Tag = tag;
      button21.BackgroundImage = InitFieldBackground(tag: ref tag);
      button21.Tag = tag;
      button22.BackgroundImage = InitFieldBackground(tag: ref tag);
      button22.Tag = tag;
      button23.BackgroundImage = InitFieldBackground(tag: ref tag);
      button23.Tag = tag;
      button24.BackgroundImage = InitFieldBackground(tag: ref tag);
      button24.Tag = tag;
      button25.BackgroundImage = InitFieldBackground(tag: ref tag);
      button25.Tag = tag;
      button26.BackgroundImage = InitFieldBackground(tag: ref tag);
      button26.Tag = tag;
      button27.BackgroundImage = InitFieldBackground(tag: ref tag);
      button27.Tag = tag;
      button28.BackgroundImage = InitFieldBackground(tag: ref tag);
      button28.Tag = tag;
      button29.BackgroundImage = InitFieldBackground(tag: ref tag);
      button29.Tag = tag;
      button30.BackgroundImage = InitFieldBackground(tag: ref tag);
      button30.Tag = tag;
      button31.BackgroundImage = InitFieldBackground(tag: ref tag);
      button31.Tag = tag;
      button32.BackgroundImage = InitFieldBackground(tag: ref tag);
      button32.Tag = tag;
      button33.BackgroundImage = InitFieldBackground(tag: ref tag);
      button33.Tag = tag;
      button34.BackgroundImage = InitFieldBackground(tag: ref tag);
      button34.Tag = tag;
      button35.BackgroundImage = InitFieldBackground(tag: ref tag);
      button35.Tag = tag;
      button36.BackgroundImage = InitFieldBackground(tag: ref tag);
      button36.Tag = tag;
      button37.BackgroundImage = InitFieldBackground(tag: ref tag);
      button37.Tag = tag;
      button38.BackgroundImage = InitFieldBackground(tag: ref tag);
      button38.Tag = tag;
      button39.BackgroundImage = InitFieldBackground(tag: ref tag);
      button39.Tag = tag;
      button40.BackgroundImage = InitFieldBackground(tag: ref tag);
      button40.Tag = tag;
      button41.BackgroundImage = InitFieldBackground(tag: ref tag);
      button41.Tag = tag;
      button42.BackgroundImage = InitFieldBackground(tag: ref tag);
      button42.Tag = tag;
      button43.BackgroundImage = InitFieldBackground(tag: ref tag);
      button43.Tag = tag;
      button44.BackgroundImage = InitFieldBackground(tag: ref tag);
      button44.Tag = tag;
      button45.BackgroundImage = InitFieldBackground(tag: ref tag);
      button45.Tag = tag;
      button46.BackgroundImage = InitFieldBackground(tag: ref tag);
      button46.Tag = tag;
      button47.BackgroundImage = InitFieldBackground(tag: ref tag);
      button47.Tag = tag;
      button48.BackgroundImage = InitFieldBackground(tag: ref tag);
      button48.Tag = tag;
      button49.BackgroundImage = InitFieldBackground(tag: ref tag);
      button49.Tag = tag;
      button50.BackgroundImage = InitFieldBackground(tag: ref tag);
      button50.Tag = tag;
      button51.BackgroundImage = InitFieldBackground(tag: ref tag);
      button51.Tag = tag;
      button52.BackgroundImage = InitFieldBackground(tag: ref tag);
      button52.Tag = tag;
      button53.BackgroundImage = InitFieldBackground(tag: ref tag);
      button53.Tag = tag;
      button54.BackgroundImage = InitFieldBackground(tag: ref tag);
      button54.Tag = tag;
      button55.BackgroundImage = InitFieldBackground(tag: ref tag);
      button55.Tag = tag;
      button56.BackgroundImage = InitFieldBackground(tag: ref tag);
      button56.Tag = tag;
      button57.BackgroundImage = InitFieldBackground(tag: ref tag);
      button57.Tag = tag;
      button58.BackgroundImage = InitFieldBackground(tag: ref tag);
      button58.Tag = tag;
      button59.BackgroundImage = InitFieldBackground(tag: ref tag);
      button59.Tag = tag;
      button60.BackgroundImage = InitFieldBackground(tag: ref tag);
      button60.Tag = tag;
      button61.BackgroundImage = InitFieldBackground(tag: ref tag);
      button61.Tag = tag;
      button62.BackgroundImage = InitFieldBackground(tag: ref tag);
      button62.Tag = tag;
      button63.BackgroundImage = InitFieldBackground(tag: ref tag);
      button63.Tag = tag;
      button64.BackgroundImage = InitFieldBackground(tag: ref tag);
      button64.Tag = tag;
      button65.BackgroundImage = InitFieldBackground(tag: ref tag);
      button65.Tag = tag;
      button66.BackgroundImage = InitFieldBackground(tag: ref tag);
      button66.Tag = tag;
      button67.BackgroundImage = InitFieldBackground(tag: ref tag);
      button67.Tag = tag;
      button68.BackgroundImage = InitFieldBackground(tag: ref tag);
      button68.Tag = tag;
      button69.BackgroundImage = InitFieldBackground(tag: ref tag);
      button69.Tag = tag;
      button70.BackgroundImage = InitFieldBackground(tag: ref tag);
      button70.Tag = tag;
      button71.BackgroundImage = InitFieldBackground(tag: ref tag);
      button71.Tag = tag;
      button72.BackgroundImage = InitFieldBackground(tag: ref tag);
      button72.Tag = tag;
      button73.BackgroundImage = InitFieldBackground(tag: ref tag);
      button73.Tag = tag;
      button74.BackgroundImage = InitFieldBackground(tag: ref tag);
      button74.Tag = tag;
      button75.BackgroundImage = InitFieldBackground(tag: ref tag);
      button75.Tag = tag;
      button76.BackgroundImage = InitFieldBackground(tag: ref tag);
      button76.Tag = tag;
      button77.BackgroundImage = InitFieldBackground(tag: ref tag);
      button77.Tag = tag;
      button78.BackgroundImage = InitFieldBackground(tag: ref tag);
      button78.Tag = tag;
      button79.BackgroundImage = InitFieldBackground(tag: ref tag);
      button79.Tag = tag;
      button80.BackgroundImage = InitFieldBackground(tag: ref tag);
      button80.Tag = tag;
      button81.BackgroundImage = InitFieldBackground(tag: ref tag);
      button81.Tag = tag;
      button82.BackgroundImage = InitFieldBackground(tag: ref tag);
      button82.Tag = tag;
      button83.BackgroundImage = InitFieldBackground(tag: ref tag);
      button83.Tag = tag;
      button84.BackgroundImage = InitFieldBackground(tag: ref tag);
      button84.Tag = tag;
      button85.BackgroundImage = InitFieldBackground(tag: ref tag);
      button85.Tag = tag;
      button86.BackgroundImage = InitFieldBackground(tag: ref tag);
      button86.Tag = tag;
      button87.BackgroundImage = InitFieldBackground(tag: ref tag);
      button87.Tag = tag;
      button88.BackgroundImage = InitFieldBackground(tag: ref tag);
      button88.Tag = tag;
      button89.BackgroundImage = InitFieldBackground(tag: ref tag);
      button89.Tag = tag;
      button90.BackgroundImage = InitFieldBackground(tag: ref tag);
      button90.Tag = tag;
      button91.BackgroundImage = InitFieldBackground(tag: ref tag);
      button91.Tag = tag;
      button92.BackgroundImage = InitFieldBackground(tag: ref tag);
      button92.Tag = tag;
      button93.BackgroundImage = InitFieldBackground(tag: ref tag);
      button93.Tag = tag;
      button94.BackgroundImage = InitFieldBackground(tag: ref tag);
      button94.Tag = tag;
      button95.BackgroundImage = InitFieldBackground(tag: ref tag);
      button95.Tag = tag;
      button96.BackgroundImage = InitFieldBackground(tag: ref tag);
      button96.Tag = tag;
      button97.BackgroundImage = InitFieldBackground(tag: ref tag);
      button97.Tag = tag;
      button98.BackgroundImage = InitFieldBackground(tag: ref tag);
      button98.Tag = tag;
      button99.BackgroundImage = InitFieldBackground(tag: ref tag);
      button99.Tag = tag;
      button100.BackgroundImage = InitFieldBackground(tag: ref tag);
      button100.Tag = tag;
    }

    private void PlaySoundfile(string ResourceName, string path)
    {
      try
      {
        if (File.Exists(path: path))
        {
          using (FileStream file = new FileStream(path: path, mode: FileMode.Open, access: FileAccess.Read))
          {
            using (SoundPlayer player = new SoundPlayer(stream: new OggDecoder.OggDecodeStream(input: file)))
            {
              player.Play();
            }
          }
        }
        else
        {
          using (Stream file = Assembly.GetExecutingAssembly().GetManifestResourceStream(name: ResourceName))
          {
            using (SoundPlayer player = new SoundPlayer(stream: new OggDecoder.OggDecodeStream(input: file)))
            {
              player.Play();
            }
          }
        }
      }
      catch
      {
        SetStatusbarInformationtext(information: noSoundfileFound);
      }
    }

    private void PlayButtonClick() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + buttonClickOggFilename, path: soundDirectory + buttonClickOggFilename);

    private void PlayNewLevel() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + newLevelOggFilename, path: soundDirectory + newLevelOggFilename);

    private void PlayMarbleClick() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + marbleClickOggFilename, path: soundDirectory + marbleClickOggFilename);

    private void PlayRectangleComplete() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + rectangleCompleteOggFilename, path: soundDirectory + rectangleCompleteOggFilename);

    private void PlaySelectionCancelled() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + selectionCancelledOggFilename, path: soundDirectory + selectionCancelledOggFilename);

    private void PlaySelectionInvalid() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + selectionInvalidOggFilename, path: soundDirectory + selectionInvalidOggFilename);

    private void PlayGameOver() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + gameOverOggFilename, path: soundDirectory + gameOverOggFilename);

    private void PlayHighscore() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + highScoreOggFilename, path: soundDirectory + highScoreOggFilename);

    private void PlayPerfectRectangle() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + perfectRectangleOggFilename, path: soundDirectory + perfectRectangleOggFilename);

    private void PlayTimeAlert() => PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + timeAlertOggFilename, path: soundDirectory + timeAlertOggFilename);

    #endregion

    private void JuzzleForm_Load(object sender, EventArgs e) => SetGamefield();

    #region Button "Sound"

    private void ButtonSound_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled)
      {
        isSoundEnabled = false;
        buttonSound.Image = Resources.unmute;
        SetStatusbarInformationtext(soundOff);
        if (isSoundEnabled)
        {
          PlayButtonClick();
        }
      }
      else if (!isSoundEnabled)
      {
        isSoundEnabled = true;
        buttonSound.Image = Resources.mute;
        SetStatusbarInformationtext(soundOn);
        if (isSoundEnabled)
        {
          PlayButtonClick();
        }
      }
    }

    private void ButtonSound_Enter(object sender, EventArgs e)
    {
      buttonSound.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(buttonSound.AccessibleDescription);
    }

    private void ButtonSound_MouseEnter(object sender, EventArgs e)
    {
      buttonSound.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(buttonSound.AccessibleDescription);
    }

    private void ButtonSound_Leave(object sender, EventArgs e)
    {
      buttonSound.BackgroundImage = Resources.btn_small_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonSound_MouseLeave(object sender, EventArgs e)
    {
      buttonSound.BackgroundImage = Resources.btn_small_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonSound_MouseDown(object sender, MouseEventArgs e)
    {
      buttonSound.BackgroundImage = Resources.btn_small_clicked;
    }

    private void ButtonSound_MouseUp(object sender, MouseEventArgs e)
    {
      buttonSound.BackgroundImage = Resources.btn_small_hover;
    }

    #endregion

    #region Button "High Score"

    private void ButtonHighscore_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled)
      {
        PlayButtonClick();
      }
      //Show high score here
    }

    private void ButtonHighscore_Enter(object sender, EventArgs e)
    {
      buttonHighscore.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(buttonHighscore.AccessibleDescription);
    }

    private void ButtonHighscore_MouseEnter(object sender, EventArgs e)
    {
      buttonHighscore.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(buttonHighscore.AccessibleDescription);
    }

    private void ButtonHighscore_Leave(object sender, EventArgs e)
    {
      buttonHighscore.BackgroundImage = Resources.btn_small_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonHighscore_MouseLeave(object sender, EventArgs e)
    {
      buttonHighscore.BackgroundImage = Resources.btn_small_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonHighscore_MouseDown(object sender, MouseEventArgs e)
    {
      buttonHighscore.BackgroundImage = Resources.btn_small_clicked;
    }

    private void ButtonHighscore_MouseUp(object sender, MouseEventArgs e)
    {
      buttonHighscore.BackgroundImage = Resources.btn_small_hover;
    }

    #endregion

    #region Button "Information"

    private void ButtonInformation_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled)
      {
        PlayButtonClick();
      }
      //Show inforamtion here
    }

    private void ButtonInformation_Enter(object sender, EventArgs e)
    {
      buttonInformation.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(buttonInformation.AccessibleDescription);
    }

    private void ButtonInformation_MouseEnter(object sender, EventArgs e)
    {
      buttonInformation.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(buttonInformation.AccessibleDescription);
    }

    private void ButtonInformation_Leave(object sender, EventArgs e)
    {
      buttonInformation.BackgroundImage = Resources.btn_small_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonInformation_MouseLeave(object sender, EventArgs e)
    {
      buttonInformation.BackgroundImage = Resources.btn_small_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonInformation_MouseDown(object sender, MouseEventArgs e)
    {
      buttonInformation.BackgroundImage = Resources.btn_small_clicked;
    }

    private void ButtonInformation_MouseUp(object sender, MouseEventArgs e)
    {
      buttonInformation.BackgroundImage = Resources.btn_small_hover;
    }

    #endregion

    #region Button "Pause"

    private void ButtonPause_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled)
      {
        PlayButtonClick();
      }

      if (isGamePaused)
      {
        isGamePaused = false;
        buttonPause.Text = "&Pause";
        buttonStart.BackgroundImage = Resources.btn_large_normal;
        buttonStart.Enabled = true;
        button1.Enabled = true;
        button2.Enabled = true;
        button3.Enabled = true;
        button4.Enabled = true;
        button5.Enabled = true;
        button6.Enabled = true;
        button7.Enabled = true;
        button8.Enabled = true;
        button9.Enabled = true;
        button10.Enabled = true;
        button11.Enabled = true;
        button12.Enabled = true;
        button13.Enabled = true;
        button14.Enabled = true;
        button15.Enabled = true;
        button16.Enabled = true;
        button17.Enabled = true;
        button18.Enabled = true;
        button19.Enabled = true;
        button20.Enabled = true;
        button21.Enabled = true;
        button22.Enabled = true;
        button23.Enabled = true;
        button24.Enabled = true;
        button25.Enabled = true;
        button26.Enabled = true;
        button27.Enabled = true;
        button28.Enabled = true;
        button29.Enabled = true;
        button30.Enabled = true;
        button31.Enabled = true;
        button32.Enabled = true;
        button33.Enabled = true;
        button34.Enabled = true;
        button35.Enabled = true;
        button36.Enabled = true;
        button37.Enabled = true;
        button38.Enabled = true;
        button39.Enabled = true;
        button40.Enabled = true;
        button41.Enabled = true;
        button42.Enabled = true;
        button43.Enabled = true;
        button44.Enabled = true;
        button45.Enabled = true;
        button46.Enabled = true;
        button47.Enabled = true;
        button48.Enabled = true;
        button49.Enabled = true;
        button50.Enabled = true;
        button51.Enabled = true;
        button52.Enabled = true;
        button53.Enabled = true;
        button54.Enabled = true;
        button55.Enabled = true;
        button56.Enabled = true;
        button57.Enabled = true;
        button58.Enabled = true;
        button59.Enabled = true;
        button60.Enabled = true;
        button61.Enabled = true;
        button62.Enabled = true;
        button63.Enabled = true;
        button64.Enabled = true;
        button65.Enabled = true;
        button66.Enabled = true;
        button67.Enabled = true;
        button68.Enabled = true;
        button69.Enabled = true;
        button70.Enabled = true;
        button71.Enabled = true;
        button72.Enabled = true;
        button73.Enabled = true;
        button74.Enabled = true;
        button75.Enabled = true;
        button76.Enabled = true;
        button77.Enabled = true;
        button78.Enabled = true;
        button79.Enabled = true;
        button80.Enabled = true;
        button81.Enabled = true;
        button82.Enabled = true;
        button83.Enabled = true;
        button84.Enabled = true;
        button85.Enabled = true;
        button86.Enabled = true;
        button87.Enabled = true;
        button88.Enabled = true;
        button89.Enabled = true;
        button90.Enabled = true;
        button91.Enabled = true;
        button92.Enabled = true;
        button93.Enabled = true;
        button94.Enabled = true;
        button95.Enabled = true;
        button96.Enabled = true;
        button97.Enabled = true;
        button98.Enabled = true;
        button99.Enabled = true;
        button100.Enabled = true;
        switch (button1.Tag.ToString())
        {
          case marbleBlue32: button1.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button1.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button1.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button1.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button1.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button1.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button1.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button1.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button2.Tag.ToString())
        {
          case marbleBlue32: button2.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button2.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button2.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button2.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button2.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button2.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button2.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button2.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button3.Tag.ToString())
        {
          case marbleBlue32: button3.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button3.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button3.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button3.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button3.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button3.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button3.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button3.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button4.Tag.ToString())
        {
          case marbleBlue32: button4.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button4.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button4.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button4.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button4.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button4.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button4.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button4.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button5.Tag.ToString())
        {
          case marbleBlue32: button5.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button5.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button5.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button5.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button5.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button5.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button5.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button5.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button6.Tag.ToString())
        {
          case marbleBlue32: button6.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button6.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button6.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button6.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button6.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button6.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button6.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button6.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button7.Tag.ToString())
        {
          case marbleBlue32: button7.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button7.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button7.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button7.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button7.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button7.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button7.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button7.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button8.Tag.ToString())
        {
          case marbleBlue32: button8.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button8.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button8.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button8.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button8.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button8.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button8.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button8.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button9.Tag.ToString())
        {
          case marbleBlue32: button9.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button9.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button9.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button9.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button9.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button9.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button9.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button9.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button10.Tag.ToString())
        {
          case marbleBlue32: button10.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button10.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button10.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button10.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button10.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button10.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button10.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button10.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button11.Tag.ToString())
        {
          case marbleBlue32: button11.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button11.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button11.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button11.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button11.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button11.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button11.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button11.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button12.Tag.ToString())
        {
          case marbleBlue32: button12.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button12.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button12.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button12.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button12.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button12.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button12.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button12.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button13.Tag.ToString())
        {
          case marbleBlue32: button13.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button13.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button13.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button13.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button13.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button13.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button13.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button13.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button14.Tag.ToString())
        {
          case marbleBlue32: button14.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button14.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button14.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button14.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button14.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button14.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button14.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button14.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button15.Tag.ToString())
        {
          case marbleBlue32: button15.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button15.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button15.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button15.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button15.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button15.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button15.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button15.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button16.Tag.ToString())
        {
          case marbleBlue32: button16.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button16.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button16.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button16.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button16.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button16.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button16.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button16.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button17.Tag.ToString())
        {
          case marbleBlue32: button17.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button17.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button17.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button17.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button17.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button17.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button17.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button17.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button18.Tag.ToString())
        {
          case marbleBlue32: button18.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button18.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button18.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button18.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button18.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button18.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button18.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button18.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button19.Tag.ToString())
        {
          case marbleBlue32: button19.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button19.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button19.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button19.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button19.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button19.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button19.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button19.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button20.Tag.ToString())
        {
          case marbleBlue32: button20.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button20.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button20.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button20.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button20.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button20.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button20.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button20.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button21.Tag.ToString())
        {
          case marbleBlue32: button21.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button21.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button21.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button21.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button21.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button21.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button21.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button21.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button22.Tag.ToString())
        {
          case marbleBlue32: button22.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button22.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button22.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button22.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button22.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button22.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button22.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button22.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button23.Tag.ToString())
        {
          case marbleBlue32: button23.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button23.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button23.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button23.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button23.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button23.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button23.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button23.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button24.Tag.ToString())
        {
          case marbleBlue32: button24.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button24.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button24.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button24.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button24.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button24.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button24.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button24.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button25.Tag.ToString())
        {
          case marbleBlue32: button25.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button25.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button25.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button25.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button25.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button25.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button25.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button25.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button26.Tag.ToString())
        {
          case marbleBlue32: button26.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button26.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button26.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button26.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button26.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button26.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button26.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button26.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button27.Tag.ToString())
        {
          case marbleBlue32: button27.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button27.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button27.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button27.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button27.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button27.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button27.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button27.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button28.Tag.ToString())
        {
          case marbleBlue32: button28.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button28.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button28.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button28.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button28.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button28.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button28.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button28.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button29.Tag.ToString())
        {
          case marbleBlue32: button29.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button29.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button29.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button29.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button29.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button29.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button29.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button29.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button30.Tag.ToString())
        {
          case marbleBlue32: button30.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button30.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button30.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button30.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button30.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button30.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button30.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button30.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button31.Tag.ToString())
        {
          case marbleBlue32: button31.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button31.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button31.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button31.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button31.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button31.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button31.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button31.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button32.Tag.ToString())
        {
          case marbleBlue32: button32.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button32.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button32.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button32.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button32.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button32.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button32.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button32.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button33.Tag.ToString())
        {
          case marbleBlue32: button33.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button33.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button33.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button33.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button33.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button33.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button33.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button33.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button34.Tag.ToString())
        {
          case marbleBlue32: button34.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button34.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button34.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button34.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button34.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button34.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button34.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button34.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button35.Tag.ToString())
        {
          case marbleBlue32: button35.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button35.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button35.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button35.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button35.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button35.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button35.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button35.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button36.Tag.ToString())
        {
          case marbleBlue32: button36.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button36.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button36.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button36.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button36.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button36.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button36.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button36.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button37.Tag.ToString())
        {
          case marbleBlue32: button37.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button37.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button37.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button37.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button37.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button37.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button37.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button37.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button38.Tag.ToString())
        {
          case marbleBlue32: button38.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button38.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button38.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button38.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button38.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button38.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button38.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button38.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button39.Tag.ToString())
        {
          case marbleBlue32: button39.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button39.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button39.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button39.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button39.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button39.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button39.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button39.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button40.Tag.ToString())
        {
          case marbleBlue32: button40.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button40.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button40.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button40.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button40.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button40.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button40.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button40.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button41.Tag.ToString())
        {
          case marbleBlue32: button41.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button41.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button41.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button41.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button41.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button41.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button41.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button41.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button42.Tag.ToString())
        {
          case marbleBlue32: button42.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button42.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button42.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button42.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button42.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button42.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button42.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button42.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button43.Tag.ToString())
        {
          case marbleBlue32: button43.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button43.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button43.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button43.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button43.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button43.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button43.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button43.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button44.Tag.ToString())
        {
          case marbleBlue32: button44.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button44.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button44.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button44.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button44.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button44.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button44.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button44.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button45.Tag.ToString())
        {
          case marbleBlue32: button45.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button45.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button45.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button45.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button45.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button45.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button45.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button45.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button46.Tag.ToString())
        {
          case marbleBlue32: button46.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button46.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button46.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button46.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button46.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button46.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button46.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button46.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button47.Tag.ToString())
        {
          case marbleBlue32: button47.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button47.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button47.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button47.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button47.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button47.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button47.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button47.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button48.Tag.ToString())
        {
          case marbleBlue32: button48.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button48.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button48.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button48.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button48.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button48.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button48.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button48.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button49.Tag.ToString())
        {
          case marbleBlue32: button49.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button49.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button49.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button49.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button49.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button49.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button49.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button49.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button50.Tag.ToString())
        {
          case marbleBlue32: button50.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button50.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button50.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button50.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button50.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button50.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button50.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button50.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button51.Tag.ToString())
        {
          case marbleBlue32: button51.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button51.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button51.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button51.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button51.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button51.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button51.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button51.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button52.Tag.ToString())
        {
          case marbleBlue32: button52.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button52.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button52.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button52.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button52.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button52.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button52.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button52.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button53.Tag.ToString())
        {
          case marbleBlue32: button53.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button53.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button53.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button53.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button53.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button53.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button53.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button53.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button54.Tag.ToString())
        {
          case marbleBlue32: button54.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button54.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button54.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button54.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button54.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button54.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button54.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button54.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button55.Tag.ToString())
        {
          case marbleBlue32: button55.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button55.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button55.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button55.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button55.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button55.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button55.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button55.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button56.Tag.ToString())
        {
          case marbleBlue32: button56.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button56.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button56.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button56.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button56.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button56.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button56.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button56.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button57.Tag.ToString())
        {
          case marbleBlue32: button57.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button57.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button57.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button57.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button57.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button57.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button57.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button57.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button58.Tag.ToString())
        {
          case marbleBlue32: button58.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button58.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button58.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button58.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button58.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button58.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button58.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button58.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button59.Tag.ToString())
        {
          case marbleBlue32: button59.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button59.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button59.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button59.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button59.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button59.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button59.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button59.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button60.Tag.ToString())
        {
          case marbleBlue32: button60.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button60.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button60.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button60.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button60.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button60.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button60.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button60.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button61.Tag.ToString())
        {
          case marbleBlue32: button61.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button61.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button61.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button61.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button61.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button61.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button61.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button61.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button62.Tag.ToString())
        {
          case marbleBlue32: button62.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button62.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button62.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button62.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button62.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button62.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button62.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button62.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button63.Tag.ToString())
        {
          case marbleBlue32: button63.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button63.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button63.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button63.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button63.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button63.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button63.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button63.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button64.Tag.ToString())
        {
          case marbleBlue32: button64.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button64.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button64.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button64.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button64.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button64.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button64.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button64.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button65.Tag.ToString())
        {
          case marbleBlue32: button65.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button65.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button65.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button65.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button65.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button65.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button65.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button65.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button66.Tag.ToString())
        {
          case marbleBlue32: button66.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button66.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button66.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button66.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button66.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button66.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button66.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button66.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button67.Tag.ToString())
        {
          case marbleBlue32: button67.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button67.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button67.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button67.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button67.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button67.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button67.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button67.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button68.Tag.ToString())
        {
          case marbleBlue32: button68.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button68.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button68.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button68.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button68.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button68.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button68.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button68.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button69.Tag.ToString())
        {
          case marbleBlue32: button69.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button69.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button69.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button69.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button69.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button69.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button69.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button69.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button70.Tag.ToString())
        {
          case marbleBlue32: button70.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button70.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button70.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button70.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button70.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button70.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button70.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button70.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button71.Tag.ToString())
        {
          case marbleBlue32: button71.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button71.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button71.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button71.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button71.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button71.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button71.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button71.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button72.Tag.ToString())
        {
          case marbleBlue32: button72.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button72.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button72.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button72.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button72.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button72.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button72.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button72.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button73.Tag.ToString())
        {
          case marbleBlue32: button73.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button73.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button73.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button73.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button73.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button73.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button73.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button73.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button74.Tag.ToString())
        {
          case marbleBlue32: button74.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button74.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button74.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button74.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button74.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button74.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button74.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button74.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button75.Tag.ToString())
        {
          case marbleBlue32: button75.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button75.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button75.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button75.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button75.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button75.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button75.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button75.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button76.Tag.ToString())
        {
          case marbleBlue32: button76.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button76.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button76.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button76.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button76.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button76.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button76.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button76.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button77.Tag.ToString())
        {
          case marbleBlue32: button77.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button77.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button77.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button77.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button77.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button77.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button77.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button77.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button78.Tag.ToString())
        {
          case marbleBlue32: button78.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button78.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button78.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button78.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button78.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button78.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button78.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button78.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button79.Tag.ToString())
        {
          case marbleBlue32: button79.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button79.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button79.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button79.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button79.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button79.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button79.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button79.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button80.Tag.ToString())
        {
          case marbleBlue32: button80.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button80.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button80.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button80.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button80.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button80.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button80.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button80.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button81.Tag.ToString())
        {
          case marbleBlue32: button81.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button81.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button81.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button81.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button81.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button81.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button81.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button81.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button82.Tag.ToString())
        {
          case marbleBlue32: button82.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button82.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button82.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button82.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button82.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button82.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button82.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button82.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button83.Tag.ToString())
        {
          case marbleBlue32: button83.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button83.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button83.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button83.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button83.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button83.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button83.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button83.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button84.Tag.ToString())
        {
          case marbleBlue32: button84.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button84.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button84.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button84.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button84.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button84.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button84.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button84.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button85.Tag.ToString())
        {
          case marbleBlue32: button85.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button85.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button85.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button85.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button85.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button85.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button85.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button85.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button86.Tag.ToString())
        {
          case marbleBlue32: button86.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button86.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button86.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button86.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button86.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button86.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button86.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button86.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button87.Tag.ToString())
        {
          case marbleBlue32: button87.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button87.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button87.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button87.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button87.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button87.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button87.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button87.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button88.Tag.ToString())
        {
          case marbleBlue32: button88.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button88.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button88.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button88.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button88.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button88.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button88.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button88.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button89.Tag.ToString())
        {
          case marbleBlue32: button89.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button89.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button89.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button89.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button89.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button89.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button89.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button89.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button90.Tag.ToString())
        {
          case marbleBlue32: button90.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button90.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button90.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button90.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button90.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button90.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button90.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button90.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button91.Tag.ToString())
        {
          case marbleBlue32: button91.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button91.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button91.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button91.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button91.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button91.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button91.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button91.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button92.Tag.ToString())
        {
          case marbleBlue32: button92.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button92.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button92.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button92.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button92.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button92.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button92.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button92.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button93.Tag.ToString())
        {
          case marbleBlue32: button93.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button93.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button93.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button93.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button93.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button93.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button93.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button93.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button94.Tag.ToString())
        {
          case marbleBlue32: button94.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button94.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button94.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button94.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button94.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button94.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button94.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button94.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button95.Tag.ToString())
        {
          case marbleBlue32: button95.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button95.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button95.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button95.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button95.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button95.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button95.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button95.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button96.Tag.ToString())
        {
          case marbleBlue32: button96.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button96.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button96.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button96.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button96.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button96.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button96.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button96.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button97.Tag.ToString())
        {
          case marbleBlue32: button97.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button97.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button97.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button97.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button97.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button97.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button97.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button97.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button98.Tag.ToString())
        {
          case marbleBlue32: button98.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button98.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button98.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button98.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button98.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button98.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button98.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button98.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button99.Tag.ToString())
        {
          case marbleBlue32: button99.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button99.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button99.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button99.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button99.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button99.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button99.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button99.BackgroundImage = Resources.marble_yellow_32_s; break;
        }
        switch (button100.Tag.ToString())
        {
          case marbleBlue32: button100.BackgroundImage = Resources.marble_blue_32; break;
          case marbleGreen32: button100.BackgroundImage = Resources.marble_green_32; break;
          case marbleRed32: button100.BackgroundImage = Resources.marble_red_32; break;
          case marbleYellow32: button100.BackgroundImage = Resources.marble_yellow_32; break;
          case marbleBlue32s: button100.BackgroundImage = Resources.marble_blue_32_s; break;
          case marbleGreen32s: button100.BackgroundImage = Resources.marble_green_32_s; break;
          case marbleRed32s: button100.BackgroundImage = Resources.marble_red_32_s; break;
          case marbleYellow32s: button100.BackgroundImage = Resources.marble_yellow_32_s; break;
        }






      }
      else if (!isGamePaused)
      {
        isGamePaused = true;
        buttonPause.Text = "&Resume";
        buttonStart.BackgroundImage = Resources.btn_large_disabled;
        buttonStart.Enabled = false;
        button1.Enabled = false;
        button2.Enabled = false;
        button3.Enabled = false;
        button4.Enabled = false;
        button5.Enabled = false;
        button6.Enabled = false;
        button7.Enabled = false;
        button8.Enabled = false;
        button9.Enabled = false;
        button10.Enabled = false;
        button11.Enabled = false;
        button12.Enabled = false;
        button13.Enabled = false;
        button14.Enabled = false;
        button15.Enabled = false;
        button16.Enabled = false;
        button17.Enabled = false;
        button18.Enabled = false;
        button19.Enabled = false;
        button20.Enabled = false;
        button21.Enabled = false;
        button22.Enabled = false;
        button23.Enabled = false;
        button24.Enabled = false;
        button25.Enabled = false;
        button26.Enabled = false;
        button27.Enabled = false;
        button28.Enabled = false;
        button29.Enabled = false;
        button30.Enabled = false;
        button31.Enabled = false;
        button32.Enabled = false;
        button33.Enabled = false;
        button34.Enabled = false;
        button35.Enabled = false;
        button36.Enabled = false;
        button37.Enabled = false;
        button38.Enabled = false;
        button39.Enabled = false;
        button40.Enabled = false;
        button41.Enabled = false;
        button42.Enabled = false;
        button43.Enabled = false;
        button44.Enabled = false;
        button45.Enabled = false;
        button46.Enabled = false;
        button47.Enabled = false;
        button48.Enabled = false;
        button49.Enabled = false;
        button50.Enabled = false;
        button51.Enabled = false;
        button52.Enabled = false;
        button53.Enabled = false;
        button54.Enabled = false;
        button55.Enabled = false;
        button56.Enabled = false;
        button57.Enabled = false;
        button58.Enabled = false;
        button59.Enabled = false;
        button60.Enabled = false;
        button61.Enabled = false;
        button62.Enabled = false;
        button63.Enabled = false;
        button64.Enabled = false;
        button65.Enabled = false;
        button66.Enabled = false;
        button67.Enabled = false;
        button68.Enabled = false;
        button69.Enabled = false;
        button70.Enabled = false;
        button71.Enabled = false;
        button72.Enabled = false;
        button73.Enabled = false;
        button74.Enabled = false;
        button75.Enabled = false;
        button76.Enabled = false;
        button77.Enabled = false;
        button78.Enabled = false;
        button79.Enabled = false;
        button80.Enabled = false;
        button81.Enabled = false;
        button82.Enabled = false;
        button83.Enabled = false;
        button84.Enabled = false;
        button85.Enabled = false;
        button86.Enabled = false;
        button87.Enabled = false;
        button88.Enabled = false;
        button89.Enabled = false;
        button90.Enabled = false;
        button91.Enabled = false;
        button92.Enabled = false;
        button93.Enabled = false;
        button94.Enabled = false;
        button95.Enabled = false;
        button96.Enabled = false;
        button97.Enabled = false;
        button98.Enabled = false;
        button99.Enabled = false;
        button100.Enabled = false;
        button1.BackgroundImage = Resources.marble_grey_32;
        button2.BackgroundImage = Resources.marble_grey_32;
        button3.BackgroundImage = Resources.marble_grey_32;
        button4.BackgroundImage = Resources.marble_grey_32;
        button5.BackgroundImage = Resources.marble_grey_32;
        button6.BackgroundImage = Resources.marble_grey_32;
        button7.BackgroundImage = Resources.marble_grey_32;
        button8.BackgroundImage = Resources.marble_grey_32;
        button9.BackgroundImage = Resources.marble_grey_32;
        button10.BackgroundImage = Resources.marble_grey_32;
        button11.BackgroundImage = Resources.marble_grey_32;
        button12.BackgroundImage = Resources.marble_grey_32;
        button13.BackgroundImage = Resources.marble_grey_32;
        button14.BackgroundImage = Resources.marble_grey_32;
        button15.BackgroundImage = Resources.marble_grey_32;
        button16.BackgroundImage = Resources.marble_grey_32;
        button17.BackgroundImage = Resources.marble_grey_32;
        button18.BackgroundImage = Resources.marble_grey_32;
        button19.BackgroundImage = Resources.marble_grey_32;
        button20.BackgroundImage = Resources.marble_grey_32;
        button21.BackgroundImage = Resources.marble_grey_32;
        button22.BackgroundImage = Resources.marble_grey_32;
        button23.BackgroundImage = Resources.marble_grey_32;
        button24.BackgroundImage = Resources.marble_grey_32;
        button25.BackgroundImage = Resources.marble_grey_32;
        button26.BackgroundImage = Resources.marble_grey_32;
        button27.BackgroundImage = Resources.marble_grey_32;
        button28.BackgroundImage = Resources.marble_grey_32;
        button29.BackgroundImage = Resources.marble_grey_32;
        button30.BackgroundImage = Resources.marble_grey_32;
        button31.BackgroundImage = Resources.marble_grey_32;
        button32.BackgroundImage = Resources.marble_grey_32;
        button33.BackgroundImage = Resources.marble_grey_32;
        button34.BackgroundImage = Resources.marble_grey_32;
        button35.BackgroundImage = Resources.marble_grey_32;
        button36.BackgroundImage = Resources.marble_grey_32;
        button37.BackgroundImage = Resources.marble_grey_32;
        button38.BackgroundImage = Resources.marble_grey_32;
        button39.BackgroundImage = Resources.marble_grey_32;
        button40.BackgroundImage = Resources.marble_grey_32;
        button41.BackgroundImage = Resources.marble_grey_32;
        button42.BackgroundImage = Resources.marble_grey_32;
        button43.BackgroundImage = Resources.marble_grey_32;
        button44.BackgroundImage = Resources.marble_grey_32;
        button45.BackgroundImage = Resources.marble_grey_32;
        button46.BackgroundImage = Resources.marble_grey_32;
        button47.BackgroundImage = Resources.marble_grey_32;
        button48.BackgroundImage = Resources.marble_grey_32;
        button49.BackgroundImage = Resources.marble_grey_32;
        button50.BackgroundImage = Resources.marble_grey_32;
        button51.BackgroundImage = Resources.marble_grey_32;
        button52.BackgroundImage = Resources.marble_grey_32;
        button53.BackgroundImage = Resources.marble_grey_32;
        button54.BackgroundImage = Resources.marble_grey_32;
        button55.BackgroundImage = Resources.marble_grey_32;
        button56.BackgroundImage = Resources.marble_grey_32;
        button57.BackgroundImage = Resources.marble_grey_32;
        button58.BackgroundImage = Resources.marble_grey_32;
        button59.BackgroundImage = Resources.marble_grey_32;
        button60.BackgroundImage = Resources.marble_grey_32;
        button61.BackgroundImage = Resources.marble_grey_32;
        button62.BackgroundImage = Resources.marble_grey_32;
        button63.BackgroundImage = Resources.marble_grey_32;
        button64.BackgroundImage = Resources.marble_grey_32;
        button65.BackgroundImage = Resources.marble_grey_32;
        button66.BackgroundImage = Resources.marble_grey_32;
        button67.BackgroundImage = Resources.marble_grey_32;
        button68.BackgroundImage = Resources.marble_grey_32;
        button69.BackgroundImage = Resources.marble_grey_32;
        button70.BackgroundImage = Resources.marble_grey_32;
        button71.BackgroundImage = Resources.marble_grey_32;
        button72.BackgroundImage = Resources.marble_grey_32;
        button73.BackgroundImage = Resources.marble_grey_32;
        button74.BackgroundImage = Resources.marble_grey_32;
        button75.BackgroundImage = Resources.marble_grey_32;
        button76.BackgroundImage = Resources.marble_grey_32;
        button77.BackgroundImage = Resources.marble_grey_32;
        button78.BackgroundImage = Resources.marble_grey_32;
        button79.BackgroundImage = Resources.marble_grey_32;
        button80.BackgroundImage = Resources.marble_grey_32;
        button81.BackgroundImage = Resources.marble_grey_32;
        button82.BackgroundImage = Resources.marble_grey_32;
        button83.BackgroundImage = Resources.marble_grey_32;
        button84.BackgroundImage = Resources.marble_grey_32;
        button85.BackgroundImage = Resources.marble_grey_32;
        button86.BackgroundImage = Resources.marble_grey_32;
        button87.BackgroundImage = Resources.marble_grey_32;
        button88.BackgroundImage = Resources.marble_grey_32;
        button89.BackgroundImage = Resources.marble_grey_32;
        button90.BackgroundImage = Resources.marble_grey_32;
        button91.BackgroundImage = Resources.marble_grey_32;
        button92.BackgroundImage = Resources.marble_grey_32;
        button93.BackgroundImage = Resources.marble_grey_32;
        button94.BackgroundImage = Resources.marble_grey_32;
        button95.BackgroundImage = Resources.marble_grey_32;
        button96.BackgroundImage = Resources.marble_grey_32;
        button97.BackgroundImage = Resources.marble_grey_32;
        button98.BackgroundImage = Resources.marble_grey_32;
        button99.BackgroundImage = Resources.marble_grey_32;
        button100.BackgroundImage = Resources.marble_grey_32;
      }
    }

    private void ButtonPause_Enter(object sender, EventArgs e)
    {
      buttonPause.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(buttonPause.AccessibleDescription);
    }

    private void ButtonPause_MouseEnter(object sender, EventArgs e)
    {
      buttonPause.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(buttonPause.AccessibleDescription);
    }

    private void ButtonPause_Leave(object sender, EventArgs e)
    {
      buttonPause.BackgroundImage = Resources.btn_large_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonPause_MouseLeave(object sender, EventArgs e)
    {
      buttonPause.BackgroundImage = Resources.btn_large_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonPause_MouseDown(object sender, MouseEventArgs e)
    {
      buttonPause.BackgroundImage = Resources.btn_large_clicked;
    }

    private void ButtonPause_MouseUp(object sender, MouseEventArgs e)
    {
      buttonPause.BackgroundImage = Resources.btn_large_hover;
    }

    #endregion

    #region Button "Start"

    private void ButtonStart_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled)
      {
        PlayButtonClick();
      }

      SetGamefield();
    }

    private void ButtonStart_Enter(object sender, EventArgs e)
    {
      buttonStart.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(buttonStart.AccessibleDescription);
    }

    private void ButtonStart_MouseEnter(object sender, EventArgs e)
    {
      buttonStart.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(buttonStart.AccessibleDescription);
    }

    private void ButtonStart_Leave(object sender, EventArgs e)
    {
      buttonStart.BackgroundImage = Resources.btn_large_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonStart_MouseLeave(object sender, EventArgs e)
    {
      buttonStart.BackgroundImage = Resources.btn_large_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonStart_MouseDown(object sender, MouseEventArgs e)
    {
      buttonStart.BackgroundImage = Resources.btn_large_clicked;
    }

    private void ButtonStart_MouseUp(object sender, MouseEventArgs e)
    {
      buttonStart.BackgroundImage = Resources.btn_large_hover;
    }

    #endregion

    #region Button "Quit"

    private void ButtonQuit_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled)
      {
        PlayButtonClick();
      }

      Close();
    }

    private void ButtonQuit_Enter(object sender, EventArgs e)
    {
      buttonQuit.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(buttonQuit.AccessibleDescription);
    }

    private void ButtonQuit_MouseEnter(object sender, EventArgs e)
    {
      buttonQuit.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(buttonQuit.AccessibleDescription);
    }

    private void ButtonQuit_Leave(object sender, EventArgs e)
    {
      buttonQuit.BackgroundImage = Resources.btn_large_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonQuit_MouseLeave(object sender, EventArgs e)
    {
      buttonQuit.BackgroundImage = Resources.btn_large_normal;
      ClearStatusbarInformationtext();
    }

    private void ButtonQuit_MouseDown(object sender, MouseEventArgs e)
    {
      buttonQuit.BackgroundImage = Resources.btn_large_clicked;
    }

    private void ButtonQuit_MouseUp(object sender, MouseEventArgs e)
    {
      buttonQuit.BackgroundImage = Resources.btn_large_hover;
    }


    #endregion

    private void Button1_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button1.AccessibleName + colon + space;
      switch (button1.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      switch (button2.Tag.ToString())
      {
        case marbleBlue32: button2.BackgroundImage = Resources.marble_blue_32_s; button2.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button2.BackgroundImage = Resources.marble_blue_32; button2.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button2.BackgroundImage = Resources.marble_green_32_s; button2.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button2.BackgroundImage = Resources.marble_green_32; button2.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button2.BackgroundImage = Resources.marble_red_32_s; button2.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button2.BackgroundImage = Resources.marble_red_32; button2.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button2.BackgroundImage = Resources.marble_yellow_32_s; button2.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button2.BackgroundImage = Resources.marble_yellow_32; button2.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button2_Enter(sender, e);
    }

    private void Button2_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button2.AccessibleName + colon + space;
      switch (button2.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      switch (button3.Tag.ToString())
      {
        case marbleBlue32: button3.BackgroundImage = Resources.marble_blue_32_s; button3.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button3.BackgroundImage = Resources.marble_blue_32; button3.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button3.BackgroundImage = Resources.marble_green_32_s; button3.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button3.BackgroundImage = Resources.marble_green_32; button3.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button3.BackgroundImage = Resources.marble_red_32_s; button3.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button3.BackgroundImage = Resources.marble_red_32; button3.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button3.BackgroundImage = Resources.marble_yellow_32_s; button3.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button3.BackgroundImage = Resources.marble_yellow_32; button3.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button3_Enter(sender, e);
    }

    private void Button3_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button3.AccessibleName + colon + space;
      switch (button3.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      switch (button4.Tag.ToString())
      {
        case marbleBlue32: button4.BackgroundImage = Resources.marble_blue_32_s; button4.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button4.BackgroundImage = Resources.marble_blue_32; button4.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button4.BackgroundImage = Resources.marble_green_32_s; button4.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button4.BackgroundImage = Resources.marble_green_32; button4.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button4.BackgroundImage = Resources.marble_red_32_s; button4.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button4.BackgroundImage = Resources.marble_red_32; button4.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button4.BackgroundImage = Resources.marble_yellow_32_s; button4.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button4.BackgroundImage = Resources.marble_yellow_32; button4.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button4_Enter(sender, e);
    }

    private void Button4_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button4.AccessibleName + colon + space;
      switch (button4.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      switch (button5.Tag.ToString())
      {
        case marbleBlue32: button5.BackgroundImage = Resources.marble_blue_32_s; button5.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button5.BackgroundImage = Resources.marble_blue_32; button5.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button5.BackgroundImage = Resources.marble_green_32_s; button5.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button5.BackgroundImage = Resources.marble_green_32; button5.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button5.BackgroundImage = Resources.marble_red_32_s; button5.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button5.BackgroundImage = Resources.marble_red_32; button5.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button5.BackgroundImage = Resources.marble_yellow_32_s; button5.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button5.BackgroundImage = Resources.marble_yellow_32; button5.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button5_Enter(sender, e);
    }

    private void Button5_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button5.AccessibleName + colon + space;
      switch (button5.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      switch (button6.Tag.ToString())
      {
        case marbleBlue32: button6.BackgroundImage = Resources.marble_blue_32_s; button6.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button6.BackgroundImage = Resources.marble_blue_32; button6.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button6.BackgroundImage = Resources.marble_green_32_s; button6.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button6.BackgroundImage = Resources.marble_green_32; button6.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button6.BackgroundImage = Resources.marble_red_32_s; button6.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button6.BackgroundImage = Resources.marble_red_32; button6.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button6.BackgroundImage = Resources.marble_yellow_32_s; button6.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button6.BackgroundImage = Resources.marble_yellow_32; button6.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button6_Enter(sender, e);
    }

    private void Button6_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button6.AccessibleName + colon + space;
      switch (button6.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button7_Click(object sender, EventArgs e)
    {
      switch (button7.Tag.ToString())
      {
        case marbleBlue32: button7.BackgroundImage = Resources.marble_blue_32_s; button7.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button7.BackgroundImage = Resources.marble_blue_32; button7.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button7.BackgroundImage = Resources.marble_green_32_s; button7.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button7.BackgroundImage = Resources.marble_green_32; button7.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button7.BackgroundImage = Resources.marble_red_32_s; button7.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button7.BackgroundImage = Resources.marble_red_32; button7.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button7.BackgroundImage = Resources.marble_yellow_32_s; button7.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button7.BackgroundImage = Resources.marble_yellow_32; button7.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button7_Enter(sender, e);
    }

    private void Button7_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button7.AccessibleName + colon + space;
      switch (button7.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button8_Click(object sender, EventArgs e)
    {
      switch (button8.Tag.ToString())
      {
        case marbleBlue32: button8.BackgroundImage = Resources.marble_blue_32_s; button8.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button8.BackgroundImage = Resources.marble_blue_32; button8.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button8.BackgroundImage = Resources.marble_green_32_s; button8.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button8.BackgroundImage = Resources.marble_green_32; button8.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button8.BackgroundImage = Resources.marble_red_32_s; button8.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button8.BackgroundImage = Resources.marble_red_32; button8.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button8.BackgroundImage = Resources.marble_yellow_32_s; button8.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button8.BackgroundImage = Resources.marble_yellow_32; button8.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button8_Enter(sender, e);
    }

    private void Button8_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button8.AccessibleName + colon + space;
      switch (button8.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button9_Click(object sender, EventArgs e)
    {
      switch (button9.Tag.ToString())
      {
        case marbleBlue32: button9.BackgroundImage = Resources.marble_blue_32_s; button9.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button9.BackgroundImage = Resources.marble_blue_32; button9.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button9.BackgroundImage = Resources.marble_green_32_s; button9.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button9.BackgroundImage = Resources.marble_green_32; button9.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button9.BackgroundImage = Resources.marble_red_32_s; button9.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button9.BackgroundImage = Resources.marble_red_32; button9.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button9.BackgroundImage = Resources.marble_yellow_32_s; button9.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button9.BackgroundImage = Resources.marble_yellow_32; button9.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button9_Enter(sender, e);
    }

    private void Button9_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button9.AccessibleName + colon + space;
      switch (button9.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button10_Click(object sender, EventArgs e)
    {
      switch (button10.Tag.ToString())
      {
        case marbleBlue32: button10.BackgroundImage = Resources.marble_blue_32_s; button10.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button10.BackgroundImage = Resources.marble_blue_32; button10.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button10.BackgroundImage = Resources.marble_green_32_s; button10.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button10.BackgroundImage = Resources.marble_green_32; button10.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button10.BackgroundImage = Resources.marble_red_32_s; button10.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button10.BackgroundImage = Resources.marble_red_32; button10.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button10.BackgroundImage = Resources.marble_yellow_32_s; button10.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button10.BackgroundImage = Resources.marble_yellow_32; button10.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button10_Enter(sender, e);
    }

    private void Button10_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button10.AccessibleName + colon + space;
      switch (button10.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button11_Click(object sender, EventArgs e)
    {
      switch (button11.Tag.ToString())
      {
        case marbleBlue32: button11.BackgroundImage = Resources.marble_blue_32_s; button11.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button11.BackgroundImage = Resources.marble_blue_32; button11.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button11.BackgroundImage = Resources.marble_green_32_s; button11.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button11.BackgroundImage = Resources.marble_green_32; button11.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button11.BackgroundImage = Resources.marble_red_32_s; button11.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button11.BackgroundImage = Resources.marble_red_32; button11.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button11.BackgroundImage = Resources.marble_yellow_32_s; button11.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button11.BackgroundImage = Resources.marble_yellow_32; button11.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button11_Enter(sender, e);
    }

    private void Button11_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button11.AccessibleName + colon + space;
      switch (button11.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button12_Click(object sender, EventArgs e)
    {
      switch (button12.Tag.ToString())
      {
        case marbleBlue32: button12.BackgroundImage = Resources.marble_blue_32_s; button12.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button12.BackgroundImage = Resources.marble_blue_32; button12.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button12.BackgroundImage = Resources.marble_green_32_s; button12.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button12.BackgroundImage = Resources.marble_green_32; button12.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button12.BackgroundImage = Resources.marble_red_32_s; button12.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button12.BackgroundImage = Resources.marble_red_32; button12.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button12.BackgroundImage = Resources.marble_yellow_32_s; button12.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button12.BackgroundImage = Resources.marble_yellow_32; button12.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button12_Enter(sender, e);
    }

    private void Button12_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button12.AccessibleName + colon + space;
      switch (button12.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button13_Click(object sender, EventArgs e)
    {
      switch (button13.Tag.ToString())
      {
        case marbleBlue32: button13.BackgroundImage = Resources.marble_blue_32_s; button13.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button13.BackgroundImage = Resources.marble_blue_32; button13.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button13.BackgroundImage = Resources.marble_green_32_s; button13.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button13.BackgroundImage = Resources.marble_green_32; button13.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button13.BackgroundImage = Resources.marble_red_32_s; button13.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button13.BackgroundImage = Resources.marble_red_32; button13.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button13.BackgroundImage = Resources.marble_yellow_32_s; button13.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button13.BackgroundImage = Resources.marble_yellow_32; button13.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button13_Enter(sender, e);
    }

    private void Button13_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button13.AccessibleName + colon + space;
      switch (button13.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button14_Click(object sender, EventArgs e)
    {
      switch (button14.Tag.ToString())
      {
        case marbleBlue32: button14.BackgroundImage = Resources.marble_blue_32_s; button14.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button14.BackgroundImage = Resources.marble_blue_32; button14.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button14.BackgroundImage = Resources.marble_green_32_s; button14.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button14.BackgroundImage = Resources.marble_green_32; button14.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button14.BackgroundImage = Resources.marble_red_32_s; button14.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button14.BackgroundImage = Resources.marble_red_32; button14.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button14.BackgroundImage = Resources.marble_yellow_32_s; button14.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button14.BackgroundImage = Resources.marble_yellow_32; button14.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button14_Enter(sender, e);
    }

    private void Button14_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button14.AccessibleName + colon + space;
      switch (button14.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button15_Click(object sender, EventArgs e)
    {
      switch (button15.Tag.ToString())
      {
        case marbleBlue32: button15.BackgroundImage = Resources.marble_blue_32_s; button15.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button15.BackgroundImage = Resources.marble_blue_32; button15.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button15.BackgroundImage = Resources.marble_green_32_s; button15.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button15.BackgroundImage = Resources.marble_green_32; button15.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button15.BackgroundImage = Resources.marble_red_32_s; button15.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button15.BackgroundImage = Resources.marble_red_32; button15.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button15.BackgroundImage = Resources.marble_yellow_32_s; button15.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button15.BackgroundImage = Resources.marble_yellow_32; button15.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button15_Enter(sender, e);
    }

    private void Button15_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button15.AccessibleName + colon + space;
      switch (button15.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button16_Click(object sender, EventArgs e)
    {
      switch (button16.Tag.ToString())
      {
        case marbleBlue32: button16.BackgroundImage = Resources.marble_blue_32_s; button16.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button16.BackgroundImage = Resources.marble_blue_32; button16.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button16.BackgroundImage = Resources.marble_green_32_s; button16.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button16.BackgroundImage = Resources.marble_green_32; button16.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button16.BackgroundImage = Resources.marble_red_32_s; button16.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button16.BackgroundImage = Resources.marble_red_32; button16.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button16.BackgroundImage = Resources.marble_yellow_32_s; button16.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button16.BackgroundImage = Resources.marble_yellow_32; button16.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button16_Enter(sender, e);
    }

    private void Button16_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button16.AccessibleName + colon + space;
      switch (button16.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button17_Click(object sender, EventArgs e)
    {
      switch (button17.Tag.ToString())
      {
        case marbleBlue32: button17.BackgroundImage = Resources.marble_blue_32_s; button17.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button17.BackgroundImage = Resources.marble_blue_32; button17.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button17.BackgroundImage = Resources.marble_green_32_s; button17.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button17.BackgroundImage = Resources.marble_green_32; button17.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button17.BackgroundImage = Resources.marble_red_32_s; button17.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button17.BackgroundImage = Resources.marble_red_32; button17.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button17.BackgroundImage = Resources.marble_yellow_32_s; button17.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button17.BackgroundImage = Resources.marble_yellow_32; button17.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button17_Enter(sender, e);
    }

    private void Button17_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button17.AccessibleName + colon + space;
      switch (button17.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button18_Click(object sender, EventArgs e)
    {
      switch (button18.Tag.ToString())
      {
        case marbleBlue32: button18.BackgroundImage = Resources.marble_blue_32_s; button18.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button18.BackgroundImage = Resources.marble_blue_32; button18.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button18.BackgroundImage = Resources.marble_green_32_s; button18.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button18.BackgroundImage = Resources.marble_green_32; button18.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button18.BackgroundImage = Resources.marble_red_32_s; button18.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button18.BackgroundImage = Resources.marble_red_32; button18.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button18.BackgroundImage = Resources.marble_yellow_32_s; button18.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button18.BackgroundImage = Resources.marble_yellow_32; button18.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button18_Enter(sender, e);
    }

    private void Button18_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button18.AccessibleName + colon + space;
      switch (button18.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button19_Click(object sender, EventArgs e)
    {
      switch (button19.Tag.ToString())
      {
        case marbleBlue32: button19.BackgroundImage = Resources.marble_blue_32_s; button19.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button19.BackgroundImage = Resources.marble_blue_32; button19.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button19.BackgroundImage = Resources.marble_green_32_s; button19.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button19.BackgroundImage = Resources.marble_green_32; button19.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button19.BackgroundImage = Resources.marble_red_32_s; button19.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button19.BackgroundImage = Resources.marble_red_32; button19.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button19.BackgroundImage = Resources.marble_yellow_32_s; button19.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button19.BackgroundImage = Resources.marble_yellow_32; button19.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button19_Enter(sender, e);
    }

    private void Button19_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button19.AccessibleName + colon + space;
      switch (button19.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button20_Click(object sender, EventArgs e)
    {
      switch (button20.Tag.ToString())
      {
        case marbleBlue32: button20.BackgroundImage = Resources.marble_blue_32_s; button20.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button20.BackgroundImage = Resources.marble_blue_32; button20.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button20.BackgroundImage = Resources.marble_green_32_s; button20.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button20.BackgroundImage = Resources.marble_green_32; button20.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button20.BackgroundImage = Resources.marble_red_32_s; button20.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button20.BackgroundImage = Resources.marble_red_32; button20.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button20.BackgroundImage = Resources.marble_yellow_32_s; button20.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button20.BackgroundImage = Resources.marble_yellow_32; button20.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button20_Enter(sender, e);
    }

    private void Button20_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button20.AccessibleName + colon + space;
      switch (button20.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button21_Click(object sender, EventArgs e)
    {
      switch (button21.Tag.ToString())
      {
        case marbleBlue32: button21.BackgroundImage = Resources.marble_blue_32_s; button21.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button21.BackgroundImage = Resources.marble_blue_32; button21.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button21.BackgroundImage = Resources.marble_green_32_s; button21.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button21.BackgroundImage = Resources.marble_green_32; button21.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button21.BackgroundImage = Resources.marble_red_32_s; button21.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button21.BackgroundImage = Resources.marble_red_32; button21.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button21.BackgroundImage = Resources.marble_yellow_32_s; button21.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button21.BackgroundImage = Resources.marble_yellow_32; button21.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button21_Enter(sender, e);
    }

    private void Button21_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button21.AccessibleName + colon + space;
      switch (button21.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button22_Click(object sender, EventArgs e)
    {
      switch (button22.Tag.ToString())
      {
        case marbleBlue32: button22.BackgroundImage = Resources.marble_blue_32_s; button22.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button22.BackgroundImage = Resources.marble_blue_32; button22.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button22.BackgroundImage = Resources.marble_green_32_s; button22.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button22.BackgroundImage = Resources.marble_green_32; button22.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button22.BackgroundImage = Resources.marble_red_32_s; button22.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button22.BackgroundImage = Resources.marble_red_32; button22.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button22.BackgroundImage = Resources.marble_yellow_32_s; button22.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button22.BackgroundImage = Resources.marble_yellow_32; button22.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button22_Enter(sender, e);
    }

    private void Button22_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button22.AccessibleName + colon + space;
      switch (button22.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button23_Click(object sender, EventArgs e)
    {
      switch (button23.Tag.ToString())
      {
        case marbleBlue32: button23.BackgroundImage = Resources.marble_blue_32_s; button23.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button23.BackgroundImage = Resources.marble_blue_32; button23.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button23.BackgroundImage = Resources.marble_green_32_s; button23.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button23.BackgroundImage = Resources.marble_green_32; button23.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button23.BackgroundImage = Resources.marble_red_32_s; button23.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button23.BackgroundImage = Resources.marble_red_32; button23.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button23.BackgroundImage = Resources.marble_yellow_32_s; button23.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button23.BackgroundImage = Resources.marble_yellow_32; button23.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button23_Enter(sender, e);
    }

    private void Button23_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button23.AccessibleName + colon + space;
      switch (button23.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button24_Click(object sender, EventArgs e)
    {
      switch (button24.Tag.ToString())
      {
        case marbleBlue32: button24.BackgroundImage = Resources.marble_blue_32_s; button24.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button24.BackgroundImage = Resources.marble_blue_32; button24.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button24.BackgroundImage = Resources.marble_green_32_s; button24.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button24.BackgroundImage = Resources.marble_green_32; button24.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button24.BackgroundImage = Resources.marble_red_32_s; button24.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button24.BackgroundImage = Resources.marble_red_32; button24.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button24.BackgroundImage = Resources.marble_yellow_32_s; button24.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button24.BackgroundImage = Resources.marble_yellow_32; button24.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button24_Enter(sender, e);
    }

    private void Button24_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button24.AccessibleName + colon + space;
      switch (button24.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button25_Click(object sender, EventArgs e)
    {
      switch (button25.Tag.ToString())
      {
        case marbleBlue32: button25.BackgroundImage = Resources.marble_blue_32_s; button25.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button25.BackgroundImage = Resources.marble_blue_32; button25.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button25.BackgroundImage = Resources.marble_green_32_s; button25.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button25.BackgroundImage = Resources.marble_green_32; button25.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button25.BackgroundImage = Resources.marble_red_32_s; button25.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button25.BackgroundImage = Resources.marble_red_32; button25.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button25.BackgroundImage = Resources.marble_yellow_32_s; button25.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button25.BackgroundImage = Resources.marble_yellow_32; button25.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button25_Enter(sender, e);
    }

    private void Button25_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button25.AccessibleName + colon + space;
      switch (button25.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button26_Click(object sender, EventArgs e)
    {
      switch (button26.Tag.ToString())
      {
        case marbleBlue32: button26.BackgroundImage = Resources.marble_blue_32_s; button26.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button26.BackgroundImage = Resources.marble_blue_32; button26.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button26.BackgroundImage = Resources.marble_green_32_s; button26.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button26.BackgroundImage = Resources.marble_green_32; button26.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button26.BackgroundImage = Resources.marble_red_32_s; button26.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button26.BackgroundImage = Resources.marble_red_32; button26.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button26.BackgroundImage = Resources.marble_yellow_32_s; button26.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button26.BackgroundImage = Resources.marble_yellow_32; button26.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button26_Enter(sender, e);
    }

    private void Button26_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button26.AccessibleName + colon + space;
      switch (button26.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button27_Click(object sender, EventArgs e)
    {
      switch (button27.Tag.ToString())
      {
        case marbleBlue32: button27.BackgroundImage = Resources.marble_blue_32_s; button27.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button27.BackgroundImage = Resources.marble_blue_32; button27.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button27.BackgroundImage = Resources.marble_green_32_s; button27.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button27.BackgroundImage = Resources.marble_green_32; button27.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button27.BackgroundImage = Resources.marble_red_32_s; button27.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button27.BackgroundImage = Resources.marble_red_32; button27.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button27.BackgroundImage = Resources.marble_yellow_32_s; button27.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button27.BackgroundImage = Resources.marble_yellow_32; button27.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button27_Enter(sender, e);
    }

    private void Button27_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button27.AccessibleName + colon + space;
      switch (button27.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button28_Click(object sender, EventArgs e)
    {
      switch (button28.Tag.ToString())
      {
        case marbleBlue32: button28.BackgroundImage = Resources.marble_blue_32_s; button28.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button28.BackgroundImage = Resources.marble_blue_32; button28.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button28.BackgroundImage = Resources.marble_green_32_s; button28.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button28.BackgroundImage = Resources.marble_green_32; button28.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button28.BackgroundImage = Resources.marble_red_32_s; button28.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button28.BackgroundImage = Resources.marble_red_32; button28.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button28.BackgroundImage = Resources.marble_yellow_32_s; button28.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button28.BackgroundImage = Resources.marble_yellow_32; button28.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button28_Enter(sender, e);
    }

    private void Button28_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button28.AccessibleName + colon + space;
      switch (button28.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button29_Click(object sender, EventArgs e)
    {
      switch (button29.Tag.ToString())
      {
        case marbleBlue32: button29.BackgroundImage = Resources.marble_blue_32_s; button29.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button29.BackgroundImage = Resources.marble_blue_32; button29.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button29.BackgroundImage = Resources.marble_green_32_s; button29.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button29.BackgroundImage = Resources.marble_green_32; button29.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button29.BackgroundImage = Resources.marble_red_32_s; button29.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button29.BackgroundImage = Resources.marble_red_32; button29.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button29.BackgroundImage = Resources.marble_yellow_32_s; button29.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button29.BackgroundImage = Resources.marble_yellow_32; button29.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button29_Enter(sender, e);
    }

    private void Button29_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button29.AccessibleName + colon + space;
      switch (button29.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button30_Click(object sender, EventArgs e)
    {
      switch (button30.Tag.ToString())
      {
        case marbleBlue32: button30.BackgroundImage = Resources.marble_blue_32_s; button30.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button30.BackgroundImage = Resources.marble_blue_32; button30.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button30.BackgroundImage = Resources.marble_green_32_s; button30.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button30.BackgroundImage = Resources.marble_green_32; button30.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button30.BackgroundImage = Resources.marble_red_32_s; button30.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button30.BackgroundImage = Resources.marble_red_32; button30.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button30.BackgroundImage = Resources.marble_yellow_32_s; button30.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button30.BackgroundImage = Resources.marble_yellow_32; button30.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button30_Enter(sender, e);
    }

    private void Button30_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button30.AccessibleName + colon + space;
      switch (button30.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button31_Click(object sender, EventArgs e)
    {
      switch (button31.Tag.ToString())
      {
        case marbleBlue32: button31.BackgroundImage = Resources.marble_blue_32_s; button31.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button31.BackgroundImage = Resources.marble_blue_32; button31.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button31.BackgroundImage = Resources.marble_green_32_s; button31.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button31.BackgroundImage = Resources.marble_green_32; button31.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button31.BackgroundImage = Resources.marble_red_32_s; button31.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button31.BackgroundImage = Resources.marble_red_32; button31.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button31.BackgroundImage = Resources.marble_yellow_32_s; button31.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button31.BackgroundImage = Resources.marble_yellow_32; button31.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button31_Enter(sender, e);
    }

    private void Button31_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button31.AccessibleName + colon + space;
      switch (button31.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button32_Click(object sender, EventArgs e)
    {
      switch (button32.Tag.ToString())
      {
        case marbleBlue32: button32.BackgroundImage = Resources.marble_blue_32_s; button32.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button32.BackgroundImage = Resources.marble_blue_32; button32.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button32.BackgroundImage = Resources.marble_green_32_s; button32.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button32.BackgroundImage = Resources.marble_green_32; button32.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button32.BackgroundImage = Resources.marble_red_32_s; button32.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button32.BackgroundImage = Resources.marble_red_32; button32.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button32.BackgroundImage = Resources.marble_yellow_32_s; button32.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button32.BackgroundImage = Resources.marble_yellow_32; button32.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button32_Enter(sender, e);
    }

    private void Button32_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button32.AccessibleName + colon + space;
      switch (button32.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button33_Click(object sender, EventArgs e)
    {
      switch (button33.Tag.ToString())
      {
        case marbleBlue32: button33.BackgroundImage = Resources.marble_blue_32_s; button33.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button33.BackgroundImage = Resources.marble_blue_32; button33.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button33.BackgroundImage = Resources.marble_green_32_s; button33.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button33.BackgroundImage = Resources.marble_green_32; button33.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button33.BackgroundImage = Resources.marble_red_32_s; button33.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button33.BackgroundImage = Resources.marble_red_32; button33.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button33.BackgroundImage = Resources.marble_yellow_32_s; button33.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button33.BackgroundImage = Resources.marble_yellow_32; button33.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button33_Enter(sender, e);
    }

    private void Button33_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button33.AccessibleName + colon + space;
      switch (button33.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button34_Click(object sender, EventArgs e)
    {
      switch (button34.Tag.ToString())
      {
        case marbleBlue32: button34.BackgroundImage = Resources.marble_blue_32_s; button34.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button34.BackgroundImage = Resources.marble_blue_32; button34.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button34.BackgroundImage = Resources.marble_green_32_s; button34.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button34.BackgroundImage = Resources.marble_green_32; button34.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button34.BackgroundImage = Resources.marble_red_32_s; button34.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button34.BackgroundImage = Resources.marble_red_32; button34.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button34.BackgroundImage = Resources.marble_yellow_32_s; button34.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button34.BackgroundImage = Resources.marble_yellow_32; button34.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button34_Enter(sender, e);
    }

    private void Button34_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button34.AccessibleName + colon + space;
      switch (button34.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button35_Click(object sender, EventArgs e)
    {
      switch (button35.Tag.ToString())
      {
        case marbleBlue32: button35.BackgroundImage = Resources.marble_blue_32_s; button35.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button35.BackgroundImage = Resources.marble_blue_32; button35.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button35.BackgroundImage = Resources.marble_green_32_s; button35.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button35.BackgroundImage = Resources.marble_green_32; button35.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button35.BackgroundImage = Resources.marble_red_32_s; button35.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button35.BackgroundImage = Resources.marble_red_32; button35.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button35.BackgroundImage = Resources.marble_yellow_32_s; button35.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button35.BackgroundImage = Resources.marble_yellow_32; button35.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button35_Enter(sender, e);
    }

    private void Button35_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button35.AccessibleName + colon + space;
      switch (button35.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button36_Click(object sender, EventArgs e)
    {
      switch (button36.Tag.ToString())
      {
        case marbleBlue32: button36.BackgroundImage = Resources.marble_blue_32_s; button36.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button36.BackgroundImage = Resources.marble_blue_32; button36.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button36.BackgroundImage = Resources.marble_green_32_s; button36.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button36.BackgroundImage = Resources.marble_green_32; button36.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button36.BackgroundImage = Resources.marble_red_32_s; button36.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button36.BackgroundImage = Resources.marble_red_32; button36.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button36.BackgroundImage = Resources.marble_yellow_32_s; button36.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button36.BackgroundImage = Resources.marble_yellow_32; button36.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button36_Enter(sender, e);
    }

    private void Button36_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button36.AccessibleName + colon + space;
      switch (button36.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button37_Click(object sender, EventArgs e)
    {
      switch (button37.Tag.ToString())
      {
        case marbleBlue32: button37.BackgroundImage = Resources.marble_blue_32_s; button37.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button37.BackgroundImage = Resources.marble_blue_32; button37.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button37.BackgroundImage = Resources.marble_green_32_s; button37.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button37.BackgroundImage = Resources.marble_green_32; button37.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button37.BackgroundImage = Resources.marble_red_32_s; button37.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button37.BackgroundImage = Resources.marble_red_32; button37.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button37.BackgroundImage = Resources.marble_yellow_32_s; button37.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button37.BackgroundImage = Resources.marble_yellow_32; button37.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button37_Enter(sender, e);
    }

    private void Button37_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button37.AccessibleName + colon + space;
      switch (button37.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button38_Click(object sender, EventArgs e)
    {
      switch (button38.Tag.ToString())
      {
        case marbleBlue32: button38.BackgroundImage = Resources.marble_blue_32_s; button38.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button38.BackgroundImage = Resources.marble_blue_32; button38.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button38.BackgroundImage = Resources.marble_green_32_s; button38.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button38.BackgroundImage = Resources.marble_green_32; button38.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button38.BackgroundImage = Resources.marble_red_32_s; button38.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button38.BackgroundImage = Resources.marble_red_32; button38.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button38.BackgroundImage = Resources.marble_yellow_32_s; button38.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button38.BackgroundImage = Resources.marble_yellow_32; button38.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button38_Enter(sender, e);
    }

    private void Button38_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button38.AccessibleName + colon + space;
      switch (button38.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button39_Click(object sender, EventArgs e)
    {
      switch (button39.Tag.ToString())
      {
        case marbleBlue32: button39.BackgroundImage = Resources.marble_blue_32_s; button39.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button39.BackgroundImage = Resources.marble_blue_32; button39.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button39.BackgroundImage = Resources.marble_green_32_s; button39.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button39.BackgroundImage = Resources.marble_green_32; button39.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button39.BackgroundImage = Resources.marble_red_32_s; button39.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button39.BackgroundImage = Resources.marble_red_32; button39.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button39.BackgroundImage = Resources.marble_yellow_32_s; button39.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button39.BackgroundImage = Resources.marble_yellow_32; button39.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button39_Enter(sender, e);
    }

    private void Button39_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button39.AccessibleName + colon + space;
      switch (button39.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button40_Click(object sender, EventArgs e)
    {
      switch (button40.Tag.ToString())
      {
        case marbleBlue32: button40.BackgroundImage = Resources.marble_blue_32_s; button40.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button40.BackgroundImage = Resources.marble_blue_32; button40.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button40.BackgroundImage = Resources.marble_green_32_s; button40.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button40.BackgroundImage = Resources.marble_green_32; button40.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button40.BackgroundImage = Resources.marble_red_32_s; button40.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button40.BackgroundImage = Resources.marble_red_32; button40.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button40.BackgroundImage = Resources.marble_yellow_32_s; button40.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button40.BackgroundImage = Resources.marble_yellow_32; button40.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button40_Enter(sender, e);
    }

    private void Button40_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button40.AccessibleName + colon + space;
      switch (button40.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button41_Click(object sender, EventArgs e)
    {
      switch (button41.Tag.ToString())
      {
        case marbleBlue32: button41.BackgroundImage = Resources.marble_blue_32_s; button41.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button41.BackgroundImage = Resources.marble_blue_32; button41.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button41.BackgroundImage = Resources.marble_green_32_s; button41.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button41.BackgroundImage = Resources.marble_green_32; button41.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button41.BackgroundImage = Resources.marble_red_32_s; button41.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button41.BackgroundImage = Resources.marble_red_32; button41.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button41.BackgroundImage = Resources.marble_yellow_32_s; button41.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button41.BackgroundImage = Resources.marble_yellow_32; button41.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button41_Enter(sender, e);
    }

    private void Button41_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button41.AccessibleName + colon + space;
      switch (button41.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button42_Click(object sender, EventArgs e)
    {
      switch (button42.Tag.ToString())
      {
        case marbleBlue32: button42.BackgroundImage = Resources.marble_blue_32_s; button42.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button42.BackgroundImage = Resources.marble_blue_32; button42.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button42.BackgroundImage = Resources.marble_green_32_s; button42.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button42.BackgroundImage = Resources.marble_green_32; button42.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button42.BackgroundImage = Resources.marble_red_32_s; button42.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button42.BackgroundImage = Resources.marble_red_32; button42.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button42.BackgroundImage = Resources.marble_yellow_32_s; button42.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button42.BackgroundImage = Resources.marble_yellow_32; button42.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button42_Enter(sender, e);
    }

    private void Button42_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button42.AccessibleName + colon + space;
      switch (button42.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button43_Click(object sender, EventArgs e)
    {
      switch (button43.Tag.ToString())
      {
        case marbleBlue32: button43.BackgroundImage = Resources.marble_blue_32_s; button43.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button43.BackgroundImage = Resources.marble_blue_32; button43.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button43.BackgroundImage = Resources.marble_green_32_s; button43.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button43.BackgroundImage = Resources.marble_green_32; button43.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button43.BackgroundImage = Resources.marble_red_32_s; button43.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button43.BackgroundImage = Resources.marble_red_32; button43.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button43.BackgroundImage = Resources.marble_yellow_32_s; button43.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button43.BackgroundImage = Resources.marble_yellow_32; button43.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button43_Enter(sender, e);
    }

    private void Button43_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button43.AccessibleName + colon + space;
      switch (button43.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button44_Click(object sender, EventArgs e)
    {
      switch (button44.Tag.ToString())
      {
        case marbleBlue32: button44.BackgroundImage = Resources.marble_blue_32_s; button44.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button44.BackgroundImage = Resources.marble_blue_32; button44.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button44.BackgroundImage = Resources.marble_green_32_s; button44.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button44.BackgroundImage = Resources.marble_green_32; button44.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button44.BackgroundImage = Resources.marble_red_32_s; button44.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button44.BackgroundImage = Resources.marble_red_32; button44.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button44.BackgroundImage = Resources.marble_yellow_32_s; button44.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button44.BackgroundImage = Resources.marble_yellow_32; button44.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button44_Enter(sender, e);
    }

    private void Button44_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button44.AccessibleName + colon + space;
      switch (button44.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button45_Click(object sender, EventArgs e)
    {
      switch (button45.Tag.ToString())
      {
        case marbleBlue32: button45.BackgroundImage = Resources.marble_blue_32_s; button45.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button45.BackgroundImage = Resources.marble_blue_32; button45.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button45.BackgroundImage = Resources.marble_green_32_s; button45.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button45.BackgroundImage = Resources.marble_green_32; button45.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button45.BackgroundImage = Resources.marble_red_32_s; button45.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button45.BackgroundImage = Resources.marble_red_32; button45.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button45.BackgroundImage = Resources.marble_yellow_32_s; button45.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button45.BackgroundImage = Resources.marble_yellow_32; button45.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button45_Enter(sender, e);
    }

    private void Button45_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button45.AccessibleName + colon + space;
      switch (button45.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button46_Click(object sender, EventArgs e)
    {
      switch (button46.Tag.ToString())
      {
        case marbleBlue32: button46.BackgroundImage = Resources.marble_blue_32_s; button46.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button46.BackgroundImage = Resources.marble_blue_32; button46.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button46.BackgroundImage = Resources.marble_green_32_s; button46.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button46.BackgroundImage = Resources.marble_green_32; button46.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button46.BackgroundImage = Resources.marble_red_32_s; button46.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button46.BackgroundImage = Resources.marble_red_32; button46.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button46.BackgroundImage = Resources.marble_yellow_32_s; button46.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button46.BackgroundImage = Resources.marble_yellow_32; button46.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button46_Enter(sender, e);
    }

    private void Button46_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button46.AccessibleName + colon + space;
      switch (button46.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button47_Click(object sender, EventArgs e)
    {
      switch (button47.Tag.ToString())
      {
        case marbleBlue32: button47.BackgroundImage = Resources.marble_blue_32_s; button47.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button47.BackgroundImage = Resources.marble_blue_32; button47.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button47.BackgroundImage = Resources.marble_green_32_s; button47.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button47.BackgroundImage = Resources.marble_green_32; button47.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button47.BackgroundImage = Resources.marble_red_32_s; button47.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button47.BackgroundImage = Resources.marble_red_32; button47.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button47.BackgroundImage = Resources.marble_yellow_32_s; button47.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button47.BackgroundImage = Resources.marble_yellow_32; button47.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button47_Enter(sender, e);
    }

    private void Button47_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button47.AccessibleName + colon + space;
      switch (button47.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button48_Click(object sender, EventArgs e)
    {
      switch (button48.Tag.ToString())
      {
        case marbleBlue32: button48.BackgroundImage = Resources.marble_blue_32_s; button48.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button48.BackgroundImage = Resources.marble_blue_32; button48.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button48.BackgroundImage = Resources.marble_green_32_s; button48.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button48.BackgroundImage = Resources.marble_green_32; button48.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button48.BackgroundImage = Resources.marble_red_32_s; button48.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button48.BackgroundImage = Resources.marble_red_32; button48.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button48.BackgroundImage = Resources.marble_yellow_32_s; button48.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button48.BackgroundImage = Resources.marble_yellow_32; button48.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button48_Enter(sender, e);
    }

    private void Button48_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button48.AccessibleName + colon + space;
      switch (button48.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button49_Click(object sender, EventArgs e)
    {
      switch (button49.Tag.ToString())
      {
        case marbleBlue32: button49.BackgroundImage = Resources.marble_blue_32_s; button49.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button49.BackgroundImage = Resources.marble_blue_32; button49.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button49.BackgroundImage = Resources.marble_green_32_s; button49.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button49.BackgroundImage = Resources.marble_green_32; button49.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button49.BackgroundImage = Resources.marble_red_32_s; button49.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button49.BackgroundImage = Resources.marble_red_32; button49.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button49.BackgroundImage = Resources.marble_yellow_32_s; button49.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button49.BackgroundImage = Resources.marble_yellow_32; button49.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button49_Enter(sender, e);
    }

    private void Button49_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button49.AccessibleName + colon + space;
      switch (button49.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button50_Click(object sender, EventArgs e)
    {
      switch (button50.Tag.ToString())
      {
        case marbleBlue32: button50.BackgroundImage = Resources.marble_blue_32_s; button50.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button50.BackgroundImage = Resources.marble_blue_32; button50.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button50.BackgroundImage = Resources.marble_green_32_s; button50.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button50.BackgroundImage = Resources.marble_green_32; button50.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button50.BackgroundImage = Resources.marble_red_32_s; button50.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button50.BackgroundImage = Resources.marble_red_32; button50.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button50.BackgroundImage = Resources.marble_yellow_32_s; button50.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button50.BackgroundImage = Resources.marble_yellow_32; button50.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button50_Enter(sender, e);
    }

    private void Button50_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button50.AccessibleName + colon + space;
      switch (button50.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button51_Click(object sender, EventArgs e)
    {
      switch (button51.Tag.ToString())
      {
        case marbleBlue32: button51.BackgroundImage = Resources.marble_blue_32_s; button51.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button51.BackgroundImage = Resources.marble_blue_32; button51.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button51.BackgroundImage = Resources.marble_green_32_s; button51.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button51.BackgroundImage = Resources.marble_green_32; button51.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button51.BackgroundImage = Resources.marble_red_32_s; button51.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button51.BackgroundImage = Resources.marble_red_32; button51.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button51.BackgroundImage = Resources.marble_yellow_32_s; button51.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button51.BackgroundImage = Resources.marble_yellow_32; button51.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button51_Enter(sender, e);
    }

    private void Button51_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button51.AccessibleName + colon + space;
      switch (button51.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button52_Click(object sender, EventArgs e)
    {
      switch (button52.Tag.ToString())
      {
        case marbleBlue32: button52.BackgroundImage = Resources.marble_blue_32_s; button52.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button52.BackgroundImage = Resources.marble_blue_32; button52.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button52.BackgroundImage = Resources.marble_green_32_s; button52.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button52.BackgroundImage = Resources.marble_green_32; button52.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button52.BackgroundImage = Resources.marble_red_32_s; button52.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button52.BackgroundImage = Resources.marble_red_32; button52.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button52.BackgroundImage = Resources.marble_yellow_32_s; button52.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button52.BackgroundImage = Resources.marble_yellow_32; button52.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button52_Enter(sender, e);
    }

    private void Button52_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button52.AccessibleName + colon + space;
      switch (button52.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button53_Click(object sender, EventArgs e)
    {
      switch (button53.Tag.ToString())
      {
        case marbleBlue32: button53.BackgroundImage = Resources.marble_blue_32_s; button53.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button53.BackgroundImage = Resources.marble_blue_32; button53.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button53.BackgroundImage = Resources.marble_green_32_s; button53.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button53.BackgroundImage = Resources.marble_green_32; button53.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button53.BackgroundImage = Resources.marble_red_32_s; button53.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button53.BackgroundImage = Resources.marble_red_32; button53.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button53.BackgroundImage = Resources.marble_yellow_32_s; button53.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button53.BackgroundImage = Resources.marble_yellow_32; button53.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button53_Enter(sender, e);
    }

    private void Button53_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button53.AccessibleName + colon + space;
      switch (button53.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button54_Click(object sender, EventArgs e)
    {
      switch (button54.Tag.ToString())
      {
        case marbleBlue32: button54.BackgroundImage = Resources.marble_blue_32_s; button54.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button54.BackgroundImage = Resources.marble_blue_32; button54.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button54.BackgroundImage = Resources.marble_green_32_s; button54.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button54.BackgroundImage = Resources.marble_green_32; button54.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button54.BackgroundImage = Resources.marble_red_32_s; button54.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button54.BackgroundImage = Resources.marble_red_32; button54.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button54.BackgroundImage = Resources.marble_yellow_32_s; button54.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button54.BackgroundImage = Resources.marble_yellow_32; button54.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button54_Enter(sender, e);
    }

    private void Button54_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button54.AccessibleName + colon + space;
      switch (button54.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button55_Click(object sender, EventArgs e)
    {
      switch (button55.Tag.ToString())
      {
        case marbleBlue32: button55.BackgroundImage = Resources.marble_blue_32_s; button55.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button55.BackgroundImage = Resources.marble_blue_32; button55.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button55.BackgroundImage = Resources.marble_green_32_s; button55.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button55.BackgroundImage = Resources.marble_green_32; button55.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button55.BackgroundImage = Resources.marble_red_32_s; button55.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button55.BackgroundImage = Resources.marble_red_32; button55.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button55.BackgroundImage = Resources.marble_yellow_32_s; button55.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button55.BackgroundImage = Resources.marble_yellow_32; button55.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button55_Enter(sender, e);
    }

    private void Button55_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button55.AccessibleName + colon + space;
      switch (button55.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button56_Click(object sender, EventArgs e)
    {
      switch (button56.Tag.ToString())
      {
        case marbleBlue32: button56.BackgroundImage = Resources.marble_blue_32_s; button56.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button56.BackgroundImage = Resources.marble_blue_32; button56.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button56.BackgroundImage = Resources.marble_green_32_s; button56.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button56.BackgroundImage = Resources.marble_green_32; button56.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button56.BackgroundImage = Resources.marble_red_32_s; button56.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button56.BackgroundImage = Resources.marble_red_32; button56.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button56.BackgroundImage = Resources.marble_yellow_32_s; button56.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button56.BackgroundImage = Resources.marble_yellow_32; button56.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button56_Enter(sender, e);
    }

    private void Button56_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button56.AccessibleName + colon + space;
      switch (button56.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button57_Click(object sender, EventArgs e)
    {
      switch (button57.Tag.ToString())
      {
        case marbleBlue32: button57.BackgroundImage = Resources.marble_blue_32_s; button57.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button57.BackgroundImage = Resources.marble_blue_32; button57.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button57.BackgroundImage = Resources.marble_green_32_s; button57.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button57.BackgroundImage = Resources.marble_green_32; button57.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button57.BackgroundImage = Resources.marble_red_32_s; button57.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button57.BackgroundImage = Resources.marble_red_32; button57.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button57.BackgroundImage = Resources.marble_yellow_32_s; button57.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button57.BackgroundImage = Resources.marble_yellow_32; button57.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button57_Enter(sender, e);
    }

    private void Button57_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button57.AccessibleName + colon + space;
      switch (button57.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button58_Click(object sender, EventArgs e)
    {
      switch (button58.Tag.ToString())
      {
        case marbleBlue32: button58.BackgroundImage = Resources.marble_blue_32_s; button58.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button58.BackgroundImage = Resources.marble_blue_32; button58.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button58.BackgroundImage = Resources.marble_green_32_s; button58.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button58.BackgroundImage = Resources.marble_green_32; button58.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button58.BackgroundImage = Resources.marble_red_32_s; button58.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button58.BackgroundImage = Resources.marble_red_32; button58.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button58.BackgroundImage = Resources.marble_yellow_32_s; button58.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button58.BackgroundImage = Resources.marble_yellow_32; button58.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button58_Enter(sender, e);
    }

    private void Button58_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button58.AccessibleName + colon + space;
      switch (button58.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button59_Click(object sender, EventArgs e)
    {
      switch (button59.Tag.ToString())
      {
        case marbleBlue32: button59.BackgroundImage = Resources.marble_blue_32_s; button59.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button59.BackgroundImage = Resources.marble_blue_32; button59.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button59.BackgroundImage = Resources.marble_green_32_s; button59.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button59.BackgroundImage = Resources.marble_green_32; button59.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button59.BackgroundImage = Resources.marble_red_32_s; button59.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button59.BackgroundImage = Resources.marble_red_32; button59.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button59.BackgroundImage = Resources.marble_yellow_32_s; button59.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button59.BackgroundImage = Resources.marble_yellow_32; button59.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button59_Enter(sender, e);
    }

    private void Button59_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button59.AccessibleName + colon + space;
      switch (button59.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button60_Click(object sender, EventArgs e)
    {
      switch (button60.Tag.ToString())
      {
        case marbleBlue32: button60.BackgroundImage = Resources.marble_blue_32_s; button60.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button60.BackgroundImage = Resources.marble_blue_32; button60.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button60.BackgroundImage = Resources.marble_green_32_s; button60.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button60.BackgroundImage = Resources.marble_green_32; button60.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button60.BackgroundImage = Resources.marble_red_32_s; button60.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button60.BackgroundImage = Resources.marble_red_32; button60.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button60.BackgroundImage = Resources.marble_yellow_32_s; button60.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button60.BackgroundImage = Resources.marble_yellow_32; button60.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button60_Enter(sender, e);
    }

    private void Button60_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button60.AccessibleName + colon + space;
      switch (button60.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button61_Click(object sender, EventArgs e)
    {
      switch (button61.Tag.ToString())
      {
        case marbleBlue32: button61.BackgroundImage = Resources.marble_blue_32_s; button61.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button61.BackgroundImage = Resources.marble_blue_32; button61.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button61.BackgroundImage = Resources.marble_green_32_s; button61.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button61.BackgroundImage = Resources.marble_green_32; button61.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button61.BackgroundImage = Resources.marble_red_32_s; button61.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button61.BackgroundImage = Resources.marble_red_32; button61.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button61.BackgroundImage = Resources.marble_yellow_32_s; button61.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button61.BackgroundImage = Resources.marble_yellow_32; button61.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button61_Enter(sender, e);
    }

    private void Button61_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button61.AccessibleName + colon + space;
      switch (button61.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button62_Click(object sender, EventArgs e)
    {
      switch (button62.Tag.ToString())
      {
        case marbleBlue32: button62.BackgroundImage = Resources.marble_blue_32_s; button62.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button62.BackgroundImage = Resources.marble_blue_32; button62.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button62.BackgroundImage = Resources.marble_green_32_s; button62.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button62.BackgroundImage = Resources.marble_green_32; button62.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button62.BackgroundImage = Resources.marble_red_32_s; button62.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button62.BackgroundImage = Resources.marble_red_32; button62.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button62.BackgroundImage = Resources.marble_yellow_32_s; button62.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button62.BackgroundImage = Resources.marble_yellow_32; button62.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button62_Enter(sender, e);
    }

    private void Button62_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button62.AccessibleName + colon + space;
      switch (button62.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button63_Click(object sender, EventArgs e)
    {
      switch (button63.Tag.ToString())
      {
        case marbleBlue32: button63.BackgroundImage = Resources.marble_blue_32_s; button63.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button63.BackgroundImage = Resources.marble_blue_32; button63.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button63.BackgroundImage = Resources.marble_green_32_s; button63.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button63.BackgroundImage = Resources.marble_green_32; button63.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button63.BackgroundImage = Resources.marble_red_32_s; button63.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button63.BackgroundImage = Resources.marble_red_32; button63.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button63.BackgroundImage = Resources.marble_yellow_32_s; button63.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button63.BackgroundImage = Resources.marble_yellow_32; button63.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button63_Enter(sender, e);
    }

    private void Button63_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button63.AccessibleName + colon + space;
      switch (button63.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button64_Click(object sender, EventArgs e)
    {
      switch (button64.Tag.ToString())
      {
        case marbleBlue32: button64.BackgroundImage = Resources.marble_blue_32_s; button64.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button64.BackgroundImage = Resources.marble_blue_32; button64.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button64.BackgroundImage = Resources.marble_green_32_s; button64.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button64.BackgroundImage = Resources.marble_green_32; button64.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button64.BackgroundImage = Resources.marble_red_32_s; button64.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button64.BackgroundImage = Resources.marble_red_32; button64.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button64.BackgroundImage = Resources.marble_yellow_32_s; button64.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button64.BackgroundImage = Resources.marble_yellow_32; button64.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button64_Enter(sender, e);
    }

    private void Button64_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button64.AccessibleName + colon + space;
      switch (button64.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button65_Click(object sender, EventArgs e)
    {
      switch (button65.Tag.ToString())
      {
        case marbleBlue32: button65.BackgroundImage = Resources.marble_blue_32_s; button65.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button65.BackgroundImage = Resources.marble_blue_32; button65.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button65.BackgroundImage = Resources.marble_green_32_s; button65.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button65.BackgroundImage = Resources.marble_green_32; button65.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button65.BackgroundImage = Resources.marble_red_32_s; button65.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button65.BackgroundImage = Resources.marble_red_32; button65.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button65.BackgroundImage = Resources.marble_yellow_32_s; button65.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button65.BackgroundImage = Resources.marble_yellow_32; button65.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button65_Enter(sender, e);
    }

    private void Button65_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button65.AccessibleName + colon + space;
      switch (button65.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button66_Click(object sender, EventArgs e)
    {
      switch (button66.Tag.ToString())
      {
        case marbleBlue32: button66.BackgroundImage = Resources.marble_blue_32_s; button66.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button66.BackgroundImage = Resources.marble_blue_32; button66.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button66.BackgroundImage = Resources.marble_green_32_s; button66.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button66.BackgroundImage = Resources.marble_green_32; button66.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button66.BackgroundImage = Resources.marble_red_32_s; button66.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button66.BackgroundImage = Resources.marble_red_32; button66.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button66.BackgroundImage = Resources.marble_yellow_32_s; button66.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button66.BackgroundImage = Resources.marble_yellow_32; button66.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button66_Enter(sender, e);
    }

    private void Button66_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button66.AccessibleName + colon + space;
      switch (button66.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button67_Click(object sender, EventArgs e)
    {
      switch (button67.Tag.ToString())
      {
        case marbleBlue32: button67.BackgroundImage = Resources.marble_blue_32_s; button67.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button67.BackgroundImage = Resources.marble_blue_32; button67.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button67.BackgroundImage = Resources.marble_green_32_s; button67.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button67.BackgroundImage = Resources.marble_green_32; button67.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button67.BackgroundImage = Resources.marble_red_32_s; button67.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button67.BackgroundImage = Resources.marble_red_32; button67.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button67.BackgroundImage = Resources.marble_yellow_32_s; button67.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button67.BackgroundImage = Resources.marble_yellow_32; button67.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button67_Enter(sender, e);
    }

    private void Button67_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button67.AccessibleName + colon + space;
      switch (button67.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button68_Click(object sender, EventArgs e)
    {
      switch (button68.Tag.ToString())
      {
        case marbleBlue32: button68.BackgroundImage = Resources.marble_blue_32_s; button68.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button68.BackgroundImage = Resources.marble_blue_32; button68.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button68.BackgroundImage = Resources.marble_green_32_s; button68.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button68.BackgroundImage = Resources.marble_green_32; button68.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button68.BackgroundImage = Resources.marble_red_32_s; button68.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button68.BackgroundImage = Resources.marble_red_32; button68.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button68.BackgroundImage = Resources.marble_yellow_32_s; button68.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button68.BackgroundImage = Resources.marble_yellow_32; button68.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button68_Enter(sender, e);
    }

    private void Button68_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button68.AccessibleName + colon + space;
      switch (button68.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button69_Click(object sender, EventArgs e)
    {
      switch (button69.Tag.ToString())
      {
        case marbleBlue32: button69.BackgroundImage = Resources.marble_blue_32_s; button69.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button69.BackgroundImage = Resources.marble_blue_32; button69.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button69.BackgroundImage = Resources.marble_green_32_s; button69.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button69.BackgroundImage = Resources.marble_green_32; button69.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button69.BackgroundImage = Resources.marble_red_32_s; button69.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button69.BackgroundImage = Resources.marble_red_32; button69.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button69.BackgroundImage = Resources.marble_yellow_32_s; button69.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button69.BackgroundImage = Resources.marble_yellow_32; button69.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button69_Enter(sender, e);
    }

    private void Button69_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button69.AccessibleName + colon + space;
      switch (button69.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button70_Click(object sender, EventArgs e)
    {
      switch (button70.Tag.ToString())
      {
        case marbleBlue32: button70.BackgroundImage = Resources.marble_blue_32_s; button70.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button70.BackgroundImage = Resources.marble_blue_32; button70.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button70.BackgroundImage = Resources.marble_green_32_s; button70.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button70.BackgroundImage = Resources.marble_green_32; button70.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button70.BackgroundImage = Resources.marble_red_32_s; button70.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button70.BackgroundImage = Resources.marble_red_32; button70.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button70.BackgroundImage = Resources.marble_yellow_32_s; button70.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button70.BackgroundImage = Resources.marble_yellow_32; button70.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button70_Enter(sender, e);
    }

    private void Button70_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button70.AccessibleName + colon + space;
      switch (button70.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button71_Click(object sender, EventArgs e)
    {
      switch (button71.Tag.ToString())
      {
        case marbleBlue32: button71.BackgroundImage = Resources.marble_blue_32_s; button71.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button71.BackgroundImage = Resources.marble_blue_32; button71.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button71.BackgroundImage = Resources.marble_green_32_s; button71.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button71.BackgroundImage = Resources.marble_green_32; button71.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button71.BackgroundImage = Resources.marble_red_32_s; button71.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button71.BackgroundImage = Resources.marble_red_32; button71.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button71.BackgroundImage = Resources.marble_yellow_32_s; button71.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button71.BackgroundImage = Resources.marble_yellow_32; button71.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button71_Enter(sender, e);
    }

    private void Button71_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button71.AccessibleName + colon + space;
      switch (button71.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button72_Click(object sender, EventArgs e)
    {
      switch (button72.Tag.ToString())
      {
        case marbleBlue32: button72.BackgroundImage = Resources.marble_blue_32_s; button72.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button72.BackgroundImage = Resources.marble_blue_32; button72.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button72.BackgroundImage = Resources.marble_green_32_s; button72.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button72.BackgroundImage = Resources.marble_green_32; button72.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button72.BackgroundImage = Resources.marble_red_32_s; button72.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button72.BackgroundImage = Resources.marble_red_32; button72.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button72.BackgroundImage = Resources.marble_yellow_32_s; button72.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button72.BackgroundImage = Resources.marble_yellow_32; button72.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button72_Enter(sender, e);
    }

    private void Button72_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button72.AccessibleName + colon + space;
      switch (button72.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button73_Click(object sender, EventArgs e)
    {
      switch (button73.Tag.ToString())
      {
        case marbleBlue32: button73.BackgroundImage = Resources.marble_blue_32_s; button73.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button73.BackgroundImage = Resources.marble_blue_32; button73.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button73.BackgroundImage = Resources.marble_green_32_s; button73.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button73.BackgroundImage = Resources.marble_green_32; button73.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button73.BackgroundImage = Resources.marble_red_32_s; button73.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button73.BackgroundImage = Resources.marble_red_32; button73.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button73.BackgroundImage = Resources.marble_yellow_32_s; button73.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button73.BackgroundImage = Resources.marble_yellow_32; button73.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button73_Enter(sender, e);
    }

    private void Button73_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button73.AccessibleName + colon + space;
      switch (button73.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button74_Click(object sender, EventArgs e)
    {
      switch (button74.Tag.ToString())
      {
        case marbleBlue32: button74.BackgroundImage = Resources.marble_blue_32_s; button74.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button74.BackgroundImage = Resources.marble_blue_32; button74.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button74.BackgroundImage = Resources.marble_green_32_s; button74.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button74.BackgroundImage = Resources.marble_green_32; button74.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button74.BackgroundImage = Resources.marble_red_32_s; button74.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button74.BackgroundImage = Resources.marble_red_32; button74.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button74.BackgroundImage = Resources.marble_yellow_32_s; button74.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button74.BackgroundImage = Resources.marble_yellow_32; button74.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button74_Enter(sender, e);
    }

    private void Button74_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button74.AccessibleName + colon + space;
      switch (button74.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button75_Click(object sender, EventArgs e)
    {
      switch (button75.Tag.ToString())
      {
        case marbleBlue32: button75.BackgroundImage = Resources.marble_blue_32_s; button75.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button75.BackgroundImage = Resources.marble_blue_32; button75.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button75.BackgroundImage = Resources.marble_green_32_s; button75.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button75.BackgroundImage = Resources.marble_green_32; button75.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button75.BackgroundImage = Resources.marble_red_32_s; button75.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button75.BackgroundImage = Resources.marble_red_32; button75.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button75.BackgroundImage = Resources.marble_yellow_32_s; button75.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button75.BackgroundImage = Resources.marble_yellow_32; button75.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button75_Enter(sender, e);
    }

    private void Button75_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button75.AccessibleName + colon + space;
      switch (button75.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button76_Click(object sender, EventArgs e)
    {
      switch (button76.Tag.ToString())
      {
        case marbleBlue32: button76.BackgroundImage = Resources.marble_blue_32_s; button76.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button76.BackgroundImage = Resources.marble_blue_32; button76.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button76.BackgroundImage = Resources.marble_green_32_s; button76.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button76.BackgroundImage = Resources.marble_green_32; button76.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button76.BackgroundImage = Resources.marble_red_32_s; button76.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button76.BackgroundImage = Resources.marble_red_32; button76.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button76.BackgroundImage = Resources.marble_yellow_32_s; button76.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button76.BackgroundImage = Resources.marble_yellow_32; button76.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button76_Enter(sender, e);
    }

    private void Button76_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button76.AccessibleName + colon + space;
      switch (button76.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button77_Click(object sender, EventArgs e)
    {
      switch (button77.Tag.ToString())
      {
        case marbleBlue32: button77.BackgroundImage = Resources.marble_blue_32_s; button77.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button77.BackgroundImage = Resources.marble_blue_32; button77.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button77.BackgroundImage = Resources.marble_green_32_s; button77.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button77.BackgroundImage = Resources.marble_green_32; button77.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button77.BackgroundImage = Resources.marble_red_32_s; button77.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button77.BackgroundImage = Resources.marble_red_32; button77.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button77.BackgroundImage = Resources.marble_yellow_32_s; button77.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button77.BackgroundImage = Resources.marble_yellow_32; button77.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button77_Enter(sender, e);
    }

    private void Button77_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button77.AccessibleName + colon + space;
      switch (button77.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button78_Click(object sender, EventArgs e)
    {
      switch (button78.Tag.ToString())
      {
        case marbleBlue32: button78.BackgroundImage = Resources.marble_blue_32_s; button78.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button78.BackgroundImage = Resources.marble_blue_32; button78.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button78.BackgroundImage = Resources.marble_green_32_s; button78.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button78.BackgroundImage = Resources.marble_green_32; button78.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button78.BackgroundImage = Resources.marble_red_32_s; button78.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button78.BackgroundImage = Resources.marble_red_32; button78.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button78.BackgroundImage = Resources.marble_yellow_32_s; button78.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button78.BackgroundImage = Resources.marble_yellow_32; button78.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button78_Enter(sender, e);
    }

    private void Button78_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button78.AccessibleName + colon + space;
      switch (button78.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button79_Click(object sender, EventArgs e)
    {
      switch (button79.Tag.ToString())
      {
        case marbleBlue32: button79.BackgroundImage = Resources.marble_blue_32_s; button79.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button79.BackgroundImage = Resources.marble_blue_32; button79.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button79.BackgroundImage = Resources.marble_green_32_s; button79.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button79.BackgroundImage = Resources.marble_green_32; button79.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button79.BackgroundImage = Resources.marble_red_32_s; button79.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button79.BackgroundImage = Resources.marble_red_32; button79.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button79.BackgroundImage = Resources.marble_yellow_32_s; button79.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button79.BackgroundImage = Resources.marble_yellow_32; button79.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button79_Enter(sender, e);
    }

    private void Button79_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button79.AccessibleName + colon + space;
      switch (button79.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button80_Click(object sender, EventArgs e)
    {
      switch (button80.Tag.ToString())
      {
        case marbleBlue32: button80.BackgroundImage = Resources.marble_blue_32_s; button80.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button80.BackgroundImage = Resources.marble_blue_32; button80.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button80.BackgroundImage = Resources.marble_green_32_s; button80.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button80.BackgroundImage = Resources.marble_green_32; button80.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button80.BackgroundImage = Resources.marble_red_32_s; button80.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button80.BackgroundImage = Resources.marble_red_32; button80.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button80.BackgroundImage = Resources.marble_yellow_32_s; button80.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button80.BackgroundImage = Resources.marble_yellow_32; button80.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button8_Enter(sender, e);
    }

    private void Button80_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button80.AccessibleName + colon + space;
      switch (button80.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button81_Click(object sender, EventArgs e)
    {
      switch (button81.Tag.ToString())
      {
        case marbleBlue32: button81.BackgroundImage = Resources.marble_blue_32_s; button81.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button81.BackgroundImage = Resources.marble_blue_32; button81.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button81.BackgroundImage = Resources.marble_green_32_s; button81.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button81.BackgroundImage = Resources.marble_green_32; button81.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button81.BackgroundImage = Resources.marble_red_32_s; button81.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button81.BackgroundImage = Resources.marble_red_32; button81.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button81.BackgroundImage = Resources.marble_yellow_32_s; button81.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button81.BackgroundImage = Resources.marble_yellow_32; button81.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button81_Enter(sender, e);
    }

    private void Button81_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button81.AccessibleName + colon + space;
      switch (button81.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button82_Click(object sender, EventArgs e)
    {
      switch (button82.Tag.ToString())
      {
        case marbleBlue32: button82.BackgroundImage = Resources.marble_blue_32_s; button82.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button82.BackgroundImage = Resources.marble_blue_32; button82.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button82.BackgroundImage = Resources.marble_green_32_s; button82.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button82.BackgroundImage = Resources.marble_green_32; button82.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button82.BackgroundImage = Resources.marble_red_32_s; button82.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button82.BackgroundImage = Resources.marble_red_32; button82.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button82.BackgroundImage = Resources.marble_yellow_32_s; button82.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button82.BackgroundImage = Resources.marble_yellow_32; button82.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button82_Enter(sender, e);
    }

    private void Button82_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button82.AccessibleName + colon + space;
      switch (button82.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button83_Click(object sender, EventArgs e)
    {
      switch (button83.Tag.ToString())
      {
        case marbleBlue32: button83.BackgroundImage = Resources.marble_blue_32_s; button83.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button83.BackgroundImage = Resources.marble_blue_32; button83.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button83.BackgroundImage = Resources.marble_green_32_s; button83.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button83.BackgroundImage = Resources.marble_green_32; button83.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button83.BackgroundImage = Resources.marble_red_32_s; button83.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button83.BackgroundImage = Resources.marble_red_32; button83.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button83.BackgroundImage = Resources.marble_yellow_32_s; button83.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button83.BackgroundImage = Resources.marble_yellow_32; button83.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button83_Enter(sender, e);
    }

    private void Button83_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button83.AccessibleName + colon + space;
      switch (button83.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button84_Click(object sender, EventArgs e)
    {
      switch (button84.Tag.ToString())
      {
        case marbleBlue32: button84.BackgroundImage = Resources.marble_blue_32_s; button84.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button84.BackgroundImage = Resources.marble_blue_32; button84.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button84.BackgroundImage = Resources.marble_green_32_s; button84.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button84.BackgroundImage = Resources.marble_green_32; button84.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button84.BackgroundImage = Resources.marble_red_32_s; button84.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button84.BackgroundImage = Resources.marble_red_32; button84.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button84.BackgroundImage = Resources.marble_yellow_32_s; button84.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button84.BackgroundImage = Resources.marble_yellow_32; button84.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button84_Enter(sender, e);
    }

    private void Button84_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button84.AccessibleName + colon + space;
      switch (button84.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button85_Click(object sender, EventArgs e)
    {
      switch (button85.Tag.ToString())
      {
        case marbleBlue32: button85.BackgroundImage = Resources.marble_blue_32_s; button85.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button85.BackgroundImage = Resources.marble_blue_32; button85.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button85.BackgroundImage = Resources.marble_green_32_s; button85.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button85.BackgroundImage = Resources.marble_green_32; button85.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button85.BackgroundImage = Resources.marble_red_32_s; button85.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button85.BackgroundImage = Resources.marble_red_32; button85.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button85.BackgroundImage = Resources.marble_yellow_32_s; button85.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button85.BackgroundImage = Resources.marble_yellow_32; button85.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button85_Enter(sender, e);
    }

    private void Button85_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button85.AccessibleName + colon + space;
      switch (button85.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button86_Click(object sender, EventArgs e)
    {
      switch (button86.Tag.ToString())
      {
        case marbleBlue32: button86.BackgroundImage = Resources.marble_blue_32_s; button86.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button86.BackgroundImage = Resources.marble_blue_32; button86.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button86.BackgroundImage = Resources.marble_green_32_s; button86.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button86.BackgroundImage = Resources.marble_green_32; button86.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button86.BackgroundImage = Resources.marble_red_32_s; button86.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button86.BackgroundImage = Resources.marble_red_32; button86.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button86.BackgroundImage = Resources.marble_yellow_32_s; button86.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button86.BackgroundImage = Resources.marble_yellow_32; button86.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button86_Enter(sender, e);
    }

    private void Button86_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button86.AccessibleName + colon + space;
      switch (button86.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button87_Click(object sender, EventArgs e)
    {
      switch (button87.Tag.ToString())
      {
        case marbleBlue32: button87.BackgroundImage = Resources.marble_blue_32_s; button87.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button87.BackgroundImage = Resources.marble_blue_32; button87.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button87.BackgroundImage = Resources.marble_green_32_s; button87.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button87.BackgroundImage = Resources.marble_green_32; button87.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button87.BackgroundImage = Resources.marble_red_32_s; button87.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button87.BackgroundImage = Resources.marble_red_32; button87.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button87.BackgroundImage = Resources.marble_yellow_32_s; button87.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button87.BackgroundImage = Resources.marble_yellow_32; button87.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button87_Enter(sender, e);
    }

    private void Button87_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button87.AccessibleName + colon + space;
      switch (button87.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button88_Click(object sender, EventArgs e)
    {
      switch (button88.Tag.ToString())
      {
        case marbleBlue32: button88.BackgroundImage = Resources.marble_blue_32_s; button88.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button88.BackgroundImage = Resources.marble_blue_32; button88.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button88.BackgroundImage = Resources.marble_green_32_s; button88.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button88.BackgroundImage = Resources.marble_green_32; button88.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button88.BackgroundImage = Resources.marble_red_32_s; button88.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button88.BackgroundImage = Resources.marble_red_32; button88.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button88.BackgroundImage = Resources.marble_yellow_32_s; button88.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button88.BackgroundImage = Resources.marble_yellow_32; button88.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button88_Enter(sender, e);
    }

    private void Button88_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button88.AccessibleName + colon + space;
      switch (button88.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button89_Click(object sender, EventArgs e)
    {
      switch (button89.Tag.ToString())
      {
        case marbleBlue32: button89.BackgroundImage = Resources.marble_blue_32_s; button89.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button89.BackgroundImage = Resources.marble_blue_32; button89.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button89.BackgroundImage = Resources.marble_green_32_s; button89.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button89.BackgroundImage = Resources.marble_green_32; button89.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button89.BackgroundImage = Resources.marble_red_32_s; button89.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button89.BackgroundImage = Resources.marble_red_32; button89.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button89.BackgroundImage = Resources.marble_yellow_32_s; button89.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button89.BackgroundImage = Resources.marble_yellow_32; button89.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button89_Enter(sender, e);
    }

    private void Button89_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button89.AccessibleName + colon + space;
      switch (button89.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button90_Click(object sender, EventArgs e)
    {
      switch (button90.Tag.ToString())
      {
        case marbleBlue32: button90.BackgroundImage = Resources.marble_blue_32_s; button90.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button90.BackgroundImage = Resources.marble_blue_32; button90.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button90.BackgroundImage = Resources.marble_green_32_s; button90.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button90.BackgroundImage = Resources.marble_green_32; button90.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button90.BackgroundImage = Resources.marble_red_32_s; button90.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button90.BackgroundImage = Resources.marble_red_32; button90.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button90.BackgroundImage = Resources.marble_yellow_32_s; button90.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button90.BackgroundImage = Resources.marble_yellow_32; button90.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button90_Enter(sender, e);
    }

    private void Button90_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button90.AccessibleName + colon + space;
      switch (button90.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button91_Click(object sender, EventArgs e)
    {
      switch (button91.Tag.ToString())
      {
        case marbleBlue32: button91.BackgroundImage = Resources.marble_blue_32_s; button91.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button91.BackgroundImage = Resources.marble_blue_32; button91.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button91.BackgroundImage = Resources.marble_green_32_s; button91.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button91.BackgroundImage = Resources.marble_green_32; button91.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button91.BackgroundImage = Resources.marble_red_32_s; button91.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button91.BackgroundImage = Resources.marble_red_32; button91.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button91.BackgroundImage = Resources.marble_yellow_32_s; button91.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button91.BackgroundImage = Resources.marble_yellow_32; button91.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button91_Enter(sender, e);
    }

    private void Button91_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button91.AccessibleName + colon + space;
      switch (button91.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button92_Click(object sender, EventArgs e)
    {
      switch (button92.Tag.ToString())
      {
        case marbleBlue32: button92.BackgroundImage = Resources.marble_blue_32_s; button92.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button92.BackgroundImage = Resources.marble_blue_32; button92.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button92.BackgroundImage = Resources.marble_green_32_s; button92.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button92.BackgroundImage = Resources.marble_green_32; button92.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button92.BackgroundImage = Resources.marble_red_32_s; button92.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button92.BackgroundImage = Resources.marble_red_32; button92.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button92.BackgroundImage = Resources.marble_yellow_32_s; button92.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button92.BackgroundImage = Resources.marble_yellow_32; button92.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button92_Enter(sender, e);
    }

    private void Button92_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button92.AccessibleName + colon + space;
      switch (button92.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button93_Click(object sender, EventArgs e)
    {
      switch (button93.Tag.ToString())
      {
        case marbleBlue32: button93.BackgroundImage = Resources.marble_blue_32_s; button93.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button93.BackgroundImage = Resources.marble_blue_32; button93.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button93.BackgroundImage = Resources.marble_green_32_s; button93.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button93.BackgroundImage = Resources.marble_green_32; button93.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button93.BackgroundImage = Resources.marble_red_32_s; button93.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button93.BackgroundImage = Resources.marble_red_32; button93.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button93.BackgroundImage = Resources.marble_yellow_32_s; button93.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button93.BackgroundImage = Resources.marble_yellow_32; button93.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button93_Enter(sender, e);
    }

    private void Button93_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button93.AccessibleName + colon + space;
      switch (button93.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button94_Click(object sender, EventArgs e)
    {
      switch (button94.Tag.ToString())
      {
        case marbleBlue32: button94.BackgroundImage = Resources.marble_blue_32_s; button94.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button94.BackgroundImage = Resources.marble_blue_32; button94.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button94.BackgroundImage = Resources.marble_green_32_s; button94.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button94.BackgroundImage = Resources.marble_green_32; button94.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button94.BackgroundImage = Resources.marble_red_32_s; button94.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button94.BackgroundImage = Resources.marble_red_32; button94.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button94.BackgroundImage = Resources.marble_yellow_32_s; button94.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button94.BackgroundImage = Resources.marble_yellow_32; button94.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button94_Enter(sender, e);
    }

    private void Button94_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button94.AccessibleName + colon + space;
      switch (button94.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button95_Click(object sender, EventArgs e)
    {
      switch (button95.Tag.ToString())
      {
        case marbleBlue32: button95.BackgroundImage = Resources.marble_blue_32_s; button95.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button95.BackgroundImage = Resources.marble_blue_32; button95.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button95.BackgroundImage = Resources.marble_green_32_s; button95.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button95.BackgroundImage = Resources.marble_green_32; button95.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button95.BackgroundImage = Resources.marble_red_32_s; button95.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button95.BackgroundImage = Resources.marble_red_32; button95.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button95.BackgroundImage = Resources.marble_yellow_32_s; button95.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button95.BackgroundImage = Resources.marble_yellow_32; button95.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button95_Enter(sender, e);
    }

    private void Button95_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button95.AccessibleName + colon + space;
      switch (button95.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button96_Click(object sender, EventArgs e)
    {
      switch (button96.Tag.ToString())
      {
        case marbleBlue32: button96.BackgroundImage = Resources.marble_blue_32_s; button96.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button96.BackgroundImage = Resources.marble_blue_32; button96.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button96.BackgroundImage = Resources.marble_green_32_s; button96.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button96.BackgroundImage = Resources.marble_green_32; button96.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button96.BackgroundImage = Resources.marble_red_32_s; button96.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button96.BackgroundImage = Resources.marble_red_32; button96.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button96.BackgroundImage = Resources.marble_yellow_32_s; button96.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button96.BackgroundImage = Resources.marble_yellow_32; button96.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button96_Enter(sender, e);
    }

    private void Button96_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button96.AccessibleName + colon + space;
      switch (button96.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button97_Click(object sender, EventArgs e)
    {
      switch (button97.Tag.ToString())
      {
        case marbleBlue32: button97.BackgroundImage = Resources.marble_blue_32_s; button97.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button97.BackgroundImage = Resources.marble_blue_32; button97.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button97.BackgroundImage = Resources.marble_green_32_s; button97.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button97.BackgroundImage = Resources.marble_green_32; button97.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button97.BackgroundImage = Resources.marble_red_32_s; button97.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button97.BackgroundImage = Resources.marble_red_32; button97.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button97.BackgroundImage = Resources.marble_yellow_32_s; button97.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button97.BackgroundImage = Resources.marble_yellow_32; button97.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button97_Enter(sender, e);
    }

    private void Button97_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button97.AccessibleName + colon + space;
      switch (button97.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button98_Click(object sender, EventArgs e)
    {
      switch (button98.Tag.ToString())
      {
        case marbleBlue32: button98.BackgroundImage = Resources.marble_blue_32_s; button98.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button98.BackgroundImage = Resources.marble_blue_32; button98.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button98.BackgroundImage = Resources.marble_green_32_s; button98.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button98.BackgroundImage = Resources.marble_green_32; button98.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button98.BackgroundImage = Resources.marble_red_32_s; button98.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button98.BackgroundImage = Resources.marble_red_32; button98.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button98.BackgroundImage = Resources.marble_yellow_32_s; button98.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button98.BackgroundImage = Resources.marble_yellow_32; button98.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button98_Enter(sender, e);
    }

    private void Button98_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button98.AccessibleName + colon + space;
      switch (button98.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button99_Click(object sender, EventArgs e)
    {
      switch (button99.Tag.ToString())
      {
        case marbleBlue32: button99.BackgroundImage = Resources.marble_blue_32_s; button99.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button99.BackgroundImage = Resources.marble_blue_32; button99.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button99.BackgroundImage = Resources.marble_green_32_s; button99.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button99.BackgroundImage = Resources.marble_green_32; button99.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button99.BackgroundImage = Resources.marble_red_32_s; button99.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button99.BackgroundImage = Resources.marble_red_32; button99.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button99.BackgroundImage = Resources.marble_yellow_32_s; button99.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button99.BackgroundImage = Resources.marble_yellow_32; button99.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button99_Enter(sender, e);
    }

    private void Button99_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button99.AccessibleName + colon + space;
      switch (button99.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }

    private void Button100_Click(object sender, EventArgs e)
    {
      switch (button100.Tag.ToString())
      {
        case marbleBlue32: button100.BackgroundImage = Resources.marble_blue_32_s; button100.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button100.BackgroundImage = Resources.marble_blue_32; button100.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button100.BackgroundImage = Resources.marble_green_32_s; button100.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button100.BackgroundImage = Resources.marble_green_32; button100.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button100.BackgroundImage = Resources.marble_red_32_s; button100.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button100.BackgroundImage = Resources.marble_red_32; button100.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button100.BackgroundImage = Resources.marble_yellow_32_s; button100.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button100.BackgroundImage = Resources.marble_yellow_32; button100.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      Button100_Enter(sender, e);
    }

    private void Button100_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button100.AccessibleName + colon + space;
      switch (button100.Tag.ToString())
      {
        case marbleBlue32: ButtonInformation += colorBlue; break;
        case marbleBlue32s: ButtonInformation = ButtonInformation + colorBlue + space + litUp; break;
        case marbleGreen32: ButtonInformation += colorGreen; break;
        case marbleGreen32s: ButtonInformation = ButtonInformation + colorGreen + space + litUp; break;
        case marbleRed32: ButtonInformation += colorRed; break;
        case marbleRed32s: ButtonInformation = ButtonInformation + colorRed + space + litUp; break;
        case marbleYellow32: ButtonInformation += colorYellow; break;
        case marbleYellow32s: ButtonInformation = ButtonInformation + colorYellow + space + litUp; break;
      }
      SetStatusbarInformationtext(ButtonInformation);
    }
  }
}
