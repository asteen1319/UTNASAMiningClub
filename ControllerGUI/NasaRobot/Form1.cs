using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XInput;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Windows.Threading;

namespace NasaRobot
{
    public partial class Form1 : Form
    {
        #region GLOBAL VARIABLES

        System.Net.Sockets.TcpClient sock = new TcpClient();
        bool addValue = true; //true if we're moving forward, false if we're going backwards
        int motorSpeed = 8;
        int actuatorSpeed = 8;
        Controller controller = new Controller(UserIndex.One);
        bool useController = false;
        DispatcherTimer timer = new DispatcherTimer();
        bool controllingMotors = true;

        List<string> MotorList = new List<string> { "DriveMotor" };
        List<string> ActuatorList = new List<string> { "Excavator", "Dump" };

        #endregion

        public Form1()
        {
            InitializeComponent();
           

            //default comboboxes to first item in collection
            cmbMotorSelect.SelectedIndex = 0;
            cmbActuatorSelect.SelectedIndex = 0;

            //connectSocket();
            Visible = true;

            if (controller.IsConnected)
            {
                var response = MessageBox.Show("Xbox Controller connected. Use that instead?", "", MessageBoxButtons.YesNo);
                useController = response == DialogResult.Yes ? true : false;
            }

            //display the correct control scheme
            changeControlScheme();
            
        }

    

        #region DISPLAY UPDATES

        /// <summary>
        /// Changes which GUI elements are displayed
        /// </summary>
        void changeControlScheme()
        {
            
            //show the correct display
            if (useController)
            {
                pnlXboxControl.Visible = true;
                pnlCompControl.Visible = false;
            }
            else
            {
                pnlXboxControl.Visible = false;
                pnlCompControl.Visible = true;
            }

            //start/stop timer
            if (timer.IsEnabled && !useController)
            {
                timer.Stop();
            }
            else if (!timer.IsEnabled && useController)
            {
                initiateTimer();
            }

            
        }

        /// <summary>
        /// Updates display to show current speed setting
        /// </summary>
        private void updateSpeedText()
        {
            string value = "";
            switch (motorSpeed)
            {
                case 8:
                    value = "1/8th";
                    break;
                case 16:
                    value = "1/4th";
                    break;
                case 24:
                    value = "3/8th";
                    break;
                case 32:
                    value = "Half";
                    break;
                case 40:
                    value = "5/8th";
                    break;
                case 48:
                    value = "3/4th";
                    break;
                case 56:
                    value = "7/8th";
                    break;
                case 64:
                    value = "Full";
                    break;
            }
            lblSpeed.Text = value;
        }

        private void btnSwapControls_Click(object sender, EventArgs e)
        {
            useController = !useController;
            changeControlScheme();
        }

        #endregion

        #region XBOX CONTROLLER

        /// <summary>
        /// Sets up and starts a timer to tick every 100 milliseconds
        /// </summary>
        private void initiateTimer()
        {
            timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(100) };
            timer.Tick += timer_Tick;
            timer.Start();

        }

        /// <summary>
        /// Event handler for the DispatcherTimer Tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Tick(object sender, EventArgs e)
        {
            UpdateController();
        }

        /// <summary>
        /// Updates and handles current controller state
        /// </summary>
        public void UpdateController()
        {
            float LeftTrigger, RightTrigger;
            if (!controller.IsConnected)
            {
                var response = MessageBox.Show("No controller detected! Connect a controller and click \"Retry\" or click \"Cancel\" if you no longer wish to use a controller.", "No Connection", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (response == DialogResult.Cancel) //retry case will be handled by coming back to this method, so no need to explicitly handle it
                {
                    useController = false;
                    changeControlScheme();
                }

                return;
            }

            var temp = "";

            Gamepad gamepad = controller.GetState().Gamepad;
            interpretInput(gamepad);

            //LeftTrigger = gamepad.LeftTrigger;
            //RightTrigger = gamepad.RightTrigger;
        }

        private Image getNextImage(string command)
        {
            Image image;
            switch (command)
            {
                case "Forward":
                    image = Properties.Resources.forward;
                    break;
                case "Left":
                    image = Properties.Resources.left;
                    break;
                case "Right":
                    image = Properties.Resources.right;
                    break;
                case "CW":
                    image = Properties.Resources.clockwise;
                    break;
                case "CCW":
                    image = Properties.Resources.counterclockwise;
                    break;
                case "Reverse":
                    image = Properties.Resources.reverse;
                    break;
                default:
                    image = Properties.Resources.stop;
                    break;
            }
            return image;
        }

        /// <summary>
        /// Reads state of controller sticks and buttons and handles input
        /// </summary>
        /// <param name="gamepad"></param>
        private void interpretInput(Gamepad gamepad)
        {
            Point LeftThumb = new Point(0, 0);
            Point RightThumb = new Point(0, 0);
            int deadband = 2500;
            
            //get stick input
            //convert thumbstick values to a range of 0-100, instead of -32000ish - 32000ish
            //currently the right stick isn't used, but keep the code here anyways
            LeftThumb.X = (int)((Math.Abs((float)gamepad.LeftThumbX) < deadband) ? 0 : (float)gamepad.LeftThumbX / short.MinValue * -100);
            LeftThumb.Y = (int)((Math.Abs((float)gamepad.LeftThumbY) < deadband) ? 0 : (float)gamepad.LeftThumbY / short.MaxValue * 100);
            RightThumb.X = (int)((Math.Abs((float)gamepad.RightThumbX) < deadband) ? 0 : (float)gamepad.RightThumbX / short.MaxValue * 100);
            RightThumb.Y = (int)((Math.Abs((float)gamepad.RightThumbY) < deadband) ? 0 : (float)gamepad.RightThumbY / short.MaxValue * 100);

            string temp = "";
            string command = getDirection(LeftThumb);
            Image nextImage = getNextImage(command);
            lblDirection.Text = (addValue ? "" : "Back ") + command;

            #region BUTTONS

            if (gamepad.Buttons.HasFlag(GamepadButtonFlags.B) || gamepad.Buttons.HasFlag(GamepadButtonFlags.Back)) //Stop. check this first so Stop overrides all other commands
            {
                lblCurrentCommand.Text = "Stop";
                lblCurrentDevice.Text = cmbMotorSelect.Text; //TODO: figure out how to let user select between motors and actuators w/ controller
                pictureBox1.Image = Properties.Resources.stop;
                //sendMessage(cmbMotorSelect.Text, "Stop", 0);
            }
            else if (gamepad.Buttons.HasFlag(GamepadButtonFlags.A)) //send command
            {
                temp = command;
                lblCurrentCommand.Text = command;
                lblCurrentDevice.Text = cmbMotorSelect.Text; //TODO: figure out how to let user select between motors and actuators w/ controller
                pictureBox1.Image = nextImage;

                //sendMessage(cmbMotorSelect.Text, command, motorSpeed);
            }
            else if (gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp))//increase speed setting
            {
                if (motorSpeed < 64)
                {
                    motorSpeed += 8;
                }

                updateSpeedText();
            }
            else if (gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown))//lower speed setting
            {
                if (motorSpeed > 8)
                {
                    motorSpeed -= 8;
                }

                updateSpeedText();
            }
            else if (gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft))//control motors
            {
                controllingMotors = true;
            }
            else if (gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight))//control actuators
            {
                controllingMotors = false;
            }
            else if (gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder))//next item in list
            {
                MotorList.
            }
            else if (gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder))//previous item in list
            {

            }
          

            #endregion

            //debugging info
            lblDisplay.Text = $"Left Stick X: {LeftThumb.X}, Left Stick Y: {LeftThumb.Y}, Right Stick X: {RightThumb.X}, Right Stick Y: {RightThumb.Y}, Buttons: {gamepad.Buttons.ToString()}, Move Direction: {temp}";

        }

        /// <summary>
        /// Determines which movement command to give based on stick position
        /// </summary>
        /// <param name="point">Current position of the stick</param>
        /// <returns>Direction command</returns>
        private string getDirection(Point point)
        {

            //NOTE: reverse turns may have robot move in the wrong direction. We need to test this. If thats the case, just swap Left and Right in this cod      
            string command = "";
            if (point.Y > 0 && point.X < 30 && point.X > -30)
            {
                
                command = "Forward";
                addValue = true;
            }
            else if (point.Y < 30 && point.Y  > -30 && point.X < 0) //pivot turn left
            {
                command = "CCW";
                addValue = true;
            }
            else if (point.Y >= 30 && point.X <= -30)//rounded turn to the left
            {
                command = "Left";
                addValue = true;
            }
            else if (point.Y < 0 && point.X > -30 && point.X < 30)
            {
                command = "Reverse";
                addValue = false;
            }
            else if (point.Y >= 30 && point.X >= 30)//rounded turn to the right
            {
                command = "Right";
                addValue = true;
            }
            else if (point.Y > -30 && point.Y < 30 && point.X > 0)//pivot turn right
            {
                command = "CW";
                addValue = true;
            }
            else if(point.X <= -30 && point.Y <= -30)//reverse rounded turn left
            {
                command = "Left";
                addValue = false;
            }
            else if (point.X >= 30 && point.Y <= -30)//reverse rounded turn right
            {
                command = "Right";
                addValue = false;
            }
            else
            {
                command = "Stop";
            }

            return command;
        }

        #endregion

        #region SOCKETS
        
        /// <summary>
        /// Establishes a socket connection with the wifi chip
        /// </summary>
        private void connectSocket()
        {
            string board = "192.168.69.113"; //make sure to update this once IP is made static
            sock.Connect(board, 23);

        }

        /// <summary>
        /// Sends a message via a socket connection
        /// </summary>
        /// <param name="deviceName">Device to control</param>
        /// <param name="command">Command to be executed</param>
        /// <param name="value">Speed value</param>
        private void sendMessage(string deviceName, string command, int value)
        {
            NetworkStream serverStream = sock.GetStream();
            //calculate actual value to pass to motor. value of 64 is stop, > 64 is forward, < 64 is backwards. range is 0-128
            value = (value * ((addValue) ? 1 : -1)) + 64; 
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(deviceName + ", " + command + ", " + value + "\x04");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            //TODO: have this recieve command back
            //TODO: after recieving, compare to sent message to check for transmission errors
            //TODO: implement timeout on recieving to ensure connection isnt lost

            //read back buffer. We were getting issues, so commented out for now
            /*byte[] inStream = new byte[99999];
            serverStream.Read(inStream, 0, (int)sock.ReceiveBufferSize);
            string returnData = System.Text.Encoding.ASCII.GetString(inStream);
            lblDisplay.Text = returnData;
            */

        }

        #endregion

        #region MOTOR CONTROLS

        #region RADIO BUTTONS
        private void rbMotorEighth_CheckedChanged(object sender, EventArgs e)
        {
            motorSpeed = 8;
        }

        private void rbMotorQuarter_CheckedChanged(object sender, EventArgs e)
        {
            motorSpeed = 16;
        }

        private void rbMotorThreeEighths_CheckedChanged(object sender, EventArgs e)
        {
            motorSpeed = 24;
        }

        private void rbMotorHalf_CheckedChanged(object sender, EventArgs e)
        {
            motorSpeed = 32;
        }

        private void rbMotorFiveEighths_CheckedChanged(object sender, EventArgs e)
        {
            motorSpeed = 40;
        }

        private void rbMotorThreeQuarters_CheckedChanged(object sender, EventArgs e)
        {
            motorSpeed = 48;
        }

        private void rbMotorSevenEighths_CheckedChanged(object sender, EventArgs e)
        {
            motorSpeed = 56;
        }

        private void rbMotorFull_CheckedChanged(object sender, EventArgs e)
        {
            motorSpeed = 64;
        }

        #endregion

        #region BUTTON COMMANDS
        private void btnForward_Click(object sender, EventArgs e)
        {
            addValue = true;
            sendMessage(cmbMotorSelect.Text, "Forward", motorSpeed);
        }

        private void btnMotorStop_Click(object sender, EventArgs e)
        {
            addValue = true;
            sendMessage(cmbMotorSelect.Text, "Stop", 0); //the value here shouldnt matter as Stop is hardcoded in the board. But due to how the speed value is determined, passing in 0 will result in 64 being sent
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            addValue = false;
            sendMessage(cmbMotorSelect.Text, "Reverse", motorSpeed);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            addValue = true;
            sendMessage(cmbMotorSelect.Text, "Left", motorSpeed);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            addValue = true;
            sendMessage(cmbMotorSelect.Text, "Right", motorSpeed);
        }
        #endregion

        #endregion

        #region ACTUATOR CONTROLS

        #region RADIO BUTTONS

        private void rbActEighth_CheckedChanged(object sender, EventArgs e)
        {
            actuatorSpeed = 8;
        }

        private void rbActQuarter_CheckedChanged(object sender, EventArgs e)
        {
            actuatorSpeed = 16;
        }

        private void rbActThreeEighths_CheckedChanged(object sender, EventArgs e)
        {
            actuatorSpeed = 24;
        }

        private void rbActHalf_CheckedChanged(object sender, EventArgs e)
        {
            actuatorSpeed = 32;
        }

        private void rbActFiveEighths_CheckedChanged(object sender, EventArgs e)
        {
            actuatorSpeed = 40;
        }

        private void rbThreeQuarters_CheckedChanged(object sender, EventArgs e)
        {
            actuatorSpeed = 48;
        }

        private void rbSevenEighths_CheckedChanged(object sender, EventArgs e)
        {
            actuatorSpeed = 56;
        }

        private void rbActFull_CheckedChanged(object sender, EventArgs e)
        {
            actuatorSpeed = 64;
        }

        #endregion

        #region BUTTON COMMANDS

        private void btnUp_Click(object sender, EventArgs e)
        {
            addValue = true;
            sendMessage(cmbActuatorSelect.Text, "Up", actuatorSpeed);
        }

        private void btnActuatorStop_Click(object sender, EventArgs e)
        {
            addValue = true;
            sendMessage(cmbActuatorSelect.Text, "Up", actuatorSpeed);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            addValue = false;
            sendMessage(cmbActuatorSelect.Text, "Up", actuatorSpeed);
        }




        #endregion

        #endregion

    

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (32)) //if the spacebar is pressed. allows quicker stopping of motors
            {
                sendMessage(cmbMotorSelect.Text, "Stop", 64);
            }
        }

       

    }
}
