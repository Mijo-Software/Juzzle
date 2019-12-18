using Juzzle.Properties;

using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

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

    public JuzzleForm() => InitializeComponent();

    #region Eigene Methoden

    private void ClearStatusbar_Leave(object sender, EventArgs e) => toolStripStatusLabelInformation.Text = string.Empty;

    private void ClearStatusbarInformationtext() => toolStripStatusLabelInformation.Text = string.Empty;

    private void SetStatusbarInformationtext(string information) => toolStripStatusLabelInformation.Text = information;

    private void InitFieldBackground(ref Button button)
    {
      switch (rnd.Next(minValue: 0, maxValue: 4))
      {
        case 0: button.Tag = marbleBlue32; button.BackgroundImage = Resources.marble_blue_32; break;
        case 1: button.Tag = marbleGreen32; button.BackgroundImage = Resources.marble_green_32; break;
        case 2: button.Tag = marbleRed32; button.BackgroundImage = Resources.marble_red_32; break;
        case 3: button.Tag = marbleYellow32; button.BackgroundImage = Resources.marble_yellow_32; break;
      }
    }

    private void SetGamefield()
    {
      InitFieldBackground(button: ref button1);
      InitFieldBackground(button: ref button2);
      InitFieldBackground(button: ref button3);
      InitFieldBackground(button: ref button4);
      InitFieldBackground(button: ref button5);
      InitFieldBackground(button: ref button6);
      InitFieldBackground(button: ref button7);
      InitFieldBackground(button: ref button8);
      InitFieldBackground(button: ref button9);
      InitFieldBackground(button: ref button10);
      InitFieldBackground(button: ref button11);
      InitFieldBackground(button: ref button12);
      InitFieldBackground(button: ref button13);
      InitFieldBackground(button: ref button14);
      InitFieldBackground(button: ref button15);
      InitFieldBackground(button: ref button16);
      InitFieldBackground(button: ref button17);
      InitFieldBackground(button: ref button18);
      InitFieldBackground(button: ref button19);
      InitFieldBackground(button: ref button20);
      InitFieldBackground(button: ref button21);
      InitFieldBackground(button: ref button22);
      InitFieldBackground(button: ref button23);
      InitFieldBackground(button: ref button24);
      InitFieldBackground(button: ref button25);
      InitFieldBackground(button: ref button26);
      InitFieldBackground(button: ref button27);
      InitFieldBackground(button: ref button28);
      InitFieldBackground(button: ref button29);
      InitFieldBackground(button: ref button30);
      InitFieldBackground(button: ref button31);
      InitFieldBackground(button: ref button32);
      InitFieldBackground(button: ref button33);
      InitFieldBackground(button: ref button34);
      InitFieldBackground(button: ref button35);
      InitFieldBackground(button: ref button36);
      InitFieldBackground(button: ref button37);
      InitFieldBackground(button: ref button38);
      InitFieldBackground(button: ref button39);
      InitFieldBackground(button: ref button40);
      InitFieldBackground(button: ref button41);
      InitFieldBackground(button: ref button42);
      InitFieldBackground(button: ref button43);
      InitFieldBackground(button: ref button44);
      InitFieldBackground(button: ref button45);
      InitFieldBackground(button: ref button46);
      InitFieldBackground(button: ref button47);
      InitFieldBackground(button: ref button48);
      InitFieldBackground(button: ref button49);
      InitFieldBackground(button: ref button50);
      InitFieldBackground(button: ref button51);
      InitFieldBackground(button: ref button52);
      InitFieldBackground(button: ref button53);
      InitFieldBackground(button: ref button54);
      InitFieldBackground(button: ref button55);
      InitFieldBackground(button: ref button56);
      InitFieldBackground(button: ref button57);
      InitFieldBackground(button: ref button58);
      InitFieldBackground(button: ref button59);
      InitFieldBackground(button: ref button60);
      InitFieldBackground(button: ref button61);
      InitFieldBackground(button: ref button62);
      InitFieldBackground(button: ref button63);
      InitFieldBackground(button: ref button64);
      InitFieldBackground(button: ref button65);
      InitFieldBackground(button: ref button66);
      InitFieldBackground(button: ref button67);
      InitFieldBackground(button: ref button68);
      InitFieldBackground(button: ref button69);
      InitFieldBackground(button: ref button70);
      InitFieldBackground(button: ref button71);
      InitFieldBackground(button: ref button72);
      InitFieldBackground(button: ref button73);
      InitFieldBackground(button: ref button74);
      InitFieldBackground(button: ref button75);
      InitFieldBackground(button: ref button76);
      InitFieldBackground(button: ref button77);
      InitFieldBackground(button: ref button78);
      InitFieldBackground(button: ref button79);
      InitFieldBackground(button: ref button80);
      InitFieldBackground(button: ref button81);
      InitFieldBackground(button: ref button82);
      InitFieldBackground(button: ref button83);
      InitFieldBackground(button: ref button84);
      InitFieldBackground(button: ref button85);
      InitFieldBackground(button: ref button86);
      InitFieldBackground(button: ref button87);
      InitFieldBackground(button: ref button88);
      InitFieldBackground(button: ref button89);
      InitFieldBackground(button: ref button90);
      InitFieldBackground(button: ref button91);
      InitFieldBackground(button: ref button92);
      InitFieldBackground(button: ref button93);
      InitFieldBackground(button: ref button94);
      InitFieldBackground(button: ref button95);
      InitFieldBackground(button: ref button96);
      InitFieldBackground(button: ref button97);
      InitFieldBackground(button: ref button98);
      InitFieldBackground(button: ref button99);
      InitFieldBackground(button: ref button100);
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

    private void PlayButtonClick()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + buttonClickOggFilename, path: soundDirectory + buttonClickOggFilename);
      }
    }

    private void PlayNewLevel()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + newLevelOggFilename, path: soundDirectory + newLevelOggFilename);
      }
    }

    private void PlayMarbleClick()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + marbleClickOggFilename, path: soundDirectory + marbleClickOggFilename);
      }
    }

    private void PlayRectangleComplete()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + rectangleCompleteOggFilename, path: soundDirectory + rectangleCompleteOggFilename);
      }
    }

    private void PlaySelectionCancelled()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + selectionCancelledOggFilename, path: soundDirectory + selectionCancelledOggFilename);
      }
    }

    private void PlaySelectionInvalid()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + selectionInvalidOggFilename, path: soundDirectory + selectionInvalidOggFilename);
      }
    }

    private void PlayGameOver()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + gameOverOggFilename, path: soundDirectory + gameOverOggFilename);
      }
    }

    private void PlayHighscore()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + highScoreOggFilename, path: soundDirectory + highScoreOggFilename);
      }
    }

    private void PlayPerfectRectangle()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + perfectRectangleOggFilename, path: soundDirectory + perfectRectangleOggFilename);
      }
    }

    private void PlayTimeAlert()
    {
      if (isSoundEnabled)
      {
        PlaySoundfile(ResourceName: defaultNamespace + dot + resources + dot + timeAlertOggFilename, path: soundDirectory + timeAlertOggFilename);
      }
    }

    #endregion

    private void JuzzleForm_Load(object sender, EventArgs e) => SetGamefield();

    #region Button "Sound"

    private void ButtonSound_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled)
      {
        isSoundEnabled = false;
        buttonSound.Image = Resources.unmute;
        SetStatusbarInformationtext(information: soundOff);
        PlayButtonClick();
      }
      else if (!isSoundEnabled)
      {
        isSoundEnabled = true;
        buttonSound.Image = Resources.mute;
        SetStatusbarInformationtext(information: soundOn);
        PlayButtonClick();
      }
    }

    private void ButtonSound_Enter(object sender, EventArgs e)
    {
      buttonSound.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(information: buttonSound.AccessibleDescription);
    }

    private void ButtonSound_MouseEnter(object sender, EventArgs e)
    {
      buttonSound.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(information: buttonSound.AccessibleDescription);
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

    private void ButtonSound_MouseDown(object sender, MouseEventArgs e) => buttonSound.BackgroundImage = Resources.btn_small_clicked;

    private void ButtonSound_MouseUp(object sender, MouseEventArgs e) => buttonSound.BackgroundImage = Resources.btn_small_hover;

    #endregion

    #region Button "High Score"

    private void ButtonHighscore_Click(object sender, EventArgs e)
    {
      PlayButtonClick();
      //Show high score here
    }

    private void ButtonHighscore_Enter(object sender, EventArgs e)
    {
      buttonHighscore.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(information: buttonHighscore.AccessibleDescription);
    }

    private void ButtonHighscore_MouseEnter(object sender, EventArgs e)
    {
      buttonHighscore.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(information: buttonHighscore.AccessibleDescription);
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

    private void ButtonHighscore_MouseDown(object sender, MouseEventArgs e) => buttonHighscore.BackgroundImage = Resources.btn_small_clicked;

    private void ButtonHighscore_MouseUp(object sender, MouseEventArgs e) => buttonHighscore.BackgroundImage = Resources.btn_small_hover;

    #endregion

    #region Button "Information"

    private void ButtonInformation_Click(object sender, EventArgs e)
    {
      PlayButtonClick();
      //Show inforamtion here
    }

    private void ButtonInformation_Enter(object sender, EventArgs e)
    {
      buttonInformation.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(information: buttonInformation.AccessibleDescription);
    }

    private void ButtonInformation_MouseEnter(object sender, EventArgs e)
    {
      buttonInformation.BackgroundImage = Resources.btn_small_hover;
      SetStatusbarInformationtext(information: buttonInformation.AccessibleDescription);
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

    private void ButtonInformation_MouseDown(object sender, MouseEventArgs e) => buttonInformation.BackgroundImage = Resources.btn_small_clicked;

    private void ButtonInformation_MouseUp(object sender, MouseEventArgs e) => buttonInformation.BackgroundImage = Resources.btn_small_hover;

    #endregion

    #region Button "Pause"

    private void SetBackgroundPause(ref Button button)
    {
      switch (button.Tag.ToString())
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
    }

    private void ButtonPause_Click(object sender, EventArgs e)
    {
      PlayButtonClick();
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
        SetBackgroundPause(button: ref button1);
        SetBackgroundPause(button: ref button2);
        SetBackgroundPause(button: ref button3);
        SetBackgroundPause(button: ref button4);
        SetBackgroundPause(button: ref button5);
        SetBackgroundPause(button: ref button6);
        SetBackgroundPause(button: ref button7);
        SetBackgroundPause(button: ref button8);
        SetBackgroundPause(button: ref button9);
        SetBackgroundPause(button: ref button10);
        SetBackgroundPause(button: ref button11);
        SetBackgroundPause(button: ref button12);
        SetBackgroundPause(button: ref button13);
        SetBackgroundPause(button: ref button14);
        SetBackgroundPause(button: ref button15);
        SetBackgroundPause(button: ref button16);
        SetBackgroundPause(button: ref button17);
        SetBackgroundPause(button: ref button18);
        SetBackgroundPause(button: ref button19);
        SetBackgroundPause(button: ref button20);
        SetBackgroundPause(button: ref button21);
        SetBackgroundPause(button: ref button22);
        SetBackgroundPause(button: ref button23);
        SetBackgroundPause(button: ref button24);
        SetBackgroundPause(button: ref button25);
        SetBackgroundPause(button: ref button26);
        SetBackgroundPause(button: ref button27);
        SetBackgroundPause(button: ref button28);
        SetBackgroundPause(button: ref button29);
        SetBackgroundPause(button: ref button30);
        SetBackgroundPause(button: ref button31);
        SetBackgroundPause(button: ref button32);
        SetBackgroundPause(button: ref button33);
        SetBackgroundPause(button: ref button34);
        SetBackgroundPause(button: ref button35);
        SetBackgroundPause(button: ref button36);
        SetBackgroundPause(button: ref button37);
        SetBackgroundPause(button: ref button38);
        SetBackgroundPause(button: ref button39);
        SetBackgroundPause(button: ref button40);
        SetBackgroundPause(button: ref button41);
        SetBackgroundPause(button: ref button42);
        SetBackgroundPause(button: ref button43);
        SetBackgroundPause(button: ref button44);
        SetBackgroundPause(button: ref button45);
        SetBackgroundPause(button: ref button46);
        SetBackgroundPause(button: ref button47);
        SetBackgroundPause(button: ref button48);
        SetBackgroundPause(button: ref button49);
        SetBackgroundPause(button: ref button50);
        SetBackgroundPause(button: ref button51);
        SetBackgroundPause(button: ref button52);
        SetBackgroundPause(button: ref button53);
        SetBackgroundPause(button: ref button54);
        SetBackgroundPause(button: ref button55);
        SetBackgroundPause(button: ref button56);
        SetBackgroundPause(button: ref button57);
        SetBackgroundPause(button: ref button58);
        SetBackgroundPause(button: ref button59);
        SetBackgroundPause(button: ref button60);
        SetBackgroundPause(button: ref button61);
        SetBackgroundPause(button: ref button62);
        SetBackgroundPause(button: ref button63);
        SetBackgroundPause(button: ref button64);
        SetBackgroundPause(button: ref button65);
        SetBackgroundPause(button: ref button66);
        SetBackgroundPause(button: ref button67);
        SetBackgroundPause(button: ref button68);
        SetBackgroundPause(button: ref button69);
        SetBackgroundPause(button: ref button70);
        SetBackgroundPause(button: ref button71);
        SetBackgroundPause(button: ref button72);
        SetBackgroundPause(button: ref button73);
        SetBackgroundPause(button: ref button74);
        SetBackgroundPause(button: ref button75);
        SetBackgroundPause(button: ref button76);
        SetBackgroundPause(button: ref button77);
        SetBackgroundPause(button: ref button78);
        SetBackgroundPause(button: ref button79);
        SetBackgroundPause(button: ref button80);
        SetBackgroundPause(button: ref button81);
        SetBackgroundPause(button: ref button82);
        SetBackgroundPause(button: ref button83);
        SetBackgroundPause(button: ref button84);
        SetBackgroundPause(button: ref button85);
        SetBackgroundPause(button: ref button86);
        SetBackgroundPause(button: ref button87);
        SetBackgroundPause(button: ref button88);
        SetBackgroundPause(button: ref button89);
        SetBackgroundPause(button: ref button90);
        SetBackgroundPause(button: ref button91);
        SetBackgroundPause(button: ref button92);
        SetBackgroundPause(button: ref button93);
        SetBackgroundPause(button: ref button94);
        SetBackgroundPause(button: ref button95);
        SetBackgroundPause(button: ref button96);
        SetBackgroundPause(button: ref button97);
        SetBackgroundPause(button: ref button98);
        SetBackgroundPause(button: ref button99);
        SetBackgroundPause(button: ref button100);
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
      SetStatusbarInformationtext(information: buttonPause.AccessibleDescription);
    }

    private void ButtonPause_MouseEnter(object sender, EventArgs e)
    {
      buttonPause.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(information: buttonPause.AccessibleDescription);
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

    private void ButtonPause_MouseDown(object sender, MouseEventArgs e) => buttonPause.BackgroundImage = Resources.btn_large_clicked;

    private void ButtonPause_MouseUp(object sender, MouseEventArgs e) => buttonPause.BackgroundImage = Resources.btn_large_hover;

    #endregion

    #region Button "Start"

    private void ButtonStart_Click(object sender, EventArgs e)
    {
      PlayButtonClick();
      SetGamefield();
    }

    private void ButtonStart_Enter(object sender, EventArgs e)
    {
      buttonStart.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(information: buttonStart.AccessibleDescription);
    }

    private void ButtonStart_MouseEnter(object sender, EventArgs e)
    {
      buttonStart.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(information: buttonStart.AccessibleDescription);
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

    private void ButtonStart_MouseDown(object sender, MouseEventArgs e) => buttonStart.BackgroundImage = Resources.btn_large_clicked;

    private void ButtonStart_MouseUp(object sender, MouseEventArgs e) => buttonStart.BackgroundImage = Resources.btn_large_hover;

    #endregion

    #region Button "Quit"

    private void ButtonQuit_Click(object sender, EventArgs e)
    {
      PlayButtonClick();
      Close();
    }

    private void ButtonQuit_Enter(object sender, EventArgs e)
    {
      buttonQuit.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(information: buttonQuit.AccessibleDescription);
    }

    private void ButtonQuit_MouseEnter(object sender, EventArgs e)
    {
      buttonQuit.BackgroundImage = Resources.btn_large_hover;
      SetStatusbarInformationtext(information: buttonQuit.AccessibleDescription);
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

    private void ButtonQuit_MouseDown(object sender, MouseEventArgs e) => buttonQuit.BackgroundImage = Resources.btn_large_clicked;

    private void ButtonQuit_MouseUp(object sender, MouseEventArgs e) => buttonQuit.BackgroundImage = Resources.btn_large_hover;

    #endregion

    private void ButtonField_Click(ref Button button)
    {
      switch (button.Tag.ToString())
      {
        case marbleBlue32: button.BackgroundImage = Resources.marble_blue_32_s; button.Tag = marbleBlue32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleBlue32s: button.BackgroundImage = Resources.marble_blue_32; button.Tag = marbleBlue32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleGreen32: button.BackgroundImage = Resources.marble_green_32_s; button.Tag = marbleGreen32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleGreen32s: button.BackgroundImage = Resources.marble_green_32; button.Tag = marbleGreen32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleRed32: button.BackgroundImage = Resources.marble_red_32_s; button.Tag = marbleRed32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleRed32s: button.BackgroundImage = Resources.marble_red_32; button.Tag = marbleRed32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
        case marbleYellow32: button.BackgroundImage = Resources.marble_yellow_32_s; button.Tag = marbleYellow32s; if (isSoundEnabled) { PlayMarbleClick(); } break;
        case marbleYellow32s: button.BackgroundImage = Resources.marble_yellow_32; button.Tag = marbleYellow32; if (isSoundEnabled) { PlaySelectionCancelled(); } break;
      }
      ButtonField_Enter(button: ref button);
    }

    private void ButtonField_Enter(ref Button button)
    {
      ButtonInformation = button.AccessibleName + colon + space;
      switch (button.Tag.ToString())
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
      SetStatusbarInformationtext(information: ButtonInformation);
    }

    private void Button1_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button1);

    private void Button1_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button1);

    private void Button2_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button2);

    private void Button2_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button2);

    private void Button3_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button3);

    private void Button3_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button3);

    private void Button4_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button4);

    private void Button4_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button4);

    private void Button5_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button5);

    private void Button5_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button5);

    private void Button6_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button6);

    private void Button6_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button6);

    private void Button7_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button7);

    private void Button7_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button7);

    private void Button8_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button8);

    private void Button8_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button8);

    private void Button9_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button9);

    private void Button9_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button9);

    private void Button10_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button10);

    private void Button10_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button10);

    private void Button11_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button11);

    private void Button11_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button11);

    private void Button12_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button12);

    private void Button12_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button12);

    private void Button13_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button13);

    private void Button13_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button13);

    private void Button14_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button14);

    private void Button14_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button14);

    private void Button15_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button15);

    private void Button15_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button15);

    private void Button16_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button16);

    private void Button16_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button16);

    private void Button17_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button17);

    private void Button17_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button17);

    private void Button18_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button18);

    private void Button18_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button18);

    private void Button19_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button19);

    private void Button19_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button19);

    private void Button20_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button20);

    private void Button20_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button20);

    private void Button21_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button21);

    private void Button21_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button21);

    private void Button22_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button22);

    private void Button22_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button22);

    private void Button23_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button23);

    private void Button23_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button23);

    private void Button24_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button24);

    private void Button24_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button24);

    private void Button25_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button25);

    private void Button25_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button25);

    private void Button26_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button26);

    private void Button26_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button26);

    private void Button27_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button27);

    private void Button27_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button27);

    private void Button28_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button28);

    private void Button28_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button28);

    private void Button29_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button29);

    private void Button29_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button29);

    private void Button30_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button30);

    private void Button30_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button30);

    private void Button31_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button31);

    private void Button31_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button31);

    private void Button32_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button32);

    private void Button32_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button32);

    private void Button33_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button33);

    private void Button33_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button33);

    private void Button34_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button34);

    private void Button34_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button34);

    private void Button35_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button35);

    private void Button35_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button35);

    private void Button36_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button36);

    private void Button36_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button36);

    private void Button37_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button37);

    private void Button37_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button37);

    private void Button38_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button38);

    private void Button38_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button38);

    private void Button39_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button39);

    private void Button39_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button39);

    private void Button40_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button40);

    private void Button40_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button40);

    private void Button41_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button41);

    private void Button41_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button41);

    private void Button42_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button42);

    private void Button42_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button42);

    private void Button43_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button43);

    private void Button43_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button43);

    private void Button44_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button44);

    private void Button44_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button44);

    private void Button45_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button45);

    private void Button45_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button45);

    private void Button46_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button46);

    private void Button46_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button46);

    private void Button47_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button47);

    private void Button47_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button47);

    private void Button48_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button48);

    private void Button48_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button48);

    private void Button49_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button49);

    private void Button49_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button49);

    private void Button50_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button50);

    private void Button50_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button50);

    private void Button51_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button51);

    private void Button51_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button51);

    private void Button52_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button52);

    private void Button52_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button52);

    private void Button53_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button53);

    private void Button53_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button53);

    private void Button54_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button54);

    private void Button54_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button54);

    private void Button55_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button55);

    private void Button55_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button55);

    private void Button56_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button56);

    private void Button56_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button56);

    private void Button57_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button57);

    private void Button57_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button57);

    private void Button58_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button58);

    private void Button58_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button58);

    private void Button59_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button59);

    private void Button59_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button59);

    private void Button60_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button60);

    private void Button60_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button60);

    private void Button61_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button61);

    private void Button61_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button61);

    private void Button62_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button62);

    private void Button62_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button62);

    private void Button63_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button63);

    private void Button63_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button63);

    private void Button64_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button64);

    private void Button64_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button64);

    private void Button65_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button65);

    private void Button65_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button65);

    private void Button66_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button66);

    private void Button66_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button66);

    private void Button67_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button67);

    private void Button67_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button67);

    private void Button68_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button68);

    private void Button68_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button68);

    private void Button69_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button69);

    private void Button69_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button69);

    private void Button70_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button70);

    private void Button70_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button70);

    private void Button71_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button71);

    private void Button71_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button71);

    private void Button72_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button72);

    private void Button72_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button72);

    private void Button73_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button73);

    private void Button73_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button73);

    private void Button74_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button74);

    private void Button74_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button74);

    private void Button75_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button75);

    private void Button75_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button75);

    private void Button76_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button76);

    private void Button76_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button76);

    private void Button77_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button77);

    private void Button77_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button77);

    private void Button78_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button78);

    private void Button78_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button78);

    private void Button79_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button79);

    private void Button79_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button79);

    private void Button80_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button80);

    private void Button80_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button80);

    private void Button81_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button81);

    private void Button81_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button81);

    private void Button82_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button82);

    private void Button82_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button82);

    private void Button83_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button83);

    private void Button83_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button83);

    private void Button84_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button84);

    private void Button84_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button84);

    private void Button85_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button85);

    private void Button85_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button85);

    private void Button86_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button86);

    private void Button86_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button86);

    private void Button87_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button87);

    private void Button87_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button87);

    private void Button88_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button88);

    private void Button88_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button88);

    private void Button89_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button89);

    private void Button89_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button89);

    private void Button90_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button90);

    private void Button90_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button90);

    private void Button91_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button91);

    private void Button91_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button91);

    private void Button92_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button92);

    private void Button92_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button92);

    private void Button93_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button93);

    private void Button93_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button93);

    private void Button94_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button94);

    private void Button94_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button94);

    private void Button95_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button95);

    private void Button95_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button95);

    private void Button96_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button96);

    private void Button96_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button96);

    private void Button97_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button97);

    private void Button97_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button97);

    private void Button98_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button98);

    private void Button98_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button98);

    private void Button99_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button99);

    private void Button99_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button99);

    private void Button100_Click(object sender, EventArgs e) => ButtonField_Click(button: ref button100);

    private void Button100_Enter(object sender, EventArgs e) => ButtonField_Enter(button: ref button100);
  }
}
