using System;
using System.Media;
using System.Windows.Forms;

namespace Juzzle
{
  public partial class JuzzleForm : Form
  {
    Boolean isSoundEnabled = true;
    Boolean isGamePaused = false;
    Random rnd = new Random();

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
        case 0: button1.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button1.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button1.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button1.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button2.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button2.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button2.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button2.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button3.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button3.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button3.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button3.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button4.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button4.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button4.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button4.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button5.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button5.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button5.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button5.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button6.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button6.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button6.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button6.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button7.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button7.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button7.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button7.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button8.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button8.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button8.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button8.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button9.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button9.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button9.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button9.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button10.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button10.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button10.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button10.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button11.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button11.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button11.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button11.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button12.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button12.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button12.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button12.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button13.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button13.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button13.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button13.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button14.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button14.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button14.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button14.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button15.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button15.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button15.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button15.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button16.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button16.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button16.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button16.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button17.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button17.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button17.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button17.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button18.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button18.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button18.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button18.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button19.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button19.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button19.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button19.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button20.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button20.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button20.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button20.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button21.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button21.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button21.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button21.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button22.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button22.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button22.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button22.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button23.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button23.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button23.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button23.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button24.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button24.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button24.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button24.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button25.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button25.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button25.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button25.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button26.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button26.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button26.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button26.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button27.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button27.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button27.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button27.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button28.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button28.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button28.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button28.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button29.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button29.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button29.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button29.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button30.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button30.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button30.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button30.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button31.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button31.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button31.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button31.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button32.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button32.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button32.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button32.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button33.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button33.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button33.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button33.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button34.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button34.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button34.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button34.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button35.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button35.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button35.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button35.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button36.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button36.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button36.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button36.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button37.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button37.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button37.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button37.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button38.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button38.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button38.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button38.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button39.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button39.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button39.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button39.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button40.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button40.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button40.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button40.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button41.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button41.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button41.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button41.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button42.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button42.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button42.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button42.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button43.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button43.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button43.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button43.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button44.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button44.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button44.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button44.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button45.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button45.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button45.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button45.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button46.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button46.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button46.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button46.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button47.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button47.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button47.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button47.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button48.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button48.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button48.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button48.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button49.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button49.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button49.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button49.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button50.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button50.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button50.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button50.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button51.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button51.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button51.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button51.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button52.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button52.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button52.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button52.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button53.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button53.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button53.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button53.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button54.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button54.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button54.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button54.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button55.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button55.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button55.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button55.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button56.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button56.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button56.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button56.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button57.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button57.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button57.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button57.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button58.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button58.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button58.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button58.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button59.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button59.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button59.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button59.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button60.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button60.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button60.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button60.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button61.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button61.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button61.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button61.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button62.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button62.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button62.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button62.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button63.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button63.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button63.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button63.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button64.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button64.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button64.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button64.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button65.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button65.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button65.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button65.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button66.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button66.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button66.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button66.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button67.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button67.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button67.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button67.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button68.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button68.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button68.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button68.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button69.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button69.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button69.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button69.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button70.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button70.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button70.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button70.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button71.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button71.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button71.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button71.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button72.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button72.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button72.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button72.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button73.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button73.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button73.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button73.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button74.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button74.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button74.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button74.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button75.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button75.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button75.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button75.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button76.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button76.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button76.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button76.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button77.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button77.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button77.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button77.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button78.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button78.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button78.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button78.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button79.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button79.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button79.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button79.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button80.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button80.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button80.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button80.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button81.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button81.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button81.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button81.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button82.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button82.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button82.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button82.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button83.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button83.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button83.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button83.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button84.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button84.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button84.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button84.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button85.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button85.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button85.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button85.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button86.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button86.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button86.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button86.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button87.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button87.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button87.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button87.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button88.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button88.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button88.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button88.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button89.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button89.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button89.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button89.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button90.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button90.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button90.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button90.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button91.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button91.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button91.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button91.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button92.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button92.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button92.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button92.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button93.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button93.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button93.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button93.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button94.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button94.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button94.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button94.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button95.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button95.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button95.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button95.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button96.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button96.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button96.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button96.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button97.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button97.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button97.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button97.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button98.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button98.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button98.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button98.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button99.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button99.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button99.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button99.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
      switch (rnd.Next(0, 4))
      {
        case 0: button100.BackgroundImage = global::Juzzle.Properties.Resources.marble_blue_32; break;
        case 1: button100.BackgroundImage = global::Juzzle.Properties.Resources.marble_green_32; break;
        case 2: button100.BackgroundImage = global::Juzzle.Properties.Resources.marble_red_32; break;
        case 3: button100.BackgroundImage = global::Juzzle.Properties.Resources.marble_yellow_32; break;
      }
    }

    private void playButtonClick()
    {
      SoundPlayer sound = new SoundPlayer(Properties.Resources.button_click);
      sound.Play();
    }

    private void playNewLevel()
    {
      SoundPlayer sound = new SoundPlayer(Properties.Resources.new_level);
      sound.Play();
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
        buttonSound.Image = global::Juzzle.Properties.Resources.unmute;
        setStatusbarInformationtext("sound OFF");
        if (isSoundEnabled) playButtonClick();
      }
      else if (!isSoundEnabled)
      {
        isSoundEnabled = true;
        buttonSound.Image = global::Juzzle.Properties.Resources.mute;
        setStatusbarInformationtext("sound ON");
        if (isSoundEnabled) playButtonClick();
      }
    }

    private void buttonSound_Enter(object sender, EventArgs e)
    {
      this.buttonSound.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonSound.AccessibleDescription);
    }

    private void buttonSound_MouseEnter(object sender, EventArgs e)
    {
      this.buttonSound.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonSound.AccessibleDescription);
    }

    private void buttonSound_Leave(object sender, EventArgs e)
    {
      this.buttonSound.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonSound_MouseLeave(object sender, EventArgs e)
    {
      this.buttonSound.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonSound_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonSound.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_clicked;
    }

    private void buttonSound_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonSound.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_hover;
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
      this.buttonHighscore.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonHighscore.AccessibleDescription);
    }

    private void buttonHighscore_MouseEnter(object sender, EventArgs e)
    {
      this.buttonHighscore.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonHighscore.AccessibleDescription);
    }

    private void buttonHighscore_Leave(object sender, EventArgs e)
    {
      this.buttonHighscore.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonHighscore_MouseLeave(object sender, EventArgs e)
    {
      this.buttonHighscore.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonHighscore_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonHighscore.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_clicked;
    }

    private void buttonHighscore_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonHighscore.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_hover;
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
      this.buttonInformation.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonInformation.AccessibleDescription);
    }

    private void buttonInformation_MouseEnter(object sender, EventArgs e)
    {
      this.buttonInformation.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_hover;
      setStatusbarInformationtext(buttonInformation.AccessibleDescription);
    }

    private void buttonInformation_Leave(object sender, EventArgs e)
    {
      this.buttonInformation.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonInformation_MouseLeave(object sender, EventArgs e)
    {
      this.buttonInformation.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_normal;
      clearStatusbarInformationtext();
    }

    private void buttonInformation_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonInformation.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_clicked;
    }

    private void buttonInformation_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonInformation.BackgroundImage = global::Juzzle.Properties.Resources.btn_small_hover;
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
        this.buttonStart.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_normal;
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
      }
      else if (!isGamePaused)
      {
        isGamePaused = true;
        buttonPause.Text = "&Resume";
        this.buttonStart.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_disabled;
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
      }
    }

    private void buttonPause_Enter(object sender, EventArgs e)
    {
      this.buttonPause.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonPause.AccessibleDescription);
    }

    private void buttonPause_MouseEnter(object sender, EventArgs e)
    {
      this.buttonPause.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonPause.AccessibleDescription);
    }

    private void buttonPause_Leave(object sender, EventArgs e)
    {
      this.buttonPause.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonPause_MouseLeave(object sender, EventArgs e)
    {
      this.buttonPause.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonPause_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonPause.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_clicked;
    }

    private void buttonPause_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonPause.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_hover;
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
      this.buttonStart.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonStart.AccessibleDescription);
    }

    private void buttonStart_MouseEnter(object sender, EventArgs e)
    {
      this.buttonStart.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonStart.AccessibleDescription);
    }

    private void buttonStart_Leave(object sender, EventArgs e)
    {
      this.buttonStart.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonStart_MouseLeave(object sender, EventArgs e)
    {
      this.buttonStart.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonStart_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonStart.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_clicked;
    }

    private void buttonStart_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonStart.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_hover;
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
      this.buttonQuit.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonQuit.AccessibleDescription);
    }

    private void buttonQuit_MouseEnter(object sender, EventArgs e)
    {
      this.buttonQuit.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_hover;
      setStatusbarInformationtext(buttonQuit.AccessibleDescription);
    }

    private void buttonQuit_Leave(object sender, EventArgs e)
    {
      this.buttonQuit.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonQuit_MouseLeave(object sender, EventArgs e)
    {
      this.buttonQuit.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_normal;
      clearStatusbarInformationtext();
    }

    private void buttonQuit_MouseDown(object sender, MouseEventArgs e)
    {
      this.buttonQuit.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_clicked;
    }

    private void buttonQuit_MouseUp(object sender, MouseEventArgs e)
    {
      this.buttonQuit.BackgroundImage = global::Juzzle.Properties.Resources.btn_large_hover;
    }


    #endregion

  }
}
