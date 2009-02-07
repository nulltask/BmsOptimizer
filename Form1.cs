using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using ToRecycled.util;

namespace BMSOptimizer
{
	/// <summary>
	/// Form1 �̊T�v�̐����ł��B
	/// </summary>
	/// 
	public class FormMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBoxMain;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.Button buttonAnalyze;
		private System.Windows.Forms.TextBox textBoxBMSPath;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonMove;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.OpenFileDialog openFileDialogBMS;
		private System.Windows.Forms.MenuItem menuItemHelp;
		private System.Windows.Forms.MenuItem menuItemAbout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItemOptions;
		private System.Windows.Forms.MenuItem menuItemGeneralOptions;
		private System.Windows.Forms.MenuItem menuItemOpen;
		public string exePath = Application.StartupPath;
		public string iniPath = Application.StartupPath + @"\BMSOptimizer.ini";
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.ComboBox comboBoxUnused;
		private System.Windows.Forms.ListBox listBoxGarbageFiles;
		private System.Windows.Forms.ContextMenu contextMenuList;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		public System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelGenre;
		private System.Windows.Forms.Label labelArtist;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel labelBGA;
		private System.Windows.Forms.ContextMenu contextMenuBGA;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.ComponentModel.IContainer components;
		
		public FormMain()
		{
			//
			// Windows �t�H�[�� �f�U�C�i �T�|�[�g�ɕK�v�ł��B
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent �Ăяo���̌�ɁA�R���X�g���N�^ �R�[�h��ǉ����Ă��������B
			//
		}

		/// <summary>
		/// �g�p����Ă��郊�\�[�X�Ɍ㏈�������s���܂��B
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h 
		/// <summary>
		/// �f�U�C�i �T�|�[�g�ɕK�v�ȃ��\�b�h�ł��B���̃��\�b�h�̓��e��
		/// �R�[�h �G�f�B�^�ŕύX���Ȃ��ł��������B
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormMain));
			this.groupBoxMain = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.listBoxGarbageFiles = new System.Windows.Forms.ListBox();
			this.contextMenuList = new System.Windows.Forms.ContextMenu();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.comboBoxUnused = new System.Windows.Forms.ComboBox();
			this.buttonAnalyze = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.buttonMove = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItemOpen = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItemOptions = new System.Windows.Forms.MenuItem();
			this.menuItemGeneralOptions = new System.Windows.Forms.MenuItem();
			this.menuItemHelp = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItemAbout = new System.Windows.Forms.MenuItem();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.textBoxBMSPath = new System.Windows.Forms.TextBox();
			this.openFileDialogBMS = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelGenre = new System.Windows.Forms.Label();
			this.labelArtist = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelBGA = new System.Windows.Forms.LinkLabel();
			this.contextMenuBGA = new System.Windows.Forms.ContextMenu();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.groupBoxMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxMain
			// 
			this.groupBoxMain.Controls.Add(this.button3);
			this.groupBoxMain.Controls.Add(this.button1);
			this.groupBoxMain.Controls.Add(this.listBoxGarbageFiles);
			this.groupBoxMain.Controls.Add(this.comboBoxUnused);
			this.groupBoxMain.Controls.Add(this.buttonAnalyze);
			this.groupBoxMain.Controls.Add(this.buttonCopy);
			this.groupBoxMain.Controls.Add(this.buttonMove);
			this.groupBoxMain.Controls.Add(this.buttonDelete);
			this.groupBoxMain.Controls.Add(this.button2);
			this.groupBoxMain.Controls.Add(this.button4);
			this.groupBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBoxMain.Location = new System.Drawing.Point(4, 44);
			this.groupBoxMain.Name = "groupBoxMain";
			this.groupBoxMain.Size = new System.Drawing.Size(328, 304);
			this.groupBoxMain.TabIndex = 3;
			this.groupBoxMain.TabStop = false;
			this.groupBoxMain.Text = "Optimize";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(188, 220);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(132, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "�v���C���ōĐ� (&P)";
			this.toolTip.SetToolTip(this.button3, "�I�v�V�����Ŏw�肵���v���C����BMS���Đ����܂��B");
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Enabled = false;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(188, 164);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "�K�v�t�@�C�����ړ� (&V)";
			this.toolTip.SetToolTip(this.button1, "�K�v�ȃt�@�C���݂̂�����̏ꏊ�Ɉړ����܂��B");
			// 
			// listBoxGarbageFiles
			// 
			this.listBoxGarbageFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxGarbageFiles.ContextMenu = this.contextMenuList;
			this.listBoxGarbageFiles.Enabled = false;
			this.listBoxGarbageFiles.ItemHeight = 12;
			this.listBoxGarbageFiles.Location = new System.Drawing.Point(8, 16);
			this.listBoxGarbageFiles.Name = "listBoxGarbageFiles";
			this.listBoxGarbageFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxGarbageFiles.Size = new System.Drawing.Size(176, 256);
			this.listBoxGarbageFiles.TabIndex = 0;
			this.toolTip.SetToolTip(this.listBoxGarbageFiles, "�s�v�t�@�C���̈ꗗ���\������܂��B�_�u���N���b�N�Ńv���r���[���܂��B");
			this.listBoxGarbageFiles.DoubleClick += new System.EventHandler(this.listBoxGarbageFiles_DoubleClick);
			// 
			// contextMenuList
			// 
			this.contextMenuList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItem4,
																							this.menuItem5,
																							this.menuItem9,
																							this.menuItem10});
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "���ׂđI�� (&A)";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "���ׂĉ��� (&U)";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "-";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 3;
			this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.menuItem10.Text = "�I�����ڂ����X�g����폜";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// comboBoxUnused
			// 
			this.comboBoxUnused.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxUnused.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxUnused.DropDownWidth = 272;
			this.comboBoxUnused.Enabled = false;
			this.comboBoxUnused.ItemHeight = 12;
			this.comboBoxUnused.Location = new System.Drawing.Point(8, 276);
			this.comboBoxUnused.MaxDropDownItems = 24;
			this.comboBoxUnused.Name = "comboBoxUnused";
			this.comboBoxUnused.Size = new System.Drawing.Size(312, 20);
			this.comboBoxUnused.Sorted = true;
			this.comboBoxUnused.TabIndex = 9;
			this.toolTip.SetToolTip(this.comboBoxUnused, "���g�p��`�̈ꗗ���\������܂��B");
			// 
			// buttonAnalyze
			// 
			this.buttonAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonAnalyze.Location = new System.Drawing.Point(188, 16);
			this.buttonAnalyze.Name = "buttonAnalyze";
			this.buttonAnalyze.Size = new System.Drawing.Size(132, 60);
			this.buttonAnalyze.TabIndex = 1;
			this.buttonAnalyze.Text = "���o (&A)";
			this.toolTip.SetToolTip(this.buttonAnalyze, "�s�v�t�@�C���E�s�v��`�E�\���G���[�����o���܂��B");
			this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
			// 
			// buttonCopy
			// 
			this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonCopy.Location = new System.Drawing.Point(188, 136);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(132, 23);
			this.buttonCopy.TabIndex = 4;
			this.buttonCopy.Text = "�I���t�@�C�����R�s�[ (&C)";
			this.toolTip.SetToolTip(this.buttonCopy, "���X�g�{�b�N�X�őI�����ꂽ�A�C�e����@copied�ɃR�s�[���܂��B");
			this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
			// 
			// buttonMove
			// 
			this.buttonMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMove.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonMove.Location = new System.Drawing.Point(188, 108);
			this.buttonMove.Name = "buttonMove";
			this.buttonMove.Size = new System.Drawing.Size(132, 23);
			this.buttonMove.TabIndex = 3;
			this.buttonMove.Text = "�I���t�@�C�����ړ� (&M)";
			this.toolTip.SetToolTip(this.buttonMove, "���X�g�{�b�N�X�őI�����ꂽ�A�C�e����@moved�Ɉړ����܂��B");
			this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonDelete.Location = new System.Drawing.Point(188, 80);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(132, 23);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "�I���t�@�C�����폜 (&D)";
			this.toolTip.SetToolTip(this.buttonDelete, "���X�g�{�b�N�X�őI�����ꂽ�A�C�e�����폜���܂��B");
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Enabled = false;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(188, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "�}�X�^�[�A�b�v (&U)";
			this.toolTip.SetToolTip(this.button2, "�K�v�t�@�C��������Z�߂�ZIP���k�Ń}�X�^�[�A�b�v���܂��B");
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(188, 248);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(132, 23);
			this.button4.TabIndex = 8;
			this.button4.Text = "�G�f�B�^�ŕҏW (&E)";
			this.toolTip.SetToolTip(this.button4, "�I�v�V�����Ŏw�肵���G�f�B�^��BMS��ҏW���܂��B");
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItemFile,
																					 this.menuItemOptions,
																					 this.menuItemHelp});
			// 
			// menuItemFile
			// 
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemOpen,
																						 this.menuItem3,
																						 this.menuItemExit});
			this.menuItemFile.Text = "�t�@�C�� (&F)";
			this.menuItemFile.Click += new System.EventHandler(this.menuItemFile_Click);
			// 
			// menuItemOpen
			// 
			this.menuItemOpen.Index = 0;
			this.menuItemOpen.Text = "�J�� (&O)";
			this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			// 
			// menuItemExit
			// 
			this.menuItemExit.Index = 2;
			this.menuItemExit.Text = "�I�� (&E)";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItemOptions
			// 
			this.menuItemOptions.Index = 1;
			this.menuItemOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItemGeneralOptions});
			this.menuItemOptions.Text = "�ݒ� (&O)";
			// 
			// menuItemGeneralOptions
			// 
			this.menuItemGeneralOptions.Index = 0;
			this.menuItemGeneralOptions.Text = "�I�v�V���� (&C)";
			this.menuItemGeneralOptions.Click += new System.EventHandler(this.menuItemGeneralOptions_Click);
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.Index = 2;
			this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem8,
																						 this.menuItem7,
																						 this.menuItem2,
																						 this.menuItem6,
																						 this.menuItem1,
																						 this.menuItemAbout});
			this.menuItemHelp.Text = "�w���v (&H)";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 0;
			this.menuItem8.Text = "�t���̃e�L�X�g���J�� (&R)";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "-";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Text = "��҂̃E�F�u�T�C�g���J�� (&V)";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 3;
			this.menuItem6.Text = "�o�O�񍐂����� (&B)";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 4;
			this.menuItem1.Text = "-";
			// 
			// menuItemAbout
			// 
			this.menuItemAbout.Index = 5;
			this.menuItemAbout.Text = "�o�[�W������� (&A)";
			this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
			// 
			// buttonOpen
			// 
			this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOpen.Location = new System.Drawing.Point(308, 24);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(24, 19);
			this.buttonOpen.TabIndex = 2;
			this.buttonOpen.Text = "...";
			this.toolTip.SetToolTip(this.buttonOpen, "�{�^���N���b�N�Ńt�@�C�����J���܂��B");
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// textBoxBMSPath
			// 
			this.textBoxBMSPath.Location = new System.Drawing.Point(4, 24);
			this.textBoxBMSPath.Name = "textBoxBMSPath";
			this.textBoxBMSPath.ReadOnly = true;
			this.textBoxBMSPath.Size = new System.Drawing.Size(300, 19);
			this.textBoxBMSPath.TabIndex = 1;
			this.textBoxBMSPath.Text = "";
			this.toolTip.SetToolTip(this.textBoxBMSPath, "BMS�̏��݂��t���p�X�ŕ\������܂��BBMS���J���ɂ͉E��...���N���b�N���Ă��������B");
			this.textBoxBMSPath.TextChanged += new System.EventHandler(this.textBoxBMSPath_TextChanged);
			// 
			// openFileDialogBMS
			// 
			this.openFileDialogBMS.Filter = "BMS File (*.bms;*.bme;*.bml;*.pms)|*.bms;*bme;*.bml;*.pms|Be-Music Script (*.bms)" +
				"|*.bms|Be-Music Script Extended (*.bme)|*.bme|Be-Music Script Longnote (*.bml)|*" +
				".bml|Be-Music Script Pomu (*.pms)|*.pms";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "BMS�t�@�C��";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(4, 353);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(590, 11);
			this.progressBar.Step = 1;
			this.progressBar.TabIndex = 4;
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 32767;
			this.toolTip.InitialDelay = 500;
			this.toolTip.ReshowDelay = 100;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(337, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "�v���r���[";
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label3.Location = new System.Drawing.Point(336, 290);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(258, 58);
			this.label3.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(340, 312);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Title :";
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(372, 312);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(216, 16);
			this.labelTitle.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(340, 296);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Genre :";
			// 
			// labelGenre
			// 
			this.labelGenre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelGenre.Location = new System.Drawing.Point(380, 296);
			this.labelGenre.Name = "labelGenre";
			this.labelGenre.Size = new System.Drawing.Size(208, 16);
			this.labelGenre.TabIndex = 10;
			// 
			// labelArtist
			// 
			this.labelArtist.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelArtist.Location = new System.Drawing.Point(376, 328);
			this.labelArtist.Name = "labelArtist";
			this.labelArtist.Size = new System.Drawing.Size(208, 16);
			this.labelArtist.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(340, 328);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "Artist :";
			// 
			// labelBGA
			// 
			this.labelBGA.ActiveLinkColor = System.Drawing.Color.DarkCyan;
			this.labelBGA.BackColor = System.Drawing.Color.Black;
			this.labelBGA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelBGA.ContextMenu = this.contextMenuBGA;
			this.labelBGA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBGA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelBGA.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.labelBGA.LinkColor = System.Drawing.Color.Gray;
			this.labelBGA.Location = new System.Drawing.Point(336, 24);
			this.labelBGA.Name = "labelBGA";
			this.labelBGA.Size = new System.Drawing.Size(258, 262);
			this.labelBGA.TabIndex = 16;
			this.labelBGA.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.labelBGA.VisitedLinkColor = System.Drawing.Color.Gray;
			this.labelBGA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelBGA_LinkClicked);
			// 
			// contextMenuBGA
			// 
			this.contextMenuBGA.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuItem11});
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Text = "�\�����N���A (&C)";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// FormMain
			// 
			this.AcceptButton = this.buttonAnalyze;
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(598, 367);
			this.Controls.Add(this.labelBGA);
			this.Controls.Add(this.labelArtist);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelGenre);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxBMSPath);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.groupBoxMain);
			this.Controls.Add(this.progressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
			this.Closed += new System.EventHandler(this.FormMain_Closed);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
			this.groupBoxMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormMain());
		}

		#region ini�ǂݍ��ݗp

		/// <summary>
		/// ini �t�@�C���̓ǂݍ��ݗp�̊֐�(GetPrivateProfileString)�̐錾����
		/// </summary>
		[DllImport("kernel32.dll", EntryPoint="GetPrivateProfileString")]
		private static extern uint GetPrivateProfileString( string lpApplicationName, string lpEntryName, string lpDefault, System.Text.StringBuilder lpReturnedString, uint nSize, string lpFileName ); 

		/// <summary>
		/// ini �t�@�C���̏������ݗp�̊֐�(WritePrivateProfileString)�̐錾����
		/// </summary>
		[DllImport("kernel32.dll", EntryPoint="WritePrivateProfileString")]
		private static extern uint WritePrivateProfileString( string lpApplicationName, string lpEntryName, string lpEntryString, string lpFileName );

		#endregion

		string titletext = "BMS Optimizer 0.0.5";

		string AskDelete;
		string ShowSplash;
		string DelOption;
		string PlayerPath;
		string PlayerOption;
		string EditorPath;
		string EditorOption;

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
			AskDelete = strEntryStringValue;
			#endregion

			#region//ShowSplash
			entryLength = GetPrivateProfileString( "Main",
				"ShowSplash",
				"False",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			ShowSplash = strEntryStringValue;
			#endregion

			#region//DelOption
			entryLength = GetPrivateProfileString( "Main",
				"DelOption",
				"Recycled",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			DelOption = strEntryStringValue;
			#endregion

			#region//PlayerPath
			entryLength = GetPrivateProfileString( "Main",
				"PlayerPath",
				@"C:\ubmplay\ubmplay.exe",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			PlayerPath = strEntryStringValue;
			#endregion

			#region//PlayerOption
			entryLength = GetPrivateProfileString( "Main",
				"PlayerOption",
				"-P -N0",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			PlayerOption = strEntryStringValue;
			#endregion

			#region//EditorPath
			entryLength = GetPrivateProfileString( "Main",
				"EditorPath",
				@"C:\bmse\bmse.exe",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			EditorPath = strEntryStringValue;
			#endregion

			#region//EditorOption
			entryLength = GetPrivateProfileString( "Main",
				"EditorOption",
				"",
				strEntryString, (uint)(strEntryString.Capacity), ini);
			strEntryStringValue = strEntryString.ToString();
			EditorOption = strEntryStringValue;
			#endregion

		}

		#region �T�E���h�Đ��p

		// �t�@�C������Đ�����
		[DllImport( "winmm.dll", EntryPoint = "PlaySound" )]
		private static extern int PlaySound(
			[MarshalAs(UnmanagedType.LPStr)] string pszSound,
			int hModule,
			int dwFlags );

		// ��������̃o�b�t�@����Đ�����
		[DllImport( "winmm.dll", EntryPoint = "PlaySound" )]
		private static extern int PlaySound(
			[MarshalAs(UnmanagedType.LPArray)] byte[] pszSound,
			int hModule,
			int dwFlags );

		// �Đ��t���O
		private const int SND_SYNC   = 0x0;    // �����Đ�
		private const int SND_ASYNC  = 0x1;    // �񓯊��Đ�
		private const int SND_MEMORY = 0x4;    // �o�b�t�@����̍Đ�
		private const int SND_LOOP   = 0x8;    // ���[�v�Đ�
		private const int SND_NOSTOP = 0x10;   // �Đ����̃T�E���h���~���Ȃ�
		private const int SND_NOWAIT = 0x2000; // �r�W�[��ԂȂ瑦���ɏ�����Ԃ�

		// �o�b�t�@
		// byte[] buffer;

		#endregion

		#region MP3�Đ��p
		[DllImport("VBMP3.dll")]
		public static extern bool vbmp3_init();
 �@
		[StructLayout(LayoutKind.Sequential)]
			public struct InputInfo
		{
			[MarshalAs(UnmanagedType.ByValTStr,SizeConst=128)]
			public string szTrackName;
			[MarshalAs(UnmanagedType.ByValTStr,SizeConst=128)]
			public string szArtistName;
			public long channels;
			public long bitrate;
			public long samplingRate;
			public long totalSec;
		}
 �@
		[DllImport("VBMP3.dll")]
		public static extern bool vbmp3_open(string pszName, ref InputInfo pInfo);
		[DllImport("VBMP3.dll")]
		public static extern bool vbmp3_play(); 
		[DllImport("VBMP3.dll")]
		public static extern bool vbmp3_stop();
		[DllImport("VBMP3.dll")]
		public static extern bool vbmp3_free();
		#endregion

		#region ZIP���k�p
		/*
		[DllImport("7-zip32.dll")]
		public static extern bool vbmp3_init();
 �@
		[StructLayout(LayoutKind.Sequential)]
			public struct InputInfo
		{

		}
 �@
		[DllImport("VBMP3.dll")]
		public static extern bool vbmp3_open(string pszName, ref InputInfo pInfo);
		[DllImport("VBMP3.dll")]
		public static extern bool vbmp3_play(); 
		[DllImport("VBMP3.dll")]
		public static extern bool vbmp3_stop();
		[DllImport("VBMP3.dll")]
		public static extern bool vbmp3_free();
		*/
		#endregion

		#region beep�p
		// beep�p
		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		private static extern int MessageBeep(uint n);
		#endregion

		string currentpath;

		private int _36ToInt(string str)
		{
			// 36�i����10�i���֕ϊ�
			int x = 0;
			int y = 0;

			if(str[0] > '0' || str[0] < '9')
			{
				x = str[0] - 48;
			}
			else if( str[0] > 'A' || str[0] < 'Z')
			{
				x = (int)str[0] - 55;
			}

			if ( str[1] > '0' || str[1] < '9')
			{
				y = str[1] - 48;
			}
			else if( str[1] > 'A' || str[1] < 'Z')
			{
				y = (int)str[1] - 55;
			}
					
			return (x * 36) + y;
		}

		private void FormMain_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// �i�[����Ă���f�[�^�̌`�����m�F����
			if ( e.Data.GetDataPresent( DataFormats.FileDrop ) ) 
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		

		private void FormMain_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData( DataFormats.FileDrop, false );
			if(
				files[0].ToLower().EndsWith(".bms") ||
				files[0].ToLower().EndsWith(".bme") ||
				files[0].ToLower().EndsWith(".bml") ||
				files[0].ToLower().EndsWith(".pms")
				)
			{
				textBoxBMSPath.Text = files[0];
				currentpath = files[0].Substring(0, files[0].LastIndexOf(@"\"));
			}
			else
			{
				MessageBeep(0);
			}
		}

		private void buttonOpen_Click(object sender, System.EventArgs e)
		{
			string tmp = textBoxBMSPath.Text;
			openFileDialogBMS.ShowDialog();
			string bmsPath = openFileDialogBMS.FileName;
			textBoxBMSPath.Text = bmsPath;

			// �J�����g�p�X�擾
			if(textBoxBMSPath.Text != "")
			{
				currentpath = textBoxBMSPath.Text.Substring(0, textBoxBMSPath.Text.LastIndexOf(@"\"));
			}

			if(openFileDialogBMS.FileName == "")
			{
				textBoxBMSPath.Text = tmp;
			}

			DisplayInit();

		}

		private void DisplayInit()
		{
			labelGenre.Text = "";
			labelArtist.Text = "";
			labelTitle.Text = "";
			labelBGA.Text = "";
		}


		private void buttonAnalyze_Click(object sender, System.EventArgs e)
		{

			if (File.Exists(textBoxBMSPath.Text))
			{
				#region �t�@�C������������
				// �t�@�C�������IBMS���ȁH
				string file_name = textBoxBMSPath.Text;
				FileInfo info = new FileInfo(file_name);

				if(info.Extension.ToLower() == ".bms" ||
					info.Extension.ToLower() == ".bme" ||
					info.Extension.ToLower() == ".bml" ||
					info.Extension.ToLower() == ".pms"
					)
				{

					DisplayInit();

					// �R���g���[���𖳌���
					listBoxGarbageFiles.Enabled = false;
					comboBoxUnused.Enabled = false;

					labelBGA.Image = null;

					// �J�[�\���������v�ɂ���
					this.Cursor = Cursors.WaitCursor;

					// �s�����擾 �v���O���X�o�[�p
					int breaks = 0;
					string linecnt;
					StreamReader read =
						new StreamReader (textBoxBMSPath.Text);
					while ((linecnt = read.ReadLine()) != null)
					{
						breaks++;
					}
					read.Close();

					progressBar.Maximum = breaks + 1;
					progressBar.Minimum = 0;
					progressBar.Value = 0;
					int	now = 0;

					this.Text = titletext + " Analyzing...";

					// �t�@�C�����i�[�p
					string[] wav;
					wav = new string[1296];
					string[] bmp;
					bmp = new string[1296];

					string[] bpm;
					bpm = new string[1296];
					string[] stop;
					stop = new string[1296];

					string[] text;
					text = new string[1296];

					string[] deffilename;
					deffilename = new string[4096];

					int resultwavcnt = 0;
					int resultbmpcnt = 0;
					int resultbpmcnt = 0;
					int resultstopcnt = 0;
					int resulttextcnt = 0;
					int syntaxerrcnt = 0;
					int deffilenamecnt = 0;

					string title = "";
					string artist = "";
					string genre = "";
					string url = "";

					// ���X�g�{�b�N�X�N���A
					listBoxGarbageFiles.Items.Clear();
					comboBoxUnused.Items.Clear();

					// #WAVxx / #BMPxx ���i�[
					StreamReader reader =
						new StreamReader (textBoxBMSPath.Text,System.Text.Encoding.Default);

					// ��s�����o��
					string bmsline;
					while ((bmsline = reader.ReadLine()) != null)
					{
						// �󔒂܂ł̋���
						int index = bmsline.IndexOf(" ");

						// #WAV��������#BMP�Ŏn�܂��Ă�s���擾
						if (bmsline.ToUpper().StartsWith("#WAV") || 
							bmsline.ToUpper().StartsWith("#BMP") ||
							bmsline.ToUpper().StartsWith("#BPM") || 
							bmsline.ToUpper().StartsWith("#STOP") ||
							bmsline.ToUpper().StartsWith("#TEXT")
							)
						{
							int intnum = _36ToInt(bmsline.Substring(index - 2 ,2).ToUpper());

							// �t�@�C�������o���p
							// string seek = " ";

							// WAV�z��ɓ����
							if(bmsline.ToUpper().StartsWith("#WAV"))
							{
								wav[intnum] = bmsline/*.Substring(index + 1)*/;
								deffilename[deffilenamecnt] = bmsline.Substring(index + 1).ToString();
								deffilenamecnt++;
							}

							// BMP�z��ɓ����
							if(bmsline.ToUpper().StartsWith("#BMP"))
							{
								bmp[intnum] = bmsline/*.Substring(index + 1)*/;
								deffilename[deffilenamecnt] = bmsline.Substring(index + 1).ToString();
								deffilenamecnt++;
							}

							// BPM�z��ɓ����
							/*if(bmsline.ToUpper().StartsWith("#BPM[A-Z_0-9][A-Z_0-9]"))*/
							if(bmsline.ToUpper().StartsWith("#BPM") && 
								Regex.Match(bmsline.ToUpper(), "#BPM[A-Z_0-9][A-Z_0-9]").Success == true) // �ʏ��#bpm�ƍ���������邽��...
							{
								bpm[intnum] = bmsline/*.Substring(index + 1)*/;
							}

							// STOP�z��ɓ����
							if(bmsline.ToUpper().StartsWith("#STOP"))
							{
								stop[intnum] = bmsline/*.Substring(index + 1)*/;
							}

							// TEXT�z��ɓ����
							if(bmsline.ToUpper().StartsWith("#TEXT"))
							{
								text[intnum] = bmsline/*.Substring(index + 1)*/;
							}
						}

						// #BACKBMP,#BANNER,#STAGEFILE�ɒ�`����Ă���t�@�C�������擾
						else if (bmsline.ToUpper().StartsWith("#BACKBMP") || bmsline.ToUpper().StartsWith("#BANNER") || bmsline.ToUpper().StartsWith("#STAGEFILE"))
						{
							deffilename[deffilenamecnt] = bmsline.Substring(index + 1).ToString();
							deffilenamecnt++;
						}

						// �W�������E�Ȗ��E�A�[�e�B�X�g�擾
						else if (bmsline.ToUpper().StartsWith("#ARTIST"))
						{
							artist = bmsline.Substring(index + 1);
						}
						else if (bmsline.ToUpper().StartsWith("#TITLE"))
						{
							title = bmsline.Substring(index + 1);
						}
						else if (bmsline.ToUpper().StartsWith("#GENRE"))
						{
							genre = bmsline.Substring(index + 1);
						}
						else if (bmsline.ToUpper().StartsWith("%URL"))
						{
							url = bmsline.Substring(index + 1);
						}

						// �I�u�W�F�z��`�F�b�N
						if ((Regex.Match(bmsline.ToUpper(), "#[0-9][0-9][0-9][A-Z_0-9][A-Z_0-9][:]")).Success == true)
						{
							string ch = bmsline.Substring(4,2).ToUpper();

							// wav/bmp�nch�؂�o��
							if (Regex.Match(ch, "[1-4][A-Z_0-9]").Success == true || 
								Regex.Match(ch, "01").Success == true || 
								Regex.Match(ch, "04").Success == true || 
								Regex.Match(ch, "0[6-9]").Success == true || 
								Regex.Match(ch, "99").Success == true || 
								Regex.Match(ch, "0A").Success == true || 
								Regex.Match(ch, "A5").Success == true
								)
							{
								// �z��ؔ���
								string objsplit = bmsline.Remove(0,7);
								string objtmp = objsplit;

								// �z��ɕςȂ̓����Ă��Ȃ����m�F
								if ((Regex.Match(objtmp, "[^a-zA-Z_0-9]")).Success == true)
								{
									// �p�������ȊO����������G���[
									MessageBox.Show((now + 1).ToString() + " �s�ڂŃG���[�𔭌����܂����B\n�I�u�W�F�N�g�ɔF���ł��Ȃ�����������܂��B" + "\n\n" + bmsline,"�\���G���[");
									syntaxerrcnt++;
								}

									// �ςȂ̓����ĂȂ��̂�obj�z����
								else
								{
									// �I�u�W�F�z�񂪂����Ƌ���������I
									if ((objsplit.Length % 2 == 0))
									{
										// obj����0�ɂȂ�܂ł̊�...
										while(objtmp.Length != 0)
										{

											int intnum = _36ToInt(objtmp.Substring(0,2).ToUpper());

											// wav�nch01,11-1Z,21-2Z,30-3Z,41-4Z
											if(Regex.Match(ch, "[1-4][A-Z_0-9]").Success == true || Regex.Match(ch, "01").Success == true)
											{
												wav[intnum] = null;
												objtmp = objtmp.Remove(0,2);
											}

											if(Regex.Match(ch, "04").Success == true || Regex.Match(ch, "0[6-7]").Success == true || Regex.Match(ch, "0A").Success == true || Regex.Match(ch, "A5").Success == true)
											{
												bmp[intnum] = null;
												objtmp = objtmp.Remove(0,2);
											}

											if(Regex.Match(ch, "08").Success == true)
											{
												bpm[intnum] = null;
												objtmp = objtmp.Remove(0,2);
											}

											if(Regex.Match(ch, "09").Success == true)
											{
												stop[intnum] = null;
												objtmp = objtmp.Remove(0,2);
											}

											if(Regex.Match(ch, "99").Success == true)
											{
												text[intnum] = null;
												objtmp = objtmp.Remove(0,2);
											}
										}
									}
									else
									{
										// �I�u�W�F�z�񂪋�������Ȃ������Ƃ��̃G���[
										MessageBox.Show((now + 1).ToString() + " �s�ڂŃG���[�𔭌����܂����B\n�I�u�W�F�N�g�z�񂪕s���ł��B\n\n" + bmsline,"�\���G���[");
										syntaxerrcnt++;
									}
								}
							}
						}

						// �v���O���X�o�[�X�V
						progressBar.Value = now + 1;
						now++;

					}

					// ���g�p#wav��`�����X�g�ɏ����o��
					for (int i = 0; i < 1296;i++)
					{
						if (wav[i] == null)continue;
						comboBoxUnused.Items.Add(wav[i].ToString());
						resultwavcnt++;
					}

					bmp[0] = null; // #bmp00���o������p

					// ���g�p#bmp��`�����X�g�ɏ����o��
					for (int i = 0; i < 1296;i++)
					{
						if (bmp[i] == null)continue;
						comboBoxUnused.Items.Add(bmp[i].ToString());
						resultbmpcnt++;
					}

					// ���g�p#bpm��`�����X�g�ɏ����o��
					for (int i = 0; i < 1296;i++)
					{
						if (bpm[i] == null)continue;
						comboBoxUnused.Items.Add(bpm[i].ToString());
						resultbpmcnt++;
					}

					// ���g�p#stop��`�����X�g�ɏ����o��
					for (int i = 0; i < 1296;i++)
					{
						if (stop[i] == null)continue;
						comboBoxUnused.Items.Add(stop[i].ToString());
						resultstopcnt++;
					}

					text[0] = null; // #text00���o������p

					// ���g�p#text��`�����X�g�ɏ����o��
					for (int i = 0; i < 1296;i++)
					{
						if (text[i] == null)continue;
						comboBoxUnused.Items.Add(text[i].ToString());
						resulttextcnt++;
					}					

					progressBar.Value = progressBar.Maximum;

					// Listbox�ɒ�`����ĂȂ��t�@�C����A�˂�
					string[] filename;
					filename = new string[4096];
					int filenamecnt = 0;
					// �J�����g�t�H���_���̃t�@�C���ꗗ���o��
					foreach (string currentfile in Directory.GetFiles(currentpath))
					{
						filename[filenamecnt] = Path.GetFileName(currentfile);
						filenamecnt++;
					}

					int filenametmpcnt = 0;
					int deffilenametmpcnt = 0;
					// ��v������null�łԂ�
					// foreach (string filenametmp in filename)
					while (filename[filenametmpcnt] != null)
					{
						foreach (string deffilenametmp in deffilename)
						{
							if (filename[filenametmpcnt] == null || deffilenametmp == null)continue;
							if (filename[filenametmpcnt].ToLower() == deffilenametmp.ToLower())
							{
								filename[filenametmpcnt] = null;
								deffilenametmpcnt++;
							}
						}
						filenametmpcnt++;
					}

					int garbage = 0;
					foreach (string filenametmp in filename)
					{
						if(filenametmp != null)
						{
							// ���X�g�ɏo���g���q
							if (filenametmp.ToLower().EndsWith(".wav") ||
								filenametmp.ToLower().EndsWith(".mp3") ||
								filenametmp.ToLower().EndsWith(".ogg") ||
								filenametmp.ToLower().EndsWith(".bmp") ||
								filenametmp.ToLower().EndsWith(".png") ||
								filenametmp.ToLower().EndsWith(".jpg") ||
								filenametmp.ToLower().EndsWith(".jpeg") ||
								filenametmp.ToLower().EndsWith(".gif") ||
								filenametmp.ToLower().EndsWith(".nsd") ||
								filenametmp.ToLower().EndsWith(".npd") ||
								filenametmp.ToLower().EndsWith("score.txt") ||
								filenametmp.ToLower().EndsWith(".m2r") ||
								filenametmp.ToLower().EndsWith(".mwr") ||
								filenametmp.ToLower().EndsWith(".774") ||
								filenametmp.ToLower().EndsWith(".rds") ||
								filenametmp.ToLower().EndsWith(".rde") ||
								filenametmp.ToLower().EndsWith(".ds_store") ||
								filenametmp.ToLower().EndsWith("thumbs.db")
								)
							{
								listBoxGarbageFiles.Items.Add(filenametmp);
								garbage++;
							}
						}
					}
					
					if (garbage != 0)
					{
						listBoxGarbageFiles.Enabled = true;

					}

					if (resultbmpcnt + resultwavcnt + resultbpmcnt + resultstopcnt + resulttextcnt != 0)
					{
						comboBoxUnused.Enabled = true;
						comboBoxUnused.SelectedIndex = 0;						
					}

					// �I���܂��� 
					MessageBox.Show(
						garbage + " �̕s�v�ȃt�@�C���𔭌����܂����B\n" + 
						syntaxerrcnt + " �̍\���G���[�𔭌����܂����B\n" + 
						resultwavcnt + " �̖��g�p#WAV��`�𔭌����܂����B\n" + 
						resultbmpcnt + " �̖��g�p#BMP��`�𔭌����܂����B\n" +
						resultbpmcnt + " �̖��g�p#BPM��`�𔭌����܂����B\n" +
						resultstopcnt + " �̖��g�p#STOP��`�𔭌����܂����B\n" +
						resulttextcnt + " �̖��g�p#TEXT��`�𔭌����܂����B",
						"���s����");

					labelGenre.Text = genre;
					labelArtist.Text = artist;
					labelTitle.Text = title;
					labelBGA.Text = url;

					// �v���O���X�o�[������
					progressBar.Value = 0;
					// �J�[�\�������ɖ߂�
					this.Cursor = Cursors.Default;
					// �^�C�g���o�[�����ɖ߂�
					this.Text = titletext;
					// ���[�_�[�I��
					reader.Close();

				}
					#endregion
				else
				{
					MessageBox.Show("BMS�t�@�C�� (*.bms;*.bme;*.bml) �ł͂���܂���B","�G���[");
				}
			}
			else if (textBoxBMSPath.Text == "")
			{
				// �p�X���󔒁I
				MessageBox.Show("BMS�t�@�C�����J���Ă��܂���B","�G���[");
			}
			else
			{
				// �t�@�C��������I
				MessageBox.Show("�w�肵���t�@�C����������܂���ł����B","�G���[");
			}

		}

		private void menuItemAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(titletext +
				"\nCopyright 2004 nulltask." +
				"\n\nThanks to : \n" +
				"aska sakurano, tokonats, Ruzeea, testers, users..."
				,"About BMS Optimizer");
		}

		private void menuItemOpen_Click(object sender, System.EventArgs e)
		{
			buttonOpen.PerformClick();
		}

		private System.Threading.Mutex mutex;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// this.Font = SystemInformation.MenuFont;
			ini_load(sender,e);
			vbmp3_init();

			// ��d�N���΍�
			mutex = new System.Threading.Mutex(false,"BMSOptimizer");
			if (mutex.WaitOne(0,false) == false)
			{
				this.Close();
			}

			// �X�v���b�V���\����ON����
				if (ShowSplash == "True")
				{

					// �X�v���b�V���\���I
					FormSplash splash = new FormSplash();
					splash.Show();

					// ��d�N���`�F�b�N
					if (mutex.WaitOne(0,false) == false)
					{
						splash.Close();
					}

					splash.Opacity = 1;
					Thread.Sleep(750);

					// �t�F�[�h�A�E�g����
					int i = 250; // �t�F�[�h�A�E�g����
					for(int j = i;j != 0 ; j--)
					{
						splash.Show();
						splash.Opacity = (double)j / i;
					}
			
					// ��
					splash.Close();
				}

			this.Text = titletext;
		}

		private void menuItemExit_Click(object sender, System.EventArgs e)
		{
			// �I��
			this.Close();
		}

		private void menuItemGeneralOptions_Click(object sender, System.EventArgs e)
		{
			// �I�v�V�����_�C�A���O
			FormGeneralOptions generaloptions = new FormGeneralOptions();
			generaloptions.ShowDialog();
			ini_load(sender,e);
		}

		private void FormMain_Closed(object sender, System.EventArgs e)
		{
			// mutex���U
			mutex.Close();
			// buffer = null;
			vbmp3_free();
		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			if (listBoxGarbageFiles.SelectedItems.Count > 0)
			{
				if(AskDelete == "True")
				{
					DialogResult myResult;
					myResult = MessageBox.Show("�I�������t�@�C���͍폜����܂��B\n�{���Ɏ��s���܂����H",
						"�m�F",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Question);

					if (myResult == DialogResult.OK)
					{
						Delete_Process();
					}
				}
				else
				{
					Delete_Process();
				}
			}
			else
			{
				MessageBox.Show("���X�g����t�@�C����I�����Ă��������B","�G���[");
			}
		}

		private void Delete_Process ()
		{
			this.Text = titletext + " Deleting...";
			int errcnt = 0;
			foreach (Object SelectItem in listBoxGarbageFiles.SelectedItems)
			{
				try
				{
					if(DelOption == "Completely")
					{
						File.Delete(currentpath + "\\" + SelectItem.ToString());
					}
					else
					{
						Shell.SHFILEOPSTRUCT sh = new Shell.SHFILEOPSTRUCT();
                        
						sh.hwnd = this.Handle;
						sh.wFunc = Shell.FOFunc.FO_DELETE;
						sh.pFrom = currentpath + "\\" + SelectItem.ToString() + '\0' + '\0';
						sh.pTo = null;
						sh.fFlags = Shell.FOFlags.FOF_NOCOPYSECURITYATTRIBS;
						sh.fAnyOperationsAborted = false;
						sh.hNameMappings = IntPtr.Zero;
						sh.lpszProgressTitle = "Hello";
						int result = Shell.SHFileOperation(ref sh);
					}
				}
					// �R�s�[���ɂȂ����t�@�C���������I
				catch (System.IO.FileNotFoundException)
				{
					MessageBox.Show("�폜���Ƀt�@�C��������܂���ł����B\n" + SelectItem.ToString(),"�G���[");
					errcnt++;
				}
			}
			atoshoridayoon();
					
			if (errcnt == 0)
			{
				MessageBox.Show("�t�@�C���̍폜�ɐ������܂����B","���s����");
			}
			else
			{
				MessageBox.Show(errcnt + " �̃G���[���������܂����B","���s����");
			}

		}

		private void buttonMove_Click(object sender, System.EventArgs e)
		{
			if (listBoxGarbageFiles.SelectedItems.Count > 0)
			{
				// Move move = new Move();
				// move.ShowDialog();
				int errcnt = 0;
				this.Text = titletext + " Moving...";
				Directory.CreateDirectory(currentpath + "\\@moved");
				foreach (Object SelectItem in listBoxGarbageFiles.SelectedItems)
				{
					try
					{
						File.Move(currentpath + "\\" + SelectItem.ToString(), currentpath + "\\@moved\\" + SelectItem.ToString());
					}
					// �ړ����ɂȂ����t�@�C���������I
					catch (System.IO.FileNotFoundException)
					{
						MessageBox.Show("�ړ����Ƀt�@�C��������܂���ł����B\n" + SelectItem.ToString(),"�G���[");
						errcnt++;
					}
					// �ړ���ɂ��łɃt�@�C��������I
					catch (System.IO.IOException)
					{
						MessageBox.Show("�ړ���Ɋ��Ƀt�@�C��������܂��B\n" + SelectItem.ToString(),"�G���[");
						errcnt++;
					}
				}
				atoshoridayoon();

				if (errcnt == 0)
				{
					MessageBox.Show("�t�@�C���̈ړ��ɐ������܂����B","���s����");
				}
				else
				{
					MessageBox.Show(errcnt + " �̃G���[���������܂����B","���s����");
				}
				
			}
			else
			{
				MessageBox.Show("���X�g����t�@�C����I�����Ă��������B","�G���[");
			}
		}

		private void buttonCopy_Click(object sender, System.EventArgs e)
		{
			if (listBoxGarbageFiles.SelectedItems.Count > 0)
			{				
				this.Text = titletext + " Copying...";
				Directory.CreateDirectory(currentpath + "\\@copied");
				int errcnt = 0;
				foreach (Object SelectItem in listBoxGarbageFiles.SelectedItems)
				{
					try
					{
						File.Copy(currentpath + "\\" + SelectItem.ToString(), currentpath + "\\@copied\\" + SelectItem.ToString());
					}
					// �R�s�[���ɂȂ����t�@�C���������I
					catch (System.IO.FileNotFoundException)
					{
						MessageBox.Show("�R�s�[���Ƀt�@�C��������܂���ł����B\n" + SelectItem.ToString(),"�G���[");
						errcnt++;
					}
					// �R�s�[��ɂ��łɃt�@�C��������I
					catch (System.IO.IOException)
					{
						MessageBox.Show("�R�s�[��Ɋ��Ƀt�@�C��������܂��B\n" + SelectItem.ToString(),"�G���[");
						errcnt++;
					}
				}
				atoshoridayoon();

				if (errcnt == 0)
				{
					MessageBox.Show("�t�@�C���̃R�s�[�ɐ������܂����B","���s����");
				}
				else
				{
					MessageBox.Show(errcnt + " �̃G���[���������܂����B","���s����");
				}
				
			}
			else
			{
				MessageBox.Show("���X�g����t�@�C����I�����Ă��������B","�G���[");
			}
		}

		private void menuItemFile_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://nulltask.bms.bz/");
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			int i = 0;
			while (i < listBoxGarbageFiles.Items.Count)
			{
				listBoxGarbageFiles.SetSelected(i, true);
				i++;
			}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			int i = 0;
			while (i < listBoxGarbageFiles.Items.Count)
			{
				listBoxGarbageFiles.SetSelected(i, false);
				i++;
			}

		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://nulltask.bms.bz/cgi-bin/patio/patio.cgi?mode=view&no=1");
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			if (File.Exists(exePath + @"\BMSOptimizer.txt"))
			{
				System.Diagnostics.Process.Start(exePath + @"\BMSOptimizer.txt");
			}
			else
			{
				MessageBox.Show("���A���[�h�~�[���Ȃ�����Ȃ����I\n�ȁA�Ȃ�Ă������I�I�I�I","�G���[");
			}
		}

		private void listBoxGarbageFiles_DoubleClick(object sender, System.EventArgs e)
		{
			vbmp3_stop();
			
			if (listBoxGarbageFiles.SelectedItem != null)
			{
				string itemname = listBoxGarbageFiles.SelectedItem.ToString().ToLower();

				if (itemname.EndsWith(".bmp") ||
					itemname.EndsWith(".jpg") ||
					itemname.EndsWith(".jpeg") ||
					itemname.EndsWith(".png") ||
					itemname.EndsWith(".gif")
					)
				{
					this.Text = titletext + " Loading...";
					try
					{
						labelBGA.Image = Image.FromFile(currentpath + @"\" + listBoxGarbageFiles.SelectedItem.ToString());
					}
					catch
					{
						MessageBox.Show("�摜�t�@�C���ǂݍ��ݒ��ɃG���[���������܂����B","�G���[");
					}
					this.Text = titletext;
				}

				if (itemname.EndsWith(".wav"))
				{
					this.Text = titletext + " Loading...";
					try
					{
						/*// �t�@�C������o�C�g�z��ɓǂݍ���
						FileStream stream;
						BinaryReader reader;
						stream = new FileStream(currentpath + @"\" + listBoxGarbageFiles.SelectedItem.ToString(), FileMode.Open, FileAccess.Read );
						reader = new BinaryReader( stream );
						buffer = reader.ReadBytes( (int)stream.Length );
						reader.Close();
						stream.Close();
						*/

						/*// �o�b�t�@����Đ�
						PlaySound( buffer, 0, SND_MEMORY | SND_ASYNC );
						*/

						// �t�@�C������Đ�
						PlaySound( currentpath + @"\" + listBoxGarbageFiles.SelectedItem.ToString(), 0, SND_ASYNC );

					}
					catch
					{
						MessageBox.Show("�����t�@�C���ǂݍ��ݒ��ɃG���[���������܂����B","�G���[");
					}
					this.Text = titletext;
				}

				if (itemname.EndsWith(".mp3"))
				{
					this.Text = titletext + " Loading...";
					try
					{
						InputInfo data = new InputInfo();
						if(vbmp3_open(currentpath + @"\" + listBoxGarbageFiles.SelectedItem.ToString(), ref data))
						{
							vbmp3_play();
						}
					}
					catch
					{
						MessageBox.Show("�����t�@�C���ǂݍ��ݒ��ɃG���[���������܂����B","�G���[");
					}
					this.Text = titletext;
				}
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{	
			if (textBoxBMSPath.Text == "")
			{
				MessageBox.Show("BMS�t�@�C�����J���Ă��܂���B","�G���[");
			}
			else if(File.Exists(textBoxBMSPath.Text) == false)
			{
				MessageBox.Show("BMS�t�@�C����������܂���ł����B","�G���[");
			}
			else
			{
				try
				{
					System.Diagnostics.Process.Start(PlayerPath,PlayerOption.Replace("<filename>",textBoxBMSPath.Text));
				}
				catch
				{
					MessageBox.Show("�v���C����������܂���B\n�I�v�V�����Őݒ肵�Ă��������B","�G���[");
				}
			}
		}

		private void textBoxBMSPath_TextChanged(object sender, System.EventArgs e)
		{
			listBoxGarbageFiles.Items.Clear();
			listBoxGarbageFiles.Enabled = false;
			comboBoxUnused.Enabled = false;
			labelBGA.Image = null;
			comboBoxUnused.Items.Clear();

			DisplayInit();


		}

		private void atoshoridayoon()
		{
			this.Text = titletext;
			listBoxGarbageFiles.Items.Clear();
			textBoxBMSPath.Clear();
			listBoxGarbageFiles.Enabled = false;
			comboBoxUnused.Enabled = false;
			labelBGA.Image = null;

			DisplayInit();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if (textBoxBMSPath.Text == "")
			{
				MessageBox.Show("BMS�t�@�C�����J���Ă��܂���B","�G���[");
			}
			else if(File.Exists(textBoxBMSPath.Text) == false)
			{
				MessageBox.Show("BMS�t�@�C����������܂���ł����B","�G���[");
			}		
			else
			{
				try
				{
					System.Diagnostics.Process.Start(EditorPath, EditorOption.Replace("<filename>",textBoxBMSPath.Text));
				}
				catch
				{
					MessageBox.Show("�G�f�B�^��������܂���B\n�I�v�V�����Őݒ肵�Ă��������B","�G���[");
				}
			}
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			if (listBoxGarbageFiles.SelectedIndex != -1)
			{
				listBoxGarbageFiles.Items.RemoveAt(listBoxGarbageFiles.SelectedIndex);
			}
		}

		private void labelBGA_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (labelBGA.Text.StartsWith("http://"))
			{
				System.Diagnostics.Process.Start(labelBGA.Text);
			}
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			labelBGA.Image = null;
		}
	}
}
