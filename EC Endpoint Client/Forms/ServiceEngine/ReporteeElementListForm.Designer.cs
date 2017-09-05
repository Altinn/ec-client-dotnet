namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    partial class ReporteeElementListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GetCorrListForArch = new System.Windows.Forms.TabPage();
            this.btn_GPDSaveResult = new System.Windows.Forms.Button();
            this.btn_GPDLoadShip = new System.Windows.Forms.Button();
            this.btn_GPDShowResult = new System.Windows.Forms.Button();
            this.btn_GPDSaveShip = new System.Windows.Forms.Button();
            this.btn_GPDInvoke = new System.Windows.Forms.Button();
            this.btn_GPDShowShip = new System.Windows.Forms.Button();
            this.GetCorrListForRep = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.GetFS = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.GetRE = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.DeleteRE = new System.Windows.Forms.TabPage();
            this.button20 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.TestPage = new System.Windows.Forms.TabPage();
            this.btn_TestInvoke = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GetCorrListForArch.SuspendLayout();
            this.GetCorrListForRep.SuspendLayout();
            this.GetFS.SuspendLayout();
            this.GetRE.SuspendLayout();
            this.DeleteRE.SuspendLayout();
            this.TestPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.tabControl1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GetCorrListForArch);
            this.tabControl1.Controls.Add(this.GetCorrListForRep);
            this.tabControl1.Controls.Add(this.GetFS);
            this.tabControl1.Controls.Add(this.GetRE);
            this.tabControl1.Controls.Add(this.DeleteRE);
            this.tabControl1.Controls.Add(this.TestPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 3;
            // 
            // GetCorrListForArch
            // 
            this.GetCorrListForArch.Controls.Add(this.btn_GPDSaveResult);
            this.GetCorrListForArch.Controls.Add(this.btn_GPDLoadShip);
            this.GetCorrListForArch.Controls.Add(this.btn_GPDShowResult);
            this.GetCorrListForArch.Controls.Add(this.btn_GPDSaveShip);
            this.GetCorrListForArch.Controls.Add(this.btn_GPDInvoke);
            this.GetCorrListForArch.Controls.Add(this.btn_GPDShowShip);
            this.GetCorrListForArch.Location = new System.Drawing.Point(4, 22);
            this.GetCorrListForArch.Name = "GetCorrListForArch";
            this.GetCorrListForArch.Padding = new System.Windows.Forms.Padding(3);
            this.GetCorrListForArch.Size = new System.Drawing.Size(417, 343);
            this.GetCorrListForArch.TabIndex = 0;
            this.GetCorrListForArch.Text = "GetCorrespondenceListForArchiveRef";
            this.GetCorrListForArch.UseVisualStyleBackColor = true;
            // 
            // btn_GPDSaveResult
            // 
            this.btn_GPDSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_GPDSaveResult.Name = "btn_GPDSaveResult";
            this.btn_GPDSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDSaveResult.TabIndex = 7;
            this.btn_GPDSaveResult.Text = "Save Result";
            this.btn_GPDSaveResult.UseVisualStyleBackColor = true;
            this.btn_GPDSaveResult.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btn_GPDLoadShip
            // 
            this.btn_GPDLoadShip.Location = new System.Drawing.Point(6, 64);
            this.btn_GPDLoadShip.Name = "btn_GPDLoadShip";
            this.btn_GPDLoadShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDLoadShip.TabIndex = 8;
            this.btn_GPDLoadShip.Text = "Load Shipment";
            this.btn_GPDLoadShip.UseVisualStyleBackColor = true;
            this.btn_GPDLoadShip.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btn_GPDShowResult
            // 
            this.btn_GPDShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_GPDShowResult.Name = "btn_GPDShowResult";
            this.btn_GPDShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDShowResult.TabIndex = 9;
            this.btn_GPDShowResult.Text = "Show Result";
            this.btn_GPDShowResult.UseVisualStyleBackColor = true;
            this.btn_GPDShowResult.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btn_GPDSaveShip
            // 
            this.btn_GPDSaveShip.Location = new System.Drawing.Point(6, 35);
            this.btn_GPDSaveShip.Name = "btn_GPDSaveShip";
            this.btn_GPDSaveShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDSaveShip.TabIndex = 10;
            this.btn_GPDSaveShip.Text = "Save Shipment";
            this.btn_GPDSaveShip.UseVisualStyleBackColor = true;
            this.btn_GPDSaveShip.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btn_GPDInvoke
            // 
            this.btn_GPDInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_GPDInvoke.Name = "btn_GPDInvoke";
            this.btn_GPDInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDInvoke.TabIndex = 11;
            this.btn_GPDInvoke.Text = "Invoke Service";
            this.btn_GPDInvoke.UseVisualStyleBackColor = true;
            this.btn_GPDInvoke.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btn_GPDShowShip
            // 
            this.btn_GPDShowShip.Location = new System.Drawing.Point(6, 6);
            this.btn_GPDShowShip.Name = "btn_GPDShowShip";
            this.btn_GPDShowShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDShowShip.TabIndex = 12;
            this.btn_GPDShowShip.Text = "Show Shipment";
            this.btn_GPDShowShip.UseVisualStyleBackColor = true;
            this.btn_GPDShowShip.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // GetCorrListForRep
            // 
            this.GetCorrListForRep.Controls.Add(this.button1);
            this.GetCorrListForRep.Controls.Add(this.button2);
            this.GetCorrListForRep.Controls.Add(this.button3);
            this.GetCorrListForRep.Controls.Add(this.button4);
            this.GetCorrListForRep.Controls.Add(this.button5);
            this.GetCorrListForRep.Controls.Add(this.button6);
            this.GetCorrListForRep.Location = new System.Drawing.Point(4, 22);
            this.GetCorrListForRep.Name = "GetCorrListForRep";
            this.GetCorrListForRep.Padding = new System.Windows.Forms.Padding(3);
            this.GetCorrListForRep.Size = new System.Drawing.Size(417, 343);
            this.GetCorrListForRep.TabIndex = 2;
            this.GetCorrListForRep.Text = "GetCorrespondenceListForReportee";
            this.GetCorrListForRep.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Load Shipment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Show Result";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Save Shipment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(294, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Invoke Service";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Show Shipment";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // GetFS
            // 
            this.GetFS.Controls.Add(this.button7);
            this.GetFS.Controls.Add(this.button8);
            this.GetFS.Controls.Add(this.button9);
            this.GetFS.Controls.Add(this.button10);
            this.GetFS.Controls.Add(this.button11);
            this.GetFS.Controls.Add(this.button12);
            this.GetFS.Location = new System.Drawing.Point(4, 22);
            this.GetFS.Name = "GetFS";
            this.GetFS.Padding = new System.Windows.Forms.Padding(3);
            this.GetFS.Size = new System.Drawing.Size(417, 343);
            this.GetFS.TabIndex = 3;
            this.GetFS.Text = "GetFormSetElements";
            this.GetFS.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(294, 64);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Save Result";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 64);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Load Shipment";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(294, 35);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Show Result";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 35);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 23);
            this.button10.TabIndex = 16;
            this.button10.Text = "Save Shipment";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(294, 6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 23);
            this.button11.TabIndex = 17;
            this.button11.Text = "Invoke Service";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(118, 23);
            this.button12.TabIndex = 18;
            this.button12.Text = "Show Shipment";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // GetRE
            // 
            this.GetRE.Controls.Add(this.button13);
            this.GetRE.Controls.Add(this.button14);
            this.GetRE.Controls.Add(this.button15);
            this.GetRE.Controls.Add(this.button16);
            this.GetRE.Controls.Add(this.button17);
            this.GetRE.Controls.Add(this.button18);
            this.GetRE.Location = new System.Drawing.Point(4, 22);
            this.GetRE.Name = "GetRE";
            this.GetRE.Padding = new System.Windows.Forms.Padding(3);
            this.GetRE.Size = new System.Drawing.Size(417, 343);
            this.GetRE.TabIndex = 4;
            this.GetRE.Text = "GetReporteeElementList";
            this.GetRE.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(294, 64);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(118, 23);
            this.button13.TabIndex = 13;
            this.button13.Text = "Save Result";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 64);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(118, 23);
            this.button14.TabIndex = 14;
            this.button14.Text = "Load Shipment";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(294, 35);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(118, 23);
            this.button15.TabIndex = 15;
            this.button15.Text = "Show Result";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 35);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(118, 23);
            this.button16.TabIndex = 16;
            this.button16.Text = "Save Shipment";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(294, 6);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(118, 23);
            this.button17.TabIndex = 17;
            this.button17.Text = "Invoke Service";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(6, 6);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(118, 23);
            this.button18.TabIndex = 18;
            this.button18.Text = "Show Shipment";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // DeleteRE
            // 
            this.DeleteRE.Controls.Add(this.button20);
            this.DeleteRE.Controls.Add(this.button22);
            this.DeleteRE.Controls.Add(this.button23);
            this.DeleteRE.Controls.Add(this.button24);
            this.DeleteRE.Location = new System.Drawing.Point(4, 22);
            this.DeleteRE.Name = "DeleteRE";
            this.DeleteRE.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteRE.Size = new System.Drawing.Size(417, 343);
            this.DeleteRE.TabIndex = 5;
            this.DeleteRE.Text = "DeleteReporteeElement";
            this.DeleteRE.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(6, 64);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(118, 23);
            this.button20.TabIndex = 14;
            this.button20.Text = "Load Shipment";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(6, 35);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(118, 23);
            this.button22.TabIndex = 16;
            this.button22.Text = "Save Shipment";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(294, 6);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(118, 23);
            this.button23.TabIndex = 17;
            this.button23.Text = "Invoke Service";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(6, 6);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(118, 23);
            this.button24.TabIndex = 18;
            this.button24.Text = "Show Shipment";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // TestPage
            // 
            this.TestPage.Controls.Add(this.btn_TestInvoke);
            this.TestPage.Location = new System.Drawing.Point(4, 22);
            this.TestPage.Name = "TestPage";
            this.TestPage.Padding = new System.Windows.Forms.Padding(3);
            this.TestPage.Size = new System.Drawing.Size(417, 343);
            this.TestPage.TabIndex = 1;
            this.TestPage.Text = "Test";
            this.TestPage.UseVisualStyleBackColor = true;
            // 
            // btn_TestInvoke
            // 
            this.btn_TestInvoke.Location = new System.Drawing.Point(6, 6);
            this.btn_TestInvoke.Name = "btn_TestInvoke";
            this.btn_TestInvoke.Size = new System.Drawing.Size(106, 23);
            this.btn_TestInvoke.TabIndex = 0;
            this.btn_TestInvoke.Text = "Test";
            this.btn_TestInvoke.UseVisualStyleBackColor = true;
            this.btn_TestInvoke.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // ReporteeElementListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "ReporteeElementListForm";
            this.Text = "ReporteeElementListForm";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.GetCorrListForArch.ResumeLayout(false);
            this.GetCorrListForRep.ResumeLayout(false);
            this.GetFS.ResumeLayout(false);
            this.GetRE.ResumeLayout(false);
            this.DeleteRE.ResumeLayout(false);
            this.TestPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GetCorrListForArch;
        private System.Windows.Forms.Button btn_GPDSaveResult;
        private System.Windows.Forms.Button btn_GPDLoadShip;
        private System.Windows.Forms.Button btn_GPDShowResult;
        private System.Windows.Forms.Button btn_GPDSaveShip;
        private System.Windows.Forms.Button btn_GPDInvoke;
        private System.Windows.Forms.Button btn_GPDShowShip;
        private System.Windows.Forms.TabPage GetCorrListForRep;
        private System.Windows.Forms.TabPage TestPage;
        private System.Windows.Forms.Button btn_TestInvoke;
        private System.Windows.Forms.TabPage GetFS;
        private System.Windows.Forms.TabPage GetRE;
        private System.Windows.Forms.TabPage DeleteRE;
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
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}