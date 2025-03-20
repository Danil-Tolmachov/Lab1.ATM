namespace ATM.DesktopApp
{
    partial class ATMForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            infoLabel = new Label();
            textLabel = new Label();
            inputTextBox = new TextBox();
            buttonDigit1 = new Button();
            buttonDigit2 = new Button();
            buttonDigit3 = new Button();
            buttonDigit4 = new Button();
            buttonDigit5 = new Button();
            buttonDigit6 = new Button();
            buttonDigit7 = new Button();
            buttonDigit8 = new Button();
            buttonDigit9 = new Button();
            buttonDigit0 = new Button();
            buttonBackspace = new Button();
            buttonEnter = new Button();
            loginPanel = new Panel();
            depositPanel = new Panel();
            depositLabel = new Label();
            goBackButton_Deposit = new Button();
            depositTextBox = new TextBox();
            withdrawPanel = new Panel();
            withdrawLabel = new Label();
            goBackButton_Withdraw = new Button();
            withdrawTextBox = new TextBox();
            keyBoardPanel = new Panel();
            balancePanel = new Panel();
            sendToCardButton = new Button();
            withdrawButton = new Button();
            depositButton = new Button();
            balanceLabel = new Label();
            goBackButton_Balance = new Button();
            mainMenuPanel = new Panel();
            showNearAtmPageButton = new Button();
            showHistoryPageButton = new Button();
            showBalancePageButton = new Button();
            mainMenuLabel = new Label();
            goBackButton_MainMenu = new Button();
            sendToCardPanel = new Panel();
            sendToCardInfoLabel = new Label();
            sendToCardLabel = new Label();
            goBackButton_SendToCard = new Button();
            sendToCardTextBox = new TextBox();
            nearAtmsPanel = new Panel();
            goBackButton_NearAtm = new Button();
            nearAtmInfoLabel = new Label();
            nearAtmLabel = new Label();
            historyPanel = new Panel();
            goBackButton_History = new Button();
            historyInfoLabel = new Label();
            historyLabel = new Label();
            loginPanel.SuspendLayout();
            depositPanel.SuspendLayout();
            withdrawPanel.SuspendLayout();
            keyBoardPanel.SuspendLayout();
            balancePanel.SuspendLayout();
            mainMenuPanel.SuspendLayout();
            sendToCardPanel.SuspendLayout();
            nearAtmsPanel.SuspendLayout();
            historyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(265, 133);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(0, 13);
            infoLabel.TabIndex = 0;
            infoLabel.Tag = "infoLabel";
            infoLabel.Visible = false;
            // 
            // textLabel
            // 
            textLabel.Font = new Font("Segoe UI", 20F);
            textLabel.Location = new Point(238, 90);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(304, 58);
            textLabel.TabIndex = 1;
            textLabel.Tag = "statusLabel";
            textLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputTextBox
            // 
            inputTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputTextBox.Font = new Font("Segoe UI", 18F);
            inputTextBox.Location = new Point(265, 165);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(250, 39);
            inputTextBox.TabIndex = 2;
            inputTextBox.Tag = "inputTextBox";
            inputTextBox.TextAlign = HorizontalAlignment.Center;
            inputTextBox.Click += inputTextBox_Click;
            // 
            // buttonDigit1
            // 
            buttonDigit1.Location = new Point(244, 35);
            buttonDigit1.Name = "buttonDigit1";
            buttonDigit1.Size = new Size(55, 55);
            buttonDigit1.TabIndex = 3;
            buttonDigit1.Text = "1";
            buttonDigit1.UseVisualStyleBackColor = true;
            buttonDigit1.Click += buttonDigit1_Click;
            // 
            // buttonDigit2
            // 
            buttonDigit2.Location = new Point(352, 35);
            buttonDigit2.Name = "buttonDigit2";
            buttonDigit2.Size = new Size(55, 55);
            buttonDigit2.TabIndex = 4;
            buttonDigit2.Text = "2";
            buttonDigit2.UseVisualStyleBackColor = true;
            buttonDigit2.Click += buttonDigit2_Click;
            // 
            // buttonDigit3
            // 
            buttonDigit3.Location = new Point(457, 35);
            buttonDigit3.Name = "buttonDigit3";
            buttonDigit3.Size = new Size(55, 55);
            buttonDigit3.TabIndex = 5;
            buttonDigit3.Text = "3";
            buttonDigit3.UseVisualStyleBackColor = true;
            buttonDigit3.Click += buttonDigit3_Click;
            // 
            // buttonDigit4
            // 
            buttonDigit4.Location = new Point(244, 123);
            buttonDigit4.Name = "buttonDigit4";
            buttonDigit4.Size = new Size(55, 55);
            buttonDigit4.TabIndex = 8;
            buttonDigit4.Text = "4";
            buttonDigit4.UseVisualStyleBackColor = true;
            buttonDigit4.Click += buttonDigit4_Click;
            // 
            // buttonDigit5
            // 
            buttonDigit5.Location = new Point(352, 123);
            buttonDigit5.Name = "buttonDigit5";
            buttonDigit5.Size = new Size(55, 55);
            buttonDigit5.TabIndex = 7;
            buttonDigit5.Text = "5";
            buttonDigit5.UseVisualStyleBackColor = true;
            buttonDigit5.Click += buttonDigit5_Click;
            // 
            // buttonDigit6
            // 
            buttonDigit6.Location = new Point(457, 123);
            buttonDigit6.Name = "buttonDigit6";
            buttonDigit6.Size = new Size(55, 55);
            buttonDigit6.TabIndex = 6;
            buttonDigit6.Text = "6";
            buttonDigit6.UseVisualStyleBackColor = true;
            buttonDigit6.Click += buttonDigit6_Click;
            // 
            // buttonDigit7
            // 
            buttonDigit7.Location = new Point(244, 211);
            buttonDigit7.Name = "buttonDigit7";
            buttonDigit7.Size = new Size(55, 55);
            buttonDigit7.TabIndex = 11;
            buttonDigit7.Text = "7";
            buttonDigit7.UseVisualStyleBackColor = true;
            buttonDigit7.Click += buttonDigit7_Click;
            // 
            // buttonDigit8
            // 
            buttonDigit8.Location = new Point(352, 211);
            buttonDigit8.Name = "buttonDigit8";
            buttonDigit8.Size = new Size(55, 55);
            buttonDigit8.TabIndex = 10;
            buttonDigit8.Text = "8";
            buttonDigit8.UseVisualStyleBackColor = true;
            buttonDigit8.Click += buttonDigit8_Click;
            // 
            // buttonDigit9
            // 
            buttonDigit9.Location = new Point(457, 211);
            buttonDigit9.Name = "buttonDigit9";
            buttonDigit9.Size = new Size(55, 55);
            buttonDigit9.TabIndex = 9;
            buttonDigit9.Text = "9";
            buttonDigit9.UseVisualStyleBackColor = true;
            buttonDigit9.Click += buttonDigit9_Click;
            // 
            // buttonDigit0
            // 
            buttonDigit0.Location = new Point(352, 296);
            buttonDigit0.Name = "buttonDigit0";
            buttonDigit0.Size = new Size(55, 55);
            buttonDigit0.TabIndex = 12;
            buttonDigit0.Text = "0";
            buttonDigit0.UseVisualStyleBackColor = true;
            buttonDigit0.Click += buttonDigit0_Click;
            // 
            // buttonBackspace
            // 
            buttonBackspace.Location = new Point(244, 296);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(55, 55);
            buttonBackspace.TabIndex = 13;
            buttonBackspace.Text = "<---";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(457, 296);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(55, 55);
            buttonEnter.TabIndex = 14;
            buttonEnter.Text = "ENTER";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.None;
            loginPanel.Controls.Add(inputTextBox);
            loginPanel.Controls.Add(textLabel);
            loginPanel.Controls.Add(infoLabel);
            loginPanel.Location = new Point(-1, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(780, 600);
            loginPanel.TabIndex = 15;
            // 
            // depositPanel
            // 
            depositPanel.Controls.Add(depositLabel);
            depositPanel.Controls.Add(goBackButton_Deposit);
            depositPanel.Controls.Add(depositTextBox);
            depositPanel.Location = new Point(0, 0);
            depositPanel.Name = "depositPanel";
            depositPanel.Size = new Size(780, 600);
            depositPanel.TabIndex = 19;
            depositPanel.Visible = false;
            // 
            // depositLabel
            // 
            depositLabel.Font = new Font("Segoe UI", 20F);
            depositLabel.Location = new Point(238, 90);
            depositLabel.Name = "depositLabel";
            depositLabel.Size = new Size(304, 58);
            depositLabel.TabIndex = 25;
            depositLabel.Tag = "statusLabel";
            depositLabel.Text = "Enter Amount";
            depositLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // goBackButton_Deposit
            // 
            goBackButton_Deposit.Font = new Font("Segoe UI", 17F);
            goBackButton_Deposit.Location = new Point(23, 23);
            goBackButton_Deposit.Name = "goBackButton_Deposit";
            goBackButton_Deposit.Size = new Size(55, 55);
            goBackButton_Deposit.TabIndex = 25;
            goBackButton_Deposit.Text = "X";
            goBackButton_Deposit.UseVisualStyleBackColor = true;
            goBackButton_Deposit.Click += goBackButton_Deposit_Click;
            // 
            // depositTextBox
            // 
            depositTextBox.Font = new Font("Segoe UI", 18F);
            depositTextBox.Location = new Point(265, 165);
            depositTextBox.Name = "depositTextBox";
            depositTextBox.Size = new Size(250, 39);
            depositTextBox.TabIndex = 4;
            depositTextBox.Tag = "inputTextBox";
            depositTextBox.TextAlign = HorizontalAlignment.Center;
            depositTextBox.Click += depositInputTextBox_Click;
            // 
            // withdrawPanel
            // 
            withdrawPanel.Controls.Add(withdrawLabel);
            withdrawPanel.Controls.Add(goBackButton_Withdraw);
            withdrawPanel.Controls.Add(withdrawTextBox);
            withdrawPanel.Location = new Point(0, 0);
            withdrawPanel.Name = "withdrawPanel";
            withdrawPanel.Size = new Size(780, 600);
            withdrawPanel.TabIndex = 18;
            withdrawPanel.Visible = false;
            // 
            // withdrawLabel
            // 
            withdrawLabel.Font = new Font("Segoe UI", 20F);
            withdrawLabel.Location = new Point(238, 90);
            withdrawLabel.Name = "withdrawLabel";
            withdrawLabel.Size = new Size(304, 58);
            withdrawLabel.TabIndex = 25;
            withdrawLabel.Tag = "statusLabel";
            withdrawLabel.Text = "Enter Amount";
            withdrawLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // goBackButton_Withdraw
            // 
            goBackButton_Withdraw.Font = new Font("Segoe UI", 17F);
            goBackButton_Withdraw.Location = new Point(23, 23);
            goBackButton_Withdraw.Name = "goBackButton_Withdraw";
            goBackButton_Withdraw.Size = new Size(55, 55);
            goBackButton_Withdraw.TabIndex = 25;
            goBackButton_Withdraw.Text = "X";
            goBackButton_Withdraw.UseVisualStyleBackColor = true;
            goBackButton_Withdraw.Click += goBackButton_Withdraw_Click;
            // 
            // withdrawTextBox
            // 
            withdrawTextBox.Font = new Font("Segoe UI", 18F);
            withdrawTextBox.Location = new Point(265, 165);
            withdrawTextBox.Name = "withdrawTextBox";
            withdrawTextBox.Size = new Size(250, 39);
            withdrawTextBox.TabIndex = 3;
            withdrawTextBox.Tag = "inputTextBox";
            withdrawTextBox.TextAlign = HorizontalAlignment.Center;
            withdrawTextBox.Click += withdrawInputTextBox_Click;
            // 
            // keyBoardPanel
            // 
            keyBoardPanel.Controls.Add(buttonDigit3);
            keyBoardPanel.Controls.Add(buttonDigit7);
            keyBoardPanel.Controls.Add(buttonDigit1);
            keyBoardPanel.Controls.Add(buttonDigit0);
            keyBoardPanel.Controls.Add(buttonDigit8);
            keyBoardPanel.Controls.Add(buttonBackspace);
            keyBoardPanel.Controls.Add(buttonDigit9);
            keyBoardPanel.Controls.Add(buttonDigit6);
            keyBoardPanel.Controls.Add(buttonEnter);
            keyBoardPanel.Controls.Add(buttonDigit2);
            keyBoardPanel.Controls.Add(buttonDigit4);
            keyBoardPanel.Controls.Add(buttonDigit5);
            keyBoardPanel.Location = new Point(15, 233);
            keyBoardPanel.Name = "keyBoardPanel";
            keyBoardPanel.Size = new Size(781, 367);
            keyBoardPanel.TabIndex = 19;
            keyBoardPanel.Visible = false;
            // 
            // balancePanel
            // 
            balancePanel.Controls.Add(sendToCardButton);
            balancePanel.Controls.Add(withdrawButton);
            balancePanel.Controls.Add(depositButton);
            balancePanel.Controls.Add(balanceLabel);
            balancePanel.Controls.Add(goBackButton_Balance);
            balancePanel.Location = new Point(0, 0);
            balancePanel.Name = "balancePanel";
            balancePanel.Size = new Size(780, 600);
            balancePanel.TabIndex = 17;
            balancePanel.Visible = false;
            // 
            // sendToCardButton
            // 
            sendToCardButton.Font = new Font("Segoe UI", 17F);
            sendToCardButton.Location = new Point(265, 415);
            sendToCardButton.Name = "sendToCardButton";
            sendToCardButton.Size = new Size(260, 70);
            sendToCardButton.TabIndex = 32;
            sendToCardButton.Text = "Send To Card";
            sendToCardButton.UseVisualStyleBackColor = true;
            sendToCardButton.Click += sendToCardButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Segoe UI", 17F);
            withdrawButton.Location = new Point(265, 308);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(260, 70);
            withdrawButton.TabIndex = 31;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Font = new Font("Segoe UI", 17F);
            depositButton.Location = new Point(265, 193);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(260, 70);
            depositButton.TabIndex = 30;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // balanceLabel
            // 
            balanceLabel.Font = new Font("Segoe UI", 20F);
            balanceLabel.Location = new Point(90, 90);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(600, 58);
            balanceLabel.TabIndex = 27;
            balanceLabel.Tag = "statusLabel";
            balanceLabel.Text = "Balance";
            balanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // goBackButton_Balance
            // 
            goBackButton_Balance.Font = new Font("Segoe UI", 17F);
            goBackButton_Balance.Location = new Point(23, 23);
            goBackButton_Balance.Name = "goBackButton_Balance";
            goBackButton_Balance.Size = new Size(55, 55);
            goBackButton_Balance.TabIndex = 25;
            goBackButton_Balance.Text = "X";
            goBackButton_Balance.UseVisualStyleBackColor = true;
            goBackButton_Balance.Click += goBackButton_Balance_Click;
            // 
            // mainMenuPanel
            // 
            mainMenuPanel.Controls.Add(showNearAtmPageButton);
            mainMenuPanel.Controls.Add(showHistoryPageButton);
            mainMenuPanel.Controls.Add(showBalancePageButton);
            mainMenuPanel.Controls.Add(mainMenuLabel);
            mainMenuPanel.Controls.Add(goBackButton_MainMenu);
            mainMenuPanel.Location = new Point(0, 0);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(780, 600);
            mainMenuPanel.TabIndex = 16;
            mainMenuPanel.Visible = false;
            // 
            // showNearAtmPageButton
            // 
            showNearAtmPageButton.Font = new Font("Segoe UI", 17F);
            showNearAtmPageButton.Location = new Point(260, 415);
            showNearAtmPageButton.Name = "showNearAtmPageButton";
            showNearAtmPageButton.Size = new Size(260, 70);
            showNearAtmPageButton.TabIndex = 29;
            showNearAtmPageButton.Text = "Near ATMs";
            showNearAtmPageButton.UseVisualStyleBackColor = true;
            showNearAtmPageButton.Click += showNearAtmPageButton_Click;
            // 
            // showHistoryPageButton
            // 
            showHistoryPageButton.Font = new Font("Segoe UI", 17F);
            showHistoryPageButton.Location = new Point(260, 308);
            showHistoryPageButton.Name = "showHistoryPageButton";
            showHistoryPageButton.Size = new Size(260, 70);
            showHistoryPageButton.TabIndex = 28;
            showHistoryPageButton.Text = "Operation Histiory";
            showHistoryPageButton.UseVisualStyleBackColor = true;
            showHistoryPageButton.Click += showHistoryPageButton_Click;
            // 
            // showBalancePageButton
            // 
            showBalancePageButton.Font = new Font("Segoe UI", 17F);
            showBalancePageButton.Location = new Point(260, 193);
            showBalancePageButton.Name = "showBalancePageButton";
            showBalancePageButton.Size = new Size(260, 70);
            showBalancePageButton.TabIndex = 27;
            showBalancePageButton.Text = "Balance";
            showBalancePageButton.UseVisualStyleBackColor = true;
            showBalancePageButton.Click += showBalancePageButton_Click;
            // 
            // mainMenuLabel
            // 
            mainMenuLabel.Font = new Font("Segoe UI", 20F);
            mainMenuLabel.Location = new Point(238, 90);
            mainMenuLabel.Name = "mainMenuLabel";
            mainMenuLabel.Size = new Size(304, 58);
            mainMenuLabel.TabIndex = 24;
            mainMenuLabel.Tag = "statusLabel";
            mainMenuLabel.Text = "Welcome";
            mainMenuLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // goBackButton_MainMenu
            // 
            goBackButton_MainMenu.Font = new Font("Segoe UI", 17F);
            goBackButton_MainMenu.Location = new Point(23, 23);
            goBackButton_MainMenu.Name = "goBackButton_MainMenu";
            goBackButton_MainMenu.Size = new Size(55, 55);
            goBackButton_MainMenu.TabIndex = 26;
            goBackButton_MainMenu.Text = "X";
            goBackButton_MainMenu.UseVisualStyleBackColor = true;
            goBackButton_MainMenu.Click += goBackButton_MainMenu_Click;
            // 
            // sendToCardPanel
            // 
            sendToCardPanel.Anchor = AnchorStyles.None;
            sendToCardPanel.Controls.Add(sendToCardInfoLabel);
            sendToCardPanel.Controls.Add(sendToCardLabel);
            sendToCardPanel.Controls.Add(goBackButton_SendToCard);
            sendToCardPanel.Controls.Add(sendToCardTextBox);
            sendToCardPanel.Location = new Point(-1, 0);
            sendToCardPanel.Name = "sendToCardPanel";
            sendToCardPanel.Size = new Size(780, 600);
            sendToCardPanel.TabIndex = 22;
            sendToCardPanel.Visible = false;
            // 
            // sendToCardInfoLabel
            // 
            sendToCardInfoLabel.AutoSize = true;
            sendToCardInfoLabel.Location = new Point(136, 150);
            sendToCardInfoLabel.Name = "sendToCardInfoLabel";
            sendToCardInfoLabel.Size = new Size(0, 13);
            sendToCardInfoLabel.TabIndex = 26;
            sendToCardInfoLabel.Tag = "infoLabel";
            sendToCardInfoLabel.Visible = false;
            // 
            // sendToCardLabel
            // 
            sendToCardLabel.Font = new Font("Segoe UI", 20F);
            sendToCardLabel.Location = new Point(238, 90);
            sendToCardLabel.Name = "sendToCardLabel";
            sendToCardLabel.Size = new Size(304, 58);
            sendToCardLabel.TabIndex = 25;
            sendToCardLabel.Tag = "statusLabel";
            sendToCardLabel.Text = "Enter Card Number";
            sendToCardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // goBackButton_SendToCard
            // 
            goBackButton_SendToCard.Font = new Font("Segoe UI", 17F);
            goBackButton_SendToCard.Location = new Point(23, 23);
            goBackButton_SendToCard.Name = "goBackButton_SendToCard";
            goBackButton_SendToCard.Size = new Size(55, 55);
            goBackButton_SendToCard.TabIndex = 25;
            goBackButton_SendToCard.Text = "X";
            goBackButton_SendToCard.UseVisualStyleBackColor = true;
            goBackButton_SendToCard.Click += goBackButton_SendToCard_Click;
            // 
            // sendToCardTextBox
            // 
            sendToCardTextBox.Font = new Font("Segoe UI", 18F);
            sendToCardTextBox.Location = new Point(265, 165);
            sendToCardTextBox.Name = "sendToCardTextBox";
            sendToCardTextBox.Size = new Size(250, 39);
            sendToCardTextBox.TabIndex = 5;
            sendToCardTextBox.Tag = "inputTextBox";
            sendToCardTextBox.TextAlign = HorizontalAlignment.Center;
            sendToCardTextBox.Click += SendToCardInputTextBox_Click;
            // 
            // nearAtmsPanel
            // 
            nearAtmsPanel.Controls.Add(goBackButton_NearAtm);
            nearAtmsPanel.Controls.Add(nearAtmInfoLabel);
            nearAtmsPanel.Controls.Add(nearAtmLabel);
            nearAtmsPanel.Location = new Point(0, 0);
            nearAtmsPanel.Name = "nearAtmsPanel";
            nearAtmsPanel.Size = new Size(780, 600);
            nearAtmsPanel.TabIndex = 20;
            nearAtmsPanel.Visible = false;
            // 
            // goBackButton_NearAtm
            // 
            goBackButton_NearAtm.Font = new Font("Segoe UI", 17F);
            goBackButton_NearAtm.Location = new Point(23, 23);
            goBackButton_NearAtm.Name = "goBackButton_NearAtm";
            goBackButton_NearAtm.Size = new Size(55, 55);
            goBackButton_NearAtm.TabIndex = 23;
            goBackButton_NearAtm.Text = "X";
            goBackButton_NearAtm.UseVisualStyleBackColor = true;
            goBackButton_NearAtm.Click += goBackButton_nearAtm_Click;
            // 
            // nearAtmInfoLabel
            // 
            nearAtmInfoLabel.Font = new Font("Segoe UI", 14F);
            nearAtmInfoLabel.Location = new Point(140, 180);
            nearAtmInfoLabel.Name = "nearAtmInfoLabel";
            nearAtmInfoLabel.Size = new Size(500, 400);
            nearAtmInfoLabel.TabIndex = 1;
            nearAtmInfoLabel.Tag = "infoLabel";
            // 
            // nearAtmLabel
            // 
            nearAtmLabel.Font = new Font("Segoe UI", 20F);
            nearAtmLabel.Location = new Point(238, 90);
            nearAtmLabel.Name = "nearAtmLabel";
            nearAtmLabel.Size = new Size(304, 58);
            nearAtmLabel.TabIndex = 0;
            nearAtmLabel.Tag = "statusLabel";
            nearAtmLabel.Text = "Near ATM's";
            nearAtmLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // historyPanel
            // 
            historyPanel.Controls.Add(goBackButton_History);
            historyPanel.Controls.Add(historyInfoLabel);
            historyPanel.Controls.Add(historyLabel);
            historyPanel.Location = new Point(0, 0);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(780, 600);
            historyPanel.TabIndex = 21;
            historyPanel.Visible = false;
            // 
            // goBackButton_History
            // 
            goBackButton_History.Font = new Font("Segoe UI", 17F);
            goBackButton_History.Location = new Point(23, 23);
            goBackButton_History.Name = "goBackButton_History";
            goBackButton_History.Size = new Size(55, 55);
            goBackButton_History.TabIndex = 25;
            goBackButton_History.Text = "X";
            goBackButton_History.UseVisualStyleBackColor = true;
            goBackButton_History.Click += goBackButton_History_Click;
            // 
            // historyInfoLabel
            // 
            historyInfoLabel.Font = new Font("Segoe UI", 14F);
            historyInfoLabel.Location = new Point(140, 180);
            historyInfoLabel.Name = "historyInfoLabel";
            historyInfoLabel.Size = new Size(500, 400);
            historyInfoLabel.TabIndex = 26;
            historyInfoLabel.Tag = "infoLabel";
            // 
            // historyLabel
            // 
            historyLabel.Font = new Font("Segoe UI", 20F);
            historyLabel.Location = new Point(238, 90);
            historyLabel.Name = "historyLabel";
            historyLabel.Size = new Size(304, 58);
            historyLabel.TabIndex = 25;
            historyLabel.Tag = "statusLabel";
            historyLabel.Text = "Operation History";
            historyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ATMForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 599);
            Controls.Add(keyBoardPanel);
            Controls.Add(nearAtmsPanel);
            Controls.Add(historyPanel);
            Controls.Add(sendToCardPanel);
            Controls.Add(withdrawPanel);
            Controls.Add(depositPanel);
            Controls.Add(balancePanel);
            Controls.Add(mainMenuPanel);
            Controls.Add(loginPanel);
            Name = "ATMForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATM";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            depositPanel.ResumeLayout(false);
            depositPanel.PerformLayout();
            withdrawPanel.ResumeLayout(false);
            withdrawPanel.PerformLayout();
            keyBoardPanel.ResumeLayout(false);
            balancePanel.ResumeLayout(false);
            mainMenuPanel.ResumeLayout(false);
            sendToCardPanel.ResumeLayout(false);
            sendToCardPanel.PerformLayout();
            nearAtmsPanel.ResumeLayout(false);
            historyPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label infoLabel;
        private Label textLabel;
        private TextBox inputTextBox;
        private Button buttonDigit1;
        private Button buttonDigit2;
        private Button buttonDigit3;
        private Button buttonDigit4;
        private Button buttonDigit5;
        private Button buttonDigit6;
        private Button buttonDigit7;
        private Button buttonDigit8;
        private Button buttonDigit9;
        private Button buttonDigit0;
        private Button buttonBackspace;
        private Button buttonEnter;
        private Panel loginPanel;
        private Panel mainMenuPanel;
        private Panel balancePanel;
        private Panel withdrawPanel;
        private Panel depositPanel;
        private Panel nearAtmsPanel;
        private Panel historyPanel;
        private Panel sendToCardPanel;
        private Panel keyBoardPanel;
        private TextBox withdrawTextBox;
        private TextBox depositTextBox;
        private TextBox sendToCardTextBox;
        private Label nearAtmLabel;
        private Label nearAtmInfoLabel;
        private Button goBackButton_NearAtm;
        private Label mainMenuLabel;
        private Label sendToCardLabel;
        private Button goBackButton_SendToCard;
        private Button goBackButton_History;
        private Label historyInfoLabel;
        private Label historyLabel;
        private Button goBackButton_Deposit;
        private Label depositLabel;
        private Button goBackButton_Withdraw;
        private Label withdrawLabel;
        private Button goBackButton_Balance;
        private Button goBackButton_MainMenu;
        private Label balanceLabel;
        private Button showBalancePageButton;
        private Button showNearAtmPageButton;
        private Button showHistoryPageButton;
        private Button sendToCardButton;
        private Button withdrawButton;
        private Button depositButton;
        private Label sendToCardInfoLabel;
    }
}
