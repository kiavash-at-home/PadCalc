/*
Copyright 2009 by Kiavash

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PadCalc
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private double R2;

		private System.Windows.Forms.Label lblZo;
		private System.Windows.Forms.TextBox txtZo;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.TextBox txtAtten;
		private System.Windows.Forms.Label lblAtten;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtR1;
		private System.Windows.Forms.TextBox txtR2;
		private System.Windows.Forms.TextBox txtR3;
		private System.Windows.Forms.TextBox txtR4;
		private System.Windows.Forms.TextBox txtR6;
		private System.Windows.Forms.TextBox txtR5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rdbPi;
		private System.Windows.Forms.RadioButton rdbT;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rdbBalance;
		private System.Windows.Forms.RadioButton rdbUnbalance;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnStandard;
		private System.Windows.Forms.Label lblPercent;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MainMenu mainMenu1;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.lblZo = new System.Windows.Forms.Label();
			this.txtZo = new System.Windows.Forms.TextBox();
			this.txtAtten = new System.Windows.Forms.TextBox();
			this.lblAtten = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtR1 = new System.Windows.Forms.TextBox();
			this.txtR2 = new System.Windows.Forms.TextBox();
			this.txtR3 = new System.Windows.Forms.TextBox();
			this.txtR4 = new System.Windows.Forms.TextBox();
			this.txtR6 = new System.Windows.Forms.TextBox();
			this.txtR5 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdbT = new System.Windows.Forms.RadioButton();
			this.rdbPi = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rdbBalance = new System.Windows.Forms.RadioButton();
			this.rdbUnbalance = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStandard = new System.Windows.Forms.Button();
			this.lblPercent = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.mnuExit);
			// 
			// mnuExit
			// 
			this.mnuExit.Text = "E&xit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// lblZo
			// 
			this.lblZo.Location = new System.Drawing.Point(8, 24);
			this.lblZo.Size = new System.Drawing.Size(32, 16);
			this.lblZo.Text = "Zo=";
			// 
			// txtZo
			// 
			this.txtZo.Location = new System.Drawing.Point(32, 24);
			this.txtZo.Size = new System.Drawing.Size(32, 22);
			this.txtZo.Text = "50";
			this.txtZo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtZo.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// txtAtten
			// 
			this.txtAtten.Location = new System.Drawing.Point(152, 24);
			this.txtAtten.Size = new System.Drawing.Size(32, 22);
			this.txtAtten.Text = "3";
			this.txtAtten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtAtten.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// lblAtten
			// 
			this.lblAtten.Location = new System.Drawing.Point(112, 24);
			this.lblAtten.Size = new System.Drawing.Size(48, 16);
			this.lblAtten.Text = "Atten=";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(176, 64);
			this.btnOK.Size = new System.Drawing.Size(48, 24);
			this.btnOK.Text = "&OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txtR1
			// 
			this.txtR1.Location = new System.Drawing.Point(56, 152);
			this.txtR1.ReadOnly = true;
			this.txtR1.Size = new System.Drawing.Size(48, 22);
			this.txtR1.Text = "0";
			this.txtR1.Visible = false;
			// 
			// txtR2
			// 
			this.txtR2.Location = new System.Drawing.Point(128, 152);
			this.txtR2.ReadOnly = true;
			this.txtR2.Size = new System.Drawing.Size(48, 22);
			this.txtR2.Text = "0";
			this.txtR2.Visible = false;
			// 
			// txtR3
			// 
			this.txtR3.Location = new System.Drawing.Point(96, 184);
			this.txtR3.ReadOnly = true;
			this.txtR3.Size = new System.Drawing.Size(48, 22);
			this.txtR3.Text = "0";
			this.txtR3.Visible = false;
			// 
			// txtR4
			// 
			this.txtR4.Location = new System.Drawing.Point(168, 184);
			this.txtR4.ReadOnly = true;
			this.txtR4.Size = new System.Drawing.Size(48, 22);
			this.txtR4.Text = "0";
			this.txtR4.Visible = false;
			// 
			// txtR6
			// 
			this.txtR6.Location = new System.Drawing.Point(128, 216);
			this.txtR6.ReadOnly = true;
			this.txtR6.Size = new System.Drawing.Size(48, 22);
			this.txtR6.Text = "0";
			this.txtR6.Visible = false;
			// 
			// txtR5
			// 
			this.txtR5.Location = new System.Drawing.Point(56, 216);
			this.txtR5.ReadOnly = true;
			this.txtR5.Size = new System.Drawing.Size(48, 22);
			this.txtR5.Text = "0";
			this.txtR5.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.Text = "Pad Config:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdbT);
			this.panel1.Controls.Add(this.rdbPi);
			this.panel1.Location = new System.Drawing.Point(24, 64);
			this.panel1.Size = new System.Drawing.Size(48, 56);
			// 
			// rdbT
			// 
			this.rdbT.Location = new System.Drawing.Point(8, 32);
			this.rdbT.Size = new System.Drawing.Size(32, 20);
			this.rdbT.Text = "&T";
			this.rdbT.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
			// 
			// rdbPi
			// 
			this.rdbPi.Checked = true;
			this.rdbPi.Location = new System.Drawing.Point(8, 8);
			this.rdbPi.Size = new System.Drawing.Size(32, 20);
			this.rdbPi.Text = "&Pi";
			this.rdbPi.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rdbBalance);
			this.panel2.Controls.Add(this.rdbUnbalance);
			this.panel2.Location = new System.Drawing.Point(80, 64);
			this.panel2.Size = new System.Drawing.Size(96, 56);
			// 
			// rdbBalance
			// 
			this.rdbBalance.Location = new System.Drawing.Point(8, 32);
			this.rdbBalance.Size = new System.Drawing.Size(72, 20);
			this.rdbBalance.Text = "&Balance";
			this.rdbBalance.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
			// 
			// rdbUnbalance
			// 
			this.rdbUnbalance.Checked = true;
			this.rdbUnbalance.Location = new System.Drawing.Point(8, 8);
			this.rdbUnbalance.Size = new System.Drawing.Size(80, 20);
			this.rdbUnbalance.Text = "&Unbalance";
			this.rdbUnbalance.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 160);
			this.button1.Size = new System.Drawing.Size(24, 8);
			this.button1.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(104, 224);
			this.button2.Size = new System.Drawing.Size(24, 8);
			this.button2.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(112, 168);
			this.button3.Size = new System.Drawing.Size(8, 16);
			this.button3.Visible = false;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(112, 200);
			this.button4.Size = new System.Drawing.Size(8, 24);
			this.button4.Visible = false;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(176, 224);
			this.button5.Size = new System.Drawing.Size(24, 8);
			this.button5.Visible = false;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(184, 200);
			this.button6.Size = new System.Drawing.Size(8, 24);
			this.button6.Visible = false;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(184, 168);
			this.button7.Size = new System.Drawing.Size(8, 16);
			this.button7.Visible = false;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(176, 160);
			this.button8.Size = new System.Drawing.Size(24, 8);
			this.button8.Visible = false;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(32, 224);
			this.button9.Size = new System.Drawing.Size(24, 8);
			this.button9.Visible = false;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(32, 160);
			this.button10.Size = new System.Drawing.Size(24, 8);
			this.button10.Visible = false;
			// 
			// label1
			// 
			this.label1.Size = new System.Drawing.Size(240, 16);
			this.label1.Text = "Attenuator Resistance Calculator";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 128);
			this.label3.Size = new System.Drawing.Size(160, 16);
			this.label3.Text = "Resistor Network (all Ohms)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnStandard
			// 
			this.btnStandard.Enabled = false;
			this.btnStandard.Location = new System.Drawing.Point(176, 96);
			this.btnStandard.Size = new System.Drawing.Size(48, 24);
			this.btnStandard.Text = "&Std";
			this.btnStandard.Visible = false;
			this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
			// 
			// lblPercent
			// 
			this.lblPercent.ForeColor = System.Drawing.Color.Red;
			this.lblPercent.Location = new System.Drawing.Point(192, 128);
			this.lblPercent.Size = new System.Drawing.Size(24, 16);
			this.lblPercent.Text = "1%";
			this.lblPercent.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(184, 24);
			this.label4.Size = new System.Drawing.Size(20, 16);
			this.label4.Text = "dB";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(64, 24);
			this.label5.Size = new System.Drawing.Size(32, 16);
			this.label5.Text = "Ohm";
			// 
			// Form1
			// 
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblPercent);
			this.Controls.Add(this.btnStandard);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtR6);
			this.Controls.Add(this.txtR5);
			this.Controls.Add(this.txtR4);
			this.Controls.Add(this.txtR3);
			this.Controls.Add(this.txtR2);
			this.Controls.Add(this.txtR1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtAtten);
			this.Controls.Add(this.lblAtten);
			this.Controls.Add(this.txtZo);
			this.Controls.Add(this.lblZo);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Text = "PadCalc";
			this.Closed += new System.EventHandler(this.mnuExit_Click);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void txtBox_TextChanged(object sender, System.EventArgs e)
		{
			// Cast the sender object to a Textbox
			TextBox tb = (TextBox)sender;

			// Test if the data is valid and set the tag background
			// color accordingly.

			if (tb.Text.Length == 0)
			{
				tb.BackColor = Color.Red;
				this.btnStandard.Enabled 
					= this.btnOK.Enabled = false;
			}
			else
			{
				tb.BackColor = SystemColors.Window;
				this.btnOK.Enabled = true;
			}
		}

		private void txt_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8
				&& e.KeyChar != Convert.ToChar(".")
				&& e.KeyChar != Convert.ToChar("-"))

				e.Handled = true; // Remove the character
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			double z0= Convert.ToDouble(this.txtZo.Text);
			double atten= Convert.ToDouble(this.txtAtten.Text);
			double ratio=Math.Pow(10,atten/20);

			if (atten==0)
				this.btnStandard.Visible = false;
			else
				this.btnStandard.Visible = true;

			if (this.rdbPi.Checked) //Pi network Design
			{
				this.txtR2.Visible =  //make the boxes visible.
					this.txtR3.Visible =
					this.txtR4.Visible = 
					this.button1.Visible =
					this.button2.Visible =
					this.button3.Visible =
					this.button4.Visible =
					this.button5.Visible =
					this.button6.Visible =
					this.button7.Visible =
					this.button8.Visible = true;


				this.txtR1.Visible =  // make the rest invisible.
					this.txtR5.Visible =
					this.button10.Visible = 
					this.button9.Visible = false;

				if (atten==0)
				{
					this.txtR3.Text 
						= this.txtR4.Text= "inf";
				}
				else
				{
					this.txtR3.Text 
						= this.txtR4.Text = Convert.ToString(z0*(ratio+1)/(ratio-1));
					R2 = z0*(ratio*ratio-1)/(2*ratio);
				}
				
				if (this.rdbUnbalance.Checked) //Unbalance Pi configuration
				{
					this.txtR6.Visible=false;

					if (atten==0)
						this.txtR2.Text= "0";
					else
						this.txtR2.Text = Convert.ToString(R2);
				}
				else //Balance Pi configuration
				{
					this.txtR6.Visible=true; //make the boxes visible.
					
					if (atten==0)
					{
						this.txtR2.Text 
							= this.txtR6.Text = "0";
					}
					else
					{
						this.txtR2.Text 
							= this.txtR6.Text = Convert.ToString(R2/2);
					}
				}
			}
			else //T Network Design
			{
				this.txtR2.Visible =  //make the boxes visible.
					this.txtR3.Visible =
					this.txtR1.Visible =
					this.button1.Visible = 
					this.button2.Visible = 
					this.button3.Visible = 
					this.button4.Visible = 
					this.button8.Visible = 
					this.button10.Visible = true;
				

				this.txtR4.Visible =  // make the rest invisible.
					this.button5.Visible = 
					this.button6.Visible = 
					this.button7.Visible = 
					this.button9.Visible = false;

				if (atten==0)
					this.txtR3.Text= "inf";
				else
				{
					this.txtR3.Text = Convert.ToString(z0*(2*ratio)/(ratio*ratio-1));
					R2 = z0*(ratio-1)/(ratio+1);
				}

				if (this.rdbUnbalance.Checked) //Unbalance T configuration
				{
					this.txtR5.Visible = false;
					this.txtR6.Visible = false;

					if (atten==0)
					{
						this.txtR1.Text 
							= this.txtR2.Text = "0";
					}
					else
					{
						this.txtR1.Text 
							= this.txtR2.Text = Convert.ToString(R2);
					}
				}
				else //Balance T configuration
				{
					this.txtR5.Visible 
						= this.txtR6.Visible 
						= this.button5.Visible 
						= this.button9.Visible = true;

					if (atten==0)
					{
						this.txtR1.Text 
							= this.txtR2.Text 
							= this.txtR5.Text 
							= this.txtR6.Text = "0";
					}
					else
					{
						this.txtR1.Text 
							= this.txtR2.Text 
							= this.txtR5.Text 
							= this.txtR6.Text = Convert.ToString(R2/2);
					}
				}
			}
			this.btnStandard.Enabled = true;
		}

		/// <summary>
		/// This function makes the resistor values standard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStandard_Click(object sender, System.EventArgs e)
		{
			float[] OnePerRes = new float [] 
				{
						10F,10.2F,10.5F,10.7F,11F,11.3F,11.5F,11.8F,12.1F,12.4F,12.7F,13F,
					13.3F,13.7F,14F,14.3F,14.7F,15F,15.4F,15.8F,16.2F,16.5F,16.9F,
					17.4F,17.8F,18.2F,18.7F,19.1F,19.6F,20F,20.5F,21F,21.5F,22.1F,
					22.6F,23.2F,23.7F,24.3F,24.9F,25.5F,26.1F,26.7F,27.4F,28F,28.7F,
					29.4F,30.1F,30.9F,31.6F,32.4F,33.2F,34F,34.8F,35.7F,36.5F,37.4F,
					38.3F,39.2F,40.2F,41.2F,42.2F,43.2F,44.2F,45.3F,46.4F,47.5F,48.7F,
					49.9F,51.1F,52.3F,53.6F,54.9F,56.2F,57.6F,59F,60.4F,61.9F,63.4F,
					64.9F,65.5F,68.1F,69.8F,71.5F,73.2F,75F,76.8F,78.7F,80.6F,82.5F,
					84.5F,86.6F,88.7F,90.9F,93.1F,95.3F,97.6F}; //Define 1% resistor values
			TextBox[] ResBox = new TextBox [] 
				{this.txtR1,this.txtR2,this.txtR3,this.txtR4,this.txtR5,this.txtR6};

			foreach (TextBox Res in ResBox)
			{
				float ResValue = Convert.ToSingle(Res.Text);
				float ErrorValue = Single.MaxValue;
				float AdjustedResValue = ResValue;
				float TenNumbers = Convert.ToSingle(Math.Floor(Math.Log10(ResValue))-1); //number of multiply of 10s minus 1

				foreach (float OnePerResValue in OnePerRes)
				{
					float AdjustedOnePerResValue = OnePerResValue * Convert.ToSingle(Math.Pow(10,TenNumbers));
					float AdjustedErrorValue = Math.Abs(AdjustedOnePerResValue - ResValue);
					if (AdjustedErrorValue < ErrorValue)
					{
						AdjustedResValue = AdjustedOnePerResValue;
						ErrorValue = AdjustedErrorValue;
					}
				}
				Res.Text = Convert.ToString(AdjustedResValue); //Updates the resistor values
			}

			this.lblPercent.Visible = true; //Makes the 1% label visibale

		}

		private void rdb_CheckedChanged(object sender, System.EventArgs e)
		{
			foreach (TextBox Res in new TextBox []
					{this.txtR1,this.txtR2,this.txtR3,this.txtR4,this.txtR5,this.txtR6})
				Res.Visible = false;
			foreach (Button Wire in new Button []
					{this.button1,this.button2,this.button3,this.button4,this.button5,this.button6,this.button7,this.button8,this.button9,this.button10})
				Wire.Visible = false;
			this.btnStandard.Enabled = false;
		}
	}
}
