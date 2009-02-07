using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace BMSOptimizer
{
	/// <summary>
	/// FormGeneralOptions の概要の説明です。
	/// </summary>
	public class FormGeneralOptions : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox checkBoxAskDelete;
		private System.Windows.Forms.CheckBox checkBoxShowSplash;
		private System.Windows.Forms.Button buttonDefault;
		private System.Windows.Forms.RadioButton radioButtonDelAsk;
		private System.Windows.Forms.RadioButton radioButtonDelRecycled;
		private System.Windows.Forms.RadioButton radioButtonDelCompletly;
		public string exePath = Application.StartupPath;
		public string iniPath = Application.StartupPath + @"\BMSOptimizer.ini";
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button buttonEditorOpen;
		private System.Windows.Forms.Button buttonPlayerOpen;
		private System.Windows.Forms.TextBox textBoxEditorPath;
		private System.Windows.Forms.TextBox textBoxPlayerPath;
		public System.Windows.Forms.OpenFileDialog openFileDialogExe;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ComboBox textBoxPlayerOption;
		private System.Windows.Forms.ComboBox textBoxEditorOption;
		private System.ComponentModel.IContainer components;

		public FormGeneralOptions()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナで生成されたコード 
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.checkBoxShowSplash = new System.Windows.Forms.CheckBox();
			this.checkBoxAskDelete = new System.Windows.Forms.CheckBox();
			this.buttonDefault = new System.Windows.Forms.Button();
			this.radioButtonDelAsk = new System.Windows.Forms.RadioButton();
			this.radioButtonDelRecycled = new System.Windows.Forms.RadioButton();
			this.radioButtonDelCompletly = new System.Windows.Forms.RadioButton();
			this.buttonEditorOpen = new System.Windows.Forms.Button();
			this.buttonPlayerOpen = new System.Windows.Forms.Button();
			this.textBoxEditorPath = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPlayerPath = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.openFileDialogExe = new System.Windows.Forms.OpenFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.textBoxPlayerOption = new System.Windows.Forms.ComboBox();
			this.textBoxEditorOption = new System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOK.Location = new System.Drawing.Point(148, 236);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(60, 28);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "&OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonCancel.Location = new System.Drawing.Point(216, 236);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(60, 28);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// checkBoxShowSplash
			// 
			this.checkBoxShowSplash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxShowSplash.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxShowSplash.Location = new System.Drawing.Point(16, 40);
			this.checkBoxShowSplash.Name = "checkBoxShowSplash";
			this.checkBoxShowSplash.Size = new System.Drawing.Size(220, 16);
			this.checkBoxShowSplash.TabIndex = 4;
			this.checkBoxShowSplash.Text = "起動時にスプラッシュを出す (&S)";
			// 
			// checkBoxAskDelete
			// 
			this.checkBoxAskDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxAskDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxAskDelete.Location = new System.Drawing.Point(16, 16);
			this.checkBoxAskDelete.Name = "checkBoxAskDelete";
			this.checkBoxAskDelete.Size = new System.Drawing.Size(220, 16);
			this.checkBoxAskDelete.TabIndex = 3;
			this.checkBoxAskDelete.Text = "削除するとき確認ダイアログを出す (&A)";
			// 
			// buttonDefault
			// 
			this.buttonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDefault.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonDefault.Location = new System.Drawing.Point(216, 236);
			this.buttonDefault.Name = "buttonDefault";
			this.buttonDefault.Size = new System.Drawing.Size(60, 28);
			this.buttonDefault.TabIndex = 5;
			this.buttonDefault.Text = "&Default";
			this.buttonDefault.Visible = false;
			this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
			// 
			// radioButtonDelAsk
			// 
			this.radioButtonDelAsk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonDelAsk.Enabled = false;
			this.radioButtonDelAsk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonDelAsk.Location = new System.Drawing.Point(16, 64);
			this.radioButtonDelAsk.Name = "radioButtonDelAsk";
			this.radioButtonDelAsk.Size = new System.Drawing.Size(220, 16);
			this.radioButtonDelAsk.TabIndex = 2;
			this.radioButtonDelAsk.Text = "常に尋ねる (&A)";
			this.radioButtonDelAsk.Visible = false;
			// 
			// radioButtonDelRecycled
			// 
			this.radioButtonDelRecycled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonDelRecycled.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonDelRecycled.Location = new System.Drawing.Point(16, 40);
			this.radioButtonDelRecycled.Name = "radioButtonDelRecycled";
			this.radioButtonDelRecycled.Size = new System.Drawing.Size(220, 16);
			this.radioButtonDelRecycled.TabIndex = 1;
			this.radioButtonDelRecycled.Text = "ゴミ箱に移動 (&R)";
			// 
			// radioButtonDelCompletly
			// 
			this.radioButtonDelCompletly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonDelCompletly.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonDelCompletly.Location = new System.Drawing.Point(16, 16);
			this.radioButtonDelCompletly.Name = "radioButtonDelCompletly";
			this.radioButtonDelCompletly.Size = new System.Drawing.Size(220, 16);
			this.radioButtonDelCompletly.TabIndex = 0;
			this.radioButtonDelCompletly.Text = "完全に削除 (&C)";
			// 
			// buttonEditorOpen
			// 
			this.buttonEditorOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonEditorOpen.Location = new System.Drawing.Point(224, 116);
			this.buttonEditorOpen.Name = "buttonEditorOpen";
			this.buttonEditorOpen.Size = new System.Drawing.Size(20, 19);
			this.buttonEditorOpen.TabIndex = 10;
			this.buttonEditorOpen.Text = "...";
			this.buttonEditorOpen.Click += new System.EventHandler(this.buttonEditorOpen_Click);
			// 
			// buttonPlayerOpen
			// 
			this.buttonPlayerOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonPlayerOpen.Location = new System.Drawing.Point(224, 32);
			this.buttonPlayerOpen.Name = "buttonPlayerOpen";
			this.buttonPlayerOpen.Size = new System.Drawing.Size(20, 19);
			this.buttonPlayerOpen.TabIndex = 9;
			this.buttonPlayerOpen.Text = "...";
			this.buttonPlayerOpen.Click += new System.EventHandler(this.buttonPlayerOpen_Click);
			// 
			// textBoxEditorPath
			// 
			this.textBoxEditorPath.AllowDrop = true;
			this.textBoxEditorPath.Location = new System.Drawing.Point(32, 116);
			this.textBoxEditorPath.Name = "textBoxEditorPath";
			this.textBoxEditorPath.Size = new System.Drawing.Size(184, 19);
			this.textBoxEditorPath.TabIndex = 7;
			this.textBoxEditorPath.Text = "";
			this.textBoxEditorPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxEditorPath_DragDrop);
			this.textBoxEditorPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxEditorPath_DragEnter);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "引数";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "エディタパス";
			// 
			// textBoxPlayerPath
			// 
			this.textBoxPlayerPath.AllowDrop = true;
			this.textBoxPlayerPath.Location = new System.Drawing.Point(32, 32);
			this.textBoxPlayerPath.Name = "textBoxPlayerPath";
			this.textBoxPlayerPath.Size = new System.Drawing.Size(184, 19);
			this.textBoxPlayerPath.TabIndex = 3;
			this.textBoxPlayerPath.Text = "";
			this.textBoxPlayerPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxPlayerPath_DragDrop);
			this.textBoxPlayerPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxPlayerPath_DragEnter);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 15);
			this.label7.TabIndex = 1;
			this.label7.Text = "引数";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 15);
			this.label8.TabIndex = 0;
			this.label8.Text = "プレイヤパス";
			// 
			// openFileDialogExe
			// 
			this.openFileDialogExe.Filter = "Exe File (*.exe)|*.exe";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(264, 216);
			this.tabControl1.TabIndex = 11;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.checkBoxAskDelete);
			this.tabPage1.Controls.Add(this.checkBoxShowSplash);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(256, 191);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "一般設定";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.radioButtonDelAsk);
			this.tabPage2.Controls.Add(this.radioButtonDelCompletly);
			this.tabPage2.Controls.Add(this.radioButtonDelRecycled);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(256, 191);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "削除オプション";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.textBoxEditorOption);
			this.tabPage3.Controls.Add(this.textBoxPlayerOption);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.textBoxPlayerPath);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.buttonEditorOpen);
			this.tabPage3.Controls.Add(this.buttonPlayerOpen);
			this.tabPage3.Controls.Add(this.textBoxEditorPath);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Location = new System.Drawing.Point(4, 21);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(256, 191);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "外部ツールの設定";
			// 
			// textBoxPlayerOption
			// 
			this.textBoxPlayerOption.DropDownWidth = 300;
			this.textBoxPlayerOption.Items.AddRange(new object[] {
																	 "\"<filename>\" -P -N0 // uBMplay",
																	 "<filename> -B -A -S -P -N0 // BMS View",
																	 "<filename> -P -N0 // BMEV"});
			this.textBoxPlayerOption.Location = new System.Drawing.Point(32, 72);
			this.textBoxPlayerOption.Name = "textBoxPlayerOption";
			this.textBoxPlayerOption.Size = new System.Drawing.Size(172, 20);
			this.textBoxPlayerOption.TabIndex = 11;
			// 
			// textBoxEditorOption
			// 
			this.textBoxEditorOption.DropDownWidth = 300;
			this.textBoxEditorOption.Location = new System.Drawing.Point(32, 156);
			this.textBoxEditorOption.Name = "textBoxEditorOption";
			this.textBoxEditorOption.Size = new System.Drawing.Size(172, 20);
			this.textBoxEditorOption.TabIndex = 12;
			// 
			// FormGeneralOptions
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(290, 271);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonDefault);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormGeneralOptions";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "オプション";
			this.Load += new System.EventHandler(this.FormGeneralOptions_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region beep用
		// beep用
		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		private static extern int MessageBeep(uint n);
		#endregion

		#region ini読み込み用

		/// <summary>
		/// ini ファイルの読み込み用の関数(GetPrivateProfileString)の宣言部分
		/// </summary>
		[DllImport("kernel32.dll", EntryPoint="GetPrivateProfileString")]
		private static extern uint GetPrivateProfileString( string lpApplicationName, string lpEntryName, string lpDefault, System.Text.StringBuilder lpReturnedString, uint nSize, string lpFileName ); 

		/// <summary>
		/// ini ファイルの書き込み用の関数(WritePrivateProfileString)の宣言部分
		/// </summary>
		[DllImport("kernel32.dll", EntryPoint="WritePrivateProfileString")]
		private static extern uint WritePrivateProfileString( string lpApplicationName, string lpEntryName, string lpEntryString, string lpFileName );

		#endregion

		string ini = Application.StartupPath + @"\BMSOptimizer.ini";

		private void ini_load(object sender, System.EventArgs e)
		{
			uint entryLength;
			string strEntryStringValue;
			System.Text.StringBuilder strEntryString = new System.Text.StringBuilder( 256 );

			#region//AskDelete
			entryLength = GetPrivateProfileString( "Main",
				"AskDelete",
				"True",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			switch(strEntryStringValue)
			{
				case "True":
					checkBoxAskDelete.Checked = true;
					break;
				case "False":
					checkBoxAskDelete.Checked = false;
					break;
				default:
					checkBoxAskDelete.Checked = true;
					break;
			}
			#endregion

			#region//ShowSplash
			entryLength = GetPrivateProfileString( "Main",
				"ShowSplash",
				"False",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			switch(strEntryStringValue)
			{
				case "True":
					checkBoxShowSplash.Checked = true;
					break;
				case "False":
					checkBoxShowSplash.Checked = false;
					break;
				default:
					checkBoxShowSplash.Checked = true;
					break;
			}
			#endregion

			#region//DelOption
			entryLength = GetPrivateProfileString( "Main",
				"DelOption",
				"Recycled",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			switch(strEntryStringValue)
			{
				case "Completely":
					radioButtonDelCompletly.Checked = true;
					break;
				case "Recycled":
					radioButtonDelRecycled.Checked = true;
					break;
				default:
					radioButtonDelRecycled.Checked = true;
					break;
			}
			#endregion

			#region//PlayerPath
			entryLength = GetPrivateProfileString( "Main",
				"PlayerPath",
				@"C:\ubmplay\ubmplay.exe",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			textBoxPlayerPath.Text = strEntryStringValue;
			#endregion

			#region//PlayerOption
			entryLength = GetPrivateProfileString( "Main",
				"PlayerOption",
				"-P -N0",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			textBoxPlayerOption.Text = strEntryStringValue;
			#endregion

			#region//EditorPath
			entryLength = GetPrivateProfileString( "Main",
				"EditorPath",
				@"C:\bmse\bmse.exe",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			textBoxEditorPath.Text = strEntryStringValue;
			#endregion

			#region//EditorOption
			entryLength = GetPrivateProfileString( "Main",
				"EditorOption",
				"",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			textBoxEditorOption.Text = strEntryStringValue;
			#endregion
		}


		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			uint entryLength;

			#region DelOption
			switch(checkBoxAskDelete.Checked)
			{
				case true:
					entryLength = WritePrivateProfileString( "Main", "DelOption", "Completely", ini );
					break;
				case false:
					entryLength = WritePrivateProfileString( "Main", "DelOption", "Recycled", ini );
					break;
			}
			#endregion

			#region AskDelete
			switch(checkBoxAskDelete.Checked)
			{
				case true:
					entryLength = WritePrivateProfileString( "Main", "AskDelete", "True", ini );
					break;
				case false:
					entryLength = WritePrivateProfileString( "Main", "AskDelete", "False", ini );
					break;
			}
			#endregion

			#region ShowSplash
			switch(checkBoxShowSplash.Checked)
			{
				case true:
					entryLength = WritePrivateProfileString( "Main", "ShowSplash", "True", ini );
					break;
				case false:
					entryLength = WritePrivateProfileString( "Main", "ShowSplash", "False", ini );
					break;
			}
			#endregion

			#region External options
			entryLength = WritePrivateProfileString( "Main", "PlayerPath", textBoxPlayerPath.Text, ini );
			entryLength = WritePrivateProfileString( "Main", "PlayerOption", quote + textBoxPlayerOption.Text + quote, ini );
			entryLength = WritePrivateProfileString( "Main", "EditorPath", textBoxEditorPath.Text, ini );
			entryLength = WritePrivateProfileString( "Main", "EditorOption", quote + textBoxEditorOption.Text + quote, ini );
			#endregion
		}

		string quote = "\"";

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void buttonDefault_Click(object sender, System.EventArgs e)
		{
			checkBoxAskDelete.Checked = true;
			checkBoxShowSplash.Checked = false;

			radioButtonDelRecycled.Checked = true;
		}

		private void FormGeneralOptions_Load(object sender, System.EventArgs e)
		{
			// this.Font = SystemInformation.MenuFont;
			ini_load(sender,e);
		}

		private void buttonPlayerOpen_Click(object sender, System.EventArgs e)
		{
			string tmp = textBoxPlayerPath.Text;
			openFileDialogExe.ShowDialog();
			string playerPath = openFileDialogExe.FileName;
			textBoxPlayerPath.Text = playerPath;
			if(openFileDialogExe.FileName == "")
			{
				textBoxPlayerPath.Text = tmp;
			}

		}

		private void buttonEditorOpen_Click(object sender, System.EventArgs e)
		{
			string tmp = textBoxEditorPath.Text;
			openFileDialogExe.ShowDialog();
			string playerPath = openFileDialogExe.FileName;
			textBoxEditorPath.Text = playerPath;
			if(openFileDialogExe.FileName == "")
			{
				textBoxEditorPath.Text = tmp;
			}
		}

		private void textBoxPlayerPath_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// 格納されているデータの形式を確認する
			if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) 
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void textBoxPlayerPath_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData( DataFormats.FileDrop, false );
			if(files[0].ToLower().EndsWith(".exe"))
			{
				textBoxPlayerPath.Text = files[0];
			}
			else
			{
				MessageBeep(0);
			}
		}

		private void textBoxEditorPath_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// 格納されているデータの形式を確認する
			if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) 
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void textBoxEditorPath_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData( DataFormats.FileDrop, false );
			if(files[0].ToLower().EndsWith(".exe"))
			{
				textBoxEditorPath.Text = files[0];
			}
			else
			{
				MessageBeep(0);
			}
		}
	}
}
