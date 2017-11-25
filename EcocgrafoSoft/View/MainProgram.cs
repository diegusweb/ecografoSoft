using EcocgrafoSoft.Enums;
using EcocgrafoSoft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcocgrafoSoft.View
{
    public partial class MainProgram : Form
    {

        /// <summary>
        /// Variable to store error message
        /// </summary>
        private string errorMessage;

        /// <summary>
        /// Member id
        /// </summary>
        private int memberId;

        public MainProgram()
        {
            InitializeComponent();
            this.InitializeResourceString();
            this.InitializeDropDownList();
            //sthis.InitilizeDataGridViewStyle();

        }

        /// <summary>
        /// Initializes resource strings
        /// </summary>
        private void InitializeResourceString()
        {
            // Registeration
            lblName.Text = Resources.Registration_Name_Label_Text;
            lblDateOfBirth.Text = Resources.Registration_DateOfBirth_Label_Text;
            lblOccupation.Text = Resources.Registration_Occupation_Label_Text;
            //lblMaritalStatus.Text = Resources.Registration_MaritalStatus_Label_Text;
            //lblHealthStatus.Text = Resources.Registration_HealthStatus_Label_Text;
            lblSalary.Text = Resources.Registration_Salary_Label_Text;
            lblNoOfChildren.Text = Resources.Registration_Children_Label_Text;
            btnRegister.Text = Resources.Registration_Register_Button_Text;

            // Search, Print, Export, Update, Delete
            btnSearch.Text = Resources.Search_Search_Button_Text;
            btnRefresh.Text = Resources.Search_Refresh_Button_Text;
            btnPrintPreview.Text = Resources.Print_PrintPreview_Button_Text;
            btnPrint.Text = Resources.Print_Print_Button_Text;
            btnExport.Text = Resources.Export_Button_Text;
            btnUpdate.Text = Resources.Update_Button_Text;
            btnDelete.Text = Resources.Delete_Button_Text;
        }

        /// <summary>
        /// Initializes all dropdown controls
        /// </summary>
        private void InitializeDropDownList()
        {
            cmbOccupation.DataSource = Enum.GetValues(typeof(Occupation));
            //cmbMaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));
            //cmbHealthStatus.DataSource = Enum.GetValues(typeof(HealthStatus));

            cmbSearchOccupation.DataSource = Enum.GetValues(typeof(Occupation));
            cmbSearchMaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));
            cmbOperand.SelectedIndex = 0;
        }

        /// <summary>
        /// Resets search criteria
        /// </summary>
        private void ResetSearch()
        {
            cmbSearchMaritalStatus.SelectedIndex = -1;
            cmbSearchOccupation.SelectedIndex = -1;
            cmbOperand.SelectedIndex = 0;
        }

        /// <summary>
        /// Resets the registration screen
        /// </summary>
        private void ResetRegistration()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNoPhone.Text = string.Empty;
            cmbOccupation.SelectedIndex = -1;
            //cmbHealthStatus.SelectedIndex = -1;
            //cmbMaritalStatus.SelectedIndex = -1;
        }

        /// <summary>
        /// Validates registration input
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidateRegistration()
        {
            this.errorMessage = string.Empty;

            if (txtName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Name_Required_Text);
            }

            if (txtFirstName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_FirstName_Required_Text);
            }

            if (txtLastName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_LastName_Required_Text);
            }

            if (dtDateOfBirth.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_DateOfBirth_Required_Text);
            }

            if (cmbOccupation.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_Occupation_Select_Text);
            }


            return this.errorMessage != string.Empty ? false : true;
        }

        /// <summary>
        /// To generate the error message
        /// </summary>
        /// <param name="error">error message</param>
        private void AddErrorMessage(string error)
        {
            if (this.errorMessage == string.Empty)
            {
                this.errorMessage = Resources.Error_Message_Header + "\n\n";
            }


            this.errorMessage += error + "\n";
        }

        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                //Resources.System_Error_Message, 
                Resources.System_Error_Message_Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRegistration())
                {

                }
                else {
                    // Display the validation failed message
                    MessageBox.Show(
                        this.errorMessage,
                        Resources.Registration_Error_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                this.ShowErrorMessage(ex);
            }
        }

    }
}
