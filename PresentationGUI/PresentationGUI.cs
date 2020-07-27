using System;
using System.Windows.Forms;
using ClubNamespace;
using IntramuralNamespace;
using FratSororityNamespace;

/*  ID
 *      StudentGov Application, Kaleb Ehlert, 3/18/2018
 *  Purpose
 *      The purpose of the program is to implement multiple projects and referrence those different .dlls to create an inheritance
 *      situation that includes both an abstract class and an interface.
 *  Form Controls
 *      lblName: A label to state what the related textfield, txtName, displays.
 *      lblFundedAmt: A label to state what the related textfield, txtFundedAmt, displays .
 *      txtName: Displays the name of the organization.
 *      txtFundedAmt: Displays the funded amount of the organization.
 *      grpBox: A group box that holds the radio buttons that take the user's input and display the associated organization.
 *      radBtnIntr: A radio button that will display the information held by the aTeam object.
 *      radBtnFratSor: A radio button that displays the information held by the aFratSorority object.
 *      radBtnClub: A radio button that displays the information held by the aClub object.
 *  Code & Logic
 *      The input is the three radio buttons the user can click.
 *      The processing takes one of the radio button clicks and finds the associated data to that organization type input.
 *      The output is the name of the organization and funding provided for that organization by student government.
 */

namespace PresentationGUI
{
    public partial class PresentationGUI : Form
    {
        // Object of Club class declared
        private Club aClub;

        // Object of Intramural class declared
        private Intramural aTeam;

        // Object of FratSorority class declared
        private FratSorority aFratSorority;

        // Constructor
        public PresentationGUI()
        {
            InitializeComponent();
        }

        // Object are instantiated when the form is loaded
        // Another GUI could be desined for entering data
        private void PresentationGUI_Load(object sender, EventArgs e)
        {
            aClub = new Club("ACM", "Jones", "Davis 203", "Tues", "12:30");

            aFratSorority = new FratSorority("Delta PI", "Brenda Wynn", true, "86 SmithField");

            aTeam = new Intramural("Winners", "Joe Kitchen", "Volleyball");
        }

        // Three CheckedChanged event-handler methods included
        // Double-clicking on the RadioButton adds the method heading and registers the event
        // Club radio button event-handler method
        private void radBtnClub_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Text = aClub.OrgName;
            aClub.SetFundingAmt();
            txtFundedAmt.Text = aClub.FundedAmt.ToString("C");
            ShowDetails();
        }

        // Fraternity/Sorority radio button event-handler method
        private void radBtnFratSor_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Text = aFratSorority.OrgName;
            aFratSorority.SetFundingAmt();
            txtFundedAmt.Text = aFratSorority.FundedAmt.ToString("C");
            ShowDetails();
        }

        // Intramural radio button event-hnadler method
        private void radBtnIntr_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Text = aTeam.OrgName;
            txtFundedAmt.Text = aTeam.FundedAmt.ToString("C");
            ShowDetails();
        }

        // Area at the bottom of the form initally set to Visible = false usingthe Properties window. Because each RadioButton objects
        //  needed to reset the objects to Visible = true, a mthod is used
        public void ShowDetails()
        {
            txtName.Visible = true;
            lblName.Visible = true;
            txtFundedAmt.Visible = true;
            lblFundedAmt.Visible = true;
        }
    }
}
