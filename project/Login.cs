using Microsoft.AspNetCore.Components;
using DataLibrary;
using crm_project.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace crm_project
{
    public class Login : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IDataAccess DataAccess { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }

        public async Task HandleLogin()
        {
            string connectionString = "Server=aws.connect.psdb.cloud;Port=3306;database=crm_project;user id=qu0lguxywbktqv9j59do;password=pscale_pw_rbCmLY90Os2QmO9sCMTJVM02QBM8p9Ub6YLovox3k3W";

            bool isValidCredentials = await DataAccess.VerifyUserCredentials(Username, Password, connectionString);

            if (isValidCredentials)
            {
                // Successful login
                // Navigate to the desired page
                NavigationManager.NavigateTo("/customers");
            }
            else
            {
                // Invalid login credentials
                ErrorMessage = "Invalid username or password.";
            }
        }
    }
 }

