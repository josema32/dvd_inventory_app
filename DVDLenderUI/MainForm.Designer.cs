namespace DVDLenderUI
{
    partial class MainForm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPageOne = new System.Windows.Forms.TabPage();
            this.MainTabPageTwo = new System.Windows.Forms.TabPage();
            this.MainTabPageThree = new System.Windows.Forms.TabPage();
            this.MainTabPageFour = new System.Windows.Forms.TabPage();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.InventoryTitleLabel = new System.Windows.Forms.Label();
            this.InventoryYearLabel = new System.Windows.Forms.Label();
            this.InventoryActorsActressesLabel = new System.Windows.Forms.Label();
            this.InventoryTitleBox = new System.Windows.Forms.TextBox();
            this.InventoryYearBox = new System.Windows.Forms.TextBox();
            this.InventoryActorsActressesBox = new System.Windows.Forms.TextBox();
            this.InventoryAddItemButton = new System.Windows.Forms.Button();
            this.MembersEmailBox = new System.Windows.Forms.TextBox();
            this.MembersLastNameBox = new System.Windows.Forms.TextBox();
            this.MembersFirstNameBox = new System.Windows.Forms.TextBox();
            this.MembersEmailLabel = new System.Windows.Forms.Label();
            this.MemebersLastNameLabel = new System.Windows.Forms.Label();
            this.MembersFirstNameLabel = new System.Windows.Forms.Label();
            this.MemberListBox = new System.Windows.Forms.ListBox();
            this.MembersPhoneBox = new System.Windows.Forms.TextBox();
            this.MembersPhoneLabel = new System.Windows.Forms.Label();
            this.MembersAddMemberButton = new System.Windows.Forms.Button();
            this.CurrentInventoryLabel = new System.Windows.Forms.Label();
            this.CurrentMembersLabel = new System.Windows.Forms.Label();
            this.LendingInventoryListBox = new System.Windows.Forms.ListBox();
            this.LendingMemberListBox = new System.Windows.Forms.ListBox();
            this.LendingCheckedOutList = new System.Windows.Forms.ListBox();
            this.LendButton = new System.Windows.Forms.Button();
            this.SelectItemLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckedOutItemsLabel = new System.Windows.Forms.Label();
            this.ReturnsCheckedOutList = new System.Windows.Forms.ListBox();
            this.ReturnsCurrentInventory = new System.Windows.Forms.ListBox();
            this.ReceiveButton = new System.Windows.Forms.Button();
            this.CheckedOutInventoryLabel = new System.Windows.Forms.Label();
            this.ReturnsInventoryLabel = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.MainTabPageOne.SuspendLayout();
            this.MainTabPageTwo.SuspendLayout();
            this.MainTabPageThree.SuspendLayout();
            this.MainTabPageFour.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainTabPageOne);
            this.MainTabControl.Controls.Add(this.MainTabPageTwo);
            this.MainTabControl.Controls.Add(this.MainTabPageThree);
            this.MainTabControl.Controls.Add(this.MainTabPageFour);
            this.MainTabControl.Location = new System.Drawing.Point(24, 29);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(539, 428);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.MainTabControl_Selected);
            // 
            // MainTabPageOne
            // 
            this.MainTabPageOne.Controls.Add(this.CurrentInventoryLabel);
            this.MainTabPageOne.Controls.Add(this.InventoryAddItemButton);
            this.MainTabPageOne.Controls.Add(this.InventoryActorsActressesBox);
            this.MainTabPageOne.Controls.Add(this.InventoryYearBox);
            this.MainTabPageOne.Controls.Add(this.InventoryTitleBox);
            this.MainTabPageOne.Controls.Add(this.InventoryActorsActressesLabel);
            this.MainTabPageOne.Controls.Add(this.InventoryYearLabel);
            this.MainTabPageOne.Controls.Add(this.InventoryTitleLabel);
            this.MainTabPageOne.Controls.Add(this.InventoryListBox);
            this.MainTabPageOne.Location = new System.Drawing.Point(4, 22);
            this.MainTabPageOne.Name = "MainTabPageOne";
            this.MainTabPageOne.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPageOne.Size = new System.Drawing.Size(531, 402);
            this.MainTabPageOne.TabIndex = 0;
            this.MainTabPageOne.Text = "Inventory";
            this.MainTabPageOne.UseVisualStyleBackColor = true;
            // 
            // MainTabPageTwo
            // 
            this.MainTabPageTwo.Controls.Add(this.CurrentMembersLabel);
            this.MainTabPageTwo.Controls.Add(this.MembersAddMemberButton);
            this.MainTabPageTwo.Controls.Add(this.MembersPhoneBox);
            this.MainTabPageTwo.Controls.Add(this.MembersPhoneLabel);
            this.MainTabPageTwo.Controls.Add(this.MembersEmailBox);
            this.MainTabPageTwo.Controls.Add(this.MembersLastNameBox);
            this.MainTabPageTwo.Controls.Add(this.MembersFirstNameBox);
            this.MainTabPageTwo.Controls.Add(this.MembersEmailLabel);
            this.MainTabPageTwo.Controls.Add(this.MemebersLastNameLabel);
            this.MainTabPageTwo.Controls.Add(this.MembersFirstNameLabel);
            this.MainTabPageTwo.Controls.Add(this.MemberListBox);
            this.MainTabPageTwo.Location = new System.Drawing.Point(4, 22);
            this.MainTabPageTwo.Name = "MainTabPageTwo";
            this.MainTabPageTwo.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPageTwo.Size = new System.Drawing.Size(531, 402);
            this.MainTabPageTwo.TabIndex = 1;
            this.MainTabPageTwo.Text = "Members";
            this.MainTabPageTwo.UseVisualStyleBackColor = true;
            // 
            // MainTabPageThree
            // 
            this.MainTabPageThree.Controls.Add(this.CheckedOutItemsLabel);
            this.MainTabPageThree.Controls.Add(this.label1);
            this.MainTabPageThree.Controls.Add(this.SelectItemLabel);
            this.MainTabPageThree.Controls.Add(this.LendButton);
            this.MainTabPageThree.Controls.Add(this.LendingCheckedOutList);
            this.MainTabPageThree.Controls.Add(this.LendingMemberListBox);
            this.MainTabPageThree.Controls.Add(this.LendingInventoryListBox);
            this.MainTabPageThree.Location = new System.Drawing.Point(4, 22);
            this.MainTabPageThree.Name = "MainTabPageThree";
            this.MainTabPageThree.Size = new System.Drawing.Size(531, 402);
            this.MainTabPageThree.TabIndex = 2;
            this.MainTabPageThree.Text = "Lending";
            this.MainTabPageThree.UseVisualStyleBackColor = true;
            // 
            // MainTabPageFour
            // 
            this.MainTabPageFour.Controls.Add(this.ReturnsInventoryLabel);
            this.MainTabPageFour.Controls.Add(this.CheckedOutInventoryLabel);
            this.MainTabPageFour.Controls.Add(this.ReceiveButton);
            this.MainTabPageFour.Controls.Add(this.ReturnsCurrentInventory);
            this.MainTabPageFour.Controls.Add(this.ReturnsCheckedOutList);
            this.MainTabPageFour.Location = new System.Drawing.Point(4, 22);
            this.MainTabPageFour.Name = "MainTabPageFour";
            this.MainTabPageFour.Size = new System.Drawing.Size(531, 402);
            this.MainTabPageFour.TabIndex = 3;
            this.MainTabPageFour.Text = "Returns";
            this.MainTabPageFour.UseVisualStyleBackColor = true;
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.Location = new System.Drawing.Point(30, 183);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(469, 186);
            this.InventoryListBox.TabIndex = 0;
            // 
            // InventoryTitleLabel
            // 
            this.InventoryTitleLabel.AutoSize = true;
            this.InventoryTitleLabel.Location = new System.Drawing.Point(92, 42);
            this.InventoryTitleLabel.Name = "InventoryTitleLabel";
            this.InventoryTitleLabel.Size = new System.Drawing.Size(33, 13);
            this.InventoryTitleLabel.TabIndex = 1;
            this.InventoryTitleLabel.Text = "Title :";
            // 
            // InventoryYearLabel
            // 
            this.InventoryYearLabel.AutoSize = true;
            this.InventoryYearLabel.Location = new System.Drawing.Point(92, 77);
            this.InventoryYearLabel.Name = "InventoryYearLabel";
            this.InventoryYearLabel.Size = new System.Drawing.Size(32, 13);
            this.InventoryYearLabel.TabIndex = 2;
            this.InventoryYearLabel.Text = "Year:";
            // 
            // InventoryActorsActressesLabel
            // 
            this.InventoryActorsActressesLabel.AutoSize = true;
            this.InventoryActorsActressesLabel.Location = new System.Drawing.Point(92, 109);
            this.InventoryActorsActressesLabel.Name = "InventoryActorsActressesLabel";
            this.InventoryActorsActressesLabel.Size = new System.Drawing.Size(91, 13);
            this.InventoryActorsActressesLabel.TabIndex = 3;
            this.InventoryActorsActressesLabel.Text = "Actors/Actresses:";
            // 
            // InventoryTitleBox
            // 
            this.InventoryTitleBox.Location = new System.Drawing.Point(192, 35);
            this.InventoryTitleBox.Name = "InventoryTitleBox";
            this.InventoryTitleBox.Size = new System.Drawing.Size(227, 20);
            this.InventoryTitleBox.TabIndex = 4;
            // 
            // InventoryYearBox
            // 
            this.InventoryYearBox.Location = new System.Drawing.Point(192, 70);
            this.InventoryYearBox.Name = "InventoryYearBox";
            this.InventoryYearBox.Size = new System.Drawing.Size(227, 20);
            this.InventoryYearBox.TabIndex = 5;
            // 
            // InventoryActorsActressesBox
            // 
            this.InventoryActorsActressesBox.Location = new System.Drawing.Point(192, 102);
            this.InventoryActorsActressesBox.Name = "InventoryActorsActressesBox";
            this.InventoryActorsActressesBox.Size = new System.Drawing.Size(227, 20);
            this.InventoryActorsActressesBox.TabIndex = 6;
            // 
            // InventoryAddItemButton
            // 
            this.InventoryAddItemButton.Location = new System.Drawing.Point(314, 137);
            this.InventoryAddItemButton.Name = "InventoryAddItemButton";
            this.InventoryAddItemButton.Size = new System.Drawing.Size(105, 23);
            this.InventoryAddItemButton.TabIndex = 7;
            this.InventoryAddItemButton.Text = "Add Item";
            this.InventoryAddItemButton.UseVisualStyleBackColor = true;
            this.InventoryAddItemButton.Click += new System.EventHandler(this.InventoryAddItemButton_Click);
            // 
            // MembersEmailBox
            // 
            this.MembersEmailBox.Location = new System.Drawing.Point(193, 101);
            this.MembersEmailBox.Name = "MembersEmailBox";
            this.MembersEmailBox.Size = new System.Drawing.Size(227, 20);
            this.MembersEmailBox.TabIndex = 13;
            // 
            // MembersLastNameBox
            // 
            this.MembersLastNameBox.Location = new System.Drawing.Point(193, 69);
            this.MembersLastNameBox.Name = "MembersLastNameBox";
            this.MembersLastNameBox.Size = new System.Drawing.Size(227, 20);
            this.MembersLastNameBox.TabIndex = 12;
            // 
            // MembersFirstNameBox
            // 
            this.MembersFirstNameBox.Location = new System.Drawing.Point(193, 34);
            this.MembersFirstNameBox.Name = "MembersFirstNameBox";
            this.MembersFirstNameBox.Size = new System.Drawing.Size(227, 20);
            this.MembersFirstNameBox.TabIndex = 11;
            // 
            // MembersEmailLabel
            // 
            this.MembersEmailLabel.AutoSize = true;
            this.MembersEmailLabel.Location = new System.Drawing.Point(93, 108);
            this.MembersEmailLabel.Name = "MembersEmailLabel";
            this.MembersEmailLabel.Size = new System.Drawing.Size(38, 13);
            this.MembersEmailLabel.TabIndex = 10;
            this.MembersEmailLabel.Text = "Email :";
            // 
            // MemebersLastNameLabel
            // 
            this.MemebersLastNameLabel.AutoSize = true;
            this.MemebersLastNameLabel.Location = new System.Drawing.Point(93, 76);
            this.MemebersLastNameLabel.Name = "MemebersLastNameLabel";
            this.MemebersLastNameLabel.Size = new System.Drawing.Size(64, 13);
            this.MemebersLastNameLabel.TabIndex = 9;
            this.MemebersLastNameLabel.Text = "Last Name :";
            // 
            // MembersFirstNameLabel
            // 
            this.MembersFirstNameLabel.AutoSize = true;
            this.MembersFirstNameLabel.Location = new System.Drawing.Point(93, 41);
            this.MembersFirstNameLabel.Name = "MembersFirstNameLabel";
            this.MembersFirstNameLabel.Size = new System.Drawing.Size(63, 13);
            this.MembersFirstNameLabel.TabIndex = 8;
            this.MembersFirstNameLabel.Text = "First Name :";
            // 
            // MemberListBox
            // 
            this.MemberListBox.FormattingEnabled = true;
            this.MemberListBox.Location = new System.Drawing.Point(31, 208);
            this.MemberListBox.Name = "MemberListBox";
            this.MemberListBox.Size = new System.Drawing.Size(469, 160);
            this.MemberListBox.TabIndex = 7;
            // 
            // MembersPhoneBox
            // 
            this.MembersPhoneBox.Location = new System.Drawing.Point(193, 135);
            this.MembersPhoneBox.Name = "MembersPhoneBox";
            this.MembersPhoneBox.Size = new System.Drawing.Size(227, 20);
            this.MembersPhoneBox.TabIndex = 15;
            // 
            // MembersPhoneLabel
            // 
            this.MembersPhoneLabel.AutoSize = true;
            this.MembersPhoneLabel.Location = new System.Drawing.Point(93, 139);
            this.MembersPhoneLabel.Name = "MembersPhoneLabel";
            this.MembersPhoneLabel.Size = new System.Drawing.Size(81, 13);
            this.MembersPhoneLabel.TabIndex = 14;
            this.MembersPhoneLabel.Text = "Phone Number:";
            // 
            // MembersAddMemberButton
            // 
            this.MembersAddMemberButton.Location = new System.Drawing.Point(315, 163);
            this.MembersAddMemberButton.Name = "MembersAddMemberButton";
            this.MembersAddMemberButton.Size = new System.Drawing.Size(105, 23);
            this.MembersAddMemberButton.TabIndex = 16;
            this.MembersAddMemberButton.Text = "Add Member";
            this.MembersAddMemberButton.UseVisualStyleBackColor = true;
            this.MembersAddMemberButton.Click += new System.EventHandler(this.MembersAddMemberButton_Click);
            // 
            // CurrentInventoryLabel
            // 
            this.CurrentInventoryLabel.AutoSize = true;
            this.CurrentInventoryLabel.Location = new System.Drawing.Point(33, 166);
            this.CurrentInventoryLabel.Name = "CurrentInventoryLabel";
            this.CurrentInventoryLabel.Size = new System.Drawing.Size(87, 13);
            this.CurrentInventoryLabel.TabIndex = 8;
            this.CurrentInventoryLabel.Text = "Current inventory";
            // 
            // CurrentMembersLabel
            // 
            this.CurrentMembersLabel.AutoSize = true;
            this.CurrentMembersLabel.Location = new System.Drawing.Point(34, 192);
            this.CurrentMembersLabel.Name = "CurrentMembersLabel";
            this.CurrentMembersLabel.Size = new System.Drawing.Size(86, 13);
            this.CurrentMembersLabel.TabIndex = 17;
            this.CurrentMembersLabel.Text = "Current members";
            // 
            // LendingInventoryListBox
            // 
            this.LendingInventoryListBox.FormattingEnabled = true;
            this.LendingInventoryListBox.Location = new System.Drawing.Point(30, 30);
            this.LendingInventoryListBox.Name = "LendingInventoryListBox";
            this.LendingInventoryListBox.Size = new System.Drawing.Size(469, 95);
            this.LendingInventoryListBox.TabIndex = 8;
            // 
            // LendingMemberListBox
            // 
            this.LendingMemberListBox.FormattingEnabled = true;
            this.LendingMemberListBox.Location = new System.Drawing.Point(30, 144);
            this.LendingMemberListBox.Name = "LendingMemberListBox";
            this.LendingMemberListBox.Size = new System.Drawing.Size(469, 95);
            this.LendingMemberListBox.TabIndex = 9;
            // 
            // LendingCheckedOutList
            // 
            this.LendingCheckedOutList.FormattingEnabled = true;
            this.LendingCheckedOutList.Location = new System.Drawing.Point(30, 277);
            this.LendingCheckedOutList.Name = "LendingCheckedOutList";
            this.LendingCheckedOutList.Size = new System.Drawing.Size(469, 95);
            this.LendingCheckedOutList.TabIndex = 10;
            // 
            // LendButton
            // 
            this.LendButton.Location = new System.Drawing.Point(394, 246);
            this.LendButton.Name = "LendButton";
            this.LendButton.Size = new System.Drawing.Size(105, 23);
            this.LendButton.TabIndex = 17;
            this.LendButton.Text = "Lend";
            this.LendButton.UseVisualStyleBackColor = true;
            // 
            // SelectItemLabel
            // 
            this.SelectItemLabel.AutoSize = true;
            this.SelectItemLabel.Location = new System.Drawing.Point(33, 14);
            this.SelectItemLabel.Name = "SelectItemLabel";
            this.SelectItemLabel.Size = new System.Drawing.Size(130, 13);
            this.SelectItemLabel.TabIndex = 18;
            this.SelectItemLabel.Text = "Select an item from the list";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select a member from the list";
            // 
            // CheckedOutItemsLabel
            // 
            this.CheckedOutItemsLabel.AutoSize = true;
            this.CheckedOutItemsLabel.Location = new System.Drawing.Point(33, 261);
            this.CheckedOutItemsLabel.Name = "CheckedOutItemsLabel";
            this.CheckedOutItemsLabel.Size = new System.Drawing.Size(95, 13);
            this.CheckedOutItemsLabel.TabIndex = 20;
            this.CheckedOutItemsLabel.Text = "Checked out items";
            // 
            // ReturnsCheckedOutList
            // 
            this.ReturnsCheckedOutList.FormattingEnabled = true;
            this.ReturnsCheckedOutList.Location = new System.Drawing.Point(30, 34);
            this.ReturnsCheckedOutList.Name = "ReturnsCheckedOutList";
            this.ReturnsCheckedOutList.Size = new System.Drawing.Size(469, 108);
            this.ReturnsCheckedOutList.TabIndex = 9;
            // 
            // ReturnsCurrentInventory
            // 
            this.ReturnsCurrentInventory.FormattingEnabled = true;
            this.ReturnsCurrentInventory.Location = new System.Drawing.Point(30, 190);
            this.ReturnsCurrentInventory.Name = "ReturnsCurrentInventory";
            this.ReturnsCurrentInventory.Size = new System.Drawing.Size(469, 147);
            this.ReturnsCurrentInventory.TabIndex = 10;
            // 
            // ReceiveButton
            // 
            this.ReceiveButton.Location = new System.Drawing.Point(394, 150);
            this.ReceiveButton.Name = "ReceiveButton";
            this.ReceiveButton.Size = new System.Drawing.Size(105, 23);
            this.ReceiveButton.TabIndex = 18;
            this.ReceiveButton.Text = "Receive Item";
            this.ReceiveButton.UseVisualStyleBackColor = true;
            // 
            // CheckedOutInventoryLabel
            // 
            this.CheckedOutInventoryLabel.AutoSize = true;
            this.CheckedOutInventoryLabel.Location = new System.Drawing.Point(32, 18);
            this.CheckedOutInventoryLabel.Name = "CheckedOutInventoryLabel";
            this.CheckedOutInventoryLabel.Size = new System.Drawing.Size(114, 13);
            this.CheckedOutInventoryLabel.TabIndex = 21;
            this.CheckedOutInventoryLabel.Text = "Checked out inventory";
            // 
            // ReturnsInventoryLabel
            // 
            this.ReturnsInventoryLabel.AutoSize = true;
            this.ReturnsInventoryLabel.Location = new System.Drawing.Point(32, 174);
            this.ReturnsInventoryLabel.Name = "ReturnsInventoryLabel";
            this.ReturnsInventoryLabel.Size = new System.Drawing.Size(87, 13);
            this.ReturnsInventoryLabel.TabIndex = 22;
            this.ReturnsInventoryLabel.Text = "Current inventory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 490);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "Personal Lending Library";
            this.MainTabControl.ResumeLayout(false);
            this.MainTabPageOne.ResumeLayout(false);
            this.MainTabPageOne.PerformLayout();
            this.MainTabPageTwo.ResumeLayout(false);
            this.MainTabPageTwo.PerformLayout();
            this.MainTabPageThree.ResumeLayout(false);
            this.MainTabPageThree.PerformLayout();
            this.MainTabPageFour.ResumeLayout(false);
            this.MainTabPageFour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainTabPageOne;
        private System.Windows.Forms.ListBox InventoryListBox;
        private System.Windows.Forms.TabPage MainTabPageTwo;
        private System.Windows.Forms.TabPage MainTabPageThree;
        private System.Windows.Forms.TabPage MainTabPageFour;
        private System.Windows.Forms.Button InventoryAddItemButton;
        private System.Windows.Forms.TextBox InventoryActorsActressesBox;
        private System.Windows.Forms.TextBox InventoryYearBox;
        private System.Windows.Forms.TextBox InventoryTitleBox;
        private System.Windows.Forms.Label InventoryActorsActressesLabel;
        private System.Windows.Forms.Label InventoryYearLabel;
        private System.Windows.Forms.Label InventoryTitleLabel;
        private System.Windows.Forms.Button MembersAddMemberButton;
        private System.Windows.Forms.TextBox MembersPhoneBox;
        private System.Windows.Forms.Label MembersPhoneLabel;
        private System.Windows.Forms.TextBox MembersEmailBox;
        private System.Windows.Forms.TextBox MembersLastNameBox;
        private System.Windows.Forms.TextBox MembersFirstNameBox;
        private System.Windows.Forms.Label MembersEmailLabel;
        private System.Windows.Forms.Label MemebersLastNameLabel;
        private System.Windows.Forms.Label MembersFirstNameLabel;
        private System.Windows.Forms.ListBox MemberListBox;
        private System.Windows.Forms.Label CurrentInventoryLabel;
        private System.Windows.Forms.Label CurrentMembersLabel;
        private System.Windows.Forms.Button LendButton;
        private System.Windows.Forms.ListBox LendingCheckedOutList;
        private System.Windows.Forms.ListBox LendingMemberListBox;
        private System.Windows.Forms.ListBox LendingInventoryListBox;
        private System.Windows.Forms.Label CheckedOutItemsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectItemLabel;
        private System.Windows.Forms.Label ReturnsInventoryLabel;
        private System.Windows.Forms.Label CheckedOutInventoryLabel;
        private System.Windows.Forms.Button ReceiveButton;
        private System.Windows.Forms.ListBox ReturnsCurrentInventory;
        private System.Windows.Forms.ListBox ReturnsCheckedOutList;
    }
}

