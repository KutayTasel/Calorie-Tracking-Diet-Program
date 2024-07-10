using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyet2.PL
{
    public partial class AdminUserCrud : Form
    {
        private readonly UserManager _userManager;
        private UserModel _selectedUser;

        public AdminUserCrud()
        {
            InitializeComponent();

            _userManager = new UserManager();
        }

        private void btnDELETE_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_selectedUser != null)
                {

                    _userManager.Delete(_selectedUser);


                    InitializeDataGridView();


                    ClearForm();

                    ShowInfoMessage("User successfully deleted.");
                }
                else
                {
                    ShowErrorMessage("Please select a user from the list before deleting.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnLISTALL_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Update the DataGridView
                InitializeDataGridView();

                ShowInfoMessage("All users listed successfully.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnSEARCH_Click_1(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = txtSEARCH.Text.Trim();

                if (!string.IsNullOrWhiteSpace(searchKeyword))
                {

                    List<UserModel> searchResults = _userManager.Search(user => user.Email.Contains(searchKeyword));

                    if (searchResults.Count > 0)
                    {

                        dtwUSER.DataSource = searchResults;
                        _selectedUser = null;
                       
                    }
                    else
                    {
                        ShowInfoMessage("No search results found.");
                    }
                }
                else
                {
                    ShowErrorMessage("Please enter a valid search keyword.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void dtwUSER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0 && rowIndex < dtwUSER.Rows.Count)
                {
                    DataGridViewRow selectedRow = dtwUSER.Rows[rowIndex];
                    _selectedUser = selectedRow.DataBoundItem as UserModel;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            try
            {
                dtwUSER.DataSource = _userManager.GetAll();
                dtwUSER.Columns[0].Visible = false;
                dtwUSER.Columns[2].Visible = false;
                dtwUSER.Refresh();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void UpdateSelectedUserModel()
        {
        }

        private void ClearForm()
        {
            txtSEARCH.Text = string.Empty;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show($"Error: {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnADMIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedUser != null && _selectedUser.IsAdmin)
                {

                    _selectedUser.IsAdmin = false;


                    _userManager.Update(_selectedUser);


                    InitializeDataGridView();


                    ClearForm();

                    ShowInfoMessage("Admin privileges removed successfully.");
                }
                else
                {
                    ShowErrorMessage("Please select an admin user from the list before removing admin privileges.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedUser != null)
                {
                    _selectedUser.IsAdmin = true;

                    _userManager.Update(_selectedUser);

                    InitializeDataGridView();

                    ClearForm();

                    ShowInfoMessage("User successfully granted admin privileges.");
                }
                else
                {
                    ShowErrorMessage("Please select a user from the list before making them admin.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
    }
}
