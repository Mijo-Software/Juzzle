using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Juzzle
{
  public partial class JuzzleForm : Form
  {
    const String COLON = ":";
    const String SPACE = " ";
    const String DOT = ".";
    const String BACKSLASH = "/";
    const String UNDERSCORE = "_";
    const String SIZE_16 = "16";
    const String SIZE_24 = "24";
    const String SIZE_32 = "32";
    const String SIZE_48 = "48";
    const String SIZE_64 = "64";
    const String S = "s";
    const String LITUP = "lit" + SPACE + "up";
    const String MARBLE = "marble";
    const String COLOR_GREY = "grey";
    const String COLOR_BLUE = "blue";
    const String COLOR_GREEN = "green";
    const String COLOR_RED = "red";
    const String COLOR_YELLOW = "yellow";
    const String MARBLE_GREY_32 = MARBLE + UNDERSCORE + COLOR_GREY + UNDERSCORE + SIZE_32;
    const String MARBLE_BLUE_32 = "marble_blue_32";
    const String MARBLE_BLUE_32_S = "marble_blue_32_s";
    const String MARBLE_GREEN_32 = "marble_green_32";
    const String MARBLE_GREEN_32_S = "marble_green_32_s";
    const String MARBLE_RED_32 = "marble_red_32";
    const String MARBLE_RED_32_S = "marble_red_32_s";
    const String MARBLE_YELLOW_32 = "marble_yellow_32";
    const String MARBLE_YELLOW_32_S = "marble_yellow_32_s";
    const String NO_SOUND_FILE_FOUND = "NO SOUND FILE FOUND!!!";
    const String SOUND_OFF = "sound OFF";
    const String SOUND_ON = "sound ON";
    const String DEFAULT_NAMESPACE = "Juzzle";
    const String RESOURCES = "Resources";
    const String DATA_DIRECTORY = "data" + BACKSLASH;
    const String SOUND_DIRECTORY = "data" + BACKSLASH + "sound" + BACKSLASH;
    const String BUTTON_CLICK_OGG_FILENAME = "button_click.ogg";
    const String GAME_OVER_OGG_FILENAME = "game_over.ogg";
    const String HIGH_SCORE_OGG_FILENAME = "high_score.ogg";
    const String MARBLE_CLICK_OGG_FILENAME = "marble_click.ogg";
    const String NEW_LEVEL_OGG_FILENAME = "new_level.ogg";
    const String PERFECT_RECTANGLE_OGG_FILENAME = "perfect_rectangle.ogg";
    const String RECTANGLE_COMPLETE_OGG_FILENAME = "rectangle_complete.ogg";
    const String SELECTION_CANCELLED_OGG_FILENAME = "selection_cancelled.ogg";
    const String SELECTION_INVALID_OGG_FILENAME = "selection_invalid.ogg";
    const String TIME_ALERT_OGG_FILENAME = "time_alert.ogg";
    Boolean isSoundEnabled = true;
    Boolean isGamePaused = false;
    Random rnd = new Random();
    String ButtonInformation;

    public JuzzleForm()
    {
      InitializeComponent();
      setGamefield();
    }

    #region Eigene Methoden

    private void clearStatusbarInformationtext()
    {
      toolStripStatusLabelInformation.Text = "";
    }

    private void setStatusbarInformationtext(String information)
    {
      toolStripStatusLabelInformation.Text = information;
    }

    private void setGamefield()
    {
      switch (rnd.Next(0, 4))
      {
        case 0: button1.BackgroundImage = Properties.Resources.marble_blue_32; button1.Tag = MARBLE_BLUE_32; break;
        case 1: button1.BackgroundImage = Properties.Resources.marble_green_32; button1.Tag = MARBLE_GREEN_32; break;
        case 2: button1.BackgroundImage = Properties.Resources.marble_red_32; button1.Tag = MARBLE_RED_32; break;
        case 3: button1.BackgroundImage = Properties.Resources.marble_yellow_32; button1.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button2.BackgroundImage = Properties.Resources.marble_blue_32; button2.Tag = MARBLE_BLUE_32; break;
        case 1: button2.BackgroundImage = Properties.Resources.marble_green_32; button2.Tag = MARBLE_GREEN_32; break;
        case 2: button2.BackgroundImage = Properties.Resources.marble_red_32; button2.Tag = MARBLE_RED_32; break;
        case 3: button2.BackgroundImage = Properties.Resources.marble_yellow_32; button2.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button3.BackgroundImage = Properties.Resources.marble_blue_32; button3.Tag = MARBLE_BLUE_32; break;
        case 1: button3.BackgroundImage = Properties.Resources.marble_green_32; button3.Tag = MARBLE_GREEN_32; break;
        case 2: button3.BackgroundImage = Properties.Resources.marble_red_32; button3.Tag = MARBLE_RED_32; break;
        case 3: button3.BackgroundImage = Properties.Resources.marble_yellow_32; button3.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button4.BackgroundImage = Properties.Resources.marble_blue_32; button4.Tag = MARBLE_BLUE_32; break;
        case 1: button4.BackgroundImage = Properties.Resources.marble_green_32; button4.Tag = MARBLE_GREEN_32; break;
        case 2: button4.BackgroundImage = Properties.Resources.marble_red_32; button4.Tag = MARBLE_RED_32; break;
        case 3: button4.BackgroundImage = Properties.Resources.marble_yellow_32; button4.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button5.BackgroundImage = Properties.Resources.marble_blue_32; button5.Tag = MARBLE_BLUE_32; break;
        case 1: button5.BackgroundImage = Properties.Resources.marble_green_32; button5.Tag = MARBLE_GREEN_32; break;
        case 2: button5.BackgroundImage = Properties.Resources.marble_red_32; button5.Tag = MARBLE_RED_32; break;
        case 3: button5.BackgroundImage = Properties.Resources.marble_yellow_32; button5.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button6.BackgroundImage = Properties.Resources.marble_blue_32; button6.Tag = MARBLE_BLUE_32; break;
        case 1: button6.BackgroundImage = Properties.Resources.marble_green_32; button6.Tag = MARBLE_GREEN_32; break;
        case 2: button6.BackgroundImage = Properties.Resources.marble_red_32; button6.Tag = MARBLE_RED_32; break;
        case 3: button6.BackgroundImage = Properties.Resources.marble_yellow_32; button6.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button7.BackgroundImage = Properties.Resources.marble_blue_32; button7.Tag = MARBLE_BLUE_32; break;
        case 1: button7.BackgroundImage = Properties.Resources.marble_green_32; button7.Tag = MARBLE_GREEN_32; break;
        case 2: button7.BackgroundImage = Properties.Resources.marble_red_32; button7.Tag = MARBLE_RED_32; break;
        case 3: button7.BackgroundImage = Properties.Resources.marble_yellow_32; button7.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button8.BackgroundImage = Properties.Resources.marble_blue_32; button8.Tag = MARBLE_BLUE_32; break;
        case 1: button8.BackgroundImage = Properties.Resources.marble_green_32; button8.Tag = MARBLE_GREEN_32; break;
        case 2: button8.BackgroundImage = Properties.Resources.marble_red_32; button8.Tag = MARBLE_RED_32; break;
        case 3: button8.BackgroundImage = Properties.Resources.marble_yellow_32; button8.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button9.BackgroundImage = Properties.Resources.marble_blue_32; button9.Tag = MARBLE_BLUE_32; break;
        case 1: button9.BackgroundImage = Properties.Resources.marble_green_32; button9.Tag = MARBLE_GREEN_32; break;
        case 2: button9.BackgroundImage = Properties.Resources.marble_red_32; button9.Tag = MARBLE_RED_32; break;
        case 3: button9.BackgroundImage = Properties.Resources.marble_yellow_32; button9.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button10.BackgroundImage = Properties.Resources.marble_blue_32; button10.Tag = MARBLE_BLUE_32; break;
        case 1: button10.BackgroundImage = Properties.Resources.marble_green_32; button10.Tag = MARBLE_GREEN_32; break;
        case 2: button10.BackgroundImage = Properties.Resources.marble_red_32; button10.Tag = MARBLE_RED_32; break;
        case 3: button10.BackgroundImage = Properties.Resources.marble_yellow_32; button10.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button11.BackgroundImage = Properties.Resources.marble_blue_32; button11.Tag = MARBLE_BLUE_32; break;
        case 1: button11.BackgroundImage = Properties.Resources.marble_green_32; button11.Tag = MARBLE_GREEN_32; break;
        case 2: button11.BackgroundImage = Properties.Resources.marble_red_32; button11.Tag = MARBLE_RED_32; break;
        case 3: button11.BackgroundImage = Properties.Resources.marble_yellow_32; button11.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button12.BackgroundImage = Properties.Resources.marble_blue_32; button12.Tag = MARBLE_BLUE_32; break;
        case 1: button12.BackgroundImage = Properties.Resources.marble_green_32; button12.Tag = MARBLE_GREEN_32; break;
        case 2: button12.BackgroundImage = Properties.Resources.marble_red_32; button12.Tag = MARBLE_RED_32; break;
        case 3: button12.BackgroundImage = Properties.Resources.marble_yellow_32; button12.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button13.BackgroundImage = Properties.Resources.marble_blue_32; button13.Tag = MARBLE_BLUE_32; break;
        case 1: button13.BackgroundImage = Properties.Resources.marble_green_32; button13.Tag = MARBLE_GREEN_32; break;
        case 2: button13.BackgroundImage = Properties.Resources.marble_red_32; button13.Tag = MARBLE_RED_32; break;
        case 3: button13.BackgroundImage = Properties.Resources.marble_yellow_32; button13.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button14.BackgroundImage = Properties.Resources.marble_blue_32; button14.Tag = MARBLE_BLUE_32; break;
        case 1: button14.BackgroundImage = Properties.Resources.marble_green_32; button14.Tag = MARBLE_GREEN_32; break;
        case 2: button14.BackgroundImage = Properties.Resources.marble_red_32; button14.Tag = MARBLE_RED_32; break;
        case 3: button14.BackgroundImage = Properties.Resources.marble_yellow_32; button14.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button15.BackgroundImage = Properties.Resources.marble_blue_32; button15.Tag = MARBLE_BLUE_32; break;
        case 1: button15.BackgroundImage = Properties.Resources.marble_green_32; button15.Tag = MARBLE_GREEN_32; break;
        case 2: button15.BackgroundImage = Properties.Resources.marble_red_32; button15.Tag = MARBLE_RED_32; break;
        case 3: button15.BackgroundImage = Properties.Resources.marble_yellow_32; button15.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button16.BackgroundImage = Properties.Resources.marble_blue_32; button16.Tag = MARBLE_BLUE_32; break;
        case 1: button16.BackgroundImage = Properties.Resources.marble_green_32; button16.Tag = MARBLE_GREEN_32; break;
        case 2: button16.BackgroundImage = Properties.Resources.marble_red_32; button16.Tag = MARBLE_RED_32; break;
        case 3: button16.BackgroundImage = Properties.Resources.marble_yellow_32; button16.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button17.BackgroundImage = Properties.Resources.marble_blue_32; button17.Tag = MARBLE_BLUE_32; break;
        case 1: button17.BackgroundImage = Properties.Resources.marble_green_32; button17.Tag = MARBLE_GREEN_32; break;
        case 2: button17.BackgroundImage = Properties.Resources.marble_red_32; button17.Tag = MARBLE_RED_32; break;
        case 3: button17.BackgroundImage = Properties.Resources.marble_yellow_32; button17.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button18.BackgroundImage = Properties.Resources.marble_blue_32; button18.Tag = MARBLE_BLUE_32; break;
        case 1: button18.BackgroundImage = Properties.Resources.marble_green_32; button18.Tag = MARBLE_GREEN_32; break;
        case 2: button18.BackgroundImage = Properties.Resources.marble_red_32; button18.Tag = MARBLE_RED_32; break;
        case 3: button18.BackgroundImage = Properties.Resources.marble_yellow_32; button18.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button19.BackgroundImage = Properties.Resources.marble_blue_32; button19.Tag = MARBLE_BLUE_32; break;
        case 1: button19.BackgroundImage = Properties.Resources.marble_green_32; button19.Tag = MARBLE_GREEN_32; break;
        case 2: button19.BackgroundImage = Properties.Resources.marble_red_32; button19.Tag = MARBLE_RED_32; break;
        case 3: button19.BackgroundImage = Properties.Resources.marble_yellow_32; button19.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button20.BackgroundImage = Properties.Resources.marble_blue_32; button20.Tag = MARBLE_BLUE_32; break;
        case 1: button20.BackgroundImage = Properties.Resources.marble_green_32; button20.Tag = MARBLE_GREEN_32; break;
        case 2: button20.BackgroundImage = Properties.Resources.marble_red_32; button20.Tag = MARBLE_RED_32; break;
        case 3: button20.BackgroundImage = Properties.Resources.marble_yellow_32; button20.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button21.BackgroundImage = Properties.Resources.marble_blue_32; button21.Tag = MARBLE_BLUE_32; break;
        case 1: button21.BackgroundImage = Properties.Resources.marble_green_32; button21.Tag = MARBLE_GREEN_32; break;
        case 2: button21.BackgroundImage = Properties.Resources.marble_red_32; button21.Tag = MARBLE_RED_32; break;
        case 3: button21.BackgroundImage = Properties.Resources.marble_yellow_32; button21.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button22.BackgroundImage = Properties.Resources.marble_blue_32; button22.Tag = MARBLE_BLUE_32; break;
        case 1: button22.BackgroundImage = Properties.Resources.marble_green_32; button22.Tag = MARBLE_GREEN_32; break;
        case 2: button22.BackgroundImage = Properties.Resources.marble_red_32; button22.Tag = MARBLE_BLUE_32; break;
        case 3: button22.BackgroundImage = Properties.Resources.marble_yellow_32; button22.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button23.BackgroundImage = Properties.Resources.marble_blue_32; button23.Tag = MARBLE_BLUE_32; break;
        case 1: button23.BackgroundImage = Properties.Resources.marble_green_32; button23.Tag = MARBLE_GREEN_32; break;
        case 2: button23.BackgroundImage = Properties.Resources.marble_red_32; button23.Tag = MARBLE_RED_32; break;
        case 3: button23.BackgroundImage = Properties.Resources.marble_yellow_32; button23.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button24.BackgroundImage = Properties.Resources.marble_blue_32; button24.Tag = MARBLE_BLUE_32; break;
        case 1: button24.BackgroundImage = Properties.Resources.marble_green_32; button24.Tag = MARBLE_GREEN_32; break;
        case 2: button24.BackgroundImage = Properties.Resources.marble_red_32; button24.Tag = MARBLE_RED_32; break;
        case 3: button24.BackgroundImage = Properties.Resources.marble_yellow_32; button24.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button25.BackgroundImage = Properties.Resources.marble_blue_32; button25.Tag = MARBLE_BLUE_32; break;
        case 1: button25.BackgroundImage = Properties.Resources.marble_green_32; button25.Tag = MARBLE_GREEN_32; break;
        case 2: button25.BackgroundImage = Properties.Resources.marble_red_32; button25.Tag = MARBLE_RED_32; break;
        case 3: button25.BackgroundImage = Properties.Resources.marble_yellow_32; button25.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button26.BackgroundImage = Properties.Resources.marble_blue_32; button26.Tag = MARBLE_BLUE_32; break;
        case 1: button26.BackgroundImage = Properties.Resources.marble_green_32; button26.Tag = MARBLE_GREEN_32; break;
        case 2: button26.BackgroundImage = Properties.Resources.marble_red_32; button26.Tag = MARBLE_RED_32; break;
        case 3: button26.BackgroundImage = Properties.Resources.marble_yellow_32; button26.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button27.BackgroundImage = Properties.Resources.marble_blue_32; button27.Tag = MARBLE_BLUE_32; break;
        case 1: button27.BackgroundImage = Properties.Resources.marble_green_32; button27.Tag = MARBLE_GREEN_32; break;
        case 2: button27.BackgroundImage = Properties.Resources.marble_red_32; button27.Tag = MARBLE_RED_32; break;
        case 3: button27.BackgroundImage = Properties.Resources.marble_yellow_32; button27.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button28.BackgroundImage = Properties.Resources.marble_blue_32; button28.Tag = MARBLE_BLUE_32; break;
        case 1: button28.BackgroundImage = Properties.Resources.marble_green_32; button28.Tag = MARBLE_GREEN_32; break;
        case 2: button28.BackgroundImage = Properties.Resources.marble_red_32; button28.Tag = MARBLE_RED_32; break;
        case 3: button28.BackgroundImage = Properties.Resources.marble_yellow_32; button28.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button29.BackgroundImage = Properties.Resources.marble_blue_32; button29.Tag = MARBLE_BLUE_32; break;
        case 1: button29.BackgroundImage = Properties.Resources.marble_green_32; button29.Tag = MARBLE_GREEN_32; break;
        case 2: button29.BackgroundImage = Properties.Resources.marble_red_32; button29.Tag = MARBLE_RED_32; break;
        case 3: button29.BackgroundImage = Properties.Resources.marble_yellow_32; button29.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button30.BackgroundImage = Properties.Resources.marble_blue_32; button30.Tag = MARBLE_BLUE_32; break;
        case 1: button30.BackgroundImage = Properties.Resources.marble_green_32; button30.Tag = MARBLE_GREEN_32; break;
        case 2: button30.BackgroundImage = Properties.Resources.marble_red_32; button30.Tag = MARBLE_RED_32; break;
        case 3: button30.BackgroundImage = Properties.Resources.marble_yellow_32; button30.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button31.BackgroundImage = Properties.Resources.marble_blue_32; button31.Tag = MARBLE_BLUE_32; break;
        case 1: button31.BackgroundImage = Properties.Resources.marble_green_32; button31.Tag = MARBLE_GREEN_32; break;
        case 2: button31.BackgroundImage = Properties.Resources.marble_red_32; button31.Tag = MARBLE_RED_32; break;
        case 3: button31.BackgroundImage = Properties.Resources.marble_yellow_32; button31.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button32.BackgroundImage = Properties.Resources.marble_blue_32; button32.Tag = MARBLE_BLUE_32; break;
        case 1: button32.BackgroundImage = Properties.Resources.marble_green_32; button32.Tag = MARBLE_GREEN_32; break;
        case 2: button32.BackgroundImage = Properties.Resources.marble_red_32; button32.Tag = MARBLE_RED_32; break;
        case 3: button32.BackgroundImage = Properties.Resources.marble_yellow_32; button32.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button33.BackgroundImage = Properties.Resources.marble_blue_32; button33.Tag = MARBLE_BLUE_32; break;
        case 1: button33.BackgroundImage = Properties.Resources.marble_green_32; button33.Tag = MARBLE_GREEN_32; break;
        case 2: button33.BackgroundImage = Properties.Resources.marble_red_32; button33.Tag = MARBLE_RED_32; break;
        case 3: button33.BackgroundImage = Properties.Resources.marble_yellow_32; button33.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button34.BackgroundImage = Properties.Resources.marble_blue_32; button34.Tag = MARBLE_BLUE_32; break;
        case 1: button34.BackgroundImage = Properties.Resources.marble_green_32; button34.Tag = MARBLE_GREEN_32; break;
        case 2: button34.BackgroundImage = Properties.Resources.marble_red_32; button34.Tag = MARBLE_RED_32; break;
        case 3: button34.BackgroundImage = Properties.Resources.marble_yellow_32; button34.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button35.BackgroundImage = Properties.Resources.marble_blue_32; button35.Tag = MARBLE_BLUE_32; break;
        case 1: button35.BackgroundImage = Properties.Resources.marble_green_32; button35.Tag = MARBLE_GREEN_32; break;
        case 2: button35.BackgroundImage = Properties.Resources.marble_red_32; button35.Tag = MARBLE_RED_32; break;
        case 3: button35.BackgroundImage = Properties.Resources.marble_yellow_32; button35.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button36.BackgroundImage = Properties.Resources.marble_blue_32; button36.Tag = MARBLE_BLUE_32; break;
        case 1: button36.BackgroundImage = Properties.Resources.marble_green_32; button36.Tag = MARBLE_GREEN_32; break;
        case 2: button36.BackgroundImage = Properties.Resources.marble_red_32; button36.Tag = MARBLE_RED_32; break;
        case 3: button36.BackgroundImage = Properties.Resources.marble_yellow_32; button36.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button37.BackgroundImage = Properties.Resources.marble_blue_32; button37.Tag = MARBLE_BLUE_32; break;
        case 1: button37.BackgroundImage = Properties.Resources.marble_green_32; button37.Tag = MARBLE_GREEN_32; break;
        case 2: button37.BackgroundImage = Properties.Resources.marble_red_32; button37.Tag = MARBLE_RED_32; break;
        case 3: button37.BackgroundImage = Properties.Resources.marble_yellow_32; button37.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button38.BackgroundImage = Properties.Resources.marble_blue_32; button38.Tag = MARBLE_BLUE_32; break;
        case 1: button38.BackgroundImage = Properties.Resources.marble_green_32; button38.Tag = MARBLE_GREEN_32; break;
        case 2: button38.BackgroundImage = Properties.Resources.marble_red_32; button38.Tag = MARBLE_RED_32; break;
        case 3: button38.BackgroundImage = Properties.Resources.marble_yellow_32; button38.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button39.BackgroundImage = Properties.Resources.marble_blue_32; button39.Tag = MARBLE_BLUE_32; break;
        case 1: button39.BackgroundImage = Properties.Resources.marble_green_32; button39.Tag = MARBLE_GREEN_32; break;
        case 2: button39.BackgroundImage = Properties.Resources.marble_red_32; button39.Tag = MARBLE_RED_32; break;
        case 3: button39.BackgroundImage = Properties.Resources.marble_yellow_32; button39.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button40.BackgroundImage = Properties.Resources.marble_blue_32; button40.Tag = MARBLE_BLUE_32; break;
        case 1: button40.BackgroundImage = Properties.Resources.marble_green_32; button40.Tag = MARBLE_GREEN_32; break;
        case 2: button40.BackgroundImage = Properties.Resources.marble_red_32; button40.Tag = MARBLE_RED_32; break;
        case 3: button40.BackgroundImage = Properties.Resources.marble_yellow_32; button40.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button41.BackgroundImage = Properties.Resources.marble_blue_32; button41.Tag = MARBLE_BLUE_32; break;
        case 1: button41.BackgroundImage = Properties.Resources.marble_green_32; button41.Tag = MARBLE_GREEN_32; break;
        case 2: button41.BackgroundImage = Properties.Resources.marble_red_32; button41.Tag = MARBLE_RED_32; break;
        case 3: button41.BackgroundImage = Properties.Resources.marble_yellow_32; button41.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button42.BackgroundImage = Properties.Resources.marble_blue_32; button42.Tag = MARBLE_BLUE_32; break;
        case 1: button42.BackgroundImage = Properties.Resources.marble_green_32; button42.Tag = MARBLE_GREEN_32; break;
        case 2: button42.BackgroundImage = Properties.Resources.marble_red_32; button42.Tag = MARBLE_RED_32; break;
        case 3: button42.BackgroundImage = Properties.Resources.marble_yellow_32; button42.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button43.BackgroundImage = Properties.Resources.marble_blue_32; button43.Tag = MARBLE_BLUE_32; break;
        case 1: button43.BackgroundImage = Properties.Resources.marble_green_32; button43.Tag = MARBLE_GREEN_32; break;
        case 2: button43.BackgroundImage = Properties.Resources.marble_red_32; button43.Tag = MARBLE_RED_32; break;
        case 3: button43.BackgroundImage = Properties.Resources.marble_yellow_32; button43.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button44.BackgroundImage = Properties.Resources.marble_blue_32; button44.Tag = MARBLE_BLUE_32; break;
        case 1: button44.BackgroundImage = Properties.Resources.marble_green_32; button44.Tag = MARBLE_GREEN_32; break;
        case 2: button44.BackgroundImage = Properties.Resources.marble_red_32; button44.Tag = MARBLE_RED_32; break;
        case 3: button44.BackgroundImage = Properties.Resources.marble_yellow_32; button44.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button45.BackgroundImage = Properties.Resources.marble_blue_32; button45.Tag = MARBLE_BLUE_32; break;
        case 1: button45.BackgroundImage = Properties.Resources.marble_green_32; button45.Tag = MARBLE_GREEN_32; break;
        case 2: button45.BackgroundImage = Properties.Resources.marble_red_32; button45.Tag = MARBLE_RED_32; break;
        case 3: button45.BackgroundImage = Properties.Resources.marble_yellow_32; button45.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button46.BackgroundImage = Properties.Resources.marble_blue_32; button46.Tag = MARBLE_BLUE_32; break;
        case 1: button46.BackgroundImage = Properties.Resources.marble_green_32; button46.Tag = MARBLE_GREEN_32; break;
        case 2: button46.BackgroundImage = Properties.Resources.marble_red_32; button46.Tag = MARBLE_RED_32; break;
        case 3: button46.BackgroundImage = Properties.Resources.marble_yellow_32; button46.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button47.BackgroundImage = Properties.Resources.marble_blue_32; button47.Tag = MARBLE_BLUE_32; break;
        case 1: button47.BackgroundImage = Properties.Resources.marble_green_32; button47.Tag = MARBLE_GREEN_32; break;
        case 2: button47.BackgroundImage = Properties.Resources.marble_red_32; button47.Tag = MARBLE_RED_32; break;
        case 3: button47.BackgroundImage = Properties.Resources.marble_yellow_32; button47.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button48.BackgroundImage = Properties.Resources.marble_blue_32; button48.Tag = MARBLE_BLUE_32; break;
        case 1: button48.BackgroundImage = Properties.Resources.marble_green_32; button48.Tag = MARBLE_GREEN_32; break;
        case 2: button48.BackgroundImage = Properties.Resources.marble_red_32; button48.Tag = MARBLE_RED_32; break;
        case 3: button48.BackgroundImage = Properties.Resources.marble_yellow_32; button48.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button49.BackgroundImage = Properties.Resources.marble_blue_32; button49.Tag = MARBLE_BLUE_32; break;
        case 1: button49.BackgroundImage = Properties.Resources.marble_green_32; button49.Tag = MARBLE_GREEN_32; break;
        case 2: button49.BackgroundImage = Properties.Resources.marble_red_32; button49.Tag = MARBLE_RED_32; break;
        case 3: button49.BackgroundImage = Properties.Resources.marble_yellow_32; button49.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button50.BackgroundImage = Properties.Resources.marble_blue_32; button50.Tag = MARBLE_BLUE_32; break;
        case 1: button50.BackgroundImage = Properties.Resources.marble_green_32; button50.Tag = MARBLE_GREEN_32; break;
        case 2: button50.BackgroundImage = Properties.Resources.marble_red_32; button50.Tag = MARBLE_RED_32; break;
        case 3: button50.BackgroundImage = Properties.Resources.marble_yellow_32; button50.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button51.BackgroundImage = Properties.Resources.marble_blue_32; button51.Tag = MARBLE_BLUE_32; break;
        case 1: button51.BackgroundImage = Properties.Resources.marble_green_32; button51.Tag = MARBLE_GREEN_32; break;
        case 2: button51.BackgroundImage = Properties.Resources.marble_red_32; button51.Tag = MARBLE_RED_32; break;
        case 3: button51.BackgroundImage = Properties.Resources.marble_yellow_32; button51.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button52.BackgroundImage = Properties.Resources.marble_blue_32; button52.Tag = MARBLE_BLUE_32; break;
        case 1: button52.BackgroundImage = Properties.Resources.marble_green_32; button52.Tag = MARBLE_GREEN_32; break;
        case 2: button52.BackgroundImage = Properties.Resources.marble_red_32; button52.Tag = MARBLE_RED_32; break;
        case 3: button52.BackgroundImage = Properties.Resources.marble_yellow_32; button52.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button53.BackgroundImage = Properties.Resources.marble_blue_32; button53.Tag = MARBLE_BLUE_32; break;
        case 1: button53.BackgroundImage = Properties.Resources.marble_green_32; button53.Tag = MARBLE_GREEN_32; break;
        case 2: button53.BackgroundImage = Properties.Resources.marble_red_32; button53.Tag = MARBLE_RED_32; break;
        case 3: button53.BackgroundImage = Properties.Resources.marble_yellow_32; button53.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button54.BackgroundImage = Properties.Resources.marble_blue_32; button54.Tag = MARBLE_BLUE_32; break;
        case 1: button54.BackgroundImage = Properties.Resources.marble_green_32; button54.Tag = MARBLE_GREEN_32; break;
        case 2: button54.BackgroundImage = Properties.Resources.marble_red_32; button54.Tag = MARBLE_RED_32; break;
        case 3: button54.BackgroundImage = Properties.Resources.marble_yellow_32; button54.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button55.BackgroundImage = Properties.Resources.marble_blue_32; button55.Tag = MARBLE_BLUE_32; break;
        case 1: button55.BackgroundImage = Properties.Resources.marble_green_32; button55.Tag = MARBLE_GREEN_32; break;
        case 2: button55.BackgroundImage = Properties.Resources.marble_red_32; button55.Tag = MARBLE_RED_32; break;
        case 3: button55.BackgroundImage = Properties.Resources.marble_yellow_32; button55.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button56.BackgroundImage = Properties.Resources.marble_blue_32; button56.Tag = MARBLE_BLUE_32; break;
        case 1: button56.BackgroundImage = Properties.Resources.marble_green_32; button56.Tag = MARBLE_GREEN_32; break;
        case 2: button56.BackgroundImage = Properties.Resources.marble_red_32; button56.Tag = MARBLE_RED_32; break;
        case 3: button56.BackgroundImage = Properties.Resources.marble_yellow_32; button56.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button57.BackgroundImage = Properties.Resources.marble_blue_32; button57.Tag = MARBLE_BLUE_32; break;
        case 1: button57.BackgroundImage = Properties.Resources.marble_green_32; button57.Tag = MARBLE_GREEN_32; break;
        case 2: button57.BackgroundImage = Properties.Resources.marble_red_32; button57.Tag = MARBLE_RED_32; break;
        case 3: button57.BackgroundImage = Properties.Resources.marble_yellow_32; button57.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button58.BackgroundImage = Properties.Resources.marble_blue_32; button58.Tag = MARBLE_BLUE_32; break;
        case 1: button58.BackgroundImage = Properties.Resources.marble_green_32; button58.Tag = MARBLE_GREEN_32; break;
        case 2: button58.BackgroundImage = Properties.Resources.marble_red_32; button58.Tag = MARBLE_RED_32; break;
        case 3: button58.BackgroundImage = Properties.Resources.marble_yellow_32; button58.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button59.BackgroundImage = Properties.Resources.marble_blue_32; button59.Tag = MARBLE_BLUE_32; break;
        case 1: button59.BackgroundImage = Properties.Resources.marble_green_32; button59.Tag = MARBLE_GREEN_32; break;
        case 2: button59.BackgroundImage = Properties.Resources.marble_red_32; button59.Tag = MARBLE_RED_32; break;
        case 3: button59.BackgroundImage = Properties.Resources.marble_yellow_32; button59.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button60.BackgroundImage = Properties.Resources.marble_blue_32; button60.Tag = MARBLE_BLUE_32; break;
        case 1: button60.BackgroundImage = Properties.Resources.marble_green_32; button60.Tag = MARBLE_GREEN_32; break;
        case 2: button60.BackgroundImage = Properties.Resources.marble_red_32; button60.Tag = MARBLE_RED_32; break;
        case 3: button60.BackgroundImage = Properties.Resources.marble_yellow_32; button60.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button61.BackgroundImage = Properties.Resources.marble_blue_32; button61.Tag = MARBLE_BLUE_32; break;
        case 1: button61.BackgroundImage = Properties.Resources.marble_green_32; button61.Tag = MARBLE_GREEN_32; break;
        case 2: button61.BackgroundImage = Properties.Resources.marble_red_32; button61.Tag = MARBLE_RED_32; break;
        case 3: button61.BackgroundImage = Properties.Resources.marble_yellow_32; button61.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button62.BackgroundImage = Properties.Resources.marble_blue_32; button62.Tag = MARBLE_BLUE_32; break;
        case 1: button62.BackgroundImage = Properties.Resources.marble_green_32; button62.Tag = MARBLE_GREEN_32; break;
        case 2: button62.BackgroundImage = Properties.Resources.marble_red_32; button62.Tag = MARBLE_RED_32; break;
        case 3: button62.BackgroundImage = Properties.Resources.marble_yellow_32; button62.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button63.BackgroundImage = Properties.Resources.marble_blue_32; button63.Tag = MARBLE_BLUE_32; break;
        case 1: button63.BackgroundImage = Properties.Resources.marble_green_32; button63.Tag = MARBLE_GREEN_32; break;
        case 2: button63.BackgroundImage = Properties.Resources.marble_red_32; button63.Tag = MARBLE_RED_32; break;
        case 3: button63.BackgroundImage = Properties.Resources.marble_yellow_32; button63.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button64.BackgroundImage = Properties.Resources.marble_blue_32; button64.Tag = MARBLE_BLUE_32; break;
        case 1: button64.BackgroundImage = Properties.Resources.marble_green_32; button64.Tag = MARBLE_GREEN_32; break;
        case 2: button64.BackgroundImage = Properties.Resources.marble_red_32; button64.Tag = MARBLE_RED_32; break;
        case 3: button64.BackgroundImage = Properties.Resources.marble_yellow_32; button64.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button65.BackgroundImage = Properties.Resources.marble_blue_32; button65.Tag = MARBLE_BLUE_32; break;
        case 1: button65.BackgroundImage = Properties.Resources.marble_green_32; button65.Tag = MARBLE_GREEN_32; break;
        case 2: button65.BackgroundImage = Properties.Resources.marble_red_32; button65.Tag = MARBLE_RED_32; break;
        case 3: button65.BackgroundImage = Properties.Resources.marble_yellow_32; button65.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button66.BackgroundImage = Properties.Resources.marble_blue_32; button66.Tag = MARBLE_BLUE_32; break;
        case 1: button66.BackgroundImage = Properties.Resources.marble_green_32; button66.Tag = MARBLE_GREEN_32; break;
        case 2: button66.BackgroundImage = Properties.Resources.marble_red_32; button66.Tag = MARBLE_RED_32; break;
        case 3: button66.BackgroundImage = Properties.Resources.marble_yellow_32; button66.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button67.BackgroundImage = Properties.Resources.marble_blue_32; button67.Tag = MARBLE_BLUE_32; break;
        case 1: button67.BackgroundImage = Properties.Resources.marble_green_32; button67.Tag = MARBLE_GREEN_32; break;
        case 2: button67.BackgroundImage = Properties.Resources.marble_red_32; button67.Tag = MARBLE_RED_32; break;
        case 3: button67.BackgroundImage = Properties.Resources.marble_yellow_32; button67.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button68.BackgroundImage = Properties.Resources.marble_blue_32; button68.Tag = MARBLE_BLUE_32; break;
        case 1: button68.BackgroundImage = Properties.Resources.marble_green_32; button68.Tag = MARBLE_GREEN_32; break;
        case 2: button68.BackgroundImage = Properties.Resources.marble_red_32; button68.Tag = MARBLE_RED_32; break;
        case 3: button68.BackgroundImage = Properties.Resources.marble_yellow_32; button68.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button69.BackgroundImage = Properties.Resources.marble_blue_32; button69.Tag = MARBLE_BLUE_32; break;
        case 1: button69.BackgroundImage = Properties.Resources.marble_green_32; button69.Tag = MARBLE_GREEN_32; break;
        case 2: button69.BackgroundImage = Properties.Resources.marble_red_32; button69.Tag = MARBLE_RED_32; break;
        case 3: button69.BackgroundImage = Properties.Resources.marble_yellow_32; button69.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button70.BackgroundImage = Properties.Resources.marble_blue_32; button70.Tag = MARBLE_BLUE_32; break;
        case 1: button70.BackgroundImage = Properties.Resources.marble_green_32; button70.Tag = MARBLE_GREEN_32; break;
        case 2: button70.BackgroundImage = Properties.Resources.marble_red_32; button70.Tag = MARBLE_RED_32; break;
        case 3: button70.BackgroundImage = Properties.Resources.marble_yellow_32; button70.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button71.BackgroundImage = Properties.Resources.marble_blue_32; button71.Tag = MARBLE_BLUE_32; break;
        case 1: button71.BackgroundImage = Properties.Resources.marble_green_32; button71.Tag = MARBLE_GREEN_32; break;
        case 2: button71.BackgroundImage = Properties.Resources.marble_red_32; button71.Tag = MARBLE_RED_32; break;
        case 3: button71.BackgroundImage = Properties.Resources.marble_yellow_32; button71.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button72.BackgroundImage = Properties.Resources.marble_blue_32; button72.Tag = MARBLE_BLUE_32; break;
        case 1: button72.BackgroundImage = Properties.Resources.marble_green_32; button72.Tag = MARBLE_GREEN_32; break;
        case 2: button72.BackgroundImage = Properties.Resources.marble_red_32; button72.Tag = MARBLE_RED_32; break;
        case 3: button72.BackgroundImage = Properties.Resources.marble_yellow_32; button72.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button73.BackgroundImage = Properties.Resources.marble_blue_32; button73.Tag = MARBLE_BLUE_32; break;
        case 1: button73.BackgroundImage = Properties.Resources.marble_green_32; button73.Tag = MARBLE_GREEN_32; break;
        case 2: button73.BackgroundImage = Properties.Resources.marble_red_32; button73.Tag = MARBLE_RED_32; break;
        case 3: button73.BackgroundImage = Properties.Resources.marble_yellow_32; button73.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button74.BackgroundImage = Properties.Resources.marble_blue_32; button74.Tag = MARBLE_BLUE_32; break;
        case 1: button74.BackgroundImage = Properties.Resources.marble_green_32; button74.Tag = MARBLE_GREEN_32; break;
        case 2: button74.BackgroundImage = Properties.Resources.marble_red_32; button74.Tag = MARBLE_RED_32; break;
        case 3: button74.BackgroundImage = Properties.Resources.marble_yellow_32; button74.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button75.BackgroundImage = Properties.Resources.marble_blue_32; button75.Tag = MARBLE_BLUE_32; break;
        case 1: button75.BackgroundImage = Properties.Resources.marble_green_32; button75.Tag = MARBLE_GREEN_32; break;
        case 2: button75.BackgroundImage = Properties.Resources.marble_red_32; button75.Tag = MARBLE_RED_32; break;
        case 3: button75.BackgroundImage = Properties.Resources.marble_yellow_32; button75.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button76.BackgroundImage = Properties.Resources.marble_blue_32; button76.Tag = MARBLE_BLUE_32; break;
        case 1: button76.BackgroundImage = Properties.Resources.marble_green_32; button76.Tag = MARBLE_GREEN_32; break;
        case 2: button76.BackgroundImage = Properties.Resources.marble_red_32; button76.Tag = MARBLE_RED_32; break;
        case 3: button76.BackgroundImage = Properties.Resources.marble_yellow_32; button76.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button77.BackgroundImage = Properties.Resources.marble_blue_32; button77.Tag = MARBLE_BLUE_32; break;
        case 1: button77.BackgroundImage = Properties.Resources.marble_green_32; button77.Tag = MARBLE_GREEN_32; break;
        case 2: button77.BackgroundImage = Properties.Resources.marble_red_32; button77.Tag = MARBLE_RED_32; break;
        case 3: button77.BackgroundImage = Properties.Resources.marble_yellow_32; button77.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button78.BackgroundImage = Properties.Resources.marble_blue_32; button78.Tag = MARBLE_BLUE_32; break;
        case 1: button78.BackgroundImage = Properties.Resources.marble_green_32; button78.Tag = MARBLE_GREEN_32; break;
        case 2: button78.BackgroundImage = Properties.Resources.marble_red_32; button78.Tag = MARBLE_RED_32; break;
        case 3: button78.BackgroundImage = Properties.Resources.marble_yellow_32; button78.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button79.BackgroundImage = Properties.Resources.marble_blue_32; button79.Tag = MARBLE_BLUE_32; break;
        case 1: button79.BackgroundImage = Properties.Resources.marble_green_32; button79.Tag = MARBLE_GREEN_32; break;
        case 2: button79.BackgroundImage = Properties.Resources.marble_red_32; button79.Tag = MARBLE_RED_32; break;
        case 3: button79.BackgroundImage = Properties.Resources.marble_yellow_32; button79.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button80.BackgroundImage = Properties.Resources.marble_blue_32; button80.Tag = MARBLE_BLUE_32; break;
        case 1: button80.BackgroundImage = Properties.Resources.marble_green_32; button80.Tag = MARBLE_GREEN_32; break;
        case 2: button80.BackgroundImage = Properties.Resources.marble_red_32; button80.Tag = MARBLE_RED_32; break;
        case 3: button80.BackgroundImage = Properties.Resources.marble_yellow_32; button80.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button81.BackgroundImage = Properties.Resources.marble_blue_32; button81.Tag = MARBLE_BLUE_32; break;
        case 1: button81.BackgroundImage = Properties.Resources.marble_green_32; button81.Tag = MARBLE_GREEN_32; break;
        case 2: button81.BackgroundImage = Properties.Resources.marble_red_32; button81.Tag = MARBLE_RED_32; break;
        case 3: button81.BackgroundImage = Properties.Resources.marble_yellow_32; button81.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button82.BackgroundImage = Properties.Resources.marble_blue_32; button82.Tag = MARBLE_BLUE_32; break;
        case 1: button82.BackgroundImage = Properties.Resources.marble_green_32; button82.Tag = MARBLE_GREEN_32; break;
        case 2: button82.BackgroundImage = Properties.Resources.marble_red_32; button82.Tag = MARBLE_RED_32; break;
        case 3: button82.BackgroundImage = Properties.Resources.marble_yellow_32; button82.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button83.BackgroundImage = Properties.Resources.marble_blue_32; button83.Tag = MARBLE_BLUE_32; break;
        case 1: button83.BackgroundImage = Properties.Resources.marble_green_32; button83.Tag = MARBLE_GREEN_32; break;
        case 2: button83.BackgroundImage = Properties.Resources.marble_red_32; button83.Tag = MARBLE_RED_32; break;
        case 3: button83.BackgroundImage = Properties.Resources.marble_yellow_32; button83.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button84.BackgroundImage = Properties.Resources.marble_blue_32; button84.Tag = MARBLE_BLUE_32; break;
        case 1: button84.BackgroundImage = Properties.Resources.marble_green_32; button84.Tag = MARBLE_GREEN_32; break;
        case 2: button84.BackgroundImage = Properties.Resources.marble_red_32; button84.Tag = MARBLE_RED_32; break;
        case 3: button84.BackgroundImage = Properties.Resources.marble_yellow_32; button84.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button85.BackgroundImage = Properties.Resources.marble_blue_32; button85.Tag = MARBLE_BLUE_32; break;
        case 1: button85.BackgroundImage = Properties.Resources.marble_green_32; button85.Tag = MARBLE_GREEN_32; break;
        case 2: button85.BackgroundImage = Properties.Resources.marble_red_32; button85.Tag = MARBLE_RED_32; break;
        case 3: button85.BackgroundImage = Properties.Resources.marble_yellow_32; button85.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button86.BackgroundImage = Properties.Resources.marble_blue_32; button86.Tag = MARBLE_BLUE_32; break;
        case 1: button86.BackgroundImage = Properties.Resources.marble_green_32; button86.Tag = MARBLE_GREEN_32; break;
        case 2: button86.BackgroundImage = Properties.Resources.marble_red_32; button86.Tag = MARBLE_RED_32; break;
        case 3: button86.BackgroundImage = Properties.Resources.marble_yellow_32; button86.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button87.BackgroundImage = Properties.Resources.marble_blue_32; button87.Tag = MARBLE_BLUE_32; break;
        case 1: button87.BackgroundImage = Properties.Resources.marble_green_32; button87.Tag = MARBLE_GREEN_32; break;
        case 2: button87.BackgroundImage = Properties.Resources.marble_red_32; button87.Tag = MARBLE_RED_32; break;
        case 3: button87.BackgroundImage = Properties.Resources.marble_yellow_32; button87.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button88.BackgroundImage = Properties.Resources.marble_blue_32; button88.Tag = MARBLE_BLUE_32; break;
        case 1: button88.BackgroundImage = Properties.Resources.marble_green_32; button88.Tag = MARBLE_GREEN_32; break;
        case 2: button88.BackgroundImage = Properties.Resources.marble_red_32; button88.Tag = MARBLE_RED_32; break;
        case 3: button88.BackgroundImage = Properties.Resources.marble_yellow_32; button88.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button89.BackgroundImage = Properties.Resources.marble_blue_32; button89.Tag = MARBLE_BLUE_32; break;
        case 1: button89.BackgroundImage = Properties.Resources.marble_green_32; button89.Tag = MARBLE_GREEN_32; break;
        case 2: button89.BackgroundImage = Properties.Resources.marble_red_32; button89.Tag = MARBLE_RED_32; break;
        case 3: button89.BackgroundImage = Properties.Resources.marble_yellow_32; button89.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button90.BackgroundImage = Properties.Resources.marble_blue_32; button90.Tag = MARBLE_BLUE_32; break;
        case 1: button90.BackgroundImage = Properties.Resources.marble_green_32; button90.Tag = MARBLE_GREEN_32; break;
        case 2: button90.BackgroundImage = Properties.Resources.marble_red_32; button90.Tag = MARBLE_RED_32; break;
        case 3: button90.BackgroundImage = Properties.Resources.marble_yellow_32; button90.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button91.BackgroundImage = Properties.Resources.marble_blue_32; button91.Tag = MARBLE_BLUE_32; break;
        case 1: button91.BackgroundImage = Properties.Resources.marble_green_32; button91.Tag = MARBLE_GREEN_32; break;
        case 2: button91.BackgroundImage = Properties.Resources.marble_red_32; button91.Tag = MARBLE_RED_32; break;
        case 3: button91.BackgroundImage = Properties.Resources.marble_yellow_32; button91.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button92.BackgroundImage = Properties.Resources.marble_blue_32; button92.Tag = MARBLE_BLUE_32; break;
        case 1: button92.BackgroundImage = Properties.Resources.marble_green_32; button92.Tag = MARBLE_GREEN_32; break;
        case 2: button92.BackgroundImage = Properties.Resources.marble_red_32; button92.Tag = MARBLE_RED_32; break;
        case 3: button92.BackgroundImage = Properties.Resources.marble_yellow_32; button92.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button93.BackgroundImage = Properties.Resources.marble_blue_32; button93.Tag = MARBLE_BLUE_32; break;
        case 1: button93.BackgroundImage = Properties.Resources.marble_green_32; button93.Tag = MARBLE_GREEN_32; break;
        case 2: button93.BackgroundImage = Properties.Resources.marble_red_32; button93.Tag = MARBLE_RED_32; break;
        case 3: button93.BackgroundImage = Properties.Resources.marble_yellow_32; button93.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button94.BackgroundImage = Properties.Resources.marble_blue_32; button94.Tag = MARBLE_BLUE_32; break;
        case 1: button94.BackgroundImage = Properties.Resources.marble_green_32; button94.Tag = MARBLE_GREEN_32; break;
        case 2: button94.BackgroundImage = Properties.Resources.marble_red_32; button94.Tag = MARBLE_RED_32; break;
        case 3: button94.BackgroundImage = Properties.Resources.marble_yellow_32; button94.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button95.BackgroundImage = Properties.Resources.marble_blue_32; button95.Tag = MARBLE_BLUE_32; break;
        case 1: button95.BackgroundImage = Properties.Resources.marble_green_32; button95.Tag = MARBLE_GREEN_32; break;
        case 2: button95.BackgroundImage = Properties.Resources.marble_red_32; button95.Tag = MARBLE_RED_32; break;
        case 3: button95.BackgroundImage = Properties.Resources.marble_yellow_32; button95.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button96.BackgroundImage = Properties.Resources.marble_blue_32; button96.Tag = MARBLE_BLUE_32; break;
        case 1: button96.BackgroundImage = Properties.Resources.marble_green_32; button96.Tag = MARBLE_GREEN_32; break;
        case 2: button96.BackgroundImage = Properties.Resources.marble_red_32; button96.Tag = MARBLE_RED_32; break;
        case 3: button96.BackgroundImage = Properties.Resources.marble_yellow_32; button96.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button97.BackgroundImage = Properties.Resources.marble_blue_32; button97.Tag = MARBLE_BLUE_32; break;
        case 1: button97.BackgroundImage = Properties.Resources.marble_green_32; button97.Tag = MARBLE_GREEN_32; break;
        case 2: button97.BackgroundImage = Properties.Resources.marble_red_32; button97.Tag = MARBLE_RED_32; break;
        case 3: button97.BackgroundImage = Properties.Resources.marble_yellow_32; button97.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button98.BackgroundImage = Properties.Resources.marble_blue_32; button98.Tag = MARBLE_BLUE_32; break;
        case 1: button98.BackgroundImage = Properties.Resources.marble_green_32; button98.Tag = MARBLE_GREEN_32; break;
        case 2: button98.BackgroundImage = Properties.Resources.marble_red_32; button98.Tag = MARBLE_RED_32; break;
        case 3: button98.BackgroundImage = Properties.Resources.marble_yellow_32; button98.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button99.BackgroundImage = Properties.Resources.marble_blue_32; button99.Tag = MARBLE_BLUE_32; break;
        case 1: button99.BackgroundImage = Properties.Resources.marble_green_32; button99.Tag = MARBLE_GREEN_32; break;
        case 2: button99.BackgroundImage = Properties.Resources.marble_red_32; button99.Tag = MARBLE_RED_32; break;
        case 3: button99.BackgroundImage = Properties.Resources.marble_yellow_32; button99.Tag = MARBLE_YELLOW_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button100.BackgroundImage = Properties.Resources.marble_blue_32; button100.Tag = MARBLE_BLUE_32; break;
        case 1: button100.BackgroundImage = Properties.Resources.marble_green_32; button100.Tag = MARBLE_GREEN_32; break;
        case 2: button100.BackgroundImage = Properties.Resources.marble_red_32; button100.Tag = MARBLE_RED_32; break;
        case 3: button100.BackgroundImage = Properties.Resources.marble_yellow_32; button100.Tag = MARBLE_YELLOW_32; break;
      }
    }

    private void playSoundfile(String ResourceName, String path)
    {
      try
      {
        if (File.Exists(path))
        {
          using (var file = new FileStream(path, FileMode.Open, FileAccess.Read))
          {
            var player = new SoundPlayer(new OggDecoder.OggDecodeStream(file));
            player.Play();
          }
        }
        else
        {
          using (var file = Assembly.GetExecutingAssembly().GetManifestResourceStream(ResourceName))
          {
            var player = new SoundPlayer(new OggDecoder.OggDecodeStream(file));
            player.Play();
          }
        }
      }
      catch
      {
        setStatusbarInformationtext(NO_SOUND_FILE_FOUND);
      }
    }

    private void playButtonClick()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + BUTTON_CLICK_OGG_FILENAME, SOUND_DIRECTORY + BUTTON_CLICK_OGG_FILENAME);
    }

    private void playNewLevel()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + NEW_LEVEL_OGG_FILENAME, SOUND_DIRECTORY + NEW_LEVEL_OGG_FILENAME);
    }

    private void playMarbleClick()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + MARBLE_CLICK_OGG_FILENAME, SOUND_DIRECTORY + MARBLE_CLICK_OGG_FILENAME);
    }

    private void playRectangleComplete()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + RECTANGLE_COMPLETE_OGG_FILENAME, SOUND_DIRECTORY + RECTANGLE_COMPLETE_OGG_FILENAME);
    }

    private void playSelectionCancelled()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + SELECTION_CANCELLED_OGG_FILENAME, SOUND_DIRECTORY + SELECTION_CANCELLED_OGG_FILENAME);
    }

    private void playSelectionInvalid()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + SELECTION_INVALID_OGG_FILENAME, SOUND_DIRECTORY + SELECTION_INVALID_OGG_FILENAME);
    }

    private void playGameOver()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + GAME_OVER_OGG_FILENAME, SOUND_DIRECTORY + GAME_OVER_OGG_FILENAME);
    }

    private void playHighscore()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + HIGH_SCORE_OGG_FILENAME, SOUND_DIRECTORY + HIGH_SCORE_OGG_FILENAME);
    }

    private void playPerfectRectangle()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + PERFECT_RECTANGLE_OGG_FILENAME, SOUND_DIRECTORY + PERFECT_RECTANGLE_OGG_FILENAME);
    }

    private void playTimeAlert()
    {
      playSoundfile(DEFAULT_NAMESPACE + DOT + RESOURCES + DOT + TIME_ALERT_OGG_FILENAME, SOUND_DIRECTORY + TIME_ALERT_OGG_FILENAME);
    }

    #endregion

    private void JuzzleForm_Load(object sender, EventArgs e)
    {
    }

    #region Button "Sound"

    private void buttonSound_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled)
      {
        isSoundEnabled = false;
        buttonSound.Image = Properties.Resources.unmute;
        setStatusbarInformationtext(SOUND_OFF);
        if (isSoundEnabled) playButtonClick();
      }
      else if (!isSoundEnabled)
      {
        isSoundEnabled = true;
        buttonSound.Image = Properties.Resources.mute;
        setStatusbarInformationtext(SOUND_ON);
        if (isSoundEnabled) playButtonClick();
      }
    }

    private void buttonSound_Enter(object sender, EventArgs e)
    {
      this.buttonSound.BackgroundImage = Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonSound.AccessibleDescription);
    }

    private void buttonSound_MouseEnter(object sender, EventArgs e)
    {
      this.buttonSound.BackgroundImage = Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonSound.AccessibleDescription);
    }

    private void buttonSound_Leave(object sender, EventArgs e)
    {
      this.buttonSound.BackgroundImage = Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonSound_MouseLeave(object sender, EventArgs e)
    {
      this.buttonSound.BackgroundImage = Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonSound_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonSound.BackgroundImage = Properties.Resources.btn_small_clicked;
    }

    private void buttonSound_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonSound.BackgroundImage = Properties.Resources.btn_small_hover;
    }

    #endregion

    #region Button "High Score"

    private void buttonHighscore_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled) playButtonClick();
      //Show high score here
    }

    private void buttonHighscore_Enter(object sender, EventArgs e)
    {
      this.buttonHighscore.BackgroundImage = Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonHighscore.AccessibleDescription);
    }

    private void buttonHighscore_MouseEnter(object sender, EventArgs e)
    {
      this.buttonHighscore.BackgroundImage = Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonHighscore.AccessibleDescription);
    }

    private void buttonHighscore_Leave(object sender, EventArgs e)
    {
      this.buttonHighscore.BackgroundImage = Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonHighscore_MouseLeave(object sender, EventArgs e)
    {
      this.buttonHighscore.BackgroundImage = Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonHighscore_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonHighscore.BackgroundImage = Properties.Resources.btn_small_clicked;
    }

    private void buttonHighscore_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonHighscore.BackgroundImage = Properties.Resources.btn_small_hover;
    }

    #endregion

    #region Button "Information"

    private void buttonInformation_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled) playButtonClick();
      //Show inforamtion here
    }

    private void buttonInformation_Enter(object sender, EventArgs e)
    {
      this.buttonInformation.BackgroundImage = Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonInformation.AccessibleDescription);
    }

    private void buttonInformation_MouseEnter(object sender, EventArgs e)
    {
      this.buttonInformation.BackgroundImage = Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonInformation.AccessibleDescription);
    }

    private void buttonInformation_Leave(object sender, EventArgs e)
    {
      this.buttonInformation.BackgroundImage = Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonInformation_MouseLeave(object sender, EventArgs e)
    {
      this.buttonInformation.BackgroundImage = Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonInformation_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonInformation.BackgroundImage = Properties.Resources.btn_small_clicked;
    }

    private void buttonInformation_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonInformation.BackgroundImage = Properties.Resources.btn_small_hover;
    }

    #endregion

    #region Button "Pause"

    private void buttonPause_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled) playButtonClick();
      if (isGamePaused)
      {
        isGamePaused = false;
        buttonPause.Text = "&Pause";
        this.buttonStart.BackgroundImage = Properties.Resources.btn_large_normal;
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
          case MARBLE_BLUE_32: button1.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button1.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button1.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button1.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button1.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button1.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button1.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button1.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button2.Tag.ToString())
        {
          case MARBLE_BLUE_32: button2.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button2.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button2.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button2.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button2.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button2.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button2.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button2.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button3.Tag.ToString())
        {
          case MARBLE_BLUE_32: button3.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button3.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button3.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button3.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button3.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button3.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button3.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button3.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button4.Tag.ToString())
        {
          case MARBLE_BLUE_32: button4.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button4.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button4.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button4.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button4.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button4.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button4.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button4.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button5.Tag.ToString())
        {
          case MARBLE_BLUE_32: button5.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button5.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button5.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button5.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button5.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button5.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button5.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button5.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button6.Tag.ToString())
        {
          case MARBLE_BLUE_32: button6.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button6.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button6.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button6.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button6.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button6.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button6.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button6.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button7.Tag.ToString())
        {
          case MARBLE_BLUE_32: button7.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button7.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button7.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button7.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button7.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button7.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button7.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button7.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button8.Tag.ToString())
        {
          case MARBLE_BLUE_32: button8.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button8.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button8.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button8.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button8.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button8.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button8.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button8.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button9.Tag.ToString())
        {
          case MARBLE_BLUE_32: button9.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button9.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button9.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button9.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button9.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button9.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button9.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button9.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button10.Tag.ToString())
        {
          case MARBLE_BLUE_32: button10.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button10.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button10.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button10.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button10.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button10.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button10.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button10.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button11.Tag.ToString())
        {
          case MARBLE_BLUE_32: button11.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button11.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button11.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button11.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button11.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button11.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button11.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button11.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button12.Tag.ToString())
        {
          case MARBLE_BLUE_32: button12.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button12.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button12.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button12.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button12.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button12.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button12.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button12.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button13.Tag.ToString())
        {
          case MARBLE_BLUE_32: button13.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button13.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button13.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button13.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button13.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button13.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button13.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button13.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button14.Tag.ToString())
        {
          case MARBLE_BLUE_32: button14.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button14.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button14.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button14.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button14.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button14.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button14.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button14.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button15.Tag.ToString())
        {
          case MARBLE_BLUE_32: button15.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button15.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button15.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button15.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button15.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button15.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button15.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button15.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button16.Tag.ToString())
        {
          case MARBLE_BLUE_32: button16.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button16.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button16.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button16.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button16.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button16.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button16.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button16.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button17.Tag.ToString())
        {
          case MARBLE_BLUE_32: button17.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button17.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button17.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button17.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button17.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button17.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button17.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button17.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button18.Tag.ToString())
        {
          case MARBLE_BLUE_32: button18.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button18.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button18.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button18.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button18.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button18.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button18.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button18.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button19.Tag.ToString())
        {
          case MARBLE_BLUE_32: button19.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button19.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button19.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button19.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button19.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button19.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button19.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button19.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button20.Tag.ToString())
        {
          case MARBLE_BLUE_32: button20.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button20.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button20.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button20.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button20.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button20.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button20.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button20.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button21.Tag.ToString())
        {
          case MARBLE_BLUE_32: button21.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button21.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button21.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button21.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button21.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button21.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button21.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button21.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button22.Tag.ToString())
        {
          case MARBLE_BLUE_32: button22.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button22.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button22.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button22.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button22.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button22.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button22.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button22.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button23.Tag.ToString())
        {
          case MARBLE_BLUE_32: button23.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button23.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button23.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button23.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button23.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button23.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button23.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button23.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button24.Tag.ToString())
        {
          case MARBLE_BLUE_32: button24.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button24.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button24.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button24.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button24.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button24.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button24.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button24.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button25.Tag.ToString())
        {
          case MARBLE_BLUE_32: button25.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button25.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button25.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button25.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button25.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button25.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button25.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button25.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button26.Tag.ToString())
        {
          case MARBLE_BLUE_32: button26.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button26.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button26.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button26.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button26.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button26.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button26.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button26.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button27.Tag.ToString())
        {
          case MARBLE_BLUE_32: button27.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button27.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button27.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button27.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button27.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button27.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button27.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button27.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button28.Tag.ToString())
        {
          case MARBLE_BLUE_32: button28.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button28.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button28.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button28.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button28.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button28.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button28.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button28.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button29.Tag.ToString())
        {
          case MARBLE_BLUE_32: button29.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button29.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button29.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button29.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button29.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button29.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button29.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button29.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button30.Tag.ToString())
        {
          case MARBLE_BLUE_32: button30.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button30.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button30.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button30.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button30.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button30.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button30.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button30.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button31.Tag.ToString())
        {
          case MARBLE_BLUE_32: button31.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button31.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button31.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button31.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button31.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button31.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button31.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button31.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button32.Tag.ToString())
        {
          case MARBLE_BLUE_32: button32.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button32.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button32.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button32.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button32.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button32.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button32.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button32.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button33.Tag.ToString())
        {
          case MARBLE_BLUE_32: button33.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button33.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button33.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button33.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button33.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button33.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button33.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button33.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button34.Tag.ToString())
        {
          case MARBLE_BLUE_32: button34.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button34.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button34.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button34.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button34.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button34.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button34.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button34.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button35.Tag.ToString())
        {
          case MARBLE_BLUE_32: button35.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button35.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button35.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button35.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button35.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button35.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button35.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button35.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button36.Tag.ToString())
        {
          case MARBLE_BLUE_32: button36.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button36.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button36.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button36.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button36.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button36.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button36.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button36.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button37.Tag.ToString())
        {
          case MARBLE_BLUE_32: button37.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button37.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button37.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button37.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button37.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button37.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button37.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button37.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button38.Tag.ToString())
        {
          case MARBLE_BLUE_32: button38.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button38.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button38.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button38.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button38.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button38.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button38.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button38.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button39.Tag.ToString())
        {
          case MARBLE_BLUE_32: button39.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button39.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button39.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button39.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button39.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button39.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button39.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button39.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button40.Tag.ToString())
        {
          case MARBLE_BLUE_32: button40.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button40.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button40.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button40.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button40.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button40.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button40.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button40.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button41.Tag.ToString())
        {
          case MARBLE_BLUE_32: button41.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button41.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button41.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button41.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button41.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button41.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button41.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button41.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button42.Tag.ToString())
        {
          case MARBLE_BLUE_32: button42.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button42.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button42.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button42.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button42.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button42.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button42.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button42.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button43.Tag.ToString())
        {
          case MARBLE_BLUE_32: button43.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button43.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button43.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button43.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button43.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button43.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button43.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button43.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button44.Tag.ToString())
        {
          case MARBLE_BLUE_32: button44.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button44.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button44.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button44.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button44.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button44.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button44.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button44.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button45.Tag.ToString())
        {
          case MARBLE_BLUE_32: button45.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button45.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button45.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button45.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button45.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button45.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button45.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button45.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button46.Tag.ToString())
        {
          case MARBLE_BLUE_32: button46.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button46.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button46.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button46.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button46.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button46.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button46.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button46.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button47.Tag.ToString())
        {
          case MARBLE_BLUE_32: button47.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button47.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button47.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button47.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button47.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button47.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button47.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button47.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button48.Tag.ToString())
        {
          case MARBLE_BLUE_32: button48.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button48.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button48.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button48.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button48.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button48.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button48.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button48.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button49.Tag.ToString())
        {
          case MARBLE_BLUE_32: button49.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button49.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button49.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button49.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button49.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button49.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button49.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button49.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button50.Tag.ToString())
        {
          case MARBLE_BLUE_32: button50.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button50.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button50.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button50.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button50.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button50.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button50.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button50.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button51.Tag.ToString())
        {
          case MARBLE_BLUE_32: button51.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button51.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button51.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button51.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button51.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button51.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button51.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button51.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button52.Tag.ToString())
        {
          case MARBLE_BLUE_32: button52.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button52.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button52.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button52.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button52.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button52.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button52.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button52.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button53.Tag.ToString())
        {
          case MARBLE_BLUE_32: button53.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button53.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button53.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button53.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button53.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button53.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button53.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button53.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button54.Tag.ToString())
        {
          case MARBLE_BLUE_32: button54.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button54.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button54.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button54.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button54.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button54.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button54.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button54.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button55.Tag.ToString())
        {
          case MARBLE_BLUE_32: button55.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button55.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button55.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button55.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button55.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button55.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button55.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button55.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button56.Tag.ToString())
        {
          case MARBLE_BLUE_32: button56.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button56.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button56.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button56.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button56.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button56.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button56.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button56.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button57.Tag.ToString())
        {
          case MARBLE_BLUE_32: button57.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button57.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button57.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button57.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button57.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button57.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button57.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button57.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button58.Tag.ToString())
        {
          case MARBLE_BLUE_32: button58.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button58.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button58.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button58.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button58.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button58.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button58.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button58.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button59.Tag.ToString())
        {
          case MARBLE_BLUE_32: button59.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button59.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button59.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button59.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button59.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button59.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button59.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button59.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button60.Tag.ToString())
        {
          case MARBLE_BLUE_32: button60.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button60.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button60.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button60.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button60.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button60.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button60.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button60.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button61.Tag.ToString())
        {
          case MARBLE_BLUE_32: button61.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button61.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button61.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button61.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button61.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button61.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button61.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button61.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button62.Tag.ToString())
        {
          case MARBLE_BLUE_32: button62.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button62.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button62.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button62.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button62.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button62.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button62.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button62.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button63.Tag.ToString())
        {
          case MARBLE_BLUE_32: button63.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button63.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button63.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button63.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button63.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button63.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button63.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button63.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button64.Tag.ToString())
        {
          case MARBLE_BLUE_32: button64.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button64.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button64.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button64.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button64.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button64.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button64.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button64.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button65.Tag.ToString())
        {
          case MARBLE_BLUE_32: button65.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button65.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button65.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button65.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button65.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button65.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button65.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button65.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button66.Tag.ToString())
        {
          case MARBLE_BLUE_32: button66.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button66.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button66.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button66.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button66.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button66.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button66.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button66.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button67.Tag.ToString())
        {
          case MARBLE_BLUE_32: button67.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button67.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button67.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button67.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button67.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button67.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button67.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button67.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button68.Tag.ToString())
        {
          case MARBLE_BLUE_32: button68.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button68.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button68.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button68.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button68.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button68.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button68.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button68.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button69.Tag.ToString())
        {
          case MARBLE_BLUE_32: button69.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button69.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button69.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button69.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button69.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button69.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button69.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button69.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button70.Tag.ToString())
        {
          case MARBLE_BLUE_32: button70.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button70.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button70.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button70.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button70.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button70.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button70.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button70.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button71.Tag.ToString())
        {
          case MARBLE_BLUE_32: button71.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button71.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button71.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button71.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button71.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button71.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button71.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button71.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button72.Tag.ToString())
        {
          case MARBLE_BLUE_32: button72.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button72.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button72.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button72.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button72.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button72.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button72.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button72.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button73.Tag.ToString())
        {
          case MARBLE_BLUE_32: button73.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button73.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button73.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button73.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button73.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button73.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button73.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button73.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button74.Tag.ToString())
        {
          case MARBLE_BLUE_32: button74.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button74.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button74.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button74.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button74.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button74.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button74.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button74.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button75.Tag.ToString())
        {
          case MARBLE_BLUE_32: button75.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button75.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button75.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button75.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button75.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button75.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button75.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button75.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button76.Tag.ToString())
        {
          case MARBLE_BLUE_32: button76.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button76.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button76.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button76.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button76.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button76.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button76.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button76.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button77.Tag.ToString())
        {
          case MARBLE_BLUE_32: button77.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button77.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button77.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button77.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button77.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button77.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button77.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button77.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button78.Tag.ToString())
        {
          case MARBLE_BLUE_32: button78.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button78.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button78.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button78.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button78.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button78.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button78.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button78.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button79.Tag.ToString())
        {
          case MARBLE_BLUE_32: button79.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button79.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button79.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button79.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button79.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button79.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button79.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button79.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button80.Tag.ToString())
        {
          case MARBLE_BLUE_32: button80.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button80.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button80.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button80.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button80.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button80.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button80.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button80.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button81.Tag.ToString())
        {
          case MARBLE_BLUE_32: button81.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button81.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button81.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button81.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button81.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button81.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button81.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button81.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button82.Tag.ToString())
        {
          case MARBLE_BLUE_32: button82.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button82.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button82.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button82.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button82.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button82.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button82.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button82.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button83.Tag.ToString())
        {
          case MARBLE_BLUE_32: button83.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button83.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button83.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button83.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button83.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button83.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button83.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button83.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button84.Tag.ToString())
        {
          case MARBLE_BLUE_32: button84.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button84.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button84.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button84.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button84.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button84.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button84.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button84.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button85.Tag.ToString())
        {
          case MARBLE_BLUE_32: button85.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button85.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button85.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button85.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button85.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button85.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button85.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button85.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button86.Tag.ToString())
        {
          case MARBLE_BLUE_32: button86.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button86.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button86.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button86.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button86.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button86.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button86.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button86.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button87.Tag.ToString())
        {
          case MARBLE_BLUE_32: button87.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button87.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button87.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button87.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button87.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button87.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button87.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button87.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button88.Tag.ToString())
        {
          case MARBLE_BLUE_32: button88.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button88.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button88.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button88.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button88.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button88.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button88.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button88.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button89.Tag.ToString())
        {
          case MARBLE_BLUE_32: button89.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button89.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button89.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button89.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button89.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button89.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button89.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button89.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button90.Tag.ToString())
        {
          case MARBLE_BLUE_32: button90.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button90.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button90.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button90.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button90.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button90.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button90.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button90.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button91.Tag.ToString())
        {
          case MARBLE_BLUE_32: button91.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button91.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button91.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button91.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button91.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button91.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button91.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button91.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button92.Tag.ToString())
        {
          case MARBLE_BLUE_32: button92.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button92.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button92.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button92.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button92.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button92.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button92.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button92.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button93.Tag.ToString())
        {
          case MARBLE_BLUE_32: button93.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button93.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button93.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button93.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button93.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button93.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button93.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button93.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button94.Tag.ToString())
        {
          case MARBLE_BLUE_32: button94.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button94.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button94.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button94.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button94.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button94.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button94.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button94.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button95.Tag.ToString())
        {
          case MARBLE_BLUE_32: button95.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button95.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button95.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button95.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button95.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button95.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button95.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button95.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button96.Tag.ToString())
        {
          case MARBLE_BLUE_32: button96.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button96.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button96.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button96.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button96.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button96.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button96.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button96.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button97.Tag.ToString())
        {
          case MARBLE_BLUE_32: button97.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button97.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button97.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button97.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button97.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button97.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button97.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button97.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button98.Tag.ToString())
        {
          case MARBLE_BLUE_32: button98.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button98.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button98.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button98.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button98.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button98.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button98.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button98.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button99.Tag.ToString())
        {
          case MARBLE_BLUE_32: button99.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button99.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button99.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button99.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button99.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button99.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button99.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button99.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }
        switch (button100.Tag.ToString())
        {
          case MARBLE_BLUE_32: button100.BackgroundImage = Properties.Resources.marble_blue_32; break;
          case MARBLE_GREEN_32: button100.BackgroundImage = Properties.Resources.marble_green_32; break;
          case MARBLE_RED_32: button100.BackgroundImage = Properties.Resources.marble_red_32; break;
          case MARBLE_YELLOW_32: button100.BackgroundImage = Properties.Resources.marble_yellow_32; break;
          case MARBLE_BLUE_32_S: button100.BackgroundImage = Properties.Resources.marble_blue_32_s; break;
          case MARBLE_GREEN_32_S: button100.BackgroundImage = Properties.Resources.marble_green_32_s; break;
          case MARBLE_RED_32_S: button100.BackgroundImage = Properties.Resources.marble_red_32_s; break;
          case MARBLE_YELLOW_32_S: button100.BackgroundImage = Properties.Resources.marble_yellow_32_s; break;
        }






      }
      else if (!isGamePaused)
      {
        isGamePaused = true;
        buttonPause.Text = "&Resume";
        this.buttonStart.BackgroundImage = Properties.Resources.btn_large_disabled;
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
        button1.BackgroundImage = Properties.Resources.marble_grey_32;
        button2.BackgroundImage = Properties.Resources.marble_grey_32;
        button3.BackgroundImage = Properties.Resources.marble_grey_32;
        button4.BackgroundImage = Properties.Resources.marble_grey_32;
        button5.BackgroundImage = Properties.Resources.marble_grey_32;
        button6.BackgroundImage = Properties.Resources.marble_grey_32;
        button7.BackgroundImage = Properties.Resources.marble_grey_32;
        button8.BackgroundImage = Properties.Resources.marble_grey_32;
        button9.BackgroundImage = Properties.Resources.marble_grey_32;
        button10.BackgroundImage = Properties.Resources.marble_grey_32;
        button11.BackgroundImage = Properties.Resources.marble_grey_32;
        button12.BackgroundImage = Properties.Resources.marble_grey_32;
        button13.BackgroundImage = Properties.Resources.marble_grey_32;
        button14.BackgroundImage = Properties.Resources.marble_grey_32;
        button15.BackgroundImage = Properties.Resources.marble_grey_32;
        button16.BackgroundImage = Properties.Resources.marble_grey_32;
        button17.BackgroundImage = Properties.Resources.marble_grey_32;
        button18.BackgroundImage = Properties.Resources.marble_grey_32;
        button19.BackgroundImage = Properties.Resources.marble_grey_32;
        button20.BackgroundImage = Properties.Resources.marble_grey_32;
        button21.BackgroundImage = Properties.Resources.marble_grey_32;
        button22.BackgroundImage = Properties.Resources.marble_grey_32;
        button23.BackgroundImage = Properties.Resources.marble_grey_32;
        button24.BackgroundImage = Properties.Resources.marble_grey_32;
        button25.BackgroundImage = Properties.Resources.marble_grey_32;
        button26.BackgroundImage = Properties.Resources.marble_grey_32;
        button27.BackgroundImage = Properties.Resources.marble_grey_32;
        button28.BackgroundImage = Properties.Resources.marble_grey_32;
        button29.BackgroundImage = Properties.Resources.marble_grey_32;
        button30.BackgroundImage = Properties.Resources.marble_grey_32;
        button31.BackgroundImage = Properties.Resources.marble_grey_32;
        button32.BackgroundImage = Properties.Resources.marble_grey_32;
        button33.BackgroundImage = Properties.Resources.marble_grey_32;
        button34.BackgroundImage = Properties.Resources.marble_grey_32;
        button35.BackgroundImage = Properties.Resources.marble_grey_32;
        button36.BackgroundImage = Properties.Resources.marble_grey_32;
        button37.BackgroundImage = Properties.Resources.marble_grey_32;
        button38.BackgroundImage = Properties.Resources.marble_grey_32;
        button39.BackgroundImage = Properties.Resources.marble_grey_32;
        button40.BackgroundImage = Properties.Resources.marble_grey_32;
        button41.BackgroundImage = Properties.Resources.marble_grey_32;
        button42.BackgroundImage = Properties.Resources.marble_grey_32;
        button43.BackgroundImage = Properties.Resources.marble_grey_32;
        button44.BackgroundImage = Properties.Resources.marble_grey_32;
        button45.BackgroundImage = Properties.Resources.marble_grey_32;
        button46.BackgroundImage = Properties.Resources.marble_grey_32;
        button47.BackgroundImage = Properties.Resources.marble_grey_32;
        button48.BackgroundImage = Properties.Resources.marble_grey_32;
        button49.BackgroundImage = Properties.Resources.marble_grey_32;
        button50.BackgroundImage = Properties.Resources.marble_grey_32;
        button51.BackgroundImage = Properties.Resources.marble_grey_32;
        button52.BackgroundImage = Properties.Resources.marble_grey_32;
        button53.BackgroundImage = Properties.Resources.marble_grey_32;
        button54.BackgroundImage = Properties.Resources.marble_grey_32;
        button55.BackgroundImage = Properties.Resources.marble_grey_32;
        button56.BackgroundImage = Properties.Resources.marble_grey_32;
        button57.BackgroundImage = Properties.Resources.marble_grey_32;
        button58.BackgroundImage = Properties.Resources.marble_grey_32;
        button59.BackgroundImage = Properties.Resources.marble_grey_32;
        button60.BackgroundImage = Properties.Resources.marble_grey_32;
        button61.BackgroundImage = Properties.Resources.marble_grey_32;
        button62.BackgroundImage = Properties.Resources.marble_grey_32;
        button63.BackgroundImage = Properties.Resources.marble_grey_32;
        button64.BackgroundImage = Properties.Resources.marble_grey_32;
        button65.BackgroundImage = Properties.Resources.marble_grey_32;
        button66.BackgroundImage = Properties.Resources.marble_grey_32;
        button67.BackgroundImage = Properties.Resources.marble_grey_32;
        button68.BackgroundImage = Properties.Resources.marble_grey_32;
        button69.BackgroundImage = Properties.Resources.marble_grey_32;
        button70.BackgroundImage = Properties.Resources.marble_grey_32;
        button71.BackgroundImage = Properties.Resources.marble_grey_32;
        button72.BackgroundImage = Properties.Resources.marble_grey_32;
        button73.BackgroundImage = Properties.Resources.marble_grey_32;
        button74.BackgroundImage = Properties.Resources.marble_grey_32;
        button75.BackgroundImage = Properties.Resources.marble_grey_32;
        button76.BackgroundImage = Properties.Resources.marble_grey_32;
        button77.BackgroundImage = Properties.Resources.marble_grey_32;
        button78.BackgroundImage = Properties.Resources.marble_grey_32;
        button79.BackgroundImage = Properties.Resources.marble_grey_32;
        button80.BackgroundImage = Properties.Resources.marble_grey_32;
        button81.BackgroundImage = Properties.Resources.marble_grey_32;
        button82.BackgroundImage = Properties.Resources.marble_grey_32;
        button83.BackgroundImage = Properties.Resources.marble_grey_32;
        button84.BackgroundImage = Properties.Resources.marble_grey_32;
        button85.BackgroundImage = Properties.Resources.marble_grey_32;
        button86.BackgroundImage = Properties.Resources.marble_grey_32;
        button87.BackgroundImage = Properties.Resources.marble_grey_32;
        button88.BackgroundImage = Properties.Resources.marble_grey_32;
        button89.BackgroundImage = Properties.Resources.marble_grey_32;
        button90.BackgroundImage = Properties.Resources.marble_grey_32;
        button91.BackgroundImage = Properties.Resources.marble_grey_32;
        button92.BackgroundImage = Properties.Resources.marble_grey_32;
        button93.BackgroundImage = Properties.Resources.marble_grey_32;
        button94.BackgroundImage = Properties.Resources.marble_grey_32;
        button95.BackgroundImage = Properties.Resources.marble_grey_32;
        button96.BackgroundImage = Properties.Resources.marble_grey_32;
        button97.BackgroundImage = Properties.Resources.marble_grey_32;
        button98.BackgroundImage = Properties.Resources.marble_grey_32;
        button99.BackgroundImage = Properties.Resources.marble_grey_32;
        button100.BackgroundImage = Properties.Resources.marble_grey_32;
      }
    }

    private void buttonPause_Enter(object sender, EventArgs e)
    {
      this.buttonPause.BackgroundImage = Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonPause.AccessibleDescription);
    }

    private void buttonPause_MouseEnter(object sender, EventArgs e)
    {
      this.buttonPause.BackgroundImage = Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonPause.AccessibleDescription);
    }

    private void buttonPause_Leave(object sender, EventArgs e)
    {
      this.buttonPause.BackgroundImage = Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonPause_MouseLeave(object sender, EventArgs e)
    {
      this.buttonPause.BackgroundImage = Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonPause_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonPause.BackgroundImage = Properties.Resources.btn_large_clicked;
    }

    private void buttonPause_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonPause.BackgroundImage = Properties.Resources.btn_large_hover;
    }

    #endregion

    #region Button "Start"

    private void buttonStart_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled) playButtonClick();
      setGamefield();
    }

    private void buttonStart_Enter(object sender, EventArgs e)
    {
      this.buttonStart.BackgroundImage = Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonStart.AccessibleDescription);
    }

    private void buttonStart_MouseEnter(object sender, EventArgs e)
    {
      this.buttonStart.BackgroundImage = Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonStart.AccessibleDescription);
    }

    private void buttonStart_Leave(object sender, EventArgs e)
    {
      this.buttonStart.BackgroundImage = Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonStart_MouseLeave(object sender, EventArgs e)
    {
      this.buttonStart.BackgroundImage = Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonStart_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonStart.BackgroundImage = Properties.Resources.btn_large_clicked;
    }

    private void buttonStart_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonStart.BackgroundImage = Properties.Resources.btn_large_hover;
    }
  
    #endregion

    #region Button "Quit"

    private void buttonQuit_Click(object sender, EventArgs e)
    {
      if (isSoundEnabled) playButtonClick();
      this.Close();
    }

    private void buttonQuit_Enter(object sender, EventArgs e)
    {
      this.buttonQuit.BackgroundImage = Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonQuit.AccessibleDescription);
    }

    private void buttonQuit_MouseEnter(object sender, EventArgs e)
    {
      this.buttonQuit.BackgroundImage = Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonQuit.AccessibleDescription);
    }

    private void buttonQuit_Leave(object sender, EventArgs e)
    {
      this.buttonQuit.BackgroundImage = Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonQuit_MouseLeave(object sender, EventArgs e)
    {
      this.buttonQuit.BackgroundImage = Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonQuit_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonQuit.BackgroundImage = Properties.Resources.btn_large_clicked;
    }

    private void buttonQuit_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonQuit.BackgroundImage = Properties.Resources.btn_large_hover;
    }


    #endregion

    private void button1_Click(object sender, EventArgs e)
    {
      switch (button1.Tag.ToString())
      {
        case MARBLE_BLUE_32: button1.BackgroundImage = Properties.Resources.marble_blue_32_s; button1.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button1.BackgroundImage = Properties.Resources.marble_blue_32; button1.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button1.BackgroundImage = Properties.Resources.marble_green_32_s; button1.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button1.BackgroundImage = Properties.Resources.marble_green_32; button1.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button1.BackgroundImage = Properties.Resources.marble_red_32_s; button1.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button1.BackgroundImage = Properties.Resources.marble_red_32; button1.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button1.BackgroundImage = Properties.Resources.marble_yellow_32_s; button1.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button1.BackgroundImage = Properties.Resources.marble_yellow_32; button1.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button1_Enter(sender, e);
    }

    private void button1_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button1.AccessibleName + COLON + SPACE;
      switch (button1.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button1_MouseEnter(object sender, EventArgs e)
    {
      button1_Enter(sender, e);
    }

    private void button1_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button1_MouseLeave(object sender, EventArgs e)
    {
      button1_Leave(sender, e);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      switch (button2.Tag.ToString())
      {
        case MARBLE_BLUE_32: button2.BackgroundImage = Properties.Resources.marble_blue_32_s; button2.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button2.BackgroundImage = Properties.Resources.marble_blue_32; button2.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button2.BackgroundImage = Properties.Resources.marble_green_32_s; button2.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button2.BackgroundImage = Properties.Resources.marble_green_32; button2.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button2.BackgroundImage = Properties.Resources.marble_red_32_s; button2.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button2.BackgroundImage = Properties.Resources.marble_red_32; button2.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button2.BackgroundImage = Properties.Resources.marble_yellow_32_s; button2.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button2.BackgroundImage = Properties.Resources.marble_yellow_32; button2.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button2_Enter(sender, e);
    }

    private void button2_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button2.AccessibleName + COLON + SPACE;
      switch (button2.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button2_MouseEnter(object sender, EventArgs e)
    {
      button2_Enter(sender, e);
    }

    private void button2_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button2_MouseLeave(object sender, EventArgs e)
    {
      button2_Leave(sender, e);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      switch (button3.Tag.ToString())
      {
        case MARBLE_BLUE_32: button3.BackgroundImage = Properties.Resources.marble_blue_32_s; button3.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button3.BackgroundImage = Properties.Resources.marble_blue_32; button3.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button3.BackgroundImage = Properties.Resources.marble_green_32_s; button3.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button3.BackgroundImage = Properties.Resources.marble_green_32; button3.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button3.BackgroundImage = Properties.Resources.marble_red_32_s; button3.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button3.BackgroundImage = Properties.Resources.marble_red_32; button3.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button3.BackgroundImage = Properties.Resources.marble_yellow_32_s; button3.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button3.BackgroundImage = Properties.Resources.marble_yellow_32; button3.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button3_Enter(sender, e);
    }

    private void button3_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button3.AccessibleName + COLON + SPACE;
      switch (button3.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button3_MouseEnter(object sender, EventArgs e)
    {
      button3_Enter(sender, e);
    }

    private void button3_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button3_MouseLeave(object sender, EventArgs e)
    {
      button3_Leave(sender, e);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      switch (button4.Tag.ToString())
      {
        case MARBLE_BLUE_32: button4.BackgroundImage = Properties.Resources.marble_blue_32_s; button4.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button4.BackgroundImage = Properties.Resources.marble_blue_32; button4.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button4.BackgroundImage = Properties.Resources.marble_green_32_s; button4.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button4.BackgroundImage = Properties.Resources.marble_green_32; button4.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button4.BackgroundImage = Properties.Resources.marble_red_32_s; button4.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button4.BackgroundImage = Properties.Resources.marble_red_32; button4.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button4.BackgroundImage = Properties.Resources.marble_yellow_32_s; button4.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button4.BackgroundImage = Properties.Resources.marble_yellow_32; button4.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button4_Enter(sender, e);
    }

    private void button4_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button4.AccessibleName + COLON + SPACE;
      switch (button4.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button4_MouseEnter(object sender, EventArgs e)
    {
      button4_Enter(sender, e);
    }

    private void button4_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button4_MouseLeave(object sender, EventArgs e)
    {
      button4_Leave(sender, e);
    }

    private void button5_Click(object sender, EventArgs e)
    {
      switch (button5.Tag.ToString())
      {
        case MARBLE_BLUE_32: button5.BackgroundImage = Properties.Resources.marble_blue_32_s; button5.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button5.BackgroundImage = Properties.Resources.marble_blue_32; button5.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button5.BackgroundImage = Properties.Resources.marble_green_32_s; button5.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button5.BackgroundImage = Properties.Resources.marble_green_32; button5.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button5.BackgroundImage = Properties.Resources.marble_red_32_s; button5.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button5.BackgroundImage = Properties.Resources.marble_red_32; button5.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button5.BackgroundImage = Properties.Resources.marble_yellow_32_s; button5.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button5.BackgroundImage = Properties.Resources.marble_yellow_32; button5.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button5_Enter(sender, e);
    }

    private void button5_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button5.AccessibleName + COLON + SPACE;
      switch (button5.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button5_MouseEnter(object sender, EventArgs e)
    {
      button5_Enter(sender, e);
    }

    private void button5_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button5_MouseLeave(object sender, EventArgs e)
    {
      button5_Leave(sender, e);
    }

    private void button6_Click(object sender, EventArgs e)
    {
      switch (button6.Tag.ToString())
      {
        case MARBLE_BLUE_32: button6.BackgroundImage = Properties.Resources.marble_blue_32_s; button6.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button6.BackgroundImage = Properties.Resources.marble_blue_32; button6.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button6.BackgroundImage = Properties.Resources.marble_green_32_s; button6.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button6.BackgroundImage = Properties.Resources.marble_green_32; button6.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button6.BackgroundImage = Properties.Resources.marble_red_32_s; button6.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button6.BackgroundImage = Properties.Resources.marble_red_32; button6.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button6.BackgroundImage = Properties.Resources.marble_yellow_32_s; button6.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button6.BackgroundImage = Properties.Resources.marble_yellow_32; button6.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button6_Enter(sender, e);
    }

    private void button6_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button6.AccessibleName + COLON + SPACE;
      switch (button6.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button6_MouseEnter(object sender, EventArgs e)
    {
      button6_Enter(sender, e);
    }

    private void button6_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button6_MouseLeave(object sender, EventArgs e)
    {
      button6_Leave(sender, e);
    }

    private void button7_Click(object sender, EventArgs e)
    {
      switch (button7.Tag.ToString())
      {
        case MARBLE_BLUE_32: button7.BackgroundImage = Properties.Resources.marble_blue_32_s; button7.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button7.BackgroundImage = Properties.Resources.marble_blue_32; button7.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button7.BackgroundImage = Properties.Resources.marble_green_32_s; button7.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button7.BackgroundImage = Properties.Resources.marble_green_32; button7.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button7.BackgroundImage = Properties.Resources.marble_red_32_s; button7.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button7.BackgroundImage = Properties.Resources.marble_red_32; button7.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button7.BackgroundImage = Properties.Resources.marble_yellow_32_s; button7.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button7.BackgroundImage = Properties.Resources.marble_yellow_32; button7.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button7_Enter(sender, e);
    }

    private void button7_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button7.AccessibleName + COLON + SPACE;
      switch (button7.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button7_MouseEnter(object sender, EventArgs e)
    {
      button7_Enter(sender, e);
    }

    private void button7_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button7_MouseLeave(object sender, EventArgs e)
    {
      button7_Leave(sender, e);
    }

    private void button8_Click(object sender, EventArgs e)
    {
      switch (button8.Tag.ToString())
      {
        case MARBLE_BLUE_32: button8.BackgroundImage = Properties.Resources.marble_blue_32_s; button8.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button8.BackgroundImage = Properties.Resources.marble_blue_32; button8.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button8.BackgroundImage = Properties.Resources.marble_green_32_s; button8.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button8.BackgroundImage = Properties.Resources.marble_green_32; button8.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button8.BackgroundImage = Properties.Resources.marble_red_32_s; button8.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button8.BackgroundImage = Properties.Resources.marble_red_32; button8.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button8.BackgroundImage = Properties.Resources.marble_yellow_32_s; button8.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button8.BackgroundImage = Properties.Resources.marble_yellow_32; button8.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button8_Enter(sender, e);
    }

    private void button8_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button8.AccessibleName + COLON + SPACE;
      switch (button8.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button8_MouseEnter(object sender, EventArgs e)
    {
      button8_Enter(sender, e);
    }

    private void button8_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button8_MouseLeave(object sender, EventArgs e)
    {
      button8_Leave(sender, e);
    }

    private void button9_Click(object sender, EventArgs e)
    {
      switch (button9.Tag.ToString())
      {
        case MARBLE_BLUE_32: button9.BackgroundImage = Properties.Resources.marble_blue_32_s; button9.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button9.BackgroundImage = Properties.Resources.marble_blue_32; button9.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button9.BackgroundImage = Properties.Resources.marble_green_32_s; button9.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button9.BackgroundImage = Properties.Resources.marble_green_32; button9.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button9.BackgroundImage = Properties.Resources.marble_red_32_s; button9.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button9.BackgroundImage = Properties.Resources.marble_red_32; button9.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button9.BackgroundImage = Properties.Resources.marble_yellow_32_s; button9.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button9.BackgroundImage = Properties.Resources.marble_yellow_32; button9.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button9_Enter(sender, e);
    }

    private void button9_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button9.AccessibleName + COLON + SPACE;
      switch (button9.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button9_MouseEnter(object sender, EventArgs e)
    {
      button9_Enter(sender, e);
    }

    private void button9_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button9_MouseLeave(object sender, EventArgs e)
    {
      button9_Leave(sender, e);
    }

    private void button10_Click(object sender, EventArgs e)
    {
      switch (button10.Tag.ToString())
      {
        case MARBLE_BLUE_32: button10.BackgroundImage = Properties.Resources.marble_blue_32_s; button10.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button10.BackgroundImage = Properties.Resources.marble_blue_32; button10.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button10.BackgroundImage = Properties.Resources.marble_green_32_s; button10.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button10.BackgroundImage = Properties.Resources.marble_green_32; button10.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button10.BackgroundImage = Properties.Resources.marble_red_32_s; button10.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button10.BackgroundImage = Properties.Resources.marble_red_32; button10.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button10.BackgroundImage = Properties.Resources.marble_yellow_32_s; button10.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button10.BackgroundImage = Properties.Resources.marble_yellow_32; button10.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button10_Enter(sender, e);
    }

    private void button10_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button10.AccessibleName + COLON + SPACE;
      switch (button10.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button10_MouseEnter(object sender, EventArgs e)
    {
      button10_Enter(sender, e);
    }

    private void button10_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button10_MouseLeave(object sender, EventArgs e)
    {
      button10_Leave(sender, e);
    }

    private void button11_Click(object sender, EventArgs e)
    {
      switch (button11.Tag.ToString())
      {
        case MARBLE_BLUE_32: button11.BackgroundImage = Properties.Resources.marble_blue_32_s; button11.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button11.BackgroundImage = Properties.Resources.marble_blue_32; button11.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button11.BackgroundImage = Properties.Resources.marble_green_32_s; button11.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button11.BackgroundImage = Properties.Resources.marble_green_32; button11.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button11.BackgroundImage = Properties.Resources.marble_red_32_s; button11.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button11.BackgroundImage = Properties.Resources.marble_red_32; button11.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button11.BackgroundImage = Properties.Resources.marble_yellow_32_s; button11.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button11.BackgroundImage = Properties.Resources.marble_yellow_32; button11.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button11_Enter(sender, e);
    }

    private void button11_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button11.AccessibleName + COLON + SPACE;
      switch (button11.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button11_MouseEnter(object sender, EventArgs e)
    {
      button11_Enter(sender, e);
    }

    private void button11_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button11_MouseLeave(object sender, EventArgs e)
    {
      button11_Leave(sender, e);
    }

    private void button12_Click(object sender, EventArgs e)
    {
      switch (button12.Tag.ToString())
      {
        case MARBLE_BLUE_32: button12.BackgroundImage = Properties.Resources.marble_blue_32_s; button12.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button12.BackgroundImage = Properties.Resources.marble_blue_32; button12.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button12.BackgroundImage = Properties.Resources.marble_green_32_s; button12.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button12.BackgroundImage = Properties.Resources.marble_green_32; button12.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button12.BackgroundImage = Properties.Resources.marble_red_32_s; button12.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button12.BackgroundImage = Properties.Resources.marble_red_32; button12.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button12.BackgroundImage = Properties.Resources.marble_yellow_32_s; button12.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button12.BackgroundImage = Properties.Resources.marble_yellow_32; button12.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button12_Enter(sender, e);
    }

    private void button12_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button12.AccessibleName + COLON + SPACE;
      switch (button12.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button12_MouseEnter(object sender, EventArgs e)
    {
      button12_Enter(sender, e);
    }

    private void button12_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button12_MouseLeave(object sender, EventArgs e)
    {
      button12_Leave(sender, e);
    }

    private void button13_Click(object sender, EventArgs e)
    {
      switch (button13.Tag.ToString())
      {
        case MARBLE_BLUE_32: button13.BackgroundImage = Properties.Resources.marble_blue_32_s; button13.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button13.BackgroundImage = Properties.Resources.marble_blue_32; button13.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button13.BackgroundImage = Properties.Resources.marble_green_32_s; button13.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button13.BackgroundImage = Properties.Resources.marble_green_32; button13.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button13.BackgroundImage = Properties.Resources.marble_red_32_s; button13.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button13.BackgroundImage = Properties.Resources.marble_red_32; button13.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button13.BackgroundImage = Properties.Resources.marble_yellow_32_s; button13.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button13.BackgroundImage = Properties.Resources.marble_yellow_32; button13.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button13_Enter(sender, e);
    }

    private void button13_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button13.AccessibleName + COLON + SPACE;
      switch (button13.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button13_MouseEnter(object sender, EventArgs e)
    {
      button13_Enter(sender, e);
    }

    private void button13_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button13_MouseLeave(object sender, EventArgs e)
    {
      button13_Leave(sender, e);
    }

    private void button14_Click(object sender, EventArgs e)
    {
      switch (button14.Tag.ToString())
      {
        case MARBLE_BLUE_32: button14.BackgroundImage = Properties.Resources.marble_blue_32_s; button14.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button14.BackgroundImage = Properties.Resources.marble_blue_32; button14.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button14.BackgroundImage = Properties.Resources.marble_green_32_s; button14.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button14.BackgroundImage = Properties.Resources.marble_green_32; button14.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button14.BackgroundImage = Properties.Resources.marble_red_32_s; button14.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button14.BackgroundImage = Properties.Resources.marble_red_32; button14.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button14.BackgroundImage = Properties.Resources.marble_yellow_32_s; button14.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button14.BackgroundImage = Properties.Resources.marble_yellow_32; button14.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button14_Enter(sender, e);
    }

    private void button14_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button14.AccessibleName + COLON + SPACE;
      switch (button14.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button14_MouseEnter(object sender, EventArgs e)
    {
      button14_Enter(sender, e);
    }

    private void button14_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button14_MouseLeave(object sender, EventArgs e)
    {
      button14_Leave(sender, e);
    }

    private void button15_Click(object sender, EventArgs e)
    {
      switch (button15.Tag.ToString())
      {
        case MARBLE_BLUE_32: button15.BackgroundImage = Properties.Resources.marble_blue_32_s; button15.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button15.BackgroundImage = Properties.Resources.marble_blue_32; button15.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button15.BackgroundImage = Properties.Resources.marble_green_32_s; button15.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button15.BackgroundImage = Properties.Resources.marble_green_32; button15.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button15.BackgroundImage = Properties.Resources.marble_red_32_s; button15.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button15.BackgroundImage = Properties.Resources.marble_red_32; button15.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button15.BackgroundImage = Properties.Resources.marble_yellow_32_s; button15.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button15.BackgroundImage = Properties.Resources.marble_yellow_32; button15.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button15_Enter(sender, e);
    }

    private void button15_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button15.AccessibleName + COLON + SPACE;
      switch (button15.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button15_MouseEnter(object sender, EventArgs e)
    {
      button15_Enter(sender, e);
    }

    private void button15_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button15_MouseLeave(object sender, EventArgs e)
    {
      button15_Leave(sender, e);
    }

    private void button16_Click(object sender, EventArgs e)
    {
      switch (button16.Tag.ToString())
      {
        case MARBLE_BLUE_32: button16.BackgroundImage = Properties.Resources.marble_blue_32_s; button16.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button16.BackgroundImage = Properties.Resources.marble_blue_32; button16.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button16.BackgroundImage = Properties.Resources.marble_green_32_s; button16.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button16.BackgroundImage = Properties.Resources.marble_green_32; button16.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button16.BackgroundImage = Properties.Resources.marble_red_32_s; button16.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button16.BackgroundImage = Properties.Resources.marble_red_32; button16.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button16.BackgroundImage = Properties.Resources.marble_yellow_32_s; button16.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button16.BackgroundImage = Properties.Resources.marble_yellow_32; button16.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button16_Enter(sender, e);
    }

    private void button16_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button16.AccessibleName + COLON + SPACE;
      switch (button16.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button16_MouseEnter(object sender, EventArgs e)
    {
      button16_Enter(sender, e);
    }

    private void button16_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button16_MouseLeave(object sender, EventArgs e)
    {
      button16_Leave(sender, e);
    }

    private void button17_Click(object sender, EventArgs e)
    {
      switch (button17.Tag.ToString())
      {
        case MARBLE_BLUE_32: button17.BackgroundImage = Properties.Resources.marble_blue_32_s; button17.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button17.BackgroundImage = Properties.Resources.marble_blue_32; button17.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button17.BackgroundImage = Properties.Resources.marble_green_32_s; button17.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button17.BackgroundImage = Properties.Resources.marble_green_32; button17.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button17.BackgroundImage = Properties.Resources.marble_red_32_s; button17.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button17.BackgroundImage = Properties.Resources.marble_red_32; button17.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button17.BackgroundImage = Properties.Resources.marble_yellow_32_s; button17.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button17.BackgroundImage = Properties.Resources.marble_yellow_32; button17.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button17_Enter(sender, e);
    }

    private void button17_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button17.AccessibleName + COLON + SPACE;
      switch (button17.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button17_MouseEnter(object sender, EventArgs e)
    {
      button17_Enter(sender, e);
    }

    private void button17_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button17_MouseLeave(object sender, EventArgs e)
    {
      button17_Leave(sender, e);
    }

    private void button18_Click(object sender, EventArgs e)
    {
      switch (button18.Tag.ToString())
      {
        case MARBLE_BLUE_32: button18.BackgroundImage = Properties.Resources.marble_blue_32_s; button18.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button18.BackgroundImage = Properties.Resources.marble_blue_32; button18.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button18.BackgroundImage = Properties.Resources.marble_green_32_s; button18.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button18.BackgroundImage = Properties.Resources.marble_green_32; button18.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button18.BackgroundImage = Properties.Resources.marble_red_32_s; button18.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button18.BackgroundImage = Properties.Resources.marble_red_32; button18.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button18.BackgroundImage = Properties.Resources.marble_yellow_32_s; button18.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button18.BackgroundImage = Properties.Resources.marble_yellow_32; button18.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button18_Enter(sender, e);
    }

    private void button18_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button18.AccessibleName + COLON + SPACE;
      switch (button18.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button18_MouseEnter(object sender, EventArgs e)
    {
      button18_Enter(sender, e);
    }

    private void button18_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button18_MouseLeave(object sender, EventArgs e)
    {
      button18_Leave(sender, e);
    }

    private void button19_Click(object sender, EventArgs e)
    {
      switch (button19.Tag.ToString())
      {
        case MARBLE_BLUE_32: button19.BackgroundImage = Properties.Resources.marble_blue_32_s; button19.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button19.BackgroundImage = Properties.Resources.marble_blue_32; button19.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button19.BackgroundImage = Properties.Resources.marble_green_32_s; button19.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button19.BackgroundImage = Properties.Resources.marble_green_32; button19.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button19.BackgroundImage = Properties.Resources.marble_red_32_s; button19.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button19.BackgroundImage = Properties.Resources.marble_red_32; button19.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button19.BackgroundImage = Properties.Resources.marble_yellow_32_s; button19.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button19.BackgroundImage = Properties.Resources.marble_yellow_32; button19.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button19_Enter(sender, e);
    }

    private void button19_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button19.AccessibleName + COLON + SPACE;
      switch (button19.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button19_MouseEnter(object sender, EventArgs e)
    {
      button19_Enter(sender, e);
    }

    private void button19_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button19_MouseLeave(object sender, EventArgs e)
    {
      button19_Leave(sender, e);
    }

    private void button20_Click(object sender, EventArgs e)
    {
      switch (button20.Tag.ToString())
      {
        case MARBLE_BLUE_32: button20.BackgroundImage = Properties.Resources.marble_blue_32_s; button20.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button20.BackgroundImage = Properties.Resources.marble_blue_32; button20.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button20.BackgroundImage = Properties.Resources.marble_green_32_s; button20.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button20.BackgroundImage = Properties.Resources.marble_green_32; button20.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button20.BackgroundImage = Properties.Resources.marble_red_32_s; button20.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button20.BackgroundImage = Properties.Resources.marble_red_32; button20.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button20.BackgroundImage = Properties.Resources.marble_yellow_32_s; button20.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button20.BackgroundImage = Properties.Resources.marble_yellow_32; button20.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button20_Enter(sender, e);
    }

    private void button20_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button20.AccessibleName + COLON + SPACE;
      switch (button20.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button20_MouseEnter(object sender, EventArgs e)
    {
      button20_Enter(sender, e);
    }

    private void button20_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button20_MouseLeave(object sender, EventArgs e)
    {
      button20_Leave(sender, e);
    }

    private void button21_Click(object sender, EventArgs e)
    {
      switch (button21.Tag.ToString())
      {
        case MARBLE_BLUE_32: button21.BackgroundImage = Properties.Resources.marble_blue_32_s; button21.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button21.BackgroundImage = Properties.Resources.marble_blue_32; button21.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button21.BackgroundImage = Properties.Resources.marble_green_32_s; button21.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button21.BackgroundImage = Properties.Resources.marble_green_32; button21.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button21.BackgroundImage = Properties.Resources.marble_red_32_s; button21.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button21.BackgroundImage = Properties.Resources.marble_red_32; button21.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button21.BackgroundImage = Properties.Resources.marble_yellow_32_s; button21.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button21.BackgroundImage = Properties.Resources.marble_yellow_32; button21.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button21_Enter(sender, e);
    }

    private void button21_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button21.AccessibleName + COLON + SPACE;
      switch (button21.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button21_MouseEnter(object sender, EventArgs e)
    {
      button21_Enter(sender, e);
    }

    private void button21_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button21_MouseLeave(object sender, EventArgs e)
    {
      button21_Leave(sender, e);
    }

    private void button22_Click(object sender, EventArgs e)
    {
      switch (button22.Tag.ToString())
      {
        case MARBLE_BLUE_32: button22.BackgroundImage = Properties.Resources.marble_blue_32_s; button22.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button22.BackgroundImage = Properties.Resources.marble_blue_32; button22.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button22.BackgroundImage = Properties.Resources.marble_green_32_s; button22.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button22.BackgroundImage = Properties.Resources.marble_green_32; button22.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button22.BackgroundImage = Properties.Resources.marble_red_32_s; button22.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button22.BackgroundImage = Properties.Resources.marble_red_32; button22.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button22.BackgroundImage = Properties.Resources.marble_yellow_32_s; button22.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button22.BackgroundImage = Properties.Resources.marble_yellow_32; button22.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button22_Enter(sender, e);
    }

    private void button22_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button22.AccessibleName + COLON + SPACE;
      switch (button22.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button22_MouseEnter(object sender, EventArgs e)
    {
      button22_Enter(sender, e);
    }

    private void button22_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button22_MouseLeave(object sender, EventArgs e)
    {
      button22_Leave(sender, e);
    }

    private void button23_Click(object sender, EventArgs e)
    {
      switch (button23.Tag.ToString())
      {
        case MARBLE_BLUE_32: button23.BackgroundImage = Properties.Resources.marble_blue_32_s; button23.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button23.BackgroundImage = Properties.Resources.marble_blue_32; button23.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button23.BackgroundImage = Properties.Resources.marble_green_32_s; button23.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button23.BackgroundImage = Properties.Resources.marble_green_32; button23.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button23.BackgroundImage = Properties.Resources.marble_red_32_s; button23.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button23.BackgroundImage = Properties.Resources.marble_red_32; button23.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button23.BackgroundImage = Properties.Resources.marble_yellow_32_s; button23.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button23.BackgroundImage = Properties.Resources.marble_yellow_32; button23.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button23_Enter(sender, e);
    }

    private void button23_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button23.AccessibleName + COLON + SPACE;
      switch (button23.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button23_MouseEnter(object sender, EventArgs e)
    {
      button23_Enter(sender, e);
    }

    private void button23_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button23_MouseLeave(object sender, EventArgs e)
    {
      button23_Leave(sender, e);
    }

    private void button24_Click(object sender, EventArgs e)
    {
      switch (button24.Tag.ToString())
      {
        case MARBLE_BLUE_32: button24.BackgroundImage = Properties.Resources.marble_blue_32_s; button24.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button24.BackgroundImage = Properties.Resources.marble_blue_32; button24.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button24.BackgroundImage = Properties.Resources.marble_green_32_s; button24.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button24.BackgroundImage = Properties.Resources.marble_green_32; button24.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button24.BackgroundImage = Properties.Resources.marble_red_32_s; button24.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button24.BackgroundImage = Properties.Resources.marble_red_32; button24.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button24.BackgroundImage = Properties.Resources.marble_yellow_32_s; button24.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button24.BackgroundImage = Properties.Resources.marble_yellow_32; button24.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button24_Enter(sender, e);
    }

    private void button24_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button24.AccessibleName + COLON + SPACE;
      switch (button24.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button24_MouseEnter(object sender, EventArgs e)
    {
      button24_Enter(sender, e);
    }

    private void button24_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button24_MouseLeave(object sender, EventArgs e)
    {
      button24_Leave(sender, e);
    }

    private void button25_Click(object sender, EventArgs e)
    {
      switch (button25.Tag.ToString())
      {
        case MARBLE_BLUE_32: button25.BackgroundImage = Properties.Resources.marble_blue_32_s; button25.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button25.BackgroundImage = Properties.Resources.marble_blue_32; button25.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button25.BackgroundImage = Properties.Resources.marble_green_32_s; button25.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button25.BackgroundImage = Properties.Resources.marble_green_32; button25.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button25.BackgroundImage = Properties.Resources.marble_red_32_s; button25.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button25.BackgroundImage = Properties.Resources.marble_red_32; button25.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button25.BackgroundImage = Properties.Resources.marble_yellow_32_s; button25.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button25.BackgroundImage = Properties.Resources.marble_yellow_32; button25.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button25_Enter(sender, e);
    }

    private void button25_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button25.AccessibleName + COLON + SPACE;
      switch (button25.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button25_MouseEnter(object sender, EventArgs e)
    {
      button25_Enter(sender, e);
    }

    private void button25_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button25_MouseLeave(object sender, EventArgs e)
    {
      button25_Leave(sender, e);
    }

    private void button26_Click(object sender, EventArgs e)
    {
      switch (button26.Tag.ToString())
      {
        case MARBLE_BLUE_32: button26.BackgroundImage = Properties.Resources.marble_blue_32_s; button26.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button26.BackgroundImage = Properties.Resources.marble_blue_32; button26.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button26.BackgroundImage = Properties.Resources.marble_green_32_s; button26.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button26.BackgroundImage = Properties.Resources.marble_green_32; button26.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button26.BackgroundImage = Properties.Resources.marble_red_32_s; button26.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button26.BackgroundImage = Properties.Resources.marble_red_32; button26.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button26.BackgroundImage = Properties.Resources.marble_yellow_32_s; button26.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button26.BackgroundImage = Properties.Resources.marble_yellow_32; button26.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button26_Enter(sender, e);
    }

    private void button26_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button26.AccessibleName + COLON + SPACE;
      switch (button26.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button26_MouseEnter(object sender, EventArgs e)
    {
      button26_Enter(sender, e);
    }

    private void button26_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button26_MouseLeave(object sender, EventArgs e)
    {
      button26_Leave(sender, e);
    }

    private void button27_Click(object sender, EventArgs e)
    {
      switch (button27.Tag.ToString())
      {
        case MARBLE_BLUE_32: button27.BackgroundImage = Properties.Resources.marble_blue_32_s; button27.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button27.BackgroundImage = Properties.Resources.marble_blue_32; button27.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button27.BackgroundImage = Properties.Resources.marble_green_32_s; button27.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button27.BackgroundImage = Properties.Resources.marble_green_32; button27.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button27.BackgroundImage = Properties.Resources.marble_red_32_s; button27.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button27.BackgroundImage = Properties.Resources.marble_red_32; button27.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button27.BackgroundImage = Properties.Resources.marble_yellow_32_s; button27.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button27.BackgroundImage = Properties.Resources.marble_yellow_32; button27.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button27_Enter(sender, e);
    }

    private void button27_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button27.AccessibleName + COLON + SPACE;
      switch (button27.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button27_MouseEnter(object sender, EventArgs e)
    {
      button27_Enter(sender, e);
    }

    private void button27_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button27_MouseLeave(object sender, EventArgs e)
    {
      button27_Leave(sender, e);
    }

    private void button28_Click(object sender, EventArgs e)
    {
      switch (button28.Tag.ToString())
      {
        case MARBLE_BLUE_32: button28.BackgroundImage = Properties.Resources.marble_blue_32_s; button28.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button28.BackgroundImage = Properties.Resources.marble_blue_32; button28.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button28.BackgroundImage = Properties.Resources.marble_green_32_s; button28.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button28.BackgroundImage = Properties.Resources.marble_green_32; button28.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button28.BackgroundImage = Properties.Resources.marble_red_32_s; button28.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button28.BackgroundImage = Properties.Resources.marble_red_32; button28.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button28.BackgroundImage = Properties.Resources.marble_yellow_32_s; button28.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button28.BackgroundImage = Properties.Resources.marble_yellow_32; button28.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button28_Enter(sender, e);
    }

    private void button28_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button28.AccessibleName + COLON + SPACE;
      switch (button28.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button28_MouseEnter(object sender, EventArgs e)
    {
      button28_Enter(sender, e);
    }

    private void button28_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button28_MouseLeave(object sender, EventArgs e)
    {
      button28_Leave(sender, e);
    }

    private void button29_Click(object sender, EventArgs e)
    {
      switch (button29.Tag.ToString())
      {
        case MARBLE_BLUE_32: button29.BackgroundImage = Properties.Resources.marble_blue_32_s; button29.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button29.BackgroundImage = Properties.Resources.marble_blue_32; button29.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button29.BackgroundImage = Properties.Resources.marble_green_32_s; button29.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button29.BackgroundImage = Properties.Resources.marble_green_32; button29.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button29.BackgroundImage = Properties.Resources.marble_red_32_s; button29.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button29.BackgroundImage = Properties.Resources.marble_red_32; button29.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button29.BackgroundImage = Properties.Resources.marble_yellow_32_s; button29.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button29.BackgroundImage = Properties.Resources.marble_yellow_32; button29.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button29_Enter(sender, e);
    }

    private void button29_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button29.AccessibleName + COLON + SPACE;
      switch (button29.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button29_MouseEnter(object sender, EventArgs e)
    {
      button29_Enter(sender, e);
    }

    private void button29_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button29_MouseLeave(object sender, EventArgs e)
    {
      button29_Leave(sender, e);
    }

    private void button30_Click(object sender, EventArgs e)
    {
      switch (button30.Tag.ToString())
      {
        case MARBLE_BLUE_32: button30.BackgroundImage = Properties.Resources.marble_blue_32_s; button30.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button30.BackgroundImage = Properties.Resources.marble_blue_32; button30.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button30.BackgroundImage = Properties.Resources.marble_green_32_s; button30.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button30.BackgroundImage = Properties.Resources.marble_green_32; button30.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button30.BackgroundImage = Properties.Resources.marble_red_32_s; button30.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button30.BackgroundImage = Properties.Resources.marble_red_32; button30.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button30.BackgroundImage = Properties.Resources.marble_yellow_32_s; button30.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button30.BackgroundImage = Properties.Resources.marble_yellow_32; button30.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button30_Enter(sender, e);
    }

    private void button30_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button30.AccessibleName + COLON + SPACE;
      switch (button30.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button30_MouseEnter(object sender, EventArgs e)
    {
      button30_Enter(sender, e);
    }

    private void button30_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button30_MouseLeave(object sender, EventArgs e)
    {
      button30_Leave(sender, e);
    }

    private void button31_Click(object sender, EventArgs e)
    {
      switch (button31.Tag.ToString())
      {
        case MARBLE_BLUE_32: button31.BackgroundImage = Properties.Resources.marble_blue_32_s; button31.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button31.BackgroundImage = Properties.Resources.marble_blue_32; button31.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button31.BackgroundImage = Properties.Resources.marble_green_32_s; button31.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button31.BackgroundImage = Properties.Resources.marble_green_32; button31.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button31.BackgroundImage = Properties.Resources.marble_red_32_s; button31.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button31.BackgroundImage = Properties.Resources.marble_red_32; button31.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button31.BackgroundImage = Properties.Resources.marble_yellow_32_s; button31.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button31.BackgroundImage = Properties.Resources.marble_yellow_32; button31.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button31_Enter(sender, e);
    }

    private void button31_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button31.AccessibleName + COLON + SPACE;
      switch (button31.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button31_MouseEnter(object sender, EventArgs e)
    {
      button31_Enter(sender, e);
    }

    private void button31_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button31_MouseLeave(object sender, EventArgs e)
    {
      button31_Leave(sender, e);
    }

    private void button32_Click(object sender, EventArgs e)
    {
      switch (button32.Tag.ToString())
      {
        case MARBLE_BLUE_32: button32.BackgroundImage = Properties.Resources.marble_blue_32_s; button32.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button32.BackgroundImage = Properties.Resources.marble_blue_32; button32.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button32.BackgroundImage = Properties.Resources.marble_green_32_s; button32.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button32.BackgroundImage = Properties.Resources.marble_green_32; button32.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button32.BackgroundImage = Properties.Resources.marble_red_32_s; button32.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button32.BackgroundImage = Properties.Resources.marble_red_32; button32.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button32.BackgroundImage = Properties.Resources.marble_yellow_32_s; button32.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button32.BackgroundImage = Properties.Resources.marble_yellow_32; button32.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button32_Enter(sender, e);
    }

    private void button32_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button32.AccessibleName + COLON + SPACE;
      switch (button32.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button32_MouseEnter(object sender, EventArgs e)
    {
      button32_Enter(sender, e);
    }

    private void button32_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button32_MouseLeave(object sender, EventArgs e)
    {
      button32_Leave(sender, e);
    }

    private void button33_Click(object sender, EventArgs e)
    {
      switch (button33.Tag.ToString())
      {
        case MARBLE_BLUE_32: button33.BackgroundImage = Properties.Resources.marble_blue_32_s; button33.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button33.BackgroundImage = Properties.Resources.marble_blue_32; button33.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button33.BackgroundImage = Properties.Resources.marble_green_32_s; button33.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button33.BackgroundImage = Properties.Resources.marble_green_32; button33.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button33.BackgroundImage = Properties.Resources.marble_red_32_s; button33.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button33.BackgroundImage = Properties.Resources.marble_red_32; button33.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button33.BackgroundImage = Properties.Resources.marble_yellow_32_s; button33.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button33.BackgroundImage = Properties.Resources.marble_yellow_32; button33.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button33_Enter(sender, e);
    }

    private void button33_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button33.AccessibleName + COLON + SPACE;
      switch (button33.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button33_MouseEnter(object sender, EventArgs e)
    {
      button33_Enter(sender, e);
    }

    private void button33_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button33_MouseLeave(object sender, EventArgs e)
    {
      button33_Leave(sender, e);
    }

    private void button34_Click(object sender, EventArgs e)
    {
      switch (button34.Tag.ToString())
      {
        case MARBLE_BLUE_32: button34.BackgroundImage = Properties.Resources.marble_blue_32_s; button34.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button34.BackgroundImage = Properties.Resources.marble_blue_32; button34.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button34.BackgroundImage = Properties.Resources.marble_green_32_s; button34.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button34.BackgroundImage = Properties.Resources.marble_green_32; button34.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button34.BackgroundImage = Properties.Resources.marble_red_32_s; button34.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button34.BackgroundImage = Properties.Resources.marble_red_32; button34.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button34.BackgroundImage = Properties.Resources.marble_yellow_32_s; button34.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button34.BackgroundImage = Properties.Resources.marble_yellow_32; button34.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button34_Enter(sender, e);
    }

    private void button34_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button34.AccessibleName + COLON + SPACE;
      switch (button34.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button34_MouseEnter(object sender, EventArgs e)
    {
      button34_Enter(sender, e);
    }

    private void button34_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button34_MouseLeave(object sender, EventArgs e)
    {
      button34_Leave(sender, e);
    }

    private void button35_Click(object sender, EventArgs e)
    {
      switch (button35.Tag.ToString())
      {
        case MARBLE_BLUE_32: button35.BackgroundImage = Properties.Resources.marble_blue_32_s; button35.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button35.BackgroundImage = Properties.Resources.marble_blue_32; button35.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button35.BackgroundImage = Properties.Resources.marble_green_32_s; button35.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button35.BackgroundImage = Properties.Resources.marble_green_32; button35.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button35.BackgroundImage = Properties.Resources.marble_red_32_s; button35.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button35.BackgroundImage = Properties.Resources.marble_red_32; button35.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button35.BackgroundImage = Properties.Resources.marble_yellow_32_s; button35.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button35.BackgroundImage = Properties.Resources.marble_yellow_32; button35.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button35_Enter(sender, e);
    }

    private void button35_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button35.AccessibleName + COLON + SPACE;
      switch (button35.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button35_MouseEnter(object sender, EventArgs e)
    {
      button35_Enter(sender, e);
    }

    private void button35_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button35_MouseLeave(object sender, EventArgs e)
    {
      button35_Leave(sender, e);
    }

    private void button36_Click(object sender, EventArgs e)
    {
      switch (button36.Tag.ToString())
      {
        case MARBLE_BLUE_32: button36.BackgroundImage = Properties.Resources.marble_blue_32_s; button36.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button36.BackgroundImage = Properties.Resources.marble_blue_32; button36.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button36.BackgroundImage = Properties.Resources.marble_green_32_s; button36.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button36.BackgroundImage = Properties.Resources.marble_green_32; button36.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button36.BackgroundImage = Properties.Resources.marble_red_32_s; button36.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button36.BackgroundImage = Properties.Resources.marble_red_32; button36.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button36.BackgroundImage = Properties.Resources.marble_yellow_32_s; button36.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button36.BackgroundImage = Properties.Resources.marble_yellow_32; button36.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button36_Enter(sender, e);
    }

    private void button36_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button36.AccessibleName + COLON + SPACE;
      switch (button36.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button36_MouseEnter(object sender, EventArgs e)
    {
      button36_Enter(sender, e);
    }

    private void button36_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button36_MouseLeave(object sender, EventArgs e)
    {
      button36_Leave(sender, e);
    }

    private void button37_Click(object sender, EventArgs e)
    {
      switch (button37.Tag.ToString())
      {
        case MARBLE_BLUE_32: button37.BackgroundImage = Properties.Resources.marble_blue_32_s; button37.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button37.BackgroundImage = Properties.Resources.marble_blue_32; button37.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button37.BackgroundImage = Properties.Resources.marble_green_32_s; button37.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button37.BackgroundImage = Properties.Resources.marble_green_32; button37.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button37.BackgroundImage = Properties.Resources.marble_red_32_s; button37.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button37.BackgroundImage = Properties.Resources.marble_red_32; button37.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button37.BackgroundImage = Properties.Resources.marble_yellow_32_s; button37.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button37.BackgroundImage = Properties.Resources.marble_yellow_32; button37.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button37_Enter(sender, e);
    }

    private void button37_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button37.AccessibleName + COLON + SPACE;
      switch (button37.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button37_MouseEnter(object sender, EventArgs e)
    {
      button37_Enter(sender, e);
    }

    private void button37_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button37_MouseLeave(object sender, EventArgs e)
    {
      button37_Leave(sender, e);
    }

    private void button38_Click(object sender, EventArgs e)
    {
      switch (button38.Tag.ToString())
      {
        case MARBLE_BLUE_32: button38.BackgroundImage = Properties.Resources.marble_blue_32_s; button38.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button38.BackgroundImage = Properties.Resources.marble_blue_32; button38.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button38.BackgroundImage = Properties.Resources.marble_green_32_s; button38.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button38.BackgroundImage = Properties.Resources.marble_green_32; button38.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button38.BackgroundImage = Properties.Resources.marble_red_32_s; button38.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button38.BackgroundImage = Properties.Resources.marble_red_32; button38.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button38.BackgroundImage = Properties.Resources.marble_yellow_32_s; button38.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button38.BackgroundImage = Properties.Resources.marble_yellow_32; button38.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button38_Enter(sender, e);
    }

    private void button38_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button38.AccessibleName + COLON + SPACE;
      switch (button38.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button38_MouseEnter(object sender, EventArgs e)
    {
      button38_Enter(sender, e);
    }

    private void button38_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button38_MouseLeave(object sender, EventArgs e)
    {
      button38_Leave(sender, e);
    }

    private void button39_Click(object sender, EventArgs e)
    {
      switch (button39.Tag.ToString())
      {
        case MARBLE_BLUE_32: button39.BackgroundImage = Properties.Resources.marble_blue_32_s; button39.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button39.BackgroundImage = Properties.Resources.marble_blue_32; button39.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button39.BackgroundImage = Properties.Resources.marble_green_32_s; button39.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button39.BackgroundImage = Properties.Resources.marble_green_32; button39.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button39.BackgroundImage = Properties.Resources.marble_red_32_s; button39.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button39.BackgroundImage = Properties.Resources.marble_red_32; button39.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button39.BackgroundImage = Properties.Resources.marble_yellow_32_s; button39.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button39.BackgroundImage = Properties.Resources.marble_yellow_32; button39.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button39_Enter(sender, e);
    }

    private void button39_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button39.AccessibleName + COLON + SPACE;
      switch (button39.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button39_MouseEnter(object sender, EventArgs e)
    {
      button39_Enter(sender, e);
    }

    private void button39_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button39_MouseLeave(object sender, EventArgs e)
    {
      button39_Leave(sender, e);
    }

    private void button40_Click(object sender, EventArgs e)
    {
      switch (button40.Tag.ToString())
      {
        case MARBLE_BLUE_32: button40.BackgroundImage = Properties.Resources.marble_blue_32_s; button40.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button40.BackgroundImage = Properties.Resources.marble_blue_32; button40.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button40.BackgroundImage = Properties.Resources.marble_green_32_s; button40.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button40.BackgroundImage = Properties.Resources.marble_green_32; button40.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button40.BackgroundImage = Properties.Resources.marble_red_32_s; button40.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button40.BackgroundImage = Properties.Resources.marble_red_32; button40.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button40.BackgroundImage = Properties.Resources.marble_yellow_32_s; button40.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button40.BackgroundImage = Properties.Resources.marble_yellow_32; button40.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button40_Enter(sender, e);
    }

    private void button40_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button40.AccessibleName + COLON + SPACE;
      switch (button40.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button40_MouseEnter(object sender, EventArgs e)
    {
      button40_Enter(sender, e);
    }

    private void button40_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button40_MouseLeave(object sender, EventArgs e)
    {
      button40_Leave(sender, e);
    }

    private void button41_Click(object sender, EventArgs e)
    {
      switch (button41.Tag.ToString())
      {
        case MARBLE_BLUE_32: button41.BackgroundImage = Properties.Resources.marble_blue_32_s; button41.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button41.BackgroundImage = Properties.Resources.marble_blue_32; button41.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button41.BackgroundImage = Properties.Resources.marble_green_32_s; button41.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button41.BackgroundImage = Properties.Resources.marble_green_32; button41.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button41.BackgroundImage = Properties.Resources.marble_red_32_s; button41.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button41.BackgroundImage = Properties.Resources.marble_red_32; button41.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button41.BackgroundImage = Properties.Resources.marble_yellow_32_s; button41.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button41.BackgroundImage = Properties.Resources.marble_yellow_32; button41.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button41_Enter(sender, e);
    }

    private void button41_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button41.AccessibleName + COLON + SPACE;
      switch (button41.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button41_MouseEnter(object sender, EventArgs e)
    {
      button41_Enter(sender, e);
    }

    private void button41_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button41_MouseLeave(object sender, EventArgs e)
    {
      button41_Leave(sender, e);
    }

    private void button42_Click(object sender, EventArgs e)
    {
      switch (button42.Tag.ToString())
      {
        case MARBLE_BLUE_32: button42.BackgroundImage = Properties.Resources.marble_blue_32_s; button42.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button42.BackgroundImage = Properties.Resources.marble_blue_32; button42.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button42.BackgroundImage = Properties.Resources.marble_green_32_s; button42.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button42.BackgroundImage = Properties.Resources.marble_green_32; button42.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button42.BackgroundImage = Properties.Resources.marble_red_32_s; button42.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button42.BackgroundImage = Properties.Resources.marble_red_32; button42.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button42.BackgroundImage = Properties.Resources.marble_yellow_32_s; button42.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button42.BackgroundImage = Properties.Resources.marble_yellow_32; button42.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button42_Enter(sender, e);
    }

    private void button42_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button42.AccessibleName + COLON + SPACE;
      switch (button42.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button42_MouseEnter(object sender, EventArgs e)
    {
      button42_Enter(sender, e);
    }

    private void button42_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button42_MouseLeave(object sender, EventArgs e)
    {
      button42_Leave(sender, e);
    }

    private void button43_Click(object sender, EventArgs e)
    {
      switch (button43.Tag.ToString())
      {
        case MARBLE_BLUE_32: button43.BackgroundImage = Properties.Resources.marble_blue_32_s; button43.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button43.BackgroundImage = Properties.Resources.marble_blue_32; button43.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button43.BackgroundImage = Properties.Resources.marble_green_32_s; button43.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button43.BackgroundImage = Properties.Resources.marble_green_32; button43.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button43.BackgroundImage = Properties.Resources.marble_red_32_s; button43.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button43.BackgroundImage = Properties.Resources.marble_red_32; button43.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button43.BackgroundImage = Properties.Resources.marble_yellow_32_s; button43.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button43.BackgroundImage = Properties.Resources.marble_yellow_32; button43.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button43_Enter(sender, e);
    }

    private void button43_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button43.AccessibleName + COLON + SPACE;
      switch (button43.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button43_MouseEnter(object sender, EventArgs e)
    {
      button43_Enter(sender, e);
    }

    private void button43_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button43_MouseLeave(object sender, EventArgs e)
    {
      button43_Leave(sender, e);
    }

    private void button44_Click(object sender, EventArgs e)
    {
      switch (button44.Tag.ToString())
      {
        case MARBLE_BLUE_32: button44.BackgroundImage = Properties.Resources.marble_blue_32_s; button44.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button44.BackgroundImage = Properties.Resources.marble_blue_32; button44.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button44.BackgroundImage = Properties.Resources.marble_green_32_s; button44.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button44.BackgroundImage = Properties.Resources.marble_green_32; button44.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button44.BackgroundImage = Properties.Resources.marble_red_32_s; button44.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button44.BackgroundImage = Properties.Resources.marble_red_32; button44.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button44.BackgroundImage = Properties.Resources.marble_yellow_32_s; button44.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button44.BackgroundImage = Properties.Resources.marble_yellow_32; button44.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button44_Enter(sender, e);
    }

    private void button44_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button44.AccessibleName + COLON + SPACE;
      switch (button44.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button44_MouseEnter(object sender, EventArgs e)
    {
      button44_Enter(sender, e);
    }

    private void button44_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button44_MouseLeave(object sender, EventArgs e)
    {
      button44_Leave(sender, e);
    }

    private void button45_Click(object sender, EventArgs e)
    {
      switch (button45.Tag.ToString())
      {
        case MARBLE_BLUE_32: button45.BackgroundImage = Properties.Resources.marble_blue_32_s; button45.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button45.BackgroundImage = Properties.Resources.marble_blue_32; button45.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button45.BackgroundImage = Properties.Resources.marble_green_32_s; button45.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button45.BackgroundImage = Properties.Resources.marble_green_32; button45.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button45.BackgroundImage = Properties.Resources.marble_red_32_s; button45.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button45.BackgroundImage = Properties.Resources.marble_red_32; button45.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button45.BackgroundImage = Properties.Resources.marble_yellow_32_s; button45.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button45.BackgroundImage = Properties.Resources.marble_yellow_32; button45.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button45_Enter(sender, e);
    }

    private void button45_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button45.AccessibleName + COLON + SPACE;
      switch (button45.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button45_MouseEnter(object sender, EventArgs e)
    {
      button45_Enter(sender, e);
    }

    private void button45_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button45_MouseLeave(object sender, EventArgs e)
    {
      button45_Leave(sender, e);
    }

    private void button46_Click(object sender, EventArgs e)
    {
      switch (button46.Tag.ToString())
      {
        case MARBLE_BLUE_32: button46.BackgroundImage = Properties.Resources.marble_blue_32_s; button46.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button46.BackgroundImage = Properties.Resources.marble_blue_32; button46.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button46.BackgroundImage = Properties.Resources.marble_green_32_s; button46.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button46.BackgroundImage = Properties.Resources.marble_green_32; button46.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button46.BackgroundImage = Properties.Resources.marble_red_32_s; button46.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button46.BackgroundImage = Properties.Resources.marble_red_32; button46.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button46.BackgroundImage = Properties.Resources.marble_yellow_32_s; button46.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button46.BackgroundImage = Properties.Resources.marble_yellow_32; button46.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button46_Enter(sender, e);
    }

    private void button46_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button46.AccessibleName + COLON + SPACE;
      switch (button46.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button46_MouseEnter(object sender, EventArgs e)
    {
      button46_Enter(sender, e);
    }

    private void button46_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button46_MouseLeave(object sender, EventArgs e)
    {
      button46_Leave(sender, e);
    }

    private void button47_Click(object sender, EventArgs e)
    {
      switch (button47.Tag.ToString())
      {
        case MARBLE_BLUE_32: button47.BackgroundImage = Properties.Resources.marble_blue_32_s; button47.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button47.BackgroundImage = Properties.Resources.marble_blue_32; button47.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button47.BackgroundImage = Properties.Resources.marble_green_32_s; button47.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button47.BackgroundImage = Properties.Resources.marble_green_32; button47.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button47.BackgroundImage = Properties.Resources.marble_red_32_s; button47.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button47.BackgroundImage = Properties.Resources.marble_red_32; button47.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button47.BackgroundImage = Properties.Resources.marble_yellow_32_s; button47.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button47.BackgroundImage = Properties.Resources.marble_yellow_32; button47.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button47_Enter(sender, e);
    }

    private void button47_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button47.AccessibleName + COLON + SPACE;
      switch (button47.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button47_MouseEnter(object sender, EventArgs e)
    {
      button47_Enter(sender, e);
    }

    private void button47_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button47_MouseLeave(object sender, EventArgs e)
    {
      button47_Leave(sender, e);
    }

    private void button48_Click(object sender, EventArgs e)
    {
      switch (button48.Tag.ToString())
      {
        case MARBLE_BLUE_32: button48.BackgroundImage = Properties.Resources.marble_blue_32_s; button48.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button48.BackgroundImage = Properties.Resources.marble_blue_32; button48.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button48.BackgroundImage = Properties.Resources.marble_green_32_s; button48.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button48.BackgroundImage = Properties.Resources.marble_green_32; button48.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button48.BackgroundImage = Properties.Resources.marble_red_32_s; button48.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button48.BackgroundImage = Properties.Resources.marble_red_32; button48.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button48.BackgroundImage = Properties.Resources.marble_yellow_32_s; button48.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button48.BackgroundImage = Properties.Resources.marble_yellow_32; button48.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button48_Enter(sender, e);
    }

    private void button48_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button48.AccessibleName + COLON + SPACE;
      switch (button48.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button48_MouseEnter(object sender, EventArgs e)
    {
      button48_Enter(sender, e);
    }

    private void button48_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button48_MouseLeave(object sender, EventArgs e)
    {
      button48_Leave(sender, e);
    }

    private void button49_Click(object sender, EventArgs e)
    {
      switch (button49.Tag.ToString())
      {
        case MARBLE_BLUE_32: button49.BackgroundImage = Properties.Resources.marble_blue_32_s; button49.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button49.BackgroundImage = Properties.Resources.marble_blue_32; button49.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button49.BackgroundImage = Properties.Resources.marble_green_32_s; button49.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button49.BackgroundImage = Properties.Resources.marble_green_32; button49.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button49.BackgroundImage = Properties.Resources.marble_red_32_s; button49.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button49.BackgroundImage = Properties.Resources.marble_red_32; button49.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button49.BackgroundImage = Properties.Resources.marble_yellow_32_s; button49.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button49.BackgroundImage = Properties.Resources.marble_yellow_32; button49.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button49_Enter(sender, e);
    }

    private void button49_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button49.AccessibleName + COLON + SPACE;
      switch (button49.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button49_MouseEnter(object sender, EventArgs e)
    {
      button49_Enter(sender, e);
    }

    private void button49_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button49_MouseLeave(object sender, EventArgs e)
    {
      button49_Leave(sender, e);
    }

    private void button50_Click(object sender, EventArgs e)
    {
      switch (button50.Tag.ToString())
      {
        case MARBLE_BLUE_32: button50.BackgroundImage = Properties.Resources.marble_blue_32_s; button50.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button50.BackgroundImage = Properties.Resources.marble_blue_32; button50.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button50.BackgroundImage = Properties.Resources.marble_green_32_s; button50.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button50.BackgroundImage = Properties.Resources.marble_green_32; button50.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button50.BackgroundImage = Properties.Resources.marble_red_32_s; button50.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button50.BackgroundImage = Properties.Resources.marble_red_32; button50.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button50.BackgroundImage = Properties.Resources.marble_yellow_32_s; button50.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button50.BackgroundImage = Properties.Resources.marble_yellow_32; button50.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button50_Enter(sender, e);
    }

    private void button50_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button50.AccessibleName + COLON + SPACE;
      switch (button50.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button50_MouseEnter(object sender, EventArgs e)
    {
      button50_Enter(sender, e);
    }

    private void button50_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button50_MouseLeave(object sender, EventArgs e)
    {
      button50_Leave(sender, e);
    }

    private void button51_Click(object sender, EventArgs e)
    {
      switch (button51.Tag.ToString())
      {
        case MARBLE_BLUE_32: button51.BackgroundImage = Properties.Resources.marble_blue_32_s; button51.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button51.BackgroundImage = Properties.Resources.marble_blue_32; button51.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button51.BackgroundImage = Properties.Resources.marble_green_32_s; button51.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button51.BackgroundImage = Properties.Resources.marble_green_32; button51.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button51.BackgroundImage = Properties.Resources.marble_red_32_s; button51.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button51.BackgroundImage = Properties.Resources.marble_red_32; button51.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button51.BackgroundImage = Properties.Resources.marble_yellow_32_s; button51.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button51.BackgroundImage = Properties.Resources.marble_yellow_32; button51.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button51_Enter(sender, e);
    }

    private void button51_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button51.AccessibleName + COLON + SPACE;
      switch (button51.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button51_MouseEnter(object sender, EventArgs e)
    {
      button51_Enter(sender, e);
    }

    private void button51_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button51_MouseLeave(object sender, EventArgs e)
    {
      button51_Leave(sender, e);
    }

    private void button52_Click(object sender, EventArgs e)
    {
      switch (button52.Tag.ToString())
      {
        case MARBLE_BLUE_32: button52.BackgroundImage = Properties.Resources.marble_blue_32_s; button52.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button52.BackgroundImage = Properties.Resources.marble_blue_32; button52.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button52.BackgroundImage = Properties.Resources.marble_green_32_s; button52.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button52.BackgroundImage = Properties.Resources.marble_green_32; button52.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button52.BackgroundImage = Properties.Resources.marble_red_32_s; button52.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button52.BackgroundImage = Properties.Resources.marble_red_32; button52.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button52.BackgroundImage = Properties.Resources.marble_yellow_32_s; button52.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button52.BackgroundImage = Properties.Resources.marble_yellow_32; button52.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button52_Enter(sender, e);
    }

    private void button52_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button52.AccessibleName + COLON + SPACE;
      switch (button52.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button52_MouseEnter(object sender, EventArgs e)
    {
      button52_Enter(sender, e);
    }

    private void button52_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button52_MouseLeave(object sender, EventArgs e)
    {
      button52_Leave(sender, e);
    }

    private void button53_Click(object sender, EventArgs e)
    {
      switch (button53.Tag.ToString())
      {
        case MARBLE_BLUE_32: button53.BackgroundImage = Properties.Resources.marble_blue_32_s; button53.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button53.BackgroundImage = Properties.Resources.marble_blue_32; button53.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button53.BackgroundImage = Properties.Resources.marble_green_32_s; button53.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button53.BackgroundImage = Properties.Resources.marble_green_32; button53.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button53.BackgroundImage = Properties.Resources.marble_red_32_s; button53.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button53.BackgroundImage = Properties.Resources.marble_red_32; button53.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button53.BackgroundImage = Properties.Resources.marble_yellow_32_s; button53.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button53.BackgroundImage = Properties.Resources.marble_yellow_32; button53.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button53_Enter(sender, e);
    }

    private void button53_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button53.AccessibleName + COLON + SPACE;
      switch (button53.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button53_MouseEnter(object sender, EventArgs e)
    {
      button53_Enter(sender, e);
    }

    private void button53_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button53_MouseLeave(object sender, EventArgs e)
    {
      button53_Leave(sender, e);
    }

    private void button54_Click(object sender, EventArgs e)
    {
      switch (button54.Tag.ToString())
      {
        case MARBLE_BLUE_32: button54.BackgroundImage = Properties.Resources.marble_blue_32_s; button54.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button54.BackgroundImage = Properties.Resources.marble_blue_32; button54.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button54.BackgroundImage = Properties.Resources.marble_green_32_s; button54.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button54.BackgroundImage = Properties.Resources.marble_green_32; button54.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button54.BackgroundImage = Properties.Resources.marble_red_32_s; button54.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button54.BackgroundImage = Properties.Resources.marble_red_32; button54.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button54.BackgroundImage = Properties.Resources.marble_yellow_32_s; button54.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button54.BackgroundImage = Properties.Resources.marble_yellow_32; button54.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button54_Enter(sender, e);
    }

    private void button54_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button54.AccessibleName + COLON + SPACE;
      switch (button54.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button54_MouseEnter(object sender, EventArgs e)
    {
      button54_Enter(sender, e);
    }

    private void button54_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button54_MouseLeave(object sender, EventArgs e)
    {
      button54_Leave(sender, e);
    }

    private void button55_Click(object sender, EventArgs e)
    {
      switch (button55.Tag.ToString())
      {
        case MARBLE_BLUE_32: button55.BackgroundImage = Properties.Resources.marble_blue_32_s; button55.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button55.BackgroundImage = Properties.Resources.marble_blue_32; button55.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button55.BackgroundImage = Properties.Resources.marble_green_32_s; button55.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button55.BackgroundImage = Properties.Resources.marble_green_32; button55.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button55.BackgroundImage = Properties.Resources.marble_red_32_s; button55.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button55.BackgroundImage = Properties.Resources.marble_red_32; button55.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button55.BackgroundImage = Properties.Resources.marble_yellow_32_s; button55.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button55.BackgroundImage = Properties.Resources.marble_yellow_32; button55.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button55_Enter(sender, e);
    }

    private void button55_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button55.AccessibleName + COLON + SPACE;
      switch (button55.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button55_MouseEnter(object sender, EventArgs e)
    {
      button55_Enter(sender, e);
    }

    private void button55_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button55_MouseLeave(object sender, EventArgs e)
    {
      button55_Leave(sender, e);
    }

    private void button56_Click(object sender, EventArgs e)
    {
      switch (button56.Tag.ToString())
      {
        case MARBLE_BLUE_32: button56.BackgroundImage = Properties.Resources.marble_blue_32_s; button56.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button56.BackgroundImage = Properties.Resources.marble_blue_32; button56.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button56.BackgroundImage = Properties.Resources.marble_green_32_s; button56.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button56.BackgroundImage = Properties.Resources.marble_green_32; button56.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button56.BackgroundImage = Properties.Resources.marble_red_32_s; button56.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button56.BackgroundImage = Properties.Resources.marble_red_32; button56.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button56.BackgroundImage = Properties.Resources.marble_yellow_32_s; button56.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button56.BackgroundImage = Properties.Resources.marble_yellow_32; button56.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button56_Enter(sender, e);
    }

    private void button56_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button56.AccessibleName + COLON + SPACE;
      switch (button56.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button56_MouseEnter(object sender, EventArgs e)
    {
      button56_Enter(sender, e);
    }

    private void button56_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button56_MouseLeave(object sender, EventArgs e)
    {
      button56_Leave(sender, e);
    }

    private void button57_Click(object sender, EventArgs e)
    {
      switch (button57.Tag.ToString())
      {
        case MARBLE_BLUE_32: button57.BackgroundImage = Properties.Resources.marble_blue_32_s; button57.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button57.BackgroundImage = Properties.Resources.marble_blue_32; button57.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button57.BackgroundImage = Properties.Resources.marble_green_32_s; button57.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button57.BackgroundImage = Properties.Resources.marble_green_32; button57.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button57.BackgroundImage = Properties.Resources.marble_red_32_s; button57.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button57.BackgroundImage = Properties.Resources.marble_red_32; button57.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button57.BackgroundImage = Properties.Resources.marble_yellow_32_s; button57.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button57.BackgroundImage = Properties.Resources.marble_yellow_32; button57.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button57_Enter(sender, e);
    }

    private void button57_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button57.AccessibleName + COLON + SPACE;
      switch (button57.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button57_MouseEnter(object sender, EventArgs e)
    {
      button57_Enter(sender, e);
    }

    private void button57_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button57_MouseLeave(object sender, EventArgs e)
    {
      button57_Leave(sender, e);
    }

    private void button58_Click(object sender, EventArgs e)
    {
      switch (button58.Tag.ToString())
      {
        case MARBLE_BLUE_32: button58.BackgroundImage = Properties.Resources.marble_blue_32_s; button58.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button58.BackgroundImage = Properties.Resources.marble_blue_32; button58.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button58.BackgroundImage = Properties.Resources.marble_green_32_s; button58.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button58.BackgroundImage = Properties.Resources.marble_green_32; button58.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button58.BackgroundImage = Properties.Resources.marble_red_32_s; button58.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button58.BackgroundImage = Properties.Resources.marble_red_32; button58.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button58.BackgroundImage = Properties.Resources.marble_yellow_32_s; button58.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button58.BackgroundImage = Properties.Resources.marble_yellow_32; button58.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button58_Enter(sender, e);
    }

    private void button58_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button58.AccessibleName + COLON + SPACE;
      switch (button58.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button58_MouseEnter(object sender, EventArgs e)
    {
      button58_Enter(sender, e);
    }

    private void button58_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button58_MouseLeave(object sender, EventArgs e)
    {
      button58_Leave(sender, e);
    }

    private void button59_Click(object sender, EventArgs e)
    {
      switch (button59.Tag.ToString())
      {
        case MARBLE_BLUE_32: button59.BackgroundImage = Properties.Resources.marble_blue_32_s; button59.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button59.BackgroundImage = Properties.Resources.marble_blue_32; button59.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button59.BackgroundImage = Properties.Resources.marble_green_32_s; button59.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button59.BackgroundImage = Properties.Resources.marble_green_32; button59.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button59.BackgroundImage = Properties.Resources.marble_red_32_s; button59.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button59.BackgroundImage = Properties.Resources.marble_red_32; button59.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button59.BackgroundImage = Properties.Resources.marble_yellow_32_s; button59.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button59.BackgroundImage = Properties.Resources.marble_yellow_32; button59.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button59_Enter(sender, e);
    }

    private void button59_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button59.AccessibleName + COLON + SPACE;
      switch (button59.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button59_MouseEnter(object sender, EventArgs e)
    {
      button59_Enter(sender, e);
    }

    private void button59_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button59_MouseLeave(object sender, EventArgs e)
    {
      button59_Leave(sender, e);
    }

    private void button60_Click(object sender, EventArgs e)
    {
      switch (button60.Tag.ToString())
      {
        case MARBLE_BLUE_32: button60.BackgroundImage = Properties.Resources.marble_blue_32_s; button60.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button60.BackgroundImage = Properties.Resources.marble_blue_32; button60.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button60.BackgroundImage = Properties.Resources.marble_green_32_s; button60.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button60.BackgroundImage = Properties.Resources.marble_green_32; button60.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button60.BackgroundImage = Properties.Resources.marble_red_32_s; button60.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button60.BackgroundImage = Properties.Resources.marble_red_32; button60.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button60.BackgroundImage = Properties.Resources.marble_yellow_32_s; button60.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button60.BackgroundImage = Properties.Resources.marble_yellow_32; button60.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button60_Enter(sender, e);
    }

    private void button60_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button60.AccessibleName + COLON + SPACE;
      switch (button60.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button60_MouseEnter(object sender, EventArgs e)
    {
      button60_Enter(sender, e);
    }

    private void button60_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button60_MouseLeave(object sender, EventArgs e)
    {
      button60_Leave(sender, e);
    }

    private void button61_Click(object sender, EventArgs e)
    {
      switch (button61.Tag.ToString())
      {
        case MARBLE_BLUE_32: button61.BackgroundImage = Properties.Resources.marble_blue_32_s; button61.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button61.BackgroundImage = Properties.Resources.marble_blue_32; button61.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button61.BackgroundImage = Properties.Resources.marble_green_32_s; button61.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button61.BackgroundImage = Properties.Resources.marble_green_32; button61.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button61.BackgroundImage = Properties.Resources.marble_red_32_s; button61.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button61.BackgroundImage = Properties.Resources.marble_red_32; button61.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button61.BackgroundImage = Properties.Resources.marble_yellow_32_s; button61.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button61.BackgroundImage = Properties.Resources.marble_yellow_32; button61.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button61_Enter(sender, e);
    }

    private void button61_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button61.AccessibleName + COLON + SPACE;
      switch (button61.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button61_MouseEnter(object sender, EventArgs e)
    {
      button61_Enter(sender, e);
    }

    private void button61_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button61_MouseLeave(object sender, EventArgs e)
    {
      button61_Leave(sender, e);
    }

    private void button62_Click(object sender, EventArgs e)
    {
      switch (button62.Tag.ToString())
      {
        case MARBLE_BLUE_32: button62.BackgroundImage = Properties.Resources.marble_blue_32_s; button62.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button62.BackgroundImage = Properties.Resources.marble_blue_32; button62.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button62.BackgroundImage = Properties.Resources.marble_green_32_s; button62.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button62.BackgroundImage = Properties.Resources.marble_green_32; button62.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button62.BackgroundImage = Properties.Resources.marble_red_32_s; button62.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button62.BackgroundImage = Properties.Resources.marble_red_32; button62.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button62.BackgroundImage = Properties.Resources.marble_yellow_32_s; button62.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button62.BackgroundImage = Properties.Resources.marble_yellow_32; button62.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button62_Enter(sender, e);
    }

    private void button62_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button62.AccessibleName + COLON + SPACE;
      switch (button62.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button62_MouseEnter(object sender, EventArgs e)
    {
      button62_Enter(sender, e);
    }

    private void button62_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button62_MouseLeave(object sender, EventArgs e)
    {
      button62_Leave(sender, e);
    }

    private void button63_Click(object sender, EventArgs e)
    {
      switch (button63.Tag.ToString())
      {
        case MARBLE_BLUE_32: button63.BackgroundImage = Properties.Resources.marble_blue_32_s; button63.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button63.BackgroundImage = Properties.Resources.marble_blue_32; button63.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button63.BackgroundImage = Properties.Resources.marble_green_32_s; button63.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button63.BackgroundImage = Properties.Resources.marble_green_32; button63.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button63.BackgroundImage = Properties.Resources.marble_red_32_s; button63.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button63.BackgroundImage = Properties.Resources.marble_red_32; button63.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button63.BackgroundImage = Properties.Resources.marble_yellow_32_s; button63.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button63.BackgroundImage = Properties.Resources.marble_yellow_32; button63.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button63_Enter(sender, e);
    }

    private void button63_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button63.AccessibleName + COLON + SPACE;
      switch (button63.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button63_MouseEnter(object sender, EventArgs e)
    {
      button63_Enter(sender, e);
    }

    private void button63_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button63_MouseLeave(object sender, EventArgs e)
    {
      button63_Leave(sender, e);
    }

    private void button64_Click(object sender, EventArgs e)
    {
      switch (button64.Tag.ToString())
      {
        case MARBLE_BLUE_32: button64.BackgroundImage = Properties.Resources.marble_blue_32_s; button64.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button64.BackgroundImage = Properties.Resources.marble_blue_32; button64.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button64.BackgroundImage = Properties.Resources.marble_green_32_s; button64.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button64.BackgroundImage = Properties.Resources.marble_green_32; button64.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button64.BackgroundImage = Properties.Resources.marble_red_32_s; button64.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button64.BackgroundImage = Properties.Resources.marble_red_32; button64.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button64.BackgroundImage = Properties.Resources.marble_yellow_32_s; button64.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button64.BackgroundImage = Properties.Resources.marble_yellow_32; button64.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button64_Enter(sender, e);
    }

    private void button64_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button64.AccessibleName + COLON + SPACE;
      switch (button64.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button64_MouseEnter(object sender, EventArgs e)
    {
      button64_Enter(sender, e);
    }

    private void button64_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button64_MouseLeave(object sender, EventArgs e)
    {
      button64_Leave(sender, e);
    }

    private void button65_Click(object sender, EventArgs e)
    {
      switch (button65.Tag.ToString())
      {
        case MARBLE_BLUE_32: button65.BackgroundImage = Properties.Resources.marble_blue_32_s; button65.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button65.BackgroundImage = Properties.Resources.marble_blue_32; button65.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button65.BackgroundImage = Properties.Resources.marble_green_32_s; button65.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button65.BackgroundImage = Properties.Resources.marble_green_32; button65.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button65.BackgroundImage = Properties.Resources.marble_red_32_s; button65.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button65.BackgroundImage = Properties.Resources.marble_red_32; button65.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button65.BackgroundImage = Properties.Resources.marble_yellow_32_s; button65.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button65.BackgroundImage = Properties.Resources.marble_yellow_32; button65.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button65_Enter(sender, e);
    }

    private void button65_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button65.AccessibleName + COLON + SPACE;
      switch (button65.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button65_MouseEnter(object sender, EventArgs e)
    {
      button65_Enter(sender, e);
    }

    private void button65_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button65_MouseLeave(object sender, EventArgs e)
    {
      button65_Leave(sender, e);
    }

    private void button66_Click(object sender, EventArgs e)
    {
      switch (button66.Tag.ToString())
      {
        case MARBLE_BLUE_32: button66.BackgroundImage = Properties.Resources.marble_blue_32_s; button66.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button66.BackgroundImage = Properties.Resources.marble_blue_32; button66.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button66.BackgroundImage = Properties.Resources.marble_green_32_s; button66.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button66.BackgroundImage = Properties.Resources.marble_green_32; button66.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button66.BackgroundImage = Properties.Resources.marble_red_32_s; button66.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button66.BackgroundImage = Properties.Resources.marble_red_32; button66.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button66.BackgroundImage = Properties.Resources.marble_yellow_32_s; button66.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button66.BackgroundImage = Properties.Resources.marble_yellow_32; button66.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button66_Enter(sender, e);
    }

    private void button66_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button66.AccessibleName + COLON + SPACE;
      switch (button66.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button66_MouseEnter(object sender, EventArgs e)
    {
      button66_Enter(sender, e);
    }

    private void button66_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button66_MouseLeave(object sender, EventArgs e)
    {
      button66_Leave(sender, e);
    }

    private void button67_Click(object sender, EventArgs e)
    {
      switch (button67.Tag.ToString())
      {
        case MARBLE_BLUE_32: button67.BackgroundImage = Properties.Resources.marble_blue_32_s; button67.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button67.BackgroundImage = Properties.Resources.marble_blue_32; button67.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button67.BackgroundImage = Properties.Resources.marble_green_32_s; button67.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button67.BackgroundImage = Properties.Resources.marble_green_32; button67.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button67.BackgroundImage = Properties.Resources.marble_red_32_s; button67.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button67.BackgroundImage = Properties.Resources.marble_red_32; button67.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button67.BackgroundImage = Properties.Resources.marble_yellow_32_s; button67.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button67.BackgroundImage = Properties.Resources.marble_yellow_32; button67.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button67_Enter(sender, e);
    }

    private void button67_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button67.AccessibleName + COLON + SPACE;
      switch (button67.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button67_MouseEnter(object sender, EventArgs e)
    {
      button67_Enter(sender, e);
    }

    private void button67_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button67_MouseLeave(object sender, EventArgs e)
    {
      button67_Leave(sender, e);
    }

    private void button68_Click(object sender, EventArgs e)
    {
      switch (button68.Tag.ToString())
      {
        case MARBLE_BLUE_32: button68.BackgroundImage = Properties.Resources.marble_blue_32_s; button68.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button68.BackgroundImage = Properties.Resources.marble_blue_32; button68.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button68.BackgroundImage = Properties.Resources.marble_green_32_s; button68.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button68.BackgroundImage = Properties.Resources.marble_green_32; button68.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button68.BackgroundImage = Properties.Resources.marble_red_32_s; button68.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button68.BackgroundImage = Properties.Resources.marble_red_32; button68.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button68.BackgroundImage = Properties.Resources.marble_yellow_32_s; button68.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button68.BackgroundImage = Properties.Resources.marble_yellow_32; button68.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button68_Enter(sender, e);
    }

    private void button68_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button68.AccessibleName + COLON + SPACE;
      switch (button68.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button68_MouseEnter(object sender, EventArgs e)
    {
      button68_Enter(sender, e);
    }

    private void button68_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button68_MouseLeave(object sender, EventArgs e)
    {
      button68_Leave(sender, e);
    }

    private void button69_Click(object sender, EventArgs e)
    {
      switch (button69.Tag.ToString())
      {
        case MARBLE_BLUE_32: button69.BackgroundImage = Properties.Resources.marble_blue_32_s; button69.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button69.BackgroundImage = Properties.Resources.marble_blue_32; button69.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button69.BackgroundImage = Properties.Resources.marble_green_32_s; button69.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button69.BackgroundImage = Properties.Resources.marble_green_32; button69.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button69.BackgroundImage = Properties.Resources.marble_red_32_s; button69.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button69.BackgroundImage = Properties.Resources.marble_red_32; button69.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button69.BackgroundImage = Properties.Resources.marble_yellow_32_s; button69.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button69.BackgroundImage = Properties.Resources.marble_yellow_32; button69.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button69_Enter(sender, e);
    }

    private void button69_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button69.AccessibleName + COLON + SPACE;
      switch (button69.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button69_MouseEnter(object sender, EventArgs e)
    {
      button69_Enter(sender, e);
    }

    private void button69_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button69_MouseLeave(object sender, EventArgs e)
    {
      button69_Leave(sender, e);
    }

    private void button70_Click(object sender, EventArgs e)
    {
      switch (button70.Tag.ToString())
      {
        case MARBLE_BLUE_32: button70.BackgroundImage = Properties.Resources.marble_blue_32_s; button70.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button70.BackgroundImage = Properties.Resources.marble_blue_32; button70.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button70.BackgroundImage = Properties.Resources.marble_green_32_s; button70.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button70.BackgroundImage = Properties.Resources.marble_green_32; button70.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button70.BackgroundImage = Properties.Resources.marble_red_32_s; button70.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button70.BackgroundImage = Properties.Resources.marble_red_32; button70.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button70.BackgroundImage = Properties.Resources.marble_yellow_32_s; button70.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button70.BackgroundImage = Properties.Resources.marble_yellow_32; button70.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button70_Enter(sender, e);
    }

    private void button70_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button70.AccessibleName + COLON + SPACE;
      switch (button70.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button70_MouseEnter(object sender, EventArgs e)
    {
      button70_Enter(sender, e);
    }

    private void button70_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button70_MouseLeave(object sender, EventArgs e)
    {
      button70_Leave(sender, e);
    }

    private void button71_Click(object sender, EventArgs e)
    {
      switch (button71.Tag.ToString())
      {
        case MARBLE_BLUE_32: button71.BackgroundImage = Properties.Resources.marble_blue_32_s; button71.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button71.BackgroundImage = Properties.Resources.marble_blue_32; button71.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button71.BackgroundImage = Properties.Resources.marble_green_32_s; button71.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button71.BackgroundImage = Properties.Resources.marble_green_32; button71.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button71.BackgroundImage = Properties.Resources.marble_red_32_s; button71.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button71.BackgroundImage = Properties.Resources.marble_red_32; button71.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button71.BackgroundImage = Properties.Resources.marble_yellow_32_s; button71.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button71.BackgroundImage = Properties.Resources.marble_yellow_32; button71.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button71_Enter(sender, e);
    }

    private void button71_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button71.AccessibleName + COLON + SPACE;
      switch (button71.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button71_MouseEnter(object sender, EventArgs e)
    {
      button71_Enter(sender, e);
    }

    private void button71_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button71_MouseLeave(object sender, EventArgs e)
    {
      button71_Leave(sender, e);
    }

    private void button72_Click(object sender, EventArgs e)
    {
      switch (button72.Tag.ToString())
      {
        case MARBLE_BLUE_32: button72.BackgroundImage = Properties.Resources.marble_blue_32_s; button72.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button72.BackgroundImage = Properties.Resources.marble_blue_32; button72.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button72.BackgroundImage = Properties.Resources.marble_green_32_s; button72.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button72.BackgroundImage = Properties.Resources.marble_green_32; button72.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button72.BackgroundImage = Properties.Resources.marble_red_32_s; button72.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button72.BackgroundImage = Properties.Resources.marble_red_32; button72.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button72.BackgroundImage = Properties.Resources.marble_yellow_32_s; button72.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button72.BackgroundImage = Properties.Resources.marble_yellow_32; button72.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button72_Enter(sender, e);
    }

    private void button72_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button72.AccessibleName + COLON + SPACE;
      switch (button72.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button72_MouseEnter(object sender, EventArgs e)
    {
      button72_Enter(sender, e);
    }

    private void button72_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button72_MouseLeave(object sender, EventArgs e)
    {
      button72_Leave(sender, e);
    }

    private void button73_Click(object sender, EventArgs e)
    {
      switch (button73.Tag.ToString())
      {
        case MARBLE_BLUE_32: button73.BackgroundImage = Properties.Resources.marble_blue_32_s; button73.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button73.BackgroundImage = Properties.Resources.marble_blue_32; button73.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button73.BackgroundImage = Properties.Resources.marble_green_32_s; button73.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button73.BackgroundImage = Properties.Resources.marble_green_32; button73.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button73.BackgroundImage = Properties.Resources.marble_red_32_s; button73.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button73.BackgroundImage = Properties.Resources.marble_red_32; button73.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button73.BackgroundImage = Properties.Resources.marble_yellow_32_s; button73.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button73.BackgroundImage = Properties.Resources.marble_yellow_32; button73.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button73_Enter(sender, e);
    }

    private void button73_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button73.AccessibleName + COLON + SPACE;
      switch (button73.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button73_MouseEnter(object sender, EventArgs e)
    {
      button73_Enter(sender, e);
    }

    private void button73_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button73_MouseLeave(object sender, EventArgs e)
    {
      button73_Leave(sender, e);
    }

    private void button74_Click(object sender, EventArgs e)
    {
      switch (button74.Tag.ToString())
      {
        case MARBLE_BLUE_32: button74.BackgroundImage = Properties.Resources.marble_blue_32_s; button74.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button74.BackgroundImage = Properties.Resources.marble_blue_32; button74.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button74.BackgroundImage = Properties.Resources.marble_green_32_s; button74.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button74.BackgroundImage = Properties.Resources.marble_green_32; button74.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button74.BackgroundImage = Properties.Resources.marble_red_32_s; button74.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button74.BackgroundImage = Properties.Resources.marble_red_32; button74.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button74.BackgroundImage = Properties.Resources.marble_yellow_32_s; button74.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button74.BackgroundImage = Properties.Resources.marble_yellow_32; button74.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button74_Enter(sender, e);
    }

    private void button74_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button74.AccessibleName + COLON + SPACE;
      switch (button74.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button74_MouseEnter(object sender, EventArgs e)
    {
      button74_Enter(sender, e);
    }

    private void button74_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button74_MouseLeave(object sender, EventArgs e)
    {
      button74_Leave(sender, e);
    }

    private void button75_Click(object sender, EventArgs e)
    {
      switch (button75.Tag.ToString())
      {
        case MARBLE_BLUE_32: button75.BackgroundImage = Properties.Resources.marble_blue_32_s; button75.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button75.BackgroundImage = Properties.Resources.marble_blue_32; button75.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button75.BackgroundImage = Properties.Resources.marble_green_32_s; button75.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button75.BackgroundImage = Properties.Resources.marble_green_32; button75.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button75.BackgroundImage = Properties.Resources.marble_red_32_s; button75.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button75.BackgroundImage = Properties.Resources.marble_red_32; button75.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button75.BackgroundImage = Properties.Resources.marble_yellow_32_s; button75.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button75.BackgroundImage = Properties.Resources.marble_yellow_32; button75.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button75_Enter(sender, e);
    }

    private void button75_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button75.AccessibleName + COLON + SPACE;
      switch (button75.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button75_MouseEnter(object sender, EventArgs e)
    {
      button75_Enter(sender, e);
    }

    private void button75_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button75_MouseLeave(object sender, EventArgs e)
    {
      button75_Leave(sender, e);
    }

    private void button76_Click(object sender, EventArgs e)
    {
      switch (button76.Tag.ToString())
      {
        case MARBLE_BLUE_32: button76.BackgroundImage = Properties.Resources.marble_blue_32_s; button76.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button76.BackgroundImage = Properties.Resources.marble_blue_32; button76.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button76.BackgroundImage = Properties.Resources.marble_green_32_s; button76.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button76.BackgroundImage = Properties.Resources.marble_green_32; button76.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button76.BackgroundImage = Properties.Resources.marble_red_32_s; button76.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button76.BackgroundImage = Properties.Resources.marble_red_32; button76.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button76.BackgroundImage = Properties.Resources.marble_yellow_32_s; button76.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button76.BackgroundImage = Properties.Resources.marble_yellow_32; button76.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button76_Enter(sender, e);
    }

    private void button76_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button76.AccessibleName + COLON + SPACE;
      switch (button76.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button76_MouseEnter(object sender, EventArgs e)
    {
      button76_Enter(sender, e);
    }

    private void button76_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button76_MouseLeave(object sender, EventArgs e)
    {
      button76_Leave(sender, e);
    }

    private void button77_Click(object sender, EventArgs e)
    {
      switch (button77.Tag.ToString())
      {
        case MARBLE_BLUE_32: button77.BackgroundImage = Properties.Resources.marble_blue_32_s; button77.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button77.BackgroundImage = Properties.Resources.marble_blue_32; button77.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button77.BackgroundImage = Properties.Resources.marble_green_32_s; button77.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button77.BackgroundImage = Properties.Resources.marble_green_32; button77.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button77.BackgroundImage = Properties.Resources.marble_red_32_s; button77.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button77.BackgroundImage = Properties.Resources.marble_red_32; button77.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button77.BackgroundImage = Properties.Resources.marble_yellow_32_s; button77.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button77.BackgroundImage = Properties.Resources.marble_yellow_32; button77.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button77_Enter(sender, e);
    }

    private void button77_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button77.AccessibleName + COLON + SPACE;
      switch (button77.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button77_MouseEnter(object sender, EventArgs e)
    {
      button77_Enter(sender, e);
    }

    private void button77_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button77_MouseLeave(object sender, EventArgs e)
    {
      button77_Leave(sender, e);
    }

    private void button78_Click(object sender, EventArgs e)
    {
      switch (button78.Tag.ToString())
      {
        case MARBLE_BLUE_32: button78.BackgroundImage = Properties.Resources.marble_blue_32_s; button78.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button78.BackgroundImage = Properties.Resources.marble_blue_32; button78.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button78.BackgroundImage = Properties.Resources.marble_green_32_s; button78.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button78.BackgroundImage = Properties.Resources.marble_green_32; button78.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button78.BackgroundImage = Properties.Resources.marble_red_32_s; button78.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button78.BackgroundImage = Properties.Resources.marble_red_32; button78.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button78.BackgroundImage = Properties.Resources.marble_yellow_32_s; button78.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button78.BackgroundImage = Properties.Resources.marble_yellow_32; button78.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button78_Enter(sender, e);
    }

    private void button78_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button78.AccessibleName + COLON + SPACE;
      switch (button78.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button78_MouseEnter(object sender, EventArgs e)
    {
      button78_Enter(sender, e);
    }

    private void button78_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button78_MouseLeave(object sender, EventArgs e)
    {
      button78_Leave(sender, e);
    }

    private void button79_Click(object sender, EventArgs e)
    {
      switch (button79.Tag.ToString())
      {
        case MARBLE_BLUE_32: button79.BackgroundImage = Properties.Resources.marble_blue_32_s; button79.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button79.BackgroundImage = Properties.Resources.marble_blue_32; button79.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button79.BackgroundImage = Properties.Resources.marble_green_32_s; button79.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button79.BackgroundImage = Properties.Resources.marble_green_32; button79.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button79.BackgroundImage = Properties.Resources.marble_red_32_s; button79.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button79.BackgroundImage = Properties.Resources.marble_red_32; button79.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button79.BackgroundImage = Properties.Resources.marble_yellow_32_s; button79.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button79.BackgroundImage = Properties.Resources.marble_yellow_32; button79.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button79_Enter(sender, e);
    }

    private void button79_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button79.AccessibleName + COLON + SPACE;
      switch (button79.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button79_MouseEnter(object sender, EventArgs e)
    {
      button79_Enter(sender, e);
    }

    private void button79_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button79_MouseLeave(object sender, EventArgs e)
    {
      button79_Leave(sender, e);
    }

    private void button80_Click(object sender, EventArgs e)
    {
      switch (button80.Tag.ToString())
      {
        case MARBLE_BLUE_32: button80.BackgroundImage = Properties.Resources.marble_blue_32_s; button80.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button80.BackgroundImage = Properties.Resources.marble_blue_32; button80.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button80.BackgroundImage = Properties.Resources.marble_green_32_s; button80.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button80.BackgroundImage = Properties.Resources.marble_green_32; button80.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button80.BackgroundImage = Properties.Resources.marble_red_32_s; button80.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button80.BackgroundImage = Properties.Resources.marble_red_32; button80.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button80.BackgroundImage = Properties.Resources.marble_yellow_32_s; button80.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button80.BackgroundImage = Properties.Resources.marble_yellow_32; button80.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button8_Enter(sender, e);
    }

    private void button80_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button80.AccessibleName + COLON + SPACE;
      switch (button80.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button80_MouseEnter(object sender, EventArgs e)
    {
      button80_Enter(sender, e);
    }

    private void button80_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button80_MouseLeave(object sender, EventArgs e)
    {
      button80_Leave(sender, e);
    }

    private void button81_Click(object sender, EventArgs e)
    {
      switch (button81.Tag.ToString())
      {
        case MARBLE_BLUE_32: button81.BackgroundImage = Properties.Resources.marble_blue_32_s; button81.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button81.BackgroundImage = Properties.Resources.marble_blue_32; button81.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button81.BackgroundImage = Properties.Resources.marble_green_32_s; button81.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button81.BackgroundImage = Properties.Resources.marble_green_32; button81.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button81.BackgroundImage = Properties.Resources.marble_red_32_s; button81.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button81.BackgroundImage = Properties.Resources.marble_red_32; button81.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button81.BackgroundImage = Properties.Resources.marble_yellow_32_s; button81.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button81.BackgroundImage = Properties.Resources.marble_yellow_32; button81.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button81_Enter(sender, e);
    }

    private void button81_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button81.AccessibleName + COLON + SPACE;
      switch (button81.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button81_MouseEnter(object sender, EventArgs e)
    {
      button81_Enter(sender, e);
    }

    private void button81_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button81_MouseLeave(object sender, EventArgs e)
    {
      button81_Leave(sender, e);
    }

    private void button82_Click(object sender, EventArgs e)
    {
      switch (button82.Tag.ToString())
      {
        case MARBLE_BLUE_32: button82.BackgroundImage = Properties.Resources.marble_blue_32_s; button82.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button82.BackgroundImage = Properties.Resources.marble_blue_32; button82.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button82.BackgroundImage = Properties.Resources.marble_green_32_s; button82.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button82.BackgroundImage = Properties.Resources.marble_green_32; button82.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button82.BackgroundImage = Properties.Resources.marble_red_32_s; button82.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button82.BackgroundImage = Properties.Resources.marble_red_32; button82.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button82.BackgroundImage = Properties.Resources.marble_yellow_32_s; button82.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button82.BackgroundImage = Properties.Resources.marble_yellow_32; button82.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button82_Enter(sender, e);
    }

    private void button82_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button82.AccessibleName + COLON + SPACE;
      switch (button82.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button82_MouseEnter(object sender, EventArgs e)
    {
      button82_Enter(sender, e);
    }

    private void button82_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button82_MouseLeave(object sender, EventArgs e)
    {
      button82_Leave(sender, e);
    }

    private void button83_Click(object sender, EventArgs e)
    {
      switch (button83.Tag.ToString())
      {
        case MARBLE_BLUE_32: button83.BackgroundImage = Properties.Resources.marble_blue_32_s; button83.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button83.BackgroundImage = Properties.Resources.marble_blue_32; button83.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button83.BackgroundImage = Properties.Resources.marble_green_32_s; button83.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button83.BackgroundImage = Properties.Resources.marble_green_32; button83.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button83.BackgroundImage = Properties.Resources.marble_red_32_s; button83.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button83.BackgroundImage = Properties.Resources.marble_red_32; button83.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button83.BackgroundImage = Properties.Resources.marble_yellow_32_s; button83.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button83.BackgroundImage = Properties.Resources.marble_yellow_32; button83.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button83_Enter(sender, e);
    }

    private void button83_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button83.AccessibleName + COLON + SPACE;
      switch (button83.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button83_MouseEnter(object sender, EventArgs e)
    {
      button83_Enter(sender, e);
    }

    private void button83_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button83_MouseLeave(object sender, EventArgs e)
    {
      button83_Leave(sender, e);
    }

    private void button84_Click(object sender, EventArgs e)
    {
      switch (button84.Tag.ToString())
      {
        case MARBLE_BLUE_32: button84.BackgroundImage = Properties.Resources.marble_blue_32_s; button84.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button84.BackgroundImage = Properties.Resources.marble_blue_32; button84.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button84.BackgroundImage = Properties.Resources.marble_green_32_s; button84.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button84.BackgroundImage = Properties.Resources.marble_green_32; button84.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button84.BackgroundImage = Properties.Resources.marble_red_32_s; button84.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button84.BackgroundImage = Properties.Resources.marble_red_32; button84.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button84.BackgroundImage = Properties.Resources.marble_yellow_32_s; button84.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button84.BackgroundImage = Properties.Resources.marble_yellow_32; button84.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button84_Enter(sender, e);
    }

    private void button84_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button84.AccessibleName + COLON + SPACE;
      switch (button84.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button84_MouseEnter(object sender, EventArgs e)
    {
      button84_Enter(sender, e);
    }

    private void button84_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button84_MouseLeave(object sender, EventArgs e)
    {
      button84_Leave(sender, e);
    }

    private void button85_Click(object sender, EventArgs e)
    {
      switch (button85.Tag.ToString())
      {
        case MARBLE_BLUE_32: button85.BackgroundImage = Properties.Resources.marble_blue_32_s; button85.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button85.BackgroundImage = Properties.Resources.marble_blue_32; button85.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button85.BackgroundImage = Properties.Resources.marble_green_32_s; button85.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button85.BackgroundImage = Properties.Resources.marble_green_32; button85.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button85.BackgroundImage = Properties.Resources.marble_red_32_s; button85.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button85.BackgroundImage = Properties.Resources.marble_red_32; button85.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button85.BackgroundImage = Properties.Resources.marble_yellow_32_s; button85.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button85.BackgroundImage = Properties.Resources.marble_yellow_32; button85.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button85_Enter(sender, e);
    }

    private void button85_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button85.AccessibleName + COLON + SPACE;
      switch (button85.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button85_MouseEnter(object sender, EventArgs e)
    {
      button85_Enter(sender, e);
    }

    private void button85_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button85_MouseLeave(object sender, EventArgs e)
    {
      button85_Leave(sender, e);
    }

    private void button86_Click(object sender, EventArgs e)
    {
      switch (button86.Tag.ToString())
      {
        case MARBLE_BLUE_32: button86.BackgroundImage = Properties.Resources.marble_blue_32_s; button86.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button86.BackgroundImage = Properties.Resources.marble_blue_32; button86.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button86.BackgroundImage = Properties.Resources.marble_green_32_s; button86.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button86.BackgroundImage = Properties.Resources.marble_green_32; button86.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button86.BackgroundImage = Properties.Resources.marble_red_32_s; button86.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button86.BackgroundImage = Properties.Resources.marble_red_32; button86.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button86.BackgroundImage = Properties.Resources.marble_yellow_32_s; button86.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button86.BackgroundImage = Properties.Resources.marble_yellow_32; button86.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button86_Enter(sender, e);
    }

    private void button86_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button86.AccessibleName + COLON + SPACE;
      switch (button86.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button86_MouseEnter(object sender, EventArgs e)
    {
      button86_Enter(sender, e);
    }

    private void button86_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button86_MouseLeave(object sender, EventArgs e)
    {
      button86_Leave(sender, e);
    }

    private void button87_Click(object sender, EventArgs e)
    {
      switch (button87.Tag.ToString())
      {
        case MARBLE_BLUE_32: button87.BackgroundImage = Properties.Resources.marble_blue_32_s; button87.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button87.BackgroundImage = Properties.Resources.marble_blue_32; button87.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button87.BackgroundImage = Properties.Resources.marble_green_32_s; button87.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button87.BackgroundImage = Properties.Resources.marble_green_32; button87.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button87.BackgroundImage = Properties.Resources.marble_red_32_s; button87.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button87.BackgroundImage = Properties.Resources.marble_red_32; button87.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button87.BackgroundImage = Properties.Resources.marble_yellow_32_s; button87.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button87.BackgroundImage = Properties.Resources.marble_yellow_32; button87.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button87_Enter(sender, e);
    }

    private void button87_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button87.AccessibleName + COLON + SPACE;
      switch (button87.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button87_MouseEnter(object sender, EventArgs e)
    {
      button87_Enter(sender, e);
    }

    private void button87_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button87_MouseLeave(object sender, EventArgs e)
    {
      button87_Leave(sender, e);
    }

    private void button88_Click(object sender, EventArgs e)
    {
      switch (button88.Tag.ToString())
      {
        case MARBLE_BLUE_32: button88.BackgroundImage = Properties.Resources.marble_blue_32_s; button88.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button88.BackgroundImage = Properties.Resources.marble_blue_32; button88.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button88.BackgroundImage = Properties.Resources.marble_green_32_s; button88.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button88.BackgroundImage = Properties.Resources.marble_green_32; button88.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button88.BackgroundImage = Properties.Resources.marble_red_32_s; button88.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button88.BackgroundImage = Properties.Resources.marble_red_32; button88.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button88.BackgroundImage = Properties.Resources.marble_yellow_32_s; button88.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button88.BackgroundImage = Properties.Resources.marble_yellow_32; button88.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button88_Enter(sender, e);
    }

    private void button88_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button88.AccessibleName + COLON + SPACE;
      switch (button88.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button88_MouseEnter(object sender, EventArgs e)
    {
      button88_Enter(sender, e);
    }

    private void button88_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button88_MouseLeave(object sender, EventArgs e)
    {
      button88_Leave(sender, e);
    }

    private void button89_Click(object sender, EventArgs e)
    {
      switch (button89.Tag.ToString())
      {
        case MARBLE_BLUE_32: button89.BackgroundImage = Properties.Resources.marble_blue_32_s; button89.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button89.BackgroundImage = Properties.Resources.marble_blue_32; button89.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button89.BackgroundImage = Properties.Resources.marble_green_32_s; button89.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button89.BackgroundImage = Properties.Resources.marble_green_32; button89.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button89.BackgroundImage = Properties.Resources.marble_red_32_s; button89.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button89.BackgroundImage = Properties.Resources.marble_red_32; button89.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button89.BackgroundImage = Properties.Resources.marble_yellow_32_s; button89.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button89.BackgroundImage = Properties.Resources.marble_yellow_32; button89.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button89_Enter(sender, e);
    }

    private void button89_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button89.AccessibleName + COLON + SPACE;
      switch (button89.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button89_MouseEnter(object sender, EventArgs e)
    {
      button89_Enter(sender, e);
    }

    private void button89_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button89_MouseLeave(object sender, EventArgs e)
    {
      button89_Leave(sender, e);
    }

    private void button90_Click(object sender, EventArgs e)
    {
      switch (button90.Tag.ToString())
      {
        case MARBLE_BLUE_32: button90.BackgroundImage = Properties.Resources.marble_blue_32_s; button90.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button90.BackgroundImage = Properties.Resources.marble_blue_32; button90.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button90.BackgroundImage = Properties.Resources.marble_green_32_s; button90.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button90.BackgroundImage = Properties.Resources.marble_green_32; button90.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button90.BackgroundImage = Properties.Resources.marble_red_32_s; button90.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button90.BackgroundImage = Properties.Resources.marble_red_32; button90.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button90.BackgroundImage = Properties.Resources.marble_yellow_32_s; button90.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button90.BackgroundImage = Properties.Resources.marble_yellow_32; button90.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button90_Enter(sender, e);
    }

    private void button90_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button90.AccessibleName + COLON + SPACE;
      switch (button90.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button90_MouseEnter(object sender, EventArgs e)
    {
      button90_Enter(sender, e);
    }

    private void button90_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button90_MouseLeave(object sender, EventArgs e)
    {
      button90_Leave(sender, e);
    }

    private void button91_Click(object sender, EventArgs e)
    {
      switch (button91.Tag.ToString())
      {
        case MARBLE_BLUE_32: button91.BackgroundImage = Properties.Resources.marble_blue_32_s; button91.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button91.BackgroundImage = Properties.Resources.marble_blue_32; button91.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button91.BackgroundImage = Properties.Resources.marble_green_32_s; button91.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button91.BackgroundImage = Properties.Resources.marble_green_32; button91.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button91.BackgroundImage = Properties.Resources.marble_red_32_s; button91.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button91.BackgroundImage = Properties.Resources.marble_red_32; button91.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button91.BackgroundImage = Properties.Resources.marble_yellow_32_s; button91.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button91.BackgroundImage = Properties.Resources.marble_yellow_32; button91.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button91_Enter(sender, e);
    }

    private void button91_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button91.AccessibleName + COLON + SPACE;
      switch (button91.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button91_MouseEnter(object sender, EventArgs e)
    {
      button91_Enter(sender, e);
    }

    private void button91_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button91_MouseLeave(object sender, EventArgs e)
    {
      button91_Leave(sender, e);
    }

    private void button92_Click(object sender, EventArgs e)
    {
      switch (button92.Tag.ToString())
      {
        case MARBLE_BLUE_32: button92.BackgroundImage = Properties.Resources.marble_blue_32_s; button92.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button92.BackgroundImage = Properties.Resources.marble_blue_32; button92.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button92.BackgroundImage = Properties.Resources.marble_green_32_s; button92.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button92.BackgroundImage = Properties.Resources.marble_green_32; button92.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button92.BackgroundImage = Properties.Resources.marble_red_32_s; button92.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button92.BackgroundImage = Properties.Resources.marble_red_32; button92.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button92.BackgroundImage = Properties.Resources.marble_yellow_32_s; button92.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button92.BackgroundImage = Properties.Resources.marble_yellow_32; button92.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button92_Enter(sender, e);
    }

    private void button92_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button92.AccessibleName + COLON + SPACE;
      switch (button92.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button92_MouseEnter(object sender, EventArgs e)
    {
      button92_Enter(sender, e);
    }

    private void button92_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button92_MouseLeave(object sender, EventArgs e)
    {
      button92_Leave(sender, e);
    }

    private void button93_Click(object sender, EventArgs e)
    {
      switch (button93.Tag.ToString())
      {
        case MARBLE_BLUE_32: button93.BackgroundImage = Properties.Resources.marble_blue_32_s; button93.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button93.BackgroundImage = Properties.Resources.marble_blue_32; button93.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button93.BackgroundImage = Properties.Resources.marble_green_32_s; button93.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button93.BackgroundImage = Properties.Resources.marble_green_32; button93.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button93.BackgroundImage = Properties.Resources.marble_red_32_s; button93.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button93.BackgroundImage = Properties.Resources.marble_red_32; button93.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button93.BackgroundImage = Properties.Resources.marble_yellow_32_s; button93.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button93.BackgroundImage = Properties.Resources.marble_yellow_32; button93.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button93_Enter(sender, e);
    }

    private void button93_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button93.AccessibleName + COLON + SPACE;
      switch (button93.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button93_MouseEnter(object sender, EventArgs e)
    {
      button93_Enter(sender, e);
    }

    private void button93_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button93_MouseLeave(object sender, EventArgs e)
    {
      button93_Leave(sender, e);
    }

    private void button94_Click(object sender, EventArgs e)
    {
      switch (button94.Tag.ToString())
      {
        case MARBLE_BLUE_32: button94.BackgroundImage = Properties.Resources.marble_blue_32_s; button94.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button94.BackgroundImage = Properties.Resources.marble_blue_32; button94.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button94.BackgroundImage = Properties.Resources.marble_green_32_s; button94.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button94.BackgroundImage = Properties.Resources.marble_green_32; button94.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button94.BackgroundImage = Properties.Resources.marble_red_32_s; button94.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button94.BackgroundImage = Properties.Resources.marble_red_32; button94.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button94.BackgroundImage = Properties.Resources.marble_yellow_32_s; button94.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button94.BackgroundImage = Properties.Resources.marble_yellow_32; button94.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button94_Enter(sender, e);
    }

    private void button94_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button94.AccessibleName + COLON + SPACE;
      switch (button94.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button94_MouseEnter(object sender, EventArgs e)
    {
      button94_Enter(sender, e);
    }

    private void button94_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button94_MouseLeave(object sender, EventArgs e)
    {
      button94_Leave(sender, e);
    }

    private void button95_Click(object sender, EventArgs e)
    {
      switch (button95.Tag.ToString())
      {
        case MARBLE_BLUE_32: button95.BackgroundImage = Properties.Resources.marble_blue_32_s; button95.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button95.BackgroundImage = Properties.Resources.marble_blue_32; button95.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button95.BackgroundImage = Properties.Resources.marble_green_32_s; button95.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button95.BackgroundImage = Properties.Resources.marble_green_32; button95.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button95.BackgroundImage = Properties.Resources.marble_red_32_s; button95.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button95.BackgroundImage = Properties.Resources.marble_red_32; button95.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button95.BackgroundImage = Properties.Resources.marble_yellow_32_s; button95.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button95.BackgroundImage = Properties.Resources.marble_yellow_32; button95.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button95_Enter(sender, e);
    }

    private void button95_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button95.AccessibleName + COLON + SPACE;
      switch (button95.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button95_MouseEnter(object sender, EventArgs e)
    {
      button95_Enter(sender, e);
    }

    private void button95_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button95_MouseLeave(object sender, EventArgs e)
    {
      button95_Leave(sender, e);
    }

    private void button96_Click(object sender, EventArgs e)
    {
      switch (button96.Tag.ToString())
      {
        case MARBLE_BLUE_32: button96.BackgroundImage = Properties.Resources.marble_blue_32_s; button96.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button96.BackgroundImage = Properties.Resources.marble_blue_32; button96.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button96.BackgroundImage = Properties.Resources.marble_green_32_s; button96.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button96.BackgroundImage = Properties.Resources.marble_green_32; button96.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button96.BackgroundImage = Properties.Resources.marble_red_32_s; button96.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button96.BackgroundImage = Properties.Resources.marble_red_32; button96.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button96.BackgroundImage = Properties.Resources.marble_yellow_32_s; button96.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button96.BackgroundImage = Properties.Resources.marble_yellow_32; button96.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button96_Enter(sender, e);
    }

    private void button96_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button96.AccessibleName + COLON + SPACE;
      switch (button96.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button96_MouseEnter(object sender, EventArgs e)
    {
      button96_Enter(sender, e);
    }

    private void button96_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button96_MouseLeave(object sender, EventArgs e)
    {
      button96_Leave(sender, e);
    }

    private void button97_Click(object sender, EventArgs e)
    {
      switch (button97.Tag.ToString())
      {
        case MARBLE_BLUE_32: button97.BackgroundImage = Properties.Resources.marble_blue_32_s; button97.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button97.BackgroundImage = Properties.Resources.marble_blue_32; button97.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button97.BackgroundImage = Properties.Resources.marble_green_32_s; button97.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button97.BackgroundImage = Properties.Resources.marble_green_32; button97.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button97.BackgroundImage = Properties.Resources.marble_red_32_s; button97.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button97.BackgroundImage = Properties.Resources.marble_red_32; button97.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button97.BackgroundImage = Properties.Resources.marble_yellow_32_s; button97.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button97.BackgroundImage = Properties.Resources.marble_yellow_32; button97.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button97_Enter(sender, e);
    }

    private void button97_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button97.AccessibleName + COLON + SPACE;
      switch (button97.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button97_MouseEnter(object sender, EventArgs e)
    {
      button97_Enter(sender, e);
    }

    private void button97_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button97_MouseLeave(object sender, EventArgs e)
    {
      button97_Leave(sender, e);
    }

    private void button98_Click(object sender, EventArgs e)
    {
      switch (button98.Tag.ToString())
      {
        case MARBLE_BLUE_32: button98.BackgroundImage = Properties.Resources.marble_blue_32_s; button98.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button98.BackgroundImage = Properties.Resources.marble_blue_32; button98.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button98.BackgroundImage = Properties.Resources.marble_green_32_s; button98.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button98.BackgroundImage = Properties.Resources.marble_green_32; button98.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button98.BackgroundImage = Properties.Resources.marble_red_32_s; button98.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button98.BackgroundImage = Properties.Resources.marble_red_32; button98.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button98.BackgroundImage = Properties.Resources.marble_yellow_32_s; button98.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button98.BackgroundImage = Properties.Resources.marble_yellow_32; button98.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button98_Enter(sender, e);
    }

    private void button98_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button98.AccessibleName + COLON + SPACE;
      switch (button98.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button98_MouseEnter(object sender, EventArgs e)
    {
      button98_Enter(sender, e);
    }

    private void button98_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button98_MouseLeave(object sender, EventArgs e)
    {
      button98_Leave(sender, e);
    }

    private void button99_Click(object sender, EventArgs e)
    {
      switch (button99.Tag.ToString())
      {
        case MARBLE_BLUE_32: button99.BackgroundImage = Properties.Resources.marble_blue_32_s; button99.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button99.BackgroundImage = Properties.Resources.marble_blue_32; button99.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button99.BackgroundImage = Properties.Resources.marble_green_32_s; button99.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button99.BackgroundImage = Properties.Resources.marble_green_32; button99.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button99.BackgroundImage = Properties.Resources.marble_red_32_s; button99.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button99.BackgroundImage = Properties.Resources.marble_red_32; button99.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button99.BackgroundImage = Properties.Resources.marble_yellow_32_s; button99.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button99.BackgroundImage = Properties.Resources.marble_yellow_32; button99.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button99_Enter(sender, e);
    }

    private void button99_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button99.AccessibleName + COLON + SPACE;
      switch (button99.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button99_MouseEnter(object sender, EventArgs e)
    {
      button99_Enter(sender, e);
    }

    private void button99_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button99_MouseLeave(object sender, EventArgs e)
    {
      button99_Leave(sender, e);
    }

    private void button100_Click(object sender, EventArgs e)
    {
      switch (button100.Tag.ToString())
      {
        case MARBLE_BLUE_32: button100.BackgroundImage = Properties.Resources.marble_blue_32_s; button100.Tag = MARBLE_BLUE_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_BLUE_32_S: button100.BackgroundImage = Properties.Resources.marble_blue_32; button100.Tag = MARBLE_BLUE_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_GREEN_32: button100.BackgroundImage = Properties.Resources.marble_green_32_s; button100.Tag = MARBLE_GREEN_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_GREEN_32_S: button100.BackgroundImage = Properties.Resources.marble_green_32; button100.Tag = MARBLE_GREEN_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_RED_32: button100.BackgroundImage = Properties.Resources.marble_red_32_s; button100.Tag = MARBLE_RED_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_RED_32_S: button100.BackgroundImage = Properties.Resources.marble_red_32; button100.Tag = MARBLE_RED_32; if (isSoundEnabled) playSelectionCancelled(); break;
        case MARBLE_YELLOW_32: button100.BackgroundImage = Properties.Resources.marble_yellow_32_s; button100.Tag = MARBLE_YELLOW_32_S; if (isSoundEnabled) playMarbleClick(); break;
        case MARBLE_YELLOW_32_S: button100.BackgroundImage = Properties.Resources.marble_yellow_32; button100.Tag = MARBLE_YELLOW_32; if (isSoundEnabled) playSelectionCancelled(); break;
      }
      button100_Enter(sender, e);
    }

    private void button100_Enter(object sender, EventArgs e)
    {
      ButtonInformation = button100.AccessibleName + COLON + SPACE;
      switch (button100.Tag.ToString())
      {
        case MARBLE_BLUE_32: ButtonInformation = ButtonInformation + COLOR_BLUE; break;
        case MARBLE_BLUE_32_S: ButtonInformation = ButtonInformation + COLOR_BLUE + SPACE + LITUP; break;
        case MARBLE_GREEN_32: ButtonInformation = ButtonInformation + COLOR_GREEN; break;
        case MARBLE_GREEN_32_S: ButtonInformation = ButtonInformation + COLOR_GREEN + SPACE + LITUP; break;
        case MARBLE_RED_32: ButtonInformation = ButtonInformation + COLOR_RED; break;
        case MARBLE_RED_32_S: ButtonInformation = ButtonInformation + COLOR_RED + SPACE + LITUP; break;
        case MARBLE_YELLOW_32: ButtonInformation = ButtonInformation + COLOR_YELLOW; break;
        case MARBLE_YELLOW_32_S: ButtonInformation = ButtonInformation + COLOR_YELLOW + SPACE + LITUP; break;
      }
      setStatusbarInformationtext(ButtonInformation);
    }

    private void button100_MouseEnter(object sender, EventArgs e)
    {
      button100_Enter(sender, e);
    }

    private void button100_Leave(object sender, EventArgs e)
    {
      clearStatusbarInformationtext();
    }

    private void button100_MouseLeave(object sender, EventArgs e)
    {
      button100_Leave(sender, e);
    }

  }
}
