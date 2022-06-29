using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public partial class EmployeeOverview
    {
        [Inject]
        private IEmployeeDataService _employeeDataService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await _employeeDataService.GetAllEmployees();
        }
    }
}
