using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLenderLibrary;

namespace DVDLenderUI
{
    public partial class MainForm : Form
    {
        private Inventory Inventory = new Inventory();
        private Person Members = new Person();

        private List<Inventory> inventory = new List<Inventory>();
        private List<Person> member = new List<Person>();
        private List<CheckedOut> checkedOutList = new List<CheckedOut>();

        BindingSource inventoryBinding = new BindingSource();
        BindingSource memberBinding = new BindingSource();
        BindingSource lendingInventory = new BindingSource();
        BindingSource lendingMember = new BindingSource();
        BindingSource checkedOutItem = new BindingSource();
             
        public MainForm()
        {
            InitializeComponent();
            SetupData();
            SetupMembers();

            inventoryBinding.DataSource = inventory;
            InventoryListBox.DataSource = inventoryBinding;

            InventoryListBox.DisplayMember = "DisplayInventory";
            InventoryListBox.ValueMember = "DisplayInventory";

            memberBinding.DataSource = member;
            MemberListBox.DataSource = memberBinding;

            MemberListBox.DisplayMember = "DisplayMember";
            MemberListBox.ValueMember = "DisplayMember";

            lendingInventory.DataSource = inventory;
            LendingInventoryListBox.DataSource = inventoryBinding;

            LendingInventoryListBox.DisplayMember = "DisplayInventory";
            LendingInventoryListBox.ValueMember = "DisplayInventory";

            lendingMember.DataSource = member;
            LendingMemberListBox.DataSource = lendingMember;

            LendingMemberListBox.DisplayMember = "DisplayMember";
            LendingMemberListBox.ValueMember = "DisplayMember";

            checkedOutItem.DataSource = checkedOutList;
            LendingCheckedOutList.DataSource = checkedOutItem;

            LendingCheckedOutList.DisplayMember = "DisplayCheckedOut";
            LendingCheckedOutList.ValueMember = "DisplayCheckedOut";

        }
        private void SetupData()
        {
            Inventory demoData = new Inventory();
            demoData.dvdTitle = "Transformers";
            demoData.dvdYear = "2007";
            demoData.dvdActorsActresses = "Shia Labeouf";
            inventory.Add(demoData);

            demoData = new Inventory();
            demoData.dvdTitle = "Elysium";
            demoData.dvdYear = "2012";
            demoData.dvdActorsActresses = "Matt Damon";
            inventory.Add(demoData);

            demoData = new Inventory();
            demoData.dvdTitle = "Wild Wild West";
            demoData.dvdYear = "1998";
            demoData.dvdActorsActresses = "Will Smith";
            inventory.Add(demoData);
        }

        private void SetupMembers()
        {
            Person demoData = new Person();
            demoData.FirstName = "John";
            demoData.LastName = "Smith";
            demoData.Email = "johnsmith@hotmail.com";
            demoData.PhoneNumber = "570-790-5098";
            member.Add(demoData);

            demoData = new Person();
            demoData.FirstName = "Bob";
            demoData.LastName = "LaRock";
            demoData.Email = "boblarock@hotmail.com";
            demoData.PhoneNumber = "570-791-5099";
            member.Add(demoData);
        }

        private void InventoryAddItemButton_Click(object sender, EventArgs e)
        {
            Inventory getItemData = new Inventory();

            if (InventoryTitleBox.Text != "" && InventoryYearBox.Text !="" && InventoryActorsActressesBox.Text != "")
            {
                getItemData.dvdTitle = InventoryTitleBox.Text;
                getItemData.dvdYear = InventoryYearBox.Text;
                getItemData.dvdActorsActresses = InventoryActorsActressesBox.Text;

                inventory.Add(getItemData);

                InventoryTitleBox.Text = "";
                InventoryYearBox.Text = "";
                InventoryActorsActressesBox.Text = "";

                InventoryListBox.DisplayMember = "";
                InventoryListBox.DisplayMember = "DisplayInventory";
            }
            else
            {
                MessageBox.Show("Data must be entered before saving new item.");
            }
            
        }

        private void MembersAddMemberButton_Click(object sender, EventArgs e)
        {
            Person getMemberData = new Person();

            if (MembersFirstNameBox.Text != "" && MembersLastNameBox.Text !="" && MembersEmailBox.Text!="" && MembersPhoneBox.Text != "")
            {
                getMemberData.FirstName = MembersFirstNameBox.Text;
                getMemberData.LastName = MembersLastNameBox.Text;
                getMemberData.Email = MembersEmailBox.Text;
                getMemberData.PhoneNumber = MembersPhoneBox.Text;

                member.Add(getMemberData);

                MembersFirstNameBox.Text="";
                MembersLastNameBox.Text="";
                MembersEmailBox.Text="";
                MembersPhoneBox.Text="";

                MemberListBox.DisplayMember = "";
                MemberListBox.DisplayMember = "DisplayMember";
            }
            else
            {
                MessageBox.Show("Data must be entered before saving new member.");
            }
        }

        private void MainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            InventoryListBox.DisplayMember = "";
            InventoryListBox.DisplayMember = "DisplayInventory";

            MemberListBox.DisplayMember = "";
            MemberListBox.DisplayMember = "DisplayMember";
        }
    }
}
