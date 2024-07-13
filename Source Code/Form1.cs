using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using SpeechLib;

namespace SpeechTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.Button cmdEnable;
		private System.Windows.Forms.Button cmdDiable;

		private SpeechLib.SpSharedRecoContext objRecoContext = null;
		private SpeechLib.ISpeechRecoGrammar grammar = null;
		private SpeechLib.ISpeechGrammarRule menuRule=null;
		
		private System.Windows.Forms.TextBox txtHyp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtReco;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button1;
        private IContainer components;

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
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.cmdEnable = new System.Windows.Forms.Button();
            this.cmdDiable = new System.Windows.Forms.Button();
            this.txtHyp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem7});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6});
            this.menuItem1.Text = "&Archivo";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Nuevo";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Abrir";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "Ce&rrar";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "Sal&ir";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem9,
            this.menuItem10,
            this.menuItem11});
            this.menuItem7.Text = "&Edición";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "Co&piar";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "&Copy";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.Text = "&Paste";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 3;
            this.menuItem11.Text = "D&elete";
            // 
            // cmdEnable
            // 
            this.cmdEnable.Location = new System.Drawing.Point(16, 16);
            this.cmdEnable.Name = "cmdEnable";
            this.cmdEnable.Size = new System.Drawing.Size(96, 39);
            this.cmdEnable.TabIndex = 0;
            this.cmdEnable.Text = "Habilitar reconocimiento";
            this.cmdEnable.Click += new System.EventHandler(this.cmdEnable_Click);
            // 
            // cmdDiable
            // 
            this.cmdDiable.Location = new System.Drawing.Point(152, 16);
            this.cmdDiable.Name = "cmdDiable";
            this.cmdDiable.Size = new System.Drawing.Size(96, 39);
            this.cmdDiable.TabIndex = 0;
            this.cmdDiable.Text = "deshabilitar reconocimiento";
            this.cmdDiable.Click += new System.EventHandler(this.cmdDiable_Click);
            // 
            // txtHyp
            // 
            this.txtHyp.Location = new System.Drawing.Point(106, 106);
            this.txtHyp.Name = "txtHyp";
            this.txtHyp.Size = new System.Drawing.Size(168, 20);
            this.txtHyp.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hipótesis";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reconocimiento";
            // 
            // txtReco
            // 
            this.txtReco.Location = new System.Drawing.Point(106, 146);
            this.txtReco.Name = "txtReco";
            this.txtReco.Size = new System.Drawing.Size(168, 20);
            this.txtReco.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 72);
            this.label3.TabIndex = 7;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 23);
            this.label4.TabIndex = 8;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 230);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "se pide:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHyp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReco);
            this.Controls.Add(this.cmdEnable);
            this.Controls.Add(this.cmdDiable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habla por mi!";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void cmdEnable_Click(object sender, System.EventArgs e)
		{
			label4.Text = "Inicializando el motor del habla...";
			// Get an insance of RecoContext. I am using the shared RecoContext.
			objRecoContext = new SpeechLib.SpSharedRecoContext();
			// Assign a eventhandler for the Hypothesis Event.
			objRecoContext.Hypothesis += new _ISpeechRecoContextEvents_HypothesisEventHandler(Hypo_Event);
			// Assign a eventhandler for the Recognition Event.
			objRecoContext.Recognition += new 
				_ISpeechRecoContextEvents_RecognitionEventHandler(Reco_Event);
			//Creating an instance of the grammer object.
			grammar = objRecoContext.CreateGrammar(0);			
			label3.Text = "Pronuncia uno de los siguientes.\r\n1. New 2. Open 3. Close 4. Exit\r\n5. Cut 6. Copy 7. Paste 8. Delete";
			//Activate the Menu Commands.			
			menuRule = grammar.Rules.Add("MenuCommands",SpeechRuleAttributes.SRATopLevel|SpeechRuleAttributes.SRADynamic,1);
			object      PropValue = "";
			menuRule.InitialState.AddWordTransition(null,"New"," ",SpeechGrammarWordType.SGLexical,"New", 1, ref PropValue, 1.0F );
			menuRule.InitialState.AddWordTransition(null,"Open"," ",SpeechGrammarWordType.SGLexical,"Open", 2, ref PropValue, 1.0F );
			menuRule.InitialState.AddWordTransition(null,"Close"," ",SpeechGrammarWordType.SGLexical,"Close",3, ref PropValue, 1.0F );
			menuRule.InitialState.AddWordTransition(null,"Exit"," ",SpeechGrammarWordType.SGLexical,"Exit",4, ref PropValue, 1.0F );
			menuRule.InitialState.AddWordTransition(null,"Cut"," ",SpeechGrammarWordType.SGLexical,"Cut",5, ref PropValue, 1.0F );
			menuRule.InitialState.AddWordTransition(null,"Copy"," ",SpeechGrammarWordType.SGLexical,"Copy",6, ref PropValue, 1.0F );
			menuRule.InitialState.AddWordTransition(null,"Paste"," ",SpeechGrammarWordType.SGLexical,"Paste",7, ref PropValue, 1.0F );
			menuRule.InitialState.AddWordTransition(null,"Delete"," ",SpeechGrammarWordType.SGLexical,"Delete",8, ref PropValue, 1.0F );
			grammar.Rules.Commit();
			grammar.CmdSetRuleState("MenuCommands", SpeechRuleState.SGDSActive);
			label4.Text = "Listo!";
		}

		private void Reco_Event(int StreamNumber, object StreamPosition,SpeechRecognitionType RecognitionType,ISpeechRecoResult Result)
		{
			txtReco.Text = Result.PhraseInfo.GetText(0, -1, true);
            if (txtReco.Text == "New")
                MessageBox.Show("Dijiste New");//aquí puedo saber cuando se reconoce palabra
            toolStripStatusLabel1.Text = "Dijiste New";
		}

		private void Hypo_Event(int StreamNumber, object StreamPosition, ISpeechRecoResult Result)
		{
			txtHyp.Text = Result.PhraseInfo.GetText(0, -1, true);

		}

		private void cmdDiable_Click(object sender, System.EventArgs e)
		{
			label3.Text = "";
			objRecoContext = null;
			label4.Text="";
		}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuItem7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mejorar el ejemplo de tal manera que aparezca\n un personaje creado por ustedes en Ilustrator y que al cargarlo\n y pronunciar por ejemplo\n word...que cargue Microsoft Word!\n....o al pronunciar quiero navegar que cargue Crhome!");
        }

	}
}
